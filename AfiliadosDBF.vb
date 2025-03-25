'***********************************************************************************************
'*
'*  Clase: AfiliadosDBF
'*  Capa: Datos
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 14/02/2025
'*  Descripción: Clase utilizada para realizar todas la acciones necesarias sobre la base de datos
'*               las base de datos.
'*
'***********************************************************************************************
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Entidades
Public Class AfiliadosDBF

#Region "Métodos públicos relacionados a OLEDB"

    ''' <summary>
    ''' Función utilizada para buscar un todos los pacientes
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <returns>Colección de objetos de la clase "Paciente".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTodosOLEDB(ByVal CadenaConexion As String) As Entidades.AfiliadosDBF
        Dim Valor As New Entidades.AfiliadosDBF
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim Tabla As String = ""
        Dim CadenaCmd As String = ""
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: AfiliadosDBF." & vbCrLf & "   Método: ConsultaTodosOLEDB."
        Try
            'Determina el nombre d ela tabla
            Tabla = CadenaConexion.Substring(CadenaConexion.IndexOf(";") + 1)
            Tabla = Tabla.Substring(0, Tabla.IndexOf(";"))
            Tabla = Tabla.Substring(Tabla.IndexOf("=") + 1)
            Tabla = Tabla.Substring(Tabla.LastIndexOf("\") + 1)
            Tabla = Tabla.Substring(0, Tabla.IndexOf("."))
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd = "Select * from " & Tabla.Trim
            CadenaCmd &= " Order by Nomb"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.AfiliadoDBF
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("cuil")) Then .cuil = Lector("cuil")
                    If Not IsDBNull(Lector("tipo")) Then .tipo = Lector("tipo")
                    If Not IsDBNull(Lector("Docu")) Then .Docu = Lector("Docu")
                    If Not IsDBNull(Lector("Secu")) Then .Secu = Lector("Secu")
                    If Not IsDBNull(Lector("Nomb")) Then .Nomb = Lector("Nomb")
                    If Not IsDBNull(Lector("Bexp")) Then .Bexp = Lector("Bexp")
                    If Not IsDBNull(Lector("Fnac")) Then .Fnac = Lector("Fnac")
                    If Not IsDBNull(Lector("Sexo")) Then .Sexo = Lector("Sexo")
                    If Not IsDBNull(Lector("Orig")) Then .Orig = Lector("Orig")
                    If Not IsDBNull(Lector("Uatre")) Then .Uatre = Lector("Uatre")
                    If Not IsDBNull(Lector("Cuif")) Then .Cuif = Lector("Cuif")
                    If Not IsDBNull(Lector("Cond")) Then .Cond = Lector("Cond")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Afiliado)
                'Libera el objeto
                Afiliado = Nothing
            End While
            'Cierra la conexión
            ConBD.Close()
        Catch ex As Exception
            'Copia la cadena de conexión y la de comandos al portapapeles
            My.Computer.Clipboard.SetText(CadenaConexion & vbCrLf & CadenaCmd)
            'Defineción del mensaje de error
            CadenaMsg = ex.Message & CadenaMsg
            'Genera un nuevo tipo de mensaje de error
            Throw New ArgumentException(CadenaMsg)
        Finally
            'Liberación de objetos utilizados
            ConBD = Nothing
            Cmd = Nothing
        End Try
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar un todos los afiliados de una provincia
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CodigoProvincia">Obligatorio. Número de provincia por la cual se quiere filtrar.</param>
    ''' <returns>Colección de objetos de la clase "Paciente".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaProvinciaOLEDB(ByVal CadenaConexion As String, ByVal CodigoProvincia As Int16) As Entidades.AfiliadosDBF
        Dim Valor As New Entidades.AfiliadosDBF
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim Tabla As String = ""
        Dim CadenaCmd As String = ""
        Dim TablaCategorias As New List(Of Int64)
        Dim NumeroProvinciaDesde As Int16 = 0
        Dim NumeroProvinciaHasta As Int16 = 0
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: AfiliadosDBF." & vbCrLf & "   Método: ConsultaProvinciaOLEDB."
        Try
            'Determina el nombre d ela tabla
            Tabla = CadenaConexion.Substring(CadenaConexion.IndexOf(";") + 1)
            Tabla = Tabla.Substring(0, Tabla.IndexOf(";"))
            Tabla = Tabla.Substring(Tabla.IndexOf("=") + 1)
            Tabla = Tabla.Substring(Tabla.LastIndexOf("\") + 1)
            Tabla = Tabla.Substring(0, Tabla.IndexOf("."))
            'Determinación de los parámetros numéricos de provincia


            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd = "Select * from " & Tabla.Trim
            CadenaCmd &= " Where Bexp between "
            CadenaCmd &= " Order by Nomb"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.AfiliadoDBF
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("cuil")) Then .cuil = Lector("cuil")
                    If Not IsDBNull(Lector("tipo")) Then .tipo = Lector("tipo")
                    If Not IsDBNull(Lector("Docu")) Then .Docu = Lector("Docu")
                    If Not IsDBNull(Lector("Secu")) Then .Secu = Lector("Secu")
                    If Not IsDBNull(Lector("Nomb")) Then .Nomb = Lector("Nomb")
                    If Not IsDBNull(Lector("Bexp")) Then .Bexp = Lector("Bexp")
                    If Not IsDBNull(Lector("Fnac")) Then .Fnac = Lector("Fnac")
                    If Not IsDBNull(Lector("Sexo")) Then .Sexo = Lector("Sexo")
                    If Not IsDBNull(Lector("Orig")) Then .Orig = Lector("Orig")
                    If Not IsDBNull(Lector("Uatre")) Then .Uatre = Lector("Uatre")
                    If Not IsDBNull(Lector("Cuif")) Then .Cuif = Lector("Cuif")
                    If Not IsDBNull(Lector("Cond")) Then .Cond = Lector("Cond")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Afiliado)
                'Libera el objeto
                Afiliado = Nothing
            End While
            'Cierra la conexión
            ConBD.Close()
        Catch ex As Exception
            'Copia la cadena de conexión y la de comandos al portapapeles
            My.Computer.Clipboard.SetText(CadenaConexion & vbCrLf & CadenaCmd)
            'Defineción del mensaje de error
            CadenaMsg = ex.Message & CadenaMsg
            'Genera un nuevo tipo de mensaje de error
            Throw New ArgumentException(CadenaMsg)
        Finally
            'Liberación de objetos utilizados
            ConBD = Nothing
            Cmd = Nothing
        End Try
        'Valor de retorno de la función
        Return Valor
    End Function

#End Region

End Class
