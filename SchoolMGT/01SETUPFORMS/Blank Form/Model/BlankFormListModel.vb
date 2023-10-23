Public Class BlankFormListModel


    Friend Function getBlankFormRecord() As DataTable
        Dim str As String = ""
        str = "SELECT
form_report.id,
form_report.form_name,
form_report.description,
form_report.typE
FROM
form_report
WHERE
form_report.applicaation_setup_id = '" & AppSetup_Domain & "'
"
        Return DataSource(str)
    End Function
End Class
