Imports DevExpress.XtraGrid.Views.Grid
Imports SchoolMGT
Imports System.Net.Mail
Imports System.Threading
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Reflection
Imports System.Version


Public Class frmNewStudentAdmissionList

    Dim ListPresenter As StudentAdmissionListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New StudentAdmissionListPresenter(Me)

    End Sub


    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Me.Close()
    End Sub

    Private Sub frmNewStudentAdmissionList_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class