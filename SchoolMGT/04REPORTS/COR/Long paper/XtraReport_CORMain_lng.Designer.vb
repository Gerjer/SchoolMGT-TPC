<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport_CORMain_lng
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
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrCopy2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCopy1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 24.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1, Me.XrCopy2, Me.XrCopy1, Me.XrLine1, Me.XrSubreport2, Me.XrSubreport1})
        Me.Detail1.HeightF = 1349.574!
        Me.Detail1.Name = "Detail1"
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1038.708!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrCopy2
        '
        Me.XrCopy2.BackColor = System.Drawing.Color.Tomato
        Me.XrCopy2.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrCopy2.LocationFloat = New DevExpress.Utils.PointFloat(646.9799!, 627.0964!)
        Me.XrCopy2.Multiline = True
        Me.XrCopy2.Name = "XrCopy2"
        Me.XrCopy2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCopy2.SizeF = New System.Drawing.SizeF(149.0201!, 23.0!)
        Me.XrCopy2.StylePriority.UseBackColor = False
        Me.XrCopy2.StylePriority.UseFont = False
        Me.XrCopy2.StylePriority.UseTextAlignment = False
        Me.XrCopy2.Text = "Registrar Copy"
        Me.XrCopy2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCopy1
        '
        Me.XrCopy1.BackColor = System.Drawing.Color.Tomato
        Me.XrCopy1.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrCopy1.LocationFloat = New DevExpress.Utils.PointFloat(646.9799!, 0!)
        Me.XrCopy1.Multiline = True
        Me.XrCopy1.Name = "XrCopy1"
        Me.XrCopy1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCopy1.SizeF = New System.Drawing.SizeF(149.0201!, 23.0!)
        Me.XrCopy1.StylePriority.UseBackColor = False
        Me.XrCopy1.StylePriority.UseFont = False
        Me.XrCopy1.StylePriority.UseTextAlignment = False
        Me.XrCopy1.Text = "Registrar Copy"
        Me.XrCopy1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LineWidth = 2.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 611.0964!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(798.0!, 16.00003!)
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 627.0964!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = New SchoolMGT.XtraReport_CORNew()
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(795.0001!, 722.4778!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New SchoolMGT.XtraReport_CORNew()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(798.0001!, 611.0964!)
        '
        'XtraReport_CORMain_lng
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail1})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(25, 20, 24, 25)
        Me.PageHeight = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.Version = "18.2"
        Me.Watermark.ImageTransparency = 202
        Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCopy2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCopy1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
End Class
