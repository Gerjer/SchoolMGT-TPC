<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ftLoginForm
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ftLoginForm))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnBlank = New DevComponents.DotNetBar.ButtonX()
        Me.pxBoxSettings = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.lblSettings = New DevComponents.DotNetBar.LabelX()
        Me.btnOK = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pic_box_save = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pxBoxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(32260, 32146)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(99, 61)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "ButtonX1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.GroupPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 230)
        Me.Panel1.TabIndex = 12
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.DarkRed
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnBlank)
        Me.GroupPanel1.Controls.Add(Me.pxBoxSettings)
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.lblSettings)
        Me.GroupPanel1.Controls.Add(Me.btnOK)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtPassword)
        Me.GroupPanel1.Controls.Add(Me.txtUserName)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(256, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(354, 230)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
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
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.TabStop = True
        '
        'btnBlank
        '
        Me.btnBlank.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBlank.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlank.Image = CType(resources.GetObject("btnBlank.Image"), System.Drawing.Image)
        Me.btnBlank.Location = New System.Drawing.Point(3, 3)
        Me.btnBlank.Name = "btnBlank"
        Me.btnBlank.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnBlank.Size = New System.Drawing.Size(136, 33)
        Me.btnBlank.TabIndex = 6
        Me.btnBlank.Text = "blacnk"
        Me.btnBlank.Visible = False
        '
        'pxBoxSettings
        '
        Me.pxBoxSettings.BackgroundImage = CType(resources.GetObject("pxBoxSettings.BackgroundImage"), System.Drawing.Image)
        Me.pxBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pxBoxSettings.Location = New System.Drawing.Point(305, 188)
        Me.pxBoxSettings.Name = "pxBoxSettings"
        Me.pxBoxSettings.Size = New System.Drawing.Size(27, 25)
        Me.pxBoxSettings.TabIndex = 5
        Me.pxBoxSettings.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(198, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnCancel.Size = New System.Drawing.Size(136, 33)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.Maroon
        Me.lblSettings.Location = New System.Drawing.Point(239, 192)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(60, 21)
        Me.lblSettings.TabIndex = 4
        Me.lblSettings.Text = "Settings"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(37, 135)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(136, 33)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "LOGIN"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX2.Location = New System.Drawing.Point(13, 91)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(73, 21)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Password"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX1.Location = New System.Drawing.Point(13, 48)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(79, 21)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "UserName"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.ButtonCustom.Image = CType(resources.GetObject("txtPassword.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtPassword.ButtonCustom.Visible = True
        Me.txtPassword.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPassword.FocusHighlightEnabled = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Olive
        Me.txtPassword.Location = New System.Drawing.Point(112, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(225, 26)
        Me.txtPassword.TabIndex = 1
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.ButtonCustom.Image = CType(resources.GetObject("txtUserName.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtUserName.ButtonCustom.Visible = True
        Me.txtUserName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserName.FocusHighlightEnabled = True
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.OliveDrab
        Me.txtUserName.Location = New System.Drawing.Point(112, 48)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(225, 26)
        Me.txtUserName.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.pic_box_save)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(256, 230)
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
        Me.GroupPanel2.TabIndex = 3
        '
        'pic_box_save
        '
        Me.pic_box_save.BackColor = System.Drawing.Color.Black
        Me.pic_box_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_box_save.Location = New System.Drawing.Point(0, 0)
        Me.pic_box_save.Name = "pic_box_save"
        Me.pic_box_save.Size = New System.Drawing.Size(250, 224)
        Me.pic_box_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_box_save.TabIndex = 0
        Me.pic_box_save.TabStop = False
        '
        'ftLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(610, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ftLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.pxBoxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.pic_box_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pic_box_save As System.Windows.Forms.PictureBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnBlank As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pxBoxSettings As System.Windows.Forms.PictureBox
    Friend WithEvents lblSettings As DevComponents.DotNetBar.LabelX
End Class
