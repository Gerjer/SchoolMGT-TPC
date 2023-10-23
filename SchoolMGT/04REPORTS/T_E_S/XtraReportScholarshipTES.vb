Public Class XtraReportScholarshipTES
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Sub PageFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageFooter.BeforePrint
        xrlcopyrigth.Text = copyrigth
    End Sub
End Class