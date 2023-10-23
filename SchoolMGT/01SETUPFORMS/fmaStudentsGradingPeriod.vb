Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Public Class fmaStudentsGradingPeriod
    Dim dtsubjectgrades As New DataTable

    Private PtypeDic As New Dictionary(Of Integer, String)
    Private columnType As New List(Of String)

    Private GRADINGPERIOD As Integer = 0

    Private Sub fmaStudentsGradingPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Student_GradingList()
    End Sub

    Public Sub Load_Student_GradingList()
        createHeader()
        displayStudentsSubject()
        loadValues()
    End Sub

    Private Sub createHeader()


        dgvSubjectGrade.Columns.Add("ID", "ID")
        dgvSubjectGrade.Columns.Add("NAME", "NAME")
        dgvSubjectGrade.Columns.Add("CREDIT", "CREDIT")
        dgvSubjectGrade.Columns.Add("INSTRUCTOR", "INSTRUCTOR")
        dgvSubjectGrade.Columns.Add("SysPK", "SysPK")

        dtsubjectgrades.Columns.Add("ID")
        dtsubjectgrades.Columns.Add("NAME")
        dtsubjectgrades.Columns.Add("CREDIT")
        dtsubjectgrades.Columns.Add("INSTRUCTOR")
        dtsubjectgrades.Columns.Add("SysPK")

        dgvSubjectGrade.Columns(0).Width = 100
        dgvSubjectGrade.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSubjectGrade.Columns(1).Width = 250
        dgvSubjectGrade.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvSubjectGrade.Columns(2).Width = 100
        dgvSubjectGrade.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSubjectGrade.Columns(3).Width = 200
        dgvSubjectGrade.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvSubjectGrade.Columns(4).Visible = False



        Dim SQLEX As String = "SELECT id, name FROM student_grading_period"
        SQLEX += " WHERE student_category_id='" & txtCatID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim colcount As Integer = dgvSubjectGrade.Columns.Count

        If MeData.Rows.Count > 0 Then
            'GRADINGPERIOD = MeData.Rows.Count
            Try
                For nCtr As Integer = 0 To MeData.Rows.Count - 1
                    Dim columnName As String = MeData.Rows(nCtr).Item("id").ToString
                    Dim Header As String = MeData.Rows(nCtr).Item("name").ToString

                    dgvSubjectGrade.Columns.Add(columnName, Header)
                    dtsubjectgrades.Columns.Add(Header)
                    dgvSubjectGrade.Columns(colcount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                    PtypeDic.Add(colcount, columnName)
                    colcount += 1
                    columnType.Add("0.00")
                Next

            Catch ex As Exception

            End Try
        End If
        GRADINGPERIOD = colcount
        dgvSubjectGrade.Columns.Add("FIN. GRADE", "FIN. GRADE")
        dtsubjectgrades.Columns.Add("FIN. GRADE")
        dgvSubjectGrade.Columns(colcount).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub displayStudentsSubject()
        Dim colcount As Integer = dgvSubjectGrade.Columns.Count - 1

        Dim SQLEX As String = "SELECT students_subjects.id 'stdid', subjects.name 'subjname'"
        SQLEX += " , subjects.credit_hours"
        'SQLEX += " , subject_class_schedule.name 'skedname'"
        SQLEX += " , subject_class_schedule.employee_name"
        SQLEX += " , subject_class_schedule.SysPK_Item"
        SQLEX += " FROM subjects"
        SQLEX += " INNER JOIN students_subjects "
        SQLEX += " ON (subjects.id = students_subjects.subject_id)"
        SQLEX += " INNER JOIN subject_class_schedule "
        SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
        SQLEX += " WHERE students_subjects.student_id='" & txtStudentID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            For nCtr As Integer = 0 To MeData.Rows.Count - 1
                Dim defaultRows As New List(Of String)

                defaultRows.Add(MeData.Rows(nCtr).Item("stdid").ToString)
                defaultRows.Add(MeData.Rows(nCtr).Item("subjname").ToString)
                defaultRows.Add(MeData.Rows(nCtr).Item("credit_hours").ToString)
                defaultRows.Add(MeData.Rows(nCtr).Item("employee_name").ToString)
                defaultRows.Add(MeData.Rows(nCtr).Item("SysPK_Item").ToString)

                defaultRows.AddRange(columnType)
                dgvSubjectGrade.Rows.Add(defaultRows.ToArray)
                dtsubjectgrades.Rows.Add(defaultRows.ToArray)

            Next

        End If



    End Sub



    Private Sub loadValues()
        'Dim pair As KeyValuePair(Of Integer, String)
        'For Each pair In PtypeDic
        '    Dim valuepair As String = pair.Key & ":" & pair.Value
        '    Dim targaet As String = ""
        'Next


        Dim rowCount As Integer = dgvSubjectGrade.Rows.Count - 1

        For jRows As Integer = 0 To rowCount

            Dim studentSubjectID As String = dgvSubjectGrade.Item(0, jRows).Value

            For pCount As Integer = 4 To GRADINGPERIOD
                Dim gradingID As String = ""
                If PtypeDic.ContainsKey(pCount) Then
                    gradingID = PtypeDic.Item(pCount)

                End If

                'gradingID = PtypeDic.Item(pCount).ToString

                Dim SQLEX As String = "SELECT student_grade.grades"
                SQLEX += " FROM student_grade"
                SQLEX += " INNER JOIN student_grading_period "
                SQLEX += " ON (student_grade.students_grading_id = student_grading_period.id)"
                SQLEX += " WHERE student_grading_period.id='" & gradingID & "'"
                SQLEX += " AND student_grade.students_subject_id='" & studentSubjectID & "'"

                Dim MeData As DataTable
                MeData = clsDBConn.ExecQuery(SQLEX)

                If MeData.Rows.Count > 0 Then
                    Dim grade As String = MeData.Rows(0).Item("grades").ToString
                    dgvSubjectGrade.Item(pCount, jRows).Value = grade
                    dtsubjectgrades.Rows(jRows).Item(pCount) = grade
                    'SUBJDATATABLE.Rows(nCtr).Item(col).ToString()
                End If

                MeData = Nothing
            Next

            Dim FINALGRADE As String = "SELECT finalgrade from students_subjects where id='" & studentSubjectID & "'"

            Dim gradeData As DataTable
            gradeData = clsDBConn.ExecQuery(FINALGRADE)

            If gradeData.Rows.Count > 0 Then
                Try
                    Dim subjfinalgrade As String = gradeData.Rows(0).Item("finalgrade").ToString
                    dgvSubjectGrade.Item(GRADINGPERIOD, jRows).Value = subjfinalgrade
                    dtsubjectgrades.Rows(jRows).Item(GRADINGPERIOD) = subjfinalgrade
                Catch ex As Exception

                End Try
            End If


        Next
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click


        Dim GradeSlip As New List(Of GradeSlip)
        Dim dt As New DataTable

        dt = LoadStudentSubject(txtStudentID.Text)
        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
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
                    .finalgrade = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                    .remarks = If(IsDBNull(row("REMARKS")), "", row("REMARKS"))
                    .sem_ay = row("Sem_AY")
                End With
                GradeSlip.Add(obj)
            Next

            Dim report As New xtrGradeSlip

            report.preparedby.Text = AuthUserName
            report.DataSource = GradeSlip
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
            report.CreateDocument()
            report.ShowPreview


        Else
            MsgBox("Records Not Found")
        End If


#Region "old"
        ''Dim SQLEX As String = "SELECT students.id,students.admission_no,students.std_number"
        ''SQLEX += " , CONCAT( person.last_name, ', ', person.first_name, '  ', person.middle_name ) AS studentname"
        ''SQLEX += " , batches.`name` AS batchname,batches.school_year,batches.semester,batches.year_level"
        ''SQLEX += " FROM students"
        ''SQLEX += " INNER JOIN batches"
        ''SQLEX += " ON (batches.id = students.batch_id)"
        ''SQLEX += " INNER JOIN person"
        ''SQLEX += " ON students.person_id = person.person_id"

        ''SQLEX += " WHERE students.id = '" & txtStudentID.Text & "' AND person.status_type_id = 1 AND person.end_time IS NULL"

        ''Dim new_report As New fzzReportViewerForm
        ''new_report.AttachReport(SQLEX, "STUDENT GRADE " & Me.txtStudentID.Text) =
        ''New rpt_StudentsGrade(dtsubjectgrades, txtCatID.Text)
        ''new_report.Show()
#End Region




    End Sub

    Public Function LoadStudentSubject(student_id As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
stdID,
stdNumber,
CONCAT(last_name,', ',first_name,' ',IFNULL(middle_name,'')) 'student_name',
gender,
CourseYrLvl,
YrLvl,
MIDTERM,
FINAL,
finalgrade,
CASE WHEN MIDTERM = 'NG' AND FINAL IS NULL THEN 'No Grade'
		WHEN MIDTERM = 'DR' AND FINAL IS NULL THEN 'Dropped'
		WHEN MIDTERM = 'NA' AND FINAL IS NULL THEN 'Not Attended'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL IS NULL THEN 'PASSED'
		
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'NG' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'DR' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'NA' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'NG' THEN 'No Grades'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'DR' THEN 'Dropped'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'NA' THEN 'Not Attended'
		 
		WHEN MIDTERM > 3.1 AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL > 3.1 THEN 'PASSED'
		 
		WHEN MIDTERM = 'NG' AND FINAL = 'NG' THEN 'No Grades'
		WHEN MIDTERM = 'DR' AND FINAL = 'DR' THEN 'Dropped'
		WHEN MIDTERM = 'NA' AND FINAL = 'NA' THEN 'Not Attended'
		 
		 WHEN MIDTERM > 3.1 AND FINAL > 3.1 THEN 'FAILED'			
		 ELSE '' END AS 'REMARKS',
		 Sem_AY,
	 	course_code,
		descriptive_title,
			units
		     
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
				WHERE person.status_type_id = 1 AND person.end_time IS NULL AND students.id = '" & student_id & "'
					
				)A  
				ORDER BY descriptive_title
		)B
		
			
		
		
		
		"
        Return DataSource(sql)
    End Function

    Dim dt As New DataTable
    Dim SysPk As String = ""
    Dim StdSubjectID As String = ""
    Dim Subject As String = ""

    Private Sub loadGradingPeriod()
        Dim frm As New fmaStudentsGradeEntryForm
        frm.Text = Subject
        frm.txtStudentname.Text = txtStudentName.Text
        frm.txtStudentID.Text = txtStudentID.Text
        frm.txtStudentSubjectID.Text = StdSubjectID

        If Subject.Length > 0 Then
            frm.ShowDialog(Me)

            dgvSubjectGrade.Rows.Clear()
            displayStudentsSubject()
            loadValues()
        Else
            MsgBox("Select row to modify grades..")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub enAbleGradeEditing()
        Dim SQLEX As String = "SELECT grade_dist_from, grade_dist_to FROM batches where id='" & txtBatchID.Text & "'"
        Dim MeData As DataTable

        Dim dateEffectFrom As String = ""
        Dim dateEffectTo As String = ""
        Dim dateNow As Date = Date.Now()

        MeData = clsDBConn.ExecQuery(SQLEX)

        If (MeData.Rows.Count > 0) Then
            Try
                If Not IsDBNull(MeData.Rows(0).Item("grade_dist_from")) Then
                    dateEffectFrom = Format(CDate(MeData.Rows(0).Item("grade_dist_from")), "yyyy-MM-dd")
                End If
            Catch ex As Exception

            End Try

            Try
                If Not IsDBNull(MeData.Rows(0).Item("grade_dist_to")) Then
                    dateEffectTo = Format(CDate(MeData.Rows(0).Item("grade_dist_to")), "yyyy-MM-dd")
                End If
            Catch ex As Exception

            End Try


        End If

        If (dateEffectFrom <> "" And dateEffectTo <> "") Then


            Dim fromDate As DateTime = DateTime.Parse(dateEffectFrom)

            Dim toDate As DateTime = DateTime.Parse(dateEffectTo)

            If ((dateNow >= fromDate) And (dateNow <= toDate)) Then
                Console.WriteLine("between")
                'lblMessage.Visible = False
                isAllowedEdit.Text = "1"
            Else
                Console.WriteLine("not between")
                'lblMessage.Visible = True
                LabelX7.Text = "CANNOT MODIFY OR EDIT GRADES. SCHEDULE OF GRADE DISTRIUTION FOR THIS BATCH HAS EXPIRED. PLS CONTACT SYSTEM ADMINISTRATOR."
                isAllowedEdit.Text = "0"
            End If

        Else
            'lblMessage.Visible = True
            LabelX7.Text = "CANNOT MODIFY OR EDIT GRADES. CHECK SCHEDULE OF GRADE DISTRIUTION FOR THIS BATCH. PLS CONTACT SYSTEM ADMINISTRATOR."
            isAllowedEdit.Text = "0"
        End If
    End Sub


    Private Sub txtBatchID_TextChanged(sender As Object, e As EventArgs) Handles txtBatchID.TextChanged
        If txtBatchID.Text <> "" Then
            enAbleGradeEditing()
        End If
    End Sub

    Private Sub dgvSubjectGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectGrade.CellDoubleClick
        If isAllowedEdit.Text = "0" Then
            MsgBox("Cannot Edit Grades. Pls Contact System Administrator", MsgBoxStyle.Critical)
            Exit Sub
        End If

        SysPk = dgvSubjectGrade.Item("SysPK", e.RowIndex).Value

        dt = Nothing

        dt = DataSource(String.Format("SELECT
            concat(subjects.`name`,' | ',subject_class_schedule.`name`) as 'Subject',
            students_subjects.id as 'StdSubjectID'
            FROM
            subjects
            INNER JOIN subject_class_schedule ON subjects.id = subject_class_schedule.subject_id
            INNER JOIN students_subjects ON subject_class_schedule.SysPK_Item = students_subjects.subject_class_schedule_id
            WHERE
            subject_class_schedule.SysPK_Item = '" & SysPk & "' AND students_subjects.student_id = '" & txtStudentID.Text & "'
            "))

        If dt.Rows.Count > 0 Then
            StdSubjectID = dt(0)("StdSubjectID").ToString
            Subject = dt(0)("Subject").ToString

            loadGradingPeriod()

        End If
    End Sub
End Class