Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document

Public Class rpt_CHED_E_List
    Dim ctr As Integer = 1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal semesterTri As String, ByVal CourseProgram As String, ByVal yearLevel As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.TextBox17.Text = semesterTri
        Me.TextBox18.Text = CourseProgram
        Me.TextBox19.Text = yearLevel

    End Sub
    Private Sub Detail1_Format(sender As Object, e As EventArgs) Handles Detail1.Format

        Dim height As Single = Me.TextBox34.Height

        For Each act_ctl As ARControl In Detail1.Controls
            System.Console.WriteLine(act_ctl.Name & " - " & act_ctl.Height)

            'If height < act_ctl.Height Then
            '    height = act_ctl.Height
            '    heighestControlName = act_ctl.Name
            'End If

        Next
        System.Console.WriteLine("NEXT Record : " & ctr)
        ctr += 1
    End Sub

    'Private Sub Detail1_BeforePrint(sender As Object, e As EventArgs) Handles Detail1.BeforePrint
    '    Dim height As Single = 0
    '    Dim heighestControlName As String

    '    For Each act_ctl As ARControl In Detail1.Controls
    '        System.Console.WriteLine(act_ctl.Name & " - " & act_ctl.Height)

    '        'If height < act_ctl.Height Then
    '        '    height = act_ctl.Height
    '        '    heighestControlName = act_ctl.Name
    '        'End If
    '    Next


    'End Sub
End Class
