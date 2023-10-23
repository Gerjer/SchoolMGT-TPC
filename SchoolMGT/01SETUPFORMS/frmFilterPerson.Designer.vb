<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFilterPerson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilterPerson))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddNewPerson = New DevComponents.DotNetBar.ButtonX()
        Me.btnSelect = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1186, 410)
        Me.PanelControl1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Panel2.Size = New System.Drawing.Size(1182, 370)
        Me.Panel2.TabIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.GridControl1.Location = New System.Drawing.Point(5, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1172, 370)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.LevelIndent = 5
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 100
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnAddNewPerson)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 36)
        Me.Panel1.TabIndex = 3
        '
        'BtnAddNewPerson
        '
        Me.BtnAddNewPerson.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddNewPerson.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddNewPerson.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAddNewPerson.Image = Global.SchoolMGT.My.Resources.Resources.add_user_32
        Me.BtnAddNewPerson.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.BtnAddNewPerson.Location = New System.Drawing.Point(98, 0)
        Me.BtnAddNewPerson.Name = "BtnAddNewPerson"
        Me.BtnAddNewPerson.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.BtnAddNewPerson.Size = New System.Drawing.Size(133, 36)
        Me.BtnAddNewPerson.TabIndex = 205
        Me.BtnAddNewPerson.Text = "Add New Person Profile"
        '
        'btnSelect
        '
        Me.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnSelect.Location = New System.Drawing.Point(0, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSelect.Size = New System.Drawing.Size(98, 36)
        Me.btnSelect.TabIndex = 204
        Me.btnSelect.Text = "Select"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(1084, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.btnCancel.Size = New System.Drawing.Size(98, 36)
        Me.btnCancel.TabIndex = 203
        Me.btnCancel.Text = "Cancel"
        '
        'frmFilterPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1186, 410)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFilterPerson"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSelect As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnAddNewPerson As DevComponents.DotNetBar.ButtonX
End Class
