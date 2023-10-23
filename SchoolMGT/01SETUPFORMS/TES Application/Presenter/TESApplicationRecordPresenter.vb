Imports DevComponents.DotNetBar
Imports SchoolMGT

Public Class TESApplicationRecordPresenter
    Dim RecordModel As New TESApplicationRecordModel
    Private _view As frmTESApplicationEntry
    Public id As Integer
    Public Operation As String = ""
    Dim TES As New TESApplication
    Public Sub New(frmTESApplicationEntry As frmTESApplicationEntry)
        _view = frmTESApplicationEntry
        _view.btnSave.Focus()
        loadComboBox()
        LoadYear()
        loadHandler()

    End Sub

    Public Sub AssigningControls()

        Dim dt As New DataTable
        dt = RecordModel.getScholarshipRecord(id)
        If dt.Rows.Count > 0 Then
            _view.cmbStudent.SelectedValue = dt(0)("person_id").ToString
            _view.txtExtensionName.Text = If(IsDBNull(dt(0)("student_extension_name")), "", dt(0)("student_extension_name"))
            _view.txtScholarshipName.Text = If(IsDBNull(dt(0)("scholarship_any")), "", dt(0)("scholarship_any"))
            _view.cmbFromYear.Text = dt(0)("from_year").ToString
            _view.cmbToYear.Text = dt(0)("to_year").ToString
            _view.txtUII.Text = If(IsDBNull(dt(0)("UII")), "", dt(0)("UII"))
            _view.txtLearnRefNo.Text = If(IsDBNull(dt(0)("learner_ref_no")), "", dt(0)("learner_ref_no"))
            _view.txtDisability.Text = If(IsDBNull(dt(0)("disability")), "", dt(0)("disability"))
            _view.txtDSWDNo.Text = If(IsDBNull(dt(0)("dswd_household_no")), "", dt(0)("dswd_household_no"))
            _view.nudIncome.Value = If(IsDBNull(dt(0)("income")), 0, dt(0)("income"))
            _view.nudTotalAssessment.Value = If(IsDBNull(dt(0)("total_assessment")), 0, dt(0)("total_assessment"))
            _view.txtFLastName.Text = If(IsDBNull(dt(0)("father_last_name")), "", dt(0)("father_last_name"))
            _view.txtFGivenName.Text = If(IsDBNull(dt(0)("father_first_name")), "", dt(0)("father_first_name"))
            _view.txtFMiddleName.Text = If(IsDBNull(dt(0)("father_middle_name")), "", dt(0)("father_middle_name"))
            _view.txtMLastName.Text = If(IsDBNull(dt(0)("mother_last_name")), "", dt(0)("mother_last_name"))
            _view.txtMGivenName.Text = If(IsDBNull(dt(0)("mother_first_name")), "", dt(0)("mother_first_name"))
            _view.txtMMiddleName.Text = If(IsDBNull(dt(0)("mother_middle_name")), "", dt(0)("mother_middle_name"))
            _view.txtSex.Text = dt(0)("gender").ToString
            _view.txtStudentID.Text = dt(0)("std_number").ToString
            _view.txtSeqNo.Text = dt(0)("class_roll_no").ToString
            _view.txtContactNo.Text = If(IsDBNull(dt(0)("telephone1")), "", dt(0)("telephone1"))
            _view.txtEmailAdd.Text = If(IsDBNull(dt(0)("email")), "", dt(0)("email"))
            _view.dtpBirthDate.Value = If(IsDBNull(dt(0)("date_of_birth")), "", dt(0)("date_of_birth"))
            _view.txtProgram.Text = dt(0)("course_name").ToString
            _view.txtYearLevel.Text = dt(0)("year_level").ToString
            _view.txtStreetBrgy.Text = If(IsDBNull(dt(0)("address")), "", dt(0)("address"))
            _view.txtMunicipalityCity.Text = If(IsDBNull(dt(0)("citymunicipality")), "", dt(0)("citymunicipality"))
            _view.txtProvince.Text = If(IsDBNull(dt(0)("province")), "", dt(0)("province"))
            _view.txtZipCode.Text = If(IsDBNull(dt(0)("zipcode")), "", dt(0)("zipcode"))
        End If
        _view.btnSave.Focus()
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

    Private Sub loadComboBox()
        _view.cmbStudent.DataSource = RecordModel.getStudentList()
        _view.cmbStudent.ValueMember = "ID"
        _view.cmbStudent.DisplayMember = "Name"
        _view.cmbStudent.SelectedIndex = -1
    End Sub

    Private Sub loadHandler()
        AddHandler _view.btnSave.Click, AddressOf SaveRecord
        AddHandler _view.cmbStudent.SelectedIndexChanged, AddressOf DropDownLoad
    End Sub

    Private Sub DropDownLoad(sender As Object, e As EventArgs)

        If RecordModel.CheckIFExist(_view.cmbStudent.SelectedValue, _view.cmbFromYear.Text, _view.cmbToYear.Text) Then
            MessageBoxEx.Show("Student '" & _view.cmbStudent.Text & "' is already Exist...!!!", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            _view.GroupBox1.Enabled = True
            Try
                Dim drv As DataRowView = DirectCast(_view.cmbStudent.SelectedItem, DataRowView)
                _view.txtSeqNo.Text = drv.Item("SeqNumber").ToString
                _view.txtStudentID.Text = drv.Item("std_number").ToString
                _view.txtSex.Text = drv.Item("gender").ToString
                _view.dtpBirthDate.Value = drv.Item("date_of_birth").ToString
                _view.txtProgram.Text = drv.Item("course_name").ToString
                _view.txtYearLevel.Text = drv.Item("year_level").ToString
                _view.txtStreetBrgy.Text = drv.Item("address").ToString
                _view.txtMunicipalityCity.Text = drv.Item("citymunicipality").ToString
                _view.txtProvince.Text = drv.Item("province").ToString
                _view.txtZipCode.Text = drv.Item("zipcode").ToString
                _view.txtContactNo.Text = drv.Item("telephone1").ToString
                _view.txtEmailAdd.Text = drv.Item("email").ToString
                _view.txtFLastName.Text = drv.Item("Father").ToString
                _view.txtMLastName.Text = drv.Item("Mother").ToString

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub SaveRecord(sender As Object, e As EventArgs)

        With TES
            .id = id
            .person_id = _view.cmbStudent.SelectedValue
            .UII = _view.txtUII.Text
            .scholarship_any = "TES"  '_view.txtScholarshipName.Text
            .extension_name = _view.txtExtensionName.Text
            .learner_ref_no = _view.txtLearnRefNo.Text
            .disability = _view.txtDisability.Text
            .dswd_household_no = _view.txtDSWDNo.Text
            .income = _view.nudIncome.Value
            .total_assessment = _view.nudTotalAssessment.Value
            .father_last_name = _view.txtFLastName.Text
            .father_first_name = _view.txtFGivenName.Text
            .father_middle_name = _view.txtFMiddleName.Text
            .mother_last_name = _view.txtMLastName.Text
            .mother_first_name = _view.txtMGivenName.Text
            .mother_middle_name = _view.txtMMiddleName.Text
            .from_year = _view.cmbFromYear.Text
            .to_year = _view.cmbToYear.Text
        End With

        RecordModel.Insert(TES, Operation)

    End Sub
End Class
