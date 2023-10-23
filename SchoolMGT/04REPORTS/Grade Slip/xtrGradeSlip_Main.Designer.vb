<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xtrGradeSlip_Main
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
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrLine1, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 765.926!
        Me.Detail.Name = "Detail"
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine1.LineWidth = 3.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 363.4075!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(797.9999!, 23.0!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 763.926!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003532128!, 395.4075!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(797.9999!, 368.5186!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New SchoolMGT.xtrGradeSlip()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(797.9999!, 363.4075!)
        '
        'xtrGradeSlip_Main
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 25, 25)
        Me.PageHeight = 1300
        Me.PaperKind = System.Drawing.Printing.PaperKind.Folio
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
End Class
