Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpeninPanel(New Dashboard)
    End Sub
    Private Sub OpeninPanel(ByVal formOpen As Object)
        If PanelMain.Controls.Count > 0 Then
            PanelMain.Controls.RemoveAt(0)
        End If

        Dim dh As Form = TryCast(formOpen, Form)
        dh.TopLevel = False
        dh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        dh.Dock = DockStyle.Fill
        PanelMain.Controls.Add(dh)
        PanelMain.Tag = dh
        dh.Show()
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpeninPanel(New Dashboard)
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        'PanelProduct.Visible = Not PanelProduct.Visible
        OpeninPanel(New List)
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        ' Hide all panels first
        PanelSetting.Visible = False
        PanelRecord.Visible = False

        ' Toggle visibility of PanelStock
        PanelStock.Visible = Not PanelStock.Visible
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        ' Hide all panels first
        PanelStock.Visible = False
        PanelSetting.Visible = False

        ' Toggle visibility of PanelRecord
        PanelRecord.Visible = Not PanelRecord.Visible
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Login.Close()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        OpeninPanel(New List)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        OpeninPanel(New Category)
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        OpeninPanel(New Entry)
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        OpeninPanel(New Adjustment)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ' Hide all panels first
        PanelStock.Visible = False
        PanelRecord.Visible = False

        ' Toggle visibility of PanelSetting
        PanelSetting.Visible = Not PanelSetting.Visible
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        OpeninPanel(New UserAccount)
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        OpeninPanel(New frm_report)
        'frm_report.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
End Class
