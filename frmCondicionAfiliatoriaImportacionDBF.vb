Imports System.Collections.Concurrent
Imports System.IO
Imports System.Timers
Imports Entidades
Public Class frmCondicionAfiliatoriaImportacionDBF


#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim CadenaConexionAnual As String = ""

    Dim afiliadosDBF As New Entidades.AfiliadosDBF
    Dim afiliados As New Entidades.Afiliados

    Dim contadorAltasCondicones As Int64 = 0
    Dim contadorAltasAfiliados As Int64 = 0
    Dim contadorExistentes As Int64 = 0
    Dim contadorDescartados As Int64 = 0
    Dim continuar As Boolean = True
    Dim Procesando As Boolean = False

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
            'Inicializa período
            nudAno.Value = Now.Year
            nudMes.Value = Now.Month
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
    ''' Función utilizada para buscar un afiliado desde la base de datos
    ''' </summary>
    ''' <param name="CUIL_Titular">Obligatorio. CUIL del titular.</param>
    ''' <param name="DNI">Oblligatorio. DNI del afiliado.</param>
    ''' <returns>Objeto de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Private Function BuscarAfiliado(ByVal CUIL_Titular As Int64, ByVal DNI As Int64) As Entidades.Afiliado
        Dim Valor As New Entidades.Afiliado
        Dim CapaNeg As New CapaNegocios.Afiliados
        Dim AfiliadosExitentes As New Entidades.Afiliados
        Try
            'Inicializa la colección
            If AfiliadosExitentes.Count > 0 Then AfiliadosExitentes.Clear()
            'Consulta a los datos de la base de datos:
            AfiliadosExitentes = CapaNeg.ConsultaCUIL_TitularDNI(CadenaConexion, TipoBaseDatos, CUIL_Titular, DNI)
            'Evalúa los resultados de la consulta
            If AfiliadosExitentes.Count > 0 Then
                Valor = AfiliadosExitentes(0)
            End If
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
            AfiliadosExitentes = Nothing
        End Try
        'Valor de retorno de la función
        Return Valor
    End Function

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
            'Determina de base de datos de movimientos (padrón)
            If ChequearBaseDatosMovimientos(nudAno.Value) = True Then
                'Define la cadena de conexión de la base de datos anual
                CadenaConexionAnual = DeterminarCadenaConexionMovimiento(nudAno.Value)
                'Almacena los datos importados uno por uno
                If rbImportarUnoAUno.Checked = True Then
                    'Almacena los datos importados
                    Call AlmacenarDatos()
                Else
                    Call AlmacenarDatosTodos()
                End If
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
    ''' Función utilizada para buscar un afiliado desde la base de datos
    ''' </summary>
    ''' <param name="afiliado">Obligatorio. Objeto de la clase "Afiliado" que se desea buscar.</param>
    ''' <returns>Objeto de la clase "Afiliado".</returns>
    ''' <remarks></remarks>
    Private Function BuscarAfiliadoBD(ByVal afiliado As Entidades.Afiliado) As Entidades.Afiliado
        Dim valor As New Entidades.Afiliado
        Dim afiliados As New Entidades.Afiliados
        Dim CapaNeg As New CapaNegocios.Afiliados
        Try
            'Inicializa la colección
            If Afiliados.Count > 0 Then Afiliados.Clear()
            'Consulta a los datos de la base de datos:
            afiliados = CapaNeg.ConsultaCUIL_TitularDNI(CadenaConexion, TipoBaseDatos, afiliado.CUILT_Titular, afiliado.DNI)
            'Evalúa los resultados de la búsqueda
            If afiliados.Count > 0 Then
                valor = afiliados(0)
            End If
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
        'Valor de retorno de la función
        Return valor
    End Function

    ''' <summary>
    ''' Procedimiento uilizado para almacenar los datos leídos
    ''' </summary>
    Private Sub AlmacenarDatos()
        'Evalúa los datos leídos
        If afiliadosDBF.Count > 0 Then
            Dim contador As Int64 = 0
            cadenaMsg = "¿Desea almacenar los " & afiliadosDBF.Count.ToString.Trim & " leídos?"
            If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim apellido As String = ""
                Dim nombre As String = ""
                Dim nombreCompleto As String = ""
                'Inicializa la variable de continuación de proceso
                continuar = True
                'Inicializa los contadores
                contadorAltasCondicones = 0
                contadorAltasAfiliados = 0
                contadorExistentes = 0
                contadorDescartados = 0
                'Recorrido secuencial por la colección de afiliados leídos
                For Each afiliadoDBF As Entidades.AfiliadoDBF In afiliadosDBF
                    'Inicializa la cadena de error
                    cadenaMsg = ""
                    'Actualiza los controles de progreso
                    contador += 1
                    lblMensajeProgreso.Text = "Almacenado registro " & contador.ToString.Trim & " / " & afiliadosDBF.Count.ToString.Trim
                    My.Application.DoEvents()
                    'Evalúa si el afiliado está en condiciones
                    If afiliadoDBF.Cond.Trim.ToUpper.Substring(0, 1) = "S" Then
                        'Evalúa si tiene los datos necesarios
                        If afiliadoDBF.Nomb.Trim.Length > 0 And (afiliadoDBF.cuil > 0 And afiliadoDBF.Docu > 0) Then
                            'Define los atributos del afiliado
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
                                Select Case afiliadoDBF.Secu
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
                                .TipoAfiliado = "IMPORTACION"
                            End With
                            'Busca si existe el afiliado en la base de datos del sistema
                            Dim afiliadoExistente As Entidades.Afiliado = BuscarAfiliadoBD(afiliado)
                            'Define los atributos de la condición afiliatoria
                            Dim condicionaAfiliatoria As New Entidades.CondicionAfiliatoria
                            With condicionaAfiliatoria
                                .Mes = nudMes.Value
                                .Id_Afiliado = afiliadoExistente.Id
                                If afiliadoDBF.Cuif = 0 Then
                                    .CUIL = afiliadoDBF.cuil
                                Else
                                    .CUIL = afiliadoDBF.Cuif
                                End If
                                .DNI = afiliadoDBF.Docu
                                .CUIL_Titular = afiliadoDBF.cuil
                                .TipoCondicion = "ACCESO.DIRECTO"
                            End With
                            'Almacena la condición afiliatoria
                            Dim capaNeg As New CapaNegocios.CondicionesAfiliatorias
                            Dim CondicionesExistente As New Entidades.CondicionesAfiliatorias
                            Try
                                'Busca si existe la la condición afiliatoria
                                CondicionesExistente = capaNeg.ConsultaCUIL_TitularDNIMeses(CadenaConexionAnual, TipoBaseDatos, condicionaAfiliatoria.CUIL_Titular, condicionaAfiliatoria.DNI, nudMes.Value)
                                If CondicionesExistente.Count = 0 Then
                                    'Agrega la condición afiliatoria
                                    Call capaNeg.Alta(CadenaConexionAnual, TipoBaseDatos, condicionaAfiliatoria)
                                    'Incrementa el contador
                                    contadorAltasCondicones += 1
                                Else
                                    'Incrementa el contador de condiciones existentes
                                    contadorExistentes += 1
                                End If
                            Catch ex As Exception
                                'Presenta mensaje de error
                                cadenaMsg = "Se generó un error al almacenar la condición afiliatoria del DNI " & condicionaAfiliatoria.DNI.ToString.Trim & " y con el CUIL del titular " & condicionaAfiliatoria.CUIL_Titular.ToString.Trim & "."
                                cadenaMsg &= vbCrLf & "¿Desea continuar con el proceso de importación?"
                                If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
                                    continuar = False
                                End If
                            Finally
                                'Libera objetos utilizado para la consulta y almacenamiento
                                capaNeg = Nothing
                                CondicionesExistente = Nothing
                            End Try
                            'Evalúa si se deben guardar los datos del afiliado
                            If chkAltaAfiliados.Checked = True Then
                                If afiliadoExistente.Id = 0 Then
                                    Call AlmacenarAfiliado(afiliado)
                                End If
                            End If
                        End If
                    End If
                    'Evalúa si se interrumpirá el proceso
                    If continuar = False Then
                        Exit For
                    End If
                Next
                'Evalúa si existe contenido mensaje en la cadena de error
                If cadenaMsg.Trim.Length = 0 Then
                    'Presenta mensaje de acción satisfactoria
                    cadenaMsg = "El proceso terminó satisfactoriamente."
                    cadenaMsg &= vbCrLf & "Se realizaron:"
                    cadenaMsg &= vbCrLf
                    cadenaMsg &= vbCrLf & "Condiciones afiliatorias:"
                    cadenaMsg &= vbCrLf & "   Altas = " & contadorAltasCondicones.ToString.Trim
                    cadenaMsg &= vbCrLf & "   Existentes = " & contadorExistentes.ToString.Trim
                    cadenaMsg &= vbCrLf & "   Descartados = " & contadorDescartados.ToString.Trim
                    If chkAltaAfiliados.Checked = True Then
                        cadenaMsg &= vbCrLf
                        cadenaMsg &= vbCrLf & "Afiliados:"
                        cadenaMsg &= vbCrLf & "   Altas = " & contadorAltasAfiliados.ToString.Trim
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para dar de alta un afiliado
    ''' </summary>
    ''' <param name="afiliado">Obligatorio. Objeto de la clase "Afiliado".</param>
    Private Sub AlmacenarAfiliado(ByVal afiliado As Entidades.Afiliado)
        Dim CapaNeg As New CapaNegocios.Afiliados
        Dim afiliadosExistentes As New Entidades.Afiliados
        Try
            'Valida los datos
            Call CapaNeg.Validar(CadenaConexion, TipoBaseDatos, afiliado)
            'Evalúa si existe
            afiliadosExistentes = CapaNeg.ConsultaCUILDNI(CadenaConexion, TipoBaseDatos, afiliado.CUIL, afiliado.DNI)
            If afiliadosExistentes.Count = 0 Then
                'Realiza el alta de un afiliado
                Call CapaNeg.Alta(CadenaConexion, TipoBaseDatos, afiliado)
                contadorAltasAfiliados += 1
            End If
        Catch ex As Exception
            'Genera un mensaje de error
            cadenaMsg = "Se generó un error al tratar de almacenar el afiliado " & afiliado.NombreCompleto & "."
            cadenaMsg &= vbCrLf & "¿Desea continuar con el proceso de almacenamiento?"
            If MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                cadenaMsg = ""
                continuar = True
            Else
                cadenaMsg = "El proceso no pudo terminar por un error de importación."
                continuar = False
            End If
        Finally
            'Libera los objetos utilizados para el almacenamiento
            CapaNeg = Nothing
        End Try
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
                Afiliados.Clear()
                'Recorrido secuencial por la colección de afiliados leídos
                For Each afiliadoDBF As Entidades.AfiliadoDBF In afiliadosDBF
                    'Actualiza los controles de progreso
                    contador += 1
                    lblMensajeProgreso.Text = "Agregando a colección registro " & contador.ToString.Trim & " / " & afiliadosDBF.Count.ToString.Trim
                    My.Application.DoEvents()
                    'Inicializa la cadena de mensaje
                    cadenaMsg = ""
                    If afiliadoDBF.Nomb.Trim.Length > 0 And (afiliadoDBF.cuil > 0 And afiliadoDBF.Docu > 0) Then
                        If afiliadoDBF.Cond.Trim.ToUpper.Substring(0, 1) = "S" Then
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
                    Dim formulario As New frmCondicionAfiliatoriaAlmacenar
                    Me.AddOwnedForm(formulario)
                    formulario._Afiliados = afiliados
                    formulario._CadenaConexionAnual = CadenaConexionAnual
                    formulario._Ano = nudAno.Value
                    formulario._Mes = nudMes.Value
                    formulario._AgregarAfiliado = chkAltaAfiliados.Checked
                    formulario.Show()
                    formulario.Focus()
                End If
            End If
        Else
            cadenaMsg = "No se existen archivos leídos para ser guardados."
            MessageBox.Show(cadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmCondicionAfiliatoriaImportacionDBF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

    Private Sub frmCondicionAfiliatoriaImportacionDBF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmCondicionAfiliatoriaImportacionDBF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Evalúa si se está ejecutando un proceso
        If Procesando = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAchivo_Click(sender As Object, e As EventArgs) Handles btnAchivo.Click
        Dim dialogo As New OpenFileDialog
        dialogo.Filter = "Tablas .dbf|*.dbf|Todos los archivos|*.*"
        If dialogo.ShowDialog = DialogResult.OK Then
            txtArchivo.Text = dialogo.FileName
            txtArchivo.SelectionStart = txtArchivo.Text.Length
        End If
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Call Proceso()
    End Sub

    Private Sub btnPausa_Click(sender As Object, e As EventArgs) Handles btnPausa.Click
        continuar = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Cierra el formulario
        Me.Close()
    End Sub

#End Region

End Class