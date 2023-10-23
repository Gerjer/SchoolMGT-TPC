Public Class frmTESApplicationEntry
    Dim RecordPresenter As TESApplicationRecordPresenter
    Public id As Integer
    Public Operation As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RecordPresenter = New TESApplicationRecordPresenter(Me)
    End Sub

    Private Sub frmTESApplicationEntry_Load(sender As Object, e As EventArgs) Handles Me.Load

        RecordPresenter.id = id
        RecordPresenter.Operation = Operation

        If Operation = "EDIT" Then
            RecordPresenter.AssigningControls()
        End If
    End Sub
End Class