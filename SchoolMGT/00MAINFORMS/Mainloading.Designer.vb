<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainloading
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
        Me.components = New System.ComponentModel.Container
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Maroon
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(530, 33)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'LabelX1
        '
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelX1.Location = New System.Drawing.Point(0, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(528, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "LOADING ..."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Mainloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 58)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Mainloading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
