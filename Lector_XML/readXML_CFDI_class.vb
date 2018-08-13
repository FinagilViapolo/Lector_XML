Imports System.Xml
Imports System.IO

Public Class readXML_CFDI_class
    Public Function LeeXML_Conceptos(ByVal archivo As String, ByVal nodo As String)
        Dim doc As XmlDocument
        doc = New XmlDocument
        doc.Load(archivo)
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

    Public Function Valida_SAT(ByVal rfce As String, ByVal rfcr As String, ByVal importe As String, ByVal uuid As String)
        Dim resultado As String = ""
        Dim servicio As WS_Consulta_SAT.ConsultaCFDIServiceClient
        servicio = New WS_Consulta_SAT.ConsultaCFDIServiceClient
        resultado = servicio.Consulta("?re=" + rfce + "&rr=" + rfcr + "&tt=" + importe + "&id=" + uuid).Estado.ToString
        Return resultado
    End Function
    Public Function LeeXML(ByVal archivo As String, ByVal nodo As String)
        Dim doc As XmlDocument
        doc = New XmlDocument
        doc.Load(archivo)
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
            ElseIf comprobante_atributos.Name = "TipoCambio" And nodo = "TipoCambio" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "MetodoPago" Or comprobante_atributos.Name = "metodoDePago") And nodo = "MetodoPago" Then
                resultado = comprobante_atributos.Value.ToString
                Return resultado
                Exit For
            ElseIf (comprobante_atributos.Name = "Fecha" Or comprobante_atributos.Name = "fecha") And nodo = "Fecha" Then
                resultado = Convert.ToDateTime(comprobante_atributos.Value.ToString.Replace("T", " ")).ToShortDateString
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
                resultado = comprobante_atributos.Value.ToString
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
                            resultado = impuestos_atributos.Value.ToString
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
                            resultado = impuestos_atributos.Value.ToString
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
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
                resultado = Format(TestDateTime, "MM/dd/yyyy")
                resultado = Format(TestDateTime, "dd/MM/yyyy")
                Return resultado
            Next
        End If

    End Function
End Class
