Imports System.IO

Public Class EmployeeDetails

    'Employee Details
    Public Property id As Integer
    Public Property employee_category_id As Integer
    Public Property employee_number As String
    Public Property empl_number As String
    Public Property joining_date As Date
    Public Property firtsday_date As Date
    Public Property job_title As Integer
    Public Property employee_position_id As Integer
    Public Property employee_department_id As Integer
    Public Property status_description As String
    Public Property employee_grade_id As Integer
    Public Property biometric_id As String
    Public Property employee_qualification As String
    Public Property salary As Double
    Public Property personID As Integer
    Public Property date_application As Date

    Public Property userID As Integer

    Public Class BankDetails
        Public Property BankName As String
        Public Property AccountNumber As String
    End Class

    Public Class CharacterReference

        Public Property CharRName As String
        Public Property CharRPosition As String
        Public Property CharRcompany As String
        Public Property CharRContactNumber As String

    End Class

    Public Class EducationalAttainment
        Public Property EduDescription As String
        Public Property SchoolAddress As String
        Public Property EduFrom As Date
        Public Property EduTo As Date
        Public Property EduHonorsReceived As String

    End Class

    Public Class EmploymentHistory

        Public Property EmplHCompanyName As String
        Public Property EmplHFrom As Date
        Public Property EmplHTo As Date
        Public Property EmplHContactNumber As String
    End Class

    Public Class ServiceHistory

        Public Property ServHLevel As String
        Public Property ServHCareer As String
        Public Property ServHDateExam As Date
        Public Property ServHPlaceExam As String
        Public Property ServHRatings As String
        Public Property ServHLicenseNumber As String
        Public Property ServHDateRelease As Date

    End Class


End Class
