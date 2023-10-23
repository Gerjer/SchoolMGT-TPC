<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaFinance_FeeSchedulerForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaFinance_FeeSchedulerForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.dgvPaymentSchedule = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCategoryID = New System.Windows.Forms.TextBox
        Me.cmbCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX
        Me.btnSave = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgvPaymentSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.dgvPaymentSchedule)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(719, 446)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.Azure
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.MediumAquamarine
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
        Me.GroupPanel2.TabIndex = 17
        '
        'dgvPaymentSchedule
        '
        Me.dgvPaymentSchedule.AllowUserToAddRows = False
        Me.dgvPaymentSchedule.AllowUserToDeleteRows = False
        Me.dgvPaymentSchedule.AllowUserToOrderColumns = True
        Me.dgvPaymentSchedule.AllowUserToResizeColumns = False
        Me.dgvPaymentSchedule.AllowUserToResizeRows = False
        Me.dgvPaymentSchedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaymentSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPaymentSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvPaymentSchedule.Location = New System.Drawing.Point(55, 147)
        Me.dgvPaymentSchedule.Name = "dgvPaymentSchedule"
        Me.dgvPaymentSchedule.Size = New System.Drawing.Size(602, 284)
        Me.dgvPaymentSchedule.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESCRIPTION"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 350
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "date.now"
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "status"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCategoryID)
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.btnClearFilter)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 131)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(444, 28)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(30, 20)
        Me.txtCategoryID.TabIndex = 117
        Me.txtCategoryID.Visible = False
        '
        'cmbCategory
        '
        Me.cmbCategory.DisplayMember = "Text"
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 14
        Me.cmbCategory.Location = New System.Drawing.Point(108, 28)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(330, 20)
        Me.cmbCategory.TabIndex = 116
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Location = New System.Drawing.Point(9, 33)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(64, 15)
        Me.LabelX4.TabIndex = 115
        Me.LabelX4.Text = "CATEGORY"
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClearFilter.Location = New System.Drawing.Point(243, 85)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 31)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Enabled = False
        Me.btnSave.Image = Global.SchoolMGT.My.Resources.Resources.Save_24x24
        Me.btnSave.Location = New System.Drawing.Point(108, 85)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 31)
        Me.btnSave.TabIndex = 111
        Me.btnSave.Text = "Save"
        Me.btnSave.Tooltip = "Save Schedule"
        '
        'fmaFinance_FeeSchedulerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(735, 484)
        Me.MinimumSize = New System.Drawing.Size(735, 484)
        Me.Name = "fmaFinance_FeeSchedulerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fee Schedule"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgvPaymentSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCategoryID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvPaymentSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
