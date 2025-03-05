Imports System.IO
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

#End Region

End Class
