<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaSubjectTeacherListForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaSubjectTeacherListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MeViewer = New DataDynamics.ActiveReports.Viewer.Viewer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stillSpinner = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.rollingSpinner = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtElectiveID = New System.Windows.Forms.TextBox()
        Me.txtElectives = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.CMenuStripOperations.SuspendLayout()
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
        Me.GroupPanel2.Controls.Add(Me.MeViewer)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1139, 681)
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
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 17
        '
        'MeViewer
        '
        Me.MeViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MeViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MeViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MeViewer.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.MeViewer.Location = New System.Drawing.Point(0, 86)
        Me.MeViewer.Name = "MeViewer"
        Me.MeViewer.ReportViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.ReportViewer.CurrentPage = 0
        Me.MeViewer.ReportViewer.HyperLinkBackColor = System.Drawing.SystemColors.Window
        Me.MeViewer.ReportViewer.MultiplePageCols = 3
        Me.MeViewer.ReportViewer.MultiplePageMode = True
        Me.MeViewer.ReportViewer.MultiplePageRows = 2
        Me.MeViewer.ReportViewer.RepositionPage = True
        Me.MeViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.MeViewer.Size = New System.Drawing.Size(1133, 542)
        Me.MeViewer.TabIndex = 25
        Me.MeViewer.TableOfContents.Text = "Table Of Contents"
        Me.MeViewer.TableOfContents.Width = 200
        Me.MeViewer.TabTitleLength = 35
        Me.MeViewer.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stillSpinner)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.rollingSpinner)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 628)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 47)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'stillSpinner
        '
        Me.stillSpinner.Location = New System.Drawing.Point(0, 0)
        Me.stillSpinner.Name = "stillSpinner"
        Me.stillSpinner.Size = New System.Drawing.Size(100, 50)
        Me.stillSpinner.TabIndex = 0
        Me.stillSpinner.TabStop = False
        '
        'lblStatus
        '
        '
        '
        '
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.Location = New System.Drawing.Point(44, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(330, 23)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Search ..."
        '
        'rollingSpinner
        '
        Me.rollingSpinner.Location = New System.Drawing.Point(0, 0)
        Me.rollingSpinner.Name = "rollingSpinner"
        Me.rollingSpinner.Size = New System.Drawing.Size(100, 50)
        Me.rollingSpinner.TabIndex = 119
        Me.rollingSpinner.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.btnClearFilter)
        Me.GroupBox1.Controls.Add(Me.btnSearchCondition)
        Me.GroupBox1.Controls.Add(Me.txtBatchID)
        Me.GroupBox1.Controls.Add(Me.cmbBatch)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtCourseID)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtElectiveID)
        Me.GroupBox1.Controls.Add(Me.txtElectives)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 86)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(494, 50)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(175, 17)
        Me.RadioButton3.TabIndex = 186
        Me.RadioButton3.Text = "Subject Schedule Per Instructor"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(494, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(159, 17)
        Me.RadioButton2.TabIndex = 185
        Me.RadioButton2.Text = "Subject Schedule Per Room"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(494, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(215, 17)
        Me.RadioButton1.TabIndex = 184
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Subject-Instructor and Schedule Listings"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtElectiveID
        '
        Me.txtElectiveID.Location = New System.Drawing.Point(345, 19)
        Me.txtElectiveID.Name = "txtElectiveID"
        Me.txtElectiveID.Size = New System.Drawing.Size(30, 20)
        Me.txtElectiveID.TabIndex = 183
        Me.txtElectiveID.Visible = False
        '
        'txtElectives
        '
        Me.txtElectives.AccessibleName = ""
        Me.txtElectives.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.txtElectives.Border.Class = "TextBoxBorder"
        Me.txtElectives.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtElectives.FocusHighlightColor = System.Drawing.Color.LightBlue
        Me.txtElectives.FocusHighlightEnabled = True
        Me.txtElectives.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtElectives.Location = New System.Drawing.Point(300, 18)
        Me.txtElectives.Name = "txtElectives"
        Me.txtElectives.ReadOnly = True
        Me.txtElectives.Size = New System.Drawing.Size(39, 20)
        Me.txtElectives.TabIndex = 182
        Me.txtElectives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtElectives.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(201, 23)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(78, 15)
        Me.LabelX3.TabIndex = 115
        Me.LabelX3.Text = "GROUP NAME"
        Me.LabelX3.Visible = False
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Location = New System.Drawing.Point(734, 45)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 31)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'btnSearchCondition
        '
        Me.btnSearchCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchCondition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchCondition.Enabled = False
        Me.btnSearchCondition.Location = New System.Drawing.Point(734, 8)
        Me.btnSearchCondition.Name = "btnSearchCondition"
        Me.btnSearchCondition.Size = New System.Drawing.Size(114, 31)
        Me.btnSearchCondition.TabIndex = 111
        Me.btnSearchCondition.Text = "Search"
        Me.btnSearchCondition.Tooltip = "Search"
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(444, 49)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 110
        Me.txtBatchID.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DisplayMember = "Text"
        Me.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.ItemHeight = 14
        Me.cmbBatch.Location = New System.Drawing.Point(108, 49)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 109
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(9, 54)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 15)
        Me.LabelX2.TabIndex = 108
        Me.LabelX2.Text = "BATCH"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(444, 21)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 107
        Me.txtCourseID.Visible = False
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(108, 21)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 106
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(9, 26)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "COURSE/LEVEL"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAssessmentToolStripMenuItem, Me.StatementOfAccountToolStripMenuItem})
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(207, 48)
        '
        'ViewAssessmentToolStripMenuItem
        '
        Me.ViewAssessmentToolStripMenuItem.Name = "ViewAssessmentToolStripMenuItem"
        Me.ViewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ViewAssessmentToolStripMenuItem.Text = "View Schedule/Instructor"
        '
        'StatementOfAccountToolStripMenuItem
        '
        Me.StatementOfAccountToolStripMenuItem.Name = "StatementOfAccountToolStripMenuItem"
        Me.StatementOfAccountToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.StatementOfAccountToolStripMenuItem.Text = "View Enrolled Students"
        '
        'fmaSubjectTeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 681)
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaSubjectTeacherListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject List(Instructor, Room, and Schedule)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CMenuStripOperations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBatchID As System.Windows.Forms.TextBox
    Friend WithEvents cmbBatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearchCondition As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ViewAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtElectives As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtElectiveID As System.Windows.Forms.TextBox
    Friend WithEvents MeViewer As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
