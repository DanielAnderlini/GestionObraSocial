<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCondicionAfiliatoriaAnual_Afiliado
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCondicionAfiliatoriaAnual_Afiliado))
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.gbAfiliado = New System.Windows.Forms.GroupBox()
		Me.btnGrupoFamiliar = New System.Windows.Forms.Button()
		Me.btnTitular = New System.Windows.Forms.Button()
		Me.lblGenero = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lblRelacion = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblUATRE = New System.Windows.Forms.Label()
		Me.lblBocaExpendio = New System.Windows.Forms.Label()
		Me.lblNumeroBocaExpendio = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblEdad = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblFechaNacimiento = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblNombreCompleto = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblCUIL = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.txtDNI = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.gbCondicionAfiliatoria = New System.Windows.Forms.GroupBox()
		Me.btnFiltrar = New System.Windows.Forms.Button()
		Me.lvCondicionAfiliatoria = New System.Windows.Forms.ListView()
		Me.nudAno = New System.Windows.Forms.NumericUpDown()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.ssBarraEstado.SuspendLayout()
		Me.gbAfiliado.SuspendLayout()
		Me.gbCondicionAfiliatoria.SuspendLayout()
		CType(Me.nudAno, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 512)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(512, 22)
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
		Me.btnCerrar.Location = New System.Drawing.Point(469, 479)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 58
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'gbAfiliado
		'
		Me.gbAfiliado.Controls.Add(Me.btnGrupoFamiliar)
		Me.gbAfiliado.Controls.Add(Me.btnTitular)
		Me.gbAfiliado.Controls.Add(Me.lblGenero)
		Me.gbAfiliado.Controls.Add(Me.Label10)
		Me.gbAfiliado.Controls.Add(Me.lblRelacion)
		Me.gbAfiliado.Controls.Add(Me.Label9)
		Me.gbAfiliado.Controls.Add(Me.lblUATRE)
		Me.gbAfiliado.Controls.Add(Me.lblBocaExpendio)
		Me.gbAfiliado.Controls.Add(Me.lblNumeroBocaExpendio)
		Me.gbAfiliado.Controls.Add(Me.Label8)
		Me.gbAfiliado.Controls.Add(Me.Label7)
		Me.gbAfiliado.Controls.Add(Me.Label6)
		Me.gbAfiliado.Controls.Add(Me.lblEdad)
		Me.gbAfiliado.Controls.Add(Me.Label5)
		Me.gbAfiliado.Controls.Add(Me.lblFechaNacimiento)
		Me.gbAfiliado.Controls.Add(Me.Label4)
		Me.gbAfiliado.Controls.Add(Me.lblNombreCompleto)
		Me.gbAfiliado.Controls.Add(Me.Label3)
		Me.gbAfiliado.Controls.Add(Me.lblCUIL)
		Me.gbAfiliado.Controls.Add(Me.Label2)
		Me.gbAfiliado.Controls.Add(Me.btnBuscar)
		Me.gbAfiliado.Controls.Add(Me.txtDNI)
		Me.gbAfiliado.Controls.Add(Me.Label1)
		Me.gbAfiliado.Location = New System.Drawing.Point(12, 12)
		Me.gbAfiliado.Name = "gbAfiliado"
		Me.gbAfiliado.Size = New System.Drawing.Size(487, 221)
		Me.gbAfiliado.TabIndex = 59
		Me.gbAfiliado.TabStop = False
		Me.gbAfiliado.Text = "Afiliado"
		'
		'btnGrupoFamiliar
		'
		Me.btnGrupoFamiliar.Enabled = False
		Me.btnGrupoFamiliar.ImageKey = "Personas"
		Me.btnGrupoFamiliar.ImageList = Me.Iconos
		Me.btnGrupoFamiliar.Location = New System.Drawing.Point(442, 185)
		Me.btnGrupoFamiliar.Name = "btnGrupoFamiliar"
		Me.btnGrupoFamiliar.Size = New System.Drawing.Size(30, 30)
		Me.btnGrupoFamiliar.TabIndex = 79
		Me.btnGrupoFamiliar.UseVisualStyleBackColor = True
		'
		'btnTitular
		'
		Me.btnTitular.Enabled = False
		Me.btnTitular.ImageKey = "Usuario"
		Me.btnTitular.ImageList = Me.Iconos
		Me.btnTitular.Location = New System.Drawing.Point(412, 185)
		Me.btnTitular.Name = "btnTitular"
		Me.btnTitular.Size = New System.Drawing.Size(30, 30)
		Me.btnTitular.TabIndex = 78
		Me.btnTitular.UseVisualStyleBackColor = True
		'
		'lblGenero
		'
		Me.lblGenero.AutoSize = True
		Me.lblGenero.Location = New System.Drawing.Point(66, 96)
		Me.lblGenero.Name = "lblGenero"
		Me.lblGenero.Size = New System.Drawing.Size(28, 13)
		Me.lblGenero.TabIndex = 77
		Me.lblGenero.Text = "XXX"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(15, 96)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(45, 13)
		Me.Label10.TabIndex = 76
		Me.Label10.Text = "Genero:"
		'
		'lblRelacion
		'
		Me.lblRelacion.AutoSize = True
		Me.lblRelacion.Location = New System.Drawing.Point(82, 192)
		Me.lblRelacion.Name = "lblRelacion"
		Me.lblRelacion.Size = New System.Drawing.Size(28, 13)
		Me.lblRelacion.TabIndex = 75
		Me.lblRelacion.Text = "XXX"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(15, 192)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(52, 13)
		Me.Label9.TabIndex = 74
		Me.Label9.Text = "Relación:"
		'
		'lblUATRE
		'
		Me.lblUATRE.AutoSize = True
		Me.lblUATRE.Location = New System.Drawing.Point(395, 130)
		Me.lblUATRE.Name = "lblUATRE"
		Me.lblUATRE.Size = New System.Drawing.Size(21, 13)
		Me.lblUATRE.TabIndex = 73
		Me.lblUATRE.Text = "XX"
		'
		'lblBocaExpendio
		'
		Me.lblBocaExpendio.AutoSize = True
		Me.lblBocaExpendio.Location = New System.Drawing.Point(115, 157)
		Me.lblBocaExpendio.Name = "lblBocaExpendio"
		Me.lblBocaExpendio.Size = New System.Drawing.Size(28, 13)
		Me.lblBocaExpendio.TabIndex = 72
		Me.lblBocaExpendio.Text = "XXX"
		'
		'lblNumeroBocaExpendio
		'
		Me.lblNumeroBocaExpendio.AutoSize = True
		Me.lblNumeroBocaExpendio.Location = New System.Drawing.Point(128, 130)
		Me.lblNumeroBocaExpendio.Name = "lblNumeroBocaExpendio"
		Me.lblNumeroBocaExpendio.Size = New System.Drawing.Size(13, 13)
		Me.lblNumeroBocaExpendio.TabIndex = 71
		Me.lblNumeroBocaExpendio.Text = "0"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(15, 157)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(96, 13)
		Me.Label8.TabIndex = 70
		Me.Label8.Text = "Boca de expendio:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(15, 130)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(110, 13)
		Me.Label7.TabIndex = 69
		Me.Label7.Text = "N° boca de expendio:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(341, 130)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(47, 13)
		Me.Label6.TabIndex = 68
		Me.Label6.Text = "UATRE:"
		'
		'lblEdad
		'
		Me.lblEdad.AutoSize = True
		Me.lblEdad.Location = New System.Drawing.Point(439, 96)
		Me.lblEdad.Name = "lblEdad"
		Me.lblEdad.Size = New System.Drawing.Size(13, 13)
		Me.lblEdad.TabIndex = 67
		Me.lblEdad.Text = "0"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(398, 96)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 13)
		Me.Label5.TabIndex = 66
		Me.Label5.Text = "Edad:"
		'
		'lblFechaNacimiento
		'
		Me.lblFechaNacimiento.AutoSize = True
		Me.lblFechaNacimiento.Location = New System.Drawing.Point(301, 96)
		Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
		Me.lblFechaNacimiento.Size = New System.Drawing.Size(65, 13)
		Me.lblFechaNacimiento.TabIndex = 65
		Me.lblFechaNacimiento.Text = "99/99/9999"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(188, 96)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(109, 13)
		Me.Label4.TabIndex = 64
		Me.Label4.Text = "Fecha de nacimiento:"
		'
		'lblNombreCompleto
		'
		Me.lblNombreCompleto.AutoSize = True
		Me.lblNombreCompleto.Location = New System.Drawing.Point(114, 67)
		Me.lblNombreCompleto.Name = "lblNombreCompleto"
		Me.lblNombreCompleto.Size = New System.Drawing.Size(21, 13)
		Me.lblNombreCompleto.TabIndex = 63
		Me.lblNombreCompleto.Text = "XX"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(15, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(98, 13)
		Me.Label3.TabIndex = 62
		Me.Label3.Text = "Apellido y nombres:"
		'
		'lblCUIL
		'
		Me.lblCUIL.AutoSize = True
		Me.lblCUIL.Location = New System.Drawing.Point(268, 28)
		Me.lblCUIL.Name = "lblCUIL"
		Me.lblCUIL.Size = New System.Drawing.Size(13, 13)
		Me.lblCUIL.TabIndex = 61
		Me.lblCUIL.Text = "0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(228, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(34, 13)
		Me.Label2.TabIndex = 60
		Me.Label2.Text = "CUIL:"
		'
		'btnBuscar
		'
		Me.btnBuscar.ImageKey = "Buscar"
		Me.btnBuscar.ImageList = Me.Iconos
		Me.btnBuscar.Location = New System.Drawing.Point(171, 19)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
		Me.btnBuscar.TabIndex = 59
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'txtDNI
		'
		Me.txtDNI.Location = New System.Drawing.Point(51, 24)
		Me.txtDNI.Name = "txtDNI"
		Me.txtDNI.Size = New System.Drawing.Size(114, 20)
		Me.txtDNI.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(15, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "DNI:"
		'
		'gbCondicionAfiliatoria
		'
		Me.gbCondicionAfiliatoria.Controls.Add(Me.btnFiltrar)
		Me.gbCondicionAfiliatoria.Controls.Add(Me.lvCondicionAfiliatoria)
		Me.gbCondicionAfiliatoria.Controls.Add(Me.nudAno)
		Me.gbCondicionAfiliatoria.Controls.Add(Me.Label11)
		Me.gbCondicionAfiliatoria.Location = New System.Drawing.Point(13, 239)
		Me.gbCondicionAfiliatoria.Name = "gbCondicionAfiliatoria"
		Me.gbCondicionAfiliatoria.Size = New System.Drawing.Size(486, 234)
		Me.gbCondicionAfiliatoria.TabIndex = 60
		Me.gbCondicionAfiliatoria.TabStop = False
		Me.gbCondicionAfiliatoria.Text = "Condición afiliatoria"
		'
		'btnFiltrar
		'
		Me.btnFiltrar.ImageKey = "Filtro"
		Me.btnFiltrar.ImageList = Me.Iconos
		Me.btnFiltrar.Location = New System.Drawing.Point(104, 22)
		Me.btnFiltrar.Name = "btnFiltrar"
		Me.btnFiltrar.Size = New System.Drawing.Size(30, 30)
		Me.btnFiltrar.TabIndex = 79
		Me.btnFiltrar.UseVisualStyleBackColor = True
		'
		'lvCondicionAfiliatoria
		'
		Me.lvCondicionAfiliatoria.HideSelection = False
		Me.lvCondicionAfiliatoria.Location = New System.Drawing.Point(6, 58)
		Me.lvCondicionAfiliatoria.Name = "lvCondicionAfiliatoria"
		Me.lvCondicionAfiliatoria.Size = New System.Drawing.Size(474, 170)
		Me.lvCondicionAfiliatoria.TabIndex = 2
		Me.lvCondicionAfiliatoria.UseCompatibleStateImageBehavior = False
		'
		'nudAno
		'
		Me.nudAno.Location = New System.Drawing.Point(39, 27)
		Me.nudAno.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudAno.Minimum = New Decimal(New Integer() {2004, 0, 0, 0})
		Me.nudAno.Name = "nudAno"
		Me.nudAno.Size = New System.Drawing.Size(59, 20)
		Me.nudAno.TabIndex = 1
		Me.nudAno.Value = New Decimal(New Integer() {2004, 0, 0, 0})
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(6, 29)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(29, 13)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "Año:"
		'
		'frmCondicionAfiliatoriaAnual_Afiliado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(512, 534)
		Me.Controls.Add(Me.gbCondicionAfiliatoria)
		Me.Controls.Add(Me.gbAfiliado)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "frmCondicionAfiliatoriaAnual_Afiliado"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Condición afiliatoria de un afiliado"
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		Me.gbAfiliado.ResumeLayout(False)
		Me.gbAfiliado.PerformLayout()
		Me.gbCondicionAfiliatoria.ResumeLayout(False)
		Me.gbCondicionAfiliatoria.PerformLayout()
		CType(Me.nudAno, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Iconos As ImageList
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents btnCerrar As Button
	Friend WithEvents gbAfiliado As GroupBox
	Friend WithEvents txtDNI As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblNombreCompleto As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblCUIL As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents lblEdad As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblFechaNacimiento As Label
	Friend WithEvents lblBocaExpendio As Label
	Friend WithEvents lblNumeroBocaExpendio As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblUATRE As Label
	Friend WithEvents lblGenero As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents lblRelacion As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents btnTitular As Button
	Friend WithEvents gbCondicionAfiliatoria As GroupBox
	Friend WithEvents nudAno As NumericUpDown
	Friend WithEvents Label11 As Label
	Friend WithEvents lvCondicionAfiliatoria As ListView
	Friend WithEvents btnFiltrar As Button
	Friend WithEvents btnGrupoFamiliar As Button
End Class
