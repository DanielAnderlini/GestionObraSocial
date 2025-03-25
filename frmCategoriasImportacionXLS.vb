Imports System.IO
Imports System.IO.Stream
Imports System.Net.WebRequestMethods
Imports Microsoft.Office.Interop
Public Class frmCategoriasImportacionXLS

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

	Dim Entidades As New List(Of String)
	Dim EntidadesRelacionadas As New List(Of String)

	Dim Procesando As Boolean = False

	Dim Sugerencias As New ToolTip

#End Region

#Region "Métodos públicos"

#End Region

#Region "Métodos privados"

	''' <summary>
	''' Procedimiento utilizado para inicializar el formulrio
	''' </summary>
	''' <remarks></remarks>
	Private Sub Inicializar()
		Try
			'Actualiza la barra de estado
			Call ActualizaBarraEstado()
			'Carga las sugerencias
			Call CargarSugerencias()
			'Carga los controles ComboBox
			Call ControlComboBox()
			'Inicializa controles
			rbNuevaEntidad.Checked = True
			txtEntidad.Enabled = True
			cbEntidadRelacionada.Enabled = False
			'Ubica el foco
			btnArchivo.Focus()
		Catch ex As Exception
			'Genera mensaje de error
			Dim MsgError As String = "Se generó un error al inicializar el formulario." & vbCrLf & vbCrLf & ex.Message
			MessageBox.Show(MsgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			'Cierra el formulario
			Me.Close()
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para actualizar la barra de estado
	''' </summary>
	''' <remarks></remarks>
	Private Sub ActualizaBarraEstado()
		Try
			'Indica cual es la lista de imagenes que utiliza la barra de estado
			ssBarraEstado.ImageList = Iconos
			'Inicializa las etiquetas de la barra de estado
			lblMensajeProgreso.Text = ""
		Catch ex As Exception
			Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: ActualizaBarraEstado"
			Throw New ArgumentException(CadenaMsg)
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
				.SetToolTip(btnArchivo, "Seleccionar archivo")
				.SetToolTip(btnEjecutar, "Ejecutar")
				.SetToolTip(btnCerrar, "Cerrar")
			End With
		Catch ex As Exception
			'Presenta mensaje de error
			Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
			Throw New ArgumentException(CadenaMsg)
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para cargar la lista de las distintas entidades desde la base de datos
	''' </summary>
	''' <remarks></remarks>
	Private Sub CargarEntidades()
		Dim CapaNeg As New CapaNegocios.Categorias
		Try
			'Inicializa la colección
			If Entidades.Count > 0 Then Entidades.Clear()
			'Consulta a los datos de la base de datos:
			Entidades = CapaNeg.ConsultaEntidades(CadenaConexion, TipoBaseDatos)
		Catch ex As Exception
			'Presenta mensaje de error
			MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			'Libera el objeto utilizado para recuperar los datos
			CapaNeg = Nothing
		End Try
	End Sub

	''' <summary>
	''' Carga los controles ComboBox
	''' </summary>
	Private Sub ControlComboBox()
		'Carga la lista de distintas entidades
		Call CargarEntidades()
		'Carga el control ComboBox
		With cbEntidad
			.Items.Clear()
			For Each entidad As String In Entidades
				.Items.Add(entidad)
			Next
			If .Items.Count > 0 Then
				.Text = .Items(0)
			End If
		End With
	End Sub

	''' <summary>
	''' Proceso utilizado para evaluar si existen instancias de MS Excel abiertas
	''' </summary>
	Private Function ProcesosAbiertos() As Boolean
		Dim Valor As Boolean = True
		Dim Proceso As Process
		Dim CadenaMsg As String = "Los siguientes procesos están abiertos y son necesarios cerrarlos para empezar el proceso:" & vbCrLf & vbCrLf
		Dim Contador As Int16 = 0
		For Each Proceso In Process.GetProcesses()
			If Not Proceso Is Nothing Then
				If Proceso.ProcessName.Trim.ToUpper = "EXCEL" Then
					Contador += 1
					CadenaMsg &= vbCrLf & Proceso.Id.ToString.Trim & ") " & Proceso.ProcessName & " -> " & Proceso.MainWindowTitle
				End If
			End If
		Next
		If Contador > 0 Then
			Valor = False
			CadenaMsg &= vbCrLf & vbCrLf & "¿Desea que este sistema los cierre? Tenga en cuenta que si el sistema los cierra los cambios realizados no serán guardados."
			If MessageBox.Show(CadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				For Each Proceso In Process.GetProcesses()
					If Not Proceso Is Nothing Then
						If Proceso.ProcessName.Trim.ToUpper = "EXCEL" Then
							Proceso.Kill()
						End If
					End If
				Next
				Valor = True
			End If
		Else
			Valor = True
		End If
		Return Valor
	End Function

	''' <summary>
	''' Función utilizada para validar los parámetros de proceso
	''' </summary>
	''' <returns>Valor boolenao que indica si los parámetros se encuentran validados.</returns>
	''' <remarks></remarks>
	Private Function Validar() As Boolean
		Dim Valor As Boolean = True
		Dim CadenaMsg As String = ""
		'Valida la selección de archivo
		If Valor = True Then
			If txtArchivo.Text.Trim.Length = 0 Then
				'Cambia el valor de la salida de la función
				Valor = False
				'Define el mensaje de error
				CadenaMsg = "No se definió el archivo utilizado para el proceso."
			End If
		End If
		'Evalúa el resultado de la validación
		If Valor = False Then
			'Presenta mensaje de error
			MessageBox.Show(CadenaMsg, "Error de parametrización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If
		'Valor de retorno de la función
		Return Valor
	End Function

	''' <summary>
	''' Procedimiento utilizado para importar los datos de los bonos desde una planilla de MS Excel
	''' </summary>
	Private Sub Importar()
		Dim categorias As New Entidades.Categorias
		'Cambia el valor de la variable bandera
		Procesando = True
		'Valida los parámetros de proceso
		If Validar() = True Then
			'Proceso de lectura de datos desde MS Excel
			'------------------------------------------
			'Cierra las instancias de MS Excel abierta
			Call ProcesosAbiertos()
			'Inicializa la colección utilizada para importar los datos
			If categorias.Count > 0 Then categorias.Clear()
			'Declaración de objetos relacionados al Microsoft Excel
			Dim Aplicacion As New Microsoft.Office.Interop.Excel.Application
			Dim Libro As Microsoft.Office.Interop.Excel.Workbook
			Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet
			Dim Celda As Object = Nothing
			Dim entidad As String = ""
			Dim codigo As String = ""
			Dim descripcion As String = ""
			Dim codigoRelacionado As String = ""
			Dim fila As Int32 = 0
			Dim continuar As Boolean = True
			Try
				'Inicialización de los controles de progreso
				lblMensajeProgreso.Text = ""
				lblMensajeProgreso.Visible = True
				pbBarraProgreso.Visible = True
				pbBarraProgreso.Minimum = nudFilaInicial.Value
				'pbBarraProgreso.Maximum = nudFilaFinal.Value
				'Definición del mensaje de progreso indicando la tarea realizada
				lblMensajeProgreso.Text = "Abriendo archivo"
				My.Application.DoEvents()
				'Instanciación de la clase aplicación
				Aplicacion = New Microsoft.Office.Interop.Excel.Application
				'Creación del libro (archivo de excel) y la hoja
				Libro = Aplicacion.Workbooks.Open(txtArchivo.Text)
				'Asigna una hoja al libro insertado
				Hoja = Libro.Worksheets(nudHoja.Value)
				'Define sobre que entidad se importará
				If rbNuevaEntidad.Checked = True Then
					entidad = txtEntidad.Text.Trim.ToUpper
				Else
					If rbEntidad.Checked = True Then
						entidad = cbEntidad.Text.Trim.ToUpper
					End If
				End If
				'Evalúa que se haya definido una entidad sobre la cual se hará la importación
				If entidad.Trim.Length > 0 Then
					'Asigna la primera fila e importación
					fila = nudFilaInicial.Value
					While continuar = True
						'Inicializa las variables
						cadenaMsg = ""
						codigo = ""
						descripcion = ""
						codigoRelacionado = ""
						'Actualiza los controles de progreso
						lblMensajeProgreso.Text = "Leyendo fila N° " & fila.ToString.Trim
						My.Application.DoEvents()
						'Lee el código
						Try
							Celda = Hoja.Cells(fila, nudCodigo.Value).Value
							If Not Celda = Nothing Then
								codigo = Celda.ToString.Trim.ToUpper
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el código de la fila N° " & fila.ToString.Trim
						End Try
						'Lee la descripción
						Try
							Celda = Hoja.Cells(fila, nudDescripcion.Value).Value
							If Not Celda = Nothing Then
								descripcion = Celda.ToString.Trim.ToUpper
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer la descripción de la fila N° " & fila.ToString.Trim
						End Try
						'Evalúa si hubo error en la lectura de datos
						If cadenaMsg.Trim.Length = 0 Then
							'Define los datos de una nueva categoría
							Dim categoria As New Entidades.Categoria
							With categoria
								.Entidad = entidad
								.Codigo = codigo
								.Descripcion = descripcion
								.Habilitado = True
							End With
							'Agrega la nueva categoría
							categorias.Add(categoria)
							'Libera el objeto usado para la definición de datos
							categoria = Nothing
						Else
							'Genera un nuevo mensaje de error
							If MessageBox.Show(cadenaMsg, "Error de importación", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) = DialogResult.No Then
								Exit Sub
							End If
						End If
						'Lee el siguiente código para evaluar si se continúa el proecso de lectura
						codigo = ""
						Celda = Hoja.Cells(fila + 1, nudCodigo.Value).Value
						If Not Celda = Nothing Then
							codigo = Celda.ToString.Trim.ToUpper
						End If
						If codigo.Trim.Length > 0 Then
							'Incrementa el contador de filas
							fila += 1
							'Indica que el proceso de lectura continúa
							continuar = True
						Else
							'Indica que el proceso de lectura finaliza
							continuar = False
						End If
					End While
					'Evalúa si de almacenarán los datos leídos
					If categorias.Count > 0 Then
						'Solicita confirmación
						cadenaMsg = "Se leyeron " & categorias.Count.ToString.Trim & " datos."
						cadenaMsg &= vbCrLf & "¿Desea almacenarlos?"
						If MessageBox.Show(cadenaMsg, "Importación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
							Dim contadorAltas As Int16 = 0
							Dim contadorModificaciones As Int16 = 0
							'Recorrido secuencial por la colección de datos leídos
							For Each categoria As Entidades.Categoria In categorias
								'Consulta si existe por su código
								Dim capaNeg As New CapaNegocios.Categorias
								Dim categoriasConsultadas As New Entidades.Categorias
								Try
									categoriasConsultadas = capaNeg.ConsultaCodigo(CadenaConexion, TipoBaseDatos, categoria.Entidad, categoria.Codigo)
									If categoriasConsultadas.Count = 0 Then
										'Alta de la categoría
										Call capaNeg.Alta(CadenaConexion, TipoBaseDatos, categoria)
										'Incrementa el contador de altas
										contadorAltas += 1
									Else
										'Modifica la categoría
										Call capaNeg.Modificar(CadenaConexion, TipoBaseDatos, categoria)
										'Incrementa el contador de modificaciones
										contadorModificaciones += 1
									End If
								Catch ex As Exception
									cadenaMsg = "Se generó un error al tratar de almacenar la categoría con código " & Chr(32) & categoria.Codigo & Chr(32) & "."
									cadenaMsg &= vbCrLf & ex.Message
									cadenaMsg &= vbCrLf & vbCrLf & "¿Desea continuar?"
									If MessageBox.Show(cadenaMsg, "Error de importación", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
										Exit For
									End If
								End Try
							Next
							'Genera el mensaje de fin de proceso
							cadenaMsg = "El proceso de importación finalizó."
							cadenaMsg &= vbCrLf & ""
							cadenaMsg &= vbCrLf & "   Leídos = " & categorias.Count.ToString.Trim
							cadenaMsg &= vbCrLf & "   Altas = " & contadorAltas.ToString.Trim
							cadenaMsg &= vbCrLf & "   Altas = " & contadorModificaciones.ToString.Trim
							MessageBox.Show(cadenaMsg, "Importación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End If
				Else
					'Genera un nuevo mensaje de error
					cadenaMsg = "No se definió la entidad sobre la cual se hará la importación."
					Throw New ArgumentException(cadenaMsg)
				End If
			Catch ex As Exception
				'Presenta el error de lectura de los datos de la fila
				cadenaMsg = "Se generó un error al tratar de abrir el archivo y leer los datos a importar."
				cadenaMsg &= vbCrLf & ex.Message
			Finally
				'Cierra el libro
				Libro.Close()
				'Cierra la aplicación
				Aplicacion.Quit()
				'Libera los objetos utilizados
				Aplicacion = Nothing
				Libro = Nothing
				Hoja = Nothing
			End Try
		End If
		'Cambia el valor de la variable bandera
		Procesando = False
	End Sub

#End Region

#Region "Métodos relacionados a los controles"

	Private Sub frmcategoriasImportacionXLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Inicializar()
	End Sub

	Private Sub frmcategoriasImportacionXLS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmcategoriasImportacionXLS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		'Evalúa si se está ejecutando un proceso
		If Procesando = True Then
			e.Cancel = True
		End If
	End Sub

	Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
		Dim Dialogo As New OpenFileDialog
		'Parametrización del cuadro de dialogo
		Dialogo.Multiselect = False
		Dialogo.Filter = "MS Excel 2007/2010|*.xlsx|MS Excel 2000/2003|*.xls|Todos los archivos|*.*"
		'Presentación del cuadro de diálogo
		If Dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
			'Actualiza el control TextBox de archivo de datos
			txtArchivo.Text = Dialogo.FileName
			txtArchivo.SelectionStart = txtArchivo.Text.Length
		End If
	End Sub

	Private Sub rbNuevaEntidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbNuevaEntidad.CheckedChanged
		txtEntidad.Enabled = rbNuevaEntidad.Checked
		cbEntidadRelacionada.Enabled = rbEntidad.Checked
		txtEntidad.Focus()
	End Sub

	Private Sub rbEntidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntidad.CheckedChanged
		txtEntidad.Enabled = rbNuevaEntidad.Checked
		cbEntidadRelacionada.Enabled = rbEntidad.Checked
		cbEntidadRelacionada.Focus()
	End Sub

	Private Sub chkCodigoRelacionado_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigoRelacionado.CheckedChanged
		nudCodigoRelacionado.Enabled = chkCodigoRelacionado.Checked
		cbEntidadRelacionada.Enabled = chkCodigoRelacionado.Checked
	End Sub

	Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
		btnEjecutar.Enabled = False
		Call Importar()
		btnEjecutar.Enabled = True
	End Sub

	Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
		'Cierra el formulario
		Me.Close()
	End Sub

#End Region

End Class