Public Class frmCancelacionCFDI
    Private Sub frmCancelacionCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.CFDI_EncabezadoTableAdapter.Top100_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado)
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarFolio.Text = "" Then
            Me.CFDI_EncabezadoTableAdapter.Buscar_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, 0, txtBuscarSerie.Text.Trim, txtBuscarUUID.Text.Trim)
        Else
            Me.CFDI_EncabezadoTableAdapter.Buscar_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, txtBuscarFolio.Text.Trim, txtBuscarSerie.Text.Trim, txtBuscarUUID.Text.Trim)
        End If
        'Me.CFDI_EncabezadoTableAdapter.Fill(Me.ATEBCOFIDIDataSet.CFDI_Encabezado)
        With CFDI_EncabezadoDataGridView
            .DataSource = CFDI_EncabezadoBindingSource
            .Refresh()
        End With
    End Sub

    Private Sub CFDI_EncabezadoDataGridView_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles CFDI_EncabezadoDataGridView.CellContentClick
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim f As New frmDetalleCFDI
        f.var_serie = _27_Serie_ComprobanteTextBox.Text.Trim
        f.var_folio = _1_FolioTextBox.Text.Trim
        f.var_uuid = GuidTextBox.Text.Trim
        f.Show()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarRango_Click(sender As Object, e As EventArgs) Handles btnBuscarRango.Click
        If txtFolioInicial.Text = "" Or txtFolioFinal.Text = "" Then
            Me.CFDI_EncabezadoTableAdapter.RangoFolios_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, 0, 0, tstSerieR.Text.Trim)
        Else
            Me.CFDI_EncabezadoTableAdapter.RangoFolios_FillBy(Me.ATEBCOFIDIDataSet.CFDI_Encabezado, txtFolioInicial.Text.Trim, txtFolioFinal.Text.Trim, tstSerieR.Text.Trim)
        End If
        'Me.CFDI_EncabezadoTableAdapter.Fill(Me.ATEBCOFIDIDataSet.CFDI_Encabezado)
        With CFDI_EncabezadoDataGridView
            .DataSource = CFDI_EncabezadoBindingSource
            .Refresh()
        End With
    End Sub
End Class