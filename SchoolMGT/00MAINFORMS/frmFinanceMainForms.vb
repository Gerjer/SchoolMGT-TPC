Imports MySql.Data.MySqlClient

Public Class frmFinanceMainForms

    

    Private Sub frmFinanceMainForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.Width \ 2 - Panel1.Width \ 2, Panel1.Top)
    End Sub
End Class