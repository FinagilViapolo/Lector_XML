﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace mx.gob.sat.facturaelectronica.consultaqr
    
    'CODEGEN: No se controló el elemento de extensión WSDL opcional 'PolicyReference' del espacio de nombres 'http://schemas.xmlsoap.org/ws/2004/09/policy'.
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="BasicHttpBinding_IConsultaCFDIService", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ConsultaCFDIService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private ConsultaOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = My.Settings.Default.Lector_XML_mx_gob_sat_facturaelectronica_consultaqr_ConsultaCFDIService ' Global.Lector_XML.Settings.Default.Lector_XML_mx_gob_sat_facturaelectronica_consultaqr_ConsultaCFDIService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event ConsultaCompleted As ConsultaCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IConsultaCFDIService/Consulta", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Consulta(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal expresionImpresa As String) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> Acuse
            Dim results() As Object = Me.Invoke("Consulta", New Object() {expresionImpresa})
            Return CType(results(0),Acuse)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ConsultaAsync(ByVal expresionImpresa As String)
            Me.ConsultaAsync(expresionImpresa, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ConsultaAsync(ByVal expresionImpresa As String, ByVal userState As Object)
            If (Me.ConsultaOperationCompleted Is Nothing) Then
                Me.ConsultaOperationCompleted = AddressOf Me.OnConsultaOperationCompleted
            End If
            Me.InvokeAsync("Consulta", New Object() {expresionImpresa}, Me.ConsultaOperationCompleted, userState)
        End Sub
        
        Private Sub OnConsultaOperationCompleted(ByVal arg As Object)
            If (Not (Me.ConsultaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ConsultaCompleted(Me, New ConsultaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/Sat.Cfdi.Negocio.ConsultaCfdi.Servicio")>  _
    Partial Public Class Acuse
        
        Private codigoEstatusField As String
        
        Private esCancelableField As String
        
        Private estadoField As String
        
        Private estatusCancelacionField As String
        
        Private validacionEFOSField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property CodigoEstatus() As String
            Get
                Return Me.codigoEstatusField
            End Get
            Set
                Me.codigoEstatusField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property EsCancelable() As String
            Get
                Return Me.esCancelableField
            End Get
            Set
                Me.esCancelableField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Estado() As String
            Get
                Return Me.estadoField
            End Get
            Set
                Me.estadoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property EstatusCancelacion() As String
            Get
                Return Me.estatusCancelacionField
            End Get
            Set
                Me.estatusCancelacionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property ValidacionEFOS() As String
            Get
                Return Me.validacionEFOSField
            End Get
            Set
                Me.validacionEFOSField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub ConsultaCompletedEventHandler(ByVal sender As Object, ByVal e As ConsultaCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ConsultaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Acuse
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Acuse)
            End Get
        End Property
    End Class
End Namespace
