Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class clsSQLGeneric

    'Returns Datatable
    Public Function customCommandDataTable(ByVal command As String) As DataTable
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()

        Dim exec As String
        exec = command
        Dim cmd As New MySqlCommand(exec, cn)

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("custom_command")

        Try
            SA.Fill(DS, "custom_command")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return DS.Tables("custom_command")

        cn.Close()
    End Function

    'Returns Boolean 
    Public Function customCommand(ByVal command As String) As Boolean
        Dim retval As Boolean = False
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Open()
        Dim exec As String = command


        Dim cmd As New MySqlCommand(exec, cn)
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("Data has been saved!",MsgBoxStyle.Information)
            retval = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return retval

    End Function

    'Returns Object (Integer / String / Date) in specified column
    Public Function customCommandObject(ByVal command As String, Optional ByVal columnIndex As Integer = 0) As Object
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

End Class


''SQL Module
'Module SQLModule
'    Private SQL As New clsSQLGeneric

'    'get DataSource
'    Public Function DataSource(ByVal command As String) As DataTable
'        Return Sql.customCommandDataTable(command)
'    End Function

'    'SQL Command
'    Public Function SQLCommand(ByVal command As String) As Boolean
'        Return SQL.customCommand(command)
'    End Function

'    'get DataObject
'    Public Function DataObject(ByVal command As String, Optional ByVal column As Integer = 0) As Object
'        DataObject = SQL.customCommandObject(command, column)
'    End Function

'End Module




Module SQLModule

    Public ADV_global_prnt_settings_4_CHECK As New PrinterSettings With {.PrinterName = "EPSON LX-300+ /II"}
    Public global_prnt_settings As New PrinterSettings With {.PrinterName = "EPSON FX-2175"}

    'get DataSource
    Public Function DataSource(ByVal command As String) As DataTable
        Return SQL.customCommandDataTable(command)
    End Function

    'SQL Command
    Public Function SQLCommand(ByVal command As String) As Boolean
        Return SQL.customCommand(command)
    End Function

    'get DataObject
    Public Function DataObject(ByVal command As String, Optional ByVal column As Integer = 0) As Object
        DataObject = SQL.customCommandObject(command, column)
    End Function

    Public Function DataObject(ByVal command As String, ByVal column As String) As Object
        DataObject = SQL.customCommandObject(command, column)
    End Function

    Private SQL As New clsSQLGeneric
    Private transact As MySqlTransaction
    Dim cmd As MySqlCommand

    'Begin the Transaction by opening the connection
    Public Sub StartTransaction()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        cmd = New MySqlCommand()
        transact = cn.BeginTransaction
        cmd.Transaction = transact
    End Sub
    'End the Transaction by closing the connection
    Public Sub EndTransaction()
        cn.Close()
    End Sub

    Public Sub commitQuery()
        transact.Commit()
    End Sub

    Public Sub rollbackQuery()
        Try
            transact.Rollback()
        Catch ex As Exception
        End Try
    End Sub
    Public Function DataSource(ByVal command As String, ByVal transactional As Boolean) As DataTable
        cmd.CommandText = command
        cmd.Connection = cn

        Dim SA As New MySqlDataAdapter(cmd)
        Dim DS As New DataSet("custom_command")

        SA.Fill(DS, "custom_command")

        Return DS.Tables("custom_command")
    End Function
End Module