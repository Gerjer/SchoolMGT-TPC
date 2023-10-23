Imports DevComponents.DotNetBar
Imports SchoolMGT

Public Class TESApplicationRecordModel
    Friend Sub Insert(TES As TESApplication, operation As String)

        Dim sql As String = ""
        StartTransaction()
        Try

            With TES

                If operation = "ADD" Then
                    sql &= " INSERT INTO scholarship SET"
                Else
                    sql &= " UPDATE scholarship SET"
                End If

                sql &= String.Format(" person_id = '{0}',", .person_id)
                sql &= String.Format(" scholarship_any = '{0}',", .scholarship_any)
                sql &= String.Format(" student_extension_name = '{0}',", .extension_name)
                sql &= String.Format(" UII = '{0}',", .UII)
                sql &= String.Format(" learner_ref_no = '{0}',", .learner_ref_no)
                sql &= String.Format(" disability = '{0}',", .disability)
                sql &= String.Format(" dswd_household_no = '{0}',", .dswd_household_no)
                sql &= String.Format(" income = '{0}',", .income)
                sql &= String.Format(" total_assessment = '{0}',", .total_assessment)
                sql &= String.Format(" father_last_name = '{0}',", .father_last_name)
                sql &= String.Format(" father_first_name = '{0}',", .father_first_name)
                sql &= String.Format(" father_middle_name = '{0}',", .father_middle_name)
                sql &= String.Format(" mother_last_name = '{0}',", .mother_last_name)
                sql &= String.Format(" mother_first_name = '{0}',", .mother_first_name)
                sql &= String.Format(" mother_middle_name = '{0}',", .mother_middle_name)
                sql &= String.Format(" from_year = '{0}',", .from_year)
                sql &= String.Format(" to_year = '{0}'", .to_year)

                If operation = "EDIT" Then
                    sql &= String.Format(" WHERE id = '{0}'", .id)
                    DataSource(sql, True)
                    MessageBoxEx.Show("Record Updated... Successfully!   ", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    DataSource(sql, True)
                    MessageBoxEx.Show("Record Save... Successfully!   ", "Successfully Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With

            commitQuery()
        Catch ex As Exception
            rollbackQuery()
            MsgBox(ex.Message)
        End Try
        EndTransaction()

        'Update Student Details Scholarship
        DataSource(String.Format("UPDATE students_details SET scholarship_any = 'TES' WHERE person_id = '" & TES.person_id & "'"))

    End Sub

    Friend Function getScholarshipRecord(id As Integer) As DataTable
        Dim sql As String = ""
        sql = "SELECT
scholarship.id,
scholarship.person_id,
LPAD(students.class_roll_no,4,0) 'class_roll_no',
scholarship.learner_ref_no,
students.std_number,
person.last_name,
person.first_name,
scholarship.student_extension_name,
person.middle_name,
person.gender,
person.date_of_birth,
courses.course_name,
students.year_level,
scholarship.father_last_name,
scholarship.father_first_name,
scholarship.father_middle_name,
scholarship.mother_last_name,
scholarship.mother_first_name,
scholarship.mother_middle_name,
scholarship.dswd_household_no,
scholarship.income,
person_address.address,
person_address.barangay,
person_address.citymunicipality,
person_address.province,
person_address.zipcode,
scholarship.total_assessment,
scholarship.disability,
person.telephone1,
person.email,
scholarship.scholarship_any,
scholarship.UII,
scholarship.from_year,
scholarship.to_year

FROM
scholarship
INNER JOIN person ON scholarship.person_id = person.person_id
INNER JOIN students ON person.person_id = students.person_id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN person_address ON person.person_id = person_address.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
scholarship.status_type_id = 1 AND
scholarship.end_time IS NULL AND
students.status_type_id = 1 AND
students.end_time IS NULL AND
person_address.address_type_id = 1 AND
scholarship.id = '" & id & "'
"
        Return DataSource(sql)
    End Function

    Friend Function getStudentList() As Object
        Dim sql As String = ""
        sql = "SELECT
person.person_id 'ID',
person.display_name 'Name',
LPAD(students.class_roll_no,4,0) 'SeqNumber',
students.std_number,
person.gender,
person.date_of_birth,
courses.course_name,
students.year_level,
person_address.address,
person_address.barangay,
person_address.citymunicipality,
person_address.province,
person_address.zipcode,
person.telephone1,
person.email,
(SELECT
family_background_name
FROM
person_familybackground
WHERE
family_background_type = 'Father' AND person_id = person.person_id
) AS 'Father',
(SELECT
family_background_name
FROM
person_familybackground
WHERE
family_background_type = 'Mother' AND person_id = person.person_id
) AS 'Mother'
FROM
person

INNER JOIN students ON person.person_id = students.person_id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN person_address ON person.person_id = person_address.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
students.status_type_id = 1 AND
students.end_time IS NULL AND
person_address.address_type_id = 1 

ORDER BY `Name`

"
        Return DataSource(sql)
    End Function

    Friend Function CheckIFExist(person_id As Object, yearFrom As String, yearTo As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT
scholarship.person_id
FROM
scholarship
WHERE
scholarship.status_type_id = 1 AND
scholarship.end_time IS NULL AND
scholarship.person_id = '" & person_id & "' AND
scholarship.from_year = '" & yearFrom & "' AND
scholarship.to_year = '" & yearTo & "'
"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
