<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelMain = New Guna.UI.WinForms.GunaPanel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.PanelSlide = New System.Windows.Forms.Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btnSetting = New Guna.UI.WinForms.GunaButton()
        Me.btnRecord = New Guna.UI.WinForms.GunaButton()
        Me.btnProduct = New Guna.UI.WinForms.GunaButton()
        Me.btnDashboard = New Guna.UI.WinForms.GunaButton()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_date1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_overallTotal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.lbl_noOfProducts = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_transno = New System.Windows.Forms.TextBox()
        Me.txt_BalanceAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_receivedAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse7 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse8 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse9 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse10 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse11 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.categorybtn = New System.Windows.Forms.Button()
        Me.PanelMain.SuspendLayout()
        Me.PanelSlide.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(214, 12)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaLabel11.Size = New System.Drawing.Size(47, 26)
        Me.GunaLabel11.TabIndex = 16
        Me.GunaLabel11.Text = "Date"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelMain.Controls.Add(Me.GunaControlBox2)
        Me.PanelMain.Controls.Add(Me.GunaControlBox1)
        Me.PanelMain.Controls.Add(Me.PanelSlide)
        Me.PanelMain.Controls.Add(Me.btnLogout)
        Me.PanelMain.Controls.Add(Me.PanelLogo)
        Me.PanelMain.Controls.Add(Me.Panel2)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1106, 700)
        Me.PanelMain.TabIndex = 8
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1021, 1)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox2.TabIndex = 23
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1065, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox1.TabIndex = 22
        '
        'PanelSlide
        '
        Me.PanelSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PanelSlide.Controls.Add(Me.GunaButton2)
        Me.PanelSlide.Controls.Add(Me.GunaButton1)
        Me.PanelSlide.Controls.Add(Me.btnSetting)
        Me.PanelSlide.Controls.Add(Me.btnRecord)
        Me.PanelSlide.Controls.Add(Me.btnProduct)
        Me.PanelSlide.Controls.Add(Me.btnDashboard)
        Me.PanelSlide.Location = New System.Drawing.Point(12, 207)
        Me.PanelSlide.Name = "PanelSlide"
        Me.PanelSlide.Size = New System.Drawing.Size(170, 407)
        Me.PanelSlide.TabIndex = 6
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GunaButton2.Image = Global.POSINVENTORY.My.Resources.Resources.Password_Resetb
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(0, 250)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(170, 50)
        Me.GunaButton2.TabIndex = 19
        Me.GunaButton2.Text = "Change Password"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GunaButton1.Image = Global.POSINVENTORY.My.Resources.Resources.Total_Salesb
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(0, 200)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(170, 50)
        Me.GunaButton1.TabIndex = 18
        Me.GunaButton1.Text = "Daily Sales"
        Me.GunaButton1.Visible = False
        '
        'btnSetting
        '
        Me.btnSetting.AnimationHoverSpeed = 0.07!
        Me.btnSetting.AnimationSpeed = 0.03!
        Me.btnSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnSetting.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnSetting.BorderColor = System.Drawing.Color.Black
        Me.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetting.FocusedColor = System.Drawing.Color.Empty
        Me.btnSetting.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSetting.Image = Global.POSINVENTORY.My.Resources.Resources.Clear_Shopping_Cartb
        Me.btnSetting.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSetting.Location = New System.Drawing.Point(0, 150)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnSetting.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSetting.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSetting.OnHoverImage = Nothing
        Me.btnSetting.OnPressedColor = System.Drawing.Color.Black
        Me.btnSetting.Size = New System.Drawing.Size(170, 50)
        Me.btnSetting.TabIndex = 17
        Me.btnSetting.Text = "Clear Cart"
        '
        'btnRecord
        '
        Me.btnRecord.AnimationHoverSpeed = 0.07!
        Me.btnRecord.AnimationSpeed = 0.03!
        Me.btnRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnRecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnRecord.BorderColor = System.Drawing.Color.Black
        Me.btnRecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnRecord.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRecord.Image = Global.POSINVENTORY.My.Resources.Resources.Online_Paymentb
        Me.btnRecord.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRecord.Location = New System.Drawing.Point(0, 100)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnRecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRecord.OnHoverImage = Nothing
        Me.btnRecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnRecord.Size = New System.Drawing.Size(170, 50)
        Me.btnRecord.TabIndex = 15
        Me.btnRecord.Text = "Settle Payment"
        '
        'btnProduct
        '
        Me.btnProduct.AnimationHoverSpeed = 0.07!
        Me.btnProduct.AnimationSpeed = 0.03!
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnProduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnProduct.BorderColor = System.Drawing.Color.Black
        Me.btnProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnProduct.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnProduct.Image = Global.POSINVENTORY.My.Resources.Resources.Searchb
        Me.btnProduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnProduct.Location = New System.Drawing.Point(0, 50)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnProduct.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnProduct.OnHoverImage = Nothing
        Me.btnProduct.OnPressedColor = System.Drawing.Color.Black
        Me.btnProduct.Size = New System.Drawing.Size(170, 50)
        Me.btnProduct.TabIndex = 11
        Me.btnProduct.Text = "Search Product"
        Me.btnProduct.Visible = False
        '
        'btnDashboard
        '
        Me.btnDashboard.AnimationHoverSpeed = 0.07!
        Me.btnDashboard.AnimationSpeed = 0.03!
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnDashboard.BorderColor = System.Drawing.Color.Black
        Me.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnDashboard.Image = Global.POSINVENTORY.My.Resources.Resources.Transactionb
        Me.btnDashboard.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDashboard.OnHoverImage = Nothing
        Me.btnDashboard.OnPressedColor = System.Drawing.Color.Black
        Me.btnDashboard.Size = New System.Drawing.Size(170, 50)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "New Transaction"
        '
        'btnLogout
        '
        Me.btnLogout.AnimationHoverSpeed = 0.07!
        Me.btnLogout.AnimationSpeed = 0.03!
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLogout.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnLogout.Image = Global.POSINVENTORY.My.Resources.Resources.Logout_Rounded_Leftb
        Me.btnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogout.Location = New System.Drawing.Point(12, 629)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(170, 50)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOG OUT"
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Controls.Add(Me.lblUsername)
        Me.PanelLogo.Location = New System.Drawing.Point(12, 36)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(170, 153)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POSINVENTORY.My.Resources.Resources.School_Cafeteriab
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(49, 88)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 22)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "UserName"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel2.Controls.Add(Me.categorybtn)
        Me.Panel2.Controls.Add(Me.txtquantity)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.btnPlus)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_date1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Controls.Add(Me.lbl_time)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(195, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 652)
        Me.Panel2.TabIndex = 9
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtquantity.Location = New System.Drawing.Point(516, 339)
        Me.txtquantity.Multiline = True
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(101, 30)
        Me.txtquantity.TabIndex = 39
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(747, 337)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(71, 32)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnminus
        '
        Me.btnminus.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnminus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminus.FlatAppearance.BorderSize = 0
        Me.btnminus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminus.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.ForeColor = System.Drawing.Color.Black
        Me.btnminus.Location = New System.Drawing.Point(681, 337)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(51, 32)
        Me.btnminus.TabIndex = 37
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.Color.Black
        Me.btnPlus.Location = New System.Drawing.Point(623, 337)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(52, 32)
        Me.btnPlus.TabIndex = 36
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "POS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.POSINVENTORY.My.Resources.Resources.Search
        Me.PictureBox2.Location = New System.Drawing.Point(11, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'lbl_date1
        '
        Me.lbl_date1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lbl_date1.Location = New System.Drawing.Point(545, 0)
        Me.lbl_date1.Name = "lbl_date1"
        Me.lbl_date1.Size = New System.Drawing.Size(251, 31)
        Me.lbl_date1.TabIndex = 25
        Me.lbl_date1.Text = "00.00"
        Me.lbl_date1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_search.Location = New System.Drawing.Point(44, 35)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(351, 24)
        Me.txt_search.TabIndex = 25
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lbl_time.Location = New System.Drawing.Point(773, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(107, 31)
        Me.lbl_time.TabIndex = 24
        Me.lbl_time.Text = "00.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel5.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel5.Location = New System.Drawing.Point(11, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(496, 569)
        Me.Panel5.TabIndex = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_overallTotal)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(496, 569)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'lbl_overallTotal
        '
        Me.lbl_overallTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_overallTotal.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overallTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_overallTotal.Location = New System.Drawing.Point(23, 20)
        Me.lbl_overallTotal.Name = "lbl_overallTotal"
        Me.lbl_overallTotal.Size = New System.Drawing.Size(265, 59)
        Me.lbl_overallTotal.TabIndex = 24
        Me.lbl_overallTotal.Text = "00.00"
        Me.lbl_overallTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_overallTotal.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(516, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(371, 299)
        Me.Panel4.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
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
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
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
        Me.DataGridView1.Size = New System.Drawing.Size(371, 299)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_tot)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_GrandTotal)
        Me.Panel1.Controls.Add(Me.lbl_TotalPrice)
        Me.Panel1.Controls.Add(Me.lbl_noOfProducts)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.txt_transno)
        Me.Panel1.Controls.Add(Me.txt_BalanceAmount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_receivedAmount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GunaLabel9)
        Me.Panel1.Controls.Add(Me.GunaLabel11)
        Me.Panel1.Location = New System.Drawing.Point(516, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 259)
        Me.Panel1.TabIndex = 3
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_tot.Location = New System.Drawing.Point(87, 244)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(39, 13)
        Me.lbl_tot.TabIndex = 32
        Me.lbl_tot.Text = "Label7"
        Me.lbl_tot.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 26)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Total :"
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.AutoSize = True
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(82, 104)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(46, 26)
        Me.lbl_GrandTotal.TabIndex = 30
        Me.lbl_GrandTotal.Text = "0.00"
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalPrice.ForeColor = System.Drawing.Color.Black
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(26, 75)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(96, 26)
        Me.lbl_TotalPrice.TabIndex = 29
        Me.lbl_TotalPrice.Text = "No of Item :"
        '
        'lbl_noOfProducts
        '
        Me.lbl_noOfProducts.AutoSize = True
        Me.lbl_noOfProducts.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noOfProducts.ForeColor = System.Drawing.Color.Black
        Me.lbl_noOfProducts.Location = New System.Drawing.Point(128, 75)
        Me.lbl_noOfProducts.Name = "lbl_noOfProducts"
        Me.lbl_noOfProducts.Size = New System.Drawing.Size(46, 26)
        Me.lbl_noOfProducts.TabIndex = 28
        Me.lbl_noOfProducts.Text = "0.00"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(215, 46)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(35, 19)
        Me.lbl_date.TabIndex = 27
        Me.lbl_date.Text = "Date"
        '
        'txt_transno
        '
        Me.txt_transno.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_transno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_transno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_transno.ForeColor = System.Drawing.Color.OrangeRed
        Me.txt_transno.Location = New System.Drawing.Point(26, 35)
        Me.txt_transno.Multiline = True
        Me.txt_transno.Name = "txt_transno"
        Me.txt_transno.Size = New System.Drawing.Size(168, 24)
        Me.txt_transno.TabIndex = 26
        '
        'txt_BalanceAmount
        '
        Me.txt_BalanceAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_BalanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BalanceAmount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BalanceAmount.ForeColor = System.Drawing.Color.OrangeRed
        Me.txt_BalanceAmount.Location = New System.Drawing.Point(26, 213)
        Me.txt_BalanceAmount.Name = "txt_BalanceAmount"
        Me.txt_BalanceAmount.Size = New System.Drawing.Size(168, 28)
        Me.txt_BalanceAmount.TabIndex = 25
        Me.txt_BalanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Balance Amount PHP"
        '
        'txt_receivedAmount
        '
        Me.txt_receivedAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_receivedAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_receivedAmount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receivedAmount.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_receivedAmount.Location = New System.Drawing.Point(26, 156)
        Me.txt_receivedAmount.Name = "txt_receivedAmount"
        Me.txt_receivedAmount.Size = New System.Drawing.Size(168, 28)
        Me.txt_receivedAmount.TabIndex = 23
        Me.txt_receivedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 26)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Received Amount PHP"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(22, 12)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaLabel9.Size = New System.Drawing.Size(130, 26)
        Me.GunaLabel9.TabIndex = 14
        Me.GunaLabel9.Text = "Transaction No."
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 15
        Me.GunaElipse2.TargetControl = Me.PanelSlide
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 15
        Me.GunaElipse3.TargetControl = Me.btnLogout
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 15
        Me.GunaElipse4.TargetControl = Me.PanelLogo
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 15
        Me.GunaElipse5.TargetControl = Me.Panel1
        '
        'GunaElipse6
        '
        Me.GunaElipse6.Radius = 15
        Me.GunaElipse6.TargetControl = Me.Panel2
        '
        'GunaElipse7
        '
        Me.GunaElipse7.Radius = 15
        Me.GunaElipse7.TargetControl = Me.Panel4
        '
        'GunaElipse8
        '
        Me.GunaElipse8.Radius = 5
        Me.GunaElipse8.TargetControl = Me.Panel5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GunaElipse9
        '
        Me.GunaElipse9.Radius = 5
        Me.GunaElipse9.TargetControl = Me.btnPlus
        '
        'GunaElipse10
        '
        Me.GunaElipse10.Radius = 5
        Me.GunaElipse10.TargetControl = Me.btnminus
        '
        'GunaElipse11
        '
        Me.GunaElipse11.Radius = 5
        Me.GunaElipse11.TargetControl = Me.btnRemove
        '
        'categorybtn
        '
        Me.categorybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.categorybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.categorybtn.FlatAppearance.BorderSize = 0
        Me.categorybtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.categorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categorybtn.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorybtn.ForeColor = System.Drawing.Color.Black
        Me.categorybtn.Location = New System.Drawing.Point(421, 35)
        Me.categorybtn.Name = "categorybtn"
        Me.categorybtn.Size = New System.Drawing.Size(75, 24)
        Me.categorybtn.TabIndex = 40
        Me.categorybtn.Text = "category"
        Me.categorybtn.UseVisualStyleBackColor = False
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 700)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelSlide.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelMain As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PanelSlide As Panel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSetting As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnRecord As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnProduct As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GunaElipse7 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse8 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_date1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_overallTotal As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_transno As TextBox
    Friend WithEvents txt_BalanceAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_receivedAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents lbl_noOfProducts As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_tot As Label
    Private WithEvents Label3 As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse9 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse10 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse11 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents categorybtn As Button
End Class
