Imports MySql.Data.MySqlClient

Public Class fmaCreditDistributionSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtid

        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtunitreq
        clsGroup.AttachControl = Me.txtunitearned
        clsGroup.AttachControl = Me.txtcourse_name
        clsGroup.AttachControl = Me.txtcourse_id


        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......
        displayCourse()

    End Sub


    Private Sub displayCourse()
        Dim SQLEX As String = "SELECT id, course_name  FROM courses"
        SQLEX += " WHERE is_deleted <> 1"
        SQLEX += " GROUP BY course_name"
        SQLEX += " ORDER BY course_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        txtcourse_name.DataSource = MeData

        txtcourse_name.ValueMember = "id"
        txtcourse_name.DisplayMember = "course_name"

        txtcourse_name.SelectedIndex = -1
        txtcourse_id.Text = ""


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

    Private Sub txtcourse_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcourse_name.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtcourse_name.SelectedItem, DataRowView)
            Me.txtcourse_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtcourse_id.Text = ""
        End Try
    End Sub
End Class