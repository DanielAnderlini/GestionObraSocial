<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoriasImportacionXLS
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoriasImportacionXLS))
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.nudCodigo = New System.Windows.Forms.NumericUpDown()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.nudCodigoRelacionado = New System.Windows.Forms.NumericUpDown()
		Me.nudDescripcion = New System.Windows.Forms.NumericUpDown()
		Me.lblNumeroBono = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.nudFilaInicial = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.nudHoja = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnArchivo = New System.Windows.Forms.Button()
		Me.txtArchivo = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.chkCodigoRelacionado = New System.Windows.Forms.CheckBox()
		Me.rbNuevaEntidad = New System.Windows.Forms.RadioButton()
		Me.rbEntidad = New System.Windows.Forms.RadioButton()
		Me.cbEntidad = New System.Windows.Forms.ComboBox()
		Me.txtEntidad = New System.Windows.Forms.TextBox()
		Me.cbEntidadRelacionada = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnEjecutar = New System.Windows.Forms.Button()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.ssBarraEstado.SuspendLayout()
		CType(Me.nudCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCodigoRelacionado, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudFilaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudHoja, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 404)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(448, 22)
		Me.ssBarraEstado.SizingGrip = False
		Me.ssBarraEstado.TabIndex = 56
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
		'nudCodigo
		'
		Me.nudCodigo.Location = New System.Drawing.Point(196, 188)
		Me.nudCodigo.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudCodigo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCodigo.Name = "nudCodigo"
		Me.nudCodigo.Size = New System.Drawing.Size(46, 20)
		Me.nudCodigo.TabIndex = 84
		Me.nudCodigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(127, 192)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(43, 13)
		Me.Label12.TabIndex = 85
		Me.Label12.Text = "Código:"
		'
		'nudCodigoRelacionado
		'
		Me.nudCodigoRelacionado.Enabled = False
		Me.nudCodigoRelacionado.Location = New System.Drawing.Point(196, 240)
		Me.nudCodigoRelacionado.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudCodigoRelacionado.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCodigoRelacionado.Name = "nudCodigoRelacionado"
		Me.nudCodigoRelacionado.Size = New System.Drawing.Size(46, 20)
		Me.nudCodigoRelacionado.TabIndex = 82
		Me.nudCodigoRelacionado.Value = New Decimal(New Integer() {3, 0, 0, 0})
		'
		'nudDescripcion
		'
		Me.nudDescripcion.Location = New System.Drawing.Point(196, 216)
		Me.nudDescripcion.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
		Me.nudDescripcion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudDescripcion.Name = "nudDescripcion"
		Me.nudDescripcion.Size = New System.Drawing.Size(46, 20)
		Me.nudDescripcion.TabIndex = 80
		Me.nudDescripcion.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'lblNumeroBono
		'
		Me.lblNumeroBono.AutoSize = True
		Me.lblNumeroBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumeroBono.Location = New System.Drawing.Point(127, 220)
		Me.lblNumeroBono.Name = "lblNumeroBono"
		Me.lblNumeroBono.Size = New System.Drawing.Size(66, 13)
		Me.lblNumeroBono.TabIndex = 81
		Me.lblNumeroBono.Text = "Descripción:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(29, 166)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(100, 13)
		Me.Label10.TabIndex = 79
		Me.Label10.Text = "Columnas de datos:"
		'
		'nudFilaInicial
		'
		Me.nudFilaInicial.Location = New System.Drawing.Point(270, 51)
		Me.nudFilaInicial.Maximum = New Decimal(New Integer() {1048576, 0, 0, 0})
		Me.nudFilaInicial.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudFilaInicial.Name = "nudFilaInicial"
		Me.nudFilaInicial.Size = New System.Drawing.Size(46, 20)
		Me.nudFilaInicial.TabIndex = 75
		Me.nudFilaInicial.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(209, 55)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(55, 13)
		Me.Label5.TabIndex = 76
		Me.Label5.Text = "Fila inicial:"
		'
		'nudHoja
		'
		Me.nudHoja.Location = New System.Drawing.Point(100, 51)
		Me.nudHoja.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
		Me.nudHoja.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudHoja.Name = "nudHoja"
		Me.nudHoja.Size = New System.Drawing.Size(46, 20)
		Me.nudHoja.TabIndex = 73
		Me.nudHoja.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(12, 55)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(82, 13)
		Me.Label8.TabIndex = 74
		Me.Label8.Text = "Hoja con datos:"
		'
		'btnArchivo
		'
		Me.btnArchivo.ImageKey = "Excel"
		Me.btnArchivo.ImageList = Me.Iconos
		Me.btnArchivo.Location = New System.Drawing.Point(405, 9)
		Me.btnArchivo.Name = "btnArchivo"
		Me.btnArchivo.Size = New System.Drawing.Size(30, 30)
		Me.btnArchivo.TabIndex = 70
		Me.btnArchivo.UseVisualStyleBackColor = True
		'
		'txtArchivo
		'
		Me.txtArchivo.ForeColor = System.Drawing.Color.Blue
		Me.txtArchivo.Location = New System.Drawing.Point(64, 14)
		Me.txtArchivo.Name = "txtArchivo"
		Me.txtArchivo.ReadOnly = True
		Me.txtArchivo.Size = New System.Drawing.Size(335, 20)
		Me.txtArchivo.TabIndex = 72
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 71
		Me.Label1.Text = "Archivo:"
		'
		'chkCodigoRelacionado
		'
		Me.chkCodigoRelacionado.AutoSize = True
		Me.chkCodigoRelacionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkCodigoRelacionado.Location = New System.Drawing.Point(73, 243)
		Me.chkCodigoRelacionado.Name = "chkCodigoRelacionado"
		Me.chkCodigoRelacionado.Size = New System.Drawing.Size(120, 17)
		Me.chkCodigoRelacionado.TabIndex = 86
		Me.chkCodigoRelacionado.Text = "Código relacionado:"
		Me.chkCodigoRelacionado.UseVisualStyleBackColor = True
		'
		'rbNuevaEntidad
		'
		Me.rbNuevaEntidad.AutoSize = True
		Me.rbNuevaEntidad.Checked = True
		Me.rbNuevaEntidad.Location = New System.Drawing.Point(15, 100)
		Me.rbNuevaEntidad.Name = "rbNuevaEntidad"
		Me.rbNuevaEntidad.Size = New System.Drawing.Size(98, 17)
		Me.rbNuevaEntidad.TabIndex = 87
		Me.rbNuevaEntidad.TabStop = True
		Me.rbNuevaEntidad.Text = "Nueva entidad:"
		Me.rbNuevaEntidad.UseVisualStyleBackColor = True
		'
		'rbEntidad
		'
		Me.rbEntidad.AutoSize = True
		Me.rbEntidad.Location = New System.Drawing.Point(15, 127)
		Me.rbEntidad.Name = "rbEntidad"
		Me.rbEntidad.Size = New System.Drawing.Size(64, 17)
		Me.rbEntidad.TabIndex = 88
		Me.rbEntidad.TabStop = True
		Me.rbEntidad.Text = "Entidad:"
		Me.rbEntidad.UseVisualStyleBackColor = True
		'
		'cbEntidad
		'
		Me.cbEntidad.Enabled = False
		Me.cbEntidad.FormattingEnabled = True
		Me.cbEntidad.Location = New System.Drawing.Point(82, 123)
		Me.cbEntidad.Name = "cbEntidad"
		Me.cbEntidad.Size = New System.Drawing.Size(182, 21)
		Me.cbEntidad.TabIndex = 89
		'
		'txtEntidad
		'
		Me.txtEntidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtEntidad.Location = New System.Drawing.Point(119, 99)
		Me.txtEntidad.Name = "txtEntidad"
		Me.txtEntidad.Size = New System.Drawing.Size(100, 20)
		Me.txtEntidad.TabIndex = 90
		'
		'cbEntidadRelacionada
		'
		Me.cbEntidadRelacionada.Enabled = False
		Me.cbEntidadRelacionada.FormattingEnabled = True
		Me.cbEntidadRelacionada.Location = New System.Drawing.Point(196, 266)
		Me.cbEntidadRelacionada.Name = "cbEntidadRelacionada"
		Me.cbEntidadRelacionada.Size = New System.Drawing.Size(182, 21)
		Me.cbEntidadRelacionada.TabIndex = 91
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(86, 274)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 13)
		Me.Label2.TabIndex = 92
		Me.Label2.Text = "Entidad relacionada:"
		'
		'btnEjecutar
		'
		Me.btnEjecutar.ImageKey = "Ejecutar"
		Me.btnEjecutar.ImageList = Me.Iconos
		Me.btnEjecutar.Location = New System.Drawing.Point(212, 324)
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(30, 30)
		Me.btnEjecutar.TabIndex = 93
		Me.btnEjecutar.UseVisualStyleBackColor = True
		'
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(405, 370)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 94
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'frmCategoriasImportacionXLS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(448, 426)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnEjecutar)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.cbEntidadRelacionada)
		Me.Controls.Add(Me.txtEntidad)
		Me.Controls.Add(Me.cbEntidad)
		Me.Controls.Add(Me.rbEntidad)
		Me.Controls.Add(Me.rbNuevaEntidad)
		Me.Controls.Add(Me.chkCodigoRelacionado)
		Me.Controls.Add(Me.nudCodigo)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.nudCodigoRelacionado)
		Me.Controls.Add(Me.nudDescripcion)
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
		Me.Name = "frmCategoriasImportacionXLS"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Importación XLS de categorías"
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		CType(Me.nudCodigo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCodigoRelacionado, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudFilaInicial, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudHoja, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents Iconos As ImageList
	Friend WithEvents nudCodigo As NumericUpDown
	Friend WithEvents Label12 As Label
	Friend WithEvents nudCodigoRelacionado As NumericUpDown
	Friend WithEvents nudDescripcion As NumericUpDown
	Friend WithEvents lblNumeroBono As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents nudFilaInicial As NumericUpDown
	Friend WithEvents Label5 As Label
	Friend WithEvents nudHoja As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents btnArchivo As Button
	Friend WithEvents txtArchivo As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents chkCodigoRelacionado As CheckBox
	Friend WithEvents rbNuevaEntidad As RadioButton
	Friend WithEvents rbEntidad As RadioButton
	Friend WithEvents cbEntidad As ComboBox
	Friend WithEvents txtEntidad As TextBox
	Friend WithEvents cbEntidadRelacionada As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnEjecutar As Button
	Friend WithEvents btnCerrar As Button
End Class
