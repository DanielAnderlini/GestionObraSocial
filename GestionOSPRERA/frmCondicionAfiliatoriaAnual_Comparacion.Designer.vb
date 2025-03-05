<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCondicionAfiliatoriaAnual_Comparacion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCondicionAfiliatoriaAnual_Comparacion))
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.gbParametros = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbAno = New System.Windows.Forms.ComboBox()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.lbAnos = New System.Windows.Forms.ListBox()
		Me.btnQuitar = New System.Windows.Forms.Button()
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.tcConsultas = New System.Windows.Forms.TabControl()
		Me.tpFiltros = New System.Windows.Forms.TabPage()
		Me.gbItems = New System.Windows.Forms.GroupBox()
		Me.btnBuscarItem = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.lblItem = New System.Windows.Forms.Label()
		Me.txtCodigoItem = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lvItems = New System.Windows.Forms.ListView()
		Me.rbArticulos = New System.Windows.Forms.RadioButton()
		Me.rbTodosItems = New System.Windows.Forms.RadioButton()
		Me.tpConsulta = New System.Windows.Forms.TabPage()
		Me.btnPDF = New System.Windows.Forms.Button()
		Me.btnVer = New System.Windows.Forms.Button()
		Me.btnExportar = New System.Windows.Forms.Button()
		Me.lblMovimientos = New System.Windows.Forms.Label()
		Me.txtBuscar = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lvConsulta = New System.Windows.Forms.ListView()
		Me.tpGrafico = New System.Windows.Forms.TabPage()
		Me.chkCambiarSigno = New System.Windows.Forms.CheckBox()
		Me.chkVerValores = New System.Windows.Forms.CheckBox()
		Me.btnPDFGrafico = New System.Windows.Forms.Button()
		Me.rbAmbosGraficos = New System.Windows.Forms.RadioButton()
		Me.rbGraficarStock = New System.Windows.Forms.RadioButton()
		Me.rbGraficarCantidades = New System.Windows.Forms.RadioButton()
		Me.btnGraficar = New System.Windows.Forms.Button()
		Me.ssBarraEstado.SuspendLayout()
		Me.gbParametros.SuspendLayout()
		Me.tcConsultas.SuspendLayout()
		Me.tpFiltros.SuspendLayout()
		Me.gbItems.SuspendLayout()
		Me.tpConsulta.SuspendLayout()
		Me.tpGrafico.SuspendLayout()
		Me.SuspendLayout()
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 570)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(960, 22)
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
		'gbParametros
		'
		Me.gbParametros.Controls.Add(Me.btnQuitar)
		Me.gbParametros.Controls.Add(Me.lbAnos)
		Me.gbParametros.Controls.Add(Me.btnAgregar)
		Me.gbParametros.Controls.Add(Me.cbAno)
		Me.gbParametros.Controls.Add(Me.Label1)
		Me.gbParametros.Location = New System.Drawing.Point(12, 12)
		Me.gbParametros.Name = "gbParametros"
		Me.gbParametros.Size = New System.Drawing.Size(188, 111)
		Me.gbParametros.TabIndex = 58
		Me.gbParametros.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Año:"
		'
		'cbAno
		'
		Me.cbAno.FormattingEnabled = True
		Me.cbAno.Location = New System.Drawing.Point(41, 19)
		Me.cbAno.Name = "cbAno"
		Me.cbAno.Size = New System.Drawing.Size(96, 21)
		Me.cbAno.TabIndex = 1
		'
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(246, 56)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 59
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'btnAgregar
		'
		Me.btnAgregar.ImageKey = "Agregar"
		Me.btnAgregar.ImageList = Me.Iconos
		Me.btnAgregar.Location = New System.Drawing.Point(143, 14)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
		Me.btnAgregar.TabIndex = 60
		Me.btnAgregar.UseVisualStyleBackColor = True
		'
		'lbAnos
		'
		Me.lbAnos.FormattingEnabled = True
		Me.lbAnos.Location = New System.Drawing.Point(41, 44)
		Me.lbAnos.Name = "lbAnos"
		Me.lbAnos.Size = New System.Drawing.Size(96, 56)
		Me.lbAnos.TabIndex = 61
		'
		'btnQuitar
		'
		Me.btnQuitar.ImageKey = "Quitar"
		Me.btnQuitar.ImageList = Me.Iconos
		Me.btnQuitar.Location = New System.Drawing.Point(143, 57)
		Me.btnQuitar.Name = "btnQuitar"
		Me.btnQuitar.Size = New System.Drawing.Size(30, 30)
		Me.btnQuitar.TabIndex = 62
		Me.btnQuitar.UseVisualStyleBackColor = True
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
		'
		'tcConsultas
		'
		Me.tcConsultas.Controls.Add(Me.tpFiltros)
		Me.tcConsultas.Controls.Add(Me.tpConsulta)
		Me.tcConsultas.Controls.Add(Me.tpGrafico)
		Me.tcConsultas.ImageList = Me.Iconos
		Me.tcConsultas.Location = New System.Drawing.Point(21, 129)
		Me.tcConsultas.Name = "tcConsultas"
		Me.tcConsultas.SelectedIndex = 0
		Me.tcConsultas.Size = New System.Drawing.Size(684, 409)
		Me.tcConsultas.TabIndex = 60
		'
		'tpFiltros
		'
		Me.tpFiltros.Controls.Add(Me.gbItems)
		Me.tpFiltros.ImageKey = "Filtro"
		Me.tpFiltros.Location = New System.Drawing.Point(4, 23)
		Me.tpFiltros.Name = "tpFiltros"
		Me.tpFiltros.Padding = New System.Windows.Forms.Padding(3)
		Me.tpFiltros.Size = New System.Drawing.Size(676, 382)
		Me.tpFiltros.TabIndex = 0
		Me.tpFiltros.Text = "Filtros"
		Me.tpFiltros.UseVisualStyleBackColor = True
		'
		'gbItems
		'
		Me.gbItems.Controls.Add(Me.btnBuscarItem)
		Me.gbItems.Controls.Add(Me.Label6)
		Me.gbItems.Controls.Add(Me.Button1)
		Me.gbItems.Controls.Add(Me.Button2)
		Me.gbItems.Controls.Add(Me.lblItem)
		Me.gbItems.Controls.Add(Me.txtCodigoItem)
		Me.gbItems.Controls.Add(Me.Label2)
		Me.gbItems.Controls.Add(Me.lvItems)
		Me.gbItems.Controls.Add(Me.rbArticulos)
		Me.gbItems.Controls.Add(Me.rbTodosItems)
		Me.gbItems.Location = New System.Drawing.Point(6, 125)
		Me.gbItems.Name = "gbItems"
		Me.gbItems.Size = New System.Drawing.Size(656, 150)
		Me.gbItems.TabIndex = 51
		Me.gbItems.TabStop = False
		Me.gbItems.Text = "Items"
		'
		'btnBuscarItem
		'
		Me.btnBuscarItem.Enabled = False
		Me.btnBuscarItem.ImageKey = "Buscar"
		Me.btnBuscarItem.ImageList = Me.Iconos
		Me.btnBuscarItem.Location = New System.Drawing.Point(297, 42)
		Me.btnBuscarItem.Name = "btnBuscarItem"
		Me.btnBuscarItem.Size = New System.Drawing.Size(30, 30)
		Me.btnBuscarItem.TabIndex = 19
		Me.btnBuscarItem.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Blue
		Me.Label6.Location = New System.Drawing.Point(181, 19)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(146, 23)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "Movimientos = 0"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Button1
		'
		Me.Button1.Enabled = False
		Me.Button1.ImageKey = "Quitar"
		Me.Button1.ImageList = Me.Iconos
		Me.Button1.Location = New System.Drawing.Point(297, 107)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(30, 30)
		Me.Button1.TabIndex = 22
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Enabled = False
		Me.Button2.ImageKey = "Agregar"
		Me.Button2.ImageList = Me.Iconos
		Me.Button2.Location = New System.Drawing.Point(297, 77)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(30, 30)
		Me.Button2.TabIndex = 21
		Me.Button2.UseVisualStyleBackColor = True
		'
		'lblItem
		'
		Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItem.ForeColor = System.Drawing.Color.Blue
		Me.lblItem.Location = New System.Drawing.Point(27, 77)
		Me.lblItem.Name = "lblItem"
		Me.lblItem.Size = New System.Drawing.Size(264, 60)
		Me.lblItem.TabIndex = 20
		Me.lblItem.Tag = "0"
		Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCodigoItem
		'
		Me.txtCodigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCodigoItem.Enabled = False
		Me.txtCodigoItem.Location = New System.Drawing.Point(133, 47)
		Me.txtCodigoItem.Name = "txtCodigoItem"
		Me.txtCodigoItem.Size = New System.Drawing.Size(158, 20)
		Me.txtCodigoItem.TabIndex = 18
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(77, 46)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 23)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Código:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lvItems
		'
		Me.lvItems.HideSelection = False
		Me.lvItems.Location = New System.Drawing.Point(332, 19)
		Me.lvItems.Name = "lvItems"
		Me.lvItems.Size = New System.Drawing.Size(315, 118)
		Me.lvItems.TabIndex = 2
		Me.lvItems.UseCompatibleStateImageBehavior = False
		'
		'rbArticulos
		'
		Me.rbArticulos.AutoSize = True
		Me.rbArticulos.Location = New System.Drawing.Point(9, 49)
		Me.rbArticulos.Name = "rbArticulos"
		Me.rbArticulos.Size = New System.Drawing.Size(67, 17)
		Me.rbArticulos.TabIndex = 1
		Me.rbArticulos.Text = "Artículos"
		Me.rbArticulos.UseVisualStyleBackColor = True
		'
		'rbTodosItems
		'
		Me.rbTodosItems.AutoSize = True
		Me.rbTodosItems.Checked = True
		Me.rbTodosItems.Location = New System.Drawing.Point(9, 29)
		Me.rbTodosItems.Name = "rbTodosItems"
		Me.rbTodosItems.Size = New System.Drawing.Size(55, 17)
		Me.rbTodosItems.TabIndex = 0
		Me.rbTodosItems.TabStop = True
		Me.rbTodosItems.Text = "Todos"
		Me.rbTodosItems.UseVisualStyleBackColor = True
		'
		'tpConsulta
		'
		Me.tpConsulta.Controls.Add(Me.btnPDF)
		Me.tpConsulta.Controls.Add(Me.btnVer)
		Me.tpConsulta.Controls.Add(Me.btnExportar)
		Me.tpConsulta.Controls.Add(Me.lblMovimientos)
		Me.tpConsulta.Controls.Add(Me.txtBuscar)
		Me.tpConsulta.Controls.Add(Me.btnBuscar)
		Me.tpConsulta.Controls.Add(Me.Label5)
		Me.tpConsulta.Controls.Add(Me.lvConsulta)
		Me.tpConsulta.ImageKey = "Tablas"
		Me.tpConsulta.Location = New System.Drawing.Point(4, 23)
		Me.tpConsulta.Name = "tpConsulta"
		Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
		Me.tpConsulta.Size = New System.Drawing.Size(676, 382)
		Me.tpConsulta.TabIndex = 1
		Me.tpConsulta.Text = "Consulta"
		Me.tpConsulta.UseVisualStyleBackColor = True
		'
		'btnPDF
		'
		Me.btnPDF.ImageKey = "PDF"
		Me.btnPDF.ImageList = Me.Iconos
		Me.btnPDF.Location = New System.Drawing.Point(37, 346)
		Me.btnPDF.Name = "btnPDF"
		Me.btnPDF.Size = New System.Drawing.Size(30, 30)
		Me.btnPDF.TabIndex = 57
		Me.btnPDF.UseVisualStyleBackColor = True
		Me.btnPDF.Visible = False
		'
		'btnVer
		'
		Me.btnVer.ImageKey = "Ver"
		Me.btnVer.ImageList = Me.Iconos
		Me.btnVer.Location = New System.Drawing.Point(323, 346)
		Me.btnVer.Name = "btnVer"
		Me.btnVer.Size = New System.Drawing.Size(30, 30)
		Me.btnVer.TabIndex = 46
		Me.btnVer.UseVisualStyleBackColor = True
		'
		'btnExportar
		'
		Me.btnExportar.ImageKey = "Exportar"
		Me.btnExportar.ImageList = Me.Iconos
		Me.btnExportar.Location = New System.Drawing.Point(6, 346)
		Me.btnExportar.Name = "btnExportar"
		Me.btnExportar.Size = New System.Drawing.Size(30, 30)
		Me.btnExportar.TabIndex = 45
		Me.btnExportar.UseVisualStyleBackColor = True
		'
		'lblMovimientos
		'
		Me.lblMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMovimientos.ForeColor = System.Drawing.Color.Blue
		Me.lblMovimientos.Location = New System.Drawing.Point(524, 7)
		Me.lblMovimientos.Name = "lblMovimientos"
		Me.lblMovimientos.Size = New System.Drawing.Size(146, 23)
		Me.lblMovimientos.TabIndex = 21
		Me.lblMovimientos.Text = "Movimientos = 0"
		Me.lblMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtBuscar
		'
		Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtBuscar.Location = New System.Drawing.Point(54, 8)
		Me.txtBuscar.Name = "txtBuscar"
		Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
		Me.txtBuscar.TabIndex = 20
		'
		'btnBuscar
		'
		Me.btnBuscar.ImageKey = "Buscar"
		Me.btnBuscar.ImageList = Me.Iconos
		Me.btnBuscar.Location = New System.Drawing.Point(157, 3)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
		Me.btnBuscar.TabIndex = 18
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 12)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 13)
		Me.Label5.TabIndex = 19
		Me.Label5.Text = "Buscar:"
		'
		'lvConsulta
		'
		Me.lvConsulta.HideSelection = False
		Me.lvConsulta.Location = New System.Drawing.Point(6, 37)
		Me.lvConsulta.Name = "lvConsulta"
		Me.lvConsulta.Size = New System.Drawing.Size(664, 303)
		Me.lvConsulta.TabIndex = 0
		Me.lvConsulta.UseCompatibleStateImageBehavior = False
		'
		'tpGrafico
		'
		Me.tpGrafico.Controls.Add(Me.chkCambiarSigno)
		Me.tpGrafico.Controls.Add(Me.chkVerValores)
		Me.tpGrafico.Controls.Add(Me.btnPDFGrafico)
		Me.tpGrafico.Controls.Add(Me.rbAmbosGraficos)
		Me.tpGrafico.Controls.Add(Me.rbGraficarStock)
		Me.tpGrafico.Controls.Add(Me.rbGraficarCantidades)
		Me.tpGrafico.Controls.Add(Me.btnGraficar)
		Me.tpGrafico.ImageKey = "Grafico"
		Me.tpGrafico.Location = New System.Drawing.Point(4, 23)
		Me.tpGrafico.Name = "tpGrafico"
		Me.tpGrafico.Padding = New System.Windows.Forms.Padding(3)
		Me.tpGrafico.Size = New System.Drawing.Size(676, 382)
		Me.tpGrafico.TabIndex = 2
		Me.tpGrafico.Text = "Gráfico"
		Me.tpGrafico.UseVisualStyleBackColor = True
		'
		'chkCambiarSigno
		'
		Me.chkCambiarSigno.AutoSize = True
		Me.chkCambiarSigno.Location = New System.Drawing.Point(467, 357)
		Me.chkCambiarSigno.Name = "chkCambiarSigno"
		Me.chkCambiarSigno.Size = New System.Drawing.Size(160, 17)
		Me.chkCambiarSigno.TabIndex = 62
		Me.chkCambiarSigno.Text = "Cambiar de signo los valores"
		Me.chkCambiarSigno.UseVisualStyleBackColor = True
		'
		'chkVerValores
		'
		Me.chkVerValores.AutoSize = True
		Me.chkVerValores.Location = New System.Drawing.Point(330, 356)
		Me.chkVerValores.Name = "chkVerValores"
		Me.chkVerValores.Size = New System.Drawing.Size(140, 17)
		Me.chkVerValores.TabIndex = 61
		Me.chkVerValores.Text = "Ver etiquetas de valores"
		Me.chkVerValores.UseVisualStyleBackColor = True
		'
		'btnPDFGrafico
		'
		Me.btnPDFGrafico.ImageKey = "PDF"
		Me.btnPDFGrafico.ImageList = Me.Iconos
		Me.btnPDFGrafico.Location = New System.Drawing.Point(639, 349)
		Me.btnPDFGrafico.Name = "btnPDFGrafico"
		Me.btnPDFGrafico.Size = New System.Drawing.Size(30, 30)
		Me.btnPDFGrafico.TabIndex = 60
		Me.btnPDFGrafico.UseVisualStyleBackColor = True
		Me.btnPDFGrafico.Visible = False
		'
		'rbAmbosGraficos
		'
		Me.rbAmbosGraficos.AutoSize = True
		Me.rbAmbosGraficos.Checked = True
		Me.rbAmbosGraficos.Location = New System.Drawing.Point(5, 356)
		Me.rbAmbosGraficos.Name = "rbAmbosGraficos"
		Me.rbAmbosGraficos.Size = New System.Drawing.Size(97, 17)
		Me.rbAmbosGraficos.TabIndex = 59
		Me.rbAmbosGraficos.TabStop = True
		Me.rbAmbosGraficos.Text = "Ambos gráficos"
		Me.rbAmbosGraficos.UseVisualStyleBackColor = True
		'
		'rbGraficarStock
		'
		Me.rbGraficarStock.AutoSize = True
		Me.rbGraficarStock.Location = New System.Drawing.Point(217, 356)
		Me.rbGraficarStock.Name = "rbGraficarStock"
		Me.rbGraficarStock.Size = New System.Drawing.Size(91, 17)
		Me.rbGraficarStock.TabIndex = 58
		Me.rbGraficarStock.Text = "Graficar stock"
		Me.rbGraficarStock.UseVisualStyleBackColor = True
		'
		'rbGraficarCantidades
		'
		Me.rbGraficarCantidades.AutoSize = True
		Me.rbGraficarCantidades.Location = New System.Drawing.Point(102, 356)
		Me.rbGraficarCantidades.Name = "rbGraficarCantidades"
		Me.rbGraficarCantidades.Size = New System.Drawing.Size(117, 17)
		Me.rbGraficarCantidades.TabIndex = 57
		Me.rbGraficarCantidades.Text = "Graficar cantidades"
		Me.rbGraficarCantidades.UseVisualStyleBackColor = True
		'
		'btnGraficar
		'
		Me.btnGraficar.Location = New System.Drawing.Point(594, 320)
		Me.btnGraficar.Name = "btnGraficar"
		Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
		Me.btnGraficar.TabIndex = 1
		Me.btnGraficar.Text = "Graficar"
		Me.btnGraficar.UseVisualStyleBackColor = True
		Me.btnGraficar.Visible = False
		'
		'frmCondicionAfiliatoriaAnual_Comparacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(960, 592)
		Me.Controls.Add(Me.tcConsultas)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.gbParametros)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.Name = "frmCondicionAfiliatoriaAnual_Comparacion"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Análisis de condicón afiliatoria - Anual"
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		Me.gbParametros.ResumeLayout(False)
		Me.gbParametros.PerformLayout()
		Me.tcConsultas.ResumeLayout(False)
		Me.tpFiltros.ResumeLayout(False)
		Me.gbItems.ResumeLayout(False)
		Me.gbItems.PerformLayout()
		Me.tpConsulta.ResumeLayout(False)
		Me.tpConsulta.PerformLayout()
		Me.tpGrafico.ResumeLayout(False)
		Me.tpGrafico.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents gbParametros As GroupBox
	Friend WithEvents cbAno As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnQuitar As Button
	Friend WithEvents lbAnos As ListBox
	Friend WithEvents btnAgregar As Button
	Friend WithEvents btnCerrar As Button
	Friend WithEvents Iconos As ImageList
	Friend WithEvents tcConsultas As TabControl
	Friend WithEvents tpFiltros As TabPage
	Friend WithEvents gbItems As GroupBox
	Friend WithEvents btnBuscarItem As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents lblItem As Label
	Friend WithEvents txtCodigoItem As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents lvItems As ListView
	Friend WithEvents rbArticulos As RadioButton
	Friend WithEvents rbTodosItems As RadioButton
	Friend WithEvents tpConsulta As TabPage
	Friend WithEvents btnPDF As Button
	Friend WithEvents btnVer As Button
	Friend WithEvents btnExportar As Button
	Friend WithEvents lblMovimientos As Label
	Friend WithEvents txtBuscar As TextBox
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents lvConsulta As ListView
	Friend WithEvents tpGrafico As TabPage
	Friend WithEvents chkCambiarSigno As CheckBox
	Friend WithEvents chkVerValores As CheckBox
	Friend WithEvents btnPDFGrafico As Button
	Friend WithEvents rbAmbosGraficos As RadioButton
	Friend WithEvents rbGraficarStock As RadioButton
	Friend WithEvents rbGraficarCantidades As RadioButton
	Friend WithEvents btnGraficar As Button
End Class
