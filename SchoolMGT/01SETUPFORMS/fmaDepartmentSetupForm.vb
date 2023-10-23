Imports DevComponents.DotNetBar.Controls
Imports MySql.Data.MySqlClient

Public Class fmaDepartmentSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""
    Public id As Integer
#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtid

        clsGroup.AttachControl = Me.txtcode
        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtdescription

        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......


    End Sub

    Private Sub DetachClasses()
        clsGroup = Nothing
    End Sub
#End Region

    Private Sub fmaEmployeeSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '    Me.DetachClasses()
        ' RaiseEvent SETUP_CLOSED()
    End Sub

    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        '     Me.AttachClasses()

        AddHandler btnSave.Click, AddressOf btnSaveClick

    End Sub

    Private Sub btnSaveClick(sender As Object, e As EventArgs)

        If Me.OPERATION = "ADD" Then
            _insert(txtcode.Text, txtname.Text, txtdescription)
        ElseIf Me.OPERATION = "EDIT" Then
            _update(id, txtcode.Text, txtname.Text, txtdescription)
        End If
        ''
        fmaDepartmentListForm.Attach()

    End Sub

    Private Sub _update(id As Integer, code As String, name As String, description As TextBoxX)
        Try
            DataSource(String.Format("UPDATE `employee_departments`
                        SET 
                          `code` = '" & txtcode.Text & "',
                          `name` = '" & txtname.Text & "',
                          `description` = '" & txtdescription.Text & "'
                        WHERE `id` = '" & id & "';"))

            MessageBox.Show("Record Updated...", "Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub _insert(code As String, name As String, description As TextBoxX)
        Try

            DataSource(String.Format("INSERT INTO `employee_departments`
            (
             `code`,
             `name`,
             `description`)
        VALUES (
                '" & txtcode.Text & "',
                '" & txtname.Text & "',
                '" & txtdescription.Text & "');"))

            MessageBox.Show("Record Save...", "Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AfterDelete() Handles clsGroup.AfterDelete
        '   RaiseEvent DB_MODIFIED()

    End Sub

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        '     RaiseEvent DB_MODIFIED()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.Close()
        End If


        'If Me.btnAdd.Visible = False Then
        '    Me.btnAdd.Visible = True
        'End If
    End Sub




    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        If Me.txtname.Text = "" Then
            MsgBox("Course Cannot be blank.", MsgBoxStyle.Critical)
            Me.DetachClasses()
            Me.AttachClasses()

            If Me.OPERATION = "ADD" Then
                Me.btnAdd.PerformClick()
            ElseIf Me.OPERATION = "EDIT" Then
                Me.btnModify.PerformClick()
            End If
        End If



    End Sub

End Class