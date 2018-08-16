Imports System.Xml
Imports System.IO
Public Class readXML_Retencion_class

    Public Function LeeXML(ByVal archivo As String, ByVal nodo As String)
        Dim doc As XmlDocument
        doc = New XmlDocument
        doc.Load(archivo)
        Dim resultado As String = ""
        Dim retenciones As XmlNode

        retenciones = doc.DocumentElement

        If nodo = "Version" Or nodo = "FechaExp" Or nodo = "CveRetenc" Or nodo = "DescRetenc" Or nodo = "FolioInt" Then
            For Each retenciones_atributos As XmlNode In retenciones.Attributes
                If retenciones_atributos.Name = "FechaExp" And nodo = "FechaExp" Then
                    resultado = retenciones_atributos.Value
                    Return resultado
                    Exit For
                ElseIf retenciones_atributos.Name = "CveRetenc" And nodo = "CveRetenc" Then
                    resultado = retenciones_atributos.Value
                    Return resultado
                    Exit For
                ElseIf retenciones_atributos.Name = "Version" And nodo = "Version" Then
                    resultado = retenciones_atributos.Value
                    Return resultado
                    Exit For
                ElseIf retenciones_atributos.Name = "DescRetenc" And nodo = "DescRetenc" Then
                    resultado = retenciones_atributos.Value
                    Return resultado
                    Exit For
                ElseIf retenciones_atributos.Name = "FolioInt" And nodo = "FolioInt" Then
                    resultado = retenciones_atributos.Value
                    Return resultado
                    Exit For
                End If
            Next
        End If

        If nodo = "RFCEmisor" Or nodo = "NomDenRazSocE" Or nodo = "CURPE" Then
            For Each emisor As XmlNode In retenciones.ChildNodes
                If emisor.Name = "retenciones:Emisor" Then
                    For Each emisor_atributos As XmlNode In emisor.Attributes
                        If emisor_atributos.Name = "RFCEmisor" And nodo = "RFCEmisor" Then
                            resultado = emisor_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf emisor_atributos.Name = "NomDenRazSocE" And nodo = "NomDenRazSocE" Then
                            resultado = emisor_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf emisor_atributos.Name = "CURPE" And nodo = "CURPE" Then
                            resultado = emisor_atributos.Value
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "Nacionalidad" Or nodo = "RFCRecep" Or nodo = "NomDenRazSocR" Or nodo = "CURPR" Then
            For Each receptor As XmlNode In retenciones.ChildNodes
                If receptor.Name = "retenciones:Receptor" Then
                    For Each receptor_atributos As XmlNode In receptor.Attributes
                        If receptor_atributos.Name = "Nacionalidad" And nodo = "Nacionalidad" Then
                            resultado = receptor_atributos.Value
                            Return resultado
                            Exit For
                        End If
                    Next
                    For Each receptor_childs As XmlNode In receptor.ChildNodes
                        If receptor_childs.Name = "retenciones:Nacional" Then
                            For Each receptor_childs_atributos As XmlNode In receptor_childs.Attributes
                                If receptor_childs_atributos.Name = "RFCRecep" And nodo = "RFCRecep" Then
                                    resultado = receptor_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf receptor_childs_atributos.Name = "NomDenRazSocR" And nodo = "NomDenRazSocR" Then
                                    resultado = receptor_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf receptor_childs_atributos.Name = "CURPR" And nodo = "CURPR" Then
                                    resultado = receptor_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                End If
                            Next
                        End If
                        If receptor_childs.Name = "retenciones:Extranjero" Then
                            For Each receptor_childs_atributos As XmlNode In receptor_childs.Attributes
                                If receptor_childs_atributos.Name = "NumRegIdTrib" And nodo = "NumRegIdTrib" Then
                                    resultado = receptor_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf receptor_childs_atributos.Name = "NomDenRazSocR" And nodo = "NomDenRazSocR" Then
                                    resultado = receptor_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "MesIni" Or nodo = "MesFin" Or nodo = "Ejerc" Then
            For Each periodo As XmlNode In retenciones.ChildNodes
                If periodo.Name = "retenciones:Periodo" Then
                    For Each periodo_atributos As XmlNode In periodo.Attributes
                        If periodo_atributos.Name = "MesIni" And nodo = "MesIni" Then
                            resultado = periodo_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf periodo_atributos.Name = "MesFin" And nodo = "MesFin" Then
                            resultado = periodo_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf periodo_atributos.Name = "Ejerc" And nodo = "Ejerc" Then
                            resultado = periodo_atributos.Value
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "montoTotOperacion" Or nodo = "montoTotGrav" Or nodo = "montoTotExent" Or nodo = "montoTotRet" Then
            For Each totales As XmlNode In retenciones.ChildNodes
                If totales.Name = "retenciones:Totales" Then
                    For Each totales_atributos As XmlNode In totales.Attributes
                        If totales_atributos.Name = "montoTotOperacion" And nodo = "montoTotOperacion" Then
                            resultado = totales_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf totales_atributos.Name = "montoTotGrav" And nodo = "montoTotGrav" Then
                            resultado = totales_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf totales_atributos.Name = "montoTotExent" And nodo = "montoTotExent" Then
                            resultado = totales_atributos.Value
                            Return resultado
                            Exit For
                        ElseIf totales_atributos.Name = "montoTotRet" And nodo = "montoTotRet" Then
                            resultado = totales_atributos.Value
                            Return resultado
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        If nodo = "BaseRet" Or nodo = "Impuesto" Or nodo = "montoRet" Or nodo = "TipoPagoRet" Then
            For Each impretenidos As XmlNode In retenciones.ChildNodes
                If impretenidos.Name = "retenciones:Totales" Then
                    For Each impretenidos_childs As XmlNode In impretenidos.ChildNodes
                        If impretenidos_childs.Name = "retenciones:ImpRetenidos" Then
                            For Each impretenidos_childs_atributos As XmlNode In impretenidos_childs.Attributes
                                If impretenidos_childs_atributos.Name = "BaseRet" And nodo = "BaseRet" Then
                                    resultado = impretenidos_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf impretenidos_childs_atributos.Name = "Impuesto" And nodo = "Impuesto" Then
                                    resultado = impretenidos_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf impretenidos_childs_atributos.Name = "montoRet" And nodo = "montoRet" Then
                                    resultado = impretenidos_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf impretenidos_childs_atributos.Name = "TipoPagoRet" And nodo = "TipoPagoRet" Then
                                    resultado = impretenidos_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End If
        'Complemento Intereses
        If nodo = "Version" Or nodo = "SistFinanciero" Or nodo = "RetiroAORESRetInt" Or nodo = "OperFinancDerivad" Or nodo = "MontIntNominal" Or nodo = "MontIntReal" Or nodo = "Perdida" Then
            For Each intereses As XmlNode In retenciones.ChildNodes
                If intereses.Name = "retenciones:Complemento" Then
                    For Each intereses_childs As XmlNode In intereses.ChildNodes
                        If intereses_childs.Name = "intereses:Intereses" Then
                            For Each intereses_childs_atributos As XmlNode In intereses_childs.Attributes
                                If intereses_childs_atributos.Name = "Version" And nodo = "Version" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "SistFinanciero" And nodo = "SistFinanciero" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "RetiroAORESRetInt" And nodo = "RetiroAORESRetInt" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "OperFinancDerivad" And nodo = "OperFinancDerivad" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "MontIntNominal" And nodo = "MontIntNominal" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "MontIntReal" And nodo = "MontIntReal" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                ElseIf intereses_childs_atributos.Name = "Perdida" And nodo = "Perdida" Then
                                    resultado = intereses_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End If
        'Complemento dividendos
        If nodo = "VersionD" Or nodo = "CveTipDivOUtil" Or nodo = "MontISRAcredRetMexico" Or nodo = "MontISRAcredRetExtranjero" Or nodo = "TipoSocDistrDiv" Or nodo = "MontDivAcumNal" Then
            For Each dividendos As XmlNode In retenciones.ChildNodes
                If dividendos.Name = "retenciones:Complemento" Then
                    For Each dividendos_childs As XmlNode In dividendos.ChildNodes
                        If dividendos_childs.Name = "dividendos:Dividendos" Then
                            For Each dividendos_childs_atributos As XmlNode In dividendos_childs.Attributes
                                If dividendos_childs_atributos.Name = "Version" And nodo = "VersionD" Then
                                    resultado = dividendos_childs_atributos.Value
                                    Return resultado
                                    Exit For
                                End If
                            Next
                            For Each dividendos_childs_childs As XmlNode In dividendos_childs.ChildNodes
                                If dividendos_childs_childs.Name = "dividendos:DividOUtil" Then
                                    For Each dividendos_childs_childs_atributos As XmlNode In dividendos_childs_childs.Attributes
                                        If dividendos_childs_childs_atributos.Name = "CveTipDivOUtil" And nodo = "CveTipDivOUtil" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontISRAcredRetMexico" And nodo = "MontISRAcredRetMexico" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontISRAcredRetExtranjero" And nodo = "MontISRAcredRetExtranjero" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontRetExtDivExt" And nodo = "MontRetExtDivExt" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "TipoSocDistrDiv" And nodo = "TipoSocDistrDiv" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontISRAcredNal" And nodo = "MontISRAcredNal" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontDivAcumNal" And nodo = "MontDivAcumNal" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        ElseIf dividendos_childs_childs_atributos.Name = "MontDivAcumExt" And nodo = "MontDivAcumExt" Then
                                            resultado = dividendos_childs_childs_atributos.Value
                                            Return resultado
                                            Exit For
                                        End If
                                    Next
                                End If
                            Next
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
    End Function
End Class
