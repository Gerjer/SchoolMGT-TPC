Public Class XtraReport_Billing_Statement_Form2
    Dim count As Integer = 1
    Private Sub PageFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageFooter.BeforePrint
        '      XrLGrandTotal.Text += XrLTotal.Text

        If DevExpress.XtraPrinting.PageInfo.Total >= count Then
            ReportFooter.Visible = True
            '      XrLGrandTotal.Text = GrandTotal
        End If
        count += 1

    End Sub

    Private Sub PageHeader_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageHeader.BeforePrint
        GroupHeader1.Visible = False
    End Sub

    'Dim GrandTotal As Double = 0
    'Private Sub GroupFooter1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
    '    GrandTotal += XrLTotal.Text
    'End Sub
End Class