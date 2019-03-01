<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacionCFDI
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
        Dim _1_FolioLabel As System.Windows.Forms.Label
        Dim _27_Serie_ComprobanteLabel As System.Windows.Forms.Label
        Dim GuidLabel As System.Windows.Forms.Label
        Me.CFDI_EncabezadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarUUID = New System.Windows.Forms.TextBox()
        Me.txtBuscarFolio = New System.Windows.Forms.TextBox()
        Me.txtBuscarSerie = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFDI_EncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATEBCOFIDIDataSet = New Lector_XML.ATEBCOFIDIDataSet()
        Me.CFDI_EncabezadoTableAdapter = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.CFDI_EncabezadoTableAdapter()
        Me.TableAdapterManager = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarRango = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFolioInicial = New System.Windows.Forms.TextBox()
        Me.tstSerieR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFolioFinal = New System.Windows.Forms.TextBox()
        Me._1_FolioTextBox = New System.Windows.Forms.TextBox()
        Me._27_Serie_ComprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.GuidTextBox = New System.Windows.Forms.TextBox()
        _1_FolioLabel = New System.Windows.Forms.Label()
        _27_Serie_ComprobanteLabel = New System.Windows.Forms.Label()
        GuidLabel = New System.Windows.Forms.Label()
        CType(Me.CFDI_EncabezadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CFDI_EncabezadoDataGridView
        '
        Me.CFDI_EncabezadoDataGridView.AllowUserToAddRows = False
        Me.CFDI_EncabezadoDataGridView.AllowUserToDeleteRows = False
        Me.CFDI_EncabezadoDataGridView.AllowUserToOrderColumns = True
        Me.CFDI_EncabezadoDataGridView.AutoGenerateColumns = False
        Me.CFDI_EncabezadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CFDI_EncabezadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.CFDI_EncabezadoDataGridView.DataSource = Me.CFDI_EncabezadoBindingSource
        Me.CFDI_EncabezadoDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.CFDI_EncabezadoDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CFDI_EncabezadoDataGridView.Name = "CFDI_EncabezadoDataGridView"
        Me.CFDI_EncabezadoDataGridView.ReadOnly = True
        Me.CFDI_EncabezadoDataGridView.Size = New System.Drawing.Size(1264, 529)
        Me.CFDI_EncabezadoDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBuscarUUID)
        Me.GroupBox1.Controls.Add(Me.txtBuscarFolio)
        Me.GroupBox1.Controls.Add(Me.txtBuscarSerie)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 556)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(376, 98)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "UUID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Folio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Serie:"
        '
        'txtBuscarUUID
        '
        Me.txtBuscarUUID.Location = New System.Drawing.Point(98, 72)
        Me.txtBuscarUUID.Name = "txtBuscarUUID"
        Me.txtBuscarUUID.Size = New System.Drawing.Size(353, 20)
        Me.txtBuscarUUID.TabIndex = 4
        '
        'txtBuscarFolio
        '
        Me.txtBuscarFolio.Location = New System.Drawing.Point(98, 45)
        Me.txtBuscarFolio.Name = "txtBuscarFolio"
        Me.txtBuscarFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarFolio.TabIndex = 3
        '
        'txtBuscarSerie
        '
        Me.txtBuscarSerie.Location = New System.Drawing.Point(98, 19)
        Me.txtBuscarSerie.Name = "txtBuscarSerie"
        Me.txtBuscarSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarSerie.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "1_Folio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "1_Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "2_Nombre_Emisor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "2_Nombre_Emisor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "3_RFC_Emisor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "3_RFC_Emisor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "5_Dom_Emisor_noExterior"
        Me.DataGridViewTextBoxColumn4.HeaderText = "5_Dom_Emisor_noExterior"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "13_Dom_Emisor_codigoPostal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "13_Dom_Emisor_codigoPostal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "26_Version"
        Me.DataGridViewTextBoxColumn6.HeaderText = "26_Version"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "27_Serie_Comprobante"
        Me.DataGridViewTextBoxColumn7.HeaderText = "27_Serie_Comprobante"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "29_FormaPago"
        Me.DataGridViewTextBoxColumn8.HeaderText = "29_FormaPago"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "30_Fecha"
        Me.DataGridViewTextBoxColumn9.HeaderText = "30_Fecha"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "31_Hora"
        Me.DataGridViewTextBoxColumn10.HeaderText = "31_Hora"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "41_Dom_LugarExpide_codigoPostal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "41_Dom_LugarExpide_codigoPostal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "42_Nombre_Receptor"
        Me.DataGridViewTextBoxColumn12.HeaderText = "42_Nombre_Receptor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "43_RFC_Receptor"
        Me.DataGridViewTextBoxColumn13.HeaderText = "43_RFC_Receptor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "53_Dom_Receptor_codigoPostal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "53_Dom_Receptor_codigoPostal"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "54_Monto_SubTotal"
        Me.DataGridViewTextBoxColumn15.HeaderText = "54_Monto_SubTotal"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "55_Monto_IVA"
        Me.DataGridViewTextBoxColumn16.HeaderText = "55_Monto_IVA"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "56_Monto_Total"
        Me.DataGridViewTextBoxColumn17.HeaderText = "56_Monto_Total"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "58_TipoCFD"
        Me.DataGridViewTextBoxColumn18.HeaderText = "58_TipoCFD"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "144_Misc32"
        Me.DataGridViewTextBoxColumn19.HeaderText = "144_Misc32"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "157_Misc45"
        Me.DataGridViewTextBoxColumn20.HeaderText = "157_Misc45"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "158_Misc46"
        Me.DataGridViewTextBoxColumn21.HeaderText = "158_Misc46"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "159_Misc47"
        Me.DataGridViewTextBoxColumn22.HeaderText = "159_Misc47"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "192_Monto_TotalImp_Retenidos"
        Me.DataGridViewTextBoxColumn23.HeaderText = "192_Monto_TotalImp_Retenidos"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "193_Monto_TotalImp_Trasladados"
        Me.DataGridViewTextBoxColumn24.HeaderText = "193_Monto_TotalImp_Trasladados"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Guid"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Guid"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "100_Letras_Monto_Total"
        Me.DataGridViewTextBoxColumn26.HeaderText = "100_Letras_Monto_Total"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "114_Misc02"
        Me.DataGridViewTextBoxColumn27.HeaderText = "114_Misc02"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "180_LugarExpedicion"
        Me.DataGridViewTextBoxColumn28.HeaderText = "180_LugarExpedicion"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "190_Metodo_Pago"
        Me.DataGridViewTextBoxColumn29.HeaderText = "190_Metodo_Pago"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "191_Efecto_Comprobante"
        Me.DataGridViewTextBoxColumn30.HeaderText = "191_Efecto_Comprobante"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'CFDI_EncabezadoBindingSource
        '
        Me.CFDI_EncabezadoBindingSource.DataMember = "CFDI_Encabezado"
        Me.CFDI_EncabezadoBindingSource.DataSource = Me.ATEBCOFIDIDataSet
        '
        'ATEBCOFIDIDataSet
        '
        Me.ATEBCOFIDIDataSet.DataSetName = "ATEBCOFIDIDataSet"
        Me.ATEBCOFIDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFDI_EncabezadoTableAdapter
        '
        Me.CFDI_EncabezadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_EncabezadoTableAdapter = Me.CFDI_EncabezadoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1150, 665)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFolioFinal)
        Me.GroupBox2.Controls.Add(Me.btnBuscarRango)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtFolioInicial)
        Me.GroupBox2.Controls.Add(Me.tstSerieR)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 556)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 127)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Rango"
        '
        'btnBuscarRango
        '
        Me.btnBuscarRango.Location = New System.Drawing.Point(292, 98)
        Me.btnBuscarRango.Name = "btnBuscarRango"
        Me.btnBuscarRango.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarRango.TabIndex = 10
        Me.btnBuscarRango.Text = "Buscar"
        Me.btnBuscarRango.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(175, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Folio Inicial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Serie:"
        '
        'txtFolioInicial
        '
        Me.txtFolioInicial.Location = New System.Drawing.Point(267, 19)
        Me.txtFolioInicial.Name = "txtFolioInicial"
        Me.txtFolioInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioInicial.TabIndex = 8
        '
        'tstSerieR
        '
        Me.tstSerieR.Location = New System.Drawing.Point(46, 19)
        Me.tstSerieR.Name = "tstSerieR"
        Me.tstSerieR.Size = New System.Drawing.Size(100, 20)
        Me.tstSerieR.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Folio Final:"
        '
        'txtFolioFinal
        '
        Me.txtFolioFinal.Location = New System.Drawing.Point(267, 45)
        Me.txtFolioFinal.Name = "txtFolioFinal"
        Me.txtFolioFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioFinal.TabIndex = 9
        '
        '_1_FolioLabel
        '
        _1_FolioLabel.AutoSize = True
        _1_FolioLabel.Location = New System.Drawing.Point(917, 590)
        _1_FolioLabel.Name = "_1_FolioLabel"
        _1_FolioLabel.Size = New System.Drawing.Size(32, 13)
        _1_FolioLabel.TabIndex = 9
        _1_FolioLabel.Text = "Folio:"
        '
        '_1_FolioTextBox
        '
        Me._1_FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "1_Folio", True))
        Me._1_FolioTextBox.Location = New System.Drawing.Point(957, 587)
        Me._1_FolioTextBox.Name = "_1_FolioTextBox"
        Me._1_FolioTextBox.ReadOnly = True
        Me._1_FolioTextBox.Size = New System.Drawing.Size(100, 20)
        Me._1_FolioTextBox.TabIndex = 12
        '
        '_27_Serie_ComprobanteLabel
        '
        _27_Serie_ComprobanteLabel.AutoSize = True
        _27_Serie_ComprobanteLabel.Location = New System.Drawing.Point(917, 564)
        _27_Serie_ComprobanteLabel.Name = "_27_Serie_ComprobanteLabel"
        _27_Serie_ComprobanteLabel.Size = New System.Drawing.Size(34, 13)
        _27_Serie_ComprobanteLabel.TabIndex = 10
        _27_Serie_ComprobanteLabel.Text = "Serie:"
        '
        '_27_Serie_ComprobanteTextBox
        '
        Me._27_Serie_ComprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "27_Serie_Comprobante", True))
        Me._27_Serie_ComprobanteTextBox.Location = New System.Drawing.Point(957, 561)
        Me._27_Serie_ComprobanteTextBox.Name = "_27_Serie_ComprobanteTextBox"
        Me._27_Serie_ComprobanteTextBox.ReadOnly = True
        Me._27_Serie_ComprobanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me._27_Serie_ComprobanteTextBox.TabIndex = 11
        '
        'GuidLabel
        '
        GuidLabel.AutoSize = True
        GuidLabel.Location = New System.Drawing.Point(919, 616)
        GuidLabel.Name = "GuidLabel"
        GuidLabel.Size = New System.Drawing.Size(32, 13)
        GuidLabel.TabIndex = 11
        GuidLabel.Text = "Guid:"
        '
        'GuidTextBox
        '
        Me.GuidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "Guid", True))
        Me.GuidTextBox.Location = New System.Drawing.Point(957, 613)
        Me.GuidTextBox.Name = "GuidTextBox"
        Me.GuidTextBox.ReadOnly = True
        Me.GuidTextBox.Size = New System.Drawing.Size(268, 20)
        Me.GuidTextBox.TabIndex = 13
        '
        'frmCancelacionCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 703)
        Me.Controls.Add(GuidLabel)
        Me.Controls.Add(Me.GuidTextBox)
        Me.Controls.Add(_27_Serie_ComprobanteLabel)
        Me.Controls.Add(Me._27_Serie_ComprobanteTextBox)
        Me.Controls.Add(_1_FolioLabel)
        Me.Controls.Add(Me._1_FolioTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CFDI_EncabezadoDataGridView)
        Me.Name = "frmCancelacionCFDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CFDI emitidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CFDI_EncabezadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ATEBCOFIDIDataSet As ATEBCOFIDIDataSet
    Friend WithEvents CFDI_EncabezadoBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CFDI_EncabezadoTableAdapter As ATEBCOFIDIDataSetTableAdapters.CFDI_EncabezadoTableAdapter
    Friend WithEvents TableAdapterManager As ATEBCOFIDIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CFDI_EncabezadoDataGridView As Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtBuscarUUID As Windows.Forms.TextBox
    Friend WithEvents txtBuscarFolio As Windows.Forms.TextBox
    Friend WithEvents txtBuscarSerie As Windows.Forms.TextBox
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtFolioFinal As Windows.Forms.TextBox
    Friend WithEvents btnBuscarRango As Windows.Forms.Button
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtFolioInicial As Windows.Forms.TextBox
    Friend WithEvents tstSerieR As Windows.Forms.TextBox
    Friend WithEvents _1_FolioTextBox As Windows.Forms.TextBox
    Friend WithEvents _27_Serie_ComprobanteTextBox As Windows.Forms.TextBox
    Friend WithEvents GuidTextBox As Windows.Forms.TextBox
End Class
