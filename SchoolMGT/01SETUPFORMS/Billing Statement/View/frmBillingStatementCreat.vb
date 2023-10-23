Imports DevComponents.DotNetBar

Public Class frmBillingStatementCreat

    Public Prensenter As BillingStatementPresenter
    Public Model As BillingStatementModel

    Dim TypeOfBiiling As String = ""
    Dim FormType As Integer
    Dim Billing As New BillingStatement
    Dim Form1 As New BillingStatement.Form1
    Public Operation As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim HE_amount As Double = 0
        Dim Semister As String = ""
        Dim AcademicYear As String = ""
        If nudAmount.Value > 0 Then
            TypeOfBiiling = "CONSOLIDATED"
            FormType = 1
            Semister = cmbTerm.Text
            AcademicYear = txtAcademicYear.Text
            HE_amount = nudAmount.Value
        Else
            If rdbtnAdmissionFee.Checked = True Then
                TypeOfBiiling = "ADMISSION FEE"
                FormType = 3
                HE_amount = nudTotalAmt.Value 'Model.getSummaryEntranceAdmissionFee(dtpBillDate.Value)
                Semister = cmbSemister.Text
                AcademicYear = cmbFromYear.Text & "-" & cmbToYear.Text
            Else
                TypeOfBiiling = "TOSF"
                FormType = 2
                HE_amount = nudTotalAmt.Value  'Model.getSummaryTotalTOSF(dtpBillDate.Value)
                Semister = cmbSemister.Text
                AcademicYear = cmbFromYear.Text & "-" & cmbToYear.Text
            End If
        End If

        If txtRefNo.Text = "" Then
            MsgBox("Required Fields....")
            Exit Sub
        Else
            If FormType = 1 Then
                If nudAmount.Value = 0 Then
                    MsgBox("Required Fields....")
                    Exit Sub
                End If
            ElseIf FormType = 2 Then
                If rdbtnTOSF.Checked = False Then
                    MsgBox("Required Fields....")
                    Exit Sub
                End If
            Else
                If rdbtnAdmissionFee.Checked = False Then
                    MsgBox("Required Fields....")
                    Exit Sub
                End If
            End If
        End If

        With Billing
            .billing_formtype_id = FormType
            .billing_reference_no = txtRefNo.Text
            .billing_date = dtpBillDate.Value
            .billing_type = TypeOfBiiling
            .amount = HE_amount
            .user_id = LoginUserID
            .Semister = Semister
            .AcademicYear = AcademicYear
        End With


        If FormType = 1 Then
            With Form1
                .billing_formtype_id = FormType
                .term = Semister
                .accountcode = txtAccountCode.Text
                .academic_year = AcademicYear
                .amount1 = HE_amount
            End With
        End If

        Prensenter._Insert(Billing, Form1, FormType, Operation)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBillingStatementCreat_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim _date As String = Year(Date.Now)
        Dim maskTBOX As New System.Windows.Forms.MaskedTextBox
        maskTBOX.Mask = "XX - XXXXXX - " & _date & " - " & "X" & " - " & "X"
        txtRefNo.Text = maskTBOX.Text

        If Me.Tag = 1 Then
            TabItem13.Visible = True
            TabItem14.Visible = False
        ElseIf Me.Tag = 2 Then
            rdbtnTOSF.Checked = True
            TabItem13.Visible = False
            TabItem14.Visible = True
            '  btnGenerate.Text = "Generate Total Amount of TOSF"
            LabelX7.Text = "TOTAL TOSF :"
        Else
            rdbtnAdmissionFee.Checked = True
            TabItem13.Visible = False
            TabItem14.Visible = True
            '    btnGenerate.Text = "Generate Total Amount of Admission Fees"
            LabelX7.Text = "TOTAL Admission Fees :"
        End If

        LoadYear()
    End Sub

    Private Sub LoadYear()

        cmbFromYear.Items.Clear()

        For i As Integer = Year(Date.Now) To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            cmbFromYear.Items.Add(item)
        Next

        cmbFromYear.SelectedIndex = 0

        cmbToYear.Items.Clear()

        For i As Integer = Year(Date.Now) To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            cmbToYear.Items.Add(item)
        Next
        cmbToYear.SelectedIndex = 0


    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim jointStr As String = ""

        'If chk1st.Checked = True And chk2nd.Checked = True And chk3rd.Checked = True Then
        '    jointStr = "1ST SEMESTER,2ND SEMESTER,SUMMER"
        'ElseIf chk1st.Checked = True And chk2nd.Checked = True And chk3rd.Checked = False Then
        '    jointStr = "1ST SEMESTER,2ND SEMESTER"
        'ElseIf chk1st.Checked = True And chk2nd.Checked = False And chk3rd.Checked = False Then
        '    jointStr = "1ST SEMESTER"
        'ElseIf chk1st.Checked = False And chk2nd.Checked = True And chk3rd.Checked = True Then
        '    jointStr = "2ND SEMESTER,SUMMER"
        'ElseIf chk1st.Checked = False And chk2nd.Checked = True And chk3rd.Checked = False Then
        '    jointStr = "2ND SEMESTER"
        'Else
        '    jointStr = "SUMMER"
        'End If


        nudTotalAmt.Value = Model.generateTotalAmount(Me.Tag, cmbFromYear.Text, cmbToYear.Text, cmbSemister.Text)

    End Sub

    Private Sub cmbSemister_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSemister.SelectionChangeCommitted

        btnGenerate.Enabled = True

    End Sub
End Class