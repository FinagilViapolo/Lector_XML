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
        Me.Remanente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvXMLRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvXMLRet
        '
        Me.dgvXMLRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXMLRet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.version, Me.folioint, Me.fechaexp, Me.cveretenc, Me.descretenc, Me.rfcemisor, Me.nomemisor, Me.curpe, Me.nacionalidad, Me.rfcreceptor, Me.nombrerec, Me.curpr, Me.idtrib, Me.mesini, Me.mesfin, Me.ejercicio, Me.montototaloperacion, Me.montototalgravado, Me.montototalexento, Me.montototalretenido, Me.baseretencion, Me.impuesto, Me.montoret, Me.tipopagoret, Me.versiondiv, Me.versionint, Me.SistFinanciero, Me.RetiroAORESRetInt, Me.OperFinancDerivad, Me.MontIntNominal, Me.MontIntReal, Me.Perdida, Me.CveTipDivOUtil, Me.MontISRAcredRetMexico, Me.MontISRAcredRetExtranjero, Me.MontRetExtDivExt, Me.TipoSocDistrDiv, Me.MontISRAcredNal, Me.MontDivAcumNal, Me.MontDivAcumExt, Me.Remanente})
        Me.dgvXMLRet.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvXMLRet.Location = New System.Drawing.Point(0, 0)
        Me.dgvXMLRet.Name = "dgvXMLRet"
        Me.dgvXMLRet.Size = New System.Drawing.Size(1410, 618)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(1410, 22)
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
        'version
        '
        Me.version.HeaderText = "Versión"
        Me.version.Name = "version"
        '
        'folioint
        '
        Me.folioint.HeaderText = "Folio Int"
        Me.folioint.Name = "folioint"
        '
        'fechaexp
        '
        Me.fechaexp.HeaderText = "Fecha Exp"
        Me.fechaexp.Name = "fechaexp"
        '
        'cveretenc
        '
        Me.cveretenc.HeaderText = "Cve Retencion"
        Me.cveretenc.Name = "cveretenc"
        '
        'descretenc
        '
        Me.descretenc.HeaderText = "DescRetenc"
        Me.descretenc.Name = "descretenc"
        '
        'rfcemisor
        '
        Me.rfcemisor.HeaderText = "RFC Emisor"
        Me.rfcemisor.Name = "rfcemisor"
        '
        'nomemisor
        '
        Me.nomemisor.HeaderText = "Nom Emisor"
        Me.nomemisor.Name = "nomemisor"
        '
        'curpe
        '
        Me.curpe.HeaderText = "CURP Emi"
        Me.curpe.Name = "curpe"
        '
        'nacionalidad
        '
        Me.nacionalidad.HeaderText = "Nacionalidad"
        Me.nacionalidad.Name = "nacionalidad"
        '
        'rfcreceptor
        '
        Me.rfcreceptor.HeaderText = "RFC Rec"
        Me.rfcreceptor.Name = "rfcreceptor"
        '
        'nombrerec
        '
        Me.nombrerec.HeaderText = "Nom Receptor"
        Me.nombrerec.Name = "nombrerec"
        '
        'curpr
        '
        Me.curpr.HeaderText = "CURP Rec"
        Me.curpr.Name = "curpr"
        '
        'idtrib
        '
        Me.idtrib.HeaderText = "ID Trib"
        Me.idtrib.Name = "idtrib"
        '
        'mesini
        '
        Me.mesini.HeaderText = "Mes Ini"
        Me.mesini.Name = "mesini"
        '
        'mesfin
        '
        Me.mesfin.HeaderText = "Mes Fin"
        Me.mesfin.Name = "mesfin"
        '
        'ejercicio
        '
        Me.ejercicio.HeaderText = "Ejercicio"
        Me.ejercicio.Name = "ejercicio"
        '
        'montototaloperacion
        '
        Me.montototaloperacion.HeaderText = "MTOp"
        Me.montototaloperacion.Name = "montototaloperacion"
        '
        'montototalgravado
        '
        Me.montototalgravado.HeaderText = "MTG"
        Me.montototalgravado.Name = "montototalgravado"
        '
        'montototalexento
        '
        Me.montototalexento.HeaderText = "MTE"
        Me.montototalexento.Name = "montototalexento"
        '
        'montototalretenido
        '
        Me.montototalretenido.HeaderText = "MTR"
        Me.montototalretenido.Name = "montototalretenido"
        '
        'baseretencion
        '
        Me.baseretencion.HeaderText = "Base Ret"
        Me.baseretencion.Name = "baseretencion"
        '
        'impuesto
        '
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        '
        'montoret
        '
        Me.montoret.HeaderText = "Monto Ret"
        Me.montoret.Name = "montoret"
        '
        'tipopagoret
        '
        Me.tipopagoret.HeaderText = "Tipo Pago Ret"
        Me.tipopagoret.Name = "tipopagoret"
        '
        'versiondiv
        '
        Me.versiondiv.HeaderText = "Version Div"
        Me.versiondiv.Name = "versiondiv"
        '
        'versionint
        '
        Me.versionint.HeaderText = "Version Int"
        Me.versionint.Name = "versionint"
        '
        'SistFinanciero
        '
        Me.SistFinanciero.HeaderText = "SistFinanciero"
        Me.SistFinanciero.Name = "SistFinanciero"
        '
        'RetiroAORESRetInt
        '
        Me.RetiroAORESRetInt.HeaderText = "RetiroAORESRetInt"
        Me.RetiroAORESRetInt.Name = "RetiroAORESRetInt"
        '
        'OperFinancDerivad
        '
        Me.OperFinancDerivad.HeaderText = "OperFinancDerivad"
        Me.OperFinancDerivad.Name = "OperFinancDerivad"
        '
        'MontIntNominal
        '
        Me.MontIntNominal.HeaderText = "MontIntNominal"
        Me.MontIntNominal.Name = "MontIntNominal"
        '
        'MontIntReal
        '
        Me.MontIntReal.HeaderText = "MontIntReal"
        Me.MontIntReal.Name = "MontIntReal"
        '
        'Perdida
        '
        Me.Perdida.HeaderText = "Perdida"
        Me.Perdida.Name = "Perdida"
        '
        'CveTipDivOUtil
        '
        Me.CveTipDivOUtil.HeaderText = "CveTipDivOUtil"
        Me.CveTipDivOUtil.Name = "CveTipDivOUtil"
        '
        'MontISRAcredRetMexico
        '
        Me.MontISRAcredRetMexico.HeaderText = "MontISRAcredRetMexico"
        Me.MontISRAcredRetMexico.Name = "MontISRAcredRetMexico"
        '
        'MontISRAcredRetExtranjero
        '
        Me.MontISRAcredRetExtranjero.HeaderText = "MontISRAcredRetExtranjero"
        Me.MontISRAcredRetExtranjero.Name = "MontISRAcredRetExtranjero"
        '
        'MontRetExtDivExt
        '
        Me.MontRetExtDivExt.HeaderText = "MontRetExtDivExt"
        Me.MontRetExtDivExt.Name = "MontRetExtDivExt"
        '
        'TipoSocDistrDiv
        '
        Me.TipoSocDistrDiv.HeaderText = "TipoSocDistrDiv"
        Me.TipoSocDistrDiv.Name = "TipoSocDistrDiv"
        '
        'MontISRAcredNal
        '
        Me.MontISRAcredNal.HeaderText = "MontISRAcredNal"
        Me.MontISRAcredNal.Name = "MontISRAcredNal"
        '
        'MontDivAcumNal
        '
        Me.MontDivAcumNal.HeaderText = "MontDivAcumNal"
        Me.MontDivAcumNal.Name = "MontDivAcumNal"
        '
        'MontDivAcumExt
        '
        Me.MontDivAcumExt.HeaderText = "MontDivAcumExt"
        Me.MontDivAcumExt.Name = "MontDivAcumExt"
        '
        'Remanente
        '
        Me.Remanente.HeaderText = "Remanente"
        Me.Remanente.Name = "Remanente"
        '
        'frmRetenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 695)
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
    Friend WithEvents Remanente As Windows.Forms.DataGridViewTextBoxColumn
End Class
