<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyProfileSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanyProfileSetup))
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pic_box_save = New System.Windows.Forms.PictureBox()
        Me.btnOK = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.txtDisplayName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPhotoPath_Empl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMobileNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtFaxNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtDescriptionName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmailAdd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.txtPhotoPath_Header = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pichdr_box_save = New System.Windows.Forms.PictureBox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.btnCancelPP = New System.Windows.Forms.Button()
        Me.txtList = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.pichdr_box_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(282, 22)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 17)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "DISPLAY NAME"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.pic_box_save)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(262, 233)
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
        Me.GroupPanel1.TabIndex = 10
        Me.GroupPanel1.Text = "ORGANIZATION LOGO"
        '
        'pic_box_save
        '
        Me.pic_box_save.BackgroundImage = CType(resources.GetObject("pic_box_save.BackgroundImage"), System.Drawing.Image)
        Me.pic_box_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_box_save.Location = New System.Drawing.Point(0, 0)
        Me.pic_box_save.Name = "pic_box_save"
        Me.pic_box_save.Size = New System.Drawing.Size(256, 212)
        Me.pic_box_save.TabIndex = 0
        Me.pic_box_save.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(486, 7)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(128, 37)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(614, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 37)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "CANCEL"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.AccessibleName = "users"
        '
        '
        '
        Me.txtDisplayName.Border.Class = "TextBoxBorder"
        Me.txtDisplayName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDisplayName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtDisplayName.FocusHighlightEnabled = True
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDisplayName.Location = New System.Drawing.Point(439, 22)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(285, 23)
        Me.txtDisplayName.TabIndex = 11
        '
        'txtPhotoPath_Empl
        '
        Me.txtPhotoPath_Empl.AccessibleName = "employees"
        '
        '
        '
        Me.txtPhotoPath_Empl.Border.Class = "TextBoxBorder"
        Me.txtPhotoPath_Empl.ButtonCustom.Text = "Browse"
        Me.txtPhotoPath_Empl.ButtonCustom.Visible = True
        Me.txtPhotoPath_Empl.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPhotoPath_Empl.FocusHighlightEnabled = True
        Me.txtPhotoPath_Empl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPhotoPath_Empl.Location = New System.Drawing.Point(14, 243)
        Me.txtPhotoPath_Empl.Name = "txtPhotoPath_Empl"
        Me.txtPhotoPath_Empl.Size = New System.Drawing.Size(256, 20)
        Me.txtPhotoPath_Empl.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(282, 79)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(67, 17)
        Me.LabelX1.TabIndex = 31
        Me.LabelX1.Text = "ADDRESS"
        '
        'txtAddress
        '
        Me.txtAddress.AccessibleName = "users"
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtAddress.FocusHighlightEnabled = True
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAddress.Location = New System.Drawing.Point(439, 79)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(285, 48)
        Me.txtAddress.TabIndex = 12
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(282, 133)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(145, 17)
        Me.LabelX3.TabIndex = 33
        Me.LabelX3.Text = "TELEPHONE NUMBER"
        '
        'txtContact
        '
        Me.txtContact.AccessibleName = "users"
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtContact.FocusHighlightEnabled = True
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContact.Location = New System.Drawing.Point(439, 133)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(285, 23)
        Me.txtContact.TabIndex = 13
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AccessibleName = "users"
        '
        '
        '
        Me.txtMobileNo.Border.Class = "TextBoxBorder"
        Me.txtMobileNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMobileNo.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtMobileNo.FocusHighlightEnabled = True
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMobileNo.Location = New System.Drawing.Point(439, 162)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(285, 23)
        Me.txtMobileNo.TabIndex = 34
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(282, 166)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(115, 17)
        Me.LabelX4.TabIndex = 35
        Me.LabelX4.Text = "MOBILE NUMBER"
        '
        'txtFaxNo
        '
        Me.txtFaxNo.AccessibleName = "users"
        '
        '
        '
        Me.txtFaxNo.Border.Class = "TextBoxBorder"
        Me.txtFaxNo.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtFaxNo.FocusHighlightEnabled = True
        Me.txtFaxNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFaxNo.Location = New System.Drawing.Point(439, 191)
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(285, 23)
        Me.txtFaxNo.TabIndex = 36
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(282, 195)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(90, 17)
        Me.LabelX5.TabIndex = 37
        Me.LabelX5.Text = "FAX NUMBER"
        '
        'txtDescriptionName
        '
        Me.txtDescriptionName.AccessibleName = "users"
        '
        '
        '
        Me.txtDescriptionName.Border.Class = "TextBoxBorder"
        Me.txtDescriptionName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescriptionName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtDescriptionName.FocusHighlightEnabled = True
        Me.txtDescriptionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescriptionName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescriptionName.Location = New System.Drawing.Point(439, 51)
        Me.txtDescriptionName.Name = "txtDescriptionName"
        Me.txtDescriptionName.Size = New System.Drawing.Size(285, 23)
        Me.txtDescriptionName.TabIndex = 39
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(282, 51)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(136, 17)
        Me.LabelX6.TabIndex = 38
        Me.LabelX6.Text = "DESCRIPTION NAME"
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.AccessibleName = "users"
        '
        '
        '
        Me.txtEmailAdd.Border.Class = "TextBoxBorder"
        Me.txtEmailAdd.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtEmailAdd.FocusHighlightEnabled = True
        Me.txtEmailAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAdd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEmailAdd.Location = New System.Drawing.Point(439, 220)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(285, 23)
        Me.txtEmailAdd.TabIndex = 40
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(285, 224)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(116, 17)
        Me.LabelX7.TabIndex = 41
        Me.LabelX7.Text = "E-MAIL ADDRESS"
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabControl2.CanReorderTabs = False
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(749, 302)
        Me.TabControl2.TabIndex = 51
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.txtPhotoPath_Header)
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(749, 276)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'txtPhotoPath_Header
        '
        Me.txtPhotoPath_Header.AccessibleName = "employees"
        '
        '
        '
        Me.txtPhotoPath_Header.Border.Class = "TextBoxBorder"
        Me.txtPhotoPath_Header.ButtonCustom.Text = "Browse"
        Me.txtPhotoPath_Header.ButtonCustom.Visible = True
        Me.txtPhotoPath_Header.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPhotoPath_Header.FocusHighlightEnabled = True
        Me.txtPhotoPath_Header.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPhotoPath_Header.Location = New System.Drawing.Point(12, 240)
        Me.txtPhotoPath_Header.Name = "txtPhotoPath_Header"
        Me.txtPhotoPath_Header.Size = New System.Drawing.Size(292, 20)
        Me.txtPhotoPath_Header.TabIndex = 12
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.pichdr_box_save)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(712, 230)
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
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 11
        Me.GroupPanel2.Text = "HEADER LOGO"
        '
        'pichdr_box_save
        '
        Me.pichdr_box_save.BackgroundImage = CType(resources.GetObject("pichdr_box_save.BackgroundImage"), System.Drawing.Image)
        Me.pichdr_box_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pichdr_box_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pichdr_box_save.Location = New System.Drawing.Point(0, 0)
        Me.pichdr_box_save.Name = "pichdr_box_save"
        Me.pichdr_box_save.Size = New System.Drawing.Size(706, 209)
        Me.pichdr_box_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pichdr_box_save.TabIndex = 0
        Me.pichdr_box_save.TabStop = False
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Other Image"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.btnCancelPP)
        Me.TabControlPanel1.Controls.Add(Me.txtEmailAdd)
        Me.TabControlPanel1.Controls.Add(Me.txtPhotoPath_Empl)
        Me.TabControlPanel1.Controls.Add(Me.LabelX7)
        Me.TabControlPanel1.Controls.Add(Me.txtList)
        Me.TabControlPanel1.Controls.Add(Me.txtDescriptionName)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX6)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX2)
        Me.TabControlPanel1.Controls.Add(Me.txtFaxNo)
        Me.TabControlPanel1.Controls.Add(Me.btnDelete)
        Me.TabControlPanel1.Controls.Add(Me.LabelX5)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel1.Controls.Add(Me.txtMobileNo)
        Me.TabControlPanel1.Controls.Add(Me.LabelX2)
        Me.TabControlPanel1.Controls.Add(Me.LabelX4)
        Me.TabControlPanel1.Controls.Add(Me.txtDisplayName)
        Me.TabControlPanel1.Controls.Add(Me.txtContact)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX3)
        Me.TabControlPanel1.Controls.Add(Me.txtAddress)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(749, 276)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'btnCancelPP
        '
        Me.btnCancelPP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelPP.Location = New System.Drawing.Point(780, 449)
        Me.btnCancelPP.Name = "btnCancelPP"
        Me.btnCancelPP.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelPP.TabIndex = 19
        Me.btnCancelPP.Text = "Cancel"
        Me.btnCancelPP.UseVisualStyleBackColor = True
        Me.btnCancelPP.Visible = False
        '
        'txtList
        '
        Me.txtList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtList.Image = CType(resources.GetObject("txtList.Image"), System.Drawing.Image)
        Me.txtList.Location = New System.Drawing.Point(886, 441)
        Me.txtList.Name = "txtList"
        Me.txtList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.txtList.Size = New System.Drawing.Size(93, 31)
        Me.txtList.TabIndex = 29
        Me.txtList.Text = "List's"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(137, 441)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.ButtonX1.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX1.TabIndex = 27
        Me.ButtonX1.Text = "Save"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.Location = New System.Drawing.Point(14, 441)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.ButtonX2.Size = New System.Drawing.Size(93, 31)
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.Text = "Add"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(260, 441)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnDelete.Size = New System.Drawing.Size(93, 31)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Default"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel1.Size = New System.Drawing.Size(749, 51)
        Me.Panel1.TabIndex = 52
        '
        'frmCompanyProfileSetup
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(749, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmCompanyProfileSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.pichdr_box_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pic_box_save As System.Windows.Forms.PictureBox
    Friend WithEvents txtDisplayName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPhotoPath_Empl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMobileNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFaxNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescriptionName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEmailAdd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pichdr_box_save As PictureBox
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents btnCancelPP As Button
    Friend WithEvents txtList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPhotoPath_Header As DevComponents.DotNetBar.Controls.TextBoxX
End Class
