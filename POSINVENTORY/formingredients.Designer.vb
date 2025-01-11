<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formingredients
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.DataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ingredient_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.measurementname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.btn_deletesupply = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GunaElipse11 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnamesize = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.size_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_deletesize = New System.Windows.Forms.Button()
        Me.cbbName = New Guna.UI.WinForms.GunaComboBox()
        Me.btnAddSupply = New System.Windows.Forms.Button()
        Me.btnAddSize = New System.Windows.Forms.Button()
        Me.txt_supplycode = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(339, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "INGREDIENTS"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.GunaControlBox1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(696, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Maroon
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(38, 24)
        Me.GunaControlBox1.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 21
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.label, Me.ingredient_quantity, Me.Column1, Me.Column2, Me.measurementname})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(364, 145)
        Me.DataGridView1.TabIndex = 51
        Me.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'label
        '
        Me.label.HeaderText = "supplycode"
        Me.label.Name = "label"
        Me.label.ReadOnly = True
        Me.label.Visible = False
        '
        'ingredient_quantity
        '
        Me.ingredient_quantity.HeaderText = "Item Code"
        Me.ingredient_quantity.Name = "ingredient_quantity"
        Me.ingredient_quantity.ReadOnly = True
        Me.ingredient_quantity.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity needed"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'measurementname
        '
        Me.measurementname.HeaderText = "label"
        Me.measurementname.Name = "measurementname"
        Me.measurementname.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(427, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Supply name :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(427, 325)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(119, 22)
        Me.label3.TabIndex = 55
        Me.label3.Text = "Quantity needed :"
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.ForeColor = System.Drawing.Color.White
        Me.txtquantity.Location = New System.Drawing.Point(431, 350)
        Me.txtquantity.Multiline = True
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(196, 24)
        Me.txtquantity.TabIndex = 54
        '
        'btn_deletesupply
        '
        Me.btn_deletesupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_deletesupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletesupply.FlatAppearance.BorderSize = 0
        Me.btn_deletesupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_deletesupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletesupply.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletesupply.ForeColor = System.Drawing.Color.Black
        Me.btn_deletesupply.Location = New System.Drawing.Point(152, 421)
        Me.btn_deletesupply.Name = "btn_deletesupply"
        Me.btn_deletesupply.Size = New System.Drawing.Size(71, 32)
        Me.btn_deletesupply.TabIndex = 57
        Me.btn_deletesupply.Text = "REMOVE"
        Me.btn_deletesupply.UseVisualStyleBackColor = False
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
        Me.btn_save.Location = New System.Drawing.Point(493, 460)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(70, 32)
        Me.btn_save.TabIndex = 56
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'GunaElipse11
        '
        Me.GunaElipse11.Radius = 15
        Me.GunaElipse11.TargetControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(428, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(427, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Size name :"
        '
        'txtnamesize
        '
        Me.txtnamesize.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtnamesize.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnamesize.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamesize.ForeColor = System.Drawing.Color.White
        Me.txtnamesize.Location = New System.Drawing.Point(431, 83)
        Me.txtnamesize.Multiline = True
        Me.txtnamesize.Name = "txtnamesize"
        Me.txtnamesize.Size = New System.Drawing.Size(196, 24)
        Me.txtnamesize.TabIndex = 59
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.White
        Me.txtPrice.Location = New System.Drawing.Point(431, 134)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(196, 24)
        Me.txtPrice.TabIndex = 58
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.size_name, Me.PRICEs})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(63, 55)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.ReadOnly = True
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(265, 145)
        Me.GunaDataGridView1.TabIndex = 62
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = True
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'size_name
        '
        Me.size_name.HeaderText = "SIZE"
        Me.size_name.Name = "size_name"
        Me.size_name.ReadOnly = True
        '
        'PRICEs
        '
        Me.PRICEs.HeaderText = "PRICE"
        Me.PRICEs.Name = "PRICEs"
        Me.PRICEs.ReadOnly = True
        '
        'btn_deletesize
        '
        Me.btn_deletesize.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_deletesize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletesize.FlatAppearance.BorderSize = 0
        Me.btn_deletesize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_deletesize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletesize.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletesize.ForeColor = System.Drawing.Color.Black
        Me.btn_deletesize.Location = New System.Drawing.Point(152, 206)
        Me.btn_deletesize.Name = "btn_deletesize"
        Me.btn_deletesize.Size = New System.Drawing.Size(71, 32)
        Me.btn_deletesize.TabIndex = 63
        Me.btn_deletesize.Text = "REMOVE"
        Me.btn_deletesize.UseVisualStyleBackColor = False
        '
        'cbbName
        '
        Me.cbbName.BackColor = System.Drawing.Color.Transparent
        Me.cbbName.BaseColor = System.Drawing.Color.White
        Me.cbbName.BorderColor = System.Drawing.Color.Silver
        Me.cbbName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbName.FocusedColor = System.Drawing.Color.Empty
        Me.cbbName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbbName.ForeColor = System.Drawing.Color.Black
        Me.cbbName.FormattingEnabled = True
        Me.cbbName.Location = New System.Drawing.Point(431, 284)
        Me.cbbName.Name = "cbbName"
        Me.cbbName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbName.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbbName.Size = New System.Drawing.Size(197, 26)
        Me.cbbName.TabIndex = 64
        '
        'btnAddSupply
        '
        Me.btnAddSupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSupply.FlatAppearance.BorderSize = 0
        Me.btnAddSupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSupply.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupply.ForeColor = System.Drawing.Color.Black
        Me.btnAddSupply.Location = New System.Drawing.Point(493, 400)
        Me.btnAddSupply.Name = "btnAddSupply"
        Me.btnAddSupply.Size = New System.Drawing.Size(70, 32)
        Me.btnAddSupply.TabIndex = 65
        Me.btnAddSupply.Text = "ADD"
        Me.btnAddSupply.UseVisualStyleBackColor = False
        '
        'btnAddSize
        '
        Me.btnAddSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnAddSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSize.FlatAppearance.BorderSize = 0
        Me.btnAddSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSize.ForeColor = System.Drawing.Color.Black
        Me.btnAddSize.Location = New System.Drawing.Point(493, 185)
        Me.btnAddSize.Name = "btnAddSize"
        Me.btnAddSize.Size = New System.Drawing.Size(70, 32)
        Me.btnAddSize.TabIndex = 66
        Me.btnAddSize.Text = "ADD"
        Me.btnAddSize.UseVisualStyleBackColor = False
        '
        'txt_supplycode
        '
        Me.txt_supplycode.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_supplycode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_supplycode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_supplycode.ForeColor = System.Drawing.Color.White
        Me.txt_supplycode.Location = New System.Drawing.Point(432, 232)
        Me.txt_supplycode.Multiline = True
        Me.txt_supplycode.Name = "txt_supplycode"
        Me.txt_supplycode.Size = New System.Drawing.Size(168, 24)
        Me.txt_supplycode.TabIndex = 67
        Me.txt_supplycode.Visible = False
        '
        'formingredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 538)
        Me.Controls.Add(Me.txt_supplycode)
        Me.Controls.Add(Me.btnAddSize)
        Me.Controls.Add(Me.btnAddSupply)
        Me.Controls.Add(Me.cbbName)
        Me.Controls.Add(Me.btn_deletesize)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnamesize)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btn_deletesupply)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formingredients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formingredients"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents DataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents btn_deletesupply As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents GunaElipse11 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnamesize As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents size_name As DataGridViewTextBoxColumn
    Friend WithEvents PRICEs As DataGridViewTextBoxColumn
    Friend WithEvents cbbName As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_deletesize As Button
    Friend WithEvents btnAddSupply As Button
    Friend WithEvents btnAddSize As Button
    Friend WithEvents txt_supplycode As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents label As DataGridViewTextBoxColumn
    Friend WithEvents ingredient_quantity As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents measurementname As DataGridViewTextBoxColumn
End Class
