<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class subrpt_SOAFee 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(subrpt_SOAFee))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox20, Me.TextBox23})
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Visible = False
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 0.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox20.Text = "DESCRIPTION"
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 1.8125!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.1875!
        Me.TextBox23.Left = 1.8125!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox23.Text = "AMOUNT"
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.9375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox3, Me.TextBox2})
        Me.Detail1.Height = 0.1145833!
        Me.Detail1.Name = "Detail1"
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
        Me.TextBox1.DataField = "FEE DESCRIPTION"
        Me.TextBox1.Height = 0.1354167!
        Me.TextBox1.Left = 0.0625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-size: 6pt; vertical-align: middle; "
        Me.TextBox1.Text = " "
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.6875!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.CanGrow = False
        Me.TextBox3.DataField = "TOTAL"
        Me.TextBox3.Height = 0.1354167!
        Me.TextBox3.Left = 1.8125!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 6pt; v" & _
            "ertical-align: middle; "
        Me.TextBox3.Text = " "
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.CanGrow = False
        Me.TextBox2.DataField = "PARTICULARS"
        Me.TextBox2.Height = 0.125!
        Me.TextBox2.Left = 0.625!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-decoration: underline; text-align: right; font-size: 6pt; v" & _
            "ertical-align: middle; "
        Me.TextBox2.Text = " "
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.125!
        '
        'subrpt_SOAFee
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.708334!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class 
