Imports MySql.Data.MySqlClient

Public Class Login
    Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter both username and password!", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Try
            Using conn As New MySqlConnection(ConnectionString)
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "SELECT id, fullname, username, password, role, status FROM tbl_users WHERE username = @username"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            If dr("password").ToString() = password Then
                                If dr("status").ToString() = "Active" Then
                                    Dim userFullname As String = dr("fullname").ToString()
                                    Dim userRole As String = dr("role").ToString()

                                    Me.Hide()

                                    If userRole = "Cashier" Then
                                        Dim cashierForm As New Cashier()
                                        cashierForm.lblUsername.Text = userFullname
                                        cashierForm.Show()
                                    ElseIf userRole = "Admin" Then
                                        Dim adminForm As New Form1()
                                        adminForm.lblUsername.Text = userFullname
                                        adminForm.Show()

                                        Dim dashboardForm As Dashboard = Application.OpenForms.OfType(Of Dashboard)().FirstOrDefault()
                                        If dashboardForm IsNot Nothing Then
                                            dashboardForm.lblUsername2.Text = userFullname
                                        End If
                                    End If
                                Else
                                    MsgBox("Your account is inactive. Please contact the administrator.", MsgBoxStyle.Critical, "Inactive Account")
                                End If
                            Else
                                MsgBox("Incorrect password!", MsgBoxStyle.Critical, "Login Failed")
                            End If
                        Else
                            MsgBox("Username not found!", MsgBoxStyle.Critical, "Login Failed")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error logging in: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class
