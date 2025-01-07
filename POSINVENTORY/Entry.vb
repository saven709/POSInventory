Public Class Entry
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        OpeninPanel(New StockinRecord)
    End Sub
    Private Sub OpeninPanel(ByVal formOpen As Object)
        If Form1.PanelMain.Controls.Count > 0 Then
            Form1.PanelMain.Controls.RemoveAt(0)
        End If

        Dim dh As Form = TryCast(formOpen, Form)
        dh.TopLevel = False
        dh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        dh.Dock = DockStyle.Fill
        Form1.PanelMain.Controls.Add(dh)
        Form1.PanelMain.Tag = dh
        dh.Show()
    End Sub
End Class