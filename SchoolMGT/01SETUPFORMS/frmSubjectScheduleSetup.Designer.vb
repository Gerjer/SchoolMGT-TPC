<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSubjectScheduleSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubjectScheduleSetup))
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.cmblocation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtroom = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.txtname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtclass_time = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtroom_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtemployee_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtclass_timing_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtemployee_name = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnModify = New DevComponents.DotNetBar.ButtonX()
        Me.btnList = New DevComponents.DotNetBar.ButtonX()
        Me.txtSysPK_Item = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsubject_id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.MediumAquamarine
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(581, 35)
        Me.WinLabel.TabIndex = 21
        Me.WinLabel.Text = "Subject Schedule Setup"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.txtroom_id)
        Me.GroupPanel2.Controls.Add(Me.txtemployee_id)
        Me.GroupPanel2.Controls.Add(Me.txtclass_timing_id)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.txtemployee_name)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK_Item)
        Me.GroupPanel2.Controls.Add(Me.txtsubject_id)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 35)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(581, 427)
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
        Me.GroupPanel2.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.LabelX10)
        Me.GroupBox2.Controls.Add(Me.cmblocation)
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Controls.Add(Me.txtroom)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 115)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOCATION"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(243, 55)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(148, 20)
        Me.NumericUpDown1.TabIndex = 171
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        Me.LabelX10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX10.Location = New System.Drawing.Point(153, 60)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(70, 15)
        Me.LabelX10.TabIndex = 170
        Me.LabelX10.Text = "Floor Number"
        '
        'cmblocation
        '
        Me.cmblocation.AccessibleName = "subject_class_schedule"
        Me.cmblocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmblocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblocation.DisplayMember = "Text"
        Me.cmblocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmblocation.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.cmblocation.FocusHighlightEnabled = True
        Me.cmblocation.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.ItemHeight = 14
        Me.cmblocation.Location = New System.Drawing.Point(153, 26)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(240, 20)
        Me.cmblocation.TabIndex = 168
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(25, 31)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(89, 15)
        Me.LabelX7.TabIndex = 169
        Me.LabelX7.Text = "BUILDING NAME"
        '
        'txtroom
        '
        Me.txtroom.AccessibleName = "subject_class_schedule"
        Me.txtroom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtroom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtroom.DisplayMember = "Text"
        Me.txtroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtroom.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtroom.FocusHighlightEnabled = True
        Me.txtroom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtroom.FormattingEnabled = True
        Me.txtroom.ItemHeight = 14
        Me.txtroom.Location = New System.Drawing.Point(155, 85)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(238, 20)
        Me.txtroom.TabIndex = 3
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(25, 85)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(44, 15)
        Me.LabelX5.TabIndex = 156
        Me.LabelX5.Text = "ROOM *"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtclass_time)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 191)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SCHEDULE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "h:mm:ss tt"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(235, 134)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(158, 20)
        Me.DateTimePicker1.TabIndex = 171
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "h:mm:ss tt"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(235, 108)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(158, 20)
        Me.dtpFrom.TabIndex = 170
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        Me.LabelX9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX9.Location = New System.Drawing.Point(155, 132)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(15, 15)
        Me.LabelX9.TabIndex = 169
        Me.LabelX9.Text = "To"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX8.Location = New System.Drawing.Point(155, 110)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(28, 15)
        Me.LabelX8.TabIndex = 168
        Me.LabelX8.Text = "From"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(25, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(73, 15)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "CLASS CODE"
        '
        'txtcode
        '
        Me.txtcode.AccessibleName = "subject_class_schedule"
        '
        '
        '
        Me.txtcode.Border.Class = "TextBoxBorder"
        Me.txtcode.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcode.Location = New System.Drawing.Point(149, 14)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(244, 20)
        Me.txtcode.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox7)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Location = New System.Drawing.Point(17, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 18)
        Me.Panel1.TabIndex = 167
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox4.Location = New System.Drawing.Point(85, 0)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(47, 18)
        Me.CheckBox4.TabIndex = 163
        Me.CheckBox4.Text = "Mon"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox7.Location = New System.Drawing.Point(132, 0)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(45, 18)
        Me.CheckBox7.TabIndex = 166
        Me.CheckBox7.Text = "Tue"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox1.Location = New System.Drawing.Point(177, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 18)
        Me.CheckBox1.TabIndex = 160
        Me.CheckBox1.Text = "Wed"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox6.Location = New System.Drawing.Point(226, 0)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(45, 18)
        Me.CheckBox6.TabIndex = 165
        Me.CheckBox6.Text = "Thu"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox2.Location = New System.Drawing.Point(271, 0)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(37, 18)
        Me.CheckBox2.TabIndex = 161
        Me.CheckBox2.Text = "Fri"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox5.Location = New System.Drawing.Point(308, 0)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(42, 18)
        Me.CheckBox5.TabIndex = 164
        Me.CheckBox5.Text = "Sat"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox3.ForeColor = System.Drawing.Color.Red
        Me.CheckBox3.Location = New System.Drawing.Point(350, 0)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(45, 18)
        Me.CheckBox3.TabIndex = 162
        Me.CheckBox3.Text = "Sun"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.AccessibleName = "subject_class_schedule"
        '
        '
        '
        Me.txtname.Border.Class = "TextBoxBorder"
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtname.FocusHighlightEnabled = True
        Me.txtname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtname.Location = New System.Drawing.Point(149, 64)
        Me.txtname.MaxLength = 30
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(244, 36)
        Me.txtname.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 65)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(97, 15)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "SCHEDULE NAME"
        '
        'txtclass_time
        '
        Me.txtclass_time.AccessibleName = "subject_class_schedule"
        Me.txtclass_time.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtclass_time.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtclass_time.DisplayMember = "Text"
        Me.txtclass_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtclass_time.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtclass_time.FocusHighlightEnabled = True
        Me.txtclass_time.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtclass_time.FormattingEnabled = True
        Me.txtclass_time.ItemHeight = 14
        Me.txtclass_time.Location = New System.Drawing.Point(149, 164)
        Me.txtclass_time.Name = "txtclass_time"
        Me.txtclass_time.Size = New System.Drawing.Size(244, 20)
        Me.txtclass_time.TabIndex = 4
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(25, 164)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(96, 15)
        Me.LabelX4.TabIndex = 151
        Me.LabelX4.Text = "TIME SCHEDULE*"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelX6.Location = New System.Drawing.Point(153, 363)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(257, 23)
        Me.LabelX6.TabIndex = 159
        Me.LabelX6.Text = "* Required to Fill Out All Fields."
        '
        'txtroom_id
        '
        Me.txtroom_id.AccessibleName = "subject_class_schedule"
        '
        '
        '
        Me.txtroom_id.Border.Class = "TextBoxBorder"
        Me.txtroom_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtroom_id.FocusHighlightEnabled = True
        Me.txtroom_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroom_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtroom_id.Location = New System.Drawing.Point(432, 158)
        Me.txtroom_id.Name = "txtroom_id"
        Me.txtroom_id.Size = New System.Drawing.Size(22, 20)
        Me.txtroom_id.TabIndex = 158
        Me.txtroom_id.TabStop = False
        Me.txtroom_id.Tag = ""
        Me.txtroom_id.Visible = False
        '
        'txtemployee_id
        '
        Me.txtemployee_id.AccessibleName = "subject_class_schedule"
        '
        '
        '
        Me.txtemployee_id.Border.Class = "TextBoxBorder"
        Me.txtemployee_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtemployee_id.FocusHighlightEnabled = True
        Me.txtemployee_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployee_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtemployee_id.Location = New System.Drawing.Point(432, 221)
        Me.txtemployee_id.Name = "txtemployee_id"
        Me.txtemployee_id.Size = New System.Drawing.Size(22, 20)
        Me.txtemployee_id.TabIndex = 155
        Me.txtemployee_id.TabStop = False
        Me.txtemployee_id.Tag = ""
        Me.txtemployee_id.Visible = False
        '
        'txtclass_timing_id
        '
        Me.txtclass_timing_id.AccessibleName = "subject_class_schedule"
        Me.txtclass_timing_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtclass_timing_id.FocusHighlightEnabled = True
        Me.txtclass_timing_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclass_timing_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtclass_timing_id.Location = New System.Drawing.Point(432, 190)
        Me.txtclass_timing_id.Name = "txtclass_timing_id"
        Me.txtclass_timing_id.Size = New System.Drawing.Size(22, 13)
        Me.txtclass_timing_id.TabIndex = 154
        Me.txtclass_timing_id.TabStop = False
        Me.txtclass_timing_id.Tag = ""
        Me.txtclass_timing_id.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(17, 337)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(79, 15)
        Me.LabelX3.TabIndex = 150
        Me.LabelX3.Text = "INSTRUCTOR*"
        '
        'txtemployee_name
        '
        Me.txtemployee_name.AccessibleName = "subject_class_schedule"
        Me.txtemployee_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtemployee_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtemployee_name.DisplayMember = "Text"
        Me.txtemployee_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtemployee_name.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtemployee_name.FocusHighlightEnabled = True
        Me.txtemployee_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtemployee_name.FormattingEnabled = True
        Me.txtemployee_name.ItemHeight = 14
        Me.txtemployee_name.Location = New System.Drawing.Point(170, 337)
        Me.txtemployee_name.Name = "txtemployee_name"
        Me.txtemployee_name.Size = New System.Drawing.Size(238, 20)
        Me.txtemployee_name.TabIndex = 5
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(371, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnModify.Size = New System.Drawing.Size(49, 18)
        Me.btnModify.TabIndex = 148
        Me.btnModify.Text = "Modify"
        Me.btnModify.Visible = False
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(415, 3)
        Me.btnList.Name = "btnList"
        Me.btnList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.btnList.Size = New System.Drawing.Size(49, 16)
        Me.btnList.TabIndex = 20
        Me.btnList.Text = "List's"
        Me.btnList.Visible = False
        '
        'txtSysPK_Item
        '
        Me.txtSysPK_Item.AccessibleName = ""
        '
        '
        '
        Me.txtSysPK_Item.Border.Class = "TextBoxBorder"
        Me.txtSysPK_Item.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtSysPK_Item.FocusHighlightEnabled = True
        Me.txtSysPK_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysPK_Item.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSysPK_Item.Location = New System.Drawing.Point(297, -1)
        Me.txtSysPK_Item.Name = "txtSysPK_Item"
        Me.txtSysPK_Item.Size = New System.Drawing.Size(49, 20)
        Me.txtSysPK_Item.TabIndex = 19
        Me.txtSysPK_Item.TabStop = False
        Me.txtSysPK_Item.Tag = "subject_class_schedule"
        Me.txtSysPK_Item.Visible = False
        '
        'txtsubject_id
        '
        Me.txtsubject_id.AccessibleName = "subject_class_schedule"
        Me.txtsubject_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubject_id.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtsubject_id.FocusHighlightEnabled = True
        Me.txtsubject_id.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsubject_id.Location = New System.Drawing.Point(128, 1)
        Me.txtsubject_id.MaxLength = 30
        Me.txtsubject_id.Name = "txtsubject_id"
        Me.txtsubject_id.Size = New System.Drawing.Size(127, 20)
        Me.txtsubject_id.TabIndex = 153
        Me.txtsubject_id.TabStop = False
        Me.txtsubject_id.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(482, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 32)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(389, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 32)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(296, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 32)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnSave)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 424)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(581, 38)
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
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 23
        '
        'frmSubjectScheduleSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 462)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.WinLabel)
        Me.Name = "frmSubjectScheduleSetup"
        Me.ShowIcon = False
        Me.Text = "SUBJECT SCHEDULE"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtroom_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtroom As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtemployee_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtclass_timing_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsubject_id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtclass_time As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtemployee_name As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSysPK_Item As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmblocation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
End Class
