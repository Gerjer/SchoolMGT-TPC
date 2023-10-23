
Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MySql.Data.MySqlClient

Public Class fmaAddSubjectForm

    Public Event SUBJECTADDED()

    Public StudentSubjectSysPK As String
    Private Sub fmaAddSubjectForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '    cmbBatch.Enabled = False
        displayCourse()
        displayBatches()

        If StudentSubjectSysPK <> "" Then
            '       getStudentSubject(StudentSubjectSysPK)
        End If

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

    Private Sub getStudentSubject(studentSubjectSysPK As String)
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	subjects.id,
	`subjects`.`code`,
	`subjects`.`name`,
	subjects.credit_hours,
	subjects.amount,
	batches.id 'batchid',
	batches.NAME 'batchname',
	'True' AS 'Check',
	courses.course_name
FROM
	batches
	INNER JOIN courses ON ( batches.course_id = courses.id )
	INNER JOIN subjects ON ( subjects.batch_id = batches.id ) 
	INNER JOIN students_subjects ON(students_subjects.batch_id =batches.id AND  students_subjects.subject_id = subjects.id)
WHERE
	students_subjects.subject_class_schedule_id IN(" & studentSubjectSysPK & ")
	AND subjects.is_deleted <> '1' 
	AND elective_group_id IS NOT NULL 
"))
        creatMultipleEntry(dt)
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


    End Sub


    Private Sub displayBatches()
        Dim SQLEX As String = "SELECT batches.id, name FROM batches"
        SQLEX += " INNER JOIN courses"
        SQLEX += " ON (batches.course_id = courses.id)"
        SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
        SQLEX += " AND course_name='" & Me.cmbCourse.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"

        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        If txtCourseID.Text.Length > 0 Then
            If cmbBatch.Enabled = False Then
                cmbBatch.Enabled = True
            End If
            '        displayBatches()
        Else
            cmbBatch.Enabled = False
        End If
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
            displayBatches()
        Catch ex As Exception
            Me.txtCourseID.Text = ""
        End Try
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbBatch.SelectedItem, DataRowView)
            Me.txtBatchID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtBatchID.Text = ""
        End Try
    End Sub


    Private Sub displaySubject()
        Dim SQLEX As String = "SELECT subjects.id, subjects.code, subjects.name"
        SQLEX += " , subjects.credit_hours, subjects.amount,batches.id 'batchid',batches.name 'batchname','False' as 'Check',courses.course_name"
        SQLEX += " FROM batches"
        SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
        SQLEX += " INNER JOIN subjects ON (subjects.batch_id = batches.id)"
        SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"
        SQLEX += " AND subjects.is_deleted <> '1' AND elective_group_id IS NOT NULL"
        SQLEX += " AND batches.id='" & txtBatchID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbSubject.DataSource = MeData

        cmbSubject.ValueMember = "id"
        cmbSubject.DisplayMember = "name"

        cmbSubject.SelectedIndex = -1
        cmbSubject.Text = ""

        creatMultipleEntry(MeData)

    End Sub

    Private Sub creatMultipleEntry(dt_subjectlist As DataTable)

        '     gcSubjectMutipleEntry.DataSource = Nothing

        If dt_subjectlist.Rows.Count > 0 Then
            'Check if list is empty


            If gvSubjectMutipleEntry.RowCount > 0 Then

                Dim dt_New_subjectlist As DataTable = gcSubjectMutipleEntry.DataSource
                For Each rows As DataRow In dt_subjectlist.Rows

                    dt_New_subjectlist.Rows.Add(rows.Item("id"), rows.Item("CODE"), rows.Item("NAME"), rows.Item("credit_hours"),
                     rows.Item("amount"), rows.Item("batchid"), rows.Item("batchname"), rows.Item("Check"), rows.Item("course_name"))

                Next
                gcSubjectMutipleEntry.DataSource = dt_New_subjectlist
            Else
                gcSubjectMutipleEntry.DataSource = dt_subjectlist
            End If


        End If


    End Sub

    Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
        If txtBatchID.Text.Length > 0 Then
            If cmbSubject.Enabled = False Then
                cmbSubject.Enabled = True
                '            displaySubject()
            End If
        Else
            cmbSubject.Enabled = False
        End If
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbSubject.SelectedItem, DataRowView)
            Me.txtSubjID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtSubjID.Text = ""
        End Try
    End Sub

    Private Sub txtSubjID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubjID.TextChanged
        If txtSubjID.Text.Length <> 0 Then
            Dim SQLEX As String = "SELECT"
            SQLEX += " subjects.name"
            SQLEX += " , subjects.credit_hours"
            SQLEX += " , batches.school_year"
            SQLEX += " , batches.semester"
            SQLEX += " , subjects.no_exams"
            SQLEX += " FROM subjects"
            SQLEX += " INNER JOIN batches "
            SQLEX += " ON (subjects.batch_id = batches.id)"
            SQLEX += " WHERE subjects.id = '" & txtSubjID.Text & "'"

            Dim MeData As DataTable

            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then
                Try
                    txtDescr.Text = MeData.Rows(0).Item("name").ToString()
                    txtUnits.Text = MeData.Rows(0).Item("credit_hours").ToString()
                    txtSY.Text = MeData.Rows(0).Item("school_year").ToString()
                    txtSem.Text = MeData.Rows(0).Item("semester").ToString()

                    Dim type As Integer = 0


                    type = If(MeData.Rows(0).Item("no_exams").ToString() = "False", 0, 1)


                    If type = 0 Then
                        txtType.Text = "Lecture"
                    Else
                        txtType.Text = "Laboratory"
                    End If
                Catch ex As Exception
                    txtDescr.Text = ""
                    txtUnits.Text = ""
                    txtSY.Text = ""
                    txtSem.Text = ""
                    txtType.Text = ""
                End Try
            Else
                txtDescr.Text = ""
                txtUnits.Text = ""
                txtSY.Text = ""
                txtSem.Text = ""
                txtType.Text = ""
            End If

            SQLEX = "SELECT id FROM students_subjects"
            SQLEX += " WHERE student_id ='" & Me.txtStudentID.Text & "'"
            SQLEX += " AND subject_id ='" & Me.txtSubjID.Text & "'"

            MeData = Nothing
            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then
                '           btnAdd.Enabled = False
            Else
                btnAdd.Enabled = True
            End If




        Else
            txtDescr.Text = ""
            txtUnits.Text = ""
            txtSY.Text = ""
            txtSem.Text = ""
            txtType.Text = ""
            '      btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Availability = "0" Then
            MsgBox("Adding to this Subject is Invalid")
            Exit Sub
        End If

        If MessageBox.Show("Are sure you want to Add Subject to this student?", "Please Verify !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            If XtraTabControl1.SelectedTabPage.Text = "Multiple Entry" Then

                If gvSubjectMutipleEntry.RowCount > 0 Then

                    For Each row As DataRow In CType(gcSubjectMutipleEntry.DataSource, DataTable).Rows
                        If row("Check") = "True" Then

                            Dim SQLIN As String = "INSERT INTO students_subjects(student_id,subject_id,batch_id)"
                            SQLIN += String.Format("VALUES('{0}', '{1}',", Me.txtStudentID.Text, row("id"))
                            SQLIN += String.Format("'{0}')", Me.txtBatchID.Text)
                            clsDBConn.Execute(SQLIN)

                        End If
                    Next

                    MsgBox("Subject has been added to Student")
                    btnAdd.Enabled = False
                    RaiseEvent SUBJECTADDED()

                End If


            Else

                Dim SQLIN As String = "INSERT INTO students_subjects(student_id,subject_id,batch_id)"
                SQLIN += String.Format("VALUES('{0}', '{1}',", Me.txtStudentID.Text, Me.txtSubjID.Text)
                SQLIN += String.Format("'{0}')", Me.txtBatchID.Text)

                If clsDBConn.Execute(SQLIN) Then

                    MsgBox("Subject has been added to Student")
                    btnAdd.Enabled = False
                    RaiseEvent SUBJECTADDED()
                End If


            End If


        End If
    End Sub

    Private Sub cmbBatch_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBatch.SelectionChangeCommitted
        Me.txtBatchID.Text = cmbBatch.SelectedValue
        displaySubject()
    End Sub

    'Private Sub XtraTabPage2_TabIndexChanged(sender As Object, e As EventArgs) Handles XtraTabPage2.TabIndexChanged

    '    If XtraTabControl1.SelectedTabPage.Text = "Multiple Entry" Then
    '        btnAdd.Enabled = True
    '    End If

    'End Sub

    Private Sub gvSubjectMutipleEntry_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvSubjectMutipleEntry.RowCellClick

        Dim view As GridView = DirectCast(sender, GridView)
        Dim SubjectID As Integer = gvSubjectMutipleEntry.GetFocusedRowCellValue("id")
        Dim BatchID As Integer = gvSubjectMutipleEntry.GetFocusedRowCellValue("batchid")

        If SubjectISClose(SubjectID, BatchID) = True Then
            MessageBoxEx.Show("This Subject is Already Close.....", "SUBJECT BEYOND THE LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            displaySubject()
            Exit Sub
        Else
            If SubjectAlreadyExist(txtStudentID.Text, SubjectID, BatchID) = True Then
                MsgBox("Subject is already added in the list", MsgBoxStyle.Information, "RECORD FOUND")
                gvSubjectMutipleEntry.SetFocusedRowCellValue("Check", "False")

            Else
                btnAdd.Enabled = True
            End If
        End If

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If e.Page.Text = "Multiple Entry" Then
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub cmbSubject_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubject.SelectionChangeCommitted

        checkSubject()

    End Sub

    Private Sub checkSubject()

        SubjectAlreadyExist(txtStudentID.Text, cmbSubject.SelectedValue, cmbBatch.SelectedValue)

        'Check Availability Subject

        If SubjectISClose(cmbSubject.SelectedValue, cmbBatch.SelectedValue) = True Then
            MessageBoxEx.Show("This Subject is Already Close.....", "SUBJECT BEYOND THE LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            displaySubject()
            Exit Sub
        End If

    End Sub

    Dim Availability As String = ""
    Private Function SubjectISClose(subjectID As Object, batchID As Object) As Boolean
        Availability = DataObject(String.Format("SELECT DISTINCT
                             IFNULL(
		                        limit_subject - (
		                        SELECT
			                        COUNT( students_subjects.subject_id ) 
		                        FROM
			                        students_subjects 
		                        WHERE
			                        students_subjects.subject_id = subjects.id 
			                        AND students_subjects.batch_id = batches.id 
		                        ORDER BY
			                        students_subjects.subject_id ASC 
		                        ),
		                        0 
	                        ) 'availability' 
                        FROM
	                        batches
	                        INNER JOIN courses ON ( batches.course_id = courses.id )
	                        RIGHT JOIN subjects ON ( subjects.batch_id = batches.id )
	                        LEFT JOIN subject_class_schedule ON subject_class_schedule.subject_id = subjects.id 
                        WHERE
	                         subjects.is_deleted <> '1'  and subjects.id = '" & subjectID & "'
	                        AND batches.id = '" & batchID & "'"))

        If Availability = "0" Or Availability = " " Or Availability.Contains("-") Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Function SubjectAlreadyExist(studentID As String, subjectID As Integer, batchID As Integer) As Boolean
        Dim exist As Integer = 0
        exist = DataObject(String.Format("SELECT
                students_subjects.id
                FROM
                students_subjects
                WHERE
                students_subjects.student_id = '" & studentID & "' AND
                students_subjects.subject_id = '" & subjectID & "'AND
                students_subjects.batch_id = '" & batchID & "'
                "))
        If exist > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmbyearbatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyearbatch.SelectedIndexChanged
        Try
            Dim SQLEX As String = "SELECT batches.id, name FROM batches"
            SQLEX += " INNER JOIN courses"
            SQLEX += " ON (batches.course_id = courses.id)"
            SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
            SQLEX += " AND course_id='" & txtCourseID.Text & "' AND batches.school_year = '" & cmbyearbatch.Text & "' "

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

    'Private Sub gvSubjectMutipleEntry_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvSubjectMutipleEntry.CustomDrawCell

    '    Dim CheckValue As String = ""
    '    If e.Column.FieldName = "Check" Then
    '        CheckValue = gvSubjectMutipleEntry.GetRowCellValue(e.RowHandle, "Check")
    '        If CheckValue = "True" Then
    '            gvSubjectMutipleEntry.SetRowCellValue(e.Handled, "ALL", True)
    '        Else
    '            gvSubjectMutipleEntry.SetRowCellValue(e.Handled, "ALL", False)
    '        End If
    '        ' gridView2.SetRowCellValue(e.RowHandle, "PILIH", true)

    '    End If
    'End Sub

    'Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged

    '    Dim s = e.ToString
    '    Dim CheckEdit As DevExpress.XtraEditors.CheckEdit = DirectCast(sender, DevExpress.XtraEditors.CheckEdit)
    '    If CheckEdit.Checked = True Then
    '        '       gvSubjectMutipleEntry.FocusedRowHandle = True
    '        CheckEdit.Checked = True
    '    Else
    '        CheckEdit.Checked = False
    '        '      gvSubjectMutipleEntry.FocusedRowHandle = False
    '    End If

    'End Sub
End Class