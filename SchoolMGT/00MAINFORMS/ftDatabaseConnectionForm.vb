Public Class ftDatabaseConnectionForm

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call Connect()
    End Sub

    Private Sub Connect()
        clsDBConn.ServerName = Me.txtServerName.Text
        clsDBConn.DatabaseName = Me.txtDatabaseName.Text
        clsDBConn.UserID = Me.txtUserName.Text
        clsDBConn.Password = Me.txtPassword.Text

        Me.SaveToRegistry()

        If clsDBConn.IsDBConnected Then
            MessageBox.Show("Connected to database....", "Successfully !")
            Me.Close()
        End If
    End Sub

    Private Sub SaveToRegistry()
        SaveSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName", Me.txtServerName.Text)
        SaveSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName", Me.txtDatabaseName.Text)
        SaveSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName", Me.txtUserName.Text)
        SaveSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password", Me.txtPassword.Text)
    End Sub

    Private Sub GetRegistryEntries()
        Me.txtServerName.Text = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
        Me.txtDatabaseName.Text = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
        Me.txtUserName.Text = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
        Me.txtPassword.Text = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
    End Sub

    Private Sub ftDatabaseConnectionForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GetRegistryEntries()
    End Sub

End Class