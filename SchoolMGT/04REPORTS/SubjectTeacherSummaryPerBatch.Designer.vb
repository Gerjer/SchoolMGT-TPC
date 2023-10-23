<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SubjectTeacherSummaryPerBatch 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubjectTeacherSummaryPerBatch))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCourseLevel = New DataDynamics.ActiveReports.TextBox()
        Me.txtBatch = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNo = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.PageBreak1 = New DataDynamics.ActiveReports.PageBreak()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCourseLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.TextBox3, Me.txtCourseLevel, Me.txtBatch, Me.Line1})
        Me.PageHeader1.Height = 0.7604167!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.TextBox2.Height = 0.1979167!
        Me.TextBox2.Left = 0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = ""
        Me.TextBox2.Text = "Course/Level"
        Me.TextBox2.Top = 0.0625!
        Me.TextBox2.Width = 1.0!
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
        Me.TextBox3.Height = 0.1979167!
        Me.TextBox3.Left = 0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = ""
        Me.TextBox3.Text = "Batch"
        Me.TextBox3.Top = 0.25!
        Me.TextBox3.Width = 1.0!
        '
        'txtCourseLevel
        '
        Me.txtCourseLevel.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCourseLevel.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCourseLevel.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCourseLevel.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCourseLevel.Border.RightColor = System.Drawing.Color.Black
        Me.txtCourseLevel.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCourseLevel.Border.TopColor = System.Drawing.Color.Black
        Me.txtCourseLevel.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCourseLevel.Height = 0.1875!
        Me.txtCourseLevel.Left = 1.0625!
        Me.txtCourseLevel.Name = "txtCourseLevel"
        Me.txtCourseLevel.Style = ""
        Me.txtCourseLevel.Text = "Course/Level"
        Me.txtCourseLevel.Top = 0.0625!
        Me.txtCourseLevel.Width = 5.875!
        '
        'txtBatch
        '
        Me.txtBatch.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBatch.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBatch.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBatch.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBatch.Border.RightColor = System.Drawing.Color.Black
        Me.txtBatch.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBatch.Border.TopColor = System.Drawing.Color.Black
        Me.txtBatch.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBatch.Height = 0.1875!
        Me.txtBatch.Left = 1.0625!
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Style = ""
        Me.txtBatch.Text = "Course/Level"
        Me.txtBatch.Top = 0.25!
        Me.txtBatch.Width = 5.875!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 3.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.625!
        Me.Line1.Width = 7.5!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.5!
        Me.Line1.Y1 = 0.625!
        Me.Line1.Y2 = 0.625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox5, Me.TextBox11, Me.TextBox12, Me.txtNo, Me.TextBox18, Me.TextBox25})
        Me.Detail1.Height = 0.1666667!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.CanGrow = False
        Me.TextBox5.DataField = "std_number"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.9375!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.CanGrow = False
        Me.TextBox11.DataField = "last_name"
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 1.3125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0!
        Me.TextBox11.Width = 2.0!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.CanGrow = False
        Me.TextBox12.DataField = "pname"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 3.3125!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; "
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 2.1875!
        '
        'txtNo
        '
        Me.txtNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.CanGrow = False
        Me.txtNo.Height = 0.1875!
        Me.txtNo.Left = 0!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Microsoft Sa" &
    "ns Serif; "
        Me.txtNo.Text = Nothing
        Me.txtNo.Top = 0!
        Me.txtNo.Width = 0.375!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.CanGrow = False
        Me.TextBox18.DataField = "middle_name"
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 5.5!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; "
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0!
        Me.TextBox18.Width = 1.3125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.PageFooter1.Height = 0.1875!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 0!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = ""
        Me.ReportInfo1.Top = 0!
        Me.ReportInfo1.Width = 1.5!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox8, Me.TextBox6, Me.TextBox23})
        Me.GroupHeader1.DataField = "subjid"
        Me.GroupHeader1.Height = 0.1770833!
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
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "background-color: #C0FFC0; "
        Me.TextBox1.Text = "Subject :"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.9375!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.CanGrow = False
        Me.TextBox8.DataField = "subjname"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 2.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: center; background-color: #C0FFC0; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 4.0!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.CanGrow = False
        Me.TextBox6.DataField = "no_exams"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 6.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "background-color: #C0FFC0; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 1.5!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.CanGrow = False
        Me.TextBox23.DataField = "subjcode"
        Me.TextBox23.Height = 0.1875!
        Me.TextBox23.Left = 0.9375!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "text-align: left; background-color: #C0FFC0; "
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0!
        Me.TextBox23.Width = 1.0625!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox14, Me.PageBreak1})
        Me.GroupFooter1.Height = 0.3125!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.CanGrow = False
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "text-align: right; background-color: #C0FFC0; "
        Me.TextBox14.Text = "TOTAL NUMBER OF STUDENT :"
        Me.TextBox14.Top = 0!
        Me.TextBox14.Width = 7.5!
        '
        'PageBreak1
        '
        Me.PageBreak1.Border.BottomColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.LeftColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.RightColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Border.TopColor = System.Drawing.Color.Black
        Me.PageBreak1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PageBreak1.Height = 0.0625!
        Me.PageBreak1.Left = 0!
        Me.PageBreak1.Name = "PageBreak1"
        Me.PageBreak1.Size = New System.Drawing.SizeF(6.5!, 0.0625!)
        Me.PageBreak1.Top = 0.25!
        Me.PageBreak1.Width = 6.5!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox4, Me.TextBox7, Me.TextBox9, Me.TextBox10, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox13, Me.TextBox24})
        Me.GroupHeader2.DataField = "employee_id"
        Me.GroupHeader2.Height = 0.6354167!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.CanGrow = False
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = ""
        Me.TextBox4.Text = "Instructor/Schedule :"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 1.375!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.CanGrow = False
        Me.TextBox7.DataField = "employee_name"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 1.375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = ""
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 4.125!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.CanGrow = False
        Me.TextBox9.DataField = "schedname"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 1.375!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = ""
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.1875!
        Me.TextBox9.Width = 3.5625!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.CanGrow = False
        Me.TextBox10.DataField = "room"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 6.25!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = ""
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.1875!
        Me.TextBox10.Width = 1.25!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.CanGrow = False
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = ""
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.1875!
        Me.TextBox15.Width = 1.375!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.CanGrow = False
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 6.0625!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = ""
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0!
        Me.TextBox16.Width = 1.4375!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 5.5!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "text-align: right; "
        Me.TextBox17.Text = "Room :"
        Me.TextBox17.Top = 0.1875!
        Me.TextBox17.Width = 0.75!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.CanGrow = False
        Me.TextBox19.Height = 0.25!
        Me.TextBox19.Left = 0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox19.Text = "NO."
        Me.TextBox19.Top = 0.375!
        Me.TextBox19.Width = 0.375!
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
        Me.TextBox20.CanGrow = False
        Me.TextBox20.Height = 0.25!
        Me.TextBox20.Left = 0.375!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox20.Text = "ID NO."
        Me.TextBox20.Top = 0.375!
        Me.TextBox20.Width = 0.9375!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.CanGrow = False
        Me.TextBox21.Height = 0.25!
        Me.TextBox21.Left = 1.3125!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox21.Text = "STUDENT LAST NAME"
        Me.TextBox21.Top = 0.375!
        Me.TextBox21.Width = 2.0!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.CanGrow = False
        Me.TextBox22.Height = 0.25!
        Me.TextBox22.Left = 3.3125!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox22.Text = "FIRST NAME"
        Me.TextBox22.Top = 0.375!
        Me.TextBox22.Width = 2.1875!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 5.5!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox13.Text = "MIDDLE NAME"
        Me.TextBox13.Top = 0.375!
        Me.TextBox13.Width = 1.3125!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.CanGrow = False
        Me.TextBox24.Height = 0.25!
        Me.TextBox24.Left = 6.8125!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "text-align: center; background-color: #FFE0C0; "
        Me.TextBox24.Text = "GENDER"
        Me.TextBox24.Top = 0.375!
        Me.TextBox24.Width = 0.6875!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.CanGrow = False
        Me.TextBox25.DataField = "gender"
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 6.8125!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; "
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0!
        Me.TextBox25.Width = 0.6875!
        '
        'SubjectTeacherSummaryPerBatch
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.520833!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCourseLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCourseLevel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBatch As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents PageBreak1 As DataDynamics.ActiveReports.PageBreak
    Friend WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
End Class
