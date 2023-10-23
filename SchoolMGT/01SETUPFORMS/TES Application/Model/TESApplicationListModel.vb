Public Class TESApplicationListModel
    Friend Function getList() As DataTable
        Dim sql As String = ""
        sql = "SELECT
scholarship.id,
scholarship.person_id,
scholarship.UII,
LPAD(students.class_roll_no, 5, 0) AS 'SEQUENCE NO.#',
students.std_number 'STUDENT ID',
person.display_name 'STUDENT NAME',
person.gender 'SEX',
DATE_FORMAT(person.date_of_birth,'%d-%m-%Y') 'BIRTH DATE',
courses.course_name 'COMPLETE PROGRAM',
students.year_level 'YEAR LEVEL',
scholarship.learner_ref_no 'LEARNER REF.NO.#',
scholarship.total_assessment 'TOTAL ASSESSMENT',
CONCAT(person_address.address,', ',person_address.barangay,', ',person_address.citymunicipality,', ',person_address.province,', ',person_address.zipcode) AS 'ADDRESS',
CONCAT(scholarship.from_year,'-',scholarship.to_year) AS 'ACADEMIC YEAR'


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
person_address.address_type_id = 1"
        Return DataSource(sql)
    End Function

    Friend Function getUII() As Object
        Dim sql As String = ""
        sql = "SELECT
id AS ID,
uii_number AS `Name`
FROM
scholarship_uii
WHERE
status_type_id = 1 AND
end_time IS NULL
ORDER BY id DESC
"
        Return DataSource(sql)
    End Function

    Friend Function CheckUII(selectedValue As Object, fromYear As String, toYear As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT
                                    id
                                    FROM
                                    scholarship_uii
                                    WHERE
                                    status_type_id = 1 AND
                                    end_time IS NULL AND
                                    id = '" & selectedValue & "' AND
                                    year_from = '" & fromYear & "' AND
                                    year_to = '" & toYear & "'
                                    "))

        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Friend Function getScholarshipList(UII As String, yearFrom As String, yearTo As String) As DataTable
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
SUBSTRING(students.year_level,1,1)'year_level',
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
-- scholarship.UII =  '" & UII & "' AND
scholarship.from_year = '" & yearFrom & "' AND
scholarship.to_year = '" & yearTo & "'
"
        Return DataSource(sql)
    End Function

    Friend Sub SaveUII(UII As String, yearFrom As String, yearTo As String)

        DataSource(String.Format("insert INTO `scholarship_uii`
            (
             `uii_number`,
             `year_from`,
             `year_to`
            )
			VALUES (
							'" & UII & "',
							'" & yearFrom & "',
							'" & yearTo & "'
				);"))

        MsgBox("UII number has been added")

    End Sub

    Friend Sub ModifyUII(id As Object, uII As String)

        DataSource(String.Format("UPDATE scholarship SET UII = '" & uII & "' WHERE id = '" & id & "'"))

    End Sub
End Class
