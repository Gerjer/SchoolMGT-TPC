Imports System.IO

Public Class PersonDetails

    'Person Detais
    Public Property person_type As Integer = 0
    Public Property first_name As String
    Public Property middle_name As String
    Public Property last_name As String
    Public Property full_name As String
    Public Property date_of_birth As Date
    Public Property date_of_place As String
    Public Property marital_status As String
    Public Property gender As String
    Public Property relegion As String
    Public Property language As String
    Public Property blood_group As String
    Public Property nationality_id As Integer
    Public Property mobile_phone As String
    Public Property home_phone As String
    Public Property email As String
    Public Property status As Integer
    Public Property personID As Integer
    Public Property disability As String
    'Contact Person
    Public Property contact_person As String
    Public Property contact_number As String
    Public Property contact_address As String
    Public Property contact_relationship As String
    'Statutory
    Public Property TIN As String
    Public Property SSS As String
    Public Property PagIBIG As String
    Public Property PhilHealth As String

    Public Class Address
        Public Property address_type_id As Integer
        Public Property address As String
        Public Property barangay As String
        Public Property citymunicipality As String
        Public Property zipcode As String
        Public Property province As String
        Public Property region As String
        Public Property country As String

    End Class


    Public Class Photo
        'Photo
        Public Property photo_file_name As String
        Public Property photo_path As String
        Public Property photo_content_type As String
        Public Property photo_data As Byte()
        Public Property photo_file_size As UInt32
        Public Property fs As FileStream
        Public Property original_photo_file_name As String


    End Class

    Public Class Dependent
        Public Property dependent_name As String
        Public Property dependent_birthdate As Date
        Public Property dependent_relationship As String
        Public Property dependent_rank As Integer
        Public Property dependent_gradeyear As String
        Public Property dependent_school As String

    End Class


    Public Class FamilyAndGuardian
        Public Property typeFamilyGuardian As String
        Public Property name As String
        Public Property occupation As String
        Public Property company_name As String
        Public Property company_number As String
        Public Property company_address As String

    End Class


End Class
