Imports MySql.Data.MySqlClient

Public Class fmaDepatmentSetup

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK_Item, clsDBConn)
        clsGroup.AttachUserPK = Me.txtItem_Code

        clsGroup.AttachControl = Me.txtItem_Code
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
        Me.DetachClasses()
        RaiseEvent SETUP_CLOSED()
    End Sub

    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If
        ''
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AfterDelete() Handles clsGroup.AfterDelete
        RaiseEvent DB_MODIFIED()

    End Sub

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        RaiseEvent DB_MODIFIED()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.Close()
        End If


        If Me.btnAdd.Visible = False Then
            Me.btnAdd.Visible = True
        End If
    End Sub


    Private Sub txtItem_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItem_Code.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
            txtname.SelectAll()
        End If
    End Sub

    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        If txtname.Text.Length = 0 Then
            MsgBox("Display Name should not be blank.", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtItem_Code.Focus()
    End Sub
End Class