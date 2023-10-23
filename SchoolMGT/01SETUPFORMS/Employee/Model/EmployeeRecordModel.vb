Imports System.IO
Imports DevExpress.XtraGrid
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports SchoolMGT
'imports  System.IO.Path.Combine
Public Class EmployeeRecordModel

    Public _personID As Integer
    Public _userID As Integer
    Public _id As New Integer
    Public _personType As Integer

    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream
    Dim UserName As String
    Public ListOfAchievements As New List(Of ListOfAchievements)
    Public ListOfAttachments As New List(Of ListOfAttachment_Documents)
    Public Attended_University As New List(Of AttendedUniversity)
    Public NonAcademic As New List(Of StudentNonAcademic)
    Public StudentID As String

    Public _CreatUser As Boolean = False

    Friend Function getBloodType() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `PersonBloodTypeID` AS 'ID',
                      `Name`
                    FROM `bloodtype`
                    ;"))
        Return dt
    End Function

    Friend Function getCitizenship() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                  `id`   AS 'ID',
                  `name` AS 'Name'
                FROM `citizenship`
                ;"))
        Return dt
    End Function

    Friend Function getBarangay() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `id`          AS 'iD',
                      `brgyDesc`    AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refbrgy`
                    WHERE `EndTime` IS NULL
                        AND `Status_TypeID` = 2
                    "))
        Return dt
    End Function

    Friend Function getBarangayParam(Code As Object, Type As String) As Object

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
refbrgy.id AS 'ID',
refbrgy.brgyDesc AS 'Name'
FROM
refbrgy
WHERE
refbrgy.citymunCode = '" & Code & "'
ORDER BY `Name`
"))
        Return dt
#Region "Old"
        '        Dim where As String = ""
        '        If Type = "Province" Then
        '            where = "WHERE `refbrgy`.`provCode` = '" & Code & "'"
        '        Else
        '            where = "WHERE `refbrgy`.`citymunCode` = '" & Code & "'"
        '        End If

        '        Dim dt As New DataTable
        '        dt = DataSource(String.Format("SELECT
        '      `refbrgy`.`id` as 'ID'
        '    , `refbrgy`.`brgyDesc` as 'Name'
        '    , `refbrgy`.`brgyCode`
        '    , `refbrgy`.`provCode`
        '    , `refbrgy`.`citymunCode`
        'FROM
        '    ``refprovince`
        '    INNER JOIN `refcitymun` 
        '        ON (`refprovince`.`provCode` = `refcitymun`.`provCode`)
        '    INNER JOIN `refbrgy` 
        '        ON (`refcitymun`.`citymunCode` = `refbrgy`.`citymunCode`)
        '" & where & " AND `refbrgy`.Status_TypeID = 2 AND `refbrgy`.EndTime IS NULL
        'ORDER BY `refbrgy`.`brgyDesc`
        '        ;"))
        '        Return dt
#End Region

    End Function

    Friend Function RetreiveRecord(id As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
    `person`.`person_id`
    , `employees`.`id`
    , `employees`.`first_name`
    , `employees`.`last_name`
    , `employees`.`middle_name`
    , `employees`.`display_name`
    , `employees`.`date_of_birth`
    , `employees`.`birth_place`
    , `employees`.`religion`
    , `employees`.`gender`
    , `employees`.`marital_status`
    , `employees`.`blood_group`
    , `employees`.`nationality_id`
    , `employees`.`language`
    , `employees`.`home_phone`
    , `employees`.`mobile_phone`
    , `employees`.`email`
    , `person_contact_person`.`contact_person`
    , `person_contact_person`.`contact_number`
    , `person_contact_person`.`contact_address`
    , `person_contact_person`.`contact_relationship`
    , `employees`.`home_address_line1`
    , `employees`.`home_address_line2`
    , `employees`.`home_city`
    , `employees`.`home_pin_code`
    , `employees`.`home_state`
    , `employees`.`office_address_line1`
    , `employees`.`office_address_line2`
    , `employees`.`office_city`
    , `employees`.`office_pin_code`
    , `employees`.`office_state`
    , `employees`.`biometric_id`
    , `employees`.`employee_department_id`
    , `employees`.`job_title`
    , `employees`.`employee_position_id`
    , `employees`.`joining_date`
    , `employees`.`firstday_date`
    , `employees`.`salary`
    , `employees`.`employee_category_id`
    , `employees`.`status_description`
    , `employees`.`qualification`
    , `employees`.`employee_grade_id`
    , `employees`.`photo_file_name`
    , `employees`.`photo_path`
    , `employees`.`user_id`
FROM
    `person`
    INNER JOIN `employees` 
        ON (`person`.`person_id` = `employees`.`person_id`)
    LEFT JOIN `person_contact_person` 
        ON (`employees`.`person_id` = `person_contact_person`.`person_id`)
WHERE employees.id = '" & id & "'
        ;"))
        Return dt
    End Function

    Friend Function getLastEmplNumber() As String
        Dim EmplNumber As String = ""
        EmplNumber = DataObject(String.Format("SELECT
  MAX(CAST(employee_number AS UNSIGNED))
FROM `employees`
INNER JOIN person
      ON person.person_id = employees.person_id AND person.status_type_id = 1 AND person.end_time IS NULL
"))
        Return EmplNumber
    End Function

    Friend Function getUserID(id As Object) As Integer
        createNewUserAccount(Nothing, id)
    End Function

    Friend Function RetreivePerson(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                        `person`.`person_id`
                        , `person`.`first_name`
                        , `person`.`middle_name`
                        , `person`.`last_name`
                        , `person`.`display_name`
                        , `person`.`gender`
                        , `person`.`date_of_birth`
                        , `person`.`birth_place`
                        , `person`.`marital_status`
                        , `person`.`blood_group`
                        , `person`.`nationality_id`
                        , `person`.`telephone1`
                        , `person`.`mobile`
                        , `person`.`email`
                        , `person`.`religion`
                        , `person`.`language`
                        , `person`.`disability`

                    FROM
                        `person`
                    WHERE person.person_id = '" & personID & "' AND  person.status_type_id = 1 AND person.end_time IS NULL   
                    ;"))
        Return dt
    End Function

    Friend Function getLastCode() As Object
        '     Throw New NotImplementedException()
    End Function

    Friend Function getCityMunicipalityParam(Code As Object, Type As String) As Object

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
refcitymun.id as 'ID',
refcitymun.citymunDesc as 'Name',
refcitymun.citymunCode

FROM
refcitymun
WHERE
refcitymun.provCode = '" & Code & "'
ORDER BY `Name`
"))

#Region "old"
        '        Dim where As String = ""
        '        If Type = "Province" Then
        '            where = "WHERE `refbrgy`.`provCode` = '" & Code & "'"
        '        Else
        '            where = "WHERE `refbrgy`.`citymunCode` = '" & Code & "'"
        '        End If
        '        Dim dt As New DataTable
        '        dt = DataSource(String.Format("SELECT
        '      `refcitymun`.`id` as 'ID'
        '    , `refcitymun`.`citymunDesc` as 'Name'
        '    , `refcitymun`.`citymunCode`
        '    , `refbrgy`.`provCode`
        '    , `refbrgy`.`citymunCode`    
        '   FROM
        '    `refprovince`
        '    INNER JOIN `refcitymun` 
        '        ON (`refprovince`.`provCode` = `refcitymun`.`provCode`)
        '    INNER JOIN `refbrgy` 
        '        ON (`refcitymun`.`citymunCode` = `refbrgy`.`citymunCode`)
        '" & where & "
        'GROUP BY  `refcitymun`.`id`
        'ORDER BY `refcitymun`.`citymunDesc`   
        '        ;"))
        '      Return dt
#End Region
        Return dt
    End Function

    Friend Function RetreivePersonContact(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `contact_person`,
  `contact_address`,
  `contact_number`,
  `contact_relationship`
 FROM `person_contact_person`
WHERE person_contact_person.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getCharacterReference(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `name` AS 'Person Name',
  `position` AS 'Position',
  `company` AS 'Company',
  `contact_number` AS 'Contact Number'
FROM `person_reference`
WHERE person_reference.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Friend Function RetreiveCharacterReference(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `name` as 'Person Name',
  `position` as 'Position',
  `company` as 'Company',
  `contact_number` as 'Contact Number'
FROM `person_reference`
WHERE person_reference.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getStatutory(personID As Object) As DataTable
        Dim sql As String = ""
        sql = "SELECT
person_id,
tin,
sss,
pagibig,
philhealth
FROM
person_statutory
WHERE
person_id = '" & personID & "'
"
        Return DataSource(sql)
    End Function

    Friend Function RetreiveEmployee(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
     `id`
    , `user_id`
    ,`employee_number`
    , `employee_category_id`
    , `joining_date`
    , `firstday_date`
    , `employee_department_id`
    , `job_title`
    , `employee_position_id`
    , `employee_grade_id`
    , `qualification`
    , `status_description`
    , `biometric_id`
    , `salary`
    ,empl_number
    ,date_encoded
    
FROM
    `employees`
WHERE  employees.person_id = '" & personID & "'  AND employees.status_type_id = 1 AND employees.end_time IS NULL   
    ;"))
        Return dt
    End Function

    Friend Function RetreiveFamilyBackground(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `family_background_id`,
  `person_id`,
  `family_background_type`,
  `family_background_name`,
  `family_background_occupation`,
  `family_background_company_name`,
  `family_background_company_number`,
  `family_background_company_address`,
  `status`
FROM `person_familybackground`
WHERE person_familybackground.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function RetreiveDependencies(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
   `dependent_name` as 'Name',
  `dependent_birthdate` as 'Birth Date',
  '' as 'Age',
  `dependent_relationship` as 'Relationship',
  `dependent_count` as 'Rank',
  grade_year as 'Grade/Year',
  school as 'School'
FROM `person_dependent`
WHERE person_dependent.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getProvinceParam(ProvinceCode As Object) As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
     `refprovince`.`id` as 'ID'
    , `refprovince`.`provDesc` as 'Name'
    ,`refprovince`.`provCode`
 FROM
    `refprovince`
    INNER JOIN `refcitymun` 
        ON (`refprovince`.`provCode` = `refcitymun`.`provCode`)
    INNER JOIN `refbrgy` 
        ON (`refcitymun`.`citymunCode` = `refbrgy`.`citymunCode`)
WHERE  `refprovince`.`provCode` = '" & ProvinceCode & "'      
GROUP BY `id`       
ORDER BY `refprovince`.`provDesc`        
;"))
        Return dt
    End Function

    Friend Function getProvinceID(Code As String) As Object

        Dim id As New DataObject
        id = DataObject(String.Format("select
                  `id`
                from `refprovince`
                where `provCode` = '" & Code & "'
                ;"))
        Return id

    End Function

    Friend Function getCityMunicipalID(Code As String) As Object
        Dim id As New DataObject
        id = DataObject(String.Format("select
              `id`
            from `refcitymun`
            where  `citymunCode` = '" & Code & "'
            ;"))
        Return id
    End Function

    Friend Function getBarangay1() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `id`          AS 'iD',
                      `brgyDesc`    AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refbrgy`
                    WHERE `EndTime` IS NULL
                        AND `Status_TypeID` = 2
                    ;"))
        Return dt
    End Function

    Friend Function getCityMunicipaltiy() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `id` AS 'ID',
                      `citymunDesc` AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refcitymun`
                  ;"))
        Return dt
    End Function

    Friend Function RetreivePhoto(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `photo_file_name`,
  `photo_path`,
  `original_file_name`
FROM `person_photo`
WHERE person_photo.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getEmployeeCategory() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `id` AS 'ID',
                      `name` AS 'Name'
                    FROM `employee_categories`
                    WHERE `status` = 1
                    ;"))
        Return dt
    End Function

    Friend Function getDepartment() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                  `id` AS 'ID',
                  `name` AS 'Name'
                FROM `employee_departments`
                WHERE `status` = 1
                ;"))
        Return dt
    End Function

    Friend Function RetreiveEduAttainment(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person_educational_attainment.education_attainment AS `Education Attaintment`,
person_educational_attainment.school_address AS `School Address`,
person_educational_attainment.date_from AS `Date From`,
person_educational_attainment.date_to AS `Date To`,
person_educational_attainment.honors_received AS `Honors Received`
FROM
person_educational_attainment
INNER JOIN person ON person_educational_attainment.person_id = person.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
person_educational_attainment.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Friend Function RetreiveServiceHistory(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person_service_history.service_level AS `Eligibility Level`,
person_service_history.service_career AS `Eligibility Career`,
person_service_history.date_examination AS `Date Examination`,
person_service_history.place_examination AS `Place of Examination`,
person_service_history.ratings AS Ratings,
person_service_history.license_number AS `License Number`,
person_service_history.date_release AS `Date of Release`
FROM
person_service_history
INNER JOIN person ON person_service_history.person_id = person.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
person_service_history.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function RetreiveEmploymentHistory(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person_employment_history.company AS `Company Name`,
person_employment_history.date_from AS `Date From`,
person_employment_history.date_to AS `Date To`,
person_employment_history.contact_number AS `Contact Number`
FROM
person_employment_history
INNER JOIN person ON person_employment_history.person_id = person.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
person_employment_history.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Friend Function getJobTitle() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
              `job_title_id` as 'ID',
              `job_title` as 'Name'
            FROM `job_title`
            WHERE `status` = 1
            ;"))
        Return dt
    End Function

    Friend Function RetreiveBank(id As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  `bank_info` AS 'Bank Name',
  `bank_account_number` AS 'Account Number'
FROM `employee_bank_details` WHERE employee_id = '" & id & "'
"))

        Return dt
    End Function

    Friend Function RetreiveListOfAchievements(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT file_name AS 'File Name',file_path AS 'File Path' FROM `students_list_achievements` WHERE person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getCityMunicipaltiy1() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                      `id` AS 'ID',
                      `citymunDesc` AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refcitymun`
                    ;"))
        Return dt
    End Function

    Friend Function RetreiveAddress(personID As Object) As DataTable
        Dim sql As String = ""
        sql = "SELECT
person_address.person_id,
person_address.address_type_id,
person_address.address,
person_address.barangay,
person_address.citymunicipality,
person_address.zipcode,
person_address.province

FROM
person_address
WHERE
person_address.address_type_id = 1 AND
person_address.person_id = '" & personID & "';"
        Return DataSource(sql)
    End Function

    Friend Function getEmployeeGrade() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
              `id` as 'ID',
              `name` as 'name',
              `priority`,
              `max_hours_day`,
              `max_hours_week`
            FROM `employee_grades`
            WHERE `status` = 1
            ;"))
        Return dt
    End Function

    Friend Function RetreiveAddress1(personID As Object) As DataTable
        Dim sql As String = ""
        sql = "SELECT
person_address.person_id,
person_address.address_type_id,
person_address.address,
person_address.barangay,
person_address.citymunicipality,
person_address.zipcode,
person_address.province

FROM
person_address
WHERE
person_address.address_type_id = 2 AND
person_address.person_id = '" & personID & "'
"
        Return DataSource(sql)
    End Function

    Friend Function RetreiveStudentDetails(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students_details.LRN_number,
students_details.high_school_name,
students_details.high_school_address,
students_details.date_graduation,
students_details.master_program,
students_details.specialization,
students_details.previous_degree,
students_details.previous_university,
students_details.year_from,
students_details.year_to,
students_details.extra_curricular_activities,
students_details.other_skills_tallents,
students_details.other_sports,
students_details.interest,
students_details.estimate_family_monthly_income,
students_details.scholarship_any,
students_details.scholarship_sponsor_name,
students_details.plan_toShift_another_course,
students_details.what_course,
students_details.first_choice_course,
students_details.plan_after_college,
students.std_number,
other_extra_curricular_participation,
other_resources_avialable,
other_skills_tallents,
other_sports, 
students_details.students_details_id as 'id',
students_details.join_position_id

FROM
person
LEFT JOIN students_details ON person.person_id = students_details.person_id
LEFT JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
person.person_id = '" & personID & "'"))
        Return dt
    End Function

    Friend Function getPosition() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                  `id` AS 'ID',
                  `name` AS 'Name',
                  `employee_category_id`
 
                FROM `employee_positions`
                WHERE  `status` = 1
                ;"))
        Return dt
    End Function

    Friend Function getProvince1() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                  `id` AS 'ID',
                  `provDesc` AS 'Name',
                  `provCode`
                FROM `refprovince`
               ;"))
        Return dt
    End Function

    Friend Function getProvince() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT 
    DISTINCT `refprovince`.`id` AS 'ID'
    , `refprovince`.`provDesc` AS 'Name'
    ,`refprovince`.`provCode`
 FROM
    `refprovince`
    ORDER BY `provDesc`"))
        Return dt
    End Function

    Friend Function RetreiveListOfAttachments(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
attach_document_type.`name` AS `Document Type`,
students_attachment.file_name AS `File Name`,
students_attachment.file_path AS `File Path`,
attach_document_type.attach_document_type_id as `ID`
FROM
students_attachment
INNER JOIN attach_document_type ON students_attachment.attach_document_type_id = attach_document_type.attach_document_type_id
WHERE
students_attachment.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Dim sql As String = ""
    Dim Exist As Boolean = False


    Friend Function CheckImage(ImgeFile As String) As Boolean

        Dim _ImageFileName As String = DataObject(String.Format("SELECT `original_file_name` FROM `person_photo` WHERE person_photo.original_file_name  = '" & ImgeFile & "'"))
        If _ImageFileName = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function createNewUserAccount(Optional personDetails As PersonDetails = Nothing, Optional employeeDetails As EmployeeDetails = Nothing) As Integer

        Dim Admin As Integer = 0
        Dim Employee As Integer = 0
        Dim Student As Integer = 0
        Select Case personDetails.person_type
            Case 1
                Employee = 1
            Case 2
                Student = 1
            Case Else
                Admin = 1
        End Select

        Dim userID As Integer

        If employeeDetails.employee_number <> "" Then


            Dim salt As String = CREATERANDOMSALT()
            Dim hashedPassword As String = HASH512(UserName, salt) 'employeeDetails.employee_number


            Dim SQLIN As String = "INSERT INTO users(username,first_name,last_name,student,admin,employee,hashed_password,salt,application_setup_id)"
            SQLIN += " VALUES("
            SQLIN += String.Format("'{0}', '{1}',", UserName, personDetails.first_name)
            SQLIN += String.Format("'{0}', '{1}',", personDetails.last_name, Student)
            SQLIN += String.Format("'{0}', '{1}',", Admin, Employee)
            SQLIN += String.Format("'{0}', '{1}','{2}')", hashedPassword, salt, AppSetup_Domain)

            If clsDBConn.Execute(SQLIN) Then
                Dim SQLEX As String = "SELECT id from users where username='" & UserName & "'"

                Dim userData As DataTable
                userData = clsDBConn.ExecQuery(SQLEX)

                If userData.Rows.Count > 0 Then
                    userID = userData.Rows(0).Item("id")
                End If
            End If

            Return userID
        End If


    End Function

    Friend Function RetreiveAttendedUniversity(personID As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students_attended_university.`name` as 'Name of Person',
students_attended_university.relationship as 'Relationship'
FROM
students_attended_university
WHERE
students_attended_university.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Friend Function RetreiveNonAcademic(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students_non_academic.title,
students_non_academic.non_academic_name
FROM
students_non_academic
WHERE
students_non_academic.person_id = '" & personID & "'
"))
        Return dt
    End Function

    Friend Sub Save(personDetails As PersonDetails, address As List(Of PersonDetails.Address), familyBackground As List(Of PersonDetails.FamilyAndGuardian), dependent As List(Of PersonDetails.Dependent), photo As List(Of PersonDetails.Photo), employeeDetails As EmployeeDetails, bankDetails As List(Of EmployeeDetails.BankDetails), characterReference As List(Of EmployeeDetails.CharacterReference), educationalAttainment As List(Of EmployeeDetails.EducationalAttainment), employmentHistory As List(Of EmployeeDetails.EmploymentHistory), serviceHistory As List(Of EmployeeDetails.ServiceHistory), oPERATION As String, studentsDetails As StudentAcademic)

        Try
            Dim sql As String = ""


            SavePerson(personDetails, oPERATION)

            Try
                'Statutory
                DataSource(String.Format("DELETE FROM person_statutory WHERE person_id = '" & _personID & "';"))

                sql &= " INSERT INTO person_statutory SET"
                sql &= String.Format(" person_id = '{0}',", _personID)
                sql &= String.Format(" tin = '{0}',", personDetails.TIN)
                sql &= String.Format(" sss = '{0}',", personDetails.SSS)
                sql &= String.Format(" pagibig = '{0}',", personDetails.PagIBIG)
                sql &= String.Format(" philhealth = '{0}'", personDetails.PhilHealth)
                DataSource(sql)
            Catch ex As Exception
                sql = Nothing
            End Try
            sql = Nothing

            Try
                'Contact Person
                DataSource(String.Format("DELETE FROM `person_contact_person` WHERE person_id = '" & _personID & "';"))
                If personDetails.contact_person <> "" Then
                    sql &= " INSERT INTO person_contact_person SET"
                    sql &= String.Format(" person_id = '{0}',", _personID)
                    sql &= String.Format(" contact_person = '{0}',", personDetails.contact_person)
                    sql &= String.Format(" contact_address = '{0}',", personDetails.contact_address)
                    sql &= String.Format(" contact_number = '{0}',", personDetails.contact_number)
                    sql &= String.Format(" contact_relationship = '{0}'", personDetails.contact_relationship)
                    DataSource(sql)
                End If
                sql = Nothing
            Catch ex As Exception
            End Try

            Try
                'Address
                DataSource(String.Format("DELETE FROM `person_address` WHERE person_id = '" & _personID & "';"))
                For Each rows In address
                    If rows.address <> "" Then
                        sql = "INSERT INTO person_address SET"
                        sql &= String.Format(" person_id = '{0}',", _personID)
                        sql &= String.Format(" address_type_id = '{0}',", rows.address_type_id)
                        sql &= String.Format(" address = '{0}',", rows.address)
                        sql &= String.Format(" barangay = '{0}',", rows.barangay)
                        sql &= String.Format(" citymunicipality = '{0}',", rows.citymunicipality)
                        sql &= String.Format(" zipcode = '{0}',", rows.zipcode)
                        sql &= String.Format(" province = '{0}'", rows.province)
                        DataSource(sql)
                    End If
                    sql = Nothing
                Next

            Catch ex As Exception
            End Try

            Try
                'Photo
                DataSource(String.Format("DELETE FROM `person_photo` WHERE person_id = '" & _personID & "';"))
                For Each rows In photo
                    If rows.photo_file_name <> "" Then
                        sql = "INSERT INTO person_photo SET"
                        sql &= String.Format(" person_id = '{0}',", _personID)
                        sql &= String.Format(" photo_file_name = '{0}',", rows.photo_file_name)
                        sql &= String.Format(" photo_path = '{0}',", rows.photo_path)
                        sql &= String.Format(" original_file_name = '{0}'", rows.original_photo_file_name)
                        DataSource(sql)

                    End If
                    sql = Nothing
                Next
            Catch ex As Exception
            End Try

            Try
                'Dependent
                DataSource(String.Format("DELETE FROM `person_dependent` WHERE person_id = '" & _personID & "';"))
                For Each rows In dependent
                    If rows.dependent_name <> "" Then
                        sql = "INSERT INTO person_dependent SET"
                        sql &= String.Format(" person_id = '{0}',", _personID)
                        sql &= String.Format(" dependent_name = '{0}',", rows.dependent_name)
                        sql &= String.Format(" dependent_birthdate = '{0}',", Format(rows.dependent_birthdate.Date, "yyyy-MM-dd"))
                        sql &= String.Format(" dependent_relationship = '{0}',", rows.dependent_relationship)
                        sql &= String.Format(" dependent_count = '{0}',", rows.dependent_rank)
                        sql &= String.Format(" grade_year = '{0}',", rows.dependent_gradeyear)
                        sql &= String.Format(" school = '{0}'", rows.dependent_school)
                        DataSource(sql)
                    End If
                    sql = Nothing
                Next
            Catch ex As Exception
            End Try

            Try
                'Family Background
                DataSource(String.Format("DELETE FROM `person_familybackground` WHERE person_id = '" & _personID & "';"))
                For Each rows In familyBackground
                    If rows.name <> "" Then
                        sql = "INSERT INTO person_familybackground SET"
                        sql &= String.Format(" person_id = '{0}',", _personID)
                        sql &= String.Format(" family_background_type = '{0}',", rows.typeFamilyGuardian)
                        sql &= String.Format(" family_background_name = '{0}',", rows.name)
                        sql &= String.Format(" family_background_occupation = '{0}',", rows.occupation)
                        sql &= String.Format(" family_background_company_name = '{0}',", rows.company_name)
                        sql &= String.Format(" family_background_company_number = '{0}',", rows.company_number)
                        sql &= String.Format(" family_background_company_address = '{0}'", rows.company_address)
                        DataSource(sql)
                    End If
                    sql = Nothing
                Next
            Catch ex As Exception

            End Try

            Try
                'Character Reference
                DataSource(String.Format("DELETE FROM `person_reference` WHERE person_id = '" & _personID & "';"))
                For Each rows In characterReference
                    If rows.CharRName <> "" Then
                        sql = "INSERT INTO person_reference SET"
                        sql &= String.Format(" person_id = '{0}',", _personID)
                        sql &= String.Format(" `name` = '{0}',", rows.CharRName)
                        sql &= String.Format(" `position` = '{0}',", rows.CharRPosition)
                        sql &= String.Format(" company = '{0}',", rows.CharRcompany)
                        sql &= String.Format(" contact_number = '{0}'", rows.CharRContactNumber)
                        DataSource(sql)
                    End If
                    sql = Nothing
                Next
            Catch ex As Exception
            End Try

        Catch ex As Exception

        End Try

        Try
            'Educational Attainment
            DataSource(String.Format("DELETE FROM `person_educational_attainment` WHERE person_id = '" & _personID & "';"))
            For Each rows In educationalAttainment
                If rows.EduDescription <> "" Then
                    sql = "INSERT INTO person_educational_attainment SET"
                    sql &= String.Format(" person_id = '{0}',", _personID)
                    sql &= String.Format(" education_attainment = '{0}',", rows.EduDescription)
                    sql &= String.Format(" school_address = '{0}',", rows.SchoolAddress)
                    sql &= String.Format(" date_from = '{0}',", Format(rows.EduFrom.Date, "yyyy-MM-dd"))
                    sql &= String.Format(" date_to = '{0}',", Format(rows.EduTo.Date, "yyyy-MM-dd"))
                    sql &= String.Format(" honors_received = '{0}'", rows.EduHonorsReceived)
                    DataSource(sql)
                End If
                sql = Nothing
            Next
        Catch ex As Exception
        End Try

        Try
            'Employment History
            DataSource(String.Format("DELETE FROM `person_employment_history` WHERE person_id = '" & _personID & "';"))
            For Each rows In employmentHistory
                If rows.EmplHCompanyName <> "" Then
                    sql = "INSERT INTO person_employment_history SET"
                    sql &= String.Format(" person_id = '{0}',", _personID)
                    sql &= String.Format(" company = '{0}',", rows.EmplHCompanyName)
                    sql &= String.Format(" date_from = '{0}',", Format(rows.EmplHFrom.Date, "yyyy-MM-dd"))
                    sql &= String.Format(" date_to = '{0}',", Format(rows.EmplHTo.Date, "yyyy-MM-dd"))
                    sql &= String.Format(" contact_number = '{0}'", rows.EmplHContactNumber)
                    DataSource(sql)
                End If
                sql = Nothing
            Next
        Catch ex As Exception
        End Try

        Try
            'Service History
            DataSource(String.Format("DELETE FROM `person_service_history` WHERE person_id = '" & _personID & "';"))
            For Each rows In serviceHistory
                If rows.ServHLevel <> "" And rows.ServHCareer <> "" Then
                    sql = "INSERT INTO person_service_history SET"
                    sql &= String.Format(" person_id = '{0}',", _personID)
                    sql &= String.Format(" service_level = '{0}',", rows.ServHLevel)
                    sql &= String.Format(" service_career = '{0}',", rows.ServHCareer)
                    sql &= String.Format(" date_examination = '{0}',", Format(rows.ServHDateExam.Date, "yyyy-MM-dd"))
                    sql &= String.Format(" place_examination = '{0}',", rows.ServHPlaceExam)
                    sql &= String.Format(" ratings = '{0}',", rows.ServHRatings)
                    sql &= String.Format(" license_number = '{0}',", rows.ServHLicenseNumber)
                    sql &= String.Format(" date_release = '{0}'", Format(rows.ServHDateRelease.Date, "yyyy-MM-dd"))
                    DataSource(sql)
                End If
                sql = Nothing
            Next
        Catch ex As Exception
        End Try


        If personDetails.person_type = 1 Then
            'Employee's details

            If employeeDetails.userID = 0 Then
                    employeeDetails.userID = createNewUserAccount(personDetails, employeeDetails)
                End If

            SaveEmployee(employeeDetails, oPERATION, personDetails.person_type)

                Try
                    'Bank
                    DataSource(String.Format("DELETE FROM `employee_bank_details` WHERE employee_id = '" & _id & "';"))
                    For Each rows In bankDetails
                        If rows.BankName <> "" Then
                            sql = "INSERT INTO employee_bank_details SET"
                            sql &= String.Format(" employee_id = '{0}',", _id)
                            sql &= String.Format(" bank_info = '{0}',", rows.BankName)
                            sql &= String.Format(" bank_account_number = '{0}'", rows.AccountNumber)
                            DataSource(sql)
                        End If
                        sql = Nothing
                    Next
                Catch ex As Exception
                End Try

            Else
            'Student's Details

            Save_StudentsDetails(studentsDetails, oPERATION)

            Try
                'Attended University
                DataSource(String.Format("DELETE FROM students_attended_university WHERE person_id = '" & _personID & "'"))
                For Each rows In Attended_University
                    DataSource(String.Format("INSERT INTO `students_attended_university`
                                            (`person_id`,
                                             `name`,
                                              relationship)
                                      VALUES ('" & _personID & "',
                                             '" & rows.NameOfAttendy & "',
                                             '" & rows.RelationshipAttendy & "');"))

                Next
            Catch ex As Exception

            End Try

            Try
                'Non-Academic
                DataSource(String.Format("DELETE FROM students_non_academic WHERE person_id = '" & _personID & "'"))
                For Each rows In NonAcademic
                    DataSource(String.Format("INSERT INTO `students_non_academic`
                                            (`person_id`,
                                             `title`,
                                              non_academic_name)
                                      VALUES ('" & _personID & "',
                                             '" & rows.Title & "',
                                             '" & rows.Non_Academic_Name & "');"))

                Next

            Catch ex As Exception

            End Try



            Try
                'List of Achievements
                DataSource(String.Format("DELETE FROM students_list_achievements WHERE person_id = '" & _personID & "'"))
                For Each rows In ListOfAchievements
                    DataSource(String.Format("INSERT INTO `students_list_achievements`
                                            (`person_id`,
                                             `file_path`,
                                              file_name)
                                      VALUES ('" & _personID & "',
                                             '" & rows.FilePath & "',
                                             '" & rows.FileName & "');"))

                Next

            Catch ex As Exception

            End Try

            Try
                'List of Attachment Documents
                DataSource(String.Format("DELETE FROM students_attachment WHERE person_id = '" & _personID & "'"))
                For Each rows In ListOfAttachments
                    DataSource(String.Format("INSERT INTO `students_attachment`
                                            (`person_id`,
                                               attach_document_type_id,
                                             `file_path`,
                                              file_name)
                                      VALUES ('" & _personID & "',
                                             '" & rows.DocumentType_id & "',  
                                             '" & rows.FilePath & "',
                                             '" & rows.FileName & "');"))

                Next
            Catch ex As Exception

            End Try

            Try
                'Update Student ID Number
                If oPERATION = "EDIT" Then

                    DataSource(String.Format("UPDATE `students` SET `std_number` = '" & StudentID & "' WHERE person_id = '" & _personID & "';"))

                End If
            Catch ex As Exception

            End Try


        End If

    End Sub

    Friend Function CheckIfStudentIDExist(StudentID As String, PersonID As Integer) As Boolean

        Dim id As String = DataObject(String.Format("SELECT
DISTINCT students.std_number
FROM
students
INNER JOIN person ON students.person_id = person.person_id
WHERE
students.status_type_id = 1 AND
person.status_type_id = 1 AND
students.end_time IS NULL AND
students.std_number = '" & StudentID & "'
"))

        If id = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Save_StudentsDetails(studentsDetails As StudentAcademic, oPERATION As String)

        'Check Person into Students Details
        If oPERATION = "EDIT" Then
            oPERATION = getRecordPerson_fromStudentDetails(_personID)
        End If


        Dim sql As String = ""
        If oPERATION = "ADD" Then
            sql = "INSERT INTO students_details SET"
        Else
            sql = "UPDATE students_details SET"
        End If

        With studentsDetails
            sql &= String.Format(" person_id = '{0}',", _personID)
            sql &= String.Format(" LRN_number = '{0}',", .LRN)
            sql &= String.Format(" student_data = '{0}',", .student_data)
            sql &= String.Format(" date_encoded = '{0}',", Format(.date_application.Date, "yyyy-MM-dd"))
            sql &= String.Format(" year_level = '{0}',", .year_level)
            sql &= String.Format(" interest = '{0}',", .interest)
            sql &= String.Format(" estimate_family_monthly_income = '{0}',", .family_income)
            sql &= String.Format(" scholarship_sponsor_name = '{0}',", .sponsors)
            sql &= String.Format(" what_course = '{0}',", .course_another)
            sql &= String.Format(" first_choice_course = '{0}',", .course_choice)
            sql &= String.Format(" plan_after_college = '{0}',", .plan_after_college)
            sql &= String.Format(" high_school_name = '{0}',", .high_school_name)
            sql &= String.Format(" high_school_address = '{0}',", .high_school_address)
            sql &= String.Format(" date_graduation = '{0}',", Format(.high_school_dategraduation.Date, "yyyy-MM-dd"))
            sql &= String.Format(" extra_curricular_activities = '{0}',", .high_school_extracurr_activities)
            sql &= String.Format(" other_extra_curricular_participation = '{0}',", .other_extra_curricular_participation)
            sql &= String.Format(" other_resources_avialable = '{0}',", .other_resources_available)
            sql &= String.Format(" other_skills_tallents = '{0}',", .other_skills_talents)
            sql &= String.Format(" other_sports = '{0}',", .other_sports)
            sql &= String.Format(" master_program = '{0}',", .college_master_program)
            sql &= String.Format(" specialization = '{0}',", .college_specialization)
            sql &= String.Format(" previous_degree = '{0}',", .college_degree_earned)
            sql &= String.Format(" previous_university = '{0}',", .college_university_name)
            sql &= String.Format(" join_position_id = '{0}',", .join_position_id)
            sql &= String.Format(" year_from = '{0}',", Format(.college_year_from.Date, "yyyy-MM-dd"))
            sql &= String.Format(" year_to = '{0}'", Format(.college_year_to.Date, "yyyy-MM-dd"))

            If oPERATION = "ADD" Then
                DataSource(sql)
                _id = DataObject(String.Format("SELECT  MAX(`students_details_id`) FROM `students_details` LIMIT 0, 1000;"))
            Else
                sql &= String.Format(" WHERE students_details_id = '{0}'", _id)
                DataSource(sql)
            End If
        End With

    End Sub

    Private Function getRecordPerson_fromStudentDetails(personID As Integer) As String
        Dim id As Integer = 0
        id = DataObject(String.Format("SELECT students_details.person_id FROM students_details WHERE students_details.person_id = '" & personID & "'"))
        If id > 0 Then
            Return "EDIT"
        Else
            Return "ADD"
        End If

    End Function

    Friend Function getExistingEmplNumber(EmplNumber As String) As Boolean
        Dim id As Integer = 0
        EmplNumber = EmplNumber.Substring(EmplNumber.LastIndexOf("-"c) + 1)
        EmplNumber = CInt(EmplNumber)
        id = DataObject(String.Format("SELECT
                  employees.employee_number
                FROM `employees`
                INNER JOIN person
                      ON person.person_id = employees.person_id AND person.status_type_id = 1 AND person.end_time IS NULL
                WHERE employees.employee_number = '" & EmplNumber & "' "))
        If id <> 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub SaveEmployee(employeeDetails As EmployeeDetails, oPERATION As String, Optional personType As Integer = Nothing)

        If personType = 1 Then

            Dim sql As String = ""
            If oPERATION = "ADD" Then
                sql = "INSERT INTO employees SET"
            Else
                sql = "UPDATE employees SET"
            End If

            With employeeDetails
                sql &= String.Format(" person_id = '{0}',", _personID)
                sql &= String.Format(" user_id = '{0}',", .userID)
                sql &= String.Format(" employee_category_id = '{0}',", .employee_category_id)
                sql &= String.Format(" employee_number = '{0}',", .employee_number)
                sql &= String.Format(" empl_number = '{0}',", .empl_number)
                sql &= String.Format(" joining_date = '{0}',", Format(.joining_date.Date, "yyyy-MM-dd"))
                sql &= String.Format(" job_title = '{0}',", .job_title)
                sql &= String.Format(" employee_position_id = '{0}',", .employee_position_id)
                sql &= String.Format(" employee_department_id = '{0}',", .employee_department_id)
                sql &= String.Format(" employee_grade_id = '{0}',", .employee_grade_id)
                sql &= String.Format(" qualification = '{0}',", .employee_qualification)
                sql &= String.Format(" status_description = '{0}',", .status_description)
                sql &= String.Format(" firstday_date = '{0}',", Format(.firtsday_date.Date, "yyyy-MM-dd"))
                sql &= String.Format(" biometric_id = '{0}',", .biometric_id)
                sql &= String.Format(" date_encoded = '{0}',", Format(.date_application.Date, "yyyy-MM-dd"))
                sql &= String.Format(" salary = '{0}'", .salary)
                If oPERATION = "ADD" Then
                    DataSource(sql)
                    _id = DataObject(String.Format("SELECT  MAX(`id`) FROM `employees` LIMIT 0, 1000;"))
                Else
                    sql &= String.Format(" WHERE id = '{0}'", _id)
                    DataSource(sql)
                End If
            End With
        End If

    End Sub

    Private Sub SavePerson(personDetails As PersonDetails, oPERATION As String)

        Dim sql As String = ""
        If oPERATION = "ADD" Then
            sql = "INSERT INTO person SET"
        Else
            sql = "UPDATE person SET"
        End If

        With personDetails

            sql &= String.Format(" person_type_id = '{0}',", .person_type)
            sql &= String.Format(" first_name = '{0}',", .first_name)
            sql &= String.Format(" middle_name = '{0}',", .middle_name)
            sql &= String.Format(" last_name = '{0}',", .last_name)
            sql &= String.Format(" display_name = '{0}',", .full_name)
            sql &= String.Format(" gender = '{0}',", .gender)
            sql &= String.Format(" date_of_birth = '{0}',", Format(.date_of_birth.Date, "yyyy-MM-dd"))
            sql &= String.Format(" birth_place = '{0}',", .date_of_place)
            sql &= String.Format(" marital_status = '{0}',", .marital_status)
            sql &= String.Format(" blood_group = '{0}',", .blood_group)
            sql &= String.Format(" nationality_id = '{0}',", .nationality_id)
            sql &= String.Format(" telephone1 = '{0}',", .home_phone)
            sql &= String.Format(" mobile = '{0}',", .mobile_phone)
            sql &= String.Format(" email = '{0}',", .email)
            sql &= String.Format(" religion = '{0}',", .relegion)
            sql &= String.Format(" `language` = '{0}',", .language)
            sql &= String.Format(" disability = '{0}',", .disability)
            sql &= String.Format(" application_setup_id = '{0}'", AppSetup_Domain)
            If oPERATION = "ADD" Then
                DataSource(sql)
                _personID = DataObject(String.Format("SELECT MAX(`person_id`) FROM `person` LIMIT 0, 1000;"))
                personID_image = _personID
            Else
                sql &= String.Format(" WHERE person_id = '{0}'", _personID)
                DataSource(sql)
            End If

        End With

    End Sub


    Friend Function getEducationAttainment(appSetup_Domain As Integer) As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                        educational_attainment_d.educational_attainment_details_id as 'ID',
                        educational_attainment.`name` as 'Name'
                        FROM
                        educational_attainment
                        INNER JOIN educational_attainment_d ON educational_attainment_d.educational_attainent_id = educational_attainment.id
                        WHERE
                        educational_attainment.status_type_id = 1 AND
                        educational_attainment_d.end_time IS NULL AND
                        educational_attainment_d.application_setup_id = '" & appSetup_Domain & "'
                        "))
        Return dt
    End Function

    Friend Function getNumberDigit(EmployeeNumber As String) As String
        Dim Number As String = ""
        Dim series As String = ""
        Dim bday As String = ""
        Dim year As String = ""

        Try
            Number = EmployeeNumber.Substring(EmployeeNumber.LastIndexOf("-"c) + 1)
            Number = CInt(Number)

            'User Name
            series = EmployeeNumber.Substring(EmployeeNumber.LastIndexOf("-"c) + 1)
            bday = EmployeeNumber.Substring(9, 4)
            year = EmployeeNumber.Substring(4, 4)

            UserName = year + bday + series


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Number
    End Function

    Friend Function getDocumentType() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
attach_document_type.attach_document_type_id AS `ID`,
attach_document_type.`name` AS `Name`,
attach_document_type.description
FROM
attach_document_type
"))
        Return dt
    End Function

    Friend Function getEntranceData() As Object
        Dim str As String = ""
        str = "SELECT
student_data.id,
student_data.`name`
FROM
student_data
WHERE
student_data.status_type_id = 1 AND
student_data.end_time IS NULL
"
        Return DataSource(str)
    End Function

    Friend Function getServerDetails(appSetup_Domain As Integer) As DataTable
        Dim sql As String = ""
        sql = "SELECT
server_path.server_path,
server_path.`directory`,
server_path.workgroup_pcname,
server_path.usernname,
server_path.`password`
FROM
server_path
WHERE
server_path.application_setup_id = '" & appSetup_Domain & "'
"
        Return DataSource(sql)
    End Function

    'Private Sub _insertPerson(sql As String, personDetails As PersonDetails)

    '    With personDetails
    '        sql &= String.Format(" first_name = '{0}',", .first_name)
    '        sql &= String.Format(" middle_name = '{0}',", .middle_name)
    '        sql &= String.Format(" last_name = '{0}',", .last_name)
    '        sql &= String.Format(" date_of_birth = '{0}',", Format(.date_of_birth.Date, "yyyy-MM-dd"))
    '        sql &= String.Format(" gender = '{0}',", .gender)
    '        sql &= String.Format(" blood_group = '{0}',", .blood_group)
    '        sql &= String.Format(" birth_place = '{0}',", .date_of_place)
    '        sql &= String.Format(" nationality_id = '{0}',", .nationality_id)
    '        sql &= String.Format(" `language` = '{0}',", .language)
    '        sql &= String.Format(" religion = '{0}',", .relegion)
    '        sql &= String.Format(" address_line1 = '{0}',", .home_address_line1)
    '        sql &= String.Format(" address_line2 = '{0}',", .home_address_line2)
    '        sql &= String.Format(" city = '{0}',", .home_city)
    '        sql &= String.Format(" state = '{0}',", .home_province)
    '        sql &= String.Format(" pin_code = '{0}',", .home_pin_code)
    '        sql &= String.Format(" phone1 = '{0}',", .home_phone)
    '        sql &= String.Format(" phone2 = '{0}',", .mobile_phone)
    '        sql &= String.Format(" email = '{0}',", .email)
    '        sql &= String.Format(" photo_file_name = '{0}',", .photo_file_name)
    '        sql &= String.Format(" photo_data = '{0}',", .photo_data)

    '    End With
    'End Sub



    'Private Sub _SQL(personDetails As EmployeeDetails, Optional personID As Integer = Nothing, Optional userID As Integer = Nothing)

    '    With personDetails
    '        'Try
    '        '    If Not personDetails.photo_file_name.Length = 0 Then

    '        '        fs = New FileStream(personDetails.photo_file_name, FileMode.Open, FileAccess.Read)
    '        '        FileSize = fs.Length

    '        '        rawData = New Byte(FileSize) {}
    '        '        fs.Read(rawData, 0, FileSize)
    '        '        fs.Close()

    '        '        sql &= String.Format(" photo_file_name = '{0}',", .photo_file_name)
    '        '        sql &= String.Format(" photo_data = '{0}',", rawData)
    '        '        sql &= String.Format(" photo_file_size = '{0}',", FileSize)

    '        '    End If
    '        'Catch ex As Exception
    '        'End Try

    '        sql &= String.Format(" employee_category_id = '{0}',", .employee_category_id)
    '        sql &= String.Format(" employee_number = '{0}',", .employee_number)
    '        sql &= String.Format(" joining_date = '{0}',", Format(.joining_date.Date, "yyyy-MM-dd"))
    '        sql &= String.Format(" first_name = '{0}',", .first_name)
    '        sql &= String.Format(" middle_name = '{0}',", .middle_name)
    '        sql &= String.Format(" last_name = '{0}',", .last_name)
    '        sql &= String.Format(" gender = '{0}',", .gender)
    '        sql &= String.Format(" job_title = '{0}',", .job_title)
    '        sql &= String.Format(" employee_position_id = '{0}',", .employee_position_id)
    '        sql &= String.Format(" employee_department_id = '{0}',", .employee_department_id)
    '        sql &= String.Format(" employee_grade_id = '{0}',", .employee_grade_id)
    '        sql &= String.Format(" qualification = '{0}',", .employee_qualification)
    '        sql &= String.Format(" `status` = '{0}',", 1)
    '        sql &= String.Format(" status_description = '{0}',", .status_description)
    '        sql &= String.Format(" date_of_birth = '{0}',", Format(.date_of_birth.Date, "yyyy-MM-dd"))
    '        sql &= String.Format(" birth_place = '{0}',", .date_of_place)
    '        sql &= String.Format(" marital_status = '{0}',", .marital_status)
    '        sql &= String.Format(" blood_group = '{0}',", .blood_group)
    '        sql &= String.Format(" nationality_id = '{0}',", .nationality_id)
    '        sql &= String.Format(" home_address_line1 = '{0}',", .home_address_line1)
    '        sql &= String.Format(" home_address_line2 = '{0}',", .home_address_line2)
    '        sql &= String.Format(" home_city = '{0}',", .home_city)
    '        sql &= String.Format(" home_state = '{0}',", .home_province)
    '        sql &= String.Format(" home_pin_code = '{0}',", .home_pin_code)
    '        sql &= String.Format(" office_address_line1 = '{0}',", .office_address_line1)
    '        sql &= String.Format(" office_address_line2 = '{0}',", .office_address_line2)
    '        sql &= String.Format(" office_city = '{0}',", .office_city)
    '        sql &= String.Format(" office_state = '{0}',", .office_province)
    '        sql &= String.Format(" office_pin_code = '{0}',", .office_pin_code)
    '        sql &= String.Format(" mobile_phone = '{0}',", .mobile_phone)
    '        sql &= String.Format(" home_phone = '{0}',", .home_phone)
    '        sql &= String.Format(" email = '{0}',", .email)
    '        sql &= String.Format(" display_name = '{0}',", .full_name)
    '        sql &= String.Format(" firstday_date = '{0}',", Format(.firtsday_date.Date, "yyyy-MM-dd"))
    '        sql &= String.Format(" biometric_id = '{0}',", .biometric_id)
    '        sql &= String.Format(" religion = '{0}',", .relegion)
    '        sql &= String.Format(" `language` = '{0}',", .language)
    '        sql &= String.Format(" salary = '{0}',", .salary)
    '        sql &= String.Format(" created_at = '{0}',", Format(Date.Now.Date, "yyyy-MM-dd H:mm:ss"))

    '        sql &= String.Format(" photo_file_name = '{0}',", .photo_file_name)
    '        sql &= String.Format(" photo_path = '{0}',", .photo_path)

    '        sql &= String.Format(" user_id = '{0}',", userID)
    '        sql &= String.Format(" person_id = '{0}'", .personID)


    '    End With
    'End Sub
End Class
