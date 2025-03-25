Imports System.IO
Imports System.IO.File
Imports System.IO.Stream
Imports System.Net.WebRequestMethods
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Public Class frmMenu

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

#End Region

#Region "Métodos públicos"

#End Region

#Region "Métodos privados"

	''' <summary>
	''' Procedimiento utilizado para inicializar el formulario
	''' </summary>
	Private Sub Inicializar()
		'Actualiza la barra de estado
		Call ActualizaBarraEstado()
		'Carga imagen de fondo
		Call CargarImagenFondo()
	End Sub

	''' <summary>
	''' Procedimiento utilizado para actualizar la barra de estado
	''' </summary>
	''' <remarks></remarks>
	Private Sub ActualizaBarraEstado()
		Try
			'Indica cual es la lista de imagenes que utiliza la barra de estado
			ssBarraEstado.ImageList = ilIconos
			'Inicializa las etiquetas de la barra de estado
			lblUsuario.Text = ""
			lblEquipo.Text = ""
			'Actualiza en la barra de estado el usuario
			If userSO.Trim.Length > 0 Then
				'Actualiza el icono de la etiqueta
				lblUsuario.Text = userSO
				lblUsuario.ImageKey = "Usuario"
				lblUsuario.ToolTipText = "Usuario"
			End If
			'Actualiza en la barra de estado el usuario
			If namePC.Trim.Length > 0 Then
				'Actualiza el icono de la etiqueta
				lblEquipo.Text = namePC
				lblEquipo.ImageKey = "Equipo"
				lblEquipo.ToolTipText = "Equipo"
			End If
		Catch ex As Exception
			Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: ActualizaBarraEstado"
			Throw New ArgumentException(CadenaMsg)
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para cargar una imagen de fondo
	''' </summary>
	Private Sub CargarImagenFondo()
		'Carga imagen de fondo
		Dim rutaImagenFondo As String = pathApp & "\SIGOS.JPG"
		If My.Computer.FileSystem.FileExists(rutaImagenFondo) = True Then
			Dim imagenFondo As Image
			imagenFondo = Image.FromFile(rutaImagenFondo)
			pbFondo.Image = imagenFondo
		End If
	End Sub

#End Region

#Region "Métodos relacionados a los controles"

	Private Sub frmImportacionCruce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Inicializar()
	End Sub

	Private Sub frmImportacionCruce_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmImportacionCruce_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

	Private Sub mArchivoSalir_Click(sender As Object, e As EventArgs) Handles mArchivoSalir.Click
		'Sale de la aplicación
		End
	End Sub

	Private Sub miImportacionesAfiliadosDBF_Click(sender As Object, e As EventArgs) Handles miImportacionesAfiliadosDBF.Click
		Dim formulario As New frmAfiliadosImportacionDBF
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miImportacionesCondiciónAfiliatoriaDBF_Click(sender As Object, e As EventArgs) Handles miImportacionesCondiciónAfiliatoriaDBF.Click
		Dim formulario As New frmCondicionAfiliatoriaImportacionDBF
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miConsultasAfiliado_Click(sender As Object, e As EventArgs) Handles miConsultasAfiliado.Click
		Dim formulario As New frmCondicionAfiliatoriaAnual_Afiliado
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miConsultasAfiliadosPorAno_Click(sender As Object, e As EventArgs) Handles miConsultasAfiliadosPorAno.Click
		Dim formulario As New frmCondicionAfiliatoriaAnual_Comparacion
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miImportacionesProveedoresDBF_Click(sender As Object, e As EventArgs) Handles miImportacionesProveedoresDBF.Click
		Dim formulario As New frmProveedoresImportacionXLS
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miCategoriasImportacionesXLS_Click(sender As Object, e As EventArgs) Handles miCategoriasImportacionesXLS.Click
		Dim formulario As New frmCategoriasImportacionXLS
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub miCategoríasConsulta_Click(sender As Object, e As EventArgs) Handles miCategoríasConsulta.Click
		Dim formulario As New frmCategoriasConsultas
		formulario.Show()
		formulario.Focus()
	End Sub

	Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem1.Click
		Dim formulario As New frmProveedoresConsultas
		formulario.Show()
		formulario.Focus()
	End Sub


#End Region

End Class
