Public Class GradeSheetListModel


    Friend Function RetreivedList(where As String) As DataTable

        Dim dt As New DataTable
        Dim sql As String = ""
        sql += " SET @rowMale := 0;"
        sql += " SET @rowFemale := 0;"
        sql += " SELECT"
        sql += " CASE WHEN gender = 'MALE' Then @rowMale := @rowMale + 1 Else @rowFemale := @rowFemale + 1 End As 'NO.'"
        sql += " ,person_id,last_name 'LAST NAME',first_name 'FIRST NAME',middle_name 'MIDDLE NAME',gender"
        sql += " ,CONCAT(course_name,' ',year_level) 'COURSE / YEAR',finalgrade,student_subject_id"
        sql += " FROM("
        sql += "     SELECT"
        sql += "     person.person_id,person.last_name,person.first_name,person.middle_name,person.gender,courses.course_name,students.year_level"
        sql += "    ,students_subjects.finalgrade,students_subjects.id 'student_subject_id',subjects.id 'subjectid',students.semester"
        sql += "    ,students.academice_year,day_schedule_id,class_timing_id,room_id"
        sql += "      FROM"
        sql += "          students_subjects"
        sql += "          INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id"
        sql += "          INNER JOIN students ON students.id = students_subjects.student_id"
        sql += "          INNER JOIN person ON person.person_id = students.person_id"
        sql += "          INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id"
        sql += "          INNER JOIN courses ON students.course_id = courses.id"
        sql += "          WHERE person.status_type_id = 1 and person.end_time is NULL"
        sql += "      )A "
        sql += "        " & where & ""

        dt = clsDBConn.ExecQuery(sql)

        Return dt

#Region "Old"
        '        Dim dt As New DataTable
        '        dt = DataSource(String.Format("
        '       SELECT
        'CASE WHEN gender = 'MALE' THEN _male + 1
        'ELSE _female + 1 END as 'No.',
        'person_id,
        'last_name 'LAST NAME',
        'first_name 'FIRST NAME',
        'middle_name 'MIDDLE NAME',
        'gender,
        '	CONCAT(course_name,' ',year_level) 'COURSE / YEAR',
        'finalgrade,
        'student_subject_id

        'FROM(
        '			SELECT
        '			person.person_id,
        '			person.last_name,
        '			person.first_name,
        '			person.middle_name,
        '			person.gender,
        '			courses.course_name,
        '			students.year_level,
        '			students_subjects.finalgrade,
        '			students_subjects.id 'student_subject_id',
        '			subjects.id 'subjectid',
        '			students.semester,
        '			students.academice_year,
        '			day_schedule_id,
        '			class_timing_id,
        '			room_id,
        '			0 '_male',
        '			0 '_female'

        '			FROM
        '			students_subjects
        '			INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
        '			INNER JOIN students ON students.id = students_subjects.student_id
        '			INNER JOIN person ON person.person_id = students.person_id 
        '			INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id
        '			INNER JOIN courses ON students.course_id = courses.id

        '			WHERE person.status_type_id = 1 and person.end_time is NULL


        '			)A 
        '              " & where & "
        ' 		ORDER BY gender desc,course_name,year_level,last_name
        '                        "))
        '        Return dt
#End Region
    End Function

    Friend Function getGradeSheetRecord() As DataTable


        Dim sql As String = ""
        sql = "SELECT
'' as 'No.',
person.person_id,
person.last_name,
person.first_name,
person.middle_name,
person.gender,
CONCAT(courses.course_name,' - ',SUBSTRING(students.year_level,1,1)) 'COURSE / YEAR',
students_subjects.id 'StudentSubjID',
(SELECT
	student_grade.grades
	FROM
	student_grade
	WHERE
	student_grade.students_grading_id = 1 AND
	student_grade.students_subject_id = 'StudentSubjID'
	) 'MIDTERM',
	(SELECT
	student_grade.grades
	FROM
	student_grade
	WHERE
	student_grade.students_grading_id = 2 AND
	student_grade.students_subject_id = 'StudentSubjID'
	) 'FINAL',
  CONCAT((SELECT
					student_grade.remarks
					FROM
					student_grade
					WHERE
					student_grade.students_grading_id = 1 AND
					student_grade.students_subject_id = 'StudentSubjID'
					) 
	,' ',
					(SELECT
					student_grade.remarks
					FROM
					student_grade
					WHERE
					student_grade.students_grading_id = 2 AND
					student_grade.students_subject_id = 'StudentSubjID'
					) ) 'Remarks',

    subjects.id 'ID',
	CONCAT(subjects.`code`,' - ',subjects.`name`) AS 'Name',
	CONCAT('Units = ',subjects.credit_hours,', ','Amount Unit = ',subjects.amount,', ','Credit Distribution - ',subjects.creditdistribution) As 'Description',
	employees.employee_department_id,
	employee_departments.`name` AS 'Deparment',
	students.semester,
	students.academice_year,
	subject_class_schedule.day_schedule_id,
	subject_class_schedule.`day`,
	subject_class_schedule.class_timing_id,
	subject_class_schedule.class_time,
	subject_class_schedule.room_id,
	subject_class_schedule.room

FROM
students_subjects
INNER JOIN subjects ON students_subjects.subject_id = subjects.id
INNER JOIN subject_class_schedule ON subjects.id = subject_class_schedule.subject_id
INNER JOIN students ON students_subjects.student_id = students.id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN employees ON subject_class_schedule.employee_id = employees.id
INNER JOIN employee_departments ON employees.employee_department_id = employee_departments.id
INNER JOIN person ON person.person_id = students.person_id 

WHERE person.status_type_id = 1

-- GROUP BY id
ORDER BY gender DESC,course_name,year_level,last_name
-- ORDER BY subjects.`name` asc

"
        Return DataSource(sql)
    End Function

    Dim subecjtIDstr As String = ""
    Dim daynameIDstr As String = ""
    Dim timeschedIDstr As String = ""
    Dim roomIDstr As Object

    Friend Function Filter(subecjtID As Integer, semester As String, year As String, daynameID As Integer, timeschedID As Integer, roomID As Integer) As DataTable



        Dim where As String = ""

        If subecjtID = 0 Then
            subecjtIDstr = "subjectid LIKE '%%'"
        Else
            subecjtIDstr = "subjectid = '" & subecjtID & "'"
        End If
        If daynameID = 0 Then
            daynameIDstr = "day_schedule_id LIKE '%%'"
        Else
            daynameIDstr = "day_schedule_id = '" & daynameID & "'"
        End If
        If timeschedID = 0 Then
            timeschedIDstr = "class_timing_id LIKE '%%'"
        Else
            timeschedIDstr = "class_timing_id = '" & timeschedID & "'"
        End If
        If roomID = 0 Then
            roomIDstr = "room_id LIKE '%%'"
        Else
            roomIDstr = "room_id = '" & roomID & "'"
        End If

        where = "WHERE academice_year LIKE '%" & year & "%' AND semester LIKE '%" & semester & "%'  AND " & subecjtIDstr & "
                  AND " & daynameIDstr & " AND " & timeschedIDstr & " AND " & roomIDstr & "
                  ORDER BY `SUBJECT`"

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT  
      academice_year 'YEAR',
      semester 'SEMESTER',
      year_level 'YEAR LEVEL',
      `name` 'SUBJECT',
      `day` 'DAY SCHEDULE',
      class_time 'TIME SCHEDULE',
      room 'ROOM',
      person_id,
      last_name 'LAST NAME',
      first_name 'FIRST NAME',
      middle_name 'MIDDLE NAME',
      gender,
      CONCAT(course_name,' ',year_level) 'COURSE / YEAR',
      finalgrade,
      student_subject_id

      
  FROM( 
        SELECT          
	students.academice_year,
	students.semester,
	students.year_level,
	subjects.name,
	subject_class_schedule.day,
        subject_class_schedule.class_time,
        subject_class_schedule.room,
	person.person_id,
	person.last_name,
	person.first_name,
	person.middle_name,
	person.gender,
	courses.course_name,	
	students_subjects.finalgrade,
	students_subjects.id 'student_subject_id',
	subjects.id 'subjectid',
	day_schedule_id,
	class_timing_id,
	room_id
	
	FROM
	students_subjects
	INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
	INNER JOIN students ON students.id = students_subjects.student_id
	INNER JOIN person ON person.person_id = students.person_id 
	INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id
	INNER JOIN courses ON students.course_id = courses.id
	)A
                   " & where & "                    
        "))
        Return dt

    End Function

    Friend Function RoomList() As Object

        Dim dt As New DataTable
        Dim str As String = ""
        If SubjectClassSchedule.Rows.Count > 0 Then
            For Each Rooms In SubjectClassSchedule.Rows
                If str = "" Then
                    str = Rooms("room_id").ToString
                Else
                    str = str + "," + Rooms("room_id").ToString
                End If

            Next
            dt = DataSource(String.Format("SELECT
            rooms.SysPK_Item 'ID',
            rooms.`name` 'Name'

            FROM
            rooms
            WHERE rooms.SysPK_Item IN('" & str & "')
            ORDER BY rooms.`name`
			"))
        Else
            dt = DataSource(String.Format("SELECT
            rooms.SysPK_Item 'ID',
            rooms.`name` 'Name'

            FROM
            rooms
            ORDER BY rooms.`name`"))
        End If
        Return dt
    End Function

    Friend Function TimeSchedList() As Object

        Dim dt As New DataTable
        Dim str As String = ""
        If SubjectClassSchedule.Rows.Count > 0 Then
            For Each TimeSched In SubjectClassSchedule.Rows
                If str = "" Then
                    str = TimeSched("class_timing_id").ToString
                Else
                    str = str + "," + TimeSched("class_timing_id").ToString
                End If

            Next
            dt = DataSource(String.Format("SELECT
	        class_timings.id AS ID,
            class_timings.`name` AS `Name`
            FROM
            class_timings
            WHERE
            class_timings.is_deleted = 0 AND class_timings.id IN('" & str & "')
			"))
        Else
            dt = DataSource(String.Format("SELECT
            class_timings.id AS ID,
            class_timings.`name` AS `Name`
            FROM
            class_timings
            WHERE
            class_timings.is_deleted = 0
           "))
        End If
        Return dt
    End Function

    Friend Function DayNameList() As Object
        Dim dt As New DataTable
        Dim str As String = ""
        If SubjectClassSchedule.Rows.Count > 0 Then
            For Each DayName In SubjectClassSchedule.Rows
                If str = "" Then
                    str = DayName("day_schedule_id").ToString
                Else
                    str = str + "," + DayName("day_schedule_id").ToString
                End If

            Next
            dt = DataSource(String.Format("SELECT
			day_schedule.id AS ID,
			day_schedule.`day_name` AS `Name`
			FROM
			day_schedule
			WHERE  day_schedule.id IN('" & str & "')"))
        Else
            dt = DataSource(String.Format("SELECT
            day_schedule_id AS ID,
            day_schedule.`day_name` AS `Name`
            FROM
            day_schedule"))
        End If

        Return dt
    End Function

    Friend Function SubjectList(batchID As Integer) As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
subjects.id 'ID',
CONCAT(subjects.`code`,' - ',subjects.`name`) AS 'name',
CONCAT('Units = ',subjects.credit_hours,', ','Amount Unit = ',subjects.amount,', ','Credit Distribution - ',subjects.creditdistribution) As 'Description',
subjects.credit_hours,
employees.employee_department_id,
employee_departments.`name` AS 'Deparment'

FROM
students_subjects
INNER JOIN subjects ON students_subjects.subject_id = subjects.id
INNER JOIN subject_class_schedule ON subjects.id = subject_class_schedule.subject_id
INNER JOIN students ON students_subjects.student_id = students.id
INNER JOIN employees ON subject_class_schedule.employee_id = employees.id
INNER JOIN employee_departments ON employees.employee_department_id = employee_departments.id

WHERE students_subjects.batch_id = '" & batchID & "'


 GROUP BY id
ORDER BY subjects.`name` asc

"))
        Return dt
    End Function

    Friend Function StudentCategoryList() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
student_categories.id,
student_categories.`name`
FROM
student_categories
WHERE
student_categories.is_deleted = 0 "))
        Return dt
    End Function

    Friend Function getSemester() As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT '1ST SEMESTER' AS 'Semester'
                                        UNION
                                        SELECT '2ND SEMESTER' AS 'Semester'
                                        UNION
                                        SELECT 'SUMMER' AS 'Semester'
    "))
        Return dt
    End Function

    Dim SubjectClassSchedule As New DataTable
    Dim SubjectID As Integer
    Friend Function getMultipleID_SubjectClassSchedule(subecjtID As Integer) As DataTable
        SubjectID = subecjtID
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students.semester,
students.academice_year,
subject_class_schedule.day_schedule_id,
subject_class_schedule.class_timing_id,
subject_class_schedule.room_id,
subject_class_schedule.subject_id

FROM
subject_class_schedule
INNER JOIN students_subjects ON subject_class_schedule.subject_id = students_subjects.subject_id
INNER JOIN students ON students_subjects.student_id = students.id
WHERE
subject_class_schedule.subject_id = '" & subecjtID & "'

GROUP BY semester,academice_year,day_schedule_id,class_timing_id,room_id
"))

        If dt.Rows.Count > 0 Then
            SubjectClassSchedule = dt
        End If

        Return dt


    End Function

    Friend Function RetreivedNewList(subecjtID As Integer, semester As String, year As String, daynameID As Integer, timeschedID As Integer, roomID As Integer) As DataTable
        Dim dt As New DataTable
        '   Dim sql As String = "CALL get_Newgrade_sheet_ger2x('" & subecjtID & "','" & semester & "','" & year & "','" & daynameID & "','" & timeschedID & "','" & roomID & "')"
        '  dt = DataSource(String.Format(sql))     'dt = DataSource(String.Format(sql))

        Dim sql As String = "
SELECT
stdID,
last_name,
first_name,
middle_name,
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
		 ELSE '' END AS 'REMARKS'
	     

   FROM(
				Select 
				stdID,
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
				finalgrade
	
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
				students.std_number 'stdID' 

				FROM
				students_subjects
				INNER JOIN subject_class_schedule ON students_subjects.subject_id = subject_class_schedule.subject_id
				INNER JOIN students ON students.id = students_subjects.student_id
				INNER JOIN person ON person.person_id = students.person_id 
				INNER JOIN subjects ON subject_class_schedule.subject_id = subjects.id
				INNER JOIN courses ON students.course_id = courses.id

			WHERE person.status_type_id = 1 AND person.end_time IS NULL and
		      subjects.id = '" & subecjtID & "' and students.semester = '" & semester & "' and
		      students.academice_year = '" & year & "' and day_schedule_id = '" & daynameID & "' and
		      class_timing_id = '" & timeschedID & "' and room_id = '" & roomID & "'
					
				)A  
				ORDER BY last_name
		)B
		"
        dt = DataSource(String.Format(sql))
        Return dt
    End Function

    Friend Function DepartmentList() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                  `id` AS 'ID',
                  `name` AS 'Name'
                FROM `employee_departments`
                WHERE `status` = 1"))
        Return dt
    End Function

    Friend Function Grades(student_subject_id As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("
                SELECT
                `name`,
                grades,
                students_subject_id,
                id
                FROM(
			                SELECT
			                student_grading_period.`name`,
			                student_grade.grades,
			                student_grade.students_subject_id,
			                id
			                FROM
			                student_grade
			                INNER JOIN student_grading_period ON student_grade.students_grading_id = student_grading_period.id
			                WHERE
			                student_grade.students_subject_id = '" & student_subject_id & "'

                UNION ALL

			                SELECT
					                 'REMARKS' AS 'name',
						                (SELECT
								                grading_system.description
								                FROM
								                grading_system
								                WHERE
								                grading_system.ratings = SUBSTRING(finalgrade,1,3)
								                ) 'grades',
								                id 'students_subject_id',
								                100 AS 'id'
					                FROM(
					                SELECT
					                students_subjects.finalgrade,
					                students_subjects.id
					                FROM
					                students_subjects
					                WHERE
					                students_subjects.id = '" & student_subject_id & "'
					                )A
                     )B
		                 ORDER BY id
                     "))
        Return dt
    End Function

    Friend Function getBatchList() As Object
        Dim sql As String = ""
        sql = "SELECT
batches.id AS ID,
batches.`name` AS `Name`,
batches.year_level,
batches.school_year,
batches.semester,
batches.course_id
FROM
batches
WHERE
batches.is_deleted = 0 ORDER BY NAME, year_level, school_year
"
        Return DataSource(sql)
    End Function

    Friend Function getColumn(studentcategoryID As Integer) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
`name`
FROM(
SELECT
student_grading_period.`name`,
student_grading_period.id
FROM
student_grading_period
WHERE
student_grading_period.student_category_id = '" & studentcategoryID & "'

UNION ALL

SELECT
'REMARKS' as 'name',
100 as 'id'
)A
ORDER BY id"))
        Return dt
    End Function

    Friend Function getGradeSheetHeader() As DataTable
        Dim sql As String = ""
        sql = "SELECT 'No.','StudentID','LastName','FirstName','MiddleName','Gender','Course','Year','Midterm','Final','FinalGrade','Remarks' limit 0"
        Return DataSource(sql)
    End Function
End Class
