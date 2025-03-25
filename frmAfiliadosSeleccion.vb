Imports Microsoft.Office.Interop.Excel

Public Class frmAfiliadosSeleccion

#Region "Propiedades públicas"

	Private mAfiliados As Entidades.Afiliados
	''' <summary>
	''' Propiedad que indica el o la Afiliados
	''' </summary>
	''' <value>mAfiliados valor del tipo Entidades.Afiliados.</value>
	''' <returns>mAfiliados valor del tipo Entidades.Afiliados.</returns>
	''' <remarks>Propiedad Afiliados.</remarks>
	Public Property _Afiliados() As Entidades.Afiliados
		Get
			Return mAfiliados
		End Get
		Set(ByVal value As Entidades.Afiliados)
			mAfiliados = value
		End Set
	End Property

#End Region

#Region "Declaraciones"

	Dim Sugerencias As New ToolTip

#End Region

#Region "Métodos públicos"

	''' <summary>
	''' Procedimiento ejecutado al instanciar la clase
	''' </summary>
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Inicializa las propiedades
		mAfiliados = New Entidades.Afiliados
	End Sub

#End Region

#Region "Métodos privados"

	''' <summary>
	''' Procedimiento utilizado para inicializar el formulrio
	''' </summary>
	''' <remarks></remarks>
	Private Sub Inicializar()
		Try
			'Carga las sugerencias
			Call CargarSugerencias()
			'Configura el control ListView
			Call ConfigurarListView()
			'Ubica el foco
			btnBuscar.Focus()
		Catch ex As Exception
			'Genera mensaje de error
			Dim MsgError As String = "Se generó un error al inicializar el formulario." & vbCrLf & vbCrLf & ex.Message
			MessageBox.Show(MsgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			'Cierra el formulario
			Me.Close()
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para cargar las sugerencia de los controles
	''' </summary>
	''' <remarks></remarks>
	Private Sub CargarSugerencias()
		Try
			With Sugerencias
				'Habilitación de los controles de tareas generales
				.SetToolTip(btnBuscar, "Buscar")
				.SetToolTip(btnSeleccionar, "Seleccionar")
				.SetToolTip(btnCancelar, "Cancelar")
			End With
		Catch ex As Exception
			'Presenta mensaje de error
			Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
			Throw New ArgumentException(CadenaMsg)
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para configurar el control ListView
	''' </summary>
	''' <remarks></remarks>
	Private Sub ConfigurarListView()
		With lvAfiliados
			'Definiciones generales del control
			.View = View.Details
			.GridLines = True
			.FullRowSelect = True
			.MultiSelect = False
			.ShowItemToolTips = True
			'Inserta las nuevas columnas
			.Columns.Add("DNI")
			.Columns.Add("CUIL")
			.Columns.Add("Apellidos y Nombres")
			.Columns.Add("CUIL Tit.")
			'Alineación de los textos
			.Columns(0).TextAlign = HorizontalAlignment.Right
			.Columns(1).TextAlign = HorizontalAlignment.Right
			.Columns(2).TextAlign = HorizontalAlignment.Left
			.Columns(3).TextAlign = HorizontalAlignment.Right
			'Definición del tamaño de las columnas
			.Columns(0).Width = 50
			.Columns(1).Width = 50
			.Columns(3).Width = 50
			.Columns(2).Width = .Width - .Columns(0).Width - .Columns(1).Width - .Columns(3).Width - 5
		End With
	End Sub




#End Region

#Region "Métodos relacionados a los controles"

	Private Sub frmAfiliadosSeleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Inicializar()
	End Sub

	Private Sub frmAfiliadosSeleccion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmAfiliadosSeleccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

	Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

	End Sub

	Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown

	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

	End Sub

	Private Sub lvAfiliados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAfiliados.SelectedIndexChanged

	End Sub

	Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

	End Sub

	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		'Cierra el formulario
		Me.Close()
	End Sub

#End Region

End Class
