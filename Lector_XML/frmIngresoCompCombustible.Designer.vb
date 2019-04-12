<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoCompCombustible
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvComplemento = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tocIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impIeps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tocIeps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvComplemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvComplemento
        '
        Me.dgvComplemento.AllowUserToAddRows = False
        Me.dgvComplemento.AllowUserToDeleteRows = False
        Me.dgvComplemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComplemento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad, Me.fecha, Me.importe, Me.rfc, Me.valorUnitario, Me.impIva, Me.tocIva, Me.impIeps, Me.tocIeps})
        Me.dgvComplemento.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvComplemento.Location = New System.Drawing.Point(0, 0)
        Me.dgvComplemento.Name = "dgvComplemento"
        Me.dgvComplemento.ReadOnly = True
        Me.dgvComplemento.Size = New System.Drawing.Size(1085, 373)
        Me.dgvComplemento.TabIndex = 0
        '
        'cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N6"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'fecha
        '
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 150
        '
        'importe
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N6"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle3
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'rfc
        '
        Me.rfc.HeaderText = "RFC"
        Me.rfc.Name = "rfc"
        Me.rfc.ReadOnly = True
        Me.rfc.Width = 150
        '
        'valorUnitario
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N6"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.valorUnitario.DefaultCellStyle = DataGridViewCellStyle4
        Me.valorUnitario.HeaderText = "Val Unit"
        Me.valorUnitario.Name = "valorUnitario"
        Me.valorUnitario.ReadOnly = True
        '
        'impIva
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N6"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.impIva.DefaultCellStyle = DataGridViewCellStyle5
        Me.impIva.HeaderText = "Imp IVA"
        Me.impIva.Name = "impIva"
        Me.impIva.ReadOnly = True
        '
        'tocIva
        '
        Me.tocIva.HeaderText = "TOC IVA"
        Me.tocIva.Name = "tocIva"
        Me.tocIva.ReadOnly = True
        '
        'impIeps
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N6"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.impIeps.DefaultCellStyle = DataGridViewCellStyle6
        Me.impIeps.HeaderText = "Imp IEPS"
        Me.impIeps.Name = "impIeps"
        Me.impIeps.ReadOnly = True
        '
        'tocIeps
        '
        Me.tocIeps.HeaderText = "TOC IEPS"
        Me.tocIeps.Name = "tocIeps"
        Me.tocIeps.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(46, 379)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(294, 379)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(649, 379)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(844, 379)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Totales:"
        '
        'frmIngresoCompCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 424)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvComplemento)
        Me.Name = "frmIngresoCompCombustible"
        Me.Text = "Complemento de Cuenta Combustible"
        CType(Me.dgvComplemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvComplemento As Windows.Forms.DataGridView
    Friend WithEvents cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorUnitario As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impIva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tocIva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impIeps As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tocIeps As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
