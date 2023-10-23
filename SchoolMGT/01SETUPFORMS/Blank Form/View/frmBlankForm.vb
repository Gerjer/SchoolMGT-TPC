Public Class frmBlankForm
    Dim ListPresenter As BlankFormListPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListPresenter = New BlankFormListPresenter(Me)
    End Sub


End Class