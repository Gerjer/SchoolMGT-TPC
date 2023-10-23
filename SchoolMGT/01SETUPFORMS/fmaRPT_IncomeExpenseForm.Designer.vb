<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaRPT_IncomeExpenseForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaRPT_IncomeExpenseForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.stillSpinner = New System.Windows.Forms.PictureBox
        Me.lblStatus = New DevComponents.DotNetBar.LabelX
        Me.rollingSpinner = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New DevComponents.DotNetBar.ButtonX
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTimer = New DevComponents.DotNetBar.LabelX
        Me.dtpTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dtpFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.pbxSearch = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupPanel2.Controls.Add(Me.tdbViewer)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(686, 483)
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
        'tdbViewer
        '
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "Income Vs. Expenses"
        Me.tdbViewer.CaptionHeight = 18
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.FilterBar = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 145)
        Me.tdbViewer.MaintainRowCurrency = True
        Me.tdbViewer.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbViewer.Name = "tdbViewer"
        Me.tdbViewer.PictureAddnewRow = CType(resources.GetObject("tdbViewer.PictureAddnewRow"), System.Drawing.Image)
        Me.tdbViewer.PictureCurrentRow = CType(resources.GetObject("tdbViewer.PictureCurrentRow"), System.Drawing.Image)
        Me.tdbViewer.PictureFilterBar = CType(resources.GetObject("tdbViewer.PictureFilterBar"), System.Drawing.Image)
        Me.tdbViewer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbViewer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbViewer.PreviewInfo.ZoomFactor = 75
        Me.tdbViewer.PrintInfo.PageSettings = CType(resources.GetObject("tdbViewer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbViewer.RowDivider.Color = System.Drawing.Color.DarkBlue
        Me.tdbViewer.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.tdbViewer.RowHeight = 15
        Me.tdbViewer.RowSubDividerColor = System.Drawing.Color.Navy
        Me.tdbViewer.Size = New System.Drawing.Size(680, 285)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 25
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.stillSpinner)
        Me.GroupBox2.Controls.Add(Me.rollingSpinner)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 47)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'stillSpinner
        '
        Me.stillSpinner.Image = Global.SchoolMGT.My.Resources.Resources.spinner_static
        Me.stillSpinner.Location = New System.Drawing.Point(7, 11)
        Me.stillSpinner.Name = "stillSpinner"
        Me.stillSpinner.Size = New System.Drawing.Size(31, 32)
        Me.stillSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stillSpinner.TabIndex = 119
        Me.stillSpinner.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(44, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(330, 23)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Search ..."
        '
        'rollingSpinner
        '
        Me.rollingSpinner.Image = Global.SchoolMGT.My.Resources.Resources.spinner
        Me.rollingSpinner.Location = New System.Drawing.Point(7, 11)
        Me.rollingSpinner.Name = "rollingSpinner"
        Me.rollingSpinner.Size = New System.Drawing.Size(31, 32)
        Me.rollingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rollingSpinner.TabIndex = 117
        Me.rollingSpinner.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTimer)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.pbxSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 145)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(168, 105)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 34)
        Me.btnClose.TabIndex = 161
        Me.btnClose.Text = "Close"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = Global.SchoolMGT.My.Resources.Resources.Print_24x24
        Me.btnPrint.Location = New System.Drawing.Point(44, 105)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(83, 34)
        Me.btnPrint.TabIndex = 160
        Me.btnPrint.Text = "Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(88, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Set Date Range From and To to start searching Income and Expenses."
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(414, 62)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(75, 23)
        Me.lblTimer.TabIndex = 158
        Me.lblTimer.Text = "0"
        Me.lblTimer.Visible = False
        '
        'dtpTo
        '
        '
        '
        '
        Me.dtpTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTo.ButtonDropDown.Visible = True
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(91, 63)
        '
        '
        '
        Me.dtpTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTo.MonthCalendar.DisplayMonth = New Date(2016, 4, 1, 0, 0, 0, 0)
        Me.dtpTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTo.MonthCalendar.TodayButtonVisible = True
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(160, 22)
        Me.dtpTo.TabIndex = 156
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(35, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(18, 15)
        Me.LabelX2.TabIndex = 155
        Me.LabelX2.Text = "TO"
        '
        'dtpFrom
        '
        '
        '
        '
        Me.dtpFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFrom.ButtonDropDown.Visible = True
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(91, 36)
        '
        '
        '
        Me.dtpFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFrom.MonthCalendar.DisplayMonth = New Date(2016, 4, 1, 0, 0, 0, 0)
        Me.dtpFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(160, 22)
        Me.dtpFrom.TabIndex = 154
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(35, 43)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(35, 15)
        Me.LabelX1.TabIndex = 105
        Me.LabelX1.Text = "FROM"
        '
        'pbxSearch
        '
        Me.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSearch.Image = Global.SchoolMGT.My.Resources.Resources.loading_2
        Me.pbxSearch.Location = New System.Drawing.Point(232, 47)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(81, 52)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 157
        Me.pbxSearch.TabStop = False
        Me.pbxSearch.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'fmaRPT_IncomeExpenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(686, 483)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmaRPT_IncomeExpenseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income-Expense Report"
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents pbxSearch As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
End Class
