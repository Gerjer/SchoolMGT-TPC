Imports System.Threading
Imports System.ComponentModel
Imports SchoolMGT
Imports System.Web.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevComponents.DotNetBar
'Imports Microsoft.VisualBasic
'Imports System
'Imports System.Web.UI.WebControls
'Imports DevExpress.Web
'Imports DevExpress.Web.Demos


Public Class fmaEmployeeListForm
    Private Class1 As New Class1
    '   Private m_AsyncWorker As New BackgroundWorker()

    Private WithEvents SETUPFORM As fmaEmployeeRecord
    Dim RecordModel As EmployeeRecordModel
    Dim id As Integer
    Dim personID As Integer
    Private TABLENAME As String = "person"



    Private Sub fmaStudentListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Privilege_TypeUser = DataObject(String.Format("SELECT IFNULL(type_user,'') FROM privileges_users WHERE user_id = '" & LoginUserID & "' and privilege_id = '" & MenuItemID & "'"))

        Timer1.Interval = 1000


        lblStatus.Text = "Waiting ..."
        tdbViewer.DataSource = Nothing
        '      displayFilterCategory()
        '       new_displayFilterCategory()

        XtraTabPage2.Text = "CUMMULATIVE LIST"
        XtraTabControl1.TabPages.Remove(XtraTabPage1)
        FirstLoad = False
    End Sub

    Dim dt_PersonList As New DataTable
    Public Sub new_displayFilterCategory()

        gvPersonList.Columns.Clear()
        Dim dt As New DataTable

        Dim SQLEX As String = ""

        '     If AuthUserType = "SUPERUSER" Or Privilege_TypeUser = "USER" Then


        '         If Me.Tag = 1 Then

        '             SQLEX = "SELECT
        '           `person`.`person_id` '/person_id'
        '             , `employees`.`id` '/id'
        '             , `users`.`username` AS 'UserName'
        '             , `employees`.empl_number AS '|EMPLOYEE NUMBER'
        '             , `person`.`first_name` 'FIRST NAME'
        '             , IFNULL(`person`.`middle_name`,'')'MIDDLE NAME'
        '             , `person`.`last_name` 'LAST NAME'
        '             , DATE_FORMAT(`employees`.`joining_date`,'%M %d,%Y') AS '|JOIN DATE'
        '             , `employee_departments`.`name` AS 'DEPARTMENT'     
        '             , `employee_positions`.`name` 'POSITION',
        '             CONCAT(`person`.`last_name`,', ',`person`.`first_name`,' ',IFNULL(`person`.`middle_name`,'')) '/FILTERNAME'
        '         FROM
        '             `person`
        '             INNER JOIN `employees` 
        '          ON (`person`.`person_id` = `employees`.`person_id`)
        '             LEFT JOIN `users` 
        '          ON (`employees`.`user_id` = `users`.`id`)
        '             INNER JOIN `employee_departments` 
        '          ON (`employees`.`employee_department_id` = `employee_departments`.`id`)
        '             INNER JOIN `employee_positions` 
        '          ON (`employees`.`employee_position_id` = `employee_positions`.`id`)

        '             where person.first_name LIKE '%" & txtEmpName.Text & "%' OR
        '                   person.middle_name LIKE '%" & txtEmpName.Text & "%' OR
        '                   person.last_name LIKE '%" & txtEmpName.Text & "%' and
        '                   employees.status_type_id = 1 and employees.end_time is null AND
        '                   person_type_id = 1
        '             ;"

        '         Else
        '             SQLEX = "SELECT
        'person_id '/person_id',
        'id '/id',
        'username 'USER NAME',
        '   std_number '|STUDENT NUMBER',
        'CONCAT(last_name,', ',first_name,' ',middle_name) 'STUDENT NAME',                                                
        'DATE_FORMAT(date_of_birth,'%M %d, %Y') as '|BIRTH DATE',
        'gender '|GENDER',
        'contact_person 'GUARDIAN',
        'course_name 'COURSE',
        'scholarship_sponsor_name 'SCHOLARSHIP',
        'stature 'STATURE',
        '         CONCAT(last_name,', ',first_name,' ',middle_name) '/FILTERNAME'

        '	FROM(
        '		SELECT
        '		`person`.`person_id`
        '		, `students`.`id`
        '		, `users`.`username`
        '		, students.std_number
        '		, `person`.`first_name`
        '		, IFNULL(`person`.`middle_name`,'')'middle_name'
        '		, `person`.`last_name`
        '		, `person`.date_of_birth 
        '		,  `person`.gender
        '		,  contact_person
        '		, `courses`.`course_name` 
        '		, students.stature
        '		, scholarship_sponsor_name
        '                 , person_type_id
        'FROM
        '`person`
        '		LEFT JOIN `students` 
        '		ON (`person`.`person_id` = `students`.`person_id` AND `students`.end_time IS NULL)
        '		LEFT JOIN `users` 
        '		ON (`users`.`id` = `students`.`user_id`)	                    
        '		LEFT JOIN `courses` 
        '		ON (`students`.`course_id` = `courses`.`id`)
        '		LEFT JOIN `students_details` 
        '		ON (students_details.person_id =  `person`.`person_id`)
        '		LEFT JOIN `person_contact_person` 
        '		ON (`person_contact_person`.person_id =  `person`.`person_id`)

        ' where person.first_name LIKE '%" & txtEmpName.Text & "%' OR
        '			person.middle_name LIKE '%" & txtEmpName.Text & "%' OR
        '			person.last_name LIKE '%" & txtEmpName.Text & "%' and
        '			person.person_type_id = 2 AND
        '			person.status_type_id = 1 AND person.end_time IS NULL 
        '				)A
        '            WHERE person_type_id = 2;"
        '         End If

        '     Else
        '         SQLEX = "	SELECT
        '        person_id AS '/person_id',
        '        StudentID AS '/id',
        '       `USER NAME`,
        '       `|STUDENT NUMBER`,
        '       `STUDENT NAME`,
        '       `|BIRTH DATE`,
        '       `|GENDER`,
        '       `GUARDIAN`,
        '       `COURSE`,
        '       `SCHOLARSHIP`,
        '       `STATURE`,
        '          display_name '/FILTERNAME'


        '       FROM(		
        '	        SELECT DISTINCT
        '	        employees.id,
        '	        users.id 'UserID',
        '	        person.person_id,
        '	        students.id AS 'StudentID',
        '	        users.username AS `USER NAME`,
        '	        students.std_number AS `|STUDENT NUMBER`,
        '	        person.display_name AS `STUDENT NAME`,
        '	        DATE_FORMAT(person.date_of_birth,'%M %d, %Y') AS `|BIRTH DATE`,
        '	        person.gender AS `|GENDER`,
        '	        person_contact_person.contact_person AS GUARDIAN,
        '	        courses.course_name AS COURSE,
        '	        students_details.scholarship_sponsor_name AS SCHOLARSHIP,
        '	        students.stature AS STATURE,
        '                      person.display_name

        '	        FROM
        '	        employees
        '	        INNER JOIN subject_class_schedule ON employees.id = subject_class_schedule.employee_id
        '	        INNER JOIN students_subjects ON subject_class_schedule.subject_id = students_subjects.id
        '	        INNER JOIN students ON students_subjects.student_id = students.id
        '	        INNER JOIN courses ON students.course_id = courses.id
        '	        INNER JOIN person ON students.person_id = person.person_id
        '	        INNER JOIN users ON employees.user_id = users.id
        '	        LEFT JOIN person_contact_person ON person.person_id = person_contact_person.person_id
        '	        LEFT JOIN students_details ON person.person_id = students_details.person_id
        '	        WHERE
        '	        person.status_type_id = 1 AND
        '	        person.end_time IS NULL AND
        '	        person.first_name LIKE '%" & txtEmpName.Text & "%' OR
        '	        person.middle_name LIKE '%" & txtEmpName.Text & "%' OR
        '	        person.last_name LIKE '%" & txtEmpName.Text & "%' 

        '            ORDER BY `UserID`,`StudentID`


        '            )A WHERE  `UserID` = '" & LoginUserID & "'"

        '     End If

        If Me.Tag = 1 Then

            SQLEX = "SELECT
              `person`.`person_id` '/person_id'
                , `employees`.`id` '/id'
                , `users`.`username` AS 'UserName'
                , `employees`.empl_number AS '|EMPLOYEE NUMBER'
                , `person`.`first_name` 'FIRST NAME'
                , IFNULL(`person`.`middle_name`,'')'MIDDLE NAME'
                , `person`.`last_name` 'LAST NAME'
                , DATE_FORMAT(`employees`.`joining_date`,'%M %d,%Y') AS '|JOIN DATE'
                , `employee_departments`.`name` AS 'DEPARTMENT'     
                , `employee_positions`.`name` 'POSITION'
                ,CONCAT(`person`.`last_name`,', ',`person`.`first_name`,' ',IFNULL(`person`.`middle_name`,'')) '/FILTERNAME'
                ,photo_file_name 'PHOTO'

            FROM
                `person`
                INNER JOIN `employees` 
	            ON (`person`.`person_id` = `employees`.`person_id`)
                LEFT JOIN `users` 
	            ON (`employees`.`user_id` = `users`.`id`)
                INNER JOIN `employee_departments` 
	            ON (`employees`.`employee_department_id` = `employee_departments`.`id`)
                INNER JOIN `employee_positions` 
	            ON (`employees`.`employee_position_id` = `employee_positions`.`id`)
                LEFT JOIN `person_photo`
	     		ON (`person`.`person_id` = `person_photo`.person_id)

                where person.first_name LIKE '%" & txtEmpName.Text & "%' OR
                      person.middle_name LIKE '%" & txtEmpName.Text & "%' OR
                      person.last_name LIKE '%" & txtEmpName.Text & "%' and
                      employees.status_type_id = 1 and employees.end_time is null AND
                      person_type_id = 1
                ;"

        Else
            SQLEX = "SELECT
			person_id '/person_id',
			id '/id',
			username 'USER NAME',
		    std_number '|STUDENT NUMBER',
			CONCAT(last_name,', ',first_name,' ',middle_name) 'STUDENT NAME',                                                
			DATE_FORMAT(date_of_birth,'%M %d, %Y') as '|BIRTH DATE',
			gender '|GENDER',
			contact_person 'GUARDIAN',
			course_name 'COURSE',
			scholarship_sponsor_name 'SCHOLARSHIP',
			stature 'STATURE',
            CONCAT(last_name,', ',first_name,' ',middle_name) '/FILTERNAME',
            photo_file_name 'PHOTO'
			
				FROM(
					SELECT
					`person`.`person_id`
					, `students`.`id`
					, `users`.`username`
					, students.std_number
					, `person`.`first_name`
					, IFNULL(`person`.`middle_name`,'')'middle_name'
					, `person`.`last_name`
					, `person`.date_of_birth 
					,  `person`.gender
					,  contact_person
					, `courses`.`course_name` 
					, students.stature
					, scholarship_sponsor_name
                    , person_type_id
                    ,photo_file_name
			FROM
			`person`
					LEFT JOIN `students` 
					ON (`person`.`person_id` = `students`.`person_id` AND `students`.end_time IS NULL)
					LEFT JOIN `users` 
					ON (`users`.`id` = `students`.`user_id`)	                    
					LEFT JOIN `courses` 
					ON (`students`.`course_id` = `courses`.`id`)
					LEFT JOIN `students_details` 
					ON (students_details.person_id =  `person`.`person_id`)
					LEFT JOIN `person_contact_person` 
					ON (`person_contact_person`.person_id =  `person`.`person_id`)
                    LEFT JOIN `person_photo`
					ON (`person`.`person_id` = `person_photo`.person_id)
		 
			 where person.first_name LIKE '%" & txtEmpName.Text & "%' OR
						person.middle_name LIKE '%" & txtEmpName.Text & "%' OR
						person.last_name LIKE '%" & txtEmpName.Text & "%' and
						person.person_type_id = 2 AND
						person.status_type_id = 1 AND person.end_time IS NULL 
							)A
               WHERE person_type_id = 2;"
        End If

        dt = DataSource(SQLEX)
        dt_PersonList = dt

        getDesignGridControl(dt)
        txtPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Class1.Innitial(gcPersonList, txtDisplayPageNo, txtPageSize)

        Try
            getTotalRecords(dt)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub getTotalRecords(dt As DataTable)
        If dt.Rows.Count > 0 Then
            totalrecords.Text = dt.Rows.Count
        End If

    End Sub

    Dim selected As Int64

    Private Sub getDesignGridControl(Data As DataTable)

        Dim disable As New List(Of String)
        For Each dc As DataColumn In Data.Columns
            If dc.ColumnName.Substring(0, 1) = "/" Then
                dc.ColumnName = Replace(dc.ColumnName, "/", "")
                disable.Add(dc.ColumnName)
            End If
        Next

        Dim center As New List(Of String)
        For Each dc As DataColumn In Data.Columns
            If dc.ColumnName.Substring(0, 1) = "|" Then
                dc.ColumnName = Replace(dc.ColumnName, "|", "")
                center.Add(dc.ColumnName)
            End If
        Next


        gcPersonList.DataSource = Data
        '   GridView1 = gvPersonList
        Try
            For Each column As Columns.GridColumn In gvPersonList.Columns
                For Each li In disable
                    If column.FieldName = li Then
                        column.Visible = False
                    End If
                    column.BestFit()
                Next
                For Each li In center
                    If column.FieldName = li Then
                        column.AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                    End If
                    column.BestFit()
                Next
            Next


            Dim i As Integer = gvPersonList.FocusedRowHandle
            Dim row As DataRow = gvPersonList.GetDataRow(i)
            '     Dim selected As Int64

            If row IsNot Nothing Then
                selected = row("person_id")
            End If

            '      gvPersonList.BeginDataUpdate()

            If Data.Rows.Count > gvPersonList.RowCount Then
                selected = Data(Data.Rows.Count - 1)("person_id")
            End If

            '        gvPersonList.EndDataUpdate()
            Dim rowHandle = gvPersonList.LocateByValue("person_id", selected)
            gvPersonList.ClearSelection()
            gvPersonList.FocusedRowHandle = rowHandle
            gvPersonList.SelectRow(rowHandle)


        Catch ex As Exception

        End Try


    End Sub

    Dim dt As New DataTable

    Public Sub displayFilterCategory()

        Me.tdbViewer.DataSource = Nothing
#Region "old"


        'Me.tdbViewer.DataSource = Nothing

        'Dim SQLEX As String = "SELECT employees.id, employees.employee_number"
        'SQLEX += " , employees.first_name, employees.middle_name"
        'SQLEX += " , employees.last_name"
        'SQLEX += " , employee_departments.name 'department'"
        'SQLEX += " , employee_positions.name 'position'"
        'SQLEX += " FROM employees"
        'SQLEX += " INNER JOIN employee_departments "
        'SQLEX += " ON (employees.employee_department_id = employee_departments.id)"
        'SQLEX += " INNER JOIN employee_positions "
        'SQLEX += " ON (employees.employee_position_id = employee_positions.id)"
        'If txtEmpName.Text.Length > 0 Then
        '    SQLEX += " WHERE "
        '    SQLEX += " employees.last_name LIKE '%" & txtEmpName.Text & "%'"
        '    SQLEX += " or employees.first_name LIKE '%" & txtEmpName.Text & "%'"
        '    SQLEX += " or employees.middle_name LIKE '%" & txtEmpName.Text & "%'"
        'Else
        '    SQLEX += " WHERE employee_positions.name='INSTRUCTOR'"
        'End If
#End Region

        Dim SQLEX As String = ""

        If Me.Tag = 1 Then

            SQLEX = "SELECT
              `person`.`person_id`
                , `employees`.`id`
                , `users`.`username` AS 'UserName'
                , `employees`.empl_number
                , `person`.`first_name`
                , `person`.`middle_name`
                , `person`.`last_name`
                , DATE_FORMAT(`employees`.`joining_date`,'%M %d,%Y') AS 'JoinDate'
                , `employee_departments`.`name` AS 'DepartmentName'     
                , `employee_positions`.`name`
            FROM
                `person`
                INNER JOIN `employees` 
	            ON (`person`.`person_id` = `employees`.`person_id`)
                LEFT JOIN `users` 
	            ON (`employees`.`user_id` = `users`.`id`)
                INNER JOIN `employee_departments` 
	            ON (`employees`.`employee_department_id` = `employee_departments`.`id`)
                INNER JOIN `employee_positions` 
	            ON (`employees`.`employee_position_id` = `employee_positions`.`id`)

                where person.first_name LIKE '%" & txtEmpName.Text & "%' AND
                      person.middle_name LIKE '%" & txtEmpName.Text & "%' and 
                      person.last_name LIKE '%" & txtEmpName.Text & "%' and
                      employees.status_type_id = 1 and employees.end_time is null  
                ;"

        Else
            SQLEX = "SELECT
			person_id,
			id,
			UserName,
			std_number,
			CONCAT(last_name,', ',first_name,' ',middle_name) 'FullName',                                                
			DATE_FORMAT(date_of_birth,'%M %d, %Y') as 'date_of_birth',
			gender,
			contact_person,
			course_name,
			scholarship_sponsor_name,
			stature
			
				FROM(
					SELECT
					`person`.`person_id`
					, `students`.`id`
					, `users`.`username` AS 'UserName'
					, students.std_number
					, `person`.`first_name`
					, `person`.`middle_name`
					, `person`.`last_name`
					, `person`.date_of_birth 
					,  `person`.gender
					,  contact_person
					, `courses`.`course_name` 
					, students.stature
					, scholarship_sponsor_name	
			FROM
			`person`
					LEFT JOIN `students` 
					ON (`person`.`person_id` = `students`.`person_id` AND `students`.end_time IS NULL)
					LEFT JOIN `users` 
					ON (`users`.`id` = `students`.`user_id`)	                    
					LEFT JOIN `courses` 
					ON (`students`.`course_id` = `courses`.`id`)
					LEFT JOIN `students_details` 
					ON (students_details.person_id =  `person`.`person_id`)
					LEFT JOIN `person_contact_person` 
					ON (`person_contact_person`.person_id =  `person`.`person_id`)
		 
			 where person.first_name LIKE '%" & txtEmpName.Text & "%' AND
						person.middle_name LIKE '%" & txtEmpName.Text & "%' and 
						person.last_name LIKE '%" & txtEmpName.Text & "%' and
						person.person_type_id = 2 AND
						person.status_type_id = 1 AND person.end_time IS NULL 
							)A;"
        End If


        Dim MeData As DataTable
        'MeData = clsDBConn.ExecQuery(SQLEX)
        MeData = DataSource(SQLEX)
        Me.tdbViewer.DataSource = MeData
        '      Me.tdbViewer.Rebind(True)
        dt = MeData
        Try

            If Me.Tag = 1 Then
                With tdbViewer.Splits(0)
                    .DisplayColumns("person_id").Visible = False
                    .DisplayColumns("id").Visible = False

                    .DisplayColumns("UserName").DataColumn.Caption = "USER NAME"
                    .DisplayColumns("UserName").Width = 100
                    .DisplayColumns("UserName").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("UserName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("empl_number").DataColumn.Caption = "EMPLOYEE NUMBER"
                    .DisplayColumns("empl_number").Width = 150
                    .DisplayColumns("empl_number").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("empl_number").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("first_name").DataColumn.Caption = "FIRST NAME"
                    .DisplayColumns("first_name").Width = 200
                    .DisplayColumns("first_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("first_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("middle_name").DataColumn.Caption = "MIDDLE NAME"
                    .DisplayColumns("middle_name").Width = 100
                    .DisplayColumns("middle_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("middle_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("last_name").DataColumn.Caption = "LAST NAME"
                    .DisplayColumns("last_name").Width = 150
                    .DisplayColumns("last_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("last_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("JoinDate").DataColumn.Caption = "JOIN DATE"
                    .DisplayColumns("JoinDate").Width = 200
                    .DisplayColumns("JoinDate").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("JoinDate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("DepartmentName").DataColumn.Caption = "DEPARTMENT"
                    .DisplayColumns("DepartmentName").Width = 200
                    .DisplayColumns("DepartmentName").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("DepartmentName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("name").DataColumn.Caption = "POSITION"
                    .DisplayColumns("name").Width = 200
                    .DisplayColumns("name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near


                End With

            Else

                With tdbViewer.Splits(0)
                    .DisplayColumns("person_id").Visible = False
                    .DisplayColumns("id").Visible = False

                    .DisplayColumns("UserName").DataColumn.Caption = "USER NAME"
                    .DisplayColumns("UserName").AutoSize()
                    .DisplayColumns("UserName").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("UserName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("std_number").DataColumn.Caption = "STUDENT NUMBER"
                    .DisplayColumns("std_number").AutoSize()
                    .DisplayColumns("std_number").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("std_number").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("FullName").DataColumn.Caption = "STUDENT NAME"
                    .DisplayColumns("FullName").AutoSize()
                    .DisplayColumns("FullName").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("FullName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("date_of_birth").DataColumn.Caption = "BIRTH DATE"
                    .DisplayColumns("course_name").AutoSize()
                    .DisplayColumns("date_of_birth").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("date_of_birth").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("gender").DataColumn.Caption = "GENDER"
                    .DisplayColumns("gender").AutoSize()
                    .DisplayColumns("gender").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("gender").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("contact_person").DataColumn.Caption = "GUARDIAN"
                    .DisplayColumns("contact_person").AutoSize()
                    .DisplayColumns("contact_person").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("contact_person").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("course_name").DataColumn.Caption = "COURSE NAME"
                    .DisplayColumns("course_name").AutoSize()
                    .DisplayColumns("course_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("course_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("scholarship_sponsor_name").DataColumn.Caption = "SCHOLARSHIP"
                    .DisplayColumns("scholarship_sponsor_name").AutoSize()
                    .DisplayColumns("scholarship_sponsor_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("scholarship_sponsor_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                    .DisplayColumns("stature").DataColumn.Caption = "STATURE"
                    .DisplayColumns("stature").AutoSize()
                    .DisplayColumns("stature").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("stature").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

                End With
            End If


        Catch ex As Exception

        End Try

        Dim sql As String = ""
        If MeData.Rows.Count > 0 Then
            MeData = Nothing
            sql = "SELECT count(person_id) as count"
            sql += " FROM " & TABLENAME
            sql += " WHERE  person_type_id = " & Me.Tag
            MeData = clsDBConn.ExecQuery(sql)
            totalrecords.Text = MeData.Rows(0).Item("count").ToString
        End If

        MeData = Nothing
        Me.txtEmpName.Text = ""

        '      gcPersonList.DataSource = dt
        '       Class1.Innitial(gcPersonList, txtDisplayPageNo, txtPageSize)
    End Sub




    Private Sub btnSearchCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCondition.Click

        Cursor.Current = Cursors.WaitCursor


        rollingSpinner.Visible = True
        lblStatus.Visible = True
        new_displayFilterCategory()
        'displayFilterCategory()
        lblStatus.Visible = False
        stillSpinner.Visible = False


        Cursor.Current = Cursors.Default
        'm_AsyncWorker.WorkerReportsProgress = True
        'm_AsyncWorker.WorkerSupportsCancellation = True
        'AddHandler m_AsyncWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bwAsync_RunWorkerCompleted)
        'AddHandler m_AsyncWorker.DoWork, New DoWorkEventHandler(AddressOf bwAsync_DoWork)

        'lblStatus.Text = "Searching..."

        '' Kickoff the worker thread to begin it's DoWork function.
        'Try
        '    m_AsyncWorker.RunWorkerAsync()
        'Catch ex As Exception
        '    MsgBox("Please wait until current process is finish.", MsgBoxStyle.Information)
        'End Try

    End Sub

    Private Sub txtStudentName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSearchCondition.PerformClick()
        End If
    End Sub



    Private Sub btnClearFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilter.Click
        lblStatus.Text = "Waiting ..."
        txtEmpName.Text = ""
        Me.tdbViewer.DataSource = Nothing
    End Sub


#Region "Asynchronous BackgroundWorker Thread"
    'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    '    ' Notify the worker thread that a cancel has been requested.
    '    ' The cancel will not actually happen until the thread in the 
    '    ' DoWork checks the bwAsync.CancellationPending flag, for this
    '    ' reason we set the label to "Canceling...", because we haven't 
    '    ' actually cancelled yet.
    '    m_AsyncWorker.CancelAsync()
    'End Sub


    Private Sub bwAsync_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        ' The Sender is the BackgroundWorker object we need it to
        ' report progress and check for cancellation.
        Dim bwAsync As BackgroundWorker = TryCast(sender, BackgroundWorker)
        ' Thread.Sleep(1200)

        Try
            '           displayFilterCategory()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SetLabel1Text("TRUE")

    End Sub



    Private Sub bwAsync_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        ' The background process is complete. We need to inspect 
        ' our response to see if an error occured, a cancel was 
        ' requested or if we completed succesfully.

        'bnAsync.Text = "Start Long Running Asychronous Process"
        'bnAsync.Enabled = True

        ' Check to see if an error occured in the 
        ' background process.
        If e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
            Return
        End If

        ' Check to see if the background process was cancelled.
        'If e.Cancelled Then
        '    lblStatus.Text = "Cancelled..."
        '    stillSpinner.Visible = True
        '    rollingSpinner.Visible = False
        'Else
        '    ' Everything completed normally.
        '    ' process the response using e.Result

        '    lblStatus.Text = "Completed..."
        '    stillSpinner.Visible = True
        '    rollingSpinner.Visible = False
        'End If
    End Sub

    Private Sub bwAsync_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' This function fires on the UI thread so it's safe to edit
        ' the UI control directly, no funny business with Control.Invoke.
        ' Update the progressBar with the integer supplide to us from the 
        ' ReportProgress() function.  Note, e.UserState is a "tag" property
        ' that can be used to send other information from the BackgroundThread
        ' to the UI thread.

    End Sub


    Delegate Sub SetLabel1TextInvoker(ByVal TextToDisplay As String)

    Public Sub SetLabel1Text(ByVal TextToDisplay As String)
        If rollingSpinner.InvokeRequired Then
            rollingSpinner.Invoke(New SetLabel1TextInvoker(AddressOf SetLabel1Text), New Object() {TextToDisplay})
        Else
            rollingSpinner.Visible = False
            stillSpinner.Visible = True
        End If
    End Sub



#End Region


    Private Sub tdbViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbViewer.MouseUp
        Dim point1 As Point
        Dim row As Integer
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then

                point1 = Windows.Forms.Cursor.Position

                Dim pt As Point = tdbViewer.PointToClient(point1)
                CMenuStripOperations.Show(tdbViewer, pt)

            Else
                row = tdbViewer.Row
                id = tdbViewer(row, "id")
                personID = tdbViewer(row, "person_id")
            End If


        Catch ex As Exception
            personID = tdbViewer(row, "person_id")
        End Try



        GroupPanel1.Visible = True

    End Sub

    'Private Sub txtEmpName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpName.KeyUp
    '    If e.KeyCode = Keys.Enter Then

    '        Cursor.Current = Cursors.WaitCursor

    '        rollingSpinner.Visible = True
    '        lblStatus.Visible = True
    '        new_displayFilterCategory()
    '        'displayFilterCategory()
    '        lblStatus.Visible = False
    '        stillSpinner.Visible = False

    '        Cursor.Current = Cursors.Default


    '        '           btnSearchCondition.PerformClick()
    '    End If
    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim SetupName As String = ""
        Cursor = Cursors.WaitCursor

        If SETUPFORM Is Nothing Then

            If Me.Tag = 1 Then
                SetupName = "EMPLOYEE SETUP"
            Else
                SetupName = "STUDENT SETUP"
            End If

            SETUPFORM = New fmaEmployeeRecord("ADD", Me.Tag, SetupName)

            SETUPFORM.ShowDialog()
            SETUPFORM.BringToFront()

        End If
        SETUPFORM = Nothing
        Cursor = Cursors.Default

    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim SetupName As String = ""
        Cursor = Cursors.WaitCursor

        If SETUPFORM Is Nothing Then

            If Me.Tag = 1 Then
                SetupName = "EMPLOYEE SETUP"
            Else
                SetupName = "STUDENT SETUP"
            End If

            SETUPFORM = New fmaEmployeeRecord("EDIT", Me.Tag, SetupName)
            SETUPFORM._personID = personID
            SETUPFORM.BringToFront()
            SETUPFORM.ShowDialog()

        End If
        SETUPFORM = Nothing
        Cursor = Cursors.Default

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete(personID, Me.Tag)
    End Sub

    Private Sub Delete(personID As Integer, personType As Object)

        If MsgBox("Are you sure???, You want to Delete this Person", MsgBoxStyle.YesNo, "DELETING PERSON") = MsgBoxResult.Yes Then
            DataSource(String.Format("DELETE FROM person WHERE person.person_id = '" & personID & "'"))
        Else
            Exit Sub
        End If
        new_displayFilterCategory()


    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click
        BtnNextPage.Appearance.BackColor = Color.MediumAquamarine
        BtnPreviousPage.Appearance.BackColor = Color.Transparent
        BtnFirstPage.Appearance.BackColor = Color.Transparent
        BtnLastPage.Appearance.BackColor = Color.Transparent
        Class1.NextPage()
    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click
        BtnPreviousPage.Appearance.BackColor = Color.MediumAquamarine
        BtnFirstPage.Appearance.BackColor = Color.Transparent
        BtnNextPage.Appearance.BackColor = Color.Transparent
        BtnLastPage.Appearance.BackColor = Color.Transparent

        Class1.PreviousPage()
    End Sub

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click
        BtnFirstPage.Appearance.BackColor = Color.MediumAquamarine
        BtnPreviousPage.Appearance.BackColor = Color.Transparent
        BtnNextPage.Appearance.BackColor = Color.Transparent
        BtnLastPage.Appearance.BackColor = Color.Transparent
        Class1.FirstPage()
    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click
        BtnLastPage.Appearance.BackColor = Color.MediumAquamarine
        BtnPreviousPage.Appearance.BackColor = Color.Transparent
        BtnNextPage.Appearance.BackColor = Color.Transparent
        BtnFirstPage.Appearance.BackColor = Color.Transparent
        Class1.LastPage()
    End Sub

    Dim FirstLoad As Boolean = True
    Private Sub txtPageSize_EditValueChanged(sender As Object, e As EventArgs) Handles txtPageSize.EditValueChanged

        If FirstLoad = False Then
            new_displayFilterCategory()
        End If

    End Sub

    Private Sub gvPersonList_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvPersonList.RowCellClick
        personID = gvPersonList.GetFocusedRowCellValue("person_id")
    End Sub

    Dim find As Integer = 1
    Dim filter As Integer = 1
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If filter = 1 Then
            gvPersonList.OptionsView.ShowAutoFilterRow = True
            filter = 0
        Else
            gvPersonList.OptionsView.ShowAutoFilterRow = False
            filter = 1
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If find = 1 Then
            gvPersonList.OptionsFind.AlwaysVisible = True
            find = 0
        Else
            gvPersonList.OptionsFind.AlwaysVisible = False
            find = 1
        End If
    End Sub

    Dim DummyEmplName As String = ""


    Private Sub txtEmpName_TextChanged(sender As Object, e As EventArgs) Handles txtEmpName.TextChanged

        Dim dt As DataTable = dt_PersonList
        Dim dt_new As New DataTable
        dt_new = likes(dt, "FILTERNAME", txtEmpName.Text.ToUpper)

        getDesignGridControl(dt_new)
        txtPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Class1.Innitial(gcPersonList, txtDisplayPageNo, txtPageSize)

        '      dt_PersonList = dt
        Try
            getTotalRecords(dt_new)

        Catch ex As Exception

        End Try


    End Sub

    Private Function likes(ByVal dt As DataTable, ByVal column As String, ByVal value As String)
        Dim result = dt.Clone()
        For Each row As DataRow In From row1 As DataRow In dt.Rows Where (row1(column).Contains(value))
            result.ImportRow(row)
        Next
        Return result
    End Function

    Private Sub txtEmpName_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtEmpName.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchCondition.Focus()
            Timer1.Start() 'Timer starts functioning
        Else
            txtEmpName.SelectionStart = txtEmpName.Text.Length
        End If

    End Sub

    Dim second As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString

        second = second + 1
        If second >= 10 Then
            Timer1.Stop() 'Timer stops functioning
            txtEmpName.Focus()
        End If
    End Sub
End Class