Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Forms.Control
Imports SchoolMGT

Public Class fmaStudentGradingPeriodForm

    Private TOTALPERCENT As Integer = 0

    Private TABLEID As String = ""

    Private Sub fmaFeeCategoryListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayStudentGradingPeriod()

        getCategory()

        'cmbyearbatch.DataSource = DataSource(String.Format("SELECT DISTINCT
        '                            1 as 'id',
        '                            batches.school_year 'name'
        '                            FROM
        '                            batches
        '                            WHERE school_year is NOT NULL
        '                            ORDER BY school_year DESC
        '                            "))
        'cmbyearbatch.ValueMember = "id"
        'cmbyearbatch.DisplayMember = "name"
        'cmbyearbatch.SelectedIndex = -1



    End Sub

    Private Sub getCategory()
        Dim SQLEX As String = "SELECT id,name from student_categories"
        SQLEX += " WHERE is_deleted <> 1"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbType.DataSource = MeData

        cmbType.ValueMember = "id"
        cmbType.DisplayMember = "name"

        cmbType.SelectedIndex = -1
        txtCatID.Text = ""
    End Sub

    Private Sub displayStudentGradingPeriod()
        tdbViewer.DataSource = Nothing
        Dim MeData As New DataTable

        Dim SQL As String = "SELECT student_grading_period.id 'stgid',student_category_id , "
        SQL += " student_grading_period.name 'stgname',student_categories.name 'stcname',concat(weight_percentage,'%') 'weight_percentage' FROM student_grading_period"
        SQL += " INNER JOIN student_categories"
        SQL += " ON (student_grading_period.student_category_id = student_categories.id)"
        SQL += " WHERE student_grading_period.is_deleted=0"
        SQL += " AND student_category_id='" & txtCatID.Text & "'"

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        Me.tdbViewer.Rebind(True)


        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("stgid").Visible = False
                .DisplayColumns("student_category_id").Visible = False

                .DisplayColumns("stgname").DataColumn.Caption = "PERIOD"
                .DisplayColumns("stgname").Width = 200
                .DisplayColumns("stgname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("stgname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("stcname").DataColumn.Caption = "CATEGORY"
                .DisplayColumns("stcname").Width = 200
                .DisplayColumns("stcname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("stcname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                .DisplayColumns("weight_percentage").DataColumn.Caption = "PERCENTAGE"
                .DisplayColumns("weight_percentage").Width = 100
                .DisplayColumns("weight_percentage").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("weight_percentage").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            End With

        Catch ex As Exception

        End Try
        displayTotalPercent()
    End Sub

    Private Sub displayTotalPercent()
        Dim MeData As New DataTable

        Dim SQL As String = "SELECT SUM(weight_percentage) 'total' FROM student_grading_period"
        SQL += " WHERE student_grading_period.is_deleted=0"
        SQL += " AND student_category_id='" & txtCatID.Text & "'"

        MeData = clsDBConn.ExecQuery(SQL)

        If MeData.Rows.Count > 0 Then
            Try

                txtTotal.Text = CInt(MeData.Rows(0).Item("total").ToString) & "%"
                TOTALPERCENT = CInt(MeData.Rows(0).Item("total").ToString)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then

            btnDelete.Visible = True
            btnEdit.Visible = True
            TABLEID = tdbViewer.Columns.Item(0).Value

            txt_name.Text = tdbViewer.Columns.Item("stgname").Value
            Dim percent As String = tdbViewer.Columns.Item("weight_percentage").Value
            percent = percent.Replace("%", "")
            txtPercentage.Value = CInt(percent)


            '      cmbType.SelectedIndex = CInt(tdbViewer.Columns.Item(1).Value) - 1
            cmbType.SelectedValue = CInt(tdbViewer.Columns.Item(1).Value)


            btnAdd.Text = "Add"
            txt_name.Enabled = False
            txtPercentage.Enabled = False
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            txt_name.Enabled = True
            txtPercentage.Enabled = True
            cmbType.Enabled = True
            txt_name.Focus()
            btnEdit.Text = "Update"
        ElseIf btnEdit.Text = "Update" Then


            Dim SQLUP As String = "update student_grading_period SET"
            SQLUP += String.Format(" name='{0}', student_category_id='{1}',", txt_name.Text, txtCatID.Text)
            SQLUP += String.Format(" weight_percentage='{0}'", txtPercentage.Value)
            SQLUP += " WHERE id='" & TABLEID & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Grading Period Updated.", MsgBoxStyle.Information)
                clearFields()
                displayStudentGradingPeriod()
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If MessageBox.Show("Are you sure you want to DELETE ITEM?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim SQLUP As String = "UPDATE student_grading_period set is_deleted='1'"
            SQLUP += " WHERE id='" & TABLEID & "'"

            If clsDBConn.Execute(SQLUP) Then
                MsgBox("Grading Period has been Deleted.")
                clearFields()
                displayStudentGradingPeriod()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub clearFields()
        txt_name.Text = ""
        txtPercentage.Value = 0
        cmbType.Text = ""
        cmbType.SelectedIndex = -1
        btnDelete.Visible = False
        btnEdit.Visible = False
        TABLEID = ""
        btnAdd.Text = "Add"
        btnEdit.Text = "Edit"
        txt_name.Enabled = False
        txtPercentage.Enabled = False
        'cmbType.Enabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            If TABLEID.Length > 0 Then
                clearFields()

            End If

            btnAdd.Text = "Save"
            txt_name.Enabled = True
            txtPercentage.Enabled = True
            'cmbType.Enabled = True
            cmbType.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If txt_name.Text.Length = 0 Then
                MsgBox("Please fill out Name.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtPercentage.Value = 0 Then
                MsgBox("Please fill out Percentage.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim SQLIN As String = "INSERT INTO student_grading_period(name,student_category_id,weight_percentage,is_deleted)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", txt_name.Text, txtCatID.Text)
            SQLIN += String.Format("'{0}', '{1}')", txtPercentage.Value, "0")

            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Grading Period has been added.")
                displayStudentGradingPeriod()
                'createTempTable()
                clearFields()
            End If

        End If


    End Sub

    Private Sub createTempTable()

        If TOTALPERCENT <> 100 Then
            Exit Sub
        End If

        Dim SQLEX As String = "SELECT name FROM student_grading_period WHERE student_category_id='" & txtCatID.Text & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        If MeData.Rows.Count > 0 Then
            Dim tableName As String = "TEMPGRADE_" & txtCatID.Text

            Dim SQLCOM As String = "DROP TABLE IF EXISTS " & tableName & ";"

            SQLCOM += " CREATE TABLE " & "`" & tableName & "`"
            SQLCOM += " ("
            SQLCOM += " `id` INT(11) NOT NULL,"
            SQLCOM += " `student_subjec_id` INT(11) NOT NULL,"

            For nCtr As Integer = 0 To MeData.Rows.Count - 1
                Dim Name As String = MeData.Rows(nCtr).Item("name").ToString
                SQLCOM += "`" & Name & "` VARCHAR(20) DEFAULT '',"
            Next
            SQLCOM += " PRIMARY KEY (`id`)"


            SQLCOM += " ) ENGINE=INNODB DEFAULT CHARSET=latin1;"

            clsDBConn.Execute(SQLCOM)


        End If


        
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbType.SelectedItem, DataRowView)
            Me.txtCatID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub

    Private Sub txtCatID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCatID.TextChanged
        If txtCatID.Text.Length = 0 Then
            tdbViewer.DataSource = Nothing
        Else
            displayStudentGradingPeriod()
        End If
    End Sub

    'Private Sub btnTempGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempGrade.Click
    '    If MessageBox.Show("This will Create Grading Table in Database," & vbNewLine & "Continue?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '        createTempTable()
    '    End If


    'End Sub
End Class