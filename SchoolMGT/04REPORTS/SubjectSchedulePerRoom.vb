Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class SubjectSchedulePerRoom

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

    End Sub

End Class
