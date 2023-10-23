<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaStudentCategorySetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaStudentCategorySetupForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtno_of_payment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnModify = New DevComponents.DotNetBar.ButtonX()
        Me.btnList = New DevComponents.DotNetBar.ButtonX()
        Me.txtSysPK = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelEx1.Size = New System.Drawing.Size(380, 28)
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
        Me.WinLabel.Size = New System.Drawing.Size(380, 23)
        Me.WinLabel.TabIndex = 20
        Me.WinLabel.Text = "STUDENT CATEGORY"
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
        Me.GroupPanel2.Controls.Add(Me.TextBox1)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.txtno_of_payment)
        Me.GroupPanel2.Controls.Add(Me.txtname)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.txtid)
        Me.GroupPanel2.Controls.Add(Me.btnModify)
        Me.GroupPanel2.Controls.Add(Me.btnList)
        Me.GroupPanel2.Controls.Add(Me.txtSysPK)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.GroupPanel2.Size = New System.Drawing.Size(380, 237)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 89)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 90)
        Me.TextBox1.TabIndex = 177
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(26, 95)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 15)
        Me.LabelX1.TabIndex = 176
        Me.LabelX1.Text = "DESCRIPTION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 32)
        Me.Panel1.TabIndex = 175
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(90, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnSave.Size = New System.Drawing.Size(93, 32)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(183, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.btnCancel.Size = New System.Drawing.Size(93, 32)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(276, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.btnAdd.Size = New System.Drawing.Size(93, 32)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(25, 62)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 15)
        Me.LabelX2.TabIndex = 173
        Me.LabelX2.Text = "NO. OF PAYMENTS"
        '
        'txtno_of_payment
        '
        Me.txtno_of_payment.AccessibleName = "student_categories"
        '
        '
        '
        Me.txtno_of_payment.Border.Class = "TextBoxBorder"
        Me.txtno_of_payment.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtno_of_payment.FocusHighlightEnabled = True
        Me.txtno_of_payment.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtno_of_payment.Location = New System.Drawing.Point(130, 57)
        Me.txtno_of_payment.Name = "txtno_of_payment"
        Me.txtno_of_payment.Size = New System.Drawing.Size(74, 20)
        Me.txtno_of_payment.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.AccessibleName = "student_categories"
        '
        '
        '
        Me.txtname.Border.Class = "TextBoxBorder"
        Me.txtname.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtname.FocusHighlightEnabled = True
        Me.txtname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtname.Location = New System.Drawing.Point(130, 27)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(233, 20)
        Me.txtname.TabIndex = 1
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(25, 32)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(99, 15)
        Me.LabelX7.TabIndex = 170
        Me.LabelX7.Text = "CATEGORY NAME"
        '
        'txtid
        '
        Me.txtid.AccessibleName = "student_categories"
        '
        '
        '
        Me.txtid.Border.Class = "TextBoxBorder"
        Me.txtid.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtid.FocusHighlightEnabled = True
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtid.Location = New System.Drawing.Point(270, 55)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(93, 20)
        Me.txtid.TabIndex = 19
        Me.txtid.Tag = ""
        Me.txtid.Visible = False
        '
        'btnModify
        '
        Me.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.Location = New System.Drawing.Point(185, 137)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.btnModify.Size = New System.Drawing.Size(49, 31)
        Me.btnModify.TabIndex = 148
        Me.btnModify.Text = "Modify"
        Me.btnModify.Visible = False
        '
        'btnList
        '
        Me.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.Location = New System.Drawing.Point(240, 137)
        Me.btnList.Name = "btnList"
        Me.btnList.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.btnList.Size = New System.Drawing.Size(49, 31)
        Me.btnList.TabIndex = 20
        Me.btnList.Text = "List's"
        Me.btnList.Visible = False
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
        Me.txtSysPK.Location = New System.Drawing.Point(270, 81)
        Me.txtSysPK.Name = "txtSysPK"
        Me.txtSysPK.Size = New System.Drawing.Size(93, 20)
        Me.txtSysPK.TabIndex = 174
        Me.txtSysPK.Tag = "student_categories"
        Me.txtSysPK.Visible = False
        '
        'fmaStudentCategorySetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(380, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaStudentCategorySetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT CATEGORY SETUP"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtno_of_payment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSysPK As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As Panel
End Class
