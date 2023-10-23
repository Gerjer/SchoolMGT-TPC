<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaCashVoucherSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaCashVoucherSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtCatID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtVoucherNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.dtpPayDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.diAmount = New DevComponents.Editors.DoubleInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.title = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dtpPayDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(578, 43)
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
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(578, 43)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "ADD NEW CASH VOUCHER"
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
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 43)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.GroupPanel2.Size = New System.Drawing.Size(578, 380)
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
        'txtCatID
        '
        Me.txtCatID.AccessibleName = "product_item"
        '
        '
        '
        Me.txtCatID.Border.Class = "TextBoxBorder"
        Me.txtCatID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCatID.FocusHighlightEnabled = True
        Me.txtCatID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCatID.Location = New System.Drawing.Point(372, 13)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.ReadOnly = True
        Me.txtCatID.Size = New System.Drawing.Size(44, 20)
        Me.txtCatID.TabIndex = 184
        Me.txtCatID.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DisplayMember = "Text"
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 14
        Me.cmbType.Items.AddRange(New Object() {Me.ComboItem6, Me.ComboItem5})
        Me.cmbType.Location = New System.Drawing.Point(120, 13)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(246, 20)
        Me.cmbType.TabIndex = 183
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "EXPENSE"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "INCOME"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(23, 14)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(87, 15)
        Me.LabelX7.TabIndex = 156
        Me.LabelX7.Text = "EXPENSE CODE"
        '
        'txtVoucherNumber
        '
        Me.txtVoucherNumber.AccessibleName = "product_item"
        '
        '
        '
        Me.txtVoucherNumber.Border.Class = "TextBoxBorder"
        Me.txtVoucherNumber.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtVoucherNumber.FocusHighlightEnabled = True
        Me.txtVoucherNumber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVoucherNumber.Location = New System.Drawing.Point(121, 76)
        Me.txtVoucherNumber.Name = "txtVoucherNumber"
        Me.txtVoucherNumber.ReadOnly = True
        Me.txtVoucherNumber.Size = New System.Drawing.Size(245, 20)
        Me.txtVoucherNumber.TabIndex = 155
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(23, 74)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(68, 15)
        Me.LabelX6.TabIndex = 154
        Me.LabelX6.Text = "VOUCHER #:"
        '
        'dtpPayDate
        '
        '
        '
        '
        Me.dtpPayDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpPayDate.ButtonDropDown.Visible = True
        Me.dtpPayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPayDate.Location = New System.Drawing.Point(120, 44)
        '
        '
        '
        Me.dtpPayDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpPayDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpPayDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpPayDate.MonthCalendar.DisplayMonth = New Date(2016, 4, 1, 0, 0, 0, 0)
        Me.dtpPayDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpPayDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpPayDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpPayDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpPayDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpPayDate.MonthCalendar.TodayButtonVisible = True
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(246, 22)
        Me.dtpPayDate.TabIndex = 153
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(21, 43)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(31, 15)
        Me.LabelX5.TabIndex = 152
        Me.LabelX5.Text = "DATE"
        '
        'diAmount
        '
        '
        '
        '
        Me.diAmount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.diAmount.Increment = 1.0R
        Me.diAmount.Location = New System.Drawing.Point(120, 146)
        Me.diAmount.Name = "diAmount"
        Me.diAmount.ShowUpDown = True
        Me.diAmount.Size = New System.Drawing.Size(160, 20)
        Me.diAmount.TabIndex = 5
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(21, 146)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(39, 15)
        Me.LabelX4.TabIndex = 150
        Me.LabelX4.Text = "Amount"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(459, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 30)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(366, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(23, 85)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(28, 15)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "ITEM"
        '
        'txtRemarks
        '
        Me.txtRemarks.AccessibleName = "product_item"
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtRemarks.FocusHighlightEnabled = True
        Me.txtRemarks.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRemarks.Location = New System.Drawing.Point(120, 75)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(400, 59)
        Me.txtRemarks.TabIndex = 4
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(23, 50)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 15)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "Address"
        '
        'address
        '
        Me.address.AccessibleName = "product_item"
        '
        '
        '
        Me.address.Border.Class = "TextBoxBorder"
        Me.address.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.address.FocusHighlightEnabled = True
        Me.address.ForeColor = System.Drawing.Color.MidnightBlue
        Me.address.Location = New System.Drawing.Point(120, 47)
        Me.address.MaxLength = 30
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(400, 20)
        Me.address.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(23, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(45, 15)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "PAID TO"
        '
        'title
        '
        Me.title.AccessibleName = "product_item"
        '
        '
        '
        Me.title.Border.Class = "TextBoxBorder"
        Me.title.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.title.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.title.FocusHighlightEnabled = True
        Me.title.ForeColor = System.Drawing.Color.MidnightBlue
        Me.title.Location = New System.Drawing.Point(120, 18)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(400, 20)
        Me.title.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cmbType)
        Me.GroupPanel1.Controls.Add(Me.txtVoucherNumber)
        Me.GroupPanel1.Controls.Add(Me.txtCatID)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.dtpPayDate)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(10, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(552, 124)
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
        Me.GroupPanel1.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 185
        Me.GroupPanel1.Text = "Details"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.title)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.diAmount)
        Me.GroupPanel3.Controls.Add(Me.address)
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.txtRemarks)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(10, 124)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(552, 210)
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
        Me.GroupPanel3.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 186
        Me.GroupPanel3.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Panel1.Size = New System.Drawing.Size(552, 40)
        Me.Panel1.TabIndex = 151
        '
        'fmaCashVoucherSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomLeftCornerSize = 0
        Me.BottomRightCornerSize = 0
        Me.ClientSize = New System.Drawing.Size(578, 423)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(594, 462)
        Me.MinimumSize = New System.Drawing.Size(594, 462)
        Me.Name = "fmaCashVoucherSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASH VOUCHER(EXPENSES)"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dtpPayDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents title As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents diAmount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpPayDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtVoucherNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCatID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
