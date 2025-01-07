Imports MySql.Data.MySqlClient
Public Class formingredients
    Private _foodCode As String  ' Private field to store the food code

    ' Add a property to set the food code
    Public WriteOnly Property FoodCode As String
        Set(value As String)
            _foodCode = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Add a method to initialize the form with data
    Public Sub LoadFormData()
        LoadIngredients()
    End Sub

    Private Sub LoadIngredients()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT label, quantity FROM tbl_ingredients WHERE foodcode = @foodcode", conn)
            cmd.Parameters.AddWithValue("@foodcode", _foodCode)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Clear the existing rows
            DataGridView1.Rows.Clear()

            ' Add rows to DataGridView
            While dr.Read()
                DataGridView1.Rows.Add(dr("label").ToString(), dr("quantity").ToString())
            End While
        Catch ex As Exception
            'MsgBox("Error loading ingredients: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If String.IsNullOrEmpty(txtlabel.Text) OrElse String.IsNullOrEmpty(txtquantity.Text) Then
            MsgBox("Please enter both label and quantity!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO tbl_ingredients (foodcode, label, quantity) VALUES (@foodcode, @label, @quantity)", conn)
            cmd.Parameters.AddWithValue("@foodcode", _foodCode)
            cmd.Parameters.AddWithValue("@label", txtlabel.Text)
            cmd.Parameters.AddWithValue("@quantity", txtquantity.Text)
            cmd.ExecuteNonQuery()

            ' Clear input fields
            txtlabel.Clear()
            txtquantity.Clear()

            ' Reload ingredients in DataGridView
            dbconn()
            List.Load_Foods()
            LoadIngredients()

            MsgBox("Ingredient added successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Check if a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please select an ingredient to delete!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

        ' Retrieve the label from the corresponding column of the selected row
        Dim label As String = selectedRow.Cells("label").Value.ToString()

        ' Confirm with the user before deletion
        If MsgBox("Are you sure you want to delete this ingredient?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                ' Open the database connection
                conn.Open()

                ' Prepare the SQL command to delete the ingredient
                Dim cmd As New MySqlCommand("DELETE FROM tbl_ingredients WHERE foodcode = @foodcode AND label = @label", conn)
                cmd.Parameters.AddWithValue("@foodcode", _foodCode) ' Ensure _foodCode is defined in your form
                cmd.Parameters.AddWithValue("@label", label)

                ' Execute the delete command
                cmd.ExecuteNonQuery()

                ' Reload the ingredients into the DataGridView
                dbconn()
                List.Load_Foods()
                LoadIngredients()

                ' Inform the user of the success
                MsgBox("Ingredient deleted successfully!", MsgBoxStyle.Information)
            Catch ex As Exception
                ' Inform the user of any errors
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                ' Close the database connection
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        btn_delete.Enabled = DataGridView1.SelectedRows.Count > 0
    End Sub
End Class