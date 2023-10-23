Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class RequisitionSlipRecordPresenter
    Private _view As frmRequisitionSlip
    Dim RecordModel As New RequisitionSlipRecordModel
    Dim TypeOfRequest As New List(Of Requisition_TypeOfRequest)
    Dim PurposeOfRequest As New List(Of Requisition_PurposeRequest)
    Dim _id As Integer
    Dim OPERATION As String
    Dim Request As New Requesition

    Public Sub New(view As frmRequisitionSlip)
        _view = view
        view.cmbform_status.SelectedIndex = 0


        loadCombobox()
        loadHandler()
        loadList()
        loadFormType()

        _view.TabItem13.Visible = False

    End Sub

    Private Sub loadFormType()

        Dim dt As New DataTable
        dt = RecordModel.getFormType()
        _view.gcFormType.DataSource = dt
        '     _view.gvFormType.OptionsBehavior.Editable = False

        getDesign1GridView(_view.gvFormType)
    End Sub

    Private Sub getDesign1GridView(view As Grid.GridView)


        For i As Integer = 0 To view.Columns.Count - 1

            Select Case i
                Case 0, 1, 6
                    view.Columns(i).Visible = False
                Case 2, 3
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    view.Columns(i).BestFit()
                    view.Columns(i).OptionsColumn.ReadOnly = True
             '       view.Columns(i).OptionsColumn.AllowEdit = False
                Case 4
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).BestFit()
                    '       view.Columns(i).OptionsColumn.ReadOnly = False
           '         view.Columns(i).OptionsColumn.AllowEdit = False
                Case 5
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    view.Columns(i).BestFit()
                    view.Columns(i).OptionsColumn.ReadOnly = True
            End Select

        Next

        view.OptionsView.ColumnAutoWidth = True

    End Sub

    Private Sub loadList()
        _view.gcRequestList.DataSource = RecordModel.getRecordList()
        '    getDesign1GridControl(_view.gvRequestList)
    End Sub
    Private Sub getDesign1GridControl(view As GridView)

        view.Columns.View.OptionsBehavior.Editable = False

        For i As Integer = 0 To view.Columns.Count - 1

            Select Case i
                Case 0, 1, 2
                    view.Columns(i).Visible = False
                Case 3
                    view.Columns(i).Caption = "REQUESTOR"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    view.Columns(i).Width = 150

                Case 4
                    view.Columns(i).Caption = "REQUEST.FORM"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    view.Columns(i).Width = 150
                Case 5
                    view.Columns(i).Caption = "NO.COPIES"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 60
                Case 6
                    view.Columns(i).Caption = "PURPOSE"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    view.Columns(i).Width = 200
                Case 7
                    view.Columns(i).Caption = "DATE.REQUESTED"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 100
                Case 8
                    view.Columns(i).Caption = "OFFICIAL.RECEIPT"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 100
                Case 9
                    view.Columns(i).Caption = "PAID.AMOUNT"
                    view.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    view.Columns(i).DisplayFormat.FormatString = "#,###,###.00"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    view.Columns(i).Width = 80
                Case 10
                    view.Columns(i).Caption = "STATUS"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 90

                Case 11
                    view.Columns(i).Caption = "CLAIMED"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 80

                Case 12
                    view.Columns(i).Caption = "DATE.CLAIMED"
                    view.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    view.Columns(i).Width = 80
            End Select

        Next

        view.OptionsView.ColumnAutoWidth = False

    End Sub
    Public Function getSelectedID(ID As Integer)
        RecordModel._id = ID
    End Function

    Private Sub loadHandler()

        '  AddHandler _view.cmbStudentName.SelectionChangeCommitted, AddressOf getValueDropDown
        AddHandler _view.cmbStudentName.SelectedIndexChanged, AddressOf cmbStudentName_SelectedIndexChanged
        AddHandler _view.cmbStudentName.KeyDown, AddressOf getValueEnter
        AddHandler _view.btnSave.Click, AddressOf Save
        AddHandler _view.gvRequestList.RowCellClick, AddressOf RowSelect
        AddHandler _view.btnAdd.Click, AddressOf Add
        AddHandler _view.btnCancel.Click, AddressOf Cancel
        AddHandler _view.gcRequestList.DoubleClick, AddressOf gcDoubleClick
        AddHandler _view.btnPrint.Click, AddressOf PrinDocument
        AddHandler _view.gvFormType.RowCellClick, AddressOf RowCheckboxSelect
        AddHandler _view.gvFormType.CellValueChanged, AddressOf CellValueChanged
        AddHandler _view.btnPayment.Click, AddressOf btnPayment_Click
        AddHandler _view.gvFormType.SelectionChanged, AddressOf gvFormType_SelectionChanged
        AddHandler _view.RepositoryItemButtonEdit1.Click, AddressOf RepositoryItemButtonEdit1_Click
        '    AddHandler _view.RepositoryItemButtonEdit1.ButtonClick, AddressOf RepositoryItemButtonEdit1_ButtonClick
        AddHandler _view.RepositoryItemComboBox2.SelectedIndexChanged, AddressOf RepositoryItemComboBox2_SelectedIndexChanged
        AddHandler _view.RepositoryItemCheckEdit1.CheckedChanged, AddressOf RepositoryItemCheckEdit1_CheckedChanged



    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs)
        Dim ClaimCheckBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit = DirectCast(sender, DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit)
        If ClaimCheckBox.ValueChecked = 1 Then
            RecordModel.UpdateClaimed(_id, 1)
            MessageBox.Show("Request Documents has been Claimed..", "Imformation..!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RecordModel.UpdateClaimed(_id, 0)
            MessageBox.Show("Request Documents UnClaimed..", "Imformation..!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        If RequesStatus = "READY" Then
            If claimed = 0 Then
                If StudentExist(class_roll_no) Then
                    If Incomplete = 1 Then
                        frmGraduateStudent.btnPrintTOR_Click(sender, e, class_roll_no, Nothing, _view.dtpDateFiled.Value)
                    Else
                        Dim frm As New frmGraduateStudent
                        frm.BringToFront()
                        frm.ShowDialog()
                    End If
                Else
                    Dim frm As New frmGraduateStudent
                    frm.BringToFront()
                    frm.ShowDialog()
                End If

            Else
                MessageBox.Show("Cannot Print this Documents...", "Documents are Already Claimed!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("The Documents Request is not yet Ready...", "Waiting for Validation of Request!!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub RepositoryItemComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim ComboBox As DevExpress.XtraEditors.ComboBoxEdit = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit)


        Try

            DataSource(String.Format("UPDATE `requisition` SET `form_stats` = '" & ComboBox.SelectedText & "' WHERE `id` = '" & _id & "'"))

            MessageBox.Show("Now the Requested Documents is ready to print..", "Please Verify !", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception

        End Try


    End Sub


    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs)

        If RequesStatus = "READY" Then
            If claimed = 0 Then
                If StudentExist(class_roll_no) Then
                    If Incomplete = 1 Then
                        frmGraduateStudent.btnPrintTOR_Click(sender, e, class_roll_no, Nothing, _view.dtpDateFiled.Value)
                    Else
                        Dim frm As New frmGraduateStudent
                        frm.BringToFront()
                        frm.ShowDialog()
                    End If
                Else
                    Dim frm As New frmGraduateStudent
                    frm.BringToFront()
                    frm.ShowDialog()
                End If

            Else
                MessageBox.Show("Cannot Print this Documents...", "Documents are Already Claimed!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("The Documents Request is not yet Ready...", "Waiting for Validation of Request!!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Dim Incomplete As Integer
    Dim graduate_student_id As Integer = 0
    Private Function StudentExist(class_roll_no As String) As Boolean
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT graduate_student_id,complete_details FROM graduate_student WHERE 	class_roll_number = '" & class_roll_no & "' "))
        If dt.Rows.Count > 0 Then
            graduate_student_id = dt(0)("graduate_student_id")
            Incomplete = dt(0)("complete_details")
            Return True
        Else
            Return False
        End If
    End Function

    Private lockSelection As Boolean = False
    Private Sub gvFormType_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If lockSelection Then
            Return
        End If
        Dim view As GridView = TryCast(sender, GridView)
        Dim selectedRows() As Integer = view.GetSelectedRows()
        lockSelection = True
        For Each selectedRow As Integer In selectedRows
            If selectedRow <> e.ControllerRow Then
                view.UnselectRow(selectedRow)
            End If

        Next selectedRow
        lockSelection = False



    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmbStudentName.SelectedItem, DataRowView)
            _view.txtCourse.Text = drv.Item("Course").ToString
            _view.txtContact.Text = drv.Item("ContactNumber").ToString
            _view.txtAddress.Text = drv.Item("ADDRESS").ToString
            _view.lblstudent_ID.Text = drv.Item("stdID").ToString
            PERSON_ID = drv.Item("person_id").ToString
            class_roll_no = drv.Item("ID").ToString
        Catch ex As Exception

        End Try
    End Sub

    Dim RequesStatus As String = ""
    Private Sub btnPayment_Click(sender As Object, e As EventArgs)

        Dim _dateIssued As New Date

        '      If RecordModel.CheckFormTypeToFinanceCategory(FinanceTransactionCategoryID) = True Then
        If Selection = "False" And NoOfCopies > 0 Then

            Dim frm As New fmaIncomeSetupForm
            frm.FeeCategoryID = FinanceTransactionCategoryID
            frm.Amount = Amount
            frm.Class_roll_no = _view.cmbStudentName.SelectedValue
            '   frm.cmbStudent.Text = _view.cmbStudentName.Text
            frm.stdID = _view.lblstudent_ID.Text
            frm.txtRemarks.Text = _view.gvFormType.GetFocusedRowCellValue("FORM") & " - Requisition Slip"
            frm.request_form = FormTypeID

            frm.dtiDateIssued.Value = _view.dtpDateFiled.Value
            _dateIssued = _view.dtpDateFiled.Value

            Amount = Amount * NoOfCopies
            frm.diAmount.Value = Amount
            frm.lblRequestForm.Text = _view.gvFormType.GetFocusedRowCellValue("FORM")
            frm.BringToFront()
            frm.ShowDialog()
            If frm.DialogResult = DialogResult.Cancel Then
                If MessageBox.Show("Do you want to Continue?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If MessageBox.Show("Do you want to Save this Request?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        RequesStatus = "PENDING"
                    End If
                    frm.Close()
                End If
            Else

                _view.dtpDateFiled.Value = _dateIssued
                RequesStatus = "ONGOING"
                frm.Close()
            End If

        Else
            MsgBox("Please.....!!!,Select Form Type or Spicify number of Copies", MsgBoxStyle.Information, "Important")
        End If
    End Sub

    Private Sub CheckCheckBox(sender As Object, e As CellValueChangedEventArgs)
        Dim View As GridView = DirectCast(sender, GridView)
        If e.Column.FieldName = "SELECT" Then
            If View.GetFocusedRowCellValue("SELECT") = False Then
                View.SetFocusedRowCellValue("COPIES", 0)
            End If
        End If
    End Sub

    Dim FinanceTransactionCategoryID As Integer
    Dim FormTypeID As Integer
    Dim FormTypeName As String = ""
    Dim NoOfCopies As Integer
    Dim Amount As Double
    Dim Selection As String = ""

    Dim PreviousRowHandle As Integer = 0
    Private Sub RowCheckboxSelect(sender As Object, e As RowCellClickEventArgs)
        Dim View As GridView = DirectCast(sender, GridView)



        If e.Column.FieldName = "SELECT" Then

            Try
                FormTypeID = View.GetFocusedRowCellValue("id")
                Amount = View.GetFocusedRowCellValue("RATE")
                Selection = View.GetFocusedRowCellValue("SELECT")
                NoOfCopies = View.GetFocusedRowCellValue("NO. OF COPIES")

                If RecordModel.CheckUnclaimedRequest(class_roll_no, FormTypeID, 0) Then
                    MessageBox.Show(" '" & _view.cmbStudentName.Text & "',  Has unclaimed Request...", "UNCLAIMED REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub getValueEnter(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Try
                Dim drv As DataRowView = DirectCast(_view.cmbStudentName.SelectedItem, DataRowView)
                _view.txtCourse.Text = drv.Item("Course").ToString
                _view.txtContact.Text = drv.Item("ContactNumber").ToString
                _view.txtAddress.Text = drv.Item("ADDRESS").ToString
                _view.lblstudent_ID.Text = drv.Item("class_roll_no").ToString
            Catch ex As Exception
            End Try
        End If
    End Sub



    Private Sub CellValueChanged(sender As Object, e As CellValueChangedEventArgs)

        Dim View As GridView = DirectCast(sender, GridView)

        If e.Column.FieldName = "NO.COPIES" Then

            View.FocusedRowHandle = e.RowHandle
            View.FocusedColumn = View.Columns("COPIES")

        End If

    End Sub

    Private Sub PrinDocument(sender As Object, e As EventArgs)

        If _view.rdbClaimStudb.Checked = True Then
            PrintClaimStub(_id)
        ElseIf _view.rdbtnBlankRequestForm.Checked Then

        Else

        End If

    End Sub

    Private Sub PrintClaimStub(id As Integer)

        Dim report As New XtraReport_ClaimStub

        'If Not File.Exists(COMPANY_HEADER_PATH) Then
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
        'Else
        '    report.XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
        'End If

        report.XrLName.Text = _view.cmbStudentName.Text
        report.XrLDateFiled.Text = _view.dtpDateFiled.Value
        report.XrLDueDate.Text = _view.dtpDateDue.Value
        report.XrLClaimWindow.Text = _view.txtClaimWindow.Text
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview

    End Sub

    Private Sub gcDoubleClick(sender As Object, e As EventArgs)

        Try
            If _view.gvRequestList.RowCount > 0 Then
                _view.btnAdd.Text = "Edit"

                _view.cmbStudentName.SelectedValue = row.Item("class_roll_number")

                getValueDropDown(_view.cmbStudentName.SelectedValue, _e)

                _view.dtpDateFiled.Value = row.Item("date_filed")
                _view.dtpDateDue.Value = row.Item("due_date")
                _view.txtYearGraduated.Text = row.Item("year_graduated")
                _view.txtFirstAttendance.Text = row.Item("year_first_attendance")
                _view.txtLastAttendance.Text = row.Item("year_last_attendance")
                _view.txtClaimWindow.Text = row.Item("request_window")
                If row.Item("first_copy") = "YES" Then
                    _view.rdbtnYes.Checked = True
                Else
                    _view.rdbtnNo.Checked = True
                End If

                _view.gvRequestList.OptionsDetail.EnableDetailToolTip = True

                'Type of Rwquest
                Dim dt As New DataTable
                dt = RecordModel.getTypeOfRequestRecord(_id)
                If dt.Rows.Count > 0 Then
                    getTypeOfRequest(dt)
                End If
                dt = Nothing

                'Purpose of Request
                dt = RecordModel.gerPurposeOfRequest(_id)
                If dt.Rows.Count > 0 Then
                    getPurposeOfRequest(dt)
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Cancel(sender As Object, e As EventArgs)

        CleanAllControls(_view)

    End Sub

    Dim _e As EventArgs
    Private Sub Add(sender As Object, e As EventArgs)
        _view.Panel5.Enabled = True
        _view.TabControl4.Enabled = True


        If _view.btnAdd.Text = "Add" Then
            OPERATION = "ADD"
            CleanAllControls(_view)
        Else
            OPERATION = "EDIT"
        End If


    End Sub

    Dim row As DataRow
    Dim class_roll_no As String = ""
    Dim claimed As Integer = 0

    Private Sub RowSelect(sender As Object, e As RowCellClickEventArgs)

        Dim view As GridView = DirectCast(sender, GridView)

        If _view.gvRequestList.RowCount > 0 Then

            If e.Column.Caption = "Selection" Then
                _view.btnAdd.Text = "Edit"
            End If

            _id = view.GetFocusedRowCellValue("id")
            FormTypeID = view.GetFocusedRowCellValue("FORM.ID") '
            FormTypeName = view.GetFocusedRowCellValue("REQUEST.FORM")
            Amount = view.GetFocusedRowCellValue("PAID.AMOUNT")
            RequesStatus = view.GetFocusedRowCellValue("STATUS").ToString
            class_roll_no = view.GetFocusedRowCellValue("class_roll_number").ToString
            Dim copies = view.GetFocusedRowCellValue("NO.COPIES").ToString


            If view.GetFocusedRowCellValue("CLAIMED").ToString = "True" Then
                claimed = 1
            Else
                claimed = 0
            End If
            '        claimed = view.GetFocusedRowCellValue("CLAIMED").ToString

            row = view.GetDataRow(e.Handled)

            '     If e.Column.Caption = "Selection" Then

            Try

                '    _view.btnAdd.Text = "Edit"

                _view.cmbStudentName.SelectedValue = view.GetFocusedRowCellValue("class_roll_number")

                getValueDropDown(_view.cmbStudentName.SelectedValue, _e)

                _view.dtpDateFiled.Value = view.GetFocusedRowCellValue("DATE.REQUESTED") ' row.Item("DATE.REQUESTED")
                _view.dtpDateDue.Value = view.GetFocusedRowCellValue("DATE.CLAIMED") 'row.Item("DATE.CLAIMED")
                _view.txtYearGraduated.Text = view.GetFocusedRowCellValue("year_graduated") 'row.Item("year_graduated")
                _view.txtFirstAttendance.Text = view.GetFocusedRowCellValue("year_first_attendance") 'row.Item("year_first_attendance")
                _view.txtLastAttendance.Text = view.GetFocusedRowCellValue("year_last_attendance") 'row.Item("year_last_attendance")
                _view.txtClaimWindow.Text = view.GetFocusedRowCellValue("WINDOW") 'row.Item("WINDOW")
                If view.GetFocusedRowCellValue("first_copy") = 1 Then
                    _view.rdbtnYes.Checked = True
                Else
                    _view.rdbtnNo.Checked = True
                End If

                _view.gvRequestList.OptionsDetail.EnableDetailToolTip = True

                'Type of Rwquest
                Dim dt As New DataTable
                dt = RecordModel.getTypeOfRequestRecord(_id)
                If dt.Rows.Count > 0 Then
                    getTypeOfRequest(dt)
                End If
                dt = Nothing


                dt = _view.gcFormType.DataSource
                _view.gcFormType.DataSource = Nothing
                For x As Integer = 0 To dt.Rows.Count - 1
                    If dt(x)("id") = FormTypeID Then
                        dt(x)("SELECT") = "True"
                        dt(x).Item("NO. OF COPIES") = copies
                    End If
                Next
                _view.gcFormType.DataSource = dt

                'Purpose of Request
                dt = RecordModel.gerPurposeOfRequest(_id)
                If dt.Rows.Count > 0 Then
                    getPurposeOfRequest(dt)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '   Else
            '_view.btnAdd.Text = "Add"
        End If


        '   End If

    End Sub

    Public Function ClearObjectList()

        TypeOfRequest.Clear()
        PurposeOfRequest.Clear()

    End Function

    Private Sub getPurposeOfRequest(dt As DataTable)

        For Each row As DataRow In dt.Rows

            Dim CheckBox = Me.GetAllControls(_view).OfType(Of CheckBox)().ToList()
            For Each item As CheckBox In CheckBox
                If row.Item("purpose_request") = item.Text Then
                    item.Checked = True
                End If

            Next
        Next

    End Sub

    Private Sub getTypeOfRequest(dt As DataTable)

        For Each row As DataRow In dt.Rows

            Dim Label = Me.GetAllControls(_view).OfType(Of DevComponents.DotNetBar.LabelX)().ToList()
            For Each lbl As DevComponents.DotNetBar.LabelX In Label
                If row.Item("type_of_request") = lbl.Text Then
                    '      lbl.ForeColor = Color.OrangeRed

                    Dim TextBox = Me.GetAllControls(_view).OfType(Of DevComponents.DotNetBar.Controls.TextBoxX)().ToList()
                    For Each txtbx As DevComponents.DotNetBar.Controls.TextBoxX In TextBox
                        If lbl.Tag = txtbx.Tag Then
                            txtbx.Text = row.Item("no_of_copies")
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Dim LastPK As Integer
    Private Sub Save(sender As Object, e As EventArgs)

        ClearObjectList()

        With Request
            .class_roll_number = _view.cmbStudentName.SelectedValue
            .date_filed = FormatDate(_view.dtpDateFiled.Value)
            .due_date = FormatDate(_view.dtpDateFiled.Value)
            .first_copy = If(_view.rdbtnYes.Checked = True, 1, 0)
            .year_graduated = _view.txtYearGraduated.Text
            .year_first_attendance = _view.txtFirstAttendance.Text
            .year_last_attendance = _view.txtLastAttendance.Text
            .request_window = _view.txtClaimWindow.Text
            .form_status = RequesStatus   '_view.cmbform_status.Text
            .financeT = finance_tran_id
        End With

        Dim TextBox = Me.GetAllControls(_view).OfType(Of DevComponents.DotNetBar.Controls.TextBoxX)().ToList()
        For Each txtbx As DevComponents.DotNetBar.Controls.TextBoxX In TextBox
            If txtbx.AccessibleName = "Type of Request" And txtbx.Text.Length > 0 Then

                Dim Label = Me.GetAllControls(_view).OfType(Of DevComponents.DotNetBar.LabelX)().ToList()
                For Each lbl As DevComponents.DotNetBar.LabelX In Label
                    If txtbx.Tag = lbl.Tag Then
                        Dim obj As New Requisition_TypeOfRequest
                        With obj
                            .TypeOfFormName = lbl.Text
                            .NoOfCopies = txtbx.Text
                            .Tag = txtbx.Tag
                        End With
                        TypeOfRequest.Add(obj)
                    End If
                Next

            End If
        Next

        If _view.gvFormType.RowCount > 0 Then
            Dim dt As New DataTable
            dt = _view.gcFormType.DataSource
            For Each rows As DataRow In dt.Rows
                If rows.Item("SELECT").ToString = "True" Then
                    Dim obj As New Requisition_TypeOfRequest
                    With obj
                        .TypeOfFormName = rows.Item("FORM").ToString
                        .TypeOfFormID = rows.Item("id").ToString
                        .NoOfCopies = rows.Item("NO. OF COPIES").ToString
                    End With
                    TypeOfRequest.Add(obj)
                End If
            Next
        End If

        Dim CheckBox = Me.GetAllControls(_view).OfType(Of CheckBox)().ToList()
        Dim Purpose As String = ""
        For Each item As CheckBox In CheckBox
            If item.Checked = True Then
                Dim obj As New Requisition_PurposeRequest
                With obj
                    .PurposeOfRequest = item.Text
                End With
                If Purpose = "" Then
                    Purpose = item.Text
                Else
                    Purpose += Purpose & ","
                End If
                PurposeOfRequest.Add(obj)
            End If
        Next
        'Dim obx As New Requisition_PurposeRequest
        'With obx
        '    .PurposeOfRequest = Purpose
        'End With
        'PurposeOfRequest.AddRange(obx)

        RecordModel._id = _id
        LastPK = RecordModel.Insert(OPERATION, Request)
        RecordModel.InsertObjectList(TypeOfRequest, PurposeOfRequest, LastPK)

        MyMessageBox(OPERATION)
        loadList()
        CleanAllControls(_view)

        _view.Panel5.Enabled = False
        _view.TabControlPanel9.Enabled = False
        _view.TabControlPanel10.Enabled = False

        _view.btnAdd.Text = "Add"

    End Sub

    Friend Sub TrapInput(sender As Object)
        Dim txtBox As TextBox = sender
        Select Case txtBox.Text
            Case "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", ""
                '         add_objectlist(txtBox.Text, txtBox.Tag)
                txtBox.Text = txtBox.Text
            Case Else
                MsgBox("Invalid Input")
                txtBox.Text = ""
        End Select

    End Sub

    Private Sub add_objectlist(NoOfCopies As String, tag As Object)
        Dim RequestType As String = ""
        Dim labelX = Me.GetAllControls(_view).OfType(Of DevComponents.DotNetBar.LabelX)().ToList()
        If tag = 13 Then
            RequestType = _view.TextBoxX11.Text
            Dim obj As New Requisition_TypeOfRequest
            With obj
                .TypeOfFormName = RequestType
                .NoOfCopies = NoOfCopies
                .Tag = tag
            End With
            TypeOfRequest.Add(obj)
        Else


            For Each item As DevComponents.DotNetBar.LabelX In labelX
                If item.Tag = tag Then
                    RequestType = item.Text
                    'If exist modify
                    For Each rows In TypeOfRequest.ToList
                        If rows.Tag = tag Then
                            rows.NoOfCopies = ReplaceMe(rows.NoOfCopies, NoOfCopies)
                        End If
                    Next

                    'Add if not exist
                    Dim obj As New Requisition_TypeOfRequest
                    With obj
                        .TypeOfFormName = RequestType
                        .NoOfCopies = NoOfCopies
                        .Tag = tag
                    End With
                    TypeOfRequest.Add(obj)
                End If

            Next

        End If

    End Sub

    Private Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function

    Friend Sub ChekBoxEdit(Name As String)

        'If exist modify
        For Each rows In PurposeOfRequest.ToList
            If rows.PurposeOfRequest = Name Then
                rows.PurposeOfRequest = ReplaceMe(rows.PurposeOfRequest, Name)
            End If
        Next

        'Add if not exist
        Dim obj As New Requisition_PurposeRequest
        With obj
            .PurposeOfRequest = Name
        End With
        PurposeOfRequest.Add(obj)

    End Sub


    Public Sub getValueDropDown(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmbStudentName.SelectedItem, DataRowView)
            _view.txtCourse.Text = drv.Item("Course").ToString
            _view.txtContact.Text = drv.Item("ContactNumber").ToString
            _view.txtAddress.Text = drv.Item("ADDRESS").ToString
            _view.lblstudent_ID.Text = drv.Item("stdID").ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub loadCombobox()

        _view.cmbStudentName.DataSource = RecordModel.getStudentRecord()
        _view.cmbStudentName.ValueMember = "ID"
        _view.cmbStudentName.DisplayMember = "Name"
        _view.cmbStudentName.SelectedIndex = -1

    End Sub
End Class
