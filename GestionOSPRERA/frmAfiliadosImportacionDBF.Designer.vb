<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAfiliadosImportacionDBF
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAfiliadosImportacionDBF))
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
		Me.gbArchivo = New System.Windows.Forms.GroupBox()
		Me.nudContinuarRegistro = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.chkDetenerErrores = New System.Windows.Forms.CheckBox()
		Me.btnEjecutar = New System.Windows.Forms.Button()
		Me.btnAchivo = New System.Windows.Forms.Button()
		Me.txtArchivo = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.pbBarraProgreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblMensajeProgreso = New System.Windows.Forms.ToolStripStatusLabel()
		Me.rbImportarUnoAUno = New System.Windows.Forms.RadioButton()
		Me.rbrbImportarTodos = New System.Windows.Forms.RadioButton()
		Me.gbArchivo.SuspendLayout()
		CType(Me.nudContinuarRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ssBarraEstado.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnCerrar
		'
		Me.btnCerrar.ImageKey = "Cerrar"
		Me.btnCerrar.ImageList = Me.Iconos
		Me.btnCerrar.Location = New System.Drawing.Point(459, 175)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
		Me.btnCerrar.TabIndex = 53
		Me.btnCerrar.UseVisualStyleBackColor = True
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
		'gbArchivo
		'
		Me.gbArchivo.Controls.Add(Me.rbrbImportarTodos)
		Me.gbArchivo.Controls.Add(Me.rbImportarUnoAUno)
		Me.gbArchivo.Controls.Add(Me.nudContinuarRegistro)
		Me.gbArchivo.Controls.Add(Me.Label2)
		Me.gbArchivo.Controls.Add(Me.chkDetenerErrores)
		Me.gbArchivo.Controls.Add(Me.btnEjecutar)
		Me.gbArchivo.Controls.Add(Me.btnAchivo)
		Me.gbArchivo.Controls.Add(Me.txtArchivo)
		Me.gbArchivo.Controls.Add(Me.Label1)
		Me.gbArchivo.Location = New System.Drawing.Point(12, 12)
		Me.gbArchivo.Name = "gbArchivo"
		Me.gbArchivo.Size = New System.Drawing.Size(477, 157)
		Me.gbArchivo.TabIndex = 54
		Me.gbArchivo.TabStop = False
		'
		'nudContinuarRegistro
		'
		Me.nudContinuarRegistro.Location = New System.Drawing.Point(136, 101)
		Me.nudContinuarRegistro.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
		Me.nudContinuarRegistro.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudContinuarRegistro.Name = "nudContinuarRegistro"
		Me.nudContinuarRegistro.Size = New System.Drawing.Size(87, 20)
		Me.nudContinuarRegistro.TabIndex = 59
		Me.nudContinuarRegistro.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 103)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 13)
		Me.Label2.TabIndex = 58
		Me.Label2.Text = "Continuar desde registro:"
		'
		'chkDetenerErrores
		'
		Me.chkDetenerErrores.AutoSize = True
		Me.chkDetenerErrores.Location = New System.Drawing.Point(9, 69)
		Me.chkDetenerErrores.Name = "chkDetenerErrores"
		Me.chkDetenerErrores.Size = New System.Drawing.Size(180, 17)
		Me.chkDetenerErrores.TabIndex = 57
		Me.chkDetenerErrores.Text = "Detener importación ante errores"
		Me.chkDetenerErrores.UseVisualStyleBackColor = True
		'
		'btnEjecutar
		'
		Me.btnEjecutar.ImageKey = "Ejecutar"
		Me.btnEjecutar.ImageList = Me.Iconos
		Me.btnEjecutar.Location = New System.Drawing.Point(357, 86)
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(30, 30)
		Me.btnEjecutar.TabIndex = 56
		Me.btnEjecutar.UseVisualStyleBackColor = True
		'
		'btnAchivo
		'
		Me.btnAchivo.ImageKey = "Carpeta"
		Me.btnAchivo.ImageList = Me.Iconos
		Me.btnAchivo.Location = New System.Drawing.Point(438, 21)
		Me.btnAchivo.Name = "btnAchivo"
		Me.btnAchivo.Size = New System.Drawing.Size(30, 30)
		Me.btnAchivo.TabIndex = 55
		Me.btnAchivo.UseVisualStyleBackColor = True
		'
		'txtArchivo
		'
		Me.txtArchivo.Location = New System.Drawing.Point(143, 26)
		Me.txtArchivo.Name = "txtArchivo"
		Me.txtArchivo.ReadOnly = True
		Me.txtArchivo.Size = New System.Drawing.Size(289, 20)
		Me.txtArchivo.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(131, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Archivo de base de datos:"
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgreso, Me.lblMensajeProgreso})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 208)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(500, 22)
		Me.ssBarraEstado.SizingGrip = False
		Me.ssBarraEstado.TabIndex = 55
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
		'rbImportarUnoAUno
		'
		Me.rbImportarUnoAUno.AutoSize = True
		Me.rbImportarUnoAUno.Checked = True
		Me.rbImportarUnoAUno.Location = New System.Drawing.Point(9, 134)
		Me.rbImportarUnoAUno.Name = "rbImportarUnoAUno"
		Me.rbImportarUnoAUno.Size = New System.Drawing.Size(114, 17)
		Me.rbImportarUnoAUno.TabIndex = 60
		Me.rbImportarUnoAUno.TabStop = True
		Me.rbImportarUnoAUno.Text = "Importar uno a uno"
		Me.rbImportarUnoAUno.UseVisualStyleBackColor = True
		'
		'rbrbImportarTodos
		'
		Me.rbrbImportarTodos.AutoSize = True
		Me.rbrbImportarTodos.Location = New System.Drawing.Point(143, 134)
		Me.rbrbImportarTodos.Name = "rbrbImportarTodos"
		Me.rbrbImportarTodos.Size = New System.Drawing.Size(123, 17)
		Me.rbrbImportarTodos.TabIndex = 61
		Me.rbrbImportarTodos.Text = "Importar todos juntos"
		Me.rbrbImportarTodos.UseVisualStyleBackColor = True
		'
		'frmAfiliadosImportacionDBF
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(500, 230)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.Controls.Add(Me.gbArchivo)
		Me.Controls.Add(Me.btnCerrar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "frmAfiliadosImportacionDBF"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Importación de afiliados DBF"
		Me.gbArchivo.ResumeLayout(False)
		Me.gbArchivo.PerformLayout()
		CType(Me.nudContinuarRegistro, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnCerrar As Button
	Friend WithEvents Iconos As ImageList
	Friend WithEvents gbArchivo As GroupBox
	Friend WithEvents txtArchivo As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnAchivo As Button
	Friend WithEvents btnEjecutar As Button
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents pbBarraProgreso As ToolStripProgressBar
	Friend WithEvents lblMensajeProgreso As ToolStripStatusLabel
	Friend WithEvents chkDetenerErrores As CheckBox
	Friend WithEvents nudContinuarRegistro As NumericUpDown
	Friend WithEvents Label2 As Label
	Friend WithEvents rbImportarUnoAUno As RadioButton
	Friend WithEvents rbrbImportarTodos As RadioButton
End Class
