<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAfiliadosAlmacenar
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAfiliadosAlmacenar))
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.lblContador = New System.Windows.Forms.Label()
		Me.lblMaximo = New System.Windows.Forms.Label()
		Me.pbBarraProgreso = New System.Windows.Forms.ProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.Label()
		Me.tRetardo = New System.Windows.Forms.Timer(Me.components)
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
		'lblContador
		'
		Me.lblContador.ForeColor = System.Drawing.Color.Blue
		Me.lblContador.Location = New System.Drawing.Point(12, 50)
		Me.lblContador.Name = "lblContador"
		Me.lblContador.Size = New System.Drawing.Size(69, 23)
		Me.lblContador.TabIndex = 0
		Me.lblContador.Text = "0"
		Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblMaximo
		'
		Me.lblMaximo.ForeColor = System.Drawing.Color.Blue
		Me.lblMaximo.Location = New System.Drawing.Point(355, 50)
		Me.lblMaximo.Name = "lblMaximo"
		Me.lblMaximo.Size = New System.Drawing.Size(69, 23)
		Me.lblMaximo.TabIndex = 1
		Me.lblMaximo.Text = "0"
		Me.lblMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pbBarraProgreso
		'
		Me.pbBarraProgreso.Location = New System.Drawing.Point(87, 50)
		Me.pbBarraProgreso.Name = "pbBarraProgreso"
		Me.pbBarraProgreso.Size = New System.Drawing.Size(262, 23)
		Me.pbBarraProgreso.TabIndex = 2
		'
		'lblMensajeProgreso
		'
		Me.lblMensajeProgreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMensajeProgreso.ForeColor = System.Drawing.Color.Blue
		Me.lblMensajeProgreso.Location = New System.Drawing.Point(23, 105)
		Me.lblMensajeProgreso.Name = "lblMensajeProgreso"
		Me.lblMensajeProgreso.Size = New System.Drawing.Size(391, 25)
		Me.lblMensajeProgreso.TabIndex = 3
		Me.lblMensajeProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tRetardo
		'
		Me.tRetardo.Enabled = True
		Me.tRetardo.Interval = 200
		'
		'frmAfiliadosAlmacenar
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(434, 151)
		Me.Controls.Add(Me.lblMensajeProgreso)
		Me.Controls.Add(Me.pbBarraProgreso)
		Me.Controls.Add(Me.lblMaximo)
		Me.Controls.Add(Me.lblContador)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "frmAfiliadosAlmacenar"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Almacenamiento de afiliados"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Iconos As ImageList
	Friend WithEvents lblContador As Label
	Friend WithEvents lblMaximo As Label
	Friend WithEvents pbBarraProgreso As ProgressBar
	Friend WithEvents lblMensajeProgreso As Label
	Friend WithEvents tRetardo As Timer
End Class
