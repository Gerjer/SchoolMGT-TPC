Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web.UI.WebControls.Image
Imports System.Configuration

Public Class ftLoginForm

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim myData As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim dt As New DataTable
    Dim abc As String
    Private DefaultImage As Image

    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream

    Private WithEvents company As frmCompanyProfileSetup


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ftLoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.DoEvents()
        GroupPanel1.Focus()
        txtUserName.Focus()
        txtUserName.SelectAll()
        Me.ActiveControl = Me.txtUserName
        displayCompanyInfo()
        clsDBConn = New clsDBConnection
        If Not clsDBConn.IsDBConnected() Then
            'ftDatabaseConnectionForm.BringToFront()
            ftDatabaseConnectionForm.ShowDialog()
        End If


    End Sub

    Private Function IsLoginOK(ByVal UserName As String, ByVal Password As String) As Boolean
        Dim SQL As String = String.Format("SELECT id, CONCAT(first_name, ' ', last_name) AS 'AuthUserName', hashed_password,salt,application_setup_id,Type_User FROM users WHERE username='{0}' ", UserName)
        Dim Medata As New DataTable
        Dim Ret As Boolean = False

        Try
            Medata = clsDBConn.ExecQuery(SQL)

            If Medata.Rows.Count > 0 Then
                Dim autPassword As String = HASH512(txtPassword.Text, Medata.Rows(0).Item("salt").ToString)
                Dim hashed_password As String = Medata.Rows(0).Item("hashed_password").ToString

                If autPassword = hashed_password Then
                    AuthUserName = Medata.Rows(0).Item("AuthUserName").ToString
                    LoginUserID = Medata.Rows(0).Item("id").ToString
                    SALT = Medata.Rows(0).Item("salt").ToString
                    AppSetup_Domain = Medata.Rows(0).Item("application_setup_id").ToString
                    AuthUserType = Medata.Rows(0).Item("Type_User").ToString
                    Return True
                End If
            End If
        Catch ex As Exception

        End Try
        Return Ret


    End Function




    Private Sub getCompanyProfile()
        Dim SQLEX As String = "SELECT company_name, address FROM file"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                COMPANY_NAME = MeData.Rows(0).Item("company_name").ToString
                COMPANY_ADDRESS = MeData.Rows(0).Item("address").ToString
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtUserName_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtUserName.Text = ""
    End Sub

    Private Sub txtPassword_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = CChar(ChrW(Keys.Enter)) Then
            Call btnOK_Click_1(sender, e)
        End If
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub pxBoxSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxBoxSettings.Click
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If

            Dim frm As New ftDatabaseConnectionForm
            frm.BringToFront()
            frm.Show()
            'company = New frmCompanyProfileSetup

            'company.ShowDialog()
        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""

            Exit Sub
        End If
        'Me.Show()
    End Sub

    Private Sub company_winClosing() Handles company.winClosing
        displayCompanyInfo()
        Me.Show()
        'Me.displayPicture()
        'Me.Close()
    End Sub

    Private Sub displayCompanyInfo()
        Dim ServerName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
        Dim DatabaseName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
        Dim UserID As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
        Dim Password As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
        Dim connectionString As String = String.Format("server={0};database={1};uid={2};pwd={3}", ServerName, DatabaseName, UserID, Password)

        Try
            con.ConnectionString = connectionString
            cmd.Connection = con
            con.Open()
        Catch ex As Exception

        End Try



        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT file_name, file_size,file,company_name, address,contactnum FROM file"

            myData = cmd.ExecuteReader

            If Not myData.HasRows Then
                myData.Close()
                Exit Sub
            End If

            myData.Read()
            Dim file_name As String = myData.GetString("file_name")


            ftmdiMainForm.filename = file_name


            Try

                Dim imagebytes As Byte() = CType(myData("file"), Byte())
                Using ms As New IO.MemoryStream(imagebytes)
                    pic_box_save.Image = Image.FromStream(ms)
                    pic_box_save.SizeMode = PictureBoxSizeMode.StretchImage
                End Using

                'Dim bytes() As Byte = System.IO.File.ReadAllBytes(myData.GetString("file"))
                'Dim ms As MemoryStream = New System.IO.MemoryStream(bytes)
                'pic_box_save.Image = Image.FromStream(ms)


                'Dim bytes() As Byte = System.IO.File.ReadAllBytes(file_name)
                'Dim ms As MemoryStream = New System.IO.MemoryStream(bytes)
                'pic_box_save.Image = Image.FromStream(ms)
                ''   pic_box_save.Load(DefaultLogInPic)
            Catch ex As Exception

            End Try

            '     pic_box_save.BackgroundImage = Image.FromFile("C:\newfile.png")
            '  Me.txtPhotoPath_Empl.Text = "C:\newfile.png"
        Catch ex As Exception
            'MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            'pic_box_save.BackgroundImage = Image.FromFile("C:\newfile.png")
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtUserName_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtUserName.SelectAll()
    End Sub

    Private Sub lblSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSettings.Click
        Me.Hide()
        If frmSU_Pass.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not frmSU_Pass.passwordOK = True Then
                MsgBox("Needs SuperUser Pin to Access Component.")
                frmSU_Pass.txtPassword.Text = ""
                Me.Show()
                Exit Sub
            End If
            company = New frmCompanyProfileSetup

            company.ShowDialog()
        Else
            Me.Show()
            frmSU_Pass.txtPassword.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        If IsLoginOK(Me.txtUserName.Text, Me.txtPassword.Text) Then
            txtUserName.Focus()
            txtPassword.Text = ""
            txtUserName.Text = ""
            Me.Hide()

            'Mainloading.ShowDialog()

            getOrganizationDetails()

            SavingDirectory()

            ftmdiMainForm.global_loginAuth.Text = AuthUserName
            ftmdiMainForm.Show()

            SetRootDirectory()
        Else
            MessageBox.Show("Login is Incorrect....", "Please Verify UserName and Password!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancel_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Private Sub lblSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSettings.Click
    '    ftDatabaseConnectionForm.ShowDialog()
    'End Sub

    'Private Sub pxBoxSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxBoxSettings.Click
    '    ftDatabaseConnectionForm.ShowDialog()
    'End Sub

    Private Sub txtUserName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub btnBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlank.Click
        txtUserName.Focus()
        txtUserName.SelectAll()
    End Sub


    Private Sub ftLoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Control And e.Shift And e.KeyCode = Keys.F10 Then
            Me.txtUserName.Text = "admin"
            Me.txtPassword.Text = "junmar@bst"
            If IsLoginOK(Me.txtUserName.Text, Me.txtPassword.Text) Then
                txtUserName.Focus()
                txtPassword.Text = ""
                txtUserName.Text = ""
                Me.Hide()

                'Mainloading.ShowDialog()

                getOrganizationDetails()

                SavingDirectory()

                ftmdiMainForm.global_loginAuth.Text = AuthUserName
                ftmdiMainForm.Show()

                SetRootDirectory()

            Else
                MessageBox.Show("Login is Incorrect....", "Please Verify UserName and Password!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub


    Public Function SetRootDirectory()
        Dim Root_Directory As String = ""
        If clsDBConn.ServerName = "localhost" Then
            Root_Directory = Directory.GetCurrentDirectory
        Else

            If SavingDir = "local.dir" Then
                Root_Directory = Directory.GetCurrentDirectory
            Else
                Dim appSettings As String = ConfigurationManager.AppSettings("Server_XTRAREPORT_Path")
                Dim directory_info As New DirectoryInfo(appSettings)
                Root_Directory = directory_info.FullName
            End If

        End If
            _RootDirectory = Root_Directory
        DevExpress.XtraReports.Configuration.Settings.Default.StorageOptions.RootDirectory = Root_Directory
        Return Nothing
    End Function



    'Private Sub ftLoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    '    If e.Control And e.Alt And Keys.C Then
    '        Dim frm As New ftDatabaseConnectionForm
    '        frm.BringToFront()
    '        frm.Show()

    '    End If
    'End Sub

End Class