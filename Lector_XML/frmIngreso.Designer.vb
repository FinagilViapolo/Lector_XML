<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngreso
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.fbdSelecDirArchivos = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnLoadXML = New System.Windows.Forms.Button()
        Me.chkValidaSAT = New System.Windows.Forms.CheckBox()
        Me.btnCofidi = New System.Windows.Forms.Button()
        Me.dgvIngresos = New System.Windows.Forms.DataGridView()
        Me.btnXLS = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnBDEkomercio = New System.Windows.Forms.Button()
        Me.chkContTCred = New System.Windows.Forms.CheckBox()
        Me.btnSepArchivos = New System.Windows.Forms.Button()
        Me.fbdSeparar_Origen = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdSeparar_Destino = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CFDIClientesCOFIDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATEBCOFIDIDataSet = New Lector_XML.ATEBCOFIDIDataSet()
        Me.CFDI_Clientes_COFIDITableAdapter = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.CFDI_Clientes_COFIDITableAdapter()
        Me.TableAdapterManager = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager()
        Me.chkDesglose = New System.Windows.Forms.CheckBox()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc_emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc_receptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_receptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucfdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiporelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipreluuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claveprodserv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claveunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttipofactor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttasaocuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totaltraslados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rimpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtipofactor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtasaocuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rimporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalretenciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechatimbrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipocredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaDePagoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcEmisorCtaBen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoDePagoDR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumParcialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpSaldoAnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpSaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.CFDIClientesCOFIDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadXML
        '
        Me.btnLoadXML.Location = New System.Drawing.Point(383, 647)
        Me.btnLoadXML.Name = "btnLoadXML"
        Me.btnLoadXML.Size = New System.Drawing.Size(134, 23)
        Me.btnLoadXML.TabIndex = 1
        Me.btnLoadXML.Text = "Cargar XML"
        Me.btnLoadXML.UseVisualStyleBackColor = True
        '
        'chkValidaSAT
        '
        Me.chkValidaSAT.AutoSize = True
        Me.chkValidaSAT.Location = New System.Drawing.Point(22, 651)
        Me.chkValidaSAT.Name = "chkValidaSAT"
        Me.chkValidaSAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkValidaSAT.Size = New System.Drawing.Size(105, 17)
        Me.chkValidaSAT.TabIndex = 2
        Me.chkValidaSAT.Text = "?Validación SAT"
        Me.chkValidaSAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkValidaSAT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkValidaSAT.UseVisualStyleBackColor = True
        '
        'btnCofidi
        '
        Me.btnCofidi.Location = New System.Drawing.Point(837, 647)
        Me.btnCofidi.Name = "btnCofidi"
        Me.btnCofidi.Size = New System.Drawing.Size(134, 23)
        Me.btnCofidi.TabIndex = 3
        Me.btnCofidi.Text = "BD de COFIDI"
        Me.btnCofidi.UseVisualStyleBackColor = True
        '
        'dgvIngresos
        '
        Me.dgvIngresos.AllowUserToAddRows = False
        Me.dgvIngresos.AllowUserToDeleteRows = False
        Me.dgvIngresos.AllowUserToOrderColumns = True
        Me.dgvIngresos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serie, Me.folio, Me.rfc_emisor, Me.nombre_emisor, Me.rfiscal, Me.rfc_receptor, Me.nombre_receptor, Me.ucfdi, Me.tipo, Me.fecha, Me.fpago, Me.cpago, Me.moneda, Me.mpago, Me.tiporelacion, Me.tipreluuid, Me.claveprodserv, Me.cantidad, Me.claveunidad, Me.unidad, Me.concepto, Me.pu, Me.importe, Me.tbase, Me.timpuesto, Me.ttipofactor, Me.ttasaocuota, Me.timporte, Me.totaltraslados, Me.rbase, Me.rimpuesto, Me.rtipofactor, Me.rtasaocuota, Me.rimporte, Me.totalretenciones, Me.subtotal, Me.descuento, Me.total, Me.uuid, Me.fechatimbrado, Me.sat, Me.version, Me.contrato, Me.tipocredito, Me.VersionCP, Me.FechaPago, Me.FormaDePagoP, Me.MonedaP, Me.Monto, Me.NumOperacion, Me.RfcEmisorCtaBen, Me.CtaBeneficiario, Me.IdDocumento, Me.SerieCP, Me.FolioCP, Me.MonedaDR, Me.MetodoDePagoDR, Me.NumParcialidad, Me.ImpSaldoAnt, Me.ImpPagado, Me.ImpSaldoInsoluto, Me.complemento, Me.archivo, Me.satC})
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIngresos.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgvIngresos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvIngresos.Location = New System.Drawing.Point(0, 0)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.ReadOnly = True
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngresos.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvIngresos.Size = New System.Drawing.Size(1370, 618)
        Me.dgvIngresos.TabIndex = 0
        '
        'btnXLS
        '
        Me.btnXLS.Location = New System.Drawing.Point(523, 647)
        Me.btnXLS.Name = "btnXLS"
        Me.btnXLS.Size = New System.Drawing.Size(134, 23)
        Me.btnXLS.TabIndex = 4
        Me.btnXLS.Text = "XLS"
        Me.btnXLS.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 673)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'btnBDEkomercio
        '
        Me.btnBDEkomercio.Location = New System.Drawing.Point(697, 647)
        Me.btnBDEkomercio.Name = "btnBDEkomercio"
        Me.btnBDEkomercio.Size = New System.Drawing.Size(134, 23)
        Me.btnBDEkomercio.TabIndex = 6
        Me.btnBDEkomercio.Text = "BD Ekomercio"
        Me.btnBDEkomercio.UseVisualStyleBackColor = True
        '
        'chkContTCred
        '
        Me.chkContTCred.AutoSize = True
        Me.chkContTCred.Location = New System.Drawing.Point(222, 651)
        Me.chkContTCred.Name = "chkContTCred"
        Me.chkContTCred.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkContTCred.Size = New System.Drawing.Size(122, 17)
        Me.chkContTCred.TabIndex = 7
        Me.chkContTCred.Text = "?Obtine Cont/TCred"
        Me.chkContTCred.UseVisualStyleBackColor = True
        '
        'btnSepArchivos
        '
        Me.btnSepArchivos.Location = New System.Drawing.Point(1005, 647)
        Me.btnSepArchivos.Name = "btnSepArchivos"
        Me.btnSepArchivos.Size = New System.Drawing.Size(134, 23)
        Me.btnSepArchivos.TabIndex = 8
        Me.btnSepArchivos.Text = "Separar Archivos (A/M)"
        Me.btnSepArchivos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1173, 647)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CFDIClientesCOFIDIBindingSource
        '
        Me.CFDIClientesCOFIDIBindingSource.DataMember = "CFDI_Clientes_COFIDI"
        Me.CFDIClientesCOFIDIBindingSource.DataSource = Me.ATEBCOFIDIDataSet
        '
        'ATEBCOFIDIDataSet
        '
        Me.ATEBCOFIDIDataSet.DataSetName = "ATEBCOFIDIDataSet"
        Me.ATEBCOFIDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFDI_Clientes_COFIDITableAdapter
        '
        Me.CFDI_Clientes_COFIDITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_EncabezadoTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'chkDesglose
        '
        Me.chkDesglose.AutoSize = True
        Me.chkDesglose.Location = New System.Drawing.Point(220, 624)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(124, 17)
        Me.chkDesglose.TabIndex = 10
        Me.chkDesglose.Text = "Desglose Conceptos"
        Me.chkDesglose.UseVisualStyleBackColor = True
        '
        'serie
        '
        Me.serie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Width = 56
        '
        'folio
        '
        Me.folio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.folio.DefaultCellStyle = DataGridViewCellStyle2
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        Me.folio.Width = 54
        '
        'rfc_emisor
        '
        Me.rfc_emisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rfc_emisor.HeaderText = "RFC Emisor"
        Me.rfc_emisor.Name = "rfc_emisor"
        Me.rfc_emisor.ReadOnly = True
        Me.rfc_emisor.Width = 87
        '
        'nombre_emisor
        '
        Me.nombre_emisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nombre_emisor.HeaderText = "Emisor"
        Me.nombre_emisor.Name = "nombre_emisor"
        Me.nombre_emisor.ReadOnly = True
        Me.nombre_emisor.Width = 63
        '
        'rfiscal
        '
        Me.rfiscal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rfiscal.HeaderText = "R Fiscal"
        Me.rfiscal.Name = "rfiscal"
        Me.rfiscal.ReadOnly = True
        Me.rfiscal.Width = 70
        '
        'rfc_receptor
        '
        Me.rfc_receptor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rfc_receptor.HeaderText = "RFC Receptor"
        Me.rfc_receptor.Name = "rfc_receptor"
        Me.rfc_receptor.ReadOnly = True
        '
        'nombre_receptor
        '
        Me.nombre_receptor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nombre_receptor.HeaderText = "N Receptor"
        Me.nombre_receptor.Name = "nombre_receptor"
        Me.nombre_receptor.ReadOnly = True
        Me.nombre_receptor.Width = 87
        '
        'ucfdi
        '
        Me.ucfdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ucfdi.DefaultCellStyle = DataGridViewCellStyle3
        Me.ucfdi.HeaderText = "U CFDI"
        Me.ucfdi.Name = "ucfdi"
        Me.ucfdi.ReadOnly = True
        Me.ucfdi.Width = 67
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 53
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'fpago
        '
        Me.fpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.NullValue = Nothing
        Me.fpago.DefaultCellStyle = DataGridViewCellStyle5
        Me.fpago.HeaderText = "F de Pago"
        Me.fpago.Name = "fpago"
        Me.fpago.ReadOnly = True
        Me.fpago.Width = 81
        '
        'cpago
        '
        Me.cpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cpago.HeaderText = "C de Pago"
        Me.cpago.Name = "cpago"
        Me.cpago.ReadOnly = True
        Me.cpago.Width = 82
        '
        'moneda
        '
        Me.moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 71
        '
        'mpago
        '
        Me.mpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.mpago.HeaderText = "M de Pago"
        Me.mpago.Name = "mpago"
        Me.mpago.ReadOnly = True
        Me.mpago.Width = 84
        '
        'tiporelacion
        '
        Me.tiporelacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.NullValue = Nothing
        Me.tiporelacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.tiporelacion.HeaderText = "TipoRelacion"
        Me.tiporelacion.Name = "tiporelacion"
        Me.tiporelacion.ReadOnly = True
        Me.tiporelacion.Width = 95
        '
        'tipreluuid
        '
        Me.tipreluuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipreluuid.HeaderText = "TipoRelacionUUID"
        Me.tipreluuid.Name = "tipreluuid"
        Me.tipreluuid.ReadOnly = True
        Me.tipreluuid.Width = 122
        '
        'claveprodserv
        '
        Me.claveprodserv.HeaderText = "Clave PS"
        Me.claveprodserv.Name = "claveprodserv"
        Me.claveprodserv.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 74
        '
        'claveunidad
        '
        Me.claveunidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.claveunidad.HeaderText = "Clave U"
        Me.claveunidad.Name = "claveunidad"
        Me.claveunidad.ReadOnly = True
        Me.claveunidad.Width = 70
        '
        'unidad
        '
        Me.unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        Me.unidad.Width = 66
        '
        'concepto
        '
        Me.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 78
        '
        'pu
        '
        Me.pu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.pu.DefaultCellStyle = DataGridViewCellStyle8
        Me.pu.HeaderText = "PU"
        Me.pu.Name = "pu"
        Me.pu.ReadOnly = True
        Me.pu.Width = 47
        '
        'importe
        '
        Me.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.importe.DefaultCellStyle = DataGridViewCellStyle9
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 67
        '
        'tbase
        '
        Me.tbase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.tbase.DefaultCellStyle = DataGridViewCellStyle10
        Me.tbase.HeaderText = "T Base"
        Me.tbase.Name = "tbase"
        Me.tbase.ReadOnly = True
        Me.tbase.Width = 66
        '
        'timpuesto
        '
        Me.timpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.timpuesto.HeaderText = "T Impuesto"
        Me.timpuesto.Name = "timpuesto"
        Me.timpuesto.ReadOnly = True
        Me.timpuesto.Width = 85
        '
        'ttipofactor
        '
        Me.ttipofactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ttipofactor.HeaderText = "T TipoFactor"
        Me.ttipofactor.Name = "ttipofactor"
        Me.ttipofactor.ReadOnly = True
        Me.ttipofactor.Width = 93
        '
        'ttasaocuota
        '
        Me.ttasaocuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ttasaocuota.HeaderText = "T TasaOCuota"
        Me.ttasaocuota.Name = "ttasaocuota"
        Me.ttasaocuota.ReadOnly = True
        Me.ttasaocuota.Width = 102
        '
        'timporte
        '
        Me.timporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.timporte.DefaultCellStyle = DataGridViewCellStyle11
        Me.timporte.HeaderText = "T Importe"
        Me.timporte.Name = "timporte"
        Me.timporte.ReadOnly = True
        Me.timporte.Width = 77
        '
        'totaltraslados
        '
        Me.totaltraslados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.totaltraslados.DefaultCellStyle = DataGridViewCellStyle12
        Me.totaltraslados.HeaderText = "Total Traslados"
        Me.totaltraslados.Name = "totaltraslados"
        Me.totaltraslados.ReadOnly = True
        Me.totaltraslados.Width = 96
        '
        'rbase
        '
        Me.rbase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.rbase.DefaultCellStyle = DataGridViewCellStyle13
        Me.rbase.HeaderText = "R Base"
        Me.rbase.Name = "rbase"
        Me.rbase.ReadOnly = True
        Me.rbase.Width = 62
        '
        'rimpuesto
        '
        Me.rimpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rimpuesto.HeaderText = "R Impuesto"
        Me.rimpuesto.Name = "rimpuesto"
        Me.rimpuesto.ReadOnly = True
        Me.rimpuesto.Width = 79
        '
        'rtipofactor
        '
        Me.rtipofactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rtipofactor.HeaderText = "R Tipo Factor"
        Me.rtipofactor.Name = "rtipofactor"
        Me.rtipofactor.ReadOnly = True
        Me.rtipofactor.Width = 89
        '
        'rtasaocuota
        '
        Me.rtasaocuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rtasaocuota.HeaderText = "R TasaOCuota"
        Me.rtasaocuota.Name = "rtasaocuota"
        Me.rtasaocuota.ReadOnly = True
        Me.rtasaocuota.Width = 95
        '
        'rimporte
        '
        Me.rimporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.rimporte.DefaultCellStyle = DataGridViewCellStyle14
        Me.rimporte.HeaderText = "R Importe"
        Me.rimporte.Name = "rimporte"
        Me.rimporte.ReadOnly = True
        Me.rimporte.Width = 72
        '
        'totalretenciones
        '
        Me.totalretenciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.totalretenciones.DefaultCellStyle = DataGridViewCellStyle15
        Me.totalretenciones.HeaderText = "Total Retenidos"
        Me.totalretenciones.Name = "totalretenciones"
        Me.totalretenciones.ReadOnly = True
        Me.totalretenciones.Width = 98
        '
        'subtotal
        '
        Me.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle16
        Me.subtotal.HeaderText = "SubTotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 75
        '
        'descuento
        '
        Me.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle17
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 84
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle18
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 56
        '
        'uuid
        '
        Me.uuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Width = 59
        '
        'fechatimbrado
        '
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.fechatimbrado.DefaultCellStyle = DataGridViewCellStyle19
        Me.fechatimbrado.HeaderText = "Fecha Timbrado"
        Me.fechatimbrado.Name = "fechatimbrado"
        Me.fechatimbrado.ReadOnly = True
        '
        'sat
        '
        Me.sat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.sat.HeaderText = "Estatus SAT"
        Me.sat.Name = "sat"
        Me.sat.ReadOnly = True
        Me.sat.Width = 84
        '
        'version
        '
        Me.version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.version.HeaderText = "Versión"
        Me.version.Name = "version"
        Me.version.ReadOnly = True
        Me.version.Width = 67
        '
        'contrato
        '
        Me.contrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle20.NullValue = Nothing
        Me.contrato.DefaultCellStyle = DataGridViewCellStyle20
        Me.contrato.HeaderText = "Contrato"
        Me.contrato.Name = "contrato"
        Me.contrato.ReadOnly = True
        Me.contrato.Width = 72
        '
        'tipocredito
        '
        Me.tipocredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipocredito.HeaderText = "Tipo Crédito"
        Me.tipocredito.Name = "tipocredito"
        Me.tipocredito.ReadOnly = True
        Me.tipocredito.Width = 82
        '
        'VersionCP
        '
        Me.VersionCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VersionCP.HeaderText = "Version CP"
        Me.VersionCP.Name = "VersionCP"
        Me.VersionCP.ReadOnly = True
        Me.VersionCP.Width = 78
        '
        'FechaPago
        '
        Me.FechaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaPago.HeaderText = "FechaPago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 87
        '
        'FormaDePagoP
        '
        Me.FormaDePagoP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.FormaDePagoP.HeaderText = "FormaDePagoP"
        Me.FormaDePagoP.Name = "FormaDePagoP"
        Me.FormaDePagoP.ReadOnly = True
        Me.FormaDePagoP.Width = 5
        '
        'MonedaP
        '
        Me.MonedaP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MonedaP.HeaderText = "MonedaP"
        Me.MonedaP.Name = "MonedaP"
        Me.MonedaP.ReadOnly = True
        Me.MonedaP.Width = 78
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 62
        '
        'NumOperacion
        '
        Me.NumOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumOperacion.HeaderText = "NumOperacion"
        Me.NumOperacion.Name = "NumOperacion"
        Me.NumOperacion.ReadOnly = True
        Me.NumOperacion.Width = 103
        '
        'RfcEmisorCtaBen
        '
        Me.RfcEmisorCtaBen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RfcEmisorCtaBen.HeaderText = "RfcEmisorCtaBen"
        Me.RfcEmisorCtaBen.Name = "RfcEmisorCtaBen"
        Me.RfcEmisorCtaBen.ReadOnly = True
        Me.RfcEmisorCtaBen.Width = 115
        '
        'CtaBeneficiario
        '
        Me.CtaBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CtaBeneficiario.HeaderText = "CtaBeneficiario"
        Me.CtaBeneficiario.Name = "CtaBeneficiario"
        Me.CtaBeneficiario.ReadOnly = True
        Me.CtaBeneficiario.Width = 103
        '
        'IdDocumento
        '
        Me.IdDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.IdDocumento.HeaderText = "IdDocumento"
        Me.IdDocumento.Name = "IdDocumento"
        Me.IdDocumento.ReadOnly = True
        Me.IdDocumento.Width = 5
        '
        'SerieCP
        '
        Me.SerieCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SerieCP.HeaderText = "SerieCP"
        Me.SerieCP.Name = "SerieCP"
        Me.SerieCP.ReadOnly = True
        Me.SerieCP.Width = 70
        '
        'FolioCP
        '
        Me.FolioCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.FolioCP.DefaultCellStyle = DataGridViewCellStyle21
        Me.FolioCP.HeaderText = "FolioCP"
        Me.FolioCP.Name = "FolioCP"
        Me.FolioCP.ReadOnly = True
        Me.FolioCP.Width = 68
        '
        'MonedaDR
        '
        Me.MonedaDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MonedaDR.HeaderText = "MonedaDR"
        Me.MonedaDR.Name = "MonedaDR"
        Me.MonedaDR.ReadOnly = True
        Me.MonedaDR.Width = 87
        '
        'MetodoDePagoDR
        '
        Me.MetodoDePagoDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MetodoDePagoDR.HeaderText = "MetodoDePagoDR"
        Me.MetodoDePagoDR.Name = "MetodoDePagoDR"
        Me.MetodoDePagoDR.ReadOnly = True
        Me.MetodoDePagoDR.Width = 123
        '
        'NumParcialidad
        '
        Me.NumParcialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumParcialidad.HeaderText = "NumParcialidad"
        Me.NumParcialidad.Name = "NumParcialidad"
        Me.NumParcialidad.ReadOnly = True
        Me.NumParcialidad.Width = 106
        '
        'ImpSaldoAnt
        '
        Me.ImpSaldoAnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.ImpSaldoAnt.DefaultCellStyle = DataGridViewCellStyle22
        Me.ImpSaldoAnt.HeaderText = "ImpSaldoAnt"
        Me.ImpSaldoAnt.Name = "ImpSaldoAnt"
        Me.ImpSaldoAnt.ReadOnly = True
        Me.ImpSaldoAnt.Width = 92
        '
        'ImpPagado
        '
        Me.ImpPagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.ImpPagado.DefaultCellStyle = DataGridViewCellStyle23
        Me.ImpPagado.HeaderText = "ImpPagado"
        Me.ImpPagado.Name = "ImpPagado"
        Me.ImpPagado.ReadOnly = True
        Me.ImpPagado.Width = 86
        '
        'ImpSaldoInsoluto
        '
        Me.ImpSaldoInsoluto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.ImpSaldoInsoluto.DefaultCellStyle = DataGridViewCellStyle24
        Me.ImpSaldoInsoluto.HeaderText = "ImpSaldoInsoluto"
        Me.ImpSaldoInsoluto.Name = "ImpSaldoInsoluto"
        Me.ImpSaldoInsoluto.ReadOnly = True
        Me.ImpSaldoInsoluto.Width = 113
        '
        'complemento
        '
        Me.complemento.HeaderText = "Complemento"
        Me.complemento.Name = "complemento"
        Me.complemento.ReadOnly = True
        '
        'archivo
        '
        Me.archivo.HeaderText = "Archivo"
        Me.archivo.Name = "archivo"
        Me.archivo.ReadOnly = True
        '
        'satC
        '
        Me.satC.HeaderText = "Estatus SAT Can"
        Me.satC.Name = "satC"
        Me.satC.ReadOnly = True
        '
        'frmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 695)
        Me.Controls.Add(Me.chkDesglose)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSepArchivos)
        Me.Controls.Add(Me.chkContTCred)
        Me.Controls.Add(Me.btnBDEkomercio)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnXLS)
        Me.Controls.Add(Me.btnCofidi)
        Me.Controls.Add(Me.chkValidaSAT)
        Me.Controls.Add(Me.btnLoadXML)
        Me.Controls.Add(Me.dgvIngresos)
        Me.Name = "frmIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngreso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.CFDIClientesCOFIDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdSelecDirArchivos As Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnLoadXML As Windows.Forms.Button
    Friend WithEvents chkValidaSAT As Windows.Forms.CheckBox
    Friend WithEvents ATEBCOFIDIDataSet As ATEBCOFIDIDataSet
    Friend WithEvents CFDIClientesCOFIDIBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CFDI_Clientes_COFIDITableAdapter As ATEBCOFIDIDataSetTableAdapters.CFDI_Clientes_COFIDITableAdapter
    Friend WithEvents TableAdapterManager As ATEBCOFIDIDataSetTableAdapters.TableAdapterManager
    Private components As ComponentModel.IContainer
    Friend WithEvents btnCofidi As Windows.Forms.Button
    Friend WithEvents dgvIngresos As Windows.Forms.DataGridView
    Friend WithEvents btnXLS As Windows.Forms.Button
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnBDEkomercio As Windows.Forms.Button
    Friend WithEvents chkContTCred As Windows.Forms.CheckBox
    Friend WithEvents btnSepArchivos As Windows.Forms.Button
    Friend WithEvents fbdSeparar_Origen As Windows.Forms.FolderBrowserDialog
    Friend WithEvents fbdSeparar_Destino As Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents chkDesglose As Windows.Forms.CheckBox
    Friend WithEvents serie As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfc_emisor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_emisor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfiscal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfc_receptor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_receptor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ucfdi As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fpago As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpago As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mpago As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiporelacion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipreluuid As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claveprodserv As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claveunidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pu As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbase As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timpuesto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttipofactor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttasaocuota As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timporte As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totaltraslados As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbase As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rimpuesto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtipofactor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtasaocuota As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rimporte As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalretenciones As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uuid As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechatimbrado As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents version As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contrato As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipocredito As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionCP As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaDePagoP As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaP As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumOperacion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcEmisorCtaBen As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaBeneficiario As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDocumento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieCP As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioCP As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaDR As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetodoDePagoDR As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumParcialidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpSaldoAnt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpPagado As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpSaldoInsoluto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents complemento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents archivo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satC As Windows.Forms.DataGridViewTextBoxColumn
End Class
