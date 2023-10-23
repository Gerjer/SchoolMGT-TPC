<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentCareerList
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentCareerList))
        Me.gvCourseBatch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcStudentCareerList = New DevExpress.XtraGrid.GridControl()
        Me.gvStudentCareerList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colperson_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collast_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirst_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddle_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate_of_birth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontact_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcourse_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstd_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLRN_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate_admitted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colscholarship = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcareer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPageSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDisplayPageNo = New DevExpress.XtraEditors.LabelControl()
        Me.BtnLastPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNextPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPreviousPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFirstPage = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.cmbBatch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.WinLabel = New DevComponents.DotNetBar.LabelX()
        Me.StudentProfileListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.gvCourseBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStudentCareerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStudentCareerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.StudentProfileListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvCourseBatch
        '
        Me.gvCourseBatch.GridControl = Me.gcStudentCareerList
        Me.gvCourseBatch.Name = "gvCourseBatch"
        '
        'gcStudentCareerList
        '
        Me.gcStudentCareerList.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvCourseBatch
        GridLevelNode1.RelationName = "Level1"
        Me.gcStudentCareerList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcStudentCareerList.Location = New System.Drawing.Point(0, 0)
        Me.gcStudentCareerList.MainView = Me.gvStudentCareerList
        Me.gcStudentCareerList.Name = "gcStudentCareerList"
        Me.gcStudentCareerList.Size = New System.Drawing.Size(1125, 290)
        Me.gcStudentCareerList.TabIndex = 1
        Me.gcStudentCareerList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStudentCareerList, Me.gvCourseBatch})
        '
        'gvStudentCareerList
        '
        Me.gvStudentCareerList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvStudentCareerList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvStudentCareerList.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvStudentCareerList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Lime
        Me.gvStudentCareerList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.Green
        Me.gvStudentCareerList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumAquamarine
        Me.gvStudentCareerList.Appearance.HeaderPanel.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gvStudentCareerList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvStudentCareerList.Appearance.HeaderPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gvStudentCareerList.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvStudentCareerList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvStudentCareerList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvStudentCareerList.Appearance.SelectedRow.BackColor = System.Drawing.Color.MidnightBlue
        Me.gvStudentCareerList.Appearance.SelectedRow.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gvStudentCareerList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvStudentCareerList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvStudentCareerList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.gvStudentCareerList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colperson_id, Me.colid, Me.collast_name, Me.colfirst_name, Me.colmiddle_name, Me.colgender, Me.coldate_of_birth, Me.colcontact_number, Me.colcourse_name, Me.colstd_number, Me.colLRN_number, Me.coldate_admitted, Me.colscholarship, Me.colcareer_status})
        Me.gvStudentCareerList.GridControl = Me.gcStudentCareerList
        Me.gvStudentCareerList.Name = "gvStudentCareerList"
        Me.gvStudentCareerList.OptionsBehavior.Editable = False
        Me.gvStudentCareerList.OptionsView.ShowIndicator = False
        Me.gvStudentCareerList.PaintStyleName = "Style3D"
        '
        'colperson_id
        '
        Me.colperson_id.FieldName = "person_id"
        Me.colperson_id.Name = "colperson_id"
        Me.colperson_id.Visible = True
        Me.colperson_id.VisibleIndex = 0
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 1
        '
        'collast_name
        '
        Me.collast_name.FieldName = "last_name"
        Me.collast_name.Name = "collast_name"
        Me.collast_name.Visible = True
        Me.collast_name.VisibleIndex = 2
        '
        'colfirst_name
        '
        Me.colfirst_name.FieldName = "first_name"
        Me.colfirst_name.Name = "colfirst_name"
        Me.colfirst_name.Visible = True
        Me.colfirst_name.VisibleIndex = 3
        '
        'colmiddle_name
        '
        Me.colmiddle_name.FieldName = "middle_name"
        Me.colmiddle_name.Name = "colmiddle_name"
        Me.colmiddle_name.Visible = True
        Me.colmiddle_name.VisibleIndex = 4
        '
        'colgender
        '
        Me.colgender.FieldName = "gender"
        Me.colgender.Name = "colgender"
        Me.colgender.Visible = True
        Me.colgender.VisibleIndex = 5
        '
        'coldate_of_birth
        '
        Me.coldate_of_birth.FieldName = "date_of_birth"
        Me.coldate_of_birth.Name = "coldate_of_birth"
        Me.coldate_of_birth.Visible = True
        Me.coldate_of_birth.VisibleIndex = 6
        '
        'colcontact_number
        '
        Me.colcontact_number.FieldName = "contact_number"
        Me.colcontact_number.Name = "colcontact_number"
        Me.colcontact_number.Visible = True
        Me.colcontact_number.VisibleIndex = 7
        '
        'colcourse_name
        '
        Me.colcourse_name.FieldName = "course_name"
        Me.colcourse_name.Name = "colcourse_name"
        Me.colcourse_name.Visible = True
        Me.colcourse_name.VisibleIndex = 8
        '
        'colstd_number
        '
        Me.colstd_number.FieldName = "std_number"
        Me.colstd_number.Name = "colstd_number"
        Me.colstd_number.Visible = True
        Me.colstd_number.VisibleIndex = 9
        '
        'colLRN_number
        '
        Me.colLRN_number.FieldName = "LRN_number"
        Me.colLRN_number.Name = "colLRN_number"
        Me.colLRN_number.Visible = True
        Me.colLRN_number.VisibleIndex = 10
        '
        'coldate_admitted
        '
        Me.coldate_admitted.FieldName = "date_admitted"
        Me.coldate_admitted.Name = "coldate_admitted"
        Me.coldate_admitted.Visible = True
        Me.coldate_admitted.VisibleIndex = 11
        '
        'colscholarship
        '
        Me.colscholarship.FieldName = "scholarship"
        Me.colscholarship.Name = "colscholarship"
        Me.colscholarship.Visible = True
        Me.colscholarship.VisibleIndex = 12
        '
        'colcareer_status
        '
        Me.colcareer_status.FieldName = "career_status"
        Me.colcareer_status.Name = "colcareer_status"
        Me.colcareer_status.Visible = True
        Me.colcareer_status.VisibleIndex = 13
        '
        'GroupPanel1
        '
        Me.GroupPanel1.AutoScroll = True
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1137, 450)
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
        Me.GroupPanel1.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1131, 318)
        Me.Panel2.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1131, 318)
        Me.XtraTabControl1.TabIndex = 27
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.TreeList1)
        Me.XtraTabPage2.Controls.Add(Me.GroupPanel3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1125, 290)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'TreeList1
        '

        'Colname
        '
        Me.Colname.Caption = "TreeListColumn1"
        Me.Colname.FieldName = "name"
        Me.Colname.Name = "Colname"
        Me.Colname.Visible = True
        Me.Colname.VisibleIndex = 0
        '
        'GroupPanel3
        '
        Me.GroupPanel3.AutoScroll = True
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.SimpleButton2)
        Me.GroupPanel3.Controls.Add(Me.SimpleButton3)
        Me.GroupPanel3.Controls.Add(Me.LabelControl1)
        Me.GroupPanel3.Controls.Add(Me.txtPageSize)
        Me.GroupPanel3.Controls.Add(Me.txtDisplayPageNo)
        Me.GroupPanel3.Controls.Add(Me.BtnLastPage)
        Me.GroupPanel3.Controls.Add(Me.BtnNextPage)
        Me.GroupPanel3.Controls.Add(Me.BtnPreviousPage)
        Me.GroupPanel3.Controls.Add(Me.BtnFirstPage)
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 242)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1125, 48)
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
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(42, 42)
        Me.SimpleButton3.TabIndex = 127
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
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcStudentCareerList)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1125, 290)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.txtBatchID)
        Me.Panel1.Controls.Add(Me.cmbBatch)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.txtCourseID)
        Me.Panel1.Controls.Add(Me.cmbCourse)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.GroupPanel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1131, 126)
        Me.Panel1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(504, 19)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 45)
        Me.SimpleButton1.TabIndex = 142
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(447, 44)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(30, 20)
        Me.txtBatchID.TabIndex = 141
        Me.txtBatchID.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DisplayMember = "Text"
        Me.cmbBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBatch.Enabled = False
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.ItemHeight = 14
        Me.cmbBatch.Location = New System.Drawing.Point(111, 44)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(330, 20)
        Me.cmbBatch.TabIndex = 140
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(12, 49)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(39, 15)
        Me.LabelX2.TabIndex = 139
        Me.LabelX2.Text = "BATCH"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(447, 18)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(30, 20)
        Me.txtCourseID.TabIndex = 138
        Me.txtCourseID.Visible = False
        '
        'cmbCourse
        '
        Me.cmbCourse.DisplayMember = "Text"
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 14
        Me.cmbCourse.Location = New System.Drawing.Point(111, 18)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(330, 20)
        Me.cmbCourse.TabIndex = 137
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(12, 23)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(84, 15)
        Me.LabelX1.TabIndex = 136
        Me.LabelX1.Text = "COURSE/LEVEL"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.AutoScroll = True
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.WinLabel)
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 91)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1131, 35)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColor = System.Drawing.SystemColors.Desktop
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel4.TabIndex = 135
        '
        'WinLabel
        '
        Me.WinLabel.BackColor = System.Drawing.Color.Transparent
        Me.WinLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLabel.Location = New System.Drawing.Point(0, 0)
        Me.WinLabel.Name = "WinLabel"
        Me.WinLabel.Size = New System.Drawing.Size(1129, 33)
        Me.WinLabel.TabIndex = 246
        Me.WinLabel.Text = "STUDENT CAREER LIST"
        Me.WinLabel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'StudentProfileListBindingSource
        '
        Me.StudentProfileListBindingSource.DataSource = GetType(SchoolMGT.StudentProfileList)
        '
        'frmStudentCareer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 450)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "frmStudentCareer"
        Me.ShowIcon = False
        Me.Text = "STUDENT CAREER"
        CType(Me.gvCourseBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStudentCareerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStudentCareerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.StudentProfileListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents WinLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBatchID As TextBox
    Friend WithEvents cmbBatch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents cmbCourse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPageSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDisplayPageNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnLastPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNextPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPreviousPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirstPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StudentProfileListBindingSource As BindingSource
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcStudentCareerList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCourseBatch As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gvStudentCareerList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colperson_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirst_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddle_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_of_birth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontact_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcourse_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstd_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLRN_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_admitted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colscholarship As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcareer_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colname As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
