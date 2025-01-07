<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List))
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.BtnFoodIngred = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnBeverageSupply = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txt_search = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.btn_ManageFoods = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-7, 635)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 32)
        Me.Panel2.TabIndex = 7
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.BtnFoodIngred)
        Me.PanelTitle.Controls.Add(Me.BtnBeverageSupply)
        Me.PanelTitle.Controls.Add(Me.txt_search)
        Me.PanelTitle.Controls.Add(Me.btn_ManageFoods)
        Me.PanelTitle.Location = New System.Drawing.Point(21, 27)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(643, 124)
        Me.PanelTitle.TabIndex = 5
        '
        'BtnFoodIngred
        '
        Me.BtnFoodIngred.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BtnFoodIngred.color = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BtnFoodIngred.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BtnFoodIngred.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFoodIngred.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFoodIngred.ForeColor = System.Drawing.Color.Black
        Me.BtnFoodIngred.Image = Global.POSINVENTORY.My.Resources.Resources._28
        Me.BtnFoodIngred.ImagePosition = 7
        Me.BtnFoodIngred.ImageZoom = 30
        Me.BtnFoodIngred.LabelPosition = 25
        Me.BtnFoodIngred.LabelText = "FOOD INGREDIENTS"
        Me.BtnFoodIngred.Location = New System.Drawing.Point(480, 18)
        Me.BtnFoodIngred.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnFoodIngred.Name = "BtnFoodIngred"
        Me.BtnFoodIngred.Size = New System.Drawing.Size(137, 86)
        Me.BtnFoodIngred.TabIndex = 28
        '
        'BtnBeverageSupply
        '
        Me.BtnBeverageSupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnBeverageSupply.color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnBeverageSupply.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BtnBeverageSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBeverageSupply.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBeverageSupply.ForeColor = System.Drawing.Color.Black
        Me.BtnBeverageSupply.Image = Global.POSINVENTORY.My.Resources.Resources._27
        Me.BtnBeverageSupply.ImagePosition = 4
        Me.BtnBeverageSupply.ImageZoom = 30
        Me.BtnBeverageSupply.LabelPosition = 25
        Me.BtnBeverageSupply.LabelText = "BEVERAGES SUPPLY"
        Me.BtnBeverageSupply.Location = New System.Drawing.Point(319, 18)
        Me.BtnBeverageSupply.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnBeverageSupply.Name = "BtnBeverageSupply"
        Me.BtnBeverageSupply.Size = New System.Drawing.Size(137, 86)
        Me.BtnBeverageSupply.TabIndex = 27
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
        Me.txt_search.Location = New System.Drawing.Point(26, 18)
        Me.txt_search.MaxLength = 32767
        Me.txt_search.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_search.Modified = False
        Me.txt_search.Multiline = False
        Me.txt_search.Name = "txt_search"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties9.FillColor = System.Drawing.Color.Empty
        StateProperties9.ForeColor = System.Drawing.Color.Empty
        StateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnActiveState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties10.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_search.OnDisabledState = StateProperties10
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties11.FillColor = System.Drawing.Color.Empty
        StateProperties11.ForeColor = System.Drawing.Color.Empty
        StateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        StateProperties12.FillColor = System.Drawing.Color.White
        StateProperties12.ForeColor = System.Drawing.Color.Black
        StateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_search.OnIdleState = StateProperties12
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
        Me.txt_search.TabIndex = 26
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_search.TextMarginBottom = 0
        Me.txt_search.TextMarginLeft = 3
        Me.txt_search.TextMarginTop = 0
        Me.txt_search.TextPlaceholder = ""
        Me.txt_search.UseSystemPasswordChar = False
        Me.txt_search.WordWrap = True
        '
        'btn_ManageFoods
        '
        Me.btn_ManageFoods.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_ManageFoods.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_ManageFoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ManageFoods.BorderRadius = 0
        Me.btn_ManageFoods.ButtonText = "ADD PRODUCT"
        Me.btn_ManageFoods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ManageFoods.DisabledColor = System.Drawing.Color.Gray
        Me.btn_ManageFoods.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_ManageFoods.Iconimage = Global.POSINVENTORY.My.Resources.Resources.Add_New1
        Me.btn_ManageFoods.Iconimage_right = Nothing
        Me.btn_ManageFoods.Iconimage_right_Selected = Nothing
        Me.btn_ManageFoods.Iconimage_Selected = Nothing
        Me.btn_ManageFoods.IconMarginLeft = 0
        Me.btn_ManageFoods.IconMarginRight = 0
        Me.btn_ManageFoods.IconRightVisible = True
        Me.btn_ManageFoods.IconRightZoom = 0R
        Me.btn_ManageFoods.IconVisible = True
        Me.btn_ManageFoods.IconZoom = 60.0R
        Me.btn_ManageFoods.IsTab = False
        Me.btn_ManageFoods.Location = New System.Drawing.Point(26, 69)
        Me.btn_ManageFoods.Name = "btn_ManageFoods"
        Me.btn_ManageFoods.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_ManageFoods.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_ManageFoods.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_ManageFoods.selected = False
        Me.btn_ManageFoods.Size = New System.Drawing.Size(254, 35)
        Me.btn_ManageFoods.TabIndex = 8
        Me.btn_ManageFoods.Text = "ADD PRODUCT"
        Me.btn_ManageFoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_ManageFoods.Textcolor = System.Drawing.SystemColors.ControlText
        Me.btn_ManageFoods.TextFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 15
        Me.GunaElipse2.TargetControl = Me.PanelTitle
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 10
        Me.GunaElipse3.TargetControl = Me.btn_ManageFoods
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 15
        Me.GunaElipse4.TargetControl = Me.BtnBeverageSupply
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 15
        Me.GunaElipse5.TargetControl = Me.BtnFoodIngred
        '
        'GunaElipse6
        '
        Me.GunaElipse6.Radius = 15
        Me.GunaElipse6.TargetControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "INVENTORY"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(21, 170)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(651, 444)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 643)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "List"
        Me.Text = "List"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txt_search As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_ManageFoods As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBeverageSupply As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnFoodIngred As Bunifu.Framework.UI.BunifuTileButton
    Private WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
