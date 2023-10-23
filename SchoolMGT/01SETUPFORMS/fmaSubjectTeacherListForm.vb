Imports System.Threading
Imports System.ComponentModel
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Xls
Imports System.IO

Public Class fmaSubjectTeacherListForm

    Dim WithEvents newSubject As fmaSubjectaSetupForm

    Private m_AsyncWorker As New BackgroundWorker()

    Private Sub fmaStudentListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblStatus.Text = "Waiting ..."

        displayCourse()
        displayBatches()
    End Sub

    Private SQLCMD As String = ""

    Public Event REPORTSTARTS()
    Public Event REPORTCLOSED()

    Public DirectPrinting As Boolean = False
    Private WithEvents MeAR As ActiveReport3

    Public Property AttachReport(ByVal SQLstring As String, ByVal Title As String)
        Get
            Return MeAR
        End Get
        Set(ByVal value)
            MeAR = value

            If Title.Trim <> "" Then
                Me.Text = Title
            End If

            If SQLstring.Trim <> "" Then
                Me.SQLCMD = SQLstring
                Me.WindowState = FormWindowState.Maximized
                MeViewer.Document.Printer.PrinterName = ""
                MeViewer.Document = MeAR.Document

                MeAR.DataSource = clsDBConn.ExecQuery(SQLstring)
                MeAR.Run(True)

                MeViewer.ReportViewer.Zoom = -1
            End If
        End Set
    End Property



    Public Sub Print()
        If DirectPrinting Then
            MeAR.Document.Print(False, True, True)
        End If
    End Sub

    Private Sub MeAR_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MeAR.ReportEnd
        RaiseEvent REPORTSTARTS()
    End Sub

    Private Sub fzzReportViewerForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent REPORTCLOSED()
    End Sub


    Public Sub exportPDF()
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text & ".pdf"

        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        Process.Start(FileName)
    End Sub

    Public Sub exportPDF(ByVal fileName As String)


        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        fileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, fileName)
        ExportPDF = Nothing

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

        'tdbViewer.DataSource = Nothing
    End Sub


    Private Sub displayBatches()
        Dim SQLEX As String = "SELECT batches.id, concat(name,'-',school_year) 'name' FROM batches"
        SQLEX += " INNER JOIN courses"
        SQLEX += " ON (batches.course_id = courses.id)"
        SQLEX += " WHERE batches.is_deleted =0 AND batches.is_active=1"
        SQLEX += " AND course_id='" & Me.txtCourseID.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"
        cmbBatch.Text = ""
        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""

        txtElectives.Text = ""
        'tdbViewer.Caption = "SUBJECT LIST"
        txtElectiveID.Text = ""
    End Sub



    'Private Sub displayFilterCategory()
    '    'Me.tdbViewer.DataSource = Nothing

    '    Dim SQLEX As String = "SELECT DISTINCT(subjects.id) 'subjid', subjects.code, subjects.name"
    '    'SQLEX += " ,subjects.ccid 'ccid',subjects.creditdistribution 'ccd'"
    '    SQLEX += " , subjects.credit_hours, subjects.amount,batches.id as 'batchid',batches.name 'batchname'"
    '    SQLEX += " , CASE WHEN subjects.no_exams = '0' THEN 'LECTURE'"
    '    SQLEX += " ELSE 'LABORATORY'"
    '    SQLEX += " End 'no_exams'"
    '    SQLEX += " , CASE WHEN subjects.elective_group_id IS NOT NULL THEN 'OPTIONAL'"
    '    SQLEX += " ELSE 'ELECTIVE'"
    '    SQLEX += " End 'elective'"

    '    'SQLEX += " , subject_class_schedule.employee_name 'EMPNAME', subject_class_schedule.name 'schedname'"
    '    SQLEX += " FROM batches"
    '    SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
    '    SQLEX += " RIGHT JOIN subjects ON (subjects.batch_id = batches.id)"
    '    SQLEX += " LEFT JOIN subject_class_schedule"
    '    SQLEX += " ON subject_class_schedule.subject_id = subjects.id"
    '    SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"
    '    SQLEX += " AND subjects.is_deleted <> '1'"

    '    If txtBatchID.Text <> "" Then
    '        SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
    '    End If

    '    Dim MeData As DataTable
    '    MeData = clsDBConn.ExecQuery(SQLEX)

    '    If MeData.Rows.Count > 0 Then
    '        Me.tdbViewer.DataSource = MeData
    '        Me.tdbViewer.Rebind(True)

    '        Try
    '            With tdbViewer.Splits(0)
    '                .DisplayColumns("subjid").Visible = False

    '                .DisplayColumns("code").DataColumn.Caption = "CODE"
    '                .DisplayColumns("code").Width = 200
    '                .DisplayColumns("code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

    '                .DisplayColumns("name").DataColumn.Caption = "DESCRIPTION"
    '                .DisplayColumns("name").Width = 450
    '                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

    '                '.DisplayColumns("ccid").Visible = False
    '                '.DisplayColumns("ccd").Visible = False

    '                .DisplayColumns("credit_hours").DataColumn.Caption = "UNIT/S"
    '                .DisplayColumns("credit_hours").Width = 100
    '                .DisplayColumns("credit_hours").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("credit_hours").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

    '                .DisplayColumns("amount").DataColumn.Caption = "RATE/UNIT"
    '                .DisplayColumns("amount").DataColumn.NumberFormat = "#,##0.00"
    '                .DisplayColumns("amount").Width = 150
    '                .DisplayColumns("amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

    '                .DisplayColumns("batchid").Visible = False
    '                .DisplayColumns("batchname").Visible = False


    '                .DisplayColumns("no_exams").DataColumn.Caption = "LEC/LAB"
    '                .DisplayColumns("no_exams").Width = 100
    '                .DisplayColumns("no_exams").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("no_exams").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
    '                'elective_group_id
    '                .DisplayColumns("elective").DataColumn.Caption = "TYPE"
    '                .DisplayColumns("elective").Width = 100
    '                .DisplayColumns("elective").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                .DisplayColumns("elective").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near



    '                '.DisplayColumns("EMPNAME").DataColumn.Caption = "INSTRUCTOR"
    '                '.DisplayColumns("EMPNAME").Width = 150
    '                '.DisplayColumns("EMPNAME").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                '.DisplayColumns("EMPNAME").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

    '                '.DisplayColumns("schedname").DataColumn.Caption = "SCHEDULE"
    '                '.DisplayColumns("schedname").Width = 200
    '                '.DisplayColumns("schedname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    '                '.DisplayColumns("schedname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


    '            End With
    '        Catch ex As Exception

    '        End Try
    '    Else
    '        tdbViewer.DataSource = Nothing
    '    End If


    'End Sub


    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
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

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click

        Cursor = Cursors.WaitCursor

        If RadioButton1.Checked Then
            Dim SQLEX As String = "SELECT DISTINCT(subjects.id) 'subjid', concat('(',subjects.code,')') 'subjcode', subjects.name 'subjname' , subjects.credit_hours,"
            SQLEX += " CASE WHEN subjects.no_exams = '0' THEN 'LECTURE' ELSE 'LABORATORY' END 'no_exams' , "
            SQLEX += " CASE WHEN subjects.elective_group_id IS NOT NULL THEN 'OPTIONAL' ELSE 'ELECTIVE' END 'elective',"
            SQLEX += " subject_class_schedule.SysPK_Item, subject_class_schedule.employee_id,"
            SQLEX += " subject_class_schedule.employee_name, subject_class_schedule.name 'schedname', subject_class_schedule.room,"
            SQLEX += " students_subjects.student_id, person.last_name, CONCAT(', '  , person.first_name) 'pname' , person.middle_name, students.std_number, person.gender"
            SQLEX += " FROM batches INNER JOIN courses ON (batches.course_id = courses.id) "
            SQLEX += " RIGHT JOIN subjects ON (subjects.batch_id = batches.id) "
            SQLEX += " LEFT JOIN subject_class_schedule ON subject_class_schedule.subject_id = subjects.id "
            SQLEX += " INNER JOIN students_subjects ON (subject_class_schedule.SysPK_Item = students_subjects.subject_class_schedule_id)"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN person ON (students.person_id = person.person_id)"

            SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"
            SQLEX += " AND subjects.is_deleted <> '1' and students.is_enrolled ='1'"

            If txtBatchID.Text <> "" Then
                SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
            End If

            SQLEX += " ORDER BY subjid, SysPK_Item, subject_class_schedule.employee_id, person.last_name, person.first_name"



            Me.AttachReport(SQLEX, "SUBJECT-TEACHER SCHEDULES ") = New SubjectTeacherSummaryPerBatch(cmbCourse.Text, cmbBatch.Text)


        ElseIf RadioButton2.Checked Then

            Dim SQLEX As String = "SELECT DISTINCT(subjects.id) 'subjid', subjects.code, subjects.name 'subjname', subjects.credit_hours,"
            SQLEX += " CASE WHEN subjects.no_exams = '0' THEN 'LECTURE' ELSE 'LABORATORY' END 'no_exams' , "
            SQLEX += " CASE WHEN subjects.elective_group_id IS NOT NULL THEN 'OPTIONAL' ELSE 'ELECTIVE' END 'elective',"
            SQLEX += " subject_class_schedule.SysPK_Item, subject_class_schedule.employee_id,"
            SQLEX += " subject_class_schedule.employee_name, subject_class_schedule.name 'schedname', subject_class_schedule.room_id, subject_class_schedule.room,"
            SQLEX += " students_subjects.student_id, person.last_name, CONCAT(', '  , person.first_name, ' ' , person.middle_name) 'pname'"
            SQLEX += " FROM batches INNER JOIN courses ON (batches.course_id = courses.id) "
            SQLEX += " RIGHT JOIN subjects ON (subjects.batch_id = batches.id) "
            SQLEX += " LEFT JOIN subject_class_schedule ON subject_class_schedule.subject_id = subjects.id "
            SQLEX += " INNER JOIN students_subjects ON (subject_class_schedule.SysPK_Item = students_subjects.subject_class_schedule_id)"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN person ON (students.person_id = person.person_id)"

            SQLEX += " WHERE courses.id='" & txtCourseID.Text & "'"

            SQLEX += " AND subjects.is_deleted <> '1'"

            If txtBatchID.Text <> "" Then
                SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
            End If
            SQLEX += " GROUP BY SysPK_Item"
            SQLEX += " ORDER BY room_id, subjid"

            Me.AttachReport(SQLEX, "SUBJECT-ROOM SCHEDULES ") = New SubjectSchedulePerRoom(cmbCourse.Text, cmbBatch.Text)

        ElseIf RadioButton3.Checked Then
            Dim SQLEX As String = "Select DISTINCT(subjects.id) 'subjid', subjects.code, subjects.name 'subjname', subjects.credit_hours, CASE WHEN subjects.no_exams = '0' THEN 'LECTURE' ELSE 'LABORATORY' END 'no_exams' ,  CASE WHEN subjects.elective_group_id IS NOT NULL THEN 'OPTIONAL' ELSE 'ELECTIVE' END 'elective', "
            SQLEX += " subject_class_schedule.SysPK_Item, subject_class_schedule.employee_id, subject_class_schedule.employee_name, subject_class_schedule.name 'schedname', "
            SQLEX += " room_id,"
            SQLEX += " subject_class_schedule.room"
            SQLEX += " FROM batches"
            SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)  "
            SQLEX += " RIGHT JOIN subjects ON (subjects.batch_id = batches.id)  "
            SQLEX += " LEFT JOIN subject_class_schedule ON subject_class_schedule.subject_id = subjects.id  "
            SQLEX += " INNER JOIN students_subjects ON (subject_class_schedule.SysPK_Item = students_subjects.subject_class_schedule_id) "
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id) "
            SQLEX += " INNER JOIN person ON (students.person_id = person.person_id) "
            SQLEX += " WHERE  subjects.is_deleted <> '1'"
            SQLEX += " AND courses.id='" & txtCourseID.Text & "'"
            SQLEX += " AND subjects.is_deleted <> '1'"

            If txtBatchID.Text <> "" Then
                SQLEX += " AND batches.id='" & txtBatchID.Text & "'"
            End If
            SQLEX += " GROUP BY subjid"
            SQLEX += " ORDER BY employee_id, subjid"

            Me.AttachReport(SQLEX, "SUBJECT-TEACHER SCHEDULES ") = New SubjectSchedulePerInstructor()
        End If

        Cursor = Cursors.Default

    End Sub

    Private Sub txtStudentName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSearchCondition.PerformClick()
        End If
    End Sub



    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        lblStatus.Text = "Waiting ..."

        displayCourse()
        displayBatches()



    End Sub


#Region "Asynchronous BackgroundWorker Thread"
    'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    '    ' Notify the worker thread that a cancel has been requested.
    '    ' The cancel will not actually happen until the thread in the 
    '    ' DoWork checks the bwAsync.CancellationPending flag, for this
    '    ' reason we set the label to "Canceling...", because we haven't 
    '    ' actually cancelled yet.
    '    m_AsyncWorker.CancelAsync()
    'End Sub


    Private Sub bwAsync_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        ' The Sender is the BackgroundWorker object we need it to
        ' report progress and check for cancellation.
        Dim bwAsync As BackgroundWorker = TryCast(sender, BackgroundWorker)
        ' Thread.Sleep(1200)


        'displayFilterCategory()
        SetLabel1Text("TRUE")

    End Sub



    Private Sub bwAsync_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        ' The background process is complete. We need to inspect 
        ' our response to see if an error occured, a cancel was 
        ' requested or if we completed succesfully.

        'bnAsync.Text = "Start Long Running Asychronous Process"
        'bnAsync.Enabled = True

        ' Check to see if an error occured in the 
        ' background process.
        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
            Return
        End If

        ' Check to see if the background process was cancelled.
        If e.Cancelled Then
            lblStatus.Text = "Cancelled..."
            stillSpinner.Visible = True
            rollingSpinner.Visible = False
        Else
            ' Everything completed normally.
            ' process the response using e.Result

            lblStatus.Text = "Completed..."
            stillSpinner.Visible = True
            rollingSpinner.Visible = False
        End If
    End Sub

    Private Sub bwAsync_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' This function fires on the UI thread so it's safe to edit
        ' the UI control directly, no funny business with Control.Invoke.
        ' Update the progressBar with the integer supplide to us from the 
        ' ReportProgress() function.  Note, e.UserState is a "tag" property
        ' that can be used to send other information from the BackgroundThread
        ' to the UI thread.

    End Sub


    Delegate Sub SetLabel1TextInvoker(ByVal TextToDisplay As String)

    Public Sub SetLabel1Text(ByVal TextToDisplay As String)
        If rollingSpinner.InvokeRequired Then
            rollingSpinner.Invoke(New SetLabel1TextInvoker(AddressOf SetLabel1Text), New Object() {TextToDisplay})
        Else
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
        End If
    End Sub



#End Region


    'Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If tdbViewer.RowCount > 0 Then
    '        Dim point1 As Point

    '        If e.Button = Windows.Forms.MouseButtons.Right Then

    '            point1 = Windows.Forms.Cursor.Position

    '            Dim pt As Point = tdbViewer.PointToClient(point1)
    '            CMenuStripOperations.Show(tdbViewer, pt)
    '        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
    '            Dim SubjectID As String = tdbViewer.Columns.Item(0).Value.ToString

    '            displayInstructors(SubjectID)


    '            btnDelete.Visible = True
    '            btnEdit.Visible = True
    '        End If
    '    End If


    'End Sub

    Private Sub ViewAssessmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAssessmentToolStripMenuItem.Click


        'With fmaSubjectScheduleListForm
        '    .txtCoursename.Text = Me.cmbCourse.Text
        '    .txtBatchName.Text = tdbViewer.Columns.Item("batchname").Value.ToString
        '    .txtSubject.Text = tdbViewer.Columns.Item(2).Value.ToString

        '    .txtCourseID.Text = Me.txtCourseID.Text
        '    .txtBatchID.Text = tdbViewer.Columns.Item("batchid").Value.ToString
        '    .txtSubjectID.Text = tdbViewer.Columns.Item(0).Value.ToString

        'End With

        'fmaSubjectScheduleListForm.Show(ftmdiMainForm)

    End Sub

    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        If txtCourseID.Text.Length > 0 Then
            If cmbBatch.Enabled = False Then
                cmbBatch.Enabled = True
            End If
            displayBatches()
        Else
            cmbBatch.Text = ""
            txtBatchID.Text = ""
            cmbBatch.Enabled = False
        End If
    End Sub


    ''Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
    ''    If txtBatchID.Text.Length > 0 Then
    ''        Dim SQLEX As String = "SELECT id, name from elective_groups where batch_id='" & txtBatchID.Text & "'"
    ''        Dim MeData As DataTable
    ''        MeData = clsDBConn.ExecQuery(SQLEX)

    ''        If MeData.Rows.Count > 0 Then
    ''            txtElectives.Text = MeData.Rows(0).Item("name").ToString
    ''            tdbViewer.Caption = txtElectives.Text
    ''            txtElectiveID.Text = MeData.Rows(0).Item("id").ToString
    ''        Else
    ''            txtElectives.Text = cmbBatch.Text
    ''            tdbViewer.Caption = txtElectives.Text
    ''        End If
    ''        btnAdd.Enabled = True
    ''    Else
    ''        txtElectives.Text = cmbBatch.Text
    ''        tdbViewer.Caption = txtElectives.Text
    ''        txtElectiveID.Text = ""
    ''        btnAdd.Enabled = False
    ''    End If
    ''End Sub

    'Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    '    If newSubject Is Nothing Then
    '        newSubject = fmaSubjectaSetupForm
    '        newSubject.txtElectives.Text = Me.txtElectives.Text
    '        tdbViewer.Caption = txtElectives.Text
    '        newSubject.txtElectiveID.Text = Me.txtElectiveID.Text
    '        newSubject.txtBatchID.Text = Me.txtBatchID.Text
    '        newSubject.OPETYPE = "NEW"
    '        newSubject.Show(Me)
    '    Else
    '        newSubject = Nothing
    '        newSubject = fmaSubjectaSetupForm
    '        newSubject.txtElectives.Text = Me.txtElectives.Text
    '        tdbViewer.Caption = txtElectives.Text
    '        newSubject.txtElectiveID.Text = Me.txtElectiveID.Text
    '        newSubject.txtBatchID.Text = Me.txtBatchID.Text
    '        newSubject.OPETYPE = "NEW"
    '        newSubject.Show(Me)
    '    End If
    'End Sub

    Private Sub newSubject_subjectAdded() Handles newSubject.subjectAdded
        btnSearchCondition.PerformClick()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'deleteSelectedItem()
    End Sub

    'Private Sub deleteSelectedItem()

    '    Dim ITEMSYSPK As String = ""

    '    Try
    '        ITEMSYSPK = tdbViewer.Columns.Item(0).Value
    '    Catch ex As Exception

    '    End Try


    '    Dim SQLEX As String = "SELECT COUNT(student_id) 'count' FROM students_subjects"
    '    SQLEX += " WHERE subject_id='" & ITEMSYSPK & "'"

    '    Dim MeData As DataTable
    '    MeData = clsDBConn.ExecQuery(SQLEX)

    '    If MeData.Rows.Count > 0 Then
    '        Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)

    '        If count > 0 Then
    '            MsgBox("Cannot Delete Subject, there are Students under it.", MsgBoxStyle.Critical)
    '            Exit Sub
    '        End If
    '    End If

    '    If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '        If ITEMSYSPK <> "" Then
    '            Dim DELETESTR As String = "DELETE FROM subjects"
    '            DELETESTR += " WHERE id='" & ITEMSYSPK & "'"

    '            If clsDBConn.Execute(DELETESTR) Then
    '                MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
    '                btnSearchCondition.PerformClick()
    '            End If
    '        End If
    '    End If



    'End Sub

    'Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    '    Dim subjID As String = ""
    '    Dim subjCode As String = ""
    '    Dim subjName As String = ""
    '    Dim subjCreditHrs As String = ""
    '    Dim subjAmount As String = ""
    '    Dim leclab As Integer = 0
    '    Dim elective As Integer = 0
    '    Dim classtype As String = tdbViewer.Columns.Item("no_exams").Value.ToString
    '    Dim electivetype As String = tdbViewer.Columns.Item("elective").Value.ToString
    '    'Dim ccid As Integer = 0

    '    Try
    '        subjID = tdbViewer.Columns.Item(0).Value
    '        subjCode = tdbViewer.Columns.Item(1).Value
    '        subjName = tdbViewer.Columns.Item(2).Value
    '        subjCreditHrs = tdbViewer.Columns.Item(3).Value
    '        subjAmount = tdbViewer.Columns.Item(4).Value

    '        'If IsDBNull(tdbViewer.Columns.Item("ccid").Value) Then
    '        '    ccid = -1
    '        'Else
    '        '    ccid = tdbViewer.Columns.Item("ccid").Value

    '        'End If


    '        If tdbViewer.Columns.Item("no_exams").Value.ToString = "LECTURE" Then
    '            leclab = 0
    '        Else
    '            leclab = 1
    '        End If

    '        If tdbViewer.Columns.Item("elective").Value.ToString = "OPTIONAL" Then
    '            elective = 0
    '        Else
    '            elective = 1
    '        End If


    '    Catch ex As Exception

    '    End Try

    '    If newSubject Is Nothing Then
    '        newSubject = fmaSubjectaSetupForm
    '        newSubject.txtElectives.Text = Me.txtElectives.Text
    '        tdbViewer.Caption = txtElectives.Text
    '        newSubject.txtElectiveID.Text = Me.txtElectiveID.Text
    '        newSubject.txtBatchID.Text = Me.txtBatchID.Text
    '        newSubject.txtSubjID.Text = subjID
    '        newSubject.txtSubjCode.Text = subjCode
    '        newSubject.txtName.Text = subjName
    '        'newSubject.CDValue = ccid
    '        If elective = 0 Then
    '            newSubject.rbtnOptional.Checked = True
    '        Else
    '            newSubject.rbtnElective.Checked = True
    '        End If

    '        newSubject.TYPE = leclab
    '        newSubject.txtNoUnit.Value = CInt(subjCreditHrs)
    '        newSubject.txtAmount.Value = CDbl(subjAmount)

    '        newSubject.OPETYPE = "EDIT"
    '        newSubject.Show(Me)
    '    Else
    '        newSubject = Nothing
    '        newSubject = fmaSubjectaSetupForm
    '        newSubject.txtElectives.Text = Me.txtElectives.Text
    '        tdbViewer.Caption = txtElectives.Text
    '        newSubject.txtElectiveID.Text = Me.txtElectiveID.Text
    '        newSubject.txtBatchID.Text = Me.txtBatchID.Text
    '        newSubject.txtSubjID.Text = subjID
    '        newSubject.txtSubjCode.Text = subjCode
    '        newSubject.txtName.Text = subjName
    '        'newSubject.CDValue = ccid
    '        If elective = 0 Then
    '            newSubject.rbtnOptional.Checked = True
    '        Else
    '            newSubject.rbtnElective.Checked = True
    '        End If

    '        newSubject.TYPE = leclab
    '        newSubject.txtNoUnit.Value = CInt(subjCreditHrs)
    '        newSubject.txtAmount.Value = CDbl(subjAmount)

    '        newSubject.OPETYPE = "EDIT"
    '        newSubject.Show(Me)
    '    End If

    'End Sub

    'Private Sub StatementOfAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementOfAccountToolStripMenuItem.Click


    '    With fmaStudentsGradeStudentList
    '        .txtCoursename.Text = Me.cmbCourse.Text
    '        .txtBatchName.Text = tdbViewer.Columns.Item("batchname").Value.ToString
    '        .txtSubject.Text = tdbViewer.Columns.Item(2).Value.ToString
    '        .txtSubjectID.Text = tdbViewer.Columns.Item(0).Value.ToString
    '    End With

    '    fmaStudentsGradeStudentList.ShowDialog(Me)
    'End Sub





    Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
        If txtBatchID.Text.Length > 0 Then
            btnSearchCondition.Enabled = True
        Else
            btnSearchCondition.Enabled = False
        End If
    End Sub
End Class