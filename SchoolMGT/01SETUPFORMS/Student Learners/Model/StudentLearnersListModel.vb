Public Class StudentLearnersListModel

    Friend Function getStudentRecord() As Object
        Dim str As String = ""
        str = "SELECT
                ID,
                `Name`
                FROM(
	                SELECT
	                person.person_id AS ID,
	                person.display_name AS `Name`
	                FROM
	                person
	                WHERE
	                person.person_type_id = 2 AND
	                person.status_type_id = 1 AND
	                person.end_time IS NULL

	                UNION all

	                SELECT 0 AS 'ID','---- ALL ----' AS 'Name'
		
	                )A  ORDER BY ID"
        Return DataSource(str)
    End Function

    Public _EnterName As String = ""
    Friend Function getStudentDetails(selectedValue As Object) As DataTable

        Dim where As String = ""
        If selectedValue = 0 Then
            where = "WHERE ID LIKE '%%'"
        Else
            where = "WHERE ID = '" & selectedValue & "'"
        End If

        Dim str As String = ""
        str = "SELECT
	ID,
`Name`,
-- CONCAT(`Name`,'                    ',StudentIDNumber,'',ClassRollNo,'',EnrolledStatus,'',Stature) 'Name',
	ClassRoll_Number
      FROM(
			SELECT
			person.person_id AS ID,
			person.display_name AS `Name`,
            students.class_roll_no 'ClassRoll_Number',
			CONCAT('     CLASS ROLL NUMBER',' : ',students.class_roll_no) 'ClassRollNo',
			CONCAT('     ENROLLED STATUS',' : ',students.enrollmentAS) 'EnrolledStatus',
			CONCAT('     STATURE',' : ',students.stature) 'Stature',
			CONCAT('     STUDENT ID-NUMBER',' : ',students.std_number) 'StudentIDNumber'
			FROM
			person
			INNER JOIN students ON person.person_id = students.person_id
			WHERE
			person.person_type_id = 2 AND
			person.status_type_id = 1 AND
			person.end_time IS NULL 

			GROUP BY person.person_id
			ORDER BY `Name`
			)A
			
			" & where & "  "
        Return DataSource(str)
    End Function

    Friend Function getStudentBatchDetails(BatchID As Object) As DataTable
        Dim str As String = ""
        str = "SELECT
students.id,
students.course_id,
courses.course_name 'CourseName',
courses.`code`,
courses.description,
students.batch_id,
batches.`name` 'BatchName',
students.status_description,
students.year_level,
students.semester,
students.academice_year

FROM
students
INNER JOIN batches ON students.batch_id = batches.id
INNER JOIN courses ON students.course_id = courses.id
WHERE
students.status_type_id = 1 AND
students.batch_id = '" & BatchID & "'
ORDER BY
batches.year_level ASC,
batches.semester ASC
"
        Return DataSource(str)
    End Function

    Friend Function getCOR_Copies() As DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM copies_of_cor "
        Return DataSource(sql)
    End Function

    Friend Function getStudentID(admissionNo As String) As Integer
        Dim id As Integer
        id = DataObject(String.Format("SELECT id FROM students WHERE status_type_id = 1 AND admission_no = '" & admissionNo & "'"))
        Return id
    End Function

    Friend Function getStudentCourse(ClassRollNo As Object) As DataTable
        Dim str As String = ""
        str = "SELECT
students.id,
students.course_id,
courses.course_name 'CourseName',
courses.`code`,
courses.description,
students.batch_id,
students.admission_no,
batches.`name` 'BatchName',
students.status_description,
students.year_level,
students.semester,
students.academice_year

FROM
students
INNER JOIN batches ON students.batch_id = batches.id
INNER JOIN courses ON students.course_id = courses.id
WHERE
students.status_type_id = 1 AND
students.class_roll_no = '" & ClassRollNo & "'
GROUP BY students.course_id
ORDER BY
batches.year_level ASC,
batches.semester ASC
"
        Return DataSource(str)
    End Function

    Friend Function getCurriculunmStatus(studentID As Integer) As String
        Dim sql As String = ""
        sql = "SELECT
CASE
	WHEN students.is_regular = 0 THEN 
		'Regular'
	ELSE
     'Irregular'
END AS 'CurriculunmStatus'

FROM
students
WHERE
students.status_type_id = 1 AND
students.end_time IS NULL AND
students.id = '" & studentID & "'
"
        Return DataObject(sql)
    End Function

    Friend Function getStudents_COR_info(admissionNo As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
  students.std_number as 'IdNumber',
	CONCAT(person.display_name,' - ',courses.course_name ,'(', batches.year_level, ')') AS 'NameCourse',
	CONCAT(batches.semester,' AY ',school_year,'// ',DATE_FORMAT(admission_date,'%m/%d/%Y')) AS 'sem_year_date',
	SUM(subjects.credit_hours) as 'TotalUnits',
	SUM(subjects.amount) as 'TutionFees'

FROM
	students_subjects
	INNER JOIN students ON ( students_subjects.student_id = students.id )
	INNER JOIN person ON (students.person_id = person.person_id)
	INNER JOIN courses ON (students.course_id = courses.id)
	INNER JOIN batches ON (students.batch_id = batches.id)
	INNER JOIN subjects ON ( students_subjects.subject_id = subjects.id )
	LEFT JOIN subject_class_schedule ON ( students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item ) 
WHERE
		students.admission_no = '" & admissionNo & "'"))
        Return dt


    End Function

    Friend Function getStudent_Subject_info(admissionNo As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	subjects.CODE 'subject_code',
	subjects.NAME 'descriptive_title',
	subjects.credit_hours 'units',
	subject_class_schedule.class_time 'time',
	subject_class_schedule.day 'day',
	subject_class_schedule.room 'room',
	subject_class_schedule.employee_name 'instructor'

    FROM
	    students_subjects
	    INNER JOIN students ON ( students_subjects.student_id = students.id )
	    INNER JOIN subjects ON ( students_subjects.subject_id = subjects.id )
	    LEFT JOIN subject_class_schedule ON ( students_subjects.subject_class_schedule_id = subject_class_schedule.SysPK_Item ) 
    WHERE
	    admission_no = '" & admissionNo & "'"))
        Return dt
    End Function

    Friend Function getTotalAmount(studentID As Integer) As String
        Dim Amount As String = ""
        Amount = DataObject(String.Format("SELECT
students_assessment.total 'Amount'

FROM
students_assessment

WHERE
students_assessment.student_id = '" & studentID & "' AND
students_assessment.columnName = 'D' AND 
students_assessment.stat = 'T+'"))
        Return Amount
    End Function

    Friend Function getStudent_Assessment_info(studentID As Integer) As DataTable
        Dim dt As New DataTable
#Region "old"
        '        dt = DataSource(String.Format("SELECT
        'Charges,
        'Amount
        'FROM(
        'SELECT
        'students_assessment.particulars 'Charges',
        'students_assessment.amount 'Amount'

        'FROM
        'students_assessment
        'INNER JOIN finance_fee_particulars ON students_assessment.particulars = finance_fee_particulars.`name`
        'WHERE
        'students_assessment.student_id = '" & studentID & "' AND
        'students_assessment.columnName = 'D'

        'UNION ALL

        'SELECT
        'students_assessment.particulars 'Charges',
        'students_assessment.amount 'Amount'

        'FROM
        'students_assessment
        '-- INNER JOIN finance_fee_particulars ON students_assessment.particulars = finance_fee_particulars.`name`
        'WHERE
        'students_assessment.student_id = '" & studentID & "' AND
        'students_assessment.columnName = 'D' AND students_assessment.particulars LIKE '%TUITION%'

        '/*
        'UNION ALL


        'SELECT
        'students_assessment.amount 'Charges',
        'students_assessment.total 'Amount'

        'FROM
        'students_assessment

        'WHERE
        'students_assessment.student_id = '" & studentID & "'/* AND
        'students_assessment.columnName = 'D' AND students_assessment.stat = '++' OR 
        'students_assessment.stat = '-+'  OR students_assessment.stat = '--'*/

        ')A
        'GROUP BY Charges


        '"))
#End Region
        dt = DataSource(String.Format("SELECT
students_assessment.masterfee 'Charges',
students_assessment.total 'Amount'
FROM
students_assessment
WHERE
students_assessment.columnName = 'H' AND
students_assessment.student_id = '" & studentID & "'
"))


        Return dt
    End Function

    Friend Function getStudentSubject(id As Object) As DataTable
        Dim str As String = ""
        str = "SELECT
subjects.`code` AS `SUBJECT CODE`,
subjects.`name` AS `SUBJECT NAME`,
subjects.credit_hours AS UNITS,
subject_class_schedule.`code` AS `CLASS CODE`,
subject_class_schedule.`name` AS `SCHEDULE`,
subject_class_schedule.room AS ROOM,
students_subjects.batch_id,
students_subjects.student_id
FROM
subject_class_schedule
INNER JOIN students_subjects ON subject_class_schedule.SysPK_Item = students_subjects.subject_class_schedule_id
INNER JOIN subjects ON students_subjects.subject_id = subjects.id

 WHERE students_subjects.student_id = '" & id & "'
 "
        Return DataSource(str)
    End Function

    Friend Function getBatchGroup(ClassRollNo As Object) As DataTable
        Dim str As String = ""
        str = "SELECT
students.id,
students.course_id,
courses.course_name 'CourseName',
courses.`code`,
courses.description,
students.batch_id,
students.admission_no,
batches.`name` 'BatchName',
students.status_description,
students.year_level,
students.semester,
students.academice_year

FROM
students
INNER JOIN batches ON students.batch_id = batches.id
INNER JOIN courses ON students.course_id = courses.id
WHERE
students.status_type_id = 1 AND
students.class_roll_no = '" & ClassRollNo & "'
-- GROUP BY students.course_id
ORDER BY
batches.year_level ASC,
batches.semester ASC
"
        Return DataSource(str)
    End Function

    Friend Function getAddFees(mode_payment As String, enroll_status As String, semester As String) As Boolean
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                    fees_protocol.id,
                    fees_protocol.enroll_status,
                    fees_protocol.mode_payment,
                    fees_protocol.semester,
                    fees_protocol.`trigger`
                    FROM
                    fees_protocol
                    WHERE
                    fees_protocol.mode_payment = '" & mode_payment & "' AND
                    fees_protocol.enroll_status = '" & enroll_status & "' AND
                    fees_protocol.semester = '" & semester & "'
                    "))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
