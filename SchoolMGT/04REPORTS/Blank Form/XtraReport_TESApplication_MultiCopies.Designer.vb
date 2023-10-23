<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport_TESApplication_MultiCopies
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
        Me.XrSubreport3 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.XrPageBreak2, Me.XrSubreport3, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 996.4078!
        Me.Detail.Name = "Detail"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(750.0!, 324.49!)
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 334.49!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(750.0!, 324.49!)
        '
        'XrSubreport3
        '
        Me.XrSubreport3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 668.98!)
        Me.XrSubreport3.Name = "XrSubreport3"
        Me.XrSubreport3.SizeF = New System.Drawing.SizeF(750.0!, 324.49!)
        '
        'XrPageBreak2
        '
        Me.XrPageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 993.47!)
        Me.XrPageBreak2.Name = "XrPageBreak2"
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LineWidth = 2.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 658.98!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(750.0!, 10.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine2.LineWidth = 2.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 324.49!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(750.0!, 10.0!)
        '
        'XtraReport_TESApplication_MultiCopies
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubreport3 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
