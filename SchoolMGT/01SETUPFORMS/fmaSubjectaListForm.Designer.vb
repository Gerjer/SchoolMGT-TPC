<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaSubjectaListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaSubjectaListForm))
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtElectives = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtElectiveID = New System.Windows.Forms.TextBox()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignSubjectLimitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cmbyearbatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.tdbViewer.Caption = "SUBJECT"
        Me.tdbViewer.CaptionHeight = 30
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 152)
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
        Me.tdbViewer.Size = New System.Drawing.Size(1133, 241)
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
        Me.GroupBox1.Controls.Add(Me.PanelEx1)
        Me.GroupBox1.Controls.Add(Me.txtElectiveID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 152)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.Color.Transparent
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.cmbyearbatch)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.cmbCourse)
        Me.PanelEx1.Controls.Add(Me.txtCourseID)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.txtElectives)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.cmbBatch)
        Me.PanelEx1.Controls.Add(Me.txtBatchID)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(3, 16)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1127, 133)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.Color = System.Drawing.SystemColors.ControlLightLight
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 189
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(6, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(84, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "COURSE/LEVEL"
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(105, 12)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 106
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(441, 12)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 107
        Me.txtCourseID.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(6, 58)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(39, 15)
        Me.LabelX2.TabIndex = 108
        Me.LabelX2.Text = "BATCH"
        '
        'txtElectives
        '
        Me.txtElectives.AccessibleName = ""
        Me.txtElectives.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtElectives.Border.Class = "TextBoxBorder"
        Me.txtElectives.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtElectives.FocusHighlightEnabled = True
        Me.txtElectives.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtElectives.Location = New System.Drawing.Point(585, 10)
        Me.txtElectives.Name = "txtElectives"
        Me.txtElectives.ReadOnly = True
        Me.txtElectives.Size = New System.Drawing.Size(330, 20)
        Me.txtElectives.TabIndex = 182
        Me.txtElectives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtElectives.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(486, 15)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 15)
        Me.LabelX3.TabIndex = 115
        Me.LabelX3.Text = "GROUP NAME"
        Me.LabelX3.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DisplayMember = "Text"
        Me.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.ItemHeight = 14
        Me.cmbBatch.Location = New System.Drawing.Point(105, 56)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 109
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(441, 56)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 110
        Me.txtBatchID.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 95)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1127, 38)
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
        Me.GroupPanel1.TabIndex = 188
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelX5)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(572, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 32)
        Me.Panel2.TabIndex = 188
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.ForeColor = System.Drawing.Color.Red
        Me.LabelX5.Location = New System.Drawing.Point(15, 9)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX5.Size = New System.Drawing.Size(38, 15)
        Me.LabelX5.TabIndex = 202
        Me.LabelX5.Text = "NOTE :"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX4.Location = New System.Drawing.Point(56, 9)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX4.Size = New System.Drawing.Size(351, 15)
        Me.LabelX4.TabIndex = 201
        Me.LabelX4.Text = "Right click on Subject List to  assign Schedule / view Enrolled Student..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnClearFilter)
        Me.Panel1.Controls.Add(Me.btnSearchCondition)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 32)
        Me.Panel1.TabIndex = 187
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(456, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 32)
        Me.btnEdit.TabIndex = 186
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(342, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 32)
        Me.btnDelete.TabIndex = 185
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Enabled = False
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(228, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 32)
        Me.btnAdd.TabIndex = 184
        Me.btnAdd.Text = "Add Subject"
        Me.btnAdd.Tooltip = "Add New Subject"
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClearFilter.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClearFilter.Location = New System.Drawing.Point(114, 0)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 32)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'btnSearchCondition
        '
        Me.btnSearchCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchCondition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearchCondition.Enabled = False
        Me.btnSearchCondition.Image = Global.SchoolMGT.My.Resources.Resources.zoom
        Me.btnSearchCondition.Location = New System.Drawing.Point(0, 0)
        Me.btnSearchCondition.Name = "btnSearchCondition"
        Me.btnSearchCondition.Size = New System.Drawing.Size(114, 32)
        Me.btnSearchCondition.TabIndex = 111
        Me.btnSearchCondition.Text = "Search"
        Me.btnSearchCondition.Tooltip = "Search"
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(1035, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtElectiveID
        '
        Me.txtElectiveID.Location = New System.Drawing.Point(924, 18)
        Me.txtElectiveID.Name = "txtElectiveID"
        Me.txtElectiveID.Size = New System.Drawing.Size(30, 20)
        Me.txtElectiveID.TabIndex = 183
        Me.txtElectiveID.Visible = False
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAssessmentToolStripMenuItem, Me.StatementOfAccountToolStripMenuItem, Me.AssignSubjectLimitToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(207, 70)
        '
        'ViewAssessmentToolStripMenuItem
        '
        Me.ViewAssessmentToolStripMenuItem.Name = "ViewAssessmentToolStripMenuItem"
        Me.ViewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ViewAssessmentToolStripMenuItem.Text = "View Schedule/Instructor"
        '
        'StatementOfAccountToolStripMenuItem
        '
        Me.StatementOfAccountToolStripMenuItem.Name = "StatementOfAccountToolStripMenuItem"
        Me.StatementOfAccountToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.StatementOfAccountToolStripMenuItem.Text = "View Enrolled Students"
        '
        'AssignSubjectLimitToolStripMenuItem
        '
        Me.AssignSubjectLimitToolStripMenuItem.Name = "AssignSubjectLimitToolStripMenuItem"
        Me.AssignSubjectLimitToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AssignSubjectLimitToolStripMenuItem.Text = "Assign Subject Limit"
        Me.AssignSubjectLimitToolStripMenuItem.Visible = False
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.Location = New System.Drawing.Point(6, 36)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(71, 15)
        Me.LabelX6.TabIndex = 189
        Me.LabelX6.Text = "BATCH YEAR"
        '
        'cmbyearbatch
        '
        Me.cmbyearbatch.DisplayMember = "Text"
        Me.cmbyearbatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbyearbatch.FormattingEnabled = True
        Me.cmbyearbatch.ItemHeight = 14
        Me.cmbyearbatch.Location = New System.Drawing.Point(105, 34)
        Me.cmbyearbatch.Name = "cmbyearbatch"
        Me.cmbyearbatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbyearbatch.TabIndex = 190
        '
        'fmaSubjectaListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaSubjectaListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatchID As System.Windows.Forms.TextBox
    Friend WithEvents cmbBatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearchCondition As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ViewAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtElectives As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtElectiveID As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnClose As Button
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents AssignSubjectLimitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbyearbatch As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
