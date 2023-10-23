<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAssessmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentAssessmentForm))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btnPDF = New DevComponents.DotNetBar.ButtonX
        Me.btnExcelExport = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.MeViewer = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.btnPDF)
        Me.PanelEx1.Controls.Add(Me.btnExcelExport)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 438)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(891, 35)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'btnPDF
        '
        Me.btnPDF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPDF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPDF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnPDF.Location = New System.Drawing.Point(773, 0)
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
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(290, 438)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Student Details"
        '
        'MeViewer
        '
        Me.MeViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MeViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MeViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MeViewer.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.MeViewer.Location = New System.Drawing.Point(290, 0)
        Me.MeViewer.Name = "MeViewer"
        Me.MeViewer.ReportViewer.BackColor = System.Drawing.Color.LightBlue
        Me.MeViewer.ReportViewer.CurrentPage = 0
        Me.MeViewer.ReportViewer.HyperLinkBackColor = System.Drawing.SystemColors.Window
        Me.MeViewer.ReportViewer.MultiplePageCols = 3
        Me.MeViewer.ReportViewer.MultiplePageMode = True
        Me.MeViewer.ReportViewer.MultiplePageRows = 2
        Me.MeViewer.ReportViewer.RepositionPage = True
        Me.MeViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.MeViewer.Size = New System.Drawing.Size(601, 438)
        Me.MeViewer.TabIndex = 3
        Me.MeViewer.TableOfContents.Text = "Table Of Contents"
        Me.MeViewer.TableOfContents.Width = 200
        Me.MeViewer.TabTitleLength = 35
        Me.MeViewer.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'StudentAssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(891, 473)
        Me.Controls.Add(Me.MeViewer)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "StudentAssessmentForm"
        Me.Text = "Report Viewer"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExcelExport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPDF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents MeViewer As DataDynamics.ActiveReports.Viewer.Viewer
End Class
