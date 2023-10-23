
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rpt_ReceiptPrintout

    Private AMOUNT As Double = 0

    Sub New()
        InitializeComponent()

    End Sub

    Sub New(ByVal datestr As String, ByVal student_name As String,
            ByVal amount As Double, ByVal paymentType As String, ByVal orNo As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.txtDate.Text = datestr
        Me.txtName.Text = student_name
        Me.txtPaymentType.Text = paymentType
        Me.txtORNo.Text = orNo
        Me.AMOUNT = amount

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
                tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
                  wAmount.Trim & " Pesos And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
          IIf(InStr(wAmount.Trim.ToLower, "pesos"),
          wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result
        Return wAmount
    End Function



    Private Sub rpt_ReceiptPrintout_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim amount_words As String = AmountInWords(Format(Me.AMOUNT, "#,##0.00"))

        Me.txtAmount.Text = amount_words & "(" & Format(Me.AMOUNT, "#,##0.00") & ")"

        Me.txtCashier.Text = AuthUserName
    End Sub

    Private Sub PageHeader1_Format(sender As Object, e As EventArgs) Handles PageHeader1.Format
        TextBox1.Text = COMPANY_NAME
        TextBox2.Text = COMPANY_ADDRESS
        '    Picture1.Image = COMPANY_IMAGE

    End Sub
End Class
