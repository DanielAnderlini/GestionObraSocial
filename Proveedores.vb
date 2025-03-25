'***********************************************************************************************
'*
'*  Clase: Proveedores
'*  Capa: Datos
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 20/03/2025
'*  Descripción: Clase utilizada para realizar todas la acciones necesarias sobre la base de datos
'*               las base de datos.
'*
'***********************************************************************************************
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Proveedores

#Region "Métodos públicos relacionados a OLEDB"

    ''' <summary>
    ''' Función utilizada para dar de alta un proveedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Proveedor">Obligatorio. Objeto de la clase "Proveedor", con todos los atributos necesarios para dar de alta el nuevo dato básico.</param>
    ''' <returns>Valor entero de 64 bits, con el nuevo número identificador asignado.</returns>
    ''' <remarks></remarks>
    Public Function AltaOLEDB(ByVal CadenaConexion As String, ByVal Proveedor As Entidades.Proveedor) As Int64
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Insert into Proveedores (NumeroSAP, CUIT, RazonSocial, Telefono, Email, Domicilio, NumeroCuenta, CBU, Id_Categoria, Id_Subcategoria, DiasVencimiento, Habilitado) values ("
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: AltaOLEDB."
        Try
            'Define la cadena de conexión aplicada a la conexión
            ConBD.ConnectionString = CadenaConexion
            'Abre la conexión
            ConBD.Open()
            Try
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Define el tipo de comando a ejecutar
                With Proveedor
                    CadenaCmd &= .NumeroSAP.ToString.Trim & ", "
                    CadenaCmd &= .CUIT.ToString.Trim & ", "
                    CadenaCmd &= "'" & .RazonSocial.ToUpper.Trim & "', "
                    CadenaCmd &= "'" & .Telefono.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Email.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .Domicilio.Trim.ToUpper & "', "
                    CadenaCmd &= "'" & .NumeroCuenta.ToString.Trim & "', "
                    CadenaCmd &= "'" & .CBU.ToString.Trim & "', "
                    CadenaCmd &= .Id_Categoria.ToString.Trim & ", "
                    CadenaCmd &= .Id_Subcategoria.ToString.Trim & ", "
                    CadenaCmd &= .DiasVencimiento.ToString.Trim & ", "
                    CadenaCmd &= .Habilitado.ToString.Trim
                    CadenaCmd &= ")"
                End With
                Cmd.CommandType = CommandType.Text
                'Define el comando
                Cmd.CommandText = CadenaCmd
                'Ejecuta la consulta
                Call Cmd.ExecuteScalar()
                'Determina el nuevo número de Id.
                CadenaCmd = "Select Max(Id) from Proveedores"
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
    ''' Procedimiento utilizado para dar de baja un proveedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador del proveedor a eliminar.</param>
    ''' <remarks></remarks>
    Public Sub BajaOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64)
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Delete from Proveedores Where "
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: BajaOLEDB."
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
    ''' Procedimiento utilizado para modificar un proveedor
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Proveedor">Obligatorio. Objeto de la clase "Proveedor", con todos los atributos necesarios para modificar el dato general.</param>
    ''' <remarks></remarks>
    Public Sub ModificacionOLEDB(ByVal CadenaConexion As String, ByVal Proveedor As Entidades.Proveedor)
        Dim Valor As Int64 = 0
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Update Proveedores Set "
        Dim CadenaCategorias As String = ""
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ModificacionOLEDB."
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
            With Proveedor
                CadenaCmd &= "NumeroSAP = " & .NumeroSAP.ToString.Trim & ", "
                CadenaCmd &= "CUIT = " & .CUIT.ToString.Trim & ", "
                CadenaCmd &= "RazonSocial = '" & .RazonSocial.ToUpper.Trim & "', "
                CadenaCmd &= "Telefono = '" & .Telefono.Trim.ToUpper & "', "
                CadenaCmd &= "Email = '" & .Email.Trim.ToUpper & "', "
                CadenaCmd &= "Domicilio = '" & .Domicilio.Trim.ToUpper & "', "
                CadenaCmd &= "NumeroCuenta = '" & .NumeroCuenta.ToString.Trim & "', "
                CadenaCmd &= "CBU = '" & .CBU.ToString.Trim & "', "
                CadenaCmd &= "Id_Categoria = " & .Id_Categoria.ToString.Trim & ", "
                CadenaCmd &= "Id_Subcategoria = " & .Id_Subcategoria.ToString.Trim & ", "
                CadenaCmd &= "DiasVencimiento = " & .DiasVencimiento.ToString.Trim & ", "
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
    ''' Función utilizada para buscar todos los proveedores
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTodosOLEDB(ByVal CadenaConexion As String) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaTodosOLEDB."
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
            CadenaCmd &= " Order by RazonSocial"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según su atributo "Id"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id">Obligatorio. Número identificador del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaIdentificadorOLEDB(ByVal CadenaConexion As String, ByVal Id As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaIdentificadorOLEDB."
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
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según su atributo "NumeroSAP"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="NumeroSAP">Obligatorio. Número SAP del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaNumeroSAPOLEDB(ByVal CadenaConexion As String, ByVal NumeroSAP As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaNumeroSAPOLEDB."
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
            CadenaCmd &= "NumeroSAP = " & NumeroSAP.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según su atributo "CUIT"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="CUIT">Obligatorio. Número SAP del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCUITOLEDB(ByVal CadenaConexion As String, ByVal CUIT As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaCUITOLEDB."
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
            CadenaCmd &= "CUIT = " & CUIT.ToString.Trim
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según su atributo "Categoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id_Categoria">Obligatorio. Número identificador de la categoría del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCategoriaOLEDB(ByVal CadenaConexion As String, ByVal Id_Categoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaCategoriaOLEDB."
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
            CadenaCmd &= "Id_Categoria = " & Id_Categoria.ToString.Trim
            CadenaCmd &= " Order by RazonSocial"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según su atributo "Subcategoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id_Subcategoria">Obligatorio. Número identificador de la categoría del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaSubcategoriaOLEDB(ByVal CadenaConexion As String, ByVal Id_Subcategoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaSubcategoriaOLEDB."
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
            CadenaCmd &= "Id_Subcategoria = " & Id_Subcategoria.ToString.Trim
            CadenaCmd &= " Order by RazonSocial"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
    ''' Función utilizada para buscar un proveedor según sus atributos "Categoria" y "Subcategoria"
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="Id_Categoria">Obligatorio. Número identificador de la categoría del proveedor a buscar.</param>
    ''' <param name="Id_Subcategoria">Obligatorio. Número identificador de la subcategoría del proveedor a buscar.</param>
    ''' <returns>Colección de objetos de la clase "Proveedor".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaCategoriaSubcategoriaOLEDB(ByVal CadenaConexion As String, ByVal Id_Categoria As Int64, ByVal Id_Subcategoria As Int64) As Entidades.Proveedores
        Dim Valor As New Entidades.Proveedores
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = "Select * from Proveedores Where "
        Dim TablaCategorias As New List(Of Int64)
        Dim CadenaMsg As String = vbCrLf & vbCrLf & "   Capa: Datos." & vbCrLf & "   Clase: Proveedores." & vbCrLf & "   Método: ConsultaCategoriaSubcategoriaOLEDB."
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
            CadenaCmd &= "Id_Categoria = " & Id_Categoria.ToString.Trim
            CadenaCmd &= " and Id_Subcategoria = " & Id_Subcategoria.ToString.Trim
            CadenaCmd &= " Order by RazonSocial"
            Cmd.CommandText = CadenaCmd
            'Define el lector que recibirá el resultado de la consulta
            Dim Lector As OleDbDataReader = Cmd.ExecuteReader
            'Recorrido secuencial por los registros encontrados
            While Lector.Read
                'Define el objeto que recibirá los datos
                Dim Proveedor As New Entidades.Proveedor
                'Asigna los valores de los campos a los atributos del objeto
                With Proveedor
                    If Not IsDBNull(Lector("Id")) Then .Id = Lector("Id")
                    If Not IsDBNull(Lector("NumeroSAP")) Then .NumeroSAP = Lector("NumeroSAP")
                    If Not IsDBNull(Lector("CUIT")) Then .CUIT = Lector("CUIT")
                    If Not IsDBNull(Lector("RazonSocial")) Then .RazonSocial = Lector("RazonSocial")
                    If Not IsDBNull(Lector("Telefono")) Then .Telefono = Lector("Telefono")
                    If Not IsDBNull(Lector("Email")) Then .Email = Lector("Email")
                    If Not IsDBNull(Lector("Domicilio")) Then .Domicilio = Lector("Domicilio")
                    If Not IsDBNull(Lector("NumeroCuenta")) Then .NumeroCuenta = Lector("NumeroCuenta")
                    If Not IsDBNull(Lector("CBU")) Then .CBU = Lector("CBU")
                    If Not IsDBNull(Lector("Id_Categoria")) Then .Id_Categoria = Lector("Id_Categoria")
                    If Not IsDBNull(Lector("Id_Subcategoria")) Then .Id_Subcategoria = Lector("Id_Subcategoria")
                    If Not IsDBNull(Lector("DiasVencimiento")) Then .DiasVencimiento = Lector("DiasVencimiento")
                    If Not IsDBNull(Lector("Habilitado")) Then .Habilitado = Lector("Habilitado")
                End With
                'Inserta el objeto a la colección respectiva
                Valor.Add(Proveedor)
                'Libera el objeto
                Proveedor = Nothing
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
