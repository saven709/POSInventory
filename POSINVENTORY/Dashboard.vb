Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call functions to display daily sales and total products
        LoadTopSellingProducts()
        LoadDailySalesTrend()
        DisplayDailySales()
        DisplayTotalProducts()
        LoadCriticalItems()
        LoadTotalProductsSold()
    End Sub
    Private Sub LoadCriticalItems()
        ' Connection string for the database
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                ' SQL query to count critical items
                Dim query As String = "SELECT COUNT(*) AS critical_count FROM tbl_inventoryad WHERE quantity < 10;"
                Dim cmd As New MySqlCommand(query, conn)

                ' Execute the query and fetch the count
                Dim criticalCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Display the count in lblcriticalitems
                lblcriticalitems.Text = criticalCount.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching critical items: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadTopSellingProducts()
        ' Connection string for the database
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        ' Clear any existing data from Chart2
        Chart2.Series.Clear()
        Chart2.Titles.Clear()

        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                ' SQL Query to get the top-selling products
                Dim query As String = "SELECT foodname, SUM(qty) AS total_quantity " &
                                  "FROM tbl_pos " &
                                  "GROUP BY foodname " &
                                  "ORDER BY total_quantity DESC " &
                                  "LIMIT 10;"
                Dim cmd As New MySqlCommand(query, conn)

                ' Execute the query and load the data
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Create a new series for the bar chart
                Dim series As New Series("Top Selling Products")
                series.ChartType = SeriesChartType.Bar
                Chart2.Series.Add(series)

                ' Populate the chart with data from the query
                While reader.Read()
                    Dim foodName As String = reader("foodname").ToString()
                    Dim totalQuantity As Integer = Convert.ToInt32(reader("total_quantity"))
                    series.Points.AddXY(foodName, totalQuantity)
                End While

                ' Add a title to the chart
                Chart2.Titles.Add("Top Selling Products (Last 10)")
                Chart2.ChartAreas(0).AxisX.Title = "Food Items"
                Chart2.ChartAreas(0).AxisY.Title = "Total Quantity Sold"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading top-selling products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Method to load daily sales data into Chart1
    Private Sub LoadDailySalesTrend()
        Try
            ' Initialize connection and query
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                Dim query As String = "SELECT DATE(transdate) AS sale_date, SUM(totalprice) AS daily_sales " &
                                      "FROM tbl_pos " &
                                      "WHERE transdate >= CURDATE() - INTERVAL 7 DAY " &
                                      "GROUP BY sale_date " &
                                      "ORDER BY sale_date;"

                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet()
                adapter.Fill(ds, "DailySales")

                ' Check if there is data to display
                If ds.Tables("DailySales").Rows.Count > 0 Then
                    ' Configure the chart
                    Chart1.Series.Clear()
                    Chart1.Series.Add("Sales")
                    Chart1.Series("Sales").ChartType = SeriesChartType.Column ' Change to Line if you prefer a line chart
                    Chart1.Series("Sales").XValueType = ChartValueType.Date

                    ' Bind data to the chart
                    For Each row As DataRow In ds.Tables("DailySales").Rows
                        Dim saleDate As Date = Convert.ToDateTime(row("sale_date"))
                        Dim dailySales As Decimal = Convert.ToDecimal(row("daily_sales"))
                        Chart1.Series("Sales").Points.AddXY(saleDate.ToString("MM/dd/yyyy"), dailySales)
                    Next

                    ' Set chart title and axis labels
                    Chart1.Titles.Clear()
                    Chart1.Titles.Add("Daily Sales (Last 7 Days)")
                    Chart1.ChartAreas(0).AxisX.Title = "Date"
                    Chart1.ChartAreas(0).AxisY.Title = "Total Sales"
                    Chart1.ChartAreas(0).AxisX.Interval = 1
                Else
                    ' If no data, clear the chart and show a message
                    Chart1.Series.Clear()
                    MsgBox("No sales data available for the last 7 days.", MsgBoxStyle.Information, "No Data")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error loading daily sales trend: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub DisplayDailySales()
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        Using conn As New MySqlConnection(ConnectionString) ' Create new connection using ConnectionString
            Try
                ' Open the database connection
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Define the start and end of the current day
                Dim todayStart As String = Date.Now.ToString("yyyy-MM-dd 00:00:00")
                Dim todayEnd As String = Date.Now.ToString("yyyy-MM-dd 23:59:59")

                ' SQL query to calculate the total daily sales
                Dim cmd As New MySqlCommand("SELECT IFNULL(SUM(`totalprice`), 0) FROM `tbl_pos` WHERE `transdate` BETWEEN @todayStart AND @todayEnd", conn)
                cmd.Parameters.AddWithValue("@todayStart", todayStart)
                cmd.Parameters.AddWithValue("@todayEnd", todayEnd)

                ' Execute the query and get the total daily sales
                Dim dailyTotal As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())

                ' Format the total and display it in the label
                lbldailysales.Text = "₱" & FormatNumber(dailyTotal, 2)

            Catch ex As Exception
                ' Handle any errors
                MsgBox("Error fetching daily sales: " & ex.Message, vbCritical, "Error")
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub
    Private Sub DisplayTotalProducts()
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        Using conn As New MySqlConnection(ConnectionString) ' Create new connection using ConnectionString
            Try
                ' Open the database connection
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' SQL query to count the total number of rows in tbl_food
                Dim cmd As New MySqlCommand("SELECT COUNT(`ID`) FROM `tbl_food`", conn)

                ' Execute the query and get the total number of products
                Dim totalProducts As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Display the total number of products in the label
                lbltotalproducts.Text = totalProducts.ToString()

            Catch ex As Exception
                ' Handle any errors
                MsgBox("Error fetching total products: " & ex.Message, vbCritical, "Error")
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub
    Private Sub LoadTotalProductsSold()
        Dim totalSold As Integer = 0
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        Try
            ' Create new connection using the ConnectionString
            Using conn As New MySqlConnection(ConnectionString)
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' SQL query to get total products sold today, using transdate format
                Dim cmd As New MySqlCommand("SELECT SUM(qty) AS total_sold FROM tbl_pos WHERE DATE_FORMAT(transdate, '%Y-%m-%d') = CURDATE()", conn)

                ' Execute the query and retrieve the result
                Dim result As Object = cmd.ExecuteScalar()

                ' If the result is not null, assign it to totalSold
                If result IsNot DBNull.Value Then
                    totalSold = Convert.ToInt32(result)
                End If

                ' Display the result in lblTotalProductSold
                lbltotalproductsold.Text = totalSold.ToString()
            End Using

        Catch ex As Exception
            MsgBox("Error loading total products sold: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class