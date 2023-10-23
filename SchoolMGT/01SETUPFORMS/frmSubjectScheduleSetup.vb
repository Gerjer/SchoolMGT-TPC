Imports MySql.Data.MySqlClient
Public Class frmSubjectScheduleSetup

    Public SUBJECTID As String = ""

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK_Item, clsDBConn)
        clsGroup.AttachUserPK = Me.txtcode

        clsGroup.AttachControl = Me.txtcode
        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtsubject_id
        clsGroup.AttachControl = Me.txtroom
        clsGroup.AttachControl = Me.txtroom_id
        clsGroup.AttachControl = Me.txtclass_time
        clsGroup.AttachControl = Me.txtclass_timing_id
        clsGroup.AttachControl = Me.txtemployee_name
        clsGroup.AttachControl = Me.txtemployee_id


        'Handles Add,Save and Delete
        clsGroup.AttachAddButton = Me.btnAdd
        clsGroup.AttachSaveButton = Me.btnSave
        clsGroup.AttachModifyButton = Me.btnModify

        clsGroup.Initialize() 'Always naa gyud ni siya at the end......



    End Sub


    Private Sub getDropDownList()
        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT SysPK_Item,name FROM rooms"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtroom.DataSource = MeData
        Me.txtroom.DisplayMember = "name"
        Me.txtroom.ValueMember = "SysPK_Item"
        Me.txtroom.Text = ""
        Me.txtroom.SelectedIndex = -1
        Me.txtroom_id.Text = ""


        MeData = Nothing
        SQL = "SELECT id,name FROM class_timings"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtclass_time.DataSource = MeData
        Me.txtclass_time.DisplayMember = "name"
        Me.txtclass_time.ValueMember = "id"
        Me.txtclass_time.Text = ""
        Me.txtclass_time.SelectedIndex = -1
        Me.txtclass_timing_id.Text = ""

        MeData = Nothing
        SQL = "SELECT employees.id, CONCAT(last_name, ', ', first_name , ' ', middle_name) AS 'EMPNAME'"
        SQL += " FROM employees"
        SQL += " INNER JOIN employee_positions ON (employees.employee_position_id = employee_positions.id) "
        'SQL += " WHERE employee_positions.id = 2"
        'SQL += " AND subject_id='" & txtsubject_id.Text & "'"
        SQL += " ORDER BY last_name"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtemployee_name.DataSource = MeData
        Me.txtemployee_name.DisplayMember = "EMPNAME"
        Me.txtemployee_name.ValueMember = "id"
        Me.txtemployee_name.Text = ""
        Me.txtemployee_name.SelectedIndex = -1
        Me.txtemployee_id.Text = ""
    End Sub

    Private Sub DetachClasses()
        clsGroup = Nothing
    End Sub
#End Region

    Private Sub fmaEmployeeSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DetachClasses()
        RaiseEvent SETUP_CLOSED()
    End Sub

    Public subject_code As String
    Dim count As Integer
    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()
        Me.txtsubject_id.Text = Me.SUBJECTID

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If

        count = getAutoNumber()
        Me.txtcode.Text = "CC-" & subject_code & "-" & Format(count, "00000")

    End Sub
    Private Function getAutoNumber() As String
        Dim AutoNumber As Integer = DataObject(String.Format("SELECT
                      CASE WHEN `Count` IS NULL THEN 1 ELSE `Count` + 1 END AS 'Count'
                    FROM(
                    SELECT
                      MAX(`count`) AS 'Count'
                    FROM `schlmgt_tpc`.`subject_class_details`
                    )A;"))

        Return AutoNumber
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AddButtonClick() Handles clsGroup.AddButtonClick
        Me.txtsubject_id.Text = Me.SUBJECTID
        getDropDownList()

        count = getAutoNumber()
        Me.txtcode.Text = "CC-" & subject_code & "-" & Format(count, "00000")

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

        'Insert Class Code
        _insert()


        If Me.btnAdd.Visible = False Then
            Me.btnAdd.Visible = True
        End If
    End Sub

    Private Sub _insert()
        Try
            DataSource(String.Format("INSERT INTO `schlmgt_tpc`.`subject_class_details`
                                                (`count`,
                                                 `code`)
                                    VALUES ('" & count & "',
                                            '" & txtcode.Text & "');"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtItem_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyUp
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
        txtname.Focus()
    End Sub

    Private Sub txtroom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtroom.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtroom.SelectedItem, DataRowView)
            Me.txtroom_id.Text = drv.Item("SysPK_Item").ToString
        Catch ex As Exception
            Me.txtroom_id.Text = ""
        End Try
    End Sub

    Private Sub txtclass_time_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtclass_time.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtclass_time.SelectedItem, DataRowView)
            Me.txtclass_timing_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtclass_timing_id.Text = ""
        End Try
    End Sub

    Private Sub txtemployee_name_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemployee_name.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtemployee_name.SelectedItem, DataRowView)
            Me.txtemployee_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtemployee_id.Text = ""
        End Try
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        AssignScheduleName(CheckBox4.Text)
    End Sub


    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        AssignScheduleName(CheckBox7.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AssignScheduleName(CheckBox1.Text)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        AssignScheduleName(CheckBox6.Text)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        AssignScheduleName(CheckBox2.Text)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        AssignScheduleName(CheckBox5.Text)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        AssignScheduleName(CheckBox3.Text)
    End Sub

    Private Sub AssignScheduleName(text As String)
        If txtname.Text.Length > 0 Then
            txtname.Text = txtname.Text & "-" & text
        Else
            txtname.Text = text
        End If
    End Sub

    Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint
        '      GroupBoxPaint(sender, e)
    End Sub

    Private Sub GroupBox2_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox2.Paint
        '    GroupBoxPaint(sender, e)
    End Sub
End Class