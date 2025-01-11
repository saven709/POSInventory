Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frm_BillPrint
    Private _transNo As String
    Private ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

    Public Sub New(transNo As String)
        InitializeComponent()
        _transNo = transNo
    End Sub

    Private Sub frm_BillPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        load_reportPrint()
    End Sub

    Private Sub load_reportPrint()
        Using conn As New MySqlConnection(ConnectionString)
            Dim rptDS As ReportDataSource
            Try
                conn.Open()
                ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
                ReportViewer1.LocalReport.DataSources.Clear()

                ' Create dataset and adapter
                Dim ds As New DataSet1
                Using da As New MySqlDataAdapter()
                    ' Ensure we're using parameters to prevent SQL injection
                    da.SelectCommand = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE transno = @transno", conn)
                    da.SelectCommand.Parameters.AddWithValue("@transno", _transNo)

                    ' Add a small delay to ensure transaction is committed
                    System.Threading.Thread.Sleep(100)

                    ' Fill dataset
                    da.Fill(ds.Tables("DataTable1"))

                    ' Check if we got any data
                    If ds.Tables("DataTable1").Rows.Count = 0 Then
                        MessageBox.Show("No data found for transaction " & _transNo, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Set up report
                rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
                ReportViewer1.LocalReport.DataSources.Add(rptDS)
                ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                ReportViewer1.ZoomMode = ZoomMode.Percent
                ReportViewer1.ZoomPercent = 80

            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class