Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class frmStudentCareerList

    Dim ListPresenter As StudentCareerListPresenter
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListPresenter = New StudentCareerListPresenter(Me)

    End Sub


End Class
