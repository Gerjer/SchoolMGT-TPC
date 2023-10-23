<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xtrCHED_E_Form_B_C
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
        Me.PrintableComponentContainer1 = New DevExpress.XtraReports.UI.PrintableComponentContainer()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
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
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PrintableComponentContainer1})
        Me.Detail.HeightF = 77.08334!
        Me.Detail.Name = "Detail"
        '
        'PrintableComponentContainer1
        '
        Me.PrintableComponentContainer1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PrintableComponentContainer1.Name = "PrintableComponentContainer1"
        Me.PrintableComponentContainer1.SizeF = New System.Drawing.SizeF(1060.0!, 75.0!)
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.GroupHeader1.HeightF = 46.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1000.0!, 23.0!)
        Me.XrLabel1.Text = "CHED E-FORM B/C"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1000.0!, 23.0!)
        Me.XrLabel2.Text = "CURRICULUM PROGRAM PROFILE / ENROLMENT & GRADUATES"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel36, Me.XrPageInfo2})
        Me.PageFooter.HeightF = 22.75!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(520.9997!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(131.6667!, 19.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextFormatString = "{0:MM/dd/yyyy h:mm tt}"
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(453.9997!, 0!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(67.0!, 19.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.Text = "Date Printed :"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(110.7324!, 19.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.TextFormatString = "Page 1 of {0}"
        '
        'xtrCHED_E_Form_B_C
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.GroupHeader1, Me.PageFooter})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(20, 20, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PrintableComponentContainer1 As DevExpress.XtraReports.UI.PrintableComponentContainer
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
End Class
