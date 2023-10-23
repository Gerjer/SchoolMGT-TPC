Imports System.IO
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.XRPictureBox
Imports DevExpress.XtraTabbedMdi
Imports MySql.Data.MySqlClient
'Imports System.Drawing.Bitmap
Imports System.Drawing.Drawing2D
Imports System.Security
Module modCommon

    Public report_dt_payables As DataTable
    Public report_dt_fees As DataTable
    Public report_dt_SOA As DataTable
    Public report_dt_StudentsPayment As DataTable

    Public WorkGroup As String = ""
    Public DepartmentName As String = ""
    Public DepartmentTo As String = ""
    Public Criteria As String = ""
    Public AuthUserName As String = ""
    Public SALT As String = ""
    Public LoginUserID As String = ""
    Public AuthUserType As String = ""
    Public FullUserName As String = ""

    Public COMPANY_NAME As String = ""
    Public COMPANY_ADDRESS As String = ""
    Public COMPANY_DESCRIPTION_NAME As String = ""
    Public COMPANY_TEL_NUMBER As String = ""
    Public COMPANY_MOBILE_NUMBER As String = ""
    Public COMPANY_FAX_NUMBER As String = ""
    Public COMPANY_EMAIL_ADDRESS As String = ""
    Public COMPANY_IMAGE As Image
    Public COMPANY_IMAGE1 As XRPictureBox
    Public COMPANY_IMAGE_HEADER As Image
    Public COMPANY_LOGO As Byte()
    Public COMPANY_HEADER As Byte()
    Public COMPANY_LOGO_PATH As String = ""
    Public COMPANY_HEADER_PATH As String = ""


    Public DAILY_TRANSACTION_SYSPK As String = ""

    Public report_summarized_balance As DataTable

    Public EMPLOYEE_ID As String = ""
    Public PERSON_ID As Integer = 0

    Public Title As AssemblyLoadEventArgs
    Public Barangay As DataTable
    Public MuncipalityCity As DataTable
    Public Province As DataTable

    Public AppSetup_Domain As Integer

    Public DefautltPic As String = My.Application.Info.DirectoryPath & "\user-blue.png" '"F:\GergerFiles\SourceCode\SchoolMgt\school_management\SCHOOL MANAGEMENT\user-blue.png" ' My.Application.Info.DirectoryPath & "\ICONS\noprofile.jpg"
    Public DefaultLogInPic As String = My.Application.Info.DirectoryPath & "\schoolmanagment.jpg"
    Public DefaultHeaderPic As String = My.Application.Info.DirectoryPath & "\arkant_bg_black.jpg"

    Public ServerPath As String = "" '"\\192.168.1.181\d\BST FILES\Application"
    Public ServerPath_PCName As String = ""
    Public ServerPath_UserName As String = ""
    Public ServerPath_Password As String = ""
    Public ServerPath_Directory As String = ""

    Private ReadOnly borderColor As Color = Color.Black
    Dim grpBoxName As String = ""

    Public _Dir As Directory
    Public _RootDirectory As String = ""

    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream
    Public personID_image As Integer
    Public Privilege_TypeUser As String = ""
    Public MenuItemID As Integer

    Public copyrigth As String = "Copyright ©️ 2020 ®Ger2x™, All rigths reserved."

    Public _courseID As Integer
    Public _batchID As Integer
    Public _studentID As Integer

    Public SavingDir As String = ""
    Public finance_tran_id As Integer
    Public OPERATION As String = ""

    Public GRADUATED_STUDENT_ID As Integer
    Public CLASS_ROLL_NO As String
    Public FUNCTION_TYPE As String = ""


    Public Function SavingDirectory()

        SavingDir = DataObject(String.Format("SELECT _saving_dir.`name` FROM _saving_dir"))

        Return Nothing
    End Function

    Public Function CreatNewDirectory_XtraReport(Root_Directory As String, FolderName As String) As String
        Dim new_directory As String = Root_Directory

        If (Not System.IO.Directory.Exists(System.IO.Path.Combine(new_directory, FolderName))) Then
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(new_directory, FolderName))
        End If

        new_directory = new_directory & "\" & FolderName & "\"

        Return new_directory
    End Function


    Public Sub CleanAllControls(frm As Form)

        Dim textboxes = GetAllControls(frm).OfType(Of TextBox)().ToList()
        For Each item As TextBox In textboxes
            item.Text = Nothing
        Next

        Dim NumericUpDown = GetAllControls(frm).OfType(Of NumericUpDown)().ToList()
        For Each item As NumericUpDown In NumericUpDown
            item.Value = 0
        Next

        Dim combobox = GetAllControls(frm).OfType(Of ComboBox)().ToList()
        For Each item As ComboBox In combobox
            item.SelectedIndex = -1
        Next

        Dim datetimepicker = GetAllControls(frm).OfType(Of DateTimePicker)().ToList()
        For Each item As DateTimePicker In datetimepicker
            item.Value = Date.Now
        Next

        Dim checkbox = GetAllControls(frm).OfType(Of CheckBox)().ToList()
        For Each item As CheckBox In checkbox
            If item.Tag IsNot Nothing Then
                item.Checked = False
            End If
        Next

    End Sub

    Private Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function

    Public Function MyMessageBox(Operation As String)
        If Operation = "EDIT" Then
            MessageBox.Show("Record Updated...", "Successfully!")
        Else
            MessageBox.Show("Record Save...", "Successfully!")
        End If
    End Function

    Public Function FormatDate(_date As Date) As String
        Dim FormatedDate As String = ""
        FormatedDate = Format(_date.Date, "yyyy-MM-dd")
        Return FormatedDate
    End Function

    Public Function ReplaceMe(name1 As String, name2 As String) As String
        Dim NewStr As String = ""
        NewStr = name2
        Return NewStr
    End Function


    Public Sub SaveImage_ServerDirectory(Optional photo_path As String = Nothing, Optional image As Image = Nothing, Optional FolderNme As String = Nothing, Optional FileName As String = Nothing)
        MsgBox("Save to SQL database")
        If Not File.Exists(photo_path) Then
            MsgBox("TRUE...Save to SQL database")
            image.Save(photo_path)
        Else
            image.Save(photo_path)
            MsgBox("FALSE...Save to SQL database")
        End If


#Region "old"
        'Dim NewPath As String = ""
        'Dim ServerDirectory As New DataTable
        'ServerDirectory = DataSource(String.Format("SELECT server_path,`directory` FROM server_path WHERE application_setup_id = '" & AppSetup_Domain & "'"))

        'If ServerDirectory.Rows.Count > 0 Then

        '    NewPath = ServerDirectory(0)("server_path") & ServerDirectory(0)("directory") & "PIC\"

        '    If (Not System.IO.Directory.Exists(Path.Combine(NewPath, FolderNme))) Then
        '        System.IO.Directory.CreateDirectory(Path.Combine(NewPath, FolderNme))
        '    End If

        '    NewPath = NewPath & FolderNme & "\\"

        '    Try
        '        '        CopyDirectory(sourcepath, DestPath)
        '        '    System.IO.File.Copy(photo_path, NewPath, True)
        '        '                    String FileName = Path.GetFileName(strfilename);
        '        'System.IO.File.Copy(strfilename, "\\\\Admin-PC\\Upload\\" + FileName);
        '        'Using bmp As New Bitmap(image) '_view.box_picture.Image 'Picture_Box.Image)
        '        '    bmp.Save(photo_path, System.Drawing.Imaging.ImageFormat.Jpeg)
        '        'End Using

        '    Catch ex As Exception
        '        MessageBox.Show("An error occurred:" & vbCrLf & vbCrLf &
        '                ex.Message, "Error Saving Image File",
        '                MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '    End Try

        'End If
#End Region


    End Sub

    Public Sub SaveImage_Global(personID As Integer, image_type As String, description As String, photo_path As String, file_name As String)



        '"TRUNCATE TABLE file "
        DataSource(String.Format("DELETE FROM images WHERE person_id = '" & personID & "' AND image_type = '" & image_type & "' AND description = '" & description & "'"))

        If clsDBConn.ServerName = "localhost" Then
            Try
                fs = New FileStream(photo_path, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                rawData = New Byte(FileSize) {}
                fs.Read(rawData, 0, FileSize)
                fs.Close()


                Dim SqlString = "INSERT INTO images VALUES(NULL,?person_id, ?image_type, ?image_path ,?description, ?file_name, ?file_format ,?file_size, ?file)"

                Dim con As New MySqlConnection
                Dim cmd As New MySqlCommand

                con.ConnectionString = clsDBConn.Connection.ConnectionString
                cmd.Connection = con
                con.Open()

                cmd.Connection = con
                cmd.CommandText = SqlString
                cmd.Parameters.AddWithValue("?person_id", personID)
                cmd.Parameters.AddWithValue("?image_type", image_type)
                cmd.Parameters.AddWithValue("?image_path", photo_path)
                cmd.Parameters.AddWithValue("?description", description)
                cmd.Parameters.AddWithValue("?file_name", file_name)
                cmd.Parameters.AddWithValue("?file_format", ".jpg")
                cmd.Parameters.AddWithValue("?file_size", FileSize)
                cmd.Parameters.AddWithValue("?file", rawData)

                cmd.ExecuteNonQuery()



            Catch ex As Exception
                MessageBox.Show("There was an error: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else

            DataSource(String.Format("INSERT INTO `images`
            (
             `person_id`,
             `image_type`,
             `image_path`,
             `description`,
             `file_name`           
             )
	    VALUES (
		    '" & personID & "',
		    '" & image_type & "',
		    '" & photo_path & "',
		    '" & description & "',
		   '" & file_name & "'
		    );"))


        End If

    End Sub

    Public Function LoadImage_Global(personID As Integer, image_type As String, description As String, photo_path As String, file_name As String) As MemoryStream

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim myData As MySqlDataReader = Nothing


        Try
            con.ConnectionString = clsDBConn.Connection.ConnectionString
            cmd.Connection = con
            con.Open()
        Catch ex As Exception

        End Try

        Try

            cmd.CommandText = "SELECT * FROM images WHERE person_id = '" & personID & "' AND image_type = '" & image_type & "'  "

            myData = cmd.ExecuteReader()


            If Not myData.HasRows Then
                myData.Close()
                Exit Function
            End If

            myData.Read()

            Dim imagebytes As Byte() = CType(myData("file"), Byte())
            Dim ms As New System.IO.MemoryStream(imagebytes)
            Return ms
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Function


    Public Function GetCurrentAge(value As Date) As String
        Dim age As Integer
        age = Today.Year - value.Year
        If (value > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Public Function getServerPath()
        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                                        server_path.server_path,
                                        server_path.`directory`,
                                        server_path.workgroup_pcname,
                                        server_path.usernname,
                                        server_path.pass_word
                                        FROM
                                        server_path
                                        WHERE
                                        server_path.application_setup_id = '" & AppSetup_Domain & "'
                                "))
        If dt.Rows.Count > 0 Then
            ServerPath = If(IsDBNull(dt(0)("server_path")), "", dt(0)("server_path"))
            ServerPath_Directory = If(IsDBNull(dt(0)("directory")), "", dt(0)("directory")) 'dt(0)("directory")
            ServerPath_PCName = If(IsDBNull(dt(0)("workgroup_pcname")), "", dt(0)("workgroup_pcname")) 'dt(0)("workgroup_pcname")
            ServerPath_UserName = If(IsDBNull(dt(0)("usernname")), "", dt(0)("usernname")) 'dt(0)("usernname")
            ServerPath_Password = If(IsDBNull(dt(0)("pass_word")), "", dt(0)("pass_word"))  'dt(0)("password")
        End If

    End Function

    Public Function getOrganizationDetails() As Object

        Dim dt As New DataTable
        dt = DataSource("SELECT
                      `file_id`,
                      `file`,
                      `file_name`,   
                      `hdr_file`,
                      `hdr_file_name`,
                      `company_name`,
                      `description_name`,
                      `address`,
                      `contactnum`,
                      `mobilenum`,
                      `faxnum`,
                      `emailaddress`
                    FROM `file`
                    ")

        COMPANY_NAME = If(IsDBNull(dt(0)("company_name").ToString), "", dt(0)("company_name").ToString)
        COMPANY_DESCRIPTION_NAME = If(IsDBNull(dt(0)("description_name").ToString), "", dt(0)("description_name").ToString)
        COMPANY_ADDRESS = If(IsDBNull(dt(0)("address").ToString), "", dt(0)("address").ToString)
        COMPANY_TEL_NUMBER = If(IsDBNull(dt(0)("contactnum").ToString), "", dt(0)("contactnum").ToString)
        COMPANY_MOBILE_NUMBER = If(IsDBNull(dt(0)("mobilenum").ToString), "", dt(0)("mobilenum").ToString)
        COMPANY_FAX_NUMBER = If(IsDBNull(dt(0)("faxnum").ToString), "", dt(0)("faxnum").ToString)
        COMPANY_EMAIL_ADDRESS = If(IsDBNull(dt(0)("emailaddress").ToString), "", dt(0)("emailaddress").ToString)

        COMPANY_LOGO_PATH = If(IsDBNull(dt(0)("file_name").ToString), "", dt(0)("file_name").ToString)
        COMPANY_LOGO_PATH = My.Application.Info.DirectoryPath & COMPANY_LOGO_PATH
        COMPANY_HEADER_PATH = If(IsDBNull(dt(0)("hdr_file_name").ToString), "", dt(0)("hdr_file_name").ToString)
        COMPANY_HEADER_PATH = My.Application.Info.DirectoryPath & COMPANY_HEADER_PATH

        Dim imageData As Byte() = DirectCast(dt(0)("file"), Byte())
        COMPANY_LOGO = imageData
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                COMPANY_IMAGE = Image.FromStream(ms, True)
            End Using
        End If

        Dim imageData_hdr As Byte() = DirectCast(dt(0)("hdr_file"), Byte())
        COMPANY_HEADER = imageData_hdr
        If Not imageData_hdr Is Nothing Then
            Using ms As New MemoryStream(imageData_hdr, 0, imageData_hdr.Length)
                ms.Write(imageData_hdr, 0, imageData_hdr.Length)
                COMPANY_IMAGE_HEADER = Image.FromStream(ms, True)
            End Using
        End If



        Return Nothing
    End Function

    'Public Function GroupBoxPaint(sender As Object, e As PaintEventArgs)

    '    Dim grpBox As GroupBox = DirectCast(sender, GroupBox)

    '    If grpBox.Text <> grpBoxName Then
    '        grpBoxName = grpBox.Text

    '        Dim tSize As Size = TextRenderer.MeasureText(grpBox.Text, grpBox.Font)
    '        Dim borderRect As Rectangle = e.ClipRectangle
    '        borderRect.Y = (borderRect.Y _
    '                    + (tSize.Height / 2))
    '        borderRect.Height = (borderRect.Height _
    '                    - (tSize.Height / 2))
    '        ControlPaint.DrawBorder(e.Graphics, borderRect, borderColor, ButtonBorderStyle.Solid)
    '        Dim textRect As Rectangle = e.ClipRectangle
    '        textRect.X = (textRect.X + 6)
    '        textRect.Width = tSize.Width
    '        textRect.Height = tSize.Height
    '        e.Graphics.FillRectangle(New SolidBrush(grpBox.BackColor), textRect)
    '        e.Graphics.DrawString(grpBox.Text, grpBox.Font, New SolidBrush(grpBox.ForeColor), textRect)
    '    End If


    'End Function



    Public Function getPersonID() As Object
        Dim id As Integer = DataObject(String.Format("SELECT IFNULL(MAX(`person_id`)+1,1) FROM `person`"))
        Return id
    End Function
    Public Function brgy()
        Barangay = DataSource(String.Format("SELECT
                      `id`          AS 'iD',
                      `brgyDesc`    AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refbrgy`
                    WHERE `EndTime` IS NULL
                        AND `Status_TypeID` = 2 LIMIT 100
                    "))
        Return Nothing
    End Function

    Public Function mncplityCity()
        MuncipalityCity = DataSource(String.Format("SELECT
                      `id` AS 'ID',
                      `citymunDesc` AS 'Name',
                      `provCode`,
                      `citymunCode`
                    FROM `refcitymun`
                  ;"))
        Return Nothing
    End Function

    Public Function prvnce()
        Province = DataSource(String.Format("SELECT 
                DISTINCT `refprovince`.`id` AS 'ID'
                , `refprovince`.`provDesc` AS 'Name'
                ,`refprovince`.`provCode`
             FROM
                `refprovince`
                ORDER BY `provDesc`"))
        Return Nothing
    End Function
    Public Function mysqlDateTime(ByVal DateTime As Date) As String
        Dim mysqlDate As String = ""
        If InStr(DateTime, "PM") <> 0 Then
            mysqlDate = String.Format("{0} {1}:{2}:{3}", Format(Now.Date, "yyyy-MM-dd"), Hour(Now), Minute(Now), Second(Now))
        Else
            mysqlDate = Format(Now, "yyyy-MM-dd hh:mm:ss")
        End If
        Return mysqlDate


    End Function

    Public Sub ProcessFilterText(ByRef MeData As DataTable, ByRef TDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim StrBuilder As New System.Text.StringBuilder()
        Dim ColData As C1.Win.C1TrueDBGrid.C1DataColumn

        For Each ColData In TDBGrid.Columns
            Application.DoEvents()
            If ColData.FilterText.Length > 0 Then
                If StrBuilder.Length > 0 Then
                    StrBuilder.Append(" AND ")
                End If

                Select Case True
                    Case InStr(ColData.FilterText.ToUpper, "UNTIL") <> 0
                        Dim getFilter() As String = Split(UCase(ColData.FilterText), "UNTIL")
                        If UBound(getFilter) > 0 Then
                            StrBuilder.Append((ColData.DataField & " >= '" & getFilter(0) & "' AND " & ColData.DataField & " <= '" & getFilter(1) & "'"))
                        End If
                    Case InStr(ColData.FilterText.ToUpper, "<") <> 0
                        StrBuilder.Append((ColData.DataField & " < " & ColData.FilterText.Replace("<", "")))
                    Case InStr(ColData.FilterText.ToUpper, "<=") <> 0
                        StrBuilder.Append((ColData.DataField & " <= " & ColData.FilterText.Replace("<=", "")))
                    Case InStr(ColData.FilterText.ToUpper, ">") <> 0
                        StrBuilder.Append((ColData.DataField & " > " & ColData.FilterText.Replace(">", "")))
                    Case InStr(ColData.FilterText.ToUpper, ">=") <> 0
                        StrBuilder.Append((ColData.DataField & " >= " & ColData.FilterText.Replace(">=", "")))
                    Case InStr(ColData.FilterText.ToUpper, "=") <> 0
                        StrBuilder.Append((ColData.DataField & " = " & ColData.FilterText.Replace("=", "")))
                    Case Else
                        StrBuilder.Append((ColData.DataField & " like " & "'*" & ColData.FilterText & "*'"))
                End Select

            End If
        Next

        Try
            MeData.DefaultView.RowFilter = StrBuilder.ToString()
        Catch ex As Exception

        End Try

    End Sub



    Public Function GET_CASH_COUNT_AMOUNT() As Double
        Dim totalsales As Double = 0
        Dim SQLEX As String = "SELECT daily_total AS 'totalsales' FROM daily_cash_count"
        SQLEX += " WHERE TRD_SYSPK='" & modCommon.DAILY_TRANSACTION_SYSPK & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            Try
                totalsales = CDbl(MeData.Rows(0).Item("totalsales").ToString)

            Catch ex As Exception

            End Try

        End If

        Return totalsales

    End Function

    Public Function GET_DAILY_SALES() As Double
        Dim totalsales As Double = 0
        Dim SQLEX As String = "SELECT SUM(dailysales_net) 'totalsales' FROM daily_sales_master"
        SQLEX += " WHERE TRD_SYSPK='" & modCommon.DAILY_TRANSACTION_SYSPK & "'"
        SQLEX += " AND Transaction_Type <> 'VOID'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then

            Try
                totalsales = CDbl(MeData.Rows(0).Item("totalsales").ToString)

            Catch ex As Exception

            End Try

        End If
        Return totalsales

    End Function


    'Public Function ApplicationStarUP()

    '    Dim folder As New DirectoryInfo(Application.StartupPath)
    '    Dim files As FileInfo() = folder.GetFiles()
    '    For Each file As FileInfo In files
    '        If file.Name.Contains(".exe") AndAlso
    '            Not file.Name.Contains(".config") AndAlso
    '            Not file.Name.Contains(".manifest") AndAlso
    '            Not file.Name.Contains(".vshost") Then
    '            currentApp = file
    '        End If
    '    Next


    'End Function


End Module
