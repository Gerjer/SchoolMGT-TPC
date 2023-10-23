Imports SchoolMGT
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraEditors.Repository
Imports System.Data.Common

Public Class StudentCareerListPresenter
    Private _view As frmStudentCareerList
    Dim ListModel As New StudentCareerListModel
    Dim StudentProfileist As New List(Of StudentProfileList)

    Public Sub New(view As frmStudentCareerList)
        _view = view

        loadComboBox()
        loadHandler()

    End Sub

    Private Sub loadHandler()

        AddHandler _view.cmbCourse.SelectionChangeCommitted, AddressOf LoadStudentWithCourse
        AddHandler _view.cmbBatch.SelectionChangeCommitted, AddressOf LoadStudentWithCourseAndBatch

    End Sub

    Private Sub LoadStudentWithCourseAndBatch(sender As Object, e As EventArgs)

        _view.gvCourseBatch.Columns.Clear()
        Dim dt As New DataTable
        dt = ListModel.getStudeentCareerCourse(_view.cmbCourse.SelectedValue, studentID)



        _view.gvStudentCareerList.Columns.Clear()


    End Sub

    Dim personID As Integer
    Dim studentID As String
    Public Property Adapter As Object

    Private Sub LoadStudentWithCourse(sender As Object, e As EventArgs)
        _view.gvStudentCareerList.Columns.Clear()
        Dim dt_StudentProfile As New DataTable
        dt_StudentProfile = ListModel.getStudentProfile(_view.cmbCourse.SelectedValue)

        If dt_StudentProfile.Rows.Count > 0 Then

            For Each rows As DataRow In dt_StudentProfile.Rows
                Dim obj As New StudentProfileList
                With obj
                    .person_id = If(IsDBNull(rows.Item("person_id")), 0, rows.Item("person_id"))
                    .id = If(IsDBNull(rows.Item("id")), 0, rows.Item("id"))
                    .last_name = If(IsDBNull(rows.Item("LAST NAME")), "", rows.Item("LAST NAME"))
                    .first_name = If(IsDBNull(rows.Item("FIRST NAME")), "", rows.Item("FIRST NAME"))
                    .middle_name = If(IsDBNull(rows.Item("MIDDLE NAME")), "", rows.Item("MIDDLE NAME"))
                    .gender = If(IsDBNull(rows.Item("GENDER")), "", rows.Item("GENDER"))
                    .birth_date = If(IsDBNull(rows.Item("BIRTH DATE")), "", rows.Item("BIRTH DATE"))
                    .contact_number = If(IsDBNull(rows.Item("CONTACT NUMBER")), "", rows.Item("CONTACT NUMBER"))
                    .course_name = If(IsDBNull(rows.Item("COURSE")), "", rows.Item("COURSE"))
                    .std_number = If(IsDBNull(rows.Item("STUDENT NUMBER")), "", rows.Item("STUDENT NUMBER"))
                    .LRN_number = If(IsDBNull(rows.Item("LRN NUMBER")), "", rows.Item("LRN NUMBER"))
                    .date_admitted = If(IsDBNull(rows.Item("DATE ADMITTED")), Date.Now, rows.Item("DATE ADMITTED"))
                    .scholarship = If(IsDBNull(rows.Item("SCHOLARSHIP")), Date.Now, rows.Item("SCHOLARSHIP"))
                    .career_status = If(IsDBNull(rows.Item("CAREER STATUS")), Date.Now, rows.Item("CAREER STATUS"))
                    .status = If(IsDBNull(rows.Item("STATUS")), Date.Now, rows.Item("STATUS"))
                End With
                StudentProfileist.Add(obj)

                If studentID = "" Then
                    studentID = rows.Item("id")
                Else
                    studentID = studentID & "," & rows.Item("id")
                End If

            Next

        End If

        '    _view.gcStudentCareerList.DataSource = dt_StudentProfile
        _view.TreeList1.DataSource = dt_StudentProfile

    End Sub



    Private Sub loadComboBox()

        CourseDropDownList()
        BatchDropDownList()

    End Sub

    Private Sub CourseDropDownList()

        _view.cmbCourse.DataSource = ListModel.getCourse()
        _view.cmbCourse.ValueMember = "ID"
        _view.cmbCourse.DisplayMember = "Name"
        _view.cmbCourse.SelectedIndex = -1

    End Sub

    Private Sub BatchDropDownList()
        _view.cmbBatch.DataSource = ListModel.getBacth()
        _view.cmbBatch.ValueMember = "ID"
        _view.cmbBatch.DisplayMember = "Name"
        _view.cmbBatch.SelectedIndex = -1

    End Sub
End Class
