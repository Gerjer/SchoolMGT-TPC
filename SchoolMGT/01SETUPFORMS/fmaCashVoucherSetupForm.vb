Imports MySql.Data.MySqlClient

Public Class fmaCashVoucherSetupForm

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCatID.Text.Length = 0 Then
            MsgBox("Please Select Expense Type.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim finance_type As String = "Expense"
        Dim category_id As String = ""
        Dim created_at As String = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss")


        Dim SQLIN As String = "INSERT INTO finance_transactions(title,description"
        SQLIN += " ,amount,category_id"
        SQLIN += " ,created_at,transaction_date"
        SQLIN += " ,finance_type, address, voucher_no)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}', '{1}'", title.Text, Me.txtRemarks.Text)
        SQLIN += String.Format(",'{0}', '{1}'", Me.diAmount.Value, txtCatID.Text)
        SQLIN += String.Format(",'{0}', '{1}'", created_at, Format(dtpPayDate.Value, "yyyy-MM-dd"))
        SQLIN += String.Format(",'{0}', '{1}', '{2}')", finance_type, Me.address.Text, generateVoucherNumber)


        If clsDBConn.Execute(SQLIN) Then

            Dim new_report As New fzzReportViewerForm

            Dim SQLEX As String = "SELECT * FROM finance_transactions"
            SQLEX += " WHERE voucher_no ='" & txtVoucherNumber.Text & "'"


            new_report.AttachReport(SQLEX, "CASH VOUCHER") = New rpt_CashVoucher()
            new_report.Show()
        End If
    End Sub

    Private Sub fmaCashVoucherSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getCategoryCode()
        Me.txtVoucherNumber.Text = generateVoucherNumber()

        Me.dtpPayDate.Value = Date.Now
    End Sub


    Private Function generateVoucherNumber() As Integer
        Dim SQLEX As String = "SELECT voucher_no FROM finance_transactions"
        SQLEX += " ORDER BY voucher_no DESC"
        SQLEX += " LIMIT 1"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        Dim vcNum As Integer = 0
        If MeData.Rows.Count > 0 Then
            Try
                vcNum = MeData.Rows(0).Item("voucher_no")
            Catch ex As Exception

            End Try
        End If


        Dim retVal As Integer = vcNum + 1

        Return retVal
    End Function


    Private Sub getCategoryCode()
        Dim SQLEX As String = "SELECT id,UPPER(name) 'name' FROM finance_transaction_categories WHERE is_income=0"
        SQLEX += " and deleted <> 1"
       
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbType.DataSource = MeData

        cmbType.ValueMember = "id"
        cmbType.DisplayMember = "name"

        cmbType.SelectedIndex = -1
        txtCatID.Text = ""
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbType.SelectedItem, DataRowView)
            Me.txtCatID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub
End Class