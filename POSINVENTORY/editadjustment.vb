Imports MySql.Data.MySqlClient

Public Class editadjustment
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Calculate the new quantity by subtracting the waste value from the current quantity
            Dim currentQuantity As Integer = Integer.Parse(txt_quantity.Text) ' Original quantity from the database
            Dim wasteQuantity As Integer = If(String.IsNullOrEmpty(txt_wastequantity.Text), 0, Integer.Parse(txt_wastequantity.Text)) ' Waste quantity input
            Dim newQuantity As Integer = currentQuantity - wasteQuantity ' Deduct waste from current quantity

            ' Check if the resulting quantity is valid
            If newQuantity < 0 Then
                MsgBox("Error: Waste quantity exceeds the current quantity!", vbCritical, "Invalid Input")
                Exit Sub
            End If

            ' Update `tbl_inventoryad` table
            Dim cmd1 As New MySqlCommand("UPDATE `tbl_inventoryad` 
                                      SET `name` = @name, 
                                          `quantity` = @quantity, 
                                          `desc` = @desc, 
                                          `adjustby` = @adjustby, 
                                          `adjustdate` = @adjustdate, 
                                          `adjusttime` = @adjusttime, 
                                          `lastquantity` = @lastquantity,
                                          `waste` = @waste
                                      WHERE `itemcode` = @itemcode", conn)
            cmd1.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
            cmd1.Parameters.AddWithValue("@name", txt_name.Text)
            cmd1.Parameters.AddWithValue("@quantity", newQuantity) ' Updated quantity
            cmd1.Parameters.AddWithValue("@desc", txt_desc.Text)
            cmd1.Parameters.AddWithValue("@adjustby", Form1.lblUsername.Text)
            cmd1.Parameters.AddWithValue("@adjustdate", lbl_date1.Text)
            cmd1.Parameters.AddWithValue("@adjusttime", lbl_time.Text)
            cmd1.Parameters.AddWithValue("@lastquantity", lbl_lastquantity.Text)
            cmd1.Parameters.AddWithValue("@waste", wasteQuantity) ' Save waste quantity

            ' Execute the first query
            Dim i As Integer = cmd1.ExecuteNonQuery()

            ' Update `tbl_inventory` table (only itemcode, name, quantity, and waste)
            Dim cmd2 As New MySqlCommand("UPDATE `tbl_inventory` 
                                      SET `name` = @name, 
                                          `quantity` = @quantity
                                      WHERE `itemcode` = @itemcode", conn)
            cmd2.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
            cmd2.Parameters.AddWithValue("@name", txt_name.Text)
            cmd2.Parameters.AddWithValue("@quantity", newQuantity) ' Updated quantity

            ' Execute the second query
            Dim j As Integer = cmd2.ExecuteNonQuery()

            ' Check if both updates succeeded
            If i > 0 And j > 0 Then
                Dim Adjustment As Adjustment = Application.OpenForms.OfType(Of Adjustment)().FirstOrDefault()
                Adjustment.LoadAdjustments() ' Refresh the inventory list
                MsgBox("Adjustment updated successfully in both tables!", vbInformation, "ADJUSTMENT")
                Me.DialogResult = DialogResult.OK ' Signal success to the calling form
                Me.Close()
            Else
                MsgBox("Warning: Failed to update adjustments in one or both tables!", vbCritical, "ADJUSTMENT")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Me.Close()
    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        ' Allow only numeric characters and control keys (e.g., Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Suppress the invalid keypress
        End If
    End Sub

    Private Sub txt_wastequantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_wastequantity.KeyPress
        ' Allow only numeric characters and control keys (e.g., Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Suppress the invalid keypress
        End If
    End Sub
    Private Sub txt_name_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents the beep sound
            btn_save.PerformClick() ' Triggers the button click
        End If
    End Sub

    Private Sub txt_quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents the beep sound
            btn_save.PerformClick() ' Triggers the button click
        End If
    End Sub
    Private Sub txt_desc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_desc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents the beep sound
            btn_save.PerformClick() ' Triggers the button click
        End If
    End Sub

    Private Sub txt_wastequantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_wastequantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents the beep sound
            btn_save.PerformClick() ' Triggers the button click
        End If
    End Sub
End Class