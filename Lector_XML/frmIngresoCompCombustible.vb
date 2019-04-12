Public Class frmIngresoCompCombustible

    Public archivo As String
    Private Sub frmIngresoCompCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim res As readXML_CFDI_class = New readXML_CFDI_class
        Dim f As New frmIngreso
        Dim complementoXml(,) As String = res.LeeXML(archivo, "ComplementoXMLCfdi")
        Dim tCantidad, tImporte, tIva, tIeps As Double
        For i As Integer = 0 To complementoXml.GetUpperBound(1)
            dgvComplemento.Rows.Add(complementoXml(0, i), complementoXml(1, i), complementoXml(2, i), complementoXml(3, i), complementoXml(4, i), complementoXml(5, i), complementoXml(9, i), complementoXml(8, i), complementoXml(12, i))
            tCantidad += CDbl(complementoXml(0, i))
            tImporte += CDbl(complementoXml(2, i))
            tIva += CDbl(complementoXml(5, i))
            tIeps += CDbl(complementoXml(8, i))
        Next
        TextBox1.Text = tCantidad.ToString
        TextBox2.Text = tImporte.ToString
        TextBox3.Text = tIva.ToString
        TextBox4.Text = tIeps.ToString
    End Sub
End Class