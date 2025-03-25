Imports System.Data.OleDb
Imports System.IO
Imports System.IO.Stream

Public Class frmAfiliadosImportacionDBF

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim afiliadosDBF As New Entidades.AfiliadosDBF
    Dim afiliados As New Entidades.Afiliados
    Dim ultimoRegistroImportado As Int64 = 0

    Dim Procesando As Boolean = False
    Dim ListaErrores As New SortedList
    Dim Sugerencias As New ToolTip

#End Region

#Region "Métodos públicos"

#End Region

#Region "Métodos privados"

    ''' <summary>
    ''' Procedimiento utilizado para inicializar el formulrio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Inicializar()
        Try
            'Actualiza la barra de estado
            Call ActualizaBarraEstado()
            'Carga las sugerencias
            Call CargarSugerencias()
            'Inicializa el último registro importado
            nudContinuarRegistro.Value = 1
            'Ubica el foco
            btnAchivo.Focus()
        Catch ex As Exception
            'Genera mensaje de error
            Dim MsgError As String = "Se generó un error al inicializar el formulario." & vbCrLf & vbCrLf & ex.Message
            MessageBox.Show(MsgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Cierra el formulario
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para actualizar la barra de estado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActualizaBarraEstado()
        Try
            'Indica cual es la lista de imagenes que utiliza la barra de estado
            ssBarraEstado.ImageList = Iconos
            'Inicializa las etiquetas de la barra de estado
            lblMensajeProgreso.Text = ""
        Catch ex As Exception
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: ActualizaBarraEstado"
            Throw New ArgumentException(CadenaMsg)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar las sugerencia de los controles
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarSugerencias()
        Try
            With Sugerencias
                'Habilitación de los controles de tareas generales
                .SetToolTip(btnAchivo, "Seleccionar archivo")
                .SetToolTip(btnEjecutar, "Ejecutar")
                .SetToolTip(btnCerrar, "Cerrar")
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
            Throw New ArgumentException(CadenaMsg)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para ejecutar el proceso de importación
    ''' </summary>
    Private Sub Proceso()
        'Cambia el estado de la variable de proceso
        Procesando = True
        'Deshabilita el botón de proceso
        btnEjecutar.Enabled = False
        'Lee los datos de la base de datos origen de datos
        If Leer() = True Then
            'Almacena los datos importados uno por uno
            If rbImportarUnoAUno.Checked = True Then
                Call AlmacenarDatos()
            Else
                Call AlmacenarDatosTodos()
            End If
        End If
        'Vuelve a cambiar el estado de la variable de procesp
        Procesando = False
        'Habilita el botón de proceso
        btnEjecutar.Enabled = True
    End Sub

    ''' <summary>
    ''' Procedimiento utilizad para leer e importar los datos desde el origen
    ''' </summary>
    Private Function Leer() As Boolean
        Dim Valor As Boolean = True
        'Presentalos controles de progreso
        lblMensajeProgreso.Visible = True
        pbBarraProgreso.Visible = True
        'Inicializa los controles de progreso
        lblMensajeProgreso.Text = ""
        'Evalúa si existe una selección de archivo
        If txtArchivo.Text.Trim.Length > 0 Then
            'Determina parámetro de importación
            Dim cadenaConexionArchivo As String = CadenaConexionDBF
            cadenaConexionArchivo = cadenaConexionArchivo.Replace("...", txtArchivo.Text)
            Dim capaNegocios As New CapaNegocios.AfiliadosDBF
            Try
                'Inicializa la colección
                afiliadosDBF.Clear()
                'Indica el progreso
                lblMensajeProgreso.Text = "Leyendo datos desde origen"
                My.Application.DoEvents()
                'Consulta los datos
                afiliadosDBF = capaNegocios.ConsultaTodos(cadenaConexionArchivo, TipoBaseDatos)
                cadenaMsg = "Se consultaron " & afiliadosDBF.Count.ToString.Trim & " afiliados."
                'Indica el progreso
                lblMensajeProgreso.Text = "Se leyenron " & afiliadosDBF.Count.ToString.Trim & " registros."
                My.Application.DoEvents()
            Catch ex As Exception
                'Presenta mensja de error
                cadenaMsg = "Se generó un error al tratar de consultar los datos del archivo origen de datos."
                cadenaMsg &= vbCrLf & ex.Message
                MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Cambia el valor de salida de la función
                Valor = False
            End Try
            'Cambia el valor de salida de la función
            Valor = True
        Else
            'Presenta mensja de error
            cadenaMsg = "No se seleccionó un archivo de origen de datos."
            MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Cambia el valor de salida de la función
            Valor = False
        End If
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento utilizado para almacenar los datos leídos
    ''' </summary>
    Private Sub AlmacenarDatos()
        'Evalúa los datos leídos
        If afiliadosDBF.Count > 0 Then
            Dim contador As Int64 = 0
            cadenaMsg = "¿Desea almacenar los " & afiliadosDBF.Count.ToString.Trim & " leídos?"
            If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim apellido As String = ""
                Dim nombre As String = ""
                Dim contadorAltas As Int64 = 0
                Dim contadorModificaciones As Int64 = 0
                Dim contadorDescartados As Int64 = 0
                Dim nombreCompleto As String = ""
                'Define desde que registro continuar la importación
                ultimoRegistroImportado = nudContinuarRegistro.Value
                'Inicializa la lista de errores
                ListaErrores.Clear()
                'Recorrido secuencial por la colección de afiliados leídos
                For Each afiliadoDBF As Entidades.AfiliadoDBF In afiliadosDBF
                    'Actualiza los controles de progreso
                    contador += 1
                    lblMensajeProgreso.Text = "Almacenado registro " & contador.ToString.Trim & " / " & afiliadosDBF.Count.ToString.Trim
                    My.Application.DoEvents()
                    'Inicializa la cadena de mensaje
                    cadenaMsg = ""
                    If contador >= ultimoRegistroImportado Then
                        'Define los atributos del afiliado a almacenar
                        Dim afiliado As New Entidades.Afiliado
                        With afiliado
                            If afiliadoDBF.Cuif = 0 Then
                                .CUIL = afiliadoDBF.cuil
                            Else
                                .CUIL = afiliadoDBF.Cuif
                            End If
                            .DNI = afiliadoDBF.Docu
                            nombreCompleto = afiliadoDBF.Nomb.Trim
                            If nombreCompleto.Length > 0 Then
                                'Valida los caracteres
                                nombreCompleto = CadenaTextoUnicamente(nombreCompleto)
                                If nombreCompleto.IndexOf(" ") <> -1 Then
                                    apellido = nombreCompleto.Substring(0, nombreCompleto.IndexOf(" ")).Trim.ToUpper
                                    nombre = nombreCompleto.Substring(nombreCompleto.IndexOf(" ") + 1).Trim.ToUpper
                                End If
                            End If
                            .Apellidos = apellido
                            .Nombres = nombre
                            If Not afiliadoDBF.Fnac = Nothing Then
                                .FechaNacimiento = afiliadoDBF.Fnac
                            End If
                            If afiliadoDBF.Sexo.ToString.Trim.Length > 0 Then
                                If afiliadoDBF.Sexo.ToString.ToUpper = "M" Then
                                    .Genero = "MASCULINO"
                                Else
                                    If afiliadoDBF.Sexo.ToString.ToUpper = "F" Then
                                        .Genero = "FEMENINO"
                                    Else
                                        .Genero = "OTRO"
                                    End If
                                End If
                            End If
                            .CUILT_Titular = afiliadoDBF.cuil
                            Select Case Int(afiliadoDBF.Secu)
                                Case 0
                                    .Relacion = "TITULAR"
                                Case 2
                                    .Relacion = "CONYUGE"
                                Case 3
                                    .Relacion = "HIJOS"
                                Case 4
                                    .Relacion = "HIJOS.CONYUGE"
                                Case Else
                                    .Relacion = "OTROS"
                            End Select
                            If afiliadoDBF.Orig = "R" Then
                                .TipoAfiliado = "RURAL"
                            Else
                                .TipoAfiliado = "MONOTRIBUTO"
                            End If
                            If afiliadoDBF.Uatre = "S" Then
                                .UATRE = True
                            Else
                                .UATRE = False
                            End If
                            .Provincia = "TUCUMAN"
                            .BocaExpendio = afiliadoDBF.Bexp
                            .TipoCarga = "IMPORTACION"
                        End With
                        'Evalúa si tiene los datos necesarios
                        If afiliadoDBF.Nomb.Trim.Length > 0 And (afiliadoDBF.cuil > 0 And afiliadoDBF.Docu > 0) Then
                            Dim CapaNeg As New CapaNegocios.Afiliados
                            Dim afiliadosExistentes As New Entidades.Afiliados
                            Try
                                'Valida los datos
                                Call CapaNeg.Validar(CadenaConexion, TipoBaseDatos, afiliado)
                                'Evalúa si existe
                                afiliadosExistentes = CapaNeg.ConsultaCUIL_TitularDNI(CadenaConexion, TipoBaseDatos, afiliado.CUILT_Titular, afiliado.DNI)
                                If afiliadosExistentes.Count = 0 Then
                                    'Realiza el alta de un afiliado
                                    Call CapaNeg.Alta(CadenaConexion, TipoBaseDatos, afiliado)
                                    contadorAltas += 1
                                Else
                                    'Realiza modificación de un afiliado
                                    afiliado.Id = afiliadosExistentes(0).Id
                                    Call CapaNeg.Modificar(CadenaConexion, TipoBaseDatos, afiliado)
                                    contadorModificaciones += 1
                                End If
                            Catch ex As Exception
                                'Evalúa si se debe detener el proceso de importación
                                If chkDetenerErrores.Checked = True Then
                                    'Genera un mensaje de error
                                    cadenaMsg = "Se generó un error al tratar de almacenar el afiliado " & afiliado.NombreCompleto & "."
                                    cadenaMsg &= vbCrLf & "¿Desea continuar con el proceso de almacenamiento?"
                                    If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                                        cadenaMsg = ""
                                    Else
                                        cadenaMsg = "El proceso no pudo terminar por un error de importación."
                                        Exit For
                                    End If
                                End If
                                'Agrega el error a la lista de errores
                                ListaErrores.Add(contador, afiliado.NombreCompleto & "->" & ex.Message)
                            Finally
                                'Libera los objetos utilizados para el almacenamiento
                                CapaNeg = Nothing
                            End Try
                        Else
                            contadorDescartados += 1
                        End If
                    End If
                Next
                'Evalúa si existe una mensaje de error
                If cadenaMsg.Trim.Length = 0 Then
                    cadenaMsg = "El proceso terminó satisfactoriamente."
                    cadenaMsg &= vbCrLf & "Se realizaron:"
                    cadenaMsg &= vbCrLf
                    cadenaMsg &= vbCrLf & "   Altas = " & contadorAltas.ToString.Trim
                    cadenaMsg &= vbCrLf & "   Modificaciones = " & contadorModificaciones.ToString.Trim
                    cadenaMsg &= vbCrLf & "   Descartados = " & contadorDescartados.ToString.Trim
                End If
                If ListaErrores.Count > 0 Then
                    cadenaMsg &= vbCrLf & "   Se generaron = " & ListaErrores.Count.ToString.Trim & " errores al almacenar los datos."
                    cadenaMsg &= vbCrLf & "   Los errores están almacenados en el portapapeles."
                    Dim enumerador As IDictionaryEnumerator = ListaErrores.GetEnumerator
                    Dim cadenaErrores As String = ""
                    While enumerador.MoveNext
                        cadenaErrores &= vbCrLf & enumerador.Key.ToString.Trim & "->" & enumerador.Value.ToString.Trim
                    End While
                    My.Computer.Clipboard.SetText(cadenaErrores)
                End If
                'Presenta mensaje de fin de proceso
                MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            cadenaMsg = "No se existen archivos leídos para ser guardados."
            MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para almacenar los datos leídos
    ''' </summary>
    Private Sub AlmacenarDatosTodos()
        'Evalúa los datos leídos
        If afiliadosDBF.Count > 0 Then
            Dim contador As Int64 = 0
            cadenaMsg = "¿Desea almacenar todos los " & afiliadosDBF.Count.ToString.Trim & " afiliados leídos?"
            If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim apellido As String = ""
                Dim nombre As String = ""
                Dim contadorAltas As Int64 = 0
                Dim contadorModificaciones As Int64 = 0
                Dim contadorDescartados As Int64 = 0
                Dim nombreCompleto As String = ""
                'Inicializa la colección
                afiliados.Clear()
                'Define desde que registro continuar la importación
                ultimoRegistroImportado = nudContinuarRegistro.Value
                'Inicializa la lista de errores
                ListaErrores.Clear()
                'Recorrido secuencial por la colección de afiliados leídos
                For Each afiliadoDBF As Entidades.AfiliadoDBF In afiliadosDBF
                    'Actualiza los controles de progreso
                    contador += 1
                    lblMensajeProgreso.Text = "Agregando a colección registro " & contador.ToString.Trim & " / " & afiliadosDBF.Count.ToString.Trim
                    My.Application.DoEvents()
                    'Inicializa la cadena de mensaje
                    cadenaMsg = ""
                    If contador >= ultimoRegistroImportado Then
                        If afiliadoDBF.Nomb.Trim.Length > 0 And (afiliadoDBF.cuil > 0 And afiliadoDBF.Docu > 0) Then
                            'Define los atributos del afiliado a almacenar
                            Dim afiliado As New Entidades.Afiliado
                            With afiliado
                                If afiliadoDBF.Cuif = 0 Then
                                    .CUIL = afiliadoDBF.cuil
                                Else
                                    .CUIL = afiliadoDBF.Cuif
                                End If
                                .DNI = afiliadoDBF.Docu
                                nombreCompleto = afiliadoDBF.Nomb.Trim
                                If nombreCompleto.Length > 0 Then
                                    'Valida los caracteres
                                    nombreCompleto = CadenaTextoUnicamente(nombreCompleto)
                                    If nombreCompleto.IndexOf(" ") <> -1 Then
                                        apellido = nombreCompleto.Substring(0, nombreCompleto.IndexOf(" ")).Trim.ToUpper
                                        nombre = nombreCompleto.Substring(nombreCompleto.IndexOf(" ") + 1).Trim.ToUpper
                                    End If
                                End If
                                .Apellidos = apellido
                                .Nombres = nombre
                                If Not afiliadoDBF.Fnac = Nothing Then
                                    .FechaNacimiento = afiliadoDBF.Fnac
                                End If
                                If afiliadoDBF.Sexo.ToString.Trim.Length > 0 Then
                                    If afiliadoDBF.Sexo.ToString.ToUpper = "M" Then
                                        .Genero = "MASCULINO"
                                    Else
                                        If afiliadoDBF.Sexo.ToString.ToUpper = "F" Then
                                            .Genero = "FEMENINO"
                                        Else
                                            .Genero = "OTRO"
                                        End If
                                    End If
                                End If
                                .CUILT_Titular = afiliadoDBF.cuil
                                Select Case Int(afiliadoDBF.Secu)
                                    Case 0
                                        .Relacion = "TITULAR"
                                    Case 2
                                        .Relacion = "CONYUGE"
                                    Case 3
                                        .Relacion = "HIJOS"
                                    Case 4
                                        .Relacion = "HIJOS.CONYUGE"
                                    Case Else
                                        .Relacion = "OTROS"
                                End Select
                                If afiliadoDBF.Orig = "R" Then
                                    .TipoAfiliado = "RURAL"
                                Else
                                    .TipoAfiliado = "MONOTRIBUTO"
                                End If
                                If afiliadoDBF.Uatre = "S" Then
                                    .UATRE = True
                                Else
                                    .UATRE = False
                                End If
                                .Provincia = "TUCUMAN"
                                .BocaExpendio = afiliadoDBF.Bexp
                                .TipoCarga = "IMPORTACION"
                            End With
                            'Agrega el objeto a la colección
                            afiliados.Add(afiliado)
                        End If
                    End If
                Next
                'Almacena toda la colección en la base de datos
                'Evalúa si tiene los datos necesarios
                If afiliados.Count > 0 Then
                    Dim formulario As New frmAfiliadosAlmacenar
                    Me.AddOwnedForm(formulario)
                    formulario._Afiliados = afiliados
                    formulario.Show()
                    formulario.Focus()
                End If
                'Evalúa si existe una mensaje de error
                If cadenaMsg.Trim.Length = 0 Then
                    cadenaMsg = "El proceso terminó satisfactoriamente."
                End If
                'Presenta mensaje de fin de proceso
                MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            cadenaMsg = "No se existen archivos leídos para ser guardados."
            MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmAfiliadosImportacionDBF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

    Private Sub frmAfiliadosImportacionDBF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmAfiliadosImportacionDBF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Evalúa si se está ejecutando un proceso
        If Procesando = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAchivo_Click(sender As Object, e As EventArgs) Handles btnAchivo.Click
        Dim dialogo As New OpenFileDialog
        dialogo.Filter = "Tbals .dbf|*.dbf|Todos los archivos|*.*"
        If dialogo.ShowDialog = DialogResult.OK Then
            txtArchivo.Text = dialogo.FileName
            txtArchivo.SelectionStart = txtArchivo.Text.Length
        End If
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Call Proceso()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Cierra el formulario
        Me.Close()
    End Sub

#End Region

End Class