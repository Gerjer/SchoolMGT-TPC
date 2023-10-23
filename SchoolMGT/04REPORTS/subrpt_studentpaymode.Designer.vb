<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class subrpt_studentpaymode 
    Inherits DataDynamics.ActiveReports.ActiveReport3 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(subrpt_studentpaymode))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25})
        Me.PageHeader1.Height = 0!
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Visible = False
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox25.Text = "TOTAL INSTALLMENT"
        Me.TextBox25.Top = 0!
        Me.TextBox25.Width = 1.875!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox20, Me.TextBox1})
        Me.Detail1.Height = 0.1041667!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.CanGrow = False
        Me.TextBox20.DataField = "MODE OF PAYMENTS"
        Me.TextBox20.Height = 0.125!
        Me.TextBox20.Left = 0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: left; font-size: 6pt; vertical-align: middle; "
        Me.TextBox20.Text = " "
        Me.TextBox20.Top = 0!
        Me.TextBox20.Width = 1.0625!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.CanGrow = False
        Me.TextBox1.DataField = "AMOUNT"
        Me.TextBox1.Height = 0.125!
        Me.TextBox1.Left = 1.0625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; vertical-align: middle; "
        Me.TextBox1.Text = " "
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'subrpt_studentpaymode
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
End Class 
