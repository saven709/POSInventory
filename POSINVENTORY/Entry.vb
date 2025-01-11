Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Entry

    Private Sub btn_ManageFoods_Click(sender As Object, e As EventArgs) Handles btn_ManageFoods.Click
        frmitem.ShowDialog()
    End Sub
    Private Sub InitializeDataGridView()
        ' Configure DataGridView layout and columns
        DataGridView1.RowTemplate.Height = 30
        DataGridView1.Columns.Clear()

        ' Define the columns in the DataGridView
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("Name", "Item Name")
        DataGridView1.Columns.Add("ItemCode", "Item Code")
        DataGridView1.Columns.Add("MeasurementName", "Measurement")
        DataGridView1.Columns.Add("Category", "Category")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Date", "Date")
        DataGridView1.Columns.Add("Time", "Time")
        DataGridView1.Columns.Add("Username", "Added By")

        DataGridView1.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("ItemCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("MeasurementName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Category").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Date").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Time").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("Username").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Hide the ItemCode column if necessary
        DataGridView1.Columns("ItemCode").Visible = False
        DataGridView1.Columns("No").Visible = False

        ' Set DataGridView properties
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Public Sub LoadInventory()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Include measurementname in the SELECT query
            Dim cmd As New MySqlCommand("SELECT `name`, `itemcode`, `measurementname`, `category`, `quantity`, `stockdate`, `stocktime`, `stockby` FROM `tbl_inventory`", conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            DataGridView1.Rows.Clear()
            Dim rowIndex As Integer = 1

            While dr.Read()
                ' Add measurementname to the DataGridView row data
                DataGridView1.Rows.Add(
                rowIndex,
                dr("name").ToString(),
                dr("itemcode").ToString(),
                dr("measurementname").ToString(),  ' Add measurementname here
                dr("category").ToString(),
                dr("quantity").ToString(),
                dr("stockdate").ToString(),
                dr("stocktime").ToString(),
                dr("stockby").ToString()
            )
                rowIndex += 1
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading inventory: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        ' Initialize DataGridView structure
        InitializeDataGridView()

        ' Load data into DataGridView on form load
        LoadInventory()
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            ' Check if a row is selected
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the itemcode and item name of the selected row
                Dim itemcode As String = DataGridView1.SelectedRows(0).Cells("ItemCode").Value.ToString()
                Dim itemName As String = DataGridView1.SelectedRows(0).Cells("Name").Value.ToString()

                ' Confirm deletion, include the item name in the message
                If MessageBox.Show("Are you sure you want to delete the item: " & itemName & "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    ' Open database connection
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Begin transaction to ensure both deletions happen together
                    Dim transaction As MySqlTransaction = conn.BeginTransaction()

                    Try
                        ' Delete from tbl_inventory
                        Dim cmd1 As New MySqlCommand("DELETE FROM `tbl_inventory` WHERE `itemcode` = @itemcode", conn, transaction)
                        cmd1.Parameters.AddWithValue("@itemcode", itemcode)

                        ' Execute the query
                        Dim result1 As Integer = cmd1.ExecuteNonQuery()

                        ' Delete from tbl_inventoryad
                        Dim cmd2 As New MySqlCommand("DELETE FROM `tbl_inventoryad` WHERE `itemcode` = @itemcode", conn, transaction)
                        cmd2.Parameters.AddWithValue("@itemcode", itemcode)

                        ' Execute the query
                        Dim result2 As Integer = cmd2.ExecuteNonQuery()

                        ' If both deletions were successful, commit the transaction
                        If result1 > 0 And result2 > 0 Then
                            transaction.Commit()
                            MsgBox("Item deleted successfully from both tables!", vbInformation, "Deletion Successful")
                            ' Refresh the DataGridView to reflect the change
                            LoadInventory()
                        Else
                            ' If any of the deletions failed, rollback the transaction
                            transaction.Rollback()
                            MsgBox("Failed to delete item from one or both tables.", vbCritical, "Error")
                        End If
                    Catch ex As Exception
                        ' If an error occurred, rollback the transaction
                        transaction.Rollback()
                        MsgBox("Error occurred while deleting item: " & ex.Message, vbCritical, "Error")
                    End Try

                    ' Close the connection
                    If conn.State = ConnectionState.Open Then conn.Close()
                End If
            Else
                MsgBox("Please select a row to delete.", vbExclamation, "No Selection")
            End If
        Catch ex As Exception
            MsgBox("Error deleting item: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date1.Text = Date.Now.ToString("ddd, dd-MM-yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ' Clear existing rows in DataGridView1
        DataGridView1.Rows.Clear()

        ' Ensure the DataGridView columns are initialized
        If DataGridView1.Columns.Count = 0 Then
            InitializeDataGridView()  ' Initialize columns if not done already
        End If

        ' Define the connection string
        Dim ConnectionString As String = "server=localhost;user=root;password=;database=brewtopia_db"

        ' Use the connection string inside a Using statement
        Using conn As New MySqlConnection(ConnectionString)
            Try
                ' Open the connection if it's not already open
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Query to search for items by name, itemcode, measurementname, or category
                Dim cmd As New MySqlCommand("SELECT `name`, `itemcode`, `measurementname`, `category`, `quantity`, `stockdate`, `stocktime`, `stockby` FROM `tbl_inventory` WHERE name LIKE @search OR itemcode LIKE @search OR measurementname LIKE @search OR category LIKE @search", conn)
                cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")

                ' Execute the command and fetch the data
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                ' Loop through the records and populate the DataGridView
                While dr.Read()
                    ' Add each record to the DataGridView
                    DataGridView1.Rows.Add(
                    DataGridView1.Rows.Count + 1,  ' Auto-increment No column
                    dr("name").ToString(),
                    dr("itemcode").ToString(),
                    dr("measurementname").ToString(),
                    dr("category").ToString(),
                    dr("quantity").ToString(),
                    dr("stockdate").ToString(),
                    dr("stocktime").ToString(),
                    dr("stockby").ToString()
                )
                End While
            Catch ex As Exception
                ' Handle exception if needed
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

End Class