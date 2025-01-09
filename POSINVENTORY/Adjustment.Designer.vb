<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adjustment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adjustment))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_search = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.btn_EditItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(11, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 600)
        Me.Panel1.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(10, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(644, 448)
        Me.DataGridView1.TabIndex = 40
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 15
        Me.GunaElipse2.TargetControl = Me.Panel1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ADJUSTMENT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Controls.Add(Me.btn_EditItem)
        Me.Panel2.Location = New System.Drawing.Point(10, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(286, 115)
        Me.Panel2.TabIndex = 41
        '
        'txt_search
        '
        Me.txt_search.AcceptsReturn = False
        Me.txt_search.AcceptsTab = False
        Me.txt_search.AnimationSpeed = 200
        Me.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_search.AutoSize = True
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BackgroundImage = CType(resources.GetObject("txt_search.BackgroundImage"), System.Drawing.Image)
        Me.txt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_search.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.BorderRadius = 1
        Me.txt_search.BorderThickness = 1
        Me.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.DefaultText = ""
        Me.txt_search.FillColor = System.Drawing.Color.White
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.HideSelection = True
        Me.txt_search.IconLeft = Global.POSINVENTORY.My.Resources.Resources.Search1
        Me.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.IconPadding = 10
        Me.txt_search.IconRight = Nothing
        Me.txt_search.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.Lines = New String(-1) {}
        Me.txt_search.Location = New System.Drawing.Point(13, 22)
        Me.txt_search.MaxLength = 32767
        Me.txt_search.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_search.Modified = False
        Me.txt_search.Multiline = False
        Me.txt_search.Name = "txt_search"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Black
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnIdleState = StateProperties4
        Me.txt_search.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderForeColor = System.Drawing.Color.White
        Me.txt_search.PlaceholderText = ""
        Me.txt_search.ReadOnly = False
        Me.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_search.SelectedText = ""
        Me.txt_search.SelectionLength = 0
        Me.txt_search.SelectionStart = 0
        Me.txt_search.ShortcutsEnabled = True
        Me.txt_search.Size = New System.Drawing.Size(254, 37)
        Me.txt_search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txt_search.TabIndex = 31
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_search.TextMarginBottom = 0
        Me.txt_search.TextMarginLeft = 3
        Me.txt_search.TextMarginTop = 0
        Me.txt_search.TextPlaceholder = ""
        Me.txt_search.UseSystemPasswordChar = False
        Me.txt_search.WordWrap = True
        '
        'btn_EditItem
        '
        Me.btn_EditItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_EditItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_EditItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_EditItem.BorderRadius = 0
        Me.btn_EditItem.ButtonText = "EDIT ITEM"
        Me.btn_EditItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EditItem.DisabledColor = System.Drawing.Color.Gray
        Me.btn_EditItem.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_EditItem.Iconimage = Global.POSINVENTORY.My.Resources.Resources.Add_New1
        Me.btn_EditItem.Iconimage_right = Nothing
        Me.btn_EditItem.Iconimage_right_Selected = Nothing
        Me.btn_EditItem.Iconimage_Selected = Nothing
        Me.btn_EditItem.IconMarginLeft = 0
        Me.btn_EditItem.IconMarginRight = 0
        Me.btn_EditItem.IconRightVisible = True
        Me.btn_EditItem.IconRightZoom = 0R
        Me.btn_EditItem.IconVisible = True
        Me.btn_EditItem.IconZoom = 60.0R
        Me.btn_EditItem.IsTab = False
        Me.btn_EditItem.Location = New System.Drawing.Point(13, 65)
        Me.btn_EditItem.Name = "btn_EditItem"
        Me.btn_EditItem.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_EditItem.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_EditItem.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_EditItem.selected = False
        Me.btn_EditItem.Size = New System.Drawing.Size(254, 35)
        Me.btn_EditItem.TabIndex = 30
        Me.btn_EditItem.Text = "EDIT ITEM"
        Me.btn_EditItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_EditItem.Textcolor = System.Drawing.SystemColors.ControlText
        Me.btn_EditItem.TextFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Adjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 643)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Adjustment"
        Me.Text = "Adjustment"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Private WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_search As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents btn_EditItem As Bunifu.Framework.UI.BunifuFlatButton
End Class
