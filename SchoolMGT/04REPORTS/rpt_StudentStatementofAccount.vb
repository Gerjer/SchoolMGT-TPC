Imports System.Drawing.Image
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rpt_StudentStatementofAccount

    Dim Height As Double = 0
    Private me_remarks As String = ""

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal SY As String, ByVal adm_no As String, ByVal name As String,
            ByVal course As String, ByVal sem As String,
            ByVal yr_level As String, ByVal balance As String, ByVal remarks As String, ByVal grants As String)

        InitializeComponent()

        Me.lblSY.Text = SY
        Me.lblAdmissionNo.Text = adm_no
        Me.lblName.Text = name
        Me.lblCourse.Text = course

        Me.lblSem.Text = sem
        Me.lvlLevel.Text = yr_level
        Me.lblBalance.Text = balance
        Me.me_remarks = remarks
        Me.lblGrant.Text = grants
    End Sub



    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        subRptSubjectList.Report = New subrpt_SOAFee
        subRptSubjectList.Report.DataSource = report_dt_SOA

        subrpt_paymentsmade.Report = New subrpt_studentspayment_made
        subrpt_paymentsmade.Report.DataSource = report_dt_StudentsPayment



    End Sub

    Private Sub GroupFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.BeforePrint
        Me.txtRemarks.Text = Me.me_remarks
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS

        'If Not COMPANY_LOGO Is Nothing Then
        '    Using ms As New MemoryStream(COMPANY_LOGO, 0, COMPANY_LOGO.Length)
        '        ms.Write(COMPANY_LOGO, 0, COMPANY_LOGO.Length)
        '        Picture1.Image = System.Drawing.Image.FromStream(ms, True)
        '    End Using

        'End If
    End Sub
End Class
