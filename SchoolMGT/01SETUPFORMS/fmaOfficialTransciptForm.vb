Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Xls
Imports MySql.Data.MySqlClient

Public Class fmaOfficialTransciptForm

    Private picturePath As String = ""
    Private SQLCMD As String = ""
    Private pictureFilename As String = ""

    Public Event REPORTSTARTS()
    Public Event REPORTCLOSED()

    Public DirectPrinting As Boolean = False
    Private WithEvents MeAR As ActiveReport3

    Public DBPICPATH As String = ""



    Private Sub fmaOfficialTransciptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayDetails()


        'pbxphoto.Image = Image.FromFile(DBPICPATH)
        Try
            Dim bytes() As Byte = System.IO.File.ReadAllBytes(DBPICPATH)
            Dim ms As MemoryStream = New System.IO.MemoryStream(bytes)
            pbxphoto.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try

        loadGradeData()

    End Sub

    Private Sub displayDetails()
        Dim SQLEX As String = "SELECT id,"
        SQLEX += " elem,elem_date,highschool,high_date,admittedTo,address"
        SQLEX += " from transcript_master_file where class_roll_no='" & txtClassRollNumber.Text & "'"
        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            Try
                txtTORMasterFileID.Text = MeData.Rows(0).Item("id").ToString
                txtElem.Text = MeData.Rows(0).Item("elem").ToString
                txtElemYr.Text = MeData.Rows(0).Item("elem_date").ToString
                txtHS.Text = MeData.Rows(0).Item("highschool").ToString
                txtHSYr.Text = MeData.Rows(0).Item("high_date").ToString
                txtAdmittedTo.Text = MeData.Rows(0).Item("admittedTo").ToString
                txtAddress.Text = MeData.Rows(0).Item("address").ToString
            Catch ex As Exception

            End Try
        End If

    End Sub


    Public Property AttachReport(ByVal SQLstring As String, ByVal Title As String)
        Get
            Return MeAR
        End Get
        Set(ByVal value)
            MeAR = value

            If Title.Trim <> "" Then
                Me.Text = Title
            End If

            If SQLstring.Trim <> "" Then
                Me.SQLCMD = SQLstring
                Me.WindowState = FormWindowState.Maximized
                MeViewer.Document.Printer.PrinterName = ""
                MeViewer.Document = MeAR.Document

                MeAR.DataSource = clsDBConn.ExecQuery(SQLstring)
                MeAR.Run(True)

                MeViewer.ReportViewer.Zoom = -1
            End If
        End Set
    End Property

    Public Sub Print()
        If DirectPrinting Then
            MeAR.Document.Print(False, True, True)
        End If
    End Sub

    Private Sub MeAR_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MeAR.ReportEnd
        RaiseEvent REPORTSTARTS()
    End Sub

    Public Sub exportPDF()
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text & ".pdf"

        Dim ExportPDF As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
        ExportPDF.ImageQuality = Export.Pdf.ImageQuality.Highest
        'FileName += ".Pdf"
        ExportPDF.Export(MeAR.Document, FileName)
        ExportPDF = Nothing
        Process.Start(FileName)
    End Sub

    Private Sub exportRTF()
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text

        Dim ExportRTF As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
        FileName += ".rtf"
        ExportRTF.Export(MeAR.Document, FileName)
        ExportRTF = Nothing

        Process.Start(FileName)
    End Sub

    Private Sub exportExcel()
        Dim NewExport As New XlsExport
        Dim spath As String = Directory.GetCurrentDirectory
        Dim FileName As String = spath & "\" & Me.Text & ".xls"
        NewExport.FileFormat = FileFormat.Xls97Plus
        Try
            If System.IO.File.Exists(FileName) Then
                Try
                    My.Computer.FileSystem.DeleteFile(FileName)
                Catch ex As Exception
                End Try
            End If

            NewExport.Export(MeAR.Document, FileName)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        exportPDF()
    End Sub

    Private Sub btnrtf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrtf.Click
        exportRTF()
    End Sub

    Private Sub btnExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelExport.Click
        exportExcel()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            btnSave.Visible = True
            enableEditControls()
            txtStudentName.Focus()
        Else
            btnSave.Visible = False
            disableEditControls()
        End If
    End Sub

    Private Sub enableEditControls()
        txtStudentName.Enabled = True
        txtElem.Enabled = True
        txtHS.Enabled = True
        txtElemYr.Enabled = True
        txtHSYr.Enabled = True
        txtAdmittedTo.Enabled = True
        txtAddress.Enabled = True
        ButtonBrowsePic.Enabled = True
    End Sub

    Private Sub disableEditControls()
        txtStudentName.Enabled = False
        txtElem.Enabled = False
        txtHS.Enabled = False
        txtElemYr.Enabled = False
        txtHSYr.Enabled = False
        txtAdmittedTo.Enabled = False
        txtAddress.Enabled = False
        ButtonBrowsePic.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtTORMasterFileID.Text.Length > 0 Then
            updateTORDetailInfo()
            saveImage()
            loadGradeData()
        Else
            saveTORDetailInfo()
            saveImage()
            loadGradeData()
        End If
    End Sub

    Private Sub saveTORDetailInfo()
        Dim SQLIN As String = "INSERT INTO transcript_master_file(class_roll_no,student_name,elem"
        SQLIN += " ,elem_date,highschool,high_date,admittedTo,address)"
        SQLIN += " VALUES("
        SQLIN += String.Format("'{0}', '{1}', ", txtClassRollNumber.Text, txtStudentName.Text)
        SQLIN += String.Format("'{0}', '{1}', ", txtElem.Text, txtElemYr.Text)
        SQLIN += String.Format("'{0}', '{1}', ", txtHS.Text, txtHSYr.Text)
        SQLIN += String.Format("'{0}','{1}') ", txtAdmittedTo.Text, txtAddress.Text)

        If clsDBConn.Execute(SQLIN) Then
            MsgBox("Students TOR Details have been saved.", MsgBoxStyle.Information)
            CheckBox1.Checked = False

            Dim SQLEX As String = "SELECT id from transcript_master_file where class_roll_no='" & txtClassRollNumber.Text & "'"
            Dim MeData As DataTable
            MeData = clsDBConn.ExecQuery(SQLEX)

            If MeData.Rows.Count > 0 Then
                Try
                    txtTORMasterFileID.Text = MeData.Rows(0).Item("id").ToString
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub updateTORDetailInfo()
        Dim SQLUP As String = "UPDATE transcript_master_file set"
        SQLUP += String.Format(" address='{0}', elem='{1}',", txtAddress.Text, txtElem.Text)
        SQLUP += String.Format(" elem_date='{0}', highschool='{1}',", txtElemYr.Text, txtHS.Text)
        SQLUP += String.Format(" high_date='{0}', admittedTo='{1}'", txtHSYr.Text, txtAdmittedTo.Text)
        SQLUP += " WHERE id= '" & txtTORMasterFileID.Text & "'"
        If clsDBConn.Execute(SQLUP) Then
            MsgBox("Students TOR Details have been updated.", MsgBoxStyle.Information)
            CheckBox1.Checked = False
        End If

    End Sub

    Private Sub loadGradeData()

        If txtTORMasterFileID.Text.Length = 0 Then
            Exit Sub
        End If
        Dim SQLEX As String = "SELECT  coursegroup.name 'cgname'"
        SQLEX += " , group_courses.course_name, batches.name 'bname', subjects.code 'subjcode'"
        SQLEX += " , UPPER(subjects.name) 'subjname', students_subjects.finalgrade"
        SQLEX += " , subjects.credit_hours"
        'SQLEX += " , students.first_name, students.middle_name"
        SQLEX += " FROM group_courses"
        SQLEX += " INNER JOIN coursegroup "
        SQLEX += " ON (group_courses.coursegroup_id = coursegroup.id)"
        SQLEX += " INNER JOIN batches "
        SQLEX += " ON (batches.course_id = group_courses.course_id)"
        SQLEX += " INNER JOIN subjects "
        SQLEX += " ON (subjects.batch_id = batches.id)"
        SQLEX += " INNER JOIN students_subjects "
        SQLEX += " ON (students_subjects.subject_id = subjects.id)"
        SQLEX += " INNER JOIN students "
        SQLEX += " ON (students_subjects.student_id = students.id)"
        SQLEX += " WHERE students.class_roll_no = '" & txtClassRollNumber.Text & "'"
        SQLEX += " ORDER BY group_courses.course_name, batches.name"

        Try
            Me.AttachReport(SQLEX, "OFFICIAL TRANSCIPT OF RECORDS " & txtStudentName.Text) = _
        New rpt_OTOR(txtStudentName.Text, txtElem.Text, txtElemYr.Text, txtHS.Text, _
                     txtHSYr.Text, txtAddress.Text, txtAdmittedTo.Text, DBPICPATH)
        Catch ex As Exception

        End Try


    End Sub


    Private Sub ButtonBrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowsePic.Click
        Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = ""
        OpenFileDialog.RestoreDirectory = True
        OpenFileDialog.Filter = "JPEG (*.jpg;*.jpeg)|*.jpg|PNG (*.png)|*.png"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            picturePath = OpenFileDialog.FileName

            Me.pbxphoto.Image = New System.Drawing.Bitmap(picturePath)
            'Me.pbxphoto.Name = txtClassRollNumber.Text
            Dim filename As String = lblPicturepath.Text & "\" & txtClassRollNumber.Text & ".jpg"
            pictureFilename = filename


            Me.pbxphoto.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub



    Private Sub saveImage()

        If pbxphoto.Image Is Nothing Then Exit Sub

        Dim absolutepath As String = pictureFilename.Replace("\", "/")

        'Dim sqlQuery As String = "INSERT INTO sample(userimg) VALUES(?File)"'
        Dim sqlQuery As String = "UPDATE transcript_master_file SET picture=?File"
        sqlQuery += ", picturepath='" & absolutepath & "'"
        sqlQuery += " where id='" & txtTORMasterFileID.Text & "'"

        Dim sqlcom As New MySqlCommand(sqlQuery, cn)


        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            fs = New FileStream(pictureFilename, FileMode.Open, FileAccess.Read)
            FileSize = fs.Length

            rawData = New Byte(FileSize) {}
            fs.Read(rawData, 0, FileSize)
            fs.Close()
            cn.Open()

            sqlcom.Parameters.AddWithValue("?File", rawData)

            sqlcom.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception

        End Try

    End Sub



End Class