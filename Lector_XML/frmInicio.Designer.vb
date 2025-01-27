<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnNomina = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelaciones = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnReporteDesglose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(34, 12)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(206, 34)
        Me.btnIngreso.TabIndex = 0
        Me.btnIngreso.Text = "CFDI Ingreso, Egreso y Pago (Clientes/Proveedores)"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnNomina
        '
        Me.btnNomina.Location = New System.Drawing.Point(34, 52)
        Me.btnNomina.Name = "btnNomina"
        Me.btnNomina.Size = New System.Drawing.Size(206, 33)
        Me.btnNomina.TabIndex = 2
        Me.btnNomina.Text = "CFDI Nómina"
        Me.btnNomina.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(165, 249)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Retención de Pagos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelaciones
        '
        Me.btnCancelaciones.Location = New System.Drawing.Point(34, 130)
        Me.btnCancelaciones.Name = "btnCancelaciones"
        Me.btnCancelaciones.Size = New System.Drawing.Size(206, 33)
        Me.btnCancelaciones.TabIndex = 5
        Me.btnCancelaciones.Text = "Cancelación de CFDI"
        Me.btnCancelaciones.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Evento contable a partir de XML"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnReporteDesglose
        '
        Me.btnReporteDesglose.Location = New System.Drawing.Point(34, 209)
        Me.btnReporteDesglose.Name = "btnReporteDesglose"
        Me.btnReporteDesglose.Size = New System.Drawing.Size(206, 34)
        Me.btnReporteDesglose.TabIndex = 7
        Me.btnReporteDesglose.Text = "Reporte desglose CFDI"
        Me.btnReporteDesglose.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 284)
        Me.Controls.Add(Me.btnReporteDesglose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCancelaciones)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNomina)
        Me.Controls.Add(Me.btnIngreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngreso As Windows.Forms.Button
    Friend WithEvents btnNomina As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents btnCancelaciones As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents btnReporteDesglose As Windows.Forms.Button
End Class
