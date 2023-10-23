<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SubjectSchedulePerRoom 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubjectSchedulePerRoom))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtCourseLevel = New DataDynamics.ActiveReports.TextBox
        Me.txtBatch = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCourseLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.TextBox3, Me.txtCourseLevel, Me.txtBatch, Me.Line1})
        Me.PageHeader1.Height = 1.010417!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox4, Me.TextBox5, Me.TextBox7, Me.TextBox13})
        Me.Detail1.Height = 0.1770833!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
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
        Me.TextBox2.Height = 0.1979167!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = ""
        Me.TextBox2.Text = "Course/Level"
        Me.TextBox2.Top = 0.0!
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
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = ""
        Me.TextBox3.Text = "Batch"
        Me.TextBox3.Top = 0.1875!
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
        Me.txtCourseLevel.Top = 0.0!
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
        Me.txtBatch.Top = 0.1875!
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
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 3.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5625!
        Me.Line1.Width = 7.5!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.5!
        Me.Line1.Y1 = 0.5625!
        Me.Line1.Y2 = 0.5625!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox12})
        Me.GroupHeader1.DataField = "room_id"
        Me.GroupHeader1.Height = 0.5416667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "background-color: #C0FFC0; "
        Me.TextBox1.Text = "Room :"
        Me.TextBox1.Top = 0.0!
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
        Me.TextBox8.DataField = "room"
        Me.TextBox8.Height = 0.375!
        Me.TextBox8.Left = 1.375!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-align: left; background-color: #C0FFC0; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 6.0625!
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
        Me.TextBox4.Left = 0.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "text-align: center; "
        Me.TextBox4.Text = "Batch"
        Me.TextBox4.Top = 0.0!
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
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 3.6875!
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
        Me.TextBox7.Left = 5.1875!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = ""
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 2.25!
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
        Me.TextBox9.Left = 0.0!
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
        Me.TextBox10.Width = 4.5625!
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
        Me.TextBox12.Left = 5.1875!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: center; "
        Me.TextBox12.Text = "SCHEDULE"
        Me.TextBox12.Top = 0.375!
        Me.TextBox12.Width = 2.25!
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
        Me.TextBox13.Left = 4.3125!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.875!
        '
        'SubjectSchedulePerRoom
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.479167!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCourseLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCourseLevel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBatch As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
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
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
End Class
