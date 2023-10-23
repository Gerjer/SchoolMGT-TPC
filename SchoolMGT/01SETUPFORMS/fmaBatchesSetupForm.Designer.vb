<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaBatchesSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaBatchesSetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtyear_level = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.txtsemester = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtcoursename = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSysPK = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcourse_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnModify = New DevComponents.DotNetBar.ButtonX()
        Me.btnList = New DevComponents.DotNetBar.ButtonX()
        Me.txtschool_year1 = New DevComponents.Editors.IntegerInput()
        Me.txtschool_year = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtschool_year2 = New DevComponents.Editors.IntegerInput()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtgrade_dist_from = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtgrade_dist_to = New System.Windows.Forms.DateTimePicker()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtschool_year1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtschool_year2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(457, 28)
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
        Me.WinLabel.Size = New System.Drawing.Size(457, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "BATCH / SECTION SETUP"
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
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.txtyear_level)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.txtsemester)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.txtname)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.txtcoursename)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.txtid)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK)
        Me.GroupPanel2.Controls.Add(Me.txtcourse_id)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.txtschool_year1)
        Me.GroupPanel2.Controls.Add(Me.txtschool_year)
        Me.GroupPanel2.Controls.Add(Me.txtschool_year2)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(457, 424)
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
        'txtyear_level
        '
        Me.txtyear_level.AccessibleName = "batches"
        Me.txtyear_level.DisplayMember = "Text"
        Me.txtyear_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtyear_level.FormattingEnabled = True
        Me.txtyear_level.ItemHeight = 14
        Me.txtyear_level.Location = New System.Drawing.Point(162, 54)
        Me.txtyear_level.Name = "txtyear_level"
        Me.txtyear_level.Size = New System.Drawing.Size(233, 20)
        Me.txtyear_level.TabIndex = 193
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(451, 32)
        Me.Panel1.TabIndex = 190
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(167, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 27)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(260, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 27)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(353, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 27)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'txtsemester
        '
        Me.txtsemester.AccessibleName = "batches"
        Me.txtsemester.AutoCompleteCustomSource.AddRange(New String() {"1ST SEMESTER", "2ND SEMESTER", "SUMMER"})
        Me.txtsemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtsemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtsemester.Border.Class = "TextBoxBorder"
        Me.txtsemester.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtsemester.FocusHighlightEnabled = True
        Me.txtsemester.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsemester.Location = New System.Drawing.Point(162, 82)
        Me.txtsemester.Name = "txtsemester"
        Me.txtsemester.Size = New System.Drawing.Size(233, 20)
        Me.txtsemester.TabIndex = 187
        Me.txtsemester.WatermarkText = "Leave Blank if not Applicable"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(25, 87)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(63, 15)
        Me.LabelX4.TabIndex = 188
        Me.LabelX4.Text = "SEMESTER"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(25, 116)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 15)
        Me.LabelX3.TabIndex = 186
        Me.LabelX3.Text = "SCHOOL YEAR*"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(25, 60)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(70, 15)
        Me.LabelX1.TabIndex = 184
        Me.LabelX1.Text = "YEAR LEVEL"
        '
        'txtname
        '
        Me.txtname.AccessibleName = "batches"
        '
        '
        '
        Me.txtname.Border.Class = "TextBoxBorder"
        Me.txtname.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtname.FocusHighlightEnabled = True
        Me.txtname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtname.Location = New System.Drawing.Point(162, 138)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(236, 47)
        Me.txtname.TabIndex = 181
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(25, 143)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(132, 15)
        Me.LabelX7.TabIndex = 182
        Me.LabelX7.Text = "BATCH NAME / SECTION"
        '
        'txtcoursename
        '
        Me.txtcoursename.AccessibleName = "batches"
        Me.txtcoursename.DisplayMember = "Text"
        Me.txtcoursename.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtcoursename.FormattingEnabled = True
        Me.txtcoursename.ItemHeight = 14
        Me.txtcoursename.Location = New System.Drawing.Point(162, 24)
        Me.txtcoursename.Name = "txtcoursename"
        Me.txtcoursename.Size = New System.Drawing.Size(233, 20)
        Me.txtcoursename.TabIndex = 179
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 15)
        Me.LabelX2.TabIndex = 178
        Me.LabelX2.Text = "COURSE / GRADE"
        '
        'txtid
        '
        Me.txtid.AccessibleName = "batches"
        '
        '
        '
        Me.txtid.Border.Class = "TextBoxBorder"
        Me.txtid.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtid.FocusHighlightEnabled = True
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtid.Location = New System.Drawing.Point(85, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(38, 20)
        Me.txtid.TabIndex = 19
        Me.txtid.Tag = ""
        Me.txtid.Visible = False
        '
        'txtSysPK
        '
        Me.txtSysPK.AccessibleName = ""
        '
        '
        '
        Me.txtSysPK.Border.Class = "TextBoxBorder"
        Me.txtSysPK.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK.FocusHighlightEnabled = True
        Me.txtSysPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK.Location = New System.Drawing.Point(312, -1)
        Me.txtSysPK.Name = "txtSysPK"
        Me.txtSysPK.Size = New System.Drawing.Size(38, 20)
        Me.txtSysPK.TabIndex = 19
        Me.txtSysPK.Tag = "batches"
        Me.txtSysPK.Visible = False
        '
        'txtcourse_id
        '
        Me.txtcourse_id.AccessibleName = "batches"
        '
        '
        '
        Me.txtcourse_id.Border.Class = "TextBoxBorder"
        Me.txtcourse_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtcourse_id.FocusHighlightEnabled = True
        Me.txtcourse_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourse_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcourse_id.Location = New System.Drawing.Point(25, 3)
        Me.txtcourse_id.Name = "txtcourse_id"
        Me.txtcourse_id.Size = New System.Drawing.Size(38, 20)
        Me.txtcourse_id.TabIndex = 180
        Me.txtcourse_id.Tag = ""
        Me.txtcourse_id.Visible = False
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(356, 143)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnModify.Size = New System.Drawing.Size(16, 31)
        Me.btnModify.TabIndex = 148
        Me.btnModify.Text = "Modify"
        Me.btnModify.Visible = False
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(334, 143)
        Me.btnList.Name = "btnList"
        Me.btnList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.btnList.Size = New System.Drawing.Size(16, 31)
        Me.btnList.TabIndex = 20
        Me.btnList.Text = "List's"
        Me.btnList.Visible = False
        '
        'txtschool_year1
        '
        Me.txtschool_year1.AccessibleName = "batches"
        Me.txtschool_year1.Location = New System.Drawing.Point(162, 112)
        Me.txtschool_year1.Name = "txtschool_year1"
        Me.txtschool_year1.ShowUpDown = True
        Me.txtschool_year1.Size = New System.Drawing.Size(233, 20)
        Me.txtschool_year1.TabIndex = 189
        '
        'txtschool_year
        '
        Me.txtschool_year.AccessibleName = "batches"
        Me.txtschool_year.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtschool_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtschool_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtschool_year.Border.Class = "TextBoxBorder"
        Me.txtschool_year.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtschool_year.FocusHighlightEnabled = True
        Me.txtschool_year.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtschool_year.Location = New System.Drawing.Point(176, 154)
        Me.txtschool_year.Name = "txtschool_year"
        Me.txtschool_year.Size = New System.Drawing.Size(193, 20)
        Me.txtschool_year.TabIndex = 191
        '
        'txtschool_year2
        '
        Me.txtschool_year2.AccessibleName = "batches"
        Me.txtschool_year2.Location = New System.Drawing.Point(273, 142)
        Me.txtschool_year2.Name = "txtschool_year2"
        Me.txtschool_year2.ShowUpDown = True
        Me.txtschool_year2.Size = New System.Drawing.Size(115, 20)
        Me.txtschool_year2.TabIndex = 192
        Me.txtschool_year2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtgrade_dist_to)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.txtgrade_dist_from)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 129)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade Distribution Schedule"
        '
        'txtgrade_dist_from
        '
        Me.txtgrade_dist_from.AccessibleName = "batches"
        Me.txtgrade_dist_from.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtgrade_dist_from.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrade_dist_from.CalendarForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtgrade_dist_from.CustomFormat = "MMMM dd,yyyy"
        Me.txtgrade_dist_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtgrade_dist_from.Location = New System.Drawing.Point(137, 39)
        Me.txtgrade_dist_from.Name = "txtgrade_dist_from"
        Me.txtgrade_dist_from.Size = New System.Drawing.Size(161, 20)
        Me.txtgrade_dist_from.TabIndex = 204
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(17, 44)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(95, 15)
        Me.LabelX5.TabIndex = 205
        Me.LabelX5.Text = "EDIT DATE FROM"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(17, 79)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(78, 15)
        Me.LabelX6.TabIndex = 206
        Me.LabelX6.Text = "EDIT DATE TO"
        '
        'txtgrade_dist_to
        '
        Me.txtgrade_dist_to.AccessibleName = "batches"
        Me.txtgrade_dist_to.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrade_dist_to.CalendarForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtgrade_dist_to.CustomFormat = "MMMM dd,yyyy"
        Me.txtgrade_dist_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtgrade_dist_to.Location = New System.Drawing.Point(137, 74)
        Me.txtgrade_dist_to.Name = "txtgrade_dist_to"
        Me.txtgrade_dist_to.Size = New System.Drawing.Size(161, 20)
        Me.txtgrade_dist_to.TabIndex = 207
        '
        'fmaBatchesSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaBatchesSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BATCH / SECTION"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtschool_year1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtschool_year2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSysPK As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcourse_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcoursename As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtsemester As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtschool_year1 As DevComponents.Editors.IntegerInput
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtschool_year As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtschool_year2 As DevComponents.Editors.IntegerInput
    Friend WithEvents txtyear_level As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtgrade_dist_to As DateTimePicker
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtgrade_dist_from As DateTimePicker
End Class
