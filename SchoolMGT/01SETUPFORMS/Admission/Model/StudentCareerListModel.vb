Public Class StudentCareerListModel
    Friend Function getCourse() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
courses.id AS ID,
courses.course_name AS `Name`,
courses.`code`,
courses.section_name
FROM
courses
WHERE
courses.is_deleted = 0
"))
        Return dt
    End Function

    Friend Function getBacth() As Object
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
batches.id AS ID,
batches.`name` AS `Name`,
batches.year_level,
batches.school_year,
batches.semester,
batches.course_id
FROM
batches
WHERE
batches.is_deleted = 0
"))
        Return dt
    End Function

    Friend Function getStudentProfile(selectedValue As Object) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
person.person_id 'person_id',
students.id 'id',
person.last_name 'LAST NAME',
person.first_name 'FIRST NAME',
person.middle_name 'MIDDLE NAME',
person.gender 'GENDER',
person.date_of_birth 'BIRTH DATE',
person.telephone1 'CONTACT NUMBER',
courses.course_name 'COURSE',
students.std_number 'STUDENT NUMBER',
students_details.LRN_number 'LRN NUMBER',
students_details.date_encoded 'DATE ADMITTED',
students_details.scholarship_sponsor_name 'SCHOLARSHIP',
CASE WHEN students.is_regular = 0 THEN 'Regular' ELSE 'Irregular' END AS 'CAREER STATUS',
students.enrollmentAS AS 'STATUS'

FROM
person
INNER JOIN students ON person.person_id = students.person_id
INNER JOIN courses ON students.course_id = courses.id
INNER JOIN students_details ON person.person_id = students_details.person_id
WHERE
person.status_type_id = 1 AND
person.end_time IS NULL AND
students.status_type_id = 1 AND
students.course_id = '" & selectedValue & "'
"))
        Return dt
    End Function


    Friend Function getStudeentCareerCourse(CourseID As Object, studentID As String) As DataTable
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
students.id,
students.course_id,
students.batch_id,
students.status_description,
students.year_level,
students.semester,
students.enrollmentAS,
students.stature,
students.academice_year,
batches.`name`
FROM
students
INNER JOIN batches ON students.batch_id = batches.id
WHERE
students.status_type_id = 1 AND
students.id  IN(" & studentID & ") AND
students.course_id = '" & CourseID & "'
"))
        Return dt
    End Function
End Class
