Imports System.Web.UI.WebControls

Public Class frmPrevilegeAccess

    Dim Presenter As PrevilegeAccessPresenter
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Presenter = New PrevilegeAccessPresenter(Me)
    End Sub

    Private Sub frmPrevilegeAccess_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Me.Tag = 1 Then
            TabItem1.Visible = True
            TabItem2.Visible = False
        Else
            TabItem1.Visible = False
            TabItem2.Visible = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Presenter.processButton(btnAdd)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Presenter.loadPrevilege()
    End Sub

    Private Sub SUPERUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPERUSERToolStripMenuItem.Click
        Presenter.UserType(sender.ToString)
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem.Click
        Presenter.UserType(sender.ToString)
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Presenter.UserType(sender.ToString)
    End Sub

    Private Sub gvPrevilege_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvPrevilege.RowCellStyle
        If e.Column.FieldName = "TYPE OF USER" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End If
    End Sub
End Class