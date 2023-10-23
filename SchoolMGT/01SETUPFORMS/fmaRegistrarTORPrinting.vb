Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Drawing
Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class fmaRegistrarTORPrinting
    Dim firstLoad As Boolean = True

    Dim PICTUREPATH As String = ""
    Dim ID_Number As String = ""

    Private Sub fmaRegistrarTORPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGroupedCourses()
        displayStudentsList()
        firstLoad = False
    End Sub

    Private Sub getGroupedCourses()
        Dim SQLEX As String = "SELECT id,name from coursegroup"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourse.DataSource = MeData

        cmbCourse.ValueMember = "id"
        cmbCourse.DisplayMember = "name"
        cmbCourse.Text = ""
        txtCourseID.Text = ""

    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCourseID.Text = ""
        End Try
    End Sub

    Private Sub displayStudentsList()
        Dim SQLEX As String = ""
        SQLEX += "SELECT DISTINCT	"
        SQLEX += "  students.class_roll_no "
        SQLEX += ", person.display_name 'name'"
        SQLEX += ", students.std_number"
        SQLEX += ",  person.person_id"
        SQLEX += "  FROM students"
        SQLEX += "  INNER JOIN students_subjects ON students.id = students_subjects.student_id 	"
        SQLEX += "  INNER JOIN subjects ON students_subjects.subject_id = subjects.id AND students_subjects.batch_id = subjects.batch_id 	"
        SQLEX += "  INNER JOIN batches ON students.batch_id = batches.id 	"
        SQLEX += "  INNER JOIN courses ON students.course_id = courses.id 	"
        SQLEX += "  INNER JOIN group_courses ON courses.id = group_courses.course_id 	"
        SQLEX += "  INNER JOIN coursegroup ON group_courses.coursegroup_id = coursegroup.id 	"
        SQLEX += "  INNER JOIN person ON students.person_id = person.person_id 	"
        SQLEX += "  WHERE	"
        SQLEX += "  person.status_type_id = 1 AND "
        SQLEX += "  students.status_type_id = 1 AND	students.end_time IS NULL AND "
        SQLEX += "  person.end_time IS NULL " 'AND 
        '     SQLEX += "  coursegroup.id = '" & txtCourseID.Text & "' "
        SQLEX += "  ORDER BY `name`  "

#Region "OLD"
        'SQLEX += "SELECT students.class_roll_no	"
        'SQLEX += ", CONCAT(person.last_name , ', ' ,person.first_name, '  '  , person.middle_name) 'name'"
        'SQLEX += ", students.id,students.std_number,person.person_id"
        'SQLEX += " FROM group_courses	"
        'SQLEX += " INNER JOIN coursegroup 	"
        'SQLEX += " ON (group_courses.coursegroup_id = coursegroup.id)	"
        'SQLEX += " INNER JOIN batches 	"
        'SQLEX += " ON (batches.course_id = group_courses.course_id)	"
        'SQLEX += " INNER JOIN subjects 	"
        'SQLEX += " ON (subjects.batch_id = batches.id)	"
        'SQLEX += " INNER JOIN students_subjects 	"
        'SQLEX += " ON (students_subjects.subject_id = subjects.id)	"
        'SQLEX += " INNER JOIN students 	"
        'SQLEX += " ON (group_courses.course_id = students.course_id)	"
        'SQLEX += " INNER JOIN person 	"
        'SQLEX += " ON (students.person_id = person.person_id)	"

        'SQLEX += " WHERE        coursegroup.id = '" & txtCourseID.Text & "'"
        'SQLEX += " GROUP BY class_roll_no	ORDER BY students.course_id,`name`"
#End Region


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        txtStudentName.DataSource = MeData

        txtStudentName.ValueMember = "class_roll_no"
        txtStudentName.DisplayMember = "name"

        txtStudentName.Text = ""
        txtClassrollNumber.Text = ""

    End Sub

    Private Sub txtStudentName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentName.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtStudentName.SelectedItem, DataRowView)
            Me.txtClassrollNumber.Text = drv.Item("class_roll_no").ToString
            ID_Number = drv.Item("std_number").ToString
            PERSON_ID = drv.Item("person_id").ToString
        Catch ex As Exception
            Me.txtClassrollNumber.Text = ""
        End Try
    End Sub

    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        If txtCourseID.Text.Length > 0 Then
            '      displayStudentsList()
            If Not firstLoad Then
                createStudentCategoryFolder()
            End If

        Else
            txtStudentName.DataSource = Nothing
        End If

    End Sub

    Private Sub txtClassrollNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClassrollNumber.TextChanged
        If txtClassrollNumber.Text.Length > 0 Then
            '     displayStudentsSubjectList()
            btnPrint.Enabled = True
        Else
            tdbViewer.DataSource = Nothing
            btnPrint.Enabled = False
        End If
    End Sub

    Public Property EditActive As Boolean

    Private Sub displayStudentsSubjectList()
        Dim SQLEX As String = "SELECT  coursegroup.name 'cgname'"
        SQLEX += " , group_courses.course_name, batches.name 'bname', subjects.code 'subjcode'"
        SQLEX += " , subjects.name 'subjname', students_subjects.finalgrade,students_subjects.re_exam,students_subjects.id"
        'SQLEX += " , students.class_roll_no, students.last_name"
        'SQLEX += " , students.first_name, students.middle_name"
        SQLEX += " FROM group_courses"
        SQLEX += " INNER JOIN coursegroup "
        SQLEX += " ON (group_courses.coursegroup_id = coursegroup.id)"
        SQLEX += " INNER JOIN batches "
        SQLEX += " ON (batches.course_id = group_courses.course_id)"
        SQLEX += " INNER JOIN subjects "
        SQLEX += " ON (subjects.batch_id = batches.id)"
        SQLEX += " INNER JOIN students_subjects "
        SQLEX += " ON (students_subjects.subject_id = subjects.id)"
        SQLEX += " INNER JOIN students "
        SQLEX += " ON (students_subjects.student_id = students.id)"
        SQLEX += " WHERE students.class_roll_no = '" & txtClassrollNumber.Text & "'"
        SQLEX += " ORDER BY group_courses.course_name, batches.name"


        Me.tdbViewer.DataSource = Nothing
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        GridControl1.DataSource = MeData
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                '.DisplayColumns("stdid").Visible = False

                .DisplayColumns("cgname").DataColumn.Caption = "COURSE"
                .DisplayColumns("cgname").Width = 250
                .DisplayColumns("cgname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("cgname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                '.DisplayColumns("course_id").Visible = False
                'course_name
                .DisplayColumns("course_name").DataColumn.Caption = "COURSE LEVEL"
                .DisplayColumns("course_name").Width = 200
                .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("bname").DataColumn.Caption = "BATCH"
                .DisplayColumns("bname").Width = 250
                .DisplayColumns("bname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("bname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("subjcode").DataColumn.Caption = "CODE"
                .DisplayColumns("subjcode").Width = 200
                .DisplayColumns("subjcode").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("subjcode").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("subjname").DataColumn.Caption = "SUBJECT"
                .DisplayColumns("subjname").Width = 500
                .DisplayColumns("subjname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("subjname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                'subjname
                .DisplayColumns("finalgrade").DataColumn.Caption = "FINAL GRADE"
                .DisplayColumns("finalgrade").Width = 300
                .DisplayColumns("finalgrade").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("finalgrade").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                'subjname
                .DisplayColumns("re_exam").DataColumn.Caption = "RE-EXAM"
                .DisplayColumns("re_exam").Width = 200
                .DisplayColumns("re_exam").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("re_exam").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("id").DataColumn.Caption = "ID"
                .DisplayColumns("id").Visible = False

            End With
        Catch ex As Exception

        End Try

        tdbViewer.GroupedColumns.Add(tdbViewer.Columns(0))
        tdbViewer.GroupedColumns.Add(tdbViewer.Columns(1))
        tdbViewer.GroupedColumns.Add(tdbViewer.Columns(2))
        '      tdbViewer.GroupedColumns.Add(tdbViewer.Columns(3))

        tdbViewer.ExpandGroupRow(0)
        tdbViewer.ExpandGroupRow(1)
        tdbViewer.ExpandGroupRow(2)
        '     tdbViewer.ExpandGroupRow(3)

    End Sub


    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        Me.Close()
    End Sub

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click
        '      displayStudentsSubjectList()
        getStudentSubjectList()
    End Sub

    Private Sub getStudentSubjectList()

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                                        students.class_roll_no,
                                        students.id,
                                        subjects.`code` 'subjcode',
                                        subjects.`name` 'subjname',
                                        students_subjects.id 'StdSubjectID',
                                        students_subjects.finalgrade,
                                        students_subjects.re_exam,
                                        batches.`name`'BatchName',
                                        courses.course_name 'CourseName',
                                        coursegroup.`name` 'GroupCouse'
                                        FROM
                                        students
                                        INNER JOIN students_subjects ON students.id = students_subjects.student_id
                                        INNER JOIN subjects ON students_subjects.subject_id = subjects.id AND students_subjects.batch_id = subjects.batch_id
                                        INNER JOIN batches ON students.batch_id = batches.id
                                        INNER JOIN courses ON students.course_id = courses.id
                                        INNER JOIN group_courses ON courses.id = group_courses.course_id
                                        INNER JOIN coursegroup ON group_courses.coursegroup_id = coursegroup.id
                                        WHERE
                                        students.status_type_id = 1 AND class_roll_no = '" & txtClassrollNumber.Text & "'

                                        ORDER BY GroupCouse,CourseName,BatchName,class_roll_no,id
                                        "))

        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        End If


    End Sub

    Private Sub btnPrint_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrint.MouseUp

        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Left Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = btnPrint.PointToClient(point1)
            CMenuStripOperations.Show(btnPrint, pt)

        End If

    End Sub



    Dim StudentName As String = ""
    Dim CourseName As String = ""
    Dim SchoolName As String = ""
    Dim SchoolAddress As String = ""
    Dim TrasactionDate As Date
    Dim AcademicYear As String = ""
    Dim Remarks As String = ""
    Dim ORnumber As String = ""
    Dim DateIssued As Date



    Private Sub Print_SLIP_and_TOR()

        Try

            Dim report As New XtraReport_TOR_SLIP With {._studentname = StudentName, ._course = CourseName, ._schoolname = SchoolName, ._academicyear = AcademicYear}


            'If Not File.Exists(COMPANY_HEADER_PATH) Then
            '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
            'Else
            '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
            'End If

            report.xrDateTransaction.Text = Format(DateIssued.Date, "MMMM dd, yyyy")
            report.XrLabel10.Text = Format(DateIssued.Date, "MMMM dd, yyyy")

            report.xrORNo.Text = ORnumber
            report.xrRemarks.Text = Remarks
            report.xrDateIssued.Text = DateIssued

            report.xrlblschoolname.Text = SchoolName
            report.xrlbladdress.Text = SchoolAddress

            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
            report.CreateDocument()
            report.ShowPreview


        Catch ex As Exception

        End Try

    End Sub

    Private Function getTORSlip(classrollNo As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person.display_name,
CONCAT(UPPER(courses.description),' (',courses.course_name,')') 'coursename',
students.semester ,
CASE WHEN students.semester = '2ND SEMESTER' THEN  CONCAT(students.academice_year,'-',students.academice_year + 1) 
ELSE students.academice_year END AS 'academicyear',
max(students.academice_year) 'LastYearAttended',
file.company_name 'University',
file.address,
class_roll_no
FROM
person
INNER JOIN students ON students.person_id = person.person_id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN users ON students.user_id = users.id
INNER JOIN application_setup ON users.application_setup_id = application_setup.application_setup_id 
INNER JOIN file ON application_setup.application_setup_id = file.application_setup_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
students.end_time IS NULL AND students.class_roll_no = '" & classrollNo & "'
"))

        Return dt
    End Function

    Private Sub createStudentCategoryFolder()
        PICTUREPATH = Directory.GetCurrentDirectory & "\PIC\" & cmbCourse.Text

        If (Not System.IO.Directory.Exists(Path.Combine(PICTUREPATH, PICTUREPATH))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(PICTUREPATH, PICTUREPATH))
        End If
    End Sub


    Private Sub StatementOfAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        Dim SQLEX As String = "SELECT id,picturepath from transcript_master_file where class_roll_no='" & txtClassrollNumber.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            fmaOfficialTranscipt9AForm = Nothing
            'fmaOfficialTranscipt9AForm = New fmaOfficialTranscipt9AForm
            With fmaOfficialTranscipt9AForm
                .txtStudentName.Text = txtStudentName.Text
                .txtClassRollNumber.Text = txtClassrollNumber.Text
                '.txtAdmittedTo.Text = cmbCourse.Text
                .txtTORMasterFileID.Text = MeData.Rows(0).Item("id").ToString
                '.lblPicturepath.Text = MeData.Rows(0).Item("picturepath").ToString
                .DBPICPATH = MeData.Rows(0).Item("picturepath").ToString
                .lblPicturepath.Text = PICTUREPATH
            End With
            fmaOfficialTranscipt9AForm.ShowDialog(Me)
        Else
            MsgBox("Please Fill-out Official Transcript Details.")
            fmaOfficialTranscipt9AForm = Nothing
            'fmaOfficialTranscipt9AForm = New fmaOfficialTranscipt9AForm
            With fmaOfficialTranscipt9AForm
                .txtStudentName.Text = txtStudentName.Text
                .txtClassRollNumber.Text = txtClassrollNumber.Text
                '.txtAdmittedTo.Text = cmbCourse.Text
                .lblPicturepath.Text = PICTUREPATH
            End With
            fmaOfficialTranscipt9AForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub CHEDFORM9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHEDFORM9ToolStripMenuItem.Click
        Dim SQLEX As String = "SELECT id,picturepath from transcript_master_file where class_roll_no='" & txtClassrollNumber.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            fmaOfficialTranscipt9Form = Nothing
            'fmaOfficialTranscipt9AForm = New fmaOfficialTranscipt9AForm
            With fmaOfficialTranscipt9Form
                .txtStudentName.Text = txtStudentName.Text
                .txtClassRollNumber.Text = txtClassrollNumber.Text
                '.txtAdmittedTo.Text = cmbCourse.Text
                .txtTORMasterFileID.Text = MeData.Rows(0).Item("id").ToString
                '.lblPicturepath.Text = MeData.Rows(0).Item("picturepath").ToString
                .DBPICPATH = MeData.Rows(0).Item("picturepath").ToString
                .lblPicturepath.Text = PICTUREPATH
            End With
            fmaOfficialTranscipt9Form.ShowDialog(Me)
        Else
            MsgBox("Please Fill-out Official Transcript Details.")
            fmaOfficialTranscipt9Form = Nothing
            'fmaOfficialTranscipt9AForm = New fmaOfficialTranscipt9AForm
            With fmaOfficialTranscipt9Form
                .txtStudentName.Text = txtStudentName.Text
                .txtClassRollNumber.Text = txtClassrollNumber.Text
                '.txtAdmittedTo.Text = cmbCourse.Text
                .lblPicturepath.Text = PICTUREPATH
            End With
            fmaOfficialTranscipt9Form.ShowDialog(Me)
        End If
    End Sub

    Private Sub TORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TORToolStripMenuItem.Click

        Cursor.Current = Cursors.WaitCursor


        frmGraduateStudent.btnPrintTOR_Click(sender, e, txtClassrollNumber.Text, "View Only")


        'If AuthUserType = "SUPERUSER" Then

        '    Dim CompleteDetails As Boolean = False
        '    CompleteDetails = Check_StudentDetails(PERSON_ID)

        '    If CompleteDetails = False Then
        '        Dim frm As New frmGraduateStudent()
        '        frm.Text = "ADDITIONAL ENTRY FOR TOR"
        '        frm._class_roll_number = txtClassrollNumber.Text
        '        frm._personID = PERSON_ID
        '        frm.BringToFront()
        '        frm.ShowDialog()

        '    Else

        '        frmGraduateStudent.btnPrintTOR_Click(sender, e, txtClassrollNumber.Text)

        '    End If


        'End If



        Cursor.Current = Cursors.Default

    End Sub

    Private Function Check_StudentDetails(pERSON_ID As Integer) As Boolean
        Dim complete_details As Integer = 0
        complete_details = DataObject(String.Format("SELECT
	                                graduate_student.complete_details
                                FROM
	                                graduate_student
                                WHERE
	                                graduate_student.end_time IS NULL AND
	                                graduate_student.person_id = '" & pERSON_ID & "'"))
        If complete_details > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function CheckIfTORDetailsCompleted(pERSON_ID As Integer) As Boolean
        Dim dt As DataTable = DataSource(String.Format("SELECT
                            graduate_student_id
                            complete_details
                            FROM
                            graduate_student
                            WHERE
                            status_type_id = 1 AND
                            end_time IS NULL AND
                            person_id = '" & pERSON_ID & "'
                            "))
        If dt.Rows.Count > 0 Then
            If dt(0)("complete_details") = 1 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Private Function CheckAvailableTOR(classRollNumber As Object) As Boolean

        Dim id As Integer = DataObject(String.Format("SELECT id FROM finance_transactions WHERE	tor_printed = 0 AND student_id = '" & classRollNumber & "'"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        DataSource(String.Format("UPDATE students_subjects SET re_exam = '" & e.Value & "' WHERE id = '" & GridView1.GetFocusedRowCellValue("StdSubjectID") & "'"))
        MessageBoxEx.Show("Grade has been added to Re-Exam", "ADDED RECORD", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Public Sub ToolTipController1_GetActiveObjectInfo_1(sender As Object, e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
        Dim info As ToolTipControlInfo = Nothing
        ' Get the view at the current mouse position.
        Dim view As GridView = GridControl1.GetViewAt(e.ControlMousePosition)
        If view Is Nothing Then Return
        ' Get the information about the visual element at the current mouse position.
        Dim hi As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
        ' Display a hint for a row indicator.
        '     If hi.HitTest = GridHitTest.RowIndicator Then
        If hi.InRow = True Then
            ' Create an object that uniquely identifies a row indicator.
            Dim o As Object = hi.HitTest.ToString() + hi.RowHandle.ToString()
            Dim text As String = "To Add Re-Exam Grade,double click column row 'Re-Exam' then make an entry" + hi.RowHandle.ToString()
            info = New ToolTipControlInfo(o, text)
        End If
        ' Assign the tooltip information if applicable; otherwise, preserve the default tooltip.
        If Not info Is Nothing Then e.Info = info
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Cursor.Current = Cursors.WaitCursor

        frmGraduateStudent.btnPrintTOR_Click(sender, e, txtClassrollNumber.Text, "View Only")

        Cursor.Current = Cursors.Default

    End Sub
End Class