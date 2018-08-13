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

    End Function
End Class
