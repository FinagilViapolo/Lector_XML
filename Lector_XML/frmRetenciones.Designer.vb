<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetenciones
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
        Me.dgvXMLRet = New System.Windows.Forms.DataGridView()
        Me.btnLoadXML = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.fbdSelecDirArchivos = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnXLS = New System.Windows.Forms.Button()
        Me.version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaexp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cveretenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descretenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcemisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomemisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcreceptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrerec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curpr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idtrib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesfin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejercicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototaloperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototalgravado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototalexento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototalretenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baseretencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipopagoret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.versiondiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.versionint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SistFinanciero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetiroAORESRetInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperFinancDerivad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontIntNominal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontIntReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perdida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveTipDivOUtil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontISRAcredRetMexico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontISRAcredRetExtranjero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontRetExtDivExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSocDistrDiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontISRAcredNal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontDivAcumNal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontDivAcumExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvXMLRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvXMLRet
        '
        Me.dgvXMLRet.AllowUserToAddRows = False
        Me.dgvXMLRet.AllowUserToDeleteRows = False
        Me.dgvXMLRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXMLRet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.version, Me.folioint, Me.fechaexp, Me.cveretenc, Me.descretenc, Me.rfcemisor, Me.nomemisor, Me.curpe, Me.nacionalidad, Me.rfcreceptor, Me.nombrerec, Me.curpr, Me.idtrib, Me.mesini, Me.mesfin, Me.ejercicio, Me.montototaloperacion, Me.montototalgravado, Me.montototalexento, Me.montototalretenido, Me.baseretencion, Me.impuesto, Me.montoret, Me.tipopagoret, Me.versiondiv, Me.versionint, Me.SistFinanciero, Me.RetiroAORESRetInt, Me.OperFinancDerivad, Me.MontIntNominal, Me.MontIntReal, Me.Perdida, Me.CveTipDivOUtil, Me.MontISRAcredRetMexico, Me.MontISRAcredRetExtranjero, Me.MontRetExtDivExt, Me.TipoSocDistrDiv, Me.MontISRAcredNal, Me.MontDivAcumNal, Me.MontDivAcumExt, Me.UUID})
        Me.dgvXMLRet.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvXMLRet.Location = New System.Drawing.Point(0, 0)
        Me.dgvXMLRet.Name = "dgvXMLRet"
        Me.dgvXMLRet.ReadOnly = True
        Me.dgvXMLRet.Size = New System.Drawing.Size(1284, 618)
        Me.dgvXMLRet.TabIndex = 0
        '
        'btnLoadXML
        '
        Me.btnLoadXML.Location = New System.Drawing.Point(12, 647)
        Me.btnLoadXML.Name = "btnLoadXML"
        Me.btnLoadXML.Size = New System.Drawing.Size(134, 23)
        Me.btnLoadXML.TabIndex = 1
        Me.btnLoadXML.Text = "Cargar XML"
        Me.btnLoadXML.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(180, 647)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(134, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 673)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 6
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
        'btnXLS
        '
        Me.btnXLS.Location = New System.Drawing.Point(342, 647)
        Me.btnXLS.Name = "btnXLS"
        Me.btnXLS.Size = New System.Drawing.Size(75, 23)
        Me.btnXLS.TabIndex = 7
        Me.btnXLS.Text = "XLS"
        Me.btnXLS.UseVisualStyleBackColor = True
        '
        'version
        '
        Me.version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.version.HeaderText = "Versión"
        Me.version.Name = "version"
        Me.version.ReadOnly = True
        Me.version.Width = 67
        '
        'folioint
        '
        Me.folioint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.folioint.HeaderText = "Folio Int"
        Me.folioint.Name = "folioint"
        Me.folioint.ReadOnly = True
        Me.folioint.Width = 69
        '
        'fechaexp
        '
        Me.fechaexp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fechaexp.HeaderText = "Fecha Exp"
        Me.fechaexp.Name = "fechaexp"
        Me.fechaexp.ReadOnly = True
        Me.fechaexp.Width = 83
        '
        'cveretenc
        '
        Me.cveretenc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cveretenc.HeaderText = "Cve Retencion"
        Me.cveretenc.Name = "cveretenc"
        Me.cveretenc.ReadOnly = True
        Me.cveretenc.Width = 95
        '
        'descretenc
        '
        Me.descretenc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.descretenc.HeaderText = "DescRetenc"
        Me.descretenc.Name = "descretenc"
        Me.descretenc.ReadOnly = True
        Me.descretenc.Width = 92
        '
        'rfcemisor
        '
        Me.rfcemisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rfcemisor.HeaderText = "RFC Emisor"
        Me.rfcemisor.Name = "rfcemisor"
        Me.rfcemisor.ReadOnly = True
        Me.rfcemisor.Width = 80
        '
        'nomemisor
        '
        Me.nomemisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomemisor.HeaderText = "Nom Emisor"
        Me.nomemisor.Name = "nomemisor"
        Me.nomemisor.ReadOnly = True
        Me.nomemisor.Width = 81
        '
        'curpe
        '
        Me.curpe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.curpe.HeaderText = "CURP Emi"
        Me.curpe.Name = "curpe"
        Me.curpe.ReadOnly = True
        Me.curpe.Width = 76
        '
        'nacionalidad
        '
        Me.nacionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nacionalidad.HeaderText = "Nacionalidad"
        Me.nacionalidad.Name = "nacionalidad"
        Me.nacionalidad.ReadOnly = True
        Me.nacionalidad.Width = 94
        '
        'rfcreceptor
        '
        Me.rfcreceptor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rfcreceptor.HeaderText = "RFC Rec"
        Me.rfcreceptor.Name = "rfcreceptor"
        Me.rfcreceptor.ReadOnly = True
        Me.rfcreceptor.Width = 70
        '
        'nombrerec
        '
        Me.nombrerec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nombrerec.HeaderText = "Nom Receptor"
        Me.nombrerec.Name = "nombrerec"
        Me.nombrerec.ReadOnly = True
        Me.nombrerec.Width = 93
        '
        'curpr
        '
        Me.curpr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.curpr.HeaderText = "CURP Rec"
        Me.curpr.Name = "curpr"
        Me.curpr.ReadOnly = True
        Me.curpr.Width = 78
        '
        'idtrib
        '
        Me.idtrib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idtrib.HeaderText = "ID Trib"
        Me.idtrib.Name = "idtrib"
        Me.idtrib.ReadOnly = True
        Me.idtrib.Width = 60
        '
        'mesini
        '
        Me.mesini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.mesini.HeaderText = "Mes Ini"
        Me.mesini.Name = "mesini"
        Me.mesini.ReadOnly = True
        Me.mesini.Width = 61
        '
        'mesfin
        '
        Me.mesfin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.mesfin.HeaderText = "Mes Fin"
        Me.mesfin.Name = "mesfin"
        Me.mesfin.ReadOnly = True
        Me.mesfin.Width = 64
        '
        'ejercicio
        '
        Me.ejercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ejercicio.HeaderText = "Ejercicio"
        Me.ejercicio.Name = "ejercicio"
        Me.ejercicio.ReadOnly = True
        Me.ejercicio.Width = 72
        '
        'montototaloperacion
        '
        Me.montototaloperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.montototaloperacion.HeaderText = "MTOp"
        Me.montototaloperacion.Name = "montototaloperacion"
        Me.montototaloperacion.ReadOnly = True
        Me.montototaloperacion.Width = 62
        '
        'montototalgravado
        '
        Me.montototalgravado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.montototalgravado.HeaderText = "MTG"
        Me.montototalgravado.Name = "montototalgravado"
        Me.montototalgravado.ReadOnly = True
        Me.montototalgravado.Width = 56
        '
        'montototalexento
        '
        Me.montototalexento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.montototalexento.HeaderText = "MTE"
        Me.montototalexento.Name = "montototalexento"
        Me.montototalexento.ReadOnly = True
        Me.montototalexento.Width = 55
        '
        'montototalretenido
        '
        Me.montototalretenido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.montototalretenido.HeaderText = "MTR"
        Me.montototalretenido.Name = "montototalretenido"
        Me.montototalretenido.ReadOnly = True
        Me.montototalretenido.Width = 56
        '
        'baseretencion
        '
        Me.baseretencion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.baseretencion.HeaderText = "Base Ret"
        Me.baseretencion.Name = "baseretencion"
        Me.baseretencion.ReadOnly = True
        Me.baseretencion.Width = 70
        '
        'impuesto
        '
        Me.impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 75
        '
        'montoret
        '
        Me.montoret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.montoret.HeaderText = "Monto Ret"
        Me.montoret.Name = "montoret"
        Me.montoret.ReadOnly = True
        Me.montoret.Width = 76
        '
        'tipopagoret
        '
        Me.tipopagoret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipopagoret.HeaderText = "Tipo Pago Ret"
        Me.tipopagoret.Name = "tipopagoret"
        Me.tipopagoret.ReadOnly = True
        Me.tipopagoret.Width = 78
        '
        'versiondiv
        '
        Me.versiondiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.versiondiv.HeaderText = "Version Div"
        Me.versiondiv.Name = "versiondiv"
        Me.versiondiv.ReadOnly = True
        Me.versiondiv.Width = 79
        '
        'versionint
        '
        Me.versionint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.versionint.HeaderText = "Version Int"
        Me.versionint.Name = "versionint"
        Me.versionint.ReadOnly = True
        Me.versionint.Width = 76
        '
        'SistFinanciero
        '
        Me.SistFinanciero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SistFinanciero.HeaderText = "SistFinanciero"
        Me.SistFinanciero.Name = "SistFinanciero"
        Me.SistFinanciero.ReadOnly = True
        Me.SistFinanciero.Width = 98
        '
        'RetiroAORESRetInt
        '
        Me.RetiroAORESRetInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RetiroAORESRetInt.HeaderText = "RetiroAORESRetInt"
        Me.RetiroAORESRetInt.Name = "RetiroAORESRetInt"
        Me.RetiroAORESRetInt.ReadOnly = True
        Me.RetiroAORESRetInt.Width = 126
        '
        'OperFinancDerivad
        '
        Me.OperFinancDerivad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OperFinancDerivad.HeaderText = "OperFinancDerivad"
        Me.OperFinancDerivad.Name = "OperFinancDerivad"
        Me.OperFinancDerivad.ReadOnly = True
        Me.OperFinancDerivad.Width = 124
        '
        'MontIntNominal
        '
        Me.MontIntNominal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontIntNominal.HeaderText = "MontIntNominal"
        Me.MontIntNominal.Name = "MontIntNominal"
        Me.MontIntNominal.ReadOnly = True
        Me.MontIntNominal.Width = 106
        '
        'MontIntReal
        '
        Me.MontIntReal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontIntReal.HeaderText = "MontIntReal"
        Me.MontIntReal.Name = "MontIntReal"
        Me.MontIntReal.ReadOnly = True
        Me.MontIntReal.Width = 90
        '
        'Perdida
        '
        Me.Perdida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Perdida.HeaderText = "Perdida"
        Me.Perdida.Name = "Perdida"
        Me.Perdida.ReadOnly = True
        Me.Perdida.Width = 68
        '
        'CveTipDivOUtil
        '
        Me.CveTipDivOUtil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CveTipDivOUtil.HeaderText = "CveTipDivOUtil"
        Me.CveTipDivOUtil.Name = "CveTipDivOUtil"
        Me.CveTipDivOUtil.ReadOnly = True
        Me.CveTipDivOUtil.Width = 105
        '
        'MontISRAcredRetMexico
        '
        Me.MontISRAcredRetMexico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontISRAcredRetMexico.HeaderText = "MontISRAcredRetMexico"
        Me.MontISRAcredRetMexico.Name = "MontISRAcredRetMexico"
        Me.MontISRAcredRetMexico.ReadOnly = True
        Me.MontISRAcredRetMexico.Width = 153
        '
        'MontISRAcredRetExtranjero
        '
        Me.MontISRAcredRetExtranjero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontISRAcredRetExtranjero.HeaderText = "MontISRAcredRetExtranjero"
        Me.MontISRAcredRetExtranjero.Name = "MontISRAcredRetExtranjero"
        Me.MontISRAcredRetExtranjero.ReadOnly = True
        Me.MontISRAcredRetExtranjero.Width = 166
        '
        'MontRetExtDivExt
        '
        Me.MontRetExtDivExt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontRetExtDivExt.HeaderText = "MontRetExtDivExt"
        Me.MontRetExtDivExt.Name = "MontRetExtDivExt"
        Me.MontRetExtDivExt.ReadOnly = True
        Me.MontRetExtDivExt.Width = 119
        '
        'TipoSocDistrDiv
        '
        Me.TipoSocDistrDiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TipoSocDistrDiv.HeaderText = "TipoSocDistrDiv"
        Me.TipoSocDistrDiv.Name = "TipoSocDistrDiv"
        Me.TipoSocDistrDiv.ReadOnly = True
        Me.TipoSocDistrDiv.Width = 109
        '
        'MontISRAcredNal
        '
        Me.MontISRAcredNal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontISRAcredNal.HeaderText = "MontISRAcredNal"
        Me.MontISRAcredNal.Name = "MontISRAcredNal"
        Me.MontISRAcredNal.ReadOnly = True
        Me.MontISRAcredNal.Width = 118
        '
        'MontDivAcumNal
        '
        Me.MontDivAcumNal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontDivAcumNal.HeaderText = "MontDivAcumNal"
        Me.MontDivAcumNal.Name = "MontDivAcumNal"
        Me.MontDivAcumNal.ReadOnly = True
        Me.MontDivAcumNal.Width = 115
        '
        'MontDivAcumExt
        '
        Me.MontDivAcumExt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontDivAcumExt.HeaderText = "MontDivAcumExt"
        Me.MontDivAcumExt.Name = "MontDivAcumExt"
        Me.MontDivAcumExt.ReadOnly = True
        Me.MontDivAcumExt.Width = 114
        '
        'UUID
        '
        Me.UUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        Me.UUID.Width = 59
        '
        'frmRetenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 695)
        Me.Controls.Add(Me.btnXLS)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLoadXML)
        Me.Controls.Add(Me.dgvXMLRet)
        Me.Name = "frmRetenciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRetenciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvXMLRet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvXMLRet As Windows.Forms.DataGridView
    Friend WithEvents btnLoadXML As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents fbdSelecDirArchivos As Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnXLS As Windows.Forms.Button
    Friend WithEvents version As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folioint As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaexp As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cveretenc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descretenc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfcemisor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomemisor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents curpe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nacionalidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfcreceptor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombrerec As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents curpr As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idtrib As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesini As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesfin As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ejercicio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montototaloperacion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montototalgravado As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montototalexento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montototalretenido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baseretencion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impuesto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montoret As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipopagoret As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents versiondiv As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents versionint As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SistFinanciero As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetiroAORESRetInt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperFinancDerivad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontIntNominal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontIntReal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Perdida As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CveTipDivOUtil As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontISRAcredRetMexico As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontISRAcredRetExtranjero As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontRetExtDivExt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoSocDistrDiv As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontISRAcredNal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontDivAcumNal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontDivAcumExt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As Windows.Forms.DataGridViewTextBoxColumn
End Class
