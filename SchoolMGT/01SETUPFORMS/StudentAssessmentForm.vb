Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Xls

Public Class StudentAssessmentForm

    Public Event REPORTSTARTS()
    Public Event REPORTCLOSED()

    Public DirectPrinting As Boolean = False
    Private WithEvents MeAR As ActiveReport3

    Public Property AttachReport(ByVal SQLstring As String, ByVal Title As String)
        Get
            Return MeAR
        End Get
        Set(ByVal value)
            MeAR = value

            If Title.Trim <> "" Then
                Me.Text = Title
            End If

            If SQLstring.Trim <> "" Then
                Me.WindowState = FormWindowState.Maximized
                MeViewer.Document.Printer.PrinterName = ""
                MeViewer.Document = MeAR.Document

                MeAR.DataSource = clsDBConn.ExecQuery(SQLstring)
                MeAR.Run(True)

                MeViewer.ReportViewer.Zoom = -1
            End If
        End Set
    End Property

    Private Sub btnExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelExport.Click
        Dim NewExport As New XlsExport
        Dim FileName As String = "C:\Report\" & Me.Text & ".xls"
        NewExport.FileFormat = FileFormat.Xls97Plus
        Try
            If System.IO.File.Exists(FileName) Then
                Try
                    My.Computer.FileSystem.DeleteFile(FileName)
                Catch ex As Exception
                End Try
            End If

            NewExport.Export(MeAR.Document, FileName)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Print()
        If DirectPrinting Then
            MeAR.Document.Print(False, True, True)
        End If
    End Sub

    Private Sub MeAR_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MeAR.ReportEnd
        RaiseEvent REPORTSTARTS()
    End Sub

    Private Sub fzzReportViewerForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent REPORTCLOSED()
    End Sub


    Public Sub exportPDF()
        Dim FileName As String = "C:\Report\" & Me.Text & ".pdf"

        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        Process.Start(FileName)
    End Sub

    Public Sub exportPDF(ByVal fileName As String)


        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        fileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, fileName)
        ExportPDF = Nothing

    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        exportPDF()
    End Sub
End Class