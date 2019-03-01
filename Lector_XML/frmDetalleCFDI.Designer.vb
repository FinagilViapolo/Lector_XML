<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCFDI
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
        Dim _2_Nombre_EmisorLabel As System.Windows.Forms.Label
        Dim _27_Serie_ComprobanteLabel As System.Windows.Forms.Label
        Dim _26_VersionLabel As System.Windows.Forms.Label
        Dim _29_FormaPagoLabel As System.Windows.Forms.Label
        Dim _30_FechaLabel As System.Windows.Forms.Label
        Dim _42_Nombre_ReceptorLabel As System.Windows.Forms.Label
        Dim _43_RFC_ReceptorLabel As System.Windows.Forms.Label
        Dim _54_Monto_SubTotalLabel As System.Windows.Forms.Label
        Dim _55_Monto_IVALabel As System.Windows.Forms.Label
        Dim _56_Monto_TotalLabel As System.Windows.Forms.Label
        Dim _144_Misc32Label As System.Windows.Forms.Label
        Dim _157_Misc45Label As System.Windows.Forms.Label
        Dim _158_Misc46Label As System.Windows.Forms.Label
        Dim _159_Misc47Label As System.Windows.Forms.Label
        Dim _192_Monto_TotalImp_RetenidosLabel As System.Windows.Forms.Label
        Dim _193_Monto_TotalImp_TrasladadosLabel As System.Windows.Forms.Label
        Dim _114_Misc02Label As System.Windows.Forms.Label
        Dim _190_Metodo_PagoLabel As System.Windows.Forms.Label
        Dim _191_Efecto_ComprobanteLabel As System.Windows.Forms.Label
        Dim GuidLabel As System.Windows.Forms.Label
        Me._1_FolioTextBox = New System.Windows.Forms.TextBox()
        Me._2_Nombre_EmisorTextBox = New System.Windows.Forms.TextBox()
        Me._27_Serie_ComprobanteTextBox = New System.Windows.Forms.TextBox()
        Me._26_VersionTextBox = New System.Windows.Forms.TextBox()
        Me._29_FormaPagoTextBox = New System.Windows.Forms.TextBox()
        Me._30_FechaTextBox = New System.Windows.Forms.TextBox()
        Me._42_Nombre_ReceptorTextBox = New System.Windows.Forms.TextBox()
        Me._43_RFC_ReceptorTextBox = New System.Windows.Forms.TextBox()
        Me._54_Monto_SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me._55_Monto_IVATextBox = New System.Windows.Forms.TextBox()
        Me._56_Monto_TotalTextBox = New System.Windows.Forms.TextBox()
        Me._144_Misc32TextBox = New System.Windows.Forms.TextBox()
        Me._157_Misc45TextBox = New System.Windows.Forms.TextBox()
        Me._158_Misc46TextBox = New System.Windows.Forms.TextBox()
        Me._159_Misc47TextBox = New System.Windows.Forms.TextBox()
        Me._192_Monto_TotalImp_RetenidosTextBox = New System.Windows.Forms.TextBox()
        Me._193_Monto_TotalImp_TrasladadosTextBox = New System.Windows.Forms.TextBox()
        Me._114_Misc02TextBox = New System.Windows.Forms.TextBox()
        Me._190_Metodo_PagoTextBox = New System.Windows.Forms.TextBox()
        Me._191_Efecto_ComprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.GuidTextBox = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CFDI_EncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATEBCOFIDIDataSet = New Lector_XML.ATEBCOFIDIDataSet()
        Me.CFDI_EncabezadoTableAdapter = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.CFDI_EncabezadoTableAdapter()
        Me.TableAdapterManager = New Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager()
        _1_FolioLabel = New System.Windows.Forms.Label()
        _2_Nombre_EmisorLabel = New System.Windows.Forms.Label()
        _27_Serie_ComprobanteLabel = New System.Windows.Forms.Label()
        _26_VersionLabel = New System.Windows.Forms.Label()
        _29_FormaPagoLabel = New System.Windows.Forms.Label()
        _30_FechaLabel = New System.Windows.Forms.Label()
        _42_Nombre_ReceptorLabel = New System.Windows.Forms.Label()
        _43_RFC_ReceptorLabel = New System.Windows.Forms.Label()
        _54_Monto_SubTotalLabel = New System.Windows.Forms.Label()
        _55_Monto_IVALabel = New System.Windows.Forms.Label()
        _56_Monto_TotalLabel = New System.Windows.Forms.Label()
        _144_Misc32Label = New System.Windows.Forms.Label()
        _157_Misc45Label = New System.Windows.Forms.Label()
        _158_Misc46Label = New System.Windows.Forms.Label()
        _159_Misc47Label = New System.Windows.Forms.Label()
        _192_Monto_TotalImp_RetenidosLabel = New System.Windows.Forms.Label()
        _193_Monto_TotalImp_TrasladadosLabel = New System.Windows.Forms.Label()
        _114_Misc02Label = New System.Windows.Forms.Label()
        _190_Metodo_PagoLabel = New System.Windows.Forms.Label()
        _191_Efecto_ComprobanteLabel = New System.Windows.Forms.Label()
        GuidLabel = New System.Windows.Forms.Label()
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_1_FolioLabel
        '
        _1_FolioLabel.AutoSize = True
        _1_FolioLabel.Location = New System.Drawing.Point(795, 15)
        _1_FolioLabel.Name = "_1_FolioLabel"
        _1_FolioLabel.Size = New System.Drawing.Size(41, 13)
        _1_FolioLabel.TabIndex = 1
        _1_FolioLabel.Text = "1 Folio:"
        '
        '_2_Nombre_EmisorLabel
        '
        _2_Nombre_EmisorLabel.AutoSize = True
        _2_Nombre_EmisorLabel.Location = New System.Drawing.Point(37, 41)
        _2_Nombre_EmisorLabel.Name = "_2_Nombre_EmisorLabel"
        _2_Nombre_EmisorLabel.Size = New System.Drawing.Size(90, 13)
        _2_Nombre_EmisorLabel.TabIndex = 2
        _2_Nombre_EmisorLabel.Text = "2 Nombre Emisor:"
        '
        '_27_Serie_ComprobanteLabel
        '
        _27_Serie_ComprobanteLabel.AutoSize = True
        _27_Serie_ComprobanteLabel.Location = New System.Drawing.Point(450, 15)
        _27_Serie_ComprobanteLabel.Name = "_27_Serie_ComprobanteLabel"
        _27_Serie_ComprobanteLabel.Size = New System.Drawing.Size(115, 13)
        _27_Serie_ComprobanteLabel.TabIndex = 4
        _27_Serie_ComprobanteLabel.Text = "27 Serie Comprobante:"
        '
        '_26_VersionLabel
        '
        _26_VersionLabel.AutoSize = True
        _26_VersionLabel.Location = New System.Drawing.Point(505, 41)
        _26_VersionLabel.Name = "_26_VersionLabel"
        _26_VersionLabel.Size = New System.Drawing.Size(60, 13)
        _26_VersionLabel.TabIndex = 6
        _26_VersionLabel.Text = "26 Version:"
        '
        '_29_FormaPagoLabel
        '
        _29_FormaPagoLabel.AutoSize = True
        _29_FormaPagoLabel.Location = New System.Drawing.Point(754, 41)
        _29_FormaPagoLabel.Name = "_29_FormaPagoLabel"
        _29_FormaPagoLabel.Size = New System.Drawing.Size(82, 13)
        _29_FormaPagoLabel.TabIndex = 8
        _29_FormaPagoLabel.Text = "29 Forma Pago:"
        '
        '_30_FechaLabel
        '
        _30_FechaLabel.AutoSize = True
        _30_FechaLabel.Location = New System.Drawing.Point(72, 15)
        _30_FechaLabel.Name = "_30_FechaLabel"
        _30_FechaLabel.Size = New System.Drawing.Size(55, 13)
        _30_FechaLabel.TabIndex = 10
        _30_FechaLabel.Text = "30 Fecha:"
        '
        '_42_Nombre_ReceptorLabel
        '
        _42_Nombre_ReceptorLabel.AutoSize = True
        _42_Nombre_ReceptorLabel.Location = New System.Drawing.Point(18, 67)
        _42_Nombre_ReceptorLabel.Name = "_42_Nombre_ReceptorLabel"
        _42_Nombre_ReceptorLabel.Size = New System.Drawing.Size(109, 13)
        _42_Nombre_ReceptorLabel.TabIndex = 12
        _42_Nombre_ReceptorLabel.Text = "42 Nombre Receptor:"
        '
        '_43_RFC_ReceptorLabel
        '
        _43_RFC_ReceptorLabel.AutoSize = True
        _43_RFC_ReceptorLabel.Location = New System.Drawing.Point(472, 67)
        _43_RFC_ReceptorLabel.Name = "_43_RFC_ReceptorLabel"
        _43_RFC_ReceptorLabel.Size = New System.Drawing.Size(93, 13)
        _43_RFC_ReceptorLabel.TabIndex = 14
        _43_RFC_ReceptorLabel.Text = "43 RFC Receptor:"
        '
        '_54_Monto_SubTotalLabel
        '
        _54_Monto_SubTotalLabel.AutoSize = True
        _54_Monto_SubTotalLabel.Location = New System.Drawing.Point(23, 93)
        _54_Monto_SubTotalLabel.Name = "_54_Monto_SubTotalLabel"
        _54_Monto_SubTotalLabel.Size = New System.Drawing.Size(104, 13)
        _54_Monto_SubTotalLabel.TabIndex = 16
        _54_Monto_SubTotalLabel.Text = "54 Monto Sub Total:"
        '
        '_55_Monto_IVALabel
        '
        _55_Monto_IVALabel.AutoSize = True
        _55_Monto_IVALabel.Location = New System.Drawing.Point(266, 93)
        _55_Monto_IVALabel.Name = "_55_Monto_IVALabel"
        _55_Monto_IVALabel.Size = New System.Drawing.Size(75, 13)
        _55_Monto_IVALabel.TabIndex = 18
        _55_Monto_IVALabel.Text = "55 Monto IVA:"
        '
        '_56_Monto_TotalLabel
        '
        _56_Monto_TotalLabel.AutoSize = True
        _56_Monto_TotalLabel.Location = New System.Drawing.Point(488, 93)
        _56_Monto_TotalLabel.Name = "_56_Monto_TotalLabel"
        _56_Monto_TotalLabel.Size = New System.Drawing.Size(82, 13)
        _56_Monto_TotalLabel.TabIndex = 20
        _56_Monto_TotalLabel.Text = "56 Monto Total:"
        '
        '_144_Misc32Label
        '
        _144_Misc32Label.AutoSize = True
        _144_Misc32Label.Location = New System.Drawing.Point(62, 118)
        _144_Misc32Label.Name = "_144_Misc32Label"
        _144_Misc32Label.Size = New System.Drawing.Size(65, 13)
        _144_Misc32Label.TabIndex = 22
        _144_Misc32Label.Text = "144 Misc32:"
        '
        '_157_Misc45Label
        '
        _157_Misc45Label.AutoSize = True
        _157_Misc45Label.Location = New System.Drawing.Point(276, 118)
        _157_Misc45Label.Name = "_157_Misc45Label"
        _157_Misc45Label.Size = New System.Drawing.Size(65, 13)
        _157_Misc45Label.TabIndex = 24
        _157_Misc45Label.Text = "157 Misc45:"
        '
        '_158_Misc46Label
        '
        _158_Misc46Label.AutoSize = True
        _158_Misc46Label.Location = New System.Drawing.Point(505, 118)
        _158_Misc46Label.Name = "_158_Misc46Label"
        _158_Misc46Label.Size = New System.Drawing.Size(65, 13)
        _158_Misc46Label.TabIndex = 26
        _158_Misc46Label.Text = "158 Misc46:"
        '
        '_159_Misc47Label
        '
        _159_Misc47Label.AutoSize = True
        _159_Misc47Label.Location = New System.Drawing.Point(771, 118)
        _159_Misc47Label.Name = "_159_Misc47Label"
        _159_Misc47Label.Size = New System.Drawing.Size(65, 13)
        _159_Misc47Label.TabIndex = 28
        _159_Misc47Label.Text = "159 Misc47:"
        '
        '_192_Monto_TotalImp_RetenidosLabel
        '
        _192_Monto_TotalImp_RetenidosLabel.AutoSize = True
        _192_Monto_TotalImp_RetenidosLabel.Location = New System.Drawing.Point(42, 157)
        _192_Monto_TotalImp_RetenidosLabel.Name = "_192_Monto_TotalImp_RetenidosLabel"
        _192_Monto_TotalImp_RetenidosLabel.Size = New System.Drawing.Size(159, 13)
        _192_Monto_TotalImp_RetenidosLabel.TabIndex = 30
        _192_Monto_TotalImp_RetenidosLabel.Text = "192 Monto Total Imp Retenidos:"
        '
        '_193_Monto_TotalImp_TrasladadosLabel
        '
        _193_Monto_TotalImp_TrasladadosLabel.AutoSize = True
        _193_Monto_TotalImp_TrasladadosLabel.Location = New System.Drawing.Point(354, 157)
        _193_Monto_TotalImp_TrasladadosLabel.Name = "_193_Monto_TotalImp_TrasladadosLabel"
        _193_Monto_TotalImp_TrasladadosLabel.Size = New System.Drawing.Size(169, 13)
        _193_Monto_TotalImp_TrasladadosLabel.TabIndex = 32
        _193_Monto_TotalImp_TrasladadosLabel.Text = "193 Monto Total Imp Trasladados:"
        '
        '_114_Misc02Label
        '
        _114_Misc02Label.AutoSize = True
        _114_Misc02Label.Location = New System.Drawing.Point(771, 93)
        _114_Misc02Label.Name = "_114_Misc02Label"
        _114_Misc02Label.Size = New System.Drawing.Size(65, 13)
        _114_Misc02Label.TabIndex = 34
        _114_Misc02Label.Text = "114 Misc02:"
        '
        '_190_Metodo_PagoLabel
        '
        _190_Metodo_PagoLabel.AutoSize = True
        _190_Metodo_PagoLabel.Location = New System.Drawing.Point(741, 67)
        _190_Metodo_PagoLabel.Name = "_190_Metodo_PagoLabel"
        _190_Metodo_PagoLabel.Size = New System.Drawing.Size(95, 13)
        _190_Metodo_PagoLabel.TabIndex = 36
        _190_Metodo_PagoLabel.Text = "190 Metodo Pago:"
        '
        '_191_Efecto_ComprobanteLabel
        '
        _191_Efecto_ComprobanteLabel.AutoSize = True
        _191_Efecto_ComprobanteLabel.Location = New System.Drawing.Point(708, 157)
        _191_Efecto_ComprobanteLabel.Name = "_191_Efecto_ComprobanteLabel"
        _191_Efecto_ComprobanteLabel.Size = New System.Drawing.Size(128, 13)
        _191_Efecto_ComprobanteLabel.TabIndex = 38
        _191_Efecto_ComprobanteLabel.Text = "191 Efecto Comprobante:"
        '
        'GuidLabel
        '
        GuidLabel.AutoSize = True
        GuidLabel.Location = New System.Drawing.Point(482, 199)
        GuidLabel.Name = "GuidLabel"
        GuidLabel.Size = New System.Drawing.Size(32, 13)
        GuidLabel.TabIndex = 40
        GuidLabel.Text = "Guid:"
        '
        '_1_FolioTextBox
        '
        Me._1_FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "1_Folio", True))
        Me._1_FolioTextBox.Location = New System.Drawing.Point(842, 12)
        Me._1_FolioTextBox.Name = "_1_FolioTextBox"
        Me._1_FolioTextBox.ReadOnly = True
        Me._1_FolioTextBox.Size = New System.Drawing.Size(100, 20)
        Me._1_FolioTextBox.TabIndex = 2
        '
        '_2_Nombre_EmisorTextBox
        '
        Me._2_Nombre_EmisorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "2_Nombre_Emisor", True))
        Me._2_Nombre_EmisorTextBox.Location = New System.Drawing.Point(133, 38)
        Me._2_Nombre_EmisorTextBox.Name = "_2_Nombre_EmisorTextBox"
        Me._2_Nombre_EmisorTextBox.ReadOnly = True
        Me._2_Nombre_EmisorTextBox.Size = New System.Drawing.Size(261, 20)
        Me._2_Nombre_EmisorTextBox.TabIndex = 3
        '
        '_27_Serie_ComprobanteTextBox
        '
        Me._27_Serie_ComprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "27_Serie_Comprobante", True))
        Me._27_Serie_ComprobanteTextBox.Location = New System.Drawing.Point(576, 12)
        Me._27_Serie_ComprobanteTextBox.Name = "_27_Serie_ComprobanteTextBox"
        Me._27_Serie_ComprobanteTextBox.ReadOnly = True
        Me._27_Serie_ComprobanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me._27_Serie_ComprobanteTextBox.TabIndex = 5
        '
        '_26_VersionTextBox
        '
        Me._26_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "26_Version", True))
        Me._26_VersionTextBox.Location = New System.Drawing.Point(576, 38)
        Me._26_VersionTextBox.Name = "_26_VersionTextBox"
        Me._26_VersionTextBox.ReadOnly = True
        Me._26_VersionTextBox.Size = New System.Drawing.Size(100, 20)
        Me._26_VersionTextBox.TabIndex = 7
        '
        '_29_FormaPagoTextBox
        '
        Me._29_FormaPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "29_FormaPago", True))
        Me._29_FormaPagoTextBox.Location = New System.Drawing.Point(842, 38)
        Me._29_FormaPagoTextBox.Name = "_29_FormaPagoTextBox"
        Me._29_FormaPagoTextBox.ReadOnly = True
        Me._29_FormaPagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me._29_FormaPagoTextBox.TabIndex = 9
        '
        '_30_FechaTextBox
        '
        Me._30_FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "30_Fecha", True))
        Me._30_FechaTextBox.Location = New System.Drawing.Point(133, 12)
        Me._30_FechaTextBox.Name = "_30_FechaTextBox"
        Me._30_FechaTextBox.ReadOnly = True
        Me._30_FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me._30_FechaTextBox.TabIndex = 11
        '
        '_42_Nombre_ReceptorTextBox
        '
        Me._42_Nombre_ReceptorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "42_Nombre_Receptor", True))
        Me._42_Nombre_ReceptorTextBox.Location = New System.Drawing.Point(133, 64)
        Me._42_Nombre_ReceptorTextBox.Name = "_42_Nombre_ReceptorTextBox"
        Me._42_Nombre_ReceptorTextBox.ReadOnly = True
        Me._42_Nombre_ReceptorTextBox.Size = New System.Drawing.Size(261, 20)
        Me._42_Nombre_ReceptorTextBox.TabIndex = 13
        '
        '_43_RFC_ReceptorTextBox
        '
        Me._43_RFC_ReceptorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "43_RFC_Receptor", True))
        Me._43_RFC_ReceptorTextBox.Location = New System.Drawing.Point(576, 64)
        Me._43_RFC_ReceptorTextBox.Name = "_43_RFC_ReceptorTextBox"
        Me._43_RFC_ReceptorTextBox.ReadOnly = True
        Me._43_RFC_ReceptorTextBox.Size = New System.Drawing.Size(100, 20)
        Me._43_RFC_ReceptorTextBox.TabIndex = 15
        '
        '_54_Monto_SubTotalTextBox
        '
        Me._54_Monto_SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "54_Monto_SubTotal", True))
        Me._54_Monto_SubTotalTextBox.Location = New System.Drawing.Point(133, 90)
        Me._54_Monto_SubTotalTextBox.Name = "_54_Monto_SubTotalTextBox"
        Me._54_Monto_SubTotalTextBox.ReadOnly = True
        Me._54_Monto_SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me._54_Monto_SubTotalTextBox.TabIndex = 17
        '
        '_55_Monto_IVATextBox
        '
        Me._55_Monto_IVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "55_Monto_IVA", True))
        Me._55_Monto_IVATextBox.Location = New System.Drawing.Point(347, 90)
        Me._55_Monto_IVATextBox.Name = "_55_Monto_IVATextBox"
        Me._55_Monto_IVATextBox.ReadOnly = True
        Me._55_Monto_IVATextBox.Size = New System.Drawing.Size(100, 20)
        Me._55_Monto_IVATextBox.TabIndex = 19
        '
        '_56_Monto_TotalTextBox
        '
        Me._56_Monto_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "56_Monto_Total", True))
        Me._56_Monto_TotalTextBox.Location = New System.Drawing.Point(576, 90)
        Me._56_Monto_TotalTextBox.Name = "_56_Monto_TotalTextBox"
        Me._56_Monto_TotalTextBox.ReadOnly = True
        Me._56_Monto_TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me._56_Monto_TotalTextBox.TabIndex = 21
        '
        '_144_Misc32TextBox
        '
        Me._144_Misc32TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "144_Misc32", True))
        Me._144_Misc32TextBox.Location = New System.Drawing.Point(133, 115)
        Me._144_Misc32TextBox.Name = "_144_Misc32TextBox"
        Me._144_Misc32TextBox.ReadOnly = True
        Me._144_Misc32TextBox.Size = New System.Drawing.Size(100, 20)
        Me._144_Misc32TextBox.TabIndex = 23
        '
        '_157_Misc45TextBox
        '
        Me._157_Misc45TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "157_Misc45", True))
        Me._157_Misc45TextBox.Location = New System.Drawing.Point(347, 115)
        Me._157_Misc45TextBox.Name = "_157_Misc45TextBox"
        Me._157_Misc45TextBox.ReadOnly = True
        Me._157_Misc45TextBox.Size = New System.Drawing.Size(100, 20)
        Me._157_Misc45TextBox.TabIndex = 25
        '
        '_158_Misc46TextBox
        '
        Me._158_Misc46TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "158_Misc46", True))
        Me._158_Misc46TextBox.Location = New System.Drawing.Point(576, 115)
        Me._158_Misc46TextBox.Name = "_158_Misc46TextBox"
        Me._158_Misc46TextBox.ReadOnly = True
        Me._158_Misc46TextBox.Size = New System.Drawing.Size(100, 20)
        Me._158_Misc46TextBox.TabIndex = 27
        '
        '_159_Misc47TextBox
        '
        Me._159_Misc47TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "159_Misc47", True))
        Me._159_Misc47TextBox.Location = New System.Drawing.Point(842, 115)
        Me._159_Misc47TextBox.Name = "_159_Misc47TextBox"
        Me._159_Misc47TextBox.ReadOnly = True
        Me._159_Misc47TextBox.Size = New System.Drawing.Size(100, 20)
        Me._159_Misc47TextBox.TabIndex = 29
        '
        '_192_Monto_TotalImp_RetenidosTextBox
        '
        Me._192_Monto_TotalImp_RetenidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "192_Monto_TotalImp_Retenidos", True))
        Me._192_Monto_TotalImp_RetenidosTextBox.Location = New System.Drawing.Point(207, 154)
        Me._192_Monto_TotalImp_RetenidosTextBox.Name = "_192_Monto_TotalImp_RetenidosTextBox"
        Me._192_Monto_TotalImp_RetenidosTextBox.ReadOnly = True
        Me._192_Monto_TotalImp_RetenidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me._192_Monto_TotalImp_RetenidosTextBox.TabIndex = 31
        '
        '_193_Monto_TotalImp_TrasladadosTextBox
        '
        Me._193_Monto_TotalImp_TrasladadosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "193_Monto_TotalImp_Trasladados", True))
        Me._193_Monto_TotalImp_TrasladadosTextBox.Location = New System.Drawing.Point(529, 154)
        Me._193_Monto_TotalImp_TrasladadosTextBox.Name = "_193_Monto_TotalImp_TrasladadosTextBox"
        Me._193_Monto_TotalImp_TrasladadosTextBox.ReadOnly = True
        Me._193_Monto_TotalImp_TrasladadosTextBox.Size = New System.Drawing.Size(100, 20)
        Me._193_Monto_TotalImp_TrasladadosTextBox.TabIndex = 33
        '
        '_114_Misc02TextBox
        '
        Me._114_Misc02TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "114_Misc02", True))
        Me._114_Misc02TextBox.Location = New System.Drawing.Point(842, 90)
        Me._114_Misc02TextBox.Name = "_114_Misc02TextBox"
        Me._114_Misc02TextBox.ReadOnly = True
        Me._114_Misc02TextBox.Size = New System.Drawing.Size(100, 20)
        Me._114_Misc02TextBox.TabIndex = 35
        '
        '_190_Metodo_PagoTextBox
        '
        Me._190_Metodo_PagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "190_Metodo_Pago", True))
        Me._190_Metodo_PagoTextBox.Location = New System.Drawing.Point(842, 64)
        Me._190_Metodo_PagoTextBox.Name = "_190_Metodo_PagoTextBox"
        Me._190_Metodo_PagoTextBox.ReadOnly = True
        Me._190_Metodo_PagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me._190_Metodo_PagoTextBox.TabIndex = 37
        '
        '_191_Efecto_ComprobanteTextBox
        '
        Me._191_Efecto_ComprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "191_Efecto_Comprobante", True))
        Me._191_Efecto_ComprobanteTextBox.Location = New System.Drawing.Point(842, 154)
        Me._191_Efecto_ComprobanteTextBox.Name = "_191_Efecto_ComprobanteTextBox"
        Me._191_Efecto_ComprobanteTextBox.ReadOnly = True
        Me._191_Efecto_ComprobanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me._191_Efecto_ComprobanteTextBox.TabIndex = 39
        '
        'GuidTextBox
        '
        Me.GuidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_EncabezadoBindingSource, "Guid", True))
        Me.GuidTextBox.Location = New System.Drawing.Point(520, 196)
        Me.GuidTextBox.Name = "GuidTextBox"
        Me.GuidTextBox.ReadOnly = True
        Me.GuidTextBox.Size = New System.Drawing.Size(422, 20)
        Me.GuidTextBox.TabIndex = 41
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(195, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(146, 36)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar CFDI"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(867, 222)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.CFDI_EncabezadoTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lector_XML.ATEBCOFIDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDetalleCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 256)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(GuidLabel)
        Me.Controls.Add(Me.GuidTextBox)
        Me.Controls.Add(_191_Efecto_ComprobanteLabel)
        Me.Controls.Add(Me._191_Efecto_ComprobanteTextBox)
        Me.Controls.Add(_190_Metodo_PagoLabel)
        Me.Controls.Add(Me._190_Metodo_PagoTextBox)
        Me.Controls.Add(_114_Misc02Label)
        Me.Controls.Add(Me._114_Misc02TextBox)
        Me.Controls.Add(_193_Monto_TotalImp_TrasladadosLabel)
        Me.Controls.Add(Me._193_Monto_TotalImp_TrasladadosTextBox)
        Me.Controls.Add(_192_Monto_TotalImp_RetenidosLabel)
        Me.Controls.Add(Me._192_Monto_TotalImp_RetenidosTextBox)
        Me.Controls.Add(_159_Misc47Label)
        Me.Controls.Add(Me._159_Misc47TextBox)
        Me.Controls.Add(_158_Misc46Label)
        Me.Controls.Add(Me._158_Misc46TextBox)
        Me.Controls.Add(_157_Misc45Label)
        Me.Controls.Add(Me._157_Misc45TextBox)
        Me.Controls.Add(_144_Misc32Label)
        Me.Controls.Add(Me._144_Misc32TextBox)
        Me.Controls.Add(_56_Monto_TotalLabel)
        Me.Controls.Add(Me._56_Monto_TotalTextBox)
        Me.Controls.Add(_55_Monto_IVALabel)
        Me.Controls.Add(Me._55_Monto_IVATextBox)
        Me.Controls.Add(_54_Monto_SubTotalLabel)
        Me.Controls.Add(Me._54_Monto_SubTotalTextBox)
        Me.Controls.Add(_43_RFC_ReceptorLabel)
        Me.Controls.Add(Me._43_RFC_ReceptorTextBox)
        Me.Controls.Add(_42_Nombre_ReceptorLabel)
        Me.Controls.Add(Me._42_Nombre_ReceptorTextBox)
        Me.Controls.Add(_30_FechaLabel)
        Me.Controls.Add(Me._30_FechaTextBox)
        Me.Controls.Add(_29_FormaPagoLabel)
        Me.Controls.Add(Me._29_FormaPagoTextBox)
        Me.Controls.Add(_26_VersionLabel)
        Me.Controls.Add(Me._26_VersionTextBox)
        Me.Controls.Add(_27_Serie_ComprobanteLabel)
        Me.Controls.Add(Me._27_Serie_ComprobanteTextBox)
        Me.Controls.Add(_2_Nombre_EmisorLabel)
        Me.Controls.Add(Me._2_Nombre_EmisorTextBox)
        Me.Controls.Add(_1_FolioLabel)
        Me.Controls.Add(Me._1_FolioTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDetalleCFDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del CFDI a cancelar"
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATEBCOFIDIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ATEBCOFIDIDataSet As ATEBCOFIDIDataSet
    Friend WithEvents CFDI_EncabezadoBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CFDI_EncabezadoTableAdapter As ATEBCOFIDIDataSetTableAdapters.CFDI_EncabezadoTableAdapter
    Friend WithEvents TableAdapterManager As ATEBCOFIDIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents _1_FolioTextBox As Windows.Forms.TextBox
    Friend WithEvents _2_Nombre_EmisorTextBox As Windows.Forms.TextBox
    Friend WithEvents _27_Serie_ComprobanteTextBox As Windows.Forms.TextBox
    Friend WithEvents _26_VersionTextBox As Windows.Forms.TextBox
    Friend WithEvents _29_FormaPagoTextBox As Windows.Forms.TextBox
    Friend WithEvents _30_FechaTextBox As Windows.Forms.TextBox
    Friend WithEvents _42_Nombre_ReceptorTextBox As Windows.Forms.TextBox
    Friend WithEvents _43_RFC_ReceptorTextBox As Windows.Forms.TextBox
    Friend WithEvents _54_Monto_SubTotalTextBox As Windows.Forms.TextBox
    Friend WithEvents _55_Monto_IVATextBox As Windows.Forms.TextBox
    Friend WithEvents _56_Monto_TotalTextBox As Windows.Forms.TextBox
    Friend WithEvents _144_Misc32TextBox As Windows.Forms.TextBox
    Friend WithEvents _157_Misc45TextBox As Windows.Forms.TextBox
    Friend WithEvents _158_Misc46TextBox As Windows.Forms.TextBox
    Friend WithEvents _159_Misc47TextBox As Windows.Forms.TextBox
    Friend WithEvents _192_Monto_TotalImp_RetenidosTextBox As Windows.Forms.TextBox
    Friend WithEvents _193_Monto_TotalImp_TrasladadosTextBox As Windows.Forms.TextBox
    Friend WithEvents _114_Misc02TextBox As Windows.Forms.TextBox
    Friend WithEvents _190_Metodo_PagoTextBox As Windows.Forms.TextBox
    Friend WithEvents _191_Efecto_ComprobanteTextBox As Windows.Forms.TextBox
    Friend WithEvents GuidTextBox As Windows.Forms.TextBox
    Friend WithEvents btnCancelar As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
End Class
