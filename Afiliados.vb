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
Imports Entidades
Public Class Afiliados

#Region "Métodos públicos relacionados a OLEDB"

    ''' <summary>
    ''' Función utilizada para dar de alta un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="ObraSocial">Obligatorio. Objeto de la clase "ObraSocial", con todos los atributos necesarios para dar de alta el nuevo dato básico.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaOLEDB(ByVal CadenaConexion As String, ByVal ObraSocial As Entidades.Afiliado) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Insert into Afiliados (CUIL, DNI, Apellidos, Nombres, FechaNacimiento, Genero, CUIL_Titular, Relacion, TipoAfiliado, UATRE, Provincia, BocaExpendio, Departamento, Localidad, Domicilio, Telefono, Email, TipoCarga) values ("
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: AltaOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            Try
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Define el tipo de comando a ejecutar
                With ObraSocial
                    CadenaCmd &= .CUIL.ToString.Trim & ", "
                    CadenaCmd &= .DNI.ToString.Trim & ", "
                    CadenaCmd &= "'" & .Apellidos.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Nombres.Trim.ToUpper & "', "
                    CadenaCmd &= "DateValue('" & .FechaNacimiento.ToShortDateString.Trim.ToUpper & "'), "
                    CadenaCmd &= "'" & .Genero.Trim.ToUpper & "', "
                    CadenaCmd &= .CUILT_Titular.ToString.Trim & ", "
                    CadenaCmd &= "'" & .Relacion.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .TipoAfiliado.Trim.ToUpper & "', "
                    CadenaCmd &= .UATRE.ToString.Trim & ", "
                    CadenaCmd &= "'" & .Provincia.Trim.ToUpper & "', "
                    CadenaCmd &= .BocaExpendio.ToString.Trim & ", "
                    CadenaCmd &= "'" & .Departamento.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Localidad.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Domicilio.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Telefono.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Email.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .TipoCarga & "')"
                End With
                Cmd.CommandType = CommandType.Text
                'Define el comando
                Cmd.CommandText = CadenaCmd
                'Ejecuta la consulta
                Call Cmd.ExecuteScalar()
                'Determina el nuevo número de Id.
                CadenaCmd = "Select Max(Id) from Afiliados"
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
    ''' Función utilizada para dar de alta una colección de afiliados
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Afiliados">Obligatorio. Colección de objetos de la clase "ObraSocial", con todos los atributos necesarios para dar de alta el nuevo dato básico.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaColeccionOLEDB(ByVal CadenaConexion As String, ByVal Afiliados As Entidades.Afiliados) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Insert into Afiliados (CUIL, DNI, Apellidos, Nombres, FechaNacimiento, Genero, CUIL_Titular, Relacion, TipoAfiliado, UATRE, Provincia, BocaExpendio, Departamento, Localidad, Domicilio, Telefono, Email, TipoCarga) values ("
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: AltaColeccionOLEDB."
        Dim contador As Int64 = 0
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            Try
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Recorrido secuencial por la colección de afiliados
                For Each afiliado As Entidades.Afiliado In Afiliados
                    'Incrementa el contador
                    contador += 1
                    My.Computer.Clipboard.SetText("Procesando registro N°" & contador.ToString.Trim)
                    'Inicializa la cadena con las instrucciones
                    CadenaCmd = "Insert into Afiliados (CUIL, DNI, Apellidos, Nombres, FechaNacimiento, Genero, CUIL_Titular, Relacion, TipoAfiliado, UATRE, Provincia, BocaExpendio, Departamento, Localidad, Domicilio, Telefono, Email, TipoCarga) values ("
                    'Define el tipo de comando a ejecutar
                    With afiliado
                        CadenaCmd &= .CUIL.ToString.Trim & ", "
                        CadenaCmd &= .DNI.ToString.Trim & ", "
                        CadenaCmd &= "'" & .Apellidos.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .Nombres.Trim.ToUpper & "', "
                        CadenaCmd &= "DateValue('" & .FechaNacimiento.ToShortDateString.Trim.ToUpper & "'), "
                        CadenaCmd &= "'" & .Genero.Trim.ToUpper & "', "
                        CadenaCmd &= .CUILT_Titular.ToString.Trim & ", "
                        CadenaCmd &= "'" & .Relacion.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .TipoAfiliado.Trim.ToUpper & "', "
                        CadenaCmd &= .UATRE.ToString.Trim & ", "
                        CadenaCmd &= "'" & .Provincia.Trim.ToUpper & "', "
                        CadenaCmd &= .BocaExpendio.ToString.Trim & ", "
                        CadenaCmd &= "'" & .Departamento.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .Localidad.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .Domicilio.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .Telefono.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .Email.Trim.ToUpper & "', "
                        CadenaCmd &= "'" & .TipoCarga & "')"
                    End With
                    Cmd.CommandType = CommandType.Text
                    'Define el comando
                    Cmd.CommandText = CadenaCmd
                    'Ejecuta la consulta
                    Call Cmd.ExecuteScalar()
                Next
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
    ''' Procedimiento utilizado para dar de baja un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador del afiliado a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub BajaOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Delete from Afiliados Where "
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: BajaOLEDB."
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
    ''' Procedimiento utilizado para modificar un afiliado
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Afiliado">Obligatorio. Objeto de la clase "Afiliado", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub ModificacionOLEDB(ByVal CadenaConexion As String, ByVal Afiliado As Entidades.Afiliado)
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Update Afiliados Set "
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ModificacionOLEDB."
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
            With Afiliado
                CadenaCmd &= "CUIL = " & .CUIL.ToString.Trim & ", "
                CadenaCmd &= "DNI = " & .DNI.ToString.Trim & ", "
                CadenaCmd &= "Apellidos ='" & .Apellidos.Trim.ToUpper & "', "
                CadenaCmd &= "Nombres = '" & .Nombres.Trim.ToUpper & "', "
                CadenaCmd &= "FechaNacimiento = DateValue ('" & .FechaNacimiento.ToShortDateString.Trim.ToUpper & "'), "
                CadenaCmd &= "Genero = '" & .Genero.Trim.ToUpper & "', "
                CadenaCmd &= "Relacion = '" & .Relacion.Trim.ToUpper & "', "
                CadenaCmd &= "CUIL_Titular = " & .CUILT_Titular.ToString.Trim & ", "
                CadenaCmd &= "TipoAfiliado = '" & .TipoAfiliado.Trim.ToUpper & "', "
                CadenaCmd &= "UATRE = " & .UATRE.ToString.Trim & ", "
                CadenaCmd &= "Provincia = '" & .Provincia.Trim.ToUpper & "', "
                CadenaCmd &= "BocaExpendio = " & .BocaExpendio.ToString.Trim & ", "
                CadenaCmd &= "Departamento = '" & .Departamento.Trim.ToUpper & "', "
                CadenaCmd &= "Localidad = '" & .Localidad.Trim.ToUpper & "', "
                CadenaCmd &= "Domicilio = '" & .Domicilio.Trim.ToUpper & "', "
                CadenaCmd &= "Telefono = '" & .Telefono.Trim.ToUpper & "', "
                CadenaCmd &= "Email = '" & .Email.Trim.ToUpper & "', "
                CadenaCmd &= "TipoCarga = '" & .TipoCarga & "'"
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
    ''' Función utilizada para buscar un afiliado según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "ObraSocial".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaIdentificadorOLEDB."
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
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "CUIL"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL">Obligatorio. CUIL del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUILOLEDB(ByVal CadenaConexion As String, ByVal CUIL As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaCUILOLEDB."
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
            CadenaCmd &= "CUIL = " & CUIL.ToString.Trim.ToUpper
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDNIOLEDB(ByVal CadenaConexion As String, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaDNIOLEDB."
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
            CadenaCmd &= "DNI = " & DNI.ToString.Trim.ToUpper
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según sus atributos "CUIL" y "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL">Obligatorio. CUIL del afiliado a buscar.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUILDNIOLEDB(ByVal CadenaConexion As String, ByVal CUIL As Int64, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaCUILOLEDB."
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
            CadenaCmd &= "CUIL = " & CUIL.ToString.Trim
            CadenaCmd &= " and DNI = " & DNI.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según sus atributos "CUIL_Titular" y "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular del grupo familiar a buscar.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNIOLEDB(ByVal CadenaConexion As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaCUIL_TitularDNIOLEDB."
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
            CadenaCmd &= "CUIL_Titular = " & CUIL_Titular.ToString.Trim
            CadenaCmd &= " and DNI = " & DNI.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "Genero"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Genero">Obligatorio. Genero del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaGeneroOLEDB(ByVal CadenaConexion As String, ByVal Genero As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaGeneroOLEDB."
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
            CadenaCmd &= "Genero = '" & Genero.Trim.ToUpper & "'"
            CadenaCmd &= " Order by Apellidos, Nombres"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "Relacion"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Relacion">Obligatorio. Relacion del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaRelacionOLEDB(ByVal CadenaConexion As String, ByVal Relacion As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaRelacionOLEDB."
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
            CadenaCmd &= "Relacion = '" & Relacion.Trim.ToUpper & "'"
            CadenaCmd &= " Order by Apellidos, Nombres"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "TipoAfiliado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoAfiliado">Obligatorio. Relacion del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTipoAfiliadoOLEDB(ByVal CadenaConexion As String, ByVal TipoAfiliado As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaTipoAfiliadoOLEDB."
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
            CadenaCmd &= "TipoAfiliado = '" & TipoAfiliado.Trim.ToUpper & "'"
            CadenaCmd &= " Order by Apellidos, Nombres"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar el grupo familiar según su atributo "CUIL_Titular"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular del grupo familiar a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaGrupoFamiliarLEDB(ByVal CadenaConexion As String, ByVal CUIL_Titular As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaGrupoFamiliarLEDB."
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
            CadenaCmd &= "CUIL_Titular = " & CUIL_Titular.ToString.Trim
            CadenaCmd &= " Order by FechaNacimiento"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "Provincia"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Provincia">Obligatorio. Relacion del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaProvinciaOLEDB(ByVal CadenaConexion As String, ByVal Provincia As String) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaProvinciaOLEDB."
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
            CadenaCmd &= "Provincia = '" & Provincia.Trim.ToUpper & "'"
            CadenaCmd &= " Order by Apellidos, Nombres"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar un afiliado según su atributo "BocaExpendio"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="BocaExpendio">Obligatorio. BocaExpendio del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaBocaExpendioOLEDB(ByVal CadenaConexion As String, ByVal BocaExpendio As Int64) As Entidades.Afiliados
        Dim Valor As New Entidades.Afiliados
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaBocaExpendioLEDB."
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
            CadenaCmd &= "BocaExpendio = " & BocaExpendio.ToString.Trim.ToUpper
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Afiliado As New Entidades.Afiliado
                'Asigna los valores de los campos a los atributos del objeto
                With Afiliado
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("Apellidos")) Then .Apellidos = Lector("Apellidos")
                    If Not IsDBNull(Lector("Nombres")) Then .Nombres = Lector("Nombres")
                    If Not IsDBNull(Lector("FechaNacimiento")) Then .FechaNacimiento = Lector("FechaNacimiento")
                    If Not IsDBNull(Lector("Genero")) Then .Genero = Lector("Genero")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUILT_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("Relacion")) Then .Relacion = Lector("Relacion")
                    If Not IsDBNull(Lector("TipoAfiliado")) Then .TipoAfiliado = Lector("TipoAfiliado")
                    If Not IsDBNull(Lector("UATRE")) Then .UATRE = Lector("UATRE")
                    If Not IsDBNull(Lector("Provincia")) Then .Provincia = Lector("Provincia")
                    If Not IsDBNull(Lector("BocaExpendio")) Then .BocaExpendio = Lector("BocaExpendio")
                    If Not IsDBNull(Lector("Departamento")) Then .Departamento = Lector("Departamento")
                    If Not IsDBNull(Lector("Localidad")) Then .Localidad = Lector("Localidad")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("TipoCarga")) Then .TipoCarga = Lector("TipoCarga")
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
    ''' Función utilizada para buscar las distintas bocas de expendio
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Provincia">Obligatorio. Proviencia a la que pertenece la bocaExpendio del afiliado a buscar.</param>
    ''' <returns>Lista de cadenas de caracteres con las distintias bocas de expendio.</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDistintasBocasExpendioOLEDB(ByVal CadenaConexion As String, ByVal Provincia As String) As List(Of String)
        Dim Valor As New List(Of String)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select Distinct(BocaExpendio) as BocaExpendio from Afiliados Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaDistintasBocasExpendioOLEDB."
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
            CadenaCmd &= " Provincia = '" & Provincia.ToUpper.Trim & "'"
            CadenaCmd &= " Order by BocaExpendio "
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                If Not IsDBNull(Lector("BocaExpendio")) Then
                        'Inserta la boca de expendio a la lista
                        Valor.Add(Lector("BocaExpendio"))
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

    ''' <summary>
    ''' Función utilizada para buscar las distintas provincias
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <returns>Lista de cadenas de caracteres con las distintias provincias.</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDistintasProvinciasOLEDB(ByVal CadenaConexion As String) As List(Of String)
        Dim Valor As New List(Of String)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select Distinct(Provincia) as Provincia from Afiliados "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Afiliados." & vbCrLf & "   Método: ConsultaDistintasProvinciasOLEDB."
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
            CadenaCmd &= " Order by Provincia"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                If Not IsDBNull(Lector("Provincia")) Then
                    'Inserta la boca de expendio a la lista
                    Valor.Add(Lector("Provincia"))
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
