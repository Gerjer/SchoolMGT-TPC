Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Module SW_Mod
    Public clsDBConn As clsDBConnection

    Public Const CONNECTION_REGISTRY_NAME As String = "ANT_ARKSOFT_SCHOOLMGT"

    Dim _ServerName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "ServerName")
    Dim _DatabaseName As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "DatabaseName")
    Dim _UserID As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "UserName")
    Dim _Password As String = GetSetting(CONNECTION_REGISTRY_NAME, "Connection", "Password")
    Public cn As New MySqlConnection(String.Format("Data Source={0};Database={1};Uid={2};Pwd={3}", _ServerName, _DatabaseName, _UserID, _Password))

    Public Function CREATERANDOMSALT() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function HASH512(ByVal password As String, ByVal salt As String) As String

        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(salt & password) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword ' boom there goes the encrypted password!

    End Function

End Module
