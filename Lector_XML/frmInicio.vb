﻿Imports System.Diagnostics
Imports Lector_XML.My
Public Class frmInicio
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim f As New frmIngreso
        f.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New frmRetenciones
        f.Show()
    End Sub

    Private Sub btnNomina_Click(sender As Object, e As EventArgs) Handles btnNomina.Click
        Dim proces As New Process
        proces.StartInfo.FileName = My.Settings.Default.hostExeNomina & "XML_Report.exe"
        proces.Start()
    End Sub

    Private Sub btnCancelaciones_Click(sender As Object, e As EventArgs) Handles btnCancelaciones.Click
        Dim f As New frmCancelacionCFDI
        f.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New frmEventoContable
        f.Show()
    End Sub

    Private Sub btnReporteDesglose_Click(sender As Object, e As EventArgs) Handles btnReporteDesglose.Click
        Dim f As New frmCfdiDesglose
        f.Show()
    End Sub
End Class