
Imports DevComponents.DotNetBar
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base.ColumnView
Public Class frmFilterPerson

    Private WithEvents SETUPFORM As fmaEmployeeRecord

    Dim FocusRow As DataRow
    Public SelectedRow As DataRow
    Public x As String
    Public AcademicYear As String = ""
    Public Semester As String = ""


    Private Sub frmFilterPerson_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadListView(Me.Tag)
        If Me.Tag = 1 Then
            Me.Text = "NEW STUDENT"
        Else
            Me.Text = "OLD STUDENT"
        End If
        '      GridView1.FindFilterText = Focus()
        GridView1.Focus()
        '       GridView1.OptionsFind = FocusedValue
    End Sub

    Private Sub LoadListView(tag As Object)
        Dim str As String = ""
        If tag = 1 Then
            str = "students.class_roll_no IS NULL"
        Else
            str = "students.class_roll_no IS NOT NULL"
        End If


        Dim dt As New DataTable
#Region "old"
        'dt = DataSource(String.Format("SELECT
        '        `students`.`admission_no`
        '        , `students`.`class_roll_no`
        '        , `students`.`first_name`
        '        , `students`.`middle_name`
        '        , `students`.`last_name`
        '        , `person`.display_name
        '        , `person`.`person_id`
        '        , `students`.`id`
        '        , `students`.`admission_date`
        '        , `students`.`date_of_birth`
        '        , `students`.`gender`
        '        , `students`.`phone1`
        '        , `students_details`.`year_level`
        '        , `students_details`.`semester`
        '        , `students_details`.`enrollmentAS`
        '        , `students_details`.`student_category_id`
        '        , `students_details`.`course_id`
        '        , `students_details`.`batch_id`
        '        , `students_details`.`enrollment_type`
        '        ,  CONCAT(`students`.`address_line1`,', ',`students`.`address_line2`,', ',`students`.`city`,', ',`students`.`pin_code`,', ',`students`.`state`)AS 'Address'

        '    FROM
        '        `schlmgt_tpc`.`person`
        '        INNER JOIN `schlmgt_tpc`.`students` 
        '            ON (`person`.`person_id` = `students`.`person_id`)
        '        LEFT JOIN `schlmgt_tpc`.`students_details` 
        '            ON (`students`.`id` = `students_details`.`id`)
        '      where   `students`.`admission_no` is null and `students`.`class_roll_no` is null
        '    --  where `students_details`.`status` = 1 and `students_details`.end_time is null        
        '                 ; 
        '                           "))
#End Region
        dt = DataSource(String.Format("SELECT
                                       person.person_id,
                                        students.id,
                                        person.last_name,
                                        person.first_name,
                                        person.middle_name,
                                        person.display_name 'STUDENT NAME',
                                        person.gender,
                                        person.date_of_birth,
                                        CONCAT(person_address.address,', ',person_address.barangay,', ',person_address.citymunicipality,', ',person_address.zipcode,', ',person_address.province) as 'Address',
                                        concat(person.telephone1,' / ',person.mobile) as 'ContactNumber',
                                        students.class_roll_no,
                                        students.runningbalance,
                                        students.scholarshipgrant,
                                        person_photo.photo_file_name,
                                        person_photo.original_file_name,
                                        students.stature,
                                        students.std_number 'ID NUMBER',
                                        students.student_category_id,
                                        students.course_id,
                                        user_id

                                        FROM
                                        person
                                        LEFT JOIN person_address ON person.person_id = person_address.person_id AND person_address.address_type_id = 1
                                        LEFT JOIN students ON person.person_id = students.person_id
                                        LEFT JOIN person_photo ON person.person_id = person_photo.person_id
                                        LEFT JOIN users ON users.id = students.user_id	

                                        WHERE
                                        person.person_type_id = 2 AND
                                        person.status_type_id = 1 AND
                                        person.end_time IS NULL AND
                                        " & str & " 
                                        GROUP BY person_id     "))


        GridControl1.DataSource = dt
    End Sub




    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        SelectedRow = GridView1.GetFocusedDataRow
        personID = GridView1.GetFocusedRowCellValue("person_id")
        Name = GridView1.GetFocusedRowCellValue("STUDENT NAME")

        Dim row = GridControl1.FocusedView
        checkStudent()
        If NotExist Then
            Me.DialogResult = DialogResult.OK
        End If

        '  Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        '    Me.Close()
    End Sub


    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged

        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceCell.Font = New Font("Tahoma", 10, FontStyle.Bold)
            Select Case i
                Case 0, 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19
                    GridView1.Columns(i).Visible = False
                Case 16
                    GridView1.Columns(i).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
            End Select
        Next
    End Sub

    Public personID As Integer
    Public Name As String = ""
    Private Sub GridView1_RowClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        SelectedRow = GridView1.GetFocusedDataRow
        personID = GridView1.GetFocusedRowCellValue("person_id")
        Name = GridView1.GetFocusedRowCellValue("STUDENT NAME")
        'Me.Close()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick

        SelectedRow = GridView1.GetFocusedDataRow
        personID = GridView1.GetFocusedRowCellValue("person_id")
        Name = GridView1.GetFocusedRowCellValue("STUDENT NAME")

        checkStudent()
        If NotExist Then
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub checkStudent()

        If CheckIfStudentIsAlreadyEnrolled(personID, AcademicYear, Semester) Then
            MessageBoxEx.Show("Mr./Ms '" & Name & "' is Already Enrolled.... ", "RECORD EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NotExist = False
        Else
            NotExist = True
        End If

    End Sub

    Private Function CheckIfStudentIsAlreadyEnrolled(personID As Integer, academicYear As String, semester As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT id FROM students WHERE status_type_id = 1 AND person_id = '" & personID & "' AND semester = '" & semester & "' AND academice_year = '" & academicYear & "'"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Dim NotExist As Boolean = True
    Private Sub frmFilterPerson_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If SelectedRow IsNot Nothing Or GridView1.SelectedRowsCount > 0 Then
            If e.KeyCode = Keys.Enter Then

                SelectedRow = GridView1.GetFocusedDataRow
                personID = GridView1.GetFocusedRowCellValue("person_id")
                Name = GridView1.GetFocusedRowCellValue("STUDENT NAME")
                checkStudent()
                If NotExist Then
                    Me.DialogResult = DialogResult.OK
                End If

            End If
        End If

    End Sub

    Private Sub BtnAddNewPerson_Click(sender As Object, e As EventArgs) Handles BtnAddNewPerson.Click
        Dim SetupName As String = ""
        Cursor = Cursors.WaitCursor

        If SETUPFORM Is Nothing Then

            SetupName = "STUDENT SETUP"

            SETUPFORM = New fmaEmployeeRecord("ADD", 2, SetupName)

            SETUPFORM.ShowDialog()
            SETUPFORM.BringToFront()

        End If
        SETUPFORM = Nothing
        Cursor = Cursors.Default
    End Sub

    Private Sub SETUPFORM_FORM_CLOSING() Handles SETUPFORM.FORM_CLOSING
        LoadListView(Me.Tag)
        If Me.Tag = 1 Then
            Me.Text = "NEW STUDENT"
        Else
            Me.Text = "OLD STUDENT"
        End If
        '      GridView1.FindFilterText = Focus()
        GridView1.Focus()
        '       GridView1.OptionsFind = FocusedValue
    End Sub
End Class