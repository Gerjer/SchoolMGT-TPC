Public Class ChedEFormBCListModel
    Friend Function getAcademicYear() As Object
        Dim sql As String = ""
        sql = "SELECT id,academice_year 'name' FROM students GROUP BY academice_year"
        Return DataSource(sql)
    End Function

    Friend Function getChedList(AcademincYear As String, Semester As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT 
 description,
 FreshmenMale,
 FreshmenFemale,
 1stYearOldMale,
 1stYearOldFemale,
 2ndYearOldMale,
 2ndYearOldFemale,
 3rdYearOldMale,
 3rdYearOldFemale,
 4thYearOldMale,
 4thYearOldFemale,
 5thYearOldMale,
 5thYearOldFemale,
 6thYearOldMale,
 6thYearOldFemale,
 7thYearOldMale,
 7thYearOldFemale,
(FreshmenMale + 1stYearOldMale + 2ndYearOldMale +3rdYearOldMale + 4thYearOldMale + 5thYearOldMale + 6thYearOldMale + 7thYearOldMale)'SubTotalM',
(FreshmenFeMale + 1stYearOldFemale + 2ndYearOldFemale +3rdYearOldFemale + 4thYearOldFemale + 5thYearOldFemale + 6thYearOldFemale + 7thYearOldFemale)'SubTotalF',
((FreshmenMale + 1stYearOldMale + 2ndYearOldMale +3rdYearOldMale + 4thYearOldMale + 5thYearOldMale + 6thYearOldMale + 7thYearOldMale) + (FreshmenFeMale + 1stYearOldFemale + 2ndYearOldFemale +3rdYearOldFemale + 4thYearOldFemale + 5thYearOldFemale + 6thYearOldFemale + 7thYearOldFemale)) AS 'sTotal',
((FreshmenMale + 1stYearOldMale + 2ndYearOldMale +3rdYearOldMale + 4thYearOldMale + 5thYearOldMale + 6thYearOldMale + 7thYearOldMale) + (FreshmenFeMale + 1stYearOldFemale + 2ndYearOldFemale +3rdYearOldFemale + 4thYearOldFemale + 5thYearOldFemale + 6thYearOldFemale + 7thYearOldFemale)) AS 'Total'
FROM(	 
		 SELECT 
		 description,
			sum(FreshmenMale)'FreshmenMale',
			sum(FreshmenFemale) 'FreshmenFemale',
			
			sum(1stYearOldMale)'1stYearOldMale',
			sum(1stYearOldFemale) '1stYearOldFemale',
			
			sum(2ndYearOldMale)'2ndYearOldMale',
			sum(2ndYearOldFemale) '2ndYearOldFemale',
			
			sum(3rdYearOldMale)'3rdYearOldMale',
			sum(3rdYearOldFemale) '3rdYearOldFemale',
			
						sum(4thYearOldMale)'4thYearOldMale',
			sum(4thYearOldFemale) '4thYearOldFemale',
			
			sum(5thYearOldMale)'5thYearOldMale',
			sum(5thYearOldFemale)'5thYearOldFemale',
			
			sum(6thYearOldMale)'6thYearOldMale',
			sum(6thYearOldFemale) '6thYearOldFemale',
			
			sum(7thYearOldMale)'7thYearOldMale',
			sum(7thYearOldFemale) '7thYearOldFemale'
			
	   FROM(
        	SELECT
					id,
					`code`, 
					description,
					-- `order`,
					CASE WHEN `order` = 1 AND gender = 'MALE' AND enrollmentAS = 'NEW' THEN 1
							 ELSE 0 END AS 'FreshmenMale',
					CASE WHEN `order` = 1 AND gender = 'FEMALE' AND enrollmentAS = 'NEW' THEN 1
							 ELSE 0 END AS 'FreshmenFemale',
					CASE WHEN `order` = 1 AND gender = 'MALE' AND enrollmentAS <> 'NEW' THEN 1
							 ELSE 0 END AS '1stYearOldMale',
					CASE WHEN `order` = 1 AND gender = 'FEMALE' AND enrollmentAS <> 'NEW' THEN 1
							 ELSE 0 END AS '1stYearOldFemale', 		 
					CASE WHEN `order` = 2 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '2ndYearOldMale',
					CASE WHEN `order` = 2 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '2ndYearOldFemale', 		 
					CASE WHEN `order` = 3 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '3rdYearOldMale',
					CASE WHEN `order` = 3 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '3rdYearOldFemale', 		 
					CASE WHEN `order` = 4 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '4thYearOldMale',
					CASE WHEN `order` = 4 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '4thYearOldFemale', 		 
					CASE WHEN `order` = 5 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '5thYearOldMale',
					CASE WHEN `order` = 5 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '5thYearOldFemale',
					CASE WHEN `order` = 6 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '6thYearOldMale',
					CASE WHEN `order` = 6 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '6thYearOldFemale', 		 
					CASE WHEN `order` = 7 AND gender = 'MALE' THEN 1
							 ELSE 0 END AS '7thYearOldMale',
					CASE WHEN `order` = 7 AND gender = 'FEMALE' THEN 1
							 ELSE 0 END AS '7thYearOldFemale', 			 
					-- gender,
					-- year_level,
					-- enrollmentAS,
					academice_year,
					semester

					FROM(
					SELECT
							id,
							`code`,
							description,
							gender,
							year_level,
							academice_year,
							semester,
							enrollmentAS,
							`order`

					FROM(
								SELECT
								courses.id,
								courses.`code`,
								courses.description,
								person.gender,
								students.year_level,
										CASE WHEN students.year_level = '1st year' THEN 1
												 WHEN students.year_level = '2nd year' THEN 2
												 WHEN students.year_level = '3rd year' then 3
												 WHEN students.year_level = '4th year' then 4
												 WHEN students.year_level = '5th year' then 5
												 WHEN students.year_level = '6th year' then 6
												 ELSE 7 END as 'order',
								students.semester,
								students.enrollmentAS,
								students.academice_year
								FROM
								students
								INNER JOIN courses ON students.course_id = courses.id
								INNER JOIN person ON students.person_id = person.person_id

							)A
							ORDER BY `order`,description,gender desc
						)B	
						WHERE academice_year = '" & AcademincYear & "' AND semester = '" & Semester & "' -- AND `code` = 'BAEL'
				 )C
				 GROUP BY `code` 
			 )D"))
        Return dt
    End Function
End Class
