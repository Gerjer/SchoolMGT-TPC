<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaGroupedCoursesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaGroupedCoursesForm))
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
        Me.groupcoursesID = New System.Windows.Forms.TextBox()
        Me.txtOrder = New DevComponents.Editors.IntegerInput()
        Me.lblOrder = New DevComponents.DotNetBar.LabelX()
        Me.lblCourse = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseNameID = New System.Windows.Forms.TextBox()
        Me.cmbCourseName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTimer = New DevComponents.DotNetBar.LabelX()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.pbxSearch = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupPanel2.Size = New System.Drawing.Size(654, 446)
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
        Me.tdbViewer.AllowFilter = False
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "Details"
        Me.tdbViewer.CaptionHeight = 30
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 161)
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
        Me.tdbViewer.Size = New System.Drawing.Size(648, 232)
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
        Me.GroupBox2.Size = New System.Drawing.Size(648, 47)
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
        Me.GroupBox1.Controls.Add(Me.groupcoursesID)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.lblOrder)
        Me.GroupBox1.Controls.Add(Me.lblCourse)
        Me.GroupBox1.Controls.Add(Me.txtCourseNameID)
        Me.GroupBox1.Controls.Add(Me.cmbCourseName)
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.lblTimer)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtCourseID)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.pbxSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 161)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'groupcoursesID
        '
        Me.groupcoursesID.Location = New System.Drawing.Point(502, 59)
        Me.groupcoursesID.Name = "groupcoursesID"
        Me.groupcoursesID.Size = New System.Drawing.Size(30, 20)
        Me.groupcoursesID.TabIndex = 122
        Me.groupcoursesID.Visible = False
        '
        'txtOrder
        '
        '
        '
        '
        Me.txtOrder.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtOrder.Location = New System.Drawing.Point(108, 85)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ShowUpDown = True
        Me.txtOrder.Size = New System.Drawing.Size(80, 20)
        Me.txtOrder.TabIndex = 121
        Me.txtOrder.Visible = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(9, 90)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(74, 15)
        Me.lblOrder.TabIndex = 120
        Me.lblOrder.Text = "DISP. ORDER"
        Me.lblOrder.Visible = False
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(9, 64)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 15)
        Me.lblCourse.TabIndex = 118
        Me.lblCourse.Text = "BATCH"
        Me.lblCourse.Visible = False
        '
        'txtCourseNameID
        '
        Me.txtCourseNameID.Location = New System.Drawing.Point(444, 59)
        Me.txtCourseNameID.Name = "txtCourseNameID"
        Me.txtCourseNameID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseNameID.TabIndex = 117
        Me.txtCourseNameID.Visible = False
        '
        'cmbCourseName
        '
        Me.cmbCourseName.DisplayMember = "Text"
        Me.cmbCourseName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourseName.FormattingEnabled = True
        Me.cmbCourseName.ItemHeight = 14
        Me.cmbCourseName.Location = New System.Drawing.Point(108, 59)
        Me.cmbCourseName.Name = "cmbCourseName"
        Me.cmbCourseName.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourseName.TabIndex = 116
        Me.cmbCourseName.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnDelete)
        Me.GroupPanel1.Controls.Add(Me.btnEdit)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 120)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(642, 38)
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
        Me.GroupPanel1.TabIndex = 115
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(244, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(158, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 32)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(550, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(547, 43)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(75, 23)
        Me.lblTimer.TabIndex = 114
        Me.lblTimer.Text = "0"
        Me.lblTimer.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(480, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 13)
        Me.LinkLabel1.TabIndex = 108
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Course Group"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(592, 17)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 107
        Me.txtCourseID.Visible = False
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(108, 21)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 106
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(9, 26)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "COURSE GROUP"
        '
        'pbxSearch
        '
        Me.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSearch.Image = Global.SchoolMGT.My.Resources.Resources.loading_2
        Me.pbxSearch.Location = New System.Drawing.Point(423, 3)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(93, 50)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 113
        Me.pbxSearch.TabStop = False
        Me.pbxSearch.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'fmaGroupedCoursesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaGroupedCoursesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GROUP COURSE LEVEL"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents pbxSearch As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblCourse As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCourseNameID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourseName As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblOrder As DevComponents.DotNetBar.LabelX
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtOrder As DevComponents.Editors.IntegerInput
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents groupcoursesID As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
