<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaChedEListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaChedEListForm))
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
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.cxbxIncludeNotEnrolled = New System.Windows.Forms.CheckBox()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbyearbatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tdbViewer.Location = New System.Drawing.Point(0, 252)
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
        Me.tdbViewer.Size = New System.Drawing.Size(1133, 141)
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
        Me.GroupBox1.Controls.Add(Me.txtYearLevel)
        Me.GroupBox1.Controls.Add(Me.cxbxIncludeNotEnrolled)
        Me.GroupBox1.Controls.Add(Me.GroupPanel4)
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.txtBatchID)
        Me.GroupBox1.Controls.Add(Me.cmbBatch)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtCourseID)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 252)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Location = New System.Drawing.Point(480, 111)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(73, 20)
        Me.txtYearLevel.TabIndex = 136
        Me.txtYearLevel.Visible = False
        '
        'cxbxIncludeNotEnrolled
        '
        Me.cxbxIncludeNotEnrolled.AutoSize = True
        Me.cxbxIncludeNotEnrolled.Checked = True
        Me.cxbxIncludeNotEnrolled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cxbxIncludeNotEnrolled.Location = New System.Drawing.Point(108, 150)
        Me.cxbxIncludeNotEnrolled.Name = "cxbxIncludeNotEnrolled"
        Me.cxbxIncludeNotEnrolled.Size = New System.Drawing.Size(170, 17)
        Me.cxbxIncludeNotEnrolled.TabIndex = 135
        Me.cxbxIncludeNotEnrolled.Text = "Display Enrolled Students Only"
        Me.cxbxIncludeNotEnrolled.UseVisualStyleBackColor = True
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(3, 16)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1127, 29)
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
        Me.GroupPanel4.Text = "CHED E-LIST FORM"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Controls.Add(Me.btnClearFilter)
        Me.GroupPanel1.Controls.Add(Me.btnSearchCondition)
        Me.GroupPanel1.Controls.Add(Me.btnRemove)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 210)
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
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.Image = Global.SchoolMGT.My.Resources.Resources.Print_24x24
        Me.btnPrint.Location = New System.Drawing.Point(228, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 33)
        Me.btnPrint.TabIndex = 133
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Tooltip = "Search"
        Me.btnPrint.Visible = False
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
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(444, 111)
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
        Me.cmbBatch.Location = New System.Drawing.Point(108, 111)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 109
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(9, 116)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 15)
        Me.LabelX2.TabIndex = 108
        Me.LabelX2.Text = "BATCH"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(444, 66)
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
        Me.cmbCourse.Location = New System.Drawing.Point(108, 66)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 106
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(9, 71)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "COURSE/LEVEL"
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
        Me.cmbyearbatch.Location = New System.Drawing.Point(109, 89)
        Me.cmbyearbatch.Name = "cmbyearbatch"
        Me.cmbyearbatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbyearbatch.TabIndex = 138
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(10, 94)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(73, 15)
        Me.LabelX3.TabIndex = 137
        Me.LabelX3.Text = "BATCH YEAR"
        '
        'fmaChedEListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaChedEListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "2"
        Me.Text = "CHED E-LIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
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
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cxbxIncludeNotEnrolled As CheckBox
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents cmbyearbatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
