<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editadjustment
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_itemcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.lbl_lastquantity = New System.Windows.Forms.Label()
        Me.lbl_date1 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(251, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ADJUSTMENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.ForeColor = System.Drawing.Color.White
        Me.txt_quantity.Location = New System.Drawing.Point(45, 182)
        Me.txt_quantity.Multiline = True
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(233, 24)
        Me.txt_quantity.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Code"
        '
        'txt_itemcode
        '
        Me.txt_itemcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_itemcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_itemcode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemcode.ForeColor = System.Drawing.Color.Red
        Me.txt_itemcode.Location = New System.Drawing.Point(45, 90)
        Me.txt_itemcode.Multiline = True
        Me.txt_itemcode.Name = "txt_itemcode"
        Me.txt_itemcode.Size = New System.Drawing.Size(233, 24)
        Me.txt_itemcode.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(45, 133)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 24)
        Me.txt_name.TabIndex = 64
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(267, 278)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 32)
        Me.btn_save.TabIndex = 74
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(299, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Description"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.ForeColor = System.Drawing.Color.White
        Me.txt_desc.Location = New System.Drawing.Point(299, 133)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(233, 24)
        Me.txt_desc.TabIndex = 75
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(558, -2)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox1.TabIndex = 79
        '
        'lbl_lastquantity
        '
        Me.lbl_lastquantity.AutoSize = True
        Me.lbl_lastquantity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lastquantity.ForeColor = System.Drawing.Color.White
        Me.lbl_lastquantity.Location = New System.Drawing.Point(45, 252)
        Me.lbl_lastquantity.Name = "lbl_lastquantity"
        Me.lbl_lastquantity.Size = New System.Drawing.Size(57, 19)
        Me.lbl_lastquantity.TabIndex = 80
        Me.lbl_lastquantity.Text = "Quantity"
        Me.lbl_lastquantity.Visible = False
        '
        'lbl_date1
        '
        Me.lbl_date1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date1.ForeColor = System.Drawing.Color.Black
        Me.lbl_date1.Location = New System.Drawing.Point(222, 48)
        Me.lbl_date1.Name = "lbl_date1"
        Me.lbl_date1.Size = New System.Drawing.Size(251, 25)
        Me.lbl_date1.TabIndex = 82
        Me.lbl_date1.Text = "00.00"
        Me.lbl_date1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_date1.Visible = False
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.Black
        Me.lbl_time.Location = New System.Drawing.Point(450, 48)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(107, 25)
        Me.lbl_time.TabIndex = 81
        Me.lbl_time.Text = "00.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_time.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'editadjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 339)
        Me.Controls.Add(Me.lbl_date1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_lastquantity)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_itemcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editadjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editadjustment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_itemcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents lbl_lastquantity As Label
    Friend WithEvents lbl_date1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
End Class
