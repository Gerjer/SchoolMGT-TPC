Public Class EHRM_PersonaProfile_ViewerListForm
    Public FormControls As Collection
    Dim MeData As New DataTable

#Region "Viewers Info"
    Private Sub Attach()
        Dim SQL As String = "SELECT SysPK_PP,pp_person_code,pp_prefix,pp_lastname,pp_firstname,"
        SQL += "pp_middlename,pp_suffix,pp_dob,pp_birthplace,pp_sex,pp_civilstatus,pp_citizenship,pp_height,"
        SQL += "pp_weight,pp_bloodType,pp_GSIS_no,pp_PAGIBIG_no,pp_PHILHEALTH_no,pp_SSS_no,pp_TIN, "
        SQL += "pp_Address1,pp_zipcode1,pp_Tel_no1,pp_Address2,pp_zipcode2,pp_email,pp_cell_no,"
        SQL += "pp_agency_employee_no "
        SQL &= " FROM hr_person_profile WHERE SysPK_PP <> 0 AND pp_Priority=2"
        SQL &= " ORDER BY pp_lastname, pp_firstname, pp_middlename"

        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewer.DataSource = MeData
        'Me.tdbViewer.Rebind(True)

        Try
            With tdbViewer.Splits(0)
                .DisplayColumns("SysPK_PP").DataColumn.Caption = "SysPK_PP"
                .DisplayColumns("SysPK_PP").Width = 0

                .DisplayColumns("pp_person_code").DataColumn.Caption = "Person ID"
                .DisplayColumns("pp_person_code").Width = 100

                .DisplayColumns("pp_prefix").DataColumn.Caption = "Prefix"
                .DisplayColumns("pp_prefix").Width = 80


                .DisplayColumns("pp_lastname").DataColumn.Caption = "Last Name"
                .DisplayColumns("pp_lastname").Width = 200

                .DisplayColumns("pp_firstname").DataColumn.Caption = "First Name"
                .DisplayColumns("pp_firstname").Width = 200

                .DisplayColumns("pp_middlename").DataColumn.Caption = "Middle Name"
                .DisplayColumns("pp_middlename").Width = 200

                .DisplayColumns("pp_suffix").DataColumn.Caption = "Suffix"
                .DisplayColumns("pp_suffix").Width = 80

                .DisplayColumns("pp_dob").DataColumn.Caption = "Date Of Birth"
                .DisplayColumns("pp_dob").Width = 200


                .DisplayColumns("pp_birthplace").Width = 0
                .DisplayColumns("pp_sex").DataColumn.Caption = "Sex"
                .DisplayColumns("pp_sex").Width = 100


                
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Detach()

    End Sub
#End Region

    Private Sub fmaDepartmentViewerListForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Detach()
    End Sub

    Private Sub fmaDepartmentViewerListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Attach()
    End Sub

    Private Sub tdbViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbViewer.DoubleClick
        If tdbViewer.RowCount > 0 Then
            Me.GridToTextboxes()
        End If
        ProcessFilterText(MeData, tdbViewer)
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
        For Each iControl As Control In FormControls
            Try
                iControl.Text = tdbViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception
            End Try
        Next
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Attach()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Me.GridToTextboxes()
    End Sub
End Class