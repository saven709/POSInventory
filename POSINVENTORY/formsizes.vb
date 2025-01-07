Imports MySql.Data.MySqlClient

Public Class formsizes
    Private foodCode As String
    Private foodName As String
    Public SelectedSize As String = Nothing
    Public SelectedPrice As Decimal = 0

    ' Constructor
    Public Sub New(code As String, name As String)
        InitializeComponent()
        foodCode = code
        foodName = name
        ' Set the form title or a label to show the food name
        Me.Text = foodName
    End Sub

    Private Sub formsizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSizes()
    End Sub

    Private Sub LoadSizes()
        FlowLayoutPanel1.Controls.Clear()
        Try
            dbconn()
            conn.Open()
            cmd = New MySqlCommand("SELECT `size_name`, `price` FROM `tbl_food_sizes` WHERE `foodcode` = @foodcode", conn)
            cmd.Parameters.AddWithValue("@foodcode", foodCode)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim sizeName = dr("size_name").ToString()
                Dim price = Decimal.Parse(dr("price").ToString())

                ' Create button for each size
                Dim sizeButton As New Button With {
                    .Text = $"{sizeName} - PHP {price:N2}",
                    .Width = 200,
                    .Height = 50,
                    .BackColor = Color.FromArgb(70, 70, 70),
                    .ForeColor = Color.White,
                    .Tag = New With {.SizeName = sizeName, .Price = price},
                    .FlatStyle = FlatStyle.Flat
                }

                ' Optional: Add hover effects
                AddHandler sizeButton.MouseEnter, Sub(sender, e)
                                                      sizeButton.BackColor = Color.FromArgb(90, 90, 90)
                                                  End Sub

                AddHandler sizeButton.MouseLeave, Sub(sender, e)
                                                      sizeButton.BackColor = Color.FromArgb(70, 70, 70)
                                                  End Sub

                AddHandler sizeButton.Click, AddressOf SizeButton_Click
                FlowLayoutPanel1.Controls.Add(sizeButton)
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub SizeButton_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim buttonData = btn.Tag
        SelectedSize = buttonData.SizeName
        SelectedPrice = buttonData.Price
        Me.Close()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()
    End Sub
End Class