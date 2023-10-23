Public Class GraduateListModel
    Friend Function LoadList() As Object
        Dim sql As String = ""
        sql = "SELECT
	graduate_student.class_roll_number, 
	graduate_student.student_name, 
	graduate_student.date_birth, 
	graduate_student.gender, 
	graduate_student.date_admitted, 
	graduate_student.degree_program, 
	graduate_student.program_major, 
	graduate_student.date_graduated, 
	graduate_student.complete_details,
    graduate_student.person_id,
    graduate_student.graduate_student_id 'id'
FROM
	graduate_student
	WHERE status_type_id = 1"
        Return DataSource(sql)
    End Function

    Friend Function LoadPRC() As DataTable
        Dim sql As String = ""
        sql = "SELECT
	graduate_student.class_roll_number, 
	graduate_student.date_birth, 
	person.last_name, 
	person.first_name, 
	person.middle_name, 
	graduate_student.gender, 
	graduate_student.date_graduated, 
	graduate_student.degree_program, 
	graduate_student.program_major, 
	graduate_student.authority_number, 
	graduate_student.authority_year_granted
FROM
	graduate_student
	INNER JOIN
	person
	ON 
		graduate_student.person_id = person.person_id AND person.status_type_id = 1 AND 
		graduate_student.authority_number <> ''
		"
        Return DataSource(sql)
    End Function

    Friend Function LoadStudent() As DataTable
        Dim sql As String = ""
        sql = "SELECT
person_id,
display_name,
`gRAD`
FROM(
SELECT
	person.person_id, 
	person.display_name,
	(SELECT
	graduate_student.student_name
FROM
	graduate_student
WHERE
	graduate_student.person_id = person.person_id) 'gRAD'
FROM
	person
WHERE
	person.status_type_id = 1 AND person.person_type_id = 2 

	GROUP BY display_name
	ORDER BY display_name
	)A WHERE A.`gRAD` IS  NULL"
        Return DataSource(sql)
    End Function
End Class
