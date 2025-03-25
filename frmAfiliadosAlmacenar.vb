Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.IO.Stream
Public Class frmAfiliadosAlmacenar


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
    End Sub

#End Region

#Region "Métodos privados"

    ''' <summary>
    ''' Procedimiento utilizado para inicializar el formulario
    ''' </summary>
    Private Sub Inicializar()
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
        Dim ConBD As New OleDbConnection
        Dim Cmd As New OleDbCommand
        Dim CadenaCmd As String = ""
        Dim contador As Int64 = 0
        'Evalúa la canidad de afiliados en la colección parametrizada
        If mAfiliados.Count > 0 Then
            'Inicializa la lista de errores
            ListaErrores.Clear()
            Try
                'Define la cadena de conexión aplicada a la conexión
                ConBD.ConnectionString = CadenaConexion
                'Abre la conexión
                ConBD.Open()
                'Asigna la conexión abierta al comando instanciado
                Cmd.Connection = ConBD
                'Recorrido secuencial por la colección de afiliados
                For Each afiliado As Entidades.Afiliado In mAfiliados
                    'Actualiza los controles de progreso
                    contador += 1
                    lblContador.Text = contador
                    lblContador.Tag = contador
                    pbBarraProgreso.Value = contador
                    My.Application.DoEvents()
                    Try
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
                        Call Cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        'Agrega el error a la lista
                        If ListaErrores.ContainsKey(afiliado.DNI) = False Then
                            ListaErrores.Add(afiliado.DNI, afiliado.NombreCompleto & "->" & ex.Message)
                        Else
                            ListaErrores.Item(afiliado.DNI) = ListaErrores.Item(afiliado.DNI).ToString.Trim & ";" & ex.Message
                        End If
                    End Try
                Next
            Catch ex As Exception
                'Defineción del mensaje de error
                cadenaMsg = ex.Message & cadenaMsg
                'Genera un nuevo tipo de mensaje de error
                Throw New ArgumentException(cadenaMsg)
            Finally
                'Cierra la conexión
                ConBD.Close()
                'Liberación de objetos utilizados
                ConBD = Nothing
                Cmd = Nothing
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
        End If
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmAfiliadosAlmacenar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmAfiliadosAlmacenar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmAfiliadosAlmacenar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub tRetardo_Tick(sender As Object, e As EventArgs) Handles tRetardo.Tick
        tRetardo.Enabled = False
        Call Inicializar()
    End Sub

#End Region

End Class