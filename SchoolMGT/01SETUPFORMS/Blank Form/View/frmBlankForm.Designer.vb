<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlankForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlankForm))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gcBlankForm = New DevExpress.XtraGrid.GridControl()
        Me.gvBlankForm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.nudCopies = New System.Windows.Forms.NumericUpDown()
        Me.btnPreview = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.gcBlankForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBlankForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupPanel2)
        Me.PanelControl1.Controls.Add(Me.GroupPanel4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(792, 341)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(2, 37)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(788, 302)
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
        Me.GroupPanel2.TabIndex = 250
        Me.GroupPanel2.Text = "FORM DETAILS"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.gcBlankForm)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(508, 281)
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
        Me.GroupPanel3.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 4
        Me.GroupPanel3.Text = "COLLECTION FOMR LIST"
        '
        'gcBlankForm
        '
        Me.gcBlankForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBlankForm.Location = New System.Drawing.Point(0, 0)
        Me.gcBlankForm.MainView = Me.gvBlankForm
        Me.gcBlankForm.Name = "gcBlankForm"
        Me.gcBlankForm.Size = New System.Drawing.Size(502, 260)
        Me.gcBlankForm.TabIndex = 0
        Me.gcBlankForm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBlankForm})
        '
        'gvBlankForm
        '
        Me.gvBlankForm.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBlankForm.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvBlankForm.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBlankForm.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvBlankForm.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvBlankForm.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvBlankForm.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvBlankForm.GridControl = Me.gcBlankForm
        Me.gvBlankForm.Name = "gvBlankForm"
        Me.gvBlankForm.OptionsBehavior.Editable = False
        Me.gvBlankForm.OptionsSelection.CheckBoxSelectorField = "Include"
        Me.gvBlankForm.OptionsSelection.MultiSelect = True
        Me.gvBlankForm.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Include"
        Me.GridColumn1.FieldName = "Include"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ShowCaption = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "id"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "FORM NAME"
        Me.GridColumn3.FieldName = "form_name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DESCRIPTION"
        Me.GridColumn4.FieldName = "description"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "REPORT TYPE"
        Me.GridColumn5.FieldName = "type"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupPanel6)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel5)
        Me.GroupPanel1.Controls.Add(Me.btnPreview)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(508, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(274, 281)
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
        Me.GroupPanel1.TabIndex = 3
        Me.GroupPanel1.Text = "BUTTONS"
        '
        'GroupPanel6
        '
        Me.GroupPanel6.AutoScroll = True
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.btnEdit)
        Me.GroupPanel6.Controls.Add(Me.btnSave)
        Me.GroupPanel6.Controls.Add(Me.ButtonX2)
        Me.GroupPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Location = New System.Drawing.Point(7, 84)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Padding = New System.Windows.Forms.Padding(50, 30, 10, 0)
        Me.GroupPanel6.Size = New System.Drawing.Size(257, 172)
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
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel6.TabIndex = 144
        Me.GroupPanel6.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(25, 20)
        Me.btnEdit.Location = New System.Drawing.Point(8, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 45)
        Me.btnEdit.TabIndex = 139
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Tooltip = "Save"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Image = Global.SchoolMGT.My.Resources.Resources.Save_24x24
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(20, 18)
        Me.btnSave.Location = New System.Drawing.Point(8, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 45)
        Me.btnSave.TabIndex = 138
        Me.btnSave.Text = "Save"
        Me.btnSave.Tooltip = "Save"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonX2.Image = Global.SchoolMGT.My.Resources.Resources.Settings_icon
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(25, 20)
        Me.ButtonX2.Location = New System.Drawing.Point(128, 12)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(110, 45)
        Me.ButtonX2.TabIndex = 140
        Me.ButtonX2.Text = "Save"
        Me.ButtonX2.Tooltip = "Save"
        '
        'GroupPanel5
        '
        Me.GroupPanel5.AutoScroll = True
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.nudCopies)
        Me.GroupPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel5.Location = New System.Drawing.Point(129, 9)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Padding = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.GroupPanel5.Size = New System.Drawing.Size(126, 55)
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
        Me.GroupPanel5.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel5.TabIndex = 143
        Me.GroupPanel5.Text = "Number of Copies"
        '
        'nudCopies
        '
        Me.nudCopies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCopies.Location = New System.Drawing.Point(10, 5)
        Me.nudCopies.Name = "nudCopies"
        Me.nudCopies.Size = New System.Drawing.Size(100, 23)
        Me.nudCopies.TabIndex = 142
        Me.nudCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnPreview
        '
        Me.btnPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPreview.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageFixedSize = New System.Drawing.Size(25, 20)
        Me.btnPreview.Location = New System.Drawing.Point(9, 19)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(110, 45)
        Me.btnPreview.TabIndex = 141
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.Tooltip = "Print"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.WinLabel)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(2, 2)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(788, 35)
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
        Me.WinLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(786, 33)
        Me.WinLabel.TabIndex = 245
        Me.WinLabel.Text = "BLANK FORM"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmBlankForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 341)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmBlankForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLANK FORM"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.gcBlankForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBlankForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel6.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gcBlankForm As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBlankForm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nudCopies As NumericUpDown
    Friend WithEvents btnPreview As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
