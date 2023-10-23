Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPdfViewer
Imports DevExpress.Utils
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraPrinting
Imports SchoolMGT
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevComponents.DotNetBar
Imports System.Web.UI.WebControls
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports GridView = DevExpress.XtraGrid.Views.Grid.GridView
Imports DevExpress.Data

Public Class StudentAdmissionListPresenter

    Dim _view As frmNewStudentAdmissionList
    Dim ListModel As New StudentAdmissionListModel
    Dim FromDate1 As Date
    Dim FromDate2 As Date
    Dim ToDate1 As Date
    Dim ToDate2 As Date
    Dim IncreasePercentage As New List(Of IncreasePercentage)
    Public Sub New(frm As frmNewStudentAdmissionList)
        _view = frm

        LoadHandler()
        LoadYear()
        Year(Date.Now)
        '    Refresh()

    End Sub



    Private Sub LoadYear()


        _view.cmbYearFrom.Items.Clear()

        For i As Integer = Year(Date.Now) To 2010 Step -1 'Year(Date.Now) - 1 To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            _view.cmbYearFrom.Items.Add(item)
        Next

        _view.cmbYearFrom.SelectedIndex = 0

        _view.cmbYearTo.Items.Clear()

        For i As Integer = Year(Date.Now) + 1 To 2010 Step -1  'Year(Date.Now) To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            _view.cmbYearTo.Items.Add(item)
        Next
        _view.cmbYearTo.SelectedIndex = 0


    End Sub

    Private Sub LoadHandler()
        AddHandler _view.cmbTypeFilter.SelectedIndexChanged, AddressOf SelectRecord
        AddHandler _view.btnSearch.Click, AddressOf LoadFilterList
        AddHandler _view.btnPrint.Click, AddressOf PrintReport
        AddHandler _view.gvStudentAdmission.CellMerge, AddressOf MergeColumn
        '    AddHandler _view.cmbstature.SelectedIndexChanged, AddressOf getIndex
        AddHandler _view.cmbstature.SelectionChangeCommitted, AddressOf getIndex
    End Sub

    Dim StatureIndex As String = ""
    Private Sub getIndex(sender As Object, e As EventArgs)
        StatureIndex = _view.cmbstature.SelectedIndex
    End Sub

    Private Sub PrintReport(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        Select Case FilterType
            Case 1
                Summry_Enrollment_Report()
            Case 2
                ComparativeData_Previous_Current_Year()
            Case Else
                ComparativeData_Transferred_Students()
        End Select

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub ComparativeData_Transferred_Students()

        Dim report As New XtraReport_Enrollment_Record


        'If Not File.Exists(COMPANY_HEADER_PATH) Then
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
        'Else
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
        'End If

        report.GroupHeader3.Visible = True
        report.GroupHeader2.Visible = False
        report.GroupHeader1.Visible = False
        report.GroupFooter1.Visible = True
        report.XrLblComparativeData_Header.Text = "AY " & _view.cmbYearFrom.Text & " TO " & _view.cmbYearTo.Text
        report.XrLbl_TransferredStudents_Header.Text = "OF " & _view.cmbstature.Text
        report.PrintableComponentContainer1.PrintableComponent = _view.gcStudentAdmission

        report.XrPanel_Signatory.Visible = True
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview


    End Sub

    Private Sub ComparativeData_Previous_Current_Year()

        Dim report As New XtraReport_Enrollment_Record


        'If Not File.Exists(COMPANY_HEADER_PATH) Then
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
        'Else
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
        'End If

        report.GroupHeader2.Visible = True
        report.GroupHeader3.Visible = False
        report.GroupHeader1.Visible = False
        report.GroupFooter1.Visible = True
        report.XrLblComparativeData_Header.Text = "AY " & _view.cmbYearFrom.Text & " TO " & _view.cmbYearTo.Text

        report.PrintableComponentContainer1.PrintableComponent = _view.gcStudentAdmission




        report.XrPanel_Signatory.Visible = True
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview



    End Sub

    Private Sub Summry_Enrollment_Report()

        Dim report As New XtraReport_Enrollment_Record


        'If Not File.Exists(COMPANY_HEADER_PATH) Then
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
        'Else
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
        'End If

        report.GroupHeader1.Visible = True
        report.GroupHeader3.Visible = False
        report.GroupHeader2.Visible = False
        report.GroupFooter1.Visible = False
        report.XrPanel_SummaryEnrollment.Visible = True
        report.XrLblSummryEnrollmentHeader.Text = ConvertString(_view.cmbSemister.Text, _view.cmbSemister.Tag,) & " ,ACADEMIC YEAR " & _view.cmbYearFrom.Text & "-" & _view.cmbYearTo.Text

        report.PrintableComponentContainer1.PrintableComponent = _view.gcStudentAdmission

        report.XrPanel_Signatory.Visible = True
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview

    End Sub

    Private Function ConvertString(text As String, tag As Object, Optional p As Object = Nothing) As String
        Dim newText As String = ""
        If tag = 1 Then
            If text.ToLower.Contains("1st").ToString.ToUpper Then
                newText = "FIRST SEMESTER"
            ElseIf text.ToLower.Contains("2nd") Then
                newText = "SECOND SEMESTER"
            Else
                newText = "SUMMER"
            End If

        End If
        Return newText
    End Function

    Private Sub MergeColumn(sender As Object, e As CellMergeEventArgs)
        Dim view As GridView = CType(sender, GridView)


        If (e.Column.FieldName = "PROGRAMS") Then

            Dim val1 As String = view.GetRowCellValue(e.RowHandle1, e.Column)
            Dim val2 As String = view.GetRowCellValue(e.RowHandle2, e.Column)
            e.Merge = (val1 = val2)
            e.Handled = True
        End If

    End Sub

    Private Sub LoadFilterList(sender As Object, e As EventArgs)
        Refresh()
    End Sub

    Dim FilterType As Integer

    Private Sub SelectRecord(sender As Object, e As EventArgs)

        Select Case _view.cmbTypeFilter.Text
            Case "Summary of Enrollment"
                FilterType = 1
                _view.Panel2.Visible = True
                _view.XtraTabControl2.Visible = True

                _view.XtraTabControl2.TabPages.Add(_view.XtraTabPage4)
                _view.XtraTabControl2.TabPages.Remove(_view.XtraTabPage6)

            Case "Comparative Data on Transfered Student"
                FilterType = 3
                _view.Panel2.Visible = True
                _view.XtraTabControl2.Visible = True

                _view.XtraTabControl2.TabPages.Remove(_view.XtraTabPage4)
                _view.XtraTabControl2.TabPages.Add(_view.XtraTabPage6)
            Case Else
                FilterType = 2
                _view.Panel2.Visible = False

        End Select



    End Sub

    Private Sub Refresh()

        _view.gvStudentAdmission.Columns.Clear()


        Dim dt As New DataTable


        Select Case FilterType
            Case 1
                dt = ListModel.getSummaryOfEnrollment(_view.cmbYearFrom.Text, _view.cmbYearTo.Text, _view.cmbSemister.Text)
                If dt.Rows.Count > 0 Then
                    _view.gcStudentAdmission.DataSource = dt

                    For i As Integer = 0 To _view.gvStudentAdmission.Columns.Count - 1
                        '  
                        Select Case i
                            Case 0
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                                _view.gvStudentAdmission.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

                            Case 5, 6, 7
                                _view.gvStudentAdmission.Columns(i).Visible = False
                            Case Else
                                _view.gvStudentAdmission.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                        End Select

                    Next
                    _view.gvStudentAdmission.Columns("YEAR LEVEL").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
                    _view.gvStudentAdmission.Columns("MALE").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
                    _view.gvStudentAdmission.Columns("FEMALE").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
                    _view.gvStudentAdmission.Columns("TOTAL").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
                    _view.gvStudentAdmission.OptionsView.AllowCellMerge = True

                End If

            Case 2, 3
                dt = Nothing
                '          dt = ListModel.getComparativeData_Previous_Current_Year(_view.cmbYearFrom.Text, _view.cmbYearTo.Text)
                dt = getDynamicList(_view.cmbYearFrom.Text, _view.cmbYearTo.Text, StatureIndex)
                If dt.Rows.Count > 0 Then
                    _view.gcStudentAdmission.DataSource = dt

                    For i As Integer = 0 To _view.gvStudentAdmission.Columns.Count - 1
                        '  
                        Select Case i
                            Case 0
                                _view.gvStudentAdmission.Columns(i).Caption = "PROGRAMS"
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                                _view.gvStudentAdmission.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

                            Case 2
                                _view.gvStudentAdmission.Columns(i).Visible = False
                            Case Else
                                _view.gvStudentAdmission.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                _view.gvStudentAdmission.Columns(i).AppearanceHeader.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                                _view.gvStudentAdmission.Columns(i).OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False

                        End Select

                    Next

                    _view.gvStudentAdmission.Columns("YEAR LEVEL").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
                    _view.gvStudentAdmission.OptionsView.AllowCellMerge = True

                    _view.gvStudentAdmission.OptionsView.ShowFooter = True

                    '_view.gvStudentAdmission.BeginUpdate()

                    Dim col As Integer = 0
                    Dim view As GridView = _view.gvStudentAdmission

                    For Each column As Columns.GridColumn In _view.gvStudentAdmission.Columns

                        If col > 2 Then

                            Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
                            item.FieldName = column.FieldName
                            item.ShowInGroupColumnFooter = view.Columns(column.FieldName)
                            item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            item.DisplayFormat = "{0:#}"

                            view.GroupSummary.Add(item)

                            column.Summary.Add(SummaryItemType.Sum, column.FieldName, "{0:#}")

                        ElseIf col = 1 Then

                            Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
                            item.FieldName = column.FieldName
                            item.ShowInGroupColumnFooter = view.Columns(column.FieldName)
                            item.SummaryType = DevExpress.Data.SummaryItemType.Count
                            item.DisplayFormat = "TOTAL = "

                            view.GroupSummary.Add(item)

                            column.Summary.Add(SummaryItemType.Count, column.FieldName, "TOTAL = ")
                        End If


                        col += 1

                    Next


                End If
                '  Case Else
                '    dt = Nothing

                '      dt = ListModel.getListOfTransferred(_view.cmbYearFrom.Text, _view.cmbYearTo.Text, _view.cmbstature.Text)

        End Select




    End Sub

    Dim listOfYear As New List(Of String)
    Private Function getDynamicList(FromYear As String, ToYear As String, Optional StatureIndex As Object = Nothing) As DataTable
        Dim dt As New DataTable
        Dim YearData As Integer = 0
        Dim Total As Integer = 0
        Dim cnt As Integer = 0

        listOfYear.Clear()

        For i As Integer = FromYear To ToYear - 1
            listOfYear.Add(i)
        Next

        dt = Nothing
        dt = ListModel.getDefaultColumn(FromYear, ToYear)

        If dt.Rows.Count > 0 Then

            For Each _year In listOfYear
                Total = 0
                YearData = ListModel.checkRecordOfTheYear(_year)
                       If YearData > 0 Then
                    dt.Columns.Add(_year)

                    Dim Total_Enrolled_ofthe_Year As Integer = 0
                    For x As Integer = 0 To dt.Rows.Count - 1
                        Total_Enrolled_ofthe_Year = ListModel.getTotalEnrolled(dt(x)("course_name"), dt(x)("year_level"), _year, StatureIndex)
                        Total += Total_Enrolled_ofthe_Year
                        dt(x)(_year) = Total_Enrolled_ofthe_Year
                    Next
                    cnt += 1
                    Dim obj As New IncreasePercentage
                    With obj
                        .Tag = cnt
                        .Year = _year
                        .Total = Total
                    End With
                    IncreasePercentage.Add(obj)
                End If


            Next



        End If

        Return dt
    End Function


End Class
