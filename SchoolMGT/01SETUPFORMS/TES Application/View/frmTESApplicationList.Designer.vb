<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTESApplicationList
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTESApplicationList))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnGenerate = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmbUII = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbToYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.cmbFromYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gcTESApplication = New DevExpress.XtraGrid.GridControl()
        Me.gvTESApplication = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.gcTESApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTESApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.GroupPanel2)
        Me.Panel2.Controls.Add(Me.GroupPanel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1122, 101)
        Me.Panel2.TabIndex = 57
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.btnGenerate)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(363, 63)
        Me.Panel3.TabIndex = 256
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(35, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(87, 35)
        Me.btnAdd.SplitButton = True
        Me.btnAdd.TabIndex = 252
        Me.btnAdd.Tag = "1"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Tooltip = "Add"
        '
        'btnGenerate
        '
        Me.btnGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGenerate.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnGenerate.Location = New System.Drawing.Point(221, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnGenerate.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.btnGenerate.Size = New System.Drawing.Size(100, 35)
        Me.btnGenerate.TabIndex = 253
        Me.btnGenerate.Tag = "1"
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.Tooltip = "Print"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnEdit.Location = New System.Drawing.Point(128, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.btnEdit.Size = New System.Drawing.Size(87, 35)
        Me.btnEdit.TabIndex = 254
        Me.btnEdit.Tag = "1"
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Tooltip = "Edit"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cmbUII)
        Me.GroupPanel2.Controls.Add(Me.btnPrint)
        Me.GroupPanel2.Controls.Add(Me.cmbToYear)
        Me.GroupPanel2.Controls.Add(Me.cmbFromYear)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 38)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1122, 63)
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
        Me.GroupPanel2.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 255
        Me.GroupPanel2.Visible = False
        '
        'cmbUII
        '
        Me.cmbUII.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUII.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUII.DisplayMember = "Text"
        Me.cmbUII.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUII.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUII.FormattingEnabled = True
        Me.cmbUII.ItemHeight = 20
        Me.cmbUII.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.cmbUII.Location = New System.Drawing.Point(461, 15)
        Me.cmbUII.Name = "cmbUII"
        Me.cmbUII.Size = New System.Drawing.Size(249, 26)
        Me.cmbUII.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbUII.TabIndex = 265
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Single"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Married"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Separated"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Widowed"
        '
        'btnPrint
        '
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.ImageIndex = 8
        Me.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnPrint.Location = New System.Drawing.Point(959, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(127, 39)
        Me.btnPrint.TabIndex = 264
        Me.btnPrint.Text = "Save and Print"
        '
        'cmbToYear
        '
        Me.cmbToYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbToYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbToYear.DisplayMember = "Text"
        Me.cmbToYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbToYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToYear.FormattingEnabled = True
        Me.cmbToYear.ItemHeight = 14
        Me.cmbToYear.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cmbToYear.Location = New System.Drawing.Point(799, 30)
        Me.cmbToYear.Name = "cmbToYear"
        Me.cmbToYear.Size = New System.Drawing.Size(144, 20)
        Me.cmbToYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbToYear.TabIndex = 263
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Single"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Married"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Separated"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Widowed"
        '
        'cmbFromYear
        '
        Me.cmbFromYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFromYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFromYear.DisplayMember = "Text"
        Me.cmbFromYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFromYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFromYear.FormattingEnabled = True
        Me.cmbFromYear.ItemHeight = 14
        Me.cmbFromYear.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbFromYear.Location = New System.Drawing.Point(799, 8)
        Me.cmbFromYear.Name = "cmbFromYear"
        Me.cmbFromYear.Size = New System.Drawing.Size(144, 20)
        Me.cmbFromYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbFromYear.TabIndex = 261
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Single"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Married"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Separated"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Widowed"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX2.Location = New System.Drawing.Point(758, 28)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(28, 16)
        Me.LabelX2.TabIndex = 262
        Me.LabelX2.Text = "Year"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX1.Location = New System.Drawing.Point(731, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 16)
        Me.LabelX1.TabIndex = 260
        Me.LabelX1.Text = "Academic"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HEI UII  :"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.WinLabel)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1122, 38)
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
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.Transparent
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(1120, 36)
        Me.WinLabel.TabIndex = 245
        Me.WinLabel.Text = "TES LIST VIEW"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel1)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 0)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(1122, 349)
        Me.TabControl4.TabIndex = 58
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem1)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.gcTESApplication)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1122, 323)
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
        'gcTESApplication
        '
        Me.gcTESApplication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTESApplication.Location = New System.Drawing.Point(1, 1)
        Me.gcTESApplication.MainView = Me.gvTESApplication
        Me.gcTESApplication.Name = "gcTESApplication"
        Me.gcTESApplication.Size = New System.Drawing.Size(1120, 321)
        Me.gcTESApplication.TabIndex = 0
        Me.gcTESApplication.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTESApplication})
        '
        'gvTESApplication
        '
        Me.gvTESApplication.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvTESApplication.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvTESApplication.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvTESApplication.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvTESApplication.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvTESApplication.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvTESApplication.GridControl = Me.gcTESApplication
        Me.gvTESApplication.Name = "gvTESApplication"
        Me.gvTESApplication.OptionsView.ShowIndicator = False
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "TES Record List"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1122, 349)
        Me.Panel1.TabIndex = 59
        '
        'frmTESApplicationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTESApplicationList"
        Me.Text = "TES APPLICATION LIST"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.gcTESApplication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTESApplication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGenerate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gcTESApplication As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTESApplication As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbToYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents cmbFromYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbUII As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
End Class
