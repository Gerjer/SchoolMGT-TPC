Imports SchoolMGT
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPdfViewer
Imports DevExpress.Utils
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevComponents.DotNetBar
'Imports System.Web.UI.WebControls
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid.GridView
Imports DevExpress.Data
Imports System.Text
Imports System.Net
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports DevExpress.XtraReports.Localization





Public Class GradeSheetListPresenter

    Dim _view As frmGradeSheet
    Dim ListModel As New GradeSheetListModel
    Dim dt_filtered As New DataTable
    Dim dt_default As New DataTable
    '   Dim lbl As New XRLabelll
    Public Sub New(frmGradeSheet As frmGradeSheet)
        _view = frmGradeSheet

        StudentCategory_DropDownList()
        '       Subject_DropDownList()
        loadComboBox()
        loadHandler()
        loadDTDefault()
        _view.BandedGridView1.OptionsView.ShowBands = False
        '    Refresh()
    End Sub

    Private Sub loadDTDefault()
        dt_default = ListModel.getGradeSheetRecord()
    End Sub

    Private Sub loadHandler()

        AddHandler _view.cmBatch.SelectedValueChanged, AddressOf BatchSelectedValueChanged

        '     AddHandler _view.cmbSubject.SelectedValueChanged, AddressOf SubjectSelectedValueChanged
        AddHandler _view.cmbSubject.SelectionChangeCommitted, AddressOf SubjectSelectionChangeCommitted
        AddHandler _view.cmbSemester.SelectedValueChanged, AddressOf SemesterSelectedValueChanged
        '      AddHandler _view.cmbSemester.SelectionChangeCommitted, AddressOf SemesterSelectionChangeCommitted
        AddHandler _view.cmbYear.SelectedValueChanged, AddressOf YearSelectedValueChanged
        AddHandler _view.cmbDayName.SelectionChangeCommitted, AddressOf DayNameSelectionChangeCommitted
        AddHandler _view.cmbTimeSched.SelectionChangeCommitted, AddressOf TimeSchedSelectionChangeCommitted
        AddHandler _view.cmbRoom.SelectionChangeCommitted, AddressOf RoomSelectionChangeCommitted
        AddHandler _view.btnSearch.Click, AddressOf LoadList

        AddHandler _view.gvGradeSheet.DataSourceChanged, AddressOf gvGradeSheetDataSourceChanged
        AddHandler _view.cmbyearbatch.SelectedIndexChanged, AddressOf cmbyearbatch_SelectedIndexChanged

    End Sub

    Private Sub cmbyearbatch_SelectedIndexChanged(sender As Object, e As EventArgs)

        Try
            Dim SQLEX As String = "SELECT batches.id, name FROM batches"
            SQLEX += " INNER JOIN courses"
            SQLEX += " ON (batches.course_id = courses.id)"
            SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
            SQLEX += " AND batches.school_year = '" & _view.cmbyearbatch.Text & "' "


            Dim MeData As DataTable
            MeData = clsDBConn.ExecQuery(SQLEX)

            _view.cmBatch.DataSource = MeData

            _view.cmBatch.ValueMember = "id"
            _view.cmBatch.DisplayMember = "name"
            _view.cmBatch.Text = ""
            _view.cmBatch.SelectedIndex = -1
        Catch ex As Exception

        End Try


    End Sub

    Private Sub gvGradeSheetDataSourceChanged(sender As Object, e As EventArgs)

        'Dim View As GridView = DirectCast(sender, GridView)
        'View.GroupFormat = "{1}"
        'View.Columns("GenderOrder").GroupIndex = 0

        'For i As Integer = 0 To View.Columns.Count - 1

        '    Select Case i
        '        Case 0
        '            View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '            View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        '            View.Columns(i).Width = 70
        '        Case 1, 5, 7, 8, 9
        '            View.Columns(i).Visible = False
        '        Case 2, 3, 4
        '            View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '            View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
        '            View.Columns(i).Width = 150
        '        Case 6
        '            View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '            View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
        '            View.Columns(i).Width = 200
        '        Case lastCol
        '            View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '            View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        '            View.Columns(i).Width = 150
        '        Case Else
        '            View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '            View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        '            View.Columns(i).Width = 100

        '    End Select

        'Next



        'View.BeginSort()
        'View.Columns("GenderOrder").SortOrder = ColumnSortOrder.Descending
        'View.ExpandAllGroups()
        'View.Columns("No.").SortOrder = ColumnSortOrder.Ascending

        'View.EndSort()



    End Sub

    Private Sub SemesterSelectionChangeCommitted(sender As Object, e As EventArgs)

        _view.cmbYear.Enabled = True
        _view.cmbYear.SelectedIndex = -1
        _view.cmbDayName.SelectedIndex = -1
        _view.cmbTimeSched.SelectedIndex = -1
        _view.cmbRoom.SelectedIndex = -1

        Dim dt As New DataTable
        dt.Columns.Add("academice_year")

        Dim query = dt_default.Select("id = '" & _view.cmbSubject.SelectedValue & "'  AND  semester = '" & _view.cmbSemester.Text & "' ", "academice_year ASC")

        '_view.gcGradeSheet.DataSource = query.CopyToDataTable
        'getDesignGridControl(_view.gvGradeSheet)

        For Each row In query.ToList
            dt.Rows.Add(row("academice_year").ToString)
        Next
        Dim dtNew As DataTable = dt.DefaultView.ToTable(True, "academice_year")

        AcademicYear_DropDownList(dtNew)

    End Sub

    Private Sub SubjectSelectionChangeCommitted(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        Try

            Dim drv As DataRowView = DirectCast(_view.cmbSubject.SelectedItem, DataRowView)
            subecjtID = _view.cmbSubject.SelectedValue
            _view.lblcreditsunit.Text = drv.Item("credit_hours").ToString
            _view.txtSubjectDescription.Text = drv.Item("Description").ToString
            _view.cmbDepartment.SelectedValue = drv.Item("employee_department_id").ToString

            _view.GroupPanel6.Visible = True
            _view.cmbSemester.Enabled = True
            _view.cmbYear.SelectedIndex = -1
            _view.cmbDayName.SelectedIndex = -1
            _view.cmbTimeSched.SelectedIndex = -1
            _view.cmbRoom.SelectedIndex = -1

            If subecjtID > 0 Then
                _view.cmbSemester.Enabled = True
                Semester_DropDownList(subecjtID)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cursor.Current = Cursors.Default

        _view.gvGradeSheet.Columns.Clear()
        '_view.lblcreditsunit.Text = " "
        '_view.lblfemalecount.Text = " "
        '_view.lblfemalecount.Text = " "
        '_view.lblTotal.Text = " "

    End Sub

    Private Sub BatchSelectedValueChanged(sender As Object, e As EventArgs)

        If _view.cmBatch.Text.Length > 0 Then
            Subject_DropDownList()
        End If

    End Sub

    Dim _year As String = ""
    Private Sub YearSelectedValueChanged(sender As Object, e As EventArgs)

        If _view.cmbSemester.Text.Length > 0 Then
            _view.cmbDayName.Enabled = True

            Dim dt As New DataTable
            dt.Columns.Add("ID")
            dt.Columns.Add("name")

            Dim query = dt_default.Select("id = '" & _view.cmbSubject.SelectedValue & "'  AND  semester = '" & _view.cmbSemester.Text & "' AND    academice_year = '" & _view.cmbYear.Text & "' ", "day ASC")

            '_view.gcGradeSheet.DataSource = query.CopyToDataTable
            'getDesignGridControl(_view.gvGradeSheet)

            For Each row In query.ToList
                dt.Rows.Add(row("day_schedule_id").ToString, row("day").ToString)
            Next

            Dim view As DataView = New DataView(dt)

            Dim dtNew As DataTable = view.ToTable(True, "ID", "name")

            DayName_DropDownList(dtNew)

        End If


        'If _view.chkFilteredActiveRecords.Checked = False Then
        '    _year = _view.cmbYear.Text
        '    dt_filtered = ListModel.Filter(subecjtID, semester, _year, daynameID, timeschedID, roomID)
        '    loadfiltered(dt_filtered)
        'Else
        '    _year = _view.cmbYear.Text
        'End If

    End Sub

    Dim semester As String = ""
    Private Sub SemesterSelectedValueChanged(sender As Object, e As EventArgs)

        If _view.cmbSubject.Text.Length > 0 Then
            _view.cmbYear.Enabled = True
            _view.cmbDayName.SelectedIndex = -1
            _view.cmbTimeSched.SelectedIndex = -1
            _view.cmbRoom.SelectedIndex = -1

            Dim dt As New DataTable
            dt.Columns.Add("academice_year")

            Dim query = dt_default.Select("semester = '" & _view.cmbSemester.Text & "' ", "academice_year ASC")

            '_view.gcGradeSheet.DataSource = query.CopyToDataTable
            'getDesignGridControl(_view.gvGradeSheet)

            For Each row In query.ToList
                dt.Rows.Add(row("academice_year").ToString)
            Next
            Dim dtNew As DataTable = dt.DefaultView.ToTable(True, "academice_year")

            AcademicYear_DropDownList(dtNew)
        End If

        'If _view.chkFilteredActiveRecords.Checked = False Then
        '    semester = _view.cmbSemester.Text
        '    dt_filtered = ListModel.Filter(subecjtID, semester, _year, daynameID, timeschedID, roomID)
        '    loadfiltered(dt_filtered)
        'Else
        '    semester = _view.cmbSemester.Text
        'End If

    End Sub

    Dim roomID As Integer
    Private Sub RoomSelectionChangeCommitted(sender As Object, e As EventArgs)

        If _view.cmbTimeSched.Text.Length > 0 Then
            _view.cmbRoom.Enabled = True

            Dim dt As New DataTable
            dt.Columns.Add("ID")
            dt.Columns.Add("name")

            Dim query = dt_default.Select("room_id = '" & _view.cmbRoom.SelectedValue & "' ")

            If _view.cmbSubject.SelectedItem IsNot Nothing And _view.cmbSemester.SelectedItem IsNot Nothing And _view.cmbYear.SelectedItem IsNot Nothing And _view.cmbDayName.SelectedItem IsNot Nothing And _view.cmbTimeSched.SelectedItem IsNot Nothing Then
                _view.btnSearch.Enabled = True
            End If

        End If

    End Sub

    Dim timeschedID As Integer
    Private Sub TimeSchedSelectionChangeCommitted(sender As Object, e As EventArgs)

        If _view.cmbDayName.Text.Length > 0 Then
            _view.cmbRoom.Enabled = True

            Dim dt As New DataTable
            dt.Columns.Add("ID")
            dt.Columns.Add("name")

            Dim query = dt_default.Select("id = '" & _view.cmbSubject.SelectedValue & "'  AND  semester = '" & _view.cmbSemester.Text & "' AND    academice_year = '" & _view.cmbYear.Text & "'   AND day_schedule_id = '" & _view.cmbDayName.SelectedValue & "'   AND  class_timing_id = '" & _view.cmbTimeSched.SelectedValue & "' ")

            '_view.gcGradeSheet.DataSource = query.CopyToDataTable
            'getDesignGridControl(_view.gvGradeSheet)

            For Each row In query.ToList.Distinct
                dt.Rows.Add(row("room_id").ToString, row("room").ToString)
            Next
            Dim View As DataView = New DataView(dt)
            View.Sort = "ID"
            Dim dtNew As DataTable = View.ToTable(True, "ID", "name")

            Rooms_DropDownList(dtNew)

        End If

        'If _view.chkFilteredActiveRecords.Checked = False Then
        '    timeschedID = _view.cmbTimeSched.SelectedValue
        '    dt_filtered = ListModel.Filter(subecjtID, semester, _year, daynameID, timeschedID, roomID)
        '    loadfiltered(dt_filtered)
        'Else
        '    timeschedID = _view.cmbTimeSched.SelectedValue
        'End If
    End Sub

    Dim daynameID As Integer
    Private Sub DayNameSelectionChangeCommitted(sender As Object, e As EventArgs)

        If _view.cmbYear.Text.Length > 0 Then
            _view.cmbTimeSched.Enabled = True
            '       _view.cmbTimeSched.SelectedIndex = -1
            _view.cmbRoom.SelectedIndex = -1


            Dim dt As New DataTable
            dt.Columns.Add("ID")
            dt.Columns.Add("name")

            Dim query = dt_default.Select("id = '" & _view.cmbSubject.SelectedValue & "'  AND  semester = '" & _view.cmbSemester.Text & "' AND    academice_year = '" & _view.cmbYear.Text & "'   AND day_schedule_id = '" & _view.cmbDayName.SelectedValue & "' ")

            '_view.gcGradeSheet.DataSource = query.CopyToDataTable
            'getDesignGridControl(_view.gvGradeSheet)

            For Each row In query.ToList.Distinct
                dt.Rows.Add(row("class_timing_id"), row("class_time"))
            Next

            Dim View As DataView = New DataView(dt)
            View.Sort = "ID"
            Dim dtNew As DataTable = View.ToTable(True, "ID", "name")

            TimeSchedule_DropDownList(dtNew)

        End If

    End Sub

    'Private Sub SubjectSelectionChangeCommitted(sender As Object, e As EventArgs)
    '    subecjtID = _view.cmbSubject.SelectedValue
    'End Sub

    Dim subecjtID As Integer = 0
    Dim SubjectClassSchedule As New DataTable

    Private Sub SubjectSelectedValueChanged(sender As Object, e As EventArgs)

        Dim cmbBox As DevComponents.DotNetBar.Controls.ComboBoxEx = DirectCast(sender, DevComponents.DotNetBar.Controls.ComboBoxEx)
        If cmbBox.SelectedValue > 0 Then

            Try
                Dim drv As DataRowView = DirectCast(_view.cmbSubject.SelectedItem, DataRowView)
                subecjtID = _view.cmbSubject.SelectedValue
                _view.lblcreditsunit.Text = drv.Item("credit_hours").ToString
                _view.txtSubjectDescription.Text = drv.Item("Description").ToString
                _view.cmbDepartment.SelectedValue = drv.Item("employee_department_id").ToString
                _view.cmbSemester.Enabled = True
                _view.GroupPanel6.Visible = True

                If subecjtID > 0 Then
                    _view.cmbSemester.Enabled = True
                    Semester_DropDownList(subecjtID)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        'Try
        '    Dim drv As DataRowView = DirectCast(_view.cmbSubject.SelectedItem, DataRowView)
        '    subecjtID = _view.cmbSubject.SelectedValue
        '    _view.lblcreditsunit.Text = drv.Item("credit_hours").ToString
        '    '       _view.cmbSemester.SelectedIndex = -1
        '    '          _view.cmbYear.SelectedIndex = -1
        '    _view.GroupPanel6.Visible = True

        '    If _view.chkFilteredActiveRecords.CheckState = 1 Then
        '        If subecjtID > 0 Then
        '            SubjectClassSchedule = ListModel.getMultipleID_SubjectClassSchedule(subecjtID)
        '        End If
        '        loadComboBox()

        '    Else

        '        dt_filtered = ListModel.Filter(subecjtID, semester, _year, daynameID, timeschedID, roomID)
        '        loadfiltered(dt_filtered)
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub loadfiltered(dt_filtered As DataTable)

        Dim dt As New DataTable

        dt = dt_filtered
        If dt.Rows.Count > 0 Then

            'Add Column
            Dim dt_column As New DataTable
            dt_column = ListModel.getColumn(13)
            If dt_column.Rows.Count > 0 Then
                For Each colRoww As DataRow In dt_column.Rows
                    dt.Columns.Add(colRoww.Item("name"))
                Next
            End If

            Dim ColumnName As String = ""
            Dim ColGrading As Integer = 0
            Dim dt_grades As New DataTable
            If dt.Rows.Count > 0 Then

                Dim x As Integer = 0

                For Each rows As DataRow In dt.Rows
                    For col As Integer = 0 To dt.Columns.Count - 1

                        ColumnName = dt.Columns(col).ToString
                        If ColumnName = "student_subject_id" Then
                            dt_grades = ListModel.Grades(rows("student_subject_id"))
                            If dt_grades.Rows.Count > 1 Then
                                ColGrading = col
                            End If
                        ElseIf ColGrading <> 0 Then
                            rows(ColumnName) = dt_grades(x)("grades")
                            x += 1
                            If dt_grades.Rows.Count - 1 >= x Then
                                ColumnName = dt_grades(x)("name")
                            End If
                        End If
                        'If ColumnName = "" Then

                        '    dt_grades = ListModel.Grades(rows("student_subject_id"))
                        '    ColumnName = dt_grades(0)("name")

                        'ElseIf ColumnName = dt.Columns(col).ToString Then

                        '    rows(ColumnName) = dt_grades(x)("grades")
                        '    x += 1
                        '    If dt_grades.Rows.Count - 1 >= x Then
                        '        ColumnName = dt_grades(x)("name")
                        '    End If
                        'End If
                        '                ColGrading = 0
                    Next

                    ''count
                    'If rows.Item("gender") = "MALE" Then
                    '    _view.lblmalecount.Text += 1
                    'Else
                    '    _view.lblfemalecount.Text += 1
                    'End If


                    x = 0
                    ColumnName = ""
                    ColGrading = 0
                Next

                '          _view.lblTotal.Text = CInt(_view.lblmalecount.Text) + CInt(_view.lblfemalecount.Text)


                _view.gcGradeSheet.DataSource = dt

                getDesign1GridControl(_view.gvGradeSheet)

            End If
        End If

        _view.gcGradeSheet.DataSource = dt

    End Sub

    Private Sub getDesign1GridControl(view As Views.Grid.GridView)

        view.Columns.View.OptionsBehavior.Editable = False

        For i As Integer = 0 To view.Columns.Count - 1

            Select Case i
                Case 7, 11, 13, 14
                    view.Columns(i).Visible = False

                Case Else
                    If i > 14 Then
                        view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                        view.Columns(i).BestFit()
                    Else
                        view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                        view.Columns(i).BestFit()
                    End If

            End Select

        Next

        view.OptionsView.ColumnAutoWidth = True
        '      view.EndUpdate()

    End Sub

    Private Sub LoadList(sender As Object, e As EventArgs)
        Refresh()
    End Sub

    Private Sub loadComboBox()
        StudentCategory_DropDownList()
        Batch_DropDownList()
        Department_DropDownList()
        '     DayName_DropDownList()
        '     TimeSchedule_DropDownList()
        '    Rooms_DropDownList()
        Year_DropDownList()
        'Semester_DropDownList()
        '    AcademicYear_DropDownList()

        YearBatch()


    End Sub

    Private Sub YearBatch()
        _view.cmbyearbatch.DataSource = DataSource(String.Format("SELECT DISTINCT
                                    1 as 'id',
                                    batches.school_year 'name'
                                    FROM
                                    batches
                                    WHERE school_year is NOT NULL
                                    ORDER BY school_year DESC
                                    "))
        _view.cmbyearbatch.ValueMember = "id"
        _view.cmbyearbatch.DisplayMember = "name"
        _view.cmbyearbatch.SelectedIndex = -1



    End Sub

    Private Sub Batch_DropDownList()

        _view.cmBatch.DataSource = ListModel.getBatchList()
        _view.cmBatch.ValueMember = "ID"
        _view.cmBatch.DisplayMember = "name"
        _view.cmBatch.SelectedIndex = -1

    End Sub

    Private Sub AcademicYear_DropDownList(dt As DataTable)

        If dt.Rows.Count > 0 Then

            Dim academic_year As String = ""
            _view.cmbYear.Items.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim item As ComboBoxItem = New ComboBoxItem()
                item.Text = dt(i)("academice_year")
                If academic_year = "" Or academic_year <> item.Text Then
                    academic_year = item.Text
                    _view.cmbYear.Items.Add(item)
                End If
            Next
            '         _view.cmbYear.SelectedIndex = 0

        End If

    End Sub

    Private Sub Semester_DropDownList(subjectID As Integer)
        Dim dt As New DataTable
        dt.Columns.Add("semester")

        Dim query = dt_default.Select("id = '" & subjectID & "'", "gender DESC ")
        '_view.gcGradeSheet.DataSource = query.CopyToDataTable
        ''getDesignGridControl(_view.gvGradeSheet)

        For Each row In query.ToList.Distinct
            dt.Rows.Add(row("semester").ToString)
        Next
        Dim dtNew As DataTable = dt.Copy

        If dtNew.Rows.Count > 0 Then

            Dim strSemester As String = ""
            _view.cmbSemester.Items.Clear()

            For i As Integer = 0 To dtNew.Rows.Count - 1
                Dim item As ComboBoxItem = New ComboBoxItem()
                item.Text = dtNew(i)("semester")
                If strSemester = "" Or strSemester <> item.Text Then
                    strSemester = item.Text
                    _view.cmbSemester.Items.Add(item)
                End If

            Next
            '          _view.cmbSemester.SelectedIndex = 0
        End If


    End Sub

    Private Sub Year_DropDownList()
        If SubjectClassSchedule.Rows.Count > 0 Then
            Dim strSemester As String = ""
            _view.cmbYear.Items.Clear()

            For i As Integer = 0 To SubjectClassSchedule.Rows.Count - 1
                Dim item As ComboBoxItem = New ComboBoxItem()
                item.Text = SubjectClassSchedule(i)("semester")
                If strSemester = "" Or strSemester <> item.Text Then
                    strSemester = item.Text
                    _view.cmbYear.Items.Add(item)
                End If
            Next

        Else
            For i As Integer = Year(Now) To 2000 Step -1
                Dim item As ComboBoxItem = New ComboBoxItem()
                item.Text = i
                _view.cmbYear.Items.Add(item)
            Next
            '    _
        End If
    End Sub

    Private Sub Rooms_DropDownList(dt As DataTable)

        _view.cmbRoom.DataSource = dt 'ListModel.RoomList()
        _view.cmbRoom.ValueMember = "ID"
        _view.cmbRoom.DisplayMember = "name"
        _view.cmbRoom.SelectedValue = -1

    End Sub

    Private Sub TimeSchedule_DropDownList(dt As DataTable)

        _view.cmbTimeSched.DataSource = dt 'ListModel.TimeSchedList()
        _view.cmbTimeSched.ValueMember = "ID"
        _view.cmbTimeSched.DisplayMember = "name"
        _view.cmbTimeSched.SelectedValue = -1
    End Sub

    Private Sub Department_DropDownList()

        _view.cmbDepartment.DataSource = ListModel.DepartmentList()
        _view.cmbDepartment.ValueMember = "ID"
        _view.cmbDepartment.DisplayMember = "name"
        _view.cmbDepartment.SelectedValue = -1
    End Sub

    Private Sub DayName_DropDownList(dt As DataTable)

        _view.cmbDayName.DataSource = dt 'ListModel.DayNameList()
        _view.cmbDayName.ValueMember = "ID"
        _view.cmbDayName.DisplayMember = "name"
        _view.cmbDayName.SelectedValue = -1
    End Sub

    Private Sub Subject_DropDownList()
        _view.cmbSubject.DataSource = ListModel.SubjectList(_view.cmBatch.SelectedValue)
        _view.cmbSubject.ValueMember = "ID"
        _view.cmbSubject.DisplayMember = "name"
        _view.cmbSubject.SelectedValue = -1
    End Sub

    Private Sub StudentCategory_DropDownList()
        _view.cmbStudentCategory.DataSource = ListModel.StudentCategoryList()
        _view.cmbStudentCategory.ValueMember = "ID"
        _view.cmbStudentCategory.DisplayMember = "name"
        _view.cmbStudentCategory.SelectedValue = -1
    End Sub

    Dim lastCol As Integer
    Private Sub Refresh()

        _view.gvGradeSheet.Columns.Clear()

        _view.lblmalecount.Text = 0
        _view.lblfemalecount.Text = 0
        _view.lblTotal.Text = 0
        Dim _No As Integer = 0
        Dim dt As New DataTable
        '    _view.gcGradeSheet.DataSource = Nothing

        dt = ListModel.RetreivedNewList(subecjtID, _view.cmbSemester.Text, _view.cmbYear.Text, _view.cmbDayName.SelectedValue, _view.cmbTimeSched.SelectedValue, _view.cmbRoom.SelectedValue)

        Dim dt_gradesheet As New DataTable
        dt_gradesheet = ListModel.getGradeSheetHeader

        For Each rows As DataRow In dt.Rows

            If rows("gender") = "MALE" Then
                _view.lblmalecount.Text += 1
            Else
                _view.lblfemalecount.Text += 1
            End If
            _No += 1
            dt_gradesheet.Rows.Add(_No, rows("stdID"), rows("last_name"), rows("first_name"), rows("middle_name"), rows("gender"), rows("CourseYrLvl"), rows("YrLvl"), rows("MIDTERM"), rows("FINAL"), rows("finalgrade"), rows("REMARKS"))

        Next

        _view.lblTotal.Text = CInt(_view.lblmalecount.Text) + CInt(_view.lblfemalecount.Text)

        '  _view.gcGradeSheet.DataSource = dt_gradesheet
        _view.BandedGridView1.OptionsView.ShowBands = True
        _view.GridControl1.DataSource = dt_gradesheet
        _view.BandedGridView1.OptionsView.ColumnAutoWidth = True
        _view.btnPrint.Enabled = True



#Region "old"
        'If dt.Rows.Count > 0 Then

        '    'Add Column
        '    Dim dt_column As New DataTable
        '    dt_column = ListModel.getColumn(13)
        '    If dt_column.Rows.Count > 0 Then
        '        For Each colRoww As DataRow In dt_column.Rows
        '            dt.Columns.Add(colRoww.Item("name"))
        '        Next
        '    End If

        '    Dim ColumnName As String = ""
        '    Dim dt_grades As New DataTable
        '    If dt.Rows.Count > 0 Then

        '        Dim x As Integer = 0

        '        For Each rows As DataRow In dt.Rows
        '            For col As Integer = 0 To dt.Columns.Count - 1
        '                If ColumnName = "" Then

        '                    dt_grades = ListModel.Grades(rows("StudentSubjID"))
        '                    ColumnName = dt_grades(0)("name")

        '                ElseIf ColumnName = dt.Columns(col).ToString Then

        '                    rows(ColumnName) = dt_grades(x)("grades")
        '                    x += 1
        '                    If dt_grades.Rows.Count - 1 >= x Then
        '                        ColumnName = dt_grades(x)("name")
        '                    End If
        '                End If

        '            Next

        '            'count
        '            If rows.Item("gender") = "MALE" Then
        '                _view.lblmalecount.Text += 1
        '            Else
        '                _view.lblfemalecount.Text += 1
        '            End If



        '            x = 0
        '            ColumnName = ""

        '        Next

        '        _view.lblTotal.Text = CInt(_view.lblmalecount.Text) + CInt(_view.lblfemalecount.Text)

        '        lastCol = dt.Columns.Count - 1

        '        _view.gcGradeSheet.DataSource = dt

        '        '           getDesignGridControl(_view.gvGradeSheet)

        '        _view.btnPrint.Enabled = True
        '    End If
        'End If


        ''     _view.gcGradeSheet.DataSource = dt


        ''     _view.gvGradeSheet.GroupFormat = "{1}"
        ''       _view.gvGradeSheet.Columns("gender").GroupIndex = 1
        ''       _view.gvGradeSheet.Columns("gender").SortIndex = SortOrder.Descending
        ''       _view.gvGradeSheet.ExpandAllGroups()

        ''   _view.gvGradeSheet.Columns("gender").OptionsColumn.AllowSort = DefaultBoolean.False
#End Region


    End Sub

    Private Sub getDesignGridControl(view As Views.Grid.GridView)

        view.BeginUpdate()
        '     view.Columns.View.OptionsBehavior.Editable = False
        '   '      view.OptionsView.ColumnAutoWidth = False
        For i As Integer = 0 To view.Columns.Count - 1

            Select Case i
                Case 1, 5, 7, 8, 9
                    view.Columns(i).Visible = False
                Case 0
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).Width = 70
                Case 2, 3, 4
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).Width = 150
                Case 6
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    view.Columns(i).Width = 200
                Case lastCol
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).Width = 150
                Case Else
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    view.Columns(i).Width = 100

            End Select

        Next

        _view.gvGradeSheet.Columns("gender").GroupIndex = 0
        view.OptionsView.ColumnAutoWidth = True
        '      _view.gvGradeSheet.ExpandAllGroups()

        view.EndUpdate()


    End Sub




    Friend Sub Print()

        Cursor.Current = Cursors.WaitCursor

        Try
            Dim report As New XtraReport_GradeSheet
            'If Not File.Exists(COMPANY_HEADER_PATH) Then
            '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
            'Else
            '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
            'End If

            report.XrLsubject.Text = _view.cmbSubject.Text
                report.XrLsemester.Text = _view.cmbSemester.Text
                report.XrLacademicyear.Text = _view.cmbYear.Text
                report.XrLdeapartment.Text = _view.cmbDepartment.Text
                report.XrLdays.Text = _view.cmbDayName.Text
                report.XrLtime.Text = _view.cmbTimeSched.Text
                report.XrLroom.Text = _view.cmbRoom.Text

                report.XrLblcreditunit.Text = "CREDIT UNIT : " & _view.lblcreditsunit.Text
                report.XrLblmalecount.Text = _view.lblmalecount.Text
                report.XrLblfemalecount.Text = _view.lblfemalecount.Text
            report.XrLbltotal.Text = _view.lblTotal.Text
            report.user.Text = AuthUserName

            report.PrintableComponentContainer1.PrintableComponent = _view.GridControl1

            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                report.CreateDocument()
                report.ShowPreview

            Catch ex As Exception

            End Try


        Cursor.Current = Cursors.Default


    End Sub

    Private Function CreateXRRichText() As XRRichText
        Dim XrRichText1 As New XRRichText()

        ' Set its height to be calculated automatically,
        ' and make its borders visible.
        XrRichText1.CanGrow = True
        XrRichText1.CanShrink = True
        XrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.All

        ' Create an array of lines and assign it to the rich text.
        Dim BoxLines() As String = New String(2) {}
        BoxLines(0) = "Line 1"
        BoxLines(1) = "Line 2"
        BoxLines(2) = "Line 3"
        XrRichText1.Lines = BoxLines
        XrRichText1.Text = "Rogerfdfdsgsgsg"
        ' Export its contents to a text file.
        '      XrRichText10.1SaveFile("output.txt", XRRichTextStreamType.PlainText)

        Return XrRichText1


    End Function
End Class
