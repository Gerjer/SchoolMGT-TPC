Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI

Public Class fmaStudentsSubjectListForm
    Private CLASS_SCHED As DataTable

    Dim WithEvents addSubj As fmaAddSubjectForm = Nothing

    Dim dgvcc As New DataGridViewComboBoxCell

    Private ROWSELECT As Integer = -1
    Dim ListModel As New StudentLearnersListModel
    Dim FirstLoad As Boolean = True

    Public CourseID As Integer
    Public BatchID As Integer

    Private Sub fmaStudentListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'getSubjSchedule()
        FirstLoad = True

        displayFilterCategory()
        curriculumStatus()
        loadHandler


        FirstLoad = False
    End Sub

    Private Sub loadHandler()
        AddHandler RadioButton1.Click, AddressOf RegularStatus
        AddHandler RadioButton2.Click, AddressOf IrregularStatus
    End Sub

    Private Sub IrregularStatus(sender As Object, e As EventArgs)
        DataSource(String.Format("UPDATE `students` SET   `is_regular` = 1 WHERE `id` = '" & txtStudentID.Text & "';"))
        MsgBox("Curriculumn Status has been change to IRREGULAR ")

    End Sub

    Private Sub RegularStatus(sender As Object, e As EventArgs)

        DataSource(String.Format("UPDATE `students` SET   `is_regular` = 0 WHERE `id` = '" & txtStudentID.Text & "';"))
        MsgBox("Curriculumn Status has been change to REGULAR ")

    End Sub

    Private Sub curriculumStatus()

        Dim isRegular As Integer = DataObject(String.Format("SELECT is_regular  FROM students WHERE status_type_id = 1 AND end_time IS NULL AND id = '" & txtStudentID.Text & "'"))
        '
        If isRegular = 0 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

    End Sub

    Dim StudentSubjectSysPK As String = ""

    Private Sub displayFilterCategory()
        dgvSubjects.Rows.Clear()

        Try

            Dim SQLEX As String = ""

            If Me.txtCategory.Text = "COLLEGE" Then
                SQLEX = "SELECT  students.admission_no"
                SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
                SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid'"
                SQLEX += ", subject_class_schedule.name"
                SQLEX += ", subject_class_schedule.room"
                SQLEX += ", subject_class_schedule.employee_name"
                SQLEX += ", courses.course_name,subject_class_schedule.`code` 'classcode'"
                SQLEX += " FROM students_subjects"
                SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
                SQLEX += " INNER JOIN batches ON (students_subjects.batch_id = batches.id)"
                SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
                SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
                SQLEX += " LEFT JOIN subject_class_schedule"
                SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
                SQLEX += " WHERE student_id='" & txtStudentID.Text & "'"


            Else
                SQLEX = "SELECT  students.admission_no"
                SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
                SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid'"
                SQLEX += ", subject_class_schedule.name"
                SQLEX += ", subject_class_schedule.room"
                SQLEX += ", subject_class_schedule.employee_name"
                SQLEX += ", courses.course_name,subject_class_schedule.`code` 'classcode'"
                SQLEX += " FROM students_subjects"
                SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
                SQLEX += " INNER JOIN batches ON (students_subjects.batch_id = batches.id)"
                SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
                SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
                SQLEX += " LEFT JOIN subject_class_schedule"
                SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
                SQLEX += " WHERE student_id='" & txtStudentID.Text & "'"


            End If


            Dim MeData As DataTable
            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then
                For cnt As Integer = 0 To MeData.Rows.Count - 1
                    Dim subjID As String = MeData.Rows(cnt).Item("subjid").ToString()

                    Dim subjlist As New List(Of Object)
                    subjlist.Add(MeData.Rows(cnt).Item("subjid").ToString())
                    'subjlist.Add(MeData.Rows(cnt).Item("batchname").ToString())
                    subjlist.Add(MeData.Rows(cnt).Item("subjCode").ToString())
                    '    subjlist.Add(MeData.Rows(cnt).Item("classcode").ToString())
                    subjlist.Add(MeData.Rows(cnt).Item("subjname").ToString())
                    subjlist.Add(MeData.Rows(cnt).Item("credit_hours").ToString())
                    dgvSubjects.Rows.Add(subjlist.ToArray)


                    dgvcc.DisplayMember = "name"
                    dgvcc.ValueMember = "SysPK_Item"
                    dgvcc.FlatStyle = FlatStyle.Popup
                    dgvcc = dgvSubjects.Rows(cnt).Cells(4)

                    Dim SQLEXSUBJ As String = "SELECT SysPK_Item,name,room,employee_name FROM subject_class_schedule"
                    SQLEXSUBJ += " WHERE subject_id='" & subjID & "'"
                    CLASS_SCHED = clsDBConn.ExecQuery(SQLEXSUBJ)

                    If CLASS_SCHED.Rows.Count > 0 Then
                        For comboRowCount As Short = 0 To CLASS_SCHED.Rows.Count - 1

                            Dim cmbItem As String = CLASS_SCHED.Rows(comboRowCount).Item("name").ToString
                            dgvcc.Items.Add(cmbItem)

                            If StudentSubjectSysPK = "" Then
                                StudentSubjectSysPK = CLASS_SCHED.Rows(comboRowCount).Item("SysPK_Item").ToString
                            Else
                                StudentSubjectSysPK = StudentSubjectSysPK + "," + CLASS_SCHED.Rows(comboRowCount).Item("SysPK_Item").ToString
                            End If

                        Next
                    Else
                        dgvcc.Items.Add("NO SCHED SET")

                    End If

                    If Not IsDBNull(MeData.Rows(cnt).Item("name").ToString()) Then
                        dgvSubjects.Item(4, cnt).Value = MeData.Rows(cnt).Item("name").ToString()
                    End If

                    If Not IsDBNull(MeData.Rows(cnt).Item("classcode").ToString()) Then
                        dgvSubjects.Item(5, cnt).Value = MeData.Rows(cnt).Item("classcode").ToString()
                    End If

                    If Not IsDBNull(MeData.Rows(cnt).Item("room").ToString()) Then
                        dgvSubjects.Item(6, cnt).Value = MeData.Rows(cnt).Item("room").ToString()
                    End If

                    If Not IsDBNull(MeData.Rows(cnt).Item("employee_name").ToString()) Then
                        dgvSubjects.Item(7, cnt).Value = MeData.Rows(cnt).Item("employee_name").ToString()
                    End If

                    If Not IsDBNull(MeData.Rows(cnt).Item("course_name").ToString()) Then
                        dgvSubjects.Item(8, cnt).Value = MeData.Rows(cnt).Item("course_name").ToString()
                    End If




                Next

            End If


            'Dim subjectList As New DataTable

            'subjectList.Columns.Add("Subject Code")
            'subjectList.Columns.Add("Subject Name")
            'subjectList.Columns.Add("Unit/S")


            getTotalUnits()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub




    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click

        displayFilterCategory()
    End Sub


    'Private Sub dgvSubjects_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
    '    If TypeOf e.Control Is ComboBox Then
    '        Dim combo As ComboBox = CType(e.Control, ComboBox)

    '        If (combo IsNot Nothing) Then

    '            ' Remove an existing event-handler, if present, to avoid
    '            ' adding multiple handlers when the editing control is reused.
    '            RemoveHandler combo.SelectedIndexChanged, _
    '                New EventHandler(AddressOf ComboBox_SelectedIndexChanged)


    '            ' Add the event handler.
    '            AddHandler combo.SelectedIndexChanged, _
    '                New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

    '        End If
    '        If dgvSubjects.CurrentCell.ColumnIndex = 4 AndAlso TypeOf e.Control Is ComboBox Then
    '            With DirectCast(e.Control, ComboBox)
    '                .DropDownStyle = ComboBoxStyle.DropDown
    '                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '                '.AutoCompleteSource = AutoCompleteSource.CustomSource
    '                'RemoveHandler .KeyDown, AddressOf ComboBox_KeyDown
    '                'AddHandler .KeyDown, AddressOf ComboBox_KeyDown
    '            End With
    '        End If
    '    End If
    'End Sub

    Public Sub ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim sendertext As String = sender.SelectedItem

        Dim comboBox As ComboBox = CType(sender, ComboBox)
        comboBox.ValueMember = "SysPK_Item"
        'Display selected value

        Dim name As String = comboBox.SelectedItem

        Dim mcolIndex As Short = dgvSubjects.CurrentCell.ColumnIndex.ToString
        Dim mrowIndex As Short = dgvSubjects.CurrentCell.RowIndex


        Dim subj_id As String = dgvSubjects.Item(0, mrowIndex).Value
        Dim SQLEX As String = "SELECT SysPK_Item,upper(employee_name) 'employee_name',room"
        SQLEX += " FROM subject_class_schedule"
        SQLEX += " WHERE subject_id='" & subj_id & "'"
        SQLEX += " AND name='" & name & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            dgvSubjects.Item(6, mrowIndex).Value = MeData.Rows(0).Item("room").ToString
            dgvSubjects.Item(7, mrowIndex).Value = MeData.Rows(0).Item("employee_name").ToString
            dgvSubjects.Item(8, mrowIndex).Value = MeData.Rows(0).Item("SysPK_Item").ToString

            Dim SQLUP As String = "UPDATE students_subjects"
            SQLUP += " SET subject_class_schedule_id='" & MeData.Rows(0).Item("SysPK_Item").ToString & "'"
            SQLUP += " WHERE student_id='" & txtStudentID.Text & "'"
            SQLUP += " AND subject_id='" & subj_id & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Subject Schedule Changed.", MsgBoxStyle.Information)
            End If


        End If

    End Sub


    Private Sub txtAdmissionNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdmissionNo.TextChanged
        If txtAdmissionNo.Text.Length > 0 Then
            Try
                displayFilterCategory()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnxAddSubj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxAddSubj.Click

        If addSubj Is Nothing Then
            addSubj = New fmaAddSubjectForm
            With addSubj
                .txtStudentID.Text = Me.txtStudentID.Text
                .StudentSubjectSysPK = StudentSubjectSysPK
            End With

            addSubj.Show(Me)

        End If
        'fmaAddSubjectForm.Show(Me)

    End Sub

    Private Sub addSubj_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles addSubj.FormClosing
        addSubj = Nothing
    End Sub

    Private Sub addSubj_SUBJECTADDED() Handles addSubj.SUBJECTADDED
        displayFilterCategory()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Are sure you want to Remove Subject from this student?", "Please Verify !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLDEL As String = "DELETE FROM students_subjects"
            SQLDEL += " WHERE student_id='" & Me.txtStudentID.Text & "'"
            SQLDEL += " AND subject_id='" & Me.txtSubjectID.Text & "'"

            If clsDBConn.Execute(SQLDEL) Then
                MsgBox("Subject has been deleted.")
                displayFilterCategory()
            End If
        End If
    End Sub


    Private Sub dgvSubjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        btnRemove.Enabled = True

        Try
            ROWSELECT = e.RowIndex

            Dim currentRow As DataGridViewRow = dgvSubjects.Rows(ROWSELECT)


            txtSubjectID.Text = currentRow.Cells(0).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvSubjects_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSubjects.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)

            If (combo IsNot Nothing) Then

                ' Remove an existing event-handler, if present, to avoid
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectedIndexChanged, _
                    New EventHandler(AddressOf ComboBox_SelectedIndexChanged)


                ' Add the event handler.
                AddHandler combo.SelectedIndexChanged, _
                    New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

            End If
            If dgvSubjects.CurrentCell.ColumnIndex = 4 AndAlso TypeOf e.Control Is ComboBox Then
                With DirectCast(e.Control, ComboBox)
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    '.AutoCompleteSource = AutoCompleteSource.CustomSource
                    'RemoveHandler .KeyDown, AddressOf ComboBox_KeyDown
                    'AddHandler .KeyDown, AddressOf ComboBox_KeyDown
                End With
            End If
        End If
    End Sub

    Private Sub getTotalUnits()
        Dim totalUnits As Double = 0


        For nCtr As Integer = 0 To dgvSubjects.Rows.Count - 1
            Dim value As Double = CDbl(dgvSubjects.Item(3, nCtr).Value)

            totalUnits += value
        Next

        Me.txtNoOfUnits.Text = Format(totalUnits, "#.00")
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
        'Cursor.Current = Cursors.WaitCursor

        'PrintCORNew()

        'Cursor.Current = Cursors.Default
    End Sub

    Dim COR_info As New Student_COR
    Dim Subject_info As New List(Of COR_Subject_Details)
    Dim Assessment_info As New List(Of COR_Assessment_Details)
    Dim Default_LogoPath As String = IO.Directory.GetCurrentDirectory & "\TPC_logo.jpg"

    Private Sub PrintCORNew()

        If txtCoursename.Text <> "BS Agriculture" Then
            'LETTER SIZE

            Dim StudentID As Integer = ListModel.getStudentID(txtAdmissionNo.Text)

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
                report.XrLabel5.Text = "Email Address: " & COMPANY_EMAIL_ADDRESS
                report.XrLabel11.Text = ListModel.getCurriculunmStatus(StudentID)

                'If Not File.Exists(COMPANY_LOGO_PATH) Then
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
                'Else
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
                'End If

                Dim dt As New DataTable
                dt = ListModel.getStudents_COR_info(txtAdmissionNo.Text)

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
                    dt = ListModel.getStudent_Subject_info(txtAdmissionNo.Text)
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
            'LEGAL SIZE

            Dim StudentID As Integer = ListModel.getStudentID(txtAdmissionNo.Text)

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
                dt = ListModel.getStudents_COR_info(txtAdmissionNo.Text)

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
                    dt = ListModel.getStudent_Subject_info(txtAdmissionNo.Text)
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




    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    '    '       If FirstLoad = False Then
    '    DataSource(String.Format("UPDATE `students` SET   `is_regular` = 0 WHERE `id` = '" & txtStudentID.Text & "';"))
    '        MsgBox("Curriculumn Status has been change to REGULAR ")
    '    '   End If
    'End Sub

    'Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    '    '    If FirstLoad = False Then
    '    DataSource(String.Format("UPDATE `students` SET   `is_regular` = 1 WHERE `id` = '" & txtStudentID.Text & "';"))
    '        MsgBox("Curriculumn Status has been change to IRREGULAR ")
    '    '   End If

    'End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

        Cursor = Cursors.WaitCursor

        getDetails_Students(txtStudentID.Text)

        With fmaStudentAssessmentForm
            .txtCategoryID.Text = dt_StdDetails(0)("categoryid").ToString
            .txtAdmissionNo.Text = dt_StdDetails(0)("admission_no").ToString
            .txtIDNumber.Text = dt_StdDetails(0)("std_number").ToString
            .txtGrant.Text = If(IsDBNull(dt_StdDetails(0)("scholarshipgrant").ToString), "", dt_StdDetails(0)("scholarshipgrant").ToString)
            .txtStudentID.Text = dt_StdDetails(0)("id").ToString
            .txtStudentName.Text = dt_StdDetails(0)("last_name").ToString _
                                   & ", " & dt_StdDetails(0)("first_name").ToString() _
                                   & " " & dt_StdDetails(0)("middle_name").ToString()
            .txtCourse.Text = dt_StdDetails(0)("course_name").ToString
            'year_level,school_year,semester
            .txtSY.Text = dt_StdDetails(0)("school_year").ToString
            .txtYearLvl.Text = dt_StdDetails(0)("year_level").ToString
            .txtSemester.Text = dt_StdDetails(0)("semester").ToString
            .txtCategoryName.Text = dt_StdDetails(0)("categoryname").ToString
            '.txtEnrollStat.Text = tdbViewer.Columns.Item("status").Value.ToString

        End With

        '   fmaStudentAssessmentForm.MdiParent = ftmdiMainForm
        fmaStudentAssessmentForm.Show()
        fmaStudentAssessmentForm.BringToFront()

        Cursor = Cursors.Default

    End Sub


    Dim dt_StdDetails As New DataTable
    Private Sub getDetails_Students(studentID As String)

        dt_StdDetails.Columns.Clear()

        Dim SQLEX As String = ""
        SQLEX += " SELECT students.id,students.admission_no,students.std_number"
        SQLEX += " , students.scholarshipgrant,REPLACE ( person.last_name, 'Ã±', 'ñ' ) AS 'last_name'"
        SQLEX += " , person.first_name,person.middle_name"
        SQLEX += " , courses.course_name"
        SQLEX += " , batches.`name` 'batchname',students.year_level,batches.school_year,students.semester"
        SQLEX += " , student_categories.name 'categoryname'"
        SQLEX += " , student_categories.id 'categoryid'"
        'SQLEX += " , students.id 'categoryid'"
        SQLEX += " , IF(is_enrolled = 1, 'enrolled', 'not enrolled') 'status'"
        SQLEX += " FROM students"
        SQLEX += " INNER JOIN person"
        SQLEX += " ON (students.person_id = person.person_id AND students.status_type_id = 1 AND person.end_time IS NULL)"
        SQLEX += " INNER JOIN student_categories "
        SQLEX += " ON (students.student_category_id = student_categories.id)"
        SQLEX += " INNER JOIN batches "
        SQLEX += " ON (students.batch_id = batches.id)"
        SQLEX += " INNER JOIN courses "
        SQLEX += " ON (batches.course_id = courses.id)"
        SQLEX += " WHERE students.id='" & studentID & "'"

        dt_StdDetails = clsDBConn.ExecQuery(SQLEX)

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New fmaStudentFeePaymentsForm
        frm.shortcut = True
        frm.BringToFront()
        frm.Show()

        Cursor = Cursors.Default

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click

        Cursor = Cursors.WaitCursor

        PrintCORNew()
        Cursor = Cursors.Default

    End Sub

End Class