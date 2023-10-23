Public Class frmSU_Pass
    Public Event OKButton_click()
    Public passwordOK As Boolean = False

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        '   Dim SQL As String = String.Format("SELECT Type_User FROM users WHERE Type_User='SUPERUSER' AND Password_User='{0}' AND SysPK_User<>0", Me.txtPassword.Text)
        Dim SQL As String = String.Format("SELECT Type_User FROM users WHERE Type_User='SUPERUSER' AND username='{0}' AND id<>0", Me.txtPassword.Text)

        Dim Medata As New DataTable

        Try
            Medata = clsDBConn.ExecQuery(SQL)

            If Medata.Rows.Count > 0 Then
                Dim userTYpe As String = Medata.Rows(0).Item("Type_User").ToString
                passwordOK = True

            Else
                AuthUserType = ""
                passwordOK = False
            End If
        Catch ex As Exception
            passwordOK = False
        End Try

        RaiseEvent OKButton_click()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Function getResult() As Boolean
        Return passwordOK
    End Function

    Private Sub frmSVPass_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtPassword.Text = ""


    End Sub

    Private Sub frmSU_Pass_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Application.DoEvents()
        txtPassword.Focus()

    End Sub

    Private Sub txtPassword_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.ButtonCustomClick
        txtPassword.Text = ""
    End Sub
End Class