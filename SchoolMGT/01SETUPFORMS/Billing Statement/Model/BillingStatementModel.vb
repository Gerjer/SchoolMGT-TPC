Imports DevComponents.DotNetBar
Imports SchoolMGT

Public Class BillingStatementModel
    Public id As Integer
    Dim LastPk As Integer

    Friend Sub Insert(billingStatement As BillingStatement, form1 As BillingStatement.Form1, formType As Integer, operation As String)

        StartTransaction()

        Try

            If operation = "ADD" Then

                DataSource(String.Format("INSERT INTO billing_statements
            (
             `billing_formtype_id`,
             `billing_reference_no`,
             `billing_date`,
             `billing_type`,
             `amount`,
             `user_id`)
            VALUES (
                    '" & billingStatement.billing_formtype_id & "',
                    '" & billingStatement.billing_reference_no & "',
                    '" & Format(billingStatement.billing_date.Date, "yyyy-MM-dd") & "',
                     '" & billingStatement.billing_type & "',
                     '" & billingStatement.amount & "',
                     '" & billingStatement.user_id & "',);
              "), True)

                MessageBox.Show("Record Save...", "Successfully!")

            Else

                DataSource(String.Format("UPDATE `billing_statements`
                SET 
                  `billing_formtype_id` = '" & billingStatement.billing_formtype_id & "',
                  `billing_reference_no` =  '" & billingStatement.billing_reference_no & "',
                  `billing_date` = '" & Format(billingStatement.billing_date.Date, "yyyy-MM-dd") & "',
                  `billing_type` = '" & billingStatement.billing_type & "',
                  `amount` = '" & billingStatement.amount & "'
                  where `billing_statements_id` = '" & id & "';
              "), True)

                MessageBox.Show("Record Updated...", "Successfully!")

            End If

            LastPk = DataObject(String.Format("SELECT  MAX(`billing_statements_id`) FROM `billing_form1_details`"))


            If formType = 1 Then
                DataSource(String.Format("DELETE FROM billing_form1_details WHERE billing_statements_id = '" & id & "' "), True)
                DataSource(String.Format("insert into billing_form1_details
            (`billing_statements_id`,
             `billing_formtype_id`,
             `term`,
             `academic_year`,
             `account_code`,
             `amount`
             )
            values ('" & LastPk & "',
                    '" & form1.billing_formtype_id & "',
                    '" & form1.term & "',
                    '" & form1.academic_year & "',
                    '" & form1.accountcode & "',
                    '" & form1.amount1 & "'
                    );"
                ), True)

            End If

            commitQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            rollbackQuery()
        End Try

        EndTransaction()

    End Sub

    Friend Function getSummaryEntranceAdmissionFee(billdate As Date) As Double
        Dim EntranceAdmissionFees As Double = 0
        EntranceAdmissionFees = DataObject(String.Format("SELECT
	SUM(EntranceAdmissionFees)
	FROM(
	SELECT DISTINCT
          	students.id,
						students.class_roll_no AS SuquenceNumber,
						students.std_number AS StudentNumber,
						person.last_name AS LastName,
						person.first_name AS GivenName,
						Substring(person.middle_name,1,1) AS MiddleName,
						Substring(person.gender,1,1) AS Sex,
						DATE_FORMAT(person.date_of_birth,'%m/%d/%Y') AS 'BirthDate',	
						courses.course_name AS DegreeProgram,
						Substring(students.year_level,1,1) AS YearLevel,
						person.email 'Email',
					  person.telephone1 'PhoneNumber',
					 	students_subjects.batch_id,
					  (SELECT
								SUM(finance_fee_particulars.amount)
								FROM
								finance_fee_categories
								INNER JOIN finance_fee_particulars ON finance_fee_particulars.finance_fee_category_id = finance_fee_categories.id
								WHERE
								finance_fee_categories.is_deleted = 0 AND
								finance_fee_categories.`name` IN ('ADMISSION FEE', 'ENTRANCE FEE') AND
								finance_fee_categories.batch_id = 	students_subjects.batch_id
								)	'EntranceAdmissionFees',
					  '' AS 'Remarks'
						FROM
						person
						INNER JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
						INNER JOIN courses ON students.course_id = courses.id
						INNER JOIN students_subjects ON students.id = students_subjects.student_id
						WHERE
						person.status_type_id = 1 AND
						person.end_time IS NULL AND
						person.person_type_id = 2 AND
						students.admission_date <= '" & Format(billdate.Date, "yyyy-MM-dd") & "'
						
						ORDER BY DegreeProgram,YearLevel,LastName
						)A"))

        Return EntranceAdmissionFees
    End Function

    Friend Function generateTotalAmount(tag As Object, yearFrom As String, yearTo As String, jointStr As String) As Decimal
        Dim amount As Double = 0
        Dim AcademicYear As String = yearFrom & "-" & yearTo
        If tag = 2 Then
            amount = DataObject(String.Format("SELECT
                                ifnull(Sum(finance_transactions.amount),0)

                                FROM
                                finance_transactions
                                INNER JOIN students ON students.id = finance_transactions.student_id
                                WHERE
                                students.status_type_id = 1 AND
                                students.end_time IS NULL AND
                                students.semester IN ('" & jointStr & "') AND
                                students.academice_year = '" & AcademicYear & "'
                                "))
        ElseIf tag = 3 Then
            amount = DataObject(String.Format("SELECT
                                IFNULL(sum(finance_fee_particulars.amount),0) AS TotalAmount
                                FROM
                                students
                                INNER JOIN finance_transactions ON students.id = finance_transactions.student_id
                                INNER JOIN finance_fee_categories ON students.batch_id = finance_fee_categories.batch_id
                                INNER JOIN finance_fee_particulars ON finance_fee_categories.id = finance_fee_particulars.finance_fee_category_id
                                WHERE
                                finance_fee_particulars.`name` = 'Enrolment Fee' AND
                                students.status_type_id = 1 AND
                                students.end_time IS NULL AND
                                students.semester IN('" & jointStr & "') AND
                                students.academice_year = '" & AcademicYear & "'
                     
"))



        End If

        Return amount
    End Function

    Friend Function getSummaryTotalTOSF(billdate As Date) As Double
        Dim TotolTSOF As Double = 0
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT 
IFNULL(sum(finance_transactions.amount),0) 'TotalTOSF'
FROM
person
INNER JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
INNER JOIN finance_transactions ON finance_transactions.student_id = students.id
WHERE
person.application_setup_id = '2' AND
person.status_type_id = 1 AND
person.end_time IS NULL AND
person.person_type_id = 2 AND
students.admission_date <= '" & Format(billdate.Date, "yyyy-MM-dd") & "'

"))
        If dt.Rows.Count > 0 Then
            TotolTSOF = dt(0)("TotalTOSF")
        Else
            TotolTSOF = 0
        End If

        Return TotolTSOF
    End Function

    Friend Function getSummaryTotalTOSF(appSetup_Domain As Integer, billdate As String) As DataTable
        Dim sql As String = ""
        sql = "
	  SELECT
			SuquenceNumber,
			StudentNumber,
			LastName,
			GivenName,
			MiddleName,
			DegreeProgram,
			SUBSTRING(YearLevel,1,1) 'YearLevel',
			SUBSTRING(Sex,1,1) 'Sex',
			admission_date,
			SubjectStudentID,
			SubjectBatchID,
      SUM(TotalUnits) 'TotalUnits',
  	  SUM(TotalUnitsNSTP) 'TotalUnitsNSTP',
 		  SUM(TotalUnits_Amount) 'TotalUnits_Amount',
	 	  SUM(TotalUnitsNSTP_Amount) 'TotalUnitsNSTP_Amount'
		 
FROM(
	  SELECT
			SuquenceNumber,
			StudentNumber,
			LastName,
			GivenName,
			MiddleName,
			DegreeProgram,
			SUBSTRING(YearLevel,1,1) 'YearLevel',
			SUBSTRING(Sex,1,1) 'Sex',
			admission_date,
			SubjectStudentID,
			SubjectBatchID,
			(SELECT
						IFNULL(sum(subjects.credit_hours),0)
						FROM
						students_subjects
						INNER JOIN subjects ON students_subjects.subject_id = subjects.id
						WHERE
						subjects.is_deleted = 0 AND
						subjects.batch_id  = SubjectBatchID AND
						students_subjects.student_id = SubjectStudentID
				)AS 'TotalUnits', 
				(SELECT
						IFNULL(sum(subjects.credit_hours),0)
						FROM
						students_subjects
						INNER JOIN subjects ON students_subjects.subject_id = subjects.id
						WHERE
						subjects.is_deleted = 0 AND subjects.creditdistribution = 'NSTP' AND
						subjects.batch_id  = SubjectBatchID AND
						students_subjects.student_id = SubjectStudentID
				) AS 'TotalUnitsNSTP',
				(SELECT
							IFNULL(SUM(subjects.amount),0)
							FROM
							students_subjects
							INNER JOIN subjects ON students_subjects.subject_id = subjects.id
							WHERE
							subjects.is_deleted = 0 AND
							subjects.batch_id  = SubjectBatchID AND
							students_subjects.student_id = SubjectStudentID
					) AS 'TotalUnits_Amount',
					(SELECT
							IFNULL(SUM(subjects.amount),0)
							FROM
							students_subjects
							INNER JOIN subjects ON students_subjects.subject_id = subjects.id
							WHERE
							subjects.is_deleted = 0 AND subjects.creditdistribution = 'NSTP' AND
							subjects.batch_id  = SubjectBatchID AND
							students_subjects.student_id = SubjectStudentID
						) AS 'TotalUnitsNSTP_Amount'
						
				FROM(				
						SELECT DISTINCT
						students.class_roll_no AS SuquenceNumber,
						students.std_number AS StudentNumber,
						person.last_name AS LastName,
						person.first_name AS GivenName,
						person.middle_name AS MiddleName,
						courses.course_name AS DegreeProgram,
						students.year_level AS YearLevel,
						person.gender AS Sex,
						students.admission_date,
						students_subjects.student_id 'SubjectStudentID',
						students_subjects.batch_id 'SubjectBatchID'
						FROM
						person
						INNER JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
						INNER JOIN courses ON students.course_id = courses.id
						INNER JOIN students_subjects ON students.id = students_subjects.student_id
						WHERE
						person.application_setup_id = '" & appSetup_Domain & "'  AND
						person.status_type_id = 1 AND
						person.end_time IS NULL AND
						person.person_type_id = 2 AND
						students.admission_date <= '" & billdate & "'
         )A
                        ORDER BY DegreeProgram,YearLevel,LastName
			)B
GROUP BY SubjectStudentID
ORDER BY DegreeProgram,YearLevel,LastName
			
			"
        Return DataSource(sql)
    End Function

    Friend Function checkOneTimePaymentsExist(particularID As Object, sequence_no As Integer) As Boolean
        Dim id As Integer
        id = DataObject(String.Format("SELECT id FROM finance_transactions_onetime_payments WHERE finance_fee_paticulars_id = '" & particularID & "' AND class_roll_no = '" & sequence_no & "'"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Friend Sub InsertStudentOnePayments(particularID As Object, sequence_no As Integer, feesAmount As Object, subjectBatchID As Integer)
        DataSource(String.Format("INSERT INTO `finance_transactions_onetime_payments`
            (
             `class_roll_no`,
             `finance_fee_paticulars_id`,
             `amount`,
             `batch_id`)
            VALUES (
                    '" & sequence_no & "',
                    '" & particularID & "',
                    '" & feesAmount & "',
                    '" & subjectBatchID & "');"))
    End Sub

    Friend Function getSummaryTotalEntranceAdmissionFees(appSetup_Domain As Integer, semister As String, academicYear As String) As DataTable
        Dim sql As String = ""
        sql = "SELECT DISTINCT
                students.id,
                students.class_roll_no AS SuquenceNumber,
                students.std_number AS StudentNumber,
                person.last_name AS LastName,
                person.first_name AS GivenName,
	                Substring(person.middle_name,1,1) AS MiddleName,
                Substring(person.gender,1,1) AS Sex,
                DATE_FORMAT(person.date_of_birth,'%m/%d/%Y') AS 'BirthDate',	
                courses.course_name AS DegreeProgram,
                Substring(students.year_level,1,1) AS YearLevel,
                person.email 'Email',
		                 person.telephone1 'PhoneNumber',
                students_subjects.batch_id,
                finance_fee_particulars.amount 'EntranceAdmissionFees',
                 '   ' AS 'Remarks'
                FROM
                finance_transactions
                INNER JOIN students ON finance_transactions.student_id = students.id
                INNER JOIN person ON person.person_id = students.person_id
                INNER JOIN courses ON students.course_id = courses.id
                INNER JOIN students_subjects ON students.id = students_subjects.student_id
                INNER JOIN finance_fee_categories ON finance_fee_categories.batch_id = students.batch_id
                INNER JOIN finance_fee_particulars ON finance_fee_particulars.finance_fee_category_id = finance_fee_categories.id
                      AND finance_fee_particulars.`name` = 'Enrolment Fee'
                WHERE
                person.application_setup_id = '" & appSetup_Domain & "' AND
                person.status_type_id = 1 AND
                person.end_time IS NULL AND
                person.person_type_id = 2 AND
                students.semester = '" & semister & "' AND
                students.academice_year = '" & academicYear & "'

                ORDER BY DegreeProgram,YearLevel,LastName  "
        Return DataSource(sql)
    End Function

    Friend Function getFees(batchID As Object, class_roll_no As Object) As DataTable

        Dim sql As String = ""
        sql = "SELECT
		batch_id,
		categoryID,
		Fees,
		FeesAmount,
		ParticularID,
		mode_payments
FROM(
        SELECT
				finance_fee_categories.batch_id,
				finance_fee_categories.id AS categoryID,
				finance_fee_categories.`name` AS Fees,
				Sum(finance_fee_particulars.amount) AS FeesAmount,
				finance_fee_particulars.id AS 'ParticularID',
			  finance_fee_particulars.mode_payments
				FROM
				finance_fee_particulars
				INNER JOIN finance_fee_categories ON finance_fee_particulars.finance_fee_category_id = finance_fee_categories.id
				WHERE
				finance_fee_categories.batch_id = '" & batchID & "'
				GROUP BY
				categoryID
				

UNION ALL

				SELECT
				finance_fee_categories.batch_id,
				0 AS categoryID,
				'TOTALTOSF' AS 'Fees',
				Sum(finance_fee_particulars.amount) AS FeesAmount,
				0 as 'ParticularID',
				0 as 'mode_payments'
				FROM
				finance_fee_particulars
				INNER JOIN finance_fee_categories ON finance_fee_particulars.finance_fee_category_id = finance_fee_categories.id
				WHERE
				finance_fee_categories.batch_id = '" & batchID & "'
			
			   ) A
		 
		 "
        Return DataSource(sql)

#Region "Old"
        '       Dim sql As String = ""
        '       sql = "SELECT
        'batch_id,
        'class_roll_no,
        'id,
        'Fees,
        'FeesAmount
        'FROM
        '     ( SELECT DISTINCT
        '		                students_subjects.batch_id,
        '		                students.class_roll_no,
        '									 finance_fee_categories.id,
        '										Finance_fee_categories.`name` 'Fees',
        '										SUM(finance_fee_particulars.amount) 'FeesAmount'
        '										FROM
        '										person
        '										INNER JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
        '										INNER JOIN courses ON students.course_id = courses.id
        '										INNER JOIN students_subjects ON students.id = students_subjects.student_id
        '										INNER JOIN finance_fee_categories  ON students_subjects.batch_id = finance_fee_categories.batch_id
        '										INNER JOIN finance_fee_particulars on finance_fee_categories.id = finance_fee_particulars.finance_fee_category_id

        '										WHERE
        '										person.status_type_id = 1 AND
        '										person.end_time IS NULL AND
        '										person.person_type_id = 2 

        '										GROUP BY finance_fee_particulars.finance_fee_category_id

        '		UNION ALL

        '				 SELECT DISTINCT
        '				          students_subjects.batch_id,
        '									students.class_roll_no,
        '									'0' AS 'id',
        '									'TOTALTOSF' AS 'Fees',
        '									SUM(finance_fee_particulars.amount) 'FeesAmount'
        '									FROM
        '									person
        '									INNER JOIN students ON person.person_id = students.person_id AND students.status_type_id = 1 AND students.end_time is NULL
        '									INNER JOIN courses ON students.course_id = courses.id
        '									INNER JOIN students_subjects ON students.id = students_subjects.student_id
        '									INNER JOIN finance_fee_categories  ON students_subjects.batch_id = finance_fee_categories.batch_id
        '									INNER JOIN finance_fee_particulars on finance_fee_categories.id = finance_fee_particulars.finance_fee_category_id

        '									WHERE
        '									person.status_type_id = 1 AND
        '									person.end_time IS NULL AND
        '									person.person_type_id = 2 

        '		)A 
        '		WHERE 	batch_id = '" & batchID & "' AND class_roll_no = '" & class_roll_no & "'"
        '       Return DataSource(sql)
#End Region

    End Function

    Friend Function getOneTimePayment(class_roll_no As Object, batch_id As Object) As Boolean
        Dim pain As Double = DataObject(String.Format("SELECT amount FROM finance_transactions_onetime_payments WHERE class_roll_no = '" & class_roll_no & "' AND batch_id = '" & batch_id & "'"))
        If pain > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Friend Function getFom1Details(id As Integer) As DataTable

        Dim str As String = ""
        str = "SELECT
term,
academic_year,
account_code,
amount
FROM
billing_form1_details
WHERE
billing_statements_id = '" & id & "'
"
        Return DataSource(str)
    End Function


    Friend Sub _Insert(billingStatement As BillingStatement, form1 As BillingStatement.Form1, formType As Integer, operation As String)

        Dim LastPK As Integer = 0
        LastPK = DataObject(String.Format("SELECT IFNULL(Max(billing_statements_id),0) FROM billing_statements WHERE status_type_id = 1 AND end_time IS NULL"))
        If LastPK = 0 Then
            LastPK = 1
        Else
            LastPK += 1
        End If

        If formType = 2 Then
            '        billingStatement.amount = 
        End If


        Dim sql As String = ""

        StartTransaction()
        Try

            With billingStatement

                sql = "INSERT INTO billing_statements SET"
                sql &= String.Format(" billing_formtype_id = '{0}',", .billing_formtype_id)
                sql &= String.Format(" billing_reference_no = '{0}',", .billing_reference_no)
                sql &= String.Format(" billing_date = '{0}',", Format(.billing_date.Date, "yyyy-MM-dd"))
                sql &= String.Format(" billing_type = '{0}',", .billing_type)
                sql &= String.Format(" amount = '{0}',", .amount)
                sql &= String.Format(" semister = '{0}',", .Semister)
                sql &= String.Format(" academic_year = '{0}',", .AcademicYear)
                sql &= String.Format(" user_id = '{0}'", .user_id)
                DataSource(sql, True)

            End With

            If formType = 1 Then

                With form1

                    sql = "INSERT INTO billing_form1_details SET"
                    sql &= String.Format(" billing_statements_id = '{0}',", LastPK)
                    sql &= String.Format(" billing_formtype_id = '{0}',", .billing_formtype_id)
                    sql &= String.Format(" term = '{0}',", .term)
                    sql &= String.Format(" academic_year = '{0}',", .academic_year)
                    sql &= String.Format(" account_code = '{0}',", .accountcode)
                    sql &= String.Format(" amount = '{0}'", .amount1)
                    DataSource(sql, True)

                End With

            End If


            commitQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            rollbackQuery()
        End Try
        EndTransaction()

        MessageBoxEx.Show("Billing Statements has been Saved Sucessfully..", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Friend Function getList() As DataTable

        Dim str As String = "SELECT
billing_statements_id AS id,
CASE WHEN billing_formtype_id = 1 THEN 'FORM 1'
     WHEN billing_formtype_id = 2 THEN 'FORM 2'
		 ELSE 'FORM 3' END AS 'FORM TYPE',
billing_reference_no AS `REFERENCE NUMBER`,
billing_date AS `BILLING DATE`,
billing_type AS `BILLING TYPE`,
amount AS AMOUNT,
semister 'SEMISTER',
academic_year 'ACADEMIC YEAR',
user_id
FROM
billing_statements
WHERE
status_type_id = 1 AND
end_time IS NULL

            "
        Return DataSource(str)

    End Function
End Class
