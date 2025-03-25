<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAfiliadosSeleccion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAfiliadosSeleccion))
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.btnSeleccionar = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.lvAfiliados = New System.Windows.Forms.ListView()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtBuscar = New System.Windows.Forms.TextBox()
		Me.lblAfiliado = New System.Windows.Forms.Label()
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
		Me.Iconos.Images.SetKeyName(35, "Pausa")
		Me.Iconos.Images.SetKeyName(36, "Correr")
		'
		'btnSeleccionar
		'
		Me.btnSeleccionar.ImageKey = "Aceptar"
		Me.btnSeleccionar.ImageList = Me.Iconos
		Me.btnSeleccionar.Location = New System.Drawing.Point(249, 398)
		Me.btnSeleccionar.Name = "btnSeleccionar"
		Me.btnSeleccionar.Size = New System.Drawing.Size(30, 30)
		Me.btnSeleccionar.TabIndex = 58
		Me.btnSeleccionar.UseVisualStyleBackColor = True
		'
		'btnCancelar
		'
		Me.btnCancelar.ImageKey = "Cancelar"
		Me.btnCancelar.ImageList = Me.Iconos
		Me.btnCancelar.Location = New System.Drawing.Point(279, 398)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(30, 30)
		Me.btnCancelar.TabIndex = 59
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'lvAfiliados
		'
		Me.lvAfiliados.HideSelection = False
		Me.lvAfiliados.Location = New System.Drawing.Point(12, 45)
		Me.lvAfiliados.Name = "lvAfiliados"
		Me.lvAfiliados.Size = New System.Drawing.Size(533, 278)
		Me.lvAfiliados.TabIndex = 60
		Me.lvAfiliados.UseCompatibleStateImageBehavior = False
		'
		'btnBuscar
		'
		Me.btnBuscar.ImageKey = "Buscar"
		Me.btnBuscar.ImageList = Me.Iconos
		Me.btnBuscar.Location = New System.Drawing.Point(201, 9)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
		Me.btnBuscar.TabIndex = 61
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(43, 13)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "Buscar:"
		'
		'txtBuscar
		'
		Me.txtBuscar.Location = New System.Drawing.Point(59, 14)
		Me.txtBuscar.Name = "txtBuscar"
		Me.txtBuscar.Size = New System.Drawing.Size(136, 20)
		Me.txtBuscar.TabIndex = 63
		'
		'lblAfiliado
		'
		Me.lblAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblAfiliado.ForeColor = System.Drawing.Color.Blue
		Me.lblAfiliado.Location = New System.Drawing.Point(12, 326)
		Me.lblAfiliado.Name = "lblAfiliado"
		Me.lblAfiliado.Size = New System.Drawing.Size(533, 69)
		Me.lblAfiliado.TabIndex = 64
		Me.lblAfiliado.Tag = "0"
		Me.lblAfiliado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmAfiliadosSeleccion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(557, 435)
		Me.Controls.Add(Me.lblAfiliado)
		Me.Controls.Add(Me.txtBuscar)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lvAfiliados)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnSeleccionar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.KeyPreview = True
		Me.Name = "frmAfiliadosSeleccion"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Selección de afiliado"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Iconos As ImageList
	Friend WithEvents btnSeleccionar As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents lvAfiliados As ListView
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents txtBuscar As TextBox
	Friend WithEvents lblAfiliado As Label
End Class
