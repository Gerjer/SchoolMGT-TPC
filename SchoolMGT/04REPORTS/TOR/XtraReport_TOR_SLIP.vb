Imports System.ComponentModel
Imports System.Drawing.Printing
Imports DataDynamics.ActiveReports.Document


Public Class XtraReport_TOR_SLIP

    Public _studentname As String
    Public _course As String
    Public _schoolname As String
    Public _academicyear As String
    Dim html As String = ""

    Private Sub XtraReport_TOR_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint

        XrRichText1.Html = "<html><body><font><pre class='tab'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This is certify that  <b><ins> " & _studentname & " </ins></b>  ,a  <ins><b>" & _course & "</b></ins>    student of   <ins><b>" & _schoolname & "</b></ins>    during the Academic Year   <ins><b>" & _academicyear & "</b></ins>  hereby granted Certificate of Transfer effective this date.
                                                      <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Her official transcript of records will be forwarded only upon receipt of the return slip below duly accomplish.</p></pre>.</font></body></html>"

        XrRichText2.Html = "<html><body><font><pre class='tab'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Please send us acopy of the  <b>  OFFICIAL TRANSCRIPT OF RECORDS  </b><ins>  of  </ins><ins><b>" & _studentname & "</b></ins>  who was temporarily admitted in our school pending the receipt of the school records.</pre>.</font></body></html>"

    End Sub
End Class