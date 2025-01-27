Imports System.Data
Imports System.Runtime.ConstrainedExecution
Imports System.Xml
Imports System.IO
Imports System.Windows.Forms

Public Class frmCfdiDesglose
    Private Sub frmCfdiDesglose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 5
            cmbYear.Items.Add(Date.Now.AddYears(-i).Year)
        Next
        cmbYear.SelectedItem = Date.Now.Year
        cmbMonth.SelectedIndex = Date.Now.Month - 1
        CrystalReportViewer1.Enabled = False
        ProgressBar1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim taCfdi As New productionTableAdapters.CFDI_ReporteDesgloseTableAdapter
        Dim dtCfdi As New production.CFDI_ReporteDesgloseDataTable
        Dim drCfdi As production.CFDI_ReporteDesgloseRow
        Dim Funciones As New Funciones
        Dim taFila As DataRow
        Dim no As Integer = 1

        taCfdi.Fill(dtCfdi, cmbMonth.SelectedIndex + 1, CInt(cmbYear.SelectedItem), "FIN940905AX7")

        Dim taAdapter As DataTable = New DataTable("factura")

        ProgressBar1.Visible = True
        ProgressBar1.Maximum = dtCfdi.Rows.Count

        taAdapter.Columns.Add("No", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("serie")
        taAdapter.Columns.Add("folio")
        taAdapter.Columns.Add("uuid")
        taAdapter.Columns.Add("fechaFac")
        taAdapter.Columns.Add("mes")
        taAdapter.Columns.Add("fechaTim")
        taAdapter.Columns.Add("rfcEmisor")
        taAdapter.Columns.Add("rfcReceptor")
        taAdapter.Columns.Add("formaPago")
        taAdapter.Columns.Add("subtotal", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("iva", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("total", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("metodoPago")
        taAdapter.Columns.Add("efectoComprobante")
        taAdapter.Columns.Add("contrato")
        taAdapter.Columns.Add("misc03")
        taAdapter.Columns.Add("usoCfdi")
        taAdapter.Columns.Add("addenda")
        taAdapter.Columns.Add("producto")
        taAdapter.Columns.Add("aviso")
        taAdapter.Columns.Add("regimenFiscal")
        taAdapter.Columns.Add("descripcion")
        taAdapter.Columns.Add("cantidad")
        taAdapter.Columns.Add("unidad")
        taAdapter.Columns.Add("precioUnitario", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("importe", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("objImp")
        taAdapter.Columns.Add("traslado_base", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("traslado_impuesto")
        taAdapter.Columns.Add("traslado_tipofactor")
        taAdapter.Columns.Add("traslado_tasaOCuota")
        taAdapter.Columns.Add("traslado_importe", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("retencion_base", Type.GetType("System.Decimal"))
        taAdapter.Columns.Add("retencion_impuesto")
        taAdapter.Columns.Add("retencion_tipoFactor")
        taAdapter.Columns.Add("retencion_tasaOCuota")
        taAdapter.Columns.Add("retencion_importe", Type.GetType("System.Decimal"))



        For Each drCfdi In dtCfdi.Rows
            ProgressBar1.Value = no
            ProgressBar1.Increment(no)
            Application.DoEvents()
            Me.Update()
            Me.Refresh()

            Dim nodos_conceptos As Integer = CInt(Funciones.LeeXMLUuid(drCfdi.xml, "NoCon"))
            Dim conceptos As XmlNode = Funciones.xmlConceptos(drCfdi.xml, "Concepto")

            Dim formaPago As String = Funciones.LeeXMLUuid(drCfdi.xml, "FormaPago")
            Dim subtotal As String = Funciones.LeeXMLUuid(drCfdi.xml, "SubTotal")
            Dim iva As String = Funciones.LeeXMLUuid(drCfdi.xml, "TotalImpuestosTrasladados")
            Dim total As String = Funciones.LeeXMLUuid(drCfdi.xml, "Total")
            Dim metodoPago As String = Funciones.LeeXMLUuid(drCfdi.xml, "MetodoPago")
            Dim efectoComprobante As String = Funciones.LeeXMLUuid(drCfdi.xml, "TipoDeComprobante")
            Dim usoCfdi As String = Funciones.LeeXMLUuid(drCfdi.xml, "UsoCFDI")
            Dim regimenFiscal As String = Funciones.LeeXMLUuid(drCfdi.xml, "RegimenFiscalReceptor")

            For Each detalle_conceptos As XmlNode In conceptos.ChildNodes

                Dim ClaveProdServ As String = ""
                Dim Cantidad As String = ""
                Dim ClaveUnidad As String = ""
                Dim Unidad As String = ""
                Dim Descripcion As String = ""
                Dim ValorUnitario As String = ""
                Dim Importe As String = ""
                Dim ObjImp As String = ""
                Dim TipoDeComprobante As String = ""
                Dim FechaFactura As String = Funciones.LeeXMLUuid(drCfdi.xml, "FechaCompleta")

                For Each concepto_atributos As XmlNode In detalle_conceptos.Attributes


                    'Detalle
                    If concepto_atributos.Name = "ClaveProdServ" Then
                        ClaveProdServ = concepto_atributos.Value.ToString()
                    ElseIf concepto_atributos.Name = "Cantidad" Or concepto_atributos.Name = "cantidad" Then
                        Cantidad = concepto_atributos.Value.ToString()
                    ElseIf concepto_atributos.Name = "ClaveUnidad" Then
                        ClaveUnidad = concepto_atributos.Value.ToString()
                    ElseIf concepto_atributos.Name = "Unidad" Or concepto_atributos.Name = "unidad" Then
                        Unidad = concepto_atributos.Value.ToString()
                    ElseIf concepto_atributos.Name = "Descripcion" Or concepto_atributos.Name = "descripcion" Then
                        Descripcion = concepto_atributos.Value.ToString()
                    ElseIf concepto_atributos.Name = "ValorUnitario" Or concepto_atributos.Name = "valorUnitario" Then
                        ValorUnitario = concepto_atributos.Value.ToString
                    ElseIf concepto_atributos.Name = "Importe" Or concepto_atributos.Name = "importe" Then
                        Importe = concepto_atributos.Value.ToString
                    ElseIf concepto_atributos.Name = "ObjetoImp" Or concepto_atributos.Name = "ObjetoImp" Then
                        ObjImp = concepto_atributos.Value.ToString
                    End If
                Next

                If detalle_conceptos.ChildNodes.Count = 0 Then
                    taFila = taAdapter.NewRow

                    taFila("No") = no
                    taFila("serie") = drCfdi.serie
                    taFila("folio") = drCfdi.folio
                    taFila("uuid") = drCfdi.uuid
                    taFila("fechaFac") = drCfdi.fecha_fac
                    taFila("mes") = drCfdi.Mes
                    taFila("rfcEmisor") = drCfdi.fecha_tim
                    taFila("rfcReceptor") = drCfdi.rfc_receptor
                    taFila("formaPago") = formaPago
                    taFila("subtotal") = subtotal
                    If IsNothing(iva) Then
                        taFila("iva") = 0
                    Else
                        taFila("iva") = (iva)
                    End If

                    taFila("total") = (total)
                    taFila("metodoPago") = metodoPago
                    taFila("efectoComprobante") = efectoComprobante
                    taFila("contrato") = drCfdi.Contrato
                    taFila("misc03") = drCfdi._115_Misc03
                    taFila("usoCfdi") = usoCfdi
                    taFila("addenda") = drCfdi.Addenda
                    taFila("producto") = drCfdi.Producto
                    taFila("aviso") = drCfdi.Aviso
                    taFila("regimenFiscal") = usoCfdi

                    taFila("descripcion") = Descripcion
                    taFila("cantidad") = Cantidad
                    taFila("unidad") = Unidad
                    taFila("precioUnitario") = (ValorUnitario)
                    taFila("importe") = Importe
                    taFila("objImp") = ObjImp

                    'taFila("impuesto_tipoImpuesto") = usoCfdi
                    taFila("traslado_base") = Importe

                    taAdapter.Rows.Add(taFila)
                End If


                For Each concepto_hijos As XmlNode In detalle_conceptos.ChildNodes
                    If concepto_hijos.Name = "cfdi:Impuestos" Then
                        For Each impuestos_detalle As XmlNode In concepto_hijos.ChildNodes

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
                                        taFila = taAdapter.NewRow

                                        taFila("No") = no
                                        taFila("serie") = drCfdi.serie
                                        taFila("folio") = drCfdi.folio
                                        taFila("uuid") = drCfdi.uuid
                                        taFila("fechaFac") = drCfdi.fecha_fac
                                        taFila("mes") = drCfdi.Mes
                                        taFila("rfcEmisor") = drCfdi.fecha_tim
                                        taFila("rfcReceptor") = drCfdi.rfc_receptor
                                        taFila("formaPago") = formaPago
                                        taFila("subtotal") = subtotal
                                        taFila("iva") = iva
                                        taFila("total") = total
                                        taFila("metodoPago") = metodoPago
                                        taFila("efectoComprobante") = efectoComprobante
                                        taFila("contrato") = drCfdi.Contrato
                                        taFila("misc03") = drCfdi._115_Misc03
                                        taFila("usoCfdi") = usoCfdi
                                        taFila("addenda") = drCfdi.Addenda
                                        taFila("producto") = drCfdi.Producto
                                        taFila("aviso") = drCfdi.Aviso
                                        taFila("regimenFiscal") = usoCfdi

                                        taFila("descripcion") = Descripcion
                                        taFila("cantidad") = Cantidad
                                        taFila("unidad") = Unidad
                                        taFila("precioUnitario") = ValorUnitario
                                        taFila("importe") = Importe
                                        taFila("objImp") = ObjImp

                                        'taFila("impuesto_tipoImpuesto") = usoCfdi
                                        If ObjImp = "01" Or ObjImp = "04" Then
                                            taFila("traslado_base") = Importe
                                        Else
                                            taFila("traslado_importe") = ""
                                        End If
                                        taFila("traslado_impuesto") = ""
                                        taFila("traslado_tipofactor") = ""
                                        taFila("traslado_tasaOCuota") = ""
                                        taFila("traslado_importe") = ""
                                        taFila("retencion_base") = Base
                                        taFila("retencion_impuesto") = Impuesto
                                        taFila("retencion_tipoFactor") = Tipofactor
                                        taFila("retencion_tasaOCuota") = TasaOCuota
                                        taFila("retencion_importe") = (ImporteImpuesto)


                                        taAdapter.Rows.Add(taFila)

                                    End If
                                Next
                            End If

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
                                        taFila = taAdapter.NewRow

                                        taFila("No") = no
                                        taFila("serie") = drCfdi.serie
                                        taFila("folio") = drCfdi.folio
                                        taFila("uuid") = drCfdi.uuid
                                        taFila("fechaFac") = drCfdi.fecha_fac
                                        taFila("mes") = drCfdi.Mes
                                        taFila("rfcEmisor") = drCfdi.fecha_tim
                                        taFila("rfcReceptor") = drCfdi.rfc_receptor
                                        taFila("formaPago") = formaPago
                                        taFila("subtotal") = subtotal
                                        If IsNothing(iva) Then
                                            taFila("iva") = 0
                                        Else
                                            taFila("iva") = iva
                                        End If
                                        taFila("total") = total
                                        taFila("metodoPago") = metodoPago
                                        taFila("efectoComprobante") = efectoComprobante
                                        taFila("contrato") = drCfdi.Contrato
                                        taFila("misc03") = drCfdi._115_Misc03
                                        taFila("usoCfdi") = usoCfdi
                                        taFila("addenda") = drCfdi.Addenda
                                        taFila("producto") = drCfdi.Producto
                                        taFila("aviso") = drCfdi.Aviso
                                        taFila("regimenFiscal") = usoCfdi

                                        taFila("descripcion") = Descripcion
                                        taFila("cantidad") = Cantidad
                                        taFila("unidad") = Unidad
                                        taFila("precioUnitario") = ValorUnitario
                                        taFila("importe") = Importe
                                        taFila("objImp") = ObjImp

                                        taFila("traslado_base") = Base
                                        taFila("traslado_impuesto") = Impuesto
                                        taFila("traslado_tipofactor") = Tipofactor
                                        taFila("traslado_tasaOCuota") = TasaOCuota

                                        If ObjImp = "01" Or ObjImp = "04" Then
                                            taFila("traslado_base") = Importe
                                        Else
                                            If ImporteImpuesto <> String.Empty Then
                                                taFila("traslado_importe") = ImporteImpuesto
                                            End If
                                        End If


                                            taAdapter.Rows.Add(taFila)

                                    End If

                                Next
                            End If

                        Next
                    End If

                Next
            Next
            no += 1
        Next
        taAdapter.WriteXml("C:\Files\rptCfdi.xml", XmlWriteMode.WriteSchema)
        Dim rpt As New rptCfdiDesglose

        rpt.SetDataSource(taAdapter)
        CrystalReportViewer1.ReportSource = rpt
        rpt.Refresh()
        taAdapter.Dispose()

        CrystalReportViewer1.Enabled = True
        ProgressBar1.Visible = False
    End Sub
End Class