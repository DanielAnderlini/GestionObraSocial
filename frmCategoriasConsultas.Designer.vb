﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoriasConsultas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoriasConsultas))
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.gbFiltros = New System.Windows.Forms.GroupBox()
		Me.btnFiltrar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbEntidad = New System.Windows.Forms.ComboBox()
		Me.gbConsultas = New System.Windows.Forms.GroupBox()
		Me.btnExportar = New System.Windows.Forms.Button()
		Me.lblItems = New System.Windows.Forms.Label()
		Me.txtBuscar = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lvConsulta = New System.Windows.Forms.ListView()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.ssBarraEstado.SuspendLayout()
		Me.gbFiltros.SuspendLayout()
		Me.gbConsultas.SuspendLayout()
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
		Me.Iconos.Images.SetKeyName(35, "XYZ")
		Me.Iconos.Images.SetKeyName(36, "Deposito")
		Me.Iconos.Images.SetKeyName(37, "Exportar")
		Me.Iconos.Images.SetKeyName(38, "PDF")
		Me.Iconos.Images.SetKeyName(39, "Grafico")
		Me.Iconos.Images.SetKeyName(40, "Actualizar")
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 539)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(626, 22)
		Me.ssBarraEstado.SizingGrip = False
		Me.ssBarraEstado.TabIndex = 58
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
		'gbFiltros
		'
		Me.gbFiltros.Controls.Add(Me.btnFiltrar)
		Me.gbFiltros.Controls.Add(Me.Label1)
		Me.gbFiltros.Controls.Add(Me.cbEntidad)
		Me.gbFiltros.Location = New System.Drawing.Point(12, 12)
		Me.gbFiltros.Name = "gbFiltros"
		Me.gbFiltros.Size = New System.Drawing.Size(601, 77)
		Me.gbFiltros.TabIndex = 59
		Me.gbFiltros.TabStop = False
		'
		'btnFiltrar
		'
		Me.btnFiltrar.ImageKey = "Filtro"
		Me.btnFiltrar.ImageList = Me.Iconos
		Me.btnFiltrar.Location = New System.Drawing.Point(268, 23)
		Me.btnFiltrar.Name = "btnFiltrar"
		Me.btnFiltrar.Size = New System.Drawing.Size(30, 30)
		Me.btnFiltrar.TabIndex = 62
		Me.btnFiltrar.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 91
		Me.Label1.Text = "Entidad:"
		'
		'cbEntidad
		'
		Me.cbEntidad.FormattingEnabled = True
		Me.cbEntidad.Location = New System.Drawing.Point(62, 28)
		Me.cbEntidad.Name = "cbEntidad"
		Me.cbEntidad.Size = New System.Drawing.Size(182, 21)
		Me.cbEntidad.TabIndex = 90
		'
		'gbConsultas
		'
		Me.gbConsultas.Controls.Add(Me.btnExportar)
		Me.gbConsultas.Controls.Add(Me.lblItems)
		Me.gbConsultas.Controls.Add(Me.txtBuscar)
		Me.gbConsultas.Controls.Add(Me.btnBuscar)
		Me.gbConsultas.Controls.Add(Me.Label5)
		Me.gbConsultas.Controls.Add(Me.lvConsulta)
		Me.gbConsultas.Location = New System.Drawing.Point(12, 106)
		Me.gbConsultas.Name = "gbConsultas"
		Me.gbConsultas.Size = New System.Drawing.Size(601, 399)
		Me.gbConsultas.TabIndex = 60
		Me.gbConsultas.TabStop = False
		'
		'btnExportar
		'
		Me.btnExportar.ImageKey = "Exportar"
		Me.btnExportar.ImageList = Me.Iconos
		Me.btnExportar.Location = New System.Drawing.Point(14, 361)
		Me.btnExportar.Name = "btnExportar"
		Me.btnExportar.Size = New System.Drawing.Size(30, 30)
		Me.btnExportar.TabIndex = 51
		Me.btnExportar.UseVisualStyleBackColor = True
		'
		'lblItems
		'
		Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItems.ForeColor = System.Drawing.Color.Blue
		Me.lblItems.Location = New System.Drawing.Point(435, 22)
		Me.lblItems.Name = "lblItems"
		Me.lblItems.Size = New System.Drawing.Size(146, 23)
		Me.lblItems.TabIndex = 50
		Me.lblItems.Text = "Items = 0"
		Me.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtBuscar
		'
		Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtBuscar.Location = New System.Drawing.Point(62, 23)
		Me.txtBuscar.Name = "txtBuscar"
		Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
		Me.txtBuscar.TabIndex = 49
		'
		'btnBuscar
		'
		Me.btnBuscar.ImageKey = "Buscar"
		Me.btnBuscar.ImageList = Me.Iconos
		Me.btnBuscar.Location = New System.Drawing.Point(165, 18)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
		Me.btnBuscar.TabIndex = 47
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(16, 27)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 13)
		Me.Label5.TabIndex = 48
		Me.Label5.Text = "Buscar:"
		'
		'lvConsulta
		'
		Me.lvConsulta.HideSelection = False
		Me.lvConsulta.Location = New System.Drawing.Point(14, 52)
		Me.lvConsulta.Name = "lvConsulta"
		Me.lvConsulta.Size = New System.Drawing.Size(567, 303)
		Me.lvConsulta.TabIndex = 46
		Me.lvConsulta.UseCompatibleStateImageBehavior = False
		'
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(583, 506)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 61
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'frmCategoriasConsultas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(626, 561)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.gbConsultas)
		Me.Controls.Add(Me.gbFiltros)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.Name = "frmCategoriasConsultas"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Consulta de categorías"
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		Me.gbFiltros.ResumeLayout(False)
		Me.gbFiltros.PerformLayout()
		Me.gbConsultas.ResumeLayout(False)
		Me.gbConsultas.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Iconos As ImageList
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents gbFiltros As GroupBox
	Friend WithEvents gbConsultas As GroupBox
	Friend WithEvents btnExportar As Button
	Friend WithEvents lblItems As Label
	Friend WithEvents txtBuscar As TextBox
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents lvConsulta As ListView
	Friend WithEvents btnCerrar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents cbEntidad As ComboBox
	Friend WithEvents btnFiltrar As Button
End Class
