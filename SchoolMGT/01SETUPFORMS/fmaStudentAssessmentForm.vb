Imports System.Threading
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting.Drawing

Public Class fmaStudentAssessmentForm

    Private IS_ENROLLED As Boolean = False

    Private TuitionFee_Lec As Double = 0
    Private TuitionFee_lab As Double = 0

    Private TOTAL_PAYABLES As Double = 0

    Private display_TuitionFee_Lec As String = ""
    Private display_TuitionFee_lab As String = ""

    Private m_AsyncWorker As New BackgroundWorker()

    Private HasLab As Boolean = False
    Dim ListModel As New StudentLearnersListModel
    Private Sub fmaStudentListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TabControl1.SelectedTabIndex = 0

        displayStudentsSubj()
        computeTuitionFee()
        displayStudentFees()
        displayEnrollmentStat()
        displayStudentPayable()

        'TabControl1.SelectedTabIndex = 1
    End Sub

    Private Sub displayEnrollmentStat()
        Dim withdrawalDate As String = ""
        Dim SQLEX As String = "SELECT CASE is_enrolled "
        SQLEX += " WHEN 1 THEN 'ENROLLED'"
        SQLEX += " WHEN 2 THEN 'WITHDRAWN'"
        SQLEX += " ELSE 'NOT ENROLLED'"
        SQLEX += " END AS 'status' , withdrawal_date, CAST(is_enrolled AS SIGNED INTEGER) AS 'is_enrolled'"

        SQLEX += " FROM students"
        SQLEX += " WHERE admission_no='" & Me.txtAdmissionNo.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            lblStatus.Text = MeData.Rows(0).Item("status").ToString
            Me.txtEnrollmentStat.Text = CInt(MeData.Rows(0).Item("is_enrolled"))
            If lblStatus.Text = "ENROLLED" Then
                IS_ENROLLED = True
                CheckBoxEnrolled.Checked = True
                CheckBoxEnrolled.Enabled = False
                btnPrintAssessment.Text = "Re-Print Assesment"

                GroupPanelWithdrawal.Visible = True
            ElseIf lblStatus.Text = "WITHDRAWN" Then
                CheckBoxEnrolled.Text = "Mark as Withdrawn"
                If Not IsDBNull(MeData.Rows(0).Item("withdrawal_date")) Then
                    lblStatus.Text += " - " & Format(MeData.Rows(0).Item("withdrawal_date"), "yyyy-MM-dd")
                End If


                IS_ENROLLED = True
                CheckBoxEnrolled.Checked = True
                CheckBoxEnrolled.Enabled = False
                btnPrintAssessment.Text = "Re-Print Assesment"

                GroupPanelWithdrawal.Visible = False
            Else
                IS_ENROLLED = False
                CheckBoxEnrolled.Checked = False
                btnPrintAssessment.Text = "Save and Print Assessment"
                GroupPanelWithdrawal.Visible = False
            End If
        End If

    End Sub

    Private Sub displayStudentsSubj()

        Dim SQLEX As String = ""

        If Me.txtCategoryName.Text = "COLLEGE" Then
            SQLEX = "SELECT  students.admission_no"
            SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid',subjects.no_exams"
            SQLEX += ", subject_class_schedule.name"
            SQLEX += ", subject_class_schedule.room"
            SQLEX += ", subject_class_schedule.employee_name"
            SQLEX += " FROM students_subjects"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
            SQLEX += " LEFT JOIN subject_class_schedule"
            SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
            SQLEX += " WHERE admission_no='" & txtAdmissionNo.Text & "'"

        Else
            'SQLEX = "SELECT  students.admission_no"
            'SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            'SQLEX += ", '' AS 'credit_hours', subjects.amount,subjects.id 'subjid',subjects.no_exams"
            'SQLEX += ", subject_class_schedule.name"
            'SQLEX += ", subject_class_schedule.room"
            'SQLEX += ", subject_class_schedule.employee_name"
            'SQLEX += " FROM students"
            'SQLEX += " INNER JOIN batches ON (students.batch_id = batches.id)"
            'SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
            'SQLEX += " INNER JOIN subjects ON (subjects.batch_id = students.batch_id)"
            'SQLEX += " LEFT JOIN subject_class_schedule ON (subject_class_schedule.subject_id = subjects.id)"
            'SQLEX += " WHERE subjects.elective_group_id IS NULL"
            'SQLEX += " AND subjects.is_deleted <> 1"
            'SQLEX += " AND admission_no='" & txtAdmissionNo.Text & "'"

            SQLEX = "SELECT  students.admission_no"
            SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid',subjects.no_exams"
            SQLEX += ", subject_class_schedule.name"
            SQLEX += ", subject_class_schedule.room"
            SQLEX += ", subject_class_schedule.employee_name"
            SQLEX += " FROM students_subjects"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
            SQLEX += " LEFT JOIN subject_class_schedule"
            SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
            SQLEX += " WHERE admission_no='" & txtAdmissionNo.Text & "'"

        End If




        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Me.tdbViewerSubjects.DataSource = MeData
        Me.tdbViewerSubjects.Rebind(True)

        Try
            With tdbViewerSubjects.Splits(0)
                .DisplayColumns("admission_no").Visible = False

                .DisplayColumns("subjCode").DataColumn.Caption = "CODE"
                .DisplayColumns("subjCode").Width = 200
                .DisplayColumns("subjCode").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("subjCode").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("subjname").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("subjname").Width = 450
                .DisplayColumns("subjname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("subjname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("credit_hours").DataColumn.Caption = "UNIT/S"
                .DisplayColumns("credit_hours").Width = 100
                .DisplayColumns("credit_hours").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("credit_hours").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                '.DisplayColumns("amount").DataColumn.Caption = "RATE/UNIT"
                '.DisplayColumns("amount").DataColumn.NumberFormat = "#,##0.00"
                '.DisplayColumns("amount").Width = 200
                '.DisplayColumns("amount").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.DisplayColumns("amount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("amount").Visible = False
                .DisplayColumns("subjid").Visible = False
                .DisplayColumns("no_exams").Visible = False

                .DisplayColumns("name").DataColumn.Caption = "SCHEDULE"
                .DisplayColumns("name").Width = 100
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("room").DataColumn.Caption = "ROOM"
                .DisplayColumns("room").Width = 100
                .DisplayColumns("room").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("room").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("employee_name").DataColumn.Caption = "INSTRUCTOR"
                .DisplayColumns("employee_name").Width = 200
                .DisplayColumns("employee_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("employee_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


                'employee_name


            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayStudentFees()
        Dim dt_fees As New DataTable
        Dim SQLEX As String = ""

        Dim MeData As DataTable

#Region "Old"
        ''CHECK IF ASSESSMENT WAS ALREADY CREATED.
        'Dim SQLEXIST As String = "SELECT masterfee,particulars,amount,total,stat,columnName FROM students_assessment"
        'SQLEXIST += " WHERE student_id ='" & Me.txtStudentID.Text & "'"

        'Dim ExistingData As DataTable

        'ExistingData = clsDBConn.ExecQuery(SQLEXIST)

        'If ExistingData.Rows.Count > 0 Then

        '    dt_fees.Columns.Add("FEE DESCRIPTION")
        '    dt_fees.Columns.Add("PARTICULARS")
        '    dt_fees.Columns.Add("AMOUNT")
        '    dt_fees.Columns.Add("TOTAL")
        '    dt_fees.Columns.Add("STAT")

        '    dgvFEES.Rows.Clear()

        '    SQLEX = "SELECT masterfee,particulars,amount,total,stat,columnName FROM students_assessment"
        '    SQLEX += " WHERE student_id ='" & Me.txtStudentID.Text & "'"



        '    MeData = clsDBConn.ExecQuery(SQLEX)

        '    If MeData.Rows.Count > 0 Then

        '        For nCtr As Integer = 0 To MeData.Rows.Count - 1
        '            dgvFEES.Rows.Add(New String() {MeData.Rows(nCtr).Item("masterfee").ToString, _
        '                                      MeData.Rows(nCtr).Item("particulars").ToString, _
        '                                      MeData.Rows(nCtr).Item("amount").ToString, _
        '                                      MeData.Rows(nCtr).Item("total").ToString})
        '            dt_fees.Rows.Add(New String() {MeData.Rows(nCtr).Item("masterfee").ToString, _
        '                                      MeData.Rows(nCtr).Item("particulars").ToString, _
        '                                      MeData.Rows(nCtr).Item("amount").ToString, _
        '                                      MeData.Rows(nCtr).Item("total").ToString})




        '        Next

        '    End If


        '    dgvFEES.ReadOnly = True
        '    Exit Sub
        'End If
#End Region



        'NO ASSESSMENT CREATED.
        Dim TOTAL_FEES As Double = 0


        dt_fees.Columns.Add("FEE DESCRIPTION")
        dt_fees.Columns.Add("PARTICULARS")
        dt_fees.Columns.Add("AMOUNT")
        dt_fees.Columns.Add("TOTAL")
        dt_fees.Columns.Add("STAT")

        dgvFEES.Rows.Clear()
        If Me.txtCategoryName.Text = "COLLEGE" Then
            ' add tuition according to enrolled subject
            dgvFEES.Rows.Add(New String() {"TUITION", "", "", Format(TuitionFee_Lec + TuitionFee_lab, "#,##0.00"), "-"})
            dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True

            dt_fees.Rows.Add(New String() {"TUITION", "", "", Format(TuitionFee_Lec + TuitionFee_lab, "#,##0.00"), "-"})
            If TuitionFee_Lec <> 0 Then
                dgvFEES.Rows.Add(New String() {"", "TUITION FEE LEC", Format(TuitionFee_Lec, "#,##0.00"), "", "-"})
                dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True

                dt_fees.Rows.Add(New String() {"", "TUITION FEE LEC", Format(TuitionFee_Lec, "#,##0.00"), "", "-"})

            End If

            If TuitionFee_lab <> 0 Then
                dgvFEES.Rows.Add(New String() {"", "TUITION FEE LAB", Format(TuitionFee_lab, "#,##0.00"), "", "-"})
                dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True
                dt_fees.Rows.Add(New String() {"", "TUITION FEE LAB", Format(TuitionFee_lab, "#,##0.00"), "", "-"})
            End If
        End If


        SQLEX = "SELECT finance_fee_categories.id, finance_fee_categories.name, SUM(finance_fee_particulars.amount),finance_fee_particulars.mode_payments,students.batch_id,students.enrollmentAS,students.class_roll_no"
        SQLEX += " FROM students"
        SQLEX += " INNER JOIN finance_fee_categories "
        SQLEX += " On (students.batch_id = finance_fee_categories.batch_id)"
        SQLEX += " INNER JOIN finance_fee_particulars "
        SQLEX += " On (finance_fee_particulars.finance_fee_category_id = finance_fee_categories.id)"
        SQLEX += " And finance_fee_particulars.is_deleted='0'"
        SQLEX += " WHERE students.admission_no='" & txtAdmissionNo.Text & "'"
        SQLEX += " GROUP BY finance_fee_categories.name"
        SQLEX += " ORDER BY id"

        MeData = Nothing
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim catname As String = ""
        Dim catid As String = ""
        Dim TotalAmt As String = ""
        Dim dt_fees_policy As New DataTable

        If MeData.Rows.Count > 0 Then
            For cnt As Integer = 0 To MeData.Rows.Count - 1

                'catname = MeData.Rows(cnt).Item("name").ToString
                'catid = MeData.Rows(cnt).Item("id").ToString
                'TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                'If MeData.Rows(cnt).Item("name").ToString = "ATHLETIC FEE" Then
                '    MsgBox("")
                'End If

                Dim mode_payment As String = MeData.Rows(cnt).Item("mode_payments").ToString
                Dim enroll_status As String = MeData.Rows(cnt).Item("enrollmentAS").ToString
                Dim class_roll_no As String = MeData.Rows(cnt).Item("class_roll_no").ToString
                Dim semester As String = txtSemester.Text

                dt_fees_policy = AddFees(mode_payment, enroll_status, semester)

                If dt_fees_policy.Rows.Count > 0 Then

                    If mode_payment = 3 And enroll_status = "OLD" And semester = "2ND SEMESTER" Then
                        Dim count As Integer = 0
                        count = DataObject(String.Format("SELECT count(DATE_FORMAT(admission_date,'%Y'))'Year' FROM students WHERE class_roll_no = '" & class_roll_no & "' AND DATE_FORMAT(admission_date,'%Y') = '" & Date.Now.Year & "'"))
                        If count = 2 Then
                            catname = MeData.Rows(cnt).Item("name").ToString
                            catid = MeData.Rows(cnt).Item("id").ToString
                            TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")
                        Else
                            Continue For
                        End If

                    Else

                        catname = MeData.Rows(cnt).Item("name").ToString
                        catid = MeData.Rows(cnt).Item("id").ToString
                        TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                    End If
                Else
                    If mode_payment = 1 Then

                        catname = MeData.Rows(cnt).Item("name").ToString
                        catid = MeData.Rows(cnt).Item("id").ToString
                        TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")
                    Else
                        Continue For
                    End If

                End If

#Region "olD"
                'If MeData.Rows(cnt).Item("mode_payments").ToString = 1 Then 'Default

                '    catname = MeData.Rows(cnt).Item("name").ToString
                '    catid = MeData.Rows(cnt).Item("id").ToString
                '    TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                'ElseIf MeData.Rows(cnt).Item("mode_payments").ToString = 2 And MeData.Rows(cnt).Item("enrollmentAS").ToString = "NEW" Then 'One Time
                '    If txtSemester.Text = "1ST SEMESTER" Or txtSemester.Text = "2ND SEMESTER" Then

                '        catname = MeData.Rows(cnt).Item("name").ToString
                '        catid = MeData.Rows(cnt).Item("id").ToString
                '        TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                '    End If
                'ElseIf MeData.Rows(cnt).Item("mode_payments").ToString = 3 Then 'Yearly
                '    If MeData.Rows(cnt).Item("enrollmentAS").ToString = "NEW" Then
                '        If txtSemester.Text = "1ST SEMESTER" Or txtSemester.Text = "2ND SEMESTER" Then

                '            catname = MeData.Rows(cnt).Item("name").ToString
                '            catid = MeData.Rows(cnt).Item("id").ToString
                '            TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                '            'Else 'Old
                '            '    If txtSemester.Text = "1ST SEMESTER" Then

                '            '        catname = MeData.Rows(cnt).Item("name").ToString
                '            '        catid = MeData.Rows(cnt).Item("id").ToString
                '            '        TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                '            '    End If
                '        End If

                '    Else
                '        If txtSemester.Text = "1ST SEMESTER" Then

                '            catname = MeData.Rows(cnt).Item("name").ToString
                '            catid = MeData.Rows(cnt).Item("id").ToString
                '            TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString), "#,##0.00")

                '        End If
                '    End If
                '        Else
                '        Continue For
                'End If



                'If catname.ToLower.Contains("lab") Then
                '    If HasLab = False Then
                '        Continue For

                '    End If
                'End If


#End Region
                TOTAL_FEES += CDbl(MeData.Rows(cnt).Item("SUM(finance_fee_particulars.amount)").ToString)
                dgvFEES.Rows.Add(New String() {catname, "", "", TotalAmt, "-"})
                dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = False 'True
                dt_fees.Rows.Add(New String() {catname, "", "", TotalAmt, "-"})

                Dim SQLEXDetails As String = "SELECT name, amount FROM finance_fee_particulars"
                SQLEXDetails += " WHERE finance_fee_category_id ='" & catid & "'"
                SQLEXDetails += " AND is_deleted !='1'"
                Dim inDataT As DataTable
                inDataT = clsDBConn.ExecQuery(SQLEXDetails)

                If inDataT.Rows.Count Then
                    For indataCtr As Integer = 0 To inDataT.Rows.Count - 1
                        Dim detailname As String = inDataT.Rows(indataCtr).Item("name").ToString
                        Dim amount As String = Format(CDbl(inDataT.Rows(indataCtr).Item("amount").ToString), "#,##0.00")

                        dgvFEES.Rows.Add(New String() {"", detailname, amount, "", "-"})
                        dt_fees.Rows.Add(New String() {"", detailname, amount, "", "-"})

                    Next
                End If


            Next

        End If

        TOTAL_FEES += TuitionFee_lab + TuitionFee_Lec

        Dim balance As Double = CDbl(getPreviousBalance())
        Dim discount As Double = CDbl(getDiscount())
        Dim TOTAL_BAL As Double = (TOTAL_FEES + balance) - discount



        dgvFEES.Rows.Add(New String() {"", "", "TOTAL", Format(TOTAL_FEES, "#,##0.00"), "++"})
        dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True
        dt_fees.Rows.Add(New String() {"", "", "TOTAL", Format(TOTAL_FEES, "#,##0.00"), "++"})

        dgvFEES.Rows.Add(New String() {"", "", "PREVIOUS BALANCE", getPreviousBalance(), "-+"})
        dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True
        dt_fees.Rows.Add(New String() {"", "", "PREVIOUS BALANCE", getPreviousBalance(), "-+"})

        dgvFEES.Rows.Add(New String() {"", "", "DISCOUNT", getDiscount(), "--"})
        dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True
        dt_fees.Rows.Add(New String() {"", "", "DISCOUNT", getDiscount(), "--"})

        dgvFEES.Rows.Add(New String() {"", "", "TOTAL PAYABLES", Format(TOTAL_BAL, "#,##0.00"), "T+"})
        dgvFEES.Item(2, dgvFEES.Rows.Count - 1).ReadOnly = True
        dt_fees.Rows.Add(New String() {"", "", "TOTAL PAYABLES", Format(TOTAL_BAL, "#,##0.00"), "T+"})

        report_dt_fees = New DataTable
        report_dt_fees = dt_fees
        TOTAL_PAYABLES = TOTAL_BAL

    End Sub

    Private Function AddFees(mode_payment As String, enroll_status As String, semester As String) As DataTable

        If enroll_status = "NEW" Or enroll_status = "TRANFEREE" Then
            enroll_status = "NEW"
        Else
            enroll_status = "OLD"
        End If

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                    fees_protocol.id,
                    fees_protocol.enroll_status,
                    fees_protocol.mode_payment,
                    fees_protocol.semester,
                    fees_protocol.`trigger`
                    FROM
                    fees_protocol
                    WHERE
                    fees_protocol.mode_payment = '" & mode_payment & "' AND
                    fees_protocol.enroll_status = '" & enroll_status & "' AND
                    fees_protocol.semester = '" & semester & "'
                    "))
        Return dt
    End Function

    Public Function getAddFees(mode_payment As String, enroll_status As String, semester As String) As Boolean

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                    fees_protocol.id,
                    fees_protocol.enroll_status,
                    fees_protocol.mode_payment,
                    fees_protocol.semester,
                    fees_protocol.`trigger`
                    FROM
                    fees_protocol
                    WHERE
                    fees_protocol.mode_payment = '" & mode_payment & "' AND
                    fees_protocol.enroll_status = '" & enroll_status & "' AND
                    fees_protocol.semester = '" & semester & "'
                    "))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub displayStudentPayable()
        Dim SQLEX As String = "SELECT description FROM fee_schedule"
        SQLEX += " WHERE student_category_id='" & txtCategoryID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim paymentCount As Integer = 1

        If MeData.Rows.Count > 0 Then

            Dim dt_paymode As New DataTable

            dt_paymode.Columns.Add("MODE OF PAYMENTS")
            dt_paymode.Columns.Add("AMOUNT")

            'dgvFEES.Rows.Clear()

            Dim paymodeRate As Double = TOTAL_PAYABLES / MeData.Rows.Count

            dgvPayment.Rows.Clear()
            For modecnt As Integer = 0 To MeData.Rows.Count - 1

                Dim paymentType As String = MeData.Rows(modecnt).Item("description").ToString

                dgvPayment.Rows.Add(New String() {paymentType, Format(paymodeRate, "#,##0.00")})
                dt_paymode.Rows.Add(New String() {paymentType, Format(paymodeRate, "#,##0.00")})
            Next
            dgvPayment.Rows.Add(New String() {"TOTAL INSTALLMENT", Format(TOTAL_PAYABLES, "#,##0.00")})
            dt_paymode.Rows.Add(New String() {"TOTAL INSTALLMENT", Format(TOTAL_PAYABLES, "#,##0.00")})

            report_dt_payables = dt_paymode

        End If



    End Sub

    Private Function getPreviousBalance() As String
        Dim SQLEX As String = "SELECT student_additional_fields.name"
        SQLEX += " , student_additional_details.student_id"
        SQLEX += " , student_additional_details.additional_info"
        SQLEX += " FROM student_additional_details"
        SQLEX += " INNER JOIN student_additional_fields "
        SQLEX += " ON (student_additional_details.additional_field_id = student_additional_fields.id)"
        SQLEX += " WHERE student_additional_fields.id='1'"
        SQLEX += " and student_id='" & txtStudentID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim prevBal As String = "0.00"
        If MeData.Rows.Count > 0 Then
            Dim value As Double = 0

            Try
                value = CDbl(MeData.Rows(0).Item("additional_info").ToString)
                prevBal = Format(value, "#,##0.00")

            Catch ex As Exception

            End Try
        End If


        Return prevBal
    End Function


    Private Function getDiscount() As String
        Dim SQLEX As String = "SELECT additional_info, student_additional_fields.id"
        SQLEX += " FROM student_additional_details"
        SQLEX += " INNER JOIN student_additional_fields"
        SQLEX += " ON (student_additional_details.additional_field_id = student_additional_fields.id)"
        SQLEX += " WHERE student_additional_fields.id ='2'"
        SQLEX += " and student_id='" & txtStudentID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        Dim prevBal As String = "0.00"
        If MeData.Rows.Count > 0 Then
            Dim value As Double = 0

            Try
                value = CDbl(MeData.Rows(0).Item("additional_info").ToString)
                prevBal = Format(value, "#,##0.00")

            Catch ex As Exception

            End Try
        End If


        Return prevBal
    End Function


    Private Sub computeTuitionFee()

        If Me.txtCategoryID.Text = "13" Then

            Dim rowcount As Integer = tdbViewerSubjects.RowCount

            For jRows As Integer = 0 To (rowcount - 1)
                'tdbViewerSubjects.Item(2, jRows).Value =

                Dim no_exams As String = tdbViewerSubjects.Columns("no_exams").CellText(jRows).ToString
                Dim subj As String = tdbViewerSubjects.Columns("subjname").CellText(jRows).ToString

                Dim amount As Double = CDbl(tdbViewerSubjects.Columns("amount").CellText(jRows).ToString)
                Dim Unit As Double = CDbl(tdbViewerSubjects.Columns("credit_hours").CellText(jRows).ToString)


                If no_exams = "False" Then '"0" 
                    TuitionFee_Lec += Unit * amount

                Else
                    TuitionFee_lab += Unit * amount
                    HasLab = True
                End If

            Next





        End If


    End Sub
    Private Sub setRunningBalance()

        'total paid
        ' check all payments
        Dim SQLPaymentsmade As String = "SELECT amount FROM finance_transactions"
        SQLPaymentsmade += " WHERE finance_id = '3'"
        SQLPaymentsmade += " AND payee_id='" & txtStudentID.Text & "'"
        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLPaymentsmade)

        Dim paymentdic As New List(Of Double)
        Dim TOTALPAYMENTSMADE As Double = 0

        If MeData.Rows.Count > 0 Then
            For modecnt As Integer = 0 To MeData.Rows.Count - 1
                Dim amount As Double = MeData.Rows(modecnt).Item("amount")
                TOTALPAYMENTSMADE += amount
                paymentdic.Add(amount)
            Next
        End If
        TOTAL_PAYABLES = TOTAL_PAYABLES - TOTALPAYMENTSMADE

        Dim SQLUP As String = "UPDATE students SET"
        SQLUP += " bal_edit='1',"
        SQLUP += " runningbalance='" & TOTAL_PAYABLES & "'"
        SQLUP += " WHERE id='" & txtStudentID.Text & "'"
        clsDBConn.ExecuteSilence(SQLUP)

        'Dim SQLTR As String = "SELECT payee_id FROM finance_transactions"
        'SQLTR += " WHERE payee_id='" & txtStudentID.Text & "'"
        'Dim MeData As DataTable

        'MeData = clsDBConn.ExecQuery(SQLTR)

        'If MeData.Rows.Count > 0 Then
        '    Exit Sub
        'End If



        'Dim SQLEX As String = "SELECT bal_edit FROM students"
        'SQLEX += " WHERE id='" & txtStudentID.Text & "'"


        'MeData = clsDBConn.ExecQuery(SQLEX)

        'If MeData.Rows.Count > 0 Then

        '    Dim EditRunningBalance As String = MeData.Rows(0).Item("bal_edit").ToString


        '    Dim SQLUP As String = "UPDATE students SET"
        '    SQLUP += " bal_edit='1',"
        '    SQLUP += " runningbalance='" & TOTAL_PAYABLES & "'"
        '    SQLUP += " WHERE id='" & txtStudentID.Text & "'"
        '    clsDBConn.ExecuteSilence(SQLUP)

        'End If


    End Sub


    Private Sub btnPrintAssessment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAssessment.Click

        Dim SQLEX As String = ""
        If Me.txtCategoryName.Text = "COLLEGE" Then
            SQLEX = "SELECT  students.admission_no"
            SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid',subjects.no_exams"
            SQLEX += ", subject_class_schedule.name"
            SQLEX += ", subject_class_schedule.room"
            SQLEX += ", UPPER(subject_class_schedule.employee_name) 'employee_name', students.is_enrolled"
            SQLEX += " FROM students_subjects"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
            SQLEX += " LEFT JOIN subject_class_schedule"
            SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
            SQLEX += " WHERE admission_no='" & txtAdmissionNo.Text & "'"
        Else
            'SQLEX = "SELECT  students.admission_no"
            'SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            'SQLEX += ", '' AS 'credit_hours', subjects.amount,subjects.id 'subjid',subjects.no_exams"
            'SQLEX += ", subject_class_schedule.name"
            'SQLEX += ", subject_class_schedule.room"
            'SQLEX += ", subject_class_schedule.employee_name"
            'SQLEX += " FROM students"
            'SQLEX += " INNER JOIN batches ON (students.batch_id = batches.id)"
            'SQLEX += " INNER JOIN courses ON (batches.course_id = courses.id)"
            'SQLEX += " INNER JOIN subjects ON (subjects.batch_id = students.batch_id)"
            'SQLEX += " LEFT JOIN subject_class_schedule ON (subject_class_schedule.subject_id = subjects.id)"
            'SQLEX += " WHERE subjects.elective_group_id IS NULL"
            'SQLEX += " AND subjects.is_deleted <> 1"
            'SQLEX += " AND admission_no='" & txtAdmissionNo.Text & "'"
            SQLEX = "SELECT  students.admission_no"
            SQLEX += ", subjects.code 'subjCode', subjects.name 'subjname' "
            SQLEX += ", subjects.credit_hours, subjects.amount,subjects.id 'subjid',subjects.no_exams"
            SQLEX += ", subject_class_schedule.name"
            SQLEX += ", subject_class_schedule.room"
            SQLEX += ", UPPER(subject_class_schedule.employee_name) 'employee_name', students.is_enrolled"
            SQLEX += " FROM students_subjects"
            SQLEX += " INNER JOIN students ON (students_subjects.student_id = students.id)"
            SQLEX += " INNER JOIN subjects ON (students_subjects.subject_id = subjects.id)"
            SQLEX += " LEFT JOIN subject_class_schedule"
            SQLEX += " ON (students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item)"
            SQLEX += " WHERE admission_no='" & txtAdmissionNo.Text & "'"
        End If

        If MessageBox.Show("STUDENT ASSESSMENT FOR :" & Me.txtStudentName.Text & vbNewLine & vbNewLine _
                           & "DO YOU WANT TO PRINT ASSESSMENT?", "Please Verify....", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.Yes Then

            displayStudentPayable()
            setRunningBalance()
            saveStudentAssessment()

            Dim new_report As New fzzReportViewerForm
            new_report.FolderName = "STUDENT ASSESSMENT SHEET"
            new_report.AttachReport(SQLEX, "ASSESSMENT " & Me.txtAdmissionNo.Text) =
        New rpt_CollegeStudentAssessmentReport(Me.txtSY.Text, Me.txtAdmissionNo.Text, Me.txtStudentName.Text,
                                               Me.txtCourse.Text, "", Me.txtSemester.Text, Me.txtYearLvl.Text, Me.txtEnrollmentStat.Text)

            new_report.Show()

        Else
            displayStudentPayable()
            setRunningBalance()
            saveStudentAssessment()

            Dim new_report As New fzzReportViewerForm
            new_report.FolderName = "STUDENT ASSESSMENT SHEET"
            new_report.AttachReport(SQLEX, "ASSESSMENT " & Me.txtAdmissionNo.Text) =
        New rpt_CollegeStudentAssessmentReport(Me.txtSY.Text, Me.txtAdmissionNo.Text, Me.txtStudentName.Text,
                                               Me.txtCourse.Text, "", Me.txtSemester.Text, Me.txtYearLvl.Text, Me.txtEnrollmentStat.Text)

            MsgBox("Student Assessment has been saved to 'STUDENT ASSESSMENT SHEET'", MsgBoxStyle.OkOnly, "SAVED DOCUMENTS")
        End If


    End Sub

    Private Sub dgvFEES_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFEES.CellEndEdit
        Dim rowIndex As Integer = e.RowIndex
        Dim colIndex As Integer = e.ColumnIndex


        'MsgBox("Row Index : " & rowIndex & vbNewLine & "Col Index : " & colIndex)
        Try

            dgvFEES.Item(colIndex, rowIndex).Value = Format(CDbl(dgvFEES.Item(colIndex, rowIndex).Value), "#,##0.00")
            dgvFEES.Item(colIndex + 1, rowIndex - 1).Value = Format(CDbl(dgvFEES.Item(colIndex, rowIndex).Value), "#,##0.00")


        Catch ex As Exception

        End Try
        recomputeTotalFees()
    End Sub

    Private Sub recomputeTotalFees()
        Dim totalValue As Double = 0
        Dim tempDT As New DataTable

        tempDT.Columns.Add("FEE DESCRIPTION")
        tempDT.Columns.Add("PARTICULARS")
        tempDT.Columns.Add("AMOUNT")
        tempDT.Columns.Add("TOTAL")
        tempDT.Columns.Add("STAT")

        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1



            Dim flag As String = dgvFEES.Item(4, nCtr).Value.ToString
            Dim value As String = dgvFEES.Item(3, nCtr).Value.ToString

            If flag = "-" And value <> "" Then
                totalValue += CDbl(value)
            End If
            If flag = "++" Then
                dgvFEES.Item(3, nCtr).Value = Format(totalValue, "#,##0.00")
            End If

            If flag = "-+" Then
                Dim prevBal As Double = 0
                If value <> "" Then
                    prevBal = CDbl(value)
                    totalValue = totalValue + prevBal
                    'dgvFEES.Item(3, nCtr).Value = Format(totalValue, "#,##0.00")
                End If
            End If

            If flag = "--" Then
                Dim discount As Double = 0
                If value <> "" Then
                    discount = CDbl(value)
                    totalValue = totalValue - discount
                    'dgvFEES.Item(3, nCtr).Value = Format(totalValue, "#,##0.00")
                End If
            End If

            If flag = "T+" Then
                dgvFEES.Item(3, nCtr).Value = Format(totalValue, "#,##0.00")
                TOTAL_PAYABLES = totalValue
            End If

            tempDT.Rows.Add(New String() {dgvFEES.Item(0, nCtr).Value.ToString,
                                          dgvFEES.Item(1, nCtr).Value.ToString,
                                          dgvFEES.Item(2, nCtr).Value.ToString,
                                          dgvFEES.Item(3, nCtr).Value.ToString,
                                          dgvFEES.Item(4, nCtr).Value.ToString})



        Next

        report_dt_fees = New DataTable
        report_dt_fees = tempDT

        'dgvFEES.Item(3, dgvFEES.Rows.Count - 1).Value = Format(totalValue, "#,##0.00")
    End Sub

    Private Sub saveStudentAssessment()

        'remove all assessment first
        Dim SQLDEL As String = "DELETE FROM students_assessment WHERE student_id='" & Me.txtStudentID.Text & "'"
        clsDBConn.ExecuteSilence(SQLDEL)

        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1
            Dim SQLIN As String = "INSERT INTO students_assessment(student_id,masterfee,particulars,amount,total,stat,columnName)"
            SQLIN += " VALUES("

            If dgvFEES.Item(1, nCtr).Value.ToString = "" And dgvFEES.Item(2, nCtr).Value.ToString = "" Then
                SQLIN += String.Format("'{0}'", Me.txtStudentID.Text)
                SQLIN += String.Format(",'{0}', '{1}'", dgvFEES.Item(0, nCtr).Value, dgvFEES.Item(1, nCtr).Value)
                SQLIN += String.Format(",'{0}', '{1}'", dgvFEES.Item(2, nCtr).Value, dgvFEES.Item(3, nCtr).Value)
                SQLIN += String.Format(",'{0}','{1}')", dgvFEES.Item(4, nCtr).Value, "H")
            Else
                SQLIN += String.Format("'{0}'", Me.txtStudentID.Text)
                SQLIN += String.Format(",'{0}', '{1}'", dgvFEES.Item(0, nCtr).Value, dgvFEES.Item(1, nCtr).Value)
                SQLIN += String.Format(",'{0}', '{1}'", dgvFEES.Item(2, nCtr).Value, dgvFEES.Item(3, nCtr).Value)
                SQLIN += String.Format(",'{0}','{1}')", dgvFEES.Item(4, nCtr).Value, "D")
            End If



            clsDBConn.Execute(SQLIN)
        Next


    End Sub

    Private Sub CheckBoxEnrolled_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxEnrolled.CheckStateChanged
        If CheckBoxEnrolled.Checked = True Then
            If Not IS_ENROLLED Then
                Dim SQLEX As String = ""
                If txtGrant.Text.Length > 0 Then
                    SQLEX = "UPDATE students SET is_enrolled='" & 1 & "'"
                    SQLEX += ", runningbalance='0'"
                    SQLEX += " WHERE id='" & txtStudentID.Text & "'"
                Else
                    SQLEX = "UPDATE students SET is_enrolled='" & 1 & "'"
                    SQLEX += " WHERE id='" & txtStudentID.Text & "'"
                End If

                If clsDBConn.Execute(SQLEX) Then
                    lblStatus.Text = "ENROLLED"
                    MsgBox("Enrollment Status has been changed.")
                    IS_ENROLLED = True
                End If
            End If
        Else
            If IS_ENROLLED Then
                Dim SQLEX As String = "UPDATE students SET is_enrolled='" & 0 & "'"
                SQLEX += " WHERE id='" & txtStudentID.Text & "'"
                If clsDBConn.Execute(SQLEX) Then
                    lblStatus.Text = "NOT ENROLLED"
                    MsgBox("Enrollment Status has been changed.")
                    IS_ENROLLED = False
                End If
            End If
        End If



    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        fmaStudentListForm.displayFilterCategory()
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Cursor.Current = Cursors.WaitCursor

        PrintCORNew(sender, e)

        Cursor.Current = Cursors.Default

    End Sub

    Dim COR_info As New Student_COR
    Dim Subject_info As New List(Of COR_Subject_Details)
    Dim Assessment_info As New List(Of COR_Assessment_Details)
    Dim Default_LogoPath As String = Directory.GetCurrentDirectory & "\TPC_logo.jpg"


    Private Sub PrintCORNew(sender As Object, e As EventArgs)

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

            If Not File.Exists(COMPANY_LOGO_PATH) Then
                report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
            Else
                report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
            End If

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

    Private Sub CheckBoxWithdraw_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxWithdraw.CheckStateChanged
        If CheckBoxWithdraw.Checked Then
            If MessageBox.Show("Are you sure you want to Withdraw Enrollment on this Student?", "Process Cannot be Undone....", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
                Dim SQLEX As String = ""
                Dim currentDate As String = Format(Date.Now, "yyyy-MM-dd")
                If txtGrant.Text.Length > 0 Then
                    SQLEX = "UPDATE students SET is_enrolled='" & 2 & "'"
                    SQLEX += ", runningbalance='0', withdrawal_date='" & currentDate & "'"
                    SQLEX += " WHERE id='" & txtStudentID.Text & "'"
                Else
                    SQLEX = "UPDATE students SET is_enrolled='" & 2 & "' , withdrawal_date='" & currentDate & "'"
                    SQLEX += " WHERE id='" & txtStudentID.Text & "'"
                End If

                If clsDBConn.Execute(SQLEX) Then

                    MsgBox("Withdrawal Status has been changed.")
                    IS_ENROLLED = True
                    CheckBoxWithdraw.Visible = False

                    GroupPanelWithdrawal.Visible = False
                    CheckBoxEnrolled.Text = "Mark as Withdrawn"
                    CheckBoxEnrolled.Enabled = False
                    lblStatus.Text = "WITHDRAWN - " & currentDate
                    txtEnrollmentStat.Text = "2"

                End If
            Else
                CheckBoxWithdraw.Checked = False
            End If


        End If



    End Sub

End Class