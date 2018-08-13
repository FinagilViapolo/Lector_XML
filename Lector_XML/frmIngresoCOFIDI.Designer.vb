<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresoCOFIDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ATEBCOFIDIDataSet = New Lector_XML.ATEBCOFIDIDataSet()
        Me.CFDI_Clientes_COFIDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFDI_Clientes_COFIDITableAdapter = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.CFDI_Clientes_COFIDITableAdapter()
        Me.TableAdapterManager = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager()
        Me.CFDI_Clientes_COFIDIDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnXLS = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatussat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkValidaSAT = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDI_Clientes_COFIDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDI_Clientes_COFIDIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(649, 645)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(155, 23)
        Me.btnProcesar.TabIndex = 8
        Me.btnProcesar.Text = "Enviar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(432, 645)
        Me.DateTimePicker2.MaxDate = New Date(2017, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2013, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 7
        Me.DateTimePicker2.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0000000010", "0000000013"})
        Me.ComboBox1.Location = New System.Drawing.Point(20, 646)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "0000000010"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(226, 646)
        Me.DateTimePicker1.MaxDate = New Date(2017, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2013, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'ATEBCOFIDIDataSet
        '
        Me.ATEBCOFIDIDataSet.DataSetName = "ATEBCOFIDIDataSet"
        Me.ATEBCOFIDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFDI_Clientes_COFIDIBindingSource
        '
        Me.CFDI_Clientes_COFIDIBindingSource.DataMember = "CFDI_Clientes_COFIDI"
        Me.CFDI_Clientes_COFIDIBindingSource.DataSource = Me.ATEBCOFIDIDataSet
        '
        'CFDI_Clientes_COFIDITableAdapter
        '
        Me.CFDI_Clientes_COFIDITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CFDI_Clientes_COFIDIDataGridView
        '
        Me.CFDI_Clientes_COFIDIDataGridView.AllowUserToAddRows = False
        Me.CFDI_Clientes_COFIDIDataGridView.AllowUserToDeleteRows = False
        Me.CFDI_Clientes_COFIDIDataGridView.AutoGenerateColumns = False
        Me.CFDI_Clientes_COFIDIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CFDI_Clientes_COFIDIDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Descuento, Me.Impuesto, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.estatussat, Me.version})
        Me.CFDI_Clientes_COFIDIDataGridView.DataSource = Me.CFDI_Clientes_COFIDIBindingSource
        Me.CFDI_Clientes_COFIDIDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.CFDI_Clientes_COFIDIDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CFDI_Clientes_COFIDIDataGridView.Name = "CFDI_Clientes_COFIDIDataGridView"
        Me.CFDI_Clientes_COFIDIDataGridView.ReadOnly = True
        Me.CFDI_Clientes_COFIDIDataGridView.Size = New System.Drawing.Size(1410, 605)
        Me.CFDI_Clientes_COFIDIDataGridView.TabIndex = 10
        '
        'btnXLS
        '
        Me.btnXLS.Location = New System.Drawing.Point(889, 646)
        Me.btnXLS.Name = "btnXLS"
        Me.btnXLS.Size = New System.Drawing.Size(168, 23)
        Me.btnXLS.TabIndex = 11
        Me.btnXLS.Text = "XLX"
        Me.btnXLS.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Empresa"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RFC"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RazonSocial"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RazonSocial"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Serie"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaEmision"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaEmision"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoCambio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TipoCambio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FormaPago"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FormaPago"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "formaDePago"
        Me.DataGridViewTextBoxColumn11.HeaderText = "formaDePago"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "UnidadMedida"
        Me.DataGridViewTextBoxColumn15.HeaderText = "UnidadMedida"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.DataPropertyName = "Descuento"
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'Impuesto
        '
        Me.Impuesto.DataPropertyName = "Impuesto"
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FolioFiscal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FolioFiscal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FacturaElectronica"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FacturaElectronica"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'estatussat
        '
        Me.estatussat.HeaderText = "Estatus SAT"
        Me.estatussat.Name = "estatussat"
        Me.estatussat.ReadOnly = True
        '
        'version
        '
        Me.version.HeaderText = "Versión"
        Me.version.Name = "version"
        Me.version.ReadOnly = True
        '
        'chkValidaSAT
        '
        Me.chkValidaSAT.AutoSize = True
        Me.chkValidaSAT.Location = New System.Drawing.Point(1097, 648)
        Me.chkValidaSAT.Name = "chkValidaSAT"
        Me.chkValidaSAT.Size = New System.Drawing.Size(105, 17)
        Me.chkValidaSAT.TabIndex = 12
        Me.chkValidaSAT.Text = "Validación SAT?"
        Me.chkValidaSAT.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 673)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1410, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'frmIngresoCOFIDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 695)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkValidaSAT)
        Me.Controls.Add(Me.btnXLS)
        Me.Controls.Add(Me.CFDI_Clientes_COFIDIDataGridView)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmIngresoCOFIDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoCOFIDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDI_Clientes_COFIDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDI_Clientes_COFIDIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcesar As Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents ATEBCOFIDIDataSet As ATEBCOFIDIDataSet
    Friend WithEvents CFDI_Clientes_COFIDIBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CFDI_Clientes_COFIDITableAdapter As ATEBCOFIDIDataSetTableAdapters.CFDI_Clientes_COFIDITableAdapter
    Friend WithEvents TableAdapterManager As ATEBCOFIDIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CFDI_Clientes_COFIDIDataGridView As Windows.Forms.DataGridView
    Friend WithEvents btnXLS As Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn17 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estatussat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents version As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkValidaSAT As Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
End Class
