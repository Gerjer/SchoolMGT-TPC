<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaSubjectaSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaSubjectaSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtNoUnit = New DevComponents.Editors.DoubleInput()
        Me.cmbDistribution = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtSubjCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAmount = New DevComponents.Editors.DoubleInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnOptional = New System.Windows.Forms.RadioButton()
        Me.rbtnElective = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtCDid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSubjID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBatchID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtElectiveID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtElectives = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtlimit_subject = New DevComponents.Editors.DoubleInput()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.txtNoUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtlimit_subject, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx1.Size = New System.Drawing.Size(456, 28)
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
        Me.WinLabel.Size = New System.Drawing.Size(456, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "SUBJECT SETUP FORM"
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
        Me.GroupPanel2.Controls.Add(Me.txtlimit_subject)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.txtNoUnit)
        Me.GroupPanel2.Controls.Add(Me.cmbDistribution)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.txtSubjCode)
        Me.GroupPanel2.Controls.Add(Me.txtAmount)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.cmbType)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.txtName)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txtCDid)
        Me.GroupPanel2.Controls.Add(Me.txtSubjID)
        Me.GroupPanel2.Controls.Add(Me.txtBatchID)
        Me.GroupPanel2.Controls.Add(Me.txtElectiveID)
        Me.GroupPanel2.Controls.Add(Me.txtElectives)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.GroupPanel2.Size = New System.Drawing.Size(456, 310)
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
        'txtNoUnit
        '
        '
        '
        '
        Me.txtNoUnit.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtNoUnit.Increment = 1.0R
        Me.txtNoUnit.Location = New System.Drawing.Point(134, 153)
        Me.txtNoUnit.MinValue = 0R
        Me.txtNoUnit.Name = "txtNoUnit"
        Me.txtNoUnit.ShowUpDown = True
        Me.txtNoUnit.Size = New System.Drawing.Size(154, 20)
        Me.txtNoUnit.TabIndex = 6
        '
        'cmbDistribution
        '
        Me.cmbDistribution.DisplayMember = "Text"
        Me.cmbDistribution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDistribution.FormattingEnabled = True
        Me.cmbDistribution.ItemHeight = 14
        Me.cmbDistribution.Location = New System.Drawing.Point(134, 209)
        Me.cmbDistribution.Name = "cmbDistribution"
        Me.cmbDistribution.Size = New System.Drawing.Size(272, 20)
        Me.cmbDistribution.TabIndex = 196
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(24, 214)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(93, 15)
        Me.LabelX6.TabIndex = 195
        Me.LabelX6.Text = "CREDIT DISTRIB."
        '
        'txtSubjCode
        '
        Me.txtSubjCode.AccessibleName = ""
        Me.txtSubjCode.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtSubjCode.Border.Class = "TextBoxBorder"
        Me.txtSubjCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubjCode.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSubjCode.FocusHighlightEnabled = True
        Me.txtSubjCode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSubjCode.Location = New System.Drawing.Point(134, 57)
        Me.txtSubjCode.Name = "txtSubjCode"
        Me.txtSubjCode.Size = New System.Drawing.Size(272, 20)
        Me.txtSubjCode.TabIndex = 3
        '
        'txtAmount
        '
        '
        '
        '
        Me.txtAmount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAmount.Increment = 1.0R
        Me.txtAmount.Location = New System.Drawing.Point(134, 181)
        Me.txtAmount.MinValue = 0R
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ShowUpDown = True
        Me.txtAmount.Size = New System.Drawing.Size(154, 20)
        Me.txtAmount.TabIndex = 7
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(24, 186)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 15)
        Me.LabelX5.TabIndex = 189
        Me.LabelX5.Text = "PRICE/UNIT"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(25, 159)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(79, 15)
        Me.LabelX4.TabIndex = 187
        Me.LabelX4.Text = "NO. OF UNIT/S"
        '
        'cmbType
        '
        Me.cmbType.DisplayMember = "Text"
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 14
        Me.cmbType.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6})
        Me.cmbType.Location = New System.Drawing.Point(134, 127)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(272, 20)
        Me.cmbType.TabIndex = 5
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "LECTURE"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "LABORATORY"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(25, 132)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(78, 15)
        Me.LabelX3.TabIndex = 185
        Me.LabelX3.Text = "LECTURE/LAB"
        '
        'txtName
        '
        Me.txtName.AccessibleName = ""
        Me.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtName.FocusHighlightEnabled = True
        Me.txtName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtName.Location = New System.Drawing.Point(134, 83)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 38)
        Me.txtName.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtnOptional)
        Me.GroupBox1.Controls.Add(Me.rbtnElective)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 52)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        '
        'rbtnOptional
        '
        Me.rbtnOptional.AutoSize = True
        Me.rbtnOptional.BackColor = System.Drawing.Color.Transparent
        Me.rbtnOptional.Checked = True
        Me.rbtnOptional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOptional.ForeColor = System.Drawing.Color.Navy
        Me.rbtnOptional.Location = New System.Drawing.Point(25, 17)
        Me.rbtnOptional.Name = "rbtnOptional"
        Me.rbtnOptional.Size = New System.Drawing.Size(174, 20)
        Me.rbtnOptional.TabIndex = 149
        Me.rbtnOptional.TabStop = True
        Me.rbtnOptional.Text = "OPTIONAL SUBJECT"
        Me.rbtnOptional.UseVisualStyleBackColor = False
        '
        'rbtnElective
        '
        Me.rbtnElective.AutoSize = True
        Me.rbtnElective.BackColor = System.Drawing.Color.Transparent
        Me.rbtnElective.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnElective.ForeColor = System.Drawing.Color.Navy
        Me.rbtnElective.Location = New System.Drawing.Point(205, 17)
        Me.rbtnElective.Name = "rbtnElective"
        Me.rbtnElective.Size = New System.Drawing.Size(171, 20)
        Me.rbtnElective.TabIndex = 150
        Me.rbtnElective.Text = "ELECTIVE SUBJECT"
        Me.rbtnElective.UseVisualStyleBackColor = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 88)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(34, 15)
        Me.LabelX2.TabIndex = 152
        Me.LabelX2.Text = "NAME"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(25, 62)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 15)
        Me.LabelX1.TabIndex = 151
        Me.LabelX1.Text = "SUBJECT CODE"
        '
        'txtCDid
        '
        Me.txtCDid.AccessibleName = ""
        Me.txtCDid.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtCDid.Border.Class = "TextBoxBorder"
        Me.txtCDid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCDid.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCDid.FocusHighlightEnabled = True
        Me.txtCDid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCDid.Location = New System.Drawing.Point(294, 208)
        Me.txtCDid.Name = "txtCDid"
        Me.txtCDid.Size = New System.Drawing.Size(30, 20)
        Me.txtCDid.TabIndex = 197
        Me.txtCDid.Text = "0"
        Me.txtCDid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCDid.Visible = False
        '
        'txtSubjID
        '
        Me.txtSubjID.AccessibleName = ""
        Me.txtSubjID.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtSubjID.Border.Class = "TextBoxBorder"
        Me.txtSubjID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubjID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSubjID.FocusHighlightEnabled = True
        Me.txtSubjID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSubjID.Location = New System.Drawing.Point(294, 158)
        Me.txtSubjID.Name = "txtSubjID"
        Me.txtSubjID.Size = New System.Drawing.Size(30, 20)
        Me.txtSubjID.TabIndex = 194
        Me.txtSubjID.Text = "0"
        Me.txtSubjID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSubjID.Visible = False
        '
        'txtBatchID
        '
        Me.txtBatchID.AccessibleName = ""
        Me.txtBatchID.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtBatchID.Border.Class = "TextBoxBorder"
        Me.txtBatchID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtBatchID.FocusHighlightEnabled = True
        Me.txtBatchID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBatchID.Location = New System.Drawing.Point(294, 127)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 193
        Me.txtBatchID.Text = "0"
        Me.txtBatchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchID.Visible = False
        '
        'txtElectiveID
        '
        Me.txtElectiveID.AccessibleName = ""
        Me.txtElectiveID.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtElectiveID.Border.Class = "TextBoxBorder"
        Me.txtElectiveID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtElectiveID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtElectiveID.FocusHighlightEnabled = True
        Me.txtElectiveID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtElectiveID.Location = New System.Drawing.Point(294, 83)
        Me.txtElectiveID.Name = "txtElectiveID"
        Me.txtElectiveID.Size = New System.Drawing.Size(30, 20)
        Me.txtElectiveID.TabIndex = 192
        Me.txtElectiveID.Text = "0"
        Me.txtElectiveID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtElectiveID.Visible = False
        '
        'txtElectives
        '
        Me.txtElectives.AccessibleName = ""
        Me.txtElectives.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtElectives.Border.Class = "TextBoxBorder"
        Me.txtElectives.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtElectives.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtElectives.FocusHighlightEnabled = True
        Me.txtElectives.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtElectives.Location = New System.Drawing.Point(294, 57)
        Me.txtElectives.Name = "txtElectives"
        Me.txtElectives.Size = New System.Drawing.Size(30, 20)
        Me.txtElectives.TabIndex = 191
        Me.txtElectives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtElectives.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 297)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(456, 41)
        Me.Panel1.TabIndex = 198
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(172, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 36)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(265, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 36)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(358, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 36)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(24, 237)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(66, 15)
        Me.LabelX7.TabIndex = 198
        Me.LabelX7.Text = "Subject Limit"
        '
        'txtlimit_subject
        '
        '
        '
        '
        Me.txtlimit_subject.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtlimit_subject.Increment = 1.0R
        Me.txtlimit_subject.Location = New System.Drawing.Point(134, 236)
        Me.txtlimit_subject.MinValue = 0R
        Me.txtlimit_subject.Name = "txtlimit_subject"
        Me.txtlimit_subject.ShowUpDown = True
        Me.txtlimit_subject.Size = New System.Drawing.Size(154, 20)
        Me.txtlimit_subject.TabIndex = 199
        '
        'fmaSubjectaSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(456, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaSubjectaSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Setup"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.txtNoUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtlimit_subject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rbtnElective As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOptional As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAmount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtElectiveID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtElectives As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBatchID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSubjCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSubjID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCDid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbDistribution As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoUnit As DevComponents.Editors.DoubleInput
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtlimit_subject As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
