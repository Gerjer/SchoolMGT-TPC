<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SubjectSchedulePerInstructor
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubjectSchedulePerInstructor))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2})
        Me.PageHeader1.Height = 0.7604167!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox4, Me.TextBox5, Me.TextBox7, Me.TextBox13, Me.TextBox6})
        Me.Detail1.Height = 0.1354167!
        Me.Detail1.Name = "Detail1"
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
        Me.TextBox4.CanGrow = False
        Me.TextBox4.DataField = "subjid"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "text-align: center; "
        Me.TextBox4.Text = "Batch"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.625!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.CanGrow = False
        Me.TextBox5.DataField = "subjname"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.625!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 2.875!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.CanGrow = False
        Me.TextBox7.DataField = "schedname"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 4.1875!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 2.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox12, Me.TextBox3})
        Me.GroupHeader1.DataField = "employee_id"
        Me.GroupHeader1.Height = 0.5416667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Height = 0.375!
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "background-color: #C0FFC0; vertical-align: middle; "
        Me.TextBox1.Text = "Instructor :"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 1.375!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.CanGrow = False
        Me.TextBox8.DataField = "employee_name"
        Me.TextBox8.Height = 0.375!
        Me.TextBox8.Left = 1.375!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: left; background-color: #C0FFC0; vertical-align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 6.0625!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: center; "
        Me.TextBox9.Text = "SUBJ ID"
        Me.TextBox9.Top = 0.375!
        Me.TextBox9.Width = 0.625!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.CanGrow = False
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 0.625!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: center; "
        Me.TextBox10.Text = "DESCRIPTION"
        Me.TextBox10.Top = 0.375!
        Me.TextBox10.Width = 3.5625!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 4.1875!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: center; "
        Me.TextBox12.Text = "SCHEDULE"
        Me.TextBox12.Top = 0.375!
        Me.TextBox12.Width = 2.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; "
        Me.TextBox2.Text = "SUBJECT SCHEDULE PER INSTRUCTOR"
        Me.TextBox2.Top = 0.1875!
        Me.TextBox2.Width = 7.5625!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.CanGrow = False
        Me.TextBox13.DataField = "no_exams"
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 3.5!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0!
        Me.TextBox13.Width = 0.6875!
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
        Me.TextBox3.CanGrow = False
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 6.1875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: center; "
        Me.TextBox3.Text = "ROOM"
        Me.TextBox3.Top = 0.375!
        Me.TextBox3.Width = 1.25!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.CanGrow = False
        Me.TextBox6.DataField = "room"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 6.1875!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 1.25!
        '
        'SubjectSchedulePerInstructor
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.5625!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
End Class
