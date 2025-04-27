Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class List
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodname As Label
    Private WithEvents img As CirclePicturBox
    Private WithEvents btnEdit As Button

    ' Add categories list and current index
    Private categories As List(Of String) = New List(Of String)
    Private currentCategoryIndex As Integer = -1

    Private Sub btn_ManageFoods_Click(sender As Object, e As EventArgs) Handles btn_ManageFoods.Click
        frm_ManageFoods.ShowDialog()
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        LoadCategories()
        categorybtn.Text = categories(0)

        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(categorybtn, "Click to switch category")

        SetupHoverTimer() ' Add this line
        Load_Foods()
    End Sub
    Public Class CirclePicturBox
        Inherits PictureBox

        Private isHovering As Boolean = False
        Private originalSize As Size
        Private originalLocation As Point

        Public Sub New()
            Me.BackColor = Color.Transparent
            Me.Size = New Size(120, 120)
            ' Set the image layout mode to zoom to help with centering
            Me.SizeMode = PictureBoxSizeMode.Zoom
        End Sub

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            Try
                ' Create a new bitmap for drawing
                Using outputImage As New Bitmap(Me.Width, Me.Height)
                    Using g As Graphics = Graphics.FromImage(outputImage)
                        ' Set up the graphics object for smooth drawing
                        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

                        ' Fill the background with transparent color
                        g.Clear(Color.Transparent)

                        ' Create the circular path - use slightly smaller dimensions to ensure it fits
                        Using path As New GraphicsPath()
                            Dim diameter As Integer = CInt(Math.Min(Me.Width, Me.Height) - 2)
                            Dim x As Integer = CInt((Me.Width - diameter) / 2)
                            Dim y As Integer = CInt((Me.Height - diameter) / 2)
                            path.AddEllipse(x, y, diameter, diameter)

                            ' If we're hovering, draw a glow effect first
                            If isHovering Then
                                Using glowBrush As New SolidBrush(Color.FromArgb(100, 255, 255, 255))
                                    Using outerPath As New GraphicsPath()
                                        outerPath.AddEllipse(CInt(x - 3), CInt(y - 3), CInt(diameter + 6), CInt(diameter + 6))
                                        g.FillPath(glowBrush, outerPath)
                                    End Using
                                End Using
                            End If

                            ' Fill the circle with the background image if it exists
                            If Me.BackgroundImage IsNot Nothing Then
                                ' Calculate scaling to properly center and fit the image in the circle
                                Dim imgWidth As Integer = Me.BackgroundImage.Width
                                Dim imgHeight As Integer = Me.BackgroundImage.Height

                                ' Calculate the scale factor to fit the image inside the circle
                                Dim scaleFactor As Double = Math.Max(diameter / imgWidth, diameter / imgHeight)
                                Dim scaledWidth As Integer = CInt(imgWidth * scaleFactor)
                                Dim scaledHeight As Integer = CInt(imgHeight * scaleFactor)

                                ' Calculate the position to center the image
                                Dim imgX As Integer = x + (diameter - scaledWidth) / 2
                                Dim imgY As Integer = y + (diameter - scaledHeight) / 2

                                ' Create a temporary bitmap with the scaled image
                                Using scaledImage As New Bitmap(Me.BackgroundImage, scaledWidth, scaledHeight)
                                    ' Create a texture brush from the scaled image
                                    Using textureBrush As New TextureBrush(scaledImage)
                                        ' Set the texture brush origin to center the image
                                        textureBrush.TranslateTransform(imgX, imgY)
                                        g.FillPath(textureBrush, path)
                                    End Using
                                End Using
                            Else
                                ' If no image, just fill with a color
                                g.FillPath(New SolidBrush(Color.DarkGray), path)
                            End If

                            ' Draw border
                            Using pen As New Pen(Color.FromArgb(60, 255, 255, 255), 1.5F)
                                g.DrawPath(pen, path)
                            End Using
                        End Using
                    End Using

                    ' Draw the final image to the screen
                    pe.Graphics.DrawImage(outputImage, 0, 0)
                End Using
            Catch ex As Exception
                ' If an error occurs, just draw a simple circle
                Try
                    pe.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    pe.Graphics.FillEllipse(Brushes.DarkGray, 1, 1, Width - 3, Height - 3)
                    pe.Graphics.DrawEllipse(Pens.LightGray, 1, 1, Width - 3, Height - 3)
                Catch
                    ' If even the fallback fails, just ignore it
                End Try
            End Try
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)

            Try
                ' Store original size and location
                originalSize = Me.Size
                originalLocation = Me.Location

                ' Calculate new size (7% larger)
                Dim growFactor As Double = 1.07
                Dim newWidth As Integer = CInt(Me.Width * growFactor)
                Dim newHeight As Integer = CInt(Me.Height * growFactor)

                ' Calculate position adjustment to keep image centered
                Dim xOffset As Integer = (newWidth - Me.Width) \ 2
                Dim yOffset As Integer = (newHeight - Me.Height) \ 2

                ' Set new size and position
                Me.SuspendLayout()
                Me.Size = New Size(newWidth, newHeight)
                Me.Location = New Point(Me.Location.X - xOffset, Me.Location.Y - yOffset)
                Me.ResumeLayout()

                isHovering = True
                Me.Invalidate()  ' Redraw with hover effect
            Catch ex As Exception
                ' If resizing fails, just show the hover effect without size change
                isHovering = True
                Me.Invalidate()
            End Try
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)

            Try
                ' Reset to original size and position if we have stored values
                If Not originalSize.IsEmpty Then
                    Me.SuspendLayout()
                    Me.Size = originalSize
                    Me.Location = originalLocation
                    Me.ResumeLayout()
                End If

                isHovering = False
                Me.Invalidate()  ' Redraw without hover effect
            Catch ex As Exception
                ' If resizing fails, just remove the hover effect
                isHovering = False
                Me.Invalidate()
            End Try
        End Sub

        ' Override the Region property to prevent graphics issues
        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            ' Create a circular region
            Using path As New GraphicsPath()
                path.AddEllipse(0, 0, Me.Width, Me.Height)
                Me.Region = New Region(path)
            End Using
        End Sub
    End Class

    Public Sub LoadCategories()
        categories.Clear()
        categories.Add("All")  ' Always add "All" as the first option

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT DISTINCT category FROM tbl_food ORDER BY category", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                If Not dr.IsDBNull(0) Then  ' Check if category is not null
                    categories.Add(dr("category").ToString())
                End If
            End While

        Catch ex As Exception
            MsgBox("Error loading categories: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub categorybtn_Click(sender As Object, e As EventArgs) Handles categorybtn.Click
        ' Move to next category
        currentCategoryIndex = (currentCategoryIndex + 1) Mod categories.Count

        ' Update button text to show current category
        categorybtn.Text = categories(currentCategoryIndex)

        ' Filter items based on selected category
        If currentCategoryIndex = 0 Then  ' "All" category
            Load_Foods()
        Else
            FilterByCategory(categories(currentCategoryIndex))
        End If

        UpdateCategoryButtonTooltip()
    End Sub

    Private Sub FilterByCategory(categoryName As String)
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT `img`, `foodcode`, `foodname` FROM `tbl_food` WHERE category = @category", conn)
            cmd.Parameters.AddWithValue("@category", categoryName)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub UpdateCategoryButtonTooltip()
        Dim nextIndex = (currentCategoryIndex + 1) Mod categories.Count
        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(categorybtn, $"Next: {categories(nextIndex)}")
    End Sub

    Public Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT img, foodcode, foodname FROM tbl_food", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub
    Private hoverTimer As New Timer()
    Private currentPanel As Panel = Nothing
    Private originalPanelColor As Color

    Private Sub SetupHoverTimer()
        hoverTimer.Interval = 50
        AddHandler hoverTimer.Tick, AddressOf HoverTimer_Tick
    End Sub

    Private Sub HoverTimer_Tick(sender As Object, e As EventArgs)
        If currentPanel IsNot Nothing Then
            ' Create a pulsing glow effect
            Dim alpha As Integer = 20 + CInt(Math.Abs(Math.Sin(DateTime.Now.Millisecond / 500.0) * 40))
            currentPanel.BackColor = Color.FromArgb(alpha + 40, alpha + 40, alpha + 40)
        End If
    End Sub

    Private Sub StartHoverEffect(panel As Panel)
        currentPanel = panel
        originalPanelColor = panel.BackColor
        hoverTimer.Start()
    End Sub

    Private Sub StopHoverEffect()
        If currentPanel IsNot Nothing Then
            currentPanel.BackColor = originalPanelColor
        End If
        currentPanel = Nothing
        hoverTimer.Stop()
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
            .Width = 156
            .Height = 180
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = foodCode
            ' Add hover effects to the panel
            AddHandler .MouseEnter, AddressOf Panel_MouseEnter
            AddHandler .MouseLeave, AddressOf Panel_MouseLeave
        End With

        ' Food Image
        img = New CirclePicturBox
        With img
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = foodCode
            .Name = "img" ' Add name for reference
        End With

        ' Food Name
        foodname = New Label
        With foodname
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Tag = foodCode
            .Text = dr.Item("foodname").ToString
            .Name = "foodname" ' Add name for reference
        End With

        ' Edit Button
        btnEdit = New Button
        With btnEdit
            .Text = "Edit"
            .Width = 50
            .Height = 30
            .Dock = DockStyle.Bottom
            .BackColor = Color.FromArgb(197, 187, 179)
            .ForeColor = Color.Black
            .FlatStyle = FlatStyle.Flat ' Set the button style to flat
            .FlatAppearance.BorderSize = 1 ' Add a subtle border
            .FlatAppearance.BorderColor = Color.DarkGray ' Set border color
            .FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 129, 77) ' Color on hover
            .FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 167, 159) ' Color on click
            .Font = New Font("Poppins Medium", 9, FontStyle.Regular) ' Optional: Set a custom font
            .Tag = foodCode
            .Name = "btnEdit" ' Add name for reference
            AddHandler .Click, AddressOf ButtonEdit_Click
        End With

        ' Assigning food image
        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        img.BackgroundImage = bitmap

        ' Adding controls to panel in correct order
        pan.Controls.Add(btnEdit)
        pan.Controls.Add(foodname)
        pan.Controls.Add(img)

        FlowLayoutPanel1.Controls.Add(pan)

        ' Adding click events
        AddHandler foodname.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub
    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs)
        Try
            Dim panel As Panel = DirectCast(sender, Panel)
            panel.BackColor = Color.FromArgb(60, 60, 60)  ' Slightly lighter on hover

            ' Find the button and change its appearance
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Button AndAlso ctrl.Name = "btnEdit" Then
                    Dim btn As Button = DirectCast(ctrl, Button)
                    btn.BackColor = Color.FromArgb(217, 207, 199)  ' Highlight color
                    Exit For
                End If
            Next
        Catch ex As Exception
            ' Silently handle any errors
        End Try
    End Sub

    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        Try
            Dim panel As Panel = DirectCast(sender, Panel)
            panel.BackColor = Color.FromArgb(40, 40, 40)  ' Original color

            ' Restore the button appearance
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Button AndAlso ctrl.Name = "btnEdit" Then
                    Dim btn As Button = DirectCast(ctrl, Button)
                    btn.BackColor = Color.FromArgb(197, 187, 179)  ' Original button color
                    Exit For
                End If
            Next
        Catch ex As Exception
            ' Silently handle any errors
        End Try
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
            If conn.State = ConnectionState.Closed Then conn.Open()

            cmd = New MySqlCommand("SELECT img, foodcode, foodname FROM tbl_food WHERE foodcode LIKE @search OR foodname LIKE @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            ' Handle exception silently
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()

        End Try
    End Sub

    Private Sub btn_ManageAddons_Click(sender As Object, e As EventArgs) Handles btn_ManageAddons.Click
        frm_ManageAddons.ShowDialog()
    End Sub
End Class