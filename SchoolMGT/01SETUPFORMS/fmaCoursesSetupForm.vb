Imports MySql.Data.MySqlClient

Public Class fmaCoursesSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtid

        clsGroup.AttachControl = Me.txtcategory_name
        clsGroup.AttachControl = Me.txtcategory_id
        clsGroup.AttachControl = Me.txtcourse_name
        clsGroup.AttachControl = Me.txtcode
        clsGroup.AttachControl = Me.txtsection_name
        clsGroup.AttachControl = Me.txtdescription

        getCategory()
        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......


    End Sub

    Private Sub getCategory()
        Dim SQLEX As String = "SELECT id,name from student_categories"
        SQLEX += " WHERE is_deleted <> 1"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        txtcategory_name.DataSource = MeData

        txtcategory_name.ValueMember = "id"
        txtcategory_name.DisplayMember = "name"

        txtcategory_name.SelectedIndex = -1
        txtcategory_id.Text = ""
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
        If Me.txtcourse_name.Text = "" Or Me.txtcategory_name.Text = "" Then
            MsgBox("Name Cannot be blank.", MsgBoxStyle.Critical)
            Me.DetachClasses()
            Me.AttachClasses()

            If Me.OPERATION = "ADD" Then
                Me.btnAdd.PerformClick()
            ElseIf Me.OPERATION = "EDIT" Then
                Me.btnModify.PerformClick()
            End If
        End If



    End Sub

    Private Sub txtcategory_name_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcategory_name.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtcategory_name.SelectedItem, DataRowView)
            Me.txtcategory_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtcategory_id.Text = ""
        End Try
    End Sub

    Private Sub btnCourselist_Click(sender As Object, e As EventArgs) Handles btnCourselist.Click

        Dim frm As New CourseList
        frm.ShowDialog()
        frm.BringToFront()

        Me.txtcourse_name.Text = frm.CourseName
        Me.txtcode.Text = ""
        Me.txtsection_name.Text = frm.CourseMajor
        Me.txtdescription.Text = frm.Description


    End Sub
End Class