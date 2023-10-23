Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rpt_StudentsGrade 

    Private lbl_id As DataDynamics.ActiveReports.Label
    Private lbl_subjname As DataDynamics.ActiveReports.Label
    Private lbl_subjunit As DataDynamics.ActiveReports.Label
    Private lbl_subjinstructor As DataDynamics.ActiveReports.Label

    Private lbl_grade As DataDynamics.ActiveReports.Label

    Private SUBJDATATABLE As DataTable

    Private ROWCOUNT As Integer = 0

    Private CATID As String = ""

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal subjDT As DataTable, ByVal catID As String)
        InitializeComponent()
        Me.CATID = catID
        Me.SUBJDATATABLE = subjDT
        Me.DataSource = subjDT
    End Sub

    Private Sub rpt_StudentsGrade_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        displayHeaders()
    End Sub

    Private Sub displayHeaders()
        Dim xLoc1 As Single = txtSIHeader.Bounds.Right
        'Dim xLocDetail As Single = txtSIHeader.Bounds.Right

        Dim SQLEX As String = "SELECT id, name FROM student_grading_period"
        SQLEX += " WHERE student_category_id='" & CATID & "'"

        Dim MeData As DataTable
        MeData = clsDBConn.ExecQuery(SQLEX)

        If MeData.Rows.Count > 0 Then
            For nCtr As Integer = 0 To MeData.Rows.Count - 1

                Dim type As String = MeData.Rows(nCtr).Item("id").ToString
                Dim ColName As String = MeData.Rows(nCtr).Item("name").ToString

                Dim lbl1 As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = ColName, .Style = FontStyle.Regular, .Font = txtSIHeader.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, txtSIHeader.Location.Y)}
                txtSIHeader.Border.CopyTo(lbl1.Border)
                GroupHeader1.Controls.Add(lbl1)
                xLoc1 = xLoc1 + txtSIHeader.Width
            Next
        End If

        ' final headers
        Dim lblFinal As New DataDynamics.ActiveReports.Label() _
                    With {.Size = txtSIHeader.Size, .Text = "FIN. GRADE", .Style = FontStyle.Regular, .Font = txtSIHeader.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLoc1, txtSIHeader.Location.Y)}
        'Dim label3size As Single = txtSIHeader.Width

        txtSIHeader.Border.CopyTo(lblFinal.Border)
        'xLoc1 = xLoc1 + Label3.Width
        GroupHeader1.Controls.Add(lblFinal)



        'values
        Dim yLoc1 As Single = TextBox4.Bounds.Top


        Dim columncount As Integer = SUBJDATATABLE.Columns.Count - 1

        For nCtr As Integer = 0 To SUBJDATATABLE.Rows.Count - 1
            Dim xLocDetail As Single = lblGradeing.Bounds.Right


            'ID
            lbl_id = New DataDynamics.ActiveReports.Label() _
                With {.Size = Label14.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(Label14.Location.X, 0 + yLoc1)}
            Label14.Border.CopyTo(lbl_id.Border)
            Dim id As String = SUBJDATATABLE.Rows(nCtr).Item(0).ToString
            lbl_id.Text = id
            Detail1.Controls.Add(lbl_id)

            'subjname
            lbl_subjname = New DataDynamics.ActiveReports.Label() _
                With {.Size = Label15.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Left, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(Label15.Location.X, 0 + yLoc1)}
            Label14.Border.CopyTo(lbl_subjname.Border)
            Dim subjname As String = SUBJDATATABLE.Rows(nCtr).Item(1).ToString
            lbl_subjname.Text = subjname
            Detail1.Controls.Add(lbl_subjname)

            'subj_unit
            lbl_subjunit = New DataDynamics.ActiveReports.Label() _
                With {.Size = Label18.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(Label18.Location.X, 0 + yLoc1)}
            Label14.Border.CopyTo(lbl_subjunit.Border)
            Dim unit As String = SUBJDATATABLE.Rows(nCtr).Item(2).ToString
            lbl_subjunit.Text = unit
            Detail1.Controls.Add(lbl_subjunit)

            'subj_instructor
            lbl_subjinstructor = New DataDynamics.ActiveReports.Label() _
                With {.Size = Label19.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Left, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(Label19.Location.X, 0 + yLoc1)}
            Label14.Border.CopyTo(lbl_subjinstructor.Border)
            lbl_subjinstructor.MultiLine = False
            Dim instructor As String = SUBJDATATABLE.Rows(nCtr).Item(3).ToString
            lbl_subjinstructor.Text = instructor
            Detail1.Controls.Add(lbl_subjinstructor)


            'add grades on grading period

            For col As Integer = 4 To columncount
                lbl_grade = New DataDynamics.ActiveReports.Label() _
                With {.Size = lblGradeing.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, 0 + yLoc1)}
                Label14.Border.CopyTo(lbl_grade.Border)

                If col <> 4 Then

                    Dim grades As String = SUBJDATATABLE.Rows(nCtr).Item(col).ToString
                    Try
                        If grades.Length > 0 Then
                            grades = Format(CDbl(grades), "#.00")
                            lbl_grade.Text = grades
                        End If
                    Catch ex As Exception
                        lbl_grade.Text = grades
                    End Try

                    lbl_grade.Text = grades
                    Detail1.Controls.Add(lbl_grade)
                    xLocDetail = xLocDetail + lblGradeing.Width
                End If
            Next
            ''final grade
            'lbl_grade = New DataDynamics.ActiveReports.Label() _
            '    With {.Size = lblGradeing.Size, .Text = "", .Style = FontStyle.Regular, .Font = Label14.Font, .Alignment = TextAlignment.Center, .VerticalAlignment = VerticalTextAlignment.Middle, .Location = New PointF(0 + xLocDetail, 0 + yLoc1)}
            'Label14.Border.CopyTo(lbl_grade.Border)
            'Dim finalgrades As String = SUBJDATATABLE.Rows(nCtr).Item(columncount).ToString
            'Try
            '    If finalgrades.Length > 0 Then
            '        finalgrades = Format(CDbl(finalgrades), "#.00")
            '        lbl_grade.Text = finalgrades
            '    End If
            'Catch ex As Exception
            '    lbl_grade.Text = finalgrades
            'End Try

            'lbl_grade.Text = finalgrades
            'Detail1.Controls.Add(lbl_grade)



            yLoc1 = yLoc1 + Label14.Height

        Next
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS
        '   Picture1.Image = COMPANY_IMAGE

    End Sub
End Class
