Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Drawing

Public Class fmaIncomeSetupForm

    Public FeeCategoryID As Integer = 0
    Public Amount As Double = 0
    Public Class_roll_no As Integer = 0
    Public stdID As Integer = 0
    Public request_form As Integer = 0
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCatID.Text.Length = 0 And request_form = 0 Then
            MsgBox("Please Select Expense Type.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Dim finance_type As String = "Income"
        Dim category_id As String = ""
        Dim created_at As String = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss")

        If request_form > 0 Then
            txtCatID.Text = 0
        End If

        Dim SQLIN As String = "INSERT INTO finance_transactions(title,description"
        SQLIN += " ,amount,category_id,student_id,issued_date"
        SQLIN += " ,created_at,transaction_date"
        SQLIN += " ,finance_type, receipt_no,payee_id)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}', '{1}'", title.Text, Me.txtRemarks.Text)
        SQLIN += String.Format(",'{0}', '{1}', '{2}', '{3}'", Me.diAmount.Value, txtCatID.Text, stdID, Format(Me.dtiDateIssued.Value, "yyyy-MM-dd"))
        SQLIN += String.Format(",'{0}', '{1}'", created_at, Format(dtpPayDate.Value, "yyyy-MM-dd"))
        SQLIN += String.Format(",'{0}', '{1}', '{2}')", finance_type, txtORNumber.Text, Class_roll_no)
        clsDBConn.Execute(SQLIN)

        finance_tran_id = DataObject(String.Format("SELECT Max(finance_transactions.id) FROM finance_transactions"))

        If CheckBox1.Checked = True Then

            '    If clsDBConn.Execute(SQLIN) Then
            Dim new_report As New fzzReportViewerForm

            Dim SQLEX As String = "SELECT admission_no FROM students"
            SQLEX += " WHERE id ='" & 0 & "'"

            new_report.FolderName = "OFFICIAL RECEIPT"
            new_report.AttachReport(SQLEX, "OR - " & Me.txtORNumber.Text & ", " & cmbType.Text) = New rpt_ReceiptPrintout(Format(dtpPayDate.Value, "yyyy-MM-dd"),
                                                                                                                  Me.title.Text, diAmount.Value,
                                                                                                                Me.txtRemarks.Text, Me.txtORNumber.Text)


            new_report.Show()
            '   End If

        End If

        If chkSlip.Checked = True Then
            Try

                _RootDirectory = CreatNewDirectory_XtraReport(_RootDirectory, "SLIP")

                Dim report As New XtraReport_TOR_SLIP With {._studentname = Me.cmbStudent.Text, ._course = Course, ._schoolname = SchoolName, ._academicyear = AcademicYear}
                report.DisplayName = "TOR SLIP - " & Format(dtiDateIssued.Value, "yyMMdd ") & Me.cmbStudent.Text
                report.ExportOptions.PrintPreview.DefaultDirectory = _RootDirectory
                report.ExportOptions.PrintPreview.SaveMode = DevExpress.XtraPrinting.SaveMode.UsingDefaultPath

                'If Not File.Exists(COMPANY_HEADER_PATH) Then
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                'Else
                '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                'End If

                report.xrDateTransaction.Text = Format(dtpPayDate.Value, "MMMM dd, yyyy")
                report.XrLabel10.Text = Format(dtiDateIssued.Value, "MMMM dd, yyyy")

                report.xrORNo.Text = txtORNumber.Text
                report.xrRemarks.Text = txtRemarks.Text
                report.xrDateIssued.Text = Format(dtiDateIssued.Value, "MMMM dd, yyyy")
                report.xrlblschoolname.Text = SchoolName
                report.xrlbladdress.Text = Address

                report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                report.CreateDocument()
                report.ShowPreview


            Catch ex As Exception

            End Try

        End If

        Me.DialogResult = DialogResult.OK

        Cursor = Cursors.Default

    End Sub

    Private Sub fmaCashVoucherSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getCategoryCode()
        getStudent()
        Me.dtpPayDate.Value = Date.Now

        If request_form > 0 Then

            Dim dt As New DataTable
            dt = getStudentDetails(Class_roll_no)
            Course = If(IsDBNull(dt(0)("Course")), "", dt(0)("Course"))
            SchoolName = If(IsDBNull(dt(0)("SchoolName")), "", dt(0)("SchoolName"))
            Address = If(IsDBNull(dt(0)("Address")), "", dt(0)("Address"))
            AcademicYear = If(IsDBNull(dt(0)("AcademicYear")), "", dt(0)("AcademicYear"))
            Me.cmbStudent.Text = If(IsDBNull(dt(0)("Name")), "", dt(0)("Name"))

            GroupPanel1.Visible = False
            GroupPanel4.Visible = True
            diAmount.Value = Amount
            chkSlip.Enabled = True
            GroupBox1.Enabled = True
        Else
            GroupPanel1.Visible = True
            GroupPanel4.Visible = False
        End If

    End Sub

    Private Function getStudentDetails(class_roll_no As Integer) As DataTable
        Dim sql As String = ""
        sql = "SELECT
                students.class_roll_no AS `ID`,
                person.display_name AS `Name`,
                courses.description AS Course,
                file.company_name AS `SchoolName`,
                file.address AS Address,
                students.academice_year AS 'AcademicYear'

                FROM
                person
                INNER JOIN FILE ON file.application_setup_id = person.application_setup_id
                INNER JOIN students ON person.person_id = students.person_id
                INNER JOIN courses ON students.course_id = courses.id
                WHERE
                person.status_type_id = 1 AND
                person.end_time IS NULL AND
                students.status_type_id = 1 AND
                students.end_time IS NULL AND
                students.class_roll_no = " & class_roll_no & "

                ORDER BY
                `Name` ASC"
        Return DataSource(sql)
    End Function

    Private Sub getStudent()
        cmbStudent.DataSource = getStudentList()
        cmbStudent.ValueMember = "ID"
        cmbStudent.DisplayMember = "Name"
        cmbStudent.SelectedIndex = -1
    End Sub

    Private Function getStudentList() As Object
        Dim str As String = ""
        str = "SELECT
                students.class_roll_no AS `ID`,
                person.display_name AS `Name`,
                courses.description AS Course,
                file.company_name AS `SchoolName`,
                file.address AS Address,
                students.academice_year as 'AcademicYear'

                FROM
                person
                INNER JOIN file ON file.application_setup_id = person.application_setup_id
                INNER JOIN students ON person.person_id = students.person_id
                INNER JOIN courses ON students.course_id = courses.id
                WHERE
                person.status_type_id = 1 AND
                person.end_time IS NULL AND
                students.status_type_id = 1 AND
                students.end_time IS NULL

                ORDER BY
                `Name` ASC
                "
        Return DataSource(str)
    End Function

    Private Sub getCategoryCode()
        Dim SQLEX As String = "SELECT id,UPPER(name) 'name',description FROM finance_transaction_categories WHERE is_income=1"
        SQLEX += " and deleted <> 1 and id <> 3"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbType.DataSource = MeData

        cmbType.ValueMember = "id"
        cmbType.DisplayMember = "name"

        cmbType.SelectedIndex = -1
        txtCatID.Text = ""
    End Sub

    Dim tor As String = ""
    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbType.SelectedItem, DataRowView)
            Me.txtCatID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub


    Private Sub cmbType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbType.SelectionChangeCommitted

        Try
            Dim drv As DataRowView = DirectCast(cmbType.SelectedItem, DataRowView)
            tor = drv.Item("name").ToString
            If tor.Contains("TOR").ToString Then
                GroupBox1.Enabled = True
                chkSlip.Enabled = True
            End If

        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub

    Public Course As String = ""
    Public SchoolName As String = ""
    Public Address As String = ""
    Public AcademicYear As String = ""

    Private Sub cmbStudent_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbStudent.SelectionChangeCommitted

        Try
                Dim drv As DataRowView = DirectCast(cmbStudent.SelectedItem, DataRowView)
                Course = drv.Item("Course").ToString
                SchoolName = drv.Item("SchoolName").ToString
                Address = drv.Item("Address").ToString
                AcademicYear = drv.Item("AcademicYear").ToString
            Catch ex As Exception
            End Try

    End Sub


End Class