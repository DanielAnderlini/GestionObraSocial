Imports System.IO
Imports System.IO.Stream
Imports Microsoft.Win32
Module General

#Region "Declaraciones públicas"

	Public CadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DFA\Proyectos OSPRERA\GestionOSPRERA\BD\ObraSocial.accdb;Persist Security Info="
	Public CadenaConexionMovimientos As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DFA\Proyectos OSPRERA\GestionOSPRERA\BD;Persist Security Info="
	Public CadenaConexionDBF As String = "Provider=VFPOLEDB.1;Data Source=...; Extended Properties=dBASE IV;"
	Public TipoBaseDatos As String = "OLEDB"

	Public pathTmp As String = Environment.GetEnvironmentVariable("TEMP")
	Public pathApp As String = My.Computer.FileSystem.CurrentDirectory
	Public userSO As String = Environment.UserName
	Public namePC As String = Environment.MachineName

	Public cadenaMsg As String = ""

#End Region

#Region "Métodos públicos"

	''' <summary>
	''' Función utililizada para analizar las cadena de texto
	''' </summary>
	''' <param name="Cadena">Obligatorio. Cadena de caracteres a analizar.</param>
	''' <returns>Cadena de caracteres analizada.</returns>
	Public Function CadenaTextoUnicamente(ByVal Cadena As String) As String
		Dim valor As String = ""
		Dim valido As Boolean = False
		'Recorrido secuencial por los caracteres de la cadena
		For Each caracter As Char In Cadena
			valido = False
			'Mayúsculas:
			'-----------
			'Lestras mayúsculas
			If 65 <= Asc(caracter) And Asc(caracter) <= 90 Then
				valido = True
			End If
			'Letra Á
			If Asc(caracter) = 181 Then
				valido = True
			End If
			'Letra É
			If Asc(caracter) = 144 Then
				valido = True
			End If
			'Letra Í
			If Asc(caracter) = 214 Then
				valido = True
			End If
			'Letra Ó
			If Asc(caracter) = 224 Then
				valido = True
			End If
			'Letra Ú
			If Asc(caracter) = 233 Then
				valido = True
			End If
			'Letra Ñ
			If Asc(caracter) = 165 Then
				valido = True
			End If
			'Letra Ü
			If Asc(caracter) = 154 Then
				valido = True
			End If

			'Minúsculas:
			'-----------
			'Letras minúsculas
			If 97 <= Asc(caracter) And Asc(caracter) <= 122 Then
				valido = True
			End If
			'Vocales minúsculas con acento
			If 160 <= Asc(caracter) And Asc(caracter) <= 163 Then
				valido = True
			End If
			'Letra é
			If Asc(caracter) = 132 Then
				valido = True
			End If
			'Letra ü
			If Asc(caracter) = 129 Then
				valido = True
			End If
			'Letra ñ
			If Asc(caracter) = 164 Then
				valido = True
			End If

			'Espacio en blanco
			If Asc(caracter) = 32 Then
				valido = True
			End If

			'Agrega a la cadena de salida
			If valido = True Then
				valor &= caracter
			Else
				valor &= "_"
			End If
		Next
		'Valor de retorno de la función
		Return valor
	End Function

	''' <summary>
	''' Función utilizada para determinar el nombre de la base de datos de movimientos de caurdo a un año
	''' </summary>
	''' <param name="Ano">Obligatorio. Años al que pertenecen los datos de movimiento.</param>
	''' <returns>Cadena de caracteres con el nombre del archivo.</returns>
	Public Function NombreBaseDatosMovimiento(ByVal Ano As Int16) As String
		Dim Valor As String = ""
		Dim NombreArchivo As String = "Movimientos"
		Dim Extension As String = "accdb"
		'Determinación del valor de salida de la función
		Valor = NombreArchivo & Ano.ToString.Trim & "." & Extension
		'Valor de retorno d ela función
		Return Valor
	End Function

	''' <summary>
	''' Función utilizada para chequear la existencia de la base de movimientos
	''' </summary>
	''' <param name="Ano">Obligatorio. Años al que pertenecen los datos de movimiento.</param>
	''' <returns>Valor booleano que indica si existe el archivo de base de datos de movimiento.</returns>
	Public Function ChequearBaseDatosMovimientos(ByVal Ano As Int16) As Boolean
		Dim valor As Boolean = True
		Dim PathBD_Movimiento As String = ""
		Dim ArchivoBaseDatosMovimiento As String = NombreBaseDatosMovimiento(Ano)
		'Determinación de la ruta de la base de datos de movimientos
		PathBD_Movimiento = CadenaConexionMovimientos.Substring(CadenaConexionMovimientos.IndexOf("\") - 2)
		PathBD_Movimiento = PathBD_Movimiento.Substring(0, PathBD_Movimiento.LastIndexOf(";"))
		'Evalúa si existe el archivo de base de datos de movimientos
		If File.Exists(PathBD_Movimiento & "\" & ArchivoBaseDatosMovimiento) = False Then
			'Evalúa si existe la base de datos de movimiento plantilla
			If File.Exists(PathBD_Movimiento & "\Movimientos.accdb") = True Then
				'Copia el archivo palntilla con el nombre relacionado al año en cuestión
				Dim origen As String = PathBD_Movimiento & "\Movimientos.accdb"
				Dim destino As String = PathBD_Movimiento & "\" & ArchivoBaseDatosMovimiento
				Try
					File.Copy(origen, destino)
					valor = True
				Catch ex As Exception
					'Presenta mensaje de error
					cadenaMsg = "Error al crear el archivo de base de datos de movimiento para el año " & Ano.ToString.Trim & "."
					MessageBox.Show(cadenaMsg, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
					valor = False
				End Try
			Else
				'Presenta mensaje de error
				cadenaMsg = "No se pudo crear el archivo de base de datos de movimiento para el año " & Ano.ToString.Trim & " porque no es encontró el archivo de base de datos plantilla."
				MessageBox.Show(cadenaMsg, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
				valor = False
			End If
		End If
		'Valor de retorno de la función
		Return valor
	End Function

	''' <summary>
	''' Función utilizada para determinar la cadena de conexión del archivo de moviemiento a partir del año
	''' </summary>
	''' <param name="Ano">bligatorio. Años al que pertenecen los datos de movimiento.</param>
	''' <returns>Cadena de caracteres con la cadena de conexión.</returns>
	Public Function DeterminarCadenaConexionMovimiento(ByVal Ano As Int16) As String
		Dim valor As String = ""
		Dim cadenaParametros As String = CadenaConexionMovimientos
		Dim cadenaDriver As String = ""
		Dim cadenaSource As String = ""
		Dim cadenaSecurity As String = ""
		Dim archivoBaseDatosMovimientos As String = NombreBaseDatosMovimiento(Ano)
		'Fracción de los parámetros de conexión
		cadenaDriver = cadenaParametros.Substring(0, cadenaParametros.IndexOf(";") + 1)
		cadenaParametros = cadenaParametros.Substring(cadenaParametros.IndexOf(";") + 1)
		cadenaSource = cadenaParametros.Substring(0, cadenaParametros.IndexOf(";"))
		cadenaParametros = cadenaParametros.Substring(cadenaParametros.IndexOf(";") + 1)
		cadenaSecurity = cadenaParametros
		'Determinación de la ruta
		cadenaSource &= "\" & archivoBaseDatosMovimientos & ";"
		Dim pathMovimiento As String = cadenaSource.Replace(";", "").Replace("Data Source=", "")
		If File.Exists(pathMovimiento) = False Then
			cadenaMsg = "Ocurrió un error al tratar de generar la cadena de conxión."
			cadenaMsg &= vbCrLf & "No se encontró el archivo: "
			cadenaMsg &= vbCrLf & pathMovimiento
			cadenaMsg &= vbCrLf & "D:\DFA\Proyectos OSPRERA\GestionOSPRERA\BD\Movimientos2024.accdb"
			MessageBox.Show(cadenaMsg, "Error de generación", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
		'Generación de la cadena de conexión
		valor = cadenaDriver & cadenaSource & cadenaSecurity
		'Valor de retorno de la función
		Return valor
	End Function

	''' <summary>
	''' Functión utilizada para determinar los años disponibles de acuerdo a los archivos de movimientos existentes
	''' </summary>
	''' <returns>SortList con los años disponibles</returns>
	Public Function AnosDisponibles() As List(Of Int16)
		Dim valor As New List(Of Int16)
		Dim pathArchibosMovimientos As String = CadenaConexionMovimientos
		'Extracción del parámetro Source
		pathArchibosMovimientos = pathArchibosMovimientos.Substring(pathArchibosMovimientos.IndexOf(";") + 1)
		pathArchibosMovimientos = pathArchibosMovimientos.Substring(pathArchibosMovimientos.IndexOf("=") + 1)
		pathArchibosMovimientos = pathArchibosMovimientos.Substring(0, pathArchibosMovimientos.IndexOf(";"))
		Dim directorioArchivosMovimiento As New DirectoryInfo(pathArchibosMovimientos)
		Dim nombreArchivo As String = ""
		'Recorrido por los archivos de la carpeta
		For Each archivo In directorioArchivosMovimiento.EnumerateFiles
			nombreArchivo = archivo.Name
			'Evalúa si se trata de un archivo de movimiento
			If nombreArchivo.ToUpper.Contains("MOVIMIENTO") = True Then
				If nombreArchivo.ToUpper.Contains(".ACCDB") = True Then
					'Extrae la extención
					nombreArchivo = nombreArchivo.Replace(".accdb", "")
					'Extrae parte del nombre del archivo
					nombreArchivo = nombreArchivo.Replace("Movimientos", "")
					'Agrega al valor de salida de la función
					If nombreArchivo.Trim.Length > 0 Then
						valor.Add(nombreArchivo)
					End If
				End If
			End If
		Next
		'Valor de retorno de la función
		Return valor
	End Function

#End Region

End Module

