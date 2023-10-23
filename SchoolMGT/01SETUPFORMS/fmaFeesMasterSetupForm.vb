Imports MySql.Data.MySqlClient

Public Class fmaFeesMasterSetupForm

    Public BATCH_ID As String = ""
    Public Event FeeAdded()


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txt_name.Text.Length = 0 Then
            MsgBox("Please Fill Master Fee Name.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If btnSave.Text = "Save" Then
            Dim SQLIN As String = "INSERT INTO finance_fee_categories(NAME,description,batch_id,is_master)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", txt_name.Text, txtDescr.Text)
            SQLIN += String.Format("'{0}', '1')", BATCH_ID, txtDescr.Text)

            If clsDBConn.Execute(SQLIN) Then
                RaiseEvent FeeAdded()
                Me.Close()
            End If
        ElseIf btnSave.Text = "Modify" Then
            Dim SQLUP As String = "UPDATE finance_fee_categories "
            SQLUP += String.Format("SET NAME='{0}', description='{1}'", txt_name.Text, txtDescr.Text)
            SQLUP += " WHERE id='" & txtCatID.Text & "'"
            If clsDBConn.Execute(SQLUP) Then
                RaiseEvent FeeAdded()
                Me.Close()
            End If
        End If

       




    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SQLEX As String = "Select COUNT(id) 'count' FROM finance_fee_particulars"
        SQLEX += " WHERE finance_fee_category_id='" & txtCatID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)
                If count > 0 Then
                    MsgBox("Cannot Delete Master Fee, Fee Details Exists.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        End If

        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLDEL As String = "DELETE FROM finance_fee_categories"
            SQLDEL += " WHERE id='" & txtCatID.Text & "'"

            If clsDBConn.Execute(SQLDEL) Then
                MsgBox("Master Fee has been deleted.", MsgBoxStyle.Information)
                RaiseEvent FeeAdded()
                Me.Close()
            End If
        End If

    End Sub
End Class