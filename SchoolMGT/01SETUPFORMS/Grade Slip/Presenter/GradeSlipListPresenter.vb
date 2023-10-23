Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class GradeSlipListPresenter
    Private _view As frmGradeSlip
    Dim ListModel As New GradeSlipListModel
    Public Sub New(frmGradeSlip As frmGradeSlip)
        _view = frmGradeSlip

        loadComboBox
        loadHandler

    End Sub

    Private Sub loadHandler()

        AddHandler _view.btnLoadList.Click, AddressOf btnLoadList_Click
        AddHandler _view.btnGenerate.Click, AddressOf btnGenerate_Click
        AddHandler _view.cmbAcademicYear.SelectedIndexChanged, AddressOf cmbAcademicYear_SelectedIndexChanged
        AddHandler _view.cmbCourse.SelectedIndexChanged, AddressOf cmbCourse_SelectedIndexChanged
        AddHandler _view.cmbYearLevel.SelectedIndexChanged, AddressOf cmbYearLevel_SelectedIndexChanged
    End Sub

    Private Sub cmbYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs)
        _view.cmbSemester.Enabled = True
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs)
        _view.cmbYearLevel.Enabled = True
    End Sub

    Private Sub cmbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        _view.cmbCourse.Enabled = True
    End Sub


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Try

            Dim GradeSlip As New List(Of GradeSlip)
            Dim dt As New DataTable
            dt = _view.gcGradeSlip.DataSource

            Dim TotalCopies As Integer = dt.Rows.Count
            Dim PerCopies As Integer = 1


            Dim page As Integer = 1

            Dim main_report As New xtrGradeSlip_Main

            Dim cntr As Integer = 1

            Dim dt_data As New DataTable
            For Each rows As DataRow In dt.Rows

                If rows("INCLUDE") = "True" Then

                    Dim master_report(page) As xtrGradeSlip_Main
                    master_report(page) = New xtrGradeSlip_Main

                    Dim report As New xtrGradeSlip
                    Dim report_dummy As New xtrGradeSlip_dummy

                    dt_data = ListModel.getGrade(rows("stdID"))
                    If dt_data.Rows.Count > 0 Then

                        For Each row As DataRow In dt_data.Rows
                            Dim obj As New GradeSlip
                            With obj
                                .student_id = row("stdID")
                                .student_number = row("stdNumber")
                                .student_name = row("student_name")
                                .course_year = row("CourseYrLvl")
                                .course_code = row("course_code")
                                .descriptive_tile = row("descriptive_title")
                                .units = row("units")
                                .midterm = If(IsDBNull(row("MIDTERM")), "", row("MIDTERM"))
                                .finalterm = If(IsDBNull(row("FINAL")), "", row("FINAL"))
                                .finalterm = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                                .remarks = If(IsDBNull(row("REMARKS")), "", row("REMARKS"))
                                .sem_ay = row("Sem_AY")
                            End With
                            GradeSlip.Add(obj)
                        Next

                        If cntr = 1 Then
                            report.preparedby.Text = AuthUserName
                            report.DataSource = GradeSlip
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report.CreateDocument()

                            'Dim Subreport1 As XRSubreport = TryCast(master_report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                            'Subreport1.ReportSource = report

                            cntr += 1
                        Else
                            report_dummy.preparedby.Text = AuthUserName
                            report_dummy.DataSource = GradeSlip
                            report_dummy.PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report_dummy.CreateDocument()

                            'Dim Subreport2 As XRSubreport = TryCast(master_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                            'Subreport2.ReportSource = report_dummy

                            cntr = 1
                        End If


                        If cntr = 1 Then

                            Dim Subreport1 As XRSubreport = TryCast(master_report(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                            Subreport1.ReportSource = report

                            Dim Subreport2 As XRSubreport = TryCast(master_report(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                            Subreport2.ReportSource = report_dummy

                            master_report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                                master_report(page).CreateDocument()

                                main_report.Pages.AddRange(master_report(page).Pages)
                                main_report.PrintingSystem.ContinuousPageNumbering = True


                                page += 1

                            End If


                            GradeSlip.Clear()
                        End If

                    End If


            Next

            main_report.ShowPreview


        Catch ex As Exception
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnLoadList_Click(sender As Object, e As EventArgs)

        Dim dt As New DataTable
        dt = ListModel.getStudentList(_view.cmbAcademicYear.Text, _view.cmbCourse.SelectedValue, _view.cmbYearLevel.Text, _view.cmbSemester.Text)
        If dt.Rows.Count > 0 Then
            Dim studentID = getJoinID(dt)
            dt = Nothing
            dt = getListStudetn(studentID)
            _view.gcGradeSlip.DataSource = dt
        End If


    End Sub

    Private Function getListStudetn(studentID As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
'False' as 'INCLUDE',
CONCAT(last_name,', ',first_name,' ',middle_name) 'display_name',
stdID
		     
   FROM(
				Select
			   stdID,	
				stdNumber,
				last_name,
				first_name,
				middle_name,
				gender,
				CONCAT(`code`,' ',substring(year_level,1,1))'CourseYrLvl',
				substring(year_level,1,1) 'YrLvl',
				(SELECT student_grade.grades FROM student_grade WHERE student_grade.students_grading_id = 1 AND 
				student_grade.students_subject_id =student_subject_id) 'MIDTERM',
				(SELECT student_grade.grades FROM student_grade WHERE student_grade.students_grading_id = 2 AND 
				student_grade.students_subject_id = student_subject_id) 'FINAL',
				finalgrade,
				CONCAT(semester,', A.Y. ',academice_year)'Sem_AY',
				course_code,
				descriptive_title,
				units
	
				FROM(
				SELECT
				person.person_id,
				person.last_name,
				person.first_name,
				person.middle_name,
				person.gender,
				courses.`code`,
				students.year_level,
				students_subjects.finalgrade,
				students_subjects.id 'student_subject_id',
				subjects.id 'subjectid',
				students.semester,
				students.academice_year,
				day_schedule_id,
				class_timing_id,
				room_id,
				students.std_number 'stdNumber',
				subjects.`code` 'course_code',
				subjects.`name` 'descriptive_title',
				subjects.credit_hours 'units',
			  students.id 'stdID'
			  
				FROM
				students_subjects
				INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
				INNER JOIN students ON students.id = students_subjects.student_id
				INNER JOIN person ON person.person_id = students.person_id 
				INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id
				INNER JOIN courses ON students.course_id = courses.id
				WHERE person.status_type_id = 1 AND person.end_time IS NULL AND students.id IN(" & studentID & ")
					
				)A  
				ORDER BY descriptive_title
		)B
		GROUP BY display_name
		ORDER BY display_name
			
		
		
		
		"
        Return DataSource(sql)
    End Function

    Private Function getJoinID(List As DataTable) As String

        Dim ItemID As New List(Of Integer)
        For Each row As DataRow In List.Rows
            ItemID.Add(row("stdID"))
        Next
        Dim Item As String = Nothing
        If ItemID IsNot Nothing Then
            Item = String.Join(",", ItemID)
        Else
            Item = ""
        End If

        Return Item

    End Function

    Private Sub loadComboBox()

        _view.cmbCourse.DataSource = ListModel.SetComboCourse
        _view.cmbCourse.ValueMember = "id"
        _view.cmbCourse.DisplayMember = "name"
        _view.cmbCourse.SelectedIndex = -1

        _view.cmbAcademicYear.DataSource = ListModel.SetComboAcademicYear
        _view.cmbAcademicYear.ValueMember = "id"
        _view.cmbAcademicYear.DisplayMember = "name"
        _view.cmbAcademicYear.SelectedIndex = -1

    End Sub
End Class
