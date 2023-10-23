Imports SchoolMGT
Public Class frmGradeSheet

    Dim ListPresenter As GradeSheetListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New GradeSheetListPresenter(Me)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ListPresenter.Print()
    End Sub

    Dim checkstatus As Boolean

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        cmbSubject.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        cmbDayName.SelectedIndex = -1
        cmbTimeSched.SelectedIndex = -1
        cmbRoom.SelectedIndex = -1
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged

    End Sub


    'Private Sub chkFilteredActiveRecords_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilteredActiveRecords.CheckedChanged
    '    checkstatus = chkFilteredActiveRecords.Checked
    'End Sub

    'Private Sub frmGradeSheet_Load(sender As Object, e As EventArgs) Handles Me.Load


    'End Sub


End Class