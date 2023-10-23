Public Class XtraReport_BillingStatements_Form3
    Dim Count As Integer = 1
    Private Sub PageFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageFooter.BeforePrint

        If DevExpress.XtraPrinting.PageInfo.NumberOfTotal >= Count Then
            ReportFooter.Visible = True
        End If
        Count += 1
    End Sub
End Class