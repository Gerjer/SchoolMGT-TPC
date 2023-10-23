Imports SchoolMGT
Public Class fmaSubjectScheduleListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "subject_class_schedule"

    Private WithEvents SETUPFORM As fmaSubjectScheduleSetupForm 'frmSubjectScheduleSetup 
    Public subject_code As String

#Region "Viewers Info"
    Private Sub Attach()


        tdbViewer.DataSource = Nothing

        Dim SQL As String = "SELECT SysPK_Item,name,code,subject_id,class_timing_id,class_time"
        SQL += " ,employee_id,employee_name,room_id,room,day_schedule_id,day"
        SQL += " FROM " & TABLENAME
        SQL += " WHERE subject_id='" & txtSubjectID.Text & "'"
        SQL += " ORDER BY subject_id "

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK_Item").Visible = False

                .DisplayColumns("name").DataColumn.Caption = "SCHEDULE"
                .DisplayColumns("name").Width = 300
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("code").DataColumn.Caption = "CODE"
                .DisplayColumns("code").Width = 200
                .DisplayColumns("code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("subject_id").Visible = False
                .DisplayColumns("class_timing_id").Visible = False
                .DisplayColumns("class_time").Visible = False
                '      .DisplayColumns("class_time").Visible = False

                .DisplayColumns("employee_id").Visible = False
                .DisplayColumns("employee_name").DataColumn.Caption = "INSTRUCTOR"
                .DisplayColumns("employee_name").Width = 250
                .DisplayColumns("employee_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("employee_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("room_id").Visible = False
                .DisplayColumns("room").DataColumn.Caption = "ROOM"
                .DisplayColumns("room").Width = 100
                .DisplayColumns("room").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("room").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("day_schedule_id").Visible = False
                .DisplayColumns("day").Visible = False


            End With
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Detach()

    End Sub
#End Region

    Private Sub fmaDepartmentViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Detach()
        RaiseEvent FORM_CLOSING()
    End Sub

    Private Sub fmaDepartmentViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Attach()

        If tdbViewer.RowCount > 0 Then
            checkSubject()
        End If

        txtclasscode.Text = "CC-" & txtBatchID.Text & "-" & subject_code

    End Sub

    Private Sub checkSubject()
        Dim SQLEX As String = "SELECT elective_group_id FROM subjects"
        SQLEX += " WHERE id='" & Me.txtSubjectID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                If IsDBNull(MeData.Rows(0).Item("elective_group_id")) Then
                    btnAdd.Enabled = False
                End If

            Catch ex As Exception

            End Try
        Else
            btnAdd.Enabled = True
        End If


    End Sub


    Private Sub tdbViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If tdbViewer.RowCount > 0 Then
                Me.GridToTextboxes()
            End If
            ProcessFilterText(MeData, tdbViewer)
        End If
    End Sub

    Private Sub GridToTextboxes()
        Try
            For Each iControl As Control In FormControls
                Try
                    iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception

        End Try

        'Me.Close()
    End Sub


    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.tdbViewer.FilterBar Then
            Me.tdbViewer.FilterBar = False
        Else
            Me.tdbViewer.FilterBar = True
        End If
    End Sub

    Public ClassCode As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaSubjectScheduleSetupForm 'frmSubjectScheduleSetup '
            SETUPFORM.SUBJECTID = Me.txtSubjectID.Text
            SETUPFORM._class_code = Me.txtclasscode.Text
            SETUPFORM._class_name = Me.txtclassname.Text
            SETUPFORM._batchID = Me.txtBatchID.Text
            SETUPFORM.OPERATION = "ADD"
            SETUPFORM.subject_code = subject_code
        End If

        SETUPFORM.Show(Me)

    End Sub

    Private Sub SETUPFORM_DB_MODIFIED() Handles SETUPFORM.DB_MODIFIED
        Attach()
        checkSubject()
    End Sub

    Private Sub SETUPFORM_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles SETUPFORM.Deactivate
        SETUPFORM.Show()
        SETUPFORM.BringToFront()
    End Sub


    Private Sub SETUPFORM_SETUP_CLOSED() Handles SETUPFORM.SETUP_CLOSED
        SETUPFORM = Nothing
    End Sub

    Private Sub PgCount_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Attach()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Me.tdbViewer.FilterBar Then
            Me.tdbViewer.FilterBar = False
            grpBoxSearch.Visible = False
            btnSearch.Text = "Show Filter Bar"
        Else
            Me.tdbViewer.FilterBar = True
            grpBoxSearch.Visible = True
            btnSearch.Text = "Hide Filter Bar"
            Try
                Me.tdbViewer.Col = 1
                With tdbViewer.Splits(0)
                    .FilterActive = True
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Dim point1 As Point

        If e.Button = Windows.Forms.MouseButtons.Right Then

            point1 = Windows.Forms.Cursor.Position

            Dim pt As Point = tdbViewer.PointToClient(point1)
            CMenuStripOperations.Show(tdbViewer, pt)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub deleteSelectedItem()

        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = tdbViewer.Columns.Item(0).Value
        Catch ex As Exception

        End Try

        If ITEMSYSPK <> "" Then
            Dim DELETESTR As String = "DELETE FROM " & TABLENAME
            DELETESTR += " WHERE SysPK_Item='" & ITEMSYSPK & "'"

            If clsDBConn.Execute(DELETESTR) Then
                MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
                Attach()
            End If
        End If


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaSubjectScheduleSetupForm 'frmSubjectScheduleSetup 
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        With SETUPFORM
            .txtsubject_id.Text = Me.txtSubjectID.Text
        End With
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()

    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            deleteSelectedItem()
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem1.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaSubjectScheduleSetupForm 'frmSubjectScheduleSetup   '
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()
    End Sub

End Class