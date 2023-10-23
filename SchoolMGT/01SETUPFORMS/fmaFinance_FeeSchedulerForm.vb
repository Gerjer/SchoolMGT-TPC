Imports System.Threading
Imports System.ComponentModel

Public Class fmaFinance_FeeSchedulerForm


    Dim PAYMENTCOUNT As Integer = 0

    Dim WithEvents dtp As DateTimePicker


    Private Sub fmaFinance_FeeSchedulerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        displayCategory()

        dtp = New DateTimePicker
        dtp.Visible = False
        dtp.Format = DateTimePickerFormat.Short
        dtp.Width = 200
        dgvPaymentSchedule.Controls.Add(dtp)


    End Sub

    Private Sub displaySchedule()
        Dim SQLEX As String = "SELECT description,due_date,student_category_id"
        SQLEX += " FROM fee_schedule"
        SQLEX += " WHERE student_category_id='" & txtCategoryID.Text & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)
        If MeData.Rows.Count > 0 Then
            dgvPaymentSchedule.Rows.Clear()
            For modecnt As Integer = 0 To MeData.Rows.Count - 1
                Dim dueDate As String = Format(MeData.Rows(modecnt).Item("due_date"), "yyyy-MM-dd")

                dgvPaymentSchedule.Rows.Add(New String() {MeData.Rows(modecnt).Item("description").ToString, _
                                                          dueDate, _
                                                          MeData.Rows(modecnt).Item("student_category_id").ToString})
            Next
        Else
            SQLEX = "SELECT no_of_payment FROM student_categories"
            SQLEX += " WHERE id='" & txtCategoryID.Text & "'"


            MeData = clsDBConn.ExecQuery(SQLEX)

            Dim paymentCount As Integer = 1

            If MeData.Rows.Count > 0 Then
                Try
                    paymentCount = CInt(MeData.Rows(0).Item("no_of_payment").ToString)
                    paymentCount = paymentCount
                Catch ex As Exception

                End Try

            Else
                paymentCount = 1
            End If


            dgvPaymentSchedule.Rows.Clear()
            For modecnt As Integer = 0 To paymentCount - 1
                Dim modeNo As Integer = modecnt + 1
                Dim paymentType As String = ""

                If modeNo = 1 Then
                    paymentType = "1ST PAYMENT"
                ElseIf modeNo = 2 Then
                    paymentType = "2ND PAYMENT"
                ElseIf modeNo = 3 Then
                    paymentType = "3RD PAYMENT"
                Else
                    paymentType = modeNo & "TH PAYMENT"
                End If


                dgvPaymentSchedule.Rows.Add(New String() {paymentType, ""})
            Next
        End If

    End Sub

    Private Sub displayCategory()
        Dim SQLEX As String = "SELECT id,name FROM student_categories"
        SQLEX += " WHERE is_deleted <> 1"
        SQLEX += " ORDER BY id"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCategory.DataSource = MeData

        cmbCategory.ValueMember = "id"
        cmbCategory.DisplayMember = "name"

        cmbCategory.SelectedIndex = -1
        txtCategoryID.Text = ""

    End Sub


    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCategory.SelectedItem, DataRowView)
            Me.txtCategoryID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCategoryID.Text = ""
        End Try
    End Sub


    Private Sub txtCategoryID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCategoryID.TextChanged

        If txtCategoryID.Text.Length > 0 Then

            displaySchedule()
            
        Else
            dgvPaymentSchedule.Rows.Clear()
        End If
    End Sub

    
    

    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        displayCategory()
        dgvPaymentSchedule.Rows.Clear()
        btnSave.Enabled = False
        
    End Sub

    Private Sub dgvPaymentSchedule_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentSchedule.CellEndEdit
        If e.ColumnIndex = 1 And e.RowIndex > -1 Then
            dgvPaymentSchedule.CurrentCell.Value = Format(dtp.Value, "yyyy-MM-dd")
        End If
    End Sub


    Private Sub dgvPaymentSchedule_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPaymentSchedule.CurrentCellDirtyStateChanged
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SQLIN As String = ""
        Dim SQLDEL As String = "DELETE FROM fee_schedule WHERE student_category_id='" & Me.txtCategoryID.Text & "'"
        clsDBConn.ExecuteSilence(SQLDEL)



        For nCtr As Integer = 0 To dgvPaymentSchedule.Rows.Count - 1

            Dim description As String = dgvPaymentSchedule.Rows.Item(nCtr).Cells(0).Value.ToString
            Dim datestr As String = dgvPaymentSchedule.Rows.Item(nCtr).Cells(1).Value.ToString

            SQLIN = "INSERT INTO fee_schedule(student_category_id,description,due_date)"
            SQLIN += String.Format("VALUES('{0}', '{1}','{2}')", txtCategoryID.Text, description, datestr)

            clsDBConn.ExecuteSilence(SQLIN)


        Next
        MsgBox("SCHEDULE HAS BEEN SAVED.", MsgBoxStyle.Information)
        btnClearFilter.PerformClick()

    End Sub


    Private Sub dgvPaymentSchedule_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPaymentSchedule.CellBeginEdit
        If e.ColumnIndex = 1 And e.RowIndex > -1 Then

            dtp.Location = dgvPaymentSchedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            dtp.Visible = True




        End If
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        dtp.Visible = False
        btnSave.Enabled = True
    End Sub
End Class