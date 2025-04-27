Imports MySql.Data.MySqlClient

Public Class Adjustment

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then ' Ensure a valid row is selected
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Create an instance of editadjustment form
            Dim editForm As New editadjustment()

            ' Pass data to the editadjustment form
            editForm.txt_itemcode.Text = selectedRow.Cells("ItemCode").Value.ToString()
            editForm.txt_name.Text = selectedRow.Cells("Name").Value.ToString()
            editForm.txt_quantity.Text = selectedRow.Cells("Quantity").Value.ToString()
            editForm.txt_desc.Text = selectedRow.Cells("Desc").Value.ToString()

            ' Also pass the last quantity value to the label
            editForm.lbl_lastquantity.Text = selectedRow.Cells("Quantity").Value.ToString()

            ' Show the editadjustment form as a dialog
            editForm.ShowDialog()
        End If
    End Sub

    Private Sub InitializeDataGridView()
        ' Configure DataGridView layout and columns
        DataGridView1.RowTemplate.Height = 30
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("Name", "Item Name")
        DataGridView1.Columns.Add("ItemCode", "Item Code")
        DataGridView1.Columns.Add("LastQuantity", "Last QTY")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Waste", "Waste")  ' New Waste column
        DataGridView1.Columns.Add("Desc", "Description")
        DataGridView1.Columns.Add("AdjustBy", "Adjusted By")
        DataGridView1.Columns.Add("AdjustDate", "Adjust Date")
        DataGridView1.Columns.Add("AdjustTime", "Adjust Time")

        ' Set column properties
        DataGridView1.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("ItemCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("LastQuantity").Width = 65
        DataGridView1.Columns("Quantity").Width = 60
        DataGridView1.Columns("Waste").Width = 50
        DataGridView1.Columns("Desc").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("AdjustBy").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("AdjustDate").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("AdjustTime").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Center text in the "Quantity" column
        DataGridView1.Columns("LastQuantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Waste").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Hide the No and ItemCode columns if necessary
        DataGridView1.Columns("ItemCode").Visible = False
        DataGridView1.Columns("No").Visible = False

        ' Set DataGridView properties
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ReadOnly = True
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub LoadAdjustments()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query data from tbl_inventoryad
            Dim cmd As New MySqlCommand("SELECT `itemcode`, `name`, `lastquantity`, `quantity`, `waste`, `desc`, `adjustby`, `adjustdate`, `adjusttime` FROM `tbl_inventoryad`", conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            DataGridView1.Rows.Clear()
            Dim rowIndex As Integer = 1

            While dr.Read()
                ' Add data from tbl_inventoryad to the DataGridView
                Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add(
                rowIndex,
                dr("name").ToString(),
                dr("itemcode").ToString(),
                dr("lastquantity").ToString(),
                dr("quantity").ToString(),
                dr("waste").ToString(),
                dr("desc").ToString(),
                dr("adjustby").ToString(),
                dr("adjustdate").ToString(),
                dr("adjusttime").ToString()
            ))

                ' Check if quantity is less than 51 and color the row red
                Dim quantity As Integer
                If Integer.TryParse(dr("quantity").ToString(), quantity) AndAlso quantity < 51 Then
                    newRow.DefaultCellStyle.BackColor = Color.Red
                    newRow.DefaultCellStyle.ForeColor = Color.White  ' Make text white for better readability
                End If

                rowIndex += 1
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading adjustments: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Adjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        ' Initialize DataGridView structure
        InitializeDataGridView()

        ' Load data into DataGridView
        LoadAdjustments()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        If DataGridView1.Columns.Count = 0 Then
            InitializeDataGridView()
        End If

        Dim ConnectionString As String = "server=localhost;port=3307;user=root;password=;database=brewtopia_db"

        Using conn As New MySqlConnection(ConnectionString)
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim cmd As New MySqlCommand("SELECT `itemcode`, `name`, `lastquantity`, `quantity`, `waste`, `desc`, `adjustby`, `adjustdate`, `adjusttime` FROM `tbl_inventoryad` WHERE `name` LIKE @search OR `itemcode` LIKE @search OR `desc` LIKE @search", conn)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")

                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                Dim rowIndex As Integer = 1
                While dr.Read()
                    Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add(
                    rowIndex,
                    dr("name").ToString(),
                    dr("itemcode").ToString(),
                    dr("lastquantity").ToString(),
                    dr("quantity").ToString(),
                    dr("waste").ToString(),
                    dr("desc").ToString(),
                    dr("adjustby").ToString(),
                    dr("adjustdate").ToString(),
                    dr("adjusttime").ToString()
                ))

                    ' Check if quantity is less than 11 and color the row red
                    Dim quantity As Integer
                    If Integer.TryParse(dr("quantity").ToString(), quantity) AndAlso quantity < 11 Then
                        newRow.DefaultCellStyle.BackColor = Color.Red
                        newRow.DefaultCellStyle.ForeColor = Color.White  ' Make text white for better readability
                    End If

                    rowIndex += 1
                End While
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

End Class