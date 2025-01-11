Imports MySql.Data.MySqlClient

Public Class frmChangepassword
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Validate that a new password is entered
        If String.IsNullOrWhiteSpace(txt_Newpassword.Text) Then
            MsgBox("Please enter a new password!", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        Try
            ' Open the database connection
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Update the password for the selected user
            Dim query As String = "UPDATE tbl_users SET password = @newpassword WHERE username = @username"

            ' Create MySQL command
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newpassword", txt_Newpassword.Text.Trim()) ' Use hashing in production
                cmd.Parameters.AddWithValue("@username", lblUsername.Text)

                ' Execute the update query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MsgBox("Password updated successfully!", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Failed to update password. User not found!", MsgBoxStyle.Critical, "Error")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error updating password: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            ' Close the database connection
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        ' Close the form after saving
        Me.Close()
        txt_Newpassword.Clear()
        Dim UserAccount As UserAccount = Application.OpenForms.OfType(Of UserAccount)().FirstOrDefault()
        If UserAccount IsNot Nothing Then
            UserAccount.LoadUsers()
        End If
    End Sub
End Class
