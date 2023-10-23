<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaRegistrarTORPrinting
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaRegistrarTORPrinting))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem14 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.lblCourse = New DevComponents.DotNetBar.LabelX()
        Me.txtClassrollNumber = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHEDFORM9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuStripOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.EmbeddedNavigator.ToolTipController = Me.ToolTipController1
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(778, 289)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ToolTipController = Me.ToolTipController1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.CardView1})
        '
        'ToolTipController1
        '
        Me.ToolTipController1.AllowHtmlText = True
        Me.ToolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolTipController1.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolTipController1.Appearance.Options.UseBackColor = True
        Me.ToolTipController1.Appearance.Options.UseForeColor = True
        Me.ToolTipController1.AppearanceTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolTipController1.AppearanceTitle.Options.UseBackColor = True
        Me.ToolTipController1.AppearanceTitle.Options.UseForeColor = True
        Me.ToolTipController1.AppearanceTitle.Options.UseTextOptions = True
        Me.ToolTipController1.AppearanceTitle.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ToolTipController1.IconSize = DevExpress.Utils.ToolTipIconSize.Large
        Me.ToolTipController1.KeepWhileHovered = True
        Me.ToolTipController1.Rounded = True
        Me.ToolTipController1.RoundRadius = 15
        Me.ToolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.WindowsXP
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn10, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 3
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "COURSE"
        Me.GridColumn1.FieldName = "GroupCouse"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "DEGREE PROGRAM"
        Me.GridColumn2.FieldName = "CourseName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "BATCH"
        Me.GridColumn3.FieldName = "BatchName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn4.Caption = "SUBJECT CODE"
        Me.GridColumn4.FieldName = "subjcode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 150
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn5.Caption = "SUBJECT"
        Me.GridColumn5.FieldName = "subjname"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 400
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn6.Caption = "FINAL GRADE"
        Me.GridColumn6.FieldName = "finalgrade"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 150
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn7.Caption = "RE-EXAM"
        Me.GridColumn7.FieldName = "re_exam"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 150
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.FieldName = "id"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "StdSubjectID"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "class_roll_no"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'RepositoryItemButtonEdit1
        '
        ToolTipTitleItem2.ImageOptions.ImageUri.Uri = "Save;Size16x16"
        ToolTipTitleItem2.Text = "Apply Re-Exam"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Save", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, SuperToolTip2, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12})
        Me.CardView1.GridControl = Me.GridControl1
        Me.CardView1.Name = "CardView1"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GridColumn11"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "GridColumn12"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
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
        Me.GroupPanel2.Controls.Add(Me.TabControl4)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.tdbViewer)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(786, 446)
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
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel10)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 123)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(780, 317)
        Me.TabControl4.TabIndex = 53
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem14)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel10
        '
        Me.TabControlPanel10.Controls.Add(Me.GridControl1)
        Me.TabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel10.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel10.Name = "TabControlPanel10"
        Me.TabControlPanel10.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel10.Size = New System.Drawing.Size(780, 291)
        Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel10.Style.GradientAngle = 90
        Me.TabControlPanel10.TabIndex = 2
        Me.TabControlPanel10.TabItem = Me.TabItem14
        '
        'TabItem14
        '
        Me.TabItem14.AttachedControl = Me.TabControlPanel10
        Me.TabItem14.Name = "TabItem14"
        Me.TabItem14.Text = "STUDENT SUBJECT LIST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.lblCourse)
        Me.GroupBox1.Controls.Add(Me.txtClassrollNumber)
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtCourseID)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 123)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnClearFilter)
        Me.GroupPanel1.Controls.Add(Me.btnSearchCondition)
        Me.GroupPanel1.Controls.Add(Me.btnPrint)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 82)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(774, 38)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 123
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClearFilter.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClearFilter.Location = New System.Drawing.Point(654, 0)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 32)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Close"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'btnSearchCondition
        '
        Me.btnSearchCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchCondition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearchCondition.Image = Global.SchoolMGT.My.Resources.Resources.zoom
        Me.btnSearchCondition.Location = New System.Drawing.Point(114, 0)
        Me.btnSearchCondition.Name = "btnSearchCondition"
        Me.btnSearchCondition.Size = New System.Drawing.Size(114, 32)
        Me.btnSearchCondition.TabIndex = 111
        Me.btnSearchCondition.Text = "Search"
        Me.btnSearchCondition.Tooltip = "Search"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(35, 25)
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 32)
        Me.btnPrint.TabIndex = 122
        Me.btnPrint.Text = "View TOR"
        Me.btnPrint.Tooltip = "Clear Filter"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        '
        '
        '
        Me.lblCourse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(9, 22)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(142, 21)
        Me.lblCourse.TabIndex = 121
        Me.lblCourse.Text = "STUDENT'S NAME"
        '
        'txtClassrollNumber
        '
        Me.txtClassrollNumber.Location = New System.Drawing.Point(374, 60)
        Me.txtClassrollNumber.Name = "txtClassrollNumber"
        Me.txtClassrollNumber.Size = New System.Drawing.Size(99, 20)
        Me.txtClassrollNumber.TabIndex = 120
        Me.txtClassrollNumber.Visible = False
        '
        'txtStudentName
        '
        Me.txtStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtStudentName.DisplayMember = "Text"
        Me.txtStudentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtStudentName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.FormattingEnabled = True
        Me.txtStudentName.ItemHeight = 21
        Me.txtStudentName.Location = New System.Drawing.Point(165, 20)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(516, 27)
        Me.txtStudentName.TabIndex = 119
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(192, 55)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 15)
        Me.LabelX1.TabIndex = 117
        Me.LabelX1.Text = "COURSE GROUP"
        Me.LabelX1.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(577, 17)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(99, 20)
        Me.txtCourseID.TabIndex = 116
        Me.txtCourseID.Visible = False
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 15
        Me.cmbCourse.Location = New System.Drawing.Point(291, 55)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(55, 21)
        Me.cmbCourse.TabIndex = 115
        Me.cmbCourse.Visible = False
        '
        'tdbViewer
        '
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "STUDENT LIST"
        Me.tdbViewer.CaptionHeight = 18
        Me.tdbViewer.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.FilterBar = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByAreaVisible = False
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(364, 143)
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
        Me.tdbViewer.Size = New System.Drawing.Size(66, 77)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 25
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TORToolStripMenuItem, Me.CHEDFORM9ToolStripMenuItem, Me.StatementOfAccountToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(181, 92)
        '
        'TORToolStripMenuItem
        '
        Me.TORToolStripMenuItem.Name = "TORToolStripMenuItem"
        Me.TORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TORToolStripMenuItem.Text = "TOR"
        Me.TORToolStripMenuItem.Visible = False
        '
        'CHEDFORM9ToolStripMenuItem
        '
        Me.CHEDFORM9ToolStripMenuItem.Name = "CHEDFORM9ToolStripMenuItem"
        Me.CHEDFORM9ToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CHEDFORM9ToolStripMenuItem.Text = "CHED FORM 9"
        Me.CHEDFORM9ToolStripMenuItem.Visible = False
        '
        'StatementOfAccountToolStripMenuItem
        '
        Me.StatementOfAccountToolStripMenuItem.Name = "StatementOfAccountToolStripMenuItem"
        Me.StatementOfAccountToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.StatementOfAccountToolStripMenuItem.Text = "CHED FORM 9-A"
        Me.StatementOfAccountToolStripMenuItem.Visible = False
        '
        'fmaRegistrarTORPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaRegistrarTORPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSearchCondition As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCourse As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtClassrollNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentName As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CHEDFORM9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem14 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
End Class
