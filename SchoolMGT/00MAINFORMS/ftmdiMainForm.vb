Imports System.Threading
Imports System.Threading.Tasks

Imports Google
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services

Imports Google.Apis.Auth
Imports Google.Apis.Download

Imports System.Net.Mail
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.IO
'Imports Google.Apis.Drive.v3.Data.File
Imports System.Reflection
Imports System.Version
Imports SchoolMGT
Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Configuration


'<Assembly: AssemblyKeyFileAttribute("ApplicationStartup.exe")>
'<Assembly: AssemblyDelaySignAttribute(True)>


Public Class ftmdiMainForm


    Private WithEvents PAYMENTWIN As fmaStudentFeePaymentsForm
    Dim VersionNumber As Version
    Dim currentApp As FileInfo = Nothing
    Dim updateApp As FileInfo = Nothing


    ' Dim appSettings As Application

    '   Dim appSettings As String = ConfigurationManager.AppSettings("ServerPath") 'ConfigurationManager.AppSettings
    '  Dim appSettings As String =
    '    Dim directory As New DirectoryInfo(appSettings)

    Public filename As String
    Public tabbedMDIManager As XtraTabbedMdiManager = New XtraTabbedMdiManager()

    Dim ReportModel As New XtraReport_Model

    Public Event MAIN_FORM_CLOSE()

    'Private Service As DriveService = New DriveService

    Dim BeGreen As Boolean = False
    'Private Sub CreateService()
    '    If Not BeGreen Then
    '        Dim ClientId = "your client ID"
    '        Dim ClientSecret = "your client secret"
    '        Dim MyUserCredential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = ClientId, .ClientSecret = ClientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
    '        Service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = MyUserCredential, .ApplicationName = "Google Drive VB Dot Net"})
    '    End If
    'End Sub

    'Private Sub UploadFile(FilePath As String)
    '    Me.Cursor = Cursors.WaitCursor
    '    If Service.ApplicationName <> "Google Drive VB Dot Net" Then CreateService()

    '    Dim TheFile As New Google.Apis.Drive.v3.Data.File
    '    '   TheFile.Title = "My document"
    '    TheFile.OriginalFilename = ""
    '    '           TheFile.Description = "A test document"
    '    TheFile.Description = ""
    '    '   TheFile.MimeType = "text/plain"
    '    TheFile.MimeType = "text/plain"

    '    Dim ByteArray As Byte() = System.IO.File.ReadAllBytes(FilePath)
    '    Dim Stream As New System.IO.MemoryStream(ByteArray)

    '    '    Dim UploadRequest As FilesResource.InsertMediaUpload = Service.Files.Insert(TheFile, Stream, TheFile.MimeType)

    '    Dim UploadRequest As FilesResource.CreateMediaUpload = Service.Files.Create(TheFile, Stream, TheFile.MimeType)



    '    Me.Cursor = Cursors.Default
    '    MsgBox("Upload Finished")
    'End Sub

    'Private Sub DownloadFile(url As String, DownloadDir As String)
    '    Me.Cursor = Cursors.WaitCursor
    '    If Service.ApplicationName <> "Google Drive VB Dot Net" Then CreateService()

    '    Dim Downloader = New MediaDownloader(Service)
    '    Downloader.ChunkSize = 256 * 1024 '256 KB

    '    ' figure out the right file type base on UploadFileName extension
    '    Dim Filename = DownloadDir & "NewDoc.txt"
    '    Using FileStream = New System.IO.FileStream(Filename, System.IO.FileMode.Create, System.IO.FileAccess.Write)
    '        Dim Progress = Downloader.DownloadAsync(url, FileStream)
    '        Threading.Thread.Sleep(1000)
    '        Do While Progress.Status = TaskStatus.Running
    '        Loop
    '        If Progress.Status = TaskStatus.RanToCompletion Then
    '            MsgBox("Downloaded!")
    '        Else
    '            MsgBox("Not Downloaded :(")
    '        End If
    '    End Using
    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub ftmdiMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tabbedMDIManager.MdiParent = Me
        tabbedMDIManager.AppearancePage.Header.BackColor = Color.Transparent
        tabbedMDIManager.AppearancePage.HeaderActive.BackColor = Color.Navy

        brgy()
        mncplityCity()
        prvnce()

        EMPLOYEE_ID = ""
        txtSystemText.Text = "System Date : " & Format(DateTime.Now, "MMMM dd, yyyy")

        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

        VersionNumber = My.Application.Info.Version
        Dim vn = VersionNumber.Major & "." & VersionNumber.Minor & "." & VersionNumber.Build & "." & VersionNumber.Revision
        Me.ToolStripLabel1.Text = My.Application.Info.AssemblyName & " V " & vn


        'Get Allowed Priviledges


        setAllowedWindows()
        '
        setEmployeeID()

        getServerPath()

        ' CheckUpdate()
        '  ApplicationStarUp()

    End Sub

    'Private Sub loadSetting()

    '    Dim config = ConfigurationManager.OpenExeConfiguration(My.Application.Info.AssemblyName + ".exe")
    '    '    Dim name1 As String = config.Sections.Item("SchoolMGT.My.MySettings").ToString

    '    Dim settingsSection As ClientSettingsSection = config.GetSection("")


    '    For Each st As SettingElement In settingsSection.Settings

    '        'get setting name and value
    '        Dim name As String = st.Name
    '        Dim value As String = st.Value.ValueXml.InnerText

    '        'skip unknown settings
    '        Dim mySettingsItem = My.Settings.Item(name)
    '        If mySettingsItem Is Nothing Then
    '            Continue For
    '        End If

    '        'get setting type
    '        Dim itemType = mySettingsItem.GetType

    '        'check setting type name
    '        'some types require special treatment
    '        If itemType.Name = "StringCollection" Then

    '            mySettingsItem.Clear()

    '            'populate new string collection
    '            Dim arrayOfString = st.Value.ValueXml.SelectNodes("ArrayOfString/string")
    '            For i = 0 To arrayOfString.Count - 1
    '                Dim newString = arrayOfString.Item(i).InnerText
    '                mySettingsItem.Add(newString)
    '            Next

    '        ElseIf itemType.Name = "Color" Then
    '            If value.Contains(",") Then
    '                Dim rgbValues As String() = value.Split(",")
    '                Dim r As Integer = Convert.ToInt32(rgbValues(0))
    '                Dim g As Integer = Convert.ToInt32(rgbValues(1))
    '                Dim b As Integer = Convert.ToInt32(rgbValues(2))
    '                mySettingsItem = Color.FromArgb(r, g, b)
    '            Else
    '                mySettingsItem = Color.FromName(value)
    '            End If
    '        Else

    '            'try to cast
    '            Try
    '                mySettingsItem = CTypeDynamic(value, itemType)
    '            Catch ex As Exception
    '                MsgBox("Cannot read " + name + " from config file!", MsgBoxStyle.Critical)
    '                Continue For
    '            End Try

    '        End If

    '        'update My.Settings
    '        My.Settings.Item(name) = mySettingsItem
    '    Next


    'End Sub

    Private Sub CheckUpdate()

        Cursor.Current = Cursors.WaitCursor
        Try
            Dim folder As New DirectoryInfo(Application.StartupPath)
            Dim files As FileInfo() = folder.GetFiles()
            For Each file As FileInfo In files
                If file.Name.Contains(".exe") AndAlso Not file.Name.Contains(".config") Then
                    currentApp = file
                End If
            Next

            Dim updatedirectory As New DirectoryInfo("\\192.168.1.23\bst files\Application\Updates")
            Dim updatefiles As FileInfo() = updatedirectory.GetFiles()
            For Each file As FileInfo In updatefiles
                If file.Name.Contains(".exe") Then
                    updateApp = file
                    Exit For
                End If
            Next

            If (currentApp IsNot Nothing And updateApp IsNot Nothing) And currentApp.Name = updateApp.Name Then
                Dim currVersion As Version = GetFileVersionInfo(currentApp.FullName)
                Dim updateVersion As Version = GetFileVersionInfo(updateApp.FullName)
                If currVersion <> updateVersion Then
                    MsgBox("There is a new update. Please restart the Application for the update to take effect.", MsgBoxStyle.Information)
                    '        View.MainForm.Close()
                End If
            End If
        Catch ex As Exception
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Function GetFileVersionInfo(filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function

    '   Private Function GetFileVersionInfo(ByVal filename As String) As Version
    '     Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    '   End Function

    Private Sub ApplicationStarUp()

        Dim folder As New DirectoryInfo(Application.StartupPath)
        Dim files As FileInfo() = folder.GetFiles()
        For Each file As FileInfo In files
            If file.Name.Contains(".exe") AndAlso
                Not file.Name.Contains(".config") AndAlso
                Not file.Name.Contains(".manifest") AndAlso
                Not file.Name.Contains(".vshost") Then
                currentApp = file
            End If
        Next

        Dim currVersion As Version = GetFileVersionInfo(currentApp.FullName)
        '     projecTitle = "E-EGS v." & currVersion.Major & "." & currVersion.Minor & "." & currVersion.Build & "." & currVersion.Revision
        '      View.MainForm.Text = projecTitle

    End Sub

    Private Sub setEmployeeID()

        Dim SQLEX As String = "SELECT id FROM employees"
        SQLEX += " WHERE user_id='" & LoginUserID & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            EMPLOYEE_ID = MeData.Rows(0).Item("id").ToString
        End If

    End Sub

    Private Sub setAllowedWindows()
        Dim SQLEX As String = "SELECT privilege_id FROM privileges_users "
        SQLEX += " WHERE  privileges_users.user_id='" & LoginUserID & "'"

        Dim MeData As DataTable

        MeData = clsDBConn.ExecQuery(SQLEX)
        Dim objToolStripItem As ToolStripItem

        If MeData.Rows.Count > 0 Then
            Try
                For nctr As Integer = 0 To MeData.Rows.Count - 1
                    Dim privilegeid As String = MeData.Rows(nctr).Item("privilege_id").ToString

                    'Menu Item
                    For Each objToolStripItem In Me.MainMenuStrip.Items
                        Dim menuname As String = objToolStripItem.Name
                        Dim accessiblename As String = objToolStripItem.AccessibleName

                        If LoginUserID = "1" Then
                            Me.MainMenuStrip.Items(menuname).Enabled = True

                            Continue For
                        End If

                        If accessiblename = "" Then
                            Continue For
                        Else

                            Dim Parent As New ToolStripMenuItem
                            If accessiblename = privilegeid Then

                                Me.MainMenuStrip.Items(menuname).Enabled = True

                                ''ToolStrip Menu Item
                                Parent = MainMenuStrip.Items(menuname)
                                For Each child In Parent.DropDownItems
                                    Dim menuname_child As String = child.name
                                    Dim accessiblename_child As String = child.AccessibleName

                                    If CheckIfExist(LoginUserID, accessiblename_child) Then
                                        Parent.DropDownItems(menuname_child).Enabled = True
                                        '    Else
                                        '      Parent.DropDownItems(menuname_child).Visible = False
                                    End If

                                Next

                            End If
                        End If
                    Next

                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            For Each objToolStripItem In Me.MainMenuStrip.Items
                Dim menuname As String = objToolStripItem.Name
                Dim accessiblename As String = objToolStripItem.AccessibleName

                If LoginUserID = "1" Or LoginUserID = "100879" Then
                    Me.MainMenuStrip.Items(menuname).Enabled = True
                    Continue For
                Else
                    If SUPERUSER(LoginUserID) Then
                        Me.MainMenuStrip.Items(menuname).Enabled = True
                        Continue For
                    End If

                End If

                If accessiblename = "" Then
                    Continue For
                Else

                    Me.MainMenuStrip.Items(menuname).Enabled = False
                End If
            Next
        End If

    End Sub

    Private Function CheckIfExist(loginUserID As String, accessiblename_child As String) As Boolean
        Dim id As Integer = DataObject(String.Format("SELECT privilege_id FROM privileges_users WHERE user_id = '" & loginUserID & "' AND privilege_id = '" & accessiblename_child & "' "))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function SUPERUSER(loginUserID As String) As Boolean
        Dim id As Integer
        id = DataObject(String.Format("SELECT `user_id` FROM `super_user` WHERE user_id = '" & loginUserID & "' "))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub DBCONNECTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ftDatabaseConnectionForm.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        ftLoginForm.Show()
    End Sub


    Private Sub FEESCHEDULEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaFinance_FeeSchedulerForm.ShowDialog()

    End Sub



    Private Sub PAYMENTWIN_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles PAYMENTWIN.FormClosed
        Me.Show()
        PAYMENTWIN = Nothing
    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsListToolStripMenuItem.Click
        'fmaStudentListForm.MdiParent = Me
        'fmaStudentListForm.Tag = StudentsListToolStripMenuItem.Tag
        'fmaStudentListForm.disableAssessmentview()
        'fmaStudentListForm.Show()
        'fmaStudentListForm.BringToFront()

        Dim frm As New fmaStudentListForm
        frm.MdiParent = Me
        frm.Tag = StudentsListToolStripMenuItem.Tag
        frm.disableAssessmentview()
        frm.Show()
        frm.BringToFront()

    End Sub



    Private Sub STUDENTASSESSMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTASSESSMENTToolStripMenuItem.Click

        'fmaStudentListForm.MdiParent = Me
        'fmaStudentListForm.Tag = STUDENTASSESSMENTToolStripMenuItem.Tag
        'fmaStudentListForm.disableSubjectView()
        'fmaStudentListForm.disableGradeView()
        'fmaStudentListForm.Show()
        'fmaStudentListForm.BringToFront()

        Dim frm As New fmaStudentListForm
        frm.MdiParent = Me
        frm.Tag = STUDENTASSESSMENTToolStripMenuItem.Tag
        frm.disableSubjectView()
        frm.disableGradeView()
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub StudentAdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAdmissionToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        Dim frm As New fmaStudentAdmissionSetupForm
        Me.Hide()
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.Cancel Then
            Me.Show()
        Else
            frm.ShowDialog()
            If frm.DialogResult = DialogResult.Cancel Then
                Me.Show()
            End If
        End If
        Cursor = Cursors.Default

    End Sub

    Private Sub SUBJECTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBJECTToolStripMenuItem.Click
        fmaSubjectaListForm.MdiParent = Me
        fmaSubjectaListForm.btnAdd.Visible = False
        fmaSubjectaListForm.Show()
        fmaSubjectaListForm.BringToFront()
    End Sub

    'Private Sub INSTRUCTORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    fmaEmployeeListForm.Tag = INSTRUCTORToolStripMenuItem.Tag
    '    fmaEmployeeListForm.MdiParent = Me
    '    fmaEmployeeListForm.Show()
    '    fmaEmployeeListForm.BringToFront()

    'End Sub

    Private Sub ROOMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fmaRoomListForm.MdiParent = Me
        fmaRoomListForm.Show()
        fmaRoomListForm.BringToFront()
    End Sub

    Private Sub STUDENTCATEGORYToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTCATEGORYToolStripMenuItem.Click

        fmaStudentCategoryListForm.MdiParent = Me
        fmaStudentCategoryListForm.Show()
        fmaStudentCategoryListForm.BringToFront()

    End Sub

    Private Sub ManageCourseOrGradeLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCourseOrGradeLevelToolStripMenuItem.Click
        fmaCoursesListForm.MdiParent = Me
        fmaCoursesListForm.Show()
        fmaCoursesListForm.BringToFront()
    End Sub

    Private Sub ManageBatchOrSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageBatchOrSectionToolStripMenuItem.Click
        fmaBatchesListForm.MdiParent = Me
        fmaBatchesListForm.Show()
        fmaBatchesListForm.BringToFront()
    End Sub

    Private Sub ManageSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageSubjectToolStripMenuItem.Click

        fmaSubjectaListForm.MdiParent = Me
        fmaSubjectaListForm.Tag = ManageSubjectToolStripMenuItem.Tag
        fmaSubjectaListForm.btnAdd.Visible = True
        fmaSubjectaListForm.Show()
        fmaSubjectaListForm.BringToFront()
    End Sub

    Private Sub CreateFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateFeesToolStripMenuItem.Click
        fmaFeesMasterListForm.MdiParent = Me
        fmaFeesMasterListForm.Show()
        fmaFeesMasterListForm.BringToFront()
    End Sub

    Private Sub STUDENTSACCOUNTPAYMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTSACCOUNTPAYMENTToolStripMenuItem.Click
        If PAYMENTWIN Is Nothing Then
            PAYMENTWIN = New fmaStudentFeePaymentsForm
            Me.Hide()
            PAYMENTWIN.ShowDialog()
        End If

        'Cursor = Cursors.WaitCursor

        'Dim frm As New fmaStudentFeePaymentsForm
        'frm.MdiParent = Me
        'frm.Show()
        'frm.BringToFront()

        'Cursor = Cursors.Default


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'frmFinanceMainForms.MdiParent = Me
        'frmFinanceMainForms.Show()
        'frmFinanceMainForms.BringToFront()
        'ToolStripMenuItem1.HideDropDown()
    End Sub

    Private Sub FinanceFeeCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinanceFeeCategoryToolStripMenuItem.Click
        fmaFeeCategoryListForm.ShowDialog(Me)
    End Sub

    Private Sub EXPENSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXPENSEToolStripMenuItem.Click
        fmaCashVoucherSetupForm.ShowDialog(Me)
    End Sub

    Private Sub REPORTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem1.Click
        fmaRPT_IncomeExpenseForm.ShowDialog(Me)
    End Sub

    Private Sub GRADINGPERIODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRADINGPERIODToolStripMenuItem.Click
        fmaStudentGradingPeriodForm.ShowDialog(Me)
    End Sub

    Private Sub MANAGEGRADEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGEGRADEToolStripMenuItem.Click
        '      fmaStudentsGradeMainForm.ShowDialog(Me)
    End Sub

    Private Sub LinkGroupCoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkGroupCoursesToolStripMenuItem.Click
        fmaGroupedCoursesForm.ShowDialog()
    End Sub


    Private Sub INCOMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INCOMEToolStripMenuItem.Click
        fmaIncomeSetupForm.ShowDialog(Me)
    End Sub

    Private Sub StudentsGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsGradesToolStripMenuItem.Click

        'fmaRegistrarTORPrinting.MdiParent = Me
        'fmaRegistrarTORPrinting.Show()
        'fmaRegistrarTORPrinting.BringToFront()

        Cursor = Cursors.WaitCursor
        Dim frm As New fmaRegistrarTORPrinting

        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub CreditDistributionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditDistributionToolStripMenuItem.Click

        fmaCreditDistributionListForm.MdiParent = Me
        fmaCreditDistributionListForm.Show()
        fmaCreditDistributionListForm.BringToFront()
    End Sub



    Private Sub EMPLOYEELISTToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim Menuname As String = e.ToString

        fmaEmployeeListForm.MdiParent = Me
        fmaEmployeeListForm.Show()
        fmaEmployeeListForm.BringToFront()

    End Sub

    Private Sub STUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTToolStripMenuItem.Click

        fmaEmployeeListForm.Tag = STUDENTToolStripMenuItem.Tag

        fmaEmployeeListForm.MdiParent = Me
        fmaEmployeeListForm.Show()
        fmaEmployeeListForm.BringToFront()
    End Sub

    Private Sub DEPARTMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEPARTMENTToolStripMenuItem.Click

        fmaDepartmentListForm.MdiParent = Me
        fmaDepartmentListForm.Show()
        fmaDepartmentListForm.BringToFront()

    End Sub

    Private Sub POSITIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSITIIONToolStripMenuItem.Click

        fmaPositionList.MdiParent = Me
        fmaPositionList.Show()
        fmaPositionList.BringToFront()
    End Sub

    Private Sub JOBTITLEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JOBTITLEToolStripMenuItem1.Click

        fmaJobTitleList.MdiParent = Me
        fmaJobTitleList.Show()
        fmaJobTitleList.BringToFront()

    End Sub

    Private Sub PAYGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAYGRADESToolStripMenuItem.Click

        fmaPayGradeList.MdiParent = Me
        fmaPayGradeList.Show()
        fmaPayGradeList.BringToFront()

    End Sub

    Private Sub ROOMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROOMSToolStripMenuItem.Click

        fmaRoomListForm.MdiParent = Me
        fmaRoomListForm.Show()
        fmaRoomListForm.BringToFront()

    End Sub

    Private Sub SUBJECTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBJECTSToolStripMenuItem.Click
        'fmaSubjectaListForm.MdiParent = Me
        'fmaSubjectaListForm.btnAdd.Visible = False
        'fmaSubjectaListForm.Show()
        'fmaSubjectaListForm.BringToFront()

        fmaSubjectTeacherListForm.MdiParent = Me

        fmaSubjectTeacherListForm.Show()

        fmaSubjectTeacherListForm.BringToFront()
    End Sub

    Private Sub INSTRUCTORToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INSTRUCTORToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor


        fmaEmployeeListForm.Close()
        fmaEmployeeListForm.Tag = INSTRUCTORToolStripMenuItem1.Tag
        fmaEmployeeListForm.Text = "EMPLOYEE LIST"
        fmaEmployeeListForm.MdiParent = Me
        fmaEmployeeListForm.Show()
        fmaEmployeeListForm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub STUDENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTSToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        MenuItemID = STUDENTSToolStripMenuItem.AccessibleName

        fmaEmployeeListForm.Close()
        fmaEmployeeListForm.Tag = STUDENTToolStripMenuItem.Tag
        fmaEmployeeListForm.Text = "STUDENT LIST"
        fmaEmployeeListForm.MdiParent = Me
        fmaEmployeeListForm.Show()
        fmaEmployeeListForm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub TIMESCHEDULEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIMESCHEDULEToolStripMenuItem.Click

        fmaTimeScheduleList.MdiParent = Me
        fmaTimeScheduleList.Show()
        fmaTimeScheduleList.BringToFront()

    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        fmaUserList.MdiParent = Me
        fmaUserList.Show()
        fmaUserList.BringToFront()


    End Sub

    Private Sub ADMISSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMISSIONToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        Dim frm As New frmNewStudentAdmissionList
        '   frm.WindowState = FormWindowState.Maximized
        '   frm.StartPosition = FormStartPosition.CenterParent

        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()


        Cursor = Cursors.Default
    End Sub

    Private Sub GRADESHEETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADESHEETToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New frmGradeSheet
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New fmaStudentsGradeMainForm
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem1.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New fmaStudentListForm
        frm.Tag = StudentToolStripMenuItem1.Tag
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click


        Cursor = Cursors.WaitCursor
        Dim frm As New fmaRegistrarTORPrinting

        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub SUBJECTSCHEDULEENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBJECTSCHEDULEENTRYToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        Dim frm As New fmaSubjectaListForm
        frm.Tag = SUBJECTSCHEDULEENTRYToolStripMenuItem.Tag
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub LISTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTSToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frm As New frmStudentLearnersList

        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub REQUESITIONFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REQUESITIONFORMToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        Dim frm As New frmRequisitionSlip

        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub BlankFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlankFormToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New frmBlankForm
        frm.BringToFront()
        frm.ShowDialog()

        Cursor = Cursors.Default
    End Sub

    Private Sub IncomeAndExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeAndExpenseToolStripMenuItem.Click
        fmaRPT_IncomeExpenseForm.ShowDialog(Me)
    End Sub

    Private Sub DBCONNECTIONToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBCONNECTIONToolStripMenuItem.Click
        ftDatabaseConnectionForm.ShowDialog(Me)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog(Me)
    End Sub

    Private Sub Form1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form1ToolStripMenuItem.Click

        Cursor.Current = Cursors.WaitCursor

        Dim report As New XtraReport_BillingStatements_Form1

        '    Dim dt As New DataTable
        '     dt = ReportModel.getSchool_Address(AppSetup_Domain)
        report.XrLSchoolName.Text = COMPANY_NAME
        report.XrLAddress.Text = COMPANY_ADDRESS
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview


        Cursor.Current = Cursors.Default
    End Sub

    'Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
    '    Me.Close()
    '    Dim frm As New ftLoginForm
    '    frm.Show()
    'End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click

        Cursor.Current = Cursors.WaitCursor

        Dim report As New XtraReport_BillingStatements_Form1

        report.XrLSchoolName.Text = COMPANY_NAME
        report.XrLAddress.Text = COMPANY_ADDRESS
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview


        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BillingStatementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingStatementsToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New frmBillingStatement
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub

    Private Sub PRIVILEGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRIVILEGEToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New frmPrevilegeAccess
        frm.LabelX2.Text = "USER's PRIVILEGE"
        frm.Tag = PRIVILEGEToolStripMenuItem.Tag
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default

    End Sub


    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click

        'Dim frm As New ftLoginForm
        'frm.Show()

        ftLoginForm.Show()

        Me.Close()


    End Sub

    Private Sub ExitToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem3.Click
        Me.Close()
        ftLoginForm.Close()
    End Sub

    Private Sub TESAPPLICATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TESAPPLICATIONToolStripMenuItem.Click


        Cursor = Cursors.WaitCursor

        Dim frm As New frmTESApplicationList
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default


    End Sub

    Private Sub STUDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDEToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor

        Dim frm As New frmStudentLearnersList
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        About.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Cursor = Cursors.WaitCursor

        Dim frm As New fmaChedEListForm
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub ftmdiMainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent MAIN_FORM_CLOSE()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub CHEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHEDToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor

        Dim frm As New frmChed_E_FormBC
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub LOADSUBJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOADSUBJECTToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor

        Dim frm As New frmSubjectLoad
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click

    End Sub

    Private Sub GRADESLIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADESLIPToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor

        Dim frm As New frmGradeSlip
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub

    Private Sub LISTOFGRADUATESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTOFGRADUATESToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor

        Dim frm As New frmGraduateList
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

        Cursor = Cursors.Default
    End Sub
End Class