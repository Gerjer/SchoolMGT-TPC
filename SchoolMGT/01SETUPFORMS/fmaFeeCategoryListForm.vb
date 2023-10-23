Imports System.Threading
Imports System.ComponentModel

Public Class fmaFeeCategoryListForm

    Private TABLEID As String = ""
    
    Private Sub fmaFeeCategoryListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayFinanceCategoryList()
    End Sub

    Private Sub displayFinanceCategoryList()
        tdbViewer.DataSource = Nothing
        Dim MeData As New DataTable

        Dim SQL As String = "SELECT id,name,description, "
        SQL += " CASE WHEN is_income = 0 THEN 'EXPENSE'"
        SQL += " ELSE 'INCOME'"
        SQL += " End 'TYPE'"
        SQL += " FROM finance_transaction_categories "
        SQL += " WHERE deleted=0"
        SQL += " ORDER BY is_income DESC"
        
        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)


        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("id").Visible = False

                .DisplayColumns("name").DataColumn.Caption = "CATEGORY"
                .DisplayColumns("name").Width = 350
                .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("description").DataColumn.Caption = "DESCRIPTION"
                .DisplayColumns("description").Width = 300
                .DisplayColumns("description").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("description").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("TYPE").DataColumn.Caption = "TYPE"
                .DisplayColumns("TYPE").Width = 100
                .DisplayColumns("TYPE").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("TYPE").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
            TABLEID = tdbViewer.Columns.Item(0).Value

            txt_name.Text = tdbViewer.Columns.Item(1).Value
            txtDescr.Text = tdbViewer.Columns.Item(2).Value

            Dim type As String = tdbViewer.Columns.Item(3).Value

            If type = "INCOME" Then
                cmbType.SelectedIndex = 1
            Else
                cmbType.SelectedIndex = 0
            End If
            btnAdd.Text = "Add"
            txt_name.Enabled = False
            txtDescr.Enabled = False
            cmbType.Enabled = False
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            txt_name.Enabled = True
            txtDescr.Enabled = True
            cmbType.Enabled = True
            txt_name.Focus()
            btnEdit.Text = "Update"
        ElseIf btnEdit.Text = "Update" Then


            Dim SQLUP As String = "update finance_transaction_categories SET"
            SQLUP += String.Format(" name='{0}', description='{1}',", txt_name.Text, txtDescr.Text)
            SQLUP += String.Format(" is_income='{0}'", cmbType.SelectedIndex)
            SQLUP += " WHERE id='" & TABLEID & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Category updated.", MsgBoxStyle.Information)
                clearFields()
                displayFinanceCategoryList()
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If TABLEID <= 3 Then
            MsgBox("Cannot Delete Default Fees.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLUP As String = "UPDATE finance_transaction_categories set deleted='1'"
            SQLUP += " WHERE id='" & TABLEID & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Finance Fee Category Deleted.")
                clearFields()
                displayFinanceCategoryList()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub clearFields()
        txt_name.Text = ""
        txtDescr.Text = ""
        cmbType.Text = ""
        cmbType.SelectedIndex = -1
        btnDelete.Visible = False
        btnEdit.Visible = False
        TABLEID = ""
        btnAdd.Text = "Add"
        btnEdit.Text = "Edit"
        txt_name.Enabled = False
        txtDescr.Enabled = False
        cmbType.Enabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            If TABLEID.Length > 0 Then
                clearFields()

            End If

            btnAdd.Text = "Save"
            txt_name.Enabled = True
            txtDescr.Enabled = True
            cmbType.Enabled = True
            txt_name.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If txt_name.Text.Length = 0 Then
                MsgBox("Please fill out Name.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If cmbType.Text.Length = 0 Then
                MsgBox("Please fill out Name.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim SQLIN As String = "INSERT INTO finance_transaction_categories(name,description,is_income,deleted)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", txt_name.Text, txtDescr.Text)
            SQLIN += String.Format("'{0}', '{1}')", cmbType.SelectedIndex, "0")

            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Category has been added.")
                displayFinanceCategoryList()
            End If

        End If

        
    End Sub
End Class