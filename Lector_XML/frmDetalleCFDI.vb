Public Class frmDetalleCFDI
    Public var_serie As String
    Public var_folio As String
    Public var_uuid As String

    Private Sub frmDetalleCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If var_folio = "" Then
            Me.CFDI_EncabezadoTableAdapter.Buscar_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, 0, var_serie, var_uuid)
        Else
            Me.CFDI_EncabezadoTableAdapter.Buscar_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, var_folio, var_serie, var_uuid)
        End If
        If GuidTextBox.Text.Trim = "" Or GuidTextBox.Text.Trim = "CANCELADA" Then
            btnCancelar.Enabled = False
        Else
            btnCancelar.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim taCancela As New ATEBCOFIDIDataSetTableAdapters.CFDI_EncabezadoTableAdapter
        Dim ask As MsgBoxResult = MsgBox("Está por cancelar el CFDI con folio fiscal: " + GuidTextBox.Text.Trim + vbNewLine + " , Serie: " + _27_Serie_ComprobanteTextBox.Text.Trim + " , Folio: " + _1_FolioTextBox.Text.Trim + vbNewLine + " del Receptor: " + _42_Nombre_ReceptorTextBox.Text.Trim, MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Try
                taCancela.CancelaCFDI_UpdateQuery(CInt(_1_FolioTextBox.Text.Trim), _27_Serie_ComprobanteTextBox.Text.Trim, GuidTextBox.Text.Trim)
                MsgBox("Proceso de cancelación ejectutado correctamente...", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class