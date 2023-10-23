Imports System.Threading
Imports System.ComponentModel

Public Class fmaStudentsGradeMainForm

    Dim WithEvents masterFeeSetup As fmaFeesMasterSetupForm
    Dim WithEvents detailFeeSetup As fmaFeesDetailListForm

    Dim ROWINDEX As Integer = 0


    Private Sub fmaFeesMasterListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        displayCourse()
        displayBatches()
        dgvFEES.Rows.Clear()
        lblMessage.Visible = False

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


    End Sub


    Private Sub displayBatches()

        Dim SQLEX As String = ""
        If AuthUserType = "SUPERUSER" Then

            SQLEX = "SELECT batches.id, name FROM batches"
            SQLEX += " INNER JOIN courses"
            SQLEX += " ON (batches.course_id = courses.id)"
            SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
            SQLEX += " AND course_id='" & Me.txtCourseID.Text & "'"

        Else

            SQLEX = "SELECT
                    batches.id,
                    batches.`name`

                    FROM
                    batches
                    INNER JOIN courses ON (batches.course_id = courses.id)
                    INNER JOIN students_subjects ON batches.id = students_subjects.batch_id
                    INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
                    INNER JOIN employees ON subject_class_schedule.employee_id = employees.id
                    WHERE
                    batches.is_deleted = 0 AND
                    batches.is_active = 1 AND
                    batches.course_id = '" & Me.txtCourseID.Text & "' AND
                    employees.user_id = '" & LoginUserID & "'
"
        End If

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"
        cmbBatch.Text = ""
        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""


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

    Private Sub getMasterFees()

        Dim TOTAL_FEES As Double = 0
        dgvFEES.Rows.Clear()

        Dim SQLEX As String = "SELECT subject_class_schedule.SysPK_Item, subjects.code 'subjcode', subjects.name 'subjname'"
        SQLEX += " , subject_class_schedule.code 'schedcode',subject_class_schedule.name 'schedname',class_time "
        SQLEX += " , employee_name, subject_id"
        SQLEX += " FROM subject_class_schedule"
        SQLEX += " INNER JOIN subjects"
        SQLEX += " ON subject_class_schedule.subject_id = subjects.id"
        SQLEX += " WHERE batch_id = '" & txtBatchID.Text & "'"
        If EMPLOYEE_ID <> "" Then
            SQLEX += " AND employee_id = '" & EMPLOYEE_ID & "'"

        End If


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            For cnt As Integer = 0 To MeData.Rows.Count - 1
                Dim SysPK_Item As String = MeData.Rows(cnt).Item("SysPK_Item").ToString
                Dim subjcode As String = MeData.Rows(cnt).Item("subjcode").ToString
                Dim subjname As String = MeData.Rows(cnt).Item("subjname").ToString
                Dim schedcode As String = MeData.Rows(cnt).Item("schedcode").ToString
                Dim schedname As String = MeData.Rows(cnt).Item("schedname").ToString
                Dim class_time As String = MeData.Rows(cnt).Item("class_time").ToString
                Dim employee_name As String = MeData.Rows(cnt).Item("employee_name").ToString


                dgvFEES.Rows.Add(New String() {SysPK_Item, subjcode, subjname, schedcode, schedname, class_time, employee_name})


            Next
        Else
        End If

        If EMPLOYEE_ID <> "" Then
            dgvFEES.Columns(6).Visible = False
        Else
            dgvFEES.Columns(6).Visible = True
        End If

    End Sub

    Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
        If txtBatchID.Text.Length > 0 Then
            pbxSearch.Visible = True
            'getMasterFees()
            Timer1.Enabled = True
            rollingSpinner.Visible = True
            stillSpinner.Visible = False
            lblStatus.Text = "Searching.."

            enAbleGradeEditing()
        Else
            Timer1.Enabled = False
            lblTimer.Text = "0"
            pbxSearch.Visible = False
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
            pbxSearch.Visible = False
            lblStatus.Text = ""
            lblMessage.Visible = False
            isAllowedEdit.Text = "0"
        End If
    End Sub

    'Private Sub pbxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxSearch.Click
    '    getMasterFees()
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tick As Integer = CInt(lblTimer.Text)

        lblTimer.Text = tick + 1

        If tick = 1 Then
            Timer1.Enabled = False
            lblTimer.Text = "0"
            getMasterFees()
            lblStatus.Text = "Done."
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
            pbxSearch.Visible = False

        End If
    End Sub

    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        dgvFEES.Rows.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub masterFeeSetup_FeeAdded() Handles masterFeeSetup.FeeAdded
        getMasterFees()
    End Sub

    'Private Sub dgvFEES_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFEES.CellContentClick
    '    ROWINDEX = e.ColumnIndex

    '    If e.ColumnIndex = 0 Then

    '        Dim colIndex As Integer = e.ColumnIndex
    '        Dim rowIndex As Integer = e.RowIndex

    '        Dim catID As String = dgvFEES.Item(4, rowIndex).Value
    '        Dim name As String = dgvFEES.Item(0, rowIndex).Value
    '        Dim description As String = dgvFEES.Item(5, rowIndex).Value


    '        If masterFeeSetup Is Nothing Then
    '            masterFeeSetup = New fmaFeesMasterSetupForm
    '            masterFeeSetup.BATCH_ID = Me.txtBatchID.Text
    '            masterFeeSetup.txtCatID.Text = catID
    '            masterFeeSetup.txt_name.Text = name
    '            masterFeeSetup.txtDescr.Text = description
    '            masterFeeSetup.btnSave.Text = "Modify"
    '            masterFeeSetup.btnDelete.Visible = True
    '            masterFeeSetup.ShowDialog(Me)
    '        Else
    '            masterFeeSetup = Nothing
    '            masterFeeSetup = New fmaFeesMasterSetupForm
    '            masterFeeSetup.BATCH_ID = Me.txtBatchID.Text
    '            masterFeeSetup.txtCatID.Text = catID
    '            masterFeeSetup.txt_name.Text = name
    '            masterFeeSetup.txtDescr.Text = description
    '            masterFeeSetup.btnSave.Text = "Modify"
    '            masterFeeSetup.btnDelete.Visible = True
    '            masterFeeSetup.ShowDialog(Me)
    '        End If

    '    End If

    'End Sub

    Private Sub dgvFEES_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvFEES.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ROWINDEX = e.RowIndex
            If e.ColumnIndex = 0 Then
                If dgvFEES.Item(0, ROWINDEX).Value.ToString = "" Then
                    Exit Sub

                End If

                Dim point1 As Point

                If e.Button = Windows.Forms.MouseButtons.Right Then

                    point1 = Windows.Forms.Cursor.Position

                    Dim pt As Point = dgvFEES.PointToClient(point1)
                    CMenuStripOperations.Show(dgvFEES, pt)
                End If
            End If
        End If
    End Sub

    'Private Sub dgvFEES_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvFEES.MouseUp



    '    Dim point1 As Point

    '    If e.Button = Windows.Forms.MouseButtons.Right Then

    '        point1 = Windows.Forms.Cursor.Position

    '        Dim pt As Point = dgvFEES.PointToClient(point1)
    '        CMenuStripOperations.Show(dgvFEES, pt)
    '    End If
    'End Sub

    Private Sub ViewAssessmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAssessmentToolStripMenuItem.Click
        Dim catID As String = dgvFEES.Item(4, ROWINDEX).Value
        Dim name As String = dgvFEES.Item(0, ROWINDEX).Value
        Dim description As String = dgvFEES.Item(5, ROWINDEX).Value


        If masterFeeSetup Is Nothing Then
            masterFeeSetup = New fmaFeesMasterSetupForm
            masterFeeSetup.BATCH_ID = Me.txtBatchID.Text
            masterFeeSetup.txtCatID.Text = catID
            masterFeeSetup.txt_name.Text = name
            masterFeeSetup.txtDescr.Text = description
            masterFeeSetup.btnSave.Text = "Modify"
            masterFeeSetup.btnDelete.Visible = True
            masterFeeSetup.ShowDialog(Me)
        Else
            masterFeeSetup = Nothing
            masterFeeSetup = New fmaFeesMasterSetupForm
            masterFeeSetup.BATCH_ID = Me.txtBatchID.Text
            masterFeeSetup.txtCatID.Text = catID
            masterFeeSetup.txt_name.Text = name
            masterFeeSetup.txtDescr.Text = description
            masterFeeSetup.btnSave.Text = "Modify"
            masterFeeSetup.btnDelete.Visible = True
            masterFeeSetup.ShowDialog(Me)
        End If
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        Dim catID As String = dgvFEES.Item(4, ROWINDEX).Value
        Dim name As String = dgvFEES.Item(0, ROWINDEX).Value
        Dim description As String = dgvFEES.Item(5, ROWINDEX).Value

        If detailFeeSetup Is Nothing Then
            detailFeeSetup = New fmaFeesDetailListForm
            detailFeeSetup.txtCatID.Text = catID
            detailFeeSetup.txt_name.Text = name
            detailFeeSetup.txtDescr.Text = description

            detailFeeSetup.ShowDialog(Me)
        Else
            detailFeeSetup = Nothing
            detailFeeSetup = New fmaFeesDetailListForm
            detailFeeSetup.txtCatID.Text = catID
            detailFeeSetup.txt_name.Text = name
            detailFeeSetup.txtDescr.Text = description

            detailFeeSetup.ShowDialog(Me)
        End If
    End Sub

    Private Sub detailFeeSetup_WINCLOSING() Handles detailFeeSetup.WINCLOSING
        getMasterFees()
    End Sub


    Private Sub btnDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Function Under Modification.")
    End Sub


    Private Sub dgvFEES_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFEES.CellContentClick


        If e.ColumnIndex = 4 Then

            If isAllowedEdit.Text = "0" Then
                MsgBox("Cannot Edit Grades. Pls Contact System Administrator", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim ROWINDEX As Integer = e.RowIndex
            Dim COLINDEX As Integer = e.ColumnIndex
            If ROWINDEX < 0 Then
                Exit Sub
            End If

            Dim instructor As String = dgvFEES.Item(6, ROWINDEX).Value
            Dim subj_name = dgvFEES.Item(2, ROWINDEX).Value & " | " & dgvFEES.Item(4, ROWINDEX).Value
            Dim subject_class_schedule_id = dgvFEES.Item(0, ROWINDEX).Value
            Dim subject_id As String = dgvFEES.Item(0, ROWINDEX).Value

            With fmaStudentsGradeStList
                .Text = "STUDENTS LIST UNDER : " & instructor
                .txtCoursename.Text = Me.cmbCourse.Text
                .txtBatchName.Text = Me.cmbBatch.Text
                .txtSubject.Text = subj_name
                .txtSubjectID.Text = subject_id
            End With

            '   fmaStudentsGradeStList.ShowDialog(Me)
            fmaStudentsGradeStList.ShowDialog()
        End If
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
                lblMessage.Visible = False
                isAllowedEdit.Text = "1"
            Else
                Console.WriteLine("not between")
                lblMessage.Visible = True
                lblMessage.Text = "CANNOT MODIFY OR EDIT GRADES. SCHEDULE OF GRADE DISTRIUTION FOR THIS BATCH HAS EXPIRED. PLS CONTACT SYSTEM ADMINISTRATOR."
                isAllowedEdit.Text = "0"
            End If

        Else
            lblMessage.Visible = True
            lblMessage.Text = "CANNOT MODIFY OR EDIT GRADES. CHECK SCHEDULE OF GRADE DISTRIUTION FOR THIS BATCH. PLS CONTACT SYSTEM ADMINISTRATOR."
            isAllowedEdit.Text = "0"
        End If



        'Dim str As String = "srt_inlbp_20130517"

        'Dim dTableDate As Date =
        '    Date.ParseExact(str.Substring(str.Length - 8), "yyyyMMdd", Nothing)

        'Dim dFromDate As New DateTime(2013, 5, 17)
        'Dim dToDate As New DateTime(2013, 6, 17)

        'If ((dTableDate >= dFromDate) And (dTableDate <= dToDate)) Then
        '    Console.WriteLine("between")
        'Else
        '    Console.WriteLine("not between")
        'End If
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