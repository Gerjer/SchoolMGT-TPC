<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaFeesMasterSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaFeesMasterSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.WinLabel = New DevComponents.DotNetBar.LabelX
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtDescr = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.txtCatID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.WinLabel)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(475, 28)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'WinLabel
        '
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(475, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "MASTER FEE"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.GroupPanel2.Controls.Add(Me.txtCatID)
        Me.GroupPanel2.Controls.Add(Me.txtDescr)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txt_name)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.btnCancel)
        Me.GroupPanel2.Controls.Add(Me.btnDelete)
        Me.GroupPanel2.Controls.Add(Me.btnSave)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(475, 187)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
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
        Me.GroupPanel2.TabIndex = 15
        '
        'txtDescr
        '
        Me.txtDescr.AccessibleName = "courses"
        '
        '
        '
        Me.txtDescr.Border.Class = "TextBoxBorder"
        Me.txtDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescr.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtDescr.FocusHighlightEnabled = True
        Me.txtDescr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescr.Location = New System.Drawing.Point(116, 59)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(233, 20)
        Me.txtDescr.TabIndex = 175
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(28, 64)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 15)
        Me.LabelX1.TabIndex = 176
        Me.LabelX1.Text = "DESCRIPTION"
        '
        'txt_name
        '
        Me.txt_name.AccessibleName = "courses"
        '
        '
        '
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txt_name.FocusHighlightEnabled = True
        Me.txt_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_name.Location = New System.Drawing.Point(116, 29)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 20)
        Me.txt_name.TabIndex = 173
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(28, 34)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(34, 15)
        Me.LabelX7.TabIndex = 174
        Me.LabelX7.Text = "NAME"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnCancel.Location = New System.Drawing.Point(137, 113)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 31)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(256, 113)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnDelete.Size = New System.Drawing.Size(93, 31)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnSave.Location = New System.Drawing.Point(28, 113)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 31)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'txtCatID
        '
        Me.txtCatID.AccessibleName = "courses"
        '
        '
        '
        Me.txtCatID.Border.Class = "TextBoxBorder"
        Me.txtCatID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCatID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCatID.FocusHighlightEnabled = True
        Me.txtCatID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCatID.Location = New System.Drawing.Point(116, 3)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.Size = New System.Drawing.Size(48, 20)
        Me.txtCatID.TabIndex = 177
        Me.txtCatID.Visible = False
        '
        'fmaFeesMasterSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(475, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaFeesMasterSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Fees"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescr As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCatID As DevComponents.DotNetBar.Controls.TextBoxX
End Class
