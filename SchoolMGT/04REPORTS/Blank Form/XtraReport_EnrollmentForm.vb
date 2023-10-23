Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraPrinting.Drawing

Public Class XtraReport_EnrollmentForm
    Private Sub PageFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageFooter.BeforePrint
        XrLcopyrigth.Text = copyrigth
    End Sub

    Private Sub XrPictureBox1_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrPictureBox1.BeforePrint

        'If Not File.Exists(COMPANY_HEADER_PATH) Then
        '    XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
        'Else
        '    XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
        'End If

    End Sub
End Class