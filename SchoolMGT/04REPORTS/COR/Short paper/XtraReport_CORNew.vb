

Imports System.IO
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Public Class XtraReport_CORNew
    'Dim ListModel As New StudentLearnersListModel

    'Dim COR_info As New Student_COR
    'Dim Subject_info As New List(Of COR_Subject_Details)
    'Dim Assessment_info As New List(Of COR_Assessment_Details)
    'Dim Default_LogoPath As String = Directory.GetCurrentDirectory & "\TPC_logo.jpg"

    'Public AdmissionNo As String = ""
    'Public COR_copy As String = ""
    'Public COR_color As String = ""

    'Dim StudentID As Integer


    'Private Sub PageHeader_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageHeader.BeforePrint
    '    XrLabel1.Text = COMPANY_NAME
    '    XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
    '    XrLabel5.Text = "Email Address: " & COMPANY_EMAIL_ADDRESS

    '    If Not File.Exists(COMPANY_LOGO_PATH) Then
    '        XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
    '    Else
    '        XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
    '    End If

    '    XrLabeLRegistrarCopy.Text = COR_copy
    '    XrLabeLRegistrarCopy.BackColor = Color.FromName(COR_color)

    '    Dim dt As New DataTable
    '    dt = ListModel.getStudents_COR_info(AdmissionNo)

    '    If dt.Rows.Count > 0 Then

    '        For x As Integer = 0 To dt.Rows.Count - 1

    '            Dim obj As New Student_COR
    '            With obj
    '                .Id_number = If(IsDBNull(dt(x)("IdNumber")), "", dt(x)("IdNumber"))
    '                .Name = If(IsDBNull(dt(x)("NameCourse")), "", dt(x)("NameCourse")) 'dt(x)("NameCourse")
    '                .Sim_year_date = If(IsDBNull(dt(x)("sem_year_date")), "", dt(x)("sem_year_date")) 'dt(x)("sem_year_date")
    '                .Total_units = If(IsDBNull(dt(x)("TotalUnits")), 0, dt(x)("TotalUnits")) 'dt(x)("TotalUnits")
    '                .Tution_fees = If(IsDBNull(dt(x)("TutionFees")), 0, dt(x)("TutionFees")) 'dt(x)("TutionFees")
    '            End With
    '            COR_info = obj
    '        Next

    '    End If


    '    BindingSource1.DataSource = COR_info

    '    StudentID = ListModel.getStudentID(AdmissionNo)


    'End Sub

    'Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint

    '    Dim dt As New DataTable

    '    Try
    '        dt = ListModel.getStudent_Subject_info(AdmissionNo)


    '        If dt.Rows.Count > 0 Then

    '            For x As Integer = 0 To dt.Rows.Count - 1

    '                Dim obj As New COR_Subject_Details
    '                With obj
    '                    .Subject_code = dt(x)("subject_code")
    '                    .Descriptive_title = dt(x)("descriptive_title")
    '                    .Units = dt(x)("units")
    '                    .Time = dt(x)("time")
    '                    .Day = dt(x)("day")
    '                    .Room = dt(x)("room")
    '                    .Instructor = dt(x)("instructor")
    '                End With
    '                Subject_info.Add(obj)
    '            Next
    '        End If

    '        Dim Subreport As XRSubreport = TryCast(Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
    '        Subreport.ReportSource.DataSource = Subject_info


    '    Catch ex As Exception

    '    End Try

    '    dt = Nothing

    '    Try
    '        dt = ListModel.getStudent_Assessment_info(StudentID)

    '        If dt.Rows.Count > 0 Then

    '            For x As Integer = 0 To dt.Rows.Count - 1

    '                Dim obj As New COR_Assessment_Details
    '                With obj
    '                    .Charges = dt(x)("Charges")
    '                    .Amount = dt(x)("Amount")
    '                End With
    '                Assessment_info.Add(obj)
    '            Next
    '        End If

    '        Dim Subreport As XRSubreport = TryCast(Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
    '        Subreport.ReportSource.DataSource = Assessment_info


    '    Catch ex As Exception

    '    End Try

    'End Sub


    'Private Sub XtraReport_CORNew_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
    '    XrLabel1.Text = COMPANY_NAME
    '    XrLabel4.Text = "Contact #: " & COMPANY_MOBILE_NUMBER
    '    XrLabel5.Text = "Email Address: " & COMPANY_EMAIL_ADDRESS

    '    If Not File.Exists(COMPANY_LOGO_PATH) Then
    '        XrPictureBox1.ImageSource = New ImageSource(New Bitmap(Default_LogoPath))
    '    Else
    '        XrPictureBox1.ImageSource = New ImageSource(New Bitmap(COMPANY_LOGO_PATH))
    '    End If

    '    XrLabeLRegistrarCopy.Text = COR_copy
    '    XrLabeLRegistrarCopy.BackColor = Color.FromName(COR_color)

    '    Dim dt As New DataTable
    '    dt = ListModel.getStudents_COR_info(AdmissionNo)

    '    If dt.Rows.Count > 0 Then

    '        For x As Integer = 0 To dt.Rows.Count - 1

    '            Dim obj As New Student_COR
    '            With obj
    '                .Id_number = If(IsDBNull(dt(x)("IdNumber")), "", dt(x)("IdNumber"))
    '                .Name = If(IsDBNull(dt(x)("NameCourse")), "", dt(x)("NameCourse")) 'dt(x)("NameCourse")
    '                .Sim_year_date = If(IsDBNull(dt(x)("sem_year_date")), "", dt(x)("sem_year_date")) 'dt(x)("sem_year_date")
    '                .Total_units = If(IsDBNull(dt(x)("TotalUnits")), 0, dt(x)("TotalUnits")) 'dt(x)("TotalUnits")
    '                .Tution_fees = If(IsDBNull(dt(x)("TutionFees")), 0, dt(x)("TutionFees")) 'dt(x)("TutionFees")
    '            End With
    '            COR_info = obj
    '        Next

    '    End If


    '    BindingSource1.DataSource = COR_info

    '    StudentID = ListModel.getStudentID(AdmissionNo)

    '    dt = Nothing

    '    Try
    '        dt = ListModel.getStudent_Subject_info(AdmissionNo)


    '        If dt.Rows.Count > 0 Then

    '            For x As Integer = 0 To dt.Rows.Count - 1

    '                Dim obj As New COR_Subject_Details
    '                With obj
    '                    .Subject_code = dt(x)("subject_code")
    '                    .Descriptive_title = dt(x)("descriptive_title")
    '                    .Units = dt(x)("units")
    '                    .Time = dt(x)("time")
    '                    .Day = dt(x)("day")
    '                    .Room = dt(x)("room")
    '                    .Instructor = dt(x)("instructor")
    '                End With
    '                Subject_info.Add(obj)
    '            Next
    '        End If

    '        Dim Subreport As XRSubreport = TryCast(Bands(BandKind.Detail).FindControl("XrSubreport1", True), XRSubreport)
    '        Subreport.ReportSource.DataSource = Subject_info


    '    Catch ex As Exception

    '    End Try

    '    dt = Nothing

    '    Try
    '        dt = ListModel.getStudent_Assessment_info(StudentID)

    '        If dt.Rows.Count > 0 Then

    '            For x As Integer = 0 To dt.Rows.Count - 1

    '                Dim obj As New COR_Assessment_Details
    '                With obj
    '                    .Charges = dt(x)("Charges")
    '                    .Amount = dt(x)("Amount")
    '                End With
    '                Assessment_info.Add(obj)
    '            Next
    '        End If

    '        Dim Subreport As XRSubreport = TryCast(Bands(BandKind.Detail).FindControl("XrSubreport2", True), XRSubreport)
    '        Subreport.ReportSource.DataSource = Assessment_info


    '    Catch ex As Exception

    '    End Try


    '   End Sub
End Class