Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class fmaBatchesSetupForm

    Public WithEvents clsGroup As clsData

    Public Event DB_MODIFIED()
    Public Event SETUP_CLOSED()

    Public OPERATION As String = ""

#Region "Classes"
    Private Sub AttachClasses()
        clsGroup = New clsData(Me.txtSysPK, clsDBConn)
        clsGroup.AttachUserPK = Me.txtid

        clsGroup.AttachControl = Me.txtcoursename
        clsGroup.AttachControl = Me.txtcourse_id
        clsGroup.AttachControl = Me.txtname
        clsGroup.AttachControl = Me.txtyear_level
        clsGroup.AttachControl = Me.txtschool_year
        clsGroup.AttachControl = Me.txtsemester
        clsGroup.AttachControl = Me.txtgrade_dist_from
        clsGroup.AttachControl = Me.txtgrade_dist_to

        getCourseGrade()
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

        If OPERATION = "ADD" Then
            Dim yearInit As Integer = 1900
            yearInit = CInt(Date.Now.Year)
            txtschool_year1.Value = yearInit
            txtschool_year2.Value = yearInit
        End If

        year_level()

        Me.AttachClasses()

        If Me.OPERATION = "ADD" Then
            Me.btnAdd.PerformClick()
        ElseIf Me.OPERATION = "EDIT" Then
            Me.btnModify.PerformClick()
        End If
        ''
    End Sub

    Public Sub year_level()

        txtyear_level.DataSource = loadYearLevel()
        txtyear_level.ValueMember = "ID"
        txtyear_level.DisplayMember = "name"
        txtyear_level.SelectedIndex = -1

    End Sub

    Private Function loadYearLevel() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
            year_level.id AS ID,
            year_level.year_level AS `Name`
            FROM
            year_level
            "))
        Return dt

    End Function

    Private Sub getCourseGrade()
        '     Dim SQLEX As String = "SELECT id,concat(code,' - ',course_name) as 'course_name',code from courses"
        Dim SQLEX As String = "SELECT id,course_name,code from courses"
        SQLEX += " WHERE is_deleted <> 1 GROUP BY course_name "
        SQLEX += " ORDER BY course_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        txtcoursename.DataSource = MeData

        txtcoursename.ValueMember = "id"
        txtcoursename.DisplayMember = "course_name"

        txtcoursename.SelectedIndex = -1
        txtcourse_id.Text = ""
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
        If Me.txtname.Text = "" Or Me.txtsemester.Text = "" Then
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

    Dim _dummyname As String
    Dim selectedControls As Boolean = False
    Dim _course As String

    Private Sub txtcoursename_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcoursename.SelectedIndexChanged

        '    If OPERATION = "ADD" Then
        Try
            Dim drv As DataRowView = DirectCast(txtcoursename.SelectedItem, DataRowView)
            Me.txtcourse_id.Text = drv.Item("id").ToString
            _course = drv.Item("code").ToString & " - "
            Me.txtname.Text = drv.Item("code").ToString & " - "
            _dummyname = Me.txtname.Text
        Catch ex As Exception
            Me.txtcourse_id.Text = ""
        End Try

    End Sub

    Private Function getSemister(text As String) As String
        Dim str As String = ""
        If text.Contains("1ST") Then
            str = "1st Sem"
        ElseIf text.Contains("2ND") Then
            str = "2nd Sem"
        Else text.Contains("SUMMER")
            str = "Summer"
        End If
        Return str
    End Function

    Private Sub txtsemester_Validating(sender As Object, e As CancelEventArgs) Handles txtsemester.Validating

        Dim txt As TextBox = DirectCast(sender, TextBox)

        '     If OPERATION = "ADD" Then
        If txt.Text.Contains("1ST") Then
            txtname.Text = txtname.Text & "1st Sem"
        ElseIf txt.Text.Contains("2ND") Then
            txtname.Text = txtname.Text & "2nd Sem"
        ElseIf txt.Text.Contains("SUMMER") Then
            txtname.Text = txtname.Text & "Summer"
        Else
            If txt.Text.Length > 0 Then
                txtname.Text = txtname.Text & " " & txt.Text
            End If
        End If

        _dummyname = txtname.Text
    End Sub

    Public school_year As String
    Private Sub txtschool_year1_ValueChanged(sender As Object, e As EventArgs) Handles txtschool_year1.ValueChanged

        txtname.Text = ""
        school_year = ""
        txtschool_year.Text = ""

        '   school_year = "( " & txtschool_year1.Value & " - " & txtschool_year2.Value & " )"
        school_year = "(" & txtschool_year1.Value & ")"
        '    txtschool_year.Text = txtschool_year1.Value & " - " & txtschool_year2.Value
        txtschool_year.Text = txtschool_year1.Value
        txtname.Text = _dummyname & " " & school_year

    End Sub

    Private Sub txtschool_year2_ValueChanged(sender As Object, e As EventArgs) Handles txtschool_year2.ValueChanged

        txtname.Text = ""
        school_year = ""
        txtschool_year.Text = ""

        school_year = "( " & txtschool_year1.Value & " - " & txtschool_year2.Value & " )"
        txtschool_year.Text = txtschool_year1.Value & " - " & txtschool_year2.Value
        txtname.Text = _dummyname & " " & school_year

    End Sub

    Private Sub txtname_Validating(sender As Object, e As CancelEventArgs) Handles txtname.Validating
        selectedControls = True
        _dummyname = txtname.Text
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim _semister As String = ""
        If selectedControls Then
            txtname.Text = _dummyname
        Else
            If OPERATION = "ADD" Then
                If txtyear_level.Text.Length > 0 Then
                    If txtsemester.Text.Length > 0 Then
                        _semister = getSemister(txtsemester.Text)
                        txtname.Text = _course & str_year & " " & _semister & " " & school_year
                    Else
                        txtname.Text = _course & str_year & " " & " " & school_year
                    End If
                Else
                    txtname.Text = _course & txtsemester.Text & " " & " " & school_year
                End If

            End If
        End If

    End Sub

    Private Sub fmaBatchesSetupForm_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        Dim str As String = ""
        str = convertTxt(txtyear_level.Text)
        txtname.Text = txtname.Text & str & " "
    End Sub

    Dim CategoryCollege As Boolean
    Dim dummy_year_level As String
    Dim str_year As String = ""

    Private Sub txtyear_level_Validating(sender As Object, e As CancelEventArgs)

        str_year = convertTxt(txtyear_level.Text)

        txtname.Text = txtname.Text & " " & str_year & " "

    End Sub

    Private Function convertTxt(text As String) As String
        Dim str As String = ""
        If text.Contains("1ST") Then
            str = "1st Year"
        ElseIf text.Contains("2ND") Then
            str = "2nd Year"
        ElseIf text.Contains("3RD") Then
            str = "3rd Year"
        ElseIf text.Contains("4TH") Then
            str = "4th Year"
        ElseIf text.Contains("5TH") Then
            str = "5th Year"
        Else
            str = text
        End If
        Return str
    End Function


    Private Function getCategory(text As String) As Boolean
        Dim value As Integer = DataObject(String.Format("SELECT courses.category_id FROM courses WHERE courses.id = " & text & ""))
        If value = 13 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub txtyear_level_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtyear_level.SelectedValueChanged

        str_year = convertTxt(txtyear_level.Text)
        If OPERATION = "EDIT" Then
            txtname.Text = txtname.Text
        Else
            txtname.Text = txtname.Text & " " & str_year & " "
        End If



    End Sub
End Class