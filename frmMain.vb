Public Class frmMain


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim strPrices As IO.StreamReader
        strPrices = IO.File.OpenText("Data.txt")
        Dim strInvoiceNumber As String = ("Invoice Number:")
        Dim strfName As String = txtName.Text
        Dim strlName As String
        Dim strFinitial As String
        Dim strLinitial As String
        Dim intF As Integer = 5
        Dim intNum As Integer = 0
        Dim intNum1 As Integer = 0
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
        Dim strChairPrice As String = 
        Dim dblSofaPrice As Double


        x = strFullName.IndexOf(" ")
        n = strFullName.IndexOf(",")
        strfName = strFullName.Substring(x)
        strFuName = strFullName.Substring(0, n)



        strlName = CStr(CInt(strFullName.IndexOf(",")))  'this line is giving length of last name
        strLinitial = strFullName.Substring(0, 1)           'this line is giving last initial
        strFinitial = strFullName.Substring(CInt((CDbl(strlName) + 2)), 1)  'this line is first initial
        

        intF = CInt(CStr(CInt((strCity.IndexOf(",")))))    'this line stops at city
        intF = intF + 5
        strZip = CStr(CInt(strCity.Substring(CInt(intF), 5)))

        'building invoice
        lstInvoice.Items.Add(strInvoiceNumber & "  " & strLinitial & strFinitial & strZip)  'returns GS16602
        lstInvoice.Items.Add(" ")
        lstInvoice.Items.Add("Name: " & strfName & " " & strFuName)
        lstInvoice.Items.Add("Address: " & strAddress)
        lstInvoice.Items.Add("City: " & strCity)
        lstInvoice.Items.Add(" ")
        lstInvoice.Items.Add("Number of Chairs: " & intChair)
        lstInvoice.Items.Add("Number of Sofas: " & intSofa)



        





    End Sub

    
End Class
