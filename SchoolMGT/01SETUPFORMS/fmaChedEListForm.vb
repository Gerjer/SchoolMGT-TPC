Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraPrinting
Imports C1.Win.C1TrueDBGrid

Public Class fmaChedEListForm

    Dim gradingPeriodGrades As New fmaStudentsGradingPeriod

    Private m_AsyncWorker As New BackgroundWorker()

    Private Sub fmaStudentListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _batchID = 0
        lblStatus.Text = "Waiting ..."
        displayCourse()
        displayBatches()

        cmbyearbatch.DataSource = DataSource(String.Format("SELECT DISTINCT
                                    1 as 'id',
                                    batches.school_year 'name'
                                    FROM
                                    batches
                                    WHERE school_year is NOT NULL
                                    ORDER BY school_year DESC
                                    "))
        cmbyearbatch.ValueMember = "id"
        cmbyearbatch.DisplayMember = "name"
        cmbyearbatch.SelectedIndex = -1




    End Sub


    Private Sub displayCourse()
        Dim SQLEX As String = "SELECT id, course_name  FROM courses"
        SQLEX += " WHERE is_deleted <> 1"
        SQLEX += " GROUP BY course_name"
        SQLEX += " ORDER BY course_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourse.DataSource = MeData

        cmbCourse.ValueMember = "id"
        cmbCourse.DisplayMember = "course_name"

        cmbCourse.SelectedIndex = -1
        txtCourseID.Text = ""

        tdbViewer.DataSource = Nothing
    End Sub


    Private Sub displayBatches()
        Dim SQLEX As String = ""
        SQLEX = "SELECT batches.id, name, year_level FROM batches"
        SQLEX += " INNER JOIN courses"
        SQLEX += " ON (batches.course_id = courses.id)"
        SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
        SQLEX += " AND course_id ='" & Me.txtCourseID.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"

        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""
    End Sub

    Dim dt_record As New DataTable

    Public Sub displayFilterCategory()

        txtBatchID.Text = _batchID

        Me.tdbViewer.DataSource = Nothing

        Dim SQLEX As String = ""
        SQLEX += " SELECT batches.semester,student_table.std_number, REPLACE ( person.last_name, 'Ã±', 'ñ' ) AS 'last_name' , "
        SQLEX += " person.first_name,person.middle_name , courses.course_name , "
        SQLEX += " person.gender, person.date_of_birth, student_table.year_level, "
        SQLEX += " Case is_enrolled"
        SQLEX += " WHEN 1 THEN 'ENROLLED'"
        SQLEX += " WHEN 2 THEN 'WITHDRAWN'"
        SQLEX += " Else 'NOT ENROLLED'"
        SQLEX += " End As 'status'"
        SQLEX += " , GROUP_CONCAT( DISTINCT subjects.code ORDER BY subjects.code SEPARATOR ', ' ) 'subjects'"
        SQLEX += " , SUM( subjects.credit_hours) 'UNITS'"
        SQLEX += " FROM students AS student_table"
        SQLEX += " INNER JOIN person ON (student_table.person_id = person.person_id AND student_table.status_type_id = 1 AND person.end_time IS NULL) "
        SQLEX += " INNER JOIN student_categories  ON (student_table.student_category_id = student_categories.id) "
        SQLEX += " INNER JOIN batches  ON (student_table.batch_id = batches.id) "
        SQLEX += " INNER JOIN courses  ON (batches.course_id = courses.id)"
        SQLEX += " LEFT JOIN students_subjects AS stud_subj_table ON  (student_table.id=stud_subj_table.student_id)"
        SQLEX += " LEFT JOIN subjects ON (subjects.id=stud_subj_table.subject_id)"
        SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"

        If txtBatchID.Text <> "" Then
            SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
        End If

        If cxbxIncludeNotEnrolled.Checked Then
            SQLEX += " AND is_enrolled='1'"
        End If

        SQLEX += "GROUP BY student_table.id ORDER BY last_name"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        dt_record = MeData
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)

                .DisplayColumns("semester").DataColumn.Caption = "SEMESTER"
                .DisplayColumns("semester").Width = 120
                .DisplayColumns("semester").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("semester").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("std_number").DataColumn.Caption = "ID NUMBER"
                .DisplayColumns("std_number").Width = 150
                .DisplayColumns("std_number").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("std_number").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("last_name").DataColumn.Caption = "LAST NAME"
                .DisplayColumns("last_name").Width = 200
                .DisplayColumns("last_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("last_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("first_name").DataColumn.Caption = "FIRST NAME"
                .DisplayColumns("first_name").Width = 200
                .DisplayColumns("first_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("first_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("middle_name").DataColumn.Caption = "MIDDLE NAME"
                .DisplayColumns("middle_name").Width = 100
                .DisplayColumns("middle_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("middle_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("course_name").DataColumn.Caption = "COURSE"
                .DisplayColumns("course_name").Width = 200
                .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("gender").DataColumn.Caption = "GENDER"
                .DisplayColumns("gender").Width = 120
                .DisplayColumns("gender").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("gender").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("date_of_birth").DataColumn.Caption = "DOB"
                .DisplayColumns("date_of_birth").Width = 150
                .DisplayColumns("date_of_birth").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("date_of_birth").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


                .DisplayColumns("year_level").DataColumn.Caption = "CURRENT YEAR"
                .DisplayColumns("year_level").Width = 150
                .DisplayColumns("year_level").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("year_level").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("status").Visible = False
                '.DisplayColumns("status").DataColumn.Caption = "STATUS"
                '.DisplayColumns("status").Width = 100
                '.DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("subjects").DataColumn.Caption = "SUBJECTS ENROLLED"
                .DisplayColumns("subjects").Width = 500
                .DisplayColumns("subjects").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("subjects").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("UNITS").DataColumn.Caption = "NO OF UNITS"
                .DisplayColumns("UNITS").Width = 100
                .DisplayColumns("UNITS").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("UNITS").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            End With
        Catch ex As Exception

        End Try

        If tdbViewer.RowCount > 0 Then
            btnPrint.Visible = True
        Else
            btnPrint.Visible = False
        End If
    End Sub




    Private Function likes(ByVal dt As DataTable, ByVal column As String, ByVal value As String)
        Dim result = dt.Clone()
        For Each row As DataRow In From row1 As DataRow In dt.Rows Where (row1(column).Contains(value))
            result.ImportRow(row)
        Next
        Return result
    End Function

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
            _courseID = drv.Item("id").ToString
            cmbyearbatch.Enabled = True
        Catch ex As Exception
            Me.txtCourseID.Text = ""
        End Try
        btnPrint.Visible = False
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbBatch.SelectedItem, DataRowView)
            Me.txtBatchID.Text = drv.Item("id").ToString
            _batchID = drv.Item("id").ToString
            Me.txtYearLevel.Text = drv.Item("year_level").ToString
        Catch ex As Exception
            Me.txtBatchID.Text = ""
            Me.txtYearLevel.Text = ""
        End Try
        btnPrint.Visible = False
    End Sub

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click

        displayFilterCategory()

        'If txtStudentName.Text.Length > 0 Then
        '    SearchStudentName()
        'Else
        '    displayFilterCategory()
        'End If

    End Sub



    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        lblStatus.Text = "Waiting ..."

        displayCourse()
        displayBatches()

        tdbViewer.DataSource = Nothing
        btnPrint.Visible = False
    End Sub



    Private Sub AssignScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With fmaStudentsSubjectListForm
            .txtCategory.Text = tdbViewer.Columns.Item("categoryname").Value.ToString
            .txtStudentID.Text = tdbViewer.Columns.Item("id").Value.ToString
            .txtCoursename.Text = tdbViewer.Columns.Item("course_name").Value.ToString
            .txtBatchName.Text = tdbViewer.Columns.Item("batchname").Value.ToString
            .txtStudentName.Text = tdbViewer.Columns.Item("last_name").Value.ToString _
                                   & ", " & tdbViewer.Columns.Item("first_name").Value.ToString() _
                                   & " " & tdbViewer.Columns.Item("middle_name").Value.ToString()
            .txtAdmissionNo.Text = tdbViewer.Columns.Item("admission_no").Value.ToString
        End With

        '     fmaStudentsSubjectListForm.MdiParent = ftmdiMainForm
        fmaStudentsSubjectListForm.Show()
        fmaStudentsSubjectListForm.BringToFront()
    End Sub

    Private Sub ViewAssessmentToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With fmaStudentAssessmentForm
            .txtCategoryID.Text = tdbViewer.Columns.Item("categoryid").Value.ToString
            .txtAdmissionNo.Text = tdbViewer.Columns.Item("admission_no").Value.ToString
            .txtIDNumber.Text = tdbViewer.Columns.Item("std_number").Value.ToString
            .txtGrant.Text = tdbViewer.Columns.Item("scholarshipgrant").Value.ToString
            .txtStudentID.Text = tdbViewer.Columns.Item("id").Value.ToString
            .txtStudentName.Text = tdbViewer.Columns.Item("last_name").Value.ToString _
                                   & ", " & tdbViewer.Columns.Item("first_name").Value.ToString() _
                                   & " " & tdbViewer.Columns.Item("middle_name").Value.ToString()
            .txtCourse.Text = tdbViewer.Columns.Item("course_name").Value.ToString
            'year_level,school_year,semester
            .txtSY.Text = tdbViewer.Columns.Item("school_year").Value.ToString
            .txtYearLvl.Text = tdbViewer.Columns.Item("year_level").Value.ToString
            .txtSemester.Text = tdbViewer.Columns.Item("semester").Value.ToString
            .txtCategoryName.Text = tdbViewer.Columns.Item("categoryname").Value.ToString
            '.txtEnrollStat.Text = tdbViewer.Columns.Item("status").Value.ToString

        End With

        '     fmaStudentAssessmentForm.MdiParent = ftmdiMainForm
        fmaStudentAssessmentForm.Show()
        fmaStudentAssessmentForm.BringToFront()
    End Sub

    Dim row As Object
    Private ReadOnly student_COR_info As Object



    Dim COR_info As New Student_COR
    Dim Subject_info As New List(Of COR_Subject_Details)
    Dim Assessment_info As New List(Of COR_Assessment_Details)
    Dim Default_LogoPath As String = Directory.GetCurrentDirectory & "\TPC_logo.jpg"
    Private Sub printCOR(addmission_no As Object, id As Integer)

        Cursor = Cursors.WaitCursor

        Dim master_report As New XtraReport_COR
        '     Dim printTool As New printc(New XtraReport())

        Dim page As Integer = 1
        While page < 3

            Dim report(page) As XtraReport_COR
            report(page) = New XtraReport_COR

            report(page).XrLabel1.Text = COMPANY_NAME
            report(page).XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
            report(page).XrLabel5.Text = "Email Address: " & COMPANY_EMAIL_ADDRESS

            If Not File.Exists(COMPANY_LOGO_PATH) Then
                report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
            Else
                report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
            End If
            report(page).XrLabel25.Text = getTotalAmount(id)

            If page = 2 Then
                report(page).XrLabeLRegistrarCopy.Visible = True
            Else
                report(page).XrLabeLRegistrarCopy.Visible = False
            End If

            Dim dt As New DataTable
            dt = getStudents_COR_info(addmission_no)

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
                dt = getStudent_Subject_info(addmission_no)

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
                dt = getStudent_Assessment_info(id)
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

        Cursor = Cursors.Default

    End Sub

    Private Function StartPrint() As PrintDocumentEventHandler

    End Function

    Private Sub StartPrint(sender As Object, e As PrintDocumentEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Function getTotalAmount(id As Integer) As String
        Dim Amount As String = ""
        Amount = DataObject(String.Format("SELECT
students_assessment.total 'Amount'

FROM
students_assessment

WHERE
students_assessment.student_id = '" & id & "' AND
students_assessment.columnName = 'D' AND 
students_assessment.stat = 'T+'"))
        Return Amount
    End Function

    Private Function getStudent_Assessment_info(id As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
Charges,
Amount
FROM(
SELECT
students_assessment.particulars 'Charges',
students_assessment.amount 'Amount'

FROM
students_assessment
INNER JOIN finance_fee_particulars ON students_assessment.particulars = finance_fee_particulars.`name`
WHERE
students_assessment.student_id = '" & id & "' AND
students_assessment.columnName = 'D'

UNION ALL

SELECT
students_assessment.particulars 'Charges',
students_assessment.amount 'Amount'

FROM
students_assessment
-- INNER JOIN finance_fee_particulars ON students_assessment.particulars = finance_fee_particulars.`name`
WHERE
students_assessment.student_id = '" & id & "' AND
students_assessment.columnName = 'D' AND students_assessment.particulars LIKE '%TUITION%'

/*
UNION ALL


SELECT
students_assessment.amount 'Charges',
students_assessment.total 'Amount'

FROM
students_assessment

WHERE
students_assessment.student_id = '" & id & "'/* AND
students_assessment.columnName = 'D' AND students_assessment.stat = '++' OR 
students_assessment.stat = '-+'  OR students_assessment.stat = '--'*/

)A



"))
        Return dt
    End Function

    Private Function getStudent_Subject_info(addmission_no As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	subjects.CODE 'subject_code',
	subjects.NAME 'descriptive_title',
	subjects.credit_hours 'units',
	subject_class_schedule.class_time 'time',
	subject_class_schedule.day 'day',
	subject_class_schedule.room 'room',
	subject_class_schedule.employee_name 'instructor'

FROM
	students_subjects
	INNER JOIN students ON ( students_subjects.student_id = students.id )
	INNER JOIN subjects ON ( students_subjects.subject_id = subjects.id )
	LEFT JOIN subject_class_schedule ON ( students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item ) 
WHERE
	admission_no = '" & addmission_no & "'"))
        Return dt
    End Function

    Private Function getStudents_COR_info(addmission_no As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  students.std_number as 'IdNumber',
	CONCAT(person.display_name,' - ',courses.course_name) AS 'NameCourse',
	CONCAT(batches.semester,' AY ',school_year,'// ',DATE_FORMAT(admission_date,'%m/%d/%Y')) AS 'sem_year_date',
	SUM(subjects.credit_hours) as 'TotalUnits',
	SUM(subjects.amount) as 'TutionFees'

FROM
	students_subjects
	INNER JOIN students ON ( students_subjects.student_id = students.id )
	INNER JOIN person ON (students.person_id = person.person_id)
	INNER JOIN courses ON (students.course_id = courses.id)
	INNER JOIN batches ON (students.batch_id = batches.id)
	INNER JOIN subjects ON ( students_subjects.subject_id = subjects.id )
	LEFT JOIN subject_class_schedule ON ( students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item ) 
WHERE
		students.admission_no = '" & addmission_no & "'"))
        Return dt
    End Function

    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        If txtCourseID.Text.Length > 0 Then
            If cmbBatch.Enabled = False Then
                cmbBatch.Enabled = True
            End If
            displayBatches()
        Else
            cmbBatch.Enabled = False
        End If
    End Sub



    Private Sub ViewGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gradingPeriodGrades Is Nothing Then
            gradingPeriodGrades = New fmaStudentsGradingPeriod
        Else
            gradingPeriodGrades = Nothing
            gradingPeriodGrades = New fmaStudentsGradingPeriod
        End If


        With gradingPeriodGrades
            .txtCategory.Text = tdbViewer.Columns.Item("categoryname").Value.ToString
            .txtStudentID.Text = tdbViewer.Columns.Item("id").Value.ToString
            .txtCoursename.Text = tdbViewer.Columns.Item("course_name").Value.ToString
            .txtBatchName.Text = tdbViewer.Columns.Item("batchname").Value.ToString
            .txtStudentName.Text = tdbViewer.Columns.Item("last_name").Value.ToString _
                                   & ", " & tdbViewer.Columns.Item("first_name").Value.ToString() _
                                   & " " & tdbViewer.Columns.Item("middle_name").Value.ToString()
            .txtAdmissionNo.Text = tdbViewer.Columns.Item("admission_no").Value.ToString
            'categoryid
            .txtCatID.Text = tdbViewer.Columns.Item("categoryid").Value.ToString
        End With

        gradingPeriodGrades.ShowDialog(Me)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Me.Close()
    End Sub

    Private Sub PreviewCORToolStripMenuItem_Click(sender As Object, e As EventArgs)

        If tdbViewer(row, "status") = "enrolled" Then
            printCOR(tdbViewer(row, "ADMISSION NUMBER"), tdbViewer(row, "id"))
        Else
            MsgBox("Cannot Print COR", MsgBoxStyle.Critical, "STUDENT NOT ENROLLED")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim FirstCharIndex As Integer 'the index where first char is located
        Dim LastCharIndex As Integer 'the index where last char is located
        Dim AYString As String


        FirstCharIndex = cmbBatch.Text.IndexOf("(") 'this will return 1 in this condition
        LastCharIndex = cmbBatch.Text.IndexOf(")") 'this will return 10


        AYString = cmbBatch.Text.Substring(FirstCharIndex + 1, (LastCharIndex - FirstCharIndex) - 1)

        Dim SQLEX As String = ""
        SQLEX += " SELECT batches.semester,student_table.std_number, REPLACE ( person.last_name, 'Ã±', 'ñ' ) AS 'last_name' , "
        SQLEX += " person.first_name,person.middle_name , courses.course_name , "
        SQLEX += " person.gender, person.date_of_birth, student_table.year_level, "
        SQLEX += " Case is_enrolled"
        SQLEX += " WHEN 1 THEN 'ENROLLED'"
        SQLEX += " WHEN 2 THEN 'WITHDRAWN'"
        SQLEX += " Else 'NOT ENROLLED'"
        SQLEX += " End As 'status'"
        SQLEX += " , GROUP_CONCAT( DISTINCT subjects.code ORDER BY subjects.code SEPARATOR ', ' ) 'subjects'"
        SQLEX += " , SUM( subjects.credit_hours) 'UNITS'"
        SQLEX += " FROM students AS student_table"
        SQLEX += " INNER JOIN person ON (student_table.person_id = person.person_id AND student_table.status_type_id = 1 AND person.end_time IS NULL) "
        SQLEX += " INNER JOIN student_categories  ON (student_table.student_category_id = student_categories.id) "
        SQLEX += " INNER JOIN batches  ON (student_table.batch_id = batches.id) "
        SQLEX += " INNER JOIN courses  ON (batches.course_id = courses.id)"
        SQLEX += " LEFT JOIN students_subjects AS stud_subj_table ON  (student_table.id=stud_subj_table.student_id)"
        SQLEX += " LEFT JOIN subjects ON (subjects.id=stud_subj_table.subject_id)"
        SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"

        If txtBatchID.Text <> "" Then
            SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
        End If

        If cxbxIncludeNotEnrolled.Checked Then
            SQLEX += " AND is_enrolled='1'"
        End If

        SQLEX += "GROUP BY student_table.id ORDER BY last_name"

        Dim new_report As New fzzReportViewerForm

        new_report.AttachReport(SQLEX, "CHED E-LIST ") = New rpt_CHED_E_List("AY " & AYString, cmbCourse.Text, txtYearLevel.Text)
        new_report.Show()

    End Sub

    Private Sub cmbyearbatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyearbatch.SelectedIndexChanged

        Try
            Dim SQLEX As String = "SELECT batches.id, name FROM batches"
            SQLEX += " INNER JOIN courses"
            SQLEX += " ON (batches.course_id = courses.id)"
            SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
            SQLEX += " AND course_id='" & Me.txtCourseID.Text & "' AND batches.school_year = '" & cmbyearbatch.Text & "' "


            Dim MeData As DataTable
            MeData = clsDBConn.ExecQuery(SQLEX)

            cmbBatch.DataSource = MeData

            cmbBatch.ValueMember = "id"
            cmbBatch.DisplayMember = "name"
            cmbBatch.Text = ""
            cmbBatch.SelectedIndex = -1
        Catch ex As Exception

        End Try

    End Sub
End Class