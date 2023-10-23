Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_OTORForm9A

    Public SUBRPT_DATASOURCE As DataTable

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal studentname As String, ByVal elem As String, _
           ByVal elemyr As String, ByVal hs As String, _
           ByVal hsyr As String, ByVal dob As Date, _
           ByVal _pob_barrio As String, ByVal _pob_town As String, _
           ByVal _pob_city As String, ByVal parent As String, _
           ByVal parentAddress As String, ByVal parentOccupation As String, _
           ByVal picturepath As String, ByVal dt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.txtName.Text = studentname
        Me.txtElem.Text = elem
        Me.txtElemYr.Text = elemyr
        Me.txtHS.Text = hs
        Me.txtHSYr.Text = hsyr

        txtdobyear.Text = Format(dob, "yyyy")
        txtdobMM.Text = Format(dob, "MMMM")
        txtdobdd.Text = Format(dob, "dd")

        txtpob_barrio.Text = _pob_barrio
        txtpob_town.Text = _pob_town
        txtpob_city.Text = _pob_city

        txtParent.Text = parent
        txtParentAddress.Text = parentAddress
        txtParentOccupation.Text = parentOccupation


        Picture2.Image = System.Drawing.Image.FromFile(picturepath)

        SUBRPT_DATASOURCE = dt
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub rpt_OTORForm9A_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        'Me.SubReport1.Report = New subrpt_OTORForma9ADetails
        'Me.SubReport1.Report.DataSource = SUBRPT_DATASOURCE
        'Me.SubReport1.

    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS
        '  Picture1.Image = COMPANY_IMAGE

    End Sub
End Class
