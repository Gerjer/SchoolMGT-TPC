<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaStudentsGradingPeriod
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaStudentsGradingPeriod))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvSubjectGrade = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShortcutToGradingPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.isAllowedEdit = New System.Windows.Forms.TextBox()
        Me.txtBatchID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCatID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtStudentID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAdmissionNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtCategory = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtStudentName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtBatchName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCoursename = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSubjectGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1370, 562)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.Azure
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.MediumAquamarine
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSubjectGrade)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1364, 345)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'dgvSubjectGrade
        '
        Me.dgvSubjectGrade.AllowUserToAddRows = False
        Me.dgvSubjectGrade.AllowUserToDeleteRows = False
        Me.dgvSubjectGrade.AllowUserToResizeColumns = False
        Me.dgvSubjectGrade.AllowUserToResizeRows = False
        Me.dgvSubjectGrade.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubjectGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubjectGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectGrade.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvSubjectGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubjectGrade.Location = New System.Drawing.Point(3, 16)
        Me.dgvSubjectGrade.Name = "dgvSubjectGrade"
        Me.dgvSubjectGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjectGrade.Size = New System.Drawing.Size(1358, 326)
        Me.dgvSubjectGrade.TabIndex = 24
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutToGradingPeriodToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(216, 26)
        '
        'ShortcutToGradingPeriodToolStripMenuItem
        '
        Me.ShortcutToGradingPeriodToolStripMenuItem.Name = "ShortcutToGradingPeriodToolStripMenuItem"
        Me.ShortcutToGradingPeriodToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ShortcutToGradingPeriodToolStripMenuItem.Text = "Shortcut to Grading Period"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.isAllowedEdit)
        Me.GroupBox1.Controls.Add(Me.txtBatchID)
        Me.GroupBox1.Controls.Add(Me.txtCatID)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtAdmissionNo)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtBatchName)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtCoursename)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1364, 211)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 173)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1358, 35)
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
        Me.GroupPanel1.TabIndex = 151
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(1247, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(105, 29)
        Me.btnCancel.TabIndex = 201
        Me.btnCancel.Text = "Close"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.ForeColor = System.Drawing.Color.Red
        Me.LabelX6.Location = New System.Drawing.Point(111, 10)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX6.Size = New System.Drawing.Size(39, 15)
        Me.LabelX6.TabIndex = 200
        Me.LabelX6.Text = "NOTE :"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX7.Location = New System.Drawing.Point(156, 10)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX7.Size = New System.Drawing.Size(264, 15)
        Me.LabelX7.TabIndex = 199
        Me.LabelX7.Text = "Double Click on Subject in the list to Enter Grades . . ."
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.Image = Global.SchoolMGT.My.Resources.Resources.Print_24x24
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 29)
        Me.btnPrint.TabIndex = 145
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Tooltip = "Clear Filter"
        '
        'isAllowedEdit
        '
        Me.isAllowedEdit.Location = New System.Drawing.Point(728, 112)
        Me.isAllowedEdit.Name = "isAllowedEdit"
        Me.isAllowedEdit.Size = New System.Drawing.Size(30, 20)
        Me.isAllowedEdit.TabIndex = 150
        Me.isAllowedEdit.Text = "0"
        Me.isAllowedEdit.Visible = False
        '
        'txtBatchID
        '
        Me.txtBatchID.AccessibleName = "rooms"
        Me.txtBatchID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtBatchID.Border.Class = "TextBoxBorder"
        Me.txtBatchID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchID.Enabled = False
        Me.txtBatchID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtBatchID.FocusHighlightEnabled = True
        Me.txtBatchID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBatchID.Location = New System.Drawing.Point(652, 110)
        Me.txtBatchID.MaxLength = 30
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.ReadOnly = True
        Me.txtBatchID.Size = New System.Drawing.Size(70, 20)
        Me.txtBatchID.TabIndex = 149
        Me.txtBatchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchID.Visible = False
        '
        'txtCatID
        '
        Me.txtCatID.AccessibleName = "rooms"
        Me.txtCatID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtCatID.Border.Class = "TextBoxBorder"
        Me.txtCatID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCatID.Enabled = False
        Me.txtCatID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCatID.FocusHighlightEnabled = True
        Me.txtCatID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCatID.Location = New System.Drawing.Point(653, 60)
        Me.txtCatID.MaxLength = 30
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.ReadOnly = True
        Me.txtCatID.Size = New System.Drawing.Size(70, 20)
        Me.txtCatID.TabIndex = 144
        Me.txtCatID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCatID.Visible = False
        '
        'txtStudentID
        '
        Me.txtStudentID.AccessibleName = "rooms"
        Me.txtStudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtStudentID.Border.Class = "TextBoxBorder"
        Me.txtStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtStudentID.FocusHighlightEnabled = True
        Me.txtStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStudentID.Location = New System.Drawing.Point(652, 133)
        Me.txtStudentID.MaxLength = 30
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(70, 20)
        Me.txtStudentID.TabIndex = 143
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStudentID.Visible = False
        '
        'txtAdmissionNo
        '
        Me.txtAdmissionNo.AccessibleName = "rooms"
        Me.txtAdmissionNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtAdmissionNo.Border.Class = "TextBoxBorder"
        Me.txtAdmissionNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdmissionNo.Enabled = False
        Me.txtAdmissionNo.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtAdmissionNo.FocusHighlightEnabled = True
        Me.txtAdmissionNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdmissionNo.Location = New System.Drawing.Point(150, 133)
        Me.txtAdmissionNo.MaxLength = 30
        Me.txtAdmissionNo.Name = "txtAdmissionNo"
        Me.txtAdmissionNo.ReadOnly = True
        Me.txtAdmissionNo.Size = New System.Drawing.Size(497, 20)
        Me.txtAdmissionNo.TabIndex = 142
        Me.txtAdmissionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(29, 137)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(115, 15)
        Me.LabelX5.TabIndex = 141
        Me.LabelX5.Text = "ADMISSION NUMBER"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(29, 65)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(64, 15)
        Me.LabelX4.TabIndex = 140
        Me.LabelX4.Text = "CATEGORY"
        '
        'txtCategory
        '
        Me.txtCategory.AccessibleName = "rooms"
        Me.txtCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtCategory.Border.Class = "TextBoxBorder"
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Enabled = False
        Me.txtCategory.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCategory.FocusHighlightEnabled = True
        Me.txtCategory.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCategory.Location = New System.Drawing.Point(150, 60)
        Me.txtCategory.MaxLength = 30
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(497, 20)
        Me.txtCategory.TabIndex = 139
        Me.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(29, 27)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(96, 15)
        Me.LabelX3.TabIndex = 138
        Me.LabelX3.Text = "STUDENTS NAME"
        '
        'txtStudentName
        '
        Me.txtStudentName.AccessibleName = "rooms"
        Me.txtStudentName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtStudentName.Border.Class = "TextBoxBorder"
        Me.txtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtStudentName.FocusHighlightEnabled = True
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStudentName.Location = New System.Drawing.Point(150, 14)
        Me.txtStudentName.MaxLength = 30
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(497, 40)
        Me.txtStudentName.TabIndex = 137
        Me.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(29, 114)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(92, 15)
        Me.LabelX1.TabIndex = 136
        Me.LabelX1.Text = "BATCH/SECTION"
        '
        'txtBatchName
        '
        Me.txtBatchName.AccessibleName = ""
        Me.txtBatchName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtBatchName.Border.Class = "TextBoxBorder"
        Me.txtBatchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchName.Enabled = False
        Me.txtBatchName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtBatchName.FocusHighlightEnabled = True
        Me.txtBatchName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBatchName.Location = New System.Drawing.Point(150, 110)
        Me.txtBatchName.MaxLength = 30
        Me.txtBatchName.Name = "txtBatchName"
        Me.txtBatchName.ReadOnly = True
        Me.txtBatchName.Size = New System.Drawing.Size(497, 20)
        Me.txtBatchName.TabIndex = 135
        Me.txtBatchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(29, 89)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(92, 15)
        Me.LabelX2.TabIndex = 134
        Me.LabelX2.Text = "COURSE/GRADE"
        '
        'txtCoursename
        '
        Me.txtCoursename.AccessibleName = "rooms"
        Me.txtCoursename.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtCoursename.Border.Class = "TextBoxBorder"
        Me.txtCoursename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCoursename.Enabled = False
        Me.txtCoursename.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCoursename.FocusHighlightEnabled = True
        Me.txtCoursename.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCoursename.Location = New System.Drawing.Point(150, 85)
        Me.txtCoursename.MaxLength = 30
        Me.txtCoursename.Name = "txtCoursename"
        Me.txtCoursename.ReadOnly = True
        Me.txtCoursename.Size = New System.Drawing.Size(497, 20)
        Me.txtCoursename.TabIndex = 133
        Me.txtCoursename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fmaStudentsGradingPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 562)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaStudentsGradingPeriod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT GRADING LIST"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSubjectGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShortcutToGradingPeriodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents isAllowedEdit As TextBox
    Friend WithEvents txtBatchID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCatID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtStudentID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAdmissionNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCategory As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStudentName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatchName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCoursename As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvSubjectGrade As DataGridView
End Class
