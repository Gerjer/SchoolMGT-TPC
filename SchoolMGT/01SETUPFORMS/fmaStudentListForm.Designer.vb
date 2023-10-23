<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaStudentListForm
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaStudentListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stillSpinner = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.rollingSpinner = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AssignScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewCORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbyearbatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CMenuStripOperations.SuspendLayout()
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
        Me.GroupPanel2.Controls.Add(Me.tdbViewer)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1139, 446)
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
        'tdbViewer
        '
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "STUDENT LIST"
        Me.tdbViewer.CaptionHeight = 30
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.FilterBar = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 180)
        Me.tdbViewer.MaintainRowCurrency = True
        Me.tdbViewer.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbViewer.Name = "tdbViewer"
        Me.tdbViewer.PictureAddnewRow = CType(resources.GetObject("tdbViewer.PictureAddnewRow"), System.Drawing.Image)
        Me.tdbViewer.PictureCurrentRow = CType(resources.GetObject("tdbViewer.PictureCurrentRow"), System.Drawing.Image)
        Me.tdbViewer.PictureFilterBar = CType(resources.GetObject("tdbViewer.PictureFilterBar"), System.Drawing.Image)
        Me.tdbViewer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbViewer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbViewer.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbViewer.PrintInfo.PageSettings = CType(resources.GetObject("tdbViewer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbViewer.RowDivider.Color = System.Drawing.Color.DarkBlue
        Me.tdbViewer.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.tdbViewer.RowHeight = 25
        Me.tdbViewer.RowSubDividerColor = System.Drawing.Color.Navy
        Me.tdbViewer.Size = New System.Drawing.Size(1133, 213)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 25
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stillSpinner)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.rollingSpinner)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 47)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'stillSpinner
        '
        Me.stillSpinner.Image = Global.SchoolMGT.My.Resources.Resources.spinner_static
        Me.stillSpinner.Location = New System.Drawing.Point(7, 11)
        Me.stillSpinner.Name = "stillSpinner"
        Me.stillSpinner.Size = New System.Drawing.Size(31, 32)
        Me.stillSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stillSpinner.TabIndex = 119
        Me.stillSpinner.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(44, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(330, 23)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Search ..."
        '
        'rollingSpinner
        '
        Me.rollingSpinner.Image = Global.SchoolMGT.My.Resources.Resources.spinner
        Me.rollingSpinner.Location = New System.Drawing.Point(7, 11)
        Me.rollingSpinner.Name = "rollingSpinner"
        Me.rollingSpinner.Size = New System.Drawing.Size(31, 32)
        Me.rollingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rollingSpinner.TabIndex = 117
        Me.rollingSpinner.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbyearbatch)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.GroupPanel4)
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.txtBatchID)
        Me.GroupBox1.Controls.Add(Me.cmbBatch)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtCourseID)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 180)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.LabelControl1)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(3, 16)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1127, 35)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel4.TabIndex = 134
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(430, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(173, 24)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "GRADE SHEET LIST"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.Controls.Add(Me.btnClearFilter)
        Me.GroupPanel1.Controls.Add(Me.btnSearchCondition)
        Me.GroupPanel1.Controls.Add(Me.btnRemove)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 138)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1127, 39)
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
        Me.GroupPanel1.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 133
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.LabelX7)
        Me.Panel1.Location = New System.Drawing.Point(361, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 29)
        Me.Panel1.TabIndex = 133
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.ForeColor = System.Drawing.Color.Red
        Me.LabelX6.Location = New System.Drawing.Point(74, 7)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX6.Size = New System.Drawing.Size(38, 15)
        Me.LabelX6.TabIndex = 202
        Me.LabelX6.Text = "NOTE :"
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX7.Location = New System.Drawing.Point(115, 7)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX7.Size = New System.Drawing.Size(264, 15)
        Me.LabelX7.TabIndex = 201
        Me.LabelX7.Text = "Double Click on Subject in the list to Enter Grades . . ."
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClearFilter.Image = CType(resources.GetObject("btnClearFilter.Image"), System.Drawing.Image)
        Me.btnClearFilter.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnClearFilter.Location = New System.Drawing.Point(114, 0)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 33)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'btnSearchCondition
        '
        Me.btnSearchCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchCondition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearchCondition.Image = Global.SchoolMGT.My.Resources.Resources.zoom
        Me.btnSearchCondition.Location = New System.Drawing.Point(0, 0)
        Me.btnSearchCondition.Name = "btnSearchCondition"
        Me.btnSearchCondition.Size = New System.Drawing.Size(114, 33)
        Me.btnSearchCondition.TabIndex = 111
        Me.btnSearchCondition.Text = "Search"
        Me.btnSearchCondition.Tooltip = "Search"
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRemove.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnRemove.Location = New System.Drawing.Point(1007, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(114, 33)
        Me.btnRemove.TabIndex = 132
        Me.btnRemove.Text = "Close"
        Me.btnRemove.Tooltip = "Add Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(715, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Entry fields then hit ""Enter"""
        Me.Label1.Visible = False
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(587, 81)
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(400, 32)
        Me.txtStudentName.TabIndex = 113
        Me.txtStudentName.TabStop = False
        Me.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(719, 55)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(132, 21)
        Me.LabelX3.TabIndex = 112
        Me.LabelX3.Text = "STUDENT NAME"
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(444, 110)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 110
        Me.txtBatchID.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DisplayMember = "Text"
        Me.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBatch.Enabled = False
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.ItemHeight = 14
        Me.cmbBatch.Location = New System.Drawing.Point(108, 110)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 109
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(9, 115)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 15)
        Me.LabelX2.TabIndex = 108
        Me.LabelX2.Text = "BATCH"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(444, 62)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 107
        Me.txtCourseID.Visible = False
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(108, 62)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 106
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(9, 67)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "COURSE/LEVEL"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignScheduleToolStripMenuItem, Me.ViewAssessmentToolStripMenuItem, Me.ViewGradesToolStripMenuItem, Me.PreviewCORToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(165, 92)
        '
        'AssignScheduleToolStripMenuItem
        '
        Me.AssignScheduleToolStripMenuItem.Name = "AssignScheduleToolStripMenuItem"
        Me.AssignScheduleToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AssignScheduleToolStripMenuItem.Text = "View Subjects"
        Me.AssignScheduleToolStripMenuItem.Visible = False
        '
        'ViewAssessmentToolStripMenuItem
        '
        Me.ViewAssessmentToolStripMenuItem.Name = "ViewAssessmentToolStripMenuItem"
        Me.ViewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewAssessmentToolStripMenuItem.Text = "View Assessment"
        '
        'ViewGradesToolStripMenuItem
        '
        Me.ViewGradesToolStripMenuItem.Name = "ViewGradesToolStripMenuItem"
        Me.ViewGradesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewGradesToolStripMenuItem.Text = "View Grades"
        Me.ViewGradesToolStripMenuItem.Visible = False
        '
        'PreviewCORToolStripMenuItem
        '
        Me.PreviewCORToolStripMenuItem.Name = "PreviewCORToolStripMenuItem"
        Me.PreviewCORToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PreviewCORToolStripMenuItem.Text = "Preview COR"
        Me.PreviewCORToolStripMenuItem.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Tip"
        '
        'cmbyearbatch
        '
        Me.cmbyearbatch.DisplayMember = "Text"
        Me.cmbyearbatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbyearbatch.Enabled = False
        Me.cmbyearbatch.FormattingEnabled = True
        Me.cmbyearbatch.ItemHeight = 14
        Me.cmbyearbatch.Location = New System.Drawing.Point(109, 87)
        Me.cmbyearbatch.Name = "cmbyearbatch"
        Me.cmbyearbatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbyearbatch.TabIndex = 136
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Location = New System.Drawing.Point(10, 92)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(73, 15)
        Me.LabelX4.TabIndex = 135
        Me.LabelX4.Text = "BATCH YEAR"
        '
        'fmaStudentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaStudentListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Management By Students"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatchID As System.Windows.Forms.TextBox
    Friend WithEvents cmbBatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearchCondition As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AssignScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As Label
    Friend WithEvents PreviewCORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmbyearbatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
