Imports MySql.Data.MySqlClient

Public Class EditForm
    Public Property FoodCode As String

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFoodDetails()
        LoadSizes()

    End Sub
    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            GunaLabel1.Text = ofd.FileName
            GunaCirclePictureBox1.Image = Image.FromFile(GunaLabel1.Text)
        End If
    End Sub

    ' Load Food details (foodname) based on the foodcode
    Private Sub LoadFoodDetails()
        Try
            conn.Open()
            ' Fetch the food name and image data from the tbl_food
            Dim cmd As New MySqlCommand("SELECT foodcode, foodname, img FROM tbl_food WHERE foodcode = @foodcode", conn)
            cmd.Parameters.AddWithValue("@foodcode", FoodCode)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Load foodname
                TextBox3.Text = dr("foodcode").ToString()
                txtFoodName.Text = dr("foodname").ToString()

                ' Load image
                If dr("img") IsNot DBNull.Value Then
                    Dim imgData As Byte() = CType(dr("img"), Byte())
                    Dim ms As New System.IO.MemoryStream(imgData)
                    GunaCirclePictureBox1.Image = Image.FromStream(ms)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error loading food details: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Load sizes and prices into DataGridView
    Private Sub LoadSizes()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT size_name, price FROM tbl_food_sizes WHERE foodcode = @foodcode", conn)
            cmd.Parameters.AddWithValue("@foodcode", FoodCode)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Clear the existing rows
            DataGridView1.Rows.Clear()

            ' Add rows to DataGridView
            While dr.Read()
                DataGridView1.Rows.Add(dr("size_name").ToString(), dr("price").ToString())
            End While
        Catch ex As Exception
            'MsgBox("Error loading sizes: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Save changes to food details
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            ' Update the food details (foodname and img) in tbl_food
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_food` SET `foodname`=@foodname, `img`=@img WHERE `foodcode`=@foodcode", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@foodname", txtFoodName.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            GunaCirclePictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            cmd.Parameters.AddWithValue("@foodcode", FoodCode)  ' Ensure foodcode is passed for the update

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Food Edit Successfully!", vbInformation, "BREWTOPIA")
            Else
                MsgBox("Warning: Food Edit Failed!", vbCritical, "BREWTOPIA")
            End If

            ' Now, handle saving the sizes to tbl_food_sizes (size_name, price, ingredients)
            If Not String.IsNullOrEmpty(txtnamesize.Text) AndAlso Not String.IsNullOrEmpty(txtPrice.Text) Then
                Dim cmdSize As New MySqlCommand("INSERT INTO tbl_food_sizes (foodcode, size_name, price) VALUES (@foodcode, @size_name, @price)", conn)
                cmdSize.Parameters.Clear()
                cmdSize.Parameters.AddWithValue("@foodcode", FoodCode)
                cmdSize.Parameters.AddWithValue("@size_name", txtnamesize.Text)
                cmdSize.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))

                cmdSize.ExecuteNonQuery()

                MsgBox("Size added successfully!", vbInformation, "BREWTOPIA")

                ' Optionally, refresh the DataGridView or update sizes list after insertion
                dbconn()
                List.Load_Foods()
                LoadSizes()
            End If

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        ' Auto click the btnList (assuming it's the button you want to trigger)
        Form1.btnList.PerformClick()  ' Simulates a click on the btnList button
    End Sub
    ' Add new size to the food item
    Private Sub btnAddSize_Click(sender As Object, e As EventArgs) Handles btn_addsize.Click
        If String.IsNullOrEmpty(txtnamesize.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MsgBox("Please enter both size name and price!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO tbl_food_sizes (foodcode, size_name, price) VALUES (@foodcode, @size_name, @price)", conn)
            cmd.Parameters.AddWithValue("@foodcode", FoodCode)
            cmd.Parameters.AddWithValue("@size_name", txtnamesize.Text)
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
            cmd.ExecuteNonQuery()

            ' Clear input fields
            txtnamesize.Clear()
            txtPrice.Clear()

            ' Reload sizes in DataGridView
            LoadSizes()

            MsgBox("Size added successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Delete selected size from DataGridView
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Check if a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please select a size to delete!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

        ' Retrieve the size_name from the first column of the selected row
        Dim sizeName As String = selectedRow.Cells("size_name").Value.ToString()

        ' Confirm with the user before deletion
        If MsgBox("Are you sure you want to delete this size?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                conn.Open()
                ' Prepare the SQL command to delete the size
                Dim cmd As New MySqlCommand("DELETE FROM tbl_food_sizes WHERE foodcode = @foodcode AND size_name = @size_name", conn)
                cmd.Parameters.AddWithValue("@foodcode", FoodCode)
                cmd.Parameters.AddWithValue("@size_name", sizeName)

                ' Execute the delete command
                cmd.ExecuteNonQuery()

                ' Reload the sizes into the DataGridView
                dbconn()
                List.Load_Foods()
                LoadSizes()

                ' Inform the user of the success
                MsgBox("Size deleted successfully!", MsgBoxStyle.Information)
            Catch ex As Exception
                'MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
            ' Auto click the btnList (assuming it's the button you want to trigger)
            Form1.btnList.PerformClick()  ' Simulates a click on the btnList button
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        ' Enable the delete button if a row is selected
        btn_delete.Enabled = DataGridView1.SelectedRows.Count > 0
    End Sub

    Private Sub btnDeletion_Click(sender As Object, e As EventArgs) Handles btndeletion.Click
        ' Ensure that the user has selected a food item to delete
        If String.IsNullOrEmpty(FoodCode) Then
            MsgBox("No food item selected to delete!", MsgBoxStyle.Exclamation, "BREWTOPIA")
            Return
        End If

        ' Confirm the deletion with the user
        If MsgBox("Are you sure you want to delete this food item and all associated sizes?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                conn.Open()

                ' Delete from tbl_food_sizes (sizes associated with the food item)
                Dim cmdSizes As New MySqlCommand("DELETE FROM tbl_food_sizes WHERE foodcode = @foodcode", conn)
                cmdSizes.Parameters.AddWithValue("@foodcode", FoodCode)
                cmdSizes.ExecuteNonQuery()

                ' Delete from tbl_food (the food item itself)
                Dim cmdFood As New MySqlCommand("DELETE FROM tbl_food WHERE foodcode = @foodcode", conn)
                cmdFood.Parameters.AddWithValue("@foodcode", FoodCode)
                cmdFood.ExecuteNonQuery()

                MsgBox("Food item and associated sizes deleted successfully!", vbInformation, "BREWTOPIA")

                ' Refresh the UI or reload the list of foods
                List.Load_Foods()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "BREWTOPIA")
            Finally
                conn.Close()
            End Try
            ' Auto click the btnList (assuming it's the button you want to trigger)
            Form1.btnList.PerformClick()  ' Simulates a click on the btnList button
            Me.Close()
        End If
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmIngredients As New formingredients()
        frmIngredients.FoodCode = Me.FoodCode  ' Pass the FoodCode to the ingredients form
        frmIngredients.LoadFormData()  ' Initialize the form with data
        frmIngredients.Show()
    End Sub
End Class
