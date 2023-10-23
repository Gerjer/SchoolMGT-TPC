<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaFeesMasterDuplicate
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaFeesMasterDuplicate))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnImport = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtBatchID = New System.Windows.Forms.TextBox
        Me.txtCourseID = New System.Windows.Forms.TextBox
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.pbxSearch = New System.Windows.Forms.PictureBox
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.dgvFEES = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblTimer = New DevComponents.DotNetBar.LabelX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtThisBatchID = New System.Windows.Forms.TextBox
        Me.txtThisCourseID = New System.Windows.Forms.TextBox
        Me.txtBatch = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCourse = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel2.SuspendLayout()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.dgvFEES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Staff"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "User"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "HR Personnel"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Accounting"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.btnImport)
        Me.GroupPanel2.Controls.Add(Me.btnCancel)
        Me.GroupPanel2.Controls.Add(Me.txtBatchID)
        Me.GroupPanel2.Controls.Add(Me.txtCourseID)
        Me.GroupPanel2.Controls.Add(Me.cmbBatch)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.cmbCourse)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.pbxSearch)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1020, 462)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 17
        '
        'btnImport
        '
        Me.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImport.HoverImage = Global.SchoolMGT.My.Resources.Resources.duplicate_icon_md
        Me.btnImport.Image = Global.SchoolMGT.My.Resources.Resources.duplicate_icon_md
        Me.btnImport.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnImport.Location = New System.Drawing.Point(235, 212)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(122, 35)
        Me.btnImport.TabIndex = 121
        Me.btnImport.Text = "Import Fees"
        Me.btnImport.Tooltip = "Import the checked Fees"
        Me.btnImport.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(114, 215)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 120
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(453, 302)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 119
        Me.txtBatchID.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(453, 276)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 118
        Me.txtCourseID.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DisplayMember = "Text"
        Me.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.ItemHeight = 14
        Me.cmbBatch.Location = New System.Drawing.Point(114, 162)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(15, 167)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(40, 15)
        Me.LabelX3.TabIndex = 115
        Me.LabelX3.Text = "BATCH"
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(114, 136)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 0
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(15, 141)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(87, 15)
        Me.LabelX4.TabIndex = 113
        Me.LabelX4.Text = "COURSE/LEVEL"
        '
        'pbxSearch
        '
        Me.pbxSearch.BackColor = System.Drawing.Color.Transparent
        Me.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSearch.Image = Global.SchoolMGT.My.Resources.Resources.loading_2
        Me.pbxSearch.Location = New System.Drawing.Point(425, 146)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(81, 52)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 117
        Me.pbxSearch.TabStop = False
        Me.pbxSearch.Visible = False
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.dgvFEES)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupPanel3.Location = New System.Drawing.Point(506, 104)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(512, 335)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 1
        Me.GroupPanel3.Text = "Group Fees"
        '
        'dgvFEES
        '
        Me.dgvFEES.AllowUserToAddRows = False
        Me.dgvFEES.AllowUserToDeleteRows = False
        Me.dgvFEES.AllowUserToResizeColumns = False
        Me.dgvFEES.AllowUserToResizeRows = False
        Me.dgvFEES.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFEES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFEES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFEES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFEES.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFEES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFEES.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvFEES.Location = New System.Drawing.Point(0, 0)
        Me.dgvFEES.MultiSelect = False
        Me.dgvFEES.Name = "dgvFEES"
        Me.dgvFEES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFEES.Size = New System.Drawing.Size(506, 314)
        Me.dgvFEES.TabIndex = 28
        '
        'Column4
        '
        Me.Column4.HeaderText = "IMPORT"
        Me.Column4.Name = "Column4"
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "AMOUNT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lblTimer)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.txtThisBatchID)
        Me.GroupPanel1.Controls.Add(Me.txtThisCourseID)
        Me.GroupPanel1.Controls.Add(Me.txtBatch)
        Me.GroupPanel1.Controls.Add(Me.txtCourse)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1018, 104)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 0
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(580, 27)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(75, 23)
        Me.lblTimer.TabIndex = 116
        Me.lblTimer.Text = "0"
        Me.lblTimer.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "CURRENT COURSE / BATCH"
        '
        'txtThisBatchID
        '
        Me.txtThisBatchID.Location = New System.Drawing.Point(535, 63)
        Me.txtThisBatchID.Name = "txtThisBatchID"
        Me.txtThisBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtThisBatchID.TabIndex = 114
        Me.txtThisBatchID.Visible = False
        '
        'txtThisCourseID
        '
        Me.txtThisCourseID.Location = New System.Drawing.Point(535, 33)
        Me.txtThisCourseID.Name = "txtThisCourseID"
        Me.txtThisCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtThisCourseID.TabIndex = 113
        Me.txtThisCourseID.Visible = False
        '
        'txtBatch
        '
        Me.txtBatch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtBatch.Border.Class = "TextBoxBorder"
        Me.txtBatch.Location = New System.Drawing.Point(111, 63)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(418, 20)
        Me.txtBatch.TabIndex = 112
        Me.txtBatch.TabStop = False
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtCourse.Border.Class = "TextBoxBorder"
        Me.txtCourse.Location = New System.Drawing.Point(111, 33)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(418, 20)
        Me.txtCourse.TabIndex = 111
        Me.txtCourse.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(6, 68)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 15)
        Me.LabelX2.TabIndex = 110
        Me.LabelX2.Text = "BATCH"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(6, 38)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 15)
        Me.LabelX1.TabIndex = 109
        Me.LabelX1.Text = "COURSE/LEVEL"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'fmaFeesMasterDuplicate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1020, 462)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaFeesMasterDuplicate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Fees from other Course/Batch"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.dgvFEES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCourse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtThisBatchID As System.Windows.Forms.TextBox
    Friend WithEvents txtThisCourseID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbBatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pbxSearch As System.Windows.Forms.PictureBox
    Friend WithEvents txtBatchID As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvFEES As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnImport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
