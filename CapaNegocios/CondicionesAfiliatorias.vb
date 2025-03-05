'***********************************************************************************************
'*
'*  Clase: CondicionesAfiliatorias
'*  Capa: Negocios
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 18/02/2025
'*  Descripción: Clase utilizada para contener toda la lógica del sistema y sirve como interface
'*               con la capa de datos.
'*
'***********************************************************************************************
Public Class CondicionesAfiliatorias

#Region "Métodos públicos"

    ''' <summary>
    ''' Función utilizada para dar de alta una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CondicionAfiliatoria">Obligatorio. Objeto de la clase "CondicionAfiliatoria", con todos los atributos necesarios para dar de alta el nuevo dato general.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function Alta(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CondicionAfiliatoria As Entidades.CondicionAfiliatoria) As Int64
        Dim Valor As Int64 = 0
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.AltaOLEDB(CadenaConexion, CondicionAfiliatoria)
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
    ''' Procedimiento utilizado para dar de baja una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la condición afiliatoria a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub Baja(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
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
    ''' Procedimiento utilizado para modificar una condición afiliatoria existente
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CondicionAfiliatoria">Obligatorio. Objeto de la clase "CondicionAfiliatoria", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub Modificar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CondicionAfiliatoria As Entidades.CondicionAfiliatoria)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Call CapaDatos.ModificacionOLEDB(CadenaConexion, CondicionAfiliatoria)
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificador(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "Id_Afiliado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id_Afiliado">Obligatorio. Número identificador del afiliado relacionado a la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaAfiliado(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id_Afiliado As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaAfiliadoOLEDB(CadenaConexion, Id_Afiliado)
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "CUIL"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL">Obligatorio. CUIL del afiliado con la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCUILOLEDB(CadenaConexion, CUIL)
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado de la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDNI(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal DNI As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaDNIOLEDB(CadenaConexion, DNI)
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
    ''' Función utilizada para buscar un afiliado según sus atributos "CUIL_Titular" y "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular de la condición afiliatoria a buscar.</param>
    ''' <param name="DNI">Obligatorio. Documento del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNI(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCUIL_TitularDNIOLEDB(CadenaConexion, CUIL_Titular, DNI)
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
    ''' Función utilizada para buscar una condición afiliatoria según sus atributos "CUIL_Titular", "DNI", "Mes"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular de la condición afiliatoria a buscar.</param>
    ''' <param name="DNI">Obligatorio. Documento del afiliado a buscar.</param>
    ''' <param name="Mes_Desde">Obligatorio. Mes sobre el cual se desea consultar.</param>
    ''' <param name="Mes_Hasta">Opcional. Mes hasta el cual se desea consultar. Por defecto es cero.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNIMeses(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64, ByVal Mes_Desde As Int16, Optional Mes_Hasta As Int16 = 0) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCUIL_TitularDNIMesesOLEDB(CadenaConexion, CUIL_Titular, DNI, Mes_Desde, Mes_Hasta)
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
    ''' Función utilizada para buscar las condiciones afiliatorias según su atributo "Mes"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Mes">Obligatorio. Mes de las condiciones afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaMesOLEDB(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Mes As Int16) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.CondicionesAfiliatorias
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaMesOLEDB(CadenaConexion, Mes)
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
    ''' Procedimiento utilizado para validar los datos de una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CondicionAfiliatoria">Obligatorio. Objeto de la clase "CondicionAfiliatoria", con todos los atributos necesarios para ser validado.</param>
    ''' <param name="Alta">Opcional. Valor booleano que indica</param>
    ''' <remarks></remarks>
    Public Sub Validar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CondicionAfiliatoria As Entidades.CondicionAfiliatoria, Optional ByVal Alta As Boolean = False)
        Dim CadenaMsg As String = ""
        Dim RutaError As String = "   Capa: Negocios." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: Validar."
        'Validación del mes
        If CadenaMsg.Trim.Length = 0 Then
            If CondicionAfiliatoria.Mes = 0 Then
                CadenaMsg = "No se definió el mes de la condición afiliatoria."
            End If
        End If
        'Validación del CUIL
        If CadenaMsg.Trim.Length = 0 Then
            If CondicionAfiliatoria.CUIL = 0 Then
                CadenaMsg = "No se definió el CUIL del afiliado."
            End If
        End If
        'Validación del DNI
        If CadenaMsg.Trim.Length = 0 Then
            If CondicionAfiliatoria.DNI = 0 Then
                CadenaMsg = "No se definió el DNI."
            End If
        End If
        'Validación del CUIL del titular
        If CadenaMsg.Trim.Length = 0 Then
            If CondicionAfiliatoria.CUIL_Titular = 0 Then
                CadenaMsg = "No se definió el CUIL del titular."
            End If
        End If
        'Validación del tipo de condición
        If CadenaMsg.Trim.Length = 0 Then
            If CondicionAfiliatoria.TipoCondicion.Trim.Length = 0 Then
                CadenaMsg = "No se definió el tipo de condición."
            End If
        End If
        'Genera el mensaje completo del error
        If CadenaMsg.Trim.Length > 0 Then
            CadenaMsg = "Error de validación de datos." & vbCrLf & CadenaMsg
            Throw New ArgumentException(CadenaMsg)
        End If
    End Sub

#End Region

End Class
