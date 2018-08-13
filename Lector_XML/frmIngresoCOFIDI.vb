Imports System.IO
Imports System.Windows.Forms
Imports Lector_XML.readXML_CFDI_class
Imports System.Xml
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Configuration
Public Class frmIngresoCOFIDI
    Public Sub frmIngresoCOFIDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim res As readXML_CFDI_class = New readXML_CFDI_class
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.CFDI_Clientes_COFIDITableAdapter.Fill(Me.ATEBCOFIDIDataSet.CFDI_Clientes_COFIDI, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)), ComboBox1.Text)
            For Each filas As DataGridViewRow In CFDI_Clientes_COFIDIDataGridView.Rows
                If chkValidaSAT.Checked = True Then
                    CFDI_Clientes_COFIDIDataGridView.Item("estatussat", filas.Index).Value = res.Valida_SAT(filas.Cells(0).Value.ToString.Replace("0000000010", "FIN940905AX7"), filas.Cells(1).Value.ToString, filas.Cells(18).Value.ToString, filas.Cells(19).Value.ToString)
                End If
                CFDI_Clientes_COFIDIDataGridView.Item("version", filas.Index).Value = "3.2"
                Me.Update()
            Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnXLS_Click(sender As Object, e As EventArgs) Handles btnXLS.Click
        Dim appXL As Excel.Application
        Dim LibroExcel As Excel.Workbook
        Dim HojaExcel As Excel.Worksheet
        Dim indice As Integer = 2
        Dim res As readXML_CFDI_class = New readXML_CFDI_class
        appXL = CreateObject("Excel.Application")
        appXL.Visible = False 'Para que no se muestre mientras se crea
        LibroExcel = appXL.Workbooks.Add
        HojaExcel = LibroExcel.ActiveSheet
        ' Añadimos las cabeceras de las columnas con formato en negrita

        HojaExcel.Range("A1:E1").Font.Bold = True
        HojaExcel.Range("A1:E1").Font.Size = 15

        HojaExcel.Range("E2:J2").Merge()
        HojaExcel.Range("E2:J2").Value = "REPORTE DE COMPROBANTES FISCALES DIGITALES BD COFIDI"
        HojaExcel.Range("E2:J2").Font.Bold = True
        HojaExcel.Range("E2:J2").Font.Size = 15
        'HojaExcel.Columns.AutoFit()

        Dim objCelda As Excel.Range
        objCelda = HojaExcel.Range("A5", Type.Missing)
        objCelda.Value = ""


        objCelda = HojaExcel.Range("B5", Type.Missing)
        objCelda.Value = "Empresa"

        objCelda = HojaExcel.Range("C5", Type.Missing)
        objCelda.Value = "RFC"

        objCelda = HojaExcel.Range("D5", Type.Missing)
        objCelda.Value = "Nombre Emisor"

        objCelda = HojaExcel.Range("E5", Type.Missing)
        objCelda.Value = "Serie"

        objCelda = HojaExcel.Range("F5", Type.Missing)
        objCelda.Value = "Folio"
        objCelda.EntireColumn.NumberFormat = "###"

        objCelda = HojaExcel.Range("G5", Type.Missing)
        objCelda.Value = "Fecha Emisión"

        objCelda = HojaExcel.Range("H5", Type.Missing)
        objCelda.Value = "Moneda"

        objCelda = HojaExcel.Range("I5", Type.Missing)
        objCelda.Value = "Tipo de Cambio"

        objCelda = HojaExcel.Range("J5", Type.Missing)
        objCelda.Value = "Forma de Pago"

        objCelda = HojaExcel.Range("K5", Type.Missing)
        objCelda.Value = "Metodo de Pago"

        objCelda = HojaExcel.Range("L5", Type.Missing)
        objCelda.Value = "Descripción"

        objCelda = HojaExcel.Range("M5", Type.Missing)
        objCelda.Value = "Cantidad"

        objCelda = HojaExcel.Range("N5", Type.Missing)
        objCelda.Value = "Precio U"

        objCelda = HojaExcel.Range("O5", Type.Missing)
        objCelda.Value = "U Medida"

        objCelda = HojaExcel.Range("P5", Type.Missing)
        objCelda.Value = "Importe"

        objCelda = HojaExcel.Range("Q5", Type.Missing)
        objCelda.Value = "SubTotal"

        objCelda = HojaExcel.Range("R5", Type.Missing)
        objCelda.Value = "Descuento"

        objCelda = HojaExcel.Range("S5", Type.Missing)
        objCelda.Value = "Impuesto"

        objCelda = HojaExcel.Range("T5", Type.Missing)
        objCelda.Value = "Total"

        objCelda = HojaExcel.Range("U5", Type.Missing)
        objCelda.Value = "UUID"

        objCelda = HojaExcel.Range("V5", Type.Missing)
        objCelda.Value = "Estatus SAT"

        objCelda = HojaExcel.Range("W5", Type.Missing)
        objCelda.Value = "Vesrsión"

        Dim i As Integer = 6
        ToolStripProgressBar1.Maximum = CFDI_Clientes_COFIDIDataGridView.Rows.Count
        For Each filas As DataGridViewRow In CFDI_Clientes_COFIDIDataGridView.Rows
            HojaExcel.Cells(i, "A") = ""
            HojaExcel.Cells(i, "B") = filas.Cells(0).Value
            HojaExcel.Cells(i, "C") = filas.Cells(1).Value
            HojaExcel.Cells(i, "D") = filas.Cells(2).Value
            HojaExcel.Cells(i, "E") = filas.Cells(3).Value
            HojaExcel.Cells(i, "F") = filas.Cells(4).Value
            HojaExcel.Cells(i, "G") = filas.Cells(5).Value
            HojaExcel.Cells(i, "H") = filas.Cells(6).Value
            HojaExcel.Cells(i, "I") = filas.Cells(7).Value
            HojaExcel.Cells(i, "J") = filas.Cells(8).Value
            HojaExcel.Cells(i, "K") = filas.Cells(9).Value
            HojaExcel.Cells(i, "L") = filas.Cells(10).Value
            HojaExcel.Cells(i, "M") = filas.Cells(11).Value
            HojaExcel.Cells(i, "N") = filas.Cells(12).Value
            HojaExcel.Cells(i, "O") = filas.Cells(13).Value
            HojaExcel.Cells(i, "P") = filas.Cells(14).Value
            HojaExcel.Cells(i, "Q") = filas.Cells(15).Value
            HojaExcel.Cells(i, "R") = filas.Cells(16).Value
            HojaExcel.Cells(i, "S") = filas.Cells(17).Value
            HojaExcel.Cells(i, "T") = filas.Cells(18).Value
            HojaExcel.Cells(i, "U") = filas.Cells(19).Value
            HojaExcel.Cells(i, "V") = res.Valida_SAT(filas.Cells(0).Value, filas.Cells(3).Value, filas.Cells(18).Value, filas.Cells(19).Value)
            HojaExcel.Cells(i, "W") = filas.Cells(22).Value

            ToolStripProgressBar1.Value = filas.Index
            ToolStripStatusLabel1.Text = CLng((ToolStripProgressBar1.Value * 100) / ToolStripProgressBar1.Maximum) & " %"
            Me.Update()
            i += 1
        Next
        HojaExcel.Columns.AutoFit()

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Title = "Guardar documento Excel"
        saveFileDialog1.Filter = "Excel File|*.xls"
        saveFileDialog1.FileName = Guid.NewGuid.ToString
        saveFileDialog1.ShowDialog()
        ' Guardamos el excel en la ruta que ha especificado el usuario
        LibroExcel.SaveAs(saveFileDialog1.FileName)
        ' Cerramos el workbook
        appXL.Workbooks.Close()
        ' Eliminamos el objeto excel
        appXL.Quit()
    End Sub
End Class