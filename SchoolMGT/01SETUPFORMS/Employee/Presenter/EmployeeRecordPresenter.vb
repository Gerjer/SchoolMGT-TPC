Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Imaging.ImageCodecInfo
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Threading
Imports SchoolMGT
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
'Imports DevExpress.XtraGrid.Columns.GridColumn
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs
Imports System.Drawing.Imaging
Imports DevComponents.DotNetBar
Imports Microsoft.SqlServer
Imports System.Configuration
Imports System.Security.SecureString
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Security.Permissions

Public Class EmployeeRecordPresenter

    Dim _view As fmaEmployeeRecord
    Dim RecordModel As New EmployeeRecordModel

    Public OPERATION As String
    Dim _id As Integer = 0
    Dim _personID As Integer = 0
    Dim _userID As Integer = 0
    Dim _photo_path As String = ""
    Dim _photo_filename As String

    Dim PersonDetails As New PersonDetails
    Dim Dependent As New List(Of PersonDetails.Dependent)

    Dim EmployeeDetails As New EmployeeDetails
    Dim BankDetails As New List(Of EmployeeDetails.BankDetails)
    Dim CharacterReference As New List(Of EmployeeDetails.CharacterReference)
    Dim EducationalAttainment As New List(Of EmployeeDetails.EducationalAttainment)
    Dim EmploymentHistory As New List(Of EmployeeDetails.EmploymentHistory)
    Dim ServiceHistory As New List(Of EmployeeDetails.ServiceHistory)

    Dim ListOfAchievments As New List(Of ListOfAchievements)
    Dim ListOfAchievments_Delete As New List(Of String)
    Dim ListOfAttachments As New List(Of ListOfAttachment_Documents)
    Dim ListOfAttachments_Deleted As New List(Of String)
    Dim Attended_University As New List(Of AttendedUniversity)
    Dim StudentDetails As New StudentAcademic
    Dim NonAcademic As New List(Of StudentNonAcademic)

    Dim FocusDatarow As DataRow
    Dim SelectedDatarow As DataRow

    Dim dt_bank As New DataTable
    Dim dt_FamilyBackground As New DataTable
    Dim dt_Dependent As New DataTable
    Dim dt_CharacterReference As New DataTable
    Dim dt_EducationalAttainment As New DataTable
    Dim dt_EmploymentHistory As New DataTable
    Dim dt_ServiceHistory As New DataTable
    Dim dt_LisOfAchievements As New DataTable
    Dim dt_ListOfAttach_Documents As New DataTable
    Dim dt_Attended_University As New DataTable

    Private DefaultImage As Image
    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream

    Dim Dir As String = ""
    Dim Current_Dir As String = ""
    Dim combinePath As String

    Dim Picture_Box As New System.Windows.Forms.PictureBox()
    Dim File_Image As Image
    Dim FolderName As String = ""

    '    Dim appSettings As String = ConfigurationManager.AppSettings(0) '.AppSettings("Server") 'ConfigurationManager.AppSettings("ServerPath")
    '    Dim _directory As New DirectoryInfo(appSettings)


    Dim _directory_info As DirectoryInfo
    Dim appSettings As String = ""




    Public Sub New(viewForm As fmaEmployeeRecord, Optional _operation As String = Nothing, Optional tag As String = Nothing, Optional name As String = Nothing)

        _view = viewForm
        _view.Tag = tag
        _view.Text = name
        OPERATION = _operation
        '      loadComboBox()
        loadAddHandler()
        LoadedImage = False

        FolderName = If(_view.Text = "EMPLOYEE SETUP", _view.Text.Substring(0, 8), _view.Text.Substring(0, 7))

        Dim _dir As String = ""
        If clsDBConn.ServerName = "localhost" Then
            'Creat Current Directory
            Try
                _dir = Directory.GetCurrentDirectory & "\PIC\"

                If (Not System.IO.Directory.Exists(IO.Path.Combine(_dir, FolderName))) Then
                    System.IO.Directory.CreateDirectory(IO.Path.Combine(_dir, FolderName))
                End If
                Current_Dir = IO.Path.Combine(_dir, FolderName) & "\"
            Catch ex As Exception

            End Try

            _dir = ""
            'Creat remote Directory
            Try

                _dir = ServerPath & ServerPath_Directory & "\PIC\" & FolderName & "\"

                If (Not Directory.Exists(_dir)) Then
                    Directory.CreateDirectory(_dir)
                End If
                Dir = _dir

            Catch ex As Exception

            End Try

        Else

            If SavingDir = "local.dir" Then
                'Creat Current Directory
                Try
                    _dir = Directory.GetCurrentDirectory & "\PIC\"

                    If (Not System.IO.Directory.Exists(IO.Path.Combine(_dir, FolderName))) Then
                        System.IO.Directory.CreateDirectory(IO.Path.Combine(_dir, FolderName))
                    End If
                    Current_Dir = IO.Path.Combine(_dir, FolderName) & "\"
                Catch ex As Exception

                End Try

            Else

                'Creat Server Directory
                Try
                    If _view.Tag = 1 Then
                        appSettings = ConfigurationManager.AppSettings("Server_PIC_EMPLOYEE_Path")
                        _directory_info = New DirectoryInfo(appSettings)
                    Else
                        appSettings = ConfigurationManager.AppSettings("Server_PIC_STUDENT_Path")
                        _directory_info = New DirectoryInfo(appSettings)
                    End If

                    _dir = _directory_info.FullName

                    If (Not Directory.Exists(_dir)) Then
                        Directory.CreateDirectory(_dir)
                    End If
                    Dir = _dir

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If




        End If


            If OPERATION = "ADD" Then
            '         _view.txtStudentID.Enabled = False
            _view.chkManulStudNum.Enabled = False
            AutoGenerated_CodeNumbers()
        Else
            '           _view.txtStudentID.Enabled = True
            _view.chkManulStudNum.Enabled = True
        End If

        Dependent_ColumnHeader()
        FamilyBackground_ColumnHeader()

        Bank_ColumnHeader()
        CharacterReference_ColumnHeader()
        EducationalAttainment_ColumnHeader()
        EmploymentHistory_ColumnHeader()
        ServiceHistory_ColumnHeader()
        ListOfAchievements_ColumnHeader()
        ListOfAttach_Documents_ColumnHeader()
        Attended_University_ColumnHeader()

    End Sub

    Private Sub Attended_University_ColumnHeader()
        dt_Attended_University.Columns.Add("Name of Person")
        dt_Attended_University.Columns.Add("Relationship")
        _view.gcAttendUniversity.DataSource = dt_Attended_University
    End Sub

    Private Sub ListOfAttach_Documents_ColumnHeader()
        dt_ListOfAttach_Documents.Columns.Add("Document Type")
        dt_ListOfAttach_Documents.Columns.Add("File Name")
        dt_ListOfAttach_Documents.Columns.Add("File Path")
        dt_ListOfAttach_Documents.Columns.Add("ID")
        _view.gcAttachment.DataSource = dt_ListOfAttach_Documents
    End Sub

    Private Sub ListOfAchievements_ColumnHeader()
        dt_LisOfAchievements.Columns.Add("File Name")
        dt_LisOfAchievements.Columns.Add("File Path")
        _view.gcAttachAchievements.DataSource = dt_LisOfAchievements
    End Sub

    Friend Sub ToolTip1()
        _view.ToolTip1.SetToolTip(_view.txtpicturepath, "")
    End Sub

    Friend Sub ToolTip()
        _view.ToolTip1.SetToolTip(_view.txtpicturepath, names)
    End Sub

    Private Sub ServiceHistory_ColumnHeader()
        dt_ServiceHistory.Columns.Add("Eligibility Level")
        dt_ServiceHistory.Columns.Add("Eligibility Career")
        dt_ServiceHistory.Columns.Add("Date Examination")
        dt_ServiceHistory.Columns.Add("Place of Examination")
        dt_ServiceHistory.Columns.Add("Ratings")
        dt_ServiceHistory.Columns.Add("License Number")
        dt_ServiceHistory.Columns.Add("Date of Release")

        _view.gcServHistory.DataSource = dt_ServiceHistory
    End Sub

    Private Sub EmploymentHistory_ColumnHeader()
        dt_EmploymentHistory.Columns.Add("Company Name")
        dt_EmploymentHistory.Columns.Add("Date From")
        dt_EmploymentHistory.Columns.Add("Date To")
        dt_EmploymentHistory.Columns.Add("Contact Number")

        _view.gcEmpHistory.DataSource = dt_EmploymentHistory
    End Sub

    Private Sub EducationalAttainment_ColumnHeader()
        dt_EducationalAttainment.Columns.Add("Education Attaintment")
        dt_EducationalAttainment.Columns.Add("School Name")
        dt_EducationalAttainment.Columns.Add("Date From")
        dt_EducationalAttainment.Columns.Add("Date To")
        dt_EducationalAttainment.Columns.Add("Honors Received")

        _view.gcEduAttainment.DataSource = dt_EducationalAttainment
    End Sub

    Private Sub CharacterReference_ColumnHeader()
        dt_CharacterReference.Columns.Add("Person Name")
        dt_CharacterReference.Columns.Add("Position")
        dt_CharacterReference.Columns.Add("Company")
        dt_CharacterReference.Columns.Add("Contact Number")

        _view.gcCharRef.DataSource = dt_CharacterReference
    End Sub

    Public Function Edit(personID)

        _personID = personID
        RecordModel._personID = personID
        personID_image = personID
        Dim dt As New DataTable
        If OPERATION = "EDIT" Then

            '        _view.WinLabel.Text = _view.txtfull_name.Text


            dt = RecordModel.RetreivePerson(personID)
            If dt.Rows.Count > 0 Then

                'Person data
                _view.txtfirst_name.Text = If(IsDBNull(dt(0)("first_name").ToString), "", dt(0)("first_name").ToString)
                _view.txtlast_name.Text = If(IsDBNull(dt(0)("last_name").ToString), "", dt(0)("last_name").ToString)
                _view.txtmiddle_name.Text = If(IsDBNull(dt(0)("middle_name").ToString), "", dt(0)("middle_name").ToString)
                _view.txtfull_name.Text = If(IsDBNull(dt(0)("display_name").ToString), "", dt(0)("display_name").ToString)
                _view.WinLabel.Text = _view.txtfull_name.Text
                _view.cmbgender.Text = If(IsDBNull(dt(0)("gender").ToString), "", dt(0)("gender").ToString)
                _view.dtpdate_of_birth.Value = If(IsDBNull(dt(0)("date_of_birth")), Date.Now, dt(0)("date_of_birth"))
                _view.txtbirthplace.Text = If(IsDBNull(dt(0)("birth_place").ToString), "", dt(0)("birth_place").ToString)
                _view.cmbmarital_status.Text = If(IsDBNull(dt(0)("marital_status").ToString), "", dt(0)("marital_status").ToString)
                _view.cmbblood_group.Text = If(IsDBNull(dt(0)("blood_group").ToString), "", dt(0)("blood_group").ToString)
                _view.cmbnationality_id.SelectedValue = If(IsDBNull(dt(0)("nationality_id")), 0, dt(0)("nationality_id"))
                _view.txthome_phone.Text = If(IsDBNull(dt(0)("telephone1").ToString), "", dt(0)("telephone1").ToString)
                _view.txtmobile_phone.Text = If(IsDBNull(dt(0)("mobile").ToString), "", dt(0)("mobile").ToString)
                _view.txtemail.Text = If(IsDBNull(dt(0)("email").ToString), "", dt(0)("email").ToString)
                _view.txtreligion.Text = If(IsDBNull(dt(0)("religion").ToString), "", dt(0)("religion").ToString)
                _view.txtlanguage.Text = If(IsDBNull(dt(0)("language").ToString), "", dt(0)("language").ToString)
                _view.txtdisability.Text = If(IsDBNull(dt(0)("disability").ToString), "", dt(0)("disability").ToString)

                'Statutory
                Dim dt_statutory As New DataTable
                dt_statutory = RecordModel.getStatutory(personID)
                If dt_statutory.Rows.Count > 0 Then
                    If _view.Tag = 1 Then
                        _view.txtTIN1.Text = If(IsDBNull(dt_statutory(0)("tin").ToString), "", dt_statutory(0)("tin").ToString)
                        _view.txtSSS1.Text = If(IsDBNull(dt_statutory(0)("sss").ToString), "", dt_statutory(0)("sss").ToString)
                        _view.txtPagIBIG1.Text = If(IsDBNull(dt_statutory(0)("pagibig").ToString), "", dt_statutory(0)("pagibig").ToString)
                        _view.txtPhilHealth1.Text = If(IsDBNull(dt_statutory(0)("philhealth").ToString), "", dt_statutory(0)("philhealth").ToString)
                    Else
                        _view.txtTIN.Text = If(IsDBNull(dt_statutory(0)("tin").ToString), "", dt_statutory(0)("tin").ToString)
                        _view.txtSSS.Text = If(IsDBNull(dt_statutory(0)("sss").ToString), "", dt_statutory(0)("sss").ToString)
                        _view.txtPagIBIG.Text = If(IsDBNull(dt_statutory(0)("pagibig").ToString), "", dt_statutory(0)("pagibig").ToString)
                        _view.txtPhilHealth.Text = If(IsDBNull(dt_statutory(0)("philhealth").ToString), "", dt_statutory(0)("philhealth").ToString)
                    End If
                End If

                'Person Contact
                dt = Nothing
                dt = RecordModel.RetreivePersonContact(personID)
                If dt.Rows.Count > 0 Then
                    _view.txtcontact_person.Text = If(IsDBNull(dt(0)("contact_person").ToString), "", dt(0)("contact_person").ToString)
                    _view.txtcontact_address.Text = If(IsDBNull(dt(0)("contact_address").ToString), "", dt(0)("contact_address").ToString)
                    _view.txtcontact_number.Text = If(IsDBNull(dt(0)("contact_number").ToString), "", dt(0)("contact_number").ToString)
                    _view.txtcontact_relationship.Text = If(IsDBNull(dt(0)("contact_relationship").ToString), "", dt(0)("contact_relationship").ToString)

                End If

                'Charactr Reference
                dt = Nothing
                dt = RecordModel.RetreiveCharacterReference(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcCharRef.DataSource = dt
                    dt_CharacterReference = dt
                End If
                _view.gvCharRef.BestFitColumns()
                'Dependent
                dt = Nothing
                dt = RecordModel.RetreiveDependencies(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcDependent.DataSource = dt
                    dt_Dependent = dt
                End If
                _view.gvDependent.BestFitColumns()
                'Family Background
                dt = Nothing
                dt = RecordModel.RetreiveFamilyBackground(personID)
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        Select Case row("family_background_type").ToString
                            Case "Spouse"
                                _view.txtspouse_name.Text = If(IsDBNull(row("family_background_name").ToString), "", row("family_background_name").ToString)
                                _view.txtspouse_occupation.Text = If(IsDBNull(row("family_background_occupation").ToString), "", row("family_background_occupation").ToString)
                                _view.txtspouse_company.Text = If(IsDBNull(row("family_background_company_name").ToString), "", row("family_background_company_name").ToString)
                                _view.txtspouse_companyNo.Text = If(IsDBNull(row("family_background_company_number").ToString), "", row("family_background_company_number").ToString)
                                _view.txtspouse_companyAddress.Text = If(IsDBNull(row("family_background_company_address").ToString), "", row("family_background_company_address").ToString)
                            Case "Father"
                                _view.txtfather_name.Text = If(IsDBNull(row("family_background_name").ToString), "", row("family_background_name").ToString)
                                _view.txtfather_occupation.Text = If(IsDBNull(row("family_background_occupation").ToString), "", row("family_background_occupation").ToString)
                                _view.txtfather_company.Text = If(IsDBNull(row("family_background_company_name").ToString), "", row("family_background_company_name").ToString)
                                _view.txtfather_companyNo.Text = If(IsDBNull(row("family_background_company_number").ToString), "", row("family_background_company_number").ToString)
                                _view.txtfather_companyAddress.Text = If(IsDBNull(row("family_background_company_address").ToString), "", row("family_background_company_address").ToString)
                            Case Else
                                _view.txtmother_name.Text = If(IsDBNull(row("family_background_name").ToString), "", row("family_background_name").ToString)
                                _view.txtmother_occupation.Text = If(IsDBNull(row("family_background_occupation").ToString), "", row("family_background_occupation").ToString)
                                _view.txtmother_company.Text = If(IsDBNull(row("family_background_company_name").ToString), "", row("family_background_company_name").ToString)
                                _view.txtmother_companyNo.Text = If(IsDBNull(row("family_background_company_number").ToString), "", row("family_background_company_number").ToString)
                                _view.txtmother_companyAddress.Text = If(IsDBNull(row("family_background_company_address").ToString), "", row("family_background_company_address").ToString)
                        End Select


                    Next
                End If

                'Photo
                dt = Nothing
                dt = RecordModel.RetreivePhoto(personID)
                If dt.Rows.Count > 0 Then

                    If ServerPath <> "" Then
                        _view.txtpicturepath.Text = If(IsDBNull(dt(0)("photo_file_name").ToString), "", dt(0)("photo_file_name").ToString)      ' If(IsDBNull(dt(0)("photo_path").ToString), "", dt(0)("photo_path").ToString)
                        _photo_filename = If(IsDBNull(dt(0)("photo_file_name").ToString), "", dt(0)("photo_file_name").ToString)
                        _photo_path = If(IsDBNull(dt(0)("photo_path").ToString), "", dt(0)("photo_path").ToString)
                        Dir = _photo_path
                    Else
                        _view.txtpicturepath.Text = If(IsDBNull(dt(0)("photo_file_name").ToString), "", dt(0)("photo_file_name").ToString)      ' If(IsDBNull(dt(0)("photo_path").ToString), "", dt(0)("photo_path").ToString)
                        _photo_filename = If(IsDBNull(dt(0)("photo_file_name").ToString), "", dt(0)("photo_file_name").ToString)
                        _photo_path = If(IsDBNull(dt(0)("photo_path").ToString), "", dt(0)("photo_path").ToString)
                        Dir = _photo_path
                    End If

                    If Not _view.txtpicturepath.Text.Length = 0 Then
                        loadPicture(True, _photo_filename)
                    End If

                End If

                'Educational Attainment
                dt = Nothing
                dt = RecordModel.RetreiveEduAttainment(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcEduAttainment.DataSource = dt
                    dt_EducationalAttainment = dt
                End If
                _view.gvEduAttainment.BestFitColumns()

                'Employment History
                dt = Nothing
                dt = RecordModel.RetreiveEmploymentHistory(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcEmpHistory.DataSource = dt
                    dt_EmploymentHistory = dt
                End If
                _view.gvEmpHistory.BestFitColumns()
                'Service History
                dt = Nothing
                dt = RecordModel.RetreiveServiceHistory(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcServHistory.DataSource = dt
                    dt_ServiceHistory = dt
                End If
                _view.gvServHistory.BestFitColumns()
                dt = Nothing
                'Address
                dt = Nothing
                dt = RecordModel.RetreiveAddress(personID) 'Home Address
                If dt.Rows.Count > 0 Then
                    _view.txthome_address_line1.Text = If(IsDBNull(dt(0)("address").ToString), "", dt(0)("address").ToString)
                    _view.txthome_pin_code.Text = If(IsDBNull(dt(0)("zipcode").ToString), "", dt(0)("zipcode").ToString)
                    _view.cmbhome_address_line2.Text = If(IsDBNull(dt(0)("barangay").ToString), "", dt(0)("barangay").ToString)
                    _view.cmbhome_city.Text = If(IsDBNull(dt(0)("citymunicipality").ToString), "", dt(0)("citymunicipality").ToString)
                    _view.cmbhome_province.Text = If(IsDBNull(dt(0)("province").ToString), "", dt(0)("province").ToString)
                End If

                dt = Nothing
                dt = RecordModel.RetreiveAddress1(personID) 'Permanent Address
                If dt.Rows.Count > 0 Then
                    _view.txtoffice_address_line1.Text = If(IsDBNull(dt(0)("address").ToString), "", dt(0)("address").ToString)
                    _view.txtoffice_pin_code.Text = If(IsDBNull(dt(0)("zipcode").ToString), "", dt(0)("zipcode").ToString)
                    _view.cmboffice_address_line2.Text = If(IsDBNull(dt(0)("barangay").ToString), "", dt(0)("barangay").ToString)
                    _view.cmboffice_city.Text = If(IsDBNull(dt(0)("citymunicipality").ToString), "", dt(0)("citymunicipality").ToString)
                    _view.cmboffice_province.Text = If(IsDBNull(dt(0)("province").ToString), "", dt(0)("province").ToString)
                End If


            Else
                dt = Nothing
            End If

            If _view.Tag = 1 Then
                'Employee's
                dt = RecordModel.RetreiveEmployee(personID)
                If dt.Rows.Count > 0 Then
                    'ID's
                    _id = If(IsDBNull(dt(0)("id").ToString), 0, dt(0)("id"))
                    RecordModel._id = If(IsDBNull(dt(0)("id").ToString), 0, dt(0)("id"))
                    _userID = If(IsDBNull(dt(0)("user_id").ToString), 0, dt(0)("user_id"))
                    PersonDetails.personID = If(IsDBNull(dt(0)("user_id").ToString), 0, dt(0)("user_id"))
                    _view.txtemployee_number.Text = If(IsDBNull(dt(0)("empl_number").ToString), "", dt(0)("empl_number").ToString)
                    _view.txtbiometric_id.Text = If(IsDBNull(dt(0)("biometric_id").ToString), "", dt(0)("biometric_id").ToString)
                    _view.cmbemployee_department_id.SelectedValue = If(IsDBNull(dt(0)("employee_department_id")), 0, dt(0)("employee_department_id"))
                    _view.cmbjob_title.SelectedValue = If(IsDBNull(dt(0)("job_title")), 0, dt(0)("job_title"))
                    _view.cmbemployee_position_id.SelectedValue = If(IsDBNull(dt(0)("employee_position_id")), 0, dt(0)("employee_position_id"))
                    _view.dtpjoining_date.Value = If(IsDBNull(dt(0)("joining_date")), Date.Now, dt(0)("joining_date"))
                    _view.dtpfirtsday_date.Value = If(IsDBNull(dt(0)("firstday_date")), Date.Now, dt(0)("firstday_date"))
                    _view.nupemployee_expected_salary.Value = If(IsDBNull(dt(0)("salary")), 0, dt(0)("salary"))
                    _view.dtpDateOfApplication.Value = If(IsDBNull(dt(0)("date_encoded")), Date.Now, dt(0)("date_encoded"))
                    'Job Info
                    _view.cmbemployee_category_id.SelectedValue = If(IsDBNull(dt(0)("employee_category_id")), 0, dt(0)("employee_category_id"))
                    _view.cmbstatus_description.Text = If(IsDBNull(dt(0)("status_description").ToString), "", dt(0)("status_description").ToString)
                    _view.cmbemployee_qualification_id.Text = If(IsDBNull(dt(0)("qualification").ToString), "", dt(0)("qualification").ToString)
                    _view.cmbemployee_grade_id.SelectedValue = If(IsDBNull(dt(0)("employee_grade_id")), 0, dt(0)("employee_grade_id"))

                    'Bank Details
                    dt = Nothing
                    dt = RecordModel.RetreiveBank(_id)
                    If dt.Rows.Count > 0 Then
                        _view.gcBank.DataSource = dt
                        dt_bank = dt
                    End If
                    '    _view.gvBank.BestFitColumns()

                Else
                    dt = Nothing
                End If


            Else
                'Student
                dt = RecordModel.RetreiveStudentDetails(_personID)

                Dim PreviousDegree As String = ""

                If dt.Rows.Count > 0 Then

                    RecordModel._id = If(IsDBNull(dt(0)("id")), 0, dt(0)("id"))
                    _view.txtLRN.Text = If(IsDBNull(dt(0)("LRN_number")), "", dt(0)("LRN_number"))
                    _view.txtStudentID.Text = If(IsDBNull(dt(0)("std_number")), "", dt(0)("std_number"))
                    'High School
                    _view.txtHighSchoolName.Text = If(IsDBNull(dt(0)("high_school_name")), "", dt(0)("high_school_name"))
                    _view.txtHighSchoolAddress.Text = If(IsDBNull(dt(0)("high_school_address")), "", dt(0)("high_school_address"))
                    _view.dtpDateGraduation.Value = If(IsDBNull(dt(0)("date_graduation")), Date.Now, dt(0)("date_graduation"))
                    _view.txtExtraCurricularActivities.Text = If(IsDBNull(dt(0)("extra_curricular_activities")), "", dt(0)("extra_curricular_activities"))
                    'College
                    _view.txtCollegeSpecialization.Text = If(IsDBNull(dt(0)("specialization")), "", dt(0)("specialization"))
                    _view.txtCollegeMasterProgram.Text = If(IsDBNull(dt(0)("master_program")), "", dt(0)("master_program"))
                    _view.txtCollegeUniversityName.Text = If(IsDBNull(dt(0)("previous_university")), "", dt(0)("previous_university"))

                    'Others
                    _view.txtExtraCurr_Others.Text = If(IsDBNull(dt(0)("other_extra_curricular_participation")), "", dt(0)("other_extra_curricular_participation"))
                    _view.txtResources_Others.Text = If(IsDBNull(dt(0)("other_resources_avialable")), "", dt(0)("other_resources_avialable"))
                    _view.txtSkillsTalents_Others.Text = If(IsDBNull(dt(0)("other_skills_tallents")), "", dt(0)("other_skills_tallents"))
                    _view.txtSports_Others.Text = If(IsDBNull(dt(0)("other_sports")), "", dt(0)("other_sports"))
                    _view.cmbJoinPosition.SelectedValue = If(IsDBNull(dt(0)("join_position_id")), 0, dt(0)("join_position_id"))

                    PreviousDegree = If(IsDBNull(dt(0)("previous_degree")), "", dt(0)("previous_degree"))
                    If PreviousDegree <> "" Then
                        If PreviousDegree = "Batchelors" Then
                            _view.rbtnDegreeBatchelors.Checked = True
                        Else
                            _view.rbtnDegreeMasters.Checked = True
                        End If
                    Else
                        _view.rbtnDegreeBatchelors.Checked = False
                        _view.rbtnDegreeMasters.Checked = False
                    End If

                    _view.dtpYearFrom.Value = If(IsDBNull(dt(0)("year_from")), Date.Now, dt(0)("year_from"))
                    _view.dtpYearTo.Value = If(IsDBNull(dt(0)("year_to")), Date.Now, dt(0)("year_to"))

                    _view.txtinterest.Text = If(IsDBNull(dt(0)("interest")), "", dt(0)("interest"))
                    _view.txtFamilyMonthlyIncome.Text = If(IsDBNull(dt(0)("estimate_family_monthly_income")), "", dt(0)("estimate_family_monthly_income"))
                    _view.txtChoiceCourse.Text = If(IsDBNull(dt(0)("first_choice_course")), "", dt(0)("first_choice_course"))
                    _view.cmbPlanCollege.Text = If(IsDBNull(dt(0)("plan_after_college")), "", dt(0)("plan_after_college"))

                    _view.txtScholarshipSponsor.Text = If(IsDBNull(dt(0)("scholarship_sponsor_name")), "", dt(0)("scholarship_sponsor_name"))
                    If _view.txtScholarshipSponsor.Text <> "" Then
                        _view.rbtnYesScholarship.Checked = True
                    Else
                        _view.rbtnNoScholarship.Checked = True
                    End If

                    _view.txtAnotherCourse.Text = If(IsDBNull(dt(0)("what_course")), "", dt(0)("what_course"))
                    If _view.txtAnotherCourse.Text <> "" Then
                        _view.rbtnYesAnotherCourse.Checked = True
                    Else
                        _view.rbtnNoAnotherCourse.Checked = True
                    End If

                End If

                dt = Nothing
                'Attended University
                dt = RecordModel.RetreiveAttendedUniversity(personID)
                If dt.Rows.Count > 0 Then
                    _view.gcAttendUniversity.DataSource = dt
                    dt_Attended_University = dt
                    _view.gvAttendUniversity.OptionsView.ColumnAutoWidth = True
                End If

                dt = Nothing
                'Non-Academic
                dt = RecordModel.RetreiveNonAcademic(_personID)
                If dt.Rows.Count > 0 Then

                    For Each rows As DataRow In dt.Rows

                        Dim checkbox = Me.GetAllControls(_view).OfType(Of CheckBox)().ToList()
                        For Each item As CheckBox In checkbox
                            If rows.Item("title").ToString = item.Tag And rows.Item("non_academic_name").ToString = item.Text Then
                                item.Checked = True
                            End If
                        Next

                    Next

                End If

                dt = Nothing
                '     dt = RecordModel.RetreiveListOfAchievements(_personID)
                dt_LisOfAchievements = RecordModel.RetreiveListOfAchievements(_personID)
                If dt_LisOfAchievements.Rows.Count > 0 Then
                    _view.gcAttachAchievements.DataSource = dt_LisOfAchievements
                    gcAttachAchievementsDesign(_view.gvAttachAchievements)

                    For x As Integer = 0 To dt_LisOfAchievements.Rows.Count - 1

                        Dim FilePath As String = ""
                        Dim obj As New ListOfAchievements
                        With obj

                            FilePath = dt_LisOfAchievements(x)("File Path").ToString
                            .FilePath = FilePath.Replace("\", "\\") 'DocumentPath
                            .FileName = dt_LisOfAchievements(x)("File Name").ToString
                            .FullPath = .FilePath
                        End With
                        ListOfAchievments.Add(obj)

                    Next

                Else
                    _view.gcAttachAchievements.DataSource = dt_LisOfAchievements
                End If



                dt_ListOfAttach_Documents = RecordModel.RetreiveListOfAttachments(_personID)
                If dt_ListOfAttach_Documents.Rows.Count > 0 Then
                    _view.gcAttachment.DataSource = dt_ListOfAttach_Documents
                    gcAttachDocumentsDesign(_view.gvAttachment)

                    For x As Integer = 0 To dt_ListOfAttach_Documents.Rows.Count - 1

                        Dim FilePath As String = ""
                        Dim obj As New ListOfAttachment_Documents
                        With obj

                            FilePath = dt_ListOfAttach_Documents(x)("File Path").ToString
                            .FilePath = FilePath.Replace("\", "\\") 'DocumentPath
                            .FileName = dt_ListOfAttach_Documents(x)("File Name").ToString
                            .FullPath = .FilePath
                            .Document_Type = dt_ListOfAttach_Documents(x)("Document Type").ToString
                            .DocumentType_id = dt_ListOfAttach_Documents(x)("ID")
                        End With
                        ListOfAttachments.Add(obj)

                    Next

                Else
                    _view.gcAttachment.DataSource = dt_ListOfAttach_Documents
                End If


            End If


        End If

        '     TrapPhoto = False

    End Function

    Friend Sub CheckIfStudentIDExist()
        If RecordModel.CheckIfStudentIDExist(_view.txtStudentID.Text, _personID) Then
            MsgBox("'" & _view.txtStudentID.Text & "' ID is already exist", MsgBoxStyle.Critical, "Record Found")
            Exit Sub
        End If
    End Sub

    Private Sub AutoGenerated_CodeNumbers()

        Dim LastCode = RecordModel.getLastCode()
        _view.txtbiometric_id.Text = getAutoGenerate_BiometricID(LastCode)

    End Sub

    Private Function getAutoGenerate_BiometricID(lastCode As Object) As String
        If lastCode = 0 Then
            '     lastCode = RecordModel.CurrentCode(_id)
            '     _view.PatientCode.Tag = lastCode
        Else
            '      _view.PatientCode.Tag = lastCode
        End If

        '   _view.PatientCode.Text = String.Format("{0} {1} {2}", "PT-", "00000000", lastCode)
        ' _view.PatientCode.Text = "PT-" & String.Format("0000000", lastCode)
        '       _view.txtbiometric_id.Text = "PT-" + String.Format("{0:D8}", CInt(lastCode))
        _view.txtbiometric_id.Text = String.Format("{0:D8}", CInt(lastCode))
        Return _view.txtbiometric_id.Text
    End Function

    Private Sub Dependent_ColumnHeader()
        dt_Dependent.Columns.Add("Name")
        dt_Dependent.Columns.Add("Birth Date")
        dt_Dependent.Columns.Add("Age")
        dt_Dependent.Columns.Add("Relationship")
        dt_Dependent.Columns.Add("Rank")
        dt_Dependent.Columns.Add("Grade/Year")
        dt_Dependent.Columns.Add("School")

        _view.gcDependent.DataSource = dt_Dependent
    End Sub

    Private Sub FamilyBackground_ColumnHeader()
        dt_FamilyBackground.Columns.Add("Type")
        dt_FamilyBackground.Columns.Add("Name")
        dt_FamilyBackground.Columns.Add("Occupation")
        dt_FamilyBackground.Columns.Add("CompanyName")
        dt_FamilyBackground.Columns.Add("CompanyNumber")
        dt_FamilyBackground.Columns.Add("CompanyAddress")

    End Sub

    Private Sub Bank_ColumnHeader()

        dt_bank.Columns.Add("Bank Name")
        dt_bank.Columns.Add("Account Number")
        _view.gcBank.DataSource = dt_bank

    End Sub

    Private Sub loadAddHandler()
        AddHandler _view.cmbhome_province.SelectionChangeCommitted, AddressOf cmbhome_provinceSelectionChangeCommitted
        AddHandler _view.cmbhome_city.SelectionChangeCommitted, AddressOf cmbhome_citySelectionChangeCommitted
        AddHandler _view.cmbhome_address_line2.SelectionChangeCommitted, AddressOf cmbhome_address_line2SelectionChangeCommitted

        AddHandler _view.cmboffice_province.SelectionChangeCommitted, AddressOf cmboffice_provinceSelectionChangeCommitted
        AddHandler _view.cmboffice_city.SelectionChangeCommitted, AddressOf cmboffice_citySelectionChangeCommitted
        AddHandler _view.cmboffice_address_line2.SelectionChangeCommitted, AddressOf cmboffice_address_line2SelectionChangeCommitted

        AddHandler _view.cmblanguage.SelectionChangeCommitted, AddressOf cmblanguageSelectionChangeCommitted
        AddHandler _view.cmblanguage.SelectedIndexChanged, AddressOf cmblanguageSelectedIndexChanged

        AddHandler _view.txtlast_name.TextChanged, AddressOf txtlast_nameTextChanged
        AddHandler _view.txtfirst_name.TextChanged, AddressOf txtfirst_nameTextChanged
        AddHandler _view.txtmiddle_name.TextChanged, AddressOf txtmiddle_nameTextChanged

        AddHandler _view.txtpicturepath.TextChanged, AddressOf txtpicturepathTextChanged
        AddHandler _view.txtpicturepath.ButtonCustomClick, AddressOf OpenFile

        'AddHandler _view.txtspouse_name.TextChanged, AddressOf txtspouse_nameTextChanged
        'AddHandler _view.txtfather_name.TextChanged, AddressOf txtfather_nameTextChanged
        'AddHandler _view.txtmother_name.TextChanged, AddressOf txtmother_nameTextChanged

        AddHandler _view.btnSave.Click, AddressOf btnSaveClick
        AddHandler _view.btnAdd.Click, AddressOf btnAddClick

        AddHandler _view.btnAddBank.Click, AddressOf btnAddBankClick
        AddHandler _view.btnCancelBank.Click, AddressOf btnCancelBank

        AddHandler _view.btnAddDependent.Click, AddressOf btnAddDependentClick
        AddHandler _view.btnCancelDependent.Click, AddressOf btnCancelDependentClick

        AddHandler _view.btnAddCharRef.Click, AddressOf btnAddCharRef
        AddHandler _view.btnCancelCharRef.Click, AddressOf btnCancelCharRef

        AddHandler _view.btnAddEdu.Click, AddressOf btnAddEdu
        AddHandler _view.btnCancelEdu.Click, AddressOf btnCancelEdu

        AddHandler _view.btnAddEmplH.Click, AddressOf btnAddEmplH
        AddHandler _view.btnCancelEmplH.Click, AddressOf btnCancelEmplH

        AddHandler _view.btnAddServ.Click, AddressOf btnAddServ
        AddHandler _view.btnCancelServ.Click, AddressOf btnCancelServ

        AddHandler _view.txtListAchivementsFilePath.ButtonCustomClick, AddressOf ListAchivementsFilePath
        AddHandler _view.btnAddListAchivement.Click, AddressOf btnAddListAchivement
        AddHandler _view.btnCancelListAchivement.Click, AddressOf btnCancelListAchivement

        AddHandler _view.txtAttachment_FilePath.ButtonCustomClick, AddressOf Attachment_FilePath
        AddHandler _view.btnAddAttach_Documents.Click, AddressOf btnAddAttach_Documents
        AddHandler _view.btnCancelAttach_Documents.Click, AddressOf btnCancelAttach_Documents

        AddHandler _view.btnAddAttUniversity.Click, AddressOf btnAddAttUniversity
        AddHandler _view.btnCancelAttUniversity.Click, AddressOf btnCancelAttUniversity


        AddHandler _view.dtpdate_of_birth.Validating, AddressOf dtpdate_of_birthValidating
        AddHandler _view.chkManulEmplNum.CheckedChanged, AddressOf chkAutoEmplNumCheckedChanged
        AddHandler _view.chkManulStudNum.CheckedChanged, AddressOf chkAutoStudNumCheckedChanged
        AddHandler _view.txtemployee_number.Validating, AddressOf txtemployeenumberValidating
        '      AddHandler _view.txtStudentID.Validating, AddressOf txtStudentIDValidating

        '   AddHandler _view.TabControl4.SelectedTabChanged, AddressOf TabChange
    End Sub

    Private Sub txtStudentIDValidating(sender As Object, e As CancelEventArgs)

        If RecordModel.CheckIfStudentIDExist(_view.txtStudentID.Text, _personID) Then
            MsgBox("Student ID is already", MsgBoxStyle.Critical, "Record Found")
            Exit Sub
        End If
    End Sub

    Private Sub chkAutoStudNumCheckedChanged(sender As Object, e As EventArgs)

        If OPERATION = "EDIT" Then
            _view.txtStudentID.Enabled = True
        End If

    End Sub

    Private Sub btnCancelAttUniversity(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvAttendUniversity.FocusedRowHandle

        For x As Integer = 0 To dt_Attended_University.Rows.Count - 1
            If row = x Then
                dt_Attended_University.Rows.RemoveAt(x)
            End If
        Next
        _view.gcAttendUniversity.DataSource = Nothing
        _view.gcAttendUniversity.DataSource = dt_Attended_University
    End Sub

    Private Sub btnAddAttUniversity(sender As Object, e As EventArgs)
        If dt_Attended_University.Rows.Count = 0 Or dt_Attended_University.Rows.Count > 0 Then
            dt_Attended_University.Rows.Add(_view.txtAttendenUniversityName.Text, _view.txtAttendedUniversityRelationship.Text)
        End If
        _view.gcAttendUniversity.DataSource = dt_Attended_University
        _view.gvAttendUniversity.BestFitColumns()
    End Sub

    Private Sub cmblanguageSelectedIndexChanged(sender As Object, e As EventArgs)
        If _view.txtlanguage.Text = "" Then
            _view.txtlanguage.Text = _view.cmblanguage.Text
        Else
            _view.txtlanguage.Text = _view.txtlanguage.Text & ", " & _view.cmblanguage.Text
        End If
    End Sub

    Private Sub btnCancelAttach_Documents(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvAttachment.FocusedRowHandle

        For x As Integer = 0 To dt_ListOfAttach_Documents.Rows.Count - 1
            If row = x Then
                ListOfAchievments_Delete.Add(IO.Path.Combine(dt_ListOfAttach_Documents(x)("File Path"), dt_ListOfAttach_Documents(x)("File Name")))

                dt_ListOfAttach_Documents.Rows.RemoveAt(x)

                ListOfAttachments.RemoveAt(x)
            End If
        Next
        _view.gcAttachment.DataSource = Nothing
        _view.gcAttachment.DataSource = dt_ListOfAttach_Documents
    End Sub

    Private Sub btnAddAttach_Documents(sender As Object, e As EventArgs)

        If dt_ListOfAttach_Documents.Rows.Count = 0 Or dt_ListOfAttach_Documents.Rows.Count > 0 Then

            For Each rows In dt_ListOfAttach_Documents.Rows
                If rows("File Name") = DocumentFileName Then
                    MsgBox("File Name is already exist", MsgBoxStyle.Critical, "FILE NAME FOUND")
                    Exit Sub
                End If

            Next

            dt_ListOfAttach_Documents.Rows.Add(_view.cmbDocumentType.Text, _view.txtAttach_Filename.Text, DocumentPath, _view.cmbDocumentType.SelectedValue)

            _view.OpenFileDialog2.Dispose()

            Dim FilePath As String = ""
            Dim obj As New ListOfAttachment_Documents
            With obj

                FilePath = DocumentPath
                .FilePath = FilePath.Replace("\", "\\") 'DocumentPath
                .FileName = _view.txtAttach_Filename.Text 'If(_view.txtAttach_Filename.Text.Contains("."), _view.txtAttach_Filename.Text, _view.txtAttach_Filename.Text + "." + DocumentFileFormat) 'DocumentFileName
                .FullPath = _view.txtAttachment_FilePath.Text
                .Document_Type = _view.cmbDocumentType.Text
                .DocumentType_id = _view.cmbDocumentType.SelectedValue
            End With
            ListOfAttachments.Add(obj)

        End If
        _view.gcAttachment.DataSource = dt_ListOfAttach_Documents

        gcAttachDocumentsDesign(_view.gvAttachment)


    End Sub

    Private Sub gcAttachDocumentsDesign(gvAttachment As GridView)
        Dim view As GridView = DirectCast(gvAttachment, GridView)

        view.BeginUpdate()

        For i As Integer = 0 To view.Columns.Count - 1
            view.Columns("Document Type").BestFit()
            view.Columns("File Name").BestFit()
            view.Columns("File Path").BestFit()
            Select Case i
                Case 2
                    view.Columns(i).AppearanceCell.ForeColor = Color.RoyalBlue
                    view.Columns(i).AppearanceCell.FontStyleDelta = FontStyle.Underline
                Case 3
                    view.Columns(i).Visible = False
            End Select

        Next
        view.EndUpdate()
    End Sub

    Private Sub Attachment_FilePath(sender As Object, e As EventArgs)
        Dim names As String = ""
        Dim phrase As String = ""

        _view.OpenFileDialog2.Dispose()

        If _view.OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then

            CreatFolder(_view.txtfull_name.Text, "Attachment")

            _view.txtAttachment_FilePath.Text = _view.OpenFileDialog2.FileName
            names = _view.txtAttachment_FilePath.Text.Trim
            phrase = names.Substring(names.LastIndexOf("\"c) + 1)
            DocumentFileName = phrase
            DocumentPath = DocumentPath '& phrase
            '        DocumentFileFormat = phrase.Substring(names.LastIndexOf("."c))
            _view.txtAttach_Filename.Text = phrase
        End If
    End Sub

    Dim DocumentPath As String = ""
    Dim DocumentFileName As String = ""
    Dim DocumentFileFormat As String = ""

    Private Sub ListAchivementsFilePath(sender As Object, e As EventArgs)

        Dim names As String = ""
        Dim phrase As String = ""

        If _view.OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then

            CreatFolder(_view.txtfull_name.Text, "List of Achievement")

            _view.txtListAchivementsFilePath.Text = _view.OpenFileDialog2.FileName
            names = _view.txtListAchivementsFilePath.Text.Trim
            phrase = names.Substring(names.LastIndexOf("\"c) + 1)
            DocumentFileName = phrase
            DocumentPath = DocumentPath '& phrase

        End If

    End Sub

    Private Sub CreatFolder(FullName As String, FolderName As String)

        Dim spath As String = ""
        If ServerPath <> "" Then

            appSettings = ConfigurationManager.AppSettings("Server_DOCUMENTS_Path")
            _directory_info = New DirectoryInfo(appSettings)
            spath = _directory_info.FullName & "\" & FolderName & "\"

            If (Not System.IO.Directory.Exists(System.IO.Path.Combine(spath, FullName))) Then
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(spath, FullName))
            End If

            spath = spath + FullName + "\"
            DocumentPath = spath


        Else
            spath = Directory.GetCurrentDirectory & "\DOCUMENTS\" & FolderName

            If (Not System.IO.Directory.Exists(System.IO.Path.Combine(spath, FullName))) Then
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(spath, FullName))
            End If

            spath = spath + FullName + "\"
            DocumentPath = spath

        End If




    End Sub

    Private Sub btnCancelListAchivement(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvAttachAchievements.FocusedRowHandle
        For x As Integer = 0 To dt_LisOfAchievements.Rows.Count - 1
            If row = x Then
                ListOfAchievments_Delete.Add(IO.Path.Combine(dt_LisOfAchievements(x)("File Path"), dt_LisOfAchievements(x)("File Name")))

                dt_LisOfAchievements.Rows.RemoveAt(x)

                ListOfAchievments.RemoveAt(x)
            End If
        Next
        _view.gcAttachAchievements.DataSource = Nothing
        _view.gcAttachAchievements.DataSource = dt_LisOfAchievements

    End Sub

    Private Sub btnAddListAchivement(sender As Object, e As EventArgs)

        _view.OpenFileDialog2.Dispose()

        If dt_LisOfAchievements.Rows.Count = 0 Or dt_LisOfAchievements.Rows.Count > 0 Then

            For Each rows In dt_LisOfAchievements.Rows
                If rows("File Name") = DocumentFileName Then
                    MsgBox("File Name is already exist", MsgBoxStyle.Critical, "FILE NAME FOUND")
                    Exit Sub
                End If

            Next

            dt_LisOfAchievements.Rows.Add(DocumentFileName, DocumentPath)

            Dim FilePath As String = ""
            Dim obj As New ListOfAchievements
            With obj

                FilePath = DocumentPath
                .FilePath = FilePath.Replace("\", "\\") 'DocumentPath
                .FileName = DocumentFileName
                .File_Size = New System.IO.FileInfo(_view.OpenFileDialog2.FileName).Length
                .FullPath = _view.txtListAchivementsFilePath.Text
                '             .OpenFileDialog.FileName = .FileName ' System.IO.Path.GetFileName(_view.OpenFileDialog2.FileName)
                '    .Picture_Box.Image = Image.FromFile(_view.OpenFileDialog2.FileName)                 
            End With
            ListOfAchievments.Add(obj)

        End If
        _view.gcAttachAchievements.DataSource = dt_LisOfAchievements

        gcAttachAchievementsDesign(_view.gvAttachAchievements)

    End Sub

    Private Sub gcAttachAchievementsDesign(gvAttachAchievements As GridView)

        Dim view As GridView = DirectCast(gvAttachAchievements, GridView)

        view.BeginUpdate()

        For i As Integer = 0 To view.Columns.Count - 1

            view.Columns("File Name").BestFit()
            view.Columns("File Path").BestFit()
            Select Case i
                Case 1
                    view.Columns(i).AppearanceCell.ForeColor = Color.RoyalBlue
                    view.Columns(i).AppearanceCell.FontStyleDelta = FontStyle.Underline
            End Select

        Next
        view.EndUpdate()

    End Sub

    Private Sub txtemployeenumberValidating(sender As Object, e As CancelEventArgs)
        Dim IfExist As Boolean = True
        IfExist = RecordModel.getExistingEmplNumber(_view.txtemployee_number.Text)
        If IfExist Then
            MsgBox("Employee Number is Already Exist", MsgBoxStyle.Critical, "EMPLOYEE NUMBER MUST BE UNIQUE")
        End If
    End Sub

    Private Sub chkAutoEmplNumCheckedChanged(sender As Object, e As EventArgs)
        _view.txtemployee_number.Enabled = True
    End Sub

    Private Sub dtpdate_of_birthValidating(sender As Object, e As CancelEventArgs)
        _view.txtemployee_number.Text = AutoGenerated_Employeenumber()
    End Sub

    Private Function AutoGenerated_Employeenumber()
        Dim EmplNumber As String = ""
        Dim year As String = Format(Date.Now.Date, "yyyy")
        Dim bday As String = Format(_view.dtpdate_of_birth.Value, "MMdd")
        Dim lastNumber As String = RecordModel.getLastEmplNumber()

        If lastNumber = "" Then
            lastNumber = 1
        Else
            lastNumber += 1
        End If

        lastNumber = String.Format("{0:D4}", CInt(lastNumber))
        EmplNumber = String.Format("{0}{1}{2}{3}{4}{5}", "TPC", year, "-", bday, "-", lastNumber)
        Return EmplNumber
    End Function

    'Private Sub TabChange(sender As Object, e As TabStripTabChangedEventArgs)
    '    _view.cmboffice_province.DataSource = Province  'RecordModel.getProvince
    '    _view.cmboffice_province.ValueMember = "ID"
    '    _view.cmboffice_province.DisplayMember = "Name"
    '    _view.cmboffice_province.SelectedIndex = -1

    'End Sub

    Private Sub btnCancelServ(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvServHistory.FocusedRowHandle

        For x As Integer = 0 To dt_ServiceHistory.Rows.Count - 1
            If row = x Then
                dt_ServiceHistory.Rows.RemoveAt(x)
            End If
        Next
        _view.gcServHistory.DataSource = Nothing
        _view.gcServHistory.DataSource = dt_EmploymentHistory

    End Sub

    Private Sub btnAddServ(sender As Object, e As EventArgs)
        If dt_ServiceHistory.Rows.Count = 0 Or dt_ServiceHistory.Rows.Count > 0 Then
            dt_ServiceHistory.Rows.Add(_view.cmbServEligibilityLevel.Text, _view.txtServEligibilityCareer.Text, Format(_view.dtpServDateExamination.Value, "MMMM dd,yyyy"), _view.txtServEligibilityPlaceofExam.Text, _view.txtServEligibilityRating.Text, _view.txtServEligibilityLicense_no.Text, Format(_view.dtpServEligibilityLicense_rel_date.Value, "MMMM dd,yyyy"))
        End If
        _view.gcServHistory.DataSource = dt_ServiceHistory
        _view.gvServHistory.BestFitColumns()
    End Sub

    Private Sub btnCancelEmplH(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvEmpHistory.FocusedRowHandle

        For x As Integer = 0 To dt_EmploymentHistory.Rows.Count - 1
            If row = x Then
                dt_EmploymentHistory.Rows.RemoveAt(x)
            End If
        Next
        _view.gcEmpHistory.DataSource = Nothing
        _view.gcEmpHistory.DataSource = dt_EmploymentHistory
    End Sub

    Private Sub btnAddEmplH(sender As Object, e As EventArgs)

        If dt_EmploymentHistory.Rows.Count = 0 Or dt_EmploymentHistory.Rows.Count > 0 Then
            dt_EmploymentHistory.Rows.Add(_view.txtEmpHCompany.Text, Format(_view.dtpEmpHFrom.Value, "MMMM dd,yyyy"), Format(_view.dtpEmplHTo.Value, "MMMM dd,yyyy"), _view.txtEmplHContactNo.Text)
        End If
        _view.gcEmpHistory.DataSource = dt_EmploymentHistory
        _view.gvEmpHistory.BestFitColumns()
    End Sub

    Private Sub btnCancelEdu(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvEduAttainment.FocusedRowHandle

        For x As Integer = 0 To dt_EducationalAttainment.Rows.Count - 1
            If row = x Then
                dt_EducationalAttainment.Rows.RemoveAt(x)
            End If
        Next
        _view.gcEduAttainment.DataSource = Nothing
        _view.gcEduAttainment.DataSource = dt_EducationalAttainment
    End Sub

    Private Sub btnAddEdu(sender As Object, e As EventArgs)

        If dt_EducationalAttainment.Rows.Count = 0 Or dt_EducationalAttainment.Rows.Count > 0 Then
            dt_EducationalAttainment.Rows.Add(_view.cmbEducationalAttainment.Text, _view.txtEduSchoolAddress.Text, Format(_view.dtpEduFrom.Value, "MMMM dd,yyyy"), Format(_view.dtpEduTo.Value, "MMMM dd,yyyy"), _view.txtEduHonorReceived.Text)
        End If
        _view.gcEduAttainment.DataSource = dt_EducationalAttainment
    End Sub

    Private Sub btnCancelCharRef(sender As Object, e As EventArgs)

        Dim row As Integer = _view.gvCharRef.FocusedRowHandle
        'dt_CharacterReference.Columns.Clear()
        'dt_CharacterReference.Rows.Clear()
        'dt_CharacterReference = _view.gcCharRef.DataSource

        For x As Integer = 0 To dt_CharacterReference.Rows.Count - 1
            If row = x Then
                dt_CharacterReference.Rows.RemoveAt(x)
            End If
        Next
        _view.gcCharRef.DataSource = Nothing
        _view.gcCharRef.DataSource = dt_CharacterReference

    End Sub

    Private Sub btnAddCharRef(sender As Object, e As EventArgs)

        If dt_CharacterReference.Rows.Count = 0 Or dt_CharacterReference.Rows.Count > 0 Then
            dt_CharacterReference.Rows.Add(_view.txtCharRefName.Text, _view.txtCharRefPosition.Text, _view.txtCharRefCompany.Text, _view.txtCharRefContactNo.Text)
        End If
        _view.gcCharRef.DataSource = dt_CharacterReference
        _view.gvCharRef.BestFitColumns()

    End Sub
    Dim names As String = ""
    Dim DoNoTSave As Boolean = False
    Dim LoadedImage As Boolean = False
    Dim source_path As String

    Private Sub OpenFile(sender As Object, e As EventArgs)

        'OpenFile:

        With _view.OpenFileDialog1
            .Title = "Select an Image"  ' Path.GetFileName(.FileName)
            .InitialDirectory = "C:\"
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|All files (*.*)|*.*" '"JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
            .FilterIndex = 1

        End With
        If _view.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LoadedImage = True
            With _view.box_picture
                .Image = Image.FromFile(_view.OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D

            End With
        End If

        _view.txtpicturepath.Text = _view.OpenFileDialog1.FileName
        _photo_path = _view.txtpicturepath.Text
        source_path = _view.txtpicturepath.Text
        names = _view.txtpicturepath.Text.Trim
        Dim phrase As String = names.Substring(names.LastIndexOf("\"c) + 1)

        '     _photo_filename = phrase
        _view.txtpicturepath.Text = phrase
        '        _photo_path = Dir & _view.txtpicturepath.Text

        ''Check Image
        'Dim Exist As Boolean = RecordModel.CheckImage(_view.txtpicturepath.Text)
        'If Exist Then
        '    MsgBox("Image is already in use", MsgBoxStyle.Information, "ALREADY EXIST")

        '    _view.txtpicturepath.Text = ""
        '    loadPicture(False, "")

        '    Exit Sub
        'End If


    End Sub
    '   Dim combinePath As String


    Private Function ReadFile(sPath As String) As Byte()
        Dim data As Byte() = Nothing
        Dim fInfo As New IO.FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        Using fStream As New IO.FileStream(sPath, IO.FileMode.Open, IO.FileAccess.Read)
            Dim br As New IO.BinaryReader(fStream)
            data = br.ReadBytes(CInt(numBytes))
        End Using
        Return data
    End Function

    Private Sub loadPicture(Optional ByVal isSelected As Boolean = False, Optional ByVal ImageFile As String = Nothing)
        Dim PathDestination As String = ""
        If isSelected Then

            PathDestination = ImageFile
            If PathDestination = "" Then
                _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
                _view.box_picture.BorderStyle = BorderStyle.Fixed3D
                _view.box_picture.Load(DefautltPic)

            Else
                Try
                    If SavingDir = "local.dir" Then
                        'If ServerPath <> "" Then

                        '          combinePath = Dir.Replace("\\", "\")
                        Current_Dir = Directory.GetCurrentDirectory & "\PIC\"
                        Current_Dir = System.IO.Path.Combine(Current_Dir, ImageFile)
                        PathDestination = Current_Dir
                        If System.IO.File.Exists(PathDestination) Then
                            _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
                            _view.box_picture.BorderStyle = BorderStyle.Fixed3D
                            _view.box_picture.Load(PathDestination)
                        End If

                    Else
                        PathDestination = Dir
                        If System.IO.File.Exists(PathDestination) Then
                            _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
                            _view.box_picture.BorderStyle = BorderStyle.Fixed3D
                            _view.box_picture.Load(PathDestination)
                        End If
                    End If

                Catch ex As Exception
                    _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
                    _view.box_picture.BorderStyle = BorderStyle.Fixed3D
                    _view.box_picture.Load(DefautltPic)

                End Try

            End If



            'If ServerPath <> "" Then

            '    'Server Path
            '    Try
            '        PathDestination = Dir
            '        If System.IO.File.Exists(PathDestination) Then
            '            _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
            '            _view.box_picture.BorderStyle = BorderStyle.Fixed3D
            '            _view.box_picture.Load(PathDestination)
            '        End If

            '    Catch ex As Exception

            '    End Try

            'Else


            '    PathDestination = ImageFile
            '    If PathDestination = "" Then
            '        _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
            '        _view.box_picture.BorderStyle = BorderStyle.Fixed3D
            '        _view.box_picture.Load(DefautltPic)
            '    Else
            '        PathDestination = Dir & ImageFile
            '        '      combinePath = System.IO.Path.Combine(Dir, ImageFile).Replace("\\", "\\\\")
            '        '      PathDestination = combinePath
            '        _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
            '        _view.box_picture.BorderStyle = BorderStyle.Fixed3D

            '        If System.IO.File.Exists(PathDestination) Then
            '            _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
            '            _view.box_picture.BorderStyle = BorderStyle.Fixed3D
            '            _view.box_picture.Load(PathDestination)
            '        Else
            '            _view.box_picture.Load(PathDestination)
            '        End If


            '    End If
            'End If

        Else

            _view.box_picture.SizeMode = PictureBoxSizeMode.StretchImage
            _view.box_picture.BorderStyle = BorderStyle.Fixed3D
            _view.box_picture.Load(DefautltPic)

        End If
    End Sub


    Dim TrapPhoto As Boolean = False
    Private Sub txtpicturepathTextChanged(sender As Object, e As EventArgs)

        TrapPhoto = True
        Try
            If _view.txtpicturepath.Text.Trim = "" Then
                _view.box_picture.BackgroundImage = DefaultImage
            Else
                _view.box_picture.BackgroundImage = Image.FromFile(_view.txtpicturepath.Text)
            End If
        Catch ex As Exception


        End Try

    End Sub

    Private Sub btnCancelDependentClick(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvDependent.FocusedRowHandle
        'dt_Dependent.Columns.Clear()
        'dt_Dependent.Rows.Clear()
        'dt_Dependent = _view.gcDependent.DataSource

        For x As Integer = 0 To dt_Dependent.Rows.Count - 1
            If row = x Then
                dt_Dependent.Rows.RemoveAt(x)
            End If
        Next
        _view.gcDependent.DataSource = Nothing
        _view.gcDependent.DataSource = dt_Dependent
    End Sub

    Private Sub btnAddDependentClick(sender As Object, e As EventArgs)
        If dt_Dependent.Rows.Count = 0 Or dt_Dependent.Rows.Count > 0 Then
            dt_Dependent.Rows.Add(_view.txtDependentName.Text, Format(_view.dtpDependentBirthDate.Value, "MMM dd, yyyy"), _view.txtDependentAge.Text, _view.cmbDependentRelationship.Text, _view.nudDependentCount.Value, _view.txtDependentGradeYear.Text, _view.txtDependentSchool.Text)
        End If
        _view.gcDependent.DataSource = dt_Dependent

        _view.gvDependent.BestFitColumns()
    End Sub


    Private Sub txtmother_nameTextChanged(sender As Object, e As EventArgs)

        If _view.txtmother_name.TextLength > 0 Then
            If dt_FamilyBackground.Rows.Count = 0 Or dt_FamilyBackground.Rows.Count > 0 Then
                '             dt_FamilyBackground.Rows.Add(_view.GroupControl3.Tag, _view.txtmother_name.Text, _view.txtmother_occupation.Text, _view.txtmother_company.Text,
                '           _view.txtmother_companyNo.Text, _view.txtmother_companyAddress.Text)
            End If
        End If

    End Sub

    Private Sub txtfather_nameTextChanged(sender As Object, e As EventArgs)

        If _view.txtfather_name.TextLength > 0 Then
            If dt_FamilyBackground.Rows.Count = 0 Or dt_FamilyBackground.Rows.Count > 0 Then
                '          dt_FamilyBackground.Rows.Add(_view.GroupControl2.Tag, _view.txtfather_name.Text, _view.txtfather_occupation.Text, _view.txtfather_company.Text,
                '       _view.txtfather_companyNo.Text, _view.txtfather_companyAddress.Text)
            End If
        End If

    End Sub

    Private Sub txtspouse_nameTextChanged(sender As Object, e As EventArgs)

        If _view.txtspouse_name.TextLength > 0 Then
            If dt_FamilyBackground.Rows.Count = 0 Or dt_FamilyBackground.Rows.Count > 0 Then
                '           dt_FamilyBackground.Rows.Add(_view.GroupControl1.Tag, _view.txtspouse_name.Text, _view.txtspouse_occupation.Text, _view.txtspouse_company.Text,
                '       _view.txtspouse_companyNo.Text, _view.txtspouse_companyAddress.Text)
            End If
        End If

    End Sub

    Private Sub btnCancelBank(sender As Object, e As EventArgs)
        Dim row As Integer = _view.gvBank.FocusedRowHandle

        For x As Integer = 0 To dt_bank.Rows.Count - 1
            If row = x Then
                dt_bank.Rows.RemoveAt(x)
            End If
        Next
        _view.gcBank.DataSource = Nothing
        _view.gcBank.DataSource = dt_bank
    End Sub

    Dim rowIndex As Integer = 0
    Private Sub btnAddBankClick(sender As Object, e As EventArgs)

        If dt_bank.Rows.Count = 0 Or dt_bank.Rows.Count > 0 Then
            dt_bank.Rows.Add(_view.txtBankName.Text, _view.txtAccountNumber.Text)
        End If
        _view.gcBank.DataSource = dt_bank

    End Sub

    Private Sub btnAddClick(sender As Object, e As EventArgs)
        ClearForm()
    End Sub

    Public Sub ClearForm()
        TrapPhoto = False
        _view.TabControl2.Enabled = True

        _view.GroupPanel1.Enabled = True
        _view.GroupPanel3.Enabled = True
        _view.GroupPanel12.Enabled = True
        _view.GroupPanel13.Enabled = True
        _view.GroupPanel15.Enabled = True
        _view.GroupBox26.Enabled = True


        _view.TabControl5.Enabled = True
        _view.TabControl7.Enabled = True

        cleanControls(_view)

        dt_bank.Rows.Clear()
        dt_Dependent.Rows.Clear()
        dt_FamilyBackground.Rows.Clear()
        dt_CharacterReference.Rows.Clear()
        dt_EducationalAttainment.Rows.Clear()
        dt_EmploymentHistory.Rows.Clear()
        dt_ServiceHistory.Rows.Clear()
        dt_LisOfAchievements.Rows.Clear()
        dt_ListOfAttach_Documents.Rows.Clear()
        dt_Attended_University.Rows.Clear()

        ListOfAchievments.Clear()
        ListOfAchievments_Delete.Clear()

        ListOfAttachments.Clear()
        ListOfAttachments_Deleted.Clear()

        Attended_University.Clear()
        NonAcademic.Clear()

        loadPicture(False, "")

        OPERATION = "ADD"
        _view.btnSave.Enabled = True
    End Sub

    Public Sub cleanControls(frm As fmaEmployeeRecord)

        Dim textboxes = Me.GetAllControls(frm).OfType(Of TextBox)().ToList()
        For Each item As TextBox In textboxes
            item.Text = Nothing
        Next

        Dim NumericUpDown = Me.GetAllControls(frm).OfType(Of NumericUpDown)().ToList()
        For Each item As NumericUpDown In NumericUpDown
            item.Value = 0
        Next

        Dim combobox = Me.GetAllControls(frm).OfType(Of ComboBox)().ToList()
        For Each item As ComboBox In combobox
            item.SelectedIndex = -1
        Next

        Dim datetimepicker = Me.GetAllControls(frm).OfType(Of DateTimePicker)().ToList()
        For Each item As DateTimePicker In datetimepicker
            item.Value = Date.Now
        Next

        Dim checkbox = Me.GetAllControls(frm).OfType(Of CheckBox)().ToList()
        For Each item As CheckBox In checkbox
            If item.Tag IsNot Nothing Then
                item.Checked = False
            End If
        Next

    End Sub

    Private Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function

    Private Sub cmblanguageSelectionChangeCommitted(sender As Object, e As EventArgs)

        'If _view.txtlanguage.Text = "" Then
        '    _view.txtlanguage.Text = _view.cmblanguage.SelectedText
        'Else
        '    _view.txtlanguage.Text = _view.txtlanguage.Text & ", " & _view.cmblanguage.SelectedText
        'End If

    End Sub

    Private Sub txtmiddle_nameTextChanged(sender As Object, e As EventArgs)
        _view.txtfull_name.Text = _view.txtlast_name.Text & ", " & _view.txtfirst_name.Text & " " & _view.txtmiddle_name.Text
    End Sub

    Private Sub txtfirst_nameTextChanged(sender As Object, e As EventArgs)
        _view.txtfull_name.Text = _view.txtlast_name.Text & ", " & _view.txtfirst_name.Text & " " & _view.txtmiddle_name.Text
    End Sub

    Private Sub txtlast_nameTextChanged(sender As Object, e As EventArgs)
        _view.txtfull_name.Text = _view.txtlast_name.Text & ", " & _view.txtfirst_name.Text & " " & _view.txtmiddle_name.Text
    End Sub

    Private Sub cmboffice_address_line2SelectionChangeCommitted(sender As Object, e As EventArgs)
        'Try
        '    Dim drv As DataRowView = DirectCast(_view.cmboffice_address_line2.SelectedItem, DataRowView)

        '    _view.cmboffice_province.DataSource = RecordModel.getProvinceParam(drv.Item("provCode"))
        '    _view.cmboffice_province.ValueMember = "ID"
        '    _view.cmboffice_province.DisplayMember = "Name"

        '    _view.cmboffice_city.DataSource = RecordModel.getCityMunicipalityParam(drv.Item("citymunCode"), "MunicipalityCity")
        '    _view.cmboffice_city.ValueMember = "ID"
        '    _view.cmboffice_city.DisplayMember = "Name"

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmboffice_citySelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmboffice_city.SelectedItem, DataRowView)

            '_view.cmboffice_province.DataSource = RecordModel.getProvinceParam(drv.Item("provCode"))
            '_view.cmboffice_province.ValueMember = "ID"
            '_view.cmboffice_province.DisplayMember = "Name"

            _view.cmboffice_address_line2.DataSource = RecordModel.getBarangayParam(drv.Item("citymunCode"), "MunicipalityCity")
            _view.cmboffice_address_line2.ValueMember = "ID"
            _view.cmboffice_address_line2.DisplayMember = "Name"

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub cmboffice_provinceSelectionChangeCommitted(sender As Object, e As EventArgs)
    '    Try
    '        Dim drv As DataRowView = DirectCast(_view.cmboffice_province.SelectedItem, DataRowView)

    '        _view.cmboffice_city.DataSource = RecordModel.getCityMunicipalityParam(drv.Item("provCode"), "Province")
    '        _view.cmboffice_city.ValueMember = "ID"
    '        _view.cmboffice_city.DisplayMember = "Name"

    '        '_view.cmboffice_address_line2.DataSource = RecordModel.getBarangayParam(drv.Item("provCode"), "Province")
    '        '_view.cmboffice_address_line2.ValueMember = "ID"
    '        '_view.cmboffice_address_line2.DisplayMember = "Name"

    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnSaveClick(sender As Object, e As EventArgs)

        RecordModel._CreatUser = If(_view.chkUpdateCreatUser.Checked = True, True, False)

        Dim Photo As New List(Of PersonDetails.Photo)
        Dim Address As New List(Of PersonDetails.Address)
        Dim FamilyBackground As New List(Of PersonDetails.FamilyAndGuardian)
        Dim DateOfBirth As Date = _view.dtpdate_of_birth.Value

        If _view.txtlast_name.Text.Length = 0 And _view.txtfirst_name.Text.Length = 0 Then
            MsgBox("Required Fields, Complete Name Profiling...", MsgBoxStyle.Critical, "All fields are required")
            Exit Sub
        Else
            '        DateOfBirth = _view.dtpdate_of_birth.Value
            If Format(DateOfBirth.Date, "MM/dd/yyyy") = Format(Date.Now, "MM/dd/yyyy") Then
                MsgBox("Required Fields, Birth Date...", MsgBoxStyle.Critical, "This fields are required")
                Exit Sub
            Else
                If _view.cmbgender.SelectedIndex = -1 And _view.cmbgender.Text = "" Then
                    MsgBox("Required Fields, Gender...", MsgBoxStyle.Critical, "This fields are required")
                    Exit Sub
                End If
            End If
        End If



        With PersonDetails
            'Person data
            .person_type = _view.Tag
            .personID = _personID

            .first_name = _view.txtfirst_name.Text
            .last_name = _view.txtlast_name.Text
            .middle_name = _view.txtmiddle_name.Text
            .full_name = _view.txtfull_name.Text
            .date_of_birth = _view.dtpdate_of_birth.Value
            .date_of_place = _view.txtbirthplace.Text
            .relegion = _view.txtreligion.Text
            .gender = _view.cmbgender.Text
            .marital_status = _view.cmbmarital_status.Text
            .blood_group = _view.cmbblood_group.Text
            .nationality_id = _view.cmbnationality_id.SelectedValue
            .language = _view.txtlanguage.Text
            .disability = _view.txtdisability.Text

            'numbers and email
            .home_phone = _view.txthome_phone.Text
            .mobile_phone = _view.txtmobile_phone.Text
            .email = _view.txtemail.Text

            'contact person
            .contact_person = _view.txtcontact_person.Text
            .contact_number = _view.txtcontact_number.Text
            .contact_address = _view.txtcontact_address.Text
            .contact_relationship = _view.txtcontact_relationship.Text

            'statutory
            If _view.Tag = 1 Then
                .TIN = _view.txtTIN1.Text
                .SSS = _view.txtSSS1.Text
                .PagIBIG = _view.txtPagIBIG1.Text
                .PhilHealth = _view.txtPhilHealth1.Text
            Else
                .TIN = _view.txtTIN.Text
                .SSS = _view.txtSSS.Text
                .PagIBIG = _view.txtPagIBIG.Text
                .PhilHealth = _view.txtPhilHealth.Text
            End If




        End With


        Try

            Try
                Try
                    'Home Address
                    Dim obj As New PersonDetails.Address
                    With obj
                        If _view.txthome_address_line1.Text.Length > 0 Then
                            .address_type_id = 1
                            .address = _view.txthome_address_line1.Text
                            .barangay = _view.cmbhome_address_line2.Text
                            .citymunicipality = _view.cmbhome_city.Text
                            .zipcode = _view.txthome_pin_code.Text
                            .province = _view.cmbhome_province.Text
                        End If
                    End With
                    Address.Add(obj)
                Catch ex As Exception
                End Try

                Try
                    'Permanent Address
                    Dim obj As New PersonDetails.Address
                    With obj
                        If _view.txtoffice_address_line1.Text.Length > 0 Then
                            .address_type_id = 2
                            .address = _view.txtoffice_address_line1.Text
                            .barangay = _view.cmboffice_address_line2.Text
                            .citymunicipality = _view.cmboffice_city.Text
                            .zipcode = _view.txtoffice_pin_code.Text
                            .province = _view.cmboffice_province.Text
                        End If
                    End With
                    Address.Add(obj)
                Catch ex As Exception
                End Try


                Try
                    'Photo

                    If clsDBConn.ServerName = "localhost" Then
                        Try
                            If System.IO.Directory.Exists((Current_Dir)) Then
                                combinePath = System.IO.Path.Combine(Current_Dir, _view.txtfull_name.Text & ".jpeg").Replace("\", "\\")
                            End If
                        Catch ex As Exception
                        End Try
                    Else
                        If LoadedImage = True Then
                            combinePath = System.IO.Path.Combine(Dir, _view.txtfull_name.Text & ".jpeg").Replace("\", "\\")
                        Else
                            combinePath = Dir.Replace("\", "\\")
                        End If
                    End If



                    If _view.txtpicturepath.Text <> "" Then

                        Dim obj As New PersonDetails.Photo
                        With obj
                            .photo_file_name = _view.txtfull_name.Text & ".jpeg" '_photo_filename
                            .photo_path = combinePath 'Dir & _view.txtfull_name.Text & ".jpg"   '_view.txtpicturepath.Text
                            .original_photo_file_name = _view.txtpicturepath.Text
                        End With
                        Photo.Add(obj)

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    'Dependent
                    For Each rows As DataRow In dt_Dependent.Rows
                        Dim obj As New PersonDetails.Dependent
                        With obj
                            .dependent_name = rows("Name")
                            .dependent_birthdate = rows("Birth Date").ToString
                            .dependent_relationship = rows("Relationship")
                            .dependent_rank = rows("Rank")
                            .dependent_gradeyear = rows("Grade/Year")
                            .dependent_school = rows("School")
                        End With
                        Dependent.Add(obj)
                    Next
                Catch ex As Exception
                End Try


                Try
                    'Spouse's
                    Dim obj As New PersonDetails.FamilyAndGuardian
                    With obj
                        If _view.txtspouse_name.Text.Length >= 0 Then
                            .typeFamilyGuardian = "Spouse"
                            .name = _view.txtspouse_name.Text
                            .occupation = _view.txtspouse_occupation.Text
                            .company_name = _view.txtspouse_company.Text
                            .company_number = _view.txtspouse_companyNo.Text
                            .company_address = _view.txtspouse_companyAddress.Text
                            FamilyBackground.Add(obj)
                        End If
                    End With

                Catch ex As Exception

                End Try


                Try
                    'Father
                    Dim obj As New PersonDetails.FamilyAndGuardian
                    With obj
                        If _view.txtfather_name.Text.Length >= 0 Then
                            .typeFamilyGuardian = "Father"
                            .name = _view.txtfather_name.Text
                            .occupation = _view.txtfather_occupation.Text
                            .company_name = _view.txtfather_company.Text
                            .company_number = _view.txtfather_companyNo.Text
                            .company_address = _view.txtfather_companyAddress.Text
                            FamilyBackground.Add(obj)
                        End If
                    End With

                Catch ex As Exception

                End Try


                Try
                    'Mother
                    Dim obj As New PersonDetails.FamilyAndGuardian
                    With obj
                        If _view.txtmother_name.Text.Length >= 0 Then
                            .typeFamilyGuardian = "Mother"
                            .name = _view.txtmother_name.Text
                            .occupation = _view.txtmother_occupation.Text
                            .company_name = _view.txtmother_company.Text
                            .company_number = _view.txtmother_companyNo.Text
                            .company_address = _view.txtmother_companyAddress.Text
                            FamilyBackground.Add(obj)
                        End If
                    End With

                Catch ex As Exception

                End Try

                Try
                    'Character Reference
                    For Each rows As DataRow In dt_CharacterReference.Rows
                        Dim obj As New EmployeeDetails.CharacterReference
                        With obj
                            .CharRName = rows.Item("Person Name").ToString
                            .CharRPosition = rows.Item("Position").ToString
                            .CharRcompany = rows.Item("Company").ToString
                            .CharRContactNumber = rows.Item("Contact Number").ToString
                        End With
                        CharacterReference.Add(obj)
                    Next
                Catch ex As Exception
                End Try



            Catch ex As Exception

            End Try

            If _view.Tag = 1 Then

                With EmployeeDetails
                    '   Designated
                    .id = _id
                    .userID = _userID
                    .empl_number = _view.txtemployee_number.Text
                    .employee_number = RecordModel.getNumberDigit(_view.txtemployee_number.Text)
                    .biometric_id = _view.txtbiometric_id.Text
                    .employee_department_id = _view.cmbemployee_department_id.SelectedValue
                    .job_title = _view.cmbjob_title.SelectedValue
                    .employee_position_id = _view.cmbemployee_position_id.SelectedValue
                    .joining_date = _view.dtpjoining_date.Value
                    .firtsday_date = _view.dtpfirtsday_date.Value
                    .salary = _view.nupemployee_expected_salary.Value
                    .date_application = _view.dtpDateOfApplication.Value

                    'Job Info
                    .employee_category_id = _view.cmbemployee_category_id.SelectedValue
                    .status_description = _view.cmbstatus_description.Text
                    .employee_qualification = _view.cmbemployee_qualification_id.Text
                    .employee_grade_id = _view.cmbemployee_grade_id.SelectedValue

                End With

            Else

                With StudentDetails
                    'Academic Background
                    .LRN = _view.txtLRN.Text
                    .student_data = _view.cmbStudentData.Text
                    .year_level = _view.cmbYearLevel.Text
                    .date_application = _view.dtpDateAppication.Value
                    .interest = _view.txtinterest.Text
                    .family_income = _view.txtFamilyMonthlyIncome.Text
                    .sponsors = _view.txtScholarshipSponsor.Text
                    .course_another = _view.txtAnotherCourse.Text
                    .course_choice = _view.txtChoiceCourse.Text
                    .plan_after_college = _view.cmbPlanCollege.Text
                    .join_position_id = _view.cmbJoinPosition.SelectedValue

                    'High School Information
                    .high_school_name = _view.txtHighSchoolName.Text
                    .high_school_address = _view.txtHighSchoolAddress.Text
                    .high_school_dategraduation = _view.dtpDateGraduation.Value
                    .high_school_lisachivement_filepath = _view.txtListAchivementsFilePath.Text
                    .high_school_extracurr_activities = _view.txtExtraCurricularActivities.Text

                    'College Information
                    .college_master_program = _view.txtCollegeMasterProgram.Text
                    .college_specialization = _view.txtCollegeSpecialization.Text
                    .college_degree_earned = If(_view.rbtnDegreeBatchelors.Checked, "Batchelors", "Masters")
                    .college_university_name = _view.txtCollegeUniversityName.Text
                    .college_year_from = _view.dtpYearFrom.Value
                    .college_year_to = _view.dtpYearTo.Value

                    'Others
                    .other_extra_curricular_participation = _view.txtExtraCurr_Others.Text
                    .other_resources_available = _view.txtResources_Others.Text
                    .other_skills_talents = _view.txtSkillsTalents_Others.Text
                    .other_sports = _view.txtSports_Others.Text

                    Try
                        'Attended University
                        For Each rows As DataRow In dt_Attended_University.Rows
                            Dim obj As New AttendedUniversity
                            With obj
                                .NameOfAttendy = rows.Item("Name of Person").ToString
                                .RelationshipAttendy = rows.Item("Relationship").ToString
                            End With
                            Attended_University.Add(obj)
                        Next
                    Catch ex As Exception
                    End Try

                    RecordModel.Attended_University = Attended_University

                    'List of Achievements Extra Curriculom
                    'Save Files from Directory
                    If ListOfAchievments.Count > 0 Then
                        For Each rows In ListOfAchievments
                            SaveFiles_Directory(rows.FullPath, rows.FilePath, rows.FileName)
                        Next
                    End If

                    RecordModel.ListOfAchievements = ListOfAchievments

                    'Delete Files from Directory
                    If ListOfAchievments_Delete.Count > 0 Then
                        If ServerPath <> "" Then
                            DeleteFiles_Directory(IO.Path.Combine(DocumentPath, _view.txtfull_name.Text))
                        Else
                            DeleteFiles_Directory(IO.Path.Combine(Directory.GetCurrentDirectory, "DOCUMENTS", _view.txtfull_name.Text))
                        End If

                    End If


                        'Attach Document
                        If ListOfAttachments.Count > 0 Then
                        For Each rows In ListOfAttachments
                            SaveFiles_Directory(rows.FullPath, rows.FilePath, rows.FileName)
                        Next
                    End If

                    RecordModel.ListOfAttachments = ListOfAttachments

                    'Delete Files from Directory ListOfAchievments_Delete
                    If ListOfAchievments_Delete.Count > 0 Then
                        If ServerPath <> "" Then
                            DeleteFiles_Directory(IO.Path.Combine(DocumentPath, _view.txtfull_name.Text))
                        Else
                            DeleteFiles_Directory(IO.Path.Combine(Directory.GetCurrentDirectory, "DOCUMENTS", _view.txtfull_name.Text))
                        End If

                    End If


                        'Other Students Non-Academic
                        '--> Title <--
                        '1-Extra Curricular Participation
                        '2-Resources Available
                        '3-Skills/Talents
                        '4-Sports
                        Dim checkbox = Me.GetAllControls(_view).OfType(Of CheckBox)().ToList()
                    For Each item As CheckBox In checkbox
                        Dim obj As New StudentNonAcademic

                        If item.Tag IsNot Nothing And item.Checked = True Then
                            With obj
                                .Title = item.Tag
                                .Non_Academic_Name = item.Text
                            End With
                            NonAcademic.Add(obj)
                        End If

                    Next

                    RecordModel.NonAcademic = NonAcademic

                    'Student ID
                    RecordModel.StudentID = _view.txtStudentID.Text

                End With


            End If
            Try
                Try
                    'Bank
                    For Each rows As DataRow In dt_bank.Rows
                        Dim obj As New EmployeeDetails.BankDetails
                        With obj
                            .BankName = rows.Item("Bank Name").ToString
                            .AccountNumber = rows.Item("Account Number").ToString
                        End With
                        BankDetails.Add(obj)
                    Next
                Catch ex As Exception
                End Try


                Try
                    'Educational Attainment
                    For Each rows As DataRow In dt_EducationalAttainment.Rows
                        Dim obj As New EmployeeDetails.EducationalAttainment
                        With obj
                            .EduDescription = rows.Item("Education Attaintment").ToString
                            .SchoolAddress = rows.Item("School Name").ToString
                            .EduFrom = rows.Item("Date From").ToString
                            .EduTo = rows.Item("Date To").ToString
                            .EduHonorsReceived = rows.Item("Honors Received").ToString
                        End With
                        EducationalAttainment.Add(obj)
                    Next
                Catch ex As Exception
                End Try

                Try
                    'Employment History
                    For Each rows As DataRow In dt_EmploymentHistory.Rows
                        Dim obj As New EmployeeDetails.EmploymentHistory
                        With obj
                            .EmplHCompanyName = rows.Item("Company Name").ToString
                            .EmplHFrom = rows.Item("Date From").ToString
                            .EmplHTo = rows.Item("Date To").ToString
                            .EmplHContactNumber = rows.Item("Contact Number").ToString
                        End With
                        EmploymentHistory.Add(obj)
                    Next
                Catch ex As Exception
                End Try

                Try
                    'Service History
                    For Each rows As DataRow In dt_ServiceHistory.Rows
                        Dim obj As New EmployeeDetails.ServiceHistory
                        With obj
                            .ServHLevel = rows.Item("Eligibility Level").ToString
                            .ServHCareer = rows.Item("Eligibility Career").ToString
                            .ServHDateExam = rows.Item("Date Examination").ToString
                            .ServHPlaceExam = rows.Item("Place of Examination").ToString
                            .ServHRatings = rows.Item("Ratings").ToString
                            .ServHLicenseNumber = rows.Item("License Number").ToString
                            .ServHDateRelease = rows.Item("Date of Release").ToString
                        End With
                        ServiceHistory.Add(obj)
                    Next
                Catch ex As Exception
                End Try

            Catch ex As Exception

            End Try

            '      SavePicture()
            RecordModel.Save(PersonDetails, Address, FamilyBackground, Dependent, Photo, EmployeeDetails, BankDetails, CharacterReference, EducationalAttainment, EmploymentHistory, ServiceHistory, OPERATION, StudentDetails)
            SavePicture()

            If OPERATION = "ADD" Then
                MsgBox("Record has been Save", MsgBoxStyle.Information, "Successfully SAVED")
            Else
                MsgBox("Record has been Updated", MsgBoxStyle.Information, "Successfully UPDATED")
            End If


            _view.btnAdd.Visible = True
            _view.btnSave.Enabled = False
            '    _view.TabControl2.Enabled = False

            _view.GroupPanel1.Enabled = False
            _view.GroupPanel3.Enabled = False
            _view.GroupPanel12.Enabled = False
            _view.GroupPanel13.Enabled = False
            _view.GroupPanel15.Enabled = False
            _view.GroupBox26.Enabled = False

            _view.TabControl5.Enabled = False
            _view.TabControl7.Enabled = False


            _view.TabControl2.SelectedTab = _view.TabItem1

            fmaEmployeeListForm.new_displayFilterCategory()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub SaveFiles_Directory(source_Path As String, new_Path As String, fileName As String)
        If IO.Directory.Exists(new_Path) Then
            If Not IO.File.Exists(IO.Path.Combine(new_Path, IO.Path.GetFileName(fileName))) Then
                'Copy file
                IO.File.Copy(source_Path, IO.Path.Combine(new_Path, IO.Path.GetFileName(fileName)))
            End If
        End If
    End Sub

    Private Sub DeleteFiles_Directory(target_folder_path As String)

        ' loop through each file in the target directory

        If _view.gcAttachAchievements.Tag = 2 Then

            Try
                For Each rows In ListOfAchievments_Delete
                    For Each file_path As String In Directory.GetFiles(target_folder_path)
                        ' delete the file if possible...otherwise skip it
                        Try
                            If rows.ToString = file_path Then
                                File.Delete(file_path)
                            End If
                        Catch ex As Exception

                        End Try
                    Next
                Next
            Catch ex As Exception

            End Try


        Else

            Try
                For Each rows In ListOfAchievments_Delete
                    For Each file_path As String In Directory.GetFiles(target_folder_path)
                        ' delete the file if possible...otherwise skip it
                        Try
                            If rows.ToString = file_path Then
                                File.Delete(file_path)
                            End If
                        Catch ex As Exception

                        End Try
                    Next
                Next
            Catch ex As Exception

            End Try

        End If




    End Sub

    Dim target_path As String
    Dim fso = My.Computer.FileSystem

    Private dtpdate_of_birth As Object

    Private Sub SavePicture()

        '        MsgBox("Save Pictue")

        If TrapPhoto Then

            If _view.txtpicturepath.Text <> "" Then

                If clsDBConn.ServerName = "localhost" Or clsDBConn.ServerName = "127.0.0.1" Then
                    'SavePicture_ServerDataBase(personID_image, FolderName, "", _photo_path, _photo_filename)
                    '            MsgBox("Localhost")
                    Try
                        'Save Picture CurrentDirectory

                        If System.IO.Directory.Exists((Current_Dir)) Then

                            _photo_path = Current_Dir & _view.txtfull_name.Text & ".jpeg" '

                            Dim _File1 As Image
                            _File1 = _view.box_picture.Image
                            _view.box_picture.Image = _File1
                            If Not File.Exists(_photo_path) Then
                                _view.box_picture.Image.Save(_photo_path)
                            Else
                                'remove existing photo
                                File.Delete(_photo_path)
                                _view.box_picture.Image.Save(_photo_path)
                            End If

                        End If

                    Catch ex As Exception

                    End Try

                    _photo_path = ""

                    'Try
                    '    '   Save Picture Remote

                    '    If Directory.Exists((Dir)) Then

                    '        _photo_path = Dir & _view.txtfull_name.Text & ".jpeg"

                    '        Dim _File As Image
                    '        _File = _view.box_picture.Image
                    '        _view.box_picture.Image = _File
                    '        If Not File.Exists(_photo_path) Then
                    '            _view.box_picture.Image.Save(_photo_path)
                    '        End If

                    '    End If

                    'Catch ex As Exception

                    'End Try

                Else

                    If SavingDir = "local.dir" Then
                        Try
                            'Save Picture CurrentDirectory
                            If System.IO.Directory.Exists((Current_Dir)) Then

                                _photo_path = Current_Dir & _view.txtfull_name.Text & ".jpeg"

                                Dim _File1 As Image
                                _File1 = _view.box_picture.Image
                                _view.box_picture.Image = _File1
                                If Not File.Exists(_photo_path) Then
                                    _view.box_picture.Image.Save(_photo_path)
                                End If

                            End If
                        Catch ex As Exception
                        End Try

                    Else

                        Try
                            If LoadedImage Then
                                target_path = Dir & "\" & _view.txtfull_name.Text & ".jpeg"
                                If Not File.Exists(target_path) Then
                                    Dim document As FileStream
                                    document = File.Create(target_path)
                                    document.Close()
                                End If

                                If source_path <> target_path Then
                                    System.IO.File.Copy(source_path, target_path.ToString, True)
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If

                End If

            End If
        End If

    End Sub

    Public Shared Function LogonUser(ByVal lpszUsername As String, ByVal lpszDomain As String,
            ByVal lpszPassword As String, ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer,
        ByRef phToken As IntPtr) As Integer
    End Function


    Public Sub ExecuteCommand(ByVal Command As String)
    Dim ProcessInfo As ProcessStartInfo
    Dim Process As Process

    '       ProcessInfo = New ProcessStartInfo("\\DESKTOP-4CAQ79Q\C:\Users\PC02\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\cmd.exe", "/K " & Command)
    ProcessInfo = New ProcessStartInfo("cmd.exe", "/K " & Command)
    ProcessInfo.CreateNoWindow = True
    ProcessInfo.UseShellExecute = True
    '     ProcessInfo.UserName = "PC02"
    '     ProcessInfo.Password = (New System.Net.NetworkCredential("", "bst2020")).SecurePassword
    Process = Process.Start(ProcessInfo)
    ' You might want to wait for the copy operation to actually finish.
    Process.WaitForExit()
    ' You might want to check the success of the operation looking at
    ' Process.ExitCode, which should be 0 when all is good (in this case).
    Process.Dispose()
End Sub

Private Sub SavePicture_ServerDataBase(personID_image As Integer, folderName As String, description As String, photo_path As String, photo_filename As String)
        SaveImage_Global(personID_image, folderName, description, _photo_path, _photo_filename)
        '    SaveImage_ServerDirectory(_photo_path, _view.box_picture.Image, folderName, _photo_filename)
    End Sub

    Private Sub SaveImage(photo_path As String)
        Try
            Using bmp As New Bitmap(_view.box_picture.Image) '_view.box_picture.Image 'Picture_Box.Image)
                bmp.Save(photo_path, Drawing.Imaging.ImageFormat.Jpeg)
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & vbCrLf &
                        ex.Message, "Error Saving Image File",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub SaveDocument(photo_path As String)
        Try
            Using bmp As New Bitmap(File_Image) '_view.box_picture.Image 'Picture_Box.Image)
                bmp.Save(photo_path, Drawing.Imaging.ImageFormat.Jpeg)
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & vbCrLf &
                        ex.Message, "Error Saving Image File",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub cmbhome_address_line2SelectionChangeCommitted(sender As Object, e As EventArgs)
        '    Try
        '        Dim drv As DataRowView = DirectCast(_view.cmbhome_address_line2.SelectedItem, DataRowView)

        '        _view.cmbhome_province.DataSource = RecordModel.getProvinceParam(drv.Item("provCode"))
        '        _view.cmbhome_province.ValueMember = "ID"
        '        _view.cmbhome_province.DisplayMember = "Name"

        '        _view.cmbhome_city.DataSource = RecordModel.getCityMunicipalityParam(drv.Item("citymunCode"), "MunicipalityCity")
        '        _view.cmbhome_city.ValueMember = "ID"
        '        _view.cmbhome_city.DisplayMember = "Name"

        '    Catch ex As Exception
        '    End Try
    End Sub

    Private Sub cmbhome_citySelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmbhome_city.SelectedItem, DataRowView)

            '_view.cmbhome_province.DataSource = RecordModel.getProvinceParam(drv.Item("provCode"))
            '_view.cmbhome_province.ValueMember = "ID"
            '_view.cmbhome_province.DisplayMember = "Name"

            _view.cmbhome_address_line2.DataSource = RecordModel.getBarangayParam(drv.Item("citymunCode"), "MunicipalityCity")
            _view.cmbhome_address_line2.ValueMember = "ID"
            _view.cmbhome_address_line2.DisplayMember = "Name"

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbhome_provinceSelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmbhome_province.SelectedItem, DataRowView)

            _view.cmbhome_city.DataSource = RecordModel.getCityMunicipalityParam(drv.Item("provCode"), "Province")
            _view.cmbhome_city.ValueMember = "ID"
            _view.cmbhome_city.DisplayMember = "Name"

            '_view.cmbhome_address_line2.DataSource = RecordModel.getBarangayParam(drv.Item("provCode"), "Province")
            '_view.cmbhome_address_line2.ValueMember = "ID"
            '_view.cmbhome_address_line2.DisplayMember = "Name"

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmboffice_provinceSelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(_view.cmboffice_province.SelectedItem, DataRowView)

            _view.cmboffice_city.DataSource = RecordModel.getCityMunicipalityParam(drv.Item("provCode"), "Province")
            _view.cmboffice_city.ValueMember = "ID"
            _view.cmboffice_city.DisplayMember = "Name"

            '_view.cmboffice_address_line2.DataSource = RecordModel.getBarangayParam(drv.Item("provCode"), "Province")
            '_view.cmboffice_address_line2.ValueMember = "ID"
            '_view.cmboffice_address_line2.DisplayMember = "Name"

        Catch ex As Exception
        End Try
    End Sub


    Public Sub loadComboBox()

        Try

            _view.cmbhome_address_line2.DataSource = Barangay ' RecordModel.getBarangay
            _view.cmbhome_address_line2.ValueMember = "ID"
            _view.cmbhome_address_line2.DisplayMember = "Name"

            _view.cmbhome_city.DataSource = MuncipalityCity 'RecordModel.getCityMunicipaltiy
            _view.cmbhome_city.ValueMember = "ID"
            _view.cmbhome_city.DisplayMember = "Name"

            _view.cmbhome_province.DataSource = Province  'RecordModel.getProvince
            _view.cmbhome_province.ValueMember = "ID"
            _view.cmbhome_province.DisplayMember = "Name"

            _view.cmboffice_province.DataSource = RecordModel.getProvince
            _view.cmboffice_province.ValueMember = "ID"
            _view.cmboffice_province.DisplayMember = "Name"

            _view.cmbblood_group.DataSource = RecordModel.getBloodType
            _view.cmbblood_group.ValueMember = "ID"
            _view.cmbblood_group.DisplayMember = "Name"

            _view.cmbnationality_id.DataSource = RecordModel.getCitizenship
            _view.cmbnationality_id.ValueMember = "ID"
            _view.cmbnationality_id.DisplayMember = "Name"

            getEmployeeCategory()
            getDepartment()
            getJobTitle()
            getPosition()
            getEmployeeGrade()
            getEducationAttainment()
            getDocumentType()
            getEntranceData()

            If OPERATION = "ADD" Then
                _view.cmbblood_group.SelectedIndex = -1
                _view.cmbnationality_id.SelectedIndex = -1
                _view.cmbhome_address_line2.SelectedIndex = -1
                _view.cmboffice_address_line2.SelectedIndex = -1
                _view.cmbhome_city.SelectedIndex = -1
                _view.cmboffice_city.SelectedIndex = -1
                _view.cmbhome_province.SelectedIndex = -1
                _view.cmboffice_province.SelectedIndex = -1
                _view.cmbemployee_category_id.SelectedIndex = -1
                _view.cmbemployee_department_id.SelectedIndex = -1
                _view.cmbjob_title.SelectedIndex = -1
                _view.cmbemployee_position_id.SelectedIndex = -1
                _view.cmbemployee_grade_id.SelectedIndex = -1

            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub getEntranceData()

        _view.cmbStudentData.DataSource = RecordModel.getEntranceData()
        _view.cmbStudentData.ValueMember = "ID"
        _view.cmbStudentData.DisplayMember = "Name"
        _view.cmbStudentData.SelectedIndex = -1

    End Sub

    Private Sub getDocumentType()
        _view.cmbDocumentType.DataSource = RecordModel.getDocumentType()
        _view.cmbDocumentType.ValueMember = "ID"
        _view.cmbDocumentType.DisplayMember = "Name"
        _view.cmbDocumentType.SelectedIndex = -1
    End Sub

    Private Sub getEducationAttainment()
        _view.cmbEducationalAttainment.DataSource = RecordModel.getEducationAttainment(AppSetup_Domain)
        _view.cmbEducationalAttainment.ValueMember = "ID"
        _view.cmbEducationalAttainment.DisplayMember = "Name"
    End Sub

    Private Sub getEmployeeGrade()
        _view.cmbemployee_grade_id.DataSource = RecordModel.getEmployeeGrade
        _view.cmbemployee_grade_id.ValueMember = "ID"
        _view.cmbemployee_grade_id.DisplayMember = "Name"

    End Sub

    Private Sub getPosition()
        _view.cmbemployee_position_id.DataSource = RecordModel.getPosition
        _view.cmbemployee_position_id.ValueMember = "ID"
        _view.cmbemployee_position_id.DisplayMember = "Name"

        _view.cmbJoinPosition.DataSource = _view.cmbemployee_position_id.DataSource
        _view.cmbJoinPosition.ValueMember = "ID"
        _view.cmbJoinPosition.DisplayMember = "Name"

    End Sub

    Private Sub getJobTitle()
        _view.cmbjob_title.DataSource = RecordModel.getJobTitle
        _view.cmbjob_title.ValueMember = "ID"
        _view.cmbjob_title.DisplayMember = "Name"
    End Sub

    Private Sub getDepartment()
        _view.cmbemployee_department_id.DataSource = RecordModel.getDepartment
        _view.cmbemployee_department_id.ValueMember = "ID"
        _view.cmbemployee_department_id.DisplayMember = "Name"
    End Sub

    Private Sub getEmployeeCategory()
        _view.cmbemployee_category_id.DataSource = RecordModel.getEmployeeCategory
        _view.cmbemployee_category_id.ValueMember = "ID"
        _view.cmbemployee_category_id.DisplayMember = "Name"
    End Sub


End Class


