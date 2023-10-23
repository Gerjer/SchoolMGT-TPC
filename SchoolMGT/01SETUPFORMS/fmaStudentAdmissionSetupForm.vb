Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Threading
Imports DevExpress.Utils
Imports DevComponents.DotNetBar

Public Class fmaStudentAdmissionSetupForm

    Dim picturePath As String = ""
    Private MeData As DataTable
    Dim SelectedRow As DataRow
    Dim Dir As String = "" 'My.Application.Info.DirectoryPath & "\PERSON\"
    Dim combinePath As String
    Dim Default_Image As Image
    Dim UserName As String
    Dim ClassRollNo As String
    Dim AcademicYear As String = ""
    '  Dim FirstLoad As Boolean = True
    '  Dim grpBOX As New myGroupBox
    Private Sub fmaStudentAdmissionSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearData()
    End Sub

    Private Sub fmaStudentAdmissionSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbluseName.Text = AuthUserType

        ComboxYear()


        cmbStature.SelectedIndex = -1
        dtpAdmDate.Value = Date.Now
        'getCategory()
        'getCourseLevel()
        'getBatch()


        cmbCourseGrade.SelectedIndex = -1
        cmbBatch.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        loadAddHandler()
        '   FirstLoad = False
        '       loadStudentList()

        Default_Image = pbxphoto.Image

    End Sub

    Private Sub loadComboBox()
        Throw New NotImplementedException()
    End Sub

    Private Sub ComboxYear()
        cmbYearFrom.Items.Clear()

        For i As Integer = Year(Date.Now) To 2010 Step -1   ' 2000 To Format(Date.Now, "yyyy")
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            cmbYearFrom.Items.Add(item)
        Next
        cmbYearFrom.SelectedIndex = 0


        cmbYearTo.Items.Clear()
        For i As Integer = Year(Date.Now) + 1 To 2010 Step -1   ' 2000 To Format(Date.Now, "yyyy")
            Dim item As ComboBoxItem = New ComboBoxItem()
            item.Text = i
            cmbYearTo.Items.Add(item)
        Next
        cmbYearTo.SelectedIndex = 0

    End Sub

    Private Sub loadAddHandler()

        '    AddHandler cmbCategory.SelectedIndexChanged, AddressOf cmbCategory_SelectedIndexChanged
        AddHandler cmbCategory.SelectionChangeCommitted, AddressOf cmbCategory_SelectionChangeCommitted
        '   AddHandler cmbCourseGrade.SelectedIndexChanged, AddressOf cmbCourseGrade_SelectedIndexChanged
        AddHandler cmbCourseGrade.SelectionChangeCommitted, AddressOf cmbCourseGrade_SelectionChangeCommitted
        '   AddHandler cmbBatch.SelectedIndexChanged, AddressOf cmbBatch_SelectedIndexChanged
        AddHandler cmbBatch.SelectionChangeCommitted, AddressOf cmbBatch_SelectionChangeCommitted

    End Sub

    Private Sub cmbBatch_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(cmbBatch.SelectedItem, DataRowView)
            Me.txtBatchID.Text = drv.Item("id").ToString
            Me.cmbYearLevel.Text = drv.Item("year_level").ToString
            '     Me.cmbSemester.Text = drv.Item("semester").ToString
            cmbYearLevel.Focus()
        Catch ex As Exception
            Me.txtBatchID.Text = ""
        End Try
        txtAdmNum.Text = generateAdmissionNum()
        If rbtnNew.Checked = True Then
            txtIDNum.Text = generateStudentNumber()
        End If

    End Sub



    Private Function generateStudentNumber() As String
        Dim StdNumber As String = ""
        Dim year As String = Format(Date.Now.Date, "yyyy")
        Dim sem As String = getSemister(cmbSemester.Text)
        Dim lastNumber As String = getClassRollNo()

        If lastNumber = "" Then
            lastNumber = 1
        Else
            lastNumber += 1
        End If

        ClassRollNo = lastNumber

        lastNumber = String.Format("{0:D4}", CInt(lastNumber))
        StdNumber = String.Format("{0}{1}{2}{3}{4}", year, "-", sem, "-", lastNumber)

        UserName = year + sem + lastNumber

        Return StdNumber

    End Function

    Private Function getClassRollNo() As String
        Dim StdNumber As String = ""
        StdNumber = DataObject(String.Format("SELECT
                    IFNULL(MAX(CAST(`students`.`class_roll_no` AS UNSIGNED)),'')
                FROM
                    `students`
                    INNER JOIN `person` 
                        ON (`students`.`person_id` = `person`.`person_id` AND `person`.status_type_id = 1 AND `person`.end_time IS NULL)
                "))
        Return StdNumber
    End Function

    Private Function getSemister(semister As String) As String
        Dim sem As String = ""

        If semister.Contains("1") Then
            sem = "1"
        ElseIf semister.Contains("2") Then
            sem = "2"
        Else
            sem = "3"
        End If

        Return sem
    End Function

    Private Sub cmbCourseGrade_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(cmbCourseGrade.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
            Me.txtCourseCode.Text = drv.Item("course_name").ToString
            createStudentCourseFolder(If(cmbCourseGrade.Text = "", Me.txtCourseCode.Text, cmbCourseGrade.Text))
            getBatch()
            cmbBatch.Focus()
        Catch ex As Exception
            Me.txtCourseID.Text = ""
            Me.txtCourseCode.Text = ""
        End Try
    End Sub

    Dim _sender As New Object
    Dim _e As New EventArgs
    Private Sub cmbCategory_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim drv As DataRowView = DirectCast(cmbCategory.SelectedItem, DataRowView)
            Me.txtCatID.Text = drv.Item("id").ToString
            Me.cmbCategory.Text = drv.Item("name").ToString

            createStudentCategoryFolder(cmbCategory.Text)
            getCourseLevel()
            cmbCourseGrade.Focus()
        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub

    Dim dt As New DataTable
    Private ReadOnly borderColor As Color = Color.Black

    Private Sub loadStudentList()

        dt = DataSource(String.Format("SELECT
    `students`.`admission_no`
    , `students`.`class_roll_no`
    , `students`.`first_name`
    , `students`.`middle_name`
    , `students`.`last_name`
    , `person`.`person_id`
    , `students`.`id`
    , `students`.`admission_date`
    , `students`.`date_of_birth`
    , `students`.`gender`
    , `students`.`phone1`
    , `students_details`.`year_level`
    , `students_details`.`semester`
    , `students_details`.`enrollmentAS`
    , `students_details`.`student_category_id`
    , `students_details`.`course_id`
    , `students_details`.`batch_id`
    , `students_details`.`enrollment_type`
    ,  CONCAT(`students`.`address_line1`,', ',`students`.`address_line2`,', ',`students`.`city`,', ',`students`.`pin_code`,', ',`students`.`state`)AS 'Address'
    
FROM
    `schlmgt_tpc`.`person`
    INNER JOIN `schlmgt_tpc`.`students` 
        ON (`person`.`person_id` = `students`.`person_id`)
    LEFT JOIN `schlmgt_tpc`.`students_details` 
        ON (`students`.`id` = `students_details`.`id`)
--  where `students_details`.`status` = 1 and `students_details`.end_time is null        
             ; 
                        "))

    End Sub

    Private Sub getCategory()
        Dim SQLEX As String = "SELECT id,name from student_categories"
        SQLEX += " WHERE is_deleted <> 1"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCategory.DataSource = MeData

        cmbCategory.ValueMember = "id"
        cmbCategory.DisplayMember = "name"

        cmbCategory.SelectedIndex = -1
        txtCatID.Text = ""
        cmbCategory.Focus()
    End Sub

    Private Sub getCourseLevel()
        'CONCAT(code, '-', course_name, ' ', section_name )
        Dim SQLEX As String = "SELECT id,course_name  FROM courses"
        SQLEX += " WHERE category_id='" & txtCatID.Text & "'"
        SQLEX += " ORDER BY course_name"
        '
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbCourseGrade.DataSource = MeData

        cmbCourseGrade.ValueMember = "id"
        cmbCourseGrade.DisplayMember = "course_name"

        cmbCourseGrade.SelectedIndex = -1
        txtCourseID.Text = ""
        txtCourseCode.Text = ""
    End Sub

    Private Sub getBatch()

        Dim SQLEX As String = "SELECT id, name,year_level,semester FROM batches"
        SQLEX += " where course_id='" & txtCourseID.Text & "'"

        If rbtnOld.Checked Then
            If txtIDNum.Text.Length > 0 Then
                Dim SQLList As String = "SELECT batch_id FROM students"
                SQLList += " WHERE class_roll_no='" & txtIDNum.Text & "'"

                Dim DataList As DataTable

                DataList = clsDBConn.ExecQuery(SQLList)

                If DataList.Rows.Count > 0 Then

                    For nCtr As Integer = 0 To DataList.Rows.Count - 1

                        Dim additionalDetails As String = " AND id <> '" & DataList(nCtr).Item("batch_id").ToString & "'"
                        SQLEX += additionalDetails
                    Next

                End If
            End If
        End If
        SQLEX += " ORDER BY name"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        cmbBatch.DataSource = MeData

        cmbBatch.ValueMember = "id"
        cmbBatch.DisplayMember = "name"

        cmbBatch.SelectedIndex = -1
        txtBatchID.Text = ""
    End Sub


    Private Sub rbtnNew_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnNew.CheckedChanged
        If rbtnNew.Checked Then
            '       Panel2.Enabled = True
            '   txtFilter.Focus()
            cmbCategory.Enabled = True
            '        cmbCategory.Focus()
            clearData()
        End If
    End Sub

    Private Sub rbtnOld_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnOld.CheckedChanged
        If rbtnOld.Checked Then
            cmbCategory.Enabled = True
            '          cmbCategory.Focus()

            'BalloonTip1.
            '      Panel2.Enabled = True
            '      txtFilter.Focus()
            '    cmbCategory.Enabled = False
            '      txtIDNum.Focus()
            clearData()
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles cmbCategory.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCategory.SelectedItem, DataRowView)
            Me.txtCatID.Text = drv.Item("id").ToString
        Catch ex As Exception
            Me.txtCatID.Text = ""
        End Try
    End Sub

    Private Sub cmbCourseGrade_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles cmbCourseGrade.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbCourseGrade.SelectedItem, DataRowView)
            Me.txtCourseID.Text = drv.Item("id").ToString
            Me.txtCourseCode.Text = drv.Item("code").ToString
            getBatch()
        Catch ex As Exception
            Me.txtCourseID.Text = ""
            Me.txtCourseCode.Text = ""
        End Try
    End Sub



    Private Sub txtCourseID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCourseID.TextChanged
        'If txtCourseID.Text.Length > 0 Then
        '    cmbBatch.Enabled = True
        '    createStudentCourseFolder()
        '    getBatch()

        '    '   Else
        '    '         cmbBatch.Enabled = False
        'End If
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles cmbBatch.SelectedIndexChanged
        Try
            Dim drv As DataRowView = DirectCast(cmbBatch.SelectedItem, DataRowView)
            Me.txtBatchID.Text = drv.Item("id").ToString
            Me.cmbYearLevel.Text = drv.Item("year_level").ToString
            '     Me.cmbSemester.Text = drv.Item("semester").ToString
        Catch ex As Exception
            Me.txtBatchID.Text = ""
        End Try
    End Sub

    Private Sub txtCatID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCatID.TextChanged
        'If txtCatID.Text.Length > 0 Then
        '    '      cmbCourseGrade.Enabled = True
        '    '        getCourseLevel()
        '    '       createStudentCategoryFolder()
        'Else
        '    '         cmbCourseGrade.Enabled = False
        'End If
    End Sub

    Private Function generateAdmissionNum() As String
        Dim year As String = Format(dtpAdmDate.Value, "yyyy")
        Dim yymmdd As String = year.Substring(year.Length - 2) & Format(dtpAdmDate.Value, "MMdd")

        Dim SQLEX As String = "SELECT count(id) AS 'lastcount' from students"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                Dim count As Integer = CInt(MeData.Rows(0).Item("lastcount").ToString)
                yymmdd = yymmdd & Format(count + 1, "000000")
            Catch ex As Exception

            End Try
        End If

        Return yymmdd
    End Function

    Private Sub txtBatchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.TextChanged
        'If rbtnNew.Checked Then
        '    If txtBatchID.Text.Length > 0 Then
        '        txtAdmNum.Text = generateAdmissionNum()
        '        '            createStudentBatchFolder()
        '    Else
        '        txtAdmNum.Text = ""
        '    End If
        'Else
        '    txtAdmNum.Text = generateAdmissionNum()
        '    createStudentBatchFolder()
        'End If


    End Sub

    Function ifStudentIDExist(ByVal idNumber As String) As Boolean
        Dim RetVal As Boolean = False

        MeData = Nothing

        Dim SQLEX As String = ""
        SQLEX += "SELECT
                    students.id,
                    person.last_name,
                    person.first_name,
                    person.middle_name,
                    person_photo.photo_file_name,
                    students.scholarshipgrant,
                    person.gender,
                    students.batch_id

                    FROM
                    students
                    INNER JOIN person ON students.person_id = person.person_id AND students.status_type_id = 1 AND person.end_time IS NULL
                    INNER JOIN person_photo ON person.person_id = person_photo.person_id
                    WHERE
                    students.class_roll_no = '" & idNumber & "'
                    ORDER BY
                    students.id DESC
                    LIMIT 1
                     "

        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            RetVal = True
        End If

        Return RetVal
    End Function

    Private Sub txtIDNum_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtLName.Focus()
        End If
    End Sub


    Private Sub txtIDNum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIDNum.LostFocus

        If txtIDNum.Text.Length = 0 Then
            Exit Sub
        End If
        If rbtnNew.Checked Then
            If ifStudentIDExist(txtIDNum.Text) Then
                MsgBox("ID Number Exists")
                txtIDNum.Text = ""
            End If
        Else
            If Not ifStudentIDExist(txtIDNum.Text) Then
                MsgBox("ID Number Does'nt Exists", MsgBoxStyle.Critical)
                Exit Sub
            Else


                Dim scholarshipGrant As String = ""
                Dim gender As String = MeData.Rows(0).Item("gender").ToString
                If gender = "m" Then
                    rbtnMale.Checked = True
                Else
                    rbtnfeMale.Checked = True
                End If

                If Not IsDBNull(MeData.Rows(0).Item("scholarshipgrant")) Then
                    txtGrant.Text = MeData.Rows(0).Item("scholarshipgrant").ToString
                    cxbxGrant.Checked = True
                Else
                    txtGrant.Text = ""
                    cxbxGrant.Checked = False
                End If


                txtFName.Text = MeData.Rows(0).Item("first_name").ToString
                txtMName.Text = MeData.Rows(0).Item("middle_name").ToString
                txtLName.Text = MeData.Rows(0).Item("last_name").ToString


                getCategory()
                getCourseLevel()
                getBatch()

                cmbCategory.Enabled = True
                '           cmbCategory.Focus()
            End If
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If txtIDNum.Text = "" Then
                MsgBox("Please check Entry, ID Number is required", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If ifStudentIDExist(txtIDNum.Text) And rbtnNew.Checked Then
                MsgBox("Please check Entry, ID Number Exists.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If MessageBox.Show("Are you sure you want to Continue And Save Student Data?", "Please Verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                saveStudentsData()
            Else
                Exit Sub
            End If


            Dim SQLEX As String = "SELECT id from students where admission_no='" & txtAdmNum.Text & "'"

            Dim userData As DataTable
            userData = clsDBConn.ExecQuery(SQLEX)
            If userData.Rows.Count > 0 Then
                txtStudentDBID.Text = userData.Rows(0).Item("id").ToString
            End If

            _courseID = cmbCourseGrade.SelectedValue
            _batchID = cmbBatch.SelectedValue
            _studentID = txtStudentDBID.Text

            With fmaStudentsSubjectListForm
                .txtCategory.Text = cmbCategory.Text
                .txtStudentID.Text = txtStudentDBID.Text
                .txtCoursename.Text = cmbCourseGrade.Text
                .txtCoursename.Tag = cmbCourseGrade.SelectedValue
                .txtBatchName.Text = cmbBatch.Text
                .txtBatchName.Tag = cmbBatch.SelectedValue
                .txtStudentName.Text = txtLName.Text _
                                       & ", " & txtFName.Text _
                                       & " " & txtMName.Text
                .txtAdmissionNo.Text = txtAdmNum.Text
            End With

            fmaStudentsSubjectListForm.ShowDialog(Me)
            clearData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub saveStudentsData()

        '      SavePicture()

        If txtIDNum.Text = "" Then
            Exit Sub
        End If
        Dim SQLIN As String = ""

        If cxbxGrant.Checked Then

            If txtGrant.Text.Length = 0 Then
                MsgBox("Please Fill Scholarship Grant.", MsgBoxStyle.Critical)
            End If


            Dim gender As String = ""
            If rbtnMale.Checked Then
                gender = "m"
            Else
                gender = "f"
            End If
            'create new User Account
            Dim userID As String = ""
            If student_userID = 0 Then
                userID = createNewUserAccount()
            Else
                userID = student_userID
                ClassRollNo = student_class_roll_no
            End If
            '   Dim userID As String = createNewUserAccount()
            txtAdmNum.Text = generateAdmissionNum()

            'Update End Time
            UpdateEndTime(student_class_roll_no)



            SQLIN = "INSERT INTO students(admission_no,class_roll_no,admission_date,"
            SQLIN += " batch_id,student_category_id,academice_year,"
            SQLIN += " user_id,stature,std_number,"
            SQLIN += " scholarshipgrant,has_paid_fees,person_id,year_level,semester,status_description,course_id,"
            SQLIN += " runningbalance "
            SQLIN += ")"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}','{1}','{2}',", txtAdmNum.Text, ClassRollNo, Format(dtpAdmDate.Value, "yyyy-MM-dd"))
            SQLIN += String.Format("'{0}','{1}','{2}',", txtBatchID.Text, txtCatID.Text, cmbYearFrom.Text & "-" & cmbYearTo.Text)
            SQLIN += String.Format("'{0}','{1}','{2}',", userID, cmbStature.Text, txtIDNum.Text)
            SQLIN += String.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}',", txtGrant.Text.Replace("'", "`"), "1", SelectedRow("person_id"), cmbYearLevel.Text, cmbSemester.Text, cmbStatus.Text, cmbCourseGrade.SelectedValue)
            If chkBBal.Checked = True Then
                SQLIN += String.Format("'{0}'", txtRemainingBalance.Text)
            Else
                SQLIN += String.Format("'{0}'", 0)
            End If
            SQLIN += ")"
            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Student data has been saved.", MsgBoxStyle.Information)
            End If


        Else
            'create new User Account
            Dim userID As String = ""
            If student_userID = 0 Then
                userID = createNewUserAccount()
            Else
                userID = student_userID
                ClassRollNo = student_class_roll_no
            End If
            '   Dim userID As String = createNewUserAccount()
            txtAdmNum.Text = generateAdmissionNum()

            Dim gender As String = ""
            If rbtnMale.Checked Then
                gender = "m"
            Else
                gender = "f"
            End If

            'Update End Time
            UpdateEndTime(student_class_roll_no)

            SQLIN = "INSERT INTO students(admission_no,class_roll_no,admission_date,"
            SQLIN += " batch_id,student_category_id,academice_year,"
            SQLIN += " user_id,stature,std_number,"
            SQLIN += " person_id,year_level,semester,enrollmentAS,course_id,"
            SQLIN += " runningbalance "
            SQLIN += ")"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}','{1}','{2}',", txtAdmNum.Text, ClassRollNo, Format(dtpAdmDate.Value, "yyyy-MM-dd"))
            SQLIN += String.Format("'{0}','{1}','{2}',", txtBatchID.Text, txtCatID.Text, cmbYearFrom.Text & "-" & cmbYearTo.Text)
            SQLIN += String.Format("'{0}','{1}','{2}',", userID, cmbStature.Text, txtIDNum.Text)
            SQLIN += String.Format("'{0}','{1}','{2}','{3}','{4}',", SelectedRow("person_id"), cmbYearLevel.Text, cmbSemester.Text, cmbStatus.Text, cmbCourseGrade.SelectedValue)
            If chkBBal.Checked = True Then
                SQLIN += String.Format("'{0}'", txtRemainingBalance.Text)
            Else
                SQLIN += String.Format("'{0}'", 0)
            End If
            SQLIN += ")"

            If clsDBConn.Execute(SQLIN) Then
                MsgBox("Student data has been saved.", MsgBoxStyle.Information)
            End If
        End If

        If BrowsePic_Selected = True Then
            SavePicture()
        End If


    End Sub

    Private Sub UpdateEndTime(student_class_roll_no As Integer)
        Dim id As Integer = DataObject(String.Format("SELECT 	IFNULL(Max(id),1)  FROM	students WHERE	status_type_id = 1 	AND class_roll_no = '" & student_class_roll_no & "'"))
        If id > 0 Then
            DataSource(String.Format("UPDATE `students` SET `end_time` = '" & Format(Date.Now, "yyyy-MM-dd H:mm:ss") & "'  WHERE id = '" & id & "'"))
        End If

    End Sub

    Dim _photo_filename As String
    Dim _photo_original_filename As String
    Dim _photo_path As String
    Private Sub SavePicture()

        If txtPhotoFileName.Text <> "" Then

            _photo_filename = stedent_fullname & ".jpeg" 'txtIDNum.Text & ".jpeg"
            _photo_original_filename = txtPhotoFileName.Text
            _photo_path = _spath & _photo_filename

            Dim _File As Image
            _File = pbxphoto.Image
            pbxphoto.Image = _File
            If Not File.Exists(_photo_path) Then
                pbxphoto.Image.Save(_photo_path)
            End If


            DataSource(String.Format("DELETE FROM person_photo WHERE person_photo.person_id = '" & SelectedRow.Item("person_id") & "'"))
            DataSource(String.Format("INSERT INTO  `person_photo`
                                    (
                                     `person_id`,
                                     `photo_file_name`,
                                     `photo_path`,
                                     `original_file_name`)
	                            VALUES (
		                            '" & SelectedRow.Item("person_id") & "',
		                            '" & _photo_filename & "',
		                            '" & _photo_path & "',
		                            '" & _photo_original_filename & "');"))

        End If


    End Sub


    Private Sub SaveImage(photo_path As String)

        Try
            Using bmp As New Bitmap(pbxphoto.Image)
                bmp.Save(photo_path, Drawing.Imaging.ImageFormat.Jpeg)

                '   bmp.Save(IO.Path.Combine(photo_path, _photo_filename), Imaging.ImageFormat.Jpeg)
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & vbCrLf &
                        ex.Message, "Error Saving Image File",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Dim _spath As String
    Private Sub createStudentCategoryFolder(CategoryName As String)


        Dim spath As String = Directory.GetCurrentDirectory & "\PIC\"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, CategoryName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, CategoryName))
        End If

        spath = spath + cmbCategory.Text + "\"
        _spath = spath

    End Sub

    Private Sub createStudentCourseFolder(CourseName As String)

        Dim spath As String = Directory.GetCurrentDirectory & "\PIC\"

        spath += cmbCategory.Text & "\"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, CourseName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, CourseName))
        End If
        spath = spath + CourseName + "\"
        _spath = spath

    End Sub

    Private Sub createStudentBatchFolder()

        Dim spath As String = Directory.GetCurrentDirectory & "\PIC\"

        spath += cmbCategory.Text & "\" & cmbCourseGrade.Text & "\"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, cmbBatch.Text))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, cmbBatch.Text))
        Else
            spath = spath & cmbBatch.Text & "\"
        End If

        _spath = spath

    End Sub

    Private Function createNewUserAccount() As String
        Dim userID As String = ""

        Dim salt As String = CREATERANDOMSALT()
        Dim hashedPassword As String = HASH512(UserName, salt) ' txtAdmNum.Text


        Dim SQLIN As String = "INSERT INTO users(username,first_name,last_name,student,admin,employee,hashed_password,salt,application_setup_id)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}', '{1}',", UserName, txtFName.Text)
        SQLIN += String.Format("'{0}', '{1}',", txtLName.Text, "1")
        SQLIN += String.Format("'{0}', '{1}',", "0", "0")
        SQLIN += String.Format("'{0}', '{1}','{2}')", hashedPassword, salt, AppSetup_Domain)

        If clsDBConn.Execute(SQLIN) Then
            Dim SQLEX As String = "SELECT id from users where username='" & UserName & "'"

            Dim userData As DataTable
            userData = clsDBConn.ExecQuery(SQLEX)

            If userData.Rows.Count > 0 Then
                userID = userData.Rows(0).Item("id").ToString
            End If
        End If

        Return userID
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearData()
        Me.Close()
    End Sub

    Private Sub cxbxGrant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxbxGrant.CheckedChanged
        If cxbxGrant.Checked Then
            txtGrant.Enabled = False

            '      txtGrant.ReadOnly = False
        Else
            txtGrant.Enabled = True
            '         txtGrant.ReadOnly = True
        End If
        txtGrant.SelectedIndex = 0
    End Sub

    Private Sub txtGrant_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not cxbxGrant.Checked Then
            MsgBox("Please Check Waive All Fees.", MsgBoxStyle.Information)
        End If
    End Sub

    Dim BrowsePic_Selected As Boolean
    Private Sub ButtonBrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowsePic.Click

        Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = ""
        OpenFileDialog.RestoreDirectory = True
        OpenFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpg|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            picturePath = OpenFileDialog.FileName
            Me.pbxphoto.Image = New System.Drawing.Bitmap(picturePath)

            txtPhotoFileName.Text = OpenFileDialog.FileName
            Dim names = txtPhotoFileName.Text.Trim
            Dim phrase As String = names.Substring(names.LastIndexOf("\"c) + 1)
            txtPhotoFileName.Text = phrase

            BrowsePic_Selected = True

        End If

        Dim Exist As Boolean = CheckImage(txtPhotoFileName.Text)
        If Exist Then
            MsgBox("Image is already in use", MsgBoxStyle.Information, "ALREADY EXIST")

            txtPhotoFileName.Text = ""
            loadPicture(False, "")

            Exit Sub
        End If


    End Sub

    Private Function CheckImage(ImgeFile As String) As Boolean
        Dim _ImageFileName As String = DataObject(String.Format("SELECT `original_file_name` FROM `person_photo` WHERE person_photo.original_file_name  = '" & ImgeFile & "'"))
        If _ImageFileName = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub clearData()

        dtpAdmDate.Value = Date.Now
        '     getCategory()
        '      getCourseLevel()
        '     getBatch()

        cxbxGrant.Checked = False
        txtGrant.Text = Nothing
        '       txtGrant.ReadOnly = True
        txtGrant.Enabled = True

        txtAdmNum.Text = ""
        txtIDNum.Text = ""

        txtCourseCode.Text = ""
        txtCourseID.Text = ""


        txtLName.Text = ""
        txtFName.Text = ""
        txtMName.Text = ""
        txtContactNumber.Text = ""
        txtCurrentAddress.Text = ""
        txtAge.Text = ""
        dtpDateBirth.Value = Date.Now


        cmbYearLevel.SelectedIndex = -1
        '      cmbSemester.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbStature.SelectedIndex = -1


        cmbCategory.SelectedIndex = -1
        cmbCourseGrade.SelectedIndex = -1
        cmbBatch.SelectedIndex = -1

        pbxphoto.Image = Default_Image

    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged

        If txtFilter.Text.Length > 0 Then

            ProcessFilterText(txtFilter.Text)
            txtFilter.SelectionStart += 1

        Else
            dtpAdmDate.Value = Format(Date.Now.Date, "yyyy-MM-dd")
            txtAdmNum.Text = ""
            txtIDNum.Text = ""
            txtLName.Text = ""
            txtFName.Text = ""
            txtMName.Text = ""

            EnrollmentAS.Text = ""
            AssingningRadioBtn(EnrollmentAS.Text)
            cmbYearLevel.Text = ""
            '        cmbSemester.Text = ""
            dtpDateBirth.Value = Format(Date.Now.Date, "yyyy-MM-dd")
            txtContactNumber.Text = ""
            txtCurrentAddress.Text = ""
        End If

    End Sub

    Private Sub ProcessFilterText(text As String)

        txtFilter.Text = text

        Dim rows = dt.Select("first_name LIKE '%" & txtFilter.Text & "%' OR middle_name LIKE '%" & txtFilter.Text & "%' OR last_name LIKE '%" & txtFilter.Text & "%' or admission_no LIKE '%" & txtFilter.Text & "%' or class_roll_no like  '%" & txtFilter.Text & "%' ")

        dtpAdmDate.Value = If(IsDBNull(rows(0).Item("admission_date")), Format(Date.Now.Date, "yyyy-MM-dd"), rows(0).Item("admission_date"))
        txtAdmNum.Text = If(IsDBNull(rows(0).Item("admission_no")), "", rows(0).Item("admission_no"))
        txtIDNum.Text = If(IsDBNull(rows(0).Item("class_roll_no")), "", rows(0).Item("class_roll_no"))
        txtLName.Text = If(IsDBNull(rows(0).Item("last_name")), "", rows(0).Item("last_name"))
        txtFName.Text = If(IsDBNull(rows(0).Item("first_name")), "", rows(0).Item("first_name"))
        txtMName.Text = If(IsDBNull(rows(0).Item("middle_name")), "", rows(0).Item("middle_name"))

        EnrollmentAS.Text = If(IsDBNull(rows(0).Item("enrollmentAS")), "", rows(0).Item("enrollmentAS"))
        AssingningRadioBtn(EnrollmentAS.Text)

        cmbYearLevel.Text = If(IsDBNull(rows(0).Item("year_level")), "", rows(0).Item("year_level"))
        cmbSemester.Text = If(IsDBNull(rows(0).Item("semester")), "", rows(0).Item("semester"))
        dtpDateBirth.Value = If(IsDBNull(rows(0).Item("date_of_birth")), Format(Date.Now.Date, "yyyy-MM-dd"), rows(0).Item("date_of_birth"))
        txtContactNumber.Text = If(IsDBNull(rows(0).Item("phone1")), "", rows(0).Item("phone1"))
        txtCurrentAddress.Text = If(IsDBNull(rows(0).Item("Address")), "", rows(0).Item("Address"))

        Dim gender = If(IsDBNull(rows(0).Item("gender")), "", rows(0).Item("gender"))
        AssingRadioBtnGender(gender)



    End Sub

    Private Sub AssingRadioBtnGender(gender As Object)

        Dim _gender As String = gender

        Select Case _gender.ToLower
            Case rbtnfeMale.Text
                rbtnfeMale.Checked = True
            Case Else
                rbtnMale.Checked = True
        End Select
    End Sub

    Private Sub AssingningRadioBtn(text As String)

        Select Case text
            Case "Freshman"
                RadioButton1.Checked = True
            Case "Undergraduate Transfer"
                RadioButton2.Checked = True
            Case "2nd Bachelor's Degree"
                RadioButton3.Checked = True
            Case "Former Student Returning"
                RadioButton4.Checked = True
            Case Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
        End Select

    End Sub

    Private Sub GroupBoxPaint(sender As Object, e As PaintEventArgs)

        Dim grpBox As GroupBox = DirectCast(sender, GroupBox)

        Dim tSize As Size = TextRenderer.MeasureText(grpBox.Text, grpBox.Font)
        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = (borderRect.Y _
                    + (tSize.Height / 2))
        borderRect.Height = (borderRect.Height _
                    - (tSize.Height / 2))
        ControlPaint.DrawBorder(e.Graphics, borderRect, borderColor, ButtonBorderStyle.Solid)
        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        e.Graphics.FillRectangle(New SolidBrush(grpBox.BackColor), textRect)
        e.Graphics.DrawString(grpBox.Text, grpBox.Font, New SolidBrush(grpBox.ForeColor), textRect)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        getEnrollmentAS(sender)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        getEnrollmentAS(sender)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        getEnrollmentAS(sender)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        getEnrollmentAS(sender)
    End Sub

    Private Sub getEnrollmentAS(sender As Object)
        Dim Enrollment As RadioButton = DirectCast(sender, RadioButton)
        EnrollmentAS.Text = Enrollment.Text
    End Sub

    Dim str1 As String = ""
    'Private Sub EnrollmentAS_Paint(sender As Object, e As PaintEventArgs) Handles EnrollmentAS.Paint

    '    If EnrollmentAS.Text <> str1 Then
    '        GroupBoxPaint(sender, e)
    '        str1 = EnrollmentAS.Text
    '    End If

    ' End Sub

    Dim str2 As String = ""
    Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint

        If GroupBox1.Text <> str2 Then
            GroupBoxPaint(sender, e)
            str2 = GroupBox1.Text
        End If

    End Sub

    Private Sub txtFilter_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtFilter.PreviewKeyDown

        If e.KeyCode = Keys.Back Then
            If txtFilter.Text.Length = 1 Then

                ProcessFilterText(txtFilter.Text)

            End If
        Else
            ProcessFilterText(txtFilter.Text)
            txtFilter.SelectionStart += 1
        End If
        '     txtFilter.SelectionStart = 0
    End Sub

    Dim str3 As String = ""

    Private Sub btbnew_Click(sender As Object, e As EventArgs) Handles btbnew.Click
        checkRadioBtn(btbnew.Tag)
        Panel2.Enabled = True

        AccessButton(btbnew.Text)
    End Sub

    Private Sub AccessButton(btnName)
        If btnName = "NEW STUDENT" Then
            btbnew.ColorTable = eButtonColor.BlueOrb
            btbnew.ForeColor = System.Drawing.SystemColors.ControlLightLight
            btnold.ColorTable = eButtonColor.Office2007WithBackground
            btnold.ForeColor = System.Drawing.SystemColors.Desktop
        Else
            btnold.ColorTable = eButtonColor.BlueOrb
            btnold.ForeColor = System.Drawing.SystemColors.ControlLightLight
            btbnew.ColorTable = eButtonColor.Office2007WithBackground
            btbnew.ForeColor = System.Drawing.SystemColors.Desktop
        End If
    End Sub

    Private Sub checkRadioBtn(tag As Object)
        If tag = 1 Then
            rbtnNew.Checked = True
        Else
            rbtnOld.Checked = True
        End If
        AcademicYear = cmbYearFrom.Text & "-" & cmbYearTo.Text
        Dim frm As New frmFilterPerson
        frm.Tag = tag
        frm.AcademicYear = AcademicYear
        frm.Semester = cmbSemester.Text
        frm.BringToFront()
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then

            getCategory()
            getCourseLevel()
            getBatch()

            SelectedRow = frm.SelectedRow
            SelectedRowAssingValue(frm.SelectedRow)
            frm.Close()
            '      cmbCategory.Text = Focus()

        Else
            frm.Close()

        End If
        cmbSemester.Text = SemesterName
        '     cmbCategory.Focus()
    End Sub

    Private Function CheckIfStudentIsAlreadyEnrolled(personID As Integer, academicYear As String, semester As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT id FROM students WHERE status_type_id = 1 AND person_id = '" & personID & "' AND semester = '" & semester & "' AND academice_year = '" & academicYear & "'"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Dim student_userID As Integer = 0
    Dim student_class_roll_no As Integer = 0
    Dim stedent_fullname As String
    Private Sub SelectedRowAssingValue(selectedRow As DataRow)

        Dim CategoryID As Integer = 0
        Dim CourseID As Integer = 0
        If selectedRow IsNot Nothing Then

            student_class_roll_no = If(IsDBNull(selectedRow("class_roll_no")), 0, selectedRow("class_roll_no"))
            ClassRollNo = student_class_roll_no
            txtIDNum.Text = If(IsDBNull(selectedRow("ID NUMBER")), "", selectedRow("ID NUMBER"))
            txtLName.Text = If(IsDBNull(selectedRow("last_name")), "", selectedRow("last_name"))
            txtFName.Text = If(IsDBNull(selectedRow("first_name")), "", selectedRow("first_name"))
            txtMName.Text = If(IsDBNull(selectedRow("middle_name")), "", selectedRow("middle_name"))

            stedent_fullname = txtLName.Text & ", " & txtFName.Text & " " & txtMName.Text

            txtContactNumber.Text = If(IsDBNull(selectedRow("ContactNumber")), "", selectedRow("ContactNumber"))
            txtCurrentAddress.Text = If(IsDBNull(selectedRow("Address")), "", selectedRow("Address"))
            txtRemainingBalance.Text = If(IsDBNull(selectedRow("runningbalance")), "", selectedRow("runningbalance"))
            txtRemainingBalance.Text = If(IsDBNull(selectedRow("scholarshipgrant")), "", selectedRow("scholarshipgrant"))

            Dim gender = If(IsDBNull(selectedRow("gender")), "", selectedRow("gender"))
            AssingRadioBtnGender(gender)

            dtpDateBirth.Value = If(IsDBNull(selectedRow("date_of_birth")), Format(Date.Now.Date, "yyyy-MM-dd"), selectedRow("date_of_birth"))
            txtAge.Text = GetCurrentAge(dtpDateBirth.Value)
            txtPhotoFileName.Text = If(IsDBNull(selectedRow("photo_file_name")), "", selectedRow("photo_file_name"))

            cmbStature.Text = If(IsDBNull(selectedRow("stature")), "", selectedRow("stature"))
            CategoryID = If(IsDBNull(selectedRow("student_category_id")), 0, selectedRow("student_category_id"))
            If CategoryID > 0 Then
                cmbCategory.SelectedValue = CategoryID
                cmbCategory_SelectionChangeCommitted(_sender, _e)
            Else
                cmbCategory.SelectedIndex = -1
            End If
            CourseID = If(IsDBNull(selectedRow("course_id")), 0, selectedRow("course_id"))
            If CourseID > 0 Then
                cmbCourseGrade.SelectedValue = CourseID
                cmbCourseGrade_SelectionChangeCommitted(_sender, _e)
            Else
                cmbCourseGrade.SelectedIndex = -1
            End If

            student_userID = If(IsDBNull(selectedRow("user_id")), 0, selectedRow("user_id"))


            If Not txtPhotoFileName.Text.Length = 0 Then
                Dim curPath = Directory.GetCurrentDirectory
                If rbtnNew.Checked Then
                    Dir = curPath & "\PIC\PERSON\"
                Else
                    curPath = curPath & "\PIC\"

                    Dim dt As New DataTable
                    dt = getStudentDescription(selectedRow("person_id"))

                    Dim Category = If(IsDBNull(dt(0)("name").ToString), "", dt(0)("name").ToString)
                    Dim Course = If(IsDBNull(dt(0)("course_name").ToString), "", dt(0)("course_name").ToString)
                    '           Dim Bacth = If(IsDBNull(dt(0)("batches.`name``").ToString), "", dt(0)("batches.`name``").ToString)

                    '         Dir = System.IO.Path.Combine(curPath, Category & "\", Course & "\")
                End If

                loadPicture(True, txtPhotoFileName.Text)
            End If
        End If

            cmbStature.Enabled = True
        '       cmbCategory.SelectedValue = 13
        '       cmbCourseGrade.Enabled = True
    End Sub

    Private Function getStudentDescription(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students.person_id,
students.id,
student_categories.`name`,
courses.course_name

FROM
students
INNER JOIN student_categories ON students.student_category_id = student_categories.id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN batches ON students.batch_id = batches.id
WHERE
students.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Private Function getPhotoPath(personID As Object) As String
        Dim path As String = DataObject(String.Format("SELECT person_photo.photo_path FROM `person_photo` WHERE person_photo.person_id = '" & personID & "'"))
        Return path
    End Function

    Private Function GetCurrentAge(value As Date) As String
        Dim age As Integer
        age = Today.Year - value.Year
        If (value > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub loadPicture(Optional ByVal isSelected As Boolean = False, Optional ByVal ImageFile As String = Nothing)
        Dim PathDestination As String = ""
        If isSelected Then
            PathDestination = ImageFile
            If PathDestination = "" Then
                pbxphoto.SizeMode = PictureBoxSizeMode.StretchImage
                pbxphoto.BorderStyle = BorderStyle.Fixed3D
                pbxphoto.Load(DefautltPic)
            Else
                Try
                    PathDestination = Dir & ImageFile
                    picturePath = PathDestination
                    pbxphoto.SizeMode = PictureBoxSizeMode.StretchImage
                    pbxphoto.BorderStyle = BorderStyle.Fixed3D
                    pbxphoto.Load(PathDestination)
                Catch ex As Exception
                    pbxphoto.SizeMode = PictureBoxSizeMode.StretchImage
                    pbxphoto.BorderStyle = BorderStyle.Fixed3D
                    '      pbxphoto.Load(Default_Image)
                    pbxphoto.Image = Default_Image
                End Try

            End If
        Else

            pbxphoto.SizeMode = PictureBoxSizeMode.StretchImage
            pbxphoto.BorderStyle = BorderStyle.Fixed3D
            '      pbxphoto.Load(Default_Image)
            pbxphoto.Image = Default_Image

        End If
    End Sub

    Private Sub btnold_Click(sender As Object, e As EventArgs) Handles btnold.Click
        checkRadioBtn(btnold.Tag)
        Panel2.Enabled = True
        AccessButton(btnold.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkBBal.CheckedChanged
        txtRemainingBalance.Enabled = True
    End Sub

    Private Sub chkManulStdNum_CheckedChanged(sender As Object, e As EventArgs) Handles chkManulStdNum.CheckedChanged
        If chkManulStdNum.Checked = True Then
            txtIDNum.Enabled = True
        Else
            txtIDNum.Enabled = False
        End If
    End Sub

    Private Sub cmbYear_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbYearFrom.SelectionChangeCommitted
        Panel6.Enabled = True
    End Sub
    Dim SemesterName As String = ""
    Private cmbyearBatch As Object

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        SemesterName = cmbSemester.Text
        Panel6.Enabled = True
    End Sub

    Private Sub cmbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbStatus.SelectionChangeCommitted
        cmbStature.Focus()
    End Sub

    Private Sub cmbYearLevel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbYearLevel.SelectionChangeCommitted
        cmbStatus.Focus()
    End Sub

    Private Sub btnSave_ClientSizeChanged(sender As Object, e As EventArgs) Handles btnSave.ClientSizeChanged

    End Sub

    Private Sub txtGrant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGrant.SelectedIndexChanged
        cxbxGrant.Checked = True
    End Sub
End Class
