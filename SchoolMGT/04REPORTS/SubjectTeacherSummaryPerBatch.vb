Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class SubjectTeacherSummaryPerBatch

    Dim detailCounter As Integer = 0
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal courseLevel As String, ByVal batch As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.txtCourseLevel.Text = courseLevel
        Me.txtBatch.Text = batch
        detailCounter = 1
    End Sub

   

    Private Sub Detail1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.Format
        txtNo.Text = detailCounter
        detailCounter += 1

    End Sub

    Private Sub GroupHeader2_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader2.BeforePrint
        detailCounter = 1
    End Sub

    Private Sub GroupFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.BeforePrint
        TextBox14.Text = "TOTAL NUMBER OF STUDENT : " & detailCounter - 1
    End Sub
End Class
