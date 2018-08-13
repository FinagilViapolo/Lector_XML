<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoEk
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TimbresEkomercioDataGridView = New System.Windows.Forms.DataGridView()
        Me.TimbresEkomercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATEBCOFIDIDataSet = New Lector_XML.ATEBCOFIDIDataSet()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcemisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcreceptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreReceptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechatimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimbresEkomercioTableAdapter = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TimbresEkomercioTableAdapter()
        Me.TableAdapterManager = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager()
        Me.SerieDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafacDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechatimDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcemisorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcreceptorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreReceptorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Misc46DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Misc02DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciclo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TimbresEkomercioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimbresEkomercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimbresEkomercioDataGridView
        '
        Me.TimbresEkomercioDataGridView.AllowUserToAddRows = False
        Me.TimbresEkomercioDataGridView.AllowUserToDeleteRows = False
        Me.TimbresEkomercioDataGridView.AutoGenerateColumns = False
        Me.TimbresEkomercioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimbresEkomercioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerieDataGridViewTextBoxColumn1, Me.FolioDataGridViewTextBoxColumn1, Me.UuidDataGridViewTextBoxColumn1, Me.FechafacDataGridViewTextBoxColumn1, Me.FechatimDataGridViewTextBoxColumn1, Me.RfcemisorDataGridViewTextBoxColumn1, Me.RfcreceptorDataGridViewTextBoxColumn1, Me.NombreReceptorDataGridViewTextBoxColumn1, Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1, Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1, Me.MontoTotalDataGridViewTextBoxColumn, Me.Misc46DataGridViewTextBoxColumn, Me.Misc02DataGridViewTextBoxColumn, Me.Anexo, Me.Ciclo, Me.TipoCredito, Me.XmlDataGridViewTextBoxColumn})
        Me.TimbresEkomercioDataGridView.DataSource = Me.TimbresEkomercioBindingSource
        Me.TimbresEkomercioDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TimbresEkomercioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TimbresEkomercioDataGridView.Name = "TimbresEkomercioDataGridView"
        Me.TimbresEkomercioDataGridView.ReadOnly = True
        Me.TimbresEkomercioDataGridView.Size = New System.Drawing.Size(1410, 605)
        Me.TimbresEkomercioDataGridView.TabIndex = 2
        '
        'TimbresEkomercioBindingSource
        '
        Me.TimbresEkomercioBindingSource.DataMember = "TimbresEkomercio"
        Me.TimbresEkomercioBindingSource.DataSource = Me.ATEBCOFIDIDataSet
        '
        'ATEBCOFIDIDataSet
        '
        Me.ATEBCOFIDIDataSet.DataSetName = "ATEBCOFIDIDataSet"
        Me.ATEBCOFIDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(12, 625)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicial.TabIndex = 3
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(230, 625)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFinal.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(446, 625)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Enviar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn2.HeaderText = "serie"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "rfc_emisor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "rfc_emisor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "rfc_receptor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "rfc_receptor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "114_Misc02"
        Me.DataGridViewTextBoxColumn1.HeaderText = "114_Misc02"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UuidDataGridViewTextBoxColumn
        '
        Me.UuidDataGridViewTextBoxColumn.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn.HeaderText = "uuid"
        Me.UuidDataGridViewTextBoxColumn.Name = "UuidDataGridViewTextBoxColumn"
        Me.UuidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RfcemisorDataGridViewTextBoxColumn
        '
        Me.RfcemisorDataGridViewTextBoxColumn.DataPropertyName = "rfc_emisor"
        Me.RfcemisorDataGridViewTextBoxColumn.HeaderText = "rfc_emisor"
        Me.RfcemisorDataGridViewTextBoxColumn.Name = "RfcemisorDataGridViewTextBoxColumn"
        Me.RfcemisorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RfcreceptorDataGridViewTextBoxColumn
        '
        Me.RfcreceptorDataGridViewTextBoxColumn.DataPropertyName = "rfc_receptor"
        Me.RfcreceptorDataGridViewTextBoxColumn.HeaderText = "rfc_receptor"
        Me.RfcreceptorDataGridViewTextBoxColumn.Name = "RfcreceptorDataGridViewTextBoxColumn"
        Me.RfcreceptorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreReceptorDataGridViewTextBoxColumn
        '
        Me.NombreReceptorDataGridViewTextBoxColumn.DataPropertyName = "42_Nombre_Receptor"
        Me.NombreReceptorDataGridViewTextBoxColumn.HeaderText = "42_Nombre_Receptor"
        Me.NombreReceptorDataGridViewTextBoxColumn.Name = "NombreReceptorDataGridViewTextBoxColumn"
        Me.NombreReceptorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechafacDataGridViewTextBoxColumn
        '
        Me.FechafacDataGridViewTextBoxColumn.DataPropertyName = "fecha_fac"
        Me.FechafacDataGridViewTextBoxColumn.HeaderText = "fecha_fac"
        Me.FechafacDataGridViewTextBoxColumn.Name = "FechafacDataGridViewTextBoxColumn"
        Me.FechafacDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechatimDataGridViewTextBoxColumn
        '
        Me.FechatimDataGridViewTextBoxColumn.DataPropertyName = "fecha_tim"
        Me.FechatimDataGridViewTextBoxColumn.HeaderText = "fecha_tim"
        Me.FechatimDataGridViewTextBoxColumn.Name = "FechatimDataGridViewTextBoxColumn"
        Me.FechatimDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoTotalImpRetenidosDataGridViewTextBoxColumn
        '
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn.DataPropertyName = "192_Monto_TotalImp_Retenidos"
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn.HeaderText = "192_Monto_TotalImp_Retenidos"
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn.Name = "MontoTotalImpRetenidosDataGridViewTextBoxColumn"
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoTotalImpTrasladadosDataGridViewTextBoxColumn
        '
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn.DataPropertyName = "193_Monto_TotalImp_Trasladados"
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn.HeaderText = "193_Monto_TotalImp_Trasladados"
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn.Name = "MontoTotalImpTrasladadosDataGridViewTextBoxColumn"
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimbresEkomercioTableAdapter
        '
        Me.TimbresEkomercioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SerieDataGridViewTextBoxColumn1
        '
        Me.SerieDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SerieDataGridViewTextBoxColumn1.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn1.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn1.Name = "SerieDataGridViewTextBoxColumn1"
        Me.SerieDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn1.Width = 54
        '
        'FolioDataGridViewTextBoxColumn1
        '
        Me.FolioDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioDataGridViewTextBoxColumn1.DataPropertyName = "folio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.FolioDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioDataGridViewTextBoxColumn1.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn1.Name = "FolioDataGridViewTextBoxColumn1"
        Me.FolioDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn1.Width = 51
        '
        'UuidDataGridViewTextBoxColumn1
        '
        Me.UuidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UuidDataGridViewTextBoxColumn1.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn1.HeaderText = "uuid"
        Me.UuidDataGridViewTextBoxColumn1.Name = "UuidDataGridViewTextBoxColumn1"
        Me.UuidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UuidDataGridViewTextBoxColumn1.Width = 52
        '
        'FechafacDataGridViewTextBoxColumn1
        '
        Me.FechafacDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechafacDataGridViewTextBoxColumn1.DataPropertyName = "fecha_fac"
        Me.FechafacDataGridViewTextBoxColumn1.HeaderText = "fecha_fac"
        Me.FechafacDataGridViewTextBoxColumn1.Name = "FechafacDataGridViewTextBoxColumn1"
        Me.FechafacDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechafacDataGridViewTextBoxColumn1.Width = 80
        '
        'FechatimDataGridViewTextBoxColumn1
        '
        Me.FechatimDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechatimDataGridViewTextBoxColumn1.DataPropertyName = "fecha_tim"
        Me.FechatimDataGridViewTextBoxColumn1.HeaderText = "fecha_tim"
        Me.FechatimDataGridViewTextBoxColumn1.Name = "FechatimDataGridViewTextBoxColumn1"
        Me.FechatimDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechatimDataGridViewTextBoxColumn1.Width = 78
        '
        'RfcemisorDataGridViewTextBoxColumn1
        '
        Me.RfcemisorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RfcemisorDataGridViewTextBoxColumn1.DataPropertyName = "rfc_emisor"
        Me.RfcemisorDataGridViewTextBoxColumn1.HeaderText = "rfc_emisor"
        Me.RfcemisorDataGridViewTextBoxColumn1.Name = "RfcemisorDataGridViewTextBoxColumn1"
        Me.RfcemisorDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RfcemisorDataGridViewTextBoxColumn1.Width = 80
        '
        'RfcreceptorDataGridViewTextBoxColumn1
        '
        Me.RfcreceptorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RfcreceptorDataGridViewTextBoxColumn1.DataPropertyName = "rfc_receptor"
        Me.RfcreceptorDataGridViewTextBoxColumn1.HeaderText = "rfc_receptor"
        Me.RfcreceptorDataGridViewTextBoxColumn1.Name = "RfcreceptorDataGridViewTextBoxColumn1"
        Me.RfcreceptorDataGridViewTextBoxColumn1.ReadOnly = True
        Me.RfcreceptorDataGridViewTextBoxColumn1.Width = 89
        '
        'NombreReceptorDataGridViewTextBoxColumn1
        '
        Me.NombreReceptorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NombreReceptorDataGridViewTextBoxColumn1.DataPropertyName = "42_Nombre_Receptor"
        Me.NombreReceptorDataGridViewTextBoxColumn1.HeaderText = "42_Nombre_Receptor"
        Me.NombreReceptorDataGridViewTextBoxColumn1.Name = "NombreReceptorDataGridViewTextBoxColumn1"
        Me.NombreReceptorDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NombreReceptorDataGridViewTextBoxColumn1.Width = 137
        '
        'MontoTotalImpTrasladadosDataGridViewTextBoxColumn1
        '
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.DataPropertyName = "193_Monto_TotalImp_Trasladados"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.HeaderText = "193_Monto_TotalImp_Trasladados"
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.Name = "MontoTotalImpTrasladadosDataGridViewTextBoxColumn1"
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MontoTotalImpTrasladadosDataGridViewTextBoxColumn1.Width = 197
        '
        'MontoTotalImpRetenidosDataGridViewTextBoxColumn1
        '
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.DataPropertyName = "192_Monto_TotalImp_Retenidos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.HeaderText = "192_Monto_TotalImp_Retenidos"
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.Name = "MontoTotalImpRetenidosDataGridViewTextBoxColumn1"
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MontoTotalImpRetenidosDataGridViewTextBoxColumn1.Width = 187
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "56_Monto_Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.MontoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "56_Monto_Total"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 110
        '
        'Misc46DataGridViewTextBoxColumn
        '
        Me.Misc46DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Misc46DataGridViewTextBoxColumn.DataPropertyName = "158_Misc46"
        Me.Misc46DataGridViewTextBoxColumn.HeaderText = "158_Misc46"
        Me.Misc46DataGridViewTextBoxColumn.Name = "Misc46DataGridViewTextBoxColumn"
        Me.Misc46DataGridViewTextBoxColumn.ReadOnly = True
        Me.Misc46DataGridViewTextBoxColumn.Width = 90
        '
        'Misc02DataGridViewTextBoxColumn
        '
        Me.Misc02DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Misc02DataGridViewTextBoxColumn.DataPropertyName = "114_Misc02"
        Me.Misc02DataGridViewTextBoxColumn.HeaderText = "114_Misc02"
        Me.Misc02DataGridViewTextBoxColumn.Name = "Misc02DataGridViewTextBoxColumn"
        Me.Misc02DataGridViewTextBoxColumn.ReadOnly = True
        Me.Misc02DataGridViewTextBoxColumn.Width = 90
        '
        'Anexo
        '
        Me.Anexo.DataPropertyName = "Anexo"
        Me.Anexo.HeaderText = "Anexo"
        Me.Anexo.Name = "Anexo"
        Me.Anexo.ReadOnly = True
        '
        'Ciclo
        '
        Me.Ciclo.DataPropertyName = "Ciclo"
        Me.Ciclo.HeaderText = "Ciclo"
        Me.Ciclo.Name = "Ciclo"
        Me.Ciclo.ReadOnly = True
        '
        'TipoCredito
        '
        Me.TipoCredito.DataPropertyName = "TipoCredito"
        Me.TipoCredito.HeaderText = "TipoCredito"
        Me.TipoCredito.Name = "TipoCredito"
        Me.TipoCredito.ReadOnly = True
        '
        'XmlDataGridViewTextBoxColumn
        '
        Me.XmlDataGridViewTextBoxColumn.DataPropertyName = "xml"
        Me.XmlDataGridViewTextBoxColumn.HeaderText = "xml"
        Me.XmlDataGridViewTextBoxColumn.Name = "XmlDataGridViewTextBoxColumn"
        Me.XmlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmIngresoEk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 695)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.TimbresEkomercioDataGridView)
        Me.Name = "frmIngresoEk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoEk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TimbresEkomercioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimbresEkomercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ATEBCOFIDIDataSet As ATEBCOFIDIDataSet
    Friend WithEvents TimbresEkomercioBindingSource As Windows.Forms.BindingSource
    Friend WithEvents TimbresEkomercioTableAdapter As ATEBCOFIDIDataSetTableAdapters.TimbresEkomercioTableAdapter
    Friend WithEvents TableAdapterManager As ATEBCOFIDIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimbresEkomercioDataGridView As Windows.Forms.DataGridView
    Friend WithEvents dtpFechaInicial As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As Windows.Forms.DateTimePicker
    Friend WithEvents btnAceptar As Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcemisorDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcreceptorDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreReceptorDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafacDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechatimDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalImpRetenidosDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalImpTrasladadosDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafacDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechatimDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcemisorDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcreceptorDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreReceptorDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalImpTrasladadosDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalImpRetenidosDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Misc46DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Misc02DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anexo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciclo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCredito As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmlDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
