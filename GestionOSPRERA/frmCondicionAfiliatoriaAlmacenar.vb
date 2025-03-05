Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.IO.Stream
Public Class frmCondicionAfiliatoriaAlmacenar

#Region "Propiedades públicas"

    Private mAfiliados As Entidades.Afiliados
    ''' <summary>
    ''' Propiedad que indica el o la Afiliados
    ''' </summary>
    ''' <value>mAfiliados valor del tipo Entidades.Afiliados.</value>
    ''' <returns>mAfiliados valor del tipo Entidades.Afiliados.</returns>
    ''' <remarks>Propiedad Afiliados.</remarks>
    Public Property _Afiliados() As Entidades.Afiliados
        Get
            Return mAfiliados
        End Get
        Set(ByVal value As Entidades.Afiliados)
            mAfiliados = value
        End Set
    End Property

    Private mCadenaConexionAnual As String
    ''' <summary>
    ''' Propiedad que indica el o la CadenaConexionAnual
    ''' </summary>
    ''' <value>mCadenaConexionAnual valor del tipo String.</value>
    ''' <returns>mCadenaConexionAnual valor del tipo String.</returns>
    ''' <remarks>Propiedad CadenaConexionAnual.</remarks>
    Public Property _CadenaConexionAnual() As String
        Get
            Return mCadenaConexionAnual
        End Get
        Set(ByVal value As String)
            mCadenaConexionAnual = value
        End Set
    End Property

    Private mAno As Int16
    ''' <summary>
    ''' Propiedad que indica el o la Ano
    ''' </summary>
    ''' <value>mAno valor del tipo Int16.</value>
    ''' <returns>mAno valor del tipo Int16.</returns>
    ''' <remarks>Propiedad Ano.</remarks>
    Public Property _Ano() As Int16
        Get
            Return mAno
        End Get
        Set(ByVal value As Int16)
            mAno = value
        End Set
    End Property

    Private mMes As Int16
    ''' <summary>
    ''' Propiedad que indica el o la Mes
    ''' </summary>
    ''' <value>mMes valor del tipo Int16.</value>
    ''' <returns>mMes valor del tipo Int16.</returns>
    ''' <remarks>Propiedad Mes.</remarks>
    Public Property _Mes() As Int16
        Get
            Return mMes
        End Get
        Set(ByVal value As Int16)
            mMes = value
        End Set
    End Property

    Private mAgregarAfiliado As Boolean
    ''' <summary>
    ''' Propiedad que indica el o la AgregarAfiliado
    ''' </summary>
    ''' <value>mAgregarAfiliado valor del tipo Boolean.</value>
    ''' <returns>mAgregarAfiliado valor del tipo Boolean.</returns>
    ''' <remarks>Propiedad AgregarAfiliado.</remarks>
    Public Property _AgregarAfiliado() As Boolean
        Get
            Return mAgregarAfiliado
        End Get
        Set(ByVal value As Boolean)
            mAgregarAfiliado = value
        End Set
    End Property

#End Region

#Region "Declaraciones"

    Dim ListaErrores As New SortedList

#End Region

#Region "Métodos públicos"

    ''' <summary>
    ''' Procedimiento ejecutado al instanciar el formulario
    ''' </summary>
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mAfiliados = New Entidades.Afiliados
        mCadenaConexionAnual = ""
        mAno = 0
        mMes = 0
        mAgregarAfiliado = False
    End Sub

#End Region

#Region "Métodos privados"

    ''' <summary>
    ''' Procedimiento utilizado para inicializar el formulario
    ''' </summary>
    Private Sub Inicializar()
        'Actualiza el título
        Me.Text = "Almacenamiento de la condición afiliatoria (" & mAno.ToString.Trim & "/" & mMes.ToString.Trim & ")"
        'Inicializa los controles de progreso
        lblMaximo.Text = mAfiliados.Count
        lblContador.Text = 0
        lblContador.Tag = 0
        pbBarraProgreso.Maximum = mAfiliados.Count
        pbBarraProgreso.Value = lblContador.Tag
        cadenaMsg = "Se van a almacenar " & mAfiliados.Count.ToString.Trim & " afiliados."
        cadenaMsg &= vbCrLf & "¿Desea continuar con el proceso?"
        If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Almacena los datos
            Call Almacenar()
        End If
        Me.Close()
    End Sub

    ''' <summary>
    ''' Procedimiento utilizad para almacenar la colección de afiliados
    ''' </summary>
    Private Sub Almacenar()
        Dim ConBDAfiliado As New OleDbConnection
        Dim ConBDCondicionAfiliado As New OleDbConnection
        Dim CmdAfiliado As New OleDbCommand
        Dim CmdCondicionAfiliado As New OleDbCommand
        Dim CadenaCmd As String = ""
        Dim contador As Int64 = 0
        Dim cantidad As Int64 = 0
        Dim cantidadAltasAfiliados As Int64 = 0
        Dim cantidadAltasCondicioneAfiliatorias As Int64 = 0
        'Evalúa la canidad de afiliados en la colección parametrizada
        If mAfiliados.Count > 0 Then
            'Inicializa la lista de errores
            ListaErrores.Clear()
            Try
                'Define la cadena de conexión aplicada a la conexión
                ConBDAfiliado.ConnectionString = CadenaConexion
                ConBDCondicionAfiliado.ConnectionString = mCadenaConexionAnual
                'Abre la conexión
                ConBDAfiliado.Open()
                ConBDCondicionAfiliado.Open()
                'Asigna la conexión abierta al comando instanciado
                CmdAfiliado.Connection = ConBDAfiliado
                CmdCondicionAfiliado.Connection = ConBDCondicionAfiliado
                'Define el tipo de consulta a realizarse
                CmdAfiliado.CommandType = CommandType.Text
                CmdAfiliado.CommandType = CommandType.Text
                'Recorrido secuencial por la colección de afiliados
                For Each afiliado As Entidades.Afiliado In mAfiliados
                    'Actualiza los controles de progreso
                    contador += 1
                    lblContador.Text = contador
                    lblContador.Tag = contador
                    If contador <= pbBarraProgreso.Maximum Then pbBarraProgreso.Value = contador
                    lblMensajeProgreso.Text = "Alta cond. afi. = " & cantidadAltasCondicioneAfiliatorias.ToString.Trim
                    lblMensajeProgreso.Text &= vbCrLf & "Alta afi. = " & cantidadAltasAfiliados.ToString.Trim
                    lblMensajeProgreso.Text &= vbCrLf & "Errores = " & ListaErrores.Count.ToString.Trim
                    My.Application.DoEvents()
                    'Busca el afiliado en la base de datos:
                    '--------------------------------------
                    Try
                        'Busca la existencia del afiliado
                        Dim afiliadoExistente As New Entidades.Afiliado
                        'Defina las sentencias de consulta
                        CadenaCmd = "Select count(*) from Afiliados Where DNI = " & afiliado.DNI.ToString.Trim & " and CUIL_Titular = " & afiliado.CUILT_Titular.ToString.Trim
                        'Define el comando
                        CmdAfiliado.CommandText = CadenaCmd
                        cantidad = CmdAfiliado.ExecuteScalar
                        If cantidad > 0 Then
                            'Defina las sentencias de consulta
                            CadenaCmd = "Select * from Afiliados Where DNI = " & afiliado.DNI.ToString.Trim & " and CUIL_Titular = " & afiliado.CUILT_Titular.ToString.Trim
                            'Define el comando
                            CmdAfiliado.CommandText = CadenaCmd
                            'Define el lector que recibirá el resultado de la consulta
                            Dim Lector As OleDbDataReader = CmdAfiliado.ExecuteReader
                            'Asigna los valores de los campos a los atributos del objeto
                            Lector.Read()
                            With afiliadoExistente
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
                            Lector.Close()
                        End If
                        'Busca la existencia de la condición afiliatoria
                        '-----------------------------------------------
                        Try
                            'Defina las sentencias de consulta
                            CadenaCmd = "Select count(*) from Padron Where (DNI = " & afiliado.DNI.ToString.Trim & " and CUIL_Titular = " & afiliado.CUILT_Titular.ToString.Trim & ") and Mes = " & mMes.ToString.Trim
                            'Define el comando
                            CmdCondicionAfiliado.CommandText = CadenaCmd
                            'Ejecuta la consulta
                            cantidad = CmdCondicionAfiliado.ExecuteScalar
                            'Evalúa si se debe agregar la condición afiliatoria
                            If cantidad = 0 Then
                                'Agrega la condición afiliatoria
                                'Define los atributos de la condición afiliatoria
                                Dim condicionaAfiliatoria As New Entidades.CondicionAfiliatoria
                                With condicionaAfiliatoria
                                    .Mes = mMes
                                    .Id_Afiliado = afiliadoExistente.Id
                                    .DNI = afiliado.DNI
                                    .CUIL = afiliado.CUIL
                                    .CUIL_Titular = afiliado.CUILT_Titular
                                    .TipoCondicion = "ACCESO.DIRECTO"
                                End With
                                'Define la sentencia se inserción
                                CadenaCmd = "Insert into Padron (Mes, Id_Afiliado, CUIL, DNI, CUIL_Titular, TipoCondicion) values ("
                                With condicionaAfiliatoria
                                    CadenaCmd &= .Mes.ToString.Trim & ", "
                                    CadenaCmd &= .Id_Afiliado.ToString.Trim & ", "
                                    CadenaCmd &= .CUIL.ToString.Trim & ", "
                                    CadenaCmd &= .DNI.ToString.Trim & ", "
                                    CadenaCmd &= .CUIL_Titular.ToString.Trim & ", "
                                    CadenaCmd &= "'" & .TipoCondicion.ToString.Trim & "')"
                                End With
                                'Define el comando
                                CmdCondicionAfiliado.CommandText = CadenaCmd
                                'Ejecuta la consulta
                                Call CmdCondicionAfiliado.ExecuteNonQuery()
                                'Incrementa el contador
                                cantidadAltasCondicioneAfiliatorias += 1
                                'Agrega el afiliado:
                                '-------------------
                                If mAgregarAfiliado = True Then
                                    If afiliadoExistente.Id = 0 Then
                                        'Define las sentencias de inserción del nuevo afiliado
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
                                        CmdAfiliado.CommandType = CommandType.Text
                                        'Define el comando
                                        CmdAfiliado.CommandText = CadenaCmd
                                        'Ejecuta la consulta
                                        Call CmdAfiliado.ExecuteNonQuery()
                                        'Incrementa el contador
                                        cantidadAltasAfiliados += 1
                                    End If
                                End If
                            End If
                        Catch ex As Exception
                            'Agrega el error a la lista
                            If ListaErrores.ContainsKey(afiliado.DNI) = False Then
                                ListaErrores.Add(afiliado.DNI, afiliado.NombreCompleto & "->" & ex.Message & "(cons. cond. afi./ins. cond./ins. afi.)")
                            Else
                                ListaErrores.Item(afiliado.DNI) = ListaErrores.Item(afiliado.DNI).ToString.Trim & ";" & ex.Message & "(cons. cond. afi./ins. cond./ins. afi.)"
                            End If
                        End Try
                    Catch ex As Exception
                        'Agrega el error a la lista
                        If ListaErrores.ContainsKey(afiliado.DNI) = False Then
                            ListaErrores.Add(afiliado.DNI, afiliado.NombreCompleto & "->" & ex.Message & "(consulta afiliado)")
                        Else
                            ListaErrores.Item(afiliado.DNI) = ListaErrores.Item(afiliado.DNI).ToString.Trim & ";" & ex.Message & "(consulta afiliado)"
                        End If
                    End Try
                Next
            Catch ex As Exception
                'Defineción del mensaje de error
                cadenaMsg = ex.Message & cadenaMsg
                MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'Cierra la conexión
                ConBDAfiliado.Close()
                ConBDCondicionAfiliado.Close()
                'Liberación de objetos utilizados
                ConBDAfiliado = Nothing
                ConBDCondicionAfiliado = Nothing
                CmdAfiliado = Nothing
                CmdCondicionAfiliado = Nothing
            End Try
            'Evalúa si hubo errores
            If ListaErrores.Count > 0 Then
                cadenaMsg = "Se generaron " & ListaErrores.Count.ToString.Trim & " errores en el almacenamiento."
                cadenaMsg &= vbCrLf & "¿Desea guardar estos errores en un archivo?"
                If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim dialogo As New SaveFileDialog
                    dialogo.Filter = "Archivos de texto|*.csv"
                    dialogo.FileName = "Errores al importar afiliados " & Now.ToShortDateString & " " & Now.ToShortTimeString
                    If dialogo.ShowDialog = DialogResult.OK Then
                        Dim archivo As New StreamWriter(dialogo.FileName)
                        Dim linea As String = ""
                        Dim enumerador As IDictionaryEnumerator = ListaErrores.GetEnumerator
                        While enumerador.MoveNext
                            linea = enumerador.Key.ToString.Trim & ";" & enumerador.Value.ToString.Trim & ";"
                            archivo.WriteLine(linea)
                        End While
                        archivo.Close()
                    End If
                    cadenaMsg = "El archivo se guardó correctamente."
                    cadenaMsg &= vbCrLf & "¿Desea abrirlo?"
                    If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Process.Start(dialogo.FileName)
                    End If
                End If
            End If
            'Presenta mensaje de fin de proceso
            cadenaMsg = "El proceso de importación de condiciones afiliatorias para el mes de " & mMes.ToString.Trim & " finalizó con los siguientes resultados:"
            cadenaMsg &= vbCrLf & vbCrLf & "     Altas afiliados = " & cantidadAltasAfiliados.ToString.Trim
            cadenaMsg &= vbCrLf & "     Altas cond. afi. = " & cantidadAltasCondicioneAfiliatorias.ToString.Trim
            cadenaMsg &= vbCrLf & "     Errores de importación = " & ListaErrores.Count.ToString.Trim
            MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmCondicionAfiliatoriaAlmacenar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub frmCondicionAfiliatoriaAlmacenar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmCondicionAfiliatoriaAlmacenar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

	Private Sub tRetardo_Tick(sender As Object, e As EventArgs) Handles tRetardo.Tick
        tRetardo.Enabled = False
        Call Inicializar()
    End Sub

#End Region

End Class