Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frm_report
    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30

        ' Configure DataGridView properties for better text display
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' Configure specific column properties
        For Each col As DataGridViewColumn In DataGridView1.Columns
            Select Case col.Name.ToLower()
                Case "foodname"
                    col.MinimumWidth = 200  ' Adjust this value based on your needs
                Case "transno", "foodcode"
                    col.MinimumWidth = 100
                Case "price", "qty", "totalprice", "grandtotal"
                    col.MinimumWidth = 80
            End Select
        Next

        Load_report()
        Get_Dashboard()  ' Load initial dashboard data
        Timer1.Start()   ' Start the dashboard update timer
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub Load_report()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` FROM `tbl_pos`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("transmonth"), dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While

            ' Auto-size columns after loading data
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            ' Ensure minimum widths are maintained
            For Each col As DataGridViewColumn In DataGridView1.Columns
                If col.Width < col.MinimumWidth Then
                    col.Width = col.MinimumWidth
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` FROM `tbl_pos` WHERE transno like @search OR foodcode like @search OR foodname like @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("transmonth"), dr.Item("foodcode"), dr.Item("foodname"), dr.Item("price"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        ' Set the dates to include the full day range
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59")

        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `foodcode`, `foodname`, `price`, `qty`, `totalprice`, `grandtotal` " &
                             "FROM `tbl_pos` " &
                             "WHERE transdate BETWEEN @date1 AND @date2 " &
                             "ORDER BY transdate", conn)
            cmd.Parameters.AddWithValue("@date1", date1)
            cmd.Parameters.AddWithValue("@date2", date2)
            dr = cmd.ExecuteReader

            While dr.Read
                ' Display the full datetime value
                Dim transDateTime As DateTime = Convert.ToDateTime(dr.Item("transdate"))
                DataGridView1.Rows.Add(
                DataGridView1.Rows.Count + 1,
                transDateTime.ToString("yyyy-MM-dd HH:mm:ss"),  ' Show full datetime
                dr.Item("transno"),
                dr.Item("transmonth"),
                dr.Item("foodcode"),
                dr.Item("foodname"),
                dr.Item("price"),
                dr.Item("qty"),
                dr.Item("totalprice"),
                dr.Item("grandtotal")
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub btn_Excel_Click(sender As Object, e As EventArgs) Handles btn_Excel.Click
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()

            ' Export headers and data
            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next

            ' Save the Excel file
            Dim fName As String = "BREWTOPIA SALES REPORT"
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    ReleaseObject(xlApp)
                    ReleaseObject(xlWorkBook)
                    ReleaseObject(xlWorkSheet)
                    MsgBox("Data Export Success!", MsgBoxStyle.Information, "BREWTOPIA")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub Get_Dashboard()
        Try
            ' Open connection if not already open
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Fetch today's sales - using date range for the full day
            Dim todayStart As String = Date.Now.ToString("yyyy-MM-dd 00:00:00")
            Dim todayEnd As String = Date.Now.ToString("yyyy-MM-dd 23:59:59")

            Dim cmd As New MySqlCommand("SELECT IFNULL(SUM(`totalprice`), 0) FROM `tbl_pos` WHERE `transdate` BETWEEN @todayStart AND @todayEnd", conn)
            cmd.Parameters.AddWithValue("@todayStart", todayStart)
            cmd.Parameters.AddWithValue("@todayEnd", todayEnd)
            lbl_todaySale.Text = FormatNumber(cmd.ExecuteScalar(), 2)

            ' Get current month's date range
            Dim currentMonth As DateTime = Date.Now
            Dim monthStart As String = New DateTime(currentMonth.Year, currentMonth.Month, 1).ToString("yyyy-MM-dd 00:00:00")
            Dim monthEnd As String = New DateTime(currentMonth.Year, currentMonth.Month, DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month)).ToString("yyyy-MM-dd 23:59:59")

            ' Query for current month's total sales
            cmd = New MySqlCommand("SELECT IFNULL(SUM(`totalprice`), 0) FROM `tbl_pos` WHERE `transdate` BETWEEN @monthStart AND @monthEnd", conn)
            cmd.Parameters.AddWithValue("@monthStart", monthStart)
            cmd.Parameters.AddWithValue("@monthEnd", monthEnd)

            ' Add debug prints to verify the date ranges
            Debug.Print($"Current Month Start: {monthStart}")
            Debug.Print($"Current Month End: {monthEnd}")

            Dim monthTotal As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            lbl_lastmonth.Text = FormatNumber(monthTotal, 2)  ' Note: You might want to rename this label to lbl_currentMonth

        Catch ex As Exception
            MsgBox("Error fetching dashboard data: " & ex.Message, vbCritical, "Error")
        Finally
            ' Close the connection only if it was opened here
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_Dashboard()
    End Sub
End Class