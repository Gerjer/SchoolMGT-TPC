Public Class PrevilegeAccessModel
    Friend Function getEmployeeList() As DataTable

        Dim str As String = ""
#Region "OLD"
        '        str = "SELECT
        ''False' as 'INCLUDE',
        'person.display_name,
        'person.person_id,
        'employees.user_id
        'FROM
        'person
        'INNER JOIN employees ON person.person_id = employees.person_id

        'WHERE
        'person.status_type_id = 1 AND
        'person.end_time IS NULL AND
        'person.person_type_id = 1

        'ORDER BY display_name"
#End Region
        str = "SELECT 
'False' as 'INCLUDE',
display_name,
person_id,
user_id

FROM(
    SELECT
		person.display_name,
		person.person_id,
		employees.user_id 
		FROM
		person
		INNER JOIN employees ON person.person_id = employees.person_id 

		WHERE
		person.status_type_id = 1 AND
		person.end_time IS NULL AND
		employees.status_type_id = 1 AND
		employees.end_time IS NULL 


		UNION ALL


		SELECT 
		person.display_name,
		person.person_id,
		students.user_id
		FROM
		person
		INNER JOIN students ON person.person_id = students.person_id
		INNER JOIN users ON students.user_id = users.id

		WHERE
		person.status_type_id = 1 AND
		person.end_time IS NULL AND
		students.status_type_id = 1 AND
		students.end_time IS null AND
		students.user_id is NOT NULL
		)A
	-- GROUP BY display_name
ORDER BY display_name"
        Return DataSource(str)

    End Function

    Friend Function getPrevilege() As DataTable

        Dim str As String = ""
        str = "	SELECT
            *
            FROM(
	            SELECT
				'False' as 'INCLUDE',
				`privileges`.parent_id,
				`privileges`.id,
				CASE WHEN `privileges`.parent_id = 1 THEN 'FINANCE' 
					 WHEN `privileges`.parent_id = 11 THEN 'REGISTRAR'
					 WHEN `privileges`.parent_id = 16 THEN 'FACULTY'
					 WHEN `privileges`.parent_id = 22 THEN 'SETUP'
					 WHEN `privileges`.parent_id = 42 THEN 'SYSTEMS'
					 WHEN `privileges`.parent_id = 47 THEN 'REPORT'		 WHEN `privileges`.parent_id = 38 THEN 'LISTS'

				END AS 'PARENT',
				`privileges`.`name` AS 'CHILD',
  			`privileges`.description 'DESCRIPTION',
				CASE WHEN `privileges`.parent_id = `privileges`.id THEN 0 ELSE 1 END AS 'NOTHING',
                '' AS 'TYPE OF USER'
				FROM
				`privileges`
				WHERE
				`privileges`.status_type_id = 1 
				)A
				WHERE A.NOTHING = 1	"
        Return DataSource(str)

    End Function

    Friend Function getUsersFunctionaliy(user_id As Integer) As DataTable

        Dim str As String = ""
        str = "	SELECT
            *
            FROM(
	            SELECT
				'True' as 'INCLUDE',
				`privileges`.parent_id,
				`privileges`.id,
				CASE WHEN `privileges`.parent_id = 1 THEN 'FINANCE' 
					 WHEN `privileges`.parent_id = 11 THEN 'REGISTRAR'
					 WHEN `privileges`.parent_id = 16 THEN 'FACULTY'
					 WHEN `privileges`.parent_id = 22 THEN 'SETUP'
					 WHEN `privileges`.parent_id = 42 THEN 'SYSTEMS'
					 WHEN `privileges`.parent_id = 47 THEN 'REPORT'		 WHEN `privileges`.parent_id = 38 THEN 'LISTS'

				END AS 'PARENT',
				`privileges`.`name` AS 'CHILD',
  			`privileges`.description 'DESCRIPTION',
				CASE WHEN `privileges`.parent_id = `privileges`.id THEN 0 ELSE 1 END AS 'NOTHING',
				privileges_users.user_id

				FROM
				`privileges`
				INNER JOIN privileges_users ON privileges_users.privilege_id =`privileges`.id
				WHERE
				`privileges`.status_type_id = 1 
				)A
				WHERE A.NOTHING = 1	AND A.user_id = '" & user_id & "'"

        Return DataSource(str)
    End Function

    Friend Sub Insert(dtEmployee As DataTable, dtPrevilege As DataTable, dtAccess As DataTable, operation As String)

        If dtEmployee.Rows.Count > 0 Then

            Dim ParentID As Integer = 0
            Dim sql As String = ""

            For Each rows As DataRow In dtEmployee.Rows
                If rows.Item("INCLUDE").ToString = "True" Then

                    DataSource(String.Format("DELETE FROM `privileges_users` WHERE `user_id` = '" & rows.Item("user_id") & "' "))

                    'PREVILEGE
                    If dtPrevilege.Rows.Count > 0 Then

                        For Each previlege As DataRow In dtPrevilege.Rows

                            If previlege.Item("INCLUDE") = "True" Then
                                If ParentID = 0 Then

                                    sql = "INSERT INTO privileges_users SET"
                                    sql &= String.Format(" user_id = '{0}',", rows.Item("user_id"))
                                    sql &= String.Format(" privilege_id = '{0}',", previlege.Item("parent_id"))
                                    sql &= String.Format(" type_user = '{0}'", previlege.Item("TYPE OF USER"))
                                    DataSource(sql)

                                    ParentID = previlege.Item("parent_id")
                                ElseIf ParentID <> previlege.Item("parent_id") Then

                                    sql = "INSERT INTO privileges_users SET"
                                    sql &= String.Format(" user_id = '{0}',", rows.Item("user_id"))
                                    sql &= String.Format(" privilege_id = '{0}',", previlege.Item("parent_id"))
                                    sql &= String.Format(" type_user = '{0}'", previlege.Item("TYPE OF USER"))
                                    DataSource(sql)


                                    ParentID = previlege.Item("parent_id")
                                End If

                                sql = "INSERT INTO privileges_users SET"
                                sql &= String.Format(" user_id = '{0}',", rows.Item("user_id"))
                                sql &= String.Format(" privilege_id = '{0}',", previlege.Item("id"))
                                sql &= String.Format(" type_user = '{0}'", previlege.Item("TYPE OF USER"))
                                DataSource(sql)

                            End If

                        Next
                        '          Parent = 0

                    End If

                    'ACCESS
                    '           If dtAccess.Rows.Count > 0 Then

                    '        End If

                End If

            Next
        End If


    End Sub
End Class
