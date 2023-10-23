Public Class MasterSetup

    Public tableName As String
    Public SetupName As String
    Public Parameter As String
    Public FieldName As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            DataSource(String.Format("INSERT INTO " & tableName & "(" & FieldName & ")VALUES ('" & txt_name.Text & "');"))
            MsgBox("Data has been added to '" & SetupName & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MasterSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        WinLabel.Text = SetupName
    End Sub
End Class