<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedoresImportacionXLS
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedoresImportacionXLS))
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.btnEjecutar = New System.Windows.Forms.Button()
		Me.chkTelefono = New System.Windows.Forms.CheckBox()
		Me.nudNumeroSAP = New System.Windows.Forms.NumericUpDown()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.nudTelefono = New System.Windows.Forms.NumericUpDown()
		Me.nudCUIT = New System.Windows.Forms.NumericUpDown()
		Me.lblNumeroBono = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.nudFilaInicial = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.nudHoja = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnArchivo = New System.Windows.Forms.Button()
		Me.txtArchivo = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbEntidadCategoria = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cbEntidadSubcategoria = New System.Windows.Forms.ComboBox()
		Me.nudRazonSocial1 = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.chkEmail = New System.Windows.Forms.CheckBox()
		Me.nudEmail = New System.Windows.Forms.NumericUpDown()
		Me.chkDomicilio = New System.Windows.Forms.CheckBox()
		Me.nudDomicilio = New System.Windows.Forms.NumericUpDown()
		Me.chkCategotia = New System.Windows.Forms.CheckBox()
		Me.nudCategotia = New System.Windows.Forms.NumericUpDown()
		Me.chkCBU = New System.Windows.Forms.CheckBox()
		Me.nudCBU = New System.Windows.Forms.NumericUpDown()
		Me.chkNumeroCuenta = New System.Windows.Forms.CheckBox()
		Me.nudNumeroCuenta = New System.Windows.Forms.NumericUpDown()
		Me.chkSubcategoria = New System.Windows.Forms.CheckBox()
		Me.nudSubcategoria = New System.Windows.Forms.NumericUpDown()
		Me.chkDiasVencimiento = New System.Windows.Forms.CheckBox()
		Me.nudDiasVencimiento = New System.Windows.Forms.NumericUpDown()
		Me.nudRazonSocial2 = New System.Windows.Forms.NumericUpDown()
		Me.ssBarraEstado.SuspendLayout()
		CType(Me.nudNumeroSAP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCUIT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudFilaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudHoja, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRazonSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudEmail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCategotia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCBU, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudSubcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDiasVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRazonSocial2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Iconos
		'
		Me.Iconos.ImageStream = CType(resources.GetObject("Iconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.Iconos.TransparentColor = System.Drawing.Color.Transparent
		Me.Iconos.Images.SetKeyName(0, "Agregar")
		Me.Iconos.Images.SetKeyName(1, "Editar")
		Me.Iconos.Images.SetKeyName(2, "Quitar")
		Me.Iconos.Images.SetKeyName(3, "Guardar")
		Me.Iconos.Images.SetKeyName(4, "Cancelar")
		Me.Iconos.Images.SetKeyName(5, "Aceptar")
		Me.Iconos.Images.SetKeyName(6, "Filtrar")
		Me.Iconos.Images.SetKeyName(7, "Buscar")
		Me.Iconos.Images.SetKeyName(8, "Ver")
		Me.Iconos.Images.SetKeyName(9, "Imprimir")
		Me.Iconos.Images.SetKeyName(10, "Configuracion")
		Me.Iconos.Images.SetKeyName(11, "Cerrar")
		Me.Iconos.Images.SetKeyName(12, "Exclamacion")
		Me.Iconos.Images.SetKeyName(13, "Precaucion")
		Me.Iconos.Images.SetKeyName(14, "Ayuda")
		Me.Iconos.Images.SetKeyName(15, "Funcion")
		Me.Iconos.Images.SetKeyName(16, "Notas")
		Me.Iconos.Images.SetKeyName(17, "Categorias")
		Me.Iconos.Images.SetKeyName(18, "Tablas")
		Me.Iconos.Images.SetKeyName(19, "Excel")
		Me.Iconos.Images.SetKeyName(20, "Ejecutar")
		Me.Iconos.Images.SetKeyName(21, "Carpeta")
		Me.Iconos.Images.SetKeyName(22, "Filtro")
		Me.Iconos.Images.SetKeyName(23, "Copiar")
		Me.Iconos.Images.SetKeyName(24, "Pegar")
		Me.Iconos.Images.SetKeyName(25, "Usuario")
		Me.Iconos.Images.SetKeyName(26, "Entidad")
		Me.Iconos.Images.SetKeyName(27, "Subir")
		Me.Iconos.Images.SetKeyName(28, "Bajar")
		Me.Iconos.Images.SetKeyName(29, "Tipo")
		Me.Iconos.Images.SetKeyName(30, "BorrarFecha")
		Me.Iconos.Images.SetKeyName(31, "AgregarFoto")
		Me.Iconos.Images.SetKeyName(32, "QuitarFoto")
		Me.Iconos.Images.SetKeyName(33, "Parametros")
		Me.Iconos.Images.SetKeyName(34, "Personas")
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 507)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(455, 22)
		Me.ssBarraEstado.SizingGrip = False
		Me.ssBarraEstado.TabIndex = 57
		'
		'pbBarraProgreso
		'
		Me.pbBarraProgreso.Name = "pbBarraProgreso"
		Me.pbBarraProgreso.Size = New System.Drawing.Size(100, 16)
		Me.pbBarraProgreso.Visible = False
		'
		'lblMensajeProgreso
		'
		Me.lblMensajeProgreso.ForeColor = System.Drawing.Color.Blue
		Me.lblMensajeProgreso.Name = "lblMensajeProgreso"
		Me.lblMensajeProgreso.Size = New System.Drawing.Size(0, 17)
		'
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(414, 474)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 116
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'btnEjecutar
		'
		Me.btnEjecutar.ImageKey = "Ejecutar"
		Me.btnEjecutar.ImageList = Me.Iconos
		Me.btnEjecutar.Location = New System.Drawing.Point(194, 391)
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(30, 30)
		Me.btnEjecutar.TabIndex = 115
		Me.btnEjecutar.UseVisualStyleBackColor = True
		'
		'chkTelefono
		'
		Me.chkTelefono.AutoSize = True
		Me.chkTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkTelefono.Location = New System.Drawing.Point(119, 313)
		Me.chkTelefono.Name = "chkTelefono"
		Me.chkTelefono.Size = New System.Drawing.Size(71, 17)
		Me.chkTelefono.TabIndex = 108
		Me.chkTelefono.Text = "Teléfono:"
		Me.chkTelefono.UseVisualStyleBackColor = True
		'
		'nudNumeroSAP
		'
		Me.nudNumeroSAP.Location = New System.Drawing.Point(194, 205)
		Me.nudNumeroSAP.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudNumeroSAP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudNumeroSAP.Name = "nudNumeroSAP"
		Me.nudNumeroSAP.Size = New System.Drawing.Size(46, 20)
		Me.nudNumeroSAP.TabIndex = 106
		Me.nudNumeroSAP.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(116, 209)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(46, 13)
		Me.Label12.TabIndex = 107
		Me.Label12.Text = "N° SAP:"
		'
		'nudTelefono
		'
		Me.nudTelefono.Enabled = False
		Me.nudTelefono.Location = New System.Drawing.Point(194, 311)
		Me.nudTelefono.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudTelefono.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudTelefono.Name = "nudTelefono"
		Me.nudTelefono.Size = New System.Drawing.Size(46, 20)
		Me.nudTelefono.TabIndex = 105
		Me.nudTelefono.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'nudCUIT
		'
		Me.nudCUIT.Location = New System.Drawing.Point(194, 232)
		Me.nudCUIT.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudCUIT.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCUIT.Name = "nudCUIT"
		Me.nudCUIT.Size = New System.Drawing.Size(46, 20)
		Me.nudCUIT.TabIndex = 103
		Me.nudCUIT.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'lblNumeroBono
		'
		Me.lblNumeroBono.AutoSize = True
		Me.lblNumeroBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumeroBono.Location = New System.Drawing.Point(116, 236)
		Me.lblNumeroBono.Name = "lblNumeroBono"
		Me.lblNumeroBono.Size = New System.Drawing.Size(35, 13)
		Me.lblNumeroBono.TabIndex = 104
		Me.lblNumeroBono.Text = "CUIT:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(16, 183)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(100, 13)
		Me.Label10.TabIndex = 102
		Me.Label10.Text = "Columnas de datos:"
		'
		'nudFilaInicial
		'
		Me.nudFilaInicial.Location = New System.Drawing.Point(279, 55)
		Me.nudFilaInicial.Maximum = New Decimal(New Integer() {1048576, 0, 0, 0})
		Me.nudFilaInicial.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudFilaInicial.Name = "nudFilaInicial"
		Me.nudFilaInicial.Size = New System.Drawing.Size(46, 20)
		Me.nudFilaInicial.TabIndex = 100
		Me.nudFilaInicial.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(218, 59)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(55, 13)
		Me.Label5.TabIndex = 101
		Me.Label5.Text = "Fila inicial:"
		'
		'nudHoja
		'
		Me.nudHoja.Location = New System.Drawing.Point(109, 55)
		Me.nudHoja.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.nudHoja.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudHoja.Name = "nudHoja"
		Me.nudHoja.Size = New System.Drawing.Size(46, 20)
		Me.nudHoja.TabIndex = 98
		Me.nudHoja.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(21, 59)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(82, 13)
		Me.Label8.TabIndex = 99
		Me.Label8.Text = "Hoja con datos:"
		'
		'btnArchivo
		'
		Me.btnArchivo.ImageKey = "Excel"
		Me.btnArchivo.ImageList = Me.Iconos
		Me.btnArchivo.Location = New System.Drawing.Point(414, 13)
		Me.btnArchivo.Name = "btnArchivo"
		Me.btnArchivo.Size = New System.Drawing.Size(30, 30)
		Me.btnArchivo.TabIndex = 95
		Me.btnArchivo.UseVisualStyleBackColor = True
		'
		'txtArchivo
		'
		Me.txtArchivo.ForeColor = System.Drawing.Color.Blue
		Me.txtArchivo.Location = New System.Drawing.Point(73, 18)
		Me.txtArchivo.Name = "txtArchivo"
		Me.txtArchivo.ReadOnly = True
		Me.txtArchivo.Size = New System.Drawing.Size(335, 20)
		Me.txtArchivo.TabIndex = 97
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(21, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 96
		Me.Label1.Text = "Archivo:"
		'
		'cbEntidadCategoria
		'
		Me.cbEntidadCategoria.FormattingEnabled = True
		Me.cbEntidadCategoria.Location = New System.Drawing.Point(143, 101)
		Me.cbEntidadCategoria.Name = "cbEntidadCategoria"
		Me.cbEntidadCategoria.Size = New System.Drawing.Size(182, 21)
		Me.cbEntidadCategoria.TabIndex = 111
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(16, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(121, 13)
		Me.Label3.TabIndex = 117
		Me.Label3.Text = "Entidad de la categoría:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(16, 144)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(138, 13)
		Me.Label4.TabIndex = 119
		Me.Label4.Text = "Entidad de la subcategoría:"
		'
		'cbEntidadSubcategoria
		'
		Me.cbEntidadSubcategoria.FormattingEnabled = True
		Me.cbEntidadSubcategoria.Location = New System.Drawing.Point(160, 141)
		Me.cbEntidadSubcategoria.Name = "cbEntidadSubcategoria"
		Me.cbEntidadSubcategoria.Size = New System.Drawing.Size(182, 21)
		Me.cbEntidadSubcategoria.TabIndex = 118
		'
		'nudRazonSocial1
		'
		Me.nudRazonSocial1.Location = New System.Drawing.Point(194, 259)
		Me.nudRazonSocial1.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudRazonSocial1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudRazonSocial1.Name = "nudRazonSocial1"
		Me.nudRazonSocial1.Size = New System.Drawing.Size(46, 20)
		Me.nudRazonSocial1.TabIndex = 120
		Me.nudRazonSocial1.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(117, 275)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(71, 13)
		Me.Label2.TabIndex = 121
		Me.Label2.Text = "Razón social:"
		'
		'chkEmail
		'
		Me.chkEmail.AutoSize = True
		Me.chkEmail.Checked = True
		Me.chkEmail.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkEmail.Location = New System.Drawing.Point(119, 340)
		Me.chkEmail.Name = "chkEmail"
		Me.chkEmail.Size = New System.Drawing.Size(57, 17)
		Me.chkEmail.TabIndex = 123
		Me.chkEmail.Text = "E-mail:"
		Me.chkEmail.UseVisualStyleBackColor = True
		'
		'nudEmail
		'
		Me.nudEmail.Enabled = False
		Me.nudEmail.Location = New System.Drawing.Point(194, 338)
		Me.nudEmail.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudEmail.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudEmail.Name = "nudEmail"
		Me.nudEmail.Size = New System.Drawing.Size(46, 20)
		Me.nudEmail.TabIndex = 122
		Me.nudEmail.Value = New Decimal(New Integer() {16, 0, 0, 0})
		'
		'chkDomicilio
		'
		Me.chkDomicilio.AutoSize = True
		Me.chkDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDomicilio.Location = New System.Drawing.Point(257, 204)
		Me.chkDomicilio.Name = "chkDomicilio"
		Me.chkDomicilio.Size = New System.Drawing.Size(71, 17)
		Me.chkDomicilio.TabIndex = 125
		Me.chkDomicilio.Text = "Domicilio:"
		Me.chkDomicilio.UseVisualStyleBackColor = True
		'
		'nudDomicilio
		'
		Me.nudDomicilio.Enabled = False
		Me.nudDomicilio.Location = New System.Drawing.Point(386, 202)
		Me.nudDomicilio.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudDomicilio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudDomicilio.Name = "nudDomicilio"
		Me.nudDomicilio.Size = New System.Drawing.Size(46, 20)
		Me.nudDomicilio.TabIndex = 124
		Me.nudDomicilio.Value = New Decimal(New Integer() {101, 0, 0, 0})
		'
		'chkCategotia
		'
		Me.chkCategotia.AutoSize = True
		Me.chkCategotia.Checked = True
		Me.chkCategotia.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkCategotia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCategotia.Location = New System.Drawing.Point(257, 287)
		Me.chkCategotia.Name = "chkCategotia"
		Me.chkCategotia.Size = New System.Drawing.Size(76, 17)
		Me.chkCategotia.TabIndex = 131
		Me.chkCategotia.Text = "Categoría:"
		Me.chkCategotia.UseVisualStyleBackColor = True
		'
		'nudCategotia
		'
		Me.nudCategotia.Enabled = False
		Me.nudCategotia.Location = New System.Drawing.Point(386, 285)
		Me.nudCategotia.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudCategotia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCategotia.Name = "nudCategotia"
		Me.nudCategotia.Size = New System.Drawing.Size(46, 20)
		Me.nudCategotia.TabIndex = 130
		Me.nudCategotia.Value = New Decimal(New Integer() {11, 0, 0, 0})
		'
		'chkCBU
		'
		Me.chkCBU.AutoSize = True
		Me.chkCBU.Checked = True
		Me.chkCBU.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkCBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCBU.Location = New System.Drawing.Point(257, 260)
		Me.chkCBU.Name = "chkCBU"
		Me.chkCBU.Size = New System.Drawing.Size(51, 17)
		Me.chkCBU.TabIndex = 129
		Me.chkCBU.Text = "CBU:"
		Me.chkCBU.UseVisualStyleBackColor = True
		'
		'nudCBU
		'
		Me.nudCBU.Enabled = False
		Me.nudCBU.Location = New System.Drawing.Point(386, 258)
		Me.nudCBU.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudCBU.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCBU.Name = "nudCBU"
		Me.nudCBU.Size = New System.Drawing.Size(46, 20)
		Me.nudCBU.TabIndex = 128
		Me.nudCBU.Value = New Decimal(New Integer() {15, 0, 0, 0})
		'
		'chkNumeroCuenta
		'
		Me.chkNumeroCuenta.AutoSize = True
		Me.chkNumeroCuenta.Checked = True
		Me.chkNumeroCuenta.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkNumeroCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkNumeroCuenta.Location = New System.Drawing.Point(257, 233)
		Me.chkNumeroCuenta.Name = "chkNumeroCuenta"
		Me.chkNumeroCuenta.Size = New System.Drawing.Size(92, 17)
		Me.chkNumeroCuenta.TabIndex = 127
		Me.chkNumeroCuenta.Text = "N° de cuenta:"
		Me.chkNumeroCuenta.UseVisualStyleBackColor = True
		'
		'nudNumeroCuenta
		'
		Me.nudNumeroCuenta.Enabled = False
		Me.nudNumeroCuenta.Location = New System.Drawing.Point(386, 231)
		Me.nudNumeroCuenta.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudNumeroCuenta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudNumeroCuenta.Name = "nudNumeroCuenta"
		Me.nudNumeroCuenta.Size = New System.Drawing.Size(46, 20)
		Me.nudNumeroCuenta.TabIndex = 126
		Me.nudNumeroCuenta.Value = New Decimal(New Integer() {14, 0, 0, 0})
		'
		'chkSubcategoria
		'
		Me.chkSubcategoria.AutoSize = True
		Me.chkSubcategoria.Checked = True
		Me.chkSubcategoria.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkSubcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSubcategoria.Location = New System.Drawing.Point(257, 314)
		Me.chkSubcategoria.Name = "chkSubcategoria"
		Me.chkSubcategoria.Size = New System.Drawing.Size(94, 17)
		Me.chkSubcategoria.TabIndex = 133
		Me.chkSubcategoria.Text = "Subcategoría:"
		Me.chkSubcategoria.UseVisualStyleBackColor = True
		'
		'nudSubcategoria
		'
		Me.nudSubcategoria.Enabled = False
		Me.nudSubcategoria.Location = New System.Drawing.Point(386, 312)
		Me.nudSubcategoria.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudSubcategoria.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudSubcategoria.Name = "nudSubcategoria"
		Me.nudSubcategoria.Size = New System.Drawing.Size(46, 20)
		Me.nudSubcategoria.TabIndex = 132
		Me.nudSubcategoria.Value = New Decimal(New Integer() {9, 0, 0, 0})
		'
		'chkDiasVencimiento
		'
		Me.chkDiasVencimiento.AutoSize = True
		Me.chkDiasVencimiento.Checked = True
		Me.chkDiasVencimiento.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkDiasVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDiasVencimiento.Location = New System.Drawing.Point(257, 341)
		Me.chkDiasVencimiento.Name = "chkDiasVencimiento"
		Me.chkDiasVencimiento.Size = New System.Drawing.Size(127, 17)
		Me.chkDiasVencimiento.TabIndex = 135
		Me.chkDiasVencimiento.Text = "Días de vencimiento:"
		Me.chkDiasVencimiento.UseVisualStyleBackColor = True
		'
		'nudDiasVencimiento
		'
		Me.nudDiasVencimiento.Enabled = False
		Me.nudDiasVencimiento.Location = New System.Drawing.Point(386, 339)
		Me.nudDiasVencimiento.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudDiasVencimiento.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudDiasVencimiento.Name = "nudDiasVencimiento"
		Me.nudDiasVencimiento.Size = New System.Drawing.Size(46, 20)
		Me.nudDiasVencimiento.TabIndex = 134
		Me.nudDiasVencimiento.Value = New Decimal(New Integer() {13, 0, 0, 0})
		'
		'nudRazonSocial2
		'
		Me.nudRazonSocial2.Location = New System.Drawing.Point(194, 284)
		Me.nudRazonSocial2.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudRazonSocial2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudRazonSocial2.Name = "nudRazonSocial2"
		Me.nudRazonSocial2.Size = New System.Drawing.Size(46, 20)
		Me.nudRazonSocial2.TabIndex = 136
		Me.nudRazonSocial2.Value = New Decimal(New Integer() {3, 0, 0, 0})
		'
		'frmProveedoresImportacionXLS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(455, 529)
		Me.Controls.Add(Me.nudRazonSocial2)
		Me.Controls.Add(Me.chkDiasVencimiento)
		Me.Controls.Add(Me.nudDiasVencimiento)
		Me.Controls.Add(Me.chkSubcategoria)
		Me.Controls.Add(Me.nudSubcategoria)
		Me.Controls.Add(Me.chkCategotia)
		Me.Controls.Add(Me.nudCategotia)
		Me.Controls.Add(Me.chkCBU)
		Me.Controls.Add(Me.nudCBU)
		Me.Controls.Add(Me.chkNumeroCuenta)
		Me.Controls.Add(Me.nudNumeroCuenta)
		Me.Controls.Add(Me.chkDomicilio)
		Me.Controls.Add(Me.nudDomicilio)
		Me.Controls.Add(Me.chkEmail)
		Me.Controls.Add(Me.nudEmail)
		Me.Controls.Add(Me.nudRazonSocial1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.cbEntidadSubcategoria)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnEjecutar)
		Me.Controls.Add(Me.cbEntidadCategoria)
		Me.Controls.Add(Me.chkTelefono)
		Me.Controls.Add(Me.nudNumeroSAP)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.nudTelefono)
		Me.Controls.Add(Me.nudCUIT)
		Me.Controls.Add(Me.lblNumeroBono)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.nudFilaInicial)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.nudHoja)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnArchivo)
		Me.Controls.Add(Me.txtArchivo)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.Name = "frmProveedoresImportacionXLS"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Importación de proveedores desde XLS"
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		CType(Me.nudNumeroSAP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTelefono, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCUIT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudFilaInicial, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudHoja, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRazonSocial1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudEmail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCategotia, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCBU, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudSubcategoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDiasVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRazonSocial2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Iconos As ImageList
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents btnCerrar As Button
	Friend WithEvents btnEjecutar As Button
	Friend WithEvents chkTelefono As CheckBox
	Friend WithEvents nudNumeroSAP As NumericUpDown
	Friend WithEvents Label12 As Label
	Friend WithEvents nudTelefono As NumericUpDown
	Friend WithEvents nudCUIT As NumericUpDown
	Friend WithEvents lblNumeroBono As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents nudFilaInicial As NumericUpDown
	Friend WithEvents Label5 As Label
	Friend WithEvents nudHoja As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents btnArchivo As Button
	Friend WithEvents txtArchivo As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents cbEntidadCategoria As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents cbEntidadSubcategoria As ComboBox
	Friend WithEvents nudRazonSocial1 As NumericUpDown
	Friend WithEvents Label2 As Label
	Friend WithEvents chkEmail As CheckBox
	Friend WithEvents nudEmail As NumericUpDown
	Friend WithEvents chkDomicilio As CheckBox
	Friend WithEvents nudDomicilio As NumericUpDown
	Friend WithEvents chkCategotia As CheckBox
	Friend WithEvents nudCategotia As NumericUpDown
	Friend WithEvents chkCBU As CheckBox
	Friend WithEvents nudCBU As NumericUpDown
	Friend WithEvents chkNumeroCuenta As CheckBox
	Friend WithEvents nudNumeroCuenta As NumericUpDown
	Friend WithEvents chkSubcategoria As CheckBox
	Friend WithEvents nudSubcategoria As NumericUpDown
	Friend WithEvents chkDiasVencimiento As CheckBox
	Friend WithEvents nudDiasVencimiento As NumericUpDown
	Friend WithEvents nudRazonSocial2 As NumericUpDown
End Class
