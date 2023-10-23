Public Class StudentAdmissionListModel
    Friend Function getSummaryOfEnrollment(YearFrom As String, YearTo As String, Semester As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
course_name 'PROGRAMS',
CASE WHEN year_level LIKE '%1st%' THEN 'FIRST YEAR'
     WHEN year_level LIKE '%2nd%' THEN 'SECOND YEAR'
     WHEN year_level LIKE '%3rd%' THEN 'THIRD YEAR'
     WHEN year_level LIKE '%4th%' THEN 'FOURTH YEAR'
ELSE 'FIFTH YEAR' END AS 'YEAR LEVEL',
SUM(MALE) 'MALE',
SUM(FEMALE)'FEMALE',
SUM(MALE) + SUM(FEMALE) 'TOTAL',
semester 'SEMESTER',
academice_year

FROM
(
				SELECT
				courses.course_name, 
				students.year_level,
				count(CASE WHEN person.gender = 'MALE' then 1
				ELSE 0 end) AS 'MALE',
				0 as 'FEMALE',
				students.semester,
		   	   academice_year

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

				where gender = 'MALE'

				GROUP BY semester,gender,year_level,course_name
				-- ORDER BY courses.id,courses.course_name,students.year_level


				UNION 

				SELECT
				courses.course_name,
				students.year_level,
				0 as 'MALE',
				count(CASE WHEN person.gender = 'FEMALE' then 1
				ELSE 0 end) AS 'FEMALE',
				students.semester,
			    academice_year

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

				where gender = 'FEMALE'

				GROUP BY semester,gender,year_level,course_name
				-- ORDER BY courses.id,courses.course_name,students.year_level

)A

 WHERE SEMESTER = '" & Semester & "'  AND academice_year BETWEEN '" & YearFrom & "' AND '" & YearTo & "'
 GROUP BY year_level,course_name
ORDER BY course_name,year_level

"))
        Return dt
    End Function

    Friend Function getComparativeData_Previous_Current_Year(YearFrom As String, YearTo As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	course_name 'PROGRAMS',
	CASE WHEN year_level LIKE '%1st%' THEN 'FIRST YEAR'
	 WHEN year_level LIKE '%2nd%' THEN 'SECOND YEAR'
	 WHEN year_level LIKE '%3rd%' THEN 'THIRD YEAR'
	 WHEN year_level LIKE '%4th%' THEN 'FOURTH YEAR'
	ELSE 'FIFTH YEAR' END AS 'YEAR LEVEL',
	sum(PreviousYear) '" & YearFrom & "',
	SUM(CurrentYear) '" & YearTo & "',
	academice_year
	
FROM(      
				SELECT
				courses.course_name, 
				students.year_level,
				CASE WHEN academice_year = '" & YearFrom & "' then 1
				ELSE 0 end  AS 'PreviousYear',
					0 AS 'CurrentYear',
	   	   academice_year

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

			   where academice_year BETWEEN '" & YearFrom & "' AND '" & YearTo & "'

				
			UNION ALL
			
				SELECT
				courses.course_name, 
				students.year_level,
				0 AS 'PreviousYear',
				CASE WHEN academice_year = '" & YearTo & "' then 1
				ELSE 0 end AS 'CurrentYear',
	   	   academice_year

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

			   where academice_year BETWEEN '" & YearFrom & "' AND '" & YearTo & "'

				)A
		 GROUP BY year_level,course_name"))
        Return dt
    End Function

    Friend Function getDefaultColumn(fromYear As String, toYear As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("

          SELECT
				courses.course_name,
                CASE WHEN students.year_level LIKE '%1st%' THEN 'FIRST YEAR'
	             WHEN students.year_level LIKE '%2nd%' THEN 'SECOND YEAR'
	             WHEN students.year_level LIKE '%3rd%' THEN 'THIRD YEAR'
	             WHEN students.year_level LIKE '%4th%' THEN 'FOURTH YEAR'
	            ELSE 'FIFTH YEAR' END AS 'YEAR LEVEL',
				students.year_level
	           

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id
				
				  where academice_year BETWEEN '" & fromYear & "' AND '" & toYear & "'
				 GROUP BY year_level,course_name
				 
				 ORDER BY course_name,academice_year
				 "))
        Return dt
    End Function

    Friend Function getTotalEnrolled(course As Object, year_level As Object, year As String, Optional StatureIndex As String = "") As Integer

        Dim dummyYear As String = ""
        Dim dummyYearFrom As Integer = CInt(year)
        Dim dummyYearTo As Integer = CInt(year) + 1
        dummyYear = "academice_year BETWEEN  '" & dummyYearFrom & "' AND '" & dummyYearTo & "' "

        Dim Total_Enrolled As Integer = 0
        If StatureIndex = "" Then
            Total_Enrolled = DataObject(String.Format("	SELECT
	   	   count(academice_year) AS '" & year & "'

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

			   WHERE students.year_level = '" & year_level & "' AND course_name = '" & course & "' AND  " & dummyYear & " "))

        Else
            Total_Enrolled = DataObject(String.Format(" SELECT
                 count(academice_year) AS '" & year & "'
                  FROM(
			                 SELECT
	   	                        academice_year,
				                CASE WHEN students.stature = 'Transfered from Public School' THEN 0
				                     WHEN students.stature = 'Transferred from Private School' THEN 1
			  		                 WHEN students.stature = 'Senior High School Graduate' THEN 2
						                 ELSE 3 END AS 'StatureIndex'
			
				                FROM
				                students
				                INNER JOIN courses ON students.course_id = courses.id
				                INNER JOIN person ON person.person_id = students.person_id
				                INNER JOIN batches ON students.batch_id = batches.id

	    		                WHERE students.year_level = '" & year_level & "' AND course_name = '" & course & "' AND  " & dummyYear & "
		                 )A
	                WHERE StatureIndex = '" & StatureIndex & "'"))

        End If


        Return Total_Enrolled
    End Function

    Friend Function checkRecordOfTheYear(year As String) As Integer

        Dim dummyYearFrom As Integer = CInt(year)
        Dim dummyYearTo As Integer = CInt(year) + 1

        year = "WHERE  academice_year BETWEEN '" & dummyYearFrom & "' AND '" & dummyYearTo & "' "
        Dim record As Integer = 0
        record = DataObject(String.Format("	 SELECT
	   	   count(academice_year)

				FROM
				students
				INNER JOIN courses ON students.course_id = courses.id
				INNER JOIN person ON person.person_id = students.person_id
				INNER JOIN batches ON students.batch_id = batches.id

                 " & year & " 
			   -- WHERE  academice_year BETWEEN '" & year & "'"))

        'Else

        '    record = DataObject(String.Format("SELECT
        '            count(academice_year)
        '            -- StatureIndex
        '            FROM(	 
        '             SELECT
        '                 academice_year,
        '                CASE WHEN students.stature = 'Transfered from Public School' THEN 0
        '                    WHEN students.stature = 'Transferred from Private School' THEN 1
        '                   WHEN students.stature = 'Senior High School Graduate' THEN 2
        '                  ELSE 3 END AS 'StatureIndex'
        '               FROM
        '               students
        '               INNER JOIN courses ON students.course_id = courses.id
        '               INNER JOIN person ON person.person_id = students.person_id
        '               INNER JOIN batches ON students.batch_id = batches.id

        '               WHERE academice_year = '" & year & "'
        '                )A
        '              WHERE StatureIndex = '" & StatureIndex & "'"))

        'End If

        Return record
    End Function

    Friend Function getListOfTransferred(fromYear As String, toYear As String, stature As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format(""))
        Return dt
    End Function
End Class
