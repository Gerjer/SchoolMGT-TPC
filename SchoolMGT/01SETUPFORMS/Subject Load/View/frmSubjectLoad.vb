Imports SchoolMGT

Public Class frmSubjectLoad

    Dim ListPresenter As SubjectLoadListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New SubjectLoadListPresenter(Me)

    End Sub


End Class