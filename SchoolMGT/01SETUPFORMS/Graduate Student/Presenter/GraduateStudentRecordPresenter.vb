Imports System.Configuration
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class GraduateStudentRecordPresenter
    Private _view As frmGraduateStudent
    Dim RecordModel As New GraduateStudentRecordModel
    Public _personID As Integer
    Public _class_roll_number As String
    Dim StudentGrauate As New GraduateStudent
    Public _OR_Details As OfficialReceiptInventroy
    Dim TOR_details As New List(Of TORDetails)

    Public Incomplete As Integer
    Public graduate_student_id As Integer = 0
    Public _id As Integer


    Public Sub New(view As frmGraduateStudent)
        _view = view
        LoadComboBox()
        LoadHanlder()

        If FUNCTION_TYPE = "PRC" Then
            _view.TabControl4.Tabs.Remove(_view.TabItem1)
            _view.TabControl4.Tabs.Remove(_view.TabItem3)

        Else

            _view.TabControl4.Tabs.Remove(_view.TabItem4)

        End If


        LoadDetails()


    End Sub

    Dim BirthDate As String = ""
    Dim DateAdmiited As String = ""
    Dim DateGraduated As String = ""
    Public Sub LoadDetails()
        Dim dt As New DataTable

        If GRADUATED_STUDENT_ID = 0 Then

            OPERATION = "Add"

            dt = RecordModel.getGraduateDetails(PERSON_ID)

            If dt.Rows.Count > 0 Then
                _view.txtname.Text = If(IsDBNull(dt(0)("NAME")), "", dt(0)("NAME"))
                _view.txtStudentID.Text = If(IsDBNull(dt(0)("STUDENT NUMBER")), "", dt(0)("STUDENT NUMBER"))
                _view.dtiDateBirth.Value = If(IsDBNull(dt(0)("DATE OF BIRTH")), "", dt(0)("DATE OF BIRTH"))
                _view.dtiDateBirth.Value = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy")
                BirthDate = _view.dtiDateBirth.Value
                _view.txtPlaceBirth.Text = If(IsDBNull(dt(0)("PLACE OF BIRTH")), "", dt(0)("PLACE OF BIRTH"))
                _view.cmbgender.Text = If(IsDBNull(dt(0)("GENDER")), "", dt(0)("GENDER"))
                _view.txtReligion.Text = If(IsDBNull(dt(0)("RELIGION")), "", dt(0)("RELIGION"))
                _view.cmbCitizenship.SelectedValue = If(IsDBNull(dt(0)("nationality_id")), 76, dt(0)("nationality_id"))
                _view.txtFather.Text = If(IsDBNull(dt(0)("FATHER")), "", dt(0)("FATHER"))
                _view.txtMother.Text = If(IsDBNull(dt(0)("MOTHER")), "", dt(0)("MOTHER"))
                _view.txtAddress.Text = If(IsDBNull(dt(0)("ADDRESS")), "", dt(0)("ADDRESS"))
                Try
                    _view.dtiDateAdmetted.Value = If(IsDBNull(dt(0)("DATE ADMITTED")), "", dt(0)("DATE ADMITTED"))
                    _view.dtiDateAdmetted.Value = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy")
                    DateAdmiited = _view.dtiDateAdmetted.Value
                Catch ex As Exception

                End Try
                _view.cmbCourse.SelectedValue = If(IsDBNull(dt(0)("course_id")), "", dt(0)("course_id"))
                _view.txtEntranceData.Text = If(IsDBNull(dt(0)("ENTRANCE DATA")), "", dt(0)("ENTRANCE DATA"))
                _view.txtClassRollNumber.Text = If(IsDBNull(dt(0)("class_roll_no")), "", dt(0)("class_roll_no"))


                Dim dt1 As New DataTable
                dt1 = RecordModel.getPremilinaryEducation(_personID)

                If dt1.Rows.Count > 0 Then

                    If _view.txtPlaceBirth.Text = "" Then
                        _view.txtPlaceBirth.Text = If(IsDBNull(dt1(0)("place_birth")), "", dt1(0)("place_birth"))
                    End If
                    If _view.txtPlaceBirth.Text = "" Then
                        _view.txtPlaceBirth.Text = If(IsDBNull(dt1(0)("place_birth")), "", dt1(0)("place_birth"))
                    End If
                    If _view.txtReligion.Text = "" Then
                        _view.txtReligion.Text = If(IsDBNull(dt1(0)("religion")), "", dt1(0)("religion"))
                    End If
                    If _view.txtFather.Text = "" Then
                        _view.txtFather.Text = If(IsDBNull(dt1(0)("father")), "", dt1(0)("father"))
                    End If
                    If _view.txtMother.Text = "" Then
                        _view.txtMother.Text = If(IsDBNull(dt1(0)("mother")), "", dt1(0)("mother"))
                    End If
                    If _view.txtAddress.Text = "" Then
                        _view.txtAddress.Text = If(IsDBNull(dt1(0)("address")), "", dt1(0)("address"))
                    End If

                    _view.txtEntranceData.Text = If(IsDBNull(dt1(0)("entrance_data")), "", dt1(0)("entrance_data"))
                    _view.txtCourseMajor.Text = If(IsDBNull(dt1(0)("program_major")), "", dt1(0)("program_major"))

                    Try
                        _view.dtiDateAdmetted.Value = If(IsDBNull(dt1(0)("date_admitted")), "", dt1(0)("date_admitted"))
                        _view.dtiDateAdmetted.Value = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy")
                        DateAdmiited = _view.dtiDateAdmetted.Value
                    Catch ex As Exception
                    End Try
                    Try
                        _view.dtiDateGraduate.Value = If(IsDBNull(dt1(0)("date_graduated")), "", dt1(0)("date_graduated"))
                        _view.dtiDateGraduate.Value = Format(_view.dtiDateGraduate.Value, "MMMM dd, yyyy")
                        DateGraduated = _view.dtiDateGraduate.Value
                    Catch ex As Exception
                    End Try
                    Dim StatusGraduate As Boolean = dt1(0)("status_graduate")
                    If StatusGraduate = True Then
                        _view.chkGraduated.Checked = True
                    Else
                        _view.chkGraduated.Checked = False
                    End If
                    Dim Complete_details As Boolean = dt1(0)("complete_details")
                    If Complete_details = True Then
                        _view.chkComplete_details.Checked = True
                    Else
                        _view.chkComplete_details.Checked = False
                    End If


                    _view.txtElementary.Text = If(IsDBNull(dt1(0)("ElemGrad")), "", dt1(0)("ElemGrad"))
                    _view.txtElemSchoolYear.Text = If(IsDBNull(dt1(0)("ElemYear")), "", dt1(0)("ElemYear"))
                    _view.txtSeconday.Text = If(IsDBNull(dt1(0)("HighGrad")), "", dt1(0)("HighGrad"))
                    _view.txtSecSchoolYear.Text = If(IsDBNull(dt1(0)("HighYear")), "", dt1(0)("HighYear"))
                    _view.txtTertiary.Text = If(IsDBNull(dt1(0)("TertiaryGrad")), "", dt1(0)("TertiaryGrad"))
                    _view.txtTerSchoolYear.Text = If(IsDBNull(dt1(0)("TertiaryYear")), "", dt1(0)("TertiaryYear"))

                End If

            End If
        Else

            OPERATION = "Edit"

                dt = RecordModel.getGraduate_StudentDetails(PERSON_ID)

                If dt.Rows.Count > 0 Then

                    _view.txtname.Text = If(IsDBNull(dt(0)("NAME")), "", dt(0)("NAME"))
                    _view.txtStudentID.Text = If(IsDBNull(dt(0)("STUDENT NUMBER")), "", dt(0)("STUDENT NUMBER"))
                    _view.dtiDateBirth.Value = If(IsDBNull(dt(0)("DATE OF BIRTH")), "", dt(0)("DATE OF BIRTH"))
                    _view.dtiDateBirth.Value = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy")
                    BirthDate = _view.dtiDateBirth.Value
                    _view.txtPlaceBirth.Text = If(IsDBNull(dt(0)("PLACE OF BIRTH")), "", dt(0)("PLACE OF BIRTH"))
                    _view.cmbgender.Text = If(IsDBNull(dt(0)("GENDER")), "", dt(0)("GENDER"))
                    _view.txtReligion.Text = If(IsDBNull(dt(0)("RELIGION")), "", dt(0)("RELIGION"))
                '          _view.cmbCitizenship.SelectedValue = If(IsDBNull(dt(0)("nationality_id")), 76, dt(0)("nationality_id"))
                _view.cmbCitizenship.Text = If(IsDBNull(dt(0)("nationality_id")), "", dt(0)("nationality_id"))
                _view.txtFather.Text = If(IsDBNull(dt(0)("FATHER")), "", dt(0)("FATHER"))
                _view.txtMother.Text = If(IsDBNull(dt(0)("MOTHER")), "", dt(0)("MOTHER"))
                    _view.txtAddress.Text = If(IsDBNull(dt(0)("ADDRESS")), "", dt(0)("ADDRESS"))
                    Try
                        _view.dtiDateAdmetted.Value = If(IsDBNull(dt(0)("DATE ADMITTED")), "", dt(0)("DATE ADMITTED"))
                        _view.dtiDateAdmetted.Value = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy")
                        DateAdmiited = _view.dtiDateAdmetted.Value
                    Catch ex As Exception

                    End Try
                '      _view.cmbCourse.SelectedValue = If(IsDBNull(dt(0)("course_id")), "", dt(0)("course_id"))
                _view.cmbCourse.Text = If(IsDBNull(dt(0)("degree_program")), "", dt(0)("degree_program"))
                _view.txtEntranceData.Text = If(IsDBNull(dt(0)("ENTRANCE DATA")), "", dt(0)("ENTRANCE DATA"))
                _view.txtClassRollNumber.Text = If(IsDBNull(dt(0)("class_roll_number")), "", dt(0)("class_roll_number"))

                _view.txtCourseMajor.Text = If(IsDBNull(dt(0)("program_major")), "", dt(0)("program_major"))

                    Try
                        _view.dtiDateGraduate.Value = If(IsDBNull(dt(0)("date_graduated")), "", dt(0)("date_graduated"))
                        _view.dtiDateGraduate.Value = Format(_view.dtiDateGraduate.Value, "MMMM dd, yyyy")
                        DateGraduated = _view.dtiDateGraduate.Value
                    Catch ex As Exception
                    End Try
                    Dim StatusGraduate As Boolean = dt(0)("status_graduate")
                    If StatusGraduate = True Then
                        _view.chkGraduated.Checked = True
                    Else
                        _view.chkGraduated.Checked = False
                    End If
                    Dim Complete_details As Boolean = dt(0)("complete_details")
                    If Complete_details = True Then
                        _view.chkComplete_details.Checked = True
                    Else
                        _view.chkComplete_details.Checked = False
                    End If

                    _view.txtElementary.Text = If(IsDBNull(dt(0)("ElemGrad")), "", dt(0)("ElemGrad"))
                    _view.txtElemSchoolYear.Text = If(IsDBNull(dt(0)("ElemYear")), "", dt(0)("ElemYear"))
                    _view.txtSeconday.Text = If(IsDBNull(dt(0)("HighGrad")), "", dt(0)("HighGrad"))
                    _view.txtSecSchoolYear.Text = If(IsDBNull(dt(0)("HighYear")), "", dt(0)("HighYear"))
                    _view.txtTertiary.Text = If(IsDBNull(dt(0)("TertiaryGrad")), "", dt(0)("TertiaryGrad"))
                    _view.txtTerSchoolYear.Text = If(IsDBNull(dt(0)("TertiaryYear")), "", dt(0)("TertiaryYear"))


                End If


            End If


            Try

                If clsDBConn.ServerName = "localhost" Then

                    Dim ms As New MemoryStream
                    ms = LoadImage_Global(_personID, "GRADUATE", "", "", "")
                    _view.PictureBox1.Image = Image.FromStream(ms)
                    _view.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    _view.PictureBox1.BorderStyle = BorderStyle.Fixed3D

                Else

                    If SavingDir = "local.dir" Then
                        Dim ms As New MemoryStream
                        ms = LoadImage_Global(_personID, "GRADUATE", "", "", "")
                        _view.PictureBox1.Image = Image.FromStream(ms)
                        _view.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                        _view.PictureBox1.BorderStyle = BorderStyle.Fixed3D

                    Else
                        Dim dt_images As New DataTable
                        dt_images = RecordModel.getImagesDetails(_personID)
                        If dt_images.Rows.Count > 0 Then

                            Dim dir As String = dt_images(0)("image_path")

                            If System.IO.File.Exists(dir) Then
                                _view.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                                _view.PictureBox1.BorderStyle = BorderStyle.Fixed3D
                                _view.PictureBox1.Load(dir)
                            End If

                        End If

                    End If
                End If
            Catch ex As Exception

            End Try



    End Sub

    Private Sub LoadHanlder()
        AddHandler _view.chkGraduated.CheckedChanged, AddressOf AssignGraduate
        AddHandler _view.txtpicturepath.ButtonCustomClick, AddressOf OpeFile_Dialog
        AddHandler _view.btnSave.Click, AddressOf SaveRecord
        AddHandler _view.btnPrintTOR.Click, AddressOf PrintTOR
        AddHandler _view.txtpicturepath.ButtonCustomClick, AddressOf OpenFile


    End Sub

    Dim _photo_path As String
    Dim _photo_filename As String
    Dim SelectedImage As Boolean = False
    Private Sub OpenFile(sender As Object, e As EventArgs)

        With _view.OpenFileDialog1
            .Title = "Select an Image"  ' Path.GetFileName(.FileName)
            .InitialDirectory = "C:\"
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|All files (*.*)|*.*" '"JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
            .FilterIndex = 1

        End With
        If Windows.Forms.DialogResult.OK Then
            SelectedImage = True
            With _view.PictureBox1
                .Image = Image.FromFile(_view.OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D

            End With
        End If

        _photo_path = _view.OpenFileDialog1.FileName
        _view.txtpicturepath.Text = _view.OpenFileDialog1.FileName
        Dim names = _view.txtpicturepath.Text.Trim
        Dim phrase As String = names.Substring(names.LastIndexOf("\"c) + 1)

        _photo_filename = phrase
        _view.txtpicturepath.Text = phrase

    End Sub

    Public Sub PrintTOR_New(sender As Object, e As EventArgs, Optional ClassRollNo As Integer = Nothing, Optional TypeOfPrint As String = Nothing, Optional DateIsuued As Date = Nothing)

        Cursor.Current = Cursors.WaitCursor

        Dim StudentName As String = ""
        Dim CourseName As String = ""
        Dim SchoolName As String = ""
        Dim AcademicYear As String = ""

        If ClassRollNo <> Nothing Then
            _view.txtClassRollNumber.Text = ClassRollNo
        End If


        If TypeOfPrint = "View Only" Then

            Dim master_report As New XtraReport_TOR_Main

            Dim page As Integer = 1

            While page <= 2

                If page = 1 Then

                    Dim report(page) As XtraReport_TOR_Main
                    report(page) = New XtraReport_TOR_Main

                    report(page).XrLName.Text = _view.txtname.Text
                    report(page).XrLIDnumber.Text = _view.txtStudentID.Text
                    report(page).XrLBirthDate.Text = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy").ToUpper   'BirthDate '_view.dtiDateBirth.Value
                    report(page).XrLBirthPlace.Text = _view.txtPlaceBirth.Text
                    report(page).XrLGender.Text = _view.cmbgender.Text
                    report(page).XrLReligion.Text = _view.txtReligion.Text
                    report(page).XrLCitizenship.Text = _view.cmbCitizenship.Text.ToUpper
                    report(page).XrLFather.Text = _view.txtFather.Text
                    report(page).XrLMother.Text = _view.txtMother.Text
                    report(page).XrLAddress.Text = _view.txtAddress.Text
                    report(page).XrLDateAdmitted.Text = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy").ToUpper  'DateAdmiited '_view.dtiDateAdmetted.Value
                    report(page).XrLEntranceData.Text = _view.txtEntranceData.Text.ToUpper
                    report(page).XrLDegreeProgram.Text = _view.cmbCourse.Text.ToUpper
                    report(page).XrLElementary.Text = _view.txtElementary.Text
                    report(page).XrLElemYear.Text = _view.txtElemSchoolYear.Text
                    report(page).XrLSecondary.Text = _view.txtSeconday.Text
                    report(page).XrLSecYear.Text = _view.txtSecSchoolYear.Text
                    report(page).XrLTertiary.Text = _view.txtTertiary.Text
                    report(page).XrLTerYear.Text = _view.txtTerSchoolYear.Text

                    Try
                        'Graduate Image
                        Dim ms As New MemoryStream
                        ms = LoadImage_Global(PERSON_ID, "GRADUATE", "", "", "")
                        report(page).XrPictureBox3.Image = Image.FromStream(ms)
                        report(page).XrPictureBox3.Sizing = PictureBoxSizeMode.StretchImage

                    Catch ex As Exception

                    End Try

                    report(page).xrORNo.Text = ""
                    report(page).xrRemarks.Text = ""
                    report(page).xrDateIssued.Text = ""

                    report(page).PrintingSystem.ShowMarginsWarning = False  'or alternatively: Report.ShowPrintStatusDialog = False
                    report(page).RequestParameters = False

                    report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report(page).CreateDocument()
                    master_report.Pages.AddRange(report(page).Pages)
                    master_report.PrintingSystem.ContinuousPageNumbering = True

                Else


                    Dim report(page) As XtraReport_TOR_Details
                    report(page) = New XtraReport_TOR_Details

                    Dim dt As New DataTable
                    dt = RecordModel.getTORDetails(_view.txtClassRollNumber.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row In dt.Rows
                            Dim obj As New TORDetails
                            With obj
                                .personID = _personID
                                .class_roll_number = _view.txtClassRollNumber.Text
                                .last_name = If(IsDBNull(row("last_name")), "", row("last_name"))
                                .first_name = If(IsDBNull(row("first_name")), "", row("first_name"))
                                .middle_name = If(IsDBNull(row("middle_name")), "", row("middle_name"))
                                .school_address_province = If(IsDBNull(row("SchollAddress")), "", row("SchollAddress"))
                                .yearlevel_semister_academicyear = If(IsDBNull(row("SemesterYear")), "", row("SemesterYear"))
                                .subjectID = row("ssID")
                                .subject_code = row("subjcode")
                                .subject_description = row("subjname")
                                .final_grade = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                                .re_exam = If(IsDBNull(row("re_exam")), "", row("re_exam"))
                                .credits = row("credit_hours")
                                .batch_id = row("BatchID")
                            End With
                            TOR_details.Add(obj)

                        Next

                    End If
                    report(page).xrORNo.Text = ""
                    report(page).xrRemarks.Text = ""
                    report(page).xrDateIssued.Text = ""

                    report(page).DataSource = TOR_details

                    report(page).PrintingSystem.ShowMarginsWarning = False  'or alternatively: Report.ShowPrintStatusDialog = False
                    report(page).RequestParameters = False

                    report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report(page).CreateDocument()
                    master_report.Pages.AddRange(report(page).Pages)
                    master_report.PrintingSystem.ContinuousPageNumbering = True

                    TOR_details.Clear()

                End If

                page += 1
            End While

            Dim tool As ReportPrintTool = New ReportPrintTool(master_report)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Save, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx, DevExpress.XtraPrinting.CommandVisibility.None)

            tool.ShowPreview()

        Else


            Dim master_report As New XtraReport_TOR_Main

            Dim _OR As New DataTable
            _OR = RecordModel.getORDetails(_view.txtClassRollNumber.Text, Format(DateIsuued.Date, "yyyy-MM-dd"))

            Dim page As Integer = 1

            While page <= 3

                If page = 1 Then

                    Dim stdnt_details As New DataTable
                    stdnt_details = getStdntDetails(_view.txtClassRollNumber.Text)
                    If stdnt_details.Rows.Count > 0 Then

                        StudentName = stdnt_details(0)("display_name")
                        CourseName = stdnt_details(0)("course")
                        AcademicYear = stdnt_details(0)("academice_year")
                        SchoolName = COMPANY_NAME.ToLower

                    End If

                    Dim report(page) As XtraReport_TOR_SLIP
                    report(page) = New XtraReport_TOR_SLIP With {._studentname = StudentName, ._course = CourseName, ._schoolname = SchoolName, ._academicyear = AcademicYear}

                    report(page).xrDateTransaction.Text = Format(CDate(_OR(0)("transaction_date")).Date, "MMMM dd,yyyy") 'Format(DateIssued.Date, "MMMM dd, yyyy")
                    report(page).XrLabel10.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMMM dd,yyyy")
                    report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no"))
                    report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description"))
                    report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper

                    report(page).xrlblschoolname.Text = COMPANY_NAME
                    report(page).xrlbladdress.Text = COMPANY_ADDRESS

                    report(page).PrintingSystem.ShowMarginsWarning = False  'or alternatively: Report.ShowPrintStatusDialog = False
                    report(page).RequestParameters = False

                    report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report(page).CreateDocument()
                    master_report.Pages.AddRange(report(page).Pages)
                    master_report.PrintingSystem.ContinuousPageNumbering = True

                ElseIf page = 2 Then

                    Dim report(page) As XtraReport_TOR_Main
                    report(page) = New XtraReport_TOR_Main

                    report(page).XrLName.Text = _view.txtname.Text
                    report(page).XrLIDnumber.Text = _view.txtStudentID.Text
                    report(page).XrLBirthDate.Text = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy").ToUpper   'BirthDate '_view.dtiDateBirth.Value
                    report(page).XrLBirthPlace.Text = _view.txtPlaceBirth.Text
                    report(page).XrLGender.Text = _view.cmbgender.Text
                    report(page).XrLReligion.Text = _view.txtReligion.Text
                    report(page).XrLCitizenship.Text = _view.cmbCitizenship.Text.ToUpper
                    report(page).XrLFather.Text = _view.txtFather.Text
                    report(page).XrLMother.Text = _view.txtMother.Text
                    report(page).XrLAddress.Text = _view.txtAddress.Text
                    report(page).XrLDateAdmitted.Text = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy").ToUpper  'DateAdmiited '_view.dtiDateAdmetted.Value
                    report(page).XrLEntranceData.Text = _view.txtEntranceData.Text.ToUpper
                    report(page).XrLDegreeProgram.Text = _view.cmbCourse.Text.ToUpper
                    report(page).XrLElementary.Text = _view.txtElementary.Text
                    report(page).XrLElemYear.Text = _view.txtElemSchoolYear.Text
                    report(page).XrLSecondary.Text = _view.txtSeconday.Text
                    report(page).XrLSecYear.Text = _view.txtSecSchoolYear.Text
                    report(page).XrLTertiary.Text = _view.txtTertiary.Text
                    report(page).XrLTerYear.Text = _view.txtTerSchoolYear.Text

                    Try
                        'Graduate Image
                        Dim ms As New MemoryStream
                        ms = LoadImage_Global(PERSON_ID, "GRADUATE", "", "", "")
                        report(page).XrPictureBox3.Image = Image.FromStream(ms)
                        report(page).XrPictureBox3.Sizing = PictureBoxSizeMode.StretchImage

                    Catch ex As Exception
                    End Try

                    If _OR.Rows.Count > 0 Then
                        report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no"))
                        report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description"))
                        report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper
                    End If

                    report(page).PrintingSystem.ShowMarginsWarning = False  'or alternatively: Report.ShowPrintStatusDialog = False
                    report(page).RequestParameters = False

                    report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report(page).CreateDocument()
                    master_report.Pages.AddRange(report(page).Pages)
                    master_report.PrintingSystem.ContinuousPageNumbering = True


                Else


                    Dim report(page) As XtraReport_TOR_Details
                    report(page) = New XtraReport_TOR_Details

                    Dim dt As New DataTable
                    dt = RecordModel.getTORDetails(_view.txtClassRollNumber.Text)
                    If dt.Rows.Count > 0 Then
                        For Each row In dt.Rows
                            Dim obj As New TORDetails
                            With obj
                                .personID = _personID
                                .class_roll_number = _view.txtClassRollNumber.Text
                                .last_name = If(IsDBNull(row("last_name")), "", row("last_name"))
                                .first_name = If(IsDBNull(row("first_name")), "", row("first_name"))
                                .middle_name = If(IsDBNull(row("middle_name")), "", row("middle_name"))
                                .school_address_province = If(IsDBNull(row("SchollAddress")), "", row("SchollAddress"))
                                .yearlevel_semister_academicyear = If(IsDBNull(row("SemesterYear")), "", row("SemesterYear"))
                                .subjectID = row("ssID")
                                .subject_code = row("subjcode")
                                .subject_description = row("subjname")
                                .final_grade = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                                .re_exam = If(IsDBNull(row("re_exam")), "", row("re_exam"))
                                .credits = row("credit_hours")
                                .batch_id = row("BatchID")
                            End With
                            TOR_details.Add(obj)

                        Next

                    End If
                    If _OR.Rows.Count > 0 Then
                        report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no")) '_OR(0)("receipt_no")
                        report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description")) '_OR(0)("description")
                        report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper
                    End If

                    report(page).DataSource = TOR_details

                    report(page).PrintingSystem.ShowMarginsWarning = False  'or alternatively: Report.ShowPrintStatusDialog = False
                    report(page).RequestParameters = False

                    report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                    report(page).CreateDocument()
                    master_report.Pages.AddRange(report(page).Pages)
                    master_report.PrintingSystem.ContinuousPageNumbering = True

                    TOR_details.Clear()

                End If

                page += 1

            End While

            master_report.ShowPreview

        End If
        Cursor.Current = Cursors.Default
    End Sub

    Public Sub PrintTOR(sender As Object, e As EventArgs, Optional ClassRollNo As Integer = Nothing, Optional TypeOfPrint As String = Nothing, Optional DateIsuued As Date = Nothing)

        Cursor.Current = Cursors.WaitCursor

        Dim StudentName As String = ""
        Dim CourseName As String = ""
        Dim SchoolName As String = ""
        Dim AcademicYear As String = ""

        If ClassRollNo <> Nothing Then
            _view.txtClassRollNumber.Text = ClassRollNo
        End If

        If TypeOfPrint <> "View Only" Then
            Try

                Dim master_report As New XtraReport_TOR_Main

                Dim _OR As New DataTable
                _OR = RecordModel.getORDetails(_view.txtClassRollNumber.Text, Format(DateIsuued.Date, "yyyy-MM-dd"))

                Dim page As Integer = 1
                While page < 4

                    If page < 2 Then

                        Dim stdnt_details As New DataTable
                        stdnt_details = getStdntDetails(_view.txtClassRollNumber.Text)
                        If stdnt_details.Rows.Count > 0 Then

                            StudentName = stdnt_details(0)("display_name")
                            CourseName = stdnt_details(0)("course")
                            AcademicYear = stdnt_details(0)("academice_year")
                            SchoolName = COMPANY_NAME.ToLower

                        End If

                        Dim report(page) As XtraReport_TOR_SLIP
                        report(page) = New XtraReport_TOR_SLIP With {._studentname = StudentName, ._course = CourseName, ._schoolname = SchoolName, ._academicyear = AcademicYear}

                        report(page).xrDateTransaction.Text = Format(CDate(_OR(0)("transaction_date")).Date, "MMMM dd,yyyy") 'Format(DateIssued.Date, "MMMM dd, yyyy")
                        report(page).XrLabel10.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMMM dd,yyyy")
                        report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no"))
                        report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description"))
                        report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper

                        report(page).xrlblschoolname.Text = COMPANY_NAME
                        report(page).xrlbladdress.Text = COMPANY_ADDRESS

                        report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                        report(page).CreateDocument()
                        master_report.Pages.AddRange(report(page).Pages)
                        master_report.PrintingSystem.ContinuousPageNumbering = True


                    ElseIf page = 2 Then

                        Dim report(page) As XtraReport_TOR_Main
                        report(page) = New XtraReport_TOR_Main

                        '--------------------------> TOR MAIN
                        Try
                            '             Dim reportMain As New XtraReport_TOR_Main

                            'If Not File.Exists(COMPANY_HEADER_PATH) Then
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                            'Else
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                            'End If
                            If ClassRollNo = Nothing Then

                                report(page).XrLName.Text = _view.txtname.Text
                                report(page).XrLIDnumber.Text = _view.txtStudentID.Text
                                report(page).XrLBirthDate.Text = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy").ToUpper   'BirthDate '_view.dtiDateBirth.Value
                                report(page).XrLBirthPlace.Text = _view.txtPlaceBirth.Text
                                report(page).XrLGender.Text = _view.cmbgender.Text
                                report(page).XrLReligion.Text = _view.txtReligion.Text
                                report(page).XrLCitizenship.Text = _view.cmbCitizenship.Text.ToUpper
                                report(page).XrLFather.Text = _view.txtFather.Text
                                report(page).XrLMother.Text = _view.txtMother.Text
                                report(page).XrLAddress.Text = _view.txtAddress.Text
                                report(page).XrLDateAdmitted.Text = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy").ToUpper  'DateAdmiited '_view.dtiDateAdmetted.Value
                                report(page).XrLEntranceData.Text = _view.txtEntranceData.Text.ToUpper
                                report(page).XrLDegreeProgram.Text = _view.cmbCourse.Text.ToUpper
                                report(page).XrLElementary.Text = _view.txtElementary.Text
                                report(page).XrLElemYear.Text = _view.txtElemSchoolYear.Text
                                report(page).XrLSecondary.Text = _view.txtSeconday.Text
                                report(page).XrLSecYear.Text = _view.txtSecSchoolYear.Text
                                report(page).XrLTertiary.Text = _view.txtTertiary.Text
                                report(page).XrLTerYear.Text = _view.txtTerSchoolYear.Text

                            Else

                                Dim dt_completeDetails As New DataTable
                                dt_completeDetails = getCompleteDetails(_view.txtClassRollNumber.Text)
                                If dt_completeDetails.Rows.Count > 0 Then

                                    report(page).XrLName.Text = dt_completeDetails(0)("student_name").ToString
                                    report(page).XrLIDnumber.Text = dt_completeDetails(0)("student_IDNumber").ToString
                                    report(page).XrLBirthDate.Text = If(IsDBNull(dt_completeDetails(0)("date_birth")), "", Format(CDate(dt_completeDetails(0)("date_birth")).Date, "MMMM dd, yyyyy"))
                                    report(page).XrLBirthPlace.Text = If(IsDBNull(dt_completeDetails(0)("place_birth")), "", dt_completeDetails(0)("place_birth"))
                                    report(page).XrLGender.Text = If(IsDBNull(dt_completeDetails(0)("gender")), "", dt_completeDetails(0)("gender"))
                                    report(page).XrLReligion.Text = If(IsDBNull(dt_completeDetails(0)("religion")), "", dt_completeDetails(0)("religion"))
                                    report(page).XrLCitizenship.Text = If(IsDBNull(dt_completeDetails(0)("citizenship")), "", dt_completeDetails(0)("citizenship").ToString.ToUpper)
                                    report(page).XrLFather.Text = If(IsDBNull(dt_completeDetails(0)("father")), "", dt_completeDetails(0)("father"))
                                    report(page).XrLMother.Text = If(IsDBNull(dt_completeDetails(0)("mother")), "", dt_completeDetails(0)("mother"))
                                    report(page).XrLAddress.Text = If(IsDBNull(dt_completeDetails(0)("address")), "", dt_completeDetails(0)("address"))
                                    report(page).XrLDateAdmitted.Text = If(IsDBNull(dt_completeDetails(0)("date_admitted")), "", Format(CDate(dt_completeDetails(0)("date_admitted")).Date, "MMMM dd, yyyyy"))
                                    report(page).XrLEntranceData.Text = If(IsDBNull(dt_completeDetails(0)("entrance_data")), "", dt_completeDetails(0)("entrance_data").ToString.ToUpper)
                                    report(page).XrLDegreeProgram.Text = If(IsDBNull(dt_completeDetails(0)("degree_program")), "", dt_completeDetails(0)("degree_program"))
                                    report(page).XrLElementary.Text = If(IsDBNull(dt_completeDetails(0)("elementary_graduated")), "", dt_completeDetails(0)("elementary_graduated"))
                                    report(page).XrLElemYear.Text = If(IsDBNull(dt_completeDetails(0)("elementary_schoolyear")), "", dt_completeDetails(0)("elementary_schoolyear"))
                                    report(page).XrLSecondary.Text = If(IsDBNull(dt_completeDetails(0)("highschool_graduated")), "", dt_completeDetails(0)("highschool_graduated"))
                                    report(page).XrLSecYear.Text = If(IsDBNull(dt_completeDetails(0)("highschool_schoolyear")), "", dt_completeDetails(0)("highschool_schoolyear"))
                                    report(page).XrLTertiary.Text = If(IsDBNull(dt_completeDetails(0)("tertiary_graduated")), "", dt_completeDetails(0)("tertiary_graduated"))
                                    report(page).XrLTerYear.Text = If(IsDBNull(dt_completeDetails(0)("tertiary_schoolyear")), "", dt_completeDetails(0)("tertiary_schoolyear"))

                                End If

                            End If
                            Try
                                'Graduate Image
                                Dim ms As New MemoryStream
                                ms = LoadImage_Global(PERSON_ID, "GRADUATE", "", "", "")
                                report(page).XrPictureBox3.Image = Image.FromStream(ms)
                                report(page).XrPictureBox3.Sizing = PictureBoxSizeMode.StretchImage

                            Catch ex As Exception

                            End Try

                            If _OR.Rows.Count > 0 Then
                                report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no"))
                                report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description"))
                                report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper
                            End If
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            '         report(page).ShowPreview

                            master_report.Pages.AddRange(report(page).Pages)
                            master_report.PrintingSystem.ContinuousPageNumbering = True

                        Catch ex As Exception

                        End Try


                    Else

                        Dim report(page) As XtraReport_TOR_Details
                        report(page) = New XtraReport_TOR_Details

                        '--------------------------> TOR DETAILS
                        Try

                            '        Dim reportDetail As New XtraReport_TOR_Details

                            Dim dt As New DataTable
                            dt = RecordModel.getTORDetails(_view.txtClassRollNumber.Text)
                            If dt.Rows.Count > 0 Then
                                For Each row In dt.Rows
                                    Dim obj As New TORDetails
                                    With obj
                                        .personID = _personID
                                        .class_roll_number = _view.txtClassRollNumber.Text
                                        .last_name = If(IsDBNull(row("last_name")), "", row("last_name"))
                                        .first_name = If(IsDBNull(row("first_name")), "", row("first_name"))
                                        .middle_name = If(IsDBNull(row("middle_name")), "", row("middle_name"))
                                        .school_address_province = If(IsDBNull(row("SchollAddress")), "", row("SchollAddress"))
                                        .yearlevel_semister_academicyear = If(IsDBNull(row("SemesterYear")), "", row("SemesterYear"))
                                        .subjectID = row("ssID")
                                        .subject_code = row("subjcode")
                                        .subject_description = row("subjname")
                                        .final_grade = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                                        .re_exam = If(IsDBNull(row("re_exam")), "", row("re_exam"))
                                        .credits = row("credit_hours")
                                        .batch_id = row("BatchID")
                                    End With
                                    TOR_details.Add(obj)


                                Next


                            End If


                            'If Not File.Exists(COMPANY_HEADER_PATH) Then
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                            'Else
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                            'End If


                            If _OR.Rows.Count > 0 Then
                                report(page).xrORNo.Text = If(IsDBNull(_OR(0)("receipt_no")), "", _OR(0)("receipt_no")) '_OR(0)("receipt_no")
                                report(page).xrRemarks.Text = If(IsDBNull(_OR(0)("description")), "", _OR(0)("description")) '_OR(0)("description")
                                report(page).xrDateIssued.Text = Format(CDate(_OR(0)("issued_date")).Date, "MMM dd,yyyy").ToUpper
                            End If

                            report(page).DataSource = TOR_details
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            '       report(page).ShowPreview
                            master_report.Pages.AddRange(report(page).Pages)
                            master_report.PrintingSystem.ContinuousPageNumbering = True


                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If

                    page += 1

                End While

                master_report.ShowPreview
            Catch ex As Exception

            End Try


        Else

            Dim master_report As New XtraReport_TOR_Main

            Try
                Dim page As Integer = 1
                While page < 3

                    If page < 2 Then

                        Dim report(page) As XtraReport_TOR_Main
                        report(page) = New XtraReport_TOR_Main

                        '--------------------------> TOR MAIN
                        Try
                            '             Dim reportMain As New XtraReport_TOR_Main

                            'If Not File.Exists(COMPANY_HEADER_PATH) Then
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                            'Else
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                            'End If
                            If ClassRollNo = Nothing Then

                                report(page).XrLName.Text = _view.txtname.Text
                                report(page).XrLIDnumber.Text = _view.txtStudentID.Text
                                report(page).XrLBirthDate.Text = Format(_view.dtiDateBirth.Value, "MMMM dd, yyyy").ToUpper   'BirthDate '_view.dtiDateBirth.Value
                                report(page).XrLBirthPlace.Text = _view.txtPlaceBirth.Text
                                report(page).XrLGender.Text = _view.cmbgender.Text
                                report(page).XrLReligion.Text = _view.txtReligion.Text
                                report(page).XrLCitizenship.Text = _view.cmbCitizenship.Text.ToUpper
                                report(page).XrLFather.Text = _view.txtFather.Text
                                report(page).XrLMother.Text = _view.txtMother.Text
                                report(page).XrLAddress.Text = _view.txtAddress.Text
                                report(page).XrLDateAdmitted.Text = Format(_view.dtiDateAdmetted.Value, "MMMM dd, yyyy").ToUpper  'DateAdmiited '_view.dtiDateAdmetted.Value
                                report(page).XrLEntranceData.Text = _view.txtEntranceData.Text.ToUpper
                                report(page).XrLDegreeProgram.Text = _view.cmbCourse.Text.ToUpper
                                report(page).XrLElementary.Text = _view.txtElementary.Text
                                report(page).XrLElemYear.Text = _view.txtElemSchoolYear.Text
                                report(page).XrLSecondary.Text = _view.txtSeconday.Text
                                report(page).XrLSecYear.Text = _view.txtSecSchoolYear.Text
                                report(page).XrLTertiary.Text = _view.txtTertiary.Text
                                report(page).XrLTerYear.Text = _view.txtTerSchoolYear.Text

                            Else

                                Dim dt_completeDetails As New DataTable
                                dt_completeDetails = getCompleteDetails(_view.txtClassRollNumber.Text)
                                If dt_completeDetails.Rows.Count > 0 Then

                                    report(page).XrLName.Text = dt_completeDetails(0)("student_name").ToString
                                    report(page).XrLIDnumber.Text = dt_completeDetails(0)("student_IDNumber").ToString
                                    report(page).XrLBirthDate.Text = If(IsDBNull(dt_completeDetails(0)("date_birth")), "", Format(CDate(dt_completeDetails(0)("date_birth")).Date, "MMMM dd, yyyyy"))
                                    report(page).XrLBirthPlace.Text = If(IsDBNull(dt_completeDetails(0)("place_birth")), "", dt_completeDetails(0)("place_birth"))
                                    report(page).XrLGender.Text = If(IsDBNull(dt_completeDetails(0)("gender")), "", dt_completeDetails(0)("gender"))
                                    report(page).XrLReligion.Text = If(IsDBNull(dt_completeDetails(0)("religion")), "", dt_completeDetails(0)("religion"))
                                    report(page).XrLCitizenship.Text = If(IsDBNull(dt_completeDetails(0)("citizenship")), "", dt_completeDetails(0)("citizenship").ToString.ToUpper)
                                    report(page).XrLFather.Text = If(IsDBNull(dt_completeDetails(0)("father")), "", dt_completeDetails(0)("father"))
                                    report(page).XrLMother.Text = If(IsDBNull(dt_completeDetails(0)("mother")), "", dt_completeDetails(0)("mother"))
                                    report(page).XrLAddress.Text = If(IsDBNull(dt_completeDetails(0)("address")), "", dt_completeDetails(0)("address"))
                                    report(page).XrLDateAdmitted.Text = If(IsDBNull(dt_completeDetails(0)("date_admitted")), "", Format(CDate(dt_completeDetails(0)("date_admitted")).Date, "MMMM dd, yyyyy"))
                                    report(page).XrLEntranceData.Text = If(IsDBNull(dt_completeDetails(0)("entrance_data")), "", dt_completeDetails(0)("entrance_data").ToString.ToUpper)
                                    report(page).XrLDegreeProgram.Text = If(IsDBNull(dt_completeDetails(0)("degree_program")), "", dt_completeDetails(0)("degree_program"))
                                    report(page).XrLElementary.Text = If(IsDBNull(dt_completeDetails(0)("elementary_graduated")), "", dt_completeDetails(0)("elementary_graduated"))
                                    report(page).XrLElemYear.Text = If(IsDBNull(dt_completeDetails(0)("elementary_schoolyear")), "", dt_completeDetails(0)("elementary_schoolyear"))
                                    report(page).XrLSecondary.Text = If(IsDBNull(dt_completeDetails(0)("highschool_graduated")), "", dt_completeDetails(0)("highschool_graduated"))
                                    report(page).XrLSecYear.Text = If(IsDBNull(dt_completeDetails(0)("highschool_schoolyear")), "", dt_completeDetails(0)("highschool_schoolyear"))
                                    report(page).XrLTertiary.Text = If(IsDBNull(dt_completeDetails(0)("tertiary_graduated")), "", dt_completeDetails(0)("tertiary_graduated"))
                                    report(page).XrLTerYear.Text = If(IsDBNull(dt_completeDetails(0)("tertiary_schoolyear")), "", dt_completeDetails(0)("tertiary_schoolyear"))

                                End If

                            End If
                            Try
                                'Graduate Image
                                Dim ms As New MemoryStream
                                ms = LoadImage_Global(PERSON_ID, "GRADUATE", "", "", "")
                                report(page).XrPictureBox3.Image = Image.FromStream(ms)
                                report(page).XrPictureBox3.Sizing = PictureBoxSizeMode.StretchImage

                            Catch ex As Exception

                            End Try

                            '   If _OR.Rows.Count > 0 Then
                            report(page).xrORNo.Text = ""
                            report(page).xrRemarks.Text = ""
                            report(page).xrDateIssued.Text = ""
                            '   End If
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            '         report(page).ShowPreview

                            master_report.Pages.AddRange(report(page).Pages)
                            master_report.PrintingSystem.ContinuousPageNumbering = True

                        Catch ex As Exception

                        End Try


                    Else

                        Dim report(page) As XtraReport_TOR_Details
                        report(page) = New XtraReport_TOR_Details

                        '--------------------------> TOR DETAILS
                        Try

                            '        Dim reportDetail As New XtraReport_TOR_Details

                            Dim dt As New DataTable
                            dt = RecordModel.getTORDetails(_view.txtClassRollNumber.Text)
                            If dt.Rows.Count > 0 Then
                                For Each row In dt.Rows
                                    Dim obj As New TORDetails
                                    With obj
                                        .personID = _personID
                                        .class_roll_number = _view.txtClassRollNumber.Text
                                        .last_name = If(IsDBNull(row("last_name")), "", row("last_name"))
                                        .first_name = If(IsDBNull(row("first_name")), "", row("first_name"))
                                        .middle_name = If(IsDBNull(row("middle_name")), "", row("middle_name"))
                                        .school_address_province = If(IsDBNull(row("SchollAddress")), "", row("SchollAddress"))
                                        .yearlevel_semister_academicyear = If(IsDBNull(row("SemesterYear")), "", row("SemesterYear"))
                                        .subjectID = row("ssID")
                                        .subject_code = row("subjcode")
                                        .subject_description = row("subjname")
                                        .final_grade = If(IsDBNull(row("finalgrade")), "", row("finalgrade"))
                                        .re_exam = If(IsDBNull(row("re_exam")), "", row("re_exam"))
                                        .credits = row("credit_hours")
                                        .batch_id = row("BatchID")
                                    End With
                                    TOR_details.Add(obj)
                                Next


                            End If


                            'If Not File.Exists(COMPANY_HEADER_PATH) Then
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(DefaultHeaderPic))
                            'Else
                            '    report(page).XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_HEADER_PATH))
                            'End If


                            '   If _OR.Rows.Count > 0 Then
                            report(page).xrORNo.Text = "" '_OR(0)("receipt_no")
                            report(page).xrRemarks.Text = "" '_OR(0)("description")
                            report(page).xrDateIssued.Text = ""
                            '     End If

                            report(page).DataSource = TOR_details
                            report(page).PrintingSystem.Document.AutoFitToPagesWidth = 1
                            report(page).CreateDocument()
                            '       report(page).ShowPreview
                            master_report.Pages.AddRange(report(page).Pages)
                            master_report.PrintingSystem.ContinuousPageNumbering = True

                            TOR_details.Clear()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If

                    page += 1

                End While


            Catch ex As Exception

            End Try


            '   master_report.ShowPreview
            Dim tool As ReportPrintTool = New ReportPrintTool(master_report)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Save, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None)
            tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx, DevExpress.XtraPrinting.CommandVisibility.None)

            tool.ShowPreview()

        End If
        Cursor.Current = Cursors.Default


    End Sub

    Private Function getStdntDetails(Class_roll_no As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT
  students.id,
	students.class_roll_no, 
	person.display_name, 
	CONCAT(courses.description,' (',courses.`code`,')')'course',
	students.academice_year
FROM
	students
	INNER JOIN
	person
	ON 
		students.person_id = person.person_id
	INNER JOIN
	courses
	ON 
		students.course_id = courses.id
WHERE
	students.class_roll_no = '" & Class_roll_no & "'
	ORDER BY id DESC
	LIMIT 1"
        Return DataSource(sql)
    End Function

    Private Function getCompleteDetails(ClossRollNo As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	                    graduate_student.class_roll_number, 
	                    graduate_student.student_name, 
	                    graduate_student.student_IDNumber, 
	                    graduate_student.date_birth, 
	                    graduate_student.place_birth, 
	                    graduate_student.gender, 
	                    graduate_student.religion, 
	                    graduate_student.citizenship, 
	                    graduate_student.father, 
	                    graduate_student.mother, 
	                    graduate_student.address, 
	                    graduate_student.date_admitted, 
	                    graduate_student.entrance_data, 
	                    graduate_student.elementary_graduated, 
	                    graduate_student.elementary_schoolyear, 
	                    graduate_student.highschool_graduated, 
	                    graduate_student.highschool_schoolyear, 
	                    graduate_student.tertiary_graduated, 
	                    graduate_student.tertiary_schoolyear, 
	                    graduate_student.degree_program, 
	                    graduate_student.date_graduated, 
	                    graduate_student.authority_number, 
	                    graduate_student.authority_year_granted, 
	                    graduate_student.status_graduate
                    FROM
	                    graduate_student
                    WHERE
	                    graduate_student.class_roll_number = " & ClossRollNo & ""))
        Return dt
    End Function

    Private Sub SaveRecord(sender As Object, e As EventArgs)

        If _view.dtiDateBirth.Value = Nothing Then
            MsgBox("Required Fields... Birth Date  ")
        End If

        If _view.dtiDateAdmetted.Value = Nothing Then
            MsgBox("Required Files..  Date Admitted")
        End If

        Try

            RecordModel.OR_Details = _OR_Details

            With StudentGrauate
                .person_id = PERSON_ID  '_personID
                .class_roll_number = _view.txtClassRollNumber.Text   '_class_roll_number
                .student_name = _view.txtname.Text
                .student_ID = _view.txtStudentID.Text
                .date_birth = _view.dtiDateBirth.Value
                .place_birth = _view.txtPlaceBirth.Text
                .gender = _view.cmbgender.Text.ToUpper
                .religion = _view.txtReligion.Text
                .citizenship = _view.cmbCitizenship.Text.ToUpper
                .father = _view.txtFather.Text
                .mother = _view.txtMother.Text
                .address = _view.txtAddress.Text
                .date_admitted = _view.dtiDateAdmetted.Value
                .entrance_data = _view.txtEntranceData.Text
                .date_graduated = _view.dtiDateGraduate.Value
                .degree_program = _view.cmbCourse.Text
                .program_major = _view.txtCourseMajor.Text

                .authority_number = _view.txtAuthorityNumber.Text
                .authority_year_granted = _view.txtYearGranted.Text

                .elementary_graduated = _view.txtElementary.Text
                .elementary_schoolyear = _view.txtElemSchoolYear.Text
                .highschool_graduated = _view.txtSeconday.Text
                .highschool_schoolyear = _view.txtSecSchoolYear.Text
                .tertiary_graduated = _view.txtTertiary.Text
                .tertiary_schoolyear = _view.txtTerSchoolYear.Text
                .status_graduate = If(_view.chkGraduated.Checked = True, 1, 0)
                .complete_details = If(_view.chkComplete_details.Checked = True, 1, 0)

            End With



            RecordModel.graduate_student_id = GRADUATED_STUDENT_ID
            RecordModel.Insert(StudentGrauate)


            If SelectedImage = True Then

                If clsDBConn.ServerName = "localhost" Then

                    'Save Picture CurrentDirectory
                    Dim dir As String = Directory.GetCurrentDirectory & "\PIC\GRADUATE"

                    If (Not System.IO.Directory.Exists(Path.Combine(dir, "GRADUATE"))) Then
                        System.IO.Directory.CreateDirectory(Path.Combine(dir, "GRADUATE"))
                    End If

                    _photo_path = dir & _photo_filename

                    Dim _Image As Image
                    _Image = _view.PictureBox1.Image
                    _view.PictureBox1.Image = _Image
                    If Not File.Exists(_photo_path) Then
                        _view.PictureBox1.Image.Save(_photo_path)
                    End If

                    SaveImage_Global(_personID, "GRADUATE", "Graduated Image", _photo_path, _photo_filename)


                Else

                    If SavingDir = "local.dir" Then
                        'Save Picture CurrentDirectory
                        Dim dir As String = Directory.GetCurrentDirectory & "\PIC"

                        If (Not System.IO.Directory.Exists(Path.Combine(dir, "GRADUATE"))) Then
                            System.IO.Directory.CreateDirectory(Path.Combine(dir, "GRADUATE"))
                        End If

                        _photo_path = dir & _photo_filename

                        Dim _Image As Image
                        _Image = _view.PictureBox1.Image
                        _view.PictureBox1.Image = _Image
                        If Not File.Exists(_photo_path) Then
                            _view.PictureBox1.Image.Save(_photo_path)
                        End If

                        SaveImage_Global(_personID, "GRADUATE", "Graduated Image", _photo_path, _photo_filename)

                    Else
                        'Save Picture to Server

                        Dim appSettings As String = ConfigurationManager.AppSettings("Server_GRADUATE_Path")
                        Dim directory_info As DirectoryInfo = New DirectoryInfo(appSettings)
                        Dim target_path As String = ""
                        Try

                            target_path = directory_info.FullName & "\" & _photo_filename
                            If Not File.Exists(target_path) Then
                                Dim document As FileStream
                                document = File.Create(target_path)
                                document.Close()
                            End If

                            If _photo_path <> target_path Then
                                System.IO.File.Copy(_photo_path, target_path.ToString, True)
                            End If

                            SaveImage_Global(_personID, "GRADUATE", "Graduated Image", target_path, _photo_filename)

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If

                End If
            End If

            FUNCTION_TYPE = ""

            frmGraduateList.frmGraduateList_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub OpeFile_Dialog(sender As Object, e As EventArgs)


        With _view.OpenFileDialog1
            .Title = "Select an Image"  ' Path.GetFileName(.FileName)
            .InitialDirectory = "C:\"
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|All files (*.*)|*.*" '"JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
            .FilterIndex = 1

        End With
        If _view.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With _view.PictureBox1
                .Image = Image.FromFile(_view.OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If


        _view.txtpicturepath.Text = _view.OpenFileDialog1.FileName & Format(_view.dtiDateGraduate.Value, "MMddyy")
        Dim names = _view.txtpicturepath.Text.Trim
        Dim phrase As String = names.Substring(names.LastIndexOf("\"c) + 1)

        _view.txtpicturepath.Text = phrase
        '     _photo_path = Dir & _view.txtpicturepath.Text

        ''Check Image
        'Dim Exist As Boolean = RecordModel.CheckImage(_view.txtpicturepath.Text)
        'If Exist Then
        '    MsgBox("Image is already in use", MsgBoxStyle.Information, "ALREADY EXIST")

        '    _view.txtpicturepath.Text = ""
        '    loadPicture(False, "")

        '    Exit Sub
        'End If


    End Sub

    Private Sub AssignGraduate(sender As Object, e As EventArgs)
        _view.Panel2.Enabled = True
    End Sub

    Private Sub LoadComboBox()

        _view.cmbCitizenship.DataSource = RecordModel.getCitizenship()
        _view.cmbCitizenship.ValueMember = "ID"
        _view.cmbCitizenship.DisplayMember = "Name"
        _view.cmbCitizenship.SelectedIndex = 0

        _view.cmbCourse.DataSource = RecordModel.gerCourseList()
        _view.cmbCourse.ValueMember = "ID"
        _view.cmbCourse.DisplayMember = "Name"
        _view.cmbCourse.SelectedIndex = -1

        _view.txtEntranceData.DataSource = RecordModel.getEntranceData()
        _view.txtEntranceData.ValueMember = "ID"
        _view.txtEntranceData.DisplayMember = "Name"
        _view.txtEntranceData.SelectedIndex = -1


    End Sub
End Class
