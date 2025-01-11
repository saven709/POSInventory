Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Cashier

    Dim connString As String = "server=localhost;user=root;password=;database=brewtopia_db"
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodcode As Label
    Private WithEvents foodname As Label
    Private WithEvents img As CirclePicturBox



    Private Sub txt_receivedAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_receivedAmount.TextChanged
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(6).Value  ' Changed from Cells(5) to Cells(6) to match subtotal column
            Next
            If Double.TryParse(txt_receivedAmount.Text, 0) Then
                txt_BalanceAmount.Text = Format(CDec(txt_receivedAmount.Text) - grandtotal, "#,##0.00")
                lbl_tot.Text = Format(grandtotal, "#,##0.00")
            End If
        Catch ex As Exception
            ' Log the error or show a message if needed
        End Try
    End Sub

    Private Sub Get_grandTotal()
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(6).Value  ' Changed from Cells(5) to Cells(6) to match subtotal column
            Next
            lbl_overallTotal.Text = Format(CDec(grandtotal), "PHP #,##0.00")
            lbl_GrandTotal.Text = Format(CDec(grandtotal), "PHP #,##0.00")
            lbl_tot.Text = Format(grandtotal, "#,##0.00")
        Catch ex As Exception
            ' Log the error or show a message if needed
        End Try
    End Sub

    Private Sub Get_pricedata()
        Try
            Dim totalQuantity As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                totalQuantity = totalQuantity + CDbl(DataGridView1.Rows(i).Cells(5).Value)  ' Changed from Cells(4) to Cells(5) to match quantity column
            Next
            lbl_noOfProducts.Text = totalQuantity.ToString()
        Catch ex As Exception
            ' Log the error or show a message if needed
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_grandTotal()
        Get_pricedata()
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        lbl_time1.Text = Date.Now.ToString("HH:mm:ss")
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        InitializeDataGridView()
        UpdateButtonVisibility()
        Load_Foods()
        auto_Transno()
        Timer1 = New Timer()
        Timer1.Interval = 1000  ' Update every second
        Timer1.Start()

        txt_transno.ReadOnly = True
        txt_transno.TabStop = False
        'txt_transno.BackColor = SystemColors.Control ' Optional: Make it look like a label
        'txt_transno.BorderStyle = BorderStyle.None   ' Optional: Remove the border for cleaner appearance
        LoadCategories()  ' Load categories when form starts
        categorybtn.Text = categories(0)  ' Set initial text to "All"

        ' Create tooltip for category button
        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(categorybtn, "Click to switch category")
    End Sub

    Private Sub InitializeDataGridView()
        DataGridView1.RowTemplate.Height = 30
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("FoodCode", "Food Code")
        DataGridView1.Columns.Add("FoodName", "Food Name")
        DataGridView1.Columns.Add("Size", "Size")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("totalprice", "Subtotal")

        ' Set column properties
        DataGridView1.Columns("Price").DefaultCellStyle.Format = "N2"
        DataGridView1.Columns("totalprice").DefaultCellStyle.Format = "N2"
        DataGridView1.Columns("No").Width = 50
        DataGridView1.Columns("FoodCode").Width = 100
        DataGridView1.Columns("FoodName").Width = 150
        DataGridView1.Columns("Size").Width = 100
        DataGridView1.Columns("Price").Width = 100
        DataGridView1.Columns("Quantity").Width = 80
        DataGridView1.Columns("totalprice").Width = 120

        ' Hide the FoodCode column
        DataGridView1.Columns("FoodCode").Visible = False

        ' Set DataGridView properties
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub auto_Transno()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` ORDER BY id DESC", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                txt_transno.Text = (CInt(dr.Item("transno")) + 1).ToString()
            Else
                txt_transno.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname` FROM `tbl_food`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Function HasSufficientIngredients(foodCode As String) As Boolean
        Dim checkConnection As New MySqlConnection(connString)  ' Create a new connection
        Try
            checkConnection.Open()

            ' First, get all sizes and their ingredients for this food
            Dim checkIngredientsCmd As New MySqlCommand(
            "SELECT i.size_name, i.itemcode, i.quantity, inv.quantity as inventory_qty " &
            "FROM tbl_ingredients i " &
            "INNER JOIN tbl_inventory inv ON i.itemcode = inv.itemcode " &
            "WHERE i.foodcode = @foodcode", checkConnection)

            checkIngredientsCmd.Parameters.AddWithValue("@foodcode", foodCode)

            ' Create a dictionary to store size availability
            Dim sizeAvailability As New Dictionary(Of String, Boolean)

            Using reader As MySqlDataReader = checkIngredientsCmd.ExecuteReader()
                While reader.Read()
                    Dim sizeName As String = reader("size_name").ToString()
                    Dim requiredQty As Decimal = Decimal.Parse(reader("quantity").ToString())
                    Dim inventoryQty As Decimal = Decimal.Parse(reader("inventory_qty").ToString())

                    ' If this size hasn't been checked yet, assume it's available
                    If Not sizeAvailability.ContainsKey(sizeName) Then
                        sizeAvailability(sizeName) = True
                    End If

                    ' If any ingredient is insufficient, mark the size as unavailable
                    If requiredQty > inventoryQty Then
                        sizeAvailability(sizeName) = False
                    End If
                End While
            End Using

            ' If all sizes are unavailable, return false
            Return sizeAvailability.Values.Any(Function(available) available = True)

        Catch ex As Exception
            MessageBox.Show("Error checking ingredients: " & ex.Message)
            Return False
        Finally
            If checkConnection IsNot Nothing AndAlso checkConnection.State = ConnectionState.Open Then
                checkConnection.Close()
                checkConnection.Dispose()
            End If
        End Try
    End Function

    Private Sub Load_controls()
        Try
            ' Retrieve image data
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            Dim foodCode As String = dr.Item("foodcode").ToString()
            Dim foodNameStr As String = dr.Item("foodname").ToString()

            ' Store the image data in memory
            Dim ms As New MemoryStream(array)
            Dim originalImage As New Bitmap(ms)

            ' Check availability using the separate connection
            Dim isAvailable As Boolean = HasSufficientIngredients(foodCode)

            pan = New Panel With {
            .Width = 140,
            .Height = 140,
            .BackColor = If(isAvailable, Color.FromArgb(40, 40, 40), Color.FromArgb(100, 100, 100)),
            .Tag = foodCode,
            .Enabled = isAvailable
        }

            img = New CirclePicturBox With {
            .Height = 100,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .Dock = DockStyle.Top,
            .Tag = foodCode
        }

            ' Apply gray filter to image if unavailable
            If Not isAvailable Then
                ' Convert image to grayscale
                Dim grayImage As New Bitmap(originalImage.Width, originalImage.Height)
                Using g As Graphics = Graphics.FromImage(grayImage)
                    Dim colorMatrix As New ColorMatrix(
                    New Single()() {
                        New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                        New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                        New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                        New Single() {0, 0, 0, 1, 0},
                        New Single() {0, 0, 0, 0, 1}
                    })

                    Dim attributes As New ImageAttributes()
                    attributes.SetColorMatrix(colorMatrix)

                    g.DrawImage(originalImage, New Rectangle(0, 0, originalImage.Width, originalImage.Height),
                           0, 0, originalImage.Width, originalImage.Height,
                           GraphicsUnit.Pixel, attributes)
                End Using
                img.BackgroundImage = grayImage
            Else
                img.BackgroundImage = originalImage
            End If

            foodname = New Label With {
            .ForeColor = If(isAvailable, Color.White, Color.Gray),
            .Font = New Font("Segoe UI", 8, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Text = foodNameStr,
            .Tag = foodCode
        }

            pan.Controls.Add(img)
            pan.Controls.Add(foodname)
            FlowLayoutPanel1.Controls.Add(pan)

            ' Only add event handlers if the item is available
            If isAvailable Then
                AddHandler pan.Click, AddressOf Selectimg_Click
                AddHandler img.Click, AddressOf Selectimg_Click
                AddHandler foodname.Click, AddressOf Selectimg_Click
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading controls: " & ex.Message)
        End Try
    End Sub

    ' Modify the Selectimg_Click to check inventory before adding to cart
    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        Dim foodCode As String = sender.Tag.ToString()

        ' Get the food name from the related control
        Dim foodName As String = ""
        If TypeOf sender Is Label Then
            foodName = DirectCast(sender, Label).Text
        Else
            ' If clicked on panel or image, find the label in the panel
            Dim panel As Panel = If(TypeOf sender Is Panel,
                              DirectCast(sender, Panel),
                              DirectCast(sender, CirclePicturBox).Parent)
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Label Then
                    foodName = DirectCast(ctrl, Label).Text
                    Exit For
                End If
            Next
        End If

        ' Pass both foodCode and foodName to the formsizes form
        Dim sizeForm As New formsizes(foodCode, foodName)
        sizeForm.ShowDialog()

        ' Get the selected size and price
        If sizeForm.SelectedSize IsNot Nothing Then
            Dim selectedSize = sizeForm.SelectedSize
            Dim selectedPrice = sizeForm.SelectedPrice

            ' Before adding to cart, check if we have enough inventory
            If HasSufficientInventoryForOrder(foodCode, selectedSize, 1) Then
                AddItemToCart(foodCode, selectedSize, selectedPrice, foodName)
            Else
                MessageBox.Show("Not enough inventory available for this item.", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub


    Private Sub AddItemToCart(foodCode As String, sizeName As String, price As Decimal, foodName As String)
        Dim exist As Boolean = False
        Dim numRow As Integer = 0

        ' Check if the item already exists in the DataGridView
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(1).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString() = foodCode AndAlso itm.Cells(3).Value.ToString() = sizeName Then
                    exist = True
                    numRow = itm.Index
                    Exit For
                End If
            End If
        Next

        ' If the item doesn't exist, add it to the DataGridView
        If Not exist Then
            Dim subtotal As Decimal = price
            DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, foodCode, foodName, sizeName, price, 1, subtotal)
        Else
            ' If it exists, update the quantity and subtotal
            DataGridView1.Rows(numRow).Cells(5).Value = CInt(DataGridView1.Rows(numRow).Cells(5).Value) + 1
            DataGridView1.Rows(numRow).Cells(6).Value = CDec(DataGridView1.Rows(numRow).Cells(4).Value) * CInt(DataGridView1.Rows(numRow).Cells(5).Value)
        End If

        CalculateTotal()
        UpdateNoOfProducts() ' Update the total number of items
        UpdateButtonVisibility()

    End Sub


    Private Sub CalculateTotal()
        Try
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(6).Value IsNot Nothing Then
                    total += CDec(row.Cells(6).Value)
                End If
            Next
            lbl_GrandTotal.Text = total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error calculating total: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 Then  ' Make sure we didn't click a header
                Dim row = DataGridView1.Rows(e.RowIndex)
                ' Store the current row index for use with quantity buttons
                DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(0)
                UpdateNoOfProducts() ' Update the total number of items when quantity changes
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting item: " & ex.Message)
        End Try
    End Sub

    ' Modified version of txtquantity_TextChanged to consider cart items
    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = DataGridView1.CurrentRow
                Dim price As Decimal = CDec(row.Cells(4).Value)
                Dim foodCode = row.Cells(1).Value.ToString()
                Dim sizeName = row.Cells(3).Value.ToString()
                Dim currentQty = CInt(row.Cells(5).Value)
                Dim newQty As Integer

                ' Skip validation if the textbox is empty
                If String.IsNullOrWhiteSpace(txtquantity.Text) Then
                    Return
                End If

                ' Validate the input in txtquantity
                If Integer.TryParse(txtquantity.Text, newQty) Then
                    If newQty > 0 Then
                        ' Temporarily set quantity to 0 to exclude current item from cart calculation
                        row.Cells(5).Value = 0

                        ' Check if we have enough inventory for the new quantity
                        If HasSufficientInventoryForOrder(foodCode, sizeName, newQty) Then
                            ' Update quantity and subtotal
                            row.Cells(5).Value = newQty
                            row.Cells(6).Value = price * newQty
                            CalculateTotal()
                            UpdateNoOfProducts()
                        Else
                            ' Restore original quantity
                            row.Cells(5).Value = currentQty
                            MessageBox.Show("Cannot set this quantity. Not enough inventory available considering items already in cart.", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtquantity.Text = currentQty.ToString()
                        End If
                    Else
                        ' Restore original quantity
                        row.Cells(5).Value = currentQty
                        If txtquantity.Text.Trim() <> "" Then
                            MessageBox.Show("Please enter a valid quantity (greater than 0).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtquantity.Text = currentQty.ToString()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating quantity: " & ex.Message)
        End Try
    End Sub

    ' Add this handler for the Enter key
    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        ' If Enter key is pressed
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Prevent the Enter key from triggering another TextChanged event
            e.Handled = True
            ' Move focus to another control or process the entry
            SendKeys.Send("{TAB}")
        End If
    End Sub
    ' Modified version of btnPlus_Click to consider cart items
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = DataGridView1.CurrentRow
                Dim foodCode = row.Cells(1).Value.ToString()
                Dim sizeName = row.Cells(3).Value.ToString()
                Dim currentQty = CInt(row.Cells(5).Value)
                Dim price = CDec(row.Cells(4).Value)

                ' Temporarily reduce the current item's quantity by 1 in the DataGridView
                row.Cells(5).Value = currentQty - 1

                ' Check if we have enough inventory for the increased quantity
                If HasSufficientInventoryForOrder(foodCode, sizeName, 1) Then
                    ' Restore and increment the quantity
                    currentQty += 1
                    row.Cells(5).Value = currentQty

                    ' Update subtotal
                    row.Cells(6).Value = price * currentQty

                    CalculateTotal()
                    UpdateNoOfProducts()
                Else
                    ' Restore the original quantity
                    row.Cells(5).Value = currentQty
                    MessageBox.Show("Cannot increase quantity. Not enough inventory available considering items already in cart.", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating quantity: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = DataGridView1.CurrentRow
                Dim currentQty = CInt(row.Cells(5).Value)
                Dim price = CDec(row.Cells(4).Value)

                If currentQty > 1 Then
                    ' Update quantity
                    currentQty -= 1
                    row.Cells(5).Value = currentQty

                    ' Update subtotal
                    row.Cells(6).Value = price * currentQty

                    CalculateTotal()
                    UpdateNoOfProducts() ' Update the total number of items
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating quantity: " & ex.Message)
        End Try
    End Sub


    ' Handle Remove button
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                If MessageBox.Show("Are you sure you want to remove this item?", "Confirm Remove",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    RenumberRows()
                    CalculateTotal()
                    UpdateNoOfProducts() ' Update the total number of items
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error removing item: " & ex.Message)
        End Try
        UpdateButtonVisibility()

    End Sub


    Private Sub RenumberRows()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Try
            If DataGridView1.Rows.Count > 0 Then
                If MessageBox.Show("Are you sure you want to start a new order?", "Confirm New Order",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Clear()
                    lbl_GrandTotal.Text = "0.00"
                    auto_Transno()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error creating new order: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRecord_Click_1(sender As Object, e As EventArgs) Handles btnRecord.Click
        If MsgBox("Are You Sure Order Confirm?", vbQuestion + vbYesNo) = vbYes Then
            If txt_receivedAmount.Text = String.Empty Then
                MsgBox("Please Enter Received Amount!", vbExclamation)
                Return
            ElseIf txt_BalanceAmount.Text < 0 Then
                MsgBox("Infinity Balance!" & vbNewLine & txt_receivedAmount.Text & " ₹", MsgBoxStyle.Exclamation)
                Return
            Else
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start transaction
                    Dim transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Insert transaction details into tbl_pos
                        cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods`) VALUES (@transno,@transdate,@transmonth,@foodcode,@foodname,@price,@qty,@totalprice,@grandtotal,@nooffoods)", conn, transaction)

                        Dim transDateTime As DateTime = DateTime.ParseExact(lbl_date.Text & " " & lbl_time1.Text, "yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

                        For j As Integer = 0 To DataGridView1.Rows.Count - 1
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@transno", txt_transno.Text)
                            cmd.Parameters.AddWithValue("@transdate", transDateTime)
                            cmd.Parameters.AddWithValue("@transmonth", lblUsername.Text)
                            cmd.Parameters.AddWithValue("@foodcode", DataGridView1.Rows(j).Cells(1).Value)

                            Dim foodname As String = DataGridView1.Rows(j).Cells(2).Value.ToString() & " - " & DataGridView1.Rows(j).Cells(3).Value.ToString()
                            cmd.Parameters.AddWithValue("@foodname", foodname)

                            cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value)
                            cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(5).Value)
                            cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(6).Value)
                            cmd.Parameters.AddWithValue("@grandtotal", lbl_tot.Text)
                            cmd.Parameters.AddWithValue("@nooffoods", lbl_noOfProducts.Text)
                            cmd.ExecuteNonQuery()

                            ' Deduct inventory for the current foodcode and size
                            DeductInventory(DataGridView1.Rows(j).Cells(1).Value.ToString(), DataGridView1.Rows(j).Cells(3).Value.ToString(), DataGridView1.Rows(j).Cells(5).Value, transaction)
                        Next

                        transaction.Commit()
                        MsgBox("Transaction completed successfully!", vbInformation)

                        If MsgBox("Print Bill?", vbQuestion + vbYesNo) = vbYes Then
                            Try
                                ' Add a small delay to ensure transaction is committed
                                System.Threading.Thread.Sleep(100)

                                ' Create and show the bill print form with the transaction number
                                Using printForm As New frm_BillPrint(txt_transno.Text)
                                    printForm.ShowDialog()
                                End Using
                            Catch ex As Exception
                                MessageBox.Show("Error showing bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If

                    Catch ex As Exception
                        transaction.Rollback()
                        MsgBox("Error deducting ingredients: " & ex.Message, vbExclamation)
                    End Try
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, vbExclamation)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End If
        Else
            Return
        End If

        new_order()
        UpdateButtonVisibility()
    End Sub

    Private Sub DeductInventory(foodCode As String, sizeName As String, quantity As Integer, transaction As MySqlTransaction)
        Try
            ' Query to fetch ingredients for the specific food code and size
            Dim fetchIngredientsCmd As New MySqlCommand("SELECT i.itemcode, i.quantity * @orderQuantity AS totalQty " &
                                                    "FROM tbl_ingredients i " &
                                                    "WHERE i.foodcode = @foodcode AND i.size_name = @size_name", conn, transaction)
            fetchIngredientsCmd.Parameters.AddWithValue("@foodcode", foodCode)
            fetchIngredientsCmd.Parameters.AddWithValue("@size_name", sizeName)
            fetchIngredientsCmd.Parameters.AddWithValue("@orderQuantity", quantity)

            Dim ingredientList As New List(Of Tuple(Of String, Decimal))()

            ' Use DataReader to fetch ingredients and store them in a temporary list
            Using reader As MySqlDataReader = fetchIngredientsCmd.ExecuteReader()
                While reader.Read()
                    Dim itemCode As String = reader("itemcode").ToString()
                    Dim totalQty As Decimal = Decimal.Parse(reader("totalQty").ToString())
                    ingredientList.Add(New Tuple(Of String, Decimal)(itemCode, totalQty))
                End While
            End Using

            ' Deduct inventory after closing the reader
            For Each ingredient In ingredientList
                Dim itemCode As String = ingredient.Item1
                Dim totalQty As Decimal = ingredient.Item2

                ' Deduct from tbl_inventory
                Dim deductInventoryCmd As New MySqlCommand("UPDATE tbl_inventory SET quantity = quantity - @quantity WHERE itemcode = @itemcode", conn, transaction)
                deductInventoryCmd.Parameters.AddWithValue("@quantity", totalQty)
                deductInventoryCmd.Parameters.AddWithValue("@itemcode", itemCode)
                deductInventoryCmd.ExecuteNonQuery()

                ' Deduct from tbl_inventoryad
                Dim deductInventoryAdCmd As New MySqlCommand("UPDATE tbl_inventoryad SET quantity = quantity - @quantity WHERE itemcode = @itemcode", conn, transaction)
                deductInventoryAdCmd.Parameters.AddWithValue("@quantity", totalQty)
                deductInventoryAdCmd.Parameters.AddWithValue("@itemcode", itemCode)
                deductInventoryAdCmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            Throw New Exception("Error deducting inventory: " & ex.Message)
        End Try
    End Sub



    Sub new_order()
        Load_Foods()
        DataGridView1.Rows.Clear()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        auto_Transno()
        txt_BalanceAmount.Clear()
        txt_receivedAmount.Clear()
        UpdateButtonVisibility()

    End Sub
    'Private Sub SaveTransaction()
    'Try
    '      conn.Open()
    'For Each row As DataGridViewRow In DataGridView1.Rows
    '            cmd = New MySqlCommand("INSERT INTO `tbl_pos` (`transno`, `foodcode`, `foodname`, `size`, `price`, `qty`, `subtotal`, `date`) VALUES (@transno, @foodcode, @foodname, @size, @price, @qty, @subtotal, @date)", conn)
    '           cmd.Parameters.AddWithValue("@transno", txt_transno.Text)
    '           cmd.Parameters.AddWithValue("@foodcode", row.Cells(1).Value)
    '           cmd.Parameters.AddWithValue("@foodname", row.Cells(2).Value)
    '           cmd.Parameters.AddWithValue("@size", row.Cells(3).Value)
    '           cmd.Parameters.AddWithValue("@price", row.Cells(4).Value)
    '          cmd.Parameters.AddWithValue("@qty", row.Cells(5).Value)
    '          cmd.Parameters.AddWithValue("@subtotal", row.Cells(6).Value)
    '          cmd.Parameters.AddWithValue("@date", lbl_date.Text)
    '           cmd.ExecuteNonQuery()
    'Next
    'Catch ex As Exception
    '       MsgBox("Error saving transaction: " & ex.Message)
    'inally
    '       conn.Close()
    'End Try
    'End Sub
    Private Sub UpdateNoOfProducts()
        Dim totalItems As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(5).Value IsNot Nothing Then
                totalItems += CInt(row.Cells(5).Value) ' Add the quantity of each item
            End If
        Next
        lbl_noOfProducts.Text = totalItems.ToString() ' Update the label
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Load_Foods()
        DataGridView1.Rows.Clear()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        auto_Transno()
        txt_BalanceAmount.Clear()
        txt_receivedAmount.Clear()
        UpdateButtonVisibility()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Show a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check user's decision
        If result = DialogResult.Yes Then
            ' Show the login form
            Login.Show()
            ' Close the current form
            Me.Close()
        End If
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname` FROM `tbl_food` WHERE foodcode like '%" & txt_search.Text & "%' or foodname like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then conn.Close()


    End Sub
    Private categories As List(Of String) = New List(Of String)
    Private currentCategoryIndex As Integer = -1

    Private Sub LoadCategories()
        categories.Clear()
        categories.Add("All")  ' Always add "All" as the first option

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT DISTINCT category FROM tbl_food ORDER BY category", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                If Not dr.IsDBNull(0) Then  ' Check if category is not null
                    categories.Add(dr("category").ToString())
                End If
            End While

        Catch ex As Exception
            MsgBox("Error loading categories: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub
    Private Sub categorybtn_Click(sender As Object, e As EventArgs) Handles categorybtn.Click
        ' Move to next category
        currentCategoryIndex = (currentCategoryIndex + 1) Mod categories.Count

        ' Update button text to show current category
        categorybtn.Text = categories(currentCategoryIndex)

        ' Filter items based on selected category
        If currentCategoryIndex = 0 Then  ' "All" category
            Load_Foods()
        Else
            FilterByCategory(categories(currentCategoryIndex))
        End If

        UpdateCategoryButtonTooltip()
    End Sub
    Private Sub FilterByCategory(categoryName As String)
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname` FROM `tbl_food` WHERE category = @category", conn)
            cmd.Parameters.AddWithValue("@category", categoryName)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub UpdateCategoryButtonTooltip()
        Dim nextIndex = (currentCategoryIndex + 1) Mod categories.Count
        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(categorybtn, $"Next: {categories(nextIndex)}")
    End Sub
    Private Sub UpdateButtonVisibility()


        btnRecord.Enabled = DataGridView1.Rows.Count > 0
        btnRemove.Enabled = DataGridView1.Rows.Count > 0
        btnPlus.Enabled = DataGridView1.Rows.Count > 0
        btnminus.Enabled = DataGridView1.Rows.Count > 0
    End Sub
    ' Modified function to check if there's enough inventory considering cart items
    Private Function HasSufficientInventoryForOrder(foodCode As String, sizeName As String, orderQuantity As Integer) As Boolean
        Dim checkConnection As New MySqlConnection(connString)
        Try
            checkConnection.Open()

            ' Get current cart ingredient usage
            Dim cartUsage As Dictionary(Of String, Decimal) = GetCartIngredientUsage()

            ' Query to check if we have enough inventory for all ingredients
            Dim checkCmd As New MySqlCommand(
            "SELECT i.itemcode, i.quantity * @orderQuantity as required_qty, inv.quantity as available_qty " &
            "FROM tbl_ingredients i " &
            "INNER JOIN tbl_inventory inv ON i.itemcode = inv.itemcode " &
            "WHERE i.foodcode = @foodcode AND i.size_name = @size_name", checkConnection)

            checkCmd.Parameters.AddWithValue("@foodcode", foodCode)
            checkCmd.Parameters.AddWithValue("@size_name", sizeName)
            checkCmd.Parameters.AddWithValue("@orderQuantity", orderQuantity)

            Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                While reader.Read()
                    Dim itemCode As String = reader("itemcode").ToString()
                    Dim requiredQty As Decimal = Decimal.Parse(reader("required_qty").ToString())
                    Dim availableQty As Decimal = Decimal.Parse(reader("available_qty").ToString())

                    ' Add existing cart usage for this ingredient
                    If cartUsage.ContainsKey(itemCode) Then
                        requiredQty += cartUsage(itemCode)
                    End If

                    ' If total required quantity exceeds available, return false
                    If requiredQty > availableQty Then
                        Return False
                    End If
                End While
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Error checking inventory: " & ex.Message)
            Return False
        Finally
            If checkConnection IsNot Nothing Then
                checkConnection.Close()
                checkConnection.Dispose()
            End If
        End Try
    End Function
    ' Function to calculate total ingredients needed for items in cart
    Private Function GetCartIngredientUsage() As Dictionary(Of String, Decimal)
        Dim ingredientUsage As New Dictionary(Of String, Decimal)
        Dim checkConnection As New MySqlConnection(connString)

        Try
            checkConnection.Open()

            ' For each item in the cart
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim foodCode As String = row.Cells(1).Value.ToString()
                Dim sizeName As String = row.Cells(3).Value.ToString()
                Dim quantity As Integer = CInt(row.Cells(5).Value)

                ' Get ingredients for this item
                Dim cmd As New MySqlCommand(
                    "SELECT itemcode, quantity * @orderQuantity as total_qty " &
                    "FROM tbl_ingredients " &
                    "WHERE foodcode = @foodcode AND size_name = @size_name", checkConnection)

                cmd.Parameters.AddWithValue("@foodcode", foodCode)
                cmd.Parameters.AddWithValue("@size_name", sizeName)
                cmd.Parameters.AddWithValue("@orderQuantity", quantity)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim itemCode As String = reader("itemcode").ToString()
                        Dim totalQty As Decimal = Decimal.Parse(reader("total_qty").ToString())

                        ' Add to dictionary
                        If ingredientUsage.ContainsKey(itemCode) Then
                            ingredientUsage(itemCode) += totalQty
                        Else
                            ingredientUsage.Add(itemCode, totalQty)
                        End If
                    End While
                End Using
            Next

            Return ingredientUsage

        Catch ex As Exception
            MessageBox.Show("Error calculating cart ingredients: " & ex.Message)
            Return New Dictionary(Of String, Decimal)
        Finally
            If checkConnection IsNot Nothing Then
                checkConnection.Close()
                checkConnection.Dispose()
            End If
        End Try
    End Function

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        ' Show a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check user's decision
        If result = DialogResult.Yes Then
            ' Close the application
            Application.Exit()
        End If
    End Sub
End Class