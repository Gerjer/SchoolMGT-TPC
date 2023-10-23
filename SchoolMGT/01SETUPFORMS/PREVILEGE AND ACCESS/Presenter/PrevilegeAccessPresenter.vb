Imports System.Web.UI.WebControls
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports SchoolMGT

Public Class PrevilegeAccessPresenter
    Private _view As frmPrevilegeAccess
    Dim Model As New PrevilegeAccessModel


    Public Sub New(frmPrevilegeAccess As frmPrevilegeAccess)
        _view = frmPrevilegeAccess

        loadEmployee()
        loadPrevilege()

        loadHandler()
    End Sub

    Private Sub loadHandler()

        '       AddHandler _view.btnAdd.Click, AddressOf ApplyPrevilegeAccess
        '    AddHandler _view.btnEdit.Click, AddressOf EditPrevilegeAccess
        AddHandler _view.gvEmployeeList.DoubleClick, AddressOf ShowUsersFunctionaliy
        AddHandler _view.btnAdd.Click, AddressOf AddPrivilegeAccess
        AddHandler _view.btnRefresh.Click, AddressOf RefreshList
        AddHandler _view.gvPrevilege.MouseUp, AddressOf getRowSelected

    End Sub

    Dim rowHandle As Integer
    Private Sub getRowSelected(sender As Object, e As MouseEventArgs)
        rowHandle = _view.gvPrevilege.FocusedRowHandle
    End Sub


    Private Sub RefreshList(sender As Object, e As EventArgs)
        loadPrevilege()
    End Sub

    Private Sub AddPrivilegeAccess(sender As Object, e As EventArgs)
        processButton(sender)
    End Sub

    Dim user_id As Integer
    Private Sub ShowUsersFunctionaliy(sender As Object, e As EventArgs)

        _view.btnAdd.Text = "Edit"

        user_id = _view.gvEmployeeList.GetFocusedRowCellValue("user_id")

        Dim dt As New DataTable
        dt = Model.getUsersFunctionaliy(user_id)

        If dt.Rows.Count > 0 Then
            _view.gcPrevilege.DataSource = dt
        Else
            dt = _view.gcPrevilege.DataSource
            For Each row As DataRow In dt.Rows
                If row.Item("INCLUDE") = "True" Then
                    row.Item("INCLUDE") = "False"
                End If
            Next
            _view.gcPrevilege.DataSource = dt
        End If

    End Sub


    Friend Sub UserType(UserType As String)

        _view.gvPrevilege.BeginDataUpdate()
        _view.gvPrevilege.SetRowCellValue(rowHandle, "TYPE OF USER", UserType)
        _view.gvPrevilege.EndDataUpdate()
    End Sub

    Private Sub EditPrevilegeAccess(sender As Object, e As EventArgs)
        processButton(sender)
    End Sub

    Public Sub processButton(sender As Object)

        Cursor.Current = Cursors.WaitCursor

        Dim check As Integer = 0
        Dim dt As New DataTable

        dt = _view.gcEmployeeList.DataSource
        'For Each row As DataRow In dt.Rows
        '    If row.Item("INCLUDE").ToString = "True" Then
        '        check = 1
        '    Else
        '        check = 0
        '    End If
        'Next

        '       If check = 1 Then

        Dim button As DevExpress.XtraEditors.SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
        If button.Text = "Edit" Then
            Operation = "EDIT"
        Else
            Operation = "ADD"
        End If


        Dim dtEmployee As New DataTable
        dtEmployee = _view.gcEmployeeList.DataSource

        Dim dtPrevilege As New DataTable
        dtPrevilege = _view.gcPrevilege.DataSource

        Dim dtAccess As New DataTable
        dtAccess = _view.gcAccess.DataSource

        Model.Insert(dtEmployee, dtPrevilege, dtAccess, Operation)

        If _view.btnAdd.Text = "Edit" Then
            _view.btnAdd.Text = "Add"
        End If

        MessageBox.Show("USER's Privilege and Access has been added...Successfully!")

        '       Else

        '       MsgBox("Pls...Select Instructor on the CheckBox", MsgBoxStyle.Information, "REQUIRED FIELDS")

        '    End If

        Cursor.Current = Cursors.Default

    End Sub

    Dim Operation As String = ""

    'Private Sub ApplyPrevilegeAccess(sender As Object, e As EventArgs)

    '    processButton(sender)

    'End Sub

    Public Sub loadPrevilege()
        Dim dt As New DataTable
        dt = Model.getPrevilege()
        _view.gcPrevilege.DataSource = dt

    End Sub

    Private Sub loadEmployee()
        Dim dt As New DataTable
        dt = Model.getEmployeeList()
        _view.gcEmployeeList.DataSource = dt
    End Sub
End Class
