Public Class fmaUserSetup

    Public Operation As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPasswordChar2_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordChar2.TextChanged
        If txtPasswordChar1.Text = txtPasswordChar2.Text Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Dim userID As Integer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Operation = "ADD" Then

            Dim salt As String = CREATERANDOMSALT()
            Dim hashedPassword As String = HASH512(txtUserName.Text, salt) ' txtAdmNum.Text

            Dim SQLIN As String = "INSERT INTO users(username,first_name,last_name,student,admin,employee,hashed_password,salt,application_setup_id)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", txtUserName.Text, txtFirstName.Text)

            If RadioButton2.Checked = True Then
                SQLIN += String.Format("'{0}', '{1}',", txtLastName.Text, "1")
                SQLIN += String.Format("'{0}', '{1}',", "0", "0")
            Else
                SQLIN += String.Format("'{0}', '{1}',", txtLastName.Text, "0")
                SQLIN += String.Format("'{0}', '{1}',", "0", "1")
            End If

            SQLIN += String.Format("'{0}', '{1}','{2}')", hashedPassword, salt, AppSetup_Domain)

            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Password has been saved.")

                Dim SQLEX As String = "SELECT id from users where username='" & txtUserName.Text & "'"

                Dim userData As DataTable
                userData = clsDBConn.ExecQuery(SQLEX)

                If userData.Rows.Count > 0 Then
                    userID = userData.Rows(0).Item("id")

                    If RadioButton1.Checked = True Then
                        'Employee
                        If CheckIfUserIDiNOTExist(userID, cmbPerson.SelectedValue, 1) Then
                            'Update Employee Table
                            DataSource(String.Format("UPDATE employees SET user_id = '" & userID & "' WHERE id = '" & cmbPerson.SelectedValue & "'"))
                        End If
                    Else
                        'Students
                        If CheckIfUserIDiNOTExist(userID, cmbPerson.SelectedValue, 2) Then
                            'Update students
                            DataSource(String.Format("UPDATE students SET user_id = '" & userID & "' WHERE id = '" & cmbPerson.SelectedValue & "'"))
                        End If
                    End If

                End If
            End If


        Else
            If MessageBox.Show("Are you sure you want to Update Password?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                Dim salt As String = CREATERANDOMSALT()
                Dim hashedPassword As String = HASH512(txtPasswordChar2.Text, salt)

                Dim SQLIN As String = String.Format("UPDATE users SET hashed_password='{0}', salt='{1}',username = '{2}' WHERE id='{3}'", hashedPassword, salt, txtUserName.Text, txtUserID.Text)

                If clsDBConn.Execute(SQLIN) Then
                    MsgBox("Password has been updated.")

                    If RadioButton1.Checked = True Then
                        'Employee
                        If CheckIfUserIDiNOTExist(txtUserID.Text, cmbPerson.SelectedValue, 1) Then
                            'Update Employee Table
                            DataSource(String.Format("UPDATE employees SET user_id = '" & userID & "' WHERE id = '" & cmbPerson.SelectedValue & "'"))
                        End If
                    Else
                        'Students
                        If CheckIfUserIDiNOTExist(txtUserID.Text, cmbPerson.SelectedValue, 2) Then
                            'Update students
                            DataSource(String.Format("UPDATE students SET user_id = '" & userID & "' WHERE id = '" & cmbPerson.SelectedValue & "''"))
                        End If
                    End If


                End If


            End If

        End If
        fmaUserList.loadlist()

    End Sub

    Private Function CheckIfUserIDiNOTExist(userID As Integer, selectedValue As Object, Optional type As Integer = Nothing) As Boolean

        Dim id As Integer
        If type = 1 Then
            Try
                id = DataObject(String.Format("SELECT
                            employees.user_id
                            FROM
                            employees
                            WHERE
                            employees.status_type_id = 1 AND
                            employees.end_time IS NULL AND
                            employees.user_id = '" & userID & "' AND
                            employees.id = '" & selectedValue & "'

                            "))
            Catch ex As Exception
            End Try
        Else
            Try
                id = DataObject(String.Format("SELECT
                            students.user_id
                            FROM
                            students
                            WHERE
                            students.status_type_id = 1 AND
                            students.end_time IS NULL AND
                            students.user_id = '" & userID & "' AND
                            students.id = '" & selectedValue & "'

                            "))
            Catch ex As Exception
            End Try
        End If

        If id = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub fmaUserSetup_Load(sender As Object, e As EventArgs) Handles Me.Load

        If RadioButton1.Checked = True Then
            loadComboBox(RadioButton1.Tag)
        Else
            loadComboBox(RadioButton2.Tag)
        End If


        If Operation = "ADD" Then
            GroupBox3.Enabled = True
            lblPassword.Text = "PASSWORD"
        Else
            GroupBox3.Enabled = False
            lblPassword.Text = "NEW PASSWORD"
        End If

    End Sub

    Private Sub loadComboBox(type As Integer)

        If type = 1 Then

            cmbPerson.DataSource = DataSource(String.Format("SELECT
                                    employees.id 'id',
                                    person.display_name 'name',
                                    person.first_name,
                                    person.last_name
                                    FROM
                                    person
                                    INNER JOIN employees ON employees.person_id = person.person_id
                                    WHERE
                                    person.status_type_id = 1 AND
                                    person.end_time IS NULL AND
                                    employees.status_type_id = 1 AND
                                    employees.end_time IS NULL
                                    ORDER BY 'name'
                                                        "))
        Else

            cmbPerson.DataSource = DataSource(String.Format("SELECT 
                                    students.id 'id',
                                    person.display_name 'name',
                                    person.first_name,
                                    person.last_name

                                    FROM
                                    person
                                    INNER JOIN students ON person.person_id = students.person_id
                                    WHERE
                                    person.status_type_id = 1 AND
                                    person.end_time IS NULL AND
                                    students.status_type_id = 1 AND
                                    students.end_time IS NULL
                                    ORDER BY 'name'
                                                        "))

        End If

        cmbPerson.ValueMember = "id"
        cmbPerson.DisplayMember = "name"
        cmbPerson.SelectedIndex = -1


    End Sub

    Private Sub cmbPerson_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPerson.SelectionChangeCommitted
        Try
            Dim drv As DataRowView = DirectCast(cmbPerson.SelectedItem, DataRowView)
            txtFirstName.Text = drv.Item("first_name")
            txtLastName.Text = drv.Item("last_name")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        loadComboBox(RadioButton1.Tag)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        loadComboBox(RadioButton2.Tag)
    End Sub
End Class