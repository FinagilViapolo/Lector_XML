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
Imports System.Data.SqlClient
Imports System.Net
Imports System.Math
Imports System.WeakReference
Imports System.Text
Imports System
'Imports System.IO.DirectoryInfo
'Imports System.IO.FileInfo

Public Class frmEventoContable
    Dim pathCxpA As String = ""
    Dim posCol As Integer
    Dim posRow As Integer

    Dim res As readXML_CFDI_class = New readXML_CFDI_class
    Dim contador As Integer

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dgvFacturasXml.Rows.Clear()
        Dim cont_file As Integer = 0
        Dim result As DialogResult = fbdSeleccionar.ShowDialog()
        Dim taDetalleImpuestos As New productionTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim dtDetalleImpuestos As New production.Vw_CXP_ImpuestosCFDIDataTable
        Dim rowsCfdi As production.Vw_CXP_ImpuestosCFDIRow

        If (result = DialogResult.OK) Then
            pathCxpA = fbdSeleccionar.SelectedPath

            procesaXmlCxpA()


        End If

        Dim archivo_02 As String = ""

        Try
            cont_file = Directory.GetFiles(pathCxpA, "*.xml", SearchOption.AllDirectories).Length
            ToolStripLabel2.Text = "Archivos en directorio: " & cont_file
            ToolStripProgressBar1.Maximum = cont_file


            Dim cont As Integer = 0
            ' renombra archivos
            For Each archivo As String In Directory.GetFiles(pathCxpA, "*.xml", SearchOption.AllDirectories)
                Dim nombre() As String = archivo.Split(".")

                Rename(archivo, pathCxpA & "\" & res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio") & "." & nombre(1))
            Next

            For Each archivo As String In Directory.GetFiles(pathCxpA, "*.xml", SearchOption.AllDirectories)
                Dim drDatos As production.Vw_CXP_ImpuestosCFDIRow
                archivo_02 = archivo
                cont += 1

                taDetalleImpuestos.Fill(dtDetalleImpuestos, res.LeeXML(archivo, "UUID"))
                If dtDetalleImpuestos.Rows.Count > 0 Then
                    drDatos = dtDetalleImpuestos.Rows(0)
                End If

                dgvFacturasXml.Rows.Add(contador, "", drDatos.total, 0, res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & drDatos.concepto, res.LeeXML(archivo, "UUID"))

                For Each rowsCfdi In dtDetalleImpuestos.Rows

                    If rowsCfdi.mTras <> "X" Then
                        If rowsCfdi.tipoFactor = "Exento" Then
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.base), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        ElseIf rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.importeCon), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) = 0 Then
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.base), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        ElseIf rowsCfdi.tipoFactor = "Tasa" And CDec(rowsCfdi.mTras) > 0 Then
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.base), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.mTras), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        End If
                    Else
                        If rowsCfdi.tipoFactor = "No Objeto" Then
                            dgvFacturasXml.Rows.Add(contador, "", 0, FormatCurrency(rowsCfdi.importeCon - rowsCfdi.descuento), res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        End If
                    End If
                    If rowsCfdi.mRet <> "X" Then
                        dgvFacturasXml.Rows.Add(contador, "", FormatCurrency(rowsCfdi.mRet), 0, res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                    End If

                    If cont = 0 Then
                        If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                            dgvFacturasXml.Rows.Add(contador, "", FormatCurrency(rowsCfdi.mLocTra), 0, res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        End If
                        If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                            dgvFacturasXml.Rows.Add(contador, "", FormatCurrency(rowsCfdi.mLocRet), 0, res.LeeXML(archivo, "Serie") & "-" & res.LeeXML(archivo, "Folio"), res.LeeXML(archivo, "NombreR") & " " & rowsCfdi.concepto, res.LeeXML(archivo, "UUID"))
                        End If
                    End If
                Next



                ToolStripProgressBar1.Value = cont
                ToolStripLabel1.Text = CLng((ToolStripProgressBar1.Value * 100) / ToolStripProgressBar1.Maximum) & " %"
                Me.Update()
            Next

        Catch ex As Exception
            MsgBox(ex.ToString + "---" + archivo_02)
        End Try



        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frmEventoContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        contador = CInt(txtPolizaInicial.Text)
    End Sub

    Public Sub procesaXmlCxpA()
        Dim dtCxp As New XSDTableAdapters.CXP_XmlCfdi2TableAdapter
        Dim dtProveedores As New XSDTableAdapters.CXP_ProveedoresTableAdapter

        Dim D As System.IO.DirectoryInfo
        D = New System.IO.DirectoryInfo(pathCxpA)
        Dim res As readXML_CFDI_class = New readXML_CFDI_class

        For Each Archivo As String In Directory.GetFiles(pathCxpA)

            Dim nombre() As String = Archivo.Split(".")

            If nombre(1) <> "xml" And nombre(1) <> "XML" Then
                Exit For
            End If

            Dim impLocRet As Decimal
            Dim impLocTra As Decimal
            Dim cadXML As String
            Dim cadena As StreamReader
            Dim totalGl As Decimal = 0
            cadena = New StreamReader(Archivo)
            cadXML = cadena.ReadToEnd
            cadena.Close()


            Try
                If res.LeeXML(Archivo, "RFCE") = "ASE930924SS7" Then
                    If res.LeeXML(Archivo, "Edenred") <> "" Then
                        totalGl = CDec(res.LeeXML(Archivo, "Edenred"))
                    Else
                        totalGl = CDec(res.LeeXML(Archivo, "Total"))
                    End If
                Else
                    totalGl = CDec(res.LeeXML(Archivo, "Total"))
                End If

                If dtProveedores.ExisteProv_ScalarQuery(res.LeeXML(Archivo, "RFCE")) = "NE" Then
                    dtProveedores.Insert(res.LeeXML(Archivo, "RFCE"), Nothing, Nothing, res.LeeXML(Archivo, "NombreE"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, System.Data.SqlTypes.SqlDateTime.Null, Nothing, Nothing, Nothing, Nothing, Nothing)
                End If

                If dtCxp.Existe_ScalarQuery(leeXMLF(cadXML, "UUID")).ToString = "NE" Then
                    impLocTra = res.LeeXML(Archivo, "implocalT")
                    impLocRet = res.LeeXML(Archivo, "implocalR")

                    Dim conceptos As XmlNode = res.LeeXML_Conceptos(Archivo, "Concepto")
                    Dim contDetalle As Integer = 0
                    For Each detalle_conceptos As XmlNode In conceptos.ChildNodes
                        If detalle_conceptos.Name = "cfdi:Concepto" Then
                            Dim importe As String = Nothing
                            Dim claveSat As String = Nothing
                            Dim descuento As String = Nothing
                            Dim importeCuentaDeTerceros As String = Nothing
                            Dim concepto As String = Nothing
                            For Each conceptoDetalle As XmlNode In detalle_conceptos.Attributes
                                If conceptoDetalle.Name = "Descripcion" Then
                                    concepto = conceptoDetalle.Value.ToString
                                End If
                            Next
                            For Each complementosConcepto As XmlNode In detalle_conceptos.ChildNodes
                                If complementosConcepto.Name = "cfdi:ComplementoConcepto" Then
                                    For Each porCuentaDeTerceros As XmlNode In complementosConcepto.ChildNodes
                                        If porCuentaDeTerceros.Name = "terceros:PorCuentadeTerceros" Then
                                            For Each hijoPorCuentaDeTerceros As XmlNode In porCuentaDeTerceros.ChildNodes
                                                If hijoPorCuentaDeTerceros.Name = "terceros:Parte" Then
                                                    For Each tercerosParte As XmlNode In hijoPorCuentaDeTerceros.Attributes
                                                        If tercerosParte.Name = "importe" Then
                                                            importeCuentaDeTerceros = tercerosParte.Value.ToString
                                                        End If
                                                    Next
                                                End If
                                            Next
                                        End If
                                    Next
                                End If
                            Next
                            For Each atributosConceptos As XmlNode In detalle_conceptos.Attributes
                                If atributosConceptos.Name = "Importe" Then
                                    importe = atributosConceptos.Value.ToString
                                ElseIf atributosConceptos.Name = "ClaveProdServ" Then
                                    claveSat = atributosConceptos.Value.ToString
                                ElseIf atributosConceptos.Name = "Descuento" Then
                                    descuento = atributosConceptos.Value.ToString
                                End If
                            Next
                            If detalle_conceptos.ChildNodes.Count = 0 Then
                                contDetalle += 1
                                dtCxp.Insert(res.LeeXML(Archivo, "RFCE"), res.LeeXML(Archivo, "RFCR"), CDec(res.LeeXML(Archivo, "SubTotal")) - CDec(res.LeeXML(Archivo, "Descuento")), Nothing, Nothing, res.LeeXML(Archivo, "UUID"), res.LeeXML(Archivo, "NombreE"), res.LeeXML(Archivo, "Moneda"), res.LeeXML(Archivo, "MetodoPago"), res.LeeXML(Archivo, "FormaPago"), CDec(res.LeeXML(Archivo, "TipoCambio")), res.LeeXML(Archivo, "TipoDeComprobante"), res.LeeXML(Archivo, "Serie"), res.LeeXML(Archivo, "Folio"), res.LeeXML(Archivo, "Fecha"), res.LeeXML(Archivo, "FechaTimbrado"), System.Data.SqlTypes.SqlDateTime.Null, "PENDIENTE", totalGl, contDetalle.ToString, Nothing, Nothing, impLocRet, impLocTra, Nothing, Nothing, Nothing, importe, claveSat, descuento, importeCuentaDeTerceros, concepto)
                            End If


                            For Each concepto_hijos As XmlNode In detalle_conceptos.ChildNodes
                                'If concepto_hijos.Name = "cfdi:ComplementoConcepto" Then
                                '    For Each concepto_hijo_complemento As XmlNode In concepto_hijos.ChildNodes
                                '        If concepto_hijo_complemento.Name = "iedu:instEducativas" Then
                                '            contDetalle += 1
                                '            dtCxp.Insert(res.LeeXML(Archivo, "RFCE"), res.LeeXML(Archivo, "RFCR"), CDec(res.LeeXML(Archivo, "SubTotal")) - CDec(res.LeeXML(Archivo, "Descuento")), Nothing, Nothing, res.LeeXML(Archivo, "UUID"), res.LeeXML(Archivo, "NombreE"), res.LeeXML(Archivo, "Moneda"), res.LeeXML(Archivo, "MetodoPago"), res.LeeXML(Archivo, "FormaPago"), CDec(res.LeeXML(Archivo, "TipoCambio")), res.LeeXML(Archivo, "TipoDeComprobante"), res.LeeXML(Archivo, "Serie"), res.LeeXML(Archivo, "Folio"), res.LeeXML(Archivo, "Fecha"), res.LeeXML(Archivo, "FechaTimbrado"), System.Data.SqlTypes.SqlDateTime.Null, "PENDIENTE", totalGl, contDetalle.ToString, Nothing, Nothing, impLocRet, impLocTra, Nothing, Nothing, Nothing, Nothing, Nothing)
                                '        End If
                                '    Next
                                'End If

                                If concepto_hijos.Name = "cfdi:Impuestos" Then
                                    For Each impuestos_detalle As XmlNode In concepto_hijos.ChildNodes
                                        If impuestos_detalle.Name = "cfdi:Traslados" Then
                                            Dim Base As String = ""
                                            Dim Impuesto As String = ""
                                            Dim Tipofactor As String = ""
                                            Dim TasaOCuota As String = "0"
                                            Dim ImporteImpuesto As String = "0"
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
                                                    'Insert
                                                    contDetalle += 1
                                                    dtCxp.Insert(res.LeeXML(Archivo, "RFCE"), res.LeeXML(Archivo, "RFCR"), CDec(res.LeeXML(Archivo, "SubTotal")) - CDec(res.LeeXML(Archivo, "Descuento")), Impuesto, CDec(ImporteImpuesto), res.LeeXML(Archivo, "UUID"), res.LeeXML(Archivo, "NombreE"), res.LeeXML(Archivo, "Moneda"), res.LeeXML(Archivo, "MetodoPago"), res.LeeXML(Archivo, "FormaPago"), CDec(res.LeeXML(Archivo, "TipoCambio")), res.LeeXML(Archivo, "TipoDeComprobante"), res.LeeXML(Archivo, "Serie"), res.LeeXML(Archivo, "Folio"), res.LeeXML(Archivo, "Fecha"), res.LeeXML(Archivo, "FechaTimbrado"), System.Data.SqlTypes.SqlDateTime.Null, "PENDIENTE", totalGl, contDetalle.ToString, Tipofactor, CDec(TasaOCuota), impLocRet, impLocTra, Nothing, Base, Nothing, Nothing, Nothing, descuento, importeCuentaDeTerceros, concepto)
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
                                                    'Insert
                                                    contDetalle += 1
                                                    dtCxp.Insert(res.LeeXML(Archivo, "RFCE"), res.LeeXML(Archivo, "RFCR"), CDec(res.LeeXML(Archivo, "SubTotal")) - CDec(res.LeeXML(Archivo, "Descuento")), Impuesto, Nothing, res.LeeXML(Archivo, "UUID"), res.LeeXML(Archivo, "NombreE"), res.LeeXML(Archivo, "Moneda"), res.LeeXML(Archivo, "MetodoPago"), res.LeeXML(Archivo, "FormaPago"), CDec(res.LeeXML(Archivo, "TipoCambio")), res.LeeXML(Archivo, "TipoDeComprobante"), res.LeeXML(Archivo, "Serie"), res.LeeXML(Archivo, "Folio"), res.LeeXML(Archivo, "Fecha"), res.LeeXML(Archivo, "FechaTimbrado"), System.Data.SqlTypes.SqlDateTime.Null, "PENDIENTE", totalGl, contDetalle.ToString, Tipofactor, CDec(TasaOCuota), impLocRet, impLocTra, CDec(ImporteImpuesto), Nothing, Base, Nothing, Nothing, descuento, importeCuentaDeTerceros, concepto)
                                                End If
                                            Next

                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next

                    'System.IO.File.Move(Archivo, pathCxpA & "Procesados\" & leeXMLF(cadXML, "UUID") & ".xml")
                    'System.IO.File.Move(pathCxpA & nombre(0) & ".pdf", pathCxpA & "Procesados\" & leeXMLF(cadXML, "UUID") & ".pdf")
                End If
            Catch ex As Exception
            End Try
            'File.Delete(Archivo)
            'File.Delete(pathCxpA & nombre(0) & ".pdf")
        Next
    End Sub

    Public Function leeXMLF(docXML As String, nodo As String)

        Dim doc As XmlDataDocument
        doc = New XmlDataDocument
        doc.LoadXml(docXML)
        Dim CFDI As XmlNode
        Dim retorno As String = ""

        CFDI = doc.DocumentElement
        If nodo = "RFCR" Or nodo = "RFCE" Or nodo = "NombreR" Or nodo = "NombreE" Then
            For Each comprobante As XmlNode In CFDI.ChildNodes
                If comprobante.Name = "cfdi:Receptor" And (nodo = "RFCR" Or nodo = "NombreR") Then
                    For Each receptor As XmlNode In comprobante.Attributes
                        If receptor.Name = "Rfc" Then
                            retorno = receptor.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                        If receptor.Name = "Nombre" And nodo = "NombreR" Then
                            retorno = receptor.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                    Next
                End If
                If comprobante.Name = "cfdi:Emisor" And (nodo = "RFCE" Or nodo = "NombreE") Then
                    For Each receptor As XmlNode In comprobante.Attributes
                        If receptor.Name = "Rfc" And nodo = "RFCE" Then
                            retorno = receptor.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                        If receptor.Name = "Nombre" And nodo = "NombreE" Then
                            retorno = receptor.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "TIR" Or nodo = "TIT" Then
            For Each comprobante As XmlNode In CFDI.ChildNodes
                If comprobante.Name = "cfdi:Impuestos" Then
                    For Each comprobanteC As XmlNode In comprobante.Attributes
                        If comprobanteC.Name = "TotalImpuestosTrasladados" And nodo = "TIT" Then
                            retorno = comprobanteC.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                        If comprobanteC.Name = "TotalImpuestosRetenidos" And nodo = "TIR" Then
                            retorno = comprobanteC.Value.ToString
                            Return retorno
                            Exit Function
                        End If
                    Next
                End If
            Next
        End If



        If nodo <> "UUID" And nodo <> "FechaT" Then
            For Each Comprobante As XmlNode In CFDI.Attributes
                If Comprobante.Name = "Moneda" And nodo = "Moneda" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf Comprobante.Name = "TipoCambio" And nodo = "TipoCambio" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf Comprobante.Name = "TipoDeComprobante" And nodo = "TipoDeComprobante" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf (Comprobante.Name = "Total" Or Comprobante.Name = "total") And nodo = "Total" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf (Comprobante.Name = "MetodoPago" Or Comprobante.Name = "metodoDePago") And nodo = "MetodoPago" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf Comprobante.Name = "FormaPago" And nodo = "FormaPago" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf (Comprobante.Name = "Serie" Or Comprobante.Name = "serie") And nodo = "Serie" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                ElseIf (Comprobante.Name = "Folio" Or Comprobante.Name = "folio") And nodo = "Folio" Then
                    If Comprobante.Value.ToString.Length > 19 Then
                        retorno = (Comprobante.Value.ToString).Substring(0, 20)
                    Else
                        retorno = Comprobante.Value.ToString
                    End If

                    If Comprobante.Value.ToString = "" Then
                        retorno = 0
                    End If
                    Return retorno
                    Exit Function
                ElseIf Comprobante.Name = "Fecha" And nodo = "Fecha" Then
                    retorno = Comprobante.Value.ToString
                    Return retorno
                    Exit Function
                End If
            Next
        Else
            For Each Comprobante As XmlNode In CFDI.ChildNodes
                For Each Complemento As XmlNode In Comprobante
                    If Complemento.Name = "tfd:TimbreFiscalDigital" Then
                        For Each atributos As XmlNode In Complemento.Attributes
                            If atributos.Name = "UUID" And nodo = "UUID" Then
                                retorno = atributos.Value.ToString
                                Return retorno
                                Exit Function
                            End If
                            If atributos.Name = "FechaTimbrado" And nodo = "FechaT" Then
                                retorno = atributos.Value.ToString
                                Return retorno
                                Exit Function
                            End If
                        Next
                    End If
                Next
            Next
        End If
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerarPolizas_Click(sender As Object, e As EventArgs) Handles btnGenerarPolizas.Click
        sfdGuardarPolizas = New SaveFileDialog
        sfdGuardarPolizas.Filter = "txt files (*.txt)|*.txt"
        sfdGuardarPolizas.FilterIndex = 2
        sfdGuardarPolizas.RestoreDirectory = True
        sfdGuardarPolizas.FileName = "PD EXTERNA " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ".txt"
        Dim encabezadoD As String = ""
        Dim filePolizaD As StreamWriter

        Dim nConcepto As String = txtEncabezado.Text.Trim

        If nConcepto.Length > 100 Then
            nConcepto = nConcepto.Substring(0, 99)
        End If
        nConcepto = res.Stuff(nConcepto, "D", " ", 100)

        If sfdGuardarPolizas.ShowDialog = DialogResult.OK Then
            filePolizaD = New StreamWriter(sfdGuardarPolizas.FileName)
            encabezadoD = "P  " & dtpFechaPoliza.Value.ToString("yyyyMMdd") & "    3" & Space(10 - contador.ToString.Length) & contador & " 1 0          " & nConcepto & " 11 0 0 "
            filePolizaD.WriteLine(res.Eliminar_AcentosPolizas(encabezadoD.ToUpper))

            For Each rows As DataGridViewRow In dgvFacturasXml.Rows
                Dim concepto As String = rows.Cells.Item("concepto").Value
                If concepto.Length > 100 Then
                    concepto = concepto.Substring(0, 99)
                End If
                If rows.Cells.Item("cargo").Value > 0 Then
                    encabezadoD = "M1 " & res.Stuff(rows.Cells.Item("cuenta").Value, "D", " ", 30) & Space(1) & res.Stuff(rows.Cells.Item("referencia").Value, "D", " ", 20) & Space(1) & "0" & Space(1) & res.Stuff(rows.Cells.Item("cargo").Value.ToString.Replace("$", "").Replace(",", ""), "D", " ", 20) & Space(1) & res.Stuff("0", "D", " ", 10) & Space(1) & res.Stuff("0.00", "D", " ", 20) & Space(1) & res.Stuff(concepto, "D", " ", 100) & Space(1) & "1   " & Space(1) & res.Stuff(rows.Cells.Item("uuid").Value, "D", " ", 33) & Space(37) & vbNewLine &
                    "AM " & rows.Cells.Item("uuid").Value & vbNewLine & "AD " & rows.Cells.Item("uuid").Value
                ElseIf rows.Cells.Item("abono").Value > 0 Then
                    encabezadoD = "M1 " & res.Stuff(rows.Cells.Item("cuenta").Value, "D", " ", 30) & Space(1) & res.Stuff(rows.Cells.Item("referencia").Value, "D", " ", 20) & Space(1) & "1" & Space(1) & res.Stuff(rows.Cells.Item("abono").Value.ToString.Replace("$", "").Replace(",", ""), "D", " ", 20) & Space(1) & res.Stuff("0", "D", " ", 10) & Space(1) & res.Stuff("0.00", "D", " ", 20) & Space(1) & res.Stuff(concepto, "D", " ", 100) & Space(1) & "1   " & Space(1) & res.Stuff(rows.Cells.Item("uuid").Value, "D", " ", 33) & Space(37) & vbNewLine &
                    "AM " & rows.Cells.Item("uuid").Value & vbNewLine & "AD " & rows.Cells.Item("uuid").Value
                End If
                filePolizaD.WriteLine(res.Eliminar_AcentosPolizas(encabezadoD.ToUpper))
            Next
            MsgBox("Proceso terminado...", MsgBoxStyle.Information, "")
        Else
            MsgBox("Proceso cancelado...", MsgBoxStyle.Information, "")
        End If
        filePolizaD.Close()
    End Sub

    Private Sub dgvFacturasXml_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturasXml.CellContentClick

    End Sub

    Private Sub dgvFacturasXml_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturasXml.CellClick
        posCol = e.ColumnIndex
        posRow = e.RowIndex

        If e.RowIndex < dgvFacturasXml.Rows.Count - 1 Then
            pnlCuentas.Visible = True
            cmbCuentas.Focus()
        End If
    End Sub

    Private Sub cmbCuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuentas.SelectedIndexChanged

    End Sub

    Private Sub cmbCuentas_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbCuentas.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            actualizaCuenta()
        ElseIf e.KeyCode = Keys.Escape Then
            pnlCuentas.Visible = False
        End If
    End Sub

    Public Sub actualizaCuenta()
        dgvFacturasXml.Item(1, posRow).Value = cmbCuentas.SelectedText
        pnlCuentas.Visible = False
    End Sub
End Class