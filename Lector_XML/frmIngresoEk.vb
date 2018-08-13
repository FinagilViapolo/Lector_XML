Public Class frmIngresoEk
    Private Sub Timbres_FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.TimbresEkomercioTableAdapter.Timbres_Fill(Me.ATEBCOFIDIDataSet.TimbresEkomercio, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class