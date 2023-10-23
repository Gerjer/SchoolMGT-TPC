Public Class frmBillingStatement

    Dim Presenter As BillingStatementPresenter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Presenter = New BillingStatementPresenter(Me)
    End Sub


End Class