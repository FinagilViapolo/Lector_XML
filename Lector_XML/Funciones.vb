﻿Imports System.Xml

Public Class Funciones

    Public Function LeeXMLUuid(ByVal archivo As String, ByVal nodo As String)
        Dim doc As XmlDocument
        doc = New XmlDocument
        doc.LoadXml(archivo)
        Dim resultado As String = ""
        Dim comprobante As XmlNode

        comprobante = doc.DocumentElement

        For Each comprobante_atributos As XmlNode In comprobante.Attributes
            resultado = ""
            If (comprobante_atributos.Name = "Serie" Or comprobante_atributos.Name = "serie") And nodo = "Serie" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Folio" Or comprobante_atributos.Name = "folio") And nodo = "Folio" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf comprobante_atributos.Name = "Moneda" And nodo = "Moneda" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf comprobante_atributos.Name = "Exportacion" And nodo = "Exportacion" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf comprobante_atributos.Name = "LugarExpedicion" And nodo = "LugarExpedicion" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf comprobante_atributos.Name = "TipoCambio" And nodo = "TipoCambio" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "MetodoPago" Or comprobante_atributos.Name = "metodoDePago") And nodo = "MetodoPago" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "NoCertificado" Or comprobante_atributos.Name = "NoCertificado") And nodo = "NoCertificado" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Fecha" Or comprobante_atributos.Name = "fecha") And nodo = "Fecha" Then
                resultado = Convert.ToDateTime(comprobante_atributos.Value.ToString.Replace("T", " ")).ToShortDateString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Fecha" Or comprobante_atributos.Name = "fecha") And nodo = "FechaCompleta" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Total" Or comprobante_atributos.Name = "total") And nodo = "Total" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "SubTotal" Or comprobante_atributos.Name = "subTotal") And nodo = "SubTotal" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "TipoDeComprobante" Or comprobante_atributos.Name = "tipoDeComprobante") And nodo = "TipoDeComprobante" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "FormaPago" Or comprobante_atributos.Name = "formaDePago") And nodo = "FormaPago" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf comprobante_atributos.Name = "CondicionesDePago" And nodo = "CondicionesDePago" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Descuento" Or comprobante_atributos.Name = "descuento") And nodo = "Descuento" Then
                If IsNothing(comprobante_atributos.Value) Or comprobante_atributos.Value.ToString = String.Empty Then
                    resultado = 0
                Else
                    resultado = comprobante_atributos.Value.ToString
                End If
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Version" Or comprobante_atributos.Name = "version") And nodo = "Version" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            End If

        Next
        If nodo = "TipoRelacion" Then
            For Each CFDI_Relacionados As XmlNode In comprobante.ChildNodes
                If CFDI_Relacionados.Name = "cfdi:CfdiRelacionados" Then
                    For Each CFDI_Relacionado_atributos As XmlNode In CFDI_Relacionados.Attributes
                        If CFDI_Relacionado_atributos.Name = "TipoRelacion" Then
                            resultado = CFDI_Relacionado_atributos.Value.ToString
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "TipoRelacionUUID" Then
            For Each CFDI_Relacionados As XmlNode In comprobante.ChildNodes
                For Each CFDI_Relacionado_childs As XmlNode In CFDI_Relacionados.ChildNodes
                    If CFDI_Relacionado_childs.Name = "cfdi:CfdiRelacionado" Then
                        For Each CFDI_relacionado_childs_atributos As XmlNode In CFDI_Relacionado_childs.Attributes
                            If CFDI_relacionado_childs_atributos.Name = "UUID" Then
                                resultado = CFDI_relacionado_childs_atributos.Value.ToString
                                Return resultado
                                Exit For
                            End If
                        Next
                    End If
                Next
            Next
        End If

        If nodo = "TipoRelacionUUIDTodos" Then
            Dim cadena As String = ""
            For Each CFDI_Relacionados As XmlNode In comprobante.ChildNodes
                For Each CFDI_Relacionado_childs As XmlNode In CFDI_Relacionados.ChildNodes
                    If CFDI_Relacionado_childs.Name = "cfdi:CfdiRelacionado" Then
                        For Each CFDI_relacionado_childs_atributos As XmlNode In CFDI_Relacionado_childs.Attributes
                            If CFDI_relacionado_childs_atributos.Name = "UUID" Then
                                cadena += CFDI_relacionado_childs_atributos.Value.ToString + vbNewLine
                            End If
                        Next
                    End If
                Next
            Next
            Return cadena
        End If

        For Each emisor As XmlNode In comprobante.ChildNodes
            If emisor.Name = "cfdi:Emisor" Then
                For Each emisor_atributos As XmlNode In emisor.Attributes
                    If (emisor_atributos.Name = "Rfc" Or emisor_atributos.Name = "rfc") And nodo = "RFCE" Then
                        resultado = emisor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf (emisor_atributos.Name = "Nombre" Or emisor_atributos.Name = "nombre") And nodo = "NombreE" Then
                        resultado = emisor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf emisor_atributos.Name = "RegimenFiscal" And nodo = "RegimenFiscal" Then
                        resultado = emisor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    End If
                Next
            End If
        Next

        For Each receptor As XmlNode In comprobante.ChildNodes
            If receptor.Name = "cfdi:Receptor" Then
                For Each receptor_atributos As XmlNode In receptor.Attributes
                    If (receptor_atributos.Name = "Rfc" Or receptor_atributos.Name = "rfc") And nodo = "RFCR" Then
                        resultado = receptor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf (receptor_atributos.Name = "Nombre" Or receptor_atributos.Name = "nombre") And nodo = "NombreR" Then
                        resultado = receptor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf receptor_atributos.Name = "UsoCFDI" And nodo = "UsoCFDI" Then
                        resultado = receptor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf receptor_atributos.Name = "RegimenFiscalReceptor" And nodo = "RegimenFiscalReceptor" Then
                        resultado = receptor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    ElseIf receptor_atributos.Name = "DomicilioFiscalReceptor" And nodo = "DomicilioFiscalReceptor" Then
                        resultado = receptor_atributos.Value.ToString
                        Return resultado
                        Exit For
                    End If
                Next
            End If
        Next
        If nodo = "NoCon" Then
            For Each conceptos As XmlNode In comprobante.ChildNodes
                If conceptos.Name = "cfdi:Conceptos" Then
                    Return conceptos.ChildNodes.Count
                    Exit For
                End If
            Next
        End If

        If nodo = "Concepto" Then
            For Each conceptos As XmlNode In comprobante.ChildNodes
                If conceptos.Name = "cfdi:Conceptos" Then
                    For Each concepto As XmlNode In conceptos.ChildNodes
                        For Each concepto_atributos As XmlNode In concepto.Attributes
                            If concepto_atributos.Name = "Descripcion" Then
                                resultado = concepto_atributos.Value.ToString
                                Return resultado
                                Exit For
                            End If
                        Next
                    Next
                End If
            Next
        End If


        If nodo = "ImpuestosT" Then
            For Each impuestos As XmlNode In comprobante.ChildNodes
                If impuestos.Name = "cfdi:Impuestos" Then
                    For Each impuestos_atributos As XmlNode In impuestos.Attributes
                        If impuestos_atributos.Name = "TotalImpuestosTrasladados" Then
                            resultado = FormatCurrency(impuestos_atributos.Value.ToString)
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
        If nodo = "ImpuestosR" Then
            For Each impuestos As XmlNode In comprobante.ChildNodes
                If impuestos.Name = "cfdi:Impuestos" Then
                    For Each impuestos_atributos As XmlNode In impuestos.Attributes
                        If impuestos_atributos.Name = "TotalImpuestosRetenidos" Then
                            resultado = FormatCurrency(impuestos_atributos.Value.ToString)
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        '*****Obtiene impuestos, 1 a 1
        If nodo = "ImpuestosTTodos" Then
            Dim impuestosR(4) As String
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList1 As XmlNodeList
            Dim nodeList2 As XmlNodeList
            Dim nodeList3 As XmlNodeList
            Dim nodeList4 As XmlNodeList
            Dim nodeList5 As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList1 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Base", nsmgr)
            nodeList2 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Impuesto", nsmgr)
            nodeList3 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TipoFactor", nsmgr)
            nodeList4 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TasaOCuota", nsmgr)
            nodeList5 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Importe", nsmgr)

            Dim uuid As XmlNode
            For Each uuid In nodeList1
                impuestosR(0) = FormatCurrency(uuid.Value.ToString)
            Next
            For Each uuid In nodeList2
                impuestosR(1) = uuid.Value.ToString
            Next
            For Each uuid In nodeList3
                impuestosR(2) = uuid.Value.ToString
            Next
            For Each uuid In nodeList4
                impuestosR(3) = uuid.Value.ToString
            Next
            For Each uuid In nodeList5
                impuestosR(4) = FormatCurrency(vbTab & uuid.Value.ToString)
            Next
            Return impuestosR
        End If

        If nodo = "ImpuestosTTodos40" Then
            Dim impuestosR(4) As String
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/4")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList1 As XmlNodeList
            Dim nodeList2 As XmlNodeList
            Dim nodeList3 As XmlNodeList
            Dim nodeList4 As XmlNodeList
            Dim nodeList5 As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList1 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Base", nsmgr)
            nodeList2 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Impuesto", nsmgr)
            nodeList3 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TipoFactor", nsmgr)
            nodeList4 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TasaOCuota", nsmgr)
            nodeList5 = root.SelectNodes("//cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Importe", nsmgr)

            Dim uuid As XmlNode
            For Each uuid In nodeList1
                impuestosR(0) = FormatCurrency(uuid.Value.ToString)
            Next
            For Each uuid In nodeList2
                impuestosR(1) = uuid.Value.ToString
            Next
            For Each uuid In nodeList3
                impuestosR(2) = uuid.Value.ToString
            Next
            For Each uuid In nodeList4
                impuestosR(3) = uuid.Value.ToString
            Next
            For Each uuid In nodeList5
                impuestosR(4) = FormatCurrency(vbTab & uuid.Value.ToString)
            Next
            Return impuestosR
        End If



        If nodo = "ImpuestosRTodos" Then
            Dim impuestosR(4) As String
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList1 As XmlNodeList
            Dim nodeList2 As XmlNodeList
            Dim nodeList3 As XmlNodeList
            Dim nodeList4 As XmlNodeList
            Dim nodeList5 As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList1 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Base", nsmgr)
            nodeList2 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Impuesto", nsmgr)
            nodeList3 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@TipoFactor", nsmgr)
            nodeList4 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@TasaOCuota", nsmgr)
            nodeList5 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Importe", nsmgr)

            Dim uuid As XmlNode
            For Each uuid In nodeList1
                impuestosR(0) = FormatCurrency(uuid.Value.ToString)
            Next
            For Each uuid In nodeList2
                impuestosR(1) = uuid.Value.ToString
            Next
            For Each uuid In nodeList3
                impuestosR(2) = uuid.Value.ToString
            Next
            For Each uuid In nodeList4
                impuestosR(3) = uuid.Value.ToString
            Next
            For Each uuid In nodeList5
                impuestosR(4) = FormatCurrency(vbTab & uuid.Value.ToString)
            Next
            Return impuestosR
        End If

        If nodo = "ImpuestosRTodos40" Then
            Dim impuestosR(4) As String
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/4")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList1 As XmlNodeList
            Dim nodeList2 As XmlNodeList
            Dim nodeList3 As XmlNodeList
            Dim nodeList4 As XmlNodeList
            Dim nodeList5 As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList1 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Base", nsmgr)
            nodeList2 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Impuesto", nsmgr)
            nodeList3 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@TipoFactor", nsmgr)
            nodeList4 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@TasaOCuota", nsmgr)
            nodeList5 = root.SelectNodes("//cfdi:Impuestos/cfdi:Retenciones/cfdi:Retencion/@Importe", nsmgr)

            Dim uuid As XmlNode
            For Each uuid In nodeList1
                impuestosR(0) = FormatCurrency(uuid.Value.ToString)
            Next
            For Each uuid In nodeList2
                impuestosR(1) = uuid.Value.ToString
            Next
            For Each uuid In nodeList3
                impuestosR(2) = uuid.Value.ToString
            Next
            For Each uuid In nodeList4
                impuestosR(3) = uuid.Value.ToString
            Next
            For Each uuid In nodeList5
                impuestosR(4) = FormatCurrency(vbTab & uuid.Value.ToString)
            Next
            Return impuestosR
        End If

        '*****

        If nodo = "UUID" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@UUID", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "ExisteImpuestos" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            'nodeList = root.SelectNodes("//cfdi:TimbreFiscalDigital/@UUID", nsmgr)
            nodeList = root.SelectNodes("//cfdi:Impuestos/@TotalImpuestosTrasladados", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "implocalR" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//implocal:ImpuestosLocales/@TotaldeRetenciones", nsmgr)
            Dim totalRet As XmlNode
            For Each totalRet In nodeList
                resultado = totalRet.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "implocalT" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//implocal:ImpuestosLocales/@TotaldeTraslados", nsmgr)
            Dim totalRet As XmlNode
            For Each totalRet In nodeList
                resultado = totalRet.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "ImpLocTrasladado" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//implocal:ImpuestosLocales/implocal:TrasladosLocales/@ImpLocTrasladado", nsmgr)
            Dim totalRet As XmlNode
            For Each totalRet In nodeList
                resultado = totalRet.Value.ToString.Replace("Impuesto Sobre Hospedaje", "ISH").Replace("2% HOSPEDAJE", "ISH")
                Return resultado
            Next
        End If

        If nodo = "FechaTimbrado" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@FechaTimbrado", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                'resultado = uuid.Value.ToString
                Dim TestDateTime As Date = "#" & uuid.Value.ToString & "#"
                resultado = String.Format(TestDateTime, "MM/dd/yyyy")
                resultado = String.Format(TestDateTime, "dd/MM/yyyy")
                Return resultado
            Next
        End If

        If nodo = "FechaTimbradoCompleta" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@FechaTimbrado", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "RfcProvCertif" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@RfcProvCertif", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "SelloCFD" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@SelloCFD", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "SelloSAT" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@SelloSAT", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "NoCertificadoSAT" Then
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@NoCertificadoSAT", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                resultado = uuid.Value.ToString
                Return resultado
            Next
        End If

        If nodo = "ComplementoXML" Or nodo = "ComplementoXMLCfdi" Or nodo = "Edenred" Then
            Dim ecc12cA(,) As String
            For Each Comp As XmlNode In comprobante.ChildNodes
                If Comp.Name = "cfdi:Addenda" Then
                    For Each nodos As XmlNode In Comp.ChildNodes
                        If nodos.Name <> "tfd:TimbreFiscalDigital" Then
                            If nodo = "ComplementoXML" Then
                                resultado = nodos.Name
                                Return resultado
                                Exit Function
                            Else
                                If nodo = "Edenred" Then
                                    For Each eden As XmlNode In nodos.Attributes
                                        If eden.Name = "totalGlobal" Then
                                            resultado = eden.Value
                                            Return resultado
                                        End If
                                    Next
                                End If
                                If nodos.Name = "ecsv:EstadoDeCuentaSiVale" Then
                                    For Each ecc12 As XmlNode In nodos.ChildNodes
                                        Dim contCon As Integer = 0
                                        If ecc12.Name = "ecsv:Complemento" Then

                                            For Each ecc12C As XmlNode In ecc12.ChildNodes
                                                If ecc12C.Name = "ecsv:Conceptos" Then
                                                    ReDim ecc12cA(13, ecc12C.ChildNodes.Count - 1)
                                                    For Each ecc12csv As XmlNode In ecc12C.ChildNodes
                                                        If ecc12csv.Name = "ecsv:Concepto" Then
                                                            For Each ecc12Cc As XmlNode In ecc12csv.Attributes
                                                                If ecc12Cc.Name = "ecc12_cantidad" Then
                                                                    ecc12cA(0, contCon) = ecc12Cc.Value
                                                                ElseIf ecc12Cc.Name = "ecc12_fecha" Then
                                                                    ecc12cA(1, contCon) = ecc12Cc.Value
                                                                ElseIf ecc12Cc.Name = "ecc12_importe" Then
                                                                    ecc12cA(2, contCon) = ecc12Cc.Value
                                                                ElseIf ecc12Cc.Name = "ecc12_rfc" Then
                                                                    ecc12cA(3, contCon) = ecc12Cc.Value
                                                                ElseIf ecc12Cc.Name = "ecc12_valorUnitario" Then
                                                                    ecc12cA(4, contCon) = ecc12Cc.Value
                                                                End If
                                                            Next
                                                            For Each ecc12Ct As XmlNode In ecc12csv.ChildNodes
                                                                If ecc12Ct.Name = "ecsv:Impuestos" Then
                                                                    Dim cont As Integer = 0
                                                                    For Each ecc12Ctt As XmlNode In ecc12Ct.ChildNodes
                                                                        If ecc12Ctt.Name = "ecsv:Impuesto" Then
                                                                            For Each ecc12CttA As XmlNode In ecc12Ctt.Attributes
                                                                                If ecc12CttA.Name = "importe" Then
                                                                                    ecc12cA(5 + cont, contCon) = ecc12CttA.Value
                                                                                ElseIf ecc12CttA.Name = "impuesto" Then
                                                                                    ecc12cA(6 + cont, contCon) = ecc12CttA.Value
                                                                                ElseIf ecc12CttA.Name = "tasaOCuota" Then
                                                                                    ecc12cA(7 + cont, contCon) = ecc12CttA.Value
                                                                                End If
                                                                                cont = cont + 1
                                                                            Next
                                                                        End If
                                                                    Next
                                                                End If
                                                            Next
                                                            contCon = contCon + 1
                                                        End If
                                                    Next
                                                End If
                                            Next
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Next
                End If
            Next
            Return ecc12cA
        End If
    End Function

    Public Function xmlConceptos(ByVal archivo As String, ByVal nodo As String)
        Dim doc As XmlDocument
        doc = New XmlDocument
        doc.LoadXml(archivo)
        Dim resultado As XmlNode
        Dim comprobante As XmlNode

        comprobante = doc.DocumentElement

        If nodo = "Concepto" Then
            For Each conceptos As XmlNode In comprobante.ChildNodes
                If conceptos.Name = "cfdi:Conceptos" Then
                    resultado = conceptos
                    Return resultado
                    Exit For
                End If
            Next
        End If
    End Function

End Class
