Public Class fmaFeesMasterDuplicate

    Public Event FORM_CLOSING()
    Public Event FEES_ADDED()

    Private FeeCount As Integer = 0

    Private Sub fmaFeesMasterDuplicate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent FORM_CLOSING()
    End Sub

    Private Sub fmaFeesMasterDuplicate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        displayCourse()
        displayBatches()
    End Sub

    Private Sub displayCourse()
        Dim SQLEX As String = "SELECT id, course_name  FROM courses"
        SQLEX += " WHERE is_deleted <> 1"
        SQLEX += " GROUP BY course_name"
        SQLEX += " ORDER BY course_name"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourse.DataSource = MeData

        cmbCourse.ValueMember = "id"
        cmbCourse.DisplayMember = "course_name"

        cmbCourse.SelectedIndex = -1
        txtCourseID.Text = ""


    End Sub


    Private Sub displayBatches()
        Dim SQLEX As String = ""

        SQLEX = "SELECT
                    id,
                    name
                    FROM(
                    SELECT
                    batches.id,
                    NAME 
                    FROM
                    batches
                    INNER JOIN courses ON ( batches.course_id = courses.id ) 
                    WHERE
                    batches.is_deleted = 0 
                    AND batches.is_active = 1 
                    AND course_id = '" & Me.txtCourseID.Text & "'
	
                    UNION
	
                    SELECT
                    batches.id,
                    NAME 
                    FROM
                    batches
                    WHERE id = 0
	
                    )A ORDER BY id
                    "

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"
        cmbBatch.Text = ""
        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""


    End Sub

    Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
        If txtBatchID.Text.Length > 0 Then
            pbxSearch.Visible = True
            'getMasterFees()
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            lblTimer.Text = "0"
            pbxSearch.Visible = False
            pbxSearch.Visible = False
        End If
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourse.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
            displayBatches()
        Catch ex As Exception
            Me.txtCourseID.Text = ""
        End Try
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbBatch.SelectedItem, DataRowView)
            Me.txtBatchID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtBatchID.Text = ""
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tick As Integer = CInt(lblTimer.Text)

        lblTimer.Text = tick + 1

        If tick = 1 Then
            Timer1.Enabled = False
            lblTimer.Text = "0"
            getMasterFees()
            pbxSearch.Visible = False

        End If
    End Sub

    Private Sub getMasterFees()
        Dim TOTAL_FEES As Double = 0
        dgvFEES.Rows.Clear()

        Dim SQLEX As String = "SELECT finance_fee_categories.id,"
        SQLEX += " finance_fee_categories.name"
        SQLEX += " , SUM(`finance_fee_particulars`.`amount`) 'amount'"
        SQLEX += " FROM finance_fee_categories"
        SQLEX += " INNER JOIN finance_fee_particulars "
        SQLEX += " ON (finance_fee_categories.id = finance_fee_particulars.finance_fee_category_id)"
        SQLEX += " WHERE finance_fee_categories.is_deleted<> 1 AND batch_id='" & txtBatchID.Text & "'"
        SQLEX += " GROUP BY finance_fee_categories.id"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            For cnt As Integer = 0 To MeData.Rows.Count - 1
                Dim catid As String = MeData.Rows(cnt).Item("id").ToString
                Dim description As String = MeData.Rows(cnt).Item("name").ToString
                Dim TotalAmt As String = ""
                Try
                    TotalAmt = Format(CDbl(MeData.Rows(cnt).Item("amount").ToString), "#,##0.00")
                Catch ex As Exception
                    TotalAmt = "0.00"
                End Try
                dgvFEES.Rows.Add(New Object() {True, catid, description, TotalAmt})
            Next
            btnImport.Visible = True
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        RaiseEvent FORM_CLOSING()
        Me.Close()
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1
            Dim chkbox As Boolean = dgvFEES.Item(0, nCtr).Value
            If chkbox = True Then
                FeeCount += 1
            End If
        Next

        If FeeCount = 0 Then
            MsgBox("Please Check One of the Fee/s.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to Import Fees?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then



            For nCtr As Integer = 0 To dgvFEES.Rows.Count - 1
                Dim chkbox As Boolean = dgvFEES.Item(0, nCtr).Value
                If chkbox = True Then
                    FeeCount += 1

                    Dim FeeCatID As String = dgvFEES.Item(1, nCtr).Value.ToString
                    Dim FeeCatName As String = dgvFEES.Item(2, nCtr).Value.ToString
                    ' 1. create this Master Fee to this Batch Fee Category
                    Dim InsertNewMasterFee As String = "INSERT INTO finance_fee_categories(name,description,batch_id, is_deleted,is_master)"
                    InsertNewMasterFee += " VALUES("
                    InsertNewMasterFee += String.Format("'{0}', '{1}', ", FeeCatName, FeeCatName)
                    InsertNewMasterFee += String.Format("'{0}', '{1}', '{2}')", txtThisBatchID.Text, "0", "1")
                    If clsDBConn.Execute(InsertNewMasterFee) Then
                        Dim getLastIndexID As String = "SELECT id FROM finance_fee_categories ORDER BY id DESC LIMIT 1"
                        Dim resTable As DataTable
                        resTable = clsDBConn.ExecQuery(getLastIndexID)

                        If resTable.Rows.Count > 0 Then
                            Dim LastIndexId As String = resTable.Rows(0).Item("id").ToString

                            Dim getParticulars As String = "SELECT name,amount,mode_payments FROM finance_fee_particulars"
                            getParticulars += " WHERE finance_fee_category_id='" & FeeCatID & "'"

                            Dim particularTbl As DataTable
                            particularTbl = clsDBConn.ExecQuery(getParticulars)

                            If particularTbl.Rows.Count > 0 Then
                                For pNctr As Integer = 0 To particularTbl.Rows.Count - 1
                                    Dim pName As String = particularTbl.Rows(pNctr).Item("name").ToString
                                    Dim amount As Double = 0
                                    Dim mode_payments As Integer = particularTbl.Rows(pNctr).Item("mode_payments").ToString

                                    If Not IsDBNull(particularTbl.Rows(pNctr).Item("amount")) Then
                                        amount = CDbl(particularTbl.Rows(pNctr).Item("amount").ToString)
                                    End If
                                    Dim insetNewParticularFee As String = "INSERT INTO finance_fee_particulars(name,description,amount,finance_fee_category_id,is_deleted,mode_payments)"
                                    insetNewParticularFee += " VALUES("
                                    insetNewParticularFee += String.Format("'{0}', '{1}', ", pName, pName)
                                    insetNewParticularFee += String.Format("'{0}', '{1}', ", amount, LastIndexId)
                                    insetNewParticularFee += String.Format("'{0}','{1}')", "0", mode_payments)

                                    clsDBConn.Execute(insetNewParticularFee)
                                Next
                            End If

                        End If
                    End If
                End If

            Next

            MsgBox("FEES HAS BEEN ADDED TO THIS COURSE/BATCH.", MsgBoxStyle.Information)
            RaiseEvent FEES_ADDED()
            Me.Close()
        End If

       
    End Sub
End Class