Imports System.Threading
Imports System.ComponentModel

Public Class fmaRPT_IncomeExpenseForm
    Dim firstLoad As Boolean = True
    
    Private Sub fmaRPT_IncomeExpenseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Now
        dtpTo.Value = Date.Now

        firstLoad = False
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        If firstLoad Then
            Exit Sub
        End If

        If dtpFrom.Value > dtpTo.Value Then
            MsgBox("Date Beginning should not be above Date End filter.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        pbxSearch.Visible = True
        Timer1.Enabled = True
        rollingSpinner.Visible = True
        stillSpinner.Visible = False
        lblStatus.Text = "Generating Report.."

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tick As Integer = CInt(lblTimer.Text)

        lblTimer.Text = tick + 1

        If tick = 1 Then
            Timer1.Enabled = False
            lblTimer.Text = "0"
            generateIncomeExpenseReport()
            lblStatus.Text = "Done."
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
            pbxSearch.Visible = False

        End If
    End Sub

    Private Sub generateIncomeExpenseReport()
        tdbViewer.DataSource = Nothing
        Dim MeData As DataTable

        Dim SQL As String = "SELECT finance_transaction_categories.id, UPPER(finance_transaction_categories.name) 'name'"
        SQL += " , CASE WHEN is_income='0' THEN"
        SQL += " FORMAT(SUM(finance_transactions.amount) ,2)"
        SQL += " ELSE"
        SQL += " '0.00'"
        SQL += " END  'EXPENSE'"
        SQL += " , CASE WHEN is_income='1' THEN"
        SQL += " FORMAT(SUM(finance_transactions.amount) ,2)"
        SQL += " ELSE"
        SQL += " '0.00'"
        SQL += " END  'INCOME'"
        SQL += " FROM finance_transactions"
        SQL += " INNER JOIN finance_transaction_categories "
        SQL += " ON (finance_transactions.category_id = finance_transaction_categories.id)"
        SQL += " WHERE transaction_date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "'"
        SQL += " AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"


        SQL += " GROUP BY ID"


        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").Visible = False

                .DisplayColumns("name").DataColumn.Caption = "PARTICULARS/DESCRIPTION"
                .DisplayColumns("name").Width = 250
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("EXPENSE").DataColumn.Caption = "EXPENSES(P)"
                .DisplayColumns("EXPENSE").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("EXPENSE").Width = 150
                .DisplayColumns("EXPENSE").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("EXPENSE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("INCOME").DataColumn.Caption = "INCOME(P)"
                .DisplayColumns("INCOME").DataColumn.NumberFormat = "#,##0.00"
                .DisplayColumns("INCOME").Width = 150
                .DisplayColumns("INCOME").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("INCOME").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far



            End With
        Catch ex As Exception

        End Try

        MeData = Nothing
    End Sub

    Private Sub tdbViewer_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbViewer.DataSourceChanged
        If tdbViewer.RowCount > 0 Then
            btnPrint.Enabled = True
        Else
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click



        Try
            Dim new_report As New fzzReportViewerForm

            

            Dim SQLEX As String = "SELECT finance_transaction_categories.id, UPPER(finance_transaction_categories.name) 'name'"
            SQLEX += " ,finance_transactions.title"
            SQLEX += " , CASE WHEN is_income='0' THEN"
            SQLEX += " finance_transactions.amount "
            SQLEX += " ELSE"
            SQLEX += " '0.00'"
            SQLEX += " END  'EXPENSE'"
            SQLEX += " , CASE WHEN is_income='1' THEN"
            SQLEX += " finance_transactions.amount"
            SQLEX += " ELSE"
            SQLEX += " '0.00'"
            SQLEX += " END  'INCOME'"
            SQLEX += String.Format(" ,'{0}' AS 'dtpfrom'", Format(dtpFrom.Value, "yyyy-MMMM-dd"))
            SQLEX += String.Format(" ,'{0}' AS 'dtpto'", Format(dtpTo.Value, "yyyy-MMMM-dd"))
            SQLEX += " FROM finance_transactions"
            SQLEX += " INNER JOIN finance_transaction_categories "
            SQLEX += " ON (finance_transactions.category_id = finance_transaction_categories.id)"
            SQLEX += " WHERE transaction_date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "'"
            SQLEX += " AND '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"
            SQLEX += " ORDER BY id"

            new_report.AttachReport(SQLEX, "INCOME EXPENSE PRINTING " & "Income and Expense Summary") = New rpt_IncomeExpeseList



            new_report.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class