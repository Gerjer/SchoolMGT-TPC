Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class TESApplicationListPresenter
    Private _view As frmTESApplicationList
    Dim ListModel As New TESApplicationListModel
    Dim id As Integer
    Public Sub New(frmTESApplicationList As frmTESApplicationList)
        _view = frmTESApplicationList

        _view.gcTESApplication.Focus()
        loadComboBox()
        LoadYear()
        loadList()
        loadHandler()
    End Sub

    Private Sub loadComboBox()
        _view.cmbUII.DataSource = ListModel.getUII()
        _view.cmbUII.ValueMember = "ID"
        _view.cmbUII.DisplayMember = "Name"
        _view.cmbUII.SelectedIndex = -1
    End Sub

    Private Sub LoadYear()

        _view.cmbFromYear.Items.Clear()

        For i As Integer = Year(Date.Now) - 1 To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            _view.cmbFromYear.Items.Add(item)
        Next

        _view.cmbFromYear.SelectedIndex = 0

        _view.cmbToYear.Items.Clear()

        For i As Integer = Year(Date.Now) To 2000 Step -1
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            _view.cmbToYear.Items.Add(item)
        Next
        _view.cmbToYear.SelectedIndex = 0


    End Sub

    Private Sub loadHandler()

        AddHandler _view.btnAdd.Click, AddressOf AddRecord
        AddHandler _view.btnEdit.Click, AddressOf EditRecord
        AddHandler _view.btnGenerate.Click, AddressOf GenerateHEIUII
        AddHandler _view.btnPrint.Click, AddressOf PrintReportTES
        AddHandler _view.gvTESApplication.RowCellClick, AddressOf SelectedRow


    End Sub

    Private Sub PrintReportTES(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        If _view.cmbUII.Text.Length = 0 Then
            Exit Sub
        Else
            If ListModel.CheckUII(_view.cmbUII.SelectedValue, _view.cmbFromYear.Text, _view.cmbToYear.Text) Then
                UII = _view.cmbUII.Text
                ContinuePrint()
            Else
                UII = _view.cmbUII.Text
                ListModel.SaveUII(_view.cmbUII.Text, _view.cmbFromYear.Text, _view.cmbToYear.Text)
                loadComboBox()
                ContinuePrint()
            End If

        End If

        Cursor.Current = Cursors.Default
    End Sub

    Dim UII As String = ""
    Private Sub PrintTES(sender As Object, e As EventArgs)

        If _view.cmbUII.SelectedIndex = -1 Or _view.cmbUII.Text.Length > 0 Then
            Exit Sub
        Else
            If ListModel.CheckUII(_view.cmbUII.SelectedValue, _view.cmbFromYear.Text, _view.cmbToYear.Text) Then

                ContinuePrint()
            Else

                ListModel.SaveUII(_view.cmbUII.Text, _view.cmbFromYear.Text, _view.cmbToYear.Text)
                loadComboBox()
                ContinuePrint()
            End If

        End If


    End Sub

    Private Sub ContinuePrint()

        Dim TES As New List(Of TESApplication)
        Dim report As New XtraReportScholarshipTES

        Dim dt As New DataTable
        dt = ListModel.getScholarshipList(UII, _view.cmbFromYear.Text, _view.cmbToYear.Text)
        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                Dim obj As New TESApplication
                With obj

                    .class_roll_no = row.Item("class_roll_no")
                    .learner_ref_no = If(IsDBNull(row.Item("learner_ref_no")), "", row.Item("learner_ref_no"))
                    .std_number = If(IsDBNull(row.Item("std_number")), "", row.Item("std_number"))
                    .last_name = If(IsDBNull(row.Item("last_name")), "", row.Item("last_name"))
                    .first_name = If(IsDBNull(row.Item("first_name")), "", row.Item("first_name"))
                    .extension_name = If(IsDBNull(row.Item("student_extension_name")), "", row.Item("student_extension_name"))
                    .middle_name = If(IsDBNull(row.Item("middle_name")), "", row.Item("middle_name"))
                    .gender = If(IsDBNull(row.Item("gender")), "", row.Item("gender"))
                    .date_of_birth = If(IsDBNull(row.Item("date_of_birth")), "", row.Item("date_of_birth"))
                    .program_degree = If(IsDBNull(row.Item("course_name")), "", row.Item("course_name"))
                    .year_level = If(IsDBNull(row.Item("year_level")), "", row.Item("year_level"))
                    .father_last_name = If(IsDBNull(row.Item("father_last_name")), "", row.Item("father_last_name"))
                    .father_first_name = If(IsDBNull(row.Item("father_first_name")), "", row.Item("father_first_name"))
                    .father_middle_name = If(IsDBNull(row.Item("father_middle_name")), "", row.Item("father_middle_name"))
                    .mother_last_name = If(IsDBNull(row.Item("mother_last_name")), "", row.Item("mother_last_name"))
                    .mother_first_name = If(IsDBNull(row.Item("mother_first_name")), "", row.Item("mother_first_name"))
                    .mother_middle_name = If(IsDBNull(row.Item("mother_middle_name")), "", row.Item("mother_middle_name"))
                    .dswd_household_no = If(IsDBNull(row.Item("dswd_household_no")), "", row.Item("dswd_household_no"))
                    .income = If(IsDBNull(row.Item("income")), 0, row.Item("income"))
                    .address = If(IsDBNull(row.Item("address")), "", row.Item("address"))
                    .citymunicipality = If(IsDBNull(row.Item("citymunicipality")), "", row.Item("citymunicipality"))
                    .province = If(IsDBNull(row.Item("province")), "", row.Item("province"))
                    .zipcode = If(IsDBNull(row.Item("zipcode")), "", row.Item("zipcode"))
                    .total_assessment = If(IsDBNull(row.Item("total_assessment")), 0, row.Item("total_assessment"))
                    .disability = If(IsDBNull(row.Item("disability")), "", row.Item("disability"))
                    .telephone1 = If(IsDBNull(row.Item("telephone1")), "", row.Item("telephone1"))
                    .email = If(IsDBNull(row.Item("email")), "", row.Item("email"))
                    .UII = If(IsDBNull(row.Item("UII")), "", row.Item("UII"))
                    .from_year = If(IsDBNull(row.Item("from_year")), "", row.Item("from_year"))
                    .to_year = If(IsDBNull(row.Item("to_year")), "", row.Item("to_year"))
                    .academic_year = If(IsDBNull(row.Item("from_year")), "", row.Item("from_year")) & "-" & If(IsDBNull(row.Item("to_year")), "", row.Item("to_year"))

                    ListModel.ModifyUII(row.Item("id"), UII)

                End With

                TES.Add(obj)

            Next

        End If

        report.xrlshcollname.Text = COMPANY_NAME
        report.xrlUII.Text = UII
        report.xrlacademicyear.Text = _view.cmbFromYear.Text & "-" & _view.cmbToYear.Text
        report.DataSource = TES
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreviewDialog



    End Sub

    Private Sub GenerateHEIUII(sender As Object, e As EventArgs)

        _view.GroupPanel2.Visible = True
        _view.btnPrint.Focus()

    End Sub

    Private Sub SelectedRow(sender As Object, e As RowCellClickEventArgs)
        id = _view.gvTESApplication.GetFocusedRowCellValue("id")
    End Sub

    Private Sub EditRecord(sender As Object, e As EventArgs)

        _view.GroupPanel2.Visible = False
        Dim frm As New frmTESApplicationEntry
        frm.Operation = "EDIT"
        frm.id = id
        frm.BringToFront()
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            loadList()
        Else
            frm.Close()
        End If

    End Sub

    Private Sub AddRecord(sender As Object, e As EventArgs)

        _view.GroupPanel2.Visible = False

        Dim frm As New frmTESApplicationEntry
        frm.Operation = "ADD"
        frm.BringToFront()
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            loadList()
        Else
            frm.Close()
        End If

    End Sub

    Public Sub loadList()
        Dim dt As New DataTable
        dt = ListModel.getList()

        _view.gcTESApplication.DataSource = dt
        Design(_view.gvTESApplication)

    End Sub

    Private Sub Design(gvTESApplication As GridView)

        gvTESApplication.Columns.View.OptionsBehavior.Editable = False

        For i As Integer = 0 To gvTESApplication.Columns.Count - 1

            Select Case i
                Case 0, 1
                    gvTESApplication.Columns(i).Visible = False

                    'Case Else
                    '    If i > 14 Then
                    '        View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    '        View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                    '        View.Columns(i).BestFit()
                    '    Else
                    '        View.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    '        View.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                    '        View.Columns(i).BestFit()
                    '    End If
                Case Else
                    gvTESApplication.Columns(i).BestFit()
            End Select

        Next
        gvTESApplication.OptionsView.ColumnAutoWidth = False

    End Sub
End Class
