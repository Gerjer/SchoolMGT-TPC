Public Class frmChed_E_FormBC

    Dim ListPresenter As ChedEFormBCListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New ChedEFormBCListPresenter(Me)

    End Sub

    Private Sub cmbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcademicYear.SelectedIndexChanged

    End Sub

    Private Sub gcChedEFormB_C_Click(sender As Object, e As EventArgs) Handles gcChedEFormB_C.Click

    End Sub
End Class