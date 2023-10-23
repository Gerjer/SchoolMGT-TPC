<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport_EnrollmentForm_MultiCopies
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1})
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 914.0634!
        Me.Detail.Name = "Detail"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(650.0!, 450.48!)
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 463.48!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(650.0!, 448.4799!)
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LineWidth = 3.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 450.48!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(650.0!, 13.0!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XtraReport_EnrollmentForm_MultiCopies
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 50, 50)
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
End Class
