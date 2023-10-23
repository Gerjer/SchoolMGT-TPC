<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xtrSubjectLoad_Main
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
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.user = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 51.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.Detail.HeightF = 24.00001!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.user, Me.XrLabel1, Me.XrPageInfo2, Me.XrLabel36, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 52.33332!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 11.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(110.7324!, 19.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.TextFormatString = "Page 1 of {0}"
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(269.833!, 11.0!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(67.0!, 19.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.Text = "Date Printed :"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(336.833!, 11.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(131.6667!, 19.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextFormatString = "{0:MM/dd/yyyy h:mm tt}"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(596.5!, 11.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Office of the Registrar"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.LocationFloat = New DevExpress.Utils.PointFloat(596.5!, 26.33332!)
        Me.user.Multiline = True
        Me.user.Name = "user"
        Me.user.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.user.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.user.StylePriority.UseFont = False
        Me.user.StylePriority.UseTextAlignment = False
        Me.user.Text = "Office of the Registrar"
        Me.user.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New SchoolMGT.xtrSubjectLoad()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(759.0!, 23.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(759.0!, 10.0!)
        '
        'xtrSubjectLoad_Main
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageFooter})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 41, 51, 50)
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents user As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
