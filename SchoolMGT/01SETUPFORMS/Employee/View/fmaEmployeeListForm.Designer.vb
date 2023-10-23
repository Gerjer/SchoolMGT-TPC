<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmaEmployeeListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmaEmployeeListForm))
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.tdbViewer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPersonList = New DevExpress.XtraGrid.GridControl()
        Me.gvPersonList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPageSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDisplayPageNo = New DevExpress.XtraEditors.LabelControl()
        Me.BtnLastPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNextPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPreviousPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFirstPage = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stillSpinner = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.rollingSpinner = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totalrecords = New System.Windows.Forms.TextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpboxFilterName = New System.Windows.Forms.GroupBox()
        Me.btnClearFilter = New DevComponents.DotNetBar.ButtonX()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.btnSearchCondition = New DevComponents.DotNetBar.ButtonX()
        Me.CMenuStripOperations = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcPersonList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPersonList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.grpboxFilterName.SuspendLayout()
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
        Me.GroupPanel2.Controls.Add(Me.XtraTabControl1)
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1139, 446)
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
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 135)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1133, 258)
        Me.XtraTabControl1.TabIndex = 26
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.tdbViewer)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1127, 230)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'tdbViewer
        '
        Me.tdbViewer.AllowHorizontalSplit = True
        Me.tdbViewer.AllowUpdate = False
        Me.tdbViewer.AllowVerticalSplit = True
        Me.tdbViewer.AlternatingRows = True
        Me.tdbViewer.BackColor = System.Drawing.Color.LightBlue
        Me.tdbViewer.Caption = "Employee Lists"
        Me.tdbViewer.CaptionHeight = 25
        Me.tdbViewer.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbViewer.ExtendRightColumn = True
        Me.tdbViewer.FilterBar = True
        Me.tdbViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tdbViewer.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbViewer.Images.Add(CType(resources.GetObject("tdbViewer.Images"), System.Drawing.Image))
        Me.tdbViewer.Location = New System.Drawing.Point(0, 0)
        Me.tdbViewer.MaintainRowCurrency = True
        Me.tdbViewer.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbViewer.Name = "tdbViewer"
        Me.tdbViewer.PictureAddnewRow = CType(resources.GetObject("tdbViewer.PictureAddnewRow"), System.Drawing.Image)
        Me.tdbViewer.PictureCurrentRow = CType(resources.GetObject("tdbViewer.PictureCurrentRow"), System.Drawing.Image)
        Me.tdbViewer.PictureFilterBar = CType(resources.GetObject("tdbViewer.PictureFilterBar"), System.Drawing.Image)
        Me.tdbViewer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbViewer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbViewer.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbViewer.PrintInfo.PageSettings = CType(resources.GetObject("tdbViewer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbViewer.RowDivider.Color = System.Drawing.Color.DarkBlue
        Me.tdbViewer.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.None
        Me.tdbViewer.RowHeight = 25
        Me.tdbViewer.RowSubDividerColor = System.Drawing.Color.Navy
        Me.tdbViewer.Size = New System.Drawing.Size(1127, 230)
        Me.tdbViewer.TabAcrossSplits = True
        Me.tdbViewer.TabIndex = 25
        Me.tdbViewer.Text = "C1TrueDBGrid1"
        Me.tdbViewer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black
        Me.tdbViewer.PropBag = resources.GetString("tdbViewer.PropBag")
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcPersonList)
        Me.XtraTabPage2.Controls.Add(Me.GroupPanel3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1127, 230)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'gcPersonList
        '
        Me.gcPersonList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPersonList.Location = New System.Drawing.Point(0, 0)
        Me.gcPersonList.MainView = Me.gvPersonList
        Me.gcPersonList.Name = "gcPersonList"
        Me.gcPersonList.Size = New System.Drawing.Size(1127, 182)
        Me.gcPersonList.TabIndex = 0
        Me.gcPersonList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPersonList})
        '
        'gvPersonList
        '
        Me.gvPersonList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvPersonList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvPersonList.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvPersonList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Lime
        Me.gvPersonList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.Green
        Me.gvPersonList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvPersonList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvPersonList.Appearance.HeaderPanel.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gvPersonList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPersonList.Appearance.HeaderPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gvPersonList.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvPersonList.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvPersonList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPersonList.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvPersonList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPersonList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvPersonList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvPersonList.Appearance.SelectedRow.BackColor = System.Drawing.Color.MidnightBlue
        Me.gvPersonList.Appearance.SelectedRow.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gvPersonList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvPersonList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvPersonList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.gvPersonList.GridControl = Me.gcPersonList
        Me.gvPersonList.Name = "gvPersonList"
        Me.gvPersonList.OptionsBehavior.Editable = False
        Me.gvPersonList.OptionsView.ShowIndicator = False
        Me.gvPersonList.PaintStyleName = "Style3D"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.SimpleButton2)
        Me.GroupPanel3.Controls.Add(Me.SimpleButton1)
        Me.GroupPanel3.Controls.Add(Me.LabelControl1)
        Me.GroupPanel3.Controls.Add(Me.txtPageSize)
        Me.GroupPanel3.Controls.Add(Me.txtDisplayPageNo)
        Me.GroupPanel3.Controls.Add(Me.BtnLastPage)
        Me.GroupPanel3.Controls.Add(Me.BtnNextPage)
        Me.GroupPanel3.Controls.Add(Me.BtnPreviousPage)
        Me.GroupPanel3.Controls.Add(Me.BtnFirstPage)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 182)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1127, 48)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 51
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(42, 0)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 42)
        Me.SimpleButton2.TabIndex = 128
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(42, 42)
        Me.SimpleButton1.TabIndex = 127
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(846, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 126
        Me.LabelControl1.Text = "Page Size:"
        '
        'txtPageSize
        '
        Me.txtPageSize.EditValue = "20"
        Me.txtPageSize.Location = New System.Drawing.Point(902, 11)
        Me.txtPageSize.Name = "txtPageSize"
        Me.txtPageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPageSize.Properties.Items.AddRange(New Object() {"20", "40", "60", "80", "100"})
        Me.txtPageSize.Size = New System.Drawing.Size(52, 20)
        Me.txtPageSize.TabIndex = 125
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(1014, 16)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(29, 13)
        Me.txtDisplayPageNo.TabIndex = 124
        Me.txtDisplayPageNo.Text = "Pages"
        '
        'BtnLastPage
        '
        Me.BtnLastPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLastPage.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnLastPage.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.BtnLastPage.Appearance.Options.UseBackColor = True
        Me.BtnLastPage.Appearance.Options.UseBorderColor = True
        Me.BtnLastPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnLastPage.ImageOptions.Image = CType(resources.GetObject("BtnLastPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnLastPage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnLastPage.Location = New System.Drawing.Point(1087, 9)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.Size = New System.Drawing.Size(25, 23)
        Me.BtnLastPage.TabIndex = 123
        '
        'BtnNextPage
        '
        Me.BtnNextPage.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnNextPage.Appearance.Options.UseBackColor = True
        Me.BtnNextPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnNextPage.ImageOptions.Image = CType(resources.GetObject("BtnNextPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnNextPage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnNextPage.Location = New System.Drawing.Point(1062, 9)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.Size = New System.Drawing.Size(25, 23)
        Me.BtnNextPage.TabIndex = 122
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnPreviousPage.Appearance.Options.UseBackColor = True
        Me.BtnPreviousPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnPreviousPage.ImageOptions.Image = CType(resources.GetObject("BtnPreviousPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnPreviousPage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnPreviousPage.Location = New System.Drawing.Point(984, 10)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.Size = New System.Drawing.Size(25, 23)
        Me.BtnPreviousPage.TabIndex = 121
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BtnFirstPage.Appearance.Options.UseBackColor = True
        Me.BtnFirstPage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.BtnFirstPage.ImageOptions.Image = CType(resources.GetObject("BtnFirstPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnFirstPage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnFirstPage.Location = New System.Drawing.Point(959, 11)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.Size = New System.Drawing.Size(25, 23)
        Me.BtnFirstPage.TabIndex = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stillSpinner)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.rollingSpinner)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 47)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
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
        Me.stillSpinner.Visible = False
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
        Me.lblStatus.Visible = False
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
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupPanel1)
        Me.GroupBox1.Controls.Add(Me.grpboxFilterName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 135)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(691, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalrecords)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(924, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 67)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Records"
        '
        'totalrecords
        '
        Me.totalrecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalrecords.ForeColor = System.Drawing.Color.Red
        Me.totalrecords.Location = New System.Drawing.Point(39, 23)
        Me.totalrecords.Multiline = True
        Me.totalrecords.Name = "totalrecords"
        Me.totalrecords.Size = New System.Drawing.Size(150, 32)
        Me.totalrecords.TabIndex = 122
        Me.totalrecords.Text = "0"
        Me.totalrecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnEdit)
        Me.GroupPanel1.Controls.Add(Me.btnClose)
        Me.GroupPanel1.Controls.Add(Me.btnDelete)
        Me.GroupPanel1.Controls.Add(Me.btnAdd)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 94)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1127, 38)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 118
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(172, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 32)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(1035, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SchoolMGT.My.Resources.Resources.cancel
        Me.btnDelete.Location = New System.Drawing.Point(86, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SchoolMGT.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpboxFilterName
        '
        Me.grpboxFilterName.Controls.Add(Me.btnClearFilter)
        Me.grpboxFilterName.Controls.Add(Me.txtEmpName)
        Me.grpboxFilterName.Controls.Add(Me.btnSearchCondition)
        Me.grpboxFilterName.Location = New System.Drawing.Point(25, 19)
        Me.grpboxFilterName.Name = "grpboxFilterName"
        Me.grpboxFilterName.Size = New System.Drawing.Size(599, 70)
        Me.grpboxFilterName.TabIndex = 117
        Me.grpboxFilterName.TabStop = False
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFilter.Image = Global.SchoolMGT.My.Resources.Resources.close
        Me.btnClearFilter.Location = New System.Drawing.Point(469, 26)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(114, 31)
        Me.btnClearFilter.TabIndex = 114
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.Tooltip = "Clear Filter"
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(13, 26)
        Me.txtEmpName.Multiline = True
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(330, 32)
        Me.txtEmpName.TabIndex = 116
        '
        'btnSearchCondition
        '
        Me.btnSearchCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearchCondition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearchCondition.Image = Global.SchoolMGT.My.Resources.Resources.zoom
        Me.btnSearchCondition.Location = New System.Drawing.Point(349, 26)
        Me.btnSearchCondition.Name = "btnSearchCondition"
        Me.btnSearchCondition.Size = New System.Drawing.Size(114, 31)
        Me.btnSearchCondition.TabIndex = 111
        Me.btnSearchCondition.Text = "Search"
        Me.btnSearchCondition.Tooltip = "Search"
        '
        'CMenuStripOperations
        '
        Me.CMenuStripOperations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CMenuStripOperations.Name = "CMenuStripOperations"
        Me.CMenuStripOperations.Size = New System.Drawing.Size(61, 4)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'fmaEmployeeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fmaEmployeeListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.tdbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcPersonList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPersonList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.stillSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollingSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.grpboxFilterName.ResumeLayout(False)
        Me.grpboxFilterName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchCondition As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClearFilter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tdbViewer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents rollingSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents stillSpinner As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents CMenuStripOperations As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents grpboxFilterName As GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcPersonList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPersonList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtnFirstPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPageSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDisplayPageNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnLastPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNextPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPreviousPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents totalrecords As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
