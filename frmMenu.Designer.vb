<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
		Me.msMenuPrincipal = New System.Windows.Forms.MenuStrip()
		Me.mArchivo = New System.Windows.Forms.ToolStripMenuItem()
		Me.mArchivoSalir = New System.Windows.Forms.ToolStripMenuItem()
		Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.miCategoríasConsulta = New System.Windows.Forms.ToolStripMenuItem()
		Me.miCategoriasImportacionesXLS = New System.Windows.Forms.ToolStripMenuItem()
		Me.mAfiliados = New System.Windows.Forms.ToolStripMenuItem()
		Me.miAfiliadosConsultas = New System.Windows.Forms.ToolStripMenuItem()
		Me.miConsultasAfiliado = New System.Windows.Forms.ToolStripMenuItem()
		Me.miConsultasAfiliadosPorAno = New System.Windows.Forms.ToolStripMenuItem()
		Me.miAfiliadosImportaciones = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportacionesAfiliadosDBF = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportacionesCondiciónAfiliatoriaDBF = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConsultasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportacionesProveedoresDBF = New System.Windows.Forms.ToolStripMenuItem()
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblEquipo = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ilIconos = New System.Windows.Forms.ImageList(Me.components)
		Me.pbFondo = New System.Windows.Forms.PictureBox()
		Me.msMenuPrincipal.SuspendLayout()
		Me.ssBarraEstado.SuspendLayout()
		CType(Me.pbFondo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'msMenuPrincipal
		'
		Me.msMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mArchivo, Me.MaestrosToolStripMenuItem, Me.mAfiliados, Me.ProveedoresToolStripMenuItem})
		Me.msMenuPrincipal.Location = New System.Drawing.Point(0, 0)
		Me.msMenuPrincipal.Name = "msMenuPrincipal"
		Me.msMenuPrincipal.Size = New System.Drawing.Size(984, 24)
		Me.msMenuPrincipal.TabIndex = 0
		Me.msMenuPrincipal.Text = "MenuStrip1"
		'
		'mArchivo
		'
		Me.mArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mArchivoSalir})
		Me.mArchivo.Name = "mArchivo"
		Me.mArchivo.Size = New System.Drawing.Size(60, 20)
		Me.mArchivo.Text = "&Archivo"
		'
		'mArchivoSalir
		'
		Me.mArchivoSalir.Name = "mArchivoSalir"
		Me.mArchivoSalir.Size = New System.Drawing.Size(96, 22)
		Me.mArchivoSalir.Text = "&Salir"
		'
		'MaestrosToolStripMenuItem
		'
		Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCategoríasConsulta, Me.miCategoriasImportacionesXLS})
		Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
		Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
		Me.MaestrosToolStripMenuItem.Text = "Categorías"
		'
		'miCategoríasConsulta
		'
		Me.miCategoríasConsulta.Name = "miCategoríasConsulta"
		Me.miCategoríasConsulta.Size = New System.Drawing.Size(195, 22)
		Me.miCategoríasConsulta.Text = "Consultas"
		'
		'miCategoriasImportacionesXLS
		'
		Me.miCategoriasImportacionesXLS.Name = "miCategoriasImportacionesXLS"
		Me.miCategoriasImportacionesXLS.Size = New System.Drawing.Size(195, 22)
		Me.miCategoriasImportacionesXLS.Text = "Importación desde XLS"
		'
		'mAfiliados
		'
		Me.mAfiliados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAfiliadosConsultas, Me.miAfiliadosImportaciones})
		Me.mAfiliados.Name = "mAfiliados"
		Me.mAfiliados.Size = New System.Drawing.Size(65, 20)
		Me.mAfiliados.Text = "A&filiados"
		'
		'miAfiliadosConsultas
		'
		Me.miAfiliadosConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miConsultasAfiliado, Me.miConsultasAfiliadosPorAno})
		Me.miAfiliadosConsultas.Name = "miAfiliadosConsultas"
		Me.miAfiliadosConsultas.Size = New System.Drawing.Size(150, 22)
		Me.miAfiliadosConsultas.Text = "Consultas"
		'
		'miConsultasAfiliado
		'
		Me.miConsultasAfiliado.Name = "miConsultasAfiliado"
		Me.miConsultasAfiliado.Size = New System.Drawing.Size(164, 22)
		Me.miConsultasAfiliado.Text = "Afiliado"
		'
		'miConsultasAfiliadosPorAno
		'
		Me.miConsultasAfiliadosPorAno.Name = "miConsultasAfiliadosPorAno"
		Me.miConsultasAfiliadosPorAno.Size = New System.Drawing.Size(164, 22)
		Me.miConsultasAfiliadosPorAno.Text = "Afiliados por año"
		'
		'miAfiliadosImportaciones
		'
		Me.miAfiliadosImportaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miImportacionesAfiliadosDBF, Me.miImportacionesCondiciónAfiliatoriaDBF})
		Me.miAfiliadosImportaciones.Name = "miAfiliadosImportaciones"
		Me.miAfiliadosImportaciones.Size = New System.Drawing.Size(150, 22)
		Me.miAfiliadosImportaciones.Text = "Importaciones"
		'
		'miImportacionesAfiliadosDBF
		'
		Me.miImportacionesAfiliadosDBF.Name = "miImportacionesAfiliadosDBF"
		Me.miImportacionesAfiliadosDBF.Size = New System.Drawing.Size(239, 22)
		Me.miImportacionesAfiliadosDBF.Text = "Afiliados desde DBF"
		'
		'miImportacionesCondiciónAfiliatoriaDBF
		'
		Me.miImportacionesCondiciónAfiliatoriaDBF.Name = "miImportacionesCondiciónAfiliatoriaDBF"
		Me.miImportacionesCondiciónAfiliatoriaDBF.Size = New System.Drawing.Size(239, 22)
		Me.miImportacionesCondiciónAfiliatoriaDBF.Text = "Condición afiliatoria desde DBF"
		'
		'ProveedoresToolStripMenuItem
		'
		Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem1, Me.ImportacionesToolStripMenuItem})
		Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
		Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
		Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
		'
		'ConsultasToolStripMenuItem1
		'
		Me.ConsultasToolStripMenuItem1.Name = "ConsultasToolStripMenuItem1"
		Me.ConsultasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
		Me.ConsultasToolStripMenuItem1.Text = "Consultas"
		'
		'ImportacionesToolStripMenuItem
		'
		Me.ImportacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miImportacionesProveedoresDBF})
		Me.ImportacionesToolStripMenuItem.Name = "ImportacionesToolStripMenuItem"
		Me.ImportacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ImportacionesToolStripMenuItem.Text = "Importaciones"
		'
		'miImportacionesProveedoresDBF
		'
		Me.miImportacionesProveedoresDBF.Name = "miImportacionesProveedoresDBF"
		Me.miImportacionesProveedoresDBF.Size = New System.Drawing.Size(195, 22)
		Me.miImportacionesProveedoresDBF.Text = "Proveedores desde XLS"
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEquipo})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 539)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(984, 22)
		Me.ssBarraEstado.SizingGrip = False
		Me.ssBarraEstado.TabIndex = 56
		'
		'lblUsuario
		'
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(47, 17)
		Me.lblUsuario.Text = "Usuario"
		'
		'lblEquipo
		'
		Me.lblEquipo.Name = "lblEquipo"
		Me.lblEquipo.Size = New System.Drawing.Size(44, 17)
		Me.lblEquipo.Text = "Equipo"
		'
		'ilIconos
		'
		Me.ilIconos.ImageStream = CType(resources.GetObject("ilIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilIconos.TransparentColor = System.Drawing.Color.Transparent
		Me.ilIconos.Images.SetKeyName(0, "Usuario")
		Me.ilIconos.Images.SetKeyName(1, "Equipo")
		'
		'pbFondo
		'
		Me.pbFondo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbFondo.Location = New System.Drawing.Point(12, 27)
		Me.pbFondo.Name = "pbFondo"
		Me.pbFondo.Size = New System.Drawing.Size(960, 509)
		Me.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.pbFondo.TabIndex = 57
		Me.pbFondo.TabStop = False
		'
		'frmMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(984, 561)
		Me.Controls.Add(Me.pbFondo)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.Controls.Add(Me.msMenuPrincipal)
		Me.MainMenuStrip = Me.msMenuPrincipal
		Me.Name = "frmMenu"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Sistema de Información para la Gestión de OSPRERA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.msMenuPrincipal.ResumeLayout(False)
		Me.msMenuPrincipal.PerformLayout()
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
		CType(Me.pbFondo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents msMenuPrincipal As MenuStrip
	Friend WithEvents mArchivo As ToolStripMenuItem
	Friend WithEvents mArchivoSalir As ToolStripMenuItem
	Friend WithEvents mAfiliados As ToolStripMenuItem
	Friend WithEvents ssBarraEstado As StatusStrip
	Friend WithEvents lblUsuario As ToolStripStatusLabel
	Friend WithEvents lblEquipo As ToolStripStatusLabel
	Friend WithEvents ilIconos As ImageList
	Friend WithEvents miAfiliadosImportaciones As ToolStripMenuItem
	Friend WithEvents miImportacionesAfiliadosDBF As ToolStripMenuItem
	Friend WithEvents miImportacionesCondiciónAfiliatoriaDBF As ToolStripMenuItem
	Friend WithEvents miAfiliadosConsultas As ToolStripMenuItem
	Friend WithEvents miConsultasAfiliado As ToolStripMenuItem
	Friend WithEvents miConsultasAfiliadosPorAno As ToolStripMenuItem
	Friend WithEvents pbFondo As PictureBox
	Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ConsultasToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ImportacionesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents miImportacionesProveedoresDBF As ToolStripMenuItem
	Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents miCategoríasConsulta As ToolStripMenuItem
	Friend WithEvents miCategoriasImportacionesXLS As ToolStripMenuItem
End Class
