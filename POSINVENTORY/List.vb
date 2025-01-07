Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class List
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodname As Label
    Private WithEvents img As CirclePicturBox

    Private Sub btn_ManageFoods_Click(sender As Object, e As EventArgs) Handles btn_ManageFoods.Click
        frm_ManageFoods.ShowDialog()
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_Foods()
    End Sub

    Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT img, foodcode, foodname FROM tbl_food", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Load_controls()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))
        Dim foodCode As String = dr.Item("foodcode").ToString

        ' Panel
        pan = New Panel
        With pan
            FlowLayoutPanel1.Padding = New Padding(5)
            .Width = 150
            .Height = 180
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = foodCode
        End With

        ' Food Image
        img = New CirclePicturBox
        With img
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = foodCode
        End With

        ' Food Name
        foodname = New Label
        With foodname
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = foodCode
            .Text = " Name  : " & dr.Item("foodname").ToString
        End With

        ' Edit Button
        Dim btnEdit As New Button
        With btnEdit
            .Text = "Edit"
            .Width = 50
            .Height = 30
            .Dock = DockStyle.Bottom
            .BackColor = Color.FromArgb(197, 187, 179)
            .ForeColor = Color.Black
            .Tag = foodCode
            AddHandler .Click, AddressOf ButtonEdit_Click
        End With

        ' Assigning food image
        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        img.BackgroundImage = bitmap

        ' Adding controls to panel in correct order
        pan.Controls.Add(btnEdit)        ' Bottom
        pan.Controls.Add(foodname)       ' Above sizes
        pan.Controls.Add(img)            ' Top

        FlowLayoutPanel1.Controls.Add(pan)

        ' Adding click events
        AddHandler foodname.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs)
        Dim foodCode As String = sender.Tag.ToString

        Dim editForm As New EditForm()
        editForm.FoodCode = foodCode
        If editForm.ShowDialog() = DialogResult.OK Then
            Load_Foods()
        End If
    End Sub

    Private Sub Selectimg_Click(sender As Object, e As EventArgs)
        ' Handle image or panel click events if necessary.
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT img, foodcode, foodname FROM tbl_food WHERE foodcode LIKE @search OR foodname LIKE @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            ' Handle exception silently
        Finally
            conn.Close()
        End Try
    End Sub
End Class