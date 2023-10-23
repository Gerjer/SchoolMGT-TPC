<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftDatabaseConnectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ftDatabaseConnectionForm))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.txtServerName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtDatabaseName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
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
        'txtServerName
        '
        '
        '
        '
        Me.txtServerName.Border.Class = "TextBoxBorder"
        Me.txtServerName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtServerName.FocusHighlightEnabled = True
        Me.txtServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtServerName.Location = New System.Drawing.Point(101, 12)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(120, 23)
        Me.txtServerName.TabIndex = 1
        '
        'txtDatabaseName
        '
        '
        '
        '
        Me.txtDatabaseName.Border.Class = "TextBoxBorder"
        Me.txtDatabaseName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtDatabaseName.FocusHighlightEnabled = True
        Me.txtDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabaseName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDatabaseName.Location = New System.Drawing.Point(101, 41)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(120, 23)
        Me.txtDatabaseName.TabIndex = 2
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtUserName.FocusHighlightEnabled = True
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUserName.Location = New System.Drawing.Point(323, 12)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(120, 23)
        Me.txtUserName.TabIndex = 3
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtPassword.FocusHighlightEnabled = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.Location = New System.Drawing.Point(323, 41)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(120, 23)
        Me.txtPassword.TabIndex = 4
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(14, 15)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(67, 15)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Server Name"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(14, 44)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 15)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Database Name"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(253, 15)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(55, 15)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "UserName"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(253, 44)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(51, 15)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Password"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(323, 76)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 33)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "Connect"
        '
        'ftDatabaseConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 121)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtDatabaseName)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.ButtonX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ftDatabaseConnectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Connection"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtServerName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDatabaseName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
End Class
