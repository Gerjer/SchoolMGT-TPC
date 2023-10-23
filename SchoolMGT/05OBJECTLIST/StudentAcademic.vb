Public Class StudentAcademic

    Public Property LRN As String
    Public Property student_data As String
    Public Property year_level As String
    Public Property date_application As Date
    Public Property interest As String
    Public Property family_income As String
    Public Property sponsors As String
    Public Property course_another As String
    Public Property course_choice As String
    Public Property plan_after_college As String
    Public Property join_position_id As Integer

    'High School
    Public Property high_school_name As String
    Public Property high_school_address As String
    Public Property high_school_dategraduation As Date
    Public Property high_school_lisachivement_filepath As String
    Public Property high_school_extracurr_activities As String

    'College
    Public Property college_master_program As String
    Public Property college_specialization As String
    Public Property college_degree_earned As String
    Public Property college_university_name As String
    Public Property college_year_from As Date
    Public Property college_year_to As Date

    'Others
    Public Property other_extra_curricular_participation As String
    Public Property other_resources_available As String
    Public Property other_skills_talents As String
    Public Property other_sports As String

    Public Class AttendedUniversity
        Public Property name_attendee As String
        Public Property relationship_attendee As String
    End Class

    Public Class AttachmentDocuments
        Public Property attachment_document_type As String
        Public Property attachemtn_filepath As String
        Public Property attachment_filename As String
    End Class

End Class
