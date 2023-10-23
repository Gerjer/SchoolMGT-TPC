Imports MySql.Data.MySqlClient

Public Class fmaSubjectaSetupForm

    Public Event subjectAdded()
    Public TYPE As Integer = 0

    'Public ELECTIVENAME As String = ""
    'Public ELECTIVEID As String = ""
    'Public BATCHID As String = ""
    Public OPETYPE As String = ""  ' NEW or EDIT Operation

    Public CDValue As Integer = 0


    Private Sub fmaSubjectaSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtSubjCode.Focus()
        cmbType.SelectedIndex = TYPE
        displayCreditDistribution()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub displayCreditDistribution()
        Dim SQLEX As String = "SELECT id, name FROM credit_distribution ORDER BY id"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbDistribution.DataSource = MeData

        cmbDistribution.ValueMember = "id"
        cmbDistribution.DisplayMember = "name"

        cmbDistribution.SelectedIndex = -1
        cmbDistribution.Text = ""
        txtCDid.Text = "-1"

        cmbDistribution.SelectedValue = CDValue


        MeData = Nothing
        SQLEX = "SELECT ccid FROM subjects WHERE id='" & txtSubjID.Text & "'"
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Dim value As Integer = CInt(MeData.Rows(0).Item("ccid").ToString)
            cmbDistribution.SelectedValue = value
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If Me.txtSubjCode.Text.Length = 0 Then
                MsgBox("Please Enter Subject Code.")
                Exit Sub
            End If

            If Me.txtName.Text.Length = 0 Then
                MsgBox("Please Enter Subject Name.")
                Exit Sub
            End If

            Dim noExam As Integer = cmbType.SelectedIndex

            If OPETYPE = "NEW" Then
                If rbtnOptional.Checked Then

                    If Me.txtElectiveID.Text.Length > 0 Then

                        Dim SQLIN As String = "INSERT INTO subjects(name,code,batch_id,no_exams,elective_group_id,credit_hours,amount"
                        SQLIN += " ,ccid,creditdistribution,limit_subject)"
                        SQLIN += " VALUES("
                        SQLIN += String.Format("'{0}','{1}',", Me.txtName.Text, Me.txtSubjCode.Text)
                        SQLIN += String.Format("'{0}','{1}',", Me.txtBatchID.Text, noExam)
                        SQLIN += String.Format("'{0}','{1}',", Me.txtElectiveID.Text, Me.txtNoUnit.Value)
                        SQLIN += String.Format("'{0}',", Me.txtAmount.Value)
                        SQLIN += String.Format("'{0}','{1}','{2}')", Me.txtCDid.Text, Me.cmbDistribution.Text, Me.txtlimit_subject.Value)

                        If clsDBConn.Execute(SQLIN) Then
                            MsgBox("Subject has been saved.")
                            RaiseEvent subjectAdded()
                        End If

                    Else
                        'create elective_groups
                        Dim SQLIN As String = "INSERT INTO elective_groups(name,batch_id)"
                        SQLIN += " VALUES("
                        SQLIN += String.Format("'{0}', '{1}')", txtElectives.Text, txtBatchID.Text)

                        Dim electiveid As String = ""

                        If clsDBConn.Execute(SQLIN) Then
                            Dim SQLEX As String = "SELECT id FROM elective_groups ORDER BY ID DESC LIMIT 1 "
                            Dim MeData As DataTable


                            MeData = clsDBConn.ExecQuery(SQLEX)
                            If MeData.Rows.Count > 0 Then
                                electiveid = MeData.Rows(0).Item("id").ToString
                                Me.txtElectiveID.Text = electiveid
                            End If


                            SQLIN = "INSERT INTO subjects(name,code,batch_id,no_exams,elective_group_id,credit_hours,amount"
                            SQLIN += " ,ccid,creditdistribution,limit_subject)"
                            SQLIN += " VALUES("
                            SQLIN += String.Format("'{0}','{1}',", Me.txtName.Text, Me.txtSubjCode.Text)
                            SQLIN += String.Format("'{0}','{1}',", Me.txtBatchID.Text, noExam)
                            SQLIN += String.Format("'{0}','{1}',", Me.txtElectiveID.Text, Me.txtNoUnit.Value)
                            SQLIN += String.Format("'{0}',", Me.txtAmount.Value)
                            SQLIN += String.Format("'{0}','{1}','{2}')", Me.txtCDid.Text, Me.cmbDistribution.Text, Me.txtlimit_subject.Value)

                            If clsDBConn.Execute(SQLIN) Then
                                MsgBox("Subject has been saved.")
                                RaiseEvent subjectAdded()
                            End If

                        End If

                    End If

                Else
                    Dim SQLIN As String = "INSERT INTO subjects(name,code,batch_id,no_exams,elective_group_id,credit_hours,amount"
                    SQLIN += " ,ccid,creditdistribution,limit_subject)"
                    SQLIN += " VALUES("
                    SQLIN += String.Format("'{0}','{1}',", Me.txtName.Text, Me.txtSubjCode.Text)
                    SQLIN += String.Format("'{0}','{1}',", Me.txtBatchID.Text, noExam)
                    SQLIN += String.Format("'{0}','{1}',", Me.txtElectiveID.Text, Me.txtNoUnit.Value)
                    SQLIN += String.Format("'{0}',", Me.txtAmount.Value)
                    SQLIN += String.Format("'{0}','{1}','{2}')", Me.txtCDid.Text, Me.cmbDistribution.Text, Me.txtlimit_subject.Value)


                    If clsDBConn.Execute(SQLIN) Then
                        MsgBox("Subject has been saved.")
                        RaiseEvent subjectAdded()
                    End If

                End If

            ElseIf OPETYPE = "EDIT" Then
                If txtCDid.Text.Length = 0 Then
                    MsgBox("Please specify Credit Distribution Value", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If rbtnOptional.Checked Then
                    Dim SQLUP As String = "UPDATE subjects SET "
                    SQLUP += String.Format("name='{0}',code='{1}',", txtName.Text, txtSubjCode.Text)
                    SQLUP += String.Format("no_exams='{0}',credit_hours='{1}'", noExam, txtNoUnit.Value)
                    SQLUP += String.Format(",amount='{0}'", txtAmount.Value)
                    SQLUP += String.Format(",elective_group_id='{0}'", txtElectiveID.Text)
                    SQLUP += String.Format(",ccid='{0}'", txtCDid.Text)
                    SQLUP += String.Format(",creditdistribution='{0}'", cmbDistribution.Text)
                    SQLUP += String.Format(",limit_subject='{0}'", txtlimit_subject.Value)
                    SQLUP += " WHERE id = '" & txtSubjID.Text & "'"

                    If clsDBConn.Execute(SQLUP) Then
                        MsgBox("Subject has been updated.")
                        RaiseEvent subjectAdded()
                    End If
                Else
                    Dim SQLUP As String = "UPDATE subjects SET "
                    SQLUP += String.Format("name='{0}',code='{1}',", txtName.Text, txtSubjCode.Text)
                    SQLUP += String.Format("no_exams='{0}',credit_hours='{1}'", noExam, txtNoUnit.Value)
                    SQLUP += String.Format(",amount='{0}'", txtAmount.Value)
                    SQLUP += ",elective_group_id=NULL"
                    SQLUP += String.Format(",ccid='{0}'", txtCDid.Text)
                    SQLUP += String.Format(",creditdistribution='{0}'", cmbDistribution.Text)
                    SQLUP += String.Format(",limit_subject='{0}'", txtlimit_subject.Value)
                    SQLUP += " WHERE id = '" & txtSubjID.Text & "'"

                    If clsDBConn.Execute(SQLUP) Then
                        MsgBox("Subject has been updated.")
                        RaiseEvent subjectAdded()
                    End If
                End If

                '   Me.Close()
            End If


            '    cmbDistribution.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        clearControl()
        btnAdd.Visible = True
    End Sub

    Private Sub clearControl()
        txtSubjCode.Text = ""
        txtName.Text = ""
        cmbType.SelectedIndex = TYPE
        txtNoUnit.Value = 0
        txtAmount.Value = 0
        cmbDistribution.SelectedIndex = -1
        GroupPanel2.Enabled = False
    End Sub

    Private Sub cmbDistribution_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDistribution.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbDistribution.SelectedItem, DataRowView)
            Me.txtCDid.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCDid.Text = ""
        End Try
    End Sub

    Private Sub rbtnOptional_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnOptional.CheckedChanged
        If rbtnOptional.Checked Then
            txtElectiveID.Text = "0"
        End If
    End Sub

    Private Sub rbtnElective_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnElective.CheckedChanged
        If rbtnElective.Checked Then
            txtElectiveID.Text = "1"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OPETYPE = "NEW"
        GroupPanel2.Enabled = True
    End Sub
End Class