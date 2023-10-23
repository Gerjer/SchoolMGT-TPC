<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaIncomeSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaIncomeSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSlip = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtiDateIssued = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.title = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtORNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.diAmount = New DevComponents.Editors.DoubleInput()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblRequestForm = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.txtCatID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cmbStudent = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtiDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(578, 28)
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
        '
        '
        '
        Me.WinLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(578, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "ADD INCOME"
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
        Me.GroupPanel2.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(578, 395)
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
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 15
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.GroupBox2)
        Me.GroupPanel3.Controls.Add(Me.GroupBox1)
        Me.GroupPanel3.Controls.Add(Me.dtpPayDate)
        Me.GroupPanel3.Controls.Add(Me.LabelX5)
        Me.GroupPanel3.Controls.Add(Me.LabelX8)
        Me.GroupPanel3.Controls.Add(Me.title)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.txtRemarks)
        Me.GroupPanel3.Controls.Add(Me.txtORNumber)
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.diAmount)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 131)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(572, 226)
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
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 191
        Me.GroupPanel3.Text = "PAYMENT STATUS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSlip)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(317, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 62)
        Me.GroupBox2.TabIndex = 192
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Print"
        '
        'chkSlip
        '
        Me.chkSlip.AutoSize = True
        Me.chkSlip.BackColor = System.Drawing.Color.Transparent
        Me.chkSlip.Enabled = False
        Me.chkSlip.Location = New System.Drawing.Point(83, 24)
        Me.chkSlip.Name = "chkSlip"
        Me.chkSlip.Size = New System.Drawing.Size(124, 21)
        Me.chkSlip.TabIndex = 188
        Me.chkSlip.Text = "Requisition Slip"
        Me.chkSlip.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(18, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(52, 21)
        Me.CheckBox1.TabIndex = 187
        Me.CheckBox1.Text = "O.R"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtiDateIssued)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 66)
        Me.GroupBox1.TabIndex = 191
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requisition Slip Date Issued"
        '
        'dtiDateIssued
        '
        Me.dtiDateIssued.AccessibleName = "hr_person_eligibility"
        '
        '
        '
        Me.dtiDateIssued.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiDateIssued.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDateIssued.ButtonDropDown.Visible = True
        Me.dtiDateIssued.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.dtiDateIssued.FocusHighlightEnabled = True
        Me.dtiDateIssued.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiDateIssued.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dtiDateIssued.IsPopupCalendarOpen = False
        Me.dtiDateIssued.Location = New System.Drawing.Point(24, 23)
        Me.dtiDateIssued.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiDateIssued.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDateIssued.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDateIssued.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiDateIssued.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDateIssued.MonthCalendar.DisplayMonth = New Date(2011, 5, 1, 0, 0, 0, 0)
        Me.dtiDateIssued.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiDateIssued.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiDateIssued.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDateIssued.MonthCalendar.TodayButtonVisible = True
        Me.dtiDateIssued.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiDateIssued.Name = "dtiDateIssued"
        Me.dtiDateIssued.Size = New System.Drawing.Size(188, 23)
        Me.dtiDateIssued.TabIndex = 246
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpPayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPayDate.Location = New System.Drawing.Point(140, 9)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(175, 23)
        Me.dtpPayDate.TabIndex = 190
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(22, 14)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 18)
        Me.LabelX5.TabIndex = 152
        Me.LabelX5.Text = "OR DATE"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(22, 142)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(68, 18)
        Me.LabelX8.TabIndex = 189
        Me.LabelX8.Text = "REMARKS"
        '
        'title
        '
        Me.title.AccessibleName = "product_item"
        '
        '
        '
        Me.title.Border.Class = "TextBoxBorder"
        Me.title.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.title.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.title.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.title.FocusHighlightEnabled = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.MidnightBlue
        Me.title.Location = New System.Drawing.Point(140, 84)
        Me.title.Multiline = True
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(415, 37)
        Me.title.TabIndex = 2
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(22, 90)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(113, 18)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "RECEIVED FROM"
        '
        'txtRemarks
        '
        Me.txtRemarks.AccessibleName = "product_item"
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtRemarks.FocusHighlightEnabled = True
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRemarks.Location = New System.Drawing.Point(139, 127)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(415, 68)
        Me.txtRemarks.TabIndex = 4
        '
        'txtORNumber
        '
        Me.txtORNumber.AccessibleName = "product_item"
        '
        '
        '
        Me.txtORNumber.Border.Class = "TextBoxBorder"
        Me.txtORNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtORNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORNumber.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtORNumber.FocusHighlightEnabled = True
        Me.txtORNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNumber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtORNumber.Location = New System.Drawing.Point(141, 43)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(175, 23)
        Me.txtORNumber.TabIndex = 186
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(22, 125)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(108, 18)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "DESCRIPTION / "
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(22, 47)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(88, 18)
        Me.LabelX2.TabIndex = 185
        Me.LabelX2.Text = "O.R NUMBER"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(22, 208)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(48, 18)
        Me.LabelX4.TabIndex = 150
        Me.LabelX4.Text = "Amount"
        '
        'diAmount
        '
        '
        '
        '
        Me.diAmount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.diAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.diAmount.DisplayFormat = "n2"
        Me.diAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diAmount.Increment = 1.0R
        Me.diAmount.Location = New System.Drawing.Point(139, 205)
        Me.diAmount.Name = "diAmount"
        Me.diAmount.ShowUpDown = True
        Me.diAmount.Size = New System.Drawing.Size(160, 26)
        Me.diAmount.TabIndex = 5
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.lblRequestForm)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 75)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(572, 56)
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
        Me.GroupPanel4.TabIndex = 193
        '
        'lblRequestForm
        '
        '
        '
        '
        Me.lblRequestForm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRequestForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRequestForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestForm.Location = New System.Drawing.Point(0, 0)
        Me.lblRequestForm.Name = "lblRequestForm"
        Me.lblRequestForm.Size = New System.Drawing.Size(566, 50)
        Me.lblRequestForm.TabIndex = 251
        Me.lblRequestForm.Text = "ADD INCOME"
        Me.lblRequestForm.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 32)
        Me.Panel1.TabIndex = 192
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Image = Global.SchoolMGT.My.Resources.Resources.Save_24x24
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnSave.Location = New System.Drawing.Point(386, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 32)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(479, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 32)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.cmbType)
        Me.GroupPanel1.Controls.Add(Me.txtCatID)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.cmbStudent)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(572, 75)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 188
        Me.GroupPanel1.Text = "CATEGORY "
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(18, 9)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(98, 18)
        Me.LabelX7.TabIndex = 156
        Me.LabelX7.Text = "INCOME CODE"
        '
        'cmbType
        '
        Me.cmbType.DisplayMember = "Text"
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 17
        Me.cmbType.Items.AddRange(New Object() {Me.ComboItem6, Me.ComboItem5})
        Me.cmbType.Location = New System.Drawing.Point(134, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(395, 23)
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
        'txtCatID
        '
        Me.txtCatID.AccessibleName = "product_item"
        '
        '
        '
        Me.txtCatID.Border.Class = "TextBoxBorder"
        Me.txtCatID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCatID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtCatID.FocusHighlightEnabled = True
        Me.txtCatID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCatID.Location = New System.Drawing.Point(373, 6)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.ReadOnly = True
        Me.txtCatID.Size = New System.Drawing.Size(44, 20)
        Me.txtCatID.TabIndex = 184
        Me.txtCatID.Visible = False
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(20, 7)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(104, 15)
        Me.LabelX6.TabIndex = 185
        Me.LabelX6.Text = "NAME OF STUDENT"
        Me.LabelX6.Visible = False
        '
        'cmbStudent
        '
        Me.cmbStudent.DisplayMember = "Text"
        Me.cmbStudent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStudent.Enabled = False
        Me.cmbStudent.FormattingEnabled = True
        Me.cmbStudent.ItemHeight = 14
        Me.cmbStudent.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8})
        Me.cmbStudent.Location = New System.Drawing.Point(134, 7)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(395, 20)
        Me.cmbStudent.TabIndex = 186
        Me.cmbStudent.Visible = False
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "EXPENSE"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "INCOME"
        '
        'fmaIncomeSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(594, 462)
        Me.MinimumSize = New System.Drawing.Size(594, 462)
        Me.Name = "fmaIncomeSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD INCOME"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtiDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
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
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents diAmount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents txtCatID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtORNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbStudent As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpPayDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSlip As CheckBox
    Friend WithEvents dtiDateIssued As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblRequestForm As DevComponents.DotNetBar.LabelX
End Class
