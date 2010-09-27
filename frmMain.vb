Public Class frmMain


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim strInvoiceNumber As String = ("Invoice Number:")
        Dim strfName As String
        Dim strlName As String
        Dim strFinitial As String
        Dim strLinitial As String
        Dim intF As Integer
        Dim intL As Integer
        Dim strAddress As String = txtAddress.Text
        Dim strCity As String = txtCity.Text
        'Dim intChair As Integer = CInt(txtNumChair.Text)
        'Dim intSofa As Integer = CInt(txtNumSofa.Text)
        Dim dblTax As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim strFullName As String = txtName.Text


        strlName = CStr(CInt(strFullName.IndexOf(",")))
        strLinitial = strFullName.Substring(0, CInt(strlName))
        lstInvoice.Items.Add(strLinitial)

        'intF = strFullName.IndexOf(" ")
        'strFinitial = strFullName.IndexOf
        'strfName = CStr(strFullName.IndexOf(" "))
        'strInvoiceNumber = CStr(strfName.Substring)
        'lstInvoice .Items.Add ("Invoice Number: " &)
        lstInvoice.Items.Add(strFullName.Substring(CInt(strfName)))






    End Sub

    
End Class
