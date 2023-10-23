Public Class CourseList

    Public CourseCode As String
    Public CourseName As String
    Public CourseMajor As String
    Public Description As String

    Private Sub CourseList_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dt As New DataTable
        dt = DataSource(String.Format("SELECT
                                        course_main.`name` as 'main',
                                        course_branches.prefix as 'code',
                                        course_branches.`name`,
                                        course_branches.major,
                                        course_branches.description
                                        FROM
                                        course_main
                                        INNER JOIN course_branches ON course_branches.course_main_id = course_main.course_main_id
                                        "))
        GridControl1.DataSource = dt


        GridView1.BestFitColumns()

    End Sub

    'Private Sub GridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView1.MouseDown

    '    Try
    '        CourseCode = GridView1.Columns.View.GetFocusedRow("code")
    '        CourseName = GridView1.Columns.View.GetFocusedRow("name")
    '        CourseMajor = If(IsDBNull(GridView1.Columns.View.GetFocusedRow("major")), "", GridView1.Columns.View.GetFocusedRow("major"))
    '        Description = GridView1.Columns.View.GetFocusedRow("description")

    '        Me.Close()

    '    Catch ex As Exception

    '    End Try


    'End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick

        Try
            CourseCode = "" ' GridView1.Columns.View.GetFocusedRow("code")
            CourseName = GridView1.Columns.View.GetFocusedRow("code") 'GridView1.Columns.View.GetFocusedRow("name")
            CourseMajor = If(IsDBNull(GridView1.Columns.View.GetFocusedRow("major")), "", GridView1.Columns.View.GetFocusedRow("major"))
            Description = GridView1.Columns.View.GetFocusedRow("description")

            Me.Close()

        Catch ex As Exception

        End Try



    End Sub
End Class