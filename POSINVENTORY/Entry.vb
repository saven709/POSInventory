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
        DataGridView1.Columns.Add("No", "No")
        DataGridView1.Columns.Add("Name", "Item Name")
        DataGridView1.Columns.Add("ItemCode", "Item Code")  ' New column for item code
        DataGridView1.Columns.Add("MeasurementName", "Measurement")  ' Added column for measurementname
        DataGridView1.Columns.Add("Category", "Category")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Date", "Date")
        DataGridView1.Columns.Add("Time", "Time")
        DataGridView1.Columns.Add("Username", "Added By")

        ' Set column properties
        DataGridView1.Columns("No").Width = 50
        DataGridView1.Columns("Name").Width = 200
        DataGridView1.Columns("ItemCode").Width = 100  ' Adjust width for ItemCode
        DataGridView1.Columns("MeasurementName").Width = 150  ' Adjust width for MeasurementName
        DataGridView1.Columns("Category").Width = 150
        DataGridView1.Columns("Quantity").Width = 100
        DataGridView1.Columns("Date").Width = 100
        DataGridView1.Columns("Time").Width = 100
        DataGridView1.Columns("Username").Width = 150

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

    Private Sub LoadInventory()
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

        ' Load data into DataGridView
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

End Class