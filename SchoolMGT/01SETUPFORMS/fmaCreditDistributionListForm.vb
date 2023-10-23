﻿Public Class fmaCreditDistributionListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

    Public Event ADD_BUTTON_CLICK()
    Public Event FORM_CLOSING()

    Private TABLENAME As String = "credit_distribution"

    Private WithEvents SETUPFORM As fmaCreditDistributionSetupForm

#Region "Viewers Info"
    Private Sub Attach()


        tdbViewer.DataSource = Nothing
        Dim LimitValue As Integer = PgCount.Value


        Dim SQL As String = "SELECT id,SysPK,name,unitreq,unitearned,course_id,course_name "
        SQL += " FROM " & TABLENAME
        SQL += " ORDER BY id "
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").DataColumn.Caption = "ID"
                .DisplayColumns("id").Width = 100
                .DisplayColumns("id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center



                .DisplayColumns("SysPK").Visible = False


                .DisplayColumns("name").DataColumn.Caption = "SUBJECT DESCRIPTION"
                .DisplayColumns("name").Width = 500
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("unitreq").DataColumn.Caption = "UNIT/S REQUIRED"
                .DisplayColumns("unitreq").DataColumn.NumberFormat = "#.00"
                .DisplayColumns("unitreq").Width = 300
                .DisplayColumns("unitreq").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("unitreq").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("unitearned").DataColumn.Caption = "UNIT/S EARNED"
                .DisplayColumns("unitearned").DataColumn.NumberFormat = "#.00"
                .DisplayColumns("unitearned").Width = 300
                .DisplayColumns("unitearned").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("unitearned").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("course_id").DataColumn.Caption = "CID"
                .DisplayColumns("course_id").Width = 90
                .DisplayColumns("course_id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("course_name").DataColumn.Caption = "PROGRAM"
                .DisplayColumns("course_name").Width = 150
                .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(SysPK) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""
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


        Dim SQL As String = "SELECT id,SysPK,name,unitreq,unitearned,course_id,course_name "
        SQL += " FROM " & TABLENAME
        SQL += " WHERE " & Me.txtFilterText.Text
        SQL += " ORDER BY id "
        SQL += String.Format(" LIMIT {0},{1}", 0, LimitValue)

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").DataColumn.Caption = "ID"
                .DisplayColumns("id").Width = 100
                .DisplayColumns("id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center



                .DisplayColumns("SysPK").Visible = False


                .DisplayColumns("name").DataColumn.Caption = "SUBJECT DESCRIPTION"
                .DisplayColumns("name").Width = 250
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("unitreq").DataColumn.Caption = "UNIT/S REQUIRED"
                .DisplayColumns("unitreq").DataColumn.NumberFormat = "#.00"
                .DisplayColumns("unitreq").Width = 150
                .DisplayColumns("unitreq").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("unitreq").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("unitearned").DataColumn.Caption = "UNIT/S EARNED"
                .DisplayColumns("unitearned").DataColumn.NumberFormat = "#.00"
                .DisplayColumns("unitearned").Width = 150
                .DisplayColumns("unitearned").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("unitearned").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

                .DisplayColumns("course_id").DataColumn.Caption = "CID"
                .DisplayColumns("course_id").Width = 90
                .DisplayColumns("course_id").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                .DisplayColumns("course_name").DataColumn.Caption = "PROGRAM"
                .DisplayColumns("course_name").Width = 150
                .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near



            End With
        Catch ex As Exception

        End Try

        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            SQL = "SELECT count(SysPK) as count"
            SQL += " FROM " & TABLENAME
            MeData = clsDBConn.ExecQuery(SQL)

            recordCount.Text = "1-" & tdbViewer.RowCount & " of " & MeData.Rows(0).Item("count").ToString
        End If


        MeData = Nothing
        Me.txtFilterText.Text = ""
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
            SETUPFORM = New fmaCreditDistributionSetupForm
            SETUPFORM.OPERATION = "ADD"
        End If

        SETUPFORM.ShowDialog()
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
            DELETESTR += " WHERE pk_code='" & ITEMSYSPK & "'"

            If clsDBConn.Execute(DELETESTR) Then
                MsgBox("ITEM HAS BEEN DELETED", MsgBoxStyle.Information)
                Attach()
            End If
        End If


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SETUPFORM Is Nothing Then
            SETUPFORM = New fmaCreditDistributionSetupForm
            SETUPFORM.OPERATION = "EDIT"

        End If


        SETUPFORM.Show(Me)

        SETUPFORM.BringToFront()
        Me.FormControls = SETUPFORM.clsGroup.FormControls
        SETUPFORM.btnModify.PerformClick()
        GridToTextboxes()

    End Sub

    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click
        searchFilterText()
    End Sub


End Class