<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class subrpt_StudentSubjectList 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(subrpt_StudentSubjectList))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4})
        Me.PageHeader1.Height = 0!
        Me.PageHeader1.Name = "PageHeader1"
        Me.PageHeader1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox1.Text = "DESCRIPTION"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 1.625!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 1.625!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox2.Text = "PARTICULARS"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 1.625!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 3.25!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox3.Text = "AMOUNT"
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.875!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 4.125!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.TextBox4.Text = "TOTAL"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.875!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23})
        Me.Detail1.Height = 0.08333334!
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
        Me.TextBox20.CanShrink = True
        Me.TextBox20.DataField = "FEE DESCRIPTION"
        Me.TextBox20.Height = 0.1354167!
        Me.TextBox20.Left = 0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: left; font-size: 6pt; vertical-align: middle; "
        Me.TextBox20.Text = " "
        Me.TextBox20.Top = 0!
        Me.TextBox20.Width = 1.625!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.CanGrow = False
        Me.TextBox21.CanShrink = True
        Me.TextBox21.DataField = "PARTICULARS"
        Me.TextBox21.Height = 0.1354167!
        Me.TextBox21.Left = 1.3125!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: left; font-size: 6pt; vertical-align: middle; "
        Me.TextBox21.Text = " "
        Me.TextBox21.Top = 0!
        Me.TextBox21.Width = 1.9375!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.CanGrow = False
        Me.TextBox22.CanShrink = True
        Me.TextBox22.DataField = "AMOUNT"
        Me.TextBox22.Height = 0.1354167!
        Me.TextBox22.Left = 3.25!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; vertical-align: middle; "
        Me.TextBox22.Text = " "
        Me.TextBox22.Top = 0!
        Me.TextBox22.Width = 0.875!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.CanGrow = False
        Me.TextBox23.CanShrink = True
        Me.TextBox23.DataField = "TOTAL"
        Me.TextBox23.Height = 0.1354167!
        Me.TextBox23.Left = 4.125!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "ddo-char-set: 0; text-decoration: underline; text-align: right; font-size: 6pt; v" &
    "ertical-align: middle; "
        Me.TextBox23.Text = " "
        Me.TextBox23.Top = 0!
        Me.TextBox23.Width = 0.875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'subrpt_StudentSubjectList
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 5.166667!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
End Class
