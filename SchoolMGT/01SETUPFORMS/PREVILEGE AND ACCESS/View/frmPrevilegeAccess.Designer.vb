<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrevilegeAccess
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrevilegeAccess))
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gcPrevilege = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SUPERUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvPrevilege = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gcAccess = New DevExpress.XtraGrid.GridControl()
        Me.gvAccess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gcEmployeeList = New DevExpress.XtraGrid.GridControl()
        Me.gvEmployeeList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.gcPrevilege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gvPrevilege, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.gcAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.gcEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.Transparent
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(800, 450)
        Me.WinLabel.TabIndex = 246
        Me.WinLabel.Text = "BIILING STATEMENTS"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(800, 450)
        Me.LabelX1.TabIndex = 247
        Me.LabelX1.Text = "BIILING STATEMENTS"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.GroupPanel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 95)
        Me.Panel2.TabIndex = 248
        '
        'btnRefresh
        '
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(123, 46)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 35)
        Me.btnRefresh.TabIndex = 258
        Me.btnRefresh.Text = "Refresh"
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.Location = New System.Drawing.Point(21, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 35)
        Me.btnAdd.TabIndex = 257
        Me.btnAdd.Text = "Add"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.LabelX2)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(800, 38)
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
        Me.GroupPanel4.TabIndex = 249
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX2.Location = New System.Drawing.Point(0, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(798, 36)
        Me.LabelX2.TabIndex = 245
        Me.LabelX2.Text = "PRIVILEGE AND ACCESS"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel1)
        Me.TabControl4.Controls.Add(Me.TabControlPanel2)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(278, 0)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(522, 310)
        Me.TabControl4.TabIndex = 249
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem1)
        Me.TabControl4.Tabs.Add(Me.TabItem2)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Label1)
        Me.TabControlPanel1.Controls.Add(Me.gcPrevilege)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(5, 20, 5, 5)
        Me.TabControlPanel1.Size = New System.Drawing.Size(522, 284)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Note: Double Click Instructor List to view Privilege / Access"
        '
        'gcPrevilege
        '
        Me.gcPrevilege.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gcPrevilege.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPrevilege.Location = New System.Drawing.Point(5, 20)
        Me.gcPrevilege.MainView = Me.gvPrevilege
        Me.gcPrevilege.Name = "gcPrevilege"
        Me.gcPrevilege.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.gcPrevilege.Size = New System.Drawing.Size(512, 259)
        Me.gcPrevilege.TabIndex = 0
        Me.gcPrevilege.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPrevilege})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUPERUSERToolStripMenuItem, Me.ADMINToolStripMenuItem, Me.USERToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 70)
        '
        'SUPERUSERToolStripMenuItem
        '
        Me.SUPERUSERToolStripMenuItem.Name = "SUPERUSERToolStripMenuItem"
        Me.SUPERUSERToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SUPERUSERToolStripMenuItem.Tag = "1"
        Me.SUPERUSERToolStripMenuItem.Text = "SUPERUSER"
        Me.SUPERUSERToolStripMenuItem.Visible = False
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ADMINToolStripMenuItem.Tag = "2"
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        Me.ADMINToolStripMenuItem.Visible = False
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.USERToolStripMenuItem.Tag = "3"
        Me.USERToolStripMenuItem.Text = "USER"
        Me.USERToolStripMenuItem.Visible = False
        '
        'gvPrevilege
        '
        Me.gvPrevilege.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn11})
        Me.gvPrevilege.GridControl = Me.gcPrevilege
        Me.gvPrevilege.GroupCount = 1
        Me.gvPrevilege.GroupFormat = "{1} "
        Me.gvPrevilege.Name = "gvPrevilege"
        Me.gvPrevilege.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvPrevilege.OptionsSelection.CheckBoxSelectorField = "INCLUDE"
        Me.gvPrevilege.OptionsSelection.MultiSelect = True
        Me.gvPrevilege.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvPrevilege.OptionsView.ShowGroupPanel = False
        Me.gvPrevilege.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "INCLUDE"
        Me.GridColumn1.FieldName = "INCLUDE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "parent_id"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "PARENT"
        Me.GridColumn4.FieldName = "PARENT"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CHILD"
        Me.GridColumn5.FieldName = "CHILD"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "DESCRIPTION"
        Me.GridColumn6.FieldName = "DESCRIPTION"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "TYPE OF USER"
        Me.GridColumn11.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn11.FieldName = "TYPE OF USER"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AllowFocused = False
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"SUPERUSER", "ADMIN", "USER"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.ShowNullValuePromptWhenFocused = True
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "PRIVILEGE"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.gcAccess)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(522, 284)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 4
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'gcAccess
        '
        Me.gcAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAccess.Location = New System.Drawing.Point(1, 1)
        Me.gcAccess.MainView = Me.gvAccess
        Me.gcAccess.Name = "gcAccess"
        Me.gcAccess.Size = New System.Drawing.Size(520, 282)
        Me.gcAccess.TabIndex = 1
        Me.gcAccess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAccess})
        '
        'gvAccess
        '
        Me.gvAccess.GridControl = Me.gcAccess
        Me.gvAccess.Name = "gvAccess"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "ACCESS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl4)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 355)
        Me.Panel1.TabIndex = 250
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.gcEmployeeList)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupPanel1.Size = New System.Drawing.Size(278, 310)
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
        Me.GroupPanel1.TabIndex = 251
        '
        'gcEmployeeList
        '
        Me.gcEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEmployeeList.Location = New System.Drawing.Point(5, 5)
        Me.gcEmployeeList.MainView = Me.gvEmployeeList
        Me.gcEmployeeList.Name = "gcEmployeeList"
        Me.gcEmployeeList.Padding = New System.Windows.Forms.Padding(10)
        Me.gcEmployeeList.Size = New System.Drawing.Size(262, 294)
        Me.gcEmployeeList.TabIndex = 250
        Me.gcEmployeeList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmployeeList})
        '
        'gvEmployeeList
        '
        Me.gvEmployeeList.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvEmployeeList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvEmployeeList.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvEmployeeList.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvEmployeeList.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvEmployeeList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvEmployeeList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn10, Me.GridColumn9})
        Me.gvEmployeeList.GridControl = Me.gcEmployeeList
        Me.gvEmployeeList.Name = "gvEmployeeList"
        Me.gvEmployeeList.OptionsBehavior.Editable = False
        Me.gvEmployeeList.OptionsSelection.CheckBoxSelectorField = "INCLUDE"
        Me.gvEmployeeList.OptionsSelection.MultiSelect = True
        Me.gvEmployeeList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvEmployeeList.OptionsView.ShowAutoFilterRow = True
        Me.gvEmployeeList.OptionsView.ShowGroupPanel = False
        Me.gvEmployeeList.OptionsView.ShowIndicator = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "INCLUDE"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn8.Caption = "USER LIST"
        Me.GridColumn8.FieldName = "display_name"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.FieldName = "user_id"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "person_id"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 310)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 45)
        Me.Panel3.TabIndex = 1
        '
        'frmPrevilegeAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.WinLabel)
        Me.Name = "frmPrevilegeAccess"
        Me.ShowIcon = False
        Me.Text = "PRIVILEGE AND ACCESS"
        Me.Panel2.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.gcPrevilege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gvPrevilege, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.gcAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.gcEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gcPrevilege As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPrevilege As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gcAccess As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAccess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gcEmployeeList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmployeeList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SUPERUSERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
End Class
