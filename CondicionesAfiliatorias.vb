'***********************************************************************************************
'*
'*  Clase: CondicionesAfiliatorias
'*  Capa: Datos
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 18/02/2025
'*  Descripción: Clase utilizada para realizar todas la acciones necesarias sobre la base de datos
'*               las base de datos.
'*
'***********************************************************************************************
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Entidades
Public Class CondicionesAfiliatorias

#Region "Métodos públicos relacionados a OLEDB"

    ''' <summary>
    ''' Función utilizada para dar de alta una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CondicionAfiliatoria">Obligatorio. Objeto de la clase "CondicionAfiliatoria", con todos los atributos necesarios para dar de alta el nuevo dato básico.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaOLEDB(ByVal CadenaConexion As String, ByVal CondicionAfiliatoria As Entidades.CondicionAfiliatoria) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Insert into Padron (Mes, Id_Afiliado, CUIL, DNI, CUIL_Titular, TipoCondicion) values ("
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: AltaOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            Try
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Define el tipo de comando a ejecutar
                With CondicionAfiliatoria
                    CadenaCmd &= .Mes.ToString.Trim & ", "
                    CadenaCmd &= .Id_Afiliado.ToString.Trim & ", "
                    CadenaCmd &= .CUIL.ToString.Trim & ", "
                    CadenaCmd &= .DNI.ToString.Trim & ", "
                    CadenaCmd &= .CUIL_Titular.ToString.Trim & ", "
                    CadenaCmd &= "'" & .TipoCondicion.Trim.ToUpper & "')"
                End With
                Cmd.CommandType = CommandType.Text
                'Define el comando
                Cmd.CommandText = CadenaCmd
                'Ejecuta la consulta
                Call Cmd.ExecuteScalar()
                'Determina el nuevo número de Id.
                CadenaCmd = "Select Max(Id) from Padron"
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
    ''' Procedimiento utilizado para dar de baja una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador del afiliado a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub BajaOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Delete from Padron Where "
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: BajaOLEDB."
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
    ''' Procedimiento utilizado para modificar una condición afiliatoria
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CondicionAfiliatoria">Obligatorio. Objeto de la clase "CondicionAfiliatoria", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub ModificacionOLEDB(ByVal CadenaConexion As String, ByVal CondicionAfiliatoria As Entidades.CondicionAfiliatoria)
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Update Padron Set "
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ModificacionOLEDB."
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
            With CondicionAfiliatoria
                CadenaCmd &= "Mes = " & .Mes.ToString.Trim & ", "
                CadenaCmd &= "Id_Afiliado = " & .Id_Afiliado.ToString.Trim & ", "
                CadenaCmd &= "CUIL = " & .CUIL.ToString.Trim & ", "
                CadenaCmd &= "DNI = " & .DNI.ToString.Trim & ", "
                CadenaCmd &= "CUIL_Titular = " & .CUIL_Titular.ToString.Trim & ", "
                CadenaCmd &= "TipoCondicion = '" & .TipoCondicion & "'"
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador de la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaIdentificadorOLEDB."
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
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "Id_Afiliado"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id_Afiliado">Obligatorio. Número identificador del afiliado relacionado a la condición afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaAfiliadoOLEDB(ByVal CadenaConexion As String, ByVal Id_Afiliado As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaAfiliadoOLEDB."
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
            CadenaCmd &= "Id_Afiliado = " & Id_Afiliado.ToString.Trim
            CadenaCmd &= " Order by Mes"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    Public Function ConsultaCUILOLEDB(ByVal CadenaConexion As String, ByVal CUIL As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaCUILOLEDB."
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
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    ''' Función utilizada para buscar una condición afiliatoria según su atributo "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaDNIOLEDB(ByVal CadenaConexion As String, ByVal DNI As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaDNIOLEDB."
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
            CadenaCmd &= " Order by Mes Desc "
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    ''' Función utilizada para buscar una condición afiliatoria según sus atributos "CUIL_Titular" y "DNI"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular a buscar.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNIOLEDB(ByVal CadenaConexion As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaCUIL_TitularDNIOLEDB."
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
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    ''' Función utilizada para buscar una condición afiliatoria según sus atributos "CUIL_Titular", "DNI", "Mes"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular a buscar.</param>
    ''' <param name="DNI">Obligatorio. DNI del afiliado a buscar.</param>
    ''' <param name="Mes_Desde">Obligatorio. Mes sobre el cual se desea consultar.</param>
    ''' <param name="Mes_Hasta">Opcional. Mes hasta el cual se desea consultar. Por defecto es cero.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUIL_TitularDNIMesesOLEDB(ByVal CadenaConexion As String, ByVal CUIL_Titular As Int64, ByVal DNI As Int64, ByVal Mes_Desde As Int16, Optional Mes_Hasta As Int16 = 0) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaCUIL_TitularDNIMesesOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            'Asigna la conexión abierta al comando instanciado
            Cmd.Connection = ConBD
            'Define el tipo de comando a ejecutar
            Cmd.CommandType = CommandType.Text
            'Analiza el mes hasta el cual se debe evaluar
            If Mes_Hasta = 0 Then
                Mes_Hasta = Mes_Desde
            End If
            'Recorrido secuencial por los meses
            For mes As Int16 = Mes_Desde To Mes_Hasta
                Dim CondicionesAfiliatorias As New Entidades.CondicionesAfiliatorias
                'Define el comando
                CadenaCmd &= "(CUIL_Titular = " & CUIL_Titular.ToString.Trim
                CadenaCmd &= " and DNI = " & DNI.ToString.Trim & ")"
                CadenaCmd &= " and Mes = " & mes.ToString.Trim
                CadenaCmd &= " Order by Mes, DNI"
                Cmd.CommandText = CadenaCmd
                'Define el lector que recibirá el resultado de la consulta
                Dim Lector As OleDbDataReader = Cmd.ExecuteReader
                'Recorrido secuencial por los registros encontrados
                While Lector.Read
                    'Define el objeto que recibirá los datos
                    Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                    'Asigna los valores de los campos a los atributos del objeto
                    With CondicionAfiliatoria
                        If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                        If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                        If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                        If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                        If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                        If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                        If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                    End With
                    'Inserta el objeto a la colección respectiva
                    CondicionesAfiliatorias.Add(CondicionAfiliatoria)
                    'Libera el objeto
                    CondicionAfiliatoria = Nothing
                End While
                'Agrega las condiciones afiliatorias consultadas
                Valor.AddRange(CondicionesAfiliatorias)
                'Libera la colección
                CondicionesAfiliatorias = Nothing
            Next
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
    ''' Función utilizada para buscar las condiciones afiliatorias según su atributo "Mes"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Mes">Obligatorio. Mes de las condiciones afiliatoria a buscar.</param>
    ''' <returns>Colección de objetos de la clase "CondicionAfiliatoria".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaMesOLEDB(ByVal CadenaConexion As String, ByVal Mes As Int16) As Entidades.CondicionesAfiliatorias
        Dim Valor As New Entidades.CondicionesAfiliatorias
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaMesOLEDB."
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
            CadenaCmd &= "Mes = " & Mes.ToString.Trim
            CadenaCmd &= "Order by CUIL_Titular, DNI"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim CondicionAfiliatoria As New Entidades.CondicionAfiliatoria
                'Asigna los valores de los campos a los atributos del objeto
                With CondicionAfiliatoria
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("Mes")) Then .Mes = Lector("Mes")
                    If Not IsDBNull(Lector("Id_Afiliado")) Then .Id_Afiliado = Lector("Id_Afiliado")
                    If Not IsDBNull(Lector("CUIL")) Then .CUIL = Lector("CUIL")
                    If Not IsDBNull(Lector("DNI")) Then .DNI = Lector("DNI")
                    If Not IsDBNull(Lector("CUIL_Titular")) Then .CUIL_Titular = Lector("CUIL_Titular")
                    If Not IsDBNull(Lector("TipoCondicion")) Then .TipoCondicion = Lector("TipoCondicion")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(CondicionAfiliatoria)
                'Libera el objeto
                CondicionAfiliatoria = Nothing
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
    ''' Función utilizada para buscar la cantidad de afiliados en condiciones afiliatorias según su atributo "Mes"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Mes">Obligatorio. Mes de las condiciones afiliatoria a buscar.</param>
    ''' <returns>Valor entero con a cantidad.</returns>
    ''' <remarks></remarks>
    Public Function ConsultaMesCantidadOLEDB(ByVal CadenaConexion As String, ByVal Mes As Int16) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select count(*) from Padron Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: CondicionesAfiliatorias." & vbCrLf & "   Método: ConsultaMesCantidadOLEDB."
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
            CadenaCmd &= "Mes = " & Mes.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Valor = Cmd.ExecuteScalar
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
