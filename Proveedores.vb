'***********************************************************************************************
'*
'*  Clase: Proveedores
'*  Capa: Negocios
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 20/03/2025
'*  Descripción: Clase utilizada para contener toda la lógica del sistema y sirve como interface
'*               con la capa de datos.
'*
'***********************************************************************************************
Public Class Proveedores

#Region "Métodos públicos"

    ''' <summary>
    ''' Función utilizada para dar de alta un probeedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Proveedor">Obligatorio. Objeto de la clase "Proveedor", con todos los atributos necesarios para dar de alta el nuevo dato general.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function Alta(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Proveedor As Entidades.Proveedor) As Int64
        Dim Valor As Int64 = 0
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.AltaOLEDB(CadenaConexion, Proveedor)
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
    ''' Procedimiento utilizado para dar de baja un proveedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador del proveedor a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub Baja(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
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
    ''' Procedimiento utilizado para modificar un proveedor existente
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Proveedor">Obligatorio. Objeto de la clase "Proveedor", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub Modificar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Proveedor As Entidades.Proveedor)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Call CapaDatos.ModificacionOLEDB(CadenaConexion, Proveedor)
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
    ''' Función utilizada para buscar todos los proveedores
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTodos(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaTodosOLEDB(CadenaConexion)
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
    ''' Función utilizada para buscar un proveedor según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la categoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificador(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
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
    ''' Función utilizada para buscar un proveedor según su atributo "NumeroSAP"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="NumeroSAP">Obligatorio. Número SAP del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaNumeroSAP(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal NumeroSAP As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaNumeroSAPOLEDB(CadenaConexion, NumeroSAP)
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
    ''' Función utilizada para buscar un proveedor según su atributo "CUIT"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIT">Obligatorio. CUIT del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIT(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIT As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCUITOLEDB(CadenaConexion, CUIT)
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
    ''' Función utilizada para buscar un proveedor según su atributo "Id_Categoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id_Categoria">Obligatorio. Número de identificador de categoría de los proveedores a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCategoria(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id_Categoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCategoriaOLEDB(CadenaConexion, Id_Categoria)
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
    ''' Función utilizada para buscar un proveedor según su atributo "Id_Subcategoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id_Subcategoria">Obligatorio. Número de identificador de subcategoría de los proveedores a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaSubcategoria(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id_Subcategoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaSubcategoriaOLEDB(CadenaConexion, Id_Subcategoria)
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
    ''' Función utilizada para buscar un proveedor según sus atributos "Id_Categoria" y "Id_Subcategoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id_Categoria">Obligatorio. Número de identificador de categoría de los proveedores a buscar.</param>
    ''' <param name="Id_Subcategoria">Obligatorio. Número de identificador de subcategoría de los proveedores a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Provedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCategoriaSubcategoria(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id_Categoria As Int64, ByVal Id_Subcategoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Proveedores
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCategoriaSubcategoriaOLEDB(CadenaConexion, Id_Categoria, Id_Subcategoria)
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
    ''' Procedimiento utilizado para validar los datos de un proveedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Proveedor">Obligatorio. Objeto de la clase "Proveedor", con todos los atributos necesarios para ser validado.</param>
    ''' <param name="Alta">Opcional. Valor booleano que indica</param>
    ''' <remarks></remarks>
    Public Sub Validar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Proveedor As Entidades.Proveedor, Optional ByVal Alta As Boolean = False)
        Dim CadenaMsg As String = ""
        Dim RutaError As String = "   Capa: Negocios." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: Validar."
        'Validación del número SAP
        If CadenaMsg.Trim.Length = 0 Then
            If Proveedor.NumeroSAP = 0 Then
                CadenaMsg = "No se definió el número SAP."
            End If
        End If
        'Validación del código
        If CadenaMsg.Trim.Length = 0 Then
            If Proveedor.CUIT = 0 Then
                CadenaMsg = "No se definió el CUIT."
            End If
        End If
        'Validación de la razón social
        If CadenaMsg.Trim.Length = 0 Then
            If Proveedor.RazonSocial.Trim.Length = 0 Then
                CadenaMsg = "No se definió la razón social."
            End If
        End If
        'Validación de la dupliación de datos
        If CadenaMsg.Trim.Length > 0 Then
            Dim proveedores As New Entidades.Proveedores
            Try
                proveedores = ConsultaCUIT(CadenaConexion, TipoBaseDatos, Proveedor.CUIT)
                If proveedores.Count > 0 Then
                    CadenaMsg = "El CUIT " & Chr(32) & Proveedor.CUIT.ToString.Trim & Chr(32) & " ya existe para el proveedor " & proveedores(0).CUIT.ToString.Trim & "."
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
