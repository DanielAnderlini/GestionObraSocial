'***********************************************************************************************
'*
'*  Clase: Categorias
'*  Capa: Negocios
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 17/03/2025
'*  Descripción: Clase utilizada para contener toda la lógica del sistema y sirve como interface
'*               con la capa de datos.
'*
'***********************************************************************************************
Public Class Categorias

#Region "Métodos públicos"

    ''' <summary>
    ''' Función utilizada para dar de alta una categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Categoria">Obligatorio. Objeto de la clase "Categoria", con todos los atributos necesarios para dar de alta el nuevo dato general.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function Alta(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Categoria As Entidades.Categoria) As Int64
        Dim Valor As Int64 = 0
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.AltaOLEDB(CadenaConexion, Categoria)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento utilizado para dar de baja una categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la categoria a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub Baja(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Call CapaDatos.BajaOLEDB(CadenaConexion, Id)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select

    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para modificar una categoría existente
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Categoria">Obligatorio. Objeto de la clase "Categpria", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub Modificar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Categoria As Entidades.Categoria)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Call CapaDatos.ModificacionOLEDB(CadenaConexion, Categoria)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
    End Sub

    ''' <summary>
    ''' Función utilizada para buscar una categoria según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificador(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaIdentificadorOLEDB(CadenaConexion, Id)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar una categoria según su atributo "Id_Relacionado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id_Relacionado">Obligatorio. Número identificador de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorRelacionado(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id_Relacionado As Int64) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaIdentificadorRelacionadoOLEDB(CadenaConexion, Id_Relacionado)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar una categoria según su atributo "Entidad"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Entidad">Obligatorio. Entidad de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaEntidad(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Entidad As String) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaEntidadOLEDB(CadenaConexion, Entidad)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar una categoria según su atributo "Entidad" y "Codigo"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Entidad">Obligatorio. Entidad de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Categoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCodigo(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Entidad As String, ByVal Codigo As String) As Entidades.Categorias
        Dim Valor As New Entidades.Categorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCodigoOLEDB(CadenaConexion, Entidad, Codigo)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar las distintas entidades de las categoría
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <returns>Lista de cadenas de caracteres..</returns>
    ''' <remarks></remarks>
    Public Function ConsultaEntidades(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String) As List(Of String)
        Dim Valor As New List(Of String)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Categorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaEntidadesOLEDB(CadenaConexion)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento utilizado para validar los datos de una categoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Categoria">Obligatorio. Objeto de la clase "Categoria", con todos los atributos necesarios para ser validado.</param>
    ''' <param name="Alta">Opcional. Valor booleano que indica</param>
    ''' <remarks></remarks>
    Public Sub Validar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Categoria As Entidades.Categoria, Optional ByVal Alta As Boolean = False)
        Dim CadenaMsg As String = ""
        Dim RutaError As String = "   Capa: Negocios." & vbCrLf & "   Clase: Categorias." & vbCrLf & "   Método: Validar."
        'Validación de la entidad
        If CadenaMsg.Trim.Length = 0 Then
            If Categoria.Entidad.Trim.Length = 0 Then
                CadenaMsg = "No se definió la entidad de la categoría."
            End If
        End If
        'Validación del código
        If CadenaMsg.Trim.Length = 0 Then
            If Categoria.Codigo.Trim.Length = 0 Then
                CadenaMsg = "No se definió el código."
            End If
        End If
        'Validación de la descripción
        If CadenaMsg.Trim.Length = 0 Then
            If Categoria.Descripcion.Trim.Length = 0 Then
                CadenaMsg = "No se definió la descripción."
            End If
        End If
        'Validación de la dupliación de datos
        If CadenaMsg.Trim.Length > 0 Then
            Dim categorias As New Entidades.Categorias
            Try
                categorias = ConsultaCodigo(CadenaConexion, TipoBaseDatos, Categoria.Entidad, Categoria.Codigo)
                If categorias.Count > 0 Then
                    CadenaMsg = "El código " & Chr(32) & Categoria.Codigo & Chr(32) & " ya existe para la entidad " & Categoria.Entidad & "."
                End If
            Catch ex As Exception

            End Try
        End If
        'Genera el mensaje completo del error
        If CadenaMsg.Trim.Length > 0 Then
            CadenaMsg = "Error de validación de datos." & vbCrLf & CadenaMsg
            Throw New ArgumentException(CadenaMsg)
        End If
    End Sub

#End Region

End Class
