Public Class PosPopup
    Private WithEvents blinkTimer As New Timer()
    Private blinkState As Boolean = True
    Private labels As List(Of Label)

    Private Sub PosPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Image = My.Resources.Untitled_design
        MakePictureBoxCircular(PictureBox2)

        ' Setup labels collection for blinking (MUST BE FIRST BEFORE LOAD DATA)
        labels = New List(Of Label) From {label1, Label2, Label3, Label4, Label6}

        ' Load critical stock data (NOW labels is already created)
        LoadCriticalStockData()

        ' Setup blinking timer
        blinkTimer.Interval = 500 ' Half a second between blinks
        blinkTimer.Start()
    End Sub


    Private Sub MakePictureBoxCircular(pb As PictureBox)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, pb.Width, pb.Height)
        pb.Region = New Region(path)
    End Sub

    ' Timer event for blinking labels
    Private Sub blinkTimer_Tick(sender As Object, e As EventArgs) Handles blinkTimer.Tick
        ' Toggle blink state
        blinkState = Not blinkState

        ' Define colors for blinking
        Dim normalColor As Color = Color.Black
        Dim alertColor As Color = Color.Red

        ' Apply to all labels
        For Each lbl As Label In labels
            ' Skip empty labels
            If String.IsNullOrWhiteSpace(lbl.Text) Then Continue For

            ' Blink between normal color and alert color
            lbl.ForeColor = If(blinkState, alertColor, normalColor)
        Next
    End Sub

    Private Sub LoadCriticalStockData()
        Try
            ' Clear FlowLayoutPanel3 before adding new items
            FlowLayoutPanel3.Controls.Clear()

            ' Enable AutoScroll for FlowLayoutPanel3
            FlowLayoutPanel3.AutoScroll = True

            Dim connectionString As String = "server=localhost;port=3307;user=root;password=;database=brewtopia_db"
            Using conn As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
                conn.Open()

                ' Fetch data for items with quantity less than 11
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT name, quantity FROM tbl_inventoryad WHERE quantity < 11", conn)
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

                ' Display critical items in FlowLayoutPanel3
                While reader.Read()
                    Dim name As String = reader("name").ToString()
                    Dim quantity As Integer = Convert.ToInt32(reader("quantity"))

                    ' Create a new label dynamically for each critical item
                    Dim itemLabel As New Label()
                    itemLabel.Text = name & " - " & quantity & " left"
                    itemLabel.AutoSize = True
                    itemLabel.ForeColor = Color.Red  ' You can change color if needed

                    ' Add it to FlowLayoutPanel3
                    FlowLayoutPanel3.Controls.Add(itemLabel)
                End While
            End Using

            ' Scroll to the bottom of FlowLayoutPanel3
            FlowLayoutPanel3.AutoScrollPosition = New Point(0, FlowLayoutPanel3.VerticalScroll.Maximum)

        Catch ex As Exception
            MessageBox.Show("Error loading critical stock data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class