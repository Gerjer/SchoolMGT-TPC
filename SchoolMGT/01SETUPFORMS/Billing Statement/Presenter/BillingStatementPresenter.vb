Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class BillingStatementPresenter
    Private _view As frmBillingStatement
    Dim Model As New BillingStatementModel
    Dim id As Integer
    Public Sub New(frmBillingStatement As frmBillingStatement)
        _view = frmBillingStatement

        loadHandler()
        loadList()

    End Sub

    Private Sub loadList()

        Dim dt As New DataTable
        dt = Model.getList()
        _view.gcBillingStatement.DataSource = dt
        _view.gvBillingStatement.Columns("id").Visible = False
        _view.gvBillingStatement.Columns("user_id").Visible = False
        _view.gvBillingStatement.OptionsBehavior.Editable = False

    End Sub

    Private Sub loadHandler()

        '    AddHandler _view.btnAdd.Click, AddressOf ShowCreatBilling
        AddHandler _view.btnAdd.MouseUp, AddressOf AddBilling
        AddHandler _view.btnEdit.Click, AddressOf ShowCreatBilling
        AddHandler _view.gvBillingStatement.RowCellClick, AddressOf SelectRow
        AddHandler _view.btnPrint.Click, AddressOf PrintBilling
        AddHandler _view.ConsToolStripMenuItem.Click, AddressOf RecordBilling
        AddHandler _view.TOSFToolStripMenuItem.Click, AddressOf RecordBilling
        AddHandler _view.ADMISSIONFEEToolStripMenuItem.Click, AddressOf RecordBilling
    End Sub

    Private Sub RecordBilling(sender As Object, e As EventArgs)

        Dim ToolStrip As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Dim frm As New frmBillingStatementCreat
        frm.Operation = "ADD"
        frm.Tag = ToolStrip.Tag
        frm.WinLabel.Text = ToolStrip.Text
        frm.Prensenter = Me
        frm.Model = Model
        frm.BringToFront()
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            BillDate = frm.dtpBillDate.Value
            loadList()
        End If



    End Sub

    Private Sub AddBilling(sender As Object, e As MouseEventArgs)

        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Left Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = _view.btnAdd.PointToClient(point1)

            _view.ContextMenuStrip1.Show(_view.btnAdd, pt)
        End If
    End Sub

    Dim SubjectBatchID As Integer
    Private Sub PrintBilling(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor
        Dim sequence_no As Integer = 0
        If FormType = "FORM 1" Then

            Dim form1 As New List(Of BillingStatement.Form1)
            Dim report As New XtraReport_BillingStatements_Form1

            report.XrLSchoolName.Text = COMPANY_NAME
            report.XrLAddress.Text = COMPANY_ADDRESS
            report.XrLReferenceNo.Text = RefNo
            report.XrLDate.Text = Format(BiilDate.Date, "dd-MMM-yy")


            Dim dt As New DataTable
            dt = Model.getFom1Details(id)
            If dt.Rows.Count > 0 Then

                Dim obj As New BillingStatement.Form1
                With obj
                    .term = If(IsDBNull(dt(0)("term")), "", dt(0)("term"))
                    .academic_year = If(IsDBNull(dt(0)("academic_year")), "", dt(0)("academic_year"))
                    .accountcode = If(IsDBNull(dt(0)("account_code")), "", dt(0)("account_code"))
                    .amount1 = If(IsDBNull(dt(0)("amount")), 0, dt(0)("amount"))
                End With
                form1.Add(obj)

                report.DataSource = form1
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1
                report.CreateDocument()
                report.ShowPreviewDialog
            End If
        ElseIf FormType = "FORM 2" Then

            Dim Form2 As New List(Of BillingStatementForm2)
            Dim report As New XtraReport_Billing_Statement_Form2

            report.xrlSchoolName.Text = COMPANY_NAME
            report.xrlAddress.Text = COMPANY_ADDRESS
            report.xrlRefNo.Text = RefNo
            report.xrlDate.Text = Format(BiilDate.Date, "dd-MMM-yy")

            Dim dt As New DataTable
            dt = Model.getSummaryTotalTOSF(AppSetup_Domain, Format(BiilDate.Date, "yyyy-MM-dd"))

            If dt.Rows.Count Then
                For Each row As DataRow In dt.Rows
                    SubjectBatchID = row("SubjectBatchID")
                    Dim obj As New BillingStatementForm2
                    With obj
                        sequence_no = If(IsDBNull(row("SuquenceNumber")), 0, row("SuquenceNumber"))
                        .SequenceNumber = String.Format("{0:D5}", CInt(sequence_no))
                        .StudentNumber = If(IsDBNull(row("StudentNumber")), "", row("StudentNumber"))
                        .LastName = If(IsDBNull(row("LastName")), "", row("LastName"))
                        .GivenName = If(IsDBNull(row("GivenName")), "", row("GivenName"))
                        .MiddleName = If(IsDBNull(row("MiddleName")), " ", row("MiddleName"))
                        .DegreeProgram = If(IsDBNull(row("DegreeProgram")), "", row("DegreeProgram"))
                        .YearLevel = If(IsDBNull(row("YearLevel")), "", row("YearLevel"))
                        .Sex = If(IsDBNull(row("Sex")), " ", row("Sex"))
                        .Units = If(IsDBNull(row("TotalUnits")), 0, row("TotalUnits"))
                        .UnitsNSTP = If(IsDBNull(row("TotalUnitsNSTP")), 0, row("TotalUnitsNSTP"))
                        .TotalAmt_Units = If(IsDBNull(row("TotalUnits_Amount")), 0, row("TotalUnits_Amount"))
                        .TotalAmt_UnitsNSTP = If(IsDBNull(row("TotalUnitsNSTP_Amount")), 0, row("TotalUnitsNSTP_Amount"))

                        Dim Paid As Boolean = False
                        Dim fees As New DataTable
                        fees = Model.getFees(row("SubjectBatchID"), row("SuquenceNumber"))
                        If fees.Rows.Count > 0 Then
                            For Each row1 As DataRow In fees.Rows
                                Select Case row1("Fees")
                                    Case "ADMISSION FEE"
                                        .Entrance_Admission_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no)   'row1("FeesAmount")
                                    Case "ATHLETIC FEE"
                                        .Athletict_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "COMPUTER LABORATORY FEE"
                                        .Computer_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "CULTURAL FEE"
                                        .Cultural_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "DEVELOPMENT FEE"
                                        .Development_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "GUIDANCE FEE"
                                        .Guidance_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "HANDBOOK FEE"
                                        .HandBook_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "LIBRARY FEE"
                                        .Library_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "MEDICAL/DENTAL FEES"
                                        .MedicalDental_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "REGISTRATION FEE"
                                        .Registration_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no) 'row1("FeesAmount")
                                    Case "SCHOOL ID FEE"
                                        .SchoolID_Fees = checkOneTimePayments(row1("FeesAmount"), row1("ParticularID"), row1("mode_payments"), sequence_no)
                                        'Paid = Model.getOneTimePayment(row("SuquenceNumber"), row("SubjectBatchID"))
                                        'If Paid = True Then
                                        '    .SchoolID_Fees = row1("FeesAmount")
                                        'Else
                                        '    .SchoolID_Fees = 0
                                        'End If
                                    Case "TOTALTOSF"
                                        .TOTAL_TOSF = If(IsDBNull(row1("FeesAmount")), 0, row1("FeesAmount"))
                                End Select
                            Next
                        End If
                    End With
                    Form2.Add(obj)
                Next

            End If

            report.DataSource = Form2
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
            report.CreateDocument()
            report.ShowPreviewDialog

        Else
            'Form 3
            Dim Form3 As New List(Of BillingStatementForm3)
            Dim report As New XtraReport_BillingStatements_Form3

            report.xrlSchoolName.Text = COMPANY_NAME
            report.xrlAddress.Text = COMPANY_ADDRESS
            report.xrlRefNo.Text = RefNo
            report.xrlDate.Text = Format(BiilDate.Date, "dd-MMM-yy")

            Dim dt As New DataTable
            dt = Model.getSummaryTotalEntranceAdmissionFees(AppSetup_Domain, Semister, AcademicYear)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim obj As New BillingStatementForm3
                    With obj
                        .StudentID = row("id")
                        sequence_no = If(IsDBNull(row("SuquenceNumber")), 0, row("SuquenceNumber"))
                        .SuquenceNumber = String.Format("{0:D5}", CInt(sequence_no))
                        .StudentNumber = If(IsDBNull(row("StudentNumber")), " ", row("StudentNumber"))
                        .LastName = If(IsDBNull(row("LastName")), " ", row("LastName"))
                        .GivenName = If(IsDBNull(row("GivenName")), " ", row("GivenName"))
                        .MiddleName = If(IsDBNull(row("MiddleName")), " ", row("MiddleName"))
                        .Sex = If(IsDBNull(row("Sex")), " ", row("Sex"))
                        .BirthDate = If(IsDBNull(row("BirthDate")), " ", row("BirthDate"))
                        .DegreeProgram = If(IsDBNull(row("DegreeProgram")), " ", row("DegreeProgram"))
                        .YearLevel = If(IsDBNull(row("YearLevel")), " ", row("YearLevel"))
                        .Email = If(IsDBNull(row("Email")), " ", row("Email"))
                        .PhoneNumber = If(IsDBNull(row("PhoneNumber")), " ", row("PhoneNumber"))
                        .batch_id = If(IsDBNull(row("batch_id")), " ", row("batch_id"))
                        .EntranceAdmissionFees = If(IsDBNull(row("EntranceAdmissionFees")), 0, row("EntranceAdmissionFees"))
                        .Remarks = If(IsDBNull(row("Remarks")), "  ", row("Remarks"))
                    End With
                    Form3.Add(obj)
                Next
            End If

            report.DataSource = Form3
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
            report.CreateDocument()
            report.ShowPreviewDialog

        End If
        Cursor.Current = Cursors.Default

    End Sub

    Private Function checkOneTimePayments(FeesAmount As Object, ParticularID As Object, mode_payments As Object, sequence_no As Integer) As Double
        Dim amount As Double = 0
        If mode_payments = 2 Then
            If Model.checkOneTimePaymentsExist(ParticularID, sequence_no) = False Then
                Model.InsertStudentOnePayments(ParticularID, sequence_no, FeesAmount, SubjectBatchID)
                amount = FeesAmount
            Else
                amount = 0
            End If
        Else
            amount = FeesAmount
        End If

        Return amount
    End Function

    Dim FormType As String = ""
    Dim RefNo As String = ""
    Dim BiilDate As Date
    Dim Semister As String = ""
    Dim AcademicYear As String = ""
    Private Sub SelectRow(sender As Object, e As RowCellClickEventArgs)

        Try
            id = _view.gvBillingStatement.GetFocusedRowCellValue("id")
            FormType = _view.gvBillingStatement.GetFocusedRowCellValue("FORM TYPE")
            RefNo = _view.gvBillingStatement.GetFocusedRowCellValue("REFERENCE NUMBER")
            BiilDate = _view.gvBillingStatement.GetFocusedRowCellValue("BILLING DATE")
            Model.id = id
            Semister = _view.gvBillingStatement.GetFocusedRowCellValue("SEMISTER")
            AcademicYear = _view.gvBillingStatement.GetFocusedRowCellValue("ACADEMIC YEAR")
        Catch ex As Exception

        End Try


    End Sub

    Dim BillDate As Date
    Private Sub ShowCreatBilling(sender As Object, e As EventArgs)

        Dim button As DevComponents.DotNetBar.ButtonX = DirectCast(sender, DevComponents.DotNetBar.ButtonX)
        Dim Operation As String = ""
        If button.Text = "Add" Then
            Operation = "ADD"
        Else
            Operation = "EDIT"
        End If

        Dim frm As New frmBillingStatementCreat
        If Operation = "ADD" Then
            frm.Operation = Operation
        Else
            frm.Operation = Operation
        End If

        frm.Prensenter = Me
        frm.Model = Model
        frm.BringToFront()
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            BillDate = frm.dtpBillDate.Value
            loadList()
        End If


    End Sub

    Friend Sub Insert(billingStatement As BillingStatement, form1 As BillingStatement.Form1, formType As Integer, operation As String)

        Model.Insert(billingStatement, form1, formType, operation)


    End Sub

    Friend Sub _Insert(billingStatement As BillingStatement, form1 As BillingStatement.Form1, formType As Integer, operation As String)

        Model._Insert(billingStatement, form1, formType, operation)

    End Sub
End Class
