Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRequisitionSlip

    Dim RocordPresenter As RequisitionSlipRecordPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        RocordPresenter = New RequisitionSlipRecordPresenter(Me)
    End Sub

    Private Sub TextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX4.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX5_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX5.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX6_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX6.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX7_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX7.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX8_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX8.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX9_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX9.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX11_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX11.TextChanged
        If TextBoxX11.Text.Length > 0 Then
            TextBoxX12.Enabled = True
        End If
    End Sub

    Private Sub TextBoxX10_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX10.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX17_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX17.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX16_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX16.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX15_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX15.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX14_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX14.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX13_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX13.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub TextBoxX12_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX12.TextChanged
        RocordPresenter.TrapInput(sender)
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        RocordPresenter.ChekBoxEdit(CheckBox1.Text)
    End Sub

    Private Sub TextBoxX18_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX18.TextChanged
        RocordPresenter.ChekBoxEdit(TextBoxX18.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged

    End Sub
End Class