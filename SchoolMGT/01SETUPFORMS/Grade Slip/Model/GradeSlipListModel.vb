Public Class GradeSlipListModel

    'Dim sql As String = ""
    '    sql = ""
    '    Return DataSource(sql)

    Friend Function SetComboCourse() As Object
        Dim sql As String = ""
        sql = "SELECT
courses.id,
courses.course_name AS `name`,
courses.`code`,
courses.section_name
FROM
courses
WHERE
courses.is_deleted = 0"
        Return DataSource(sql)
    End Function

    Friend Function SetComboAcademicYear() As Object
        Dim sql As String = ""
        sql = "SELECT
students.id,
students.academice_year 'name'
FROM
students
GROUP BY
students.academice_year
ORDER BY
students.academice_year DESC
"
        Return DataSource(sql)
    End Function

    Friend Function getStudentList(AcademicYear As String, CourseID As Object, YearLevel As String, Semester As String) As Object
        Dim sql As String = ""
        sql = "SELECT
'False'AS 'INCLUDE',
person.display_name,
students.id AS stdID
FROM
students
INNER JOIN person ON students.person_id = person.person_id
WHERE
students.academice_year = '" & AcademicYear & "' AND
students.course_id = '" & CourseID & "' AND
students.year_level = '" & YearLevel & "' AND
students.semester = '" & Semester & "'

ORDER BY
display_name ASC
"
        Return DataSource(sql)
    End Function

    Friend Function getGrade(stdID As Object) As DataTable
        Dim sql As String = ""
        sql = "SELECT
stdID,
stdNumber,
CONCAT(last_name,', ',first_name,' ',middle_name) 'student_name',
gender,
CourseYrLvl,
YrLvl,
MIDTERM,
FINAL,
finalgrade,
CASE WHEN MIDTERM = 'NG' AND FINAL IS NULL THEN 'No Grade'
		WHEN MIDTERM = 'DR' AND FINAL IS NULL THEN 'Dropped'
		WHEN MIDTERM = 'NA' AND FINAL IS NULL THEN 'Not Attended'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL IS NULL THEN 'PASSED'
		
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'NG' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'DR' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM = 'NA' AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'NG' THEN 'No Grades'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'DR' THEN 'Dropped'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL = 'NA' THEN 'Not Attended'
		 
		WHEN MIDTERM > 3.1 AND FINAL BETWEEN 1.0 AND 3.0 THEN 'PASSED'
		WHEN MIDTERM BETWEEN 1.0 AND 3.0 AND FINAL > 3.1 THEN 'PASSED'
		 
		WHEN MIDTERM = 'NG' AND FINAL = 'NG' THEN 'No Grades'
		WHEN MIDTERM = 'DR' AND FINAL = 'DR' THEN 'Dropped'
		WHEN MIDTERM = 'NA' AND FINAL = 'NA' THEN 'Not Attended'
		 
		 WHEN MIDTERM > 3.1 AND FINAL > 3.1 THEN 'FAILED'			
		 ELSE '' END AS 'REMARKS',
		 Sem_AY,
	 	course_code,
		descriptive_title,
			units
		     
   FROM(
				Select
			   stdID,	
				stdNumber,
				last_name,
				first_name,
				middle_name,
				gender,
				CONCAT(`code`,' ',substring(year_level,1,1))'CourseYrLvl',
				substring(year_level,1,1) 'YrLvl',
				(SELECT student_grade.grades FROM student_grade WHERE student_grade.students_grading_id = 1 AND 
				student_grade.students_subject_id =student_subject_id) 'MIDTERM',
				(SELECT student_grade.grades FROM student_grade WHERE student_grade.students_grading_id = 2 AND 
				student_grade.students_subject_id = student_subject_id) 'FINAL',
				finalgrade,
			CONCAT(semester,', A.Y. ',academice_year)'Sem_AY',
				course_code,
				descriptive_title,
				units
	
				FROM(
				SELECT
				person.person_id,
				person.last_name,
				person.first_name,
				person.middle_name,
				person.gender,
				courses.`code`,
				students.year_level,
				students_subjects.finalgrade,
				students_subjects.id 'student_subject_id',
				subjects.id 'subjectid',
				students.semester,
				students.academice_year,
				day_schedule_id,
				class_timing_id,
				room_id,
				students.std_number 'stdNumber',
				subjects.`code` 'course_code',
				subjects.`name` 'descriptive_title',
				subjects.credit_hours 'units',
			  students.id 'stdID'
			  
				FROM
				students_subjects
				INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
				INNER JOIN students ON students.id = students_subjects.student_id
				INNER JOIN person ON person.person_id = students.person_id 
				INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id
				INNER JOIN courses ON students.course_id = courses.id
				WHERE person.status_type_id = 1 AND person.end_time IS NULL AND students.id = '" & stdID & "'
					
				)A  
				ORDER BY descriptive_title
		)B  GROUP BY descriptive_title"

        Return DataSource(sql)
    End Function
End Class
