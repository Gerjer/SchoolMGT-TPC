Imports DevComponents.DotNetBar.Controls

Public Class SubjectLoadListModel
    Friend Function getAcademicYear() As Object
        Dim sql As String = ""
        sql = "SELECT DISTINCT
'0' AS 'id',
students.academice_year 'name'
FROM
students
ORDER BY academice_year desc
    "
        Return DataSource(sql)
    End Function

    Friend Function getSubjectLoad(where As String) As Object
        Dim sql As String = ""
        sql = "SELECT
   'False' AS 'INCLUDE',
   	employee_name 'Instructor',
	COUNT( employee_name ) 'TotalSubjectLoad',
   employee_id
FROM
	(
	SELECT
		subject_class_schedule.employee_id,
		subject_class_schedule.employee_name,
		subjects.`name`,
		subjects.`code`,
		students.academice_year,
		students.semester,
		students.year_level

	FROM
		students_subjects
		INNER JOIN subject_class_schedule ON students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item
		INNER JOIN subjects ON students_subjects.subject_id = subjects.id
		INNER JOIN students ON students_subjects.student_id = students.id 

         " & where & "

	GROUP BY
		`code` 
	ORDER BY
		subject_class_schedule.employee_name ASC,
		subjects.`name` ASC 
	) A 
GROUP BY
	`Instructor`"
        Return DataSource(sql)
    End Function

    Friend Function getSubjectLoadInsttructor(InstructorID As Integer) As DataTable
        Dim sql As String = ""
        sql = "
SELECT
employee_id,
employee_name,
class_time,
SubjectCode,
SubjectName,
credit_hours,
Concat(Course,'-',`order`) 'Course',
Block,
`day`,
room,
`No.Student`,
year_level,
`order`
FROM(
			SELECT
			subject_class_schedule.employee_id,
			subject_class_schedule.employee_name,
			subject_class_schedule.class_time,
			subjects.`code` AS SubjectCode,
			subjects.`name` AS SubjectName,
			subjects.credit_hours,
			(SELECT courses.`code` FROM courses WHERE courses.id = students.course_id) AS Course,
			subject_class_schedule.`code`,
			CASE WHEN subject_class_schedule.`code` LIKE '%Block' THEN subject_class_schedule.`code`
			     ELSE '' END AS 'Block',
			subject_class_schedule.`day`,
			subject_class_schedule.room,
			Count(students.person_id) AS `No.Student`,
			students.year_level,
			CASE WHEN students.year_level = '1st year' THEN 1
				 WHEN students.year_level = '2nd year' THEN 2
				 WHEN students.year_level = '3rd year' then 3
				 WHEN students.year_level = '4th year' then 4
				 WHEN students.year_level = '5th year' then 5
				 WHEN students.year_level = '6th year' then 6
				 ELSE 7 END as 'order'
				
			FROM
			students_subjects
			INNER JOIN subject_class_schedule ON students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item
			INNER JOIN subjects ON students_subjects.subject_id = subjects.id
			INNER JOIN students ON students_subjects.student_id = students.id
			WHERE
			subject_class_schedule.employee_id IN ('" & InstructorID & "')
			GROUP BY
			subjects.`code`
			ORDER BY
			subject_class_schedule.employee_name ASC,
			SubjectCode ASC,
			students.person_id ASC
) A

ORDER BY `order`"
        Return DataSource(sql)
    End Function

    Friend Function getPreparationSubject1(where As String) As DataTable
        Dim dt As New DataTable
        Dim sql As String = ""
        sql = "SELECT 
        employee_id,
         count(employee_id) AS 'PreSubject'
        FROM(
        SELECT
        	subjects.`name`,
        	subjects.`code`,
        	subject_class_schedule.employee_id,
        	students.year_level

        FROM
        	students_subjects
        	INNER JOIN subject_class_schedule ON students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item
        	INNER JOIN subjects ON students_subjects.subject_id = subjects.id
        	INNER JOIN students ON students_subjects.student_id = students.id 

             " & where & "

        			 GROUP BY `code`
        			 ORDER BY `code`
         )A
            GROUP BY employee_id
        		ORDER BY `code`"
        'dt = clsDBConn.ExecQuery(String.Format("	SELECT 
        'employee_id,
        ' concat(count(employee_id),' PREPARATIONS (SUBJECTS)') AS 'PreSubject'
        'FROM(
        'SELECT
        '	subjects.`name`,
        '	subjects.`code`,
        '	subject_class_schedule.employee_id,
        '	students.year_level

        'FROM
        '	students_subjects
        '	INNER JOIN subject_class_schedule ON students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item
        '	INNER JOIN subjects ON students_subjects.subject_id = subjects.id
        '	INNER JOIN students ON students_subjects.student_id = students.id 

        '     " & where & "

        '			 GROUP BY `code`
        '			 ORDER BY `code`
        ' )A
        '    GROUP BY employee_id
        '		ORDER BY `code`"))
        dt = clsDBConn.ExecQuery(sql)
        Return dt
    End Function

    Friend Function getPreparationSubject(AcademincYear As String, semester As String, InstructorID As Integer) As String
        Dim PreSubject As String = ""
        Dim sql As String = ""
        sql = "	SELECT 
	 concat(count(employee_id),' PREPARATIONS (SUBJECTS)') AS 'PreSubject'
	FROM(
	SELECT
		subjects.`name`,
		subjects.`code`,
		subject_class_schedule.employee_id
		
	FROM
		students_subjects
		INNER JOIN subject_class_schedule ON students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item
		INNER JOIN subjects ON students_subjects.subject_id = subjects.id
		INNER JOIN students ON students_subjects.student_id = students.id 

         WHERE students.academice_year = '" & AcademincYear & "' AND students.semester = '" & semester & "' AND subject_class_schedule.employee_id= '" & InstructorID & "'
				 GROUP BY `code`
				 ORDER BY `code`
  )A
	    GROUP BY employee_id
			ORDER BY `code`"
        PreSubject = DataObject(sql)
        Return PreSubject
    End Function
End Class
