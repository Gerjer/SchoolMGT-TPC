Public Class clsData
    'Tamers Note
    'FielName = name of the Control just remove "txt" keyword
    'TableName= Tag value for SysPK Control and "AccessibleName" for Common Control
#Region "Constructor"
    Sub New()
        MeData = New DataTable
        MeTableFields = New Collection
    End Sub

    Sub New(ByVal SysPKControl As Control, ByVal DatabaseConnection As clsDBConnection)
        MeSysPKControl = SysPKControl
        MeData = New DataTable
        MeTableFields = New Collection
        MeFormControls = New Collection
        clsDB = DatabaseConnection
        TableName = SysPKControl.Tag
        MeFormControls.Add(SysPKControl, SysPKControl.Name.Replace("txt", ""))
    End Sub

    Private Sub Detach()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Me.Detach()
    End Sub
#End Region

#Region "Declarations"
    Private clsDB As clsDBConnection
    Private MeData As DataTable
    Private MeTableFields As Collection
    Private MeFormControls As Collection

    Private WithEvents MeSysPKControl As Control
    Private WithEvents UserPKControl As Control
    Private WithEvents AddButton As Control
    Private WithEvents SaveButton As Control
    Private WithEvents DeleteButton As Control
    Private WithEvents ModifyButton As Control
    Private WithEvents ResetButton As Control

    Private TableName As String = ""
    Private sqlSELECT As String = ""
    Private sqlFROM As String = ""
    Private sqlWHERE As String = ""
    Private SQLString As String = ""
    Private Criteria As String = ""
    Private AddingMode As Boolean = False

    Public Event AdditionalWhere(ByRef Criteria As String)
    Public Event BeforeRecordSave()
    Public Event AfterRecordSave()
    Public Event BeforeDelete()
    Public Event AfterDelete()
    Public Event AddButtonClick()
    Public Event EditButtonClick()

#End Region

#Region "Properties"
    Public WriteOnly Property AttachControl() As Control
        Set(ByVal value As Control)
            Dim FieldName As String = value.Name.ToString.Replace("txt", "")
            Dim ControlTableName As String = value.AccessibleName.ToString
            Try
                If ControlTableName = TableName Then
                    MeTableFields.Add(FieldName, FieldName)
                    MeFormControls.Add(value, FieldName)
                End If               
            Catch ex As Exception
                MessageBox.Show(ex.Message, value.Name.ToString & " is attach twice....") '(value.Name.ToString & " is attach twice....", "Please Verify !")
            End Try
        End Set
    End Property

    Public WriteOnly Property AttachAddButton() As Control
        Set(ByVal value As Control)
            AddButton = value
        End Set
    End Property
    Public WriteOnly Property AttachModifyButton() As Control
        Set(ByVal value As Control)
            ModifyButton = value
        End Set
    End Property

    Public WriteOnly Property AttachSaveButton() As Control
        Set(ByVal value As Control)
            SaveButton = value
        End Set
    End Property

    Public WriteOnly Property AttachDeleteButton() As Control
        Set(ByVal value As Control)
            DeleteButton = value
        End Set
    End Property

    Public WriteOnly Property AttachResetButton() As Control
        Set(ByVal value As Control)
            ResetButton = value
        End Set
    End Property


    Public ReadOnly Property FormControls() As Collection
        Get
            Return MeFormControls
        End Get
    End Property

    Public WriteOnly Property AttachUserPK() As Control
        Set(ByVal value As Control)
            UserPKControl = value
        End Set
    End Property

    Public ReadOnly Property IsAdding() As Boolean
        Get
            Return AddingMode
        End Get
    End Property
#End Region

#Region "Methods and Subs"
    Public Sub Initialize()
        Me.AssembleSQLString()
        Me.EnableControls(False)
    End Sub

    Private Sub AssembleSQLString()
        'SELECT
        sqlSELECT = MeSysPKControl.Name.ToString.Replace("txt", "") & ","
        For Each Field As String In MeTableFields
            sqlSELECT = String.Format("{0}{1},", sqlSELECT, Field)
        Next
        sqlSELECT = Left(sqlSELECT, Len(sqlSELECT) - 1)

        'FROM
        sqlFROM = TableName

        'WHERE
        Criteria = ""
        RaiseEvent AdditionalWhere(Criteria)
        If Criteria.Trim <> "" Then
            sqlWHERE = String.Format("{0} AND {1}", sqlWHERE, Criteria)
        End If

        If sqlSELECT.Trim <> "" Then
            SQLString = String.Format("SELECT {0}", sqlSELECT)
        End If
        If sqlFROM.Trim <> "" Then
            SQLString = String.Format("{0} FROM {1}", SQLString, sqlFROM)
        End If

        If sqlWHERE.Trim <> "" Then
            SQLString = String.Format("{0} WHERE {1}", SQLString, sqlWHERE)
        End If
    End Sub

    Public Function RecordSave(Optional ByVal IsUpdate As Boolean = False) As Boolean
        If IsUpdate Then
            If Me.UpdateRecord() Then
                MessageBox.Show("Record Updated...", "Successfully!")
            End If
        Else
            If Me.NewRecord() Then
                MessageBox.Show("Record Save...", "Successfully!")
            End If
        End If
    End Function

    Private Function NewRecord() As Boolean
        Dim DataType As Type = Nothing
        Dim ControlValue As String = ""
        Dim sqlSELECTVALUE As String = ""
        Dim mysqlSELECT As String = ""
        Dim FieldName As String = ""
        Dim SQL As String = ""

        MeSysPKControl.Text = System.Guid.NewGuid.GetHashCode

        AddingMode = True
        RaiseEvent BeforeRecordSave()

        If sqlWHERE.Trim <> "" Then
            Criteria = String.Format("{0}=0", MeSysPKControl.Name.Replace("txt", ""))
        Else
            Criteria = String.Format(" WHERE {0}=0", MeSysPKControl.Name.Replace("txt", ""))
        End If

        MeData = clsDB.ExecQuery(SQLString & Criteria) 'use for identifying data types for formatting
        Try

        
            For Each icontrol As Control In MeFormControls
                FieldName = icontrol.Name.Replace("txt", "")
                ControlValue = icontrol.Text.Replace("'", "`").Replace("\", "/")
                DataType = MeData.Columns(FieldName).DataType
                Select Case DataType.Name
                    Case "Decimal", "Double"
                        ControlValue = Val(ControlValue.ToString.Replace(",", ""))
                        mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                        sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                    Case "DateTime"
                        If ControlValue.Trim <> "" Then
                            ControlValue = String.Format("'{0}'", Format(CDate(ControlValue), "yyyy-MM-dd")) 'yyyy-MM-dd h:mm tt
                            mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                            sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                        End If
                    Case "Integer", "Int16"
                        ControlValue = Convert.ToInt16(ControlValue.ToString.Replace(",", ""))
                        mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                        sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                    Case "Int32"
                        ControlValue = Convert.ToInt32(ControlValue.ToString.Replace(",", ""))
                        mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                        sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                    Case "Int64"
                        ControlValue = Convert.ToInt64(ControlValue.ToString.Replace(",", ""))
                        mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                        sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                    Case Else
                        ControlValue = String.Format("'{0}'", ControlValue.ToString)
                        mysqlSELECT = String.Format("{0},{1}", mysqlSELECT, FieldName)
                        sqlSELECTVALUE = String.Format("{0},{1}", sqlSELECTVALUE, ControlValue)
                End Select
            Next

        Catch ex As Exception
            MessageBox.Show("Field: " & "'" & FieldName & "' " & ex.Message, "DB Write Error !")
            Application.DoEvents()
            RaiseEvent AfterRecordSave()
            Return False
        End Try
        'Clean up SQL Statements
        mysqlSELECT = Mid(mysqlSELECT, 2, Len(mysqlSELECT))
        sqlSELECTVALUE = Mid(sqlSELECTVALUE, 2, Len(sqlSELECTVALUE))

        SQL = String.Format("INSERT INTO {0}({1}) VALUES ({2})", TableName, mysqlSELECT, sqlSELECTVALUE)

        Try

            If clsDB.Execute(SQL) Then
                Application.DoEvents()
                RaiseEvent AfterRecordSave()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
            Return False
        End Try
    End Function

    Private Function UpdateRecord() As Boolean
        Dim DataType As Type = Nothing
        Dim ControlValue As String = ""
        Dim sqlSELECTVALUE As String = ""
        Dim mysqlSELECT As String = ""
        Dim FieldName As String = ""
        Dim SQL As String = ""

        AddingMode = False
        RaiseEvent BeforeRecordSave()

        If sqlWHERE.Trim <> "" Then
            Criteria = String.Format("{0}=0", MeSysPKControl.Name.Replace("txt", ""))
        Else
            Criteria = String.Format(" WHERE {0}=0", MeSysPKControl.Name.Replace("txt", ""))
        End If

        MeData = clsDB.ExecQuery(SQLString & Criteria) 'use for identifying data types for formatting
        Try

        
            For Each icontrol As Control In MeFormControls
                FieldName = icontrol.Name.Replace("txt", "")
                ControlValue = icontrol.Text.Replace("'", "`").Replace("\", "/")
                DataType = MeData.Columns(FieldName).DataType
                Select Case DataType.Name
                    Case "Decimal", "Double"
                        ControlValue = Val(ControlValue.ToString.Replace(",", ""))
                        sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                    Case "DateTime"
                        If ControlValue.Trim <> "" Then
                            ControlValue = String.Format("'{0}'", Format(CDate(ControlValue), "yyyy-MM-dd"))
                            sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                        End If
                    Case "Integer", "Int16"
                        ControlValue = Convert.ToInt16(ControlValue.ToString.Replace(",", ""))
                        sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                    Case "Int32"
                        ControlValue = Convert.ToInt32(ControlValue.ToString.Replace(",", ""))
                        sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                    Case "Int64"
                        ControlValue = Convert.ToInt64(ControlValue.ToString.Replace(",", ""))
                        sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                    Case Else
                        ControlValue = String.Format("'{0}'", ControlValue.ToString)
                        sqlSELECTVALUE = String.Format("{0},{1}={2}", sqlSELECTVALUE, FieldName, ControlValue)
                End Select
            Next

        Catch ex As Exception
            MessageBox.Show("Field: " & "'" & FieldName & "' " & ex.Message, "DB Update Error !")
            Application.DoEvents()
            RaiseEvent AfterRecordSave()
            Return False
        End Try

        'Clean up SQL Statements
        sqlSELECTVALUE = Mid(sqlSELECTVALUE, 2, Len(sqlSELECTVALUE))

        SQL = String.Format("UPDATE {0} SET {1} WHERE {2}={3}", TableName, sqlSELECTVALUE, MeSysPKControl.Name.Replace("txt", ""), MeSysPKControl.Text)

        Try
            clsDB.Execute(SQL)
            Application.DoEvents()
            RaiseEvent AfterRecordSave()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
            Return False
        End Try
    End Function

    Private Function DeleteRecord() As Boolean
        Dim FieldName As String = MeSysPKControl.Name.Replace("txt", "")
        Dim SQL As String = String.Format("DELETE FROM {0} WHERE {1}={2}", TableName, FieldName, MeSysPKControl.Text)
        Try
            clsDB.Execute(SQL)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
            Return False
        End Try
    End Function

    Private Sub ClearControls()
        For Each iControl As Control In MeFormControls
            If iControl.Tag <> "1" Then
                Try
                    iControl.Text = ""
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub

    Private Function AutoNumber() As String
        Dim FieldName As String = UserPKControl.Name.Replace("txt", "")
        Dim SQL As String = String.Format(" SELECT max({0}) as UserPK FROM {1}", FieldName, TableName)
        Dim MeData As New DataTable
        Dim UserPK As String = ""
        Try
            MeData = clsDB.ExecQuery(SQL)
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

        Return UserPK
        MeData = Nothing
    End Function
#End Region

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If MessageBox.Show("Are sure you want to Save/Update this record?", "Please Verify !", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If UserPKControl.Text.Trim = "" Then
                UserPKControl.Text = Me.AutoNumber
            End If
            If MeSysPKControl.Text.Trim <> "" Then
                If Me.RecordSave(True) Then
                    Me.ClearControls()
                    Me.EnableControls(False)
                End If
            Else
                If Me.RecordSave(False) Then
                    Me.ClearControls()
                    Me.EnableControls(False)

                End If
            End If
            
        End If
    End Sub

    Private Sub AddButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddButton.Click
        AddingMode = True
              Me.ClearControls()
        Me.EnableControls(True)
        RaiseEvent AddButtonClick()

    End Sub
    Private Sub ModifyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifyButton.Click
        AddingMode = True
        'Me.ClearControls()
        Me.EnableControls(True)
        RaiseEvent EditButtonClick()
      
    End Sub
    Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Are you sure you want to DELETE this record?", "Please verify....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            RaiseEvent BeforeDelete()
            If Me.DeleteRecord() Then
                MessageBox.Show("The record is deleted....", "Successfully !")
                Me.ClearControls()
            End If
            RaiseEvent AfterDelete()
        End If

    End Sub

    Private Sub EnableControls(ByVal iEnabled As Boolean)
        For Each iControl As Control In MeFormControls
            If iControl.Tag <> "1" Then
                If iEnabled Then
                    iControl.Enabled = True
                Else
                    iControl.Enabled = False
                End If
            End If
        Next
    End Sub
End Class
