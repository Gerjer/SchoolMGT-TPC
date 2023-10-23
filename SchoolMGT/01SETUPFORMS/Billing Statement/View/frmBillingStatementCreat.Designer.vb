<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBillingStatementCreat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingStatementCreat))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdbtnTOSF = New System.Windows.Forms.RadioButton()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.rdbtnAdmissionFee = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.chk3rd = New System.Windows.Forms.CheckBox()
        Me.chk2nd = New System.Windows.Forms.CheckBox()
        Me.chk1st = New System.Windows.Forms.CheckBox()
        Me.TabControl4 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtAccountCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtAcademicYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbTerm = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonX11 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX12 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX13 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX14 = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem13 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnGenerate = New DevComponents.DotNetBar.ButtonX()
        Me.nudTotalAmt = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSemister = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.cmbFromYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.cmbToYear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem14 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtRefNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabControlPanel9.SuspendLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel10.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.nudTotalAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.Controls.Add(Me.TabControl4)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(599, 346)
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
        Me.GroupPanel1.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.rdbtnTOSF)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.rdbtnAdmissionFee)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.chk3rd)
        Me.Panel2.Controls.Add(Me.chk2nd)
        Me.Panel2.Controls.Add(Me.chk1st)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(593, 43)
        Me.Panel2.TabIndex = 253
        '
        'rdbtnTOSF
        '
        Me.rdbtnTOSF.AutoSize = True
        Me.rdbtnTOSF.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnTOSF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnTOSF.Location = New System.Drawing.Point(128, 11)
        Me.rdbtnTOSF.Name = "rdbtnTOSF"
        Me.rdbtnTOSF.Size = New System.Drawing.Size(53, 17)
        Me.rdbtnTOSF.TabIndex = 1
        Me.rdbtnTOSF.TabStop = True
        Me.rdbtnTOSF.Text = "TOSF"
        Me.rdbtnTOSF.UseVisualStyleBackColor = False
        Me.rdbtnTOSF.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.SchoolMGT.My.Resources.Resources.Save_24x24
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnSave.Location = New System.Drawing.Point(414, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnSave.Size = New System.Drawing.Size(87, 33)
        Me.btnSave.TabIndex = 255
        Me.btnSave.Tag = "1"
        Me.btnSave.Text = "&Save"
        Me.btnSave.Tooltip = "Add"
        '
        'rdbtnAdmissionFee
        '
        Me.rdbtnAdmissionFee.AutoSize = True
        Me.rdbtnAdmissionFee.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnAdmissionFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnAdmissionFee.Location = New System.Drawing.Point(14, 10)
        Me.rdbtnAdmissionFee.Name = "rdbtnAdmissionFee"
        Me.rdbtnAdmissionFee.Size = New System.Drawing.Size(108, 17)
        Me.rdbtnAdmissionFee.TabIndex = 0
        Me.rdbtnAdmissionFee.TabStop = True
        Me.rdbtnAdmissionFee.Text = "ADMISSION FEE"
        Me.rdbtnAdmissionFee.UseVisualStyleBackColor = False
        Me.rdbtnAdmissionFee.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(501, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.btnCancel.Size = New System.Drawing.Size(87, 33)
        Me.btnCancel.TabIndex = 254
        Me.btnCancel.Tag = "1"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Tooltip = "Add"
        '
        'chk3rd
        '
        Me.chk3rd.AutoSize = True
        Me.chk3rd.Location = New System.Drawing.Point(187, 43)
        Me.chk3rd.Name = "chk3rd"
        Me.chk3rd.Size = New System.Drawing.Size(131, 17)
        Me.chk3rd.TabIndex = 2
        Me.chk3rd.Text = "3rd Semester/Summer"
        Me.chk3rd.UseVisualStyleBackColor = True
        Me.chk3rd.Visible = False
        '
        'chk2nd
        '
        Me.chk2nd.AutoSize = True
        Me.chk2nd.Location = New System.Drawing.Point(187, 24)
        Me.chk2nd.Name = "chk2nd"
        Me.chk2nd.Size = New System.Drawing.Size(91, 17)
        Me.chk2nd.TabIndex = 1
        Me.chk2nd.Text = "2nd Semester"
        Me.chk2nd.UseVisualStyleBackColor = True
        Me.chk2nd.Visible = False
        '
        'chk1st
        '
        Me.chk1st.AutoSize = True
        Me.chk1st.Location = New System.Drawing.Point(187, 6)
        Me.chk1st.Name = "chk1st"
        Me.chk1st.Size = New System.Drawing.Size(87, 17)
        Me.chk1st.TabIndex = 0
        Me.chk1st.Text = "1st Semester"
        Me.chk1st.UseVisualStyleBackColor = True
        Me.chk1st.Visible = False
        '
        'TabControl4
        '
        Me.TabControl4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl4.CanReorderTabs = False
        Me.TabControl4.Controls.Add(Me.TabControlPanel9)
        Me.TabControl4.Controls.Add(Me.TabControlPanel10)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl4.Location = New System.Drawing.Point(0, 115)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl4.SelectedTabIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(593, 182)
        Me.TabControl4.TabIndex = 250
        Me.TabControl4.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl4.Tabs.Add(Me.TabItem13)
        Me.TabControl4.Tabs.Add(Me.TabItem14)
        Me.TabControl4.Text = "TabControl4"
        '
        'TabControlPanel9
        '
        Me.TabControlPanel9.Controls.Add(Me.nudAmount)
        Me.TabControlPanel9.Controls.Add(Me.LabelX6)
        Me.TabControlPanel9.Controls.Add(Me.txtAccountCode)
        Me.TabControlPanel9.Controls.Add(Me.LabelX5)
        Me.TabControlPanel9.Controls.Add(Me.LabelX4)
        Me.TabControlPanel9.Controls.Add(Me.LabelX3)
        Me.TabControlPanel9.Controls.Add(Me.txtAcademicYear)
        Me.TabControlPanel9.Controls.Add(Me.cmbTerm)
        Me.TabControlPanel9.Controls.Add(Me.Button3)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX11)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX12)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX13)
        Me.TabControlPanel9.Controls.Add(Me.ButtonX14)
        Me.TabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel9.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel9.Name = "TabControlPanel9"
        Me.TabControlPanel9.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel9.Size = New System.Drawing.Size(593, 156)
        Me.TabControlPanel9.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel9.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel9.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel9.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel9.Style.GradientAngle = 90
        Me.TabControlPanel9.TabIndex = 1
        Me.TabControlPanel9.TabItem = Me.TabItem13
        Me.TabControlPanel9.Text = "CONSOLIDATED"
        '
        'nudAmount
        '
        Me.nudAmount.DecimalPlaces = 2
        Me.nudAmount.Location = New System.Drawing.Point(174, 85)
        Me.nudAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(347, 20)
        Me.nudAmount.TabIndex = 259
        Me.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(66, 86)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(49, 15)
        Me.LabelX6.TabIndex = 258
        Me.LabelX6.Text = "AMOUNT"
        '
        'txtAccountCode
        '
        '
        '
        '
        Me.txtAccountCode.Border.Class = "TextBoxBorder"
        Me.txtAccountCode.Border.TextShadowColor = System.Drawing.Color.Tomato
        Me.txtAccountCode.FocusHighlightEnabled = True
        Me.txtAccountCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountCode.Location = New System.Drawing.Point(174, 60)
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.Size = New System.Drawing.Size(347, 20)
        Me.txtAccountCode.TabIndex = 257
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(64, 61)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(89, 15)
        Me.LabelX5.TabIndex = 256
        Me.LabelX5.Text = "ACCOUNT CODE"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(64, 36)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(91, 15)
        Me.LabelX4.TabIndex = 255
        Me.LabelX4.Text = "ACADEMIC YEAR"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(66, 11)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(33, 15)
        Me.LabelX3.TabIndex = 254
        Me.LabelX3.Text = "TERM"
        '
        'txtAcademicYear
        '
        '
        '
        '
        Me.txtAcademicYear.Border.Class = "TextBoxBorder"
        Me.txtAcademicYear.Border.TextShadowColor = System.Drawing.Color.Tomato
        Me.txtAcademicYear.FocusHighlightEnabled = True
        Me.txtAcademicYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcademicYear.Location = New System.Drawing.Point(174, 35)
        Me.txtAcademicYear.Name = "txtAcademicYear"
        Me.txtAcademicYear.Size = New System.Drawing.Size(347, 20)
        Me.txtAcademicYear.TabIndex = 253
        '
        'cmbTerm
        '
        Me.cmbTerm.DisplayMember = "Text"
        Me.cmbTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.ItemHeight = 14
        Me.cmbTerm.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbTerm.Location = New System.Drawing.Point(174, 9)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(347, 20)
        Me.cmbTerm.TabIndex = 248
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "1ST SEMISTER"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "2ND SEMISTER"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "3RD SEMISTER"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "SUMMER"
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(780, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'ButtonX11
        '
        Me.ButtonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX11.Image = CType(resources.GetObject("ButtonX11.Image"), System.Drawing.Image)
        Me.ButtonX11.Location = New System.Drawing.Point(886, 441)
        Me.ButtonX11.Name = "ButtonX11"
        Me.ButtonX11.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.ButtonX11.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX11.TabIndex = 29
        Me.ButtonX11.Text = "List's"
        '
        'ButtonX12
        '
        Me.ButtonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX12.Image = CType(resources.GetObject("ButtonX12.Image"), System.Drawing.Image)
        Me.ButtonX12.Location = New System.Drawing.Point(137, 441)
        Me.ButtonX12.Name = "ButtonX12"
        Me.ButtonX12.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.ButtonX12.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX12.TabIndex = 27
        Me.ButtonX12.Text = "Save"
        '
        'ButtonX13
        '
        Me.ButtonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ButtonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX13.Image = CType(resources.GetObject("ButtonX13.Image"), System.Drawing.Image)
        Me.ButtonX13.Location = New System.Drawing.Point(14, 441)
        Me.ButtonX13.Name = "ButtonX13"
        Me.ButtonX13.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.ButtonX13.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX13.TabIndex = 0
        Me.ButtonX13.Text = "Add"
        '
        'ButtonX14
        '
        Me.ButtonX14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX14.Image = CType(resources.GetObject("ButtonX14.Image"), System.Drawing.Image)
        Me.ButtonX14.Location = New System.Drawing.Point(260, 441)
        Me.ButtonX14.Name = "ButtonX14"
        Me.ButtonX14.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.ButtonX14.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX14.TabIndex = 28
        Me.ButtonX14.Text = "Delete"
        '
        'TabItem13
        '
        Me.TabItem13.AttachedControl = Me.TabControlPanel9
        Me.TabItem13.Name = "TabItem13"
        Me.TabItem13.Text = "CONSOLIDATED"
        Me.TabItem13.Visible = False
        '
        'TabControlPanel10
        '
        Me.TabControlPanel10.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel10.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel10.Name = "TabControlPanel10"
        Me.TabControlPanel10.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel10.Size = New System.Drawing.Size(593, 156)
        Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel10.Style.GradientAngle = 90
        Me.TabControlPanel10.TabIndex = 2
        Me.TabControlPanel10.TabItem = Me.TabItem14
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.btnGenerate)
        Me.GroupPanel2.Controls.Add(Me.nudTotalAmt)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(591, 154)
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
        Me.GroupPanel2.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageFixedSize = New System.Drawing.Size(30, 25)
        Me.btnGenerate.Location = New System.Drawing.Point(66, 85)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(208, 43)
        Me.btnGenerate.TabIndex = 271
        Me.btnGenerate.Text = "<b>Generate </b>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<font color=""#ED1C24"">TOTAL AMOUNT</font>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'nudTotalAmt
        '
        Me.nudTotalAmt.DecimalPlaces = 2
        Me.nudTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTotalAmt.Location = New System.Drawing.Point(312, 101)
        Me.nudTotalAmt.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudTotalAmt.Name = "nudTotalAmt"
        Me.nudTotalAmt.Size = New System.Drawing.Size(249, 26)
        Me.nudTotalAmt.TabIndex = 270
        Me.nudTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbSemister)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 62)
        Me.GroupBox2.TabIndex = 269
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Semister"
        '
        'cmbSemister
        '
        Me.cmbSemister.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSemister.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSemister.DisplayMember = "Text"
        Me.cmbSemister.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSemister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemister.FormattingEnabled = True
        Me.cmbSemister.ItemHeight = 14
        Me.cmbSemister.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16})
        Me.cmbSemister.Location = New System.Drawing.Point(10, 24)
        Me.cmbSemister.Name = "cmbSemister"
        Me.cmbSemister.Size = New System.Drawing.Size(249, 20)
        Me.cmbSemister.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbSemister.TabIndex = 268
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "1ST SEMISTER"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "2ND SEMISTER"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "3RD SEMISTER"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "SUMMER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.cmbFromYear)
        Me.GroupBox1.Controls.Add(Me.cmbToYear)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 71)
        Me.GroupBox1.TabIndex = 268
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Academic Year"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(22, 44)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(21, 15)
        Me.LabelX11.TabIndex = 269
        Me.LabelX11.Text = "To :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(22, 19)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(33, 15)
        Me.LabelX10.TabIndex = 268
        Me.LabelX10.Text = "From :"
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
        Me.cmbFromYear.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.cmbFromYear.Location = New System.Drawing.Point(61, 16)
        Me.cmbFromYear.Name = "cmbFromYear"
        Me.cmbFromYear.Size = New System.Drawing.Size(208, 20)
        Me.cmbFromYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbFromYear.TabIndex = 265
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
        Me.cmbToYear.Location = New System.Drawing.Point(61, 42)
        Me.cmbToYear.Name = "cmbToYear"
        Me.cmbToYear.Size = New System.Drawing.Size(208, 20)
        Me.cmbToYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.cmbToYear.TabIndex = 267
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
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX8.Location = New System.Drawing.Point(115, 39)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(28, 16)
        Me.LabelX8.TabIndex = 266
        Me.LabelX8.Text = "Year"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX9.Location = New System.Drawing.Point(88, 21)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(55, 16)
        Me.LabelX9.TabIndex = 264
        Me.LabelX9.Text = "Academic"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(302, 80)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(76, 15)
        Me.LabelX7.TabIndex = 251
        Me.LabelX7.Text = "<font color=""#ED1C24""><b>TOTAL TOSF :</b><font color=""#ED1C24""></font></font>"
        '
        'TabItem14
        '
        Me.TabItem14.AttachedControl = Me.TabControlPanel10
        Me.TabItem14.Name = "TabItem14"
        Me.TabItem14.Text = "EDUCATION BIILINGS DETAILS"
        Me.TabItem14.Visible = False
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupPanel3.Controls.Add(Me.dtpBillDate)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.txtRefNo)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 35)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(593, 80)
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
        Me.GroupPanel3.TabIndex = 252
        Me.GroupPanel3.Text = "Reference Details"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(432, 8)
        Me.MaskedTextBox1.Mask = "XX-XXXXXX-2021-X-X"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(149, 20)
        Me.MaskedTextBox1.TabIndex = 254
        Me.MaskedTextBox1.Visible = False
        '
        'dtpBillDate
        '
        Me.dtpBillDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDate.Location = New System.Drawing.Point(157, 30)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(257, 20)
        Me.dtpBillDate.TabIndex = 253
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(24, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(123, 15)
        Me.LabelX1.TabIndex = 250
        Me.LabelX1.Text = "REFERENCE NUMBER :"
        '
        'txtRefNo
        '
        '
        '
        '
        Me.txtRefNo.Border.Class = "TextBoxBorder"
        Me.txtRefNo.Border.TextShadowColor = System.Drawing.Color.Tomato
        Me.txtRefNo.FocusHighlightEnabled = True
        Me.txtRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(157, 4)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(257, 20)
        Me.txtRefNo.TabIndex = 252
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(24, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(37, 15)
        Me.LabelX2.TabIndex = 251
        Me.LabelX2.Text = "DATE :"
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
        Me.GroupPanel4.Size = New System.Drawing.Size(593, 35)
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
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(591, 33)
        Me.WinLabel.TabIndex = 245
        Me.WinLabel.Text = "CREAT BILLING"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmBillingStatementCreat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 346)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "frmBillingStatementCreat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREAT BIILING"
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabControlPanel9.ResumeLayout(False)
        Me.TabControlPanel9.PerformLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel10.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.nudTotalAmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl4 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonX11 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX12 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX13 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX14 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem13 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem14 As DevComponents.DotNetBar.TabItem
    Friend WithEvents rdbtnAdmissionFee As RadioButton
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rdbtnTOSF As RadioButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpBillDate As DateTimePicker
    Friend WithEvents txtRefNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAccountCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAcademicYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbTerm As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk2nd As CheckBox
    Friend WithEvents chk1st As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFromYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents cmbToYear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents nudTotalAmt As NumericUpDown
    Friend WithEvents chk3rd As CheckBox
    Friend WithEvents btnGenerate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbSemister As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
