<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rpt_ReceiptPrintout
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_ReceiptPrintout))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.txtName = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPaymentType = New DataDynamics.ActiveReports.TextBox()
        Me.txtDate = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCashier = New DataDynamics.ActiveReports.TextBox()
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.txtORNo = New DataDynamics.ActiveReports.TextBox()
        Me.Detail1 = New DataDynamics.ActiveReports.Detail()
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtORNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.TextBox1, Me.TextBox2, Me.Picture1, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.txtName, Me.TextBox7, Me.txtAmount, Me.TextBox9, Me.txtPaymentType, Me.txtDate, Me.TextBox6, Me.txtCashier, Me.ReportInfo1, Me.TextBox8, Me.txtORNo})
        Me.PageHeader1.Height = 3.25!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 3.0!
        Me.Shape1.Left = 0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0!
        Me.Shape1.Width = 6.9375!
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
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.0625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; "
        Me.TextBox1.Text = "Don Jose Ecleo Memorial Foundation College of Science and Technology"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 7.0!
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
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 0.0625!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.TextBox2.Text = "San Jose, Dinagat Islands"
        Me.TextBox2.Top = 0.1875!
        Me.TextBox2.Width = 7.0!
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.75!
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 0.375!
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0.0625!
        Me.Picture1.Width = 0.8125!
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
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 0.0625!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.TextBox3.Text = "ACKNOWLEDGEMENT RECEIPT"
        Me.TextBox3.Top = 0.5625!
        Me.TextBox3.Width = 7.0!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 5.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox4.Text = "DATE :"
        Me.TextBox4.Top = 0.75!
        Me.TextBox4.Width = 0.4375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.0625!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox5.Text = "RECIEVED FROM :"
        Me.TextBox5.Top = 1.3125!
        Me.TextBox5.Width = 1.1875!
        '
        'txtName
        '
        Me.txtName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Border.RightColor = System.Drawing.Color.Black
        Me.txtName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Border.TopColor = System.Drawing.Color.Black
        Me.txtName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Height = 0.1875!
        Me.txtName.Left = 1.25!
        Me.txtName.Name = "txtName"
        Me.txtName.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" &
    "ical-align: middle; "
        Me.txtName.Text = "RECIEVED FROM :"
        Me.txtName.Top = 1.3125!
        Me.txtName.Width = 5.625!
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
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0.0625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox7.Text = "THE AMOUNT OF "
        Me.TextBox7.Top = 1.5625!
        Me.TextBox7.Width = 1.1875!
        '
        'txtAmount
        '
        Me.txtAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.25!
        Me.txtAmount.MultiLine = False
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" &
    "ical-align: middle; "
        Me.txtAmount.Text = "RECIEVED FROM :"
        Me.txtAmount.Top = 1.5625!
        Me.txtAmount.Width = 5.625!
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
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0.0625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox9.Text = "AS PAYMENT FOR"
        Me.TextBox9.Top = 1.8125!
        Me.TextBox9.Width = 1.1875!
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPaymentType.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPaymentType.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPaymentType.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentType.Border.RightColor = System.Drawing.Color.Black
        Me.txtPaymentType.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentType.Border.TopColor = System.Drawing.Color.Black
        Me.txtPaymentType.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentType.Height = 0.1875!
        Me.txtPaymentType.Left = 1.25!
        Me.txtPaymentType.MultiLine = False
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.txtPaymentType.Text = "RECIEVED FROM :"
        Me.txtPaymentType.Top = 1.8125!
        Me.txtPaymentType.Width = 5.625!
        '
        'txtDate
        '
        Me.txtDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Height = 0.1875!
        Me.txtDate.Left = 5.4375!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.txtDate.Text = "AS"
        Me.txtDate.Top = 0.75!
        Me.txtDate.Width = 1.1875!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 4.125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" &
    "ical-align: middle; "
        Me.TextBox6.Text = "RECIEVED BY : NAME/SIGNATURE"
        Me.TextBox6.Top = 2.5!
        Me.TextBox6.Width = 2.75!
        '
        'txtCashier
        '
        Me.txtCashier.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCashier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtCashier.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCashier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Border.RightColor = System.Drawing.Color.Black
        Me.txtCashier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Border.TopColor = System.Drawing.Color.Black
        Me.txtCashier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Height = 0.1875!
        Me.txtCashier.Left = 4.125!
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" &
    "ical-align: middle; "
        Me.txtCashier.Text = Nothing
        Me.txtCashier.Top = 2.25!
        Me.txtCashier.Width = 2.75!
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
        Me.ReportInfo1.FormatString = "Printed Date: {RunDateTime:M/d/yy h:mm tt}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 0.0625!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 2.75!
        Me.ReportInfo1.Width = 4.0!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 5.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.TextBox8.Text = "OR NO:"
        Me.TextBox8.Top = 1.0!
        Me.TextBox8.Width = 0.4375!
        '
        'txtORNo
        '
        Me.txtORNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtORNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtORNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtORNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtORNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtORNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtORNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtORNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtORNo.Height = 0.1875!
        Me.txtORNo.Left = 5.4375!
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; vertic" &
    "al-align: middle; "
        Me.txtORNo.Text = "AS"
        Me.txtORNo.Top = 1.0!
        Me.txtORNo.Width = 1.1875!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Height = 0!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rpt_ReceiptPrintout
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.25!
        Me.PageSettings.Margins.Left = 0.25!
        Me.PageSettings.Margins.Right = 0.25!
        Me.PageSettings.Margins.Top = 0.25!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.958333!
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
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtORNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPaymentType As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCashier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtORNo As DataDynamics.ActiveReports.TextBox
End Class
