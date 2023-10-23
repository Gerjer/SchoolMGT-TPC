<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaStudentsGradeEntryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaStudentsGradeEntryForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFinalGrades = New System.Windows.Forms.TextBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtGivenFinalGrades = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtGradePerioID = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcMultipleEntryGrade = New DevExpress.XtraGrid.GridControl()
        Me.gvMultipleEntryGrade = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks1 = New System.Windows.Forms.TextBox()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtGradeReExam = New System.Windows.Forms.TextBox()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtStudentname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtStudentSubjectID = New System.Windows.Forms.TextBox()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcMultipleEntryGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMultipleEntryGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
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
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.tdbViewer)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(723, 499)
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
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtFinalGrades)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.LabelX10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 444)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(717, 49)
        Me.Panel1.TabIndex = 205
        '
        'txtFinalGrades
        '
        Me.txtFinalGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalGrades.ForeColor = System.Drawing.Color.Red
        Me.txtFinalGrades.Location = New System.Drawing.Point(9, 6)
        Me.txtFinalGrades.Multiline = True
        Me.txtFinalGrades.Name = "txtFinalGrades"
        Me.txtFinalGrades.Size = New System.Drawing.Size(135, 32)
        Me.txtFinalGrades.TabIndex = 203
        Me.txtFinalGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(40, 25)
        Me.ButtonX1.Location = New System.Drawing.Point(532, 8)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(177, 33)
        Me.ButtonX1.TabIndex = 204
        Me.ButtonX1.Text = "Set as Final Grade"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.Red
        Me.LabelX10.Location = New System.Drawing.Point(152, 8)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(102, 27)
        Me.LabelX10.TabIndex = 202
        Me.LabelX10.Text = "AVERAGE"
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
        Me.tdbViewer.Location = New System.Drawing.Point(0, 325)
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
        Me.tdbViewer.Size = New System.Drawing.Size(717, 168)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 25
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.XtraTabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupPanel3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtStudentname)
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtStudentSubjectID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 325)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.Header.BorderColor = System.Drawing.Color.Black
        Me.XtraTabControl1.AppearancePage.Header.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseBorderColor = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.RoyalBlue
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = True
        Me.XtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.XtraTabControl1.Location = New System.Drawing.Point(17, 74)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(517, 203)
        Me.XtraTabControl1.TabIndex = 206
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupPanel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(511, 175)
        Me.XtraTabPage1.Text = "Single Entry"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.LabelX1)
        Me.GroupPanel4.Controls.Add(Me.txtGivenFinalGrades)
        Me.GroupPanel4.Controls.Add(Me.cmbCategory)
        Me.GroupPanel4.Controls.Add(Me.LabelX11)
        Me.GroupPanel4.Controls.Add(Me.txtGradePerioID)
        Me.GroupPanel4.Controls.Add(Me.txtRemarks)
        Me.GroupPanel4.Controls.Add(Me.LabelX3)
        Me.GroupPanel4.Controls.Add(Me.LabelX9)
        Me.GroupPanel4.Controls.Add(Me.txtGrade)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(511, 175)
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
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 51
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(7, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(96, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "GRADING PERIOD"
        '
        'txtGivenFinalGrades
        '
        Me.txtGivenFinalGrades.Location = New System.Drawing.Point(112, 146)
        Me.txtGivenFinalGrades.Name = "txtGivenFinalGrades"
        Me.txtGivenFinalGrades.Size = New System.Drawing.Size(76, 20)
        Me.txtGivenFinalGrades.TabIndex = 205
        Me.txtGivenFinalGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCategory
        '
        Me.cmbCategory.DisplayMember = "Text"
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 14
        Me.cmbCategory.Location = New System.Drawing.Point(112, 9)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(330, 20)
        Me.cmbCategory.TabIndex = 106
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(10, 151)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(73, 15)
        Me.LabelX11.TabIndex = 204
        Me.LabelX11.Text = "FINAL GRADE"
        '
        'txtGradePerioID
        '
        Me.txtGradePerioID.Location = New System.Drawing.Point(307, 35)
        Me.txtGradePerioID.Name = "txtGradePerioID"
        Me.txtGradePerioID.Size = New System.Drawing.Size(63, 20)
        Me.txtGradePerioID.TabIndex = 107
        Me.txtGradePerioID.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(112, 66)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(330, 75)
        Me.txtRemarks.TabIndex = 203
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(10, 40)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(48, 15)
        Me.LabelX3.TabIndex = 192
        Me.LabelX3.Text = "GRADES"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(10, 66)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(55, 15)
        Me.LabelX9.TabIndex = 201
        Me.LabelX9.Text = "REMARKS"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(112, 37)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(76, 20)
        Me.txtGrade.TabIndex = 198
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcMultipleEntryGrade)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(511, 175)
        Me.XtraTabPage2.Text = "Mutiple Entry"
        '
        'gcMultipleEntryGrade
        '
        Me.gcMultipleEntryGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMultipleEntryGrade.Location = New System.Drawing.Point(0, 0)
        Me.gcMultipleEntryGrade.MainView = Me.gvMultipleEntryGrade
        Me.gcMultipleEntryGrade.Name = "gcMultipleEntryGrade"
        Me.gcMultipleEntryGrade.Size = New System.Drawing.Size(511, 175)
        Me.gcMultipleEntryGrade.TabIndex = 0
        Me.gcMultipleEntryGrade.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMultipleEntryGrade, Me.GridView1})
        '
        'gvMultipleEntryGrade
        '
        Me.gvMultipleEntryGrade.GridControl = Me.gcMultipleEntryGrade
        Me.gvMultipleEntryGrade.Name = "gvMultipleEntryGrade"
        Me.gvMultipleEntryGrade.OptionsView.ShowGroupPanel = False
        Me.gvMultipleEntryGrade.OptionsView.ShowIndicator = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcMultipleEntryGrade
        Me.GridView1.Name = "GridView1"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupPanel5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(511, 175)
        Me.XtraTabPage3.Text = "Re-exam"
        '
        'GroupPanel5
        '
        Me.GroupPanel5.AutoScroll = True
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.ButtonX2)
        Me.GroupPanel5.Controls.Add(Me.GroupPanel6)
        Me.GroupPanel5.Controls.Add(Me.txtRemarks1)
        Me.GroupPanel5.Controls.Add(Me.LabelX14)
        Me.GroupPanel5.Controls.Add(Me.txtGradeReExam)
        Me.GroupPanel5.Controls.Add(Me.LabelX15)
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(511, 175)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 52
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(30, 25)
        Me.ButtonX2.Location = New System.Drawing.Point(207, 45)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.ButtonX2.Size = New System.Drawing.Size(163, 32)
        Me.ButtonX2.TabIndex = 250
        Me.ButtonX2.Text = "Set as Re-Exam Grade"
        Me.ButtonX2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'GroupPanel6
        '
        Me.GroupPanel6.AutoScroll = True
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.WinLabel)
        Me.GroupPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(505, 37)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 249
        '
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.WinLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(503, 35)
        Me.WinLabel.TabIndex = 245
        Me.WinLabel.Text = "RE-EXAM"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtRemarks1
        '
        Me.txtRemarks1.Location = New System.Drawing.Point(112, 84)
        Me.txtRemarks1.Multiline = True
        Me.txtRemarks1.Name = "txtRemarks1"
        Me.txtRemarks1.Size = New System.Drawing.Size(330, 75)
        Me.txtRemarks1.TabIndex = 203
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(10, 60)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(48, 15)
        Me.LabelX14.TabIndex = 192
        Me.LabelX14.Text = "GRADES"
        '
        'txtGradeReExam
        '
        Me.txtGradeReExam.Location = New System.Drawing.Point(112, 55)
        Me.txtGradeReExam.Name = "txtGradeReExam"
        Me.txtGradeReExam.Size = New System.Drawing.Size(76, 20)
        Me.txtGradeReExam.TabIndex = 198
        Me.txtGradeReExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(10, 89)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(55, 15)
        Me.LabelX15.TabIndex = 201
        Me.LabelX15.Text = "REMARKS"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.LabelX5)
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.LabelX8)
        Me.GroupPanel3.Controls.Add(Me.LabelX6)
        Me.GroupPanel3.Controls.Add(Me.LabelX7)
        Me.GroupPanel3.Location = New System.Drawing.Point(541, 87)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(175, 188)
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
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 202
        Me.GroupPanel3.Text = "GRADE VALUE"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX5.Location = New System.Drawing.Point(13, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(84, 15)
        Me.LabelX5.TabIndex = 195
        Me.LabelX5.Text = "1.0 - 3.0  - PASS"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX4.Location = New System.Drawing.Point(13, 20)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(78, 15)
        Me.LabelX4.TabIndex = 196
        Me.LabelX4.Text = "3.1 - 5.0  - FAIL"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX8.Location = New System.Drawing.Point(13, 75)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(126, 15)
        Me.LabelX8.TabIndex = 200
        Me.LabelX8.Text = "INC         - INCOMPLETE"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX6.Location = New System.Drawing.Point(13, 36)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(121, 15)
        Me.LabelX6.TabIndex = 197
        Me.LabelX6.Text = "NG          - NO GRADES"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX7.Location = New System.Drawing.Point(13, 54)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(109, 15)
        Me.LabelX7.TabIndex = 199
        Me.LabelX7.Text = "DR          - DROPPED"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(17, 36)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(96, 15)
        Me.LabelX2.TabIndex = 189
        Me.LabelX2.Text = "STUDENTS NAME"
        '
        'txtStudentname
        '
        Me.txtStudentname.AccessibleName = "rooms"
        Me.txtStudentname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtStudentname.Border.Class = "TextBoxBorder"
        Me.txtStudentname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStudentname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentname.Enabled = False
        Me.txtStudentname.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtStudentname.FocusHighlightEnabled = True
        Me.txtStudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStudentname.Location = New System.Drawing.Point(132, 21)
        Me.txtStudentname.MaxLength = 30
        Me.txtStudentname.Multiline = True
        Me.txtStudentname.Name = "txtStudentname"
        Me.txtStudentname.ReadOnly = True
        Me.txtStudentname.Size = New System.Drawing.Size(493, 40)
        Me.txtStudentname.TabIndex = 188
        Me.txtStudentname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.btnEdit)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 281)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(711, 41)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 111
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(612, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 35)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Close"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(144, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(126, 35)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit Grades"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 35)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Apply Grades"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(496, 20)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(63, 20)
        Me.txtStudentID.TabIndex = 190
        Me.txtStudentID.Visible = False
        '
        'txtStudentSubjectID
        '
        Me.txtStudentSubjectID.Location = New System.Drawing.Point(565, 19)
        Me.txtStudentSubjectID.Name = "txtStudentSubjectID"
        Me.txtStudentSubjectID.Size = New System.Drawing.Size(60, 20)
        Me.txtStudentSubjectID.TabIndex = 191
        Me.txtStudentSubjectID.Visible = False
        '
        'fmaStudentsGradeEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(723, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaStudentsGradeEntryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Fee"
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcMultipleEntryGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMultipleEntryGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel5.PerformLayout()
        Me.GroupPanel6.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStudentname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtStudentSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtFinalGrades As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtGivenFinalGrades As TextBox
    Friend WithEvents cmbCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGradePerioID As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcMultipleEntryGrade As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMultipleEntryGrade As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtRemarks1 As TextBox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGradeReExam As TextBox
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Protected WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As Panel
End Class
