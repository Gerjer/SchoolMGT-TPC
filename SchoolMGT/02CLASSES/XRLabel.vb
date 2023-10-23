Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI

<DefaultBindableProperty("Text")>
Public Class XRLabel
    Inherits XRFieldEmbeddableControl
    Implements IEditOptionsContainer

    Public Property AllowMarkupText As Boolean
End Class

Friend Interface IEditOptionsContainer
End Interface
