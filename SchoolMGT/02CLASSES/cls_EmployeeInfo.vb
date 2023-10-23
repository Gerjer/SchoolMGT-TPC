
Imports MySql.Data.MySqlClient

Public Class cls_EmployeeInfo

    ' PERSON PROFILE INFO
    Private p_profile_number As Integer
    Private p_emp_lname As String
    Private p_emp_fname As String
    Private p_emp_mname As String


    ' EMPLOYEE INFO
    Private p_emp_number As Integer
    Private p_emp_ID As String
    Private p_emp_status As String
    Private p_emp_position As Short
    Private p_emp_datehired As Date


    ' user info

    Private p_user_name As String
    Private p_user_password As String
    Private p_user_permission As Integer
    Private p_user_description As String



#Region "Properties"

    Public WriteOnly Property personProfileNo() As Integer
        Set(ByVal value As Integer)
            p_profile_number = value
        End Set
    End Property

    Public WriteOnly Property employeeID() As String
        Set(ByVal value As String)
            p_emp_ID = value
        End Set
    End Property

    Public WriteOnly Property dateHired() As Date
        Set(ByVal value As Date)
            p_emp_datehired = value
        End Set
    End Property

    ' employment info
    Public WriteOnly Property employmentStatus() As String
        Set(ByVal value As String)
            p_emp_status = value
        End Set
    End Property


    ' User
    Public WriteOnly Property userName() As String
        Set(ByVal value As String)
            p_user_name = value
        End Set
    End Property

    Public WriteOnly Property userPassword() As String
        Set(ByVal value As String)
            p_user_password = value
        End Set
    End Property

    Public WriteOnly Property empNumber() As Integer
        Set(ByVal value As Integer)
            p_emp_number = value
        End Set
    End Property


#End Region


    Public Function getAllPersonProfile(ByVal lname As String, Optional ByVal fname As String = "", Optional ByVal mname As String = "") As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call display_personProfile_lname_fname_mname ('" & lname & "%" & "','" & fname & "%" & "','" & mname & "%" & "')"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()


    End Function

    Public Function getAllPersonName() As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call getAllPersonName()"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()


    End Function

    Public Function getEmployeeCount() As Integer
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim count As Integer = 0
        Dim exec As String
        exec = "select count(emp_number) from hr_employee"

        Dim cmd As New MySqlCommand(exec, cn)

        Dim myReader As MySqlDataReader
        myReader = cmd.ExecuteReader

        If Not myReader.HasRows Then

            count = 0
        Else
            While myReader.Read()
                count = myReader(0)
            End While
        End If
        cn.Close()


        Return count

    End Function

    Public Function saveEmployeeInformation() As Boolean

        Dim SQL As String = " SELECT max(emp_number) as UserPK FROM hr_employee"

        Dim MeData As New DataTable
        Dim UserPK As String = ""
        Try
            MeData = clsDBConn.ExecQuery(SQL)
            UserPK = MeData.Rows(0).Item("UserPK").ToString

            If Val(UserPK) > 0 Then
                UserPK = Val(UserPK) + 1
                UserPK = Format(Val(UserPK), "000000")
            Else
                UserPK = "000001"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        Dim exec As String = "INSERT into hr_employee(emp_number, person_profile_no, employee_id, joined_date, emp_status) VALUES('" & _
                             p_profile_number & "','" & p_profile_number & "','" & p_emp_ID & "','" & Format(p_emp_datehired, "yyyy-MM-dd") & "' ,'" & _
                             p_emp_status & "')"


        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data has been saved!")
            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function

    Public Function saveEmployeeShift(ByVal EightToFive As Boolean) As Boolean
        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        Dim exec As String = ""

        If EightToFive Then
            Dim timeIn As Double = 8.0
            Dim timeOut As Double = 5.01
            exec = "INSERT into hr_emp_shift(emp_number, timeIn, timeOut) VALUES('" & _
                             p_emp_number & "','" & timeIn & "','" & timeOut & "')"
        Else
            Dim timeIn As Double = 7.0
            Dim timeOut As Double = 4.01
            exec = "INSERT into hr_emp_shift(emp_number, timeIn, timeOut) VALUES('" & _
                             p_emp_number & "','" & timeIn & "','" & timeOut & "')"
        End If
        
        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("Data has been saved!")
            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function


    Public Function getAllEmployeeListsActive() As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call display_employee_list"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()
    End Function

    Public Function getAllEmployeeListsInActive() As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call display_employee_list_inactive"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()
    End Function

    Public Function getAllEmployeeNameID() As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call display_employee_name_id"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()
    End Function



    Public Function getEmp_DTR_by_Date(ByVal empNumber As Integer, ByVal dateFrom As Date, ByVal dateTo As Date) As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = "call display_emp_dtr('" & empNumber & "','" & Format(dateFrom, "yyyy-MM-dd") & "','" & _
                                     Format(dateTo, "yyyy-MM-dd") & "')"
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("cust_accnt")

        SA.Fill(DS, "cust_accnt")

        Return DS.Tables("cust_accnt")

        cn.Close()
    End Function

    Public Function insertEmployeePicture(ByVal pempNumber As Integer, ByVal picturePath As String) As Boolean

        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        picturePath = picturePath.Replace("\", "/")

        Dim exec As String = "insert into hr_emp_picture(emp_number, epic_filename) values('" & pempNumber & _
                             "','" & picturePath & "')"


        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()

            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function

    Public Function updateEmployeePicture(ByVal pempNumber As Integer, ByVal picturePath As String) As Boolean

        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        picturePath = picturePath.Replace("\", "/")

        Dim exec As String = "update hr_emp_picture set epic_filename='" & picturePath & "' where emp_number ='" & pempNumber & "'"


        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()

            retval = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return retval

    End Function
    
    Public Function deleteEmployeeAccount(ByVal pempNumber As Integer) As Boolean
        Dim SQL As String = "UPDATE hr_employee set record_status='DISABLED' WHERE emp_number='" & pempNumber & "'"

        If clsDBConn.Execute(SQL) Then
            Return True
        Else
            Return False
        End If


    End Function



End Class
