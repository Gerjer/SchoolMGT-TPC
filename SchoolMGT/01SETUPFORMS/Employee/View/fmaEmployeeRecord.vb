Imports System.IO
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPdfViewer
'Imports DevExpress.XtraGrid.Views.Base.ColumnView

Public Class fmaEmployeeRecord

    Dim RecordPresenter As EmployeeRecordPresenter
    Public _id As Integer
    Public _personID As Integer

    Dim ListOfAchievemenst As New List(Of ListOfAchievements)

    Public Event FORM_CLOSING()




    Public Sub New(Optional OPERATION As String = Nothing, Optional TAG As String = Nothing, Optional NAME As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RecordPresenter = New EmployeeRecordPresenter(Me, OPERATION, TAG, NAME)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '      RecordPresenter.cleanControls(Me)
        '   RecordPresenter.ClearForm()
        Me.Close()
        'fmaEmployeeListForm.displayFilterCategory()
    End Sub

    Private Sub fmaEmployeeRecord_Load(sender As Object, e As EventArgs) Handles Me.Load

        RecordPresenter.loadComboBox()
        RecordPresenter.Edit(_personID)

        If Me.Tag = 1 Then
            TabItem1.Visible = True
            TabItem3.Visible = True
            TabItem4.Visible = True
            TabItem5.Visible = True
            TabItem15.Visible = False
        Else

            TabItem1.Visible = True
            TabItem15.Visible = True
            TabItem4.Visible = True
            TabItem5.Visible = True
            TabItem3.Visible = False

            TabItem20.Visible = True
            TabItem21.Visible = True

        End If

    End Sub

    Private Sub txtemployee_number_LostFocus(sender As Object, e As EventArgs) Handles txtemployee_number.LostFocus

        If txtemployee_number.Text = "" Then
        Else
            If ifEmployeeNumbeExist(txtemployee_number.Text) Then
                MsgBox("Employee Number Already Exists")
                txtemployee_number.Text = ""
            End If
        End If

    End Sub

    Private Function ifEmployeeNumbeExist(employeeNumber As String) As Boolean

        Dim id As Integer = DataObject(String.Format("SELECT  `id` FROM `employees` WHERE employee_number = '" & employeeNumber & "'"))
        If id > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Private Sub btnAddBank_Click(sender As Object, e As EventArgs) Handles btnAddBank.Click
    '    gvBank.AddNewRow()
    '    gvBank.SetFocusedRowCellValue("Bank Name", txtBankName.Text)
    '    gvBank.SetFocusedRowCellValue("Account Number", txtAccountNumber.Text)
    'End Sub

    Private Sub txtpicturepath_MouseHover(sender As Object, e As EventArgs) Handles txtpicturepath.MouseHover
        RecordPresenter.ToolTip()
    End Sub

    Private Sub txtpicturepath_MouseLeave(sender As Object, e As EventArgs) Handles txtpicturepath.MouseLeave
        RecordPresenter.ToolTip1()
    End Sub

    Private Sub rbtnYesScholarship_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnYesScholarship.CheckedChanged
        txtScholarshipSponsor.Enabled = True
    End Sub

    Private Sub rbtnNoScholarship_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNoScholarship.CheckedChanged
        txtScholarshipSponsor.Enabled = False
    End Sub

    Private Sub rbtnYesAnotherCourse_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnYesAnotherCourse.CheckedChanged
        txtAnotherCourse.Enabled = True
    End Sub

    Private Sub rbtnNoAnotherCourse_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNoAnotherCourse.CheckedChanged
        txtAnotherCourse.Enabled = False
    End Sub


    Dim DocumentPath As String = ""
    Private Sub CreatFolder(FullName As String)

        Dim spath As String = Directory.GetCurrentDirectory & "\DOCUMENTS\"

        If (Not System.IO.Directory.Exists(Path.Combine(spath, FullName))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, FullName))
        End If

        spath = spath + FullName + "\"
        DocumentPath = spath

    End Sub

    Private Sub btnCancelListAchivement_Click(sender As Object, e As EventArgs) Handles btnCancelListAchivement.Click

    End Sub

    Private Sub LabelX91_Click(sender As Object, e As EventArgs)

        'Dim pdf As PdfViewer = New PdfViewer()
        ''       pdf.DocumentFilePath = "F:\GergerFiles\SourceCode\SchoolMgt\school_management\SCHOOL MANAGEMENT\docs\payroll_designation.pdf"
        ''       pdf.Show()
        ''       pdf.Print()

        ''  Dim bytes() As Byte = System.IO.File.ReadAllBytes(pdf.DocumentFilePath)
        ''      Dim ms As MemoryStream = New System.IO.MemoryStream(bytes)
        ''        pic_box_save.Image = Image.FromStream(ms)
        ''pdf.LoadDocument(ms)
        ''      pdf.Sh
        ''      pdf.LoadDocument()

        'pdf.FindForm.ShowDialog()
    End Sub

    'Private Sub gvAttachAchievements_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvAttachAchievements.RowCellStyle
    '    Dim ColumnName As String = ""

    '    If gvAttachAchievements.RowCount > 0 Then
    '        If (e.RowHandle > 0) Then
    '            If gvAttachAchievements.Columns("File Path").FieldName = "File Path" Then
    '                e.Appearance.ForeColor = Color.RoyalBlue
    '                e.Appearance.FontStyleDelta = FontStyle.Underline
    '            Else
    '                e.Appearance.ForeColor = Color.Black
    '                e.Appearance.FontStyleDelta = FontStyle.Regular
    '            End If
    '            '          gvAttachAchievements.BestFitColumns()
    '        End If
    '    End If


    '   End Sub

    Private Sub gvAttachAchievements_DoubleClick(sender As Object, e As EventArgs) Handles gvAttachAchievements.DoubleClick
        'IO.Path.Combine(rows.FilePath, IO.Path.GetFileName(rows.FileName)
        Dim LinkFile As String = ""
        Dim FullPath As String = Application.ExecutablePath
        Dim FileName As String = ""
        If gvAttachAchievements.RowCount > 0 Then
            FullPath = Path.Combine(Path.GetDirectoryName(gvAttachAchievements.Columns.View.GetFocusedRow("File Path").ToString))
            '        FullPath = FullPath.Replace("\", "\\")
            FileName = gvAttachAchievements.Columns.View.GetFocusedRow("File Name").ToString
            LinkFile = IO.Path.Combine(FullPath, FileName)
            If My.Computer.FileSystem.FileExists(LinkFile) Then
                Process.Start(LinkFile)
            Else
                MsgBox("File does not exist", MsgBoxStyle.Critical, "FIL NOT FOUND")
            End If
        End If

    End Sub


    Private Sub ButtonX27_Click(sender As Object, e As EventArgs) Handles ButtonX27.Click

        Dim Link As String = ""
        Dim Initial_Directory As String = ""
        If gvAttachAchievements.RowCount > 0 Then
            Initial_Directory = Path.Combine(Directory.GetCurrentDirectory, "DOCUMENTS", txtfull_name.Text & "\")
            With OpenFileDialog2
                .Title = "Select an Image"  ' Path.GetFileName(.FileName)
                .InitialDirectory = Initial_Directory
                .Filter = "All files (*.*)|*.*" '"JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
                .FilterIndex = 1
                '           .ShowDialog()
            End With
            OpenFileDialog2.Dispose()
            If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Link = IO.Path.Combine(OpenFileDialog2.InitialDirectory, OpenFileDialog2.FileName)
                Process.Start(Link)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtAttach_Filename.Enabled = True
    End Sub

    Private Sub gvAttachment_DoubleClick(sender As Object, e As EventArgs) Handles gvAttachment.DoubleClick
        Dim LinkFile As String = ""
        Dim FullPath As String = Application.ExecutablePath
        Dim FileName As String = ""
        If gvAttachment.RowCount > 0 Then
            FullPath = Path.Combine(Path.GetDirectoryName(gvAttachment.Columns.View.GetFocusedRow("File Path").ToString))
            '        FullPath = FullPath.Replace("\", "\\")
            FileName = gvAttachment.Columns.View.GetFocusedRow("File Name").ToString
            LinkFile = IO.Path.Combine(FullPath, FileName)
            If My.Computer.FileSystem.FileExists(LinkFile) Then
                Process.Start(LinkFile)
            Else
                MsgBox("File does not exist", MsgBoxStyle.Critical, "FIL NOT FOUND")
            End If
        End If
    End Sub

    Private Sub ButtonX28_Click(sender As Object, e As EventArgs) Handles ButtonX28.Click

        Dim Link As String = ""
        Dim Initial_Directory As String = ""
        If gvAttachAchievements.RowCount > 0 Then
            Initial_Directory = Path.Combine(Directory.GetCurrentDirectory, "DOCUMENTS", txtfull_name.Text & "\")
            With OpenFileDialog2
                .Title = "Select an Image"  ' Path.GetFileName(.FileName)
                .InitialDirectory = Initial_Directory
                .Filter = "All files (*.*)|*.*" '"JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
                .FilterIndex = 1
                '           .ShowDialog()
            End With
            OpenFileDialog2.Dispose()
            If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Link = IO.Path.Combine(OpenFileDialog2.InitialDirectory, OpenFileDialog2.FileName)
                Process.Start(Link)
            End If
        End If

    End Sub

    Private Sub txtfull_name_TextChanged(sender As Object, e As EventArgs) Handles txtfull_name.TextChanged
        Me.WinLabel.Text = txtfull_name.Text
    End Sub

    Private Sub dtpDependentBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDependentBirthDate.ValueChanged
        txtDependentAge.Text = GetCurrentAge(dtpDependentBirthDate.Value)
    End Sub

    Private Sub TabControlPanel13_Click(sender As Object, e As EventArgs) Handles TabControlPanel13.Click

    End Sub

    Private Sub txtStudentID_LostFocus(sender As Object, e As EventArgs) Handles txtStudentID.LostFocus
        RecordPresenter.CheckIfStudentIDExist()
    End Sub

    Private Sub cmbDocumentType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDocumentType.SelectionChangeCommitted

        If cmbDocumentType.SelectedItem IsNot Nothing Then
            txtAttachment_FilePath.Text = ""
            txtAttach_Filename.Text = ""
        End If

    End Sub

    Private Sub fmaEmployeeRecord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent FORM_CLOSING()
    End Sub



    '  Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged


    'Private Sub txtStudentID_Leave(sender As Object, e As EventArgs) Handles txtStudentID.Leave
    '    RecordPresenter.CheckIfStudentIDExist()
    'End Sub

    'Private Sub btnAddListAchivement_Click(sender As Object, e As EventArgs) Handles btnAddListAchivement.Click
    '    If dt_LisOfAchievements.Rows.Count = 0 Or dt_LisOfAchievements.Rows.Count > 0 Then
    '        dt_LisOfAchievements.Rows.Add(DocumentPath)
    '    End If

    '    gcAttachAchievements.DataSource = dt_LisOfAchievements

    '    Dim obj As New ListOfAchievements
    '    With obj
    '        .FilePath = DocumentPath
    '        .Picture_Box.Image = Picture_Box.Image
    '        .File_Image = Picture_Box.Image
    '    End With
    '    ListOfAchievemenst.Add(obj)

    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    '    RecordPresenter.ListOfAchievments(ListOfAchievemenst)

    'End Sub
End Class