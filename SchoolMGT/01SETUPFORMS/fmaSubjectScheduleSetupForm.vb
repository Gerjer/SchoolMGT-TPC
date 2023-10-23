Imports DevComponents.DotNetBar.Controls
Imports MySql.Data.MySqlClient

Public Class fmaSubjectScheduleSetupForm

    Public SUBJECTID As String = ""

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""
    Public subject_code As String
    Public count As Integer

    Public _class_code As String
    Public _class_name As String
    Public _batchID As Integer

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK_Item, clsDBConn)
        clsGroup.AttachUserPK = Me.txtcode

        clsGroup.AttachControl = Me.txtcode
        clsGroup.AttachControl = Me.txtday
        clsGroup.AttachControl = Me.txtsubject_id
        clsGroup.AttachControl = Me.txtroom
        clsGroup.AttachControl = Me.txtroom_id
        clsGroup.AttachControl = Me.txtclass_time
        clsGroup.AttachControl = Me.txtclass_timing_id
        clsGroup.AttachControl = Me.txtemployee_name
        clsGroup.AttachControl = Me.txtemployee_id
        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtday_schedule_id

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
        Me.txtclass_time.SelectedIndex = 0
        Me.txtclass_timing_id.Text = ""

        MeData = Nothing
        SQL = "SELECT employees.id,CONCAT(last_name, ', ', first_name, ' ', middle_name ) AS 'EMPNAME'"
        SQL += " FROM employees"
        SQL += " INNER JOIN person ON (employees.person_id = person.person_id) "
        SQL += " INNER JOIN employee_positions ON (employee_positions.id =employees.employee_position_id ) "
        SQL += " WHERE person.status_type_id = 1 AND person.end_time IS NULL AND person.person_type_id = 1"
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

    Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AttachClasses()
        Me.txtsubject_id.Text = Me.SUBJECTID

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If

        generateAutocode()


        '  Me.txtcode.Text = fmaSubjectScheduleListForm.ClassCode
    End Sub

    Private Sub generateAutocode()
        count = getAutoNumber()
        Me.txtcode.Text = "SSC-" & Format(count, "00000")
    End Sub

    Private Function getAutoNumber() As String
        Dim AutoNumber As Integer = DataObject(String.Format("SELECT
                CASE WHEN `count` IS NULL THEN 1 ELSE `count` + 1 END AS 'count'
                FROM(
	                    SELECT
	                    MAX(COUNT)AS 'count'
	                    FROM
	                    subject_class_details
	                    INNER JOIN subject_class_code ON subject_class_code.subject_class_code = subject_class_details.subject_class_code
	                    WHERE
	                    subject_class_code.subject_class_code = '" & _class_code & "'
                )A"))

        Return AutoNumber
#Region "old"
        'Select Case
        '              Case WHEN `Count` IS NULL THEN 1 ELSE `Count` + 1 END AS 'Count'
        '            FROM(
        '            SELECT
        '              MAX(`count`) AS 'Count'
        '            FROM `subject_class_details` WHERE 
        '            )A;
#End Region
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clsGroup_AddButtonClick() Handles clsGroup.AddButtonClick
        Me.txtsubject_id.Text = Me.SUBJECTID
        getDropDownList()
        DayNameDropDownList()
        generateAutocode()
        Panel1.Enabled = True
    End Sub

    Private Sub DayNameDropDownList()

        txtday.DataSource = getDayName()
        txtday.ValueMember = "ID"
        txtday.DisplayMember = "Name"
        txtday.SelectedIndex = -1

    End Sub

    Private Function getDayName() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
            day_schedule_id AS 'ID',
            day_schedule.`day_name` AS `Name`
            FROM
            day_schedule"))
        Return dt
    End Function

    Private Sub clsGroup_AfterDelete() Handles clsGroup.AfterDelete
        RaiseEvent DB_MODIFIED()

    End Sub

    Private Sub clsGroup_AfterRecordSave() Handles clsGroup.AfterRecordSave
        RaiseEvent DB_MODIFIED()
        If ErrorSaving = True Then
            _insert()
        End If

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.Close()
        End If


        If Me.btnAdd.Visible = False Then
            Panel1.Enabled = False
            Me.btnAdd.Visible = True
        End If
        txtcode.Text = ""

    End Sub


    Private Sub txtItem_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtday.Focus()
            txtday.SelectAll()
        End If
    End Sub

    Dim ErrorSaving As Boolean = True
    Private Sub clsGroup_BeforeRecordSave() Handles clsGroup.BeforeRecordSave

        If txtday.Text.Length = 0 Then
            MsgBox("Display Name should not be blank.", MsgBoxStyle.Critical)
            ErrorSaving = False
            Exit Sub
        End If
        If txtday.Text = "" Then
            MsgBox("Required fields Day Schedule.", MsgBoxStyle.Critical)
            ErrorSaving = False
            Exit Sub
        End If
        If txtclass_time.Text = "" Then
            MsgBox("Required fields Time Schedule.", MsgBoxStyle.Critical)
            ErrorSaving = False
            Exit Sub
        End If
        If txtroom.Text = "" Then
            MsgBox("Required Room Time Schedule.", MsgBoxStyle.Critical)
            ErrorSaving = False
            Exit Sub
        End If
        If txtemployee_name.Text = "" Then
            MsgBox("Required Instructor Schedule.", MsgBoxStyle.Critical)
            ErrorSaving = False
            Exit Sub
        End If
        ErrorSaving = True
        txtday_schedule_id.Text = txtday.SelectedValue

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Panel1.Enabled = True
        txtcode.Focus()
        generateAutocode()
        '    txtname.Focus()

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

        'Try
        '    Dim drv As DataRowView = DirectCast(txtclass_time.SelectedItem, DataRowView)
        '    Me.txtclass_timing_id.Text = drv.Item("id").ToString
        'Catch ex As Exception
        '    Me.txtclass_timing_id.Text = ""
        'End Try

        'txtname.Text = txtname.Text & " " & txtclass_time.Text
        'If txtfloor.Text.Length > 0 Then
        '    If txtLocation.Text.Length > 0 Then
        '        txtroom.Text = txtroom.Text & ", " & txtfloor.Text & ", " & txtLocation.Text
        '    Else
        '        txtroom.Text = txtroom.Text & ", " & txtfloor.Text
        '    End If
        'Else
        '    txtroom.Text = txtroom.Text & ", " & txtLocation.Text
        'End If


    End Sub

    Private Sub txtemployee_name_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemployee_name.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(txtemployee_name.SelectedItem, DataRowView)
            Me.txtemployee_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtemployee_id.Text = ""
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtday.Text.Length > 0 Then
            '          _insert()
        End If

    End Sub
    Private Sub _insert()


        Try
            If Not ClassCodeExist(_class_code) Then
                DataSource(String.Format("INSERT INTO `subject_class_code`
                                        (
                                         `subject_class_code`,
                                         `subject_class_name`,
                                         `batch_id`)
                                    VALUES (
                                            '" & _class_code & "',
                                            '" & _class_name & "',
                                            '" & _batchID & "');"))
            End If

        Catch ex As Exception

        End Try



        Try
            DataSource(String.Format("INSERT INTO `subject_class_details`
                                                (`count`,
                                                 `subject_schedule_code`,
                                                 subject_class_code)
                                    VALUES ('" & count & "',
                                            '" & txtcode.Text & "',
                                            '" & _class_code & "');"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ClassCodeExist(class_code As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT
subject_class_code.subject_class_code_id
FROM
subject_class_code
WHERE
subject_class_code.subject_class_code = '" & class_code & "'
"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click

        '  txtclass_time.Text = Format(dtpFrom.Value, "h:mm tt") & " - " & Format(dtpTo.Value, "h:mm tt")

        Dim Time = Format(dtpFrom.Value, "h:mm tt") & " - " & Format(dtpTo.Value, "h:mm tt")
        Try
            DataSource(String.Format("INSERT INTO `class_timings`
                                        (`name`,
                                         `start_time`,
                                         `end_time`           
                                         )
                                VALUES ('" & Time & "',
                                        '" & Format(dtpFrom.Value, "HH:mm") & "',
                                        '" & Format(dtpTo.Value, "HH:mm  ") & "'
                                        );"))
        Catch ex As Exception

        End Try

        Dim MeData As New DataTable
        Dim SQL As String = ""

        MeData = Nothing
        SQL = "SELECT id,name FROM class_timings"
        MeData = clsDBConn.ExecQuery(SQL)
        Me.txtclass_time.DataSource = MeData
        Me.txtclass_time.DisplayMember = "name"
        Me.txtclass_time.ValueMember = "id"
        Me.txtclass_time.Text = ""
        Me.txtclass_time.SelectedIndex = -1
        Me.txtclass_timing_id.Text = ""

    End Sub

    Private Sub txtclass_time_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles txtclass_time.SelectionChangeCommitted


        Try
            Dim drv As DataRowView = DirectCast(txtclass_time.SelectedItem, DataRowView)
            Me.txtclass_timing_id.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtclass_timing_id.Text = ""
        End Try

        '    txtday.Text = txtname.Text
        '     txtname.Text = txtname.Text & " " & txtclass_time.Text
        '     If txtfloor.Text.Length > 0 Then
        If txtLocation.Text.Length > 0 Then
            txtroom.Text = txtroom.Text & ", " & txtLocation.Text
            ' Else
            '     txtroom.Text = txtroom.Text & ", " & txtfloor.Text
        End If
        '  Else
        '  txtroom.Text = txtroom.Text & ", " & txtLocation.Text
        '  End If

        getDuplicateSchedule()
    End Sub

    Private Sub clsGroup_EditButtonClick() Handles clsGroup.EditButtonClick
        getDropDownList()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New MasterSetup
        frm.SetupName = txtday.Tag
        frm.tableName = txtday.CommandParameter
        frm.FieldName = txtday.AccessibleDescription
        frm.BringToFront()
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.Cancel Then
            frm.Close()
        End If

        DayNameDropDownList()
    End Sub

    Private Sub txtname_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles txtday.SelectionChangeCommitted

        'Try
        '    Dim drv As DataRowView = DirectCast(txtday.SelectedItem, DataRowView)
        '    txtname.Text = drv.Item("Name").ToString
        'Catch ex As Exception
        '    Me.txtclass_timing_id.Text = ""
        'End Try


        getDuplicateSchedule()
    End Sub

    Private Sub getDuplicateSchedule()

        txtname.Text = getDisplayName(txtday.SelectedValue, txtclass_time.SelectedValue)

        If txtday.SelectedIndex > -1 And txtclass_time.SelectedIndex > -1 And txtroom.SelectedIndex > -1 Then
            If ScheduleDuplicate(txtday.SelectedValue, txtclass_time.SelectedValue, txtroom.SelectedValue) Then
                MsgBox("Duplicate Schedule", MsgBoxStyle.Information, "RECORD FOUND")
                Exit Sub
            End If
        End If
        '      txtname.Text = DaySchedule
    End Sub

    Dim DaySchedule As String = ""

    Private Function getDisplayName(day_name_id As Integer, class_time_id As Integer) As String


        Dim DayName As String = DataObject(String.Format("SELECT day_name FROM day_schedule WHERE day_schedule_id = '" & day_name_id & "'"))
        Dim Time As String = DataObject(String.Format("SELECT `name` FROM class_timings WHERE id = '" & class_time_id & "'"))

        DaySchedule = DayName & " " & Time
        Return DaySchedule
    End Function

    Private Function ScheduleDuplicate(dayschduleID As Object, timescheduleID As Object, roomID As Object) As Boolean
        Dim id As String = ""
        id = DataObject(String.Format("SELECT
                        subject_class_schedule.SysPK_Item
                        FROM
                        subject_class_schedule
                        WHERE
                        subject_class_schedule.day_schedule_id = '" & dayschduleID & "' AND
                        subject_class_schedule.class_timing_id = '" & timescheduleID & "' AND
                        subject_class_schedule.room_id = '" & roomID & "'
                        "))
        If id <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtroom_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles txtroom.SelectionChangeCommitted
        getDuplicateSchedule()
    End Sub

    'Private Sub txtname_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtname.SelectedValueChanged
    '    txtname.Text = DaySchedule
    'End Sub
End Class