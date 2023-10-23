Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging


Public Class frmCompanyProfileSetup
    'Dim cn As New MySqlConnection
    Dim con As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim myData As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim dt As New DataTable
    Dim abc As String
    Private DefaultImage As Image


    Dim rawData() As Byte
    Dim FileSize As UInt32
    Dim fs As FileStream

    Dim rawData1() As Byte
    Dim FileSize1 As UInt32
    Dim fs1 As FileStream


    Public Event winClosing()
    Dim connectionString As String



    Private Sub txtPhotoPath_Empl_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhotoPath_Empl.ButtonCustomClick
        Me.SelectPicture()
    End Sub

    Private Sub SelectPicture()
        With ofdBrowse
            .FilterIndex = 0
            .Filter = "All Files|*.*"
            .ShowDialog()

            If .FileName.Trim <> "" Then
                Me.txtPhotoPath_Empl.Text = .FileName
                Try
                    pic_box_save.Image = Image.FromFile(.FileName)
                Catch ex As Exception
                End Try
            End If
        End With
    End Sub

    Private Sub txtPhotoPath_Empl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhotoPath_Empl.TextChanged
        Try
            If Me.txtPhotoPath_Empl.Text.Trim = "" Then
                pic_box_save.BackgroundImage = DefaultImage
            Else
                pic_box_save.BackgroundImage = Image.FromFile(Me.txtPhotoPath_Empl.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        RaiseEvent winClosing()
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        'Dim arrImage() As Byte
        'Dim strImage As String
        'Dim myMs As New IO.MemoryStream
        'If Not IsNothing(Me.pic_box_save.Image) Then
        '    Me.pic_box_save.Image.Save(myMs, Me.pic_box_save.Image.RawFormat)
        '    arrImage = myMs.GetBuffer
        '    strImage = "1000"
        'Else
        '    arrImage = Nothing
        '    strImage = "NULL"
        'End If
        'cmd.CommandText = "INSERT INTO client_profile(COMPANY_NAME, COMPANY_PHOTO) VALUES('" & Me.txtDisplayName.Text & "'," & _
        '                       strImage & ")"

        'If strImage = "1000" Then
        '    cmd.Parameters.Add(strImage, MySqlDbType.Blob).Value = arrImage

        'End If

        'MsgBox("Data save successfully!")

        'cmd.ExecuteNonQuery()

        'cn.Close()

        If Not txtPhotoPath_Empl.Text.Length = 0 Then
            saveImage()
        End If
        


    End Sub

    Private Sub frmCompanyProfileSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent winClosing()
    End Sub

    Private Sub frmCompanyProfileSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ServerName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
        Dim DatabaseName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
        Dim UserID As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
        Dim Password As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
        connectionString = String.Format("server={0};database={1};uid={2};pwd={3}", ServerName, DatabaseName, UserID, Password)

        Try
           
            con = New MySqlConnection
            cmd = New MySqlCommand
            con.ConnectionString = connectionString
            cmd.Connection = con
            con.Open()
        Catch ex As Exception

        End Try
        


        Try
            loadImage()
        Catch ex As Exception

        End Try

        txtDisplayName.SelectAll()
        txtDisplayName.Focus()



    End Sub


    Private Sub saveImage()
        Dim SQLDEL As String = "TRUNCATE TABLE file "
        clsDBConn.ExecuteSilence(SQLDEL)

        Try
            fs = New FileStream(txtPhotoPath_Empl.Text, FileMode.Open, FileAccess.Read)
            FileSize = fs.Length

            rawData = New Byte(FileSize) {}
            fs.Read(rawData, 0, FileSize)
            fs.Close()


            fs1 = New FileStream(txtPhotoPath_Header.Text, FileMode.Open, FileAccess.Read)
            FileSize1 = fs1.Length

            rawData1 = New Byte(FileSize1) {}
            fs1.Read(rawData1, 0, FileSize1)
            fs1.Close()

            Dim names = txtPhotoPath_Empl.Text.Trim
            Dim phrase As String = names.Substring(names.LastIndexOf("\"c) + 1)
            txtPhotoPath_Empl.Text = "\" & phrase

            names = txtPhotoPath_Header.Text.Trim
            phrase = names.Substring(names.LastIndexOf("\"c) + 1)
            txtPhotoPath_Header.Text = "\" & phrase



            Dim SqlString = "INSERT INTO file VALUES(NULL, ?FileName, ?FileSize, ?File, ?company_name,?address, ?contactnum,?description_name,?mobilenum,?faxnum,?emailaddress,?hdr_file_name,?hdr_file_size,?hdr_file)"

            con = New MySqlConnection
            con.ConnectionString = connectionString
            cmd.Connection = con
            con.Open()


            cmd.Connection = con
            cmd.CommandText = SqlString
            cmd.Parameters.AddWithValue("?FileName", txtPhotoPath_Empl.Text)
            cmd.Parameters.AddWithValue("?FileSize", FileSize)
            cmd.Parameters.AddWithValue("?File", rawData)
            cmd.Parameters.AddWithValue("?company_name", txtDisplayName.Text)
            cmd.Parameters.AddWithValue("?address", txtAddress.Text)
            cmd.Parameters.AddWithValue("?contactnum", txtContact.Text)
            cmd.Parameters.AddWithValue("?description_name", txtDescriptionName.Text)
            cmd.Parameters.AddWithValue("?mobilenum", txtMobileNo.Text)
            cmd.Parameters.AddWithValue("?faxnum", txtFaxNo.Text)
            cmd.Parameters.AddWithValue("?emailaddress", txtEmailAdd.Text)
            cmd.Parameters.AddWithValue("?hdr_file_name", txtPhotoPath_Header.Text)
            cmd.Parameters.AddWithValue("?hdr_file_size", FileSize1)
            cmd.Parameters.AddWithValue("?hdr_file", rawData1)

            cmd.ExecuteNonQuery()

            MessageBox.Show("File Inserted into database successfully!", _
            "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            con.Close()
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub loadImage()
        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT file_name, file_size, file,company_name, address,contactnum FROM file"

            myData = cmd.ExecuteReader

            If Not myData.HasRows Then
                myData.Close()
                Exit Sub
            End If

            myData.Read()
            Dim file_name As String = myData.GetString("file_name")
            Me.txtPhotoPath_Empl.Text = myData.GetString("file_name")
            Me.txtDisplayName.Text = myData.GetString("company_name")
            Me.txtAddress.Text = myData.GetString("address")
            Me.txtContact.Text = myData.GetString("contactnum")


            FileSize = myData.GetUInt32(myData.GetOrdinal("file_size"))
            rawData = New Byte(FileSize) {}

            myData.GetBytes(myData.GetOrdinal("file"), 0, rawData, 0, FileSize)

            fs = New FileStream("C:\newfile.png", FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(rawData, 0, FileSize)
            fs.Close()




            myData.Close()
            con.Close()
            'Me.txtPhotoPath_Empl.Text = "C:\newfile.png"
        Catch ex As Exception
            'MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            pic_box_save.BackgroundImage = Image.FromFile("C:\newfile.png")
            '      pichdr_box_save.BackgroundImage = Image.FromFile("C:\newfile.png")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtPhotoPath_Header_ButtonCustomClick(sender As Object, e As EventArgs) Handles txtPhotoPath_Header.ButtonCustomClick
        Me.SelectPicture1()
    End Sub

    Private Sub SelectPicture1()
        With ofdBrowse
            .FilterIndex = 0
            .Filter = "All Files|*.*"
            .ShowDialog()

            If .FileName.Trim <> "" Then
                Me.txtPhotoPath_Header.Text = .FileName
                Try
                    pichdr_box_save.Image = Image.FromFile(.FileName)
                Catch ex As Exception
                End Try
            End If
        End With
    End Sub
End Class