
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
'Imports System.Net.Mail
'Imports System.Threading
'Imports System.ComponentModel
'Imports System.Runtime.InteropServices
'Imports System.IO
'Imports System.Reflection


Public Class rpt_CollegeStudentAssessmentReport
    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal SY As String, ByVal adm_no As String, ByVal name As String,
            ByVal course As String, ByVal reg_date As String, ByVal sem As String,
            ByVal yr_level As String, ByVal enrollmentStat As String)

        InitializeComponent()

        Me.lblSY.Text = SY
        Me.lblAdmissionNo.Text = adm_no
        Me.lblName.Text = name
        Me.lblCourse.Text = course
        Me.lblRegDate.Text = reg_date
        Me.lblSem.Text = sem
        Me.lvlLevel.Text = yr_level

        If enrollmentStat = "2" Then
            Label17.Visible = True
        Else
            Label17.Visible = False
        End If


    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        subRptSubjectList.Report = New subrpt_StudentSubjectList
        subRptSubjectList.Report.DataSource = report_dt_fees

        subRptPaymode.Report = New subrpt_studentpaymode
        subRptPaymode.Report.DataSource = report_dt_payables
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS


        'If Not COMPANY_LOGO Is Nothing Then
        '    Using ms As New MemoryStream(COMPANY_LOGO, 0, COMPANY_LOGO.Length)
        '        ms.Write(COMPANY_LOGO, 0, COMPANY_LOGO.Length)
        '        COMPANY_IMAGE = Image.FromStream(ms, True)
        '    End Using
        'End If
        'Picture1.Image = COMPANY_IMAGE


        'Try
        '    Dim bytes() As Byte = System.IO.File.ReadAllBytes(COMPANY_LOGO_PATH)
        '    Dim ms As MemoryStream = New System.IO.MemoryStream(bytes)
        '    Picture1.Image = Image.FromStream(ms)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub PageFooter1_BeforePrint(sender As Object, e As EventArgs) Handles PageFooter1.BeforePrint
        Label16.Text = copyrigth
    End Sub
End Class
