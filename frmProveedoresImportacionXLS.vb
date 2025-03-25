Imports Entidades

Public Class frmProveedoresImportacionXLS

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

	Dim Entidades As New List(Of String)
	Dim Categorias As New Entidades.Categorias
	Dim Subcategorias As New Entidades.Categorias

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
	Private Sub CargarEntidadesCategorias()
		Dim CapaNeg As New CapaNegocios.Categorias
		Try
			'Inicializa la colección
			If Categorias.Count > 0 Then Categorias.Clear()
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
		'Carga la lista de distintas entidades (categorías)
		Call CargarEntidadesCategorias()
		'Carga el control ComboBox
		cbEntidadCategoria.Items.Clear()
		cbEntidadSubcategoria.Items.Clear()
		For Each categoria As String In Entidades
			cbEntidadCategoria.Items.Add(categoria)
			cbEntidadSubcategoria.Items.Add(categoria)
		Next
		If Categorias.Count > 0 Then
			cbEntidadCategoria.Text = cbEntidadCategoria.Items(0)
			cbEntidadSubcategoria.Text = cbEntidadSubcategoria.Items(0)
		End If
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
		'Valida la selección de categorías
		If Valor = True Then
			If cbEntidadCategoria.Text.Trim.Length = 0 Then
				'Cambia el valor de la salida de la función
				Valor = False
				'Define el mensaje de error
				CadenaMsg = "No se definió la entidad que representa a la categoría."
			End If
		End If
		'Valida la selección de subcategorías
		If Valor = True Then
			If cbEntidadSubcategoria.Text.Trim.Length = 0 Then
				'Cambia el valor de la salida de la función
				Valor = False
				'Define el mensaje de error
				CadenaMsg = "No se definió la entidad que representa a la subcategoría."
			End If
		End If
		'Valida la selección de categorías y subcategorías
		If Valor = True Then
			If cbEntidadCategoria.Text.Trim.ToUpper = cbEntidadSubcategoria.Text.Trim.ToUpper Then
				'Cambia el valor de la salida de la función
				Valor = False
				'Define el mensaje de error
				CadenaMsg = "No se puede seleccionar la misma entidad de categoría que de subcategoría."
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
	''' Procedimiento utilizado para cargar la colección "Categorias" desde la base de datos
	''' </summary>
	''' <remarks></remarks>
	Private Sub CargarCategorias()
		Dim CapaNeg As New CapaNegocios.Categorias
		Try
			'Inicializa la colección
			If Categorias.Count > 0 Then Categorias.Clear()
			'Consulta a los datos de la base de datos:
			Categorias = CapaNeg.ConsultaEntidad(CadenaConexion, TipoBaseDatos, cbEntidadCategoria.Text.Trim.ToUpper)
		Catch ex As Exception
			'Presenta mensaje de error
			MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			'Libera el objeto utilizado para recuperar los datos
			CapaNeg = Nothing
		End Try
	End Sub

	''' <summary>
	''' Procedimiento utilizado para cargar la colección "Categorias" desde la base de datos
	''' </summary>
	''' <remarks></remarks>
	Private Sub CargarSubcategorias()
		Dim CapaNeg As New CapaNegocios.Categorias
		Try
			'Inicializa la colección
			If Subcategorias.Count > 0 Then Subcategorias.Clear()
			'Consulta a los datos de la base de datos:
			Subcategorias = CapaNeg.ConsultaEntidad(CadenaConexion, TipoBaseDatos, cbEntidadSubcategoria.Text.Trim.ToUpper)
		Catch ex As Exception
			'Presenta mensaje de error
			MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			'Libera el objeto utilizado para recuperar los datos
			CapaNeg = Nothing
		End Try
	End Sub

	''' <summary>
	''' Función utilizada para buscar un cateoria en la colección Categorias, según su código
	''' </summary>
	''' <param name="codigo">Obligatorio. Código de la cateoria a buscar.</param>
	''' <param name="coleccion">.Obligatorio. Colección sobre la cual se debe buscar</param>
	''' <returns>Objeto encontrado de la clase "cateoria".</returns>
	''' <remarks></remarks>
	Private Function BuscarCateoriaCodigo(ByVal coleccion As Entidades.Categorias, ByVal codigo As String) As Entidades.Categoria
		Dim Valor As New Entidades.Categoria
		'Evalúa la existencia de cateorias en la colección Categorias
		If Categorias.Count > 0 Then
			'Recorrido secuencial por la colección Categorias
			For Each Obj As Entidades.Categoria In coleccion
				'Evalúa si existe coincidencia en el identificador
				If Obj.Codigo = codigo Then
					'Define el valor de salida de la función
					Valor = Obj
					'Sale del bucle
					Exit For
				End If
			Next
		End If
		'Valor de retorno de la función
		Return Valor
	End Function


	''' <summary>
	''' Procedimiento utilizado para importar los datos de los bonos desde una planilla de MS Excel
	''' </summary>
	Private Sub Importar()
		Dim proveedores As New Entidades.Proveedores
		'Cambia el valor de la variable bandera
		Procesando = True
		'Valida los parámetros de proceso
		If Validar() = True Then
			'Proceso de lectura de datos desde MS Excel
			'------------------------------------------
			'Cierra las instancias de MS Excel abierta
			Call ProcesosAbiertos()
			'Inicializa la colección utilizada para importar los datos
			If proveedores.Count > 0 Then proveedores.Clear()
			'Carga las colecciones de categorías y subcategorías
			Call CargarCategorias()
			Call CargarSubcategorias()
			'Declaración de objetos relacionados al Microsoft Excel
			Dim Aplicacion As New Microsoft.Office.Interop.Excel.Application
			Dim Libro As Microsoft.Office.Interop.Excel.Workbook
			Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet
			Dim Celda As Object = Nothing
			Dim numeroSAP As Int64 = 0
			Dim cuit As Int64 = 0
			Dim razonSocial As String = ""
			Dim telefono As String = ""
			Dim email As String = ""
			Dim domicilio As String = ""
			Dim numeroCuenta As String = ""
			Dim cbu As String = ""
			Dim codigoCategoria As String = ""
			Dim id_categoria As Int64 = 0
			Dim codigoSubcategoria As String = ""
			Dim id_subcategoria As Int64 = 0
			Dim codigoDiasVencimiento As String = ""
			Dim diasVencimiento As Int16 = 0
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
				'Asigna la primera fila e importación
				fila = nudFilaInicial.Value
				While continuar = True
					'Inicializa las variables
					cadenaMsg = ""
					numeroSAP = 0
					cuit = 0
					razonSocial = ""
					telefono = ""
					email = ""
					domicilio = ""
					numeroCuenta = ""
					cbu = ""
					codigoCategoria = ""
					id_categoria = 0
					codigoSubcategoria = ""
					id_subcategoria = 0
					codigoDiasVencimiento = ""
					diasVencimiento = 0
					'Actualiza los controles de progreso
					lblMensajeProgreso.Text = "Leyendo fila N° " & fila.ToString.Trim
					My.Application.DoEvents()
					'Lee el número SAP
					Try
						Celda = Hoja.Cells(fila, nudNumeroSAP.Value).Value
						If Not Celda = Nothing Then
							numeroSAP = Celda
						End If
					Catch ex As Exception
						'Genera un nuevo mensaje de error
						cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el número SAP de la fila N° " & fila.ToString.Trim
						cadenaMsg &= vbCrLf & ex.Message
					End Try
					'Lee el CUIT
					Try
						Celda = Hoja.Cells(fila, nudCUIT.Value).Value
						If Not Celda = Nothing Then
							cuit = Celda
						End If
					Catch ex As Exception
						'Genera un nuevo mensaje de error
						cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el CUIT de la fila N° " & fila.ToString.Trim
						cadenaMsg &= vbCrLf & ex.Message
					End Try
					'Lee la razón social
					Try
						Celda = Hoja.Cells(fila, nudRazonSocial1.Value).Value
						If Not Celda = Nothing Then
							razonSocial = Celda.ToString.Trim.ToUpper
							If nudRazonSocial2.Value > 0 Then
								Try
									Celda = Hoja.Cells(fila, nudRazonSocial2.Value).Value
									If Not Celda = Nothing Then
										razonSocial &= Celda.ToString.Trim.ToUpper
									End If
								Catch ex As Exception
									'Genera un nuevo mensaje de error
									cadenaMsg &= vbCrLf & "Se generó un error al trata de leer la segunda parte de la razón social de la fila N° " & fila.ToString.Trim
								End Try
							End If
						End If
					Catch ex As Exception
						'Genera un nuevo mensaje de error
						cadenaMsg &= vbCrLf & "Se generó un error al trata de leer la primera parte de la razón social de la fila N° " & fila.ToString.Trim
						cadenaMsg &= vbCrLf & ex.Message
					End Try
					'Lee el teléfono
					If chkTelefono.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudTelefono.Value).Value
							If Not Celda = Nothing Then
								telefono = Celda.ToString.Trim
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el teléfono de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee el e-mail
					If chkEmail.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudEmail.Value).Value
							If Not Celda = Nothing Then
								email = Celda.ToString.Trim
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el e-mail de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee el domicilio
					If chkDomicilio.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudDomicilio.Value).Value
							If Not Celda = Nothing Then
								domicilio = Celda.ToString.Trim
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el domicilio de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee el número de cuenta
					If chkNumeroCuenta.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudNumeroCuenta.Value).Value
							If Not Celda = Nothing Then
								numeroCuenta = Celda.ToString.Trim
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el número de cuenta de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee el CBU
					If chkCBU.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudCBU.Value).Value
							If Not Celda = Nothing Then
								cbu = Celda.ToString.Trim
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer el CBU de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee la categoría
					If chkCategotia.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudCategotia.Value).Value
							If Not Celda = Nothing Then
								codigoCategoria = CInt(Celda.ToString.Trim).ToString.Trim
								Dim categoria As Entidades.Categoria = BuscarCateoriaCodigo(Categorias, codigoCategoria)
								If categoria.Id > 0 Then
									id_categoria = categoria.Id
								End If
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer la categoría de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee la subcategoría
					If chkSubcategoria.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudSubcategoria.Value).Value
							If Not Celda = Nothing Then
								codigoSubcategoria = CInt(Celda.ToString.Trim).ToString.Trim
								Dim subcategoria As Entidades.Categoria = BuscarCateoriaCodigo(Subcategorias, codigoCategoria)
								If subcategoria.Id > 0 Then
									id_subcategoria = subcategoria.Id
								End If
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer la subcategoría de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Lee los días de vencimiento
					If chkDiasVencimiento.Checked = True Then
						Try
							Celda = Hoja.Cells(fila, nudDiasVencimiento.Value).Value
							If Not Celda = Nothing Then
								codigoDiasVencimiento = Celda.ToString.Trim
								'Determinación de los días de vencimiento de acuerdo al código
								If codigoDiasVencimiento.Contains("31") Then
									diasVencimiento = 7
								End If
								If codigoDiasVencimiento.Contains("41") Then
									diasVencimiento = 15
								End If
								If codigoDiasVencimiento.Contains("51") Then
									diasVencimiento = 30
								End If
								If codigoDiasVencimiento.Contains("61") Then
									diasVencimiento = 60
								End If
							End If
						Catch ex As Exception
							'Genera un nuevo mensaje de error
							cadenaMsg &= vbCrLf & "Se generó un error al trata de leer los días de vencimiento de la fila N° " & fila.ToString.Trim
							cadenaMsg &= vbCrLf & ex.Message
						End Try
					End If
					'Evalúa si hubo error en la lectura de datos
					If cadenaMsg.Trim.Length = 0 Then
						'Define los datos de un nuevo proveedor
						Dim proveedor As New Entidades.Proveedor
						With proveedor
							.NumeroSAP = numeroSAP
							.CUIT = cuit
							.RazonSocial = razonSocial
							.Telefono = telefono
							.Email = email
							.Domicilio = domicilio
							.NumeroCuenta = numeroCuenta
							.CBU = cbu
							.Id_Categoria = id_categoria
							.Id_Subcategoria = id_subcategoria
							.DiasVencimiento = diasVencimiento
							.Habilitado = True
						End With
						'Agrega la nueva categoría
						proveedores.Add(proveedor)
						'Libera el objeto usado para la definición de datos
						proveedor = Nothing
					Else
						'Genera un nuevo mensaje de error
						If MessageBox.Show(cadenaMsg, "Error de importación", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) = DialogResult.No Then
							Exit Sub
						End If
					End If
					'Lee el siguiente código para evaluar si se continúa el proecso de lectura
					numeroSAP = 0
					Celda = Hoja.Cells(fila + 1, nudNumeroSAP.Value).Value
					If Not Celda = Nothing Then
						numeroSAP = Celda
					End If
					If numeroSAP <> 0 Then
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
				If proveedores.Count > 0 Then
					'Solicita confirmación
					cadenaMsg = "Se leyeron " & proveedores.Count.ToString.Trim & " datos."
					cadenaMsg &= vbCrLf & "¿Desea almacenarlos?"
					If MessageBox.Show(cadenaMsg, "Importación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
						Dim contadorAltas As Int16 = 0
						Dim contadorModificaciones As Int16 = 0
						Dim contador As Int16 = 0
						'Recorrido secuencial por la colección de datos leídos
						For Each proveedor As Entidades.Proveedor In proveedores
							'Actuañiza el contador
							contador += 1
							'Actualiza los controles de progreso
							lblMensajeProgreso.Text = "Almacenando a " & proveedor.RazonSocial.Trim & "(" & contador.ToString.Trim & "/" & proveedores.Count.ToString.ToString & ")"
							My.Application.DoEvents()
							'Consulta si existe por su código
							Dim capaNeg As New CapaNegocios.Proveedores
							Dim proveedoresConsultadas As New Entidades.Proveedores
							Try
								proveedoresConsultadas = capaNeg.ConsultaNumeroSAP(CadenaConexion, TipoBaseDatos, proveedor.NumeroSAP)
								If proveedoresConsultadas.Count = 0 Then
									'Alta del proveedor
									Call capaNeg.Alta(CadenaConexion, TipoBaseDatos, proveedor)
									'Incrementa el contador de altas
									contadorAltas += 1
								Else
									'Modifica el proveedor
									Call capaNeg.Modificar(CadenaConexion, TipoBaseDatos, proveedor)
									'Incrementa el contador de modificaciones
									contadorModificaciones += 1
								End If
							Catch ex As Exception
								cadenaMsg = "Se generó un error al tratar de almacenar el proveedor con N° SAP " & Chr(32) & proveedor.NumeroSAP.ToString.Trim & Chr(32) & "."
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
						cadenaMsg &= vbCrLf & "   Leídos = " & Categorias.Count.ToString.Trim
						cadenaMsg &= vbCrLf & "   Altas = " & contadorAltas.ToString.Trim
						cadenaMsg &= vbCrLf & "   Altas = " & contadorModificaciones.ToString.Trim
						MessageBox.Show(cadenaMsg, "Importación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
					End If
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
		lblMensajeProgreso.Text = ""
		My.Application.DoEvents()
		'Cambia el valor de la variable bandera
		Procesando = False
	End Sub

#End Region

#Region "Métodos relacionados a los controles"

	Private Sub frmProveedoresImportacionDBF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Inicializar()
	End Sub

	Private Sub frmProveedoresImportacionDBF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmProveedoresImportacionDBF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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