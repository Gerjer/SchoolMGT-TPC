Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.XtraGrid

Public Class fmaStudentsGradeEntryForm

    Private GRADES As DataTable
    Dim MultiEntryGrade As New List(Of GradingPeriod)

    Private Sub fmaStudentsGradeEntryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayGrading()
        displayGrades()
        displayFinalGrade()
    End Sub

    Private Sub displayGrades()
        GRADES = New DataTable
        GRADES.Rows.Clear()
        Dim MeData As New DataTable

        Dim SQLEX As String = "SELECT students_grading_id,students_subject_id,"
        SQLEX += " student_grading_period.name 'gradingname', grades,remarks,student_grading_period.weight_percentage FROM student_grade"
        SQLEX += " INNER JOIN student_grading_period"
        SQLEX += " ON student_grading_period.id = student_grade.students_grading_id"
        'SQLEX += " LEFT JOIN students_subjects"
        'SQLEX += " ON students_subjects.subject_id = student_grade.students_subject_id"

        SQLEX += " WHERE student_grade.students_subject_id='" & txtStudentSubjectID.Text & "'"

        MeData = clsDBConn.ExecQuery(SQLEX)
        GRADES = MeData
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("students_grading_id").Visible = False
                .DisplayColumns("students_subject_id").Visible = False

                .DisplayColumns("gradingname").DataColumn.Caption = "GRADING PERIOD"
                .DisplayColumns("gradingname").Width = 150
                .DisplayColumns("gradingname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("gradingname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("grades").DataColumn.Caption = "GRADES"
                .DisplayColumns("grades").Width = 150
                .DisplayColumns("grades").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("grades").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("remarks").DataColumn.Caption = "REMARKS"
                .DisplayColumns("remarks").Width = 150
                .DisplayColumns("remarks").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("remarks").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("weight_percentage").DataColumn.Caption = "GRADE WEIGHT%"
                .DisplayColumns("weight_percentage").Width = 100
                .DisplayColumns("weight_percentage").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("weight_percentage").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center



            End With

        Catch ex As Exception

        End Try

        computeAverage()
    End Sub

    Private Sub displayGrading()
        Dim category As String = ""
        Dim categorySQL As String = "SELECT courses.category_id"
        categorySQL += " FROM students"
        categorySQL += " INNER JOIN batches "
        categorySQL += " ON (students.batch_id = batches.id)"
        categorySQL += " INNER JOIN courses "
        categorySQL += " ON (batches.course_id = courses.id)"
        categorySQL += " WHERE students.id='" & txtStudentID.Text & "'"


        Dim catData As DataTable
        catData = clsDBConn.ExecQuery(categorySQL)

        If catData.Rows.Count > 0 Then
            category = catData.Rows(0).Item("category_id").ToString
            creatMultipleEntryDT(category)
        End If


        Dim SQLEX As String = "SELECT id, name, weight_percentage  FROM student_grading_period"
        SQLEX += " WHERE is_deleted <> 1"
        SQLEX += " AND student_category_id='" & category & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCategory.DataSource = MeData

        cmbCategory.ValueMember = "id"
        cmbCategory.DisplayMember = "name"

        cmbCategory.SelectedIndex = -1
        txtGradePerioID.Text = ""



    End Sub

    Private Sub creatMultipleEntryDT(category As String)
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                student_grading_period.id,
                student_grading_period.`name` AS CATEGORY,
                '' AS 'GRADE',
                '' AS 'REMARKS',
                '' AS 'FINAL GRADE'
                FROM
                student_grading_period
                WHERE
                student_grading_period.student_category_id = 13
                "))

        If dt.Rows.Count > 0 Then
            gcMultipleEntryGrade.DataSource = dt
            gvMultipleEntryGrade.BestFitColumns()
            gvMultipleEntryGrade.OptionsBehavior.Editable = True
            gvMultipleEntryGrade.Columns("id").Visible = False
        End If

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCategory.SelectedItem, DataRowView)
            Me.txtGradePerioID.Text = drv.Item("id").ToString
            txtGrade.Focus()
        Catch ex As Exception
            Me.txtGradePerioID.Text = ""
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If MultipleEntryGrading() = False Then

            If txtGradePerioID.Text.Length = 0 Then
                MsgBox("Please select grading period.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtGrade.Text.Length = 0 Then
                MsgBox("Please Enter Grade.", MsgBoxStyle.Critical)
                Exit Sub
            End If

        End If

        saveGrades()
    End Sub

    Dim dt_MultipleEntryGrade As New DataTable
    Private Function MultipleEntryGrading() As Boolean
        Dim grade As String = ""
        Dim row As Integer = 0

        Dim dt As DataTable = gcMultipleEntryGrade.DataSource
        For Each rows As DataRow In dt.Rows
            grade += rows.Item("GRADE").ToString
        Next

        dt_MultipleEntryGrade = dt

        If grade = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub saveGrades()

        Dim SQLIN As String = ""

        If MultipleEntryGrading() = True Then

            For Each rows As DataRow In dt_MultipleEntryGrade.Rows

                SQLIN = "INSERT INTO student_grade(students_grading_id,students_subject_id,grades,remarks)"
                SQLIN += " VALUES("
                SQLIN += String.Format("'{0}', '{1}',", rows.Item("id").ToString, txtStudentSubjectID.Text)
                SQLIN += String.Format("'{0}', '{1}'", rows.Item("GRADE").ToString, rows.Item("REMARKS").ToString)
                SQLIN += " )"

                clsDBConn.Execute(SQLIN)

            Next
            MsgBox("Grades has been added.")
            displayGrades()
            clearFields()

        Else

            SQLIN = "INSERT INTO student_grade(students_grading_id,students_subject_id,grades,remarks)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", txtGradePerioID.Text, txtStudentSubjectID.Text)
            SQLIN += String.Format("'{0}', '{1}'", txtGrade.Text, txtRemarks.Text)
            SQLIN += " )"

            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Grades has been added.")
                displayGrades()
                clearFields()
            End If
        End If



    End Sub

    Private Sub clearFields()
        txtRemarks.Text = ""
        cmbCategory.SelectedIndex = -1
        cmbCategory.Text = ""
        txtGradePerioID.Text = ""
        txtGrade.Text = ""
        btnEdit.Visible = False
    End Sub



    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim students_grading_id As String = tdbViewer.Columns.Item("students_grading_id").Value
                Dim students_subject_id As String = tdbViewer.Columns.Item("students_subject_id").Value

                Dim grades As String = tdbViewer.Columns.Item("grades").Value
                Dim remarks As String = tdbViewer.Columns.Item("remarks").Value


                cmbCategory.SelectedValue = CInt(students_grading_id)
                txtGrade.Text = grades
                txtRemarks.Text = remarks
                btnEdit.Visible = True


            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtGradePerioID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGradePerioID.TextChanged
        If txtGradePerioID.Text.Length > 0 Then
            txtGrade.Text = ""
            txtRemarks.Text = ""
            btnEdit.Visible = False
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim SQLUP As String = "UPDATE student_grade SET"
        SQLUP += String.Format(" grades='{0}', remarks='{1}'", txtGrade.Text, txtRemarks.Text)

        SQLUP += String.Format(" WHERE students_grading_id='{0}' AND  students_subject_id='{1}'", txtGradePerioID.Text, txtStudentSubjectID.Text)

        If clsDBConn.Execute(SQLUP) Then
            MsgBox("Grade has been modified.")
            displayGrades()
            clearFields()
        End If
    End Sub

    Private Sub computeAverage()
        Dim total As Double = 0

        For nCtr As Integer = 0 To GRADES.Rows.Count - 1
            Dim gradeStr As String = GRADES.Rows(nCtr).Item(3).ToString
            Dim weight As String = GRADES.Rows(nCtr).Item(5).ToString



            Try
                total += CDbl(gradeStr) * (weight / 100)
            Catch ex As Exception

            End Try

        Next

        txtFinalGrades.Text = Format(total, "#.00")
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If MessageBox.Show("Are you sure you want to SET FINAL GRADE?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLUP As String = "UPDATE students_subjects SET finalgrade='" & txtFinalGrades.Text & "'"
            SQLUP += "  WHERE id='" & txtStudentSubjectID.Text & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Final Grade has been Set on this subject.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub displayFinalGrade()
        Dim SQLEX As String = "SELECT finalgrade FROM students_subjects WHERE id='" & txtStudentSubjectID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                txtGivenFinalGrades.Text = MeData.Rows(0).Item("finalgrade").ToString
            Catch ex As Exception
                txtGivenFinalGrades.Text = "None"
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX2_Click_1(sender As Object, e As EventArgs) Handles ButtonX2.Click

        If txtStudentSubjectID.Text.Length > 0 Then
            'Update Student Subject
            DataSource(String.Format("UPDATE `students_subjects` SET  `re_exam` = '" & txtGradeReExam.Text & "' WHERE `id` = '" & txtStudentSubjectID.Text & "';"))
            MsgBox("Re-Exam has been Added")
        End If

    End Sub

    Private Sub txtFinalGrades_TextChanged(sender As Object, e As EventArgs) Handles txtFinalGrades.TextChanged

    End Sub
End Class