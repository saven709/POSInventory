<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.SigninBtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PassTxtbox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'SigninBtn
        '
        Me.SigninBtn.AnimationHoverSpeed = 0.07!
        Me.SigninBtn.AnimationSpeed = 0.03!
        Me.SigninBtn.BackColor = System.Drawing.Color.Transparent
        Me.SigninBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SigninBtn.BorderColor = System.Drawing.Color.Black
        Me.SigninBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SigninBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SigninBtn.FocusedColor = System.Drawing.Color.Empty
        Me.SigninBtn.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SigninBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.SigninBtn.Image = Nothing
        Me.SigninBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.SigninBtn.Location = New System.Drawing.Point(612, 567)
        Me.SigninBtn.Name = "SigninBtn"
        Me.SigninBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SigninBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SigninBtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.SigninBtn.OnHoverImage = Nothing
        Me.SigninBtn.OnPressedColor = System.Drawing.Color.Black
        Me.SigninBtn.Radius = 5
        Me.SigninBtn.Size = New System.Drawing.Size(174, 43)
        Me.SigninBtn.TabIndex = 3
        Me.SigninBtn.Text = "Sign In"
        Me.SigninBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SigninBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel7.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(524, 407)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(117, 37)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "Password"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel6.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(524, 324)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(125, 37)
        Me.GunaLabel6.TabIndex = 0
        Me.GunaLabel6.Text = "Username"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(687, 175)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(168, 37)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Please login to"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel1.Font = New System.Drawing.Font("Poppins Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(549, 172)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(146, 42)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Welcome,"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(869, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(54, 24)
        Me.GunaControlBox1.TabIndex = 4
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(825, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(54, 24)
        Me.GunaControlBox2.TabIndex = 5
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(531, 616)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 5
        Me.GunaButton1.Size = New System.Drawing.Size(331, 43)
        Me.GunaButton1.TabIndex = 9
        Me.GunaButton1.Text = "cashier test"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 15
        Me.GunaElipse2.TargetControl = Me.SigninBtn
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GunaLabel2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(621, 212)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(156, 37)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "your account"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GunaLabel3.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(17, 551)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(342, 26)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "Find the best drink to accompany your days"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.AnimationSpeed = 200
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.AutoSize = True
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.BorderRadius = 1
        Me.BunifuTextBox1.BorderThickness = 1
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.ForeColor = System.Drawing.Color.White
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Global.POSINVENTORY.My.Resources.Resources.Contacts1
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.Lines = New String(-1) {}
        Me.BunifuTextBox1.Location = New System.Drawing.Point(528, 350)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Multiline = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuTextBox1.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnIdleState = StateProperties4
        Me.BunifuTextBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.BunifuTextBox1.PlaceholderText = ""
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(334, 50)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.BunifuTextBox1.TabIndex = 16
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginBottom = 0
        Me.BunifuTextBox1.TextMarginLeft = 3
        Me.BunifuTextBox1.TextMarginTop = 0
        Me.BunifuTextBox1.TextPlaceholder = ""
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        Me.BunifuTextBox1.WordWrap = True
        '
        'PassTxtbox
        '
        Me.PassTxtbox.AcceptsReturn = False
        Me.PassTxtbox.AcceptsTab = False
        Me.PassTxtbox.AnimationSpeed = 200
        Me.PassTxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PassTxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PassTxtbox.AutoSize = True
        Me.PassTxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.BackgroundImage = CType(resources.GetObject("PassTxtbox.BackgroundImage"), System.Drawing.Image)
        Me.PassTxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PassTxtbox.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.BorderRadius = 1
        Me.PassTxtbox.BorderThickness = 1
        Me.PassTxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PassTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassTxtbox.DefaultFont = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxtbox.DefaultText = ""
        Me.PassTxtbox.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.ForeColor = System.Drawing.Color.White
        Me.PassTxtbox.HideSelection = True
        Me.PassTxtbox.IconLeft = Global.POSINVENTORY.My.Resources.Resources.Lock1
        Me.PassTxtbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.PassTxtbox.IconPadding = 10
        Me.PassTxtbox.IconRight = Nothing
        Me.PassTxtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.PassTxtbox.Lines = New String(-1) {}
        Me.PassTxtbox.Location = New System.Drawing.Point(528, 431)
        Me.PassTxtbox.MaxLength = 32767
        Me.PassTxtbox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.PassTxtbox.Modified = False
        Me.PassTxtbox.Multiline = False
        Me.PassTxtbox.Name = "PassTxtbox"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PassTxtbox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PassTxtbox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PassTxtbox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties8.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PassTxtbox.OnIdleState = StateProperties8
        Me.PassTxtbox.Padding = New System.Windows.Forms.Padding(3)
        Me.PassTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTxtbox.PlaceholderForeColor = System.Drawing.Color.White
        Me.PassTxtbox.PlaceholderText = ""
        Me.PassTxtbox.ReadOnly = False
        Me.PassTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PassTxtbox.SelectedText = ""
        Me.PassTxtbox.SelectionLength = 0
        Me.PassTxtbox.SelectionStart = 0
        Me.PassTxtbox.ShortcutsEnabled = True
        Me.PassTxtbox.Size = New System.Drawing.Size(334, 50)
        Me.PassTxtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.PassTxtbox.TabIndex = 15
        Me.PassTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PassTxtbox.TextMarginBottom = 0
        Me.PassTxtbox.TextMarginLeft = 3
        Me.PassTxtbox.TextMarginTop = 0
        Me.PassTxtbox.TextPlaceholder = ""
        Me.PassTxtbox.UseSystemPasswordChar = False
        Me.PassTxtbox.WordWrap = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox3.Image = Global.POSINVENTORY.My.Resources.Resources._2
        Me.PictureBox3.Location = New System.Drawing.Point(648, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PictureBox2.Image = Global.POSINVENTORY.My.Resources.Resources._1
        Me.PictureBox2.Location = New System.Drawing.Point(37, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.POSINVENTORY.My.Resources.Resources.Login2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(918, 700)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 700)
        Me.Controls.Add(Me.BunifuTextBox1)
        Me.Controls.Add(Me.PassTxtbox)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.SigninBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents SigninBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PassTxtbox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextBox
End Class
