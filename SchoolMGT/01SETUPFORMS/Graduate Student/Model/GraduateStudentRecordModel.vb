Imports SchoolMGT

Public Class GraduateStudentRecordModel
    Public OR_Details As OfficialReceiptInventroy
    Public graduate_student_id As Integer
    Friend Function getCitizenship() As Object
        Dim str As String = Nothing
        str = "SELECT
                  `id`   AS 'ID',
                  UPPER(`name`) AS 'Name'
                FROM `citizenship`
             WHERE `id` = 76
              "
        Return DataSource(str)
    End Function

    Friend Function gerCourseList() As Object
        Dim str As String = Nothing
        str = "SELECT
courses.id AS ID,
courses.description AS `Name`,
courses.`code`,
courses.section_name
FROM
courses
WHERE
courses.is_deleted = 0
"
        Return DataSource(str)
    End Function

    Friend Function getGraduateDetails(personID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person.person_id,
students.class_roll_no,
person.display_name AS `NAME`,
students.std_number AS `STUDENT NUMBER`,
person.date_of_birth AS `DATE OF BIRTH`,
person.birth_place AS `PLACE OF BIRTH`,
person.gender AS GENDER,
person.religion AS RELIGION,
person.nationality_id,
(SELECT
			citizenship.`name`
			FROM
			citizenship
			WHERE
			citizenship.id = person.nationality_id
) AS CITIZENSHIP,
(SELECT
			person_familybackground.family_background_name
			FROM
			person_familybackground
			WHERE
			person_familybackground.family_background_type = 'Father' AND
			person_familybackground.person_id = person.person_id
) AS 'FATHER',
(SELECT
			person_familybackground.family_background_name
			FROM
			person_familybackground
			WHERE
			person_familybackground.family_background_type = 'Mother' AND
			person_familybackground.person_id = person.person_id
) AS 'MOTHER',
CASE WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL AND zipcode IS NOT NULL AND province IS NOT NULL  THEN CONCAT(barangay,', ',citymunicipality,',',zipcode,', ',province)
WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL AND zipcode IS NOT NULL THEN CONCAT(barangay,', ',citymunicipality,',',zipcode)
WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL THEN CONCAT(barangay,', ',citymunicipality)
ELSE barangay END AS 'ADDRESS',
students_details.date_encoded 'DATE ADMITTED',
courses.description 'DEGREE PROGRAM',
students_details.student_data 'ENTRANCE DATA',
courses.id 'course_id'

FROM
person
LEFT JOIN students ON students.person_id = person.person_id
LEFT JOIN students_details ON students_details.person_id = person.person_id
LEFT JOIN courses ON students.course_id = courses.id
LEFT JOIN person_address ON person_address.person_id = person.person_id AND person_address.address_type_id = 1

WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
students.status_type_id = 1 AND
students.end_time IS NULL AND 
person.person_id = '" & personID & "'

GROUP BY person_id
"))
        Return dt
    End Function

    Friend Function getPremilinaryEducation(personID As Integer) As Object
        Dim str As String = "SELECT
                            religion,
                            father,
                            mother,
                            address,
                            entrance_data,
                            program_major,
                            date_graduated,
                            status_graduate,
                            place_birth,
                            date_admitted,
                            elementary_graduated 'ElemGrad',
                            elementary_schoolyear 'ElemYear',
                            highschool_graduated 'HighGrad',
                            highschool_schoolyear 'HighYear',
                            tertiary_graduated 'TertiaryGrad',
                            tertiary_schoolyear 'TertiaryYear',
                            graduate_student.complete_details
                            
                            FROM
                            graduate_student
                            WHERE
                            status_type_id = 1 AND
                            end_time IS NULL AND
                            person_id = '" & personID & "'
                            "
        Return DataSource(str)
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

    Friend Sub Insert(studentGrauate As GraduateStudent)
        Try
            With studentGrauate

                '    Delete Insert
                DataSource(String.Format("DELETE FROM graduate_student WHERE graduate_student_id = '" & graduate_student_id & "'"))

                DataSource(String.Format("INSERT INTO `graduate_student`
                        (
                         `person_id`,
                         `class_roll_number`,
                         `student_name`,
                         `student_IDNumber`,
                         `date_birth`,
                         `place_birth`,
                         `gender`,
                         `religion`,
                         `citizenship`,
                         `father`,
                         `mother`,
                         `address`,
                         `date_admitted`,
                         `entrance_data`,
                         `elementary_graduated`,
                         `elementary_schoolyear`,
                         `highschool_graduated`,
                         `highschool_schoolyear`,
                         `tertiary_graduated`,
                         `tertiary_schoolyear`,
                         `degree_program`,
                         `date_graduated`,
                         `program_major`,
                         `authority_number`,
                         `authority_year_granted`,
                         `status_graduate`,
                          complete_details
                          )
                VALUES (
                        '" & .person_id & "',
                        '" & .class_roll_number & "',
                        '" & .student_name & "',
                        '" & .student_ID & "',
                        '" & Format(.date_birth.Date, "yyyy-MM-dd") & "',
                        '" & .place_birth & "',
                        '" & .gender & "',
                        '" & .religion & "',
                        '" & .citizenship & "',
                        '" & .father & "',
                        '" & .mother & "',
                        '" & .address & "',
                        '" & Format(.date_admitted.Date, "yyyy-MM-dd") & "',
                        '" & .entrance_data & "',
                        '" & .elementary_graduated & "',
                        '" & .elementary_schoolyear & "',
                        '" & .highschool_graduated & "',
                        '" & .highschool_schoolyear & "',
                        '" & .tertiary_graduated & "',
                        '" & .tertiary_schoolyear & "',
                        '" & .degree_program & "',
                        '" & Format(.date_graduated.Date, "yyyy-MM-dd") & "',
                        '" & .program_major & "',
                        '" & .authority_number & "',
                        '" & .authority_year_granted & "',
                        '" & .status_graduate & "',
                        '" & .complete_details & "'
                         );"))
#Region "old"

                '            If OPERATION = "Add" Then
                '                ''Get ID last row
                '                'Dim id As Integer = DataObject(String.Format("SELECT
                '                '                            IFNULL(Max(graduate_student.graduate_student_id),0)
                '                '                            FROM
                '                '                            graduate_student
                '                '                            WHERE
                '                '                            graduate_student.status_type_id = 1 AND
                '                '                            graduate_student.person_id = '" & .person_id & "'
                '                '                            "))
                '                ''Update Last Row
                '                'If id > 0 Then
                '                '    DataSource(String.Format("UPDATE `graduate_student` SET `end_time` = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE `graduate_student_id` = '" & id & "';"))
                '                'End If

                '                'Insert 
                '                DataSource(String.Format("INSERT INTO `graduate_student`
                '        (
                '         `person_id`,
                '         `class_roll_number`,
                '         `student_name`,
                '         `student_IDNumber`,
                '         `date_birth`,
                '         `place_birth`,
                '         `gender`,
                '         `religion`,
                '         `citizenship`,
                '         `father`,
                '         `mother`,
                '         `address`,
                '         `date_admitted`,
                '         `entrance_data`,
                '         `elementary_graduated`,
                '         `elementary_schoolyear`,
                '         `highschool_graduated`,
                '         `highschool_schoolyear`,
                '         `tertiary_graduated`,
                '         `tertiary_schoolyear`,
                '         `degree_program`,
                '         `date_graduated`,
                '         `program_major`,
                '         `authority_number`,
                '         `authority_year_granted`,
                '         `status_graduate`,
                '          complete_details
                '          )
                'VALUES (
                '        '" & .person_id & "',
                '        '" & .class_roll_number & "',
                '        '" & .student_name & "',
                '        '" & .student_ID & "',
                '        '" & Format(.date_birth.Date, "yyyy-MM-dd") & "',
                '        '" & .place_birth & "',
                '        '" & .gender & "',
                '        '" & .religion & "',
                '        '" & .citizenship & "',
                '        '" & .father & "',
                '        '" & .mother & "',
                '        '" & .address & "',
                '        '" & Format(.date_admitted.Date, "yyyy-MM-dd") & "',
                '        '" & .entrance_data & "',
                '        '" & .elementary_graduated & "',
                '        '" & .elementary_schoolyear & "',
                '        '" & .highschool_graduated & "',
                '        '" & .highschool_schoolyear & "',
                '        '" & .tertiary_graduated & "',
                '        '" & .tertiary_schoolyear & "',
                '        '" & .degree_program & "',
                '        '" & Format(.date_graduated.Date, "yyyy-MM-dd") & "',
                '        '" & .program_major & "',
                '        '" & .authority_number & "',
                '        '" & .authority_year_granted & "',
                '        '" & .status_graduate & "',
                '        '" & .complete_details & "'
                '         );"))


                '            Else

                '                'Delete Insert
                '                DataSource(String.Format("DELETE FROM graduate_student WHERE graduate_student_id = '" & graduate_student_id & "'"))

                '                DataSource(String.Format("INSERT INTO `graduate_student`
                '        (
                '         `person_id`,
                '         `class_roll_number`,
                '         `student_name`,
                '         `student_IDNumber`,
                '         `date_birth`,
                '         `place_birth`,
                '         `gender`,
                '         `religion`,
                '         `citizenship`,
                '         `father`,
                '         `mother`,
                '         `address`,
                '         `date_admitted`,
                '         `entrance_data`,
                '         `elementary_graduated`,
                '         `elementary_schoolyear`,
                '         `highschool_graduated`,
                '         `highschool_schoolyear`,
                '         `tertiary_graduated`,
                '         `tertiary_schoolyear`,
                '         `degree_program`,
                '         `date_graduated`,
                '         `program_major`,
                '         `authority_number`,
                '         `authority_year_granted`,
                '         `status_graduate`,
                '          complete_details
                '          )
                'VALUES (
                '        '" & .person_id & "',
                '        '" & .class_roll_number & "',
                '        '" & .student_name & "',
                '        '" & .student_ID & "',
                '        '" & Format(.date_birth.Date, "yyyy-MM-dd") & "',
                '        '" & .place_birth & "',
                '        '" & .gender & "',
                '        '" & .religion & "',
                '        '" & .citizenship & "',
                '        '" & .father & "',
                '        '" & .mother & "',
                '        '" & .address & "',
                '        '" & Format(.date_admitted.Date, "yyyy-MM-dd") & "',
                '        '" & .entrance_data & "',
                '        '" & .elementary_graduated & "',
                '        '" & .elementary_schoolyear & "',
                '        '" & .highschool_graduated & "',
                '        '" & .highschool_schoolyear & "',
                '        '" & .tertiary_graduated & "',
                '        '" & .tertiary_schoolyear & "',
                '        '" & .degree_program & "',
                '        '" & Format(.date_graduated.Date, "yyyy-MM-dd") & "',
                '        '" & .program_major & "',
                '        '" & .authority_number & "',
                '        '" & .authority_year_granted & "',
                '        '" & .status_graduate & "',
                '        '" & .complete_details & "'
                '         );"))



                '            End If
#End Region
                If OPERATION = "Add" Then
                    MessageBox.Show("Record has been Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record has been Update", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Function getGraduate_StudentDetails(pERSON_ID As Integer) As DataTable
        Dim sql As String = ""
        sql = "SELECT
	graduate_student.graduate_student_id, 
	graduate_student.person_id, 
	graduate_student.student_name AS `NAME`, 
	graduate_student.student_IDNumber AS `STUDENT NUMBER`, 
	graduate_student.date_birth AS `DATE OF BIRTH`, 
	graduate_student.place_birth AS `PLACE OF BIRTH`, 
	graduate_student.gender AS GENDER, 
	graduate_student.religion AS RELIGION, 
	graduate_student.citizenship AS nationality_id, 
	graduate_student.father AS FATHER, 
	graduate_student.mother AS MOTHER, 
	graduate_student.address AS ADDRESS, 
	graduate_student.date_admitted AS `DATE ADMITTED`, 
	graduate_student.entrance_data AS `ENTRANCE DATA`, 
	graduate_student.class_roll_number, 
	graduate_student.degree_program, 
	graduate_student.date_graduated, 
	graduate_student.status_graduate, 
	graduate_student.complete_details, 
	graduate_student.elementary_graduated AS ElemGrad, 
	graduate_student.elementary_schoolyear AS ElemYear, 
	graduate_student.highschool_graduated AS HighGrad, 
	graduate_student.highschool_schoolyear AS HighYear, 
	graduate_student.tertiary_graduated AS TertiaryGrad, 
	graduate_student.tertiary_schoolyear AS TertiaryYear,
    graduate_student.program_major
FROM
	graduate_student
WHERE
	graduate_student.person_id = '" & pERSON_ID & "'"
        Return DataSource(sql)
    End Function

    Friend Function getImagesDetails(personID As Integer) As DataTable
        Dim sql As String = ""
        sql = "SELECT
images.person_id,
images.image_type,
images.image_path,
images.description,
images.file_name
FROM
images
WHERE
images.person_id = '" & personID & "'
"
        Return DataSource(sql)
    End Function

    Friend Function getORDetails(ClassRollnumber As String, IssuedDate As String) As DataTable
        Dim str As String = "SELECT description,title,transaction_date,receipt_no,issued_date FROM finance_transactions WHERE payee_id = '" & ClassRollnumber & "' AND issued_date = '" & IssuedDate & "'  "
        Return DataSource(str)
    End Function

    Friend Function getTORDetails(class_roll_number As String) As DataTable
        Dim str = "SELECT
  last_name,
	first_name,
	middle_name,
	CONCAT(file.company_name,'-',FILE.description_name) 'SchollAddress',
	CONCAT(batches.semester,', AY ',batches.school_year,'-',batches.school_year + 1) 'SemesterYear',
	subjects.CODE 'subjcode',
	UPPER( subjects.NAME )'subjname',
	ROUND(students_subjects.finalgrade,1) 'finalgrade',    -- students_subjects.finalgrade,
    IFNULL(ROUND(students_subjects.re_exam,1),'')'re_exam',  -- IFNULL(students_subjects.re_exam,'')'re_exam',
	subjects.credit_hours,
	coursegroup.NAME 'cgname',
	group_courses.course_name,
	batches.NAME 'bname',
	subjects.ccid,
    students_subjects.id 'ssID',
    batches.id 'BatchID'
		
FROM
	group_courses
	INNER JOIN coursegroup ON ( group_courses.coursegroup_id = coursegroup.id )
	INNER JOIN batches ON ( batches.course_id = group_courses.course_id )
	INNER JOIN subjects ON ( subjects.batch_id = batches.id )
	INNER JOIN students_subjects ON ( students_subjects.subject_id = subjects.id )
	INNER JOIN students ON ( students_subjects.student_id = students.id ) 
	INNER JOIN person ON students.person_id = person.person_id AND person.status_type_id = 1 AND person.end_time IS NULL
	INNER JOIN file ON person.application_setup_id = file.application_setup_id
	
WHERE
	students.class_roll_no = '" & class_roll_number & "'  and   group_courses.end_time is NULL
ORDER BY
	batches.year_level,group_courses.course_name,
	batches.`NAME`"
        Return DataSource(str)
    End Function
End Class
