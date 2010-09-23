Public Class frmMain


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Dim strInvoiceNumber As String = ("Invoice Number:")
        Dim strfName As String
        Dim strlName As String
        Dim strAddress As String = txtAddress.Text
        Dim strCity As String = txtCity.Text
        Dim intChair As Integer = CInt(txtNumChair.Text)
        Dim intSofa As Integer = CInt(txtNumSofa.Text)
        Dim dblTax As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim strFullName As String = txtName.Text

        strfName = CStr(strFullName.IndexOf(","))

        lstInvoice.Items.Add = (strfName)




    End Sub
End Class
