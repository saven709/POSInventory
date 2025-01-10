Imports MySql.Data.MySqlClient

Public Class frmitem
    Sub auto_itemcode()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT * FROM `tbl_inventory` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_itemcode.Text = dr.Item("itemcode").ToString + 1

            Else
                txt_itemcode.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()


            ' Insert data into tbl_inventory
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_inventory`(`itemcode`, `name`, `measurementname`, `quantity`, `category`, `stockdate`, `stocktime`, `stockby`) VALUES (@itemcode, @name, @measurementname, @quantity, @category, @date, @time, @username)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@measurementname", txt_measurementname.Text)
            cmd.Parameters.AddWithValue("@quantity", txt_quantity.Text)
            cmd.Parameters.AddWithValue("@category", txt_category.Text)
            cmd.Parameters.AddWithValue("@date", Form1.lbl_date1.Text)
            cmd.Parameters.AddWithValue("@time", Form1.lbl_time.Text)
            cmd.Parameters.AddWithValue("@username", Form1.lblUsername.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                ' If the first insert is successful, proceed to insert into tbl_inventoryad
                Dim cmd2 As New MySqlCommand("INSERT INTO `tbl_inventoryad`(`itemcode`, `name`, `quantity`) VALUES (@itemcode, @name, @quantity)", conn)
                cmd2.Parameters.Clear()
                cmd2.Parameters.AddWithValue("@itemcode", txt_itemcode.Text)
                cmd2.Parameters.AddWithValue("@name", txt_name.Text)
                cmd2.Parameters.AddWithValue("@quantity", txt_quantity.Text)

                Dim j As Integer = cmd2.ExecuteNonQuery()
                If j > 0 Then
                    MsgBox("Inventory item saved successfully in both tables!", vbInformation, "INVENTORY")
                Else
                    MsgBox("Warning: Failed to save item in tbl_inventoryad!", vbCritical, "INVENTORY")
                End If
            Else
                MsgBox("Warning: Failed to save inventory item!", vbCritical, "INVENTORY")
            End If
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try

        ' Clear the textboxes after saving
        txt_itemcode.Clear()
        txt_name.Clear()
        txt_measurementname.Clear()
        txt_category.Clear()
        txt_quantity.Clear()
        Form1.GunaButton7.PerformClick()  ' Trigger any post-save actions (like refreshing the grid)
    End Sub



    Private Sub frmitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_itemcode()
    End Sub
End Class