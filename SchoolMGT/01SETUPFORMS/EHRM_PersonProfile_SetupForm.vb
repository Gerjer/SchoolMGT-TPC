Public Class EHRM_PersonProfile_SetupForm




    Dim employeeInfo As New cls_EmployeeInfo

    Private WithEvents clsPerson As clsData
    Private WithEvents clsPPFBG As clsData
    Private WithEvents clsEDUBG As clsData
    Private WithEvents clsCService As clsData

    Private WithEvents clsWorkEXP As clsData
    Private WithEvents clsVWork As clsData
    Private WithEvents clsTraining As clsData


    Private FBGformControls As Collection

    Dim ROWSELECT As Integer = -1




#Region "Classes"
    Private Sub AttachClasses()
        clsPerson = New clsData(Me.txtSysPK_PP, clsDBConn)
        clsPerson.AttachUserPK = Me.txtpp_person_code
        clsPerson.AttachControl = Me.txtpp_person_code

        clsPerson.AttachControl = Me.txtpp_prefix
        clsPerson.AttachControl = Me.txtpp_lastname
        clsPerson.AttachControl = Me.txtpp_firstname
        clsPerson.AttachControl = Me.txtpp_middlename
        clsPerson.AttachControl = Me.txtpp_suffix
        clsPerson.AttachControl = Me.txtpp_fullname
        clsPerson.AttachControl = Me.txtpp_dob
        clsPerson.AttachControl = Me.txtpp_birthplace
        clsPerson.AttachControl = Me.txtpp_sex
        clsPerson.AttachControl = Me.txtpp_civilstatus
        clsPerson.AttachControl = Me.txtpp_citizenship
        clsPerson.AttachControl = Me.txtpp_height
        clsPerson.AttachControl = Me.txtpp_weight
        clsPerson.AttachControl = Me.txtpp_bloodType
        clsPerson.AttachControl = Me.txtpp_GSIS_no
        clsPerson.AttachControl = Me.txtpp_PAGIBIG_no
        clsPerson.AttachControl = Me.txtpp_PHILHEALTH_no
        clsPerson.AttachControl = Me.txtpp_SSS_no
        clsPerson.AttachControl = Me.txtpp_TIN
        clsPerson.AttachControl = Me.txtpp_Address1
        clsPerson.AttachControl = Me.txtpp_zipcode1
        clsPerson.AttachControl = Me.txtpp_Tel_no1
        clsPerson.AttachControl = Me.txtpp_Address2
        clsPerson.AttachControl = Me.txtpp_zipcode2
        clsPerson.AttachControl = Me.txtpp_Tel_no2
        clsPerson.AttachControl = Me.txtpp_email
        clsPerson.AttachControl = Me.txtpp_cell_no
        clsPerson.AttachControl = Me.txtpp_agency_employee_no
        clsPerson.AttachControl = Me.txtpp_Priority





        'Handles Add,Save and Delete
        clsPerson.AttachAddButton = Me.btnAdd
        clsPerson.AttachSaveButton = Me.btnSave
        clsPerson.AttachDeleteButton = Me.btnDelete
        clsPerson.Initialize() 'Always naa gyud ni siya at the end......

    End Sub

    Private Sub AttachFBGClasses()
        clsPPFBG = New clsData(Me.txtSysPK_PPFBG, clsDBConn)
        clsPPFBG.AttachUserPK = Me.txtpp_fbg_pp_code
        clsPPFBG.AttachControl = Me.txtpp_fbg_pp_code
        clsPPFBG.AttachControl = Me.txtpp_fbg_spousecode
        clsPPFBG.AttachControl = Me.txtpp_fbg_spousename
        clsPPFBG.AttachControl = Me.txtpp_fbg_spouse_occupation
        clsPPFBG.AttachControl = Me.txtpp_fbg_sp_EmpAddress
        clsPPFBG.AttachControl = Me.txtpp_fbg_sp_Employer
        clsPPFBG.AttachControl = Me.txtpp_fbg_sp_Contact
        clsPPFBG.AttachControl = Me.txtpp_fbg_fathercode
        clsPPFBG.AttachControl = Me.txtpp_fbg_fathersname
        clsPPFBG.AttachControl = Me.txtpp_fbg_mothercode
        clsPPFBG.AttachControl = Me.txtpp_fbg_mothersname

        'Handles Add,Save and Delete

        clsPPFBG.AttachSaveButton = Me.btnSaveFBG
        clsPPFBG.AttachAddButton = Me.btnAddFBG
        clsPPFBG.Initialize() 'Always naa gyud ni siya at the end......
    End Sub


    Private Sub AttachEDUClasses()
        clsEDUBG = New clsData(Me.txtSysPK_EDBG, clsDBConn)
        clsEDUBG.AttachUserPK = Me.txteducation_pp_code
        clsEDUBG.AttachControl = Me.txteducation_pp_code
        clsEDUBG.AttachControl = Me.txteducation_level
        clsEDUBG.AttachControl = Me.txteducation_School
        clsEDUBG.AttachControl = Me.txteducation_DegreeCourse
        clsEDUBG.AttachControl = Me.txteducation_yearGraduated
        clsEDUBG.AttachControl = Me.txteducation_date_from
        clsEDUBG.AttachControl = Me.txteducation_date_to
        clsEDUBG.AttachControl = Me.txteducation_grades
        clsEDUBG.AttachControl = Me.txteducation_honors_etc


        'Handles Add,Save and Delete

        clsEDUBG.AttachSaveButton = Me.btnSaveEdu
        clsEDUBG.AttachAddButton = Me.btnAddEDU
        clsEDUBG.AttachDeleteButton = Me.btnDeleteEDU
        clsEDUBG.Initialize() 'Always naa gyud ni siya at the end......


        'displayEDUBG()

    End Sub

    Private Sub displayEDUBG()
        Dim SQLEX As String = "SELECT SysPK_EDBG, education_pp_code, "
        SQLEX += " education_date_from, education_date_to, education_level,education_School,education_DegreeCourse,"
        SQLEX += " education_yearGraduated,"
        SQLEX += " education_grades,education_honors_etc FROM hr_person_educational_bg"
        SQLEX += " WHERE education_pp_code='" & txtpp_person_code.Text & "'"
        SQLEX += " ORDER BY education_date_from, education_date_to, education_yearGraduated"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        tdbEduViewer.DataSource = MeData

        With tdbEduViewer.Splits(0)

            .DisplayColumns("SysPK_EDBG").DataColumn.Caption = "SYSPK"
            .DisplayColumns("SysPK_EDBG").Width = 0
            'education_pp_code
            .DisplayColumns("education_pp_code").DataColumn.Caption = "SYSPK"
            .DisplayColumns("education_pp_code").Width = 0

            .DisplayColumns("education_date_from").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_date_from").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_date_from").DataColumn.Caption = "DATE FROM"
            .DisplayColumns("education_date_from").Width = 100

            .DisplayColumns("education_date_to").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_date_to").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_date_to").DataColumn.Caption = "DATE TO"
            .DisplayColumns("education_date_to").Width = 100


            .DisplayColumns("education_level").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_level").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_level").DataColumn.Caption = "LEVEL"
            .DisplayColumns("education_level").Width = 200

            .DisplayColumns("education_School").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_School").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_School").DataColumn.Caption = "SCHOOL"
            .DisplayColumns("education_School").Width = 200

            .DisplayColumns("education_DegreeCourse").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_DegreeCourse").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_DegreeCourse").DataColumn.Caption = "DEGREE/COURSE"
            .DisplayColumns("education_DegreeCourse").Width = 200

            .DisplayColumns("education_yearGraduated").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_yearGraduated").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_yearGraduated").DataColumn.Caption = "YEAR GRADUATED"
            .DisplayColumns("education_yearGraduated").Width = 100


            'education_level, education_School, education_DegreeCourse, ""
            'SQLEX += " education_yearGraduated,"
            'SQLEX += " education_grades,education_honors_etc FROM hr_person_educational_bg"

            .DisplayColumns("education_grades").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_grades").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_grades").DataColumn.Caption = "GRADE"
            .DisplayColumns("education_grades").Width = 100

            .DisplayColumns("education_honors_etc").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("education_honors_etc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("education_honors_etc").DataColumn.Caption = "HONORS"
            .DisplayColumns("education_honors_etc").Width = 150



        End With
    End Sub

    Private Sub AttachCServiceClasses()
        clsCService = New clsData(Me.txtSysPK_eligibility, clsDBConn)
        clsCService.AttachUserPK = Me.txteligibility_pp_code
        clsCService.AttachControl = Me.txteligibility_pp_code
        clsCService.AttachControl = Me.txteligibility_level
        clsCService.AttachControl = Me.txteligibility_career
        clsCService.AttachControl = Me.txteligibility_dateofExam
        clsCService.AttachControl = Me.txteligibility_placeofExam
        clsCService.AttachControl = Me.txteligibility_rating
        clsCService.AttachControl = Me.txteligibility_license_no
        clsCService.AttachControl = Me.txteligibility_license_rel_date

        'Handles Add,Save and Delete

        clsCService.AttachSaveButton = Me.btnCServiceSave
        clsCService.AttachAddButton = Me.btnCServiceAdd
        clsCService.AttachDeleteButton = Me.btnCServiceDel
        clsCService.Initialize() 'Always naa gyud ni siya at the end......


        'displayCServiceBG()

    End Sub

    Private Sub displayCServiceBG()
        Dim SQLEX As String = "SELECT SysPK_eligibility, eligibility_pp_code, "
        SQLEX += " eligibility_level, eligibility_career,eligibility_dateofExam,eligibility_placeofExam,"
        SQLEX += " eligibility_rating,eligibility_license_no,eligibility_license_rel_date"
        SQLEX += " FROM hr_person_eligibility WHERE eligibility_pp_code='" & txtpp_person_code.Text & "'"
        SQLEX += " ORDER BY eligibility_dateofExam"
        
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        tdbCServiceViewer.DataSource = MeData

        With tdbCServiceViewer.Splits(0)

            .DisplayColumns("SysPK_eligibility").DataColumn.Caption = "SYSPK"
            .DisplayColumns("SysPK_eligibility").Width = 0
            'education_pp_code
            .DisplayColumns("eligibility_pp_code").DataColumn.Caption = "SYSPK"
            .DisplayColumns("eligibility_pp_code").Width = 0

            .DisplayColumns("eligibility_level").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_level").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_level").DataColumn.Caption = "LEVEL"
            .DisplayColumns("eligibility_level").Width = 100

            .DisplayColumns("eligibility_career").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_career").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_career").DataColumn.Caption = "CAREER SERVICE"
            .DisplayColumns("eligibility_career").Width = 200

            .DisplayColumns("eligibility_dateofExam").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_dateofExam").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_dateofExam").DataColumn.Caption = "EXAM DATE"
            .DisplayColumns("eligibility_dateofExam").Width = 100


            .DisplayColumns("eligibility_placeofExam").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_placeofExam").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("eligibility_placeofExam").DataColumn.Caption = "PLACE OF EXAM"
            .DisplayColumns("eligibility_placeofExam").Width = 200

            .DisplayColumns("eligibility_rating").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_rating").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("eligibility_rating").DataColumn.Caption = "RATING"
            .DisplayColumns("eligibility_rating").Width = 100

            .DisplayColumns("eligibility_license_no").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_license_no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("eligibility_license_no").DataColumn.Caption = "LICENSE NUMBER"
            .DisplayColumns("eligibility_license_no").Width = 200

            .DisplayColumns("eligibility_license_rel_date").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("eligibility_license_rel_date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("eligibility_license_rel_date").DataColumn.Caption = "LIC. REL. DATE"
            .DisplayColumns("eligibility_license_rel_date").Width = 150



        End With
    End Sub

    Private Sub AttachWorkEXPClasses()
        clsWorkEXP = New clsData(Me.txtSysPK_work_xp, clsDBConn)
        clsWorkEXP.AttachUserPK = Me.txtwexp_pp_code
        clsWorkEXP.AttachControl = Me.txtwexp_pp_code
        clsWorkEXP.AttachControl = Me.txtwexp_dateFrom
        clsWorkEXP.AttachControl = Me.txtwexp_dateTo
        clsWorkEXP.AttachControl = Me.txtwexp_Position
        clsWorkEXP.AttachControl = Me.txtwexp_Agency
        clsWorkEXP.AttachControl = Me.txtwexp_monthly_sal
        clsWorkEXP.AttachControl = Me.txtwexp_salarygrade
        clsWorkEXP.AttachControl = Me.txtwexp_status
        clsWorkEXP.AttachControl = Me.txtwexp_govtservice
        

        'Handles Add,Save and Delete

        clsWorkEXP.AttachSaveButton = Me.btnWEXPSave
        clsWorkEXP.AttachAddButton = Me.btnWEXPAdd
        clsWorkEXP.AttachDeleteButton = Me.btnWEXPDel
        clsWorkEXP.Initialize() 'Always naa gyud ni siya at the end......


        'displayWEXPBG()

    End Sub

    Private Sub displayWEXPBG()
        Dim SQLEX As String = "SELECT SysPK_work_xp, wexp_pp_code, "
        SQLEX += " wexp_dateFrom,"
        SQLEX += " CASE WHEN wexp_dateTo IS NULL THEN 'present'"
        SQLEX += " ELSE wexp_dateTo"
        SQLEX += " END AS 'wexp_dateTo'"
        SQLEX += " ,wexp_Position, wexp_Agency, wexp_monthly_sal, "
        SQLEX += " wexp_salarygrade,wexp_status,wexp_govtservice"
        SQLEX += " FROM hr_person_work_exp WHERE wexp_pp_code='" & txtpp_person_code.Text & "'"
        SQLEX += " ORDER BY wexp_dateFrom DESC"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        tdbWEXPViewer.DataSource = MeData
        With tdbWEXPViewer.Splits(0)

            .DisplayColumns("SysPK_work_xp").DataColumn.Caption = "SYSPK"
            .DisplayColumns("SysPK_work_xp").Width = 0
            'education_pp_code
            .DisplayColumns("wexp_pp_code").DataColumn.Caption = "SYSPK"
            .DisplayColumns("wexp_pp_code").Width = 0

            .DisplayColumns("wexp_dateFrom").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_dateFrom").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_dateFrom").DataColumn.Caption = "FROM"
            .DisplayColumns("wexp_dateFrom").Width = 100

            .DisplayColumns("wexp_dateTo").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_dateTo").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_dateTo").DataColumn.Caption = "TO"
            .DisplayColumns("wexp_dateTo").Width = 100


            .DisplayColumns("wexp_Position").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_Position").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("wexp_Position").DataColumn.Caption = "POSITION"
            .DisplayColumns("wexp_Position").Width = 200

            .DisplayColumns("wexp_Agency").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_Agency").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("wexp_Agency").DataColumn.Caption = "DEPARTMENT/AGENCY"
            .DisplayColumns("wexp_Agency").Width = 250

            .DisplayColumns("wexp_monthly_sal").DataColumn.NumberFormat = "#,###,###.00"
            .DisplayColumns("wexp_monthly_sal").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_monthly_sal").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
            .DisplayColumns("wexp_monthly_sal").DataColumn.Caption = "MO. SALARY"
            .DisplayColumns("wexp_monthly_sal").Width = 100

            'wexp_salarygrade
            .DisplayColumns("wexp_salarygrade").Width = 0

            .DisplayColumns("wexp_status").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_status").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("wexp_status").DataColumn.Caption = "STATUS"
            .DisplayColumns("wexp_status").Width = 150

            .DisplayColumns("wexp_govtservice").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("wexp_govtservice").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("wexp_govtservice").DataColumn.Caption = "GOV'T SERVICE"
            .DisplayColumns("wexp_govtservice").Width = 100



        End With
    End Sub

    Private Sub AttachVWorkClasses()
        clsVWork = New clsData(Me.txtSysPK_VWork, clsDBConn)
        clsVWork.AttachUserPK = Me.txtvoluntary_ppcode
        clsVWork.AttachControl = Me.txtvoluntary_ppcode
        clsVWork.AttachControl = Me.txtvoluntary_dateFrom
        clsVWork.AttachControl = Me.txtvoluntary_dateTo
        clsVWork.AttachControl = Me.txtvoluntary_Hours
        clsVWork.AttachControl = Me.txtvoluntary_Position
        clsVWork.AttachControl = Me.txtvoluntary_Organization

        

        'Handles Add,Save and Delete

        clsVWork.AttachSaveButton = Me.btnVWorkSave
        clsVWork.AttachAddButton = Me.btnVWorkAdd
        clsVWork.AttachDeleteButton = Me.btnVWorkDel
        clsVWork.Initialize() 'Always naa gyud ni siya at the end......

        '        displayVWPBG()

    End Sub

    Private Sub displayVWPBG()
        Dim SQLEX As String = "SELECT SysPK_VWork,voluntary_ppcode,voluntary_dateFrom,"
        SQLEX += " voluntary_dateTo,voluntary_Hours,voluntary_Position,voluntary_Organization"
        SQLEX += " FROM hr_person_voluntary_work WHERE voluntary_ppcode='" & txtpp_person_code.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        tdbVWorkViewer.DataSource = MeData
        With tdbVWorkViewer.Splits(0)

            .DisplayColumns("SysPK_VWork").DataColumn.Caption = "SYSPK"
            .DisplayColumns("SysPK_VWork").Width = 0
            'education_pp_code
            .DisplayColumns("voluntary_ppcode").DataColumn.Caption = "SYSPK"
            .DisplayColumns("voluntary_ppcode").Width = 0

            .DisplayColumns("voluntary_dateFrom").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_dateFrom").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_dateFrom").DataColumn.Caption = "FROM"
            .DisplayColumns("voluntary_dateFrom").Width = 100

            .DisplayColumns("voluntary_dateTo").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_dateTo").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_dateTo").DataColumn.Caption = "TO"
            .DisplayColumns("voluntary_dateTo").Width = 100


            .DisplayColumns("voluntary_Hours").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_Hours").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_Hours").DataColumn.Caption = "HOURS"
            .DisplayColumns("voluntary_Hours").Width = 100

            .DisplayColumns("voluntary_Position").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_Position").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("voluntary_Position").DataColumn.Caption = "POSITION"
            .DisplayColumns("voluntary_Position").Width = 150

            .DisplayColumns("voluntary_Organization").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("voluntary_Organization").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("voluntary_Organization").DataColumn.Caption = "ORGANIZATION NAME"
            .DisplayColumns("voluntary_Organization").Width = 250

        End With
    End Sub

    Private Sub AttachTrainingClasses()
        clsTraining = New clsData(Me.txtSysPK_training, clsDBConn)
        clsTraining.AttachUserPK = Me.txttraining_pp_code
        clsTraining.AttachControl = Me.txttraining_pp_code
        clsTraining.AttachControl = Me.txttraining_training_name
        clsTraining.AttachControl = Me.txttraining_dateFrom
        clsTraining.AttachControl = Me.txttraining_dateTo
        clsTraining.AttachControl = Me.txttraining_Hours
        clsTraining.AttachControl = Me.txttraining_sponsors

        


        'Handles Add,Save and Delete

        clsTraining.AttachSaveButton = Me.btnTrainingSave
        clsTraining.AttachAddButton = Me.btnTrainingAdd
        clsTraining.AttachDeleteButton = Me.btnTrainingDelete
        clsTraining.Initialize() 'Always naa gyud ni siya at the end......

        'displayTrainingBG()

    End Sub

    Private Sub displayTrainingBG()
        Dim SQLEX As String = "SELECT SysPK_training,training_pp_code,training_training_name,"
        SQLEX += " training_dateFrom,training_dateTo,training_Hours,training_sponsors"
        SQLEX += " FROM hr_person_training WHERE training_pp_code='" & txtpp_person_code.Text & "'"


        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        tdbTrainingViewer.DataSource = MeData
        With tdbTrainingViewer.Splits(0)

            .DisplayColumns("SysPK_training").DataColumn.Caption = "SYSPK"
            .DisplayColumns("SysPK_training").Width = 0
            'education_pp_code
            .DisplayColumns("training_pp_code").DataColumn.Caption = "SYSPK"
            .DisplayColumns("training_pp_code").Width = 0

            .DisplayColumns("training_training_name").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_training_name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("training_training_name").DataColumn.Caption = "TRAINING NAME"
            .DisplayColumns("training_training_name").Width = 100

            .DisplayColumns("training_dateFrom").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_dateFrom").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_dateFrom").DataColumn.Caption = "FROM"
            .DisplayColumns("training_dateFrom").Width = 100


            .DisplayColumns("training_dateTo").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_dateTo").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_dateTo").DataColumn.Caption = "TO"
            .DisplayColumns("training_dateTo").Width = 100

            .DisplayColumns("training_Hours").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_Hours").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("training_Hours").DataColumn.Caption = "HOURS"
            .DisplayColumns("training_Hours").Width = 100

            .DisplayColumns("training_sponsors").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            .DisplayColumns("training_sponsors").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
            .DisplayColumns("training_sponsors").DataColumn.Caption = "SPONSORS"
            .DisplayColumns("training_sponsors").Width = 250

        End With
    End Sub


    Private Sub DetachClasses()
        clsPerson = Nothing
        clsPPFBG = Nothing
        clsCService = Nothing
        clsWorkEXP = Nothing
        clsEDUBG = Nothing
        clsVWork = Nothing
        clsTraining = Nothing
    End Sub


#End Region

    Private Sub fmaEmployeeSetupForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DetachClasses()
    End Sub

    'Private Sub fmaEmployeeSetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    clsDBConn = New clsDBConnection
    '    If Not clsDBConn.IsDBConnected() Then
    '        clsDBConn.SaveToRegistry()
    '    End If


    '    Me.AttachClasses()
    'End Sub


    'Private Sub txtPhotoPath_Empl_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.SelectPicture()
    'End Sub

    'Private Sub SelectPicture()
    '    With ofdBrowse
    '        .FilterIndex = 0
    '        .Filter = "All Files|*.*"
    '        .ShowDialog()

    '        If .FileName.Trim <> "" Then
    '            Me.txtPicturePath_Cust.Text = .FileName
    '            Try
    '                picEmployee.Image = Image.FromFile(.FileName)
    '            Catch ex As Exception
    '            End Try
    '        End If
    '    End With
    'End Sub

    'Private Sub txtPhotoPath_Empl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Me.txtPicturePath_Cust.Text.Trim = "" Then
    '            picEmployee.Image = DefaultImage
    '        Else
    '            picEmployee.Image = Image.FromFile(Me.txtPicturePath_Cust.Text)
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub clsPerson_BeforeRecordSave() Handles clsPerson.BeforeRecordSave
        txtpp_fullname.Text = txtpp_lastname.Text & ", " & txtpp_firstname.Text & ", " & txtpp_middlename.Text
        txtpp_Priority.Text = "2"
    End Sub


    Private Sub txtList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtList.Click
        EHRM_PersonaProfile_ViewerListForm.FormControls = clsPerson.FormControls
        EHRM_PersonaProfile_ViewerListForm.Show()
        EHRM_PersonaProfile_ViewerListForm.BringToFront()

    End Sub

    Private Sub EHRM_PersonProfile_SetupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        AttachClasses()
        AttachFBGClasses()

        Me.AttachTrainingClasses()
        Me.AttachVWorkClasses()
        Me.AttachWorkEXPClasses()
        Me.AttachEDUClasses()
        Me.AttachCServiceClasses()

        Me.txtPersonNumber.Text = Me.txtpp_person_code.Text
        disableSaveButtons()

        'If Not EHRM_MAIN_FORM.txtUserType.Text = "HR ADMIN" Then
        '    btnAdd.Enabled = False
        'End If
    End Sub

    Private Sub btnCancelPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPP.Click
        Me.Close()
    End Sub

    Private Sub TabItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem2.Click

        If Me.txtSysPK_PP.Text.Length > 0 Then
            'AttachFBGClasses()
            clsPPFBG.Initialize()
            btnSaveFBG.Enabled = False
            'FBGformControls = clsPPFBG.FormControls


            Try
                getFBGData()
            Catch ex As Exception

            End Try

            If Me.txtSysPK_PP.Text.Length > 0 Then
                FBGdataToGrid()
            End If


            'C1TrueDBGridPersonProfile.DataSource = employeeInfo.getAllPersonProfile("", "", "")
            'arrangeGrid()
            Dim MeData As New DataTable
            Dim SQL As String = "call _hr_display_person_profile_name_lists"
            MeData = clsDBConn.ExecQuery(SQL)
            C1TrueDBGridPersonProfile.DataSource = MeData
            arrangeGrid()


        End If


    End Sub

    Private Sub arrangeGrid()
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_person_code").Width = 0

        C1TrueDBGridPersonProfile.Columns(1).Caption = "LAST NAME"
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_lastname").Width = 150
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_lastname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_lastname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        C1TrueDBGridPersonProfile.Columns(2).Caption = "FIRST NAME"
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_firstname").Width = 150
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_firstname").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_firstname").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        C1TrueDBGridPersonProfile.Columns(3).Caption = "MIDDLE NAME"
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_middlename").Width = 150
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_middlename").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_middlename").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near

        C1TrueDBGridPersonProfile.Splits(0).DisplayColumns("pp_fullname").Width = 0
    End Sub


    Private Sub btnSpouseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpouseSearch.Click
        If Not GroupPanel3.Visible Then
            GroupPanel3.Visible = True
            GroupPanel2.Tag = "spouse"
        Else
            GroupPanel3.Visible = False
            GroupPanel2.Tag = ""
            txtpp_fbg_spousecode.Text = ""
        End If
    End Sub

    Private Sub btnFatherSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFatherSearch.Click
        If Not GroupPanel3.Visible Then
            GroupPanel3.Visible = True
            GroupPanel2.Tag = "father"
        Else
            GroupPanel3.Visible = False
            GroupPanel2.Tag = ""
            txtpp_fbg_fathercode.Text = ""
        End If
    End Sub

    Private Sub btnMotherSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotherSearch.Click
        If Not GroupPanel3.Visible Then
            GroupPanel3.Visible = True
            GroupPanel2.Tag = "mother"
        Else
            GroupPanel3.Visible = False
            GroupPanel2.Tag = ""
            txtpp_fbg_mothercode.Text = ""
        End If
    End Sub

    Private Sub C1TrueDBGridPersonProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TrueDBGridPersonProfile.DoubleClick
        Select Case GroupPanel2.Tag
            Case "spouse"
                txtpp_fbg_spousecode.Text = C1TrueDBGridPersonProfile.Columns.Item(0).Value.ToString()
                txtpp_fbg_spousename.Text = C1TrueDBGridPersonProfile.Columns.Item(4).Value.ToString()
            Case "father"
                txtpp_fbg_fathercode.Text = C1TrueDBGridPersonProfile.Columns.Item(0).Value.ToString()
                txtpp_fbg_fathersname.Text = C1TrueDBGridPersonProfile.Columns.Item(4).Value.ToString()
            Case "mother"
                txtpp_fbg_mothercode.Text = C1TrueDBGridPersonProfile.Columns.Item(0).Value.ToString()
                txtpp_fbg_mothersname.Text = C1TrueDBGridPersonProfile.Columns.Item(4).Value.ToString()
        End Select
        GroupPanel3.Visible = False
    End Sub

    Private Sub clsPPFBG_BeforeRecordSave() Handles clsPPFBG.BeforeRecordSave
        Me.txtpp_fbg_pp_code.Text = Me.txtpp_person_code.Text
    End Sub

    Private Sub getFBGData()
        Dim SQL As String = "SELECT SysPK_PPFBG,pp_fbg_pp_code,pp_fbg_spousecode,pp_fbg_spousename,pp_fbg_spouse_occupation,pp_fbg_sp_Employer,pp_fbg_sp_EmpAddress,pp_fbg_sp_Contact,pp_fbg_fathercode,pp_fbg_fathersname,pp_fbg_mothercode,pp_fbg_mothersname"

        SQL &= " FROM hr_person_family_bg WHERE pp_fbg_pp_code = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        Me.tdbViewerFBG.DataSource = MeData
        Me.tdbViewerFBG.Rebind(True)


    End Sub

    Private Sub FBGdataToGrid()
        For Each iControl As Control In FBGformControls
            Try
                iControl.Text = tdbViewerFBG.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception
            End Try
        Next
    End Sub


    Private Sub txtpp_person_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpp_person_code.TextChanged

        If txtpp_person_code.Text.Length > 0 Then
            enableSaveButtons()

            txtPersonNumber.Text = txtpp_person_code.Text
            'txtSysPK_PP
            txtSysPK_PPFBG.Text = txtSysPK_PP.Text



            FBGformControls = clsPPFBG.FormControls

            Try
                getFBGData()
            Catch ex As Exception

            End Try

            If Me.txtSysPK_PP.Text.Length > 0 Then
                clearOtherFields()
                FBGdataToGrid()

                getDependents()
                getEducationBG()
                'getCivilServiceList()
                'getWorkExperienceList()
                'getVoluntaryWork()
                getOtherInfo()
                getReferencePersons()
                'getTrainingPrograms()
                getSkills()

                displayTrainingBG()
                displayVWPBG()
                displayEDUBG()
                displayWEXPBG()
                displayCServiceBG()



            End If
        Else
            disableSaveButtons()
        End If
    End Sub

    

    Private Sub enableSaveButtons()



        btnAddFBG.Enabled = True

        'btnAddCivilService.Enabled = True
        'btnaddDependents.Enabled = True
        btnAddOtherInfo.Enabled = True
        btnAddReference.Enabled = True
        btnAddSkills.Enabled = True
        'btnAddVWork.Enabled = True
        'btnAddTPrograms.Enabled = True
        'btnAddWExp.Enabled = True
    End Sub

    Private Sub disableSaveButtons()
        If txtpp_person_code.Text.Length > 0 Then
            btnAddFBG.Enabled = True
        Else
            btnAddFBG.Enabled = False
        End If

        'btnAddCivilService.Enabled = False
        'btnaddDependents.Enabled = False
        btnAddOtherInfo.Enabled = False
        btnAddReference.Enabled = False
        btnAddSkills.Enabled = False
        'btnAddVWork.Enabled = False
        'btnAddTPrograms.Enabled = False
        'btnAddWExp.Enabled = False
    End Sub


    Private Sub clsPPFBG_ButtonAddClicked() Handles clsPPFBG.addButtonClick
        If txtPersonNumber.Text.Length > 0 Then
            FBGformControls = clsPPFBG.FormControls
            FBGdataToGrid()
        End If
        txtpp_fbg_pp_code.Text = txtpp_person_code.Text
    End Sub

    Private Sub btnaddDependents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddDependents.Click
        If txtDependentName.Text.Length > 0 Then
            Select Case True
                Case RadioButtonOthers.Checked
                    IntegerInputOthers.Value = 0
                Case RadioButton1st.Checked
                    IntegerInputOthers.Value = 1
                Case RadioButton2nd.Checked
                    IntegerInputOthers.Value = 2
                Case RadioButton3rd.Checked
                    IntegerInputOthers.Value = 3
            End Select

            Dim n As Integer = dtgvDependents.Rows.Add()
            dtgvDependents.Rows.Item(n).Cells(0).Value = txtDependentName.Text
            dtgvDependents.Rows.Item(n).Cells(1).Value = Format(DateTimeInput1.Value, "yyyy/MM/dd")
            dtgvDependents.Rows.Item(n).Cells(2).Value = ComboBoxRelationship.Text
            dtgvDependents.Rows.Item(n).Cells(3).Value = IntegerInputOthers.Value

            Dim SQL As String = "INSERT INTO hr_person_dependents(ed_pp_code,ed_seqno,ed_name,ed_relationship,ed_date_of_birth)"
            SQL += " VALUES('" & txtpp_fbg_pp_code.Text & "','" & IntegerInputOthers.Value & "','"
            SQL += txtDependentName.Text & "','" & ComboBoxRelationship.Text & "','" & Format(DateTimeInput1.Value, "yyyy-MM-dd") & "')"

            clsDBConn.Execute(SQL)

        End If
    End Sub

    Private Sub ComboBoxRelationship_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxRelationship.SelectedIndexChanged
        If ComboBoxRelationship.Text = "CHILD" Then
            GroupBoxDependent.Visible = True
        Else
            GroupBoxDependent.Visible = False
        End If
    End Sub

    Private Sub clsPerson_ButtonAddClicked() Handles clsPerson.addButtonClick
        txtpp_firstname.Focus()
    End Sub


    Private Sub txtDependentName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDependentName.TextChanged
        If txtDependentName.Text.Length > 0 Then
            If txtpp_person_code.Text.Length > 0 Then
                btnaddDependents.Enabled = True
            Else
                btnaddDependents.Enabled = False
            End If
        Else
            btnaddDependents.Enabled = False
        End If
    End Sub


    Private Sub getDependents()
        Dim SQL As String = "SELECT ed_pp_code, ed_seqno, ed_name, ed_relationship, ed_date_of_birth"
        SQL &= " FROM hr_person_dependents WHERE ed_pp_code = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        dtgvDependentsDS.DataSource = MeData

        dtgvDependents.Rows.Clear()


        Dim finalItemrowcount As Integer = dtgvDependentsDS.Rows.Count

        For jRows As Integer = 0 To (finalItemrowcount - 1)
            Dim n As Integer = dtgvDependents.Rows.Add()
            dtgvDependents.Rows.Item(n).Cells(0).Value = dtgvDependentsDS.Rows(jRows).Cells(2).Value
            dtgvDependents.Rows.Item(n).Cells(1).Value = dtgvDependentsDS.Rows(jRows).Cells(4).Value
            dtgvDependents.Rows.Item(n).Cells(2).Value = dtgvDependentsDS.Rows(jRows).Cells(3).Value


        Next




    End Sub

    Private Sub dtgvDependents_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvDependents.CellClick
        If e.RowIndex >= 0 Then
            btndeleteDependents.Enabled = True
            ROWSELECT = e.RowIndex
        Else
            btndeleteDependents.Enabled = False
        End If
    End Sub




    Private Sub btndeleteDependents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeleteDependents.Click
        If MessageBox.Show("Are you sure you want to DELETE this record?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Dim name As String = dtgvDependents.Rows(ROWSELECT).Cells(0).Value.ToString

            Dim SQL As String = "DELETE FROM hr_person_dependents where ed_pp_code = '" & Me.txtpp_person_code.Text & "'"
            SQL &= " and ed_name='" & name & "'"

            clsDBConn.Execute(SQL)
            dtgvDependents.Rows.RemoveAt(ROWSELECT)
        End If
    End Sub




    Private Sub getEducationBG()
        Dim SQL As String = "SELECT * from hr_person_educational_bg "
        SQL &= " WHERE education_pp_code = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)

    End Sub

    

    Private Sub getOtherInfo()
        Dim SQL As String = "SELECT otherInfo_pp_code,otherInfo_ans1A,"
        SQL += "otherInfo_desc1A,otherInfo_ans1B,otherInfo_desc1B,otherInfo_ans2A,otherInfo_desc2A,"
        SQL += "otherInfo_ans2B,otherInfo_desc2B,otherInfo_ans3,otherInfo_desc3,otherInfo_ans4,"
        SQL += "otherInfo_descr4,otherInfo_ans5,otherInfo_descr5,otherInfo_ans6A,otherInfo_descr6A,"
        SQL += "otherInfo_ans6B,otherInfo_descr6B,otherInfo_ans6C,otherInfo_descr6C From hr_person_other_info"
        SQL &= " WHERE otherInfo_pp_code  = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)

        dtgvOtherInfoDS.DataSource = MeData
        Try
            If MeData.Rows(0).Item("otherInfo_pp_code").ToString = Me.txtpp_person_code.Text Then
                btnAddOtherInfo.Text = "Update"
            End If

            If MeData.Rows(0).Item("otherInfo_ans1A").ToString = "YES" Then
                rdo1aYes.Checked = True
            Else
                rdo1aYes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans2A").ToString = "YES" Then
                rdo2aYes.Checked = True
            Else
                rdo2aYes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans2B").ToString = "YES" Then
                rdo2bYes.Checked = True
            Else
                rdo2bYes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans3").ToString = "YES" Then
                rdo3Yes.Checked = True
            Else
                rdo3Yes.Checked = False
            End If


            If MeData.Rows(0).Item("otherInfo_ans4").ToString = "YES" Then
                rdo4Yes.Checked = True
            Else
                rdo4Yes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans5").ToString = "YES" Then
                rdo5Yes.Checked = True
            Else
                rdo5Yes.Checked = False
            End If


            If MeData.Rows(0).Item("otherInfo_ans6A").ToString = "YES" Then
                rdo6aYes.Checked = True
            Else
                rdo6aYes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans6B").ToString = "YES" Then
                rdo6bYes.Checked = True
            Else
                rdo6bYes.Checked = False
            End If

            If MeData.Rows(0).Item("otherInfo_ans6C").ToString = "YES" Then
                rdo6cYes.Checked = True
            Else
                rdo6cYes.Checked = False
            End If



            txt1a.Text = MeData.Rows(0).Item("otherInfo_desc1A").ToString
            txt1b.Text = MeData.Rows(0).Item("otherInfo_desc1B").ToString
            txt2a.Text = MeData.Rows(0).Item("otherInfo_desc2A").ToString
            txt2b.Text = MeData.Rows(0).Item("otherInfo_desc2B").ToString
            txt3.Text = MeData.Rows(0).Item("otherInfo_desc3").ToString
            txt4.Text = MeData.Rows(0).Item("otherInfo_descr4").ToString
            txt5.Text = MeData.Rows(0).Item("otherInfo_descr5").ToString
            txt6a.Text = MeData.Rows(0).Item("otherInfo_descr6A").ToString
            txt6b.Text = MeData.Rows(0).Item("otherInfo_descr6B").ToString
            txt6c.Text = MeData.Rows(0).Item("otherInfo_descr6C").ToString



        Catch ex As Exception

        End Try





    End Sub

    Private Sub btnAddOtherInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOtherInfo.Click

        Dim otherInfo_ans1A As String = "NO"
        If rdo1aYes.Checked Then
            otherInfo_ans1A = "YES"
        End If
        Dim otherInfo_desc1A As String = txt1a.Text

        Dim otherInfo_ans1B As String = "NO"
        If rdo1bYes.Checked Then
            otherInfo_ans1B = "YES"
        End If
        Dim otherInfo_desc1B As String = txt1b.Text

        Dim otherInfo_ans2A As String = "NO"
        If rdo2aYes.Checked Then
            otherInfo_ans2A = "YES"
        End If
        Dim otherInfo_desc2A As String = txt2a.Text

        Dim otherInfo_ans2B As String = "NO"
        If rdo2bYes.Checked Then
            otherInfo_ans2B = "YES"
        End If
        Dim otherInfo_desc2B As String = txt2b.Text

        Dim otherInfo_ans3 As String = "NO"
        If rdo3Yes.Checked Then
            otherInfo_ans3 = "YES"
        End If
        Dim otherInfo_desc3 As String = txt3.Text

        Dim otherInfo_ans4 As String = "NO"
        If rdo4Yes.Checked Then
            otherInfo_ans4 = "YES"
        End If
        Dim otherInfo_descr4 As String = txt4.Text

        Dim otherInfo_ans5 As String = "NO"
        If rdo5Yes.Checked Then
            otherInfo_ans5 = "YES"
        End If
        Dim otherInfo_descr5 As String = txt5.Text

        Dim otherInfo_ans6A As String = "NO"
        If rdo6aYes.Checked Then
            otherInfo_ans6A = "YES"
        End If
        Dim otherInfo_descr6A As String = txt6a.Text

        Dim otherInfo_ans6B As String = "NO"
        If rdo6bYes.Checked Then
            otherInfo_ans6B = "YES"
        End If
        Dim otherInfo_descr6B As String = txt6b.Text

        Dim otherInfo_ans6C As String = "NO"
        If rdo6cYes.Checked Then
            otherInfo_ans6C = "YES"
        End If
        Dim otherInfo_descr6C As String = txt6c.Text


        Dim SQL As String = ""
        If btnAddOtherInfo.Text = "Save" Then
            If MessageBox.Show("Are you sure you want to Save record?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                SQL = "INSERT INTO hr_person_other_info(otherInfo_pp_code,otherInfo_ans1A,"
                SQL += "otherInfo_desc1A,otherInfo_ans1B,otherInfo_desc1B,otherInfo_ans2A,otherInfo_desc2A,"
                SQL += "otherInfo_ans2B,otherInfo_desc2B,otherInfo_ans3,otherInfo_desc3,otherInfo_ans4,"
                SQL += "otherInfo_descr4,otherInfo_ans5,otherInfo_descr5,otherInfo_ans6A,otherInfo_descr6A,"
                SQL += "otherInfo_ans6B,otherInfo_descr6B,otherInfo_ans6C,otherInfo_descr6C)"

                'Dim VALUES As String = "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}', '{8}', "
                'VALUES += "'{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}'"
                'VALUES += ", '{20}', '{21}'"


                SQL += String.Format("VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}')" _
                                     , txtpp_person_code.Text, otherInfo_ans1A, otherInfo_desc1A, _
                                     otherInfo_ans1B, otherInfo_desc1B, otherInfo_ans2A, otherInfo_desc2A, _
                                     otherInfo_ans2B, otherInfo_desc2B, otherInfo_ans3, otherInfo_desc3, _
                                     otherInfo_ans4, otherInfo_descr4, otherInfo_ans5, otherInfo_descr5, _
                                     otherInfo_ans6A, otherInfo_descr6A, otherInfo_ans6B, otherInfo_descr6B, _
                                     otherInfo_ans6C, otherInfo_descr6C)
            End If
        ElseIf btnAddOtherInfo.Text = "Update" Then
            If MessageBox.Show("Are you sure you want to Update record?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                SQL = "UPDATE hr_person_other_info SET "

                SQL += String.Format("	otherInfo_ans1A	 ='{0}' , ", otherInfo_ans1A)
                SQL += String.Format("	otherInfo_desc1A	 ='{0}' , ", otherInfo_desc1A)
                SQL += String.Format("	otherInfo_ans1B	 ='{0}' , ", otherInfo_ans1B)
                SQL += String.Format("	otherInfo_desc1B	 ='{0}' , ", otherInfo_desc1B)
                SQL += String.Format("	otherInfo_ans2A	 ='{0}' , ", otherInfo_ans2A)
                SQL += String.Format("	otherInfo_desc2A	 ='{0}' , ", otherInfo_desc2A)
                SQL += String.Format("	otherInfo_ans2B	 ='{0}' , ", otherInfo_ans2B)
                SQL += String.Format("	otherInfo_desc2B	 ='{0}' , ", otherInfo_desc2B)
                SQL += String.Format("	otherInfo_ans3	 ='{0}' , ", otherInfo_ans3)
                SQL += String.Format("	otherInfo_desc3	 ='{0}' , ", otherInfo_desc3)
                SQL += String.Format("	otherInfo_ans4	 ='{0}' , ", otherInfo_ans4)
                SQL += String.Format("	otherInfo_descr4	 ='{0}' , ", otherInfo_descr4)
                SQL += String.Format("	otherInfo_ans5	 ='{0}' , ", otherInfo_ans5)
                SQL += String.Format("	otherInfo_descr5	 ='{0}' , ", otherInfo_descr5)
                SQL += String.Format("	otherInfo_ans6A	 ='{0}' , ", otherInfo_ans6A)
                SQL += String.Format("	otherInfo_descr6A	 ='{0}' , ", otherInfo_descr6A)
                SQL += String.Format("	otherInfo_ans6B	 ='{0}' , ", otherInfo_ans6B)
                SQL += String.Format("	otherInfo_descr6B	 ='{0}' , ", otherInfo_descr6B)
                SQL += String.Format("	otherInfo_ans6C	 ='{0}' , ", otherInfo_ans6C)
                SQL += String.Format("	otherInfo_descr6C	 ='{0}' ", otherInfo_descr6C)




                SQL &= " WHERE otherInfo_pp_code  = '" & Me.txtpp_person_code.Text & "'"
            End If



        End If


        If clsDBConn.Execute(SQL) Then
            If btnAddOtherInfo.Text = "Save" Then
                MsgBox("New Other Information Records has been Saved.")
            Else
                MsgBox("Other Information Records has been Updated.")
            End If
        Else
            MsgBox("Record Save/Update Failed.")
        End If




    End Sub

    Private Sub txtRefName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefName.TextChanged
        If txtRefName.Text.Length > 0 Then
            If txtpp_person_code.Text.Length > 0 Then
                btnAddReference.Enabled = True

            Else
                btnAddReference.Enabled = False
            End If
        End If
    End Sub

    Private Sub getReferencePersons()

        Dim SQL As String = "SELECT ref_pp_code,ref_name,ref_position,ref_address,ref_telno,ref_mobileno,ref_SysNum"
        SQL += " FROM hr_person_reference "
        SQL &= " WHERE ref_pp_code  = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        dtgvReferenceListDS.DataSource = MeData

        dtgvReferenceList.Rows.Clear()


        Dim finalItemrowcount As Integer = dtgvReferenceListDS.Rows.Count

        For jRows As Integer = 0 To (finalItemrowcount - 1)
            Dim n As Integer = dtgvReferenceList.Rows.Add()
            dtgvReferenceList.Rows.Item(n).Cells(0).Value = dtgvReferenceListDS.Rows(jRows).Cells(0).Value
            dtgvReferenceList.Rows.Item(n).Cells(1).Value = dtgvReferenceListDS.Rows(jRows).Cells(1).Value
            dtgvReferenceList.Rows.Item(n).Cells(2).Value = dtgvReferenceListDS.Rows(jRows).Cells(2).Value
            dtgvReferenceList.Rows.Item(n).Cells(3).Value = dtgvReferenceListDS.Rows(jRows).Cells(3).Value
            dtgvReferenceList.Rows.Item(n).Cells(4).Value = dtgvReferenceListDS.Rows(jRows).Cells(4).Value
            dtgvReferenceList.Rows.Item(n).Cells(5).Value = dtgvReferenceListDS.Rows(jRows).Cells(5).Value
            dtgvReferenceList.Rows.Item(n).Cells(6).Value = dtgvReferenceListDS.Rows(jRows).Cells(6).Value



        Next

    End Sub

    Private Sub btnAddReference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReference.Click
        Dim isOK As Boolean = True
        If txtRefName.Text.Length = 0 Then
            isOK = False
        End If

        If Not isOK Then
            MsgBox("Please Fill Blank Fields *")
            Exit Sub
        End If

        txtRefPos.Text = txtRefPos.Text.Replace("'", "`")
        txtRefName.Text = txtRefName.Text.Replace("'", "`")
        txtRefAddress.Text = txtRefAddress.Text.Replace("'", "`")


        Dim n As Integer = dtgvReferenceList.Rows.Add()
        dtgvReferenceList.Rows.Item(n).Cells(1).Value = txtRefName.Text
        dtgvReferenceList.Rows.Item(n).Cells(2).Value = txtRefPos.Text
        dtgvReferenceList.Rows.Item(n).Cells(3).Value = txtRefAddress.Text
        dtgvReferenceList.Rows.Item(n).Cells(4).Value = txtRefTelNo.Text
        dtgvReferenceList.Rows.Item(n).Cells(5).Value = txtRefMobile.Text



        Dim SQL As String = "INSERT INTO hr_person_reference(ref_pp_code,ref_name,ref_position,ref_address,"
        SQL += "ref_telno,ref_mobileno)"


        SQL += String.Format("VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtpp_person_code.Text, _
                             txtRefName.Text, txtRefPos.Text, txtRefAddress.Text, txtRefTelNo.Text, txtRefMobile.Text)



        If clsDBConn.Execute(SQL) Then
            txtRefName.Text = ""
            txtRefPos.Text = ""
            txtRefAddress.Text = ""
            txtRefTelNo.Text = ""
            txtRefMobile.Text = ""
            txtRefName.Focus()
        End If

    End Sub


    

    


    Private Sub getSkills()

        Dim SQL As String = "SELECT skills_pp_code,skills_name,skills_recognition,skills_membership"
        SQL += ",skills_SysNum FROM hr_person_skills "
        SQL &= " WHERE skills_pp_code  = '" & Me.txtpp_person_code.Text & "'"


        Dim MeData As New DataTable
        MeData = clsDBConn.ExecQuery(SQL)
        dtgvSkillsListDS.DataSource = MeData

        dtgvSkillsList.Rows.Clear()


        Dim finalItemrowcount As Integer = dtgvSkillsListDS.Rows.Count

        For jRows As Integer = 0 To (finalItemrowcount - 1)
            Dim n As Integer = dtgvSkillsList.Rows.Add()
            dtgvSkillsList.Rows.Item(n).Cells(0).Value = dtgvSkillsListDS.Rows(jRows).Cells(0).Value
            dtgvSkillsList.Rows.Item(n).Cells(1).Value = dtgvSkillsListDS.Rows(jRows).Cells(1).Value
            dtgvSkillsList.Rows.Item(n).Cells(2).Value = dtgvSkillsListDS.Rows(jRows).Cells(2).Value
            dtgvSkillsList.Rows.Item(n).Cells(3).Value = dtgvSkillsListDS.Rows(jRows).Cells(3).Value
            dtgvSkillsList.Rows.Item(n).Cells(4).Value = dtgvSkillsListDS.Rows(jRows).Cells(4).Value




        Next

    End Sub



    Private Sub txtSkillsName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSkillsName.TextChanged
        If txtSkillsName.Text.Length > 0 Then
            If txtpp_person_code.Text.Length > 0 Then
                btnAddSkills.Enabled = True
            Else
                btnAddSkills.Enabled = False
            End If
        Else
            btnAddSkills.Enabled = False
        End If
    End Sub


    Private Sub btnAddSkills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSkills.Click
        Dim isOK As Boolean = True
        If txtSkillsName.Text.Length = 0 Then
            isOK = False

        End If

        If Not isOK Then
            MsgBox("Please Fill Blank Fields *")
            Exit Sub
        End If


        Dim n As Integer = dtgvSkillsList.Rows.Add()
        dtgvSkillsList.Rows.Item(n).Cells(1).Value = txtSkillsName.Text
        dtgvSkillsList.Rows.Item(n).Cells(2).Value = txtSkillsRecognition.Text
        dtgvSkillsList.Rows.Item(n).Cells(3).Value = txtSkillsMembership.Text



        Dim SQL As String = "INSERT INTO hr_person_skills(skills_pp_code,skills_name,skills_recognition,skills_membership)"
        SQL += String.Format("VALUES('{0}', '{1}', '{2}', '{3}')", txtpp_person_code.Text, _
                             txtSkillsName.Text, txtSkillsRecognition.Text, txtSkillsMembership.Text)


        If clsDBConn.Execute(SQL) Then
            txtSkillsName.Text = ""
            txtSkillsRecognition.Text = ""
            txtSkillsMembership.Text = ""
        End If
    End Sub

    Private Sub clearEducationalBG()
        txteducation_level.Text = ""
        txteducation_School.Text = ""
        txteducation_DegreeCourse.Text = ""
        txteducation_grades.Text = ""
        txteducation_honors_etc.Text = ""
        txteducation_yearGraduated.Text = ""
        txteducation_date_from.Text = ""
        txteducation_date_to.Text = ""


    End Sub

    

    


    

    Private Sub clearOtherInfo()
        txt1a.Text = ""
        txt2a.Text = ""
        txt2b.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6a.Text = ""
        txt6b.Text = ""
        txt6c.Text = ""


        rdo1aNo.Checked = True
        rdo1bNo.Checked = True

        rdo2aNo.Checked = True
        rdo2bNo.Checked = True

        rdo3No.Checked = True
        rdo4No.Checked = True

        rdo5No.Checked = True

        rdo6aNo.Checked = True
        rdo6bNo.Checked = True
        rdo6cNo.Checked = True

    End Sub

    Private Sub clearReferences()
        txtRefName.Text = ""
        txtRefPos.Text = ""
        txtRefAddress.Text = ""
        txtRefTelNo.Text = ""
        txtRefMobile.Text = ""

        Try
            dtgvReferenceList.Rows.Clear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub clearSkills()
        txtSkillsName.Text = ""
        txtSkillsRecognition.Text = ""
        txtSkillsMembership.Text = ""
        Try
            dtgvSkillsList.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub clearOtherFields()
        clearEducationalBG()
        'clearCivilService()
        'clearVoluntaryWork()
        clearOtherInfo()
        clearReferences()
        clearSkills()
        'clearTrainingPrograms()
        'clearWorkExperience()
    End Sub


    Private Sub dtgvReferenceList_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvReferenceList.CellContentClick
        If e.RowIndex >= 0 Then
            btnDelReference.Enabled = True
            ROWSELECT = e.RowIndex
        Else
            btnDelReference.Enabled = False
        End If
    End Sub

    Private Sub btnDelReference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelReference.Click
        If MessageBox.Show("Are you sure you want to DELETE this Person Reference?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Dim edCode As String = dtgvReferenceList.Rows(ROWSELECT).Cells(6).Value.ToString

            Dim SQL As String = "DELETE FROM hr_person_reference where ref_SysNum = '" & edCode & "'"


            If clsDBConn.Execute(SQL) Then
                dtgvReferenceList.Rows.RemoveAt(ROWSELECT)
                btnDelReference.Enabled = False
            End If

        End If
    End Sub

    Private Sub dtgvSkillsList_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvSkillsList.CellContentClick
        If e.RowIndex >= 0 Then
            btnDelSkills.Enabled = True
            ROWSELECT = e.RowIndex
        Else
            btnDelSkills.Enabled = False
        End If
    End Sub

    Private Sub btnDelSkills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelSkills.Click
        If MessageBox.Show("Are you sure you want to DELETE this Skills?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Dim edCode As String = dtgvSkillsList.Rows(ROWSELECT).Cells(4).Value.ToString

            Dim SQL As String = "DELETE FROM hr_person_skills where skills_SysNum = '" & edCode & "'"


            If clsDBConn.Execute(SQL) Then
                dtgvSkillsList.Rows.RemoveAt(ROWSELECT)
                btnDelSkills.Enabled = False
            End If

        End If
    End Sub

    
    Private Sub btnAddFBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFBG.Click
        btnSaveFBG.Enabled = True
    End Sub


    Private Sub tdbEduViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbEduViewer.DoubleClick
        Me.EDUGridToTextboxes()
    End Sub


    Private Sub tdbEduViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbEduViewer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If tdbEduViewer.RowCount > 0 Then
                Me.EDUGridToTextboxes()
            End If
        End If
    End Sub

    Private Sub EDUGridToTextboxes()
        For Each iControl As Control In clsEDUBG.FormControls
            iControl.Text = tdbEduViewer.Columns(iControl.Name.Replace("txt", "")).Text
        Next
    End Sub


    Private Sub clsEDUBG_addButtonClick() Handles clsEDUBG.addButtonClick
        btnSaveEdu.Enabled = True
    End Sub

    Private Sub txtSysPK_EDBG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_EDBG.TextChanged
        If txtSysPK_EDBG.Text.Length > 0 Then
            Me.btnDeleteEDU.Enabled = True
        Else
            Me.btnDeleteEDU.Enabled = False
        End If
    End Sub

    Private Sub clsEDUBG_afterDelete() Handles clsEDUBG.afterDelete
        displayEDUBG()
    End Sub

    Private Sub clsEDUBG_AfterRecordSave() Handles clsEDUBG.AfterRecordSave
        displayEDUBG()
    End Sub

    Private Sub clsEDUBG_BeforeRecordSave() Handles clsEDUBG.BeforeRecordSave
        Me.txteducation_pp_code.Text = Me.txtpp_person_code.Text
    End Sub


    Private Sub CServiceGridToTextboxes()
        For Each iControl As Control In clsCService.FormControls
            iControl.Text = tdbCServiceViewer.Columns(iControl.Name.Replace("txt", "")).Text
        Next
    End Sub


    Private Sub tdbCServiceViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbCServiceViewer.DoubleClick
        Me.CServiceGridToTextboxes()
    End Sub

    Private Sub txtSysPK_eligibility_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_eligibility.TextChanged
        If txtSysPK_eligibility.Text.Length > 0 Then
            Me.btnCServiceDel.Enabled = True
        Else
            Me.btnCServiceDel.Enabled = False
        End If
    End Sub

    Private Sub clsCService_addButtonClick() Handles clsCService.addButtonClick
        btnCServiceSave.Enabled = True
        txteligibility_career.Focus()
    End Sub


    Private Sub clsCService_afterDelete() Handles clsCService.afterDelete
        displayCServiceBG()
    End Sub

    Private Sub clsCService_AfterRecordSave() Handles clsCService.AfterRecordSave
        Me.displayCServiceBG()
    End Sub

    Private Sub clsCService_BeforeRecordSave() Handles clsCService.BeforeRecordSave
        Me.txteligibility_pp_code.Text = Me.txtpp_person_code.Text
    End Sub

   

    Private Sub WEXPGridToTextboxes()
        For Each iControl As Control In clsWorkEXP.FormControls
            Try
                iControl.Text = tdbWEXPViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception

            End Try

        Next
    End Sub

    Private Sub tdbWEXPViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbWEXPViewer.DoubleClick
        Me.WEXPGridToTextboxes()
    End Sub


    Private Sub txtSysPK_work_xp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_work_xp.TextChanged
        If txtSysPK_work_xp.Text.Length > 0 Then
            Me.btnWEXPDel.Enabled = True
        Else
            Me.btnWEXPDel.Enabled = False
        End If
    End Sub

    Private Sub clsWorkEXP_addButtonClick() Handles clsWorkEXP.addButtonClick
        btnWEXPSave.Enabled = True
        txtwexp_dateFrom.Focus()
    End Sub

    Private Sub clsWorkEXP_afterDelete() Handles clsWorkEXP.afterDelete
        Me.displayWEXPBG()
    End Sub

    Private Sub clsWorkEXP_AfterRecordSave() Handles clsWorkEXP.AfterRecordSave
        Me.displayWEXPBG()
    End Sub

    Private Sub clsWorkEXP_BeforeRecordSave() Handles clsWorkEXP.BeforeRecordSave
        Me.txtwexp_pp_code.Text = Me.txtpp_person_code.Text
    End Sub


    Private Sub VWorkGridToTextboxes()
        For Each iControl As Control In clsVWork.FormControls
            Try
                iControl.Text = tdbVWorkViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception

            End Try

        Next
    End Sub


    Private Sub tdbVWorkViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbVWorkViewer.DoubleClick
        Me.VWorkGridToTextboxes()
    End Sub

    Private Sub txtSysPK_VWork_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_VWork.TextChanged
        If txtSysPK_VWork.Text.Length > 0 Then
            Me.btnVWorkDel.Enabled = True
        Else
            Me.btnVWorkDel.Enabled = False
        End If
    End Sub

    Private Sub clsVWork_addButtonClick() Handles clsVWork.addButtonClick
        btnVWorkSave.Enabled = True
        txtvoluntary_dateFrom.Focus()
    End Sub

    Private Sub clsVWork_afterDelete() Handles clsVWork.afterDelete
        Me.displayVWPBG()
    End Sub

    Private Sub clsVWork_AfterRecordSave() Handles clsVWork.AfterRecordSave
        Me.displayVWPBG()
    End Sub

    Private Sub clsVWork_BeforeRecordSave() Handles clsVWork.BeforeRecordSave
        Me.txtvoluntary_ppcode.Text = Me.txtpp_person_code.Text
    End Sub


    
    Private Sub TrainingGridToTextboxes()
        For Each iControl As Control In clsTraining.FormControls
            Try
                iControl.Text = tdbTrainingViewer.Columns(iControl.Name.Replace("txt", "")).Text
            Catch ex As Exception

            End Try

        Next
    End Sub


    Private Sub tdbTrainingViewer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbTrainingViewer.DoubleClick
        Me.TrainingGridToTextboxes()
    End Sub

    Private Sub txtSysPK_training_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_training.TextChanged
        If txtSysPK_training.Text.Length > 0 Then
            Me.btnTrainingDelete.Enabled = True
        Else
            Me.btnTrainingDelete.Enabled = False
        End If
    End Sub


    Private Sub clsTraining_addButtonClick() Handles clsTraining.addButtonClick
        btnTrainingSave.Enabled = True
    End Sub

    Private Sub clsTraining_afterDelete() Handles clsTraining.afterDelete
        Me.displayTrainingBG()
    End Sub

    Private Sub clsTraining_AfterRecordSave() Handles clsTraining.AfterRecordSave
        Me.displayTrainingBG()
    End Sub

    Private Sub clsTraining_BeforeRecordSave() Handles clsTraining.BeforeRecordSave
        Me.txttraining_pp_code.Text = Me.txtpp_person_code.Text
    End Sub

    Private Sub txtSysPK_PPFBG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSysPK_PPFBG.TextChanged
        If txtSysPK_PPFBG.Text.Length > 0 Then
            btnAddFBG.Text = "Update"
        Else
            btnAddFBG.Text = "Add"
        End If
    End Sub

End Class