Imports DevExpress.Utils.Menu

Public Class frmGraduateStudent

    Dim RecordPresenter As GraduateStudentRecordPresenter
    Public _personID As Integer
    Public _class_roll_number As Integer
    Public Tag_description As String
    Public Incomplete As Integer
    Public graduate_student_id As Integer = 0


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        RecordPresenter = New GraduateStudentRecordPresenter(Me)

    End Sub

    Private Sub frmGraduateStudent_Load(sender As Object, e As EventArgs) Handles Me.Load

        '     RecordPresenter._personID = PERSON_ID
        '      RecordPresenter._class_roll_number = _class_roll_number
        '      RecordPresenter.graduate_student_id = graduate_student_id
        '   RecordPresenter.LoadDetails()

        Dim popupMenu As New DXPopupMenu()
        popupMenu.Items.Add(New DXMenuItem() With {.Caption = "Menu Item"})
        popupMenu.Items.Add(New DXMenuCheckItem() With {.Caption = "Check Item"})
        ddbPrintSelect.DropDownControl = popupMenu

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub btnPrintTOR_Click(sender As Object, e As EventArgs, Optional ClasRollNo As Integer = Nothing, Optional TypeOfPrint As String = Nothing, Optional DateIsuued As Date = Nothing) Handles btnPrintTOR.Click
        '     RecordPresenter.PrintTOR(sender, e, ClasRollNo, TypeOfPrint, DateIsuued)
        RecordPresenter.PrintTOR_New(sender, e, ClasRollNo, TypeOfPrint, DateIsuued)
    End Sub

End Class