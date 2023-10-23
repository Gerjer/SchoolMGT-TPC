<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBillingStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingStatement))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.gcBillingStatement = New DevExpress.XtraGrid.GridControl()
        Me.gvBillingStatement = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOSFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMISSIONFEEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.gcBillingStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBillingStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.GroupPanel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 101)
        Me.Panel2.TabIndex = 55
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnEdit.Location = New System.Drawing.Point(108, 49)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnEdit.Size = New System.Drawing.Size(87, 35)
        Me.btnEdit.TabIndex = 254
        Me.btnEdit.Tag = "1"
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Tooltip = "Edit"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.SchoolMGT.My.Resources.Resources.Print_24x24
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnPrint.Location = New System.Drawing.Point(201, 49)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnPrint.Size = New System.Drawing.Size(87, 35)
        Me.btnPrint.TabIndex = 253
        Me.btnPrint.Tag = "1"
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Tooltip = "Add"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAdd.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(15, 49)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnAdd.Size = New System.Drawing.Size(87, 35)
        Me.btnAdd.SplitButton = True
        Me.btnAdd.TabIndex = 252
        Me.btnAdd.Tag = "1"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Tooltip = "Find"
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
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.Transparent
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(798, 36)
        Me.WinLabel.TabIndex = 245
        Me.WinLabel.Text = "BILLING STATEMENTS"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel1)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 101)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(800, 349)
        Me.TabControl4.TabIndex = 56
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem1)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.gcBillingStatement)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(800, 323)
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
        'gcBillingStatement
        '
        Me.gcBillingStatement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBillingStatement.Location = New System.Drawing.Point(1, 1)
        Me.gcBillingStatement.MainView = Me.gvBillingStatement
        Me.gcBillingStatement.Name = "gcBillingStatement"
        Me.gcBillingStatement.Size = New System.Drawing.Size(798, 321)
        Me.gcBillingStatement.TabIndex = 0
        Me.gcBillingStatement.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBillingStatement})
        '
        'gvBillingStatement
        '
        Me.gvBillingStatement.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBillingStatement.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvBillingStatement.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBillingStatement.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvBillingStatement.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBillingStatement.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvBillingStatement.GridControl = Me.gcBillingStatement
        Me.gvBillingStatement.Name = "gvBillingStatement"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Billing Record"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsToolStripMenuItem, Me.TOSFToolStripMenuItem, Me.ADMISSIONFEEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 70)
        '
        'ConsToolStripMenuItem
        '
        Me.ConsToolStripMenuItem.Name = "ConsToolStripMenuItem"
        Me.ConsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ConsToolStripMenuItem.Tag = "1"
        Me.ConsToolStripMenuItem.Text = "CONSOLIDATED"
        '
        'TOSFToolStripMenuItem
        '
        Me.TOSFToolStripMenuItem.Name = "TOSFToolStripMenuItem"
        Me.TOSFToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TOSFToolStripMenuItem.Tag = "2"
        Me.TOSFToolStripMenuItem.Text = "TOSF"
        '
        'ADMISSIONFEEToolStripMenuItem
        '
        Me.ADMISSIONFEEToolStripMenuItem.Name = "ADMISSIONFEEToolStripMenuItem"
        Me.ADMISSIONFEEToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ADMISSIONFEEToolStripMenuItem.Tag = "3"
        Me.ADMISSIONFEEToolStripMenuItem.Text = "ADMISSION FEE"
        '
        'frmBillingStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmBillingStatement"
        Me.ShowIcon = False
        Me.Text = "BILLING STATEMENTS"
        Me.Panel2.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.gcBillingStatement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBillingStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gcBillingStatement As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBillingStatement As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ConsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOSFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMISSIONFEEToolStripMenuItem As ToolStripMenuItem
End Class
