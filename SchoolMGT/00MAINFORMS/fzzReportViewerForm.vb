Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Xls
Imports System.Configuration
Imports DevExpress.DataAccess

Public Class fzzReportViewerForm

    Private SQLCMD As String = ""

    Public Event REPORTSTARTS()
    Public Event REPORTCLOSED()

    Public DirectPrinting As Boolean = False
    Private WithEvents MeAR As ActiveReport3

    Public FolderName As String = ""
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
                Me.SQLCMD = SQLstring
                Me.WindowState = FormWindowState.Maximized
                MeViewer.Document.Printer.PrinterName = ""
                MeViewer.Document = MeAR.Document

                MeAR.DataSource = clsDBConn.ExecQuery(SQLstring)
                MeAR.Run(True)

                MeViewer.ReportViewer.Zoom = -1

                SaveDocs()

            End If
        End Set
    End Property

    Dim _directory_info As DirectoryInfo
    Dim appSettings As String = ""

    Private Sub SaveDocs()

        Dim spath As String = ""

        If clsDBConn.ServerName = "localhost" Then


            If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
            End If

            spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
        Else

            If SavingDir = "local.dir" Then
                If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                    System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
                End If

                spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
            Else
                appSettings = ConfigurationManager.AppSettings("Server_TRANSACTION_DOC_Path")
                _directory_info = New DirectoryInfo(appSettings)
                spath = _directory_info.FullName
            End If

        End If

        If (Not System.IO.Directory.Exists(Path.Combine(spath, FolderName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, FolderName))
        End If

        Dim FileName As String = spath & "\" & FolderName & "\" & Me.Text & ".pdf"

        If File.Exists(FileName) Then
            File.Delete(FileName)
        End If

        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        '      Process.Start(FileName)

    End Sub

    Dim copy As Integer = 0
    Private Sub btnExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelExport.Click


        Dim spath As String = ""

        If clsDBConn.ServerName = "localhost" Then

            If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
            End If

            spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
        Else

            If SavingDir = "local.dir" Then
                If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                    System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
                End If

                spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
            Else
                appSettings = ConfigurationManager.AppSettings("Server_TRANSACTION_DOC_Path")
                _directory_info = New DirectoryInfo(appSettings)
                spath = _directory_info.FullName
            End If

        End If

        FolderName = "EXPORTED DOC"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, FolderName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, FolderName))
        End If

        Dim FileName As String = spath & "\" & FolderName & "\" & Me.Text & ".xls"

        If File.Exists(FileName) Then
            File.Delete(FileName)
        End If

        Dim NewExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport
        NewExport.MultiSheet = True
        NewExport.Export(MeAR.Document, FileName)
        NewExport = Nothing
        Process.Start(FileName)

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


        Dim spath As String = ""

        If clsDBConn.ServerName = "localhost" Then

            If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
            End If

            spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
        Else

            If SavingDir = "local.dir" Then
                If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                    System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
                End If

                spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
            Else
                appSettings = ConfigurationManager.AppSettings("Server_TRANSACTION_DOC_Path")
                _directory_info = New DirectoryInfo(appSettings)
                spath = _directory_info.FullName
            End If

        End If

        FolderName = "EXPORTED DOC"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, FolderName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, FolderName))
        End If

        Dim FileName As String = spath & "\" & FolderName & "\" & Me.Text & ".pdf"

        If File.Exists(FileName) Then
            File.Delete(FileName)
        End If


        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        Process.Start(FileName)
    End Sub

    'Public Sub exportPDF(ByVal fileName As String)


    '    Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
    '    ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
    '    fileName += ".Pdf"
    '    ExportPDF.Export(MeAR.Document, fileName)
    '    ExportPDF = Nothing

    'End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        exportPDF()
    End Sub


    Private Sub btnrtf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrtf.Click


        Dim spath As String = ""

        If clsDBConn.ServerName = "localhost" Then

            If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
            End If

            spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
        Else

            If SavingDir = "local.dir" Then
                If Not System.IO.Directory.Exists(Directory.GetCurrentDirectory & "\TRANSACTION DOC") Then
                    System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory & "\TRANSACTION DOC")
                End If

                spath = Directory.GetCurrentDirectory & "\TRANSACTION DOC"
            Else
                appSettings = ConfigurationManager.AppSettings("Server_TRANSACTION_DOC_Path")
                _directory_info = New DirectoryInfo(appSettings)
                spath = _directory_info.FullName
            End If

        End If

        FolderName = "EXPORTED DOC"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, FolderName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, FolderName))
        End If

        Dim FileName As String = spath & "\" & FolderName & "\" & Me.Text & ".rtf"

        If File.Exists(FileName) Then
            File.Delete(FileName)
        End If

        Dim ExportRTF As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
        FileName += ".rtf"
        ExportRTF.Export(MeAR.Document, FileName)
        ExportRTF = Nothing

        Process.Start(FileName)
    End Sub
End Class