
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rpt_IncomeExpeseList

    Private Sub rpt_IncomeExpeseList_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        txtDate.Text = Format(Date.Now, "yyyy-MMMM-dd")
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS
        '     Picture1.Image = COMPANY_IMAGE

    End Sub
End Class
