Imports CapaNegocios

Public Class frmCondicionAfiliatoriaAnual_Afiliado

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim Afiliado As New Entidades.Afiliado
    Dim AfiliadoTitular As New Entidades.Afiliado
    Dim GrupoAfiliar As New Entidades.Afiliados
    Dim CondicionesAfiliatorias As New Entidades.CondicionesAfiliatorias

    Dim anosMovimientos As New List(Of Int16)
    Dim anoMinimo As Int16 = 0
    Dim anoMaximo As Int16 = 0

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
            'Configura el control ListView
            Call ConfigurarListView()
            'Actualiza la barra de estado
            Call ActualizaBarraEstado()
            'Carga las sugerencias
            Call CargarSugerencias()
            'Determinación del los valores máximos y mínimos de años
            anosMovimientos = AnosDisponibles()
            If anosMovimientos.Count > 0 Then
                If anosMovimientos.Count = 1 Then
                    nudAno.Minimum = anosMovimientos(0)
                    nudAno.Maximum = anosMovimientos(0)
                    nudAno.Value = anosMovimientos(0)
                Else
                    Dim primero As Boolean = True
                    For Each ano As Int16 In anosMovimientos
                        If primero = True Then
                            primero = False
                            anoMinimo = ano
                            anoMaximo = ano
                        Else
                            If ano < anoMinimo Then
                                anoMinimo = ano
                            End If
                            If ano > anoMaximo Then
                                anoMaximo = ano
                            End If
                        End If
                    Next
                    nudAno.Minimum = anoMinimo
                    nudAno.Maximum = anoMaximo
                End If
            Else
                nudAno.Minimum = Now.Year
                nudAno.Maximum = Now.Year
            End If
            nudAno.Value = nudAno.Maximum
            If nudAno.Minimum = nudAno.Maximum Then
                nudAno.Enabled = False
            Else
                nudAno.Enabled = True
            End If
            'Inicializa los controles relacioado al afiliado
            Call InicializarControlesDatos()
            'Ubica el foco
            txtDNI.Focus()
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
                .SetToolTip(btnBuscar, "Buscar")
                .SetToolTip(btnTitular, "Datos del titular")
                .SetToolTip(btnGrupoFamiliar, "GrupoFamiliar")
                .SetToolTip(btnFiltrar, "Filtrar")
                .SetToolTip(btnCerrar, "Cerrar")
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
            Throw New ArgumentException(CadenaMsg)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para configurar el control ListView
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigurarListView()
        With lvCondicionAfiliatoria
            'Definiciones generales del control
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .MultiSelect = False
            .ShowItemToolTips = True
            'Inserta las nuevas columnas
            .Columns.Add("Mes")
            .Columns.Add("Tipo de condición")
            'Alineación de los textos
            .Columns(0).TextAlign = HorizontalAlignment.Left
            .Columns(1).TextAlign = HorizontalAlignment.Left
            'Definición del tamaño de las columnas
            .Columns(0).Width = 80
            .Columns(1).Width = .Width - .Columns(0).Width - 5
        End With
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar la colección desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarAfiliado(ByVal DNI As Int64)
        Dim CapaNeg As New CapaNegocios.Afiliados
        Dim afiliados As New Entidades.Afiliados
        Try
            'Inicializa los objetos de la clase "Afiliado"
            Afiliado = New Entidades.Afiliado
            AfiliadoTitular = New Entidades.Afiliado
            GrupoAfiliar = New Entidades.Afiliados
            'Inicializa la colección
            If afiliados.Count > 0 Then afiliados.Clear()
            'Consulta a los datos de la base de datos:
            afiliados = CapaNeg.ConsultaDNI(CadenaConexion, TipoBaseDatos, DNI)
            'Evalúa los resultados de la consulta
            If afiliados.Count > 0 Then
                Afiliado = afiliados(0)
                If Afiliado.Relacion <> "TITULAR" Then
                    'Busca el afiliado titular
                    afiliados = CapaNeg.ConsultaCUIL(CadenaConexion, TipoBaseDatos, Afiliado.CUILT_Titular)
                    If afiliados.Count > 0 Then
                        AfiliadoTitular = afiliados(0)
                    End If
                Else
                    'Busca el grupo familiar
                    GrupoAfiliar = CapaNeg.ConsultaGrupoFamiliar(CadenaConexion, TipoBaseDatos, Afiliado.CUILT_Titular)
                End If
            End If
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
            afiliados = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar la colección desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCondicionesAfiliatorias()
        Dim CapaNeg As New CapaNegocios.CondicionesAfiliatorias
        Dim cadenaConexionAnual As String = DeterminarCadenaConexionMovimiento(nudAno.Value)
        Try
            'Inicializa la colección
            If CondicionesAfiliatorias.Count > 0 Then CondicionesAfiliatorias.Clear()

            'Consulta a los datos de la base de datos:
            CondicionesAfiliatorias = CapaNeg.ConsultaDNI(cadenaConexionAnual, TipoBaseDatos, Afiliado.DNI)
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar el control ListView lvCondicionAfiliatoria
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarListView()
        Dim Item As ListViewItem
        Dim ContadorDeshabilitados As Int16 = 0
        'Inicia la actualización del control
        lvCondicionAfiliatoria.BeginUpdate()
        'Inicializa los ítems del control
        If lvCondicionAfiliatoria.Items.Count > 0 Then lvCondicionAfiliatoria.Items.Clear()
        'Carga la colección de condiciones afiliatorias
        Call CargarCondicionesAfiliatorias()
        'Evalúa la existencia de objetos en la colección
        If CondicionesAfiliatorias.Count > 0 Then
            'Recorrido secuencial por la colección
            For Each condicion As Entidades.CondicionAfiliatoria In CondicionesAfiliatorias
                Item = lvCondicionAfiliatoria.Items.Add(condicion.Mes)
                Item.SubItems.Add(condicion.TipoCondicion)
                'Evalúa la cantidad de ítems del control para determinar el color de fondo
                If (lvCondicionAfiliatoria.Items.Count Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.LightBlue
                End If
                'Inserción del comentario del ítem
                Item.ToolTipText = Item.SubItems(0).Text & "->" & Item.SubItems(1).Text
                'Asignación del Id. al que representa
                Item.Tag = condicion.Id
            Next
        End If
        'Finaliza la actualización del control ListView
        lvCondicionAfiliatoria.EndUpdate()
        'Actualiza los controles relacionados a los contadores
        gbCondicionAfiliatoria.Text = "Condición afiliatoria (" & lvCondicionAfiliatoria.Items.Count.ToString.Trim & ")"
        'Evalúa si el control tiene ítems, para seleccionar el primero
        If lvCondicionAfiliatoria.Items.Count > 0 Then
            lvCondicionAfiliatoria.Items(0).Selected = True
            lvCondicionAfiliatoria.Select()
            lvCondicionAfiliatoria.EnsureVisible(0)
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para inicializar los controles relacionados a los datos del afiliado
    ''' </summary>
    Private Sub InicializarControlesDatos()
        lblCUIL.Text = ""
        lblNombreCompleto.Text = ""
        lblGenero.Text = ""
        lblFechaNacimiento.Text = ""
        lblEdad.Text = ""
        lblNumeroBocaExpendio.Text = ""
        lblUATRE.Text = ""
        lblBocaExpendio.Text = ""
        lblRelacion.Text = ""
        btnTitular.Enabled = False
        btnGrupoFamiliar.Enabled = False
        gbCondicionAfiliatoria.Text = "Condición afiliatoria (0)"
        lvCondicionAfiliatoria.Items.Clear()
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para buscar los afiliados y sus datos
    ''' </summary>
    Private Sub BuscarAfiliado()
        'Inicializa los controles relacionados al afiliado
        Call InicializarControlesDatos()
        'Evalúa si se definieron los datos de búsqueda
        If txtDNI.Text.Trim.Length > 0 Then
            If CInt(txtDNI.Text) > 9 Then
                'Busca los afiliados (el afiliato y su titular)
                Call CargarAfiliado(txtDNI.Text)
                'Actualiza los datos del afiliado
                If Afiliado.Id > 0 Then
                    With Afiliado
                        lblCUIL.Text = .CUIL
                        lblNombreCompleto.Text = .NombreCompleto
                        lblGenero.Text = .Genero
                        lblFechaNacimiento.Text = .FechaNacimiento.ToShortDateString
                        lblEdad.Text = .Edad
                        lblNumeroBocaExpendio.Text = .BocaExpendio
                        If .UATRE = True Then
                            lblUATRE.Text = "Si"
                        Else
                            lblUATRE.Text = "No"
                        End If
                        lblBocaExpendio.Text = ""
                        lblRelacion.Text = .Relacion
                    End With
                End If
                If AfiliadoTitular.Id > 0 Then
                    btnTitular.Enabled = True
                Else
                    btnTitular.Enabled = False
                End If
                If GrupoAfiliar.Count > 0 Then
                    btnGrupoFamiliar.Enabled = True
                Else
                    btnGrupoFamiliar.Enabled = False
                End If
                'Carga el control ListView
                Call CargarListView()
            End If
        End If
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmCondicionAfiliatoriaAnual_Afiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

	Private Sub frmCondicionAfiliatoriaAnual_Afiliado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmCondicionAfiliatoriaAnual_Afiliado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

    Private Sub txtDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNI.KeyDown
        'Evalúa la tecla presionada
        If e.KeyCode = Keys.Enter Then
            Call BuscarAfiliado()
        End If
    End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call BuscarAfiliado()
    End Sub

	Private Sub btnTitular_Click(sender As Object, e As EventArgs) Handles btnTitular.Click
        If AfiliadoTitular.Id > 0 Then
            With AfiliadoTitular
                cadenaMsg = .NombreCompleto
                cadenaMsg &= vbCrLf
                cadenaMsg &= vbCrLf & "DNI: " & .DNI.ToString.Trim & vbTab & "CUIL: " & .CUIL.ToString.Trim
                cadenaMsg &= vbCrLf & "Genero: " & .Genero.Trim
                cadenaMsg &= vbCrLf & "Fecha de naciemiento: " & .FechaNacimiento.ToShortDateString.Trim & vbTab & "Edad: " & .Edad.ToString.Trim
                cadenaMsg &= vbCrLf & "N° boca de expendio: " & .BocaExpendio.ToString.Trim & vbTab & "UATRE: " & .UATRE.ToString.Trim
                cadenaMsg &= vbCrLf
                cadenaMsg &= vbCrLf & "(*) Se almacenó en el portapapeles el DNI del titular"
                MessageBox.Show(cadenaMsg, "Datos del afiliado titular", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Computer.Clipboard.SetText(.DNI)
            End With
        End If
    End Sub

    Private Sub btnGrupoFamiliar_Click(sender As Object, e As EventArgs) Handles btnGrupoFamiliar.Click
        If GrupoAfiliar.Count > 0 Then
            cadenaMsg = ""
            For Each afiliadoFamiliar As Entidades.Afiliado In GrupoAfiliar
                If afiliadoFamiliar.DNI <> Afiliado.DNI Then
                    With afiliadoFamiliar
                        cadenaMsg &= vbCrLf & .DNI.ToString.Trim
                        cadenaMsg &= " " & .NombreCompleto.Trim
                        'cadenaMsg &= " (" & .Relacion.Trim & ")"
                        cadenaMsg &= " " & .Edad.ToString.Trim & " años"
                    End With
                End If
            Next
            MessageBox.Show(cadenaMsg, "Grupo familiar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Call CargarListView()
    End Sub

    Private Sub nudAno_ValueChanged(sender As Object, e As EventArgs) Handles nudAno.ValueChanged

	End Sub

	Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
		'Cierra el formulario
		Me.Close()
	End Sub


#End Region

End Class