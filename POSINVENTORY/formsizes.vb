Imports MySql.Data.MySqlClient

Public Class formsizes
    Dim connString As String = "server=localhost;port=3307;user=root;password=;database=brewtopia_db"
    Public SelectedAddons As New List(Of AddonItem)
    ' Add reference to parent Cashier form
    Private parentCashierForm As Cashier

    ' Create a class to store addon information
    Public Class AddonItem
        Public Property AddonName As String
        Public Property Price As Decimal
        Public Property AddonCode As String
        Public Property ItemCode As String
        Public Property Quantity As Decimal
    End Class
    Private foodCode As String
    Private foodName As String
    Public SelectedSize As String = Nothing
    Public SelectedPrice As Decimal = 0

    Public Sub New(code As String, name As String, cashierForm As Cashier)
        InitializeComponent()
        foodCode = code
        foodName = name
        parentCashierForm = cashierForm
    End Sub

    Private Sub formsizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign the food name to the label
        foodnamelbl.Text = foodName

        ' Load sizes and addons into their respective FlowLayoutPanels
        LoadSizes()
        LoadAddons()
    End Sub

    Private Sub LoadSizes()
        FlowLayoutPanel1.Controls.Clear()
        Try
            dbconn()
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `size_name`, `price` FROM `tbl_food_sizes` WHERE `foodcode` = @foodcode", conn)
            cmd.Parameters.AddWithValue("@foodcode", foodCode)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim sizeName = dr("size_name").ToString()
                Dim price = Decimal.Parse(dr("price").ToString())

                ' Create button for each size
                Dim sizeButton As New Button With {
                    .Text = $"{sizeName} - PHP {price:N2}",
                    .Width = 200,
                    .Height = 50,
                    .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                    .BackColor = Color.FromArgb(70, 70, 70),
                    .ForeColor = Color.White,
                    .Tag = New With {.SizeName = sizeName, .Price = price},
                    .FlatStyle = FlatStyle.Flat
                }

                ' Customize FlatAppearance properties
                sizeButton.FlatAppearance.BorderSize = 0 ' Removes border
                sizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90) ' Change color on hover
                sizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50) ' Change color on click

                ' Add hover effects
                AddHandler sizeButton.MouseEnter, Sub(sender, e)
                                                      sizeButton.BackColor = Color.FromArgb(90, 90, 90)
                                                  End Sub

                AddHandler sizeButton.MouseLeave, Sub(sender, e)
                                                      sizeButton.BackColor = Color.FromArgb(70, 70, 70)
                                                  End Sub

                AddHandler sizeButton.Click, AddressOf SizeButton_Click
                FlowLayoutPanel1.Controls.Add(sizeButton)
            End While

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()
    End Sub
    Private Sub LoadAddons()
        FlowLayoutPanel2.Controls.Clear()
        Dim addonsList As New List(Of (name As String, price As Decimal, addonCode As String,
                              itemCode As String, requiredQty As Decimal, availableQty As Decimal))

        Try
            dbconn()
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Get current cart addon usage
            Dim cartAddonUsage As Dictionary(Of String, Decimal) = GetCartAddonUsage()

            ' First, get all the addon data
            cmd = New MySqlCommand(
        "SELECT a.name, a.price, a.addoncode, s.itemcode, s.quantity as required_qty, " &
        "LEAST(i.quantity, ia.quantity) as available_qty " &
        "FROM tbl_addons a " &
        "INNER JOIN tbl_addon_supplies s ON a.addoncode = s.addoncode " &
        "INNER JOIN tbl_inventory i ON s.itemcode = i.itemcode " &
        "INNER JOIN tbl_inventoryad ia ON s.itemcode = ia.itemcode", conn)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    addonsList.Add((
                reader("name").ToString(),
                Decimal.Parse(reader("price").ToString()),
                reader("addoncode").ToString(),
                reader("itemcode").ToString(),
                Decimal.Parse(reader("required_qty").ToString()),
                Decimal.Parse(reader("available_qty").ToString())
            ))
                End While
            End Using

            ' Now create controls for each addon
            For Each addon In addonsList
                Dim addonCheckBox As New CheckBox With {
            .Text = $"{addon.name} - PHP {addon.price:N2}",
            .AutoSize = True,
            .Tag = New AddonItem With {
                .AddonName = addon.name,
                .Price = addon.price,
                .AddonCode = addon.addonCode,
                .ItemCode = addon.itemCode,
                .Quantity = addon.requiredQty
            }
        }

                ' Calculate remaining inventory after considering cart usage
                Dim remainingQty As Decimal = addon.availableQty
                If cartAddonUsage.ContainsKey(addon.itemCode) Then
                    remainingQty -= cartAddonUsage(addon.itemCode)
                End If

                ' Check if there's enough inventory considering cart usage
                Dim isAvailable = (remainingQty >= addon.requiredQty)
                addonCheckBox.Enabled = isAvailable
                addonCheckBox.ForeColor = If(isAvailable, Color.Black, Color.Gray)

                ' Add tooltip to show remaining quantity
                Dim tooltip As New ToolTip()
                tooltip.SetToolTip(addonCheckBox, $"Available: {remainingQty}")

                ' Add event handler for checkbox state change
                AddHandler addonCheckBox.CheckedChanged, AddressOf AddonCheckBox_CheckedChanged

                FlowLayoutPanel2.Controls.Add(addonCheckBox)
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function GetCartAddonUsage() As Dictionary(Of String, Decimal)
        Dim addonUsage As New Dictionary(Of String, Decimal)

        ' Go through each row in the cart
        For Each row As DataGridViewRow In parentCashierForm.a.Rows
            Dim foodName As String = row.Cells(2).Value.ToString()
            Dim quantity As Integer = CInt(row.Cells(5).Value)

            ' Check if the item has addons
            If foodName.Contains(" with ") Then
                Dim addons = foodName.Split(New String() {" with "}, StringSplitOptions.None)(1).Split(",")
                For Each addon In addons
                    Dim trimmedAddon = addon.Trim()
                    If Not String.IsNullOrEmpty(trimmedAddon) Then
                        ' Get addon details from database
                        Using conn As New MySqlConnection(connString)
                            conn.Open()
                            Dim cmd As New MySqlCommand(
                            "SELECT s.itemcode, s.quantity " &
                            "FROM tbl_addons a " &
                            "INNER JOIN tbl_addon_supplies s ON a.addoncode = s.addoncode " &
                            "WHERE a.name = @name", conn)
                            cmd.Parameters.AddWithValue("@name", trimmedAddon)

                            Using reader As MySqlDataReader = cmd.ExecuteReader()
                                If reader.Read() Then
                                    Dim itemCode As String = reader("itemcode").ToString()
                                    Dim addonQty As Decimal = CDec(reader("quantity")) * quantity

                                    If addonUsage.ContainsKey(itemCode) Then
                                        addonUsage(itemCode) += addonQty
                                    Else
                                        addonUsage.Add(itemCode, addonQty)
                                    End If
                                End If
                            End Using
                        End Using
                    End If
                Next
            End If
        Next

        Return addonUsage
    End Function

    Private Sub AddonCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim checkBox As CheckBox = DirectCast(sender, CheckBox)
        Dim addonItem As AddonItem = DirectCast(checkBox.Tag, AddonItem)

        If checkBox.Checked Then
            ' Verify inventory one more time before adding
            If HasSufficientAddonInventory(addonItem.ItemCode, addonItem.Quantity) Then
                ' Add to selected addons if checked
                SelectedAddons.Add(addonItem)
            Else
                ' Uncheck the box if there's not enough inventory
                checkBox.Checked = False
                MessageBox.Show("This addon is no longer available due to insufficient inventory.", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            ' Remove from selected addons if unchecked
            SelectedAddons.RemoveAll(Function(x) x.AddonCode = addonItem.AddonCode)
        End If
    End Sub

    Private Function HasSufficientAddonInventory(itemCode As String, requiredQty As Decimal) As Boolean
        Try
            ' Get current cart addon usage
            Dim cartAddonUsage As Dictionary(Of String, Decimal) = GetCartAddonUsage()

            dbconn()
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Check both inventory tables
            cmd = New MySqlCommand(
            "SELECT LEAST(i.quantity, ia.quantity) as available_qty " &
            "FROM tbl_inventory i " &
            "INNER JOIN tbl_inventoryad ia ON i.itemcode = ia.itemcode " &
            "WHERE i.itemcode = @itemcode", conn)

            cmd.Parameters.AddWithValue("@itemcode", itemCode)

            Dim availableQty As Decimal = CDec(cmd.ExecuteScalar())

            ' Subtract current cart usage
            If cartAddonUsage.ContainsKey(itemCode) Then
                availableQty -= cartAddonUsage(itemCode)
            End If

            Return availableQty >= requiredQty

        Catch ex As Exception
            MsgBox("Error checking addon inventory: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function

    Private Sub SizeButton_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim buttonData = btn.Tag
        SelectedSize = buttonData.SizeName
        SelectedPrice = buttonData.Price

        ' Add selected addons prices to total
        For Each addon In SelectedAddons
            SelectedPrice += addon.Price
        Next

        Me.Close()
    End Sub
End Class