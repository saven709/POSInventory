Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frm_ManageFoods
    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox3.Text = ofd.FileName
            GunaCirclePictureBox1.Image = Image.FromFile(TextBox3.Text)
        End If
    End Sub

    Private Sub frm_ManageFoods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_foodcode()
    End Sub
    Sub auto_foodcode()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_food` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_foodcode.Text = dr.Item("foodcode").ToString + 1

            Else
                txt_foodcode.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub clear()
        txt_foodname.Clear()
        'txt_size.Clear()
        GunaCirclePictureBox1.Image = Nothing
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_food`(`foodcode`, `foodname`, `img`, `category`) VALUES (@foodcode, @foodname, @img, @category)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
            cmd.Parameters.AddWithValue("@foodname", txt_foodname.Text)
            cmd.Parameters.AddWithValue("@category", txt_category.Text) ' Add category parameter

            ' Check if an image is selected in GunaCirclePictureBox1
            If GunaCirclePictureBox1.Image IsNot Nothing Then
                ' Use the selected image
                Dim mstream As New System.IO.MemoryStream
                GunaCirclePictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                mstream.Close()
                cmd.Parameters.AddWithValue("@img", picture)
            Else
                ' Use a default placeholder image if no image is provided
                Dim defaultImagePath As String = Application.StartupPath & "\placeholder.jpg" ' Path to your default image
                Dim defaultImage As Image = Image.FromFile(defaultImagePath)
                Dim mstream As New System.IO.MemoryStream
                defaultImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                mstream.Close()
                cmd.Parameters.AddWithValue("@img", picture)
            End If

            Dim i As Integer
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New Food Save Successfully!", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning: Food Save Failed!", vbCritical, "FAST FOOD")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        clear()
        auto_foodcode()
        ' Auto click the btnList (assuming it's the button you want to trigger)
        Form1.btnList.PerformClick() ' Simulates a click on the btnList button
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_food` SET `foodname`=@foodname,`price`=@price,`img`=@img WHERE `foodcode`=@foodcode", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@foodname", txt_foodname.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            GunaCirclePictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Food Edit Successfully !", vbInformation, "FAST FOOD")
            Else
                MsgBox("Warning : Food Edit Failed !", vbCritical, "FAST FOOD")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        auto_foodcode()
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you Sure Delete this Food Product !", vbQuestion + vbYesNo, "Brewtopia") = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tbl_food` WHERE `foodcode`=@foodcode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@foodcode", txt_foodcode.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Food Delete Successfully !", vbInformation, "FAST FOOD")
                Else
                    MsgBox("Warning : Food Delete Failed !", vbCritical, "FAST FOOD")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            clear()
            auto_foodcode()
        Else
            Return

        End If

    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_food` WHERE `foodcode`=@foodcode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txt_found.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim foodcode As String = dr.Item("foodcode")
                Dim foodname As String = dr.Item("foodname")
                'Dim price As Decimal = dr.Item("price")

                txt_foodcode.Text = foodcode
                txt_foodname.Text = foodname
                'txt_price.Text = price
                Dim bytes As [Byte]() = dr.Item("img")
                Dim ms As New MemoryStream(bytes)
                GunaCirclePictureBox1.Image = Image.FromStream(ms)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()
        List.Load_Foods()
    End Sub
End Class