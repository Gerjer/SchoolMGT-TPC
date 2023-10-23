Imports SchoolMGT
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraReports.UI

Public Class ChedEFormBCListPresenter
    Private _view As frmChed_E_FormBC
    Dim ListModel As New ChedEFormBCListModel
    Public Sub New(view As frmChed_E_FormBC)
        _view = view
        loadComboBox()
        loadHandler()
    End Sub

    Private Sub loadHandler()
        AddHandler _view.cmbAcademicYear.SelectedIndexChanged, AddressOf cmbAcademicYear_SelectedIndexChanged
        AddHandler _view.btnGenerate.Click, AddressOf btnGenerate_Click
        AddHandler _view.btnSearch.Click, AddressOf btnSearch_Click
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        Dim dt As New DataTable
        dt = ListModel.getChedList(_view.cmbAcademicYear.Text, _view.cmbSemester.Text)
        If dt.Rows.Count > 0 Then

            _view.gcChedEFormB_C.DataSource = dt
            _view.BandedGridView1.BeginUpdate()
            _view.gridBand5.Caption = _view.cmbSemester.Text & ", AY " & _view.cmbAcademicYear.Text
            _view.BandedGridView1.EndUpdate()
        Else
            MsgBox("No Records Found...")
        End If

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs)

        Cursor.Current = Cursors.WaitCursor

        Dim report As New xtrCHED_E_Form_B_C

        report.PrintableComponentContainer1.PrintableComponent = _view.gcChedEFormB_C
        report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        report.CreateDocument()
        report.ShowPreview

        Cursor.Current = Cursors.Default


    End Sub

    Private Sub cmbAcademicYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        '   Throw New NotImplementedException()
    End Sub

    Private Sub loadComboBox()

        _view.cmbAcademicYear.DataSource = ListModel.getAcademicYear
        _view.cmbAcademicYear.ValueMember = "id"
        _view.cmbAcademicYear.DisplayMember = "name"
        _view.cmbAcademicYear.SelectedValue = -1

    End Sub
End Class
