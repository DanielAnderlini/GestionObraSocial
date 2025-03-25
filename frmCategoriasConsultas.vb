Imports System.IO
Imports System.IO.Stream
Imports CapaNegocios
Public Class frmCategoriasConsultas

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim categorias As New Entidades.Categorias
    Dim entidades As New List(Of String)

    Dim Sugerencias As New ToolTip

#End Region

#Region "Métodos públicos"

#End Region

#Region "Métodos privados"

    ''' <summary>
    ''' Procedimiento utilizado para inicializar el fomulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Inicializar()
        'Actualiza la barra de estado
        Call ActualizaBarraEstado()
        'Carga las sugerencias
        Call CargarSugerencias()
        'Carga control ComboBox
        Call CargarComboBox()
        'Configura controles ListView
        Call ConfigurarListView()
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar las sugerencia de los controles
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarSugerencias()
        Try
            With Sugerencias
                'Habilitación de los controles de tareas generales
                .SetToolTip(btnFiltrar, "Filtrar")
                .SetToolTip(btnExportar, "Exportar")
                .SetToolTip(btnBuscar, "Buscar")
                '.SetToolTip(btnAyuda, "Ayuda")
                .SetToolTip(btnCerrar, "Cerrar")
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
            Throw New ArgumentException(CadenaMsg)
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
    ''' Procedimiento utilizado para cargar la lista de las distintas entidades desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEntidades()
        Dim CapaNeg As New CapaNegocios.Categorias
        Try
            'Inicializa la colección
            If entidades.Count > 0 Then entidades.Clear()
            'Consulta a los datos de la base de datos:
            entidades = CapaNeg.ConsultaEntidades(CadenaConexion, TipoBaseDatos)
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Carga los controles ComboBox
    ''' </summary>
    Private Sub CargarComboBox()
        'Carga la lista de distintas entidades
        Call CargarEntidades()
        'Carga el control ComboBox
        With cbEntidad
            .Items.Clear()
            For Each entidad As String In entidades
                .Items.Add(entidad)
            Next
            If .Items.Count > 0 Then
                .Text = .Items(0)
            End If
        End With
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para configurar el control ListView
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigurarListView()
        With lvConsulta
            'Definiciones generales del control
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .MultiSelect = False
            .ShowItemToolTips = True
            'Inserta las nuevas columnas
            .Columns.Add("Código")
            .Columns.Add("Descripción")
            .Columns.Add("Hab.")
            'Alineación de los textos
            .Columns(0).TextAlign = HorizontalAlignment.Left
            .Columns(1).TextAlign = HorizontalAlignment.Left
            .Columns(2).TextAlign = HorizontalAlignment.Center
            'Definición del tamaño de las columnas
            .Columns(0).Width = 50
            .Columns(2).Width = 50
            .Columns(1).Width = .Width - .Columns(0).Width - .Columns(2).Width - 5
        End With
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar la colección "Categorias" desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCategorias()
        Dim CapaNeg As New CapaNegocios.Categorias
        Try
            'Inicializa la colección
            If categorias.Count > 0 Then categorias.Clear()
            'Consulta a los datos de la base de datos:
            categorias = CapaNeg.ConsultaEntidad(CadenaConexion, TipoBaseDatos, cbEntidad.Text.Trim.ToUpper)
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar el control ListView lvConsulta
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarListView()
        Dim Item As ListViewItem
        Dim ContadorDeshabilitados As Int16 = 0
        'Inicia la actualización del control
        lvConsulta.BeginUpdate()
        'Inicializa los ítems del control
        If lvConsulta.Items.Count > 0 Then lvConsulta.Items.Clear()
        'Carga la colección de categorías
        Call CargarCategorias()
        'Evalúa la existencia de objetos en la colección
        If categorias.Count > 0 Then
            'Recorrido secuencial por la colección
            For Each Objeto As Entidades.Categoria In categorias
                Item = lvConsulta.Items.Add(Objeto.Codigo)
                Item.SubItems.Add(Objeto.Descripcion)
                'Evalúa si está habilitado el objeto
                If Objeto.Habilitado = False Then
                    Item.BackColor = Color.Gray
                    'Incrementa el contador de objetos deshabilitados
                    ContadorDeshabilitados += 1
                Else
                    'Evalúa la cantidad de ítems del control para determinar el color de fondo
                    If (lvConsulta.Items.Count Mod 2) = 0 Then
                        Item.BackColor = Color.White
                    Else
                        Item.BackColor = Color.LightBlue
                    End If
                End If
                'Inserción del comentario del ítem
                Item.ToolTipText = "(" & Item.SubItems(0).Text & ") " & Item.SubItems(1).Text
                'Asignación del Id. al que representa
                Item.Tag = Objeto.Id
            Next
        End If
        'Finaliza la actualización del control ListView
        lvConsulta.EndUpdate()
        'Actualiza los controles relacionados a los contadores
        lblItems.Text = "Items = " & lvConsulta.Items.Count.ToString.Trim
        'Evalúa si el control tiene ítems, para seleccionar el primero
        If lvConsulta.Items.Count > 0 Then
            lvConsulta.Items(0).Selected = True
            lvConsulta.Select()
            lvConsulta.EnsureVisible(0)
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para exportar los datos
    ''' </summary>
    Private Sub ExportarCSV()
        Dim Dialogo As New SaveFileDialog
        Dim NombreArchivo As String = cbEntidad.Text.Trim & " (" & Now.Year.ToString.Trim & "-" & Now.Month.ToString.Trim.PadLeft(2).Replace(" ", "") & "-" & Now.Day.ToString.Trim.PadLeft(2).Replace(" ", "")
        Dim CaracterSeparador As Char = ";"
        Dim CadenaMsg As String = ""
        Dim TotalGrupo As Decimal = 0
        Dim Total As Decimal = 0
        Try
            With Dialogo
                .FileName = NombreArchivo
                .Filter = "CSV Delimitado por comas|*.csv"
                If Dialogo.ShowDialog = DialogResult.OK Then
                    Dim RutaArchivo As String = .FileName
                    Dim Archivo As New StreamWriter(RutaArchivo, False, System.Text.Encoding.UTF8)
                    Dim Linea As String = ""
                    'Evalúa la existencia de grupos
                    If lvConsulta.Items.Count > 0 Then
                        'Inicializa la variable totalizadora
                        Total = 0
                        'Inserta las cabeceras de las columnas
                        Linea = ""
                        'Recorrido secuencial por las columnas del control ListView
                        For Each Columna As ColumnHeader In lvConsulta.Columns
                            Linea &= Columna.Text.Trim & CaracterSeparador
                        Next
                        'Inserta la línea en el archivo
                        Archivo.WriteLine(Linea)
                        'Recorrido secuencial por el control ListView
                        For Each Item As ListViewItem In lvConsulta.Items
                            Linea = ""
                            'Recorrido secuencial por los subítems
                            For Each Columna As ColumnHeader In lvConsulta.Columns
                                Linea &= Item.SubItems(Columna.Index).Text & CaracterSeparador
                            Next
                            Archivo.WriteLine(Linea)
                        Next
                    End If
                    'Cierra el archivo
                    Archivo.Close()
                    'Presenta mensaje de acción satisfactoria
                    CadenaMsg = "La exportación de datos, se realizó correctamente en el archivo: " & Chr(34) & Dialogo.FileName & Chr(34) & "."
                    CadenaMsg &= vbCrLf & "¿Desea abrir el archivo?"
                    If MessageBox.Show(CadenaMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Process.Start(RutaArchivo)
                    End If
                End If
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            CadenaMsg = "Se generó un error al exportar los datos." & vbCrLf & ex.Message
            MessageBox.Show(CadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            Dialogo = Nothing
        End Try
    End Sub

#End Region

#Region "Métodos relacionados a los controles"

    Private Sub frmCategoriasConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

    Private Sub frmCategoriasConsultas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmCategoriasConsultas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

	Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Call CargarListView()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown

	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

	End Sub

	Private Sub lvConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvConsulta.SelectedIndexChanged

	End Sub

	Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Call ExportarCSV()
    End Sub

	Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
		'Cierra el formulario
		Me.Close()
	End Sub

#End Region

End Class