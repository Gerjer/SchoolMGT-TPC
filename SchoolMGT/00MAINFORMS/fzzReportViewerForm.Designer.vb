<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fzzReportViewerForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fzzReportViewerForm))
        Me.MeViewer = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btnrtf = New DevComponents.DotNetBar.ButtonX
        Me.btnPDF = New DevComponents.DotNetBar.ButtonX
        Me.btnExcelExport = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MeViewer
        '
        Me.MeViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MeViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MeViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MeViewer.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.MeViewer.Location = New System.Drawing.Point(0, 0)
        Me.MeViewer.Name = "MeViewer"
        Me.MeViewer.ReportViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.ReportViewer.CurrentPage = 0
        Me.MeViewer.ReportViewer.HyperLinkBackColor = System.Drawing.SystemColors.Window
        Me.MeViewer.ReportViewer.MultiplePageCols = 3
        Me.MeViewer.ReportViewer.MultiplePageMode = True
        Me.MeViewer.ReportViewer.MultiplePageRows = 2
        Me.MeViewer.ReportViewer.RepositionPage = True
        Me.MeViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.MeViewer.Size = New System.Drawing.Size(704, 361)
        Me.MeViewer.TabIndex = 0
        Me.MeViewer.TableOfContents.Text = "Table Of Contents"
        Me.MeViewer.TableOfContents.Width = 200
        Me.MeViewer.TabTitleLength = 35
        Me.MeViewer.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btnrtf)
        Me.PanelEx1.Controls.Add(Me.btnPDF)
        Me.PanelEx1.Controls.Add(Me.btnExcelExport)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 361)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(704, 35)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'btnrtf
        '
        Me.btnrtf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnrtf.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnrtf.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnrtf.Image = Global.SchoolMGT.My.Resources.Resources.wordDoc_B
        Me.btnrtf.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnrtf.Location = New System.Drawing.Point(118, 0)
        Me.btnrtf.Name = "btnrtf"
        Me.btnrtf.Size = New System.Drawing.Size(118, 35)
        Me.btnrtf.TabIndex = 2
        Me.btnrtf.Text = "Export to Doc"
        '
        'btnPDF
        '
        Me.btnPDF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPDF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPDF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnPDF.Location = New System.Drawing.Point(586, 0)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(118, 35)
        Me.btnPDF.TabIndex = 1
        Me.btnPDF.Text = "Export to PDF"
        '
        'btnExcelExport
        '
        Me.btnExcelExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExcelExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExcelExport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExcelExport.Image = CType(resources.GetObject("btnExcelExport.Image"), System.Drawing.Image)
        Me.btnExcelExport.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnExcelExport.Location = New System.Drawing.Point(0, 0)
        Me.btnExcelExport.Name = "btnExcelExport"
        Me.btnExcelExport.Size = New System.Drawing.Size(118, 35)
        Me.btnExcelExport.TabIndex = 0
        Me.btnExcelExport.Text = "Export to Excel"
        '
        'fzzReportViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(704, 396)
        Me.Controls.Add(Me.MeViewer)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "fzzReportViewerForm"
        Me.Text = "Tamers Report Viewer"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MeViewer As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExcelExport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPDF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnrtf As DevComponents.DotNetBar.ButtonX
End Class
