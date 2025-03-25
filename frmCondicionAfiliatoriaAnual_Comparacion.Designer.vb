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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.gbParametros = New System.Windows.Forms.GroupBox()
		Me.btnQuitar = New System.Windows.Forms.Button()
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.lbAnos = New System.Windows.Forms.ListBox()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.cbAno = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.tcConsultas = New System.Windows.Forms.TabControl()
		Me.tpFiltros = New System.Windows.Forms.TabPage()
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
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.chGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.chkVerValores = New System.Windows.Forms.CheckBox()
		Me.btnPDFGrafico = New System.Windows.Forms.Button()
		Me.ssBarraEstado.SuspendLayout()
		Me.gbParametros.SuspendLayout()
		Me.tcConsultas.SuspendLayout()
		Me.tpFiltros.SuspendLayout()
		Me.tpConsulta.SuspendLayout()
		Me.tpGrafico.SuspendLayout()
		CType(Me.chGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 465)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(827, 22)
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
		Me.gbParametros.Location = New System.Drawing.Point(16, 19)
		Me.gbParametros.Name = "gbParametros"
		Me.gbParametros.Size = New System.Drawing.Size(638, 336)
		Me.gbParametros.TabIndex = 58
		Me.gbParametros.TabStop = False
		Me.gbParametros.Text = "Parámetros"
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
		Me.Iconos.Images.SetKeyName(40, "Actualizar")
		'
		'lbAnos
		'
		Me.lbAnos.FormattingEnabled = True
		Me.lbAnos.Location = New System.Drawing.Point(41, 44)
		Me.lbAnos.Name = "lbAnos"
		Me.lbAnos.Size = New System.Drawing.Size(96, 56)
		Me.lbAnos.TabIndex = 61
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
		'cbAno
		'
		Me.cbAno.FormattingEnabled = True
		Me.cbAno.Location = New System.Drawing.Point(41, 19)
		Me.cbAno.Name = "cbAno"
		Me.cbAno.Size = New System.Drawing.Size(96, 21)
		Me.cbAno.TabIndex = 1
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
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(785, 427)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 59
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'tcConsultas
		'
		Me.tcConsultas.Controls.Add(Me.tpFiltros)
		Me.tcConsultas.Controls.Add(Me.tpConsulta)
		Me.tcConsultas.Controls.Add(Me.tpGrafico)
		Me.tcConsultas.ImageList = Me.Iconos
		Me.tcConsultas.Location = New System.Drawing.Point(12, 12)
		Me.tcConsultas.Name = "tcConsultas"
		Me.tcConsultas.SelectedIndex = 0
		Me.tcConsultas.Size = New System.Drawing.Size(803, 409)
		Me.tcConsultas.TabIndex = 60
		'
		'tpFiltros
		'
		Me.tpFiltros.Controls.Add(Me.gbParametros)
		Me.tpFiltros.ImageKey = "Filtro"
		Me.tpFiltros.Location = New System.Drawing.Point(4, 23)
		Me.tpFiltros.Name = "tpFiltros"
		Me.tpFiltros.Padding = New System.Windows.Forms.Padding(3)
		Me.tpFiltros.Size = New System.Drawing.Size(795, 382)
		Me.tpFiltros.TabIndex = 0
		Me.tpFiltros.Text = "Filtros"
		Me.tpFiltros.UseVisualStyleBackColor = True
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
		Me.tpConsulta.Size = New System.Drawing.Size(795, 382)
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
		Me.btnVer.Location = New System.Drawing.Point(382, 346)
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
		Me.lblMovimientos.Location = New System.Drawing.Point(643, 7)
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
		Me.lvConsulta.Size = New System.Drawing.Size(783, 303)
		Me.lvConsulta.TabIndex = 0
		Me.lvConsulta.UseCompatibleStateImageBehavior = False
		'
		'tpGrafico
		'
		Me.tpGrafico.Controls.Add(Me.btnActualizar)
		Me.tpGrafico.Controls.Add(Me.chGrafico)
		Me.tpGrafico.Controls.Add(Me.chkVerValores)
		Me.tpGrafico.Controls.Add(Me.btnPDFGrafico)
		Me.tpGrafico.ImageKey = "Grafico"
		Me.tpGrafico.Location = New System.Drawing.Point(4, 23)
		Me.tpGrafico.Name = "tpGrafico"
		Me.tpGrafico.Padding = New System.Windows.Forms.Padding(3)
		Me.tpGrafico.Size = New System.Drawing.Size(795, 382)
		Me.tpGrafico.TabIndex = 2
		Me.tpGrafico.Text = "Gráfico"
		Me.tpGrafico.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.ImageKey = "Actualizar"
		Me.btnActualizar.ImageList = Me.Iconos
		Me.btnActualizar.Location = New System.Drawing.Point(639, 348)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(30, 30)
		Me.btnActualizar.TabIndex = 64
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'chGrafico
		'
		ChartArea1.Name = "ChartArea1"
		Me.chGrafico.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.chGrafico.Legends.Add(Legend1)
		Me.chGrafico.Location = New System.Drawing.Point(6, 6)
		Me.chGrafico.Name = "chGrafico"
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.chGrafico.Series.Add(Series1)
		Me.chGrafico.Size = New System.Drawing.Size(783, 300)
		Me.chGrafico.TabIndex = 63
		Me.chGrafico.Text = "Chart1"
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
		Me.btnPDFGrafico.Location = New System.Drawing.Point(759, 348)
		Me.btnPDFGrafico.Name = "btnPDFGrafico"
		Me.btnPDFGrafico.Size = New System.Drawing.Size(30, 30)
		Me.btnPDFGrafico.TabIndex = 60
		Me.btnPDFGrafico.UseVisualStyleBackColor = True
		Me.btnPDFGrafico.Visible = False
		'
		'frmCondicionAfiliatoriaAnual_Comparacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(827, 487)
		Me.Controls.Add(Me.tcConsultas)
		Me.Controls.Add(Me.btnCerrar)
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
		Me.tpConsulta.ResumeLayout(False)
		Me.tpConsulta.PerformLayout()
		Me.tpGrafico.ResumeLayout(False)
		Me.tpGrafico.PerformLayout()
		CType(Me.chGrafico, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents chkVerValores As CheckBox
	Friend WithEvents btnPDFGrafico As Button
	Friend WithEvents chGrafico As DataVisualization.Charting.Chart
	Friend WithEvents btnActualizar As Button
End Class
