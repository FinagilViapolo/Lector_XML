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
Public Class frmRetenciones
    Dim directorio_origen As String = ""
    Private Sub btnLoadXML_Click(sender As Object, e As EventArgs) Handles btnLoadXML.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dgvXMLRet.Rows.Clear()
        Dim cont_file As Integer = 0
        Dim result As DialogResult = fbdSelecDirArchivos.ShowDialog()

        If (result = DialogResult.OK) Then
            directorio_origen = fbdSelecDirArchivos.SelectedPath
        End If

        Dim archivo_02 As String = ""

        Try
            cont_file = Directory.GetFiles(directorio_origen, "*.xml", SearchOption.AllDirectories).Length
            ToolStripStatusLabel2.Text = "Archivos en directorio: " & cont_file
            ToolStripProgressBar1.Maximum = cont_file

            Dim res As readXML_Retencion_class = New readXML_Retencion_class
            Dim cont As Integer = 0

            For Each archivo As String In Directory.GetFiles(directorio_origen, "*.xml", SearchOption.AllDirectories)
                archivo_02 = archivo
                cont += 1
                Me.dgvXMLRet.Rows.Add(res.LeeXML(archivo, "Version"), res.LeeXML(archivo, "FolioInt"), res.LeeXML(archivo, "FechaExp"), res.LeeXML(archivo, "CveRetenc"), res.LeeXML(archivo, "DescRetenc"), res.LeeXML(archivo, "RFCEmisor"), res.LeeXML(archivo, "NomDenRazSocE"), res.LeeXML(archivo, "CURPE"), res.LeeXML(archivo, "Nacionalidad"), res.LeeXML(archivo, "RFCRecep"), res.LeeXML(archivo, "NomDenRazSocR"), res.LeeXML(archivo, "CURPR"), res.LeeXML(archivo, "NumRegIdTrib"), res.LeeXML(archivo, "MesIni"), res.LeeXML(archivo, "MesFin"), res.LeeXML(archivo, "Ejerc"), res.LeeXML(archivo, "montoTotOperacion"), res.LeeXML(archivo, "montoTotGrav"), res.LeeXML(archivo, "montoTotExent"), res.LeeXML(archivo, "montoTotRet"), res.LeeXML(archivo, "BaseRet"), res.LeeXML(archivo, "Impuesto"), res.LeeXML(archivo, "montoRet"), res.LeeXML(archivo, "TipoPagoRet"), res.LeeXML(archivo, "VersionD"), res.LeeXML(archivo, "Version"), res.LeeXML(archivo, "SistFinanciero"), res.LeeXML(archivo, "RetiroAORESRetInt"), res.LeeXML(archivo, "OperFinancDerivad"), res.LeeXML(archivo, "MontIntNominal"), res.LeeXML(archivo, "MontIntReal"), res.LeeXML(archivo, "Perdida"), res.LeeXML(archivo, "CveTipDivOUtil"), res.LeeXML(archivo, "MontISRAcredRetMexico"), res.LeeXML(archivo, "MontISRAcredRetExtranjero"), res.LeeXML(archivo, "MontRetExtDivExt"), res.LeeXML(archivo, "TipoSocDistrDiv"), res.LeeXML(archivo, "MontISRAcredNal"), res.LeeXML(archivo, "MontDivAcumNal"), res.LeeXML(archivo, "MontDivAcumExt"), res.LeeXML(archivo, "UUID"))
                ToolStripProgressBar1.Value = cont
                ToolStripStatusLabel1.Text = CLng((ToolStripProgressBar1.Value * 100) / ToolStripProgressBar1.Maximum) & " %"
                Me.Update()
            Next

        Catch ex As Exception
            MsgBox(ex.ToString + "---" + archivo_02)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frmRetenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnXLS_Click(sender As Object, e As EventArgs) Handles btnXLS.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim appXL As Excel.Application
        Dim LibroExcel As Excel.Workbook
        Dim HojaExcel As Excel.Worksheet
        Dim indice As Integer = 2
        appXL = CreateObject("Excel.Application")
        appXL.Visible = False 'Para que no se muestre mientras se crea
        LibroExcel = appXL.Workbooks.Add
        HojaExcel = LibroExcel.ActiveSheet
        ' Añadimos las cabeceras de las columnas con formato en negrita

        HojaExcel.Range("A1:E1").Font.Bold = True
        HojaExcel.Range("A1:E1").Font.Size = 15

        HojaExcel.Range("E2:J2").Merge()
        HojaExcel.Range("E2:J2").Value = "REPORTE DE COMPROBANTES FISCALES POR RETENCIONES E INFORMACIÓN DE PAGOS"
        HojaExcel.Range("E2:J2").Font.Bold = True
        HojaExcel.Range("E2:J2").Font.Size = 15
        'HojaExcel.Columns.AutoFit()

        Dim objCelda As Excel.Range
        objCelda = HojaExcel.Range("A5", Type.Missing)
        objCelda.Value = ""


        objCelda = HojaExcel.Range("B5", Type.Missing)
        objCelda.Value = "Version"

        objCelda = HojaExcel.Range("C5", Type.Missing)
        objCelda.Value = "FolioInt"
        objCelda.EntireColumn.NumberFormat = "###"

        objCelda = HojaExcel.Range("D5", Type.Missing)
        objCelda.EntireColumn.NumberFormat = "dd/mm/yyyy;@"
        objCelda.Value = "FechaExp"

        objCelda = HojaExcel.Range("E5", Type.Missing)
        objCelda.Value = "CveRetenc"

        objCelda = HojaExcel.Range("F5", Type.Missing)
        objCelda.Value = "DescRetenc"

        objCelda = HojaExcel.Range("G5", Type.Missing)
        objCelda.Value = "RFCEmisor"

        objCelda = HojaExcel.Range("H5", Type.Missing)
        objCelda.Value = "NomDenRazSocE"

        objCelda = HojaExcel.Range("I5", Type.Missing)
        objCelda.Value = "CURPE"

        objCelda = HojaExcel.Range("J5", Type.Missing)
        objCelda.Value = "Nacionalidad"

        objCelda = HojaExcel.Range("K5", Type.Missing)
        objCelda.Value = "RFCRecep"

        objCelda = HojaExcel.Range("L5", Type.Missing)
        objCelda.Value = "NomDenRazSocR"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("M5", Type.Missing)
        objCelda.Value = "CURPR"

        objCelda = HojaExcel.Range("N5", Type.Missing)
        objCelda.Value = "NumRegIdTrib"

        objCelda = HojaExcel.Range("O5", Type.Missing)
        objCelda.Value = "MesIni"

        objCelda = HojaExcel.Range("P5", Type.Missing)
        objCelda.Value = "MesFin"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("Q5", Type.Missing)
        objCelda.Value = "Ejerc"

        objCelda = HojaExcel.Range("R5", Type.Missing)
        objCelda.Value = "montoTotOperacion"

        objCelda = HojaExcel.Range("S5", Type.Missing)
        objCelda.Value = "montoTotGrav"

        objCelda = HojaExcel.Range("T5", Type.Missing)
        objCelda.Value = "montoTotExent"

        objCelda = HojaExcel.Range("U5", Type.Missing)
        objCelda.Value = "montoTotRet"

        objCelda = HojaExcel.Range("V5", Type.Missing)
        objCelda.Value = "BaseRet"

        objCelda = HojaExcel.Range("W5", Type.Missing)
        objCelda.Value = "Impuesto"

        objCelda = HojaExcel.Range("X5", Type.Missing)
        objCelda.Value = "montoRet"

        objCelda = HojaExcel.Range("Y5", Type.Missing)
        objCelda.Value = "TipoPagoRet"

        objCelda = HojaExcel.Range("Z5", Type.Missing)
        objCelda.Value = "VersionD"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("AA5", Type.Missing)
        objCelda.Value = "Version"

        objCelda = HojaExcel.Range("AB5", Type.Missing)
        objCelda.Value = "SistFinanciero"

        objCelda = HojaExcel.Range("AC5", Type.Missing)
        objCelda.Value = "RetiroAORESRetInt"

        objCelda = HojaExcel.Range("AD5", Type.Missing)
        objCelda.Value = "OperFinancDerivad"

        objCelda = HojaExcel.Range("AE5", Type.Missing)
        objCelda.Value = "MontIntNominal"

        objCelda = HojaExcel.Range("AF5", Type.Missing)
        objCelda.Value = "MontIntReal"
        objCelda.EntireColumn.ToString()

        objCelda = HojaExcel.Range("AG5", Type.Missing)
        objCelda.Value = "Perdida"

        objCelda = HojaExcel.Range("AH5", Type.Missing)
        objCelda.Value = "CveTipDivOUtil"

        objCelda = HojaExcel.Range("AI5", Type.Missing)
        objCelda.Value = "MontISRAcredRetMexico"

        objCelda = HojaExcel.Range("AJ5", Type.Missing)
        objCelda.Value = "MontISRAcredRetExtranjero"

        objCelda = HojaExcel.Range("AK5", Type.Missing)
        objCelda.Value = "MontRetExtDivExt"

        objCelda = HojaExcel.Range("AL5", Type.Missing)
        objCelda.Value = "TipoSocDistrDiv"

        objCelda = HojaExcel.Range("AM5", Type.Missing)
        objCelda.Value = "MontISRAcredNal"

        objCelda = HojaExcel.Range("AN5", Type.Missing)
        objCelda.Value = "MontDivAcumNal"

        objCelda = HojaExcel.Range("AO5", Type.Missing)
        objCelda.Value = "MontDivAcumExt"

        objCelda = HojaExcel.Range("AP5", Type.Missing)
        objCelda.Value = "UUID"


        Dim i As Integer = 6
        ToolStripProgressBar1.Maximum = dgvXMLRet.Rows.Count
        For Each filas As DataGridViewRow In dgvXMLRet.Rows
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
            HojaExcel.Cells(i, "V") = filas.Cells(20).Value
            HojaExcel.Cells(i, "W") = filas.Cells(21).Value
            HojaExcel.Cells(i, "X") = filas.Cells(22).Value
            HojaExcel.Cells(i, "Y") = filas.Cells(23).Value
            HojaExcel.Cells(i, "Z") = filas.Cells(24).Value
            HojaExcel.Cells(i, "AA") = filas.Cells(25).Value
            HojaExcel.Cells(i, "AB") = filas.Cells(26).Value
            HojaExcel.Cells(i, "AC") = filas.Cells(27).Value
            HojaExcel.Cells(i, "AD") = filas.Cells(28).Value
            HojaExcel.Cells(i, "AE") = filas.Cells(29).Value
            HojaExcel.Cells(i, "AF") = filas.Cells(30).Value
            HojaExcel.Cells(i, "AG") = filas.Cells(31).Value
            HojaExcel.Cells(i, "AH") = filas.Cells(32).Value
            HojaExcel.Cells(i, "AI") = filas.Cells(33).Value
            HojaExcel.Cells(i, "AJ") = filas.Cells(34).Value
            HojaExcel.Cells(i, "AK") = filas.Cells(35).Value
            HojaExcel.Cells(i, "AL") = filas.Cells(36).Value
            HojaExcel.Cells(i, "AM") = filas.Cells(37).Value
            HojaExcel.Cells(i, "AN") = filas.Cells(38).Value
            HojaExcel.Cells(i, "AO") = filas.Cells(39).Value
            HojaExcel.Cells(i, "AP") = filas.Cells(40).Value

            ToolStripProgressBar1.Value = filas.Index
            ToolStripStatusLabel1.Text = CLng((ToolStripProgressBar1.Value * 100) / ToolStripProgressBar1.Maximum) & " %"
            Me.Update()
            i += 1
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
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