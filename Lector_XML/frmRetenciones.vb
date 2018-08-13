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
                Me.dgvXMLRet.Rows.Add(res.LeeXML(archivo, "Version"), res.LeeXML(archivo, "FolioInt"), res.LeeXML(archivo, "FechaExp"), res.LeeXML(archivo, "CveRetenc"), res.LeeXML(archivo, "DescRetenc"), res.LeeXML(archivo, "RFCEmisor"), res.LeeXML(archivo, "NomDenRazSocE"), res.LeeXML(archivo, "CURPE"), res.LeeXML(archivo, "Nacionalidad"), res.LeeXML(archivo, "RFCRecep"), res.LeeXML(archivo, "NomDenRazSocR"), res.LeeXML(archivo, "CURPR"))
            Next

        Catch ex As Exception
            MsgBox(ex.ToString + "---" + archivo_02)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class