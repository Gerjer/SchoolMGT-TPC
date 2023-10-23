<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReport_RequestForm_MultiCopies
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 70.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1})
        Me.BottomMargin.HeightF = 70.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail.HeightF = 701.6888!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        '
        'XrLine1
        '
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.BorderWidth = 1.0!
        Me.XrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(398.6!, 0.00002445318!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(97.0!, 700.4168!)
        Me.XrLine1.StylePriority.UseBorderDashStyle = False
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(495.5999!, 0!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(398.6!, 701.6888!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(398.6!, 700.4168!)
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XtraReport_RequestForm_MultiCopies
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 70, 70)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
End Class
