Imports MySql.Data.MySqlClient

Public Class fmaStudentCategorySetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtid

        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtno_of_payment


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


        'If Me.btnAdd.Visible = False Then
        '    Me.btnAdd.Visible = True
        'End If
    End Sub




    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave
        If Me.txtname.Text = "" Then
            MsgBox("Code Cannot be blank.", MsgBoxStyle.Critical)
            Me.DetachClasses()
            Me.AttachClasses()

            If Me.OPERATION = "ADD" Then
                Me.btnAdd.PerformClick()
            ElseIf Me.OPERATION = "EDIT" Then
                Me.btnModify.PerformClick()
            End If
        End If



    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtname.Focus()
    End Sub

End Class