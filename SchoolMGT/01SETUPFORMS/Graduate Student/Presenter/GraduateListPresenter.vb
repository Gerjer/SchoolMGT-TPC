Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports SchoolMGT

Public Class GraduateListPresenter
    Private _view As frmGraduateList
    Dim ListModel As New GraduateListModel
    Dim graduate_student_id As Integer
    Dim _Function_type As String = ""
    Public Sub New(frmGraduateList As frmGraduateList)
        _view = frmGraduateList

        loadHandler()
        loadList()
        loadStudentList()
        loadPRCList()


    End Sub

    Public Sub loadPRCList()

        If FUNCTION_TYPE = "PRC" Then
            _view.TabControl4.TabIndex = 0
        Else
            _view.TabControl4.TabIndex = 1
        End If

        Try
            _view.gcPRC.DataSource = Nothing
            Dim dt As New DataTable
            dt = ListModel.LoadPRC

            _view.gcPRC.BeginUpdate()
            _view.gcPRC.DataSource = dt
            _view.gcPRC.EndUpdate()
            _view.gcPRC.RefreshDataSource()
            '           _view.BandedGridView1.DataSource = dt.TableName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadStudentList()
        Try
            _view.gcList.DataSource = Nothing
            Dim dt As New DataTable
            dt = ListModel.LoadStudent
            _view.gcList.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub

    Private Sub loadHandler()
        AddHandler _view.btnAdd.Click, AddressOf btnAdd_Click
        AddHandler _view.btnList.Click, AddressOf btnList_Click
        AddHandler _view.btnPRC.Click, AddressOf btnPRC_Click
        AddHandler _view.gvList.RowCellClick, AddressOf gvList_RowCellClick
        AddHandler _view.btnclose.Click, AddressOf btnClose_Click
        AddHandler _view.btnOpen.Click, AddressOf btnOpen_Click
        AddHandler _view.gvGradStudent.RowCellClick, AddressOf gvGradStudent_RowCellClick
        AddHandler _view.btnprintPRC.Click, AddressOf btnprintPRC_Click
        AddHandler _view.EditRecordToolStripMenuItem.Click, AddressOf EditRecordToolStrip_Click
        AddHandler _view.btnRefresh.Click, AddressOf btnRefresh_Click
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        loadList()
        loadPRCList()
    End Sub

    Private Sub EditRecordToolStrip_Click(sender As Object, e As EventArgs)
        Try
            If GRADUATED_STUDENT_ID > 0 Then
                If _view.TabControl4.SelectedTabIndex = 0 Then

                Else
                    FUNCTION_TYPE = "PRC"
                End If

                Dim frm As New frmGraduateStudent
                frm.graduate_student_id = GRADUATED_STUDENT_ID
                frm.BringToFront()
                frm.Show()

                loadList()
                loadStudentList()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprintPRC_Click(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        Try
            Dim report As New xtrPRCList
            report.PrintableComponentContainer1.PrintableComponent = _view.gcPRC
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1
            report.CreateDocument()
            report.ShowPreview

        Catch ex As Exception

        End Try

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnPRC_Click(sender As Object, e As EventArgs)
        Try
            If GRADUATED_STUDENT_ID > 0 Then
                FUNCTION_TYPE = "PRC"
                Dim frm As New frmGraduateStudent
                frm.graduate_student_id = GRADUATED_STUDENT_ID
                frm.BringToFront()
                frm.Show()

                loadList()
                loadStudentList()

            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub gvGradStudent_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        Dim view As GridView = DirectCast(sender, GridView)

        PERSON_ID = view.GetFocusedRowCellDisplayText("person_id")
        CLASS_ROLL_NO = view.GetFocusedRowCellDisplayText("class_roll_number")
        GRADUATED_STUDENT_ID = view.GetFocusedRowCellDisplayText("id")

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs)
        '   _view.SplitContainerControl1.Collapsed = False
        Try
            If GRADUATED_STUDENT_ID > 0 Then
                If _view.TabControl4.SelectedTabIndex = 0 Then

                Else
                    FUNCTION_TYPE = "PRC"
                End If

                Dim frm As New frmGraduateStudent
                frm.graduate_student_id = GRADUATED_STUDENT_ID
                frm.BringToFront()
                frm.Show()

                loadList()
                loadStudentList()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

        If _view.btnclose.Tag = 1 Then
            _view.btnclose.Text = "Hide"
            _view.btnclose.ImageOptions.Image = Global.SchoolMGT.My.Resources.Resources.hide_16x16
            _view.btnclose.Tag = 0
            _view.SplitContainerControl1.Collapsed = True
        Else
            _view.btnclose.Text = "Show"
            _view.btnclose.ImageOptions.Image = Global.SchoolMGT.My.Resources.Resources.show_16x16
            _view.btnclose.Tag = 1
            _view.SplitContainerControl1.Collapsed = False
        End If



    End Sub

    Private Sub gvList_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        Dim view As GridView = DirectCast(sender, GridView)
        Try

            PERSON_ID = view.GetFocusedRowCellDisplayText("person_id")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs)

        Try
            frmGraduateStudent.btnPrintTOR_Click(sender, e, CLASS_ROLL_NO, "View Only")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Try
            If PERSON_ID > 0 Then
                FUNCTION_TYPE = ""
                GRADUATED_STUDENT_ID = 0
                Dim frm As New frmGraduateStudent
                frm.graduate_student_id = GRADUATED_STUDENT_ID

                frm.BringToFront()
                frm.Show()

                loadList()
                loadStudentList()

            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub loadList()
        Try
            _view.gcGradStudent.DataSource = Nothing

            _view.gcGradStudent.BeginUpdate()
            _view.gcGradStudent.DataSource = ListModel.LoadList()
            _view.gcGradStudent.RefreshDataSource()
            _view.gcGradStudent.EndUpdate()

        Catch ex As Exception

        End Try
    End Sub
End Class
