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
Imports System.Web.Services.Protocols.SoapDocumentServiceAttribute
Imports Valida_SAT_WS
Imports System.Xml.XmlText
Imports System.Xml.Schema

Public Class frmIngreso
    Dim directorio_origen As String = ""
    Dim taContraro As New ATEBCOFIDIDataSetTableAdapters.TimbresEkomercioTableAdapter
    Dim dsContrato As New ATEBCOFIDIDataSet

    Public Sub btnLoadXML_Click(sender As Object, e As EventArgs) Handles btnLoadXML.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dgvIngresos.Rows.Clear()
        Dim cont_file As Integer = 0
        Dim result As DialogResult = fbdSelecDirArchivos.ShowDialog()

        If (result = DialogResult.OK) Then
            directorio_origen = fbdSelecDirArchivos.SelectedPath
        End If

        Dim archivo_02 As String = ""


        cont_file = Directory.GetFiles(directorio_origen, "*.xml", SearchOption.AllDirectories).Length
            ToolStripStatusLabel2.Text = "Archivos en directorio: " & cont_file
            ToolStripProgressBar1.Maximum = cont_file



            Dim res As readXML_CFDI_class = New readXML_CFDI_class
        Dim cont As Integer = 0
        Dim rootPath As String = My.Settings.Default.hostExe & "XSD"

        For Each archivo As String In Directory.GetFiles(directorio_origen, "*.xml", SearchOption.AllDirectories)

            archivo_02 = archivo
                cont += 1
            Dim resValidSAT(1) As String
            Dim version_valida As String = res.LeeXML(archivo, "Version")
                If chkValidaSAT.Checked = True Then
                resValidSAT = res.Valida_SAT(res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID")) 'res.Valida_SAT(res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"))
                'MsgBox(res.LeeXML(archivo, "RFCE") & "-" & res.LeeXML(archivo, "RFCR") & "-" & res.LeeXML(archivo, "Total") & "-" & res.LeeXML(archivo, "UUID"))
                Dim resXSD As validaXSD = New validaXSD
                    Dim var As String = "VALIDO"
                    Try
                        resXSD.LoadValidatedXmlDocument(archivo, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                        resXSD.LoadValidatedXDocument(archivo, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                        resXSD.LoadXml(archivo, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                    Catch ex As Exception
                        var = ex.ToString
                    End Try
                End If


            Dim complementoXml As String
            If chkDesglose.Checked = True Then
                complementoXml = res.LeeXML(archivo, "ComplementoXML")
            End If
            Dim serie As String = res.LeeXML(archivo, "Serie")
                Dim folio As String = res.LeeXML(archivo, "Folio")
                Dim TipoRelacion As String = res.LeeXML(archivo, "TipoRelacion")
                Dim TipoRelacionUUID As String = res.LeeXML(archivo, "TipoRelacionUUID")
                Dim FechaTimbrado As String = res.LeeXML(archivo, "FechaTimbrado")
                Dim contrato As String = ""
                Dim tcredito As String = ""

                If chkContTCred.Checked = True And (res.LeeXML(archivo, "RFCE") = "FIN940905AX7" Or res.LeeXML(archivo, "RFCE") = "SAR951230N5A") Then
                    Try
                        contrato = Me.taContraro.ObtContrato(serie, folio).ToString
                    Catch ex As Exception
                        contrato = "NOT FOUND"
                    End Try
                    If contrato <> "NOT FOUND" Then
                        contrato = Me.taContraro.ObtContrato(serie, folio).ToString.Insert(5, "/")
                    Else
                        contrato = "NOT FOUND"
                    End If
                    If serie.Trim = "AV" Or serie.Trim = "AAV" Then
                        Try
                            contrato = Me.taContraro.ObtContrato_CFDI_ScalarQuery(serie, folio).ToString
                        Catch ex As Exception
                            contrato = "NOT FOUND"
                        End Try
                    End If
                Else
                    contrato = ""
                End If

                If contrato <> "" Then
                    tcredito = Me.taContraro.ObtTCredito(contrato.Replace("/", ""))
                Else
                    tcredito = ""
                End If

            If chkDesglose.Checked = True Then

                Dim nodos_conceptos As Integer = CInt(res.LeeXML(archivo, "NoCon"))
                Dim conceptos As XmlNode = res.LeeXML_Conceptos(archivo, "Concepto")


                Dim contador As Integer = 0

                For Each detalle_conceptos As XmlNode In conceptos.ChildNodes
                    Dim ClaveProdServ As String = ""
                    Dim Cantidad As String = ""
                    Dim ClaveUnidad As String = ""
                    Dim Unidad As String = ""
                    Dim Descripcion As String = ""
                    Dim ValorUnitario As String = ""
                    Dim Importe As String = ""



                    If version_valida = "3.2" Then
                        For Each concepto_atributos As XmlNode In detalle_conceptos.Attributes
                            If concepto_atributos.Name = "ClaveProdServ" Then
                                ClaveProdServ = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "Cantidad" Or concepto_atributos.Name = "cantidad" Then
                                Cantidad = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "ClaveUnidad" Then
                                ClaveUnidad = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "Unidad" Or concepto_atributos.Name = "unidad" Then
                                Unidad = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "Descripcion" Or concepto_atributos.Name = "descripcion" Then
                                Descripcion = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "ValorUnitario" Or concepto_atributos.Name = "valorUnitario" Then
                                ValorUnitario = concepto_atributos.Value.ToString
                            ElseIf concepto_atributos.Name = "Importe" Or concepto_atributos.Name = "importe" Then
                                Importe = concepto_atributos.Value.ToString
                            End If
                            contador += 1
                        Next

                        Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion, ValorUnitario, Importe, "", "", "", "", "", res.LeeXML(archivo, "ImpuestosT"), "", "", "", "", "", "", res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT, res.LeeXML(archivo, "Version"), contrato, tcredito, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", complementoXml, archivo)
                    End If

                    For Each concepto_atributos As XmlNode In detalle_conceptos.Attributes
                        If concepto_atributos.Name = "ClaveProdServ" Then
                            ClaveProdServ = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "Cantidad" Or concepto_atributos.Name = "cantidad" Then
                            Cantidad = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "ClaveUnidad" Then
                            ClaveUnidad = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "Unidad" Or concepto_atributos.Name = "unidad" Then
                            Unidad = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "Descripcion" Or concepto_atributos.Name = "descripcion" Then
                            Descripcion = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "ValorUnitario" Or concepto_atributos.Name = "valorUnitario" Then
                            ValorUnitario = concepto_atributos.Value.ToString
                        ElseIf concepto_atributos.Name = "Importe" Or concepto_atributos.Name = "importe" Then
                            Importe = concepto_atributos.Value.ToString
                        End If
                        contador += 1
                    Next

                    If detalle_conceptos.ChildNodes.Count = 0 And res.LeeXML(archivo, "TipoDeComprobante") <> "P" Then
                        Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion, ValorUnitario, Importe, "", "", "", "", "", res.LeeXML(archivo, "ImpuestosT"), "", "", "", "", "", "", res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT, res.LeeXML(archivo, "Version"), contrato, tcredito, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", complementoXml, archivo)
                    End If

                    If res.LeeXML(archivo, "TipoDeComprobante") = "P" Then
                        Dim pagos_detalle As XmlNode = res.LeeXML_Pagos(archivo, "PagosDetalle")
                        For Each pagos_detalle_pagos As XmlNode In pagos_detalle.ChildNodes
                            If pagos_detalle_pagos.Name = "pago10:DoctoRelacionado" Then
                                Dim IdDocumento As String = ""
                                Dim SerieCP As String = ""
                                Dim FolioCP As String = ""
                                Dim MonedaDR As String = ""
                                Dim MetodoDePagoDR As String = ""
                                Dim NumParcialidad As String = ""
                                Dim ImpSaldoAnt As String = ""
                                Dim ImpPagado As String = ""
                                Dim ImpSaldoInsoluto As String = ""
                                For Each pago_detalle_atributos As XmlNode In pagos_detalle_pagos.Attributes
                                    If pago_detalle_atributos.Name = "IdDocumento" Then
                                        IdDocumento = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "Serie" Then
                                        SerieCP = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "Folio" Then
                                        FolioCP = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "MonedaDR" Then
                                        MonedaDR = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "MetodoDePagoDR" Then
                                        MetodoDePagoDR = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "NumParcialidad" Then
                                        NumParcialidad = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "ImpSaldoAnt" Then
                                        ImpSaldoAnt = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "ImpPagado" Then
                                        ImpPagado = pago_detalle_atributos.Value
                                    ElseIf pago_detalle_atributos.Name = "ImpSaldoInsoluto" Then
                                        ImpSaldoInsoluto = pago_detalle_atributos.Value
                                    End If
                                Next
                                Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion, ValorUnitario, Importe, "", "", "", "", "", res.LeeXML(archivo, "ImpuestosT"), "", "", "", "", "", "", res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT, res.LeeXML(archivo, "Version"), contrato, tcredito, res.LeeXML_Pagos(archivo, "VersionCP"), res.LeeXML_Pagos(archivo, "FechaPago"), res.LeeXML_Pagos(archivo, "FormaDePagoP"), res.LeeXML_Pagos(archivo, "MonedaP"), res.LeeXML_Pagos(archivo, "Monto"), res.LeeXML_Pagos(archivo, "NumOperacion"), res.LeeXML_Pagos(archivo, "RfcEmisorCtaBen"), res.LeeXML_Pagos(archivo, "CtaBeneficiario"), IdDocumento, SerieCP, FolioCP, MonedaDR, MetodoDePagoDR, NumParcialidad, ImpSaldoAnt, ImpPagado, ImpSaldoInsoluto)
                            End If
                        Next
                    End If

                    For Each concepto_hijos As XmlNode In detalle_conceptos.ChildNodes
                        If concepto_hijos.Name = "cfdi:Impuestos" Then

                            For Each impuestos_detalle As XmlNode In concepto_hijos.ChildNodes
                                If impuestos_detalle.Name = "cfdi:Traslados" Then
                                    Dim Base As String = ""
                                    Dim Impuesto As String = ""
                                    Dim Tipofactor As String = ""
                                    Dim TasaOCuota As String = ""
                                    Dim ImporteImpuesto As String = ""
                                    For Each impuestos_traslado As XmlNode In impuestos_detalle.ChildNodes
                                        If impuestos_traslado.Name = "cfdi:Traslado" Then
                                            For Each impuestos_traslado_atributos As XmlNode In impuestos_traslado.Attributes
                                                If impuestos_traslado_atributos.Name = "Base" Then
                                                    Base = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "Impuesto" Then
                                                    Impuesto = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "TipoFactor" Then
                                                    Tipofactor = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "TasaOCuota" Then
                                                    TasaOCuota = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "Importe" Then
                                                    ImporteImpuesto = impuestos_traslado_atributos.Value.ToString
                                                End If
                                            Next
                                            Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion, ValorUnitario, Importe, Base, Impuesto, Tipofactor, TasaOCuota, ImporteImpuesto, res.LeeXML(archivo, "ImpuestosT"), "", "", "", "", "", "", res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT, res.LeeXML(archivo, "Version"), contrato, tcredito, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", complementoXml, archivo)
                                        End If
                                    Next
                                End If
                                If impuestos_detalle.Name = "cfdi:Retenciones" Then
                                    Dim Base As String = ""
                                    Dim Impuesto As String = ""
                                    Dim Tipofactor As String = ""
                                    Dim TasaOCuota As String = ""
                                    Dim ImporteImpuesto As String = ""
                                    For Each impuestos_traslado As XmlNode In impuestos_detalle.ChildNodes
                                        If impuestos_traslado.Name = "cfdi:Retencion" Then
                                            For Each impuestos_traslado_atributos As XmlNode In impuestos_traslado.Attributes
                                                If impuestos_traslado_atributos.Name = "Base" Then
                                                    Base = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "Impuesto" Then
                                                    Impuesto = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "TipoFactor" Then
                                                    Tipofactor = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "TasaOCuota" Then
                                                    TasaOCuota = impuestos_traslado_atributos.Value.ToString
                                                ElseIf impuestos_traslado_atributos.Name = "Importe" Then
                                                    ImporteImpuesto = impuestos_traslado_atributos.Value.ToString
                                                End If
                                            Next
                                            Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion, ValorUnitario, Importe, "", "", "", "", "", "", Base, Impuesto, Tipofactor, TasaOCuota, ImporteImpuesto, res.LeeXML(archivo, "ImpuestosR"), res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT, res.LeeXML(archivo, "Version"), contrato, tcredito, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", complementoXml, archivo)
                                        End If
                                    Next

                                End If
                            Next

                        End If
                    Next
                Next
            Else
                Me.dgvIngresos.Rows.Add(serie, folio, res.LeeXML(archivo, "RFCE"), res.LeeXML(archivo, "NombreE"), res.LeeXML(archivo, "RegimenFiscal"), res.LeeXML(archivo, "RFCR"), res.LeeXML(archivo, "NombreR"), res.LeeXML(archivo, "UsoCFDI"), res.LeeXML(archivo, "TipoDeComprobante"), res.LeeXML(archivo, "Fecha"), res.LeeXML(archivo, "FormaPago"), res.LeeXML(archivo, "CondicionesDePago"), res.LeeXML(archivo, "Moneda"), res.LeeXML(archivo, "MetodoPago"), TipoRelacion, TipoRelacionUUID, "", "", "", "", "", "", "", "", "", "", "", "", res.LeeXML(archivo, "ImpuestosT"), "", "", "", "", "", "", res.LeeXML(archivo, "SubTotal"), res.LeeXML(archivo, "Descuento"), res.LeeXML(archivo, "Total"), res.LeeXML(archivo, "UUID"), FechaTimbrado, resValidSAT(0), res.LeeXML(archivo, "Version"), contrato, tcredito, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", complementoXml, archivo, resValidSAT(1))
            End If
            ToolStripProgressBar1.Value = cont
            ToolStripStatusLabel1.Text = CLng((ToolStripProgressBar1.Value * 100) / ToolStripProgressBar1.Maximum) & " % ( Filas: " & dgvIngresos.Rows.Count.ToString & ")"
            Me.Update()
            'Catch ex As Exception
            '    MsgBox("El archivo****:  " & archivo_02 & " **presenta los siguiente errores***: " & ex.ToString + "---", MsgBoxStyle.Critical, "Nombre del archivo con errores: " & archivo_02)
            'End Try
        Next

        MsgBox("Proceso terminado", MsgBoxStyle.Information)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Function lee_nodo_concepto(ByVal archivo As XmlNode, ByVal nodo As String)
        Dim doc As XmlNode
        Dim resultado As String = ""
        doc = archivo

        For Each concepto As XmlNode In archivo.ChildNodes
            For Each concepto_atributos As XmlNode In concepto.Attributes
                If concepto_atributos.Name = "Descripcion" And nodo = "Descripcion" Then
                    resultado = concepto_atributos.Value.ToString
                    Return resultado
                    Exit For
                End If
            Next
        Next
    End Function
    Private Sub btnCofidi_Click(sender As Object, e As EventArgs) Handles btnCofidi.Click
        Dim f As frmIngresoCOFIDI
        f = New frmIngresoCOFIDI
        f.Show()
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
        HojaExcel.Range("E2:J2").Value = "REPORTE DE COMPROBANTES FISCALES DIGITALES"
        HojaExcel.Range("E2:J2").Font.Bold = True
        HojaExcel.Range("E2:J2").Font.Size = 15
        'HojaExcel.Columns.AutoFit()

        Dim objCelda As Excel.Range
        objCelda = HojaExcel.Range("A5", Type.Missing)
        objCelda.Value = ""


        objCelda = HojaExcel.Range("B5", Type.Missing)
        objCelda.Value = "Serie"

        objCelda = HojaExcel.Range("C5", Type.Missing)
        objCelda.Value = "Folio"
        objCelda.EntireColumn.NumberFormat = "###"

        objCelda = HojaExcel.Range("D5", Type.Missing)
        objCelda.Value = "RFC Emisor"

        objCelda = HojaExcel.Range("E5", Type.Missing)
        objCelda.Value = "Nombre Emisor"

        objCelda = HojaExcel.Range("F5", Type.Missing)
        objCelda.Value = "Régimen Fiscal"

        objCelda = HojaExcel.Range("G5", Type.Missing)
        objCelda.Value = "RFC Recepctor"

        objCelda = HojaExcel.Range("H5", Type.Missing)
        objCelda.Value = "Nombre Receptor"

        objCelda = HojaExcel.Range("I5", Type.Missing)
        objCelda.Value = "Uso CFDI"

        objCelda = HojaExcel.Range("J5", Type.Missing)
        objCelda.Value = "Tipo Comprobante"

        objCelda = HojaExcel.Range("K5", Type.Missing)
        objCelda.EntireColumn.NumberFormat = "dd/mm/yyyy;@"
        objCelda.Value = "Fecha Emisión"

        objCelda = HojaExcel.Range("L5", Type.Missing)
        objCelda.Value = "Forma Pago"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("M5", Type.Missing)
        objCelda.Value = "Cond de Pago"

        objCelda = HojaExcel.Range("N5", Type.Missing)
        objCelda.Value = "Moneda"

        objCelda = HojaExcel.Range("O5", Type.Missing)
        objCelda.Value = "Metodo Pago"

        objCelda = HojaExcel.Range("P5", Type.Missing)
        objCelda.Value = "TipoRelacion"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("Q5", Type.Missing)
        objCelda.Value = "TipoRelacionUUID"

        objCelda = HojaExcel.Range("R5", Type.Missing)
        objCelda.Value = "Clv Prod/Serv"

        objCelda = HojaExcel.Range("S5", Type.Missing)
        objCelda.Value = "Cantidad"

        objCelda = HojaExcel.Range("T5", Type.Missing)
        objCelda.Value = "Clv Unidad"

        objCelda = HojaExcel.Range("U5", Type.Missing)
        objCelda.Value = "Unidad"

        objCelda = HojaExcel.Range("V5", Type.Missing)
        objCelda.Value = "Concepto"

        objCelda = HojaExcel.Range("W5", Type.Missing)
        objCelda.Value = "P Unit"

        objCelda = HojaExcel.Range("X5", Type.Missing)
        objCelda.Value = "Importe"

        objCelda = HojaExcel.Range("Y5", Type.Missing)
        objCelda.Value = "Base (T)"

        objCelda = HojaExcel.Range("Z5", Type.Missing)
        objCelda.Value = "Impuesto (T)"
        objCelda.EntireColumn.NumberFormat = "@"

        objCelda = HojaExcel.Range("AA5", Type.Missing)
        objCelda.Value = "TipoFactor (T)"

        objCelda = HojaExcel.Range("AB5", Type.Missing)
        objCelda.Value = "TasaOCuota (T)"

        objCelda = HojaExcel.Range("AC5", Type.Missing)
        objCelda.Value = "Importe (T)"

        objCelda = HojaExcel.Range("AD5", Type.Missing)
        objCelda.Value = "Total Traslados"

        objCelda = HojaExcel.Range("AE5", Type.Missing)
        objCelda.Value = "Base (R)"

        objCelda = HojaExcel.Range("AF5", Type.Missing)
        objCelda.Value = "Impuesto (R)"
        objCelda.EntireColumn.ToString()

        objCelda = HojaExcel.Range("AG5", Type.Missing)
        objCelda.Value = "TipoFactor (R)"

        objCelda = HojaExcel.Range("AH5", Type.Missing)
        objCelda.Value = "TasaOCuota (R)"

        objCelda = HojaExcel.Range("AI5", Type.Missing)
        objCelda.Value = "Importe (R)"

        objCelda = HojaExcel.Range("AJ5", Type.Missing)
        objCelda.Value = "Total Retenidos"

        objCelda = HojaExcel.Range("AK5", Type.Missing)
        objCelda.Value = "SubTotal"

        objCelda = HojaExcel.Range("AL5", Type.Missing)
        objCelda.Value = "Descuento"

        objCelda = HojaExcel.Range("AM5", Type.Missing)
        objCelda.Value = "Total"

        objCelda = HojaExcel.Range("AN5", Type.Missing)
        objCelda.Value = "UUID"

        objCelda = HojaExcel.Range("AO5", Type.Missing)
        objCelda.EntireColumn.NumberFormat = "dd/mm/yyyy;@"
        objCelda.Value = "FechaTimbrado"

        objCelda = HojaExcel.Range("AP5", Type.Missing)
        objCelda.Value = "Estatus SAT"

        objCelda = HojaExcel.Range("AQ5", Type.Missing)
        objCelda.Value = "Versión"

        objCelda = HojaExcel.Range("AR5", Type.Missing)
        objCelda.Value = "Contrato"

        objCelda = HojaExcel.Range("AS5", Type.Missing)
        objCelda.Value = "Tipo de Crédito"

        '-----
        objCelda = HojaExcel.Range("AT5", Type.Missing)
        objCelda.Value = "Version CP"

        objCelda = HojaExcel.Range("AU5", Type.Missing)
        objCelda.EntireColumn.NumberFormat = "dd/mm/yyyy;@"
        objCelda.Value = "FechaPago"

        objCelda = HojaExcel.Range("AV5", Type.Missing)
        objCelda.Value = "FormaDePagoP"

        objCelda = HojaExcel.Range("AW5", Type.Missing)
        objCelda.Value = "MonedaP"

        objCelda = HojaExcel.Range("AX5", Type.Missing)
        objCelda.Value = "Monto"

        objCelda = HojaExcel.Range("AY5", Type.Missing)
        objCelda.Value = "NumOperacion"

        objCelda = HojaExcel.Range("AZ5", Type.Missing)
        objCelda.Value = "RfcEmisorCtaBen"

        objCelda = HojaExcel.Range("BA5", Type.Missing)
        objCelda.Value = "CtaBeneficiario"

        objCelda = HojaExcel.Range("BB5", Type.Missing)
        objCelda.Value = "IdDocumento"

        objCelda = HojaExcel.Range("BC5", Type.Missing)
        objCelda.Value = "Serie CP"

        objCelda = HojaExcel.Range("BD5", Type.Missing)
        objCelda.Value = "Folio CP"

        objCelda = HojaExcel.Range("BE5", Type.Missing)
        objCelda.Value = "MonedaDR"

        objCelda = HojaExcel.Range("BF5", Type.Missing)
        objCelda.Value = "MetodoDePagoDR"

        objCelda = HojaExcel.Range("BG5", Type.Missing)
        objCelda.Value = "NumParcialidad"

        objCelda = HojaExcel.Range("BH5", Type.Missing)
        objCelda.Value = "ImpSaldoAnt"

        objCelda = HojaExcel.Range("BI5", Type.Missing)
        objCelda.Value = "ImpPagado"

        objCelda = HojaExcel.Range("BJ5", Type.Missing)
        objCelda.Value = "ImpSaldoInsoluto"

        Dim i As Integer = 6
        ToolStripProgressBar1.Maximum = dgvIngresos.Rows.Count
        For Each filas As DataGridViewRow In dgvIngresos.Rows
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
            HojaExcel.Cells(i, "AQ") = filas.Cells(41).Value
            HojaExcel.Cells(i, "AR") = filas.Cells(42).Value
            HojaExcel.Cells(i, "AS") = filas.Cells(43).Value
            HojaExcel.Cells(i, "AT") = filas.Cells(44).Value
            HojaExcel.Cells(i, "AU") = filas.Cells(45).Value
            HojaExcel.Cells(i, "AV") = filas.Cells(46).Value
            HojaExcel.Cells(i, "AW") = filas.Cells(47).Value
            HojaExcel.Cells(i, "AX") = filas.Cells(48).Value
            HojaExcel.Cells(i, "AY") = filas.Cells(49).Value
            HojaExcel.Cells(i, "AZ") = filas.Cells(50).Value
            HojaExcel.Cells(i, "BA") = filas.Cells(51).Value
            HojaExcel.Cells(i, "BB") = filas.Cells(52).Value
            HojaExcel.Cells(i, "BC") = filas.Cells(53).Value
            HojaExcel.Cells(i, "BD") = filas.Cells(54).Value
            HojaExcel.Cells(i, "BE") = filas.Cells(55).Value
            HojaExcel.Cells(i, "BF") = filas.Cells(56).Value
            HojaExcel.Cells(i, "BG") = filas.Cells(57).Value
            HojaExcel.Cells(i, "BH") = filas.Cells(58).Value
            HojaExcel.Cells(i, "BI") = filas.Cells(59).Value
            HojaExcel.Cells(i, "BJ") = filas.Cells(60).Value

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
        MsgBox("Proceso terminado", MsgBoxStyle.Information)
    End Sub

    Private Sub btnBDEkomercio_Click(sender As Object, e As EventArgs) Handles btnBDEkomercio.Click
        Dim f As frmIngresoEk
        f = New frmIngresoEk
        f.Show()
    End Sub

    Public Function validaNull(valor As Object)
        If String.IsNullOrEmpty(valor) Then
            Return ""
            Exit Function
        Else
            Return valor
            Exit Function
        End If
    End Function

    Private Sub btnSepArchivos_Click(sender As Object, e As EventArgs) Handles btnSepArchivos.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim result_origen As DialogResult = fbdSeparar_Origen.ShowDialog()
            Dim result_destino As DialogResult = fbdSeparar_Destino.ShowDialog()

            Dim directorio_origen_sep As String = ""
            Dim directorio_destino_sep As String = ""

            Dim cont_file As Integer = Directory.GetFiles(fbdSeparar_Origen.SelectedPath, "*.xml", SearchOption.AllDirectories).Length
            ToolStripStatusLabel2.Text = "Archivos en directorio: " & cont_file
            ToolStripProgressBar1.Maximum = cont_file

            If (result_origen = DialogResult.OK) Then
                directorio_origen_sep = fbdSeparar_Origen.SelectedPath
            End If
            If (result_destino = DialogResult.OK) Then
                directorio_destino_sep = fbdSeparar_Destino.SelectedPath
            End If

            Dim res As readXML_CFDI_class = New readXML_CFDI_class
            Dim cont As Integer = 0
            For Each archivo As String In Directory.GetFiles(directorio_origen_sep, "*.xml", SearchOption.AllDirectories)
                Dim fecha As String = res.LeeXML(archivo, "Fecha")
                Dim anio As Integer = CDate(fecha).Year
                Dim mes As Integer = CDate(fecha).Month
                Dim dia As Integer = CDate(fecha).Day


                If Directory.Exists(directorio_destino_sep & "\" & anio & "\" & mes & "\" & dia) Then
                    System.IO.File.Move(archivo, directorio_destino_sep & "\" & anio & "\" & mes & "\" & dia & "\" & res.LeeXML(archivo, "UUID") & ".xml")
                Else
                    System.IO.Directory.CreateDirectory(directorio_destino_sep & "\" & anio & "\" & mes & "\" & dia)
                    System.IO.File.Move(archivo, directorio_destino_sep & "\" & anio & "\" & mes & "\" & dia & "\" & res.LeeXML(archivo, "UUID") & ".xml")
                End If
                cont += 1
                ToolStripProgressBar1.Value = cont
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvIngresos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIngresos.CellContentClick
        If dgvIngresos.Item("Complemento", e.RowIndex).Value = "ecsv:EstadoDeCuentaSiVale" Then
            Dim f As New frmIngresoCompCombustible
            f.archivo = dgvIngresos.Item("Archivo", e.RowIndex).Value
            f.Show()
        End If
    End Sub
End Class