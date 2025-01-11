Imports MySql.Data.MySqlClient

Public Class editadjustment
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Update `tbl_inventoryad` table
            Dim cmd1 As New MySqlCommand("UPDATE `tbl_inventoryad` 
                                      SET `name` = @name, 
                                          `quantity` = @quantity, 
                                          `desc` = @desc, 
                                          `adjustby` = @adjustby, 
                                          `adjustdate` = @adjustdate, 
                                          `adjusttime` = @adjusttime, 
                                          `lastquantity` = @lastquantity 
                                      WHERE `itemcode` = @itemcode", conn)
            cmd1.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
            cmd1.Parameters.AddWithValue("@name", txt_name.Text)
            cmd1.Parameters.AddWithValue("@quantity", txt_quantity.Text)
            cmd1.Parameters.AddWithValue("@desc", txt_desc.Text)
            cmd1.Parameters.AddWithValue("@adjustby", Form1.lblUsername.Text)
            cmd1.Parameters.AddWithValue("@adjustdate", lbl_date1.Text)
            cmd1.Parameters.AddWithValue("@adjusttime", lbl_time.Text)
            cmd1.Parameters.AddWithValue("@lastquantity", lbl_lastquantity.Text)

            ' Execute the first query
            Dim i As Integer = cmd1.ExecuteNonQuery()

            ' Update `tbl_inventory` table (only itemcode, name, quantity)
            Dim cmd2 As New MySqlCommand("UPDATE `tbl_inventory` 
                                      SET `name` = @name, 
                                          `quantity` = @quantity 
                                      WHERE `itemcode` = @itemcode", conn)
            cmd2.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
            cmd2.Parameters.AddWithValue("@name", txt_name.Text)
            cmd2.Parameters.AddWithValue("@quantity", txt_quantity.Text)

            ' Execute the second query
            Dim j As Integer = cmd2.ExecuteNonQuery()

            ' Check if both updates succeeded
            If i > 0 And j > 0 Then
                MsgBox("Adjustment updated successfully in both tables!", vbInformation, "ADJUSTMENT")
                Me.DialogResult = DialogResult.OK ' Signal success to the calling form
                Me.Close()

                ' Call LoadAdjustments() from the adjustment form
                Dim adjustment As Adjustment = Application.OpenForms.OfType(Of Adjustment)().FirstOrDefault()
                If adjustment IsNot Nothing Then
                    adjustment.LoadAdjustments() ' Refresh the inventory list
                End If
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
End Class