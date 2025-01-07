Public Class Login
    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Cashier.Show()
        Me.Hide()
    End Sub
End Class