<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventoContable
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.fbdSeleccionar = New System.Windows.Forms.FolderBrowserDialog()
        Me.dgvFacturasXml = New System.Windows.Forms.DataGridView()
        Me.poliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.txtPolizaInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaPoliza = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarPolizas = New System.Windows.Forms.Button()
        Me.sfdGuardarPolizas = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEncabezado = New System.Windows.Forms.TextBox()
        Me.pnlCuentas = New System.Windows.Forms.Panel()
        Me.cmbCuentas = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New Lector_XML.contpaq()
        Me.CuentasTableAdapter = New Lector_XML.contpaqTableAdapters.CuentasTableAdapter()
        CType(Me.dgvFacturasXml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlCuentas.SuspendLayout()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar archivos XML:"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(152, 4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 1
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'dgvFacturasXml
        '
        Me.dgvFacturasXml.AllowUserToAddRows = False
        Me.dgvFacturasXml.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturasXml.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacturasXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasXml.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.poliza, Me.cuenta, Me.cargo, Me.abono, Me.referencia, Me.concepto, Me.uuid})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturasXml.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFacturasXml.Location = New System.Drawing.Point(15, 33)
        Me.dgvFacturasXml.Name = "dgvFacturasXml"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturasXml.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFacturasXml.Size = New System.Drawing.Size(1005, 362)
        Me.dgvFacturasXml.TabIndex = 2
        '
        'poliza
        '
        Me.poliza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.poliza.HeaderText = "Póliza"
        Me.poliza.Name = "poliza"
        Me.poliza.Width = 60
        '
        'cuenta
        '
        Me.cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cuenta.HeaderText = "Cuenta Contable"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Width = 102
        '
        'cargo
        '
        Me.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 60
        '
        'abono
        '
        Me.abono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "N2"
        Me.abono.DefaultCellStyle = DataGridViewCellStyle3
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.Width = 63
        '
        'referencia
        '
        Me.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.Width = 84
        '
        'concepto
        '
        Me.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 78
        '
        'uuid
        '
        Me.uuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Width = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripProgressBar1, Me.ToolStripTextBox1, Me.ToolStripTextBox2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 449)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1032, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(10, 22)
        Me.ToolStripLabel1.Text = "."
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(10, 22)
        Me.ToolStripLabel2.Text = "."
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'txtPolizaInicial
        '
        Me.txtPolizaInicial.Location = New System.Drawing.Point(349, 4)
        Me.txtPolizaInicial.Name = "txtPolizaInicial"
        Me.txtPolizaInicial.Size = New System.Drawing.Size(50, 20)
        Me.txtPolizaInicial.TabIndex = 4
        Me.txtPolizaInicial.Text = "130"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Póliza inicial:"
        '
        'dtpFechaPoliza
        '
        Me.dtpFechaPoliza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPoliza.Location = New System.Drawing.Point(495, 4)
        Me.dtpFechaPoliza.Name = "dtpFechaPoliza"
        Me.dtpFechaPoliza.Size = New System.Drawing.Size(121, 20)
        Me.dtpFechaPoliza.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha pólizas:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(945, 412)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerarPolizas
        '
        Me.btnGenerarPolizas.Location = New System.Drawing.Point(28, 412)
        Me.btnGenerarPolizas.Name = "btnGenerarPolizas"
        Me.btnGenerarPolizas.Size = New System.Drawing.Size(118, 23)
        Me.btnGenerarPolizas.TabIndex = 9
        Me.btnGenerarPolizas.Text = "Generar Pólizas"
        Me.btnGenerarPolizas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(633, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Encabezado póliza:"
        '
        'txtEncabezado
        '
        Me.txtEncabezado.Location = New System.Drawing.Point(739, 6)
        Me.txtEncabezado.Name = "txtEncabezado"
        Me.txtEncabezado.Size = New System.Drawing.Size(281, 20)
        Me.txtEncabezado.TabIndex = 11
        Me.txtEncabezado.Text = "REGISTRO FACTURACION SERIE 2021"
        '
        'pnlCuentas
        '
        Me.pnlCuentas.Controls.Add(Me.cmbCuentas)
        Me.pnlCuentas.Location = New System.Drawing.Point(289, 177)
        Me.pnlCuentas.Name = "pnlCuentas"
        Me.pnlCuentas.Size = New System.Drawing.Size(445, 54)
        Me.pnlCuentas.TabIndex = 12
        Me.pnlCuentas.Visible = False
        '
        'cmbCuentas
        '
        Me.cmbCuentas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentas.DataSource = Me.CuentasBindingSource
        Me.cmbCuentas.DisplayMember = "Codigo"
        Me.cmbCuentas.FormattingEnabled = True
        Me.cmbCuentas.Location = New System.Drawing.Point(17, 14)
        Me.cmbCuentas.Name = "cmbCuentas"
        Me.cmbCuentas.Size = New System.Drawing.Size(413, 21)
        Me.cmbCuentas.TabIndex = 0
        Me.cmbCuentas.ValueMember = "Codigo"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'frmEventoContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 474)
        Me.Controls.Add(Me.pnlCuentas)
        Me.Controls.Add(Me.txtEncabezado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGenerarPolizas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaPoliza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPolizaInicial)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvFacturasXml)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEventoContable"
        Me.Text = "Evento contable a partir de XML"
        CType(Me.dgvFacturasXml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlCuentas.ResumeLayout(False)
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnSeleccionar As Windows.Forms.Button
    Friend WithEvents fbdSeleccionar As Windows.Forms.FolderBrowserDialog
    Friend WithEvents dgvFacturasXml As Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripTextBox1 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As Windows.Forms.ToolStripTextBox
    Friend WithEvents txtPolizaInicial As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dtpFechaPoliza As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents btnGenerarPolizas As Windows.Forms.Button
    Friend WithEvents sfdGuardarPolizas As Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtEncabezado As Windows.Forms.TextBox
    Friend WithEvents pnlCuentas As Windows.Forms.Panel
    Friend WithEvents cmbCuentas As Windows.Forms.ComboBox
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents poliza As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abono As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents referencia As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uuid As Windows.Forms.DataGridViewTextBoxColumn
End Class
