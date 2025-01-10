Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Cashier
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

    Private Sub Load_controls()
        ' Retrieve image data
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        pan = New Panel With {
            .Width = 140,
            .Height = 140,
            .BackColor = Color.FromArgb(40, 40, 40),
            .Tag = dr.Item("foodcode").ToString()
        }

        img = New CirclePicturBox With {
            .Height = 100,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .Dock = DockStyle.Top,
            .Tag = dr.Item("foodcode").ToString()
        }

        Dim ms As New MemoryStream(array)
        img.BackgroundImage = New Bitmap(ms)

        foodname = New Label With {
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 8, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Text = dr.Item("foodname").ToString(),
            .Tag = dr.Item("foodcode").ToString()
        }

        pan.Controls.Add(img)
        pan.Controls.Add(foodname)
        FlowLayoutPanel1.Controls.Add(pan)

        ' Event handler for selecting food
        AddHandler pan.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler foodname.Click, AddressOf Selectimg_Click
    End Sub

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

            ' Add item to DataGridView using the stored food name
            AddItemToCart(foodCode, selectedSize, selectedPrice, foodName)
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

    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged
        Try
            ' Check if a row is selected
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = DataGridView1.CurrentRow
                Dim price As Decimal = CDec(row.Cells(4).Value) ' Get the price from the selected row
                Dim newQty As Integer

                ' Skip validation if the textbox is empty
                If String.IsNullOrWhiteSpace(txtquantity.Text) Then
                    Return
                End If

                ' Validate the input in txtquantity
                If Integer.TryParse(txtquantity.Text, newQty) Then
                    If newQty > 0 Then
                        ' Update quantity
                        row.Cells(5).Value = newQty
                        ' Update subtotal
                        row.Cells(6).Value = price * newQty
                        ' Recalculate totals
                        CalculateTotal()
                        UpdateNoOfProducts() ' Update total items
                    Else
                        ' Only show message if the value is actually invalid (not just empty)
                        If txtquantity.Text.Trim() <> "" Then
                            MessageBox.Show("Please enter a valid quantity (greater than 0).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Please select a row in the DataGridView before updating the quantity.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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


    ' Handle + button
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = DataGridView1.CurrentRow
                Dim currentQty = CInt(row.Cells(5).Value)
                Dim price = CDec(row.Cells(4).Value)

                ' Update quantity
                currentQty += 1
                row.Cells(5).Value = currentQty

                ' Update subtotal
                row.Cells(6).Value = price * currentQty

                CalculateTotal()
                UpdateNoOfProducts() ' Update the total number of items
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

                    cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal`, `nooffoods`) VALUES (@transno,@transdate,@transmonth,@foodcode,@foodname,@price,@qty,@totalprice,@grandtotal,@nooffoods)", conn)

                    ' Combine lbl_date.Text and lbl_time.Text into a DateTime object
                    Dim transDateTime As DateTime = DateTime.ParseExact(lbl_date.Text & " " & lbl_time1.Text, "yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

                    For j As Integer = 0 To DataGridView1.Rows.Count - 1
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@transno", txt_transno.Text)
                        cmd.Parameters.AddWithValue("@transdate", transDateTime) ' Use concatenated date and time
                        cmd.Parameters.AddWithValue("@transmonth", lblUsername.Text) ' Extract the month
                        cmd.Parameters.AddWithValue("@foodcode", DataGridView1.Rows(j).Cells(1).Value)

                        ' Concatenate foodname with size to save it in foodname field
                        Dim foodname As String = DataGridView1.Rows(j).Cells(2).Value.ToString() & " - " & DataGridView1.Rows(j).Cells(3).Value.ToString()
                        cmd.Parameters.AddWithValue("@foodname", foodname)

                        cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value)
                        cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@grandtotal", lbl_tot.Text)
                        cmd.Parameters.AddWithValue("@nooffoods", lbl_noOfProducts.Text)
                        i = cmd.ExecuteNonQuery
                    Next

                    If i > 0 Then
                        If MsgBox("Print Bill?", vbQuestion + vbYesNo) = vbYes Then
                            frm_BillPrint.ShowDialog()
                        End If
                    Else
                        MsgBox("Warning: Some Failure!", vbExclamation)
                    End If
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

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Login.Close()
    End Sub
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
        Login.Show()
        Me.Close()
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

End Class