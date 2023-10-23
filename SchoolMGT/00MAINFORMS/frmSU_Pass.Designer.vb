<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSU_Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSU_Pass))
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.btnOK = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(146, 69)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 39)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(12, 69)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(128, 39)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(12, 33)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(112, 17)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "SUPERUSER PIN"
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
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.Location = New System.Drawing.Point(134, 27)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(140, 23)
        Me.txtPassword.TabIndex = 6
        '
        'frmSU_Pass
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(283, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtPassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(299, 143)
        Me.MinimumSize = New System.Drawing.Size(299, 143)
        Me.Name = "frmSU_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
End Class
