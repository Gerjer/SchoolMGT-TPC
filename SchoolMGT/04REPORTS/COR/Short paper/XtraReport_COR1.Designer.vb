<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReport_COR1
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
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(SchoolMGT.Student_COR)
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
        Me.Detail.HeightF = 350.9228!
        Me.Detail.MultiColumn.ColumnSpacing = 9.842491!
        Me.Detail.MultiColumn.ColumnWidth = 355.1181!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 78.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 91.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'panel1
        '
        Me.panel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.panel1.CanGrow = False
        Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.panel1.Name = "panel1"
        Me.panel1.SizeF = New System.Drawing.SizeF(355.1181!, 350.9228!)
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999996!, 10.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(227.2522!, 114.2162!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XtraReport_COR1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.BindingSource1})
        Me.DataSource = Me.BindingSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(51, 0, 78, 91)
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 10
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "18.2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents panel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
End Class
