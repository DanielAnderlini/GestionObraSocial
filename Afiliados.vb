'***********************************************************************************************
'*
'*  Clase: Afiliados
'*  Capa: Negocios
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 17/02/2025
'*  Descripción: Clase utilizada para contener toda la lógica del sistema y sirve como interface
'*               con la capa de datos.
'*
'***********************************************************************************************
Public Class Afiliados

#Region "Métodos públicos"

    ''' <summary>
    ''' Función utilizada para dar de alta un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Afiliado">Obligatorio. Objeto de la clase "Afiliado", con todos los atributos necesarios para dar de alta el nuevo dato general.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function Alta(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Afiliado As Entidades.Afiliado) As Int64
        Dim Valor As Int64 = 0
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.AltaOLEDB(CadenaConexion, Afiliado)
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
    ''' Función utilizada para dar de alta un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Afiliados">Obligatorio. Colección de objetos de la clase "Afiliado", con todos los atributos necesarios para dar de alta el nuevo dato general.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaColeccion(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Afiliados As Entidades.Afiliados) As Int64
        Dim Valor As Int64 = 0
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.AltaColeccionOLEDB(CadenaConexion, Afiliados)
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
    ''' Procedimiento utilizado para dar de baja un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador del afiliado a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub Baja(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
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
    ''' Procedimiento utilizado para modificar un afiliado existente
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Afiliado">Obligatorio. Objeto de la clase "Afiliado", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub Modificar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Afiliado As Entidades.Afiliado)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Call CapaDatos.ModificacionOLEDB(CadenaConexion, Afiliado)
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
    ''' Función utilizada para buscar un afiliado según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Id">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificador(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Id As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
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
    ''' Función utilizada para buscar un afiliado según su atributo "CUIL"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
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
    ''' Función utilizada para buscar un afiliado según su atributo "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="DNI">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDNI(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
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
    ''' Función utilizada para buscar un afiliado según sus atributos "CUIL" y "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <param name="DNI">Obligatorio. Documento del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUILDNI(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL As Int64, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaCUILDNIOLEDB(CadenaConexion, CUIL, DNI)
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
    ''' <param name="CUIL_Titular">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <param name="DNI">Obligatorio. Documento del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNI(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
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
    ''' Función utilizada para buscar un afiliado según su atributo "Genero"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Genero">Obligatorio. Genero del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaGenero(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Genero As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaGeneroOLEDB(CadenaConexion, Genero)
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
    ''' Función utilizada para buscar un afiliado según su atributo "Relacion"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Relacion">Obligatorio. Relación del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaRelacion(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Relacion As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaRelacionOLEDB(CadenaConexion, Relacion)
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
    ''' Función utilizada para buscar el grupo familiar según su atributo "CUIL_Titular"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="CUIL_Titular">Obligatorio. Número identificador del profesional a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaGrupoFamiliar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal CUIL_Titular As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaGrupoFamiliarLEDB(CadenaConexion, CUIL_Titular)
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
    ''' Función utilizada para buscar un afiliado según su atributo "TipoAfiliado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="TipoAfiliado">Obligatorio. Relación del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTipoAfiliado(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal TipoAfiliado As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaTipoAfiliadoOLEDB(CadenaConexion, TipoAfiliado)
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
    ''' Función utilizada para buscar un afiliado según su atributo "Provincia"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Provincia">Obligatorio. Provincia del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaProvincia(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Provincia As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaProvinciaOLEDB(CadenaConexion, Provincia)
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
    ''' Función utilizada para buscar un afiliado según su atributo "BocaExpendio"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="BocaExpendio">Obligatorio. Número de boca de expendio del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaBocaExpendio(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal BocaExpendio As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaBocaExpendioOLEDB(CadenaConexion, BocaExpendio)
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
    ''' Función utilizada para buscar las distintas bocas de expendio
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Provincia">Obligatorio. Provincia a las que pertenecen las bocas de expendio.</param>
    ''' <returns>Lista de cadenas de caracteres con las distintias bocas de expendio.</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDistintasBocasExpendio(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Provincia As String) As List(Of String)
        Dim Valor As New List(Of String)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaDistintasBocasExpendioOLEDB(CadenaConexion, Provincia)
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
    ''' Función utilizada para buscar las distintas provincias
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <returns>Lista de cadenas de caracteres con las distintias provincias.</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDistintasProvincias(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String) As List(Of String)
        Dim Valor As New List(Of String)
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.Afiliados
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaDistintasProvinciasOLEDB(CadenaConexion)
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
    ''' Procedimiento utilizado para validar los datos de un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <param name="Afiliado">Obligatorio. Objeto de la clase "Practica", con todos los atributos necesarios para ser validado.</param>
    ''' <param name="Alta">Opcional. Valor booleano que indica</param>
    ''' <remarks></remarks>
    Public Sub Validar(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String, ByVal Afiliado As Entidades.Afiliado, Optional ByVal Alta As Boolean = False)
        Dim CadenaMsg As String = ""
        Dim RutaError As String = "   Capa: Negocios." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: Validar."
        'Validación del CUIL
        If CadenaMsg.Trim.Length = 0 Then
            If Afiliado.CUIL = 0 Then
                CadenaMsg = "No se definió el CUIL del afiliado."
            End If
        End If
        'Validación del DNI
        If CadenaMsg.Trim.Length = 0 Then
            If Afiliado.DNI = 0 Then
                CadenaMsg = "No se definió el DNI."
            End If
        End If
        'Validación del apellido
        If CadenaMsg.Trim.Length = 0 Then
            If Afiliado.Apellidos.Trim.Length = 0 Then
                CadenaMsg = "No se definió el apellido."
            End If
        End If
        'Validación del nombre
        If CadenaMsg.Trim.Length = 0 Then
            If Afiliado.Nombres.Trim.Length = 0 Then
                CadenaMsg = "No se definió el nombre."
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
