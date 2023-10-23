Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class clsDBConnection

#Region "Constructor"

    Sub New()
        myConn = New MySqlConnection
        MeAdapter = New MySqlDataAdapter
    End Sub

#End Region

#Region "Declarations"
    Private _ServerName As String = ""
    Private _DatabaseName As String = ""
    Private _UserID As String = ""
    Private _Password As String = ""

    Private myConn As MySqlConnection = Nothing
    Private MeAdapter As MySqlDataAdapter

#End Region

#Region "Properties"
    Public Property ServerName() As String
        Get
            Return _ServerName
        End Get
        Set(ByVal value As String)
            _ServerName = value
        End Set
    End Property

    Public Property DatabaseName() As String
        Get
            Return _DatabaseName
        End Get
        Set(ByVal value As String)
            _DatabaseName = value
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public ReadOnly Property Connection() As MySqlConnection
        Get
            Return myConn
        End Get
    End Property

#End Region

#Region "Subs And Methods"
    Private Sub GetConnSettingsFromRegistry()
        _ServerName = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
        _DatabaseName = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
        _UserID = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
        _Password = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
    End Sub

    Public Function IsDBConnected() As Boolean
       

        Dim Constring As String = ""
        Me.GetConnSettingsFromRegistry()
        Constring = String.Format("server={0};database={1};uid={2};pwd={3};Character Set=utf8;", _ServerName, _DatabaseName, _UserID, _Password)

        If _ServerName = "" And _DatabaseName = "" Then
            Return False
        End If

        myConn.ConnectionString = Constring

        Try
            myConn.Open()
            Application.DoEvents()

            myConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
            Return False
        End Try
    End Function


    Public Function ExecQuery(ByVal SQLString As String) As DataTable
        Dim MeData As New DataTable
        Try
            MeAdapter = New MySqlDataAdapter(SQLString, myConn)
            MeAdapter.Fill(MeData)
            Return MeData
        Catch ex As Exception
            If Not String.IsNullOrEmpty(SQLString) Then
                Clipboard.SetText(SQLString)
            End If
            MessageBox.Show(ex.Message, "DB Error !")
            Return Nothing
        End Try

        MeData = Nothing
    End Function

    Public Function ExecLongQuery(ByVal SQLString As String) As DataTable
        Dim MeData As New DataTable
        Try
            MeAdapter = New MySqlDataAdapter(SQLString, myConn)
            MeAdapter.SelectCommand.CommandTimeout = 0
            MeAdapter.Fill(MeData)
            Return MeData
        Catch ex As Exception
            If Not String.IsNullOrEmpty(SQLString) Then
                Clipboard.SetText(SQLString)
            End If
            MessageBox.Show(ex.Message, "DB Error !")
            Return Nothing
        End Try

        MeData = Nothing
    End Function


    Public Function Execute(ByVal SQLString As String) As Boolean
        Dim mySQLCom As New MySqlCommand

        Try
            mySQLCom.Connection = myConn
            mySQLCom.CommandText = SQLString
            myConn.Open()
            mySQLCom.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            myConn.Close()
            mySQLCom = Nothing
        End Try
    End Function

    Public Function DataObject(ByVal command As String, Optional ByVal columnIndex As Integer = 0) As Object
        Dim retval As Object = Nothing
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String = command

        Dim cmd As New MySqlCommand(exec, cn)

        Dim myReader As MySqlDataReader
        myReader = cmd.ExecuteReader

        If Not myReader.HasRows Then
            retval = Nothing
        Else
            While myReader.Read()
                Try
                    retval = myReader(columnIndex)
                Catch ex As Exception
                    retval = Nothing
                    MsgBox(ex.Message)
                End Try
            End While
        End If

        Return retval

        cn.Close()
    End Function

    Public Function ExecuteSilence(ByVal SQLString As String) As Boolean
        Dim mySQLCom As New MySqlCommand

        Try
            mySQLCom.Connection = myConn
            mySQLCom.CommandText = SQLString
            myConn.Open()
            mySQLCom.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        Finally
            myConn.Close()
            mySQLCom = Nothing
        End Try
    End Function

#End Region

End Class
