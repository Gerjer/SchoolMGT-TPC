Imports System.IO
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting



Imports SchoolMGT

Public Class StudentLearnersListPresenter
    Private _view As frmStudentLearnersList
    Dim ListModel As New StudentLearnersListModel
    Public Sub New(view As frmStudentLearnersList)
        _view = view

        loadComboBox()
        loadHandler()
        '   CreateColumns(_view.TreeList1)
        CreateColumns(_view.TreeList2)
        loadTreelistDesign(_view.TreeList2)
        _view.cmbStudentName.Focus()
        '      loadList()
    End Sub

    Private Sub loadTreelistDesign(treeList2 As TreeList)
        Dim childNode As TreeListNode = Nothing
        treeList2.LookAndFeel.UseDefaultLookAndFeel = False
        treeList2.LookAndFeel.SkinName = "iMaginary"
        '     treeList2.TreeLevelWidth = 150
        treeList2.OptionsBehavior.Editable = False
        treeList2.OptionsView.ShowColumns = False
        treeList2.OptionsView.ShowIndicator = False
        treeList2.OptionsView.ShowHorzLines = False
        treeList2.OptionsView.ShowVertLines = False
        treeList2.ViewStyle = TreeListViewStyle.TreeView
        treeList2.OptionsView.TreeLineStyle = LineStyle.Solid
        treeList2.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True
        '    treeList2.OptionsView.BestFitNodes = TreeListBestFitNodes.All

    End Sub

    Private Sub loadHandler()
        '    AddHandler _view.cmbStudentName.SelectionChangeCommitted, AddressOf GetStudentDetails
        AddHandler _view.btnSearch.Click, AddressOf Treelistload
        AddHandler _view.TreeList2.FocusedNodeChanged, AddressOf getNodeValueAdmissionNo
        AddHandler _view.TreeList2.MouseUp, AddressOf MenuStripVisible
        AddHandler _view.TreeList2.Click, AddressOf CheckNodeLevel
        '   AddHandler _view.PrintCORToolStripMenuItem.Click, AddressOf PrintCOR
        AddHandler _view.PrintCORToolStripMenuItem.Click, AddressOf PrintCORNew


    End Sub



    Private Sub PrintCORNew(sender As Object, e As EventArgs)


        If _courseID <> 1 Then

            'SHORT BOND PAPER

            Dim StudentID As Integer = ListModel.getStudentID(AdmissionNo)

            Dim COR_Copies As New DataTable
            COR_Copies = ListModel.getCOR_Copies()
            Dim row As Integer = 0

            Dim page As Integer = 1
            Dim total_page As Double = COR_Copies.Rows.Count
            total_page = total_page / 2
            total_page = Round_Up(total_page)

            Dim Master_Report As New XtraReport_CORMain

            While page <= total_page

                Dim Main_report(page) As XtraReport_CORMain
                Main_report(page) = New XtraReport_CORMain

                Dim report As New XtraReport_CORNew
                report.XrLabel1.Text = COMPANY_NAME
                report.XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
                report.XrLabel5.Text = "Email Address: registrar@tpc.edu.ph"
                report.XrLabel11.Text = ListModel.getCurriculunmStatus(StudentID)

                'If Not File.Exists(COMPANY_LOGO_PATH) Then
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
                'Else
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
                'End If

                Dim dt As New DataTable
                dt = ListModel.getStudents_COR_info(AdmissionNo)

                If dt.Rows.Count > 0 Then

                    For x As Integer = 0 To dt.Rows.Count - 1

                        Dim obj As New Student_COR
                        With obj
                            .Id_number = If(IsDBNull(dt(x)("IdNumber")), "", dt(x)("IdNumber"))
                            .Name = If(IsDBNull(dt(x)("NameCourse")), "", dt(x)("NameCourse")) 'dt(x)("NameCourse")
                            .Sim_year_date = If(IsDBNull(dt(x)("sem_year_date")), "", dt(x)("sem_year_date")) 'dt(x)("sem_year_date")
                            .Total_units = If(IsDBNull(dt(x)("TotalUnits")), 0, dt(x)("TotalUnits")) 'dt(x)("TotalUnits")
                            .Tution_fees = If(IsDBNull(dt(x)("TutionFees")), 0, dt(x)("TutionFees")) 'dt(x)("TutionFees")
                        End With
                        COR_info = obj
                    Next
                End If

                report.XrLabel25.Text = ListModel.getTotalAmount(StudentID)

                dt = Nothing

                Try
                    dt = ListModel.getStudent_Subject_info(AdmissionNo)
                    If dt.Rows.Count > 0 Then

                        For x As Integer = 0 To dt.Rows.Count - 1

                            Dim obj As New COR_Subject_Details
                            With obj
                                .Subject_code = dt(x)("subject_code")
                                .Descriptive_title = dt(x)("descriptive_title")
                                .Units = dt(x)("units")
                                .Time = dt(x)("time")
                                .Day = dt(x)("day")
                                .Room = dt(x)("room")
                                .Instructor = dt(x)("instructor")
                            End With
                            Subject_info.Add(obj)
                        Next
                    End If
                    Dim Subreport As XRSubreport = TryCast(report.Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                    Subreport.ReportSource.DataSource = Subject_info

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                dt = Nothing

                Try
                    dt = ListModel.getStudent_Assessment_info(StudentID)
                    If dt.Rows.Count > 0 Then

                        For x As Integer = 0 To dt.Rows.Count - 1

                            Dim obj As New COR_Assessment_Details
                            With obj
                                .Charges = dt(x)("Charges")
                                .Amount = dt(x)("Amount")
                            End With
                            Assessment_info.Add(obj)
                        Next
                    End If

                    Dim Subreport1 As XRSubreport = TryCast(report.Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Subreport1.ReportSource.DataSource = Assessment_info

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                report.BindingSource1.DataSource = COR_info
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1

                Dim Main_Subreport1 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                Main_Subreport1.ReportSource = report

                Main_report(page).XrCopy1.Text = COR_Copies(row)("name")
                Main_report(page).XrCopy1.BackColor = Color.FromName(COR_Copies(row)("description"))

                If COR_Copies.Rows.Count - 1 <> row Then

                    Dim Main_Subreport2 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Main_Subreport2.ReportSource = report

                    Main_report(page).XrCopy2.Text = COR_Copies(row + 1)("name")
                    Main_report(page).XrCopy2.BackColor = Color.FromName(COR_Copies(row + 1)("description"))

                Else

                    Dim Main_Subreport2 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Main_Subreport2.ReportSource = Nothing
                    Main_Subreport2.Visible = False
                    Main_report(page).XrCopy2.Visible = False

                End If

                Main_report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                Main_report(page).CreateDocument()

                row += 2

                Master_Report.Pages.AddRange(Main_report(page).Pages)
                Master_Report.PrintingSystem.ContinuousPageNumbering = True

                page += 1

                Subject_info.Clear()
                Assessment_info.Clear()
            End While

            Master_Report.ShowPreview


        Else
            'LONG BOND PAPER

            Dim StudentID As Integer = ListModel.getStudentID(AdmissionNo)

            Dim COR_Copies As New DataTable
            COR_Copies = ListModel.getCOR_Copies()
            Dim row As Integer = 0

            Dim page As Integer = 1
            Dim total_page As Double = COR_Copies.Rows.Count
            total_page = total_page / 2
            total_page = Round_Up(total_page)

            Dim Master_Report As New XtraReport_CORMain_lng

            While page <= total_page

                Dim Main_report(page) As XtraReport_CORMain_lng
                Main_report(page) = New XtraReport_CORMain_lng

                Dim report As New XtraReport_CORNew
                report.XrLabel1.Text = COMPANY_NAME
                report.XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
                report.XrLabel5.Text = "Email Address: registrar@tpc.edu.ph"
                report.XrLabel11.Text = ListModel.getCurriculunmStatus(StudentID)

                'If Not File.Exists(COMPANY_LOGO_PATH) Then
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
                'Else
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
                'End If

                Dim dt As New DataTable
                dt = ListModel.getStudents_COR_info(AdmissionNo)

                If dt.Rows.Count > 0 Then

                    For x As Integer = 0 To dt.Rows.Count - 1

                        Dim obj As New Student_COR
                        With obj
                            .Id_number = If(IsDBNull(dt(x)("IdNumber")), "", dt(x)("IdNumber"))
                            .Name = If(IsDBNull(dt(x)("NameCourse")), "", dt(x)("NameCourse")) 'dt(x)("NameCourse")
                            .Sim_year_date = If(IsDBNull(dt(x)("sem_year_date")), "", dt(x)("sem_year_date")) 'dt(x)("sem_year_date")
                            .Total_units = If(IsDBNull(dt(x)("TotalUnits")), 0, dt(x)("TotalUnits")) 'dt(x)("TotalUnits")
                            .Tution_fees = If(IsDBNull(dt(x)("TutionFees")), 0, dt(x)("TutionFees")) 'dt(x)("TutionFees")
                        End With
                        COR_info = obj
                    Next
                End If

                report.XrLabel25.Text = ListModel.getTotalAmount(StudentID)

                dt = Nothing

                Try
                    dt = ListModel.getStudent_Subject_info(AdmissionNo)
                    If dt.Rows.Count > 0 Then

                        For x As Integer = 0 To dt.Rows.Count - 1

                            Dim obj As New COR_Subject_Details
                            With obj
                                .Subject_code = dt(x)("subject_code")
                                .Descriptive_title = dt(x)("descriptive_title")
                                .Units = dt(x)("units")
                                .Time = dt(x)("time")
                                .Day = dt(x)("day")
                                .Room = dt(x)("room")
                                .Instructor = dt(x)("instructor")
                            End With
                            Subject_info.Add(obj)
                        Next
                    End If
                    Dim Subreport As XRSubreport = TryCast(report.Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                    Subreport.ReportSource.DataSource = Subject_info

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                dt = Nothing

                Try
                    dt = ListModel.getStudent_Assessment_info(StudentID)
                    If dt.Rows.Count > 0 Then

                        For x As Integer = 0 To dt.Rows.Count - 1

                            Dim obj As New COR_Assessment_Details
                            With obj
                                .Charges = dt(x)("Charges")
                                .Amount = dt(x)("Amount")
                            End With
                            Assessment_info.Add(obj)
                        Next
                    End If

                    Dim Subreport1 As XRSubreport = TryCast(report.Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Subreport1.ReportSource.DataSource = Assessment_info

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                report.BindingSource1.DataSource = COR_info
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1

                Dim Main_Subreport1 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                Main_Subreport1.ReportSource = report

                Main_report(page).XrCopy1.Text = COR_Copies(row)("name")
                Main_report(page).XrCopy1.BackColor = Color.FromName(COR_Copies(row)("description"))

                If COR_Copies.Rows.Count - 1 <> row Then

                    Dim Main_Subreport2 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Main_Subreport2.ReportSource = report

                    Main_report(page).XrCopy2.Text = COR_Copies(row + 1)("name")
                    Main_report(page).XrCopy2.BackColor = Color.FromName(COR_Copies(row + 1)("description"))

                Else

                    Dim Main_Subreport2 As XRSubreport = TryCast(Main_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                    Main_Subreport2.ReportSource = Nothing
                    Main_Subreport2.Visible = False
                    Main_report(page).XrCopy2.Visible = False

                End If

                Main_report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                Main_report(page).CreateDocument()

                row += 2

                Master_Report.Pages.AddRange(Main_report(page).Pages)
                Master_Report.PrintingSystem.ContinuousPageNumbering = True

                page += 1

                Subject_info.Clear()
                Assessment_info.Clear()
            End While

            Master_Report.ShowPreview

        End If

    End Sub

    Function Round_Up(ByVal num As Double) As Integer
        Dim result As Integer
        result = Math.Round(num)
        If result >= num Then
            Round_Up = result
        Else
            Round_Up = result + 1
        End If
    End Function


    Dim COR_info As New Student_COR
    Dim Subject_info As New List(Of COR_Subject_Details)
    Dim Assessment_info As New List(Of COR_Assessment_Details)
    Dim Default_LogoPath As String = Directory.GetCurrentDirectory & "\TPC_logo.jpg"

    Public Sub PrintCOR(sender As Object, e As EventArgs)

        Dim StudentID As Integer = ListModel.getStudentID(AdmissionNo)


        Dim master_report As New XtraReport_COR
        '     Dim printTool As New printc(New XtraReport())

        Dim page As Integer = 1
        While page < 3

            Dim report(page) As XtraReport_COR
            report(page) = New XtraReport_COR

            report(page).XrLabel1.Text = COMPANY_NAME
            report(page).XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
            report(page).XrLabel5.Text = "Email Address: " & COMPANY_EMAIL_ADDRESS

            'If Not File.Exists(COMPANY_LOGO_PATH) Then
            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
            'Else
            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
            'End If

            report(page).XrLabel25.Text = ListModel.getTotalAmount(StudentID)


            If page = 2 Then
                report(page).XrLabeLRegistrarCopy.Visible = True
            Else
                report(page).XrLabeLRegistrarCopy.Visible = False
            End If

            Dim dt As New DataTable
            dt = ListModel.getStudents_COR_info(AdmissionNo)

            If dt.Rows.Count > 0 Then

                For x As Integer = 0 To dt.Rows.Count - 1

                    Dim obj As New Student_COR
                    With obj
                        .Id_number = If(IsDBNull(dt(x)("IdNumber")), "", dt(x)("IdNumber"))
                        .Name = If(IsDBNull(dt(x)("NameCourse")), "", dt(x)("NameCourse")) 'dt(x)("NameCourse")
                        .Sim_year_date = If(IsDBNull(dt(x)("sem_year_date")), "", dt(x)("sem_year_date")) 'dt(x)("sem_year_date")
                        .Total_units = If(IsDBNull(dt(x)("TotalUnits")), 0, dt(x)("TotalUnits")) 'dt(x)("TotalUnits")
                        .Tution_fees = If(IsDBNull(dt(x)("TutionFees")), 0, dt(x)("TutionFees")) 'dt(x)("TutionFees")
                    End With
                    COR_info = obj
                Next

            End If
            dt = Nothing

            Try
                dt = ListModel.getStudent_Subject_info(AdmissionNo)


                If dt.Rows.Count > 0 Then

                    For x As Integer = 0 To dt.Rows.Count - 1

                        Dim obj As New COR_Subject_Details
                        With obj
                            .Subject_code = dt(x)("subject_code")
                            .Descriptive_title = dt(x)("descriptive_title")
                            .Units = dt(x)("units")
                            .Time = dt(x)("time")
                            .Day = dt(x)("day")
                            .Room = dt(x)("room")
                            .Instructor = dt(x)("instructor")
                        End With
                        Subject_info.Add(obj)
                    Next
                End If

                Dim Subreport As XRSubreport = TryCast(report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                Subreport.ReportSource.DataSource = Subject_info


            Catch ex As Exception

            End Try

            dt = Nothing

            Try
                dt = ListModel.getStudent_Assessment_info(StudentID)

                If dt.Rows.Count > 0 Then

                    For x As Integer = 0 To dt.Rows.Count - 1

                        Dim obj As New COR_Assessment_Details
                        With obj
                            .Charges = dt(x)("Charges")
                            .Amount = dt(x)("Amount")
                        End With
                        Assessment_info.Add(obj)
                    Next
                End If

                Dim Subreport As XRSubreport = TryCast(report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                Subreport.ReportSource.DataSource = Assessment_info


            Catch ex As Exception

            End Try

            report(page).BindingSource1.DataSource = COR_info
            '        report(page).
            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
            report(page).CreateDocument()

            master_report.Pages.AddRange(report(page).Pages)
            master_report.PrintingSystem.ContinuousPageNumbering = True

            Subject_info.Clear()
            Assessment_info.Clear()

            page += 1
        End While

        '      master_report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        master_report.ShowPreview

        '    Cursor.Cursor = Cursors.Default



    End Sub

    Dim NodeLevel As Boolean = False
    Private Sub CheckNodeLevel(sender As Object, e As EventArgs)
        Dim TreList As TreeList = DirectCast(sender, TreeList)

        If TreList.FocusedNode IsNot Nothing Then
            If TreList.FocusedNode.Level = 2 Then
                NodeLevel = True
            Else
                NodeLevel = False
            End If
        End If

    End Sub

    Private Sub MenuStripVisible(sender As Object, e As MouseEventArgs)

        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            If NodeLevel Then
                point1 = Windows.Forms.Cursor.Position
                Dim pt As Point = _view.TreeList2.PointToClient(point1)
                _view.ContextMenuStrip1.Show(_view.TreeList2, pt)
                '             _view.
            Else
                _view.ContextMenuStrip1.Visible = False
            End If

        End If

    End Sub

    Dim AdmissionNo As String
    Private Sub getNodeValueAdmissionNo(sender As Object, e As FocusedNodeChangedEventArgs)

        If e.Node IsNot Nothing Then
            If e.Node.Level = 2 Then
                AdmissionNo = e.Node.Tag
            End If
        End If

    End Sub

    Public _EnterKey As Boolean = False

    Public Sub Treelistload(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        _view.TreeList2.ClearFocusedColumn()
        _view.TreeList2.ClearNodes()

        Dim dt As New DataTable
        dt = ListModel.getStudentDetails(_view.cmbStudentName.SelectedValue)

        CreateNodes(_view.TreeList2, dt)

        Cursor.Current = Cursors.Default
    End Sub


    Public Property BestFitNodes As TreeListBestFitNodes
    Private Sub CreateNodes(treeList1 As TreeList, dt As DataTable)

        'If _view.cmbStudentName.SelectedValue = 0 Then
        treeList1.Appearance.Row.Font = New Font("Tahoma", 8.25)
        treeList1.Appearance.EvenRow.Font = New Font("Tahoma", 8.25)
        treeList1.Appearance.OddRow.Font = New Font("Tahoma", 8.25)
        'Else
        '    treeList1.Appearance.Row.Font = New Font("Tahoma", 12)
        '    treeList1.Appearance.EvenRow.Font = New Font("Tahoma", 12)
        '    treeList1.Appearance.OddRow.Font = New Font("Tahoma", 12)
        'End If

        treeList1.BeginUnboundLoad()

        For Each rows As DataRow In dt.Rows

            ' Create a root node .
            Dim ColumnName As String = rows.Item("Name")
            Dim parentForRootNodes As TreeListNode = Nothing
            Dim CourseNode As TreeListNode = treeList1.AppendNode(New Object() {ColumnName}, parentForRootNodes)
            'COURSE
            Dim dt1 As DataTable = ListModel.getStudentCourse(rows("ClassRoll_Number"))

            _courseID = dt1(0)("course_id")

            For Each rows1 As DataRow In dt1.Rows

                Dim value1 As String = rows1.Item("CourseName")
                Dim BatchNode As TreeListNode = treeList1.AppendNode(New Object() {value1}, CourseNode)
                If CourseNode IsNot Nothing Then
                    CourseNode.CheckState = CheckState.Checked
                    '           CourseNode.Expanded = True
                End If
                'BATCH
                Dim dt2 As DataTable = ListModel.getBatchGroup(rows("ClassRoll_Number"))
                For Each rows2 As DataRow In dt2.Rows

                    Dim value2 As String = rows2.Item("BatchName")
                    Dim SubbjectNode As TreeListNode = treeList1.AppendNode(New Object() {value2}, BatchNode)
                    SubbjectNode.Tag = rows2("admission_no")
                    If BatchNode IsNot Nothing Then
                        BatchNode.CheckState = CheckState.Checked
                        '           BatchNode.Expanded = True
                    End If
                    'BATCH SUBJECT DETAILS
                    Dim dt3 As DataTable = ListModel.getStudentSubject(rows2("id"))
                    For Each rows3 As DataRow In dt3.Rows
                        treeList1.AppendNode(New Object() {rows3("SUBJECT CODE"), rows3("SUBJECT NAME"), rows3("UNITS"), rows3("CLASS CODE"), rows3("SCHEDULE"), rows3("ROOM")}, SubbjectNode)

                        If SubbjectNode IsNot Nothing Then
                            SubbjectNode.CheckState = CheckState.Checked
                            '               SubbjectNode.Expanded = True
                        End If


                    Next
                Next
            Next
        Next
        treeList1.EndUnboundLoad()
        treeList1.OptionsView.BestFitNodes = TreeListBestFitNodes.Default
        If _view.cmbStudentName.SelectedValue > 0 Then
            treeList1.ExpandAll()
        Else
            '       _view.lbltimer.Text = "1"
        End If


    End Sub

    Private Sub loadComboBox()
        _view.cmbStudentName.DataSource = ListModel.getStudentRecord()
        _view.cmbStudentName.ValueMember = "ID"
        _view.cmbStudentName.DisplayMember = "Name"
        _view.cmbStudentName.SelectedIndex = -1
    End Sub


    Public Overridable Property FixedWidth As Boolean = True

    Private Sub CreateColumns(treeList1 As TreeList)

        ' Create three columns.
        treeList1.BeginUpdate()

        Dim col0 As TreeListColumn = treeList1.Columns.Add()
        col0.Caption = "SUBJECT CODE"
        col0.VisibleIndex = 0

        Dim col1 As TreeListColumn = treeList1.Columns.Add()
        col1.Caption = "SUBJECT NAME"
        col1.VisibleIndex = 1

        Dim col2 As TreeListColumn = treeList1.Columns.Add()
        col2.Caption = "UNITS"
        col2.VisibleIndex = 2

        Dim col3 As TreeListColumn = treeList1.Columns.Add()
        col3.Caption = "CLASS CODE"
        col3.VisibleIndex = 3

        Dim col4 As TreeListColumn = treeList1.Columns.Add()
        col4.Caption = "SCHEDULE"
        col4.VisibleIndex = 4

        Dim col5 As TreeListColumn = treeList1.Columns.Add()
        col5.Caption = "ROOM"
        col5.VisibleIndex = 5

        treeList1.EndUpdate()

    End Sub
End Class
