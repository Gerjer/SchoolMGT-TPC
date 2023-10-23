Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class BlankFormListPresenter
    Private _view As frmBlankForm
    Dim ListModel As New BlankFormListModel
    Dim id As Integer
    Public Sub New(view As frmBlankForm)
        _view = view

        Loadlist()
        LoadHandler()

    End Sub

    Private Sub LoadHandler()
        AddHandler _view.btnPreview.Click, AddressOf PreviewPrint
        AddHandler _view.gvBlankForm.RowCellClick, AddressOf SelectRow

    End Sub

    Private Sub SelectRow(sender As Object, e As RowCellClickEventArgs)

    End Sub

    Private Sub PreviewPrint(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        id = _view.gvBlankForm.GetFocusedRowCellValue("id")
        Dim copies As Integer = 1
        Dim count As Integer = 1
        Dim page_total As Decimal
        Dim page As Integer = 1
        Dim str As String = ""
        Try

            If _view.nudCopies.Value > 1 Then
                page_total = (_view.nudCopies.Value / 2)
                page_total = Math.Round(page_total, 1, MidpointRounding.AwayFromZero)
                If CStr(page_total).ToString.Contains(".") Then
                    page_total = CInt(page_total) + 1
                Else
                    page_total = CInt(page_total)
                End If
            Else
                    page_total = _view.nudCopies.Value
            End If



            Select Case id
                Case 1 'Request Form'

                    Dim master_report As New XtraReport_RequestForm_MultiCopies

                    While page_total >= page

                        Dim report_repeater(page) As XtraReport_RequestForm_MultiCopies
                        report_repeater(page) = New XtraReport_RequestForm_MultiCopies

                        If _view.nudCopies.Value > 1 Then

                            While _view.nudCopies.Value >= copies

                                If _view.nudCopies.Value = copies Then
                                    'Check numbers Even or Odd
                                    Dim Mynumber As Integer
                                    Mynumber = Val(_view.nudCopies.Value)
                                    If Mynumber Mod 2 = 1 Then
                                        GoTo SingleCopies
                                    End If

                                End If

                                Dim report As New XtraReport_RequestForm

                                If count = 1 Then
                                    Dim Subreport1 As XRSubreport = TryCast(report_repeater(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                                    Subreport1.ReportSource = report
                                    count += 1
                                Else
                                    Dim Subreport2 As XRSubreport = TryCast(report_repeater(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                                    Subreport2.ReportSource = report
                                    count += 1
                                End If

                                If count = 3 Then
                                    count = 1
                                    copies += 1
                                    GoTo NextPage
                                End If

                                copies += 1

                            End While

NextPage:
                            report_repeater(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report_repeater(page).CreateDocument()
                            master_report.Pages.AddRange(report_repeater(page).Pages)

                        Else
SingleCopies:
                            Dim report(page) As XtraReport_RequestForm
                            report(page) = New XtraReport_RequestForm
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            master_report.Pages.AddRange(report(page).Pages)

                        End If

                        master_report.PrintingSystem.ContinuousPageNumbering = True

                        page += 1

                    End While

                    master_report.ShowPreview


                Case 2 ' Claim Stub

                    Dim master_report1 As New XtraReport_ClaimStub_MultiCopies

                    While page_total >= page

                        Dim report_repeater1(page) As XtraReport_ClaimStub_MultiCopies
                        report_repeater1(page) = New XtraReport_ClaimStub_MultiCopies

                        If _view.nudCopies.Value > 1 Then

                            While _view.nudCopies.Value >= copies

                                If _view.nudCopies.Value = copies Then
                                    'Check numbers Even or Odd
                                    Dim Mynumber As Integer
                                    Mynumber = Val(_view.nudCopies.Value)
                                    If Mynumber Mod 2 = 1 Then
                                        GoTo SingleCopies1
                                    End If

                                End If

                                Dim report As New XtraReport_ClaimStub

                                If count = 1 Then
                                    Dim Subreport1 As XRSubreport = TryCast(report_repeater1(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                                    Subreport1.ReportSource = report
                                    count += 1
                                Else
                                    Dim Subreport2 As XRSubreport = TryCast(report_repeater1(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                                    Subreport2.ReportSource = report
                                    count += 1
                                End If

                                If count = 3 Then
                                    count = 1
                                    copies += 1
                                    GoTo NextPage1
                                End If

                                copies += 1

                            End While

NextPage1:
                            report_repeater1(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report_repeater1(page).CreateDocument()
                            master_report1.Pages.AddRange(report_repeater1(page).Pages)

                        Else
SingleCopies1:
                            Dim report(page) As XtraReport_ClaimStub
                            report(page) = New XtraReport_ClaimStub
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            master_report1.Pages.AddRange(report(page).Pages)

                        End If

                        master_report1.PrintingSystem.ContinuousPageNumbering = True

                        page += 1

                    End While

                    master_report1.ShowPreview

                Case 3 'TES Application Form


                    If _view.nudCopies.Value > 3 Then
                        page_total = (_view.nudCopies.Value / 3)
                        page_total = Math.Round(page_total, 1, MidpointRounding.AwayFromZero)
                        If CStr(page_total).ToString.Contains(".") Then
                            page_total = CInt(page_total) + 1
                        Else
                            page_total = CInt(page_total)
                        End If
                    Else
                        page_total = 1
                    End If


                    Dim master_report2 As New XtraReport_TESApplication_MultiCopies

                    While page_total >= page

                        Dim report_repeater2(page) As XtraReport_TESApplication_MultiCopies
                        report_repeater2(page) = New XtraReport_TESApplication_MultiCopies

                        If _view.nudCopies.Value > 1 Then

                            While _view.nudCopies.Value >= copies

                                Dim report As New XtraReport_TES

                                If count = 1 Then
                                    Dim Subreport1 As XRSubreport = TryCast(report_repeater2(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                                    Subreport1.ReportSource = report
                                    count += 1
                                ElseIf count = 2 Then
                                    Dim Subreport2 As XRSubreport = TryCast(report_repeater2(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                                    Subreport2.ReportSource = report
                                    count += 1
                                Else
                                    Dim Subreport3 As XRSubreport = TryCast(report_repeater2(page).Bands(BandKind.Detail).FindControl("XrSubreport3", True), XRSubreport)
                                    Subreport3.ReportSource = report
                                    count += 1
                                End If

                                If count = 4 Then
                                    count = 1
                                    copies += 1
                                    GoTo NextPage2
                                End If

                                copies += 1

                            End While

NextPage2:

                            report_repeater2(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report_repeater2(page).CreateDocument()
                            master_report2.Pages.AddRange(report_repeater2(page).Pages)

                        Else
SingleCopies2:
                            Dim report(page) As XtraReport_TES
                            report(page) = New XtraReport_TES
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            master_report2.Pages.AddRange(report(page).Pages)


                        End If

                        master_report2.PrintingSystem.ContinuousPageNumbering = True

                        page += 1

                    End While

                    master_report2.ShowPreview

                Case 4 'Enrollment Form

                    Dim master_report3 As New XtraReport_EnrollmentForm_MultiCopies

                    While page_total >= page

                        Dim report_repeater3(page) As XtraReport_EnrollmentForm_MultiCopies
                        report_repeater3(page) = New XtraReport_EnrollmentForm_MultiCopies

                        If _view.nudCopies.Value > 1 Then

                            While _view.nudCopies.Value >= copies

                                Dim report As New XtraReport_EnrollmentForm

                                If count = 1 Then
                                    Dim Subreport1 As XRSubreport = TryCast(report_repeater3(page).Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
                                    Subreport1.ReportSource = report
                                    count += 1
                                Else
                                    Dim Subreport2 As XRSubreport = TryCast(report_repeater3(page).Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
                                    Subreport2.ReportSource = report
                                    count += 1
                                End If

                                If count = 3 Then
                                    count = 1
                                    copies += 1
                                    GoTo NextPage3
                                End If

                                copies += 1

                            End While

NextPage3:
                            report_repeater3(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report_repeater3(page).CreateDocument()
                            master_report3.Pages.AddRange(report_repeater3(page).Pages)

                        Else
                            'SingleCopies2:
                            Dim report(page) As XtraReport_EnrollmentForm
                            report(page) = New XtraReport_EnrollmentForm
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            master_report3.Pages.AddRange(report(page).Pages)

                        End If

                        master_report3.PrintingSystem.ContinuousPageNumbering = True

                        page += 1

                    End While

                    master_report3.ShowPreviewDialog

            End Select






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Cursor.Current = Cursors.Default


    End Sub

    Private Sub Loadlist()

        Dim dt As New DataTable
        dt = ListModel.getBlankFormRecord()
        _view.gcBlankForm.DataSource = dt

    End Sub
End Class
