Imports System.IO
Imports MySql.Data.MySqlClient
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
        DataGridView1.Columns.Add("MeasurementName", "Measurement Name")  ' Added column for measurementname
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
            conn.Open()
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
            conn.Close()
        End Try
    End Sub


    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        ' Initialize DataGridView structure
        InitializeDataGridView()

        ' Load data into DataGridView
        LoadInventory()
    End Sub

End Class