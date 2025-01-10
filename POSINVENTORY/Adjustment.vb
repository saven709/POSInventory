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
        DataGridView1.Columns.Add("ItemCode", "Item Code")  ' Item Code column
        DataGridView1.Columns.Add("LastQuantity", "Last Quantity")  ' Added column for Last Quantity
        DataGridView1.Columns.Add("Quantity", "Quantity")  ' Existing column for Quantity
        DataGridView1.Columns.Add("Desc", "Description")  ' Added column for Description
        DataGridView1.Columns.Add("AdjustBy", "Adjusted By")  ' Added column for Adjusted By
        DataGridView1.Columns.Add("AdjustDate", "Adjust Date")  ' Added column for Adjust Date
        DataGridView1.Columns.Add("AdjustTime", "Adjust Time")  ' Added column for Adjust Time

        ' Set column properties
        DataGridView1.Columns("No").Width = 50
        DataGridView1.Columns("Name").Width = 200
        DataGridView1.Columns("ItemCode").Width = 100
        DataGridView1.Columns("LastQuantity").Width = 100  ' Adjust width for Last Quantity
        DataGridView1.Columns("Quantity").Width = 100
        DataGridView1.Columns("Desc").Width = 150
        DataGridView1.Columns("AdjustBy").Width = 150
        DataGridView1.Columns("AdjustDate").Width = 100
        DataGridView1.Columns("AdjustTime").Width = 100

        ' Hide the No and ItemCode columns if necessary
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

    Private Sub LoadAdjustments()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query data from tbl_inventoryad
            ' Include lastquantity in the SELECT query
            Dim cmd As New MySqlCommand("SELECT `itemcode`, `name`, `lastquantity`, `quantity`, `desc`, `adjustby`, `adjustdate`, `adjusttime` FROM `tbl_inventoryad`", conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            DataGridView1.Rows.Clear()
            Dim rowIndex As Integer = 1

            While dr.Read()
                ' Add data from tbl_inventoryad to the DataGridView
                ' Include lastquantity in the row data
                DataGridView1.Rows.Add(
            rowIndex,
            dr("name").ToString(),
            dr("itemcode").ToString(),
            dr("lastquantity").ToString(),  ' Last quantity from database
            dr("quantity").ToString(),
            dr("desc").ToString(),
            dr("adjustby").ToString(),
            dr("adjustdate").ToString(),
            dr("adjusttime").ToString()
        )
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
End Class