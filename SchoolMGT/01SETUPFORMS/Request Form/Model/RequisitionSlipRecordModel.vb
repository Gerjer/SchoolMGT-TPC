Imports SchoolMGT

Public Class RequisitionSlipRecordModel
    Public _id As Integer



    Friend Function getStudentRecord() As Object
        Dim str As String = ""
        str = "SELECT
students.class_roll_no AS ID,
person.display_name AS `Name`,
person.telephone1 AS ContactNumber,
courses.course_name AS Course,
CASE WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL AND zipcode IS NOT NULL AND province IS NOT NULL  THEN CONCAT(barangay,', ',citymunicipality,',',zipcode,', ',province)
WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL AND zipcode IS NOT NULL THEN CONCAT(barangay,', ',citymunicipality,',',zipcode)
WHEN barangay IS NOT NULL AND citymunicipality  IS NOT NULL THEN CONCAT(barangay,', ',citymunicipality)
ELSE barangay END AS 'ADDRESS',
person.person_id ,
students.id 'stdID'

FROM
students
INNER JOIN person ON students.person_id = person.person_id 
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN person_address ON person.person_id = person_address.person_id AND person_address.address_type_id = 1 
WHERE
students.status_type_id = 1 AND
students.end_time IS NULL AND
person.status_type_id = 1 AND
person_type_id = 2 AND
person.end_time IS NULL

ORDER BY display_name

"
        Return DataSource(str)
    End Function

    Friend Function getFormType() As Object
        Dim sql As String = ""
        sql = "SELECT
'False' as 'SELECT',
requisition_type_form.id,
requisition_type_form.`name` 'FORM',
requisition_type_form.description 'DESCRIPTION',
0 AS 'NO. OF COPIES',
amount 'RATE',
finance_transaction_categories_id
FROM
requisition_type_form
WHERE
requisition_type_form.status_type_id = 1"
        Return DataSource(sql)
    End Function

    Friend Function getRecordList() As DataTable
        Dim dt As New DataTable
        Dim str As String = ""
        str = "Select 
                '0' AS 'Include',
                r.id,
                r.class_roll_number,
		                (SELECT
				                person.display_name
		                FROM
		                person
		                INNER Join students ON person.person_id = students.person_id
						                WHERE
		                person.status_type_id = 1 And
		                person.end_time Is NULL And
		                students.class_roll_no = class_roll_number LIMIT 1
				                ) 'REQUESTOR',
                rtr.type_of_request AS `REQUEST.FORM`,
                rtr.no_of_copies As `NO.COPIES`,
                rpr.purpose_request AS PURPOSE,				
                DATE_FORMAT(r.date_filed,'%m-%d-%Y') AS `DATE.REQUESTED`,
                ft.receipt_no As `OR`,
                ft.amount AS `PAID.AMOUNT`,
                r.form_stats As `STATUS`,
                CASE WHEN r.claim = 0 THEN 'False' ELSE 'True' END AS CLAIMED,
                DATE_FORMAT(r.due_date,'%m-%d-%Y') As `DATE.CLAIMED`,
                r.request_window As 'WINDOW',
                r.year_graduated,
                r.year_first_attendance,
                r.year_last_attendance,
                r.first_copy,
                rtr.finance_transaction_categories_id 'FORM.ID'

                From
                requisition As r
                INNER Join requisition_type_request AS rtr ON r.id = rtr.requisition_id
                INNER Join requisition_purpose_request AS rpr ON r.id = rpr.requisition_id
                INNER Join finance_transactions As ft ON r.ft_id = ft.id

                                "

        '     Return clsDBConn.ExecQuery(str)
        '       Return DataSource(str)
        '      dt = DataSource(String.Format(str))

        dt = DataSource(String.Format(str))
        Return dt

#Region "old1"
        '        Select Case
        '                '0' AS 'Include',
        '                r.id,

        '                r.class_roll_number,
        '                (SELECT
        '		                person.display_name
        '            FROM
        '            person
        '            INNER Join students ON person.person_id = students.person_id
        '                        WHERE
        '            person.status_type_id = 1 And
        '                        person.end_time Is NULL And
        '                        students.class_roll_no = class_roll_number LIMIT 1
        '		                ) 'STUDENT NAME',
        '                r.date_filed AS `DATE FILED`,
        '                r.first_copy As `1ST.COPY?`,
        '                rtr.type_of_request AS `REQUEST FORM`,
        '                rtr.no_of_copies As `NO.COPIES`,
        '                ft.amount AS AMOUNT,
        '                ft.receipt_no As `Or.RECEIPT`,
        '                rpr.purpose_request AS PURPOSE,
        '                r.form_stats As `STATUS`,
        '                r.claim AS CLAIMED
        '                From
        '                requisition As r
        '                INNER Join requisition_type_request AS rtr ON r.id = rtr.requisition_id
        '                INNER Join requisition_purpose_request AS rpr ON r.id = rpr.requisition_id
        '                INNER Join finance_transactions As ft ON r.finance_transactions_id = ft.id
#End Region
#Region "old"
        'Select Case
        '       '0' AS 'Include',
        '        id,
        '        class_roll_number,
        '        (SELECT
        '        person.display_name
        '    FROM
        '    person
        '    INNER Join students ON person.person_id = students.person_id
        '        WHERE
        '    person.status_type_id = 1 And
        '    person.end_time Is NULL And
        '    students.class_roll_no = class_roll_number LIMIT 1
        '        ) 'STUDENT NAME',
        '        DATE_FORMAT(date_filed,'%m/%d/%Y') 'date_filed',
        '        CASE WHEN first_copy = 1 THEN 'YES' ELSE 'NO' END AS 'first_copy',
        '        year_graduated,
        '        year_first_attendance,
        '        year_last_attendance,
        '        DATE_FORMAT(due_date,'%m/%d/%Y') 'due_date',
        '        request_window
        '        FROM
        '    requisition
        '    WHERE
        '    status_type_id = 1 And
        '    end_time Is NULL
#End Region
    End Function


    Friend Sub InsertObjectList(typeOfRequest As List(Of Requisition_TypeOfRequest), purposeOfRequest As List(Of Requisition_PurposeRequest), Optional LastPK As Integer = Nothing)

        Dim sql As String = ""

        StartTransaction()

        Try

            'Delete previous record
            DataSource(String.Format("DELETE FROM requisition_type_request WHERE requisition_id = '" & LastPK & "'"))
            DataSource(String.Format("DELETE FROM requisition_purpose_request WHERE requisition_id = '" & LastPK & "'"))

            For Each rows In typeOfRequest.ToList
                sql = "INSERT INTO requisition_type_request SET"
                sql &= String.Format(" requisition_id = '{0}',", LastPK)
                sql &= String.Format(" type_of_request = '{0}',", rows.TypeOfFormName)
                sql &= String.Format(" no_of_copies = '{0}',", rows.NoOfCopies)
                sql &= String.Format(" finance_transaction_categories_id = '{0}'", rows.TypeOfFormID)
                DataSource(sql, True)
            Next
            '         DataSource(sql, True)


            For Each rows In purposeOfRequest.ToList
                sql = "INSERT INTO requisition_purpose_request   SET"
                sql &= String.Format(" requisition_id = '{0}',", LastPK)
                sql &= String.Format(" purpose_request = '{0}',", rows.PurposeOfRequest)
                sql &= String.Format(" description = '{0}'", rows.PurposeOfRequest)
                DataSource(sql, True)
            Next
            '          DataSource(sql, True)
            '           DataSource(sql)

            commitQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            rollbackQuery()

        End Try
        EndTransaction()

    End Sub

    Friend Function Insert(oPERATION As String, request As Requesition) As Integer
      

        Dim LastPK As Integer
        StartTransaction()
        Try
            Dim sql As String = ""

            If oPERATION = "ADD" Then
                sql = "INSERT INTO requisition SET"
                sql = _StringFormat(request, sql)
            Else
                sql = "UPDATE requisition SET"
                sql = _StringFormat(request, sql)
                sql &= "WHERE id = '" & _id & "' "
            End If

            DataSource(sql, True)
            commitQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            rollbackQuery()
            Return 0
        End Try

        EndTransaction()

        LastPK = DataObject(String.Format("SELECT IFNULL(Max(id),0) FROM requisition WHERE status_type_id = 1 AND end_time IS NULL"))

        Return LastPK

    End Function

    Private Function _StringFormat(request As Requesition, sql As String) As String
        With request
            sql &= String.Format(" class_roll_number = '{0}',", .class_roll_number)
            sql &= String.Format(" date_filed = '{0}',", FormatDate(.date_filed))
            sql &= String.Format(" due_date = '{0}',", FormatDate(.due_date))
            sql &= String.Format(" first_copy = '{0}',", .first_copy)
            sql &= String.Format(" year_graduated = '{0}',", .year_graduated)
            sql &= String.Format(" year_first_attendance = '{0}',", .year_first_attendance)
            sql &= String.Format(" year_last_attendance = '{0}',", .year_last_attendance)
            sql &= String.Format(" form_stats = '{0}',", .form_status)
            sql &= String.Format(" claim = '{0}',", .claimed)
            sql &= String.Format(" ft_id = '{0}',", .financeT)
            sql &= String.Format(" request_window = '{0}'", .request_window)

        End With
        Return sql
    End Function

    Friend Sub UpdateClaimed(id As Integer, checkvalue As Integer)
        DataSource(String.Format("UPDATE `requisition` SET `claim` = " & checkvalue & " WHERE `id` = '" & id & "';"))
    End Sub

    Friend Function CheckFormTypeToFinanceCategory(financeTransactionCategoryID As Integer) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT
                finance_transaction_categories.id
                FROM
                finance_transaction_categories
                WHERE
                finance_transaction_categories.id = '" & financeTransactionCategoryID & "' AND
                finance_transaction_categories.deleted = 0
                "))
        If id > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Friend Function gerPurposeOfRequest(id As Integer) As DataTable
        Dim str As String = ""
        str = "SELECT purpose_request FROM requisition_purpose_request WHERE requisition_id = '" & id & "' "
        Return DataSource(str)
    End Function

    Friend Function getTypeOfRequestRecord(id As Integer) As DataTable
        Dim str As String = ""
        str = "SELECT
requisition_id,
type_of_request,
no_of_copies,
finance_transaction_categories_id
FROM
requisition_type_request
WHERE
requisition_id = '" & id & "'
"
        Return DataSource(str)
    End Function

    Friend Function CheckUnclaimedRequest(class_roll_no As String, formTypeID As Integer, claimed As Integer) As Boolean
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
	            requisition.class_roll_number, 
	            requisition_type_request.finance_transaction_categories_id AS form_type_id, 
	            requisition.claim
            FROM
	            requisition
	            INNER JOIN
	            requisition_type_request
	            ON 
		            requisition.id = requisition_type_request.requisition_id
            WHERE
	            requisition.class_roll_number = '" & class_roll_no & "' AND
	            requisition_type_request.finance_transaction_categories_id = '" & formTypeID & "' AND
	            requisition.claim = " & claimed & ""))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
