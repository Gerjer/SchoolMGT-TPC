Imports System.Threading
Imports System.ComponentModel

Public Class fmaGroupedCoursesForm

    Dim WithEvents GROUPCOURSE As New fmaGroupepCourseEntryForm


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        GROUPCOURSE.ShowDialog()
    End Sub

    Private Sub fmaGroupedCoursesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGroupedCourses()
        btnAdd.Visible = False
    End Sub

    Private Sub getGroupedCourses()
        Dim SQLEX As String = "SELECT id,name from coursegroup"
       

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourse.DataSource = MeData

        cmbCourse.ValueMember = "id"
        cmbCourse.DisplayMember = "name"
        cmbCourse.Text = ""
        txtCourseID.Text = ""

    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCourseID.Text = ""
        End Try
    End Sub

    Private Sub GROUPCOURSE_OK_CLICK() Handles GROUPCOURSE.OK_CLICK
        If GROUPCOURSE.DialogResult = Windows.Forms.DialogResult.OK Then
            With GROUPCOURSE
                Dim name As String = .txtCGroupName.Text

                Dim SQLIN As String = "INSERT INTO coursegroup(name) VALUES('" & name & "')"
                If clsDBConn.Execute(SQLIN) Then
                    getGroupedCourses()
                    btnAdd.Visible = False
                    btnEdit.Visible = False
                    btnDelete.Visible = False
                    lblCourse.Visible = False
                    cmbCourseName.Visible = False
                    txtOrder.Visible = False
                    lblOrder.Visible = False

                End If

            End With
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tick As Integer = CInt(lblTimer.Text)

        lblTimer.Text = tick + 1

        If tick = 1 Then
            Timer1.Enabled = False
            lblTimer.Text = "0"
            displaySubGroup()
            lblStatus.Text = "Done."
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
            pbxSearch.Visible = False
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        groupcoursesID.Text = ""
        If txtCourseID.Text.Length > 0 Then
            btnAdd.Visible = False
            pbxSearch.Visible = True
            Timer1.Enabled = True
            rollingSpinner.Visible = True
            stillSpinner.Visible = False
            lblStatus.Text = "Searching.."
            lblCourse.Visible = False
            cmbCourseName.Visible = False
            txtOrder.Visible = False
            lblOrder.Visible = False
        Else
            Timer1.Enabled = False
            lblTimer.Text = "0"
            pbxSearch.Visible = False
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
            pbxSearch.Visible = False
            lblStatus.Text = ""
            btnAdd.Visible = False
        End If
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnAdd.Text = "ADD"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub getCourseList()
        Dim SQLEX As String = "SELECT id, CONCAT(course_name,'-',section_name) 'course_name' FROM courses"
        SQLEX += " ORDER BY course_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourseName.DataSource = MeData

        cmbCourseName.ValueMember = "id"
        cmbCourseName.DisplayMember = "course_name"
        cmbCourseName.Text = ""
        txtCourseNameID.Text = ""


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "ADD" Then
            btnAdd.Text = "ADD TO GROUP"
            lblCourse.Visible = True
            cmbCourseName.Visible = True
            txtOrder.Visible = True
            lblOrder.Visible = True
            getCourseList()
        ElseIf btnAdd.Text = "ADD TO GROUP" Then
            addToGroup()
            btnAdd.Text = "ADD"
            'lblCourse.Visible = False
            'cmbCourseName.Visible = False
            'txtOrder.Visible = False
            'lblOrder.Visible = False
        End If
    End Sub

    Private Sub cmbCourseName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourseName.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourseName.SelectedItem, DataRowView)
            Me.txtCourseNameID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCourseNameID.Text = ""
        End Try
    End Sub

    Private Sub addToGroup()

        Dim SQLIN As String = "INSERT INTO group_courses(coursegroup_id,course_id,course_name,ordernum)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}','{1}',", txtCourseID.Text, txtCourseNameID.Text)
        SQLIN += String.Format("'{0}','{1}')", cmbCourseName.Text, txtOrder.Text)

        If clsDBConn.Execute(SQLIN) Then
            displaySubGroup()
        End If

    End Sub

    Private Sub displaySubGroup()
        tdbViewer.DataSource = Nothing

        Dim SQLEX As String = "SELECT id,coursegroup_id,course_id,course_name,ordernum FROM group_courses"
        SQLEX += " WHERE coursegroup_id='" & txtCourseID.Text & "'"
        SQLEX += " ORDER BY ordernum"

        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").Visible = False
                .DisplayColumns("coursegroup_id").Visible = False
                .DisplayColumns("course_id").Visible = False

                .DisplayColumns("course_name").DataColumn.Caption = "CATEGORY"
                .DisplayColumns("course_name").Width = 250
                .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("ordernum").DataColumn.Caption = "ORDER"
                .DisplayColumns("ordernum").Width = 100
                .DisplayColumns("ordernum").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("ordernum").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center


            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCourseNameID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseNameID.TextChanged
        If txtCourseNameID.Text.Length > 0 Then
            'displaySubGroup()
        Else
            'tdbViewer.DataSource = Nothing
        End If
    End Sub




    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        lblCourse.Visible = True
        cmbCourseName.Visible = True
        txtOrder.Visible = True
        lblOrder.Visible = True
        btnEdit.Visible = True
        btnEdit.Text = "Edit"
        btnDelete.Visible = True
        groupcoursesID.Text = tdbViewer.Columns.Item(0).Value
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            getCourseList()
            btnEdit.Visible = True
            btnEdit.Text = "Modify"
            groupcoursesID.Text = tdbViewer.Columns.Item(0).Value
            Dim courseID As Integer = CInt(tdbViewer.Columns.Item(2).Value)
            txtCourseNameID.Text = courseID
            cmbCourseName.Text = tdbViewer.Columns.Item(3).Value

            txtOrder.Value = tdbViewer.Columns.Item(4).Value
        ElseIf btnEdit.Text = "Modify" Then
            Dim SQLUP As String = "UPDATE group_courses SET "
            SQLUP += " course_id = '" & txtCourseNameID.Text & "'"
            SQLUP += " , course_name = '" & cmbCourseName.Text & "'"
            SQLUP += " , ordernum = '" & txtOrder.Value & "'"
            SQLUP += " WHERE id = '" & groupcoursesID.Text & "'"

            If clsDBConn.Execute(SQLUP) Then
                displaySubGroup()
            End If

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim ITEMSYSPK As String = ""

            Try
                ITEMSYSPK = tdbViewer.Columns.Item(0).Value
            Catch ex As Exception

            End Try

            If ITEMSYSPK <> "" Then
                Dim DELETESTR As String = "DELETE FROM group_courses"
                DELETESTR += " WHERE id='" & ITEMSYSPK & "'"

                If clsDBConn.Execute(DELETESTR) Then
                    MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
                    displaySubGroup()
                End If
            End If
        End If
    End Sub
End Class