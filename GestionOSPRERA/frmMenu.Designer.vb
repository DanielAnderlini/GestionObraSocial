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
		Me.mAfiliados = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportaciones = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportacionesAfiliadosDBF = New System.Windows.Forms.ToolStripMenuItem()
		Me.miImportacionesCondiciónAfiliatoriaDBF = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
		Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblEquipo = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ilIconos = New System.Windows.Forms.ImageList(Me.components)
		Me.miConsultasAfiliado = New System.Windows.Forms.ToolStripMenuItem()
		Me.msMenuPrincipal.SuspendLayout()
		Me.ssBarraEstado.SuspendLayout()
		Me.SuspendLayout()
		'
		'msMenuPrincipal
		'
		Me.msMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mArchivo, Me.mAfiliados})
		Me.msMenuPrincipal.Location = New System.Drawing.Point(0, 0)
		Me.msMenuPrincipal.Name = "msMenuPrincipal"
		Me.msMenuPrincipal.Size = New System.Drawing.Size(950, 24)
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
		'mAfiliados
		'
		Me.mAfiliados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.miImportaciones})
		Me.mAfiliados.Name = "mAfiliados"
		Me.mAfiliados.Size = New System.Drawing.Size(65, 20)
		Me.mAfiliados.Text = "A&filiados"
		'
		'miImportaciones
		'
		Me.miImportaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miImportacionesAfiliadosDBF, Me.miImportacionesCondiciónAfiliatoriaDBF})
		Me.miImportaciones.Name = "miImportaciones"
		Me.miImportaciones.Size = New System.Drawing.Size(321, 22)
		Me.miImportaciones.Text = "Importaciones"
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
		'ConsultasToolStripMenuItem
		'
		Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miConsultasAfiliado})
		Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
		Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(321, 22)
		Me.ConsultasToolStripMenuItem.Text = "Consultas"
		'
		'ssBarraEstado
		'
		Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEquipo})
		Me.ssBarraEstado.Location = New System.Drawing.Point(0, 521)
		Me.ssBarraEstado.Name = "ssBarraEstado"
		Me.ssBarraEstado.ShowItemToolTips = True
		Me.ssBarraEstado.Size = New System.Drawing.Size(950, 22)
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
		'miConsultasAfiliado
		'
		Me.miConsultasAfiliado.Name = "miConsultasAfiliado"
		Me.miConsultasAfiliado.Size = New System.Drawing.Size(180, 22)
		Me.miConsultasAfiliado.Text = "Afiliado"
		'
		'frmMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(950, 543)
		Me.Controls.Add(Me.ssBarraEstado)
		Me.Controls.Add(Me.msMenuPrincipal)
		Me.MainMenuStrip = Me.msMenuPrincipal
		Me.Name = "frmMenu"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Sistema de Información para la Gestión de OSPRERA"
		Me.msMenuPrincipal.ResumeLayout(False)
		Me.msMenuPrincipal.PerformLayout()
		Me.ssBarraEstado.ResumeLayout(False)
		Me.ssBarraEstado.PerformLayout()
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
	Friend WithEvents miImportaciones As ToolStripMenuItem
	Friend WithEvents miImportacionesAfiliadosDBF As ToolStripMenuItem
	Friend WithEvents miImportacionesCondiciónAfiliatoriaDBF As ToolStripMenuItem
	Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents miConsultasAfiliado As ToolStripMenuItem
End Class
