<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageFoods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManageFoods))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_foodname = New System.Windows.Forms.TextBox()
        Me.txt_foodcode = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.txt_found = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.TextBox3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse11 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_category = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(247, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(247, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Code"
        '
        'txt_foodname
        '
        Me.txt_foodname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_foodname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_foodname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_foodname.ForeColor = System.Drawing.Color.White
        Me.txt_foodname.Location = New System.Drawing.Point(247, 157)
        Me.txt_foodname.Multiline = True
        Me.txt_foodname.Name = "txt_foodname"
        Me.txt_foodname.Size = New System.Drawing.Size(233, 24)
        Me.txt_foodname.TabIndex = 10
        '
        'txt_foodcode
        '
        Me.txt_foodcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_foodcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_foodcode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_foodcode.ForeColor = System.Drawing.Color.Red
        Me.txt_foodcode.Location = New System.Drawing.Point(247, 108)
        Me.txt_foodcode.Multiline = True
        Me.txt_foodcode.Name = "txt_foodcode"
        Me.txt_foodcode.Size = New System.Drawing.Size(233, 24)
        Me.txt_foodcode.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btn_find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_find.FlatAppearance.BorderSize = 0
        Me.btn_find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find.ForeColor = System.Drawing.Color.White
        Me.btn_find.Location = New System.Drawing.Point(179, 24)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(67, 23)
        Me.btn_find.TabIndex = 27
        Me.btn_find.Text = "FIND"
        Me.btn_find.UseVisualStyleBackColor = False
        Me.btn_find.Visible = False
        '
        'txt_found
        '
        Me.txt_found.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_found.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_found.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_found.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_found.Location = New System.Drawing.Point(44, 24)
        Me.txt_found.Multiline = True
        Me.txt_found.Name = "txt_found"
        Me.txt_found.Size = New System.Drawing.Size(137, 24)
        Me.txt_found.TabIndex = 26
        Me.txt_found.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(316, 244)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(97, 32)
        Me.btn_save.TabIndex = 29
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(44, 80)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(174, 152)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 32
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(58, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 26)
        Me.TextBox3.TabIndex = 47
        Me.TextBox3.Visible = False
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(491, -2)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox2.TabIndex = 49
        Me.GunaControlBox2.Visible = False
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(535, -2)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox1.TabIndex = 48
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaElipse11
        '
        Me.GunaElipse11.Radius = 15
        Me.GunaElipse11.TargetControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(233, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 22)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ADD PRODUCT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(247, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Category"
        '
        'txt_category
        '
        Me.txt_category.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_category.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_category.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category.ForeColor = System.Drawing.Color.White
        Me.txt_category.Location = New System.Drawing.Point(247, 204)
        Me.txt_category.Multiline = True
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(233, 24)
        Me.txt_category.TabIndex = 51
        '
        'frm_ManageFoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 288)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.txt_found)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_foodname)
        Me.Controls.Add(Me.txt_foodcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ManageFoods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManageFoods"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_foodname As TextBox
    Friend WithEvents txt_foodcode As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_find As Button
    Friend WithEvents txt_found As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents TextBox3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse11 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_category As TextBox
End Class
