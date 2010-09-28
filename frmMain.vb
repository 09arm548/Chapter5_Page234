Public Class frmMain


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim strFormat As String = "{0, 15} {1, 15}"
        Dim strPrices As IO.StreamReader = IO.File.OpenText("../../Data.txt")
        Dim strfName As String = txtName.Text
        Dim strlName As String
        Dim strFinitial As String
        Dim strLinitial As String
        Dim intF As Integer = 5
        Dim strAddress As String = txtAddress.Text
        Dim strCity As String = txtCity.Text
        Dim intChair As Integer = CInt(txtNumChair.Text)
        Dim intSofa As Integer = CInt(txtNumSofa.Text)
        Dim dblTax As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim strFullName As String = txtName.Text
        Dim strZip As String
        Dim n As Integer
        Dim x As Integer
        Dim strFuName As String
        Dim strChairPrice As String
        strChairPrice = CStr(strPrices.ReadLine)
        Dim strSofaPrice As String
        strSofaPrice = CStr(strPrices.ReadLine)
        Dim dblTotally As Double = (CDbl(strChairPrice) * intChair + CDbl(strSofaPrice) * intSofa)
        dblTax = CDbl(strPrices.ReadLine)
        dblTax = dblTax * dblTotally
        dblTotal = (dblTax + dblTotally)


        x = strFullName.IndexOf(" ")
        n = strFullName.IndexOf(",")
        strfName = strFullName.Substring(x)
        strFuName = strFullName.Substring(0, n)



        strlName = CStr(CInt(strFullName.IndexOf(",")))  'this line is giving length of last name
        strLinitial = strFullName.Substring(0, 1)           'this line is giving last initial
        strFinitial = strFullName.Substring(CInt((CDbl(strlName) + 2)), 1)  'this line is first initial
        

        intF = CInt(CStr(CInt((strCity.IndexOf(",")))))    'this line stops at city
        intF = intF + 5
        strZip = CStr(CInt(strCity.Substring(CInt(intF), 4)))

        'building invoice
        lstInvoice.Items.Add("Invoice Number:" & "  " & strLinitial & strFinitial & strZip)  'returns GS16602
        lstInvoice.Items.Add(" ")
        lstInvoice.Items.Add("Name: " & strfName & " " & strFuName)
        lstInvoice.Items.Add("Address: " & strAddress)
        lstInvoice.Items.Add("City: " & strCity)
        lstInvoice.Items.Add(" ")
        lstInvoice.Items.Add("Number of Chairs: " & intChair)
        lstInvoice.Items.Add("Number of Sofas: " & intSofa)
        lstInvoice.Items.Add(" ")
        lstInvoice.Items.Add(String.Format(strFormat, "Cost: ", FormatCurrency(dblTotally)))
        lstInvoice.Items.Add(String.Format(strFormat, "Sales Tax: ", FormatCurrency(dblTax)))
        lstInvoice.Items.Add(String.Format(strFormat, " ", "----------"))
        lstInvoice.Items.Add(String.Format(strFormat, "Total Cost: ", FormatCurrency(dblTotal)))


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        lstInvoice.Items.Clear()

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub

    Function getFinitial()
        Dim strFullName As String = txtName.Text

        Return
    End Function
End Class
