<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaUserSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaUserSetup))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cmbPerson = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUserID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtPasswordChar2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.lblPassword = New DevComponents.DotNetBar.LabelX()
        Me.txtPasswordChar1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtUserType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtFirstName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLastName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(526, 32)
        Me.Panel1.TabIndex = 190
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(242, 0)
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
        Me.btnAdd.Enabled = False
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(335, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(428, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 27)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupBox3)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 23)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(532, 406)
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
        Me.GroupPanel2.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.LabelX7)
        Me.GroupBox3.Controls.Add(Me.cmbPerson)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 82)
        Me.GroupBox3.TabIndex = 206
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Person Type"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(325, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 208
        Me.RadioButton2.Tag = "2"
        Me.RadioButton2.Text = "Student"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(194, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton1.TabIndex = 207
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "1"
        Me.RadioButton1.Text = "Employee"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(17, 48)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(114, 15)
        Me.LabelX7.TabIndex = 206
        Me.LabelX7.Text = "PERSCON ACCOUNT"
        '
        'cmbPerson
        '
        Me.cmbPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPerson.FormattingEnabled = True
        Me.cmbPerson.Location = New System.Drawing.Point(160, 46)
        Me.cmbPerson.Name = "cmbPerson"
        Me.cmbPerson.Size = New System.Drawing.Size(306, 21)
        Me.cmbPerson.TabIndex = 205
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtUserID)
        Me.GroupBox2.Controls.Add(Me.LabelX2)
        Me.GroupBox2.Controls.Add(Me.txtPasswordChar2)
        Me.GroupBox2.Controls.Add(Me.txtUserName)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Controls.Add(Me.lblPassword)
        Me.GroupBox2.Controls.Add(Me.txtPasswordChar1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 134)
        Me.GroupBox2.TabIndex = 204
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Details"
        '
        'txtUserID
        '
        Me.txtUserID.AccessibleName = ""
        Me.txtUserID.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtUserID.Border.Class = "TextBoxBorder"
        Me.txtUserID.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserID.FocusHighlightEnabled = True
        Me.txtUserID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserID.Location = New System.Drawing.Point(159, 6)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(70, 20)
        Me.txtUserID.TabIndex = 200
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.ForeColor = System.Drawing.Color.Red
        Me.LabelX2.Location = New System.Drawing.Point(36, 37)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 15)
        Me.LabelX2.TabIndex = 178
        Me.LabelX2.Text = "USER NAME*"
        '
        'txtPasswordChar2
        '
        Me.txtPasswordChar2.AccessibleName = "batches"
        Me.txtPasswordChar2.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtPasswordChar2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPasswordChar2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtPasswordChar2.Border.Class = "TextBoxBorder"
        Me.txtPasswordChar2.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPasswordChar2.FocusHighlightEnabled = True
        Me.txtPasswordChar2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPasswordChar2.Location = New System.Drawing.Point(159, 90)
        Me.txtPasswordChar2.Name = "txtPasswordChar2"
        Me.txtPasswordChar2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordChar2.Size = New System.Drawing.Size(307, 20)
        Me.txtPasswordChar2.TabIndex = 199
        Me.txtPasswordChar2.WatermarkText = "Re-type password"
        '
        'txtUserName
        '
        Me.txtUserName.AccessibleName = ""
        Me.txtUserName.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserName.FocusHighlightEnabled = True
        Me.txtUserName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserName.Location = New System.Drawing.Point(159, 32)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(307, 20)
        Me.txtUserName.TabIndex = 196
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.ForeColor = System.Drawing.Color.Red
        Me.LabelX5.Location = New System.Drawing.Point(36, 95)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(117, 15)
        Me.LabelX5.TabIndex = 198
        Me.LabelX5.Text = "RE-TYPE PASSWORD"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.Red
        Me.lblPassword.Location = New System.Drawing.Point(36, 65)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 15)
        Me.lblPassword.TabIndex = 186
        Me.lblPassword.Text = "NEW PASSWORD"
        '
        'txtPasswordChar1
        '
        Me.txtPasswordChar1.AccessibleName = "batches"
        Me.txtPasswordChar1.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtPasswordChar1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPasswordChar1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtPasswordChar1.Border.Class = "TextBoxBorder"
        Me.txtPasswordChar1.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPasswordChar1.FocusHighlightEnabled = True
        Me.txtPasswordChar1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPasswordChar1.Location = New System.Drawing.Point(159, 62)
        Me.txtPasswordChar1.Name = "txtPasswordChar1"
        Me.txtPasswordChar1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordChar1.Size = New System.Drawing.Size(307, 20)
        Me.txtPasswordChar1.TabIndex = 197
        Me.txtPasswordChar1.WatermarkText = "Type new password"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtUserType)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 122)
        Me.GroupBox1.TabIndex = 203
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Person Details"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(37, 28)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(69, 15)
        Me.LabelX1.TabIndex = 192
        Me.LabelX1.Text = "FIRST NAME"
        '
        'txtUserType
        '
        Me.txtUserType.AccessibleName = "batches"
        Me.txtUserType.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtUserType.Border.Class = "TextBoxBorder"
        Me.txtUserType.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserType.FocusHighlightEnabled = True
        Me.txtUserType.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserType.Location = New System.Drawing.Point(160, 80)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.ReadOnly = True
        Me.txtUserType.Size = New System.Drawing.Size(307, 20)
        Me.txtUserType.TabIndex = 202
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(37, 58)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(65, 15)
        Me.LabelX4.TabIndex = 193
        Me.LabelX4.Text = "LAST NAME"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(37, 88)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(65, 15)
        Me.LabelX6.TabIndex = 201
        Me.LabelX6.Text = "USER TYPE"
        '
        'txtFirstName
        '
        Me.txtFirstName.AccessibleName = "batches"
        Me.txtFirstName.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtFirstName.Border.Class = "TextBoxBorder"
        Me.txtFirstName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtFirstName.FocusHighlightEnabled = True
        Me.txtFirstName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFirstName.Location = New System.Drawing.Point(160, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(307, 20)
        Me.txtFirstName.TabIndex = 194
        '
        'txtLastName
        '
        Me.txtLastName.AccessibleName = "batches"
        Me.txtLastName.AutoCompleteCustomSource.AddRange(New String() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR"})
        Me.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtLastName.Border.Class = "TextBoxBorder"
        Me.txtLastName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtLastName.FocusHighlightEnabled = True
        Me.txtLastName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLastName.Location = New System.Drawing.Point(160, 52)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(307, 20)
        Me.txtLastName.TabIndex = 195
        '
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(532, 23)
        Me.WinLabel.TabIndex = 22
        Me.WinLabel.Text = "USER SETUP"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'fmaUserSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 429)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.WinLabel)
        Me.Name = "fmaUserSetup"
        Me.Text = "fmaUserSetup"
        Me.Panel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblPassword As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtLastName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFirstName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPasswordChar1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPasswordChar2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUserType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbPerson As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
