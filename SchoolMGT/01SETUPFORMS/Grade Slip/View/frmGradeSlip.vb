Imports SchoolMGT

Public Class frmGradeSlip

    Dim ListPresenter As GradeSlipListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New GradeSlipListPresenter(Me)

    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged

    End Sub
End Class