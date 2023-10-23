Public Class fmaDepartmentListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "employee_departments"

    Private WithEvents SETUPFORM As fmaDepartmentSetupForm

#Region "Viewers Info"
    Public Sub Attach()


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        'Dim SQL As String = "SELECT SysPk,id,course_id,coursename,name,year_level,school_year,semester "
        'SQL += " FROM " & TABLENAME
        'SQL += " ORDER BY name "
        'SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        Dim SQL As String = "SELECT id,code,name,description,status "
        SQL += " FROM " & TABLENAME
        SQL += " ORDER BY name "
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)

                .DisplayColumns("id").Visible = False

                .DisplayColumns("code").DataColumn.Caption = "CODE"
                .DisplayColumns("code").Width = 200
                .DisplayColumns("code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("name").DataColumn.Caption = "DEPARTMENT NAME"
                .DisplayColumns("name").Width = 400
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("description").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("description").Width = 400
                .DisplayColumns("description").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("description").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 150
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


            End With
        Catch ex As Exception

        End Try



        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(id) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""

#Region "OLD"
        'Try
        '    With tdbViewer.Splits(0)
        '        .DisplayColumns("SysPK").Visible = False
        '        .DisplayColumns("id").Visible = False
        '        .DisplayColumns("id").DataColumn.Caption = "ID"
        '        .DisplayColumns("id").Width = 80
        '        .DisplayColumns("id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


        '        .DisplayColumns("course_id").Visible = False

        '        .DisplayColumns("coursename").DataColumn.Caption = "BATCH NAME"
        '        .DisplayColumns("coursename").Width = 250
        '        .DisplayColumns("coursename").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("coursename").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("name").DataColumn.Caption = "BATCH NAME"
        '        .DisplayColumns("name").Width = 250
        '        .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("year_level").DataColumn.Caption = "YEAR LEVEL"
        '        .DisplayColumns("year_level").Width = 150
        '        .DisplayColumns("year_level").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("year_level").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("school_year").DataColumn.Caption = "SCHOOL YEAR"
        '        .DisplayColumns("school_year").Width = 150
        '        .DisplayColumns("school_year").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("school_year").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("semester").DataColumn.Caption = "SEMESTER"
        '        .DisplayColumns("semester").Width = 120
        '        .DisplayColumns("semester").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("semester").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
        '    End With
        'Catch ex As Exception

        'End Try

        'If MeData.Rows.Count > 0 Then
        '    MeData = Nothing
        '    SQL = "SELECT count(SysPK) as count"
        '    SQL += " FROM " & TABLENAME
        '    MeData = clsDBConn.ExecQuery(SQL)

        '    recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        'End If


        'MeData = Nothing
        'Me.txtFilterText.Text = ""
#End Region

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
    End Sub

    Private Sub tdbViewer_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbViewer.FilterChange
        ' Build our filter expression.


        Dim sb As New System.Text.StringBuilder()
        Dim dc As C1.Win.C1TrueDBGrid.C1DataColumn

        For Each dc In Me.tdbViewer.Columns

            If dc.FilterText.Length > 0 Then

                If sb.Length > 0 Then

                    sb.Append(" AND ")

                End If
                If Me.RadioButton1.Checked Then
                    sb.Append((dc.DataField + " = " + "'" + dc.FilterText + "'"))
                Else
                    sb.Append((dc.DataField + " like " + "'%" + dc.FilterText + "%'"))
                End If

                Me.txtFilterText.Text = sb.ToString
            End If

        Next dc



    End Sub

    Private Sub searchFilterText()
        If Me.txtFilterText.Text = "" Then
            Attach()
            Exit Sub
        End If


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        'Dim SQL As String = "SELECT SysPk,id,course_id,coursename,name,year_level,school_year,semester "
        'SQL += " FROM " & TABLENAME
        'SQL += " WHERE " & Me.txtFilterText.Text
        'SQL += " ORDER BY name "

        Dim SQL As String = "SELECT id,code,name,description,status "
        SQL += " FROM " & TABLENAME
        SQL += " WHERE " & Me.txtFilterText.Text
        SQL += " ORDER BY name "
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)


        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").Visible = False
                .DisplayColumns("id").DataColumn.Caption = "ID"
                .DisplayColumns("id").Width = 150
                .DisplayColumns("id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("code").DataColumn.Caption = "CODE"
                .DisplayColumns("code").Width = 150
                .DisplayColumns("code").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("name").DataColumn.Caption = "DEPARTMENT NAME"
                .DisplayColumns("name").Width = 300
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("description").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("description").Width = 300
                .DisplayColumns("description").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("description").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("status").DataColumn.Caption = "STATUS"
                .DisplayColumns("status").Width = 150
                .DisplayColumns("status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(id) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""


#Region "old"
        'Try
        '    With tdbViewer.Splits(0)
        '        .DisplayColumns("SysPK").Visible = False
        '        '.DisplayColumns("id").Visible = False
        '        .DisplayColumns("id").DataColumn.Caption = "ID"
        '        .DisplayColumns("id").Width = 80
        '        .DisplayColumns("id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


        '        .DisplayColumns("course_id").Visible = False

        '        .DisplayColumns("coursename").DataColumn.Caption = "BATCH NAME"
        '        .DisplayColumns("coursename").Width = 250
        '        .DisplayColumns("coursename").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("coursename").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("name").DataColumn.Caption = "BATCH NAME"
        '        .DisplayColumns("name").Width = 250
        '        .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("year_level").DataColumn.Caption = "YEAR LEVEL"
        '        .DisplayColumns("year_level").Width = 150
        '        .DisplayColumns("year_level").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("year_level").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
        '        'school_year,semester 
        '        .DisplayColumns("school_year").DataColumn.Caption = "SCHOOL YEAR"
        '        .DisplayColumns("school_year").Width = 150
        '        .DisplayColumns("school_year").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("school_year").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        '        .DisplayColumns("semester").DataColumn.Caption = "SEMESTER"
        '        .DisplayColumns("semester").Width = 120
        '        .DisplayColumns("semester").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        '        .DisplayColumns("semester").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
        '    End With
        'Catch ex As Exception

        'End Try

        'If MeData.Rows.Count > 0 Then
        '    MeData = Nothing
        '    SQL = "SELECT count(SysPK) as count"
        '    SQL += " FROM " & TABLENAME
        '    MeData = clsDBConn.ExecQuery(SQL)

        '    recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        'End If


        'MeData = Nothing
        'Me.txtFilterText.Text = ""
#End Region

    End Sub

    Private Sub tdbViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtFilterText.Text.Length > 0 Then
                btnSearchCondition.PerformClick()
            End If
        End If
    End Sub

    Private Sub GridToTextboxes()
        For Each iControl As Control In FormControls
            Try
                iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception
            End Try
        Next
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaDepartmentSetupForm
            SETUPFORM.OPERATION = "ADD"
            SETUPFORM.ShowDialog()
            SETUPFORM.BringToFront()
        End If


        'Dim frm As New fmaDepartmentSetupForm
        'frm.OPERATION = "ADD"
        'frm.BringToFront()
        'frm.ShowDialog()
        SETUPFORM = Nothing

    End Sub

    Private Sub SETUPFORM_DB_MODIFIED() Handles SETUPFORM.DB_MODIFIED
        Attach()
    End Sub

    Private Sub SETUPFORM_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles SETUPFORM.Deactivate
        SETUPFORM.Show()
        SETUPFORM.BringToFront()
    End Sub


    Private Sub SETUPFORM_SETUP_CLOSED() Handles SETUPFORM.SETUP_CLOSED
        SETUPFORM = Nothing
    End Sub

    Private Sub PgCount_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PgCount.ValueChanged
        Attach()
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click

        txtFrom.Text = CInt(txtFrom.Text) + 10
        txtTo.Text = CInt(txtFrom.Text) + 10

    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click

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


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = tdbViewer.Columns.Item("id").Value
        Catch ex As Exception

        End Try


        'Dim SQLEX As String = "SELECT COUNT(batch_id) 'count' FROM subjects "
        'SQLEX += " WHERE batch_id='" & ITEMSYSPK & "'"

        'Dim MeData As DataTable
        'MeData = clsDBConn.ExecQuery(SQLEX)

        'If MeData.Rows.Count > 0 Then
        '    Dim count As Integer = CInt(MeData.Rows(0).Item("count").ToString)

        '    If count > 0 Then
        '        MsgBox("Cannot Delete Batch, there are Subjects/Students under it.", MsgBoxStyle.Critical)
        '        Exit Sub
        '    End If
        'End If


        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            '        deleteSelectedItem()
            _delete(ITEMSYSPK)
        End If
    End Sub

    Private Sub _delete(iTEMSYSPK As String)

        Try
            DataSource(String.Format("DELETE
                                        FROM `employee_departments`
                                        WHERE `id` = '" & iTEMSYSPK & "';"))

            MessageBox.Show("Record Deleted...", "Successfully!")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub deleteSelectedItem()

        Dim ITEMSYSPK As String = ""

        Try
            ITEMSYSPK = tdbViewer.Columns.Item(0).Value
        Catch ex As Exception

        End Try

        If ITEMSYSPK <> "" Then
            Dim DELETESTR As String = "DELETE FROM " & TABLENAME
            DELETESTR += " WHERE pk_code='" & ITEMSYSPK & "'"

            If clsDBConn.Execute(DELETESTR) Then
                MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
                Attach()
            End If
        End If


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaDepartmentSetupForm
            SETUPFORM.OPERATION = "EDIT"

            Dim row = tdbViewer.Row
            SETUPFORM.id = tdbViewer(row, "id").ToString
            SETUPFORM.txtcode.Text = tdbViewer(row, "code").ToString
            SETUPFORM.txtname.Text = tdbViewer(row, "name").ToString
            SETUPFORM.txtdescription.Text = tdbViewer(row, "description").ToString

            SETUPFORM.Show()

            SETUPFORM.BringToFront()

        End If
        SETUPFORM = Nothing

        'Me.FormControls = SETUPFORM.clsGroup.FormControls
        'SETUPFORM.btnModify.PerformClick()
        'GridToTextboxes()

    End Sub

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click
        searchFilterText()
    End Sub




    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
        End If
    End Sub

    Private Sub btnTrans_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        Dim SQLEX As String = "SELECT batches.id as 'batchID', course_id , `batches`.`name`"
        SQLEX += " , `courses`.`course_name`"
        SQLEX += " FROM  `SchoolMGT2016-2017`.`batches`"
        SQLEX += " INNER JOIN `SchoolMGT2016-2017`.`courses` "
        SQLEX += " ON (`batches`.`course_id` = `courses`.`id`)"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            For nCtr As Integer = 0 To MeData.Rows.Count - 1
                Dim id As String = MeData.Rows(nCtr).Item("batchID").ToString
                Dim course_id As String = MeData.Rows(nCtr).Item("course_id").ToString
                Dim course_name As String = MeData.Rows(nCtr).Item("course_name").ToString

                Dim SysPK As String = System.Guid.NewGuid.GetHashCode

                Dim SQLUP As String = "Update batches SET "
                SQLUP += String.Format(" SysPk='{0}', coursename='{1}'", SysPK, course_name)
                SQLUP += String.Format(" WHERE batches.id='{0}'", id)

                clsDBConn.ExecuteSilence(SQLUP)
            Next
        End If
    End Sub

    Private Sub tdbViewer_Click(sender As Object, e As EventArgs) Handles tdbViewer.Click

    End Sub
End Class