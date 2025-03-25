'***********************************************************************************************
'*
'*  Clase: Afiliados
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
Public Class Categorias

#Region "Métodos públicos relacionados a OLEDB"

    ''' <summary>
    ''' Función utilizada para dar de alta una categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Categoria">Obligatorio. Objeto de la clase "Categoria", con todos los atributos necesarios para dar de alta el nuevo dato básico.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaOLEDB(ByVal CadenaConexion As String, ByVal Categoria As Entidades.Categoria) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Insert into Categorias (Entidad, Codigo, Descripcion, EntidadRelacionada, Id_Relacionado, Habilitado) values ("
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: AltaOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            Try
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Define el tipo de comando a ejecutar
                With Categoria
                    CadenaCmd &= "'" & .Entidad.ToUpper.Trim & "', "
                    CadenaCmd &= "'" & .Codigo.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Descripcion.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .EntidadRelacionada.Trim.ToUpper & "', "
                    CadenaCmd &= .Id_Relacionado.ToString.Trim & ", "
                    CadenaCmd &= .Habilitado.ToString.Trim
                    CadenaCmd &= ")"
                End With
                Cmd.CommandType = CommandType.Text
                'Define el comando
                Cmd.CommandText = CadenaCmd
                'Ejecuta la consulta
                Call Cmd.ExecuteScalar()
                'Determina el nuevo número de Id.
                CadenaCmd = "Select Max(Id) from Categorias"
                Cmd.CommandText = CadenaCmd
                Valor = Cmd.ExecuteScalar
            Catch ex As Exception
                'Defineción del mensaje de error
                CadenaMsg = ex.Message & CadenaMsg
                'Genera un nuevo tipo de mensaje de error
                Throw New ArgumentException(CadenaMsg)
            End Try
        Catch ex As Exception
            'Copia la cadena de conexión y la de comandos al portapapeles
            My.Computer.Clipboard.SetText(CadenaConexion & vbCrLf & CadenaCmd)
            'Defineción del mensaje de error
            CadenaMsg = ex.Message & CadenaMsg
            'Genera un nuevo tipo de mensaje de error
            Throw New ArgumentException(CadenaMsg)
        Finally
            'Cierra la conexión
            ConBD.Close()
            'Liberación de objetos utilizados
            ConBD = Nothing
            Cmd = Nothing
        End Try
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento utilizado para dar de baja una categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la categoria a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub BajaOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Delete from Categorias Where "
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: BajaOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd &= "Id = " & Id.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Ejecuta la consulta
            Call Cmd.ExecuteNonQuery()
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
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para modificar una categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Categoria">Obligatorio. Objeto de la clase "Categoria", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub ModificacionOLEDB(ByVal CadenaConexion As String, ByVal Categoria As Entidades.Categoria)
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Update Categorias Set "
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ModificacionOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            With Categoria
                CadenaCmd &= "Entidad ='" & .Entidad.Trim.ToUpper & "', "
                CadenaCmd &= "Codigo = '" & .Codigo.Trim.ToUpper & "', "
                CadenaCmd &= "Descripcion = '" & .Descripcion.Trim.ToUpper & "', "
                CadenaCmd &= "EntidadRelacionada = '" & .EntidadRelacionada.Trim.ToUpper & "', "
                CadenaCmd &= "Id_Relacionada = " & .Id_Relacionado.ToString.Trim & ", "
                CadenaCmd &= "Habilitado = " & .Habilitado.ToString.Trim
                CadenaCmd &= " Where Id = " & .Id.ToString.Trim
            End With
            Cmd.CommandText = CadenaCmd
            'Ejecuta la consulta
            Call Cmd.ExecuteNonQuery()
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
    End Sub

    ''' <summary>
    ''' Función utilizada para buscar una categoría según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Categorias Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ConsultaIdentificadorOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd &= "Id = " & Id.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Categoria
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Entidad")) Then .Entidad = Lector("Entidad")
                    If Not IsDBNull(Lector("Codigo")) Then .Codigo = Lector("Codigo")
                    If Not IsDBNull(Lector("Descripcion")) Then .Descripcion = Lector("Descripcion")
                    If Not IsDBNull(Lector("EntidadRelacionada")) Then .EntidadRelacionada = Lector("EntidadRelacionada")
                    If Not IsDBNull(Lector("Id_Relacionado")) Then .Id_Relacionado = Lector("Id_Relacionado")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
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
    ''' Función utilizada para buscar una categoría según su atributo "Id_Relacionado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id_Relacionado">Obligatorio. Número identificador de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorRelacionadoOLEDB(ByVal CadenaConexion As String, ByVal Id_Relacionado As Int64) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Categorias Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ConsultaIdentificadorRelacionadoOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd &= "Id_Relacionado = " & Id_Relacionado.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Categoria As New Entidades.Categoria
                'Asigna los vlores de los campos a los atributos del objeto
                With Categoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Entidad")) Then .Entidad = Lector("Entidad")
                    If Not IsDBNull(Lector("Codigo")) Then .Codigo = Lector("Codigo")
                    If Not IsDBNull(Lector("Descripcion")) Then .Descripcion = Lector("Descripcion")
                    If Not IsDBNull(Lector("EntidadRelacionada")) Then .EntidadRelacionada = Lector("EntidadRelacionada")
                    If Not IsDBNull(Lector("Id_Relacionado")) Then .Id_Relacionado = Lector("Id_Relacionado")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Categoria)
                'Libera el objeto
                Categoria = Nothing
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
    ''' Función utilizada para buscar una categoría según su atributo "Entidad"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Entidad">Obligatorio. Entidad de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaEntidadOLEDB(ByVal CadenaConexion As String, ByVal Entidad As String) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Categorias Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ConsultaIdentificadorOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd &= "Entidad = '" & Entidad.ToUpper.Trim & "'"
            CadenaCmd &= " Order by Codigo"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Categoria As New Entidades.Categoria
                'Asigna los valores de los campos a los atributos del objeto
                With Categoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Entidad")) Then .Entidad = Lector("Entidad")
                    If Not IsDBNull(Lector("Codigo")) Then .Codigo = Lector("Codigo")
                    If Not IsDBNull(Lector("Descripcion")) Then .Descripcion = Lector("Descripcion")
                    If Not IsDBNull(Lector("EntidadRelacionada")) Then .EntidadRelacionada = Lector("EntidadRelacionada")
                    If Not IsDBNull(Lector("Id_Relacionado")) Then .Id_Relacionado = Lector("Id_Relacionado")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Categoria)
                'Libera el objeto
                Categoria = Nothing
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
    ''' Función utilizada para buscar una categoría según sus atributos "Entidad" y "Código"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Entidad">Obligatorio. Entidad de la categoria a buscar.</param>
    ''' <param name="Codigo">Obligatorio. Código de la categoría.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCodigoOLEDB(ByVal CadenaConexion As String, ByVal Entidad As String, ByVal Codigo As String) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Categorias Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ConsultaCodigoOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            CadenaCmd &= "Entidad = '" & Entidad.ToUpper.Trim & "'"
            CadenaCmd &= "and Codigo = '" & Codigo.ToUpper.Trim & "'"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Categoria As New Entidades.Categoria
                'Asigna los valores de los campos a los atributos del objeto
                With Categoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Entidad")) Then .Entidad = Lector("Entidad")
                    If Not IsDBNull(Lector("Codigo")) Then .Codigo = Lector("Codigo")
                    If Not IsDBNull(Lector("Descripcion")) Then .Descripcion = Lector("Descripcion")
                    If Not IsDBNull(Lector("EntidadRelacionada")) Then .EntidadRelacionada = Lector("EntidadRelacionada")
                    If Not IsDBNull(Lector("Id_Relacionado")) Then .Id_Relacionado = Lector("Id_Relacionado")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Categoria)
                'Libera el objeto
                Categoria = Nothing
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
    ''' Función utilizada para buscar las distintas entidades de las categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <returns>Lista de cadenas de caracteres..</returns>
    ''' <remarks></remarks>
    Public Function ConsultaEntidadesOLEDB(ByVal CadenaConexion As String) As List(Of String)
        Dim Valor As New List(Of String)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select Distinct Entidad from Categorias"
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: ConsultaEntidadesOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Define el comando
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                If Not IsDBNull(Lector("Entidad")) Then
                    Valor.Add(Lector("Entidad"))
                End If
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
