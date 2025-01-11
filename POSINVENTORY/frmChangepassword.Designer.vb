<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangepassword
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txt_Newpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(73, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 22)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "CHANGE PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Username :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(118, 64)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 19)
        Me.lblUsername.TabIndex = 55
        Me.lblUsername.Text = "Username"
        '
        'txt_Newpassword
        '
        Me.txt_Newpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_Newpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Newpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Newpassword.ForeColor = System.Drawing.Color.White
        Me.txt_Newpassword.Location = New System.Drawing.Point(47, 132)
        Me.txt_Newpassword.Multiline = True
        Me.txt_Newpassword.Name = "txt_Newpassword"
        Me.txt_Newpassword.Size = New System.Drawing.Size(189, 25)
        Me.txt_Newpassword.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "New Password"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(251, 7)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox1.TabIndex = 62
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(89, 172)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(97, 25)
        Me.btn_save.TabIndex = 63
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'frmChangepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 226)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Newpassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangepassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txt_Newpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btn_save As Button
End Class
