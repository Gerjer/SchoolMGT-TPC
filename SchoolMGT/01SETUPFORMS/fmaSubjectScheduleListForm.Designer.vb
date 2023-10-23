<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaSubjectScheduleListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaSubjectScheduleListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtclassname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtclasscode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.grpBoxSearch = New System.Windows.Forms.GroupBox()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtSubject = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtBatchName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCoursename = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpBoxSearch.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.tdbViewer)
        Me.GroupPanel2.Controls.Add(Me.PanelEx1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1054, 484)
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
        'tdbViewer
        '
        Me.tdbViewer.AllowFilter = False
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "Details"
        Me.tdbViewer.CaptionHeight = 17
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 172)
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
        Me.tdbViewer.RowHeight = 15
        Me.tdbViewer.RowSubDividerColor = System.Drawing.Color.Navy
        Me.tdbViewer.Size = New System.Drawing.Size(1048, 306)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 21
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.grpBoxSearch)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1048, 172)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Azure
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.MediumAquamarine
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtclassname)
        Me.GroupBox1.Controls.Add(Me.txtclasscode)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Location = New System.Drawing.Point(658, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 118)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Class Description"
        '
        'txtclassname
        '
        Me.txtclassname.AccessibleName = "rooms"
        Me.txtclassname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtclassname.Border.Class = "TextBoxBorder"
        Me.txtclassname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclassname.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtclassname.FocusHighlightEnabled = True
        Me.txtclassname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtclassname.Location = New System.Drawing.Point(139, 63)
        Me.txtclassname.MaxLength = 30
        Me.txtclassname.Name = "txtclassname"
        Me.txtclassname.ReadOnly = True
        Me.txtclassname.Size = New System.Drawing.Size(236, 26)
        Me.txtclassname.TabIndex = 23
        Me.txtclassname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtclasscode
        '
        Me.txtclasscode.AccessibleName = "rooms"
        Me.txtclasscode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtclasscode.Border.Class = "TextBoxBorder"
        Me.txtclasscode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclasscode.Enabled = False
        Me.txtclasscode.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtclasscode.FocusHighlightEnabled = True
        Me.txtclasscode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtclasscode.Location = New System.Drawing.Point(139, 30)
        Me.txtclasscode.MaxLength = 30
        Me.txtclasscode.Name = "txtclasscode"
        Me.txtclasscode.ReadOnly = True
        Me.txtclasscode.Size = New System.Drawing.Size(236, 26)
        Me.txtclasscode.TabIndex = 22
        Me.txtclasscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(18, 63)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(105, 21)
        Me.LabelX5.TabIndex = 21
        Me.LabelX5.Tag = ""
        Me.LabelX5.Text = "CLASS NAME"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(18, 34)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(105, 21)
        Me.LabelX4.TabIndex = 20
        Me.LabelX4.Text = "CLASS CODE"
        '
        'grpBoxSearch
        '
        Me.grpBoxSearch.Controls.Add(Me.txtSubjectID)
        Me.grpBoxSearch.Controls.Add(Me.txtBatchID)
        Me.grpBoxSearch.Controls.Add(Me.txtCourseID)
        Me.grpBoxSearch.Controls.Add(Me.LabelX3)
        Me.grpBoxSearch.Controls.Add(Me.txtSubject)
        Me.grpBoxSearch.Controls.Add(Me.LabelX1)
        Me.grpBoxSearch.Controls.Add(Me.txtBatchName)
        Me.grpBoxSearch.Controls.Add(Me.LabelX2)
        Me.grpBoxSearch.Controls.Add(Me.txtCoursename)
        Me.grpBoxSearch.Location = New System.Drawing.Point(9, 9)
        Me.grpBoxSearch.Name = "grpBoxSearch"
        Me.grpBoxSearch.Size = New System.Drawing.Size(643, 119)
        Me.grpBoxSearch.TabIndex = 28
        Me.grpBoxSearch.TabStop = False
        Me.grpBoxSearch.Text = "Search Conditions"
        '
        'txtSubjectID
        '
        Me.txtSubjectID.Location = New System.Drawing.Point(617, 79)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(42, 26)
        Me.txtSubjectID.TabIndex = 110
        Me.txtSubjectID.Visible = False
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(617, 48)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(18, 26)
        Me.txtBatchID.TabIndex = 109
        Me.txtBatchID.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(617, 21)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(18, 26)
        Me.txtCourseID.TabIndex = 108
        Me.txtCourseID.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(6, 85)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 21)
        Me.LabelX3.TabIndex = 23
        Me.LabelX3.Text = "SUBJECT"
        '
        'txtSubject
        '
        Me.txtSubject.AccessibleName = "rooms"
        Me.txtSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtSubject.Border.Class = "TextBoxBorder"
        Me.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubject.Enabled = False
        Me.txtSubject.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSubject.FocusHighlightEnabled = True
        Me.txtSubject.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSubject.Location = New System.Drawing.Point(146, 80)
        Me.txtSubject.MaxLength = 30
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(465, 26)
        Me.txtSubject.TabIndex = 22
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(6, 53)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(111, 21)
        Me.LabelX1.TabIndex = 21
        Me.LabelX1.Text = "BATCH/LEVEL"
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
        Me.txtBatchName.Location = New System.Drawing.Point(146, 50)
        Me.txtBatchName.MaxLength = 30
        Me.txtBatchName.Name = "txtBatchName"
        Me.txtBatchName.ReadOnly = True
        Me.txtBatchName.Size = New System.Drawing.Size(465, 26)
        Me.txtBatchName.TabIndex = 20
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(6, 26)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(132, 21)
        Me.LabelX2.TabIndex = 19
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
        Me.txtCoursename.Location = New System.Drawing.Point(146, 21)
        Me.txtCoursename.MaxLength = 30
        Me.txtCoursename.Name = "txtCoursename"
        Me.txtCoursename.ReadOnly = True
        Me.txtCoursename.Size = New System.Drawing.Size(465, 26)
        Me.txtCoursename.TabIndex = 18
        Me.txtCoursename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Controls.Add(Me.btnSearch)
        Me.GroupPanel1.Controls.Add(Me.btnEdit)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Controls.Add(Me.btnDelete)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 134)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1048, 38)
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
        Me.GroupPanel1.TabIndex = 21
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.SchoolMGT.My.Resources.Resources.Print_24x24
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(391, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(86, 32)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.SchoolMGT.My.Resources.Resources.zoom
        Me.btnSearch.Location = New System.Drawing.Point(258, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 32)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Show Filter Bar"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(172, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 32)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(956, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(86, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem1})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(184, 56)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'DeleteSelectedToolStripMenuItem1
        '
        Me.DeleteSelectedToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSelectedToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSelectedToolStripMenuItem1.Name = "DeleteSelectedToolStripMenuItem1"
        Me.DeleteSelectedToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DeleteSelectedToolStripMenuItem1.Text = "Edit Selected"
        '
        'fmaSubjectScheduleListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1054, 484)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaSubjectScheduleListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Subject/Schedule List"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpBoxSearch.ResumeLayout(False)
        Me.grpBoxSearch.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpBoxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCoursename As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatchName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSubject As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchID As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtclassname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtclasscode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
