Imports System.IO
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class SubjectLoadListPresenter
    Private _view As frmSubjectLoad
    Dim ListModel As New SubjectLoadListModel
    Public Sub New(view As frmSubjectLoad)
        _view = view

        loadComboBox()
        loadHandler()

        _view.cmbSemester.SelectedIndex = -1
        _view.cmbYearLevel.SelectedIndex = -1


    End Sub

    Private Sub loadHandler()

        AddHandler _view.cmbAcademicYear.SelectedIndexChanged, AddressOf cmbAcademicYear_SelectedIndexChanged
        AddHandler _view.cmbSemester.SelectedIndexChanged, AddressOf cmbSemester_SelectedIndexChanged
        AddHandler _view.cmbYearLevel.SelectedIndexChanged, AddressOf cmbYearLevel_SelectedIndexChanged
        AddHandler _view.btnGenerate.Click, AddressOf btnGenerate_Click
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor

        Dim dt As New DataTable
        dt = _view.gcSubjectLoad.DataSource
        generate(dt)

        Cursor.Current = Cursors.Default

    End Sub



    Private Sub generate(dt As DataTable)

        Dim page As Integer = 1

        Dim main_report As New xtrSubjectLoad_Main

        For Each rows As DataRow In dt.Rows

            If rows("INCLUDE") = "True" Then

                Dim master_report(page) As xtrSubjectLoad_Main
                master_report(page) = New xtrSubjectLoad_Main

                Dim report As New xtrSubjectLoad
                'If Not File.Exists(COMPANY_HEADER_PATH) Then
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                'Else
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                'End If

                Dim parameter As String = where & " AND subject_class_schedule.employee_id= '" & rows("employee_id") & "'"
                Dim dt_PreSubject As DataTable = ListModel.getPreparationSubject1(parameter)

                report.preparation_subject.Text = dt_PreSubject(0)("PreSubject").ToString & " PREPARATIONS (SUBJECTS)"
                report.semester.Text = _view.cmbSemester.Text
                report.academic_year.Text = _view.cmbAcademicYear.Text

                Dim dt_SubjectLoadInsttructor As New DataTable

                dt_SubjectLoadInsttructor = ListModel.getSubjectLoadInsttructor(rows("employee_id"))

                Dim TotalUnits As Double = 0

                Dim SubjectLoadQuery As New List(Of SubjectLoadInstructor)
                For Each rowss As DataRow In dt_SubjectLoadInsttructor.Rows
                    Dim obj As New SubjectLoadInstructor
                    With obj
                        .employee_id = rowss("employee_id")
                        .employee_name = rowss("employee_name").ToString
                        .class_time = rowss("class_time")
                        .SubjectCode = rowss("SubjectCode")
                        .SubjectName = rowss("SubjectName")
                        .credit_hours = rowss("credit_hours")
                        TotalUnits += .credit_hours
                        .Course = rowss("Course")
                        .Block = rowss("Block")
                        .day = rowss("day")
                        .room = rowss("room")
                        .NoStudent = rowss("No.Student")
                        .year_level = rowss("year_level")
                    End With
                    SubjectLoadQuery.Add(obj)
                Next

                report.DataSource = SubjectLoadQuery
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1

                Dim Subreport As XRSubreport = TryCast(master_report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                Subreport.ReportSource = report

                master_report(page).user.Text = "User Name : " & ServerPath_UserName
                master_report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                master_report(page).CreateDocument()

                main_report.Pages.AddRange(master_report(page).Pages)
                main_report.PrintingSystem.ContinuousPageNumbering = True

                page += 1

                SubjectLoadQuery.Clear()
            End If
        Next

        main_report.ShowPreview
    End Sub

    Private Sub cmbYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadList()
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadList()
    End Sub

    Private Sub cmbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        _view.cmbSemester.SelectedIndex = 0
        _view.cmbYearLevel.SelectedIndex = 0

        _view.cmbSemester.Enabled = True
        _view.cmbYearLevel.Enabled = True

        loadList()
    End Sub

    Dim where As String = ""
    Private Sub loadList()
        where = ""
        Cursor.Current = Cursors.WaitCursor

        If _view.cmbAcademicYear.SelectedIndex > -1 And _view.cmbSemester.SelectedIndex = 0 And _view.cmbYearLevel.SelectedIndex = 0 Then
            where = "WHERE students.academice_year = '" & _view.cmbAcademicYear.Text & "' "
        ElseIf _view.cmbAcademicYear.SelectedIndex > -1 And _view.cmbSemester.SelectedIndex > 0 And _view.cmbYearLevel.SelectedIndex = 0 Then
            where = "WHERE students.academice_year = '" & _view.cmbAcademicYear.Text & "' AND students.semester = '" & _view.cmbSemester.Text & "'"
        ElseIf _view.cmbAcademicYear.SelectedIndex > -1 And _view.cmbSemester.SelectedIndex > 0 And _view.cmbYearLevel.SelectedIndex > 0 Then
            where = "WHERE students.academice_year = '" & _view.cmbAcademicYear.Text & "' AND students.semester = '" & _view.cmbSemester.Text & "' AND students.year_level = '" & _view.cmbYearLevel.Text & "'"
        Else
            where = "WHERE students.academice_year = '" & _view.cmbAcademicYear.Text & "' AND students.year_level = '" & _view.cmbYearLevel.Text & "'"
        End If

        '   _view.gvSubjectLoad.Columns.Clear()
        _view.gcSubjectLoad.DataSource = ListModel.getSubjectLoad(where)

        Cursor.Current = Cursors.Default


    End Sub

    Private Sub loadComboBox()
        _view.cmbAcademicYear.DataSource = ListModel.getAcademicYear
        _view.cmbAcademicYear.ValueMember = "id"
        _view.cmbAcademicYear.DisplayMember = "name"
        _view.cmbAcademicYear.SelectedIndex = -1
    End Sub
End Class
