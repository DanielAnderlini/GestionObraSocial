Imports System.IO
Imports System.IO.Stream
Public Class frmProveedoresConsultas

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim proveedores As New Entidades.Proveedores

    Dim Entidades As New List(Of String)
    Dim Categorias As New Entidades.Categorias
    Dim Subcategorias As New Entidades.Categorias

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
            'Carga los controles ComboBox
            Call ControlComboBox()
            'Configurar control ListView
            Call ConfigurarListView()
            'Ubica el foco
            btnFiltrar.Focus()
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
                .SetToolTip(btnFiltrar, "Filtrar")
                .SetToolTip(btnBuscar, "Buscar")
                .SetToolTip(btnExportar, "Exportar")
                .SetToolTip(btnCerrar, "Cerrar")
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: CargarSugerencias"
            Throw New ArgumentException(CadenaMsg)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar la lista de las distintas entidades desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEntidadesCategorias()
        Dim CapaNeg As New CapaNegocios.Categorias
        Try
            'Inicializa la colección
            If Categorias.Count > 0 Then Categorias.Clear()
            'Consulta a los datos de la base de datos:
            Categorias = CapaNeg.ConsultaEntidad(CadenaConexion, TipoBaseDatos, "GRUPO")
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar las categorías desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEntidadesSubCategorias()
        Dim CapaNeg As New CapaNegocios.Categorias
        Try
            'Inicializa la colección
            If Subcategorias.Count > 0 Then Subcategorias.Clear()
            'Consulta a los datos de la base de datos:
            Subcategorias = CapaNeg.ConsultaEntidad(CadenaConexion, TipoBaseDatos, "RAMO")
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Función utilizada para buscar un categorias en la colección Coleccion, según su código
    ''' </summary>
    ''' <param name="coleccion">Obligatorio. Colección a la que pertenece la categoria a buscar.</param>
    ''' <param name="codigo">Obligatorio. Código de la categoría a buiscar.</param>
    ''' <returns>Objeto encontrado de la clase "categoria".</returns>
    ''' <remarks></remarks>
    Private Function BuscarCategoriaCodigo(ByVal coleccion As Entidades.Categorias, ByVal codigo As String) As Entidades.Categoria
        Dim Valor As New Entidades.Categoria
        'Evalúa la existencia de categoriass en la colección Coleccion
        If coleccion.Count > 0 Then
            'Recorrido secuencial por la colección Coleccion
            For Each Obj As Entidades.Categoria In coleccion
                'Evalúa si existe coincidencia en el identificador
                If Obj.Codigo = codigo Then
                    'Define el valor de salida de la función
                    Valor = Obj
                    'Sale del bucle
                    Exit For
                End If
            Next
        End If
        'Valor de retorno de la función
        Return Valor
    End Function

    ''' <summary>
    ''' Función utilizada para buscar un categorias en la colección Coleccion, según su identificador
    ''' </summary>
    ''' <param name="coleccion">Obligatorio. Colección a la que pertenece la categoria a buscar.</param>
    ''' <param name="id">Obligatorio. Número identificador de la categoría a buiscar.</param>
    ''' <returns>Objeto encontrado de la clase "categoria".</returns>
    ''' <remarks></remarks>
    Private Function BuscarCategoriaId(ByVal coleccion As Entidades.Categorias, ByVal id As Int64) As Entidades.Categoria
        Dim Valor As New Entidades.Categoria
        'Evalúa la existencia de categoriass en la colección Coleccion
        If coleccion.Count > 0 Then
            'Recorrido secuencial por la colección Coleccion
            For Each Obj As Entidades.Categoria In coleccion
                'Evalúa si existe coincidencia en el identificador
                If Obj.Id = id Then
                    'Define el valor de salida de la función
                    Valor = Obj
                    'Sale del bucle
                    Exit For
                End If
            Next
        End If
        'Valor de retorno de la función
        Return Valor
    End Function
    ''' <summary>
    ''' Carga los controles ComboBox
    ''' </summary>
    Private Sub ControlComboBox()
        'Carga la lista de distintas entidades (categorías)
        Call CargarEntidadesCategorias()
        Call CargarEntidadesSubCategorias()
        'Carga el control ComboBox
        cbCategoria.Items.Clear()
        cbSubcategoria.Items.Clear()
        cbDiasVencimientos.Items.Clear()
        cbCategoria.Items.Add("TODOS")
        cbSubcategoria.Items.Add("TODOS")
        cbDiasVencimientos.Items.Add("TODOS")
        For Each categoria As Entidades.Categoria In Categorias
            cbCategoria.Items.Add(categoria.Codigo.Trim & "|" & categoria.Descripcion)
        Next
        For Each subCategoria As Entidades.Categoria In Subcategorias
            cbSubcategoria.Items.Add(subCategoria.Codigo.Trim & "|" & subCategoria.Descripcion)
        Next
        cbDiasVencimientos.Items.Add("60")
        cbDiasVencimientos.Items.Add("30")
        cbDiasVencimientos.Items.Add("15")
        cbDiasVencimientos.Items.Add("7")
        cbCategoria.Text = cbCategoria.Items(0)
        cbSubcategoria.Text = cbSubcategoria.Items(0)
        cbDiasVencimientos.Text = cbDiasVencimientos.Items(0)
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
            .Columns.Add("N° SAP") '0
            .Columns.Add("CUIT") '1
            .Columns.Add("Razón social") '2
            .Columns.Add("Teléfono") '3
            .Columns.Add("E-mail") '4
            .Columns.Add("Domicilio") '5
            .Columns.Add("# cuenta") '6
            .Columns.Add("CBU") '7
            .Columns.Add("Grupo") '8
            .Columns.Add("Ramo") '9
            .Columns.Add("Venc.") '10
            'Alineación de los textos
            .Columns(0).TextAlign = HorizontalAlignment.Left
            .Columns(1).TextAlign = HorizontalAlignment.Left
            .Columns(2).TextAlign = HorizontalAlignment.Left
            .Columns(3).TextAlign = HorizontalAlignment.Left
            .Columns(4).TextAlign = HorizontalAlignment.Left
            .Columns(5).TextAlign = HorizontalAlignment.Left
            .Columns(6).TextAlign = HorizontalAlignment.Left
            .Columns(7).TextAlign = HorizontalAlignment.Left
            .Columns(8).TextAlign = HorizontalAlignment.Left
            .Columns(9).TextAlign = HorizontalAlignment.Left
            .Columns(10).TextAlign = HorizontalAlignment.Left
            'Definición del tamaño de las columnas
            .Columns(0).Width = 50
            .Columns(1).Width = 50
            .Columns(2).Width = 80
            .Columns(3).Width = 50
            .Columns(4).Width = 50
            .Columns(6).Width = 50
            .Columns(7).Width = 50
            .Columns(8).Width = 50
            .Columns(9).Width = 50
            .Columns(10).Width = 50
            Dim ancho As Int16 = 0
            For Each columna As ColumnHeader In lvConsulta.Columns
                If columna.Index <> 5 Then
                    ancho += columna.Width
                End If
            Next
            .Columns(5).Width = .Width - ancho - 5
        End With
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para cargar la colección "Categorias" desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarProveedores()
        Dim CapaNeg As New CapaNegocios.Proveedores
        Try
            'Inicializa la colección
            If proveedores.Count > 0 Then proveedores.Clear()
            'Consulta a los datos de la base de datos:
            If cbCategoria.Text.Trim = "TODOS" And cbSubcategoria.Text.Trim = "TODOS" Then
                proveedores = CapaNeg.ConsultaTodos(CadenaConexion, TipoBaseDatos)
            Else
                Dim categoria As New Entidades.Categoria
                Dim subCategoria As New Entidades.Categoria
                If cbCategoria.Text.Trim.ToUpper <> "TODOS" Then
                    Dim codicategoria As String = cbCategoria.Text.Trim.ToUpper.Substring(0, cbCategoria.Text.Trim.ToUpper.IndexOf("|"))
                    If codicategoria.Trim.Length > 0 Then
                        categoria = BuscarCategoriaCodigo(Categorias, codicategoria)
                    End If
                End If
                If cbSubcategoria.Text.Trim.ToUpper <> "TODOS" Then
                    Dim codisubcategoria As String = cbSubcategoria.Text.Trim.ToUpper.Substring(0, cbSubcategoria.Text.Trim.ToUpper.IndexOf("|"))
                    If codisubcategoria.Trim.Length > 0 Then
                        subCategoria = BuscarCategoriaCodigo(Categorias, codisubcategoria)
                    End If
                End If
                If categoria.Id > 0 Then
                    If subCategoria.Id > 0 Then
                        proveedores = CapaNeg.ConsultaCategoriaSubcategoria(CadenaConexion, TipoBaseDatos, categoria.Id, subCategoria.Id)
                    Else
                        proveedores = CapaNeg.ConsultaCategoria(CadenaConexion, TipoBaseDatos, categoria.Id)
                    End If
                Else
                    If subCategoria.Id > 0 Then
                        proveedores = CapaNeg.ConsultaCategoria(CadenaConexion, TipoBaseDatos, subCategoria.Id)
                    End If
                End If
            End If
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Función utilizada para filtrar los datos de un proveedor
    ''' </summary>
    ''' <param name="proveedor">Obligatorio. Objeto de la clase "" que se quiere analizar.</param>
    ''' <returns>Valor booleano que indica si el objeto pasa los filtros</returns>
    Private Function Filtros(ByVal proveedor As Entidades.Proveedor) As Boolean
        Dim valor As Boolean = True
        'Evalúa si pasa el filtro de días de vencimientos
        If valor = True Then
            If cbDiasVencimientos.Text.Trim.ToUpper <> "TODOS" Then
                If proveedor.DiasVencimiento <> cbDiasVencimientos.Text Then
                    valor = False
                End If
            End If
        End If
        'Valor de retorno de la función
        Return valor
    End Function

    ''' <summary>
    ''' Procedimiento utilizado para cargar el control ListView lvConsulta
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarListView()
        Dim Item As ListViewItem
        'Inicia la actualización del control
        lvConsulta.BeginUpdate()
        'Inicializa los ítems del control
        If lvConsulta.Items.Count > 0 Then lvConsulta.Items.Clear()
        'Carga la colección de categorías
        Call CargarProveedores()
        'Evalúa la existencia de objetos en la colección
        If Categorias.Count > 0 Then
            'Recorrido secuencial por la colección
            For Each Objeto As Entidades.Proveedor In proveedores
                'Evalúa si pasa los filtros
                If Filtros(Objeto) = True Then
                    Item = lvConsulta.Items.Add(Objeto.NumeroSAP)
                    Item.SubItems.Add(Objeto.CUIT)
                    Item.SubItems.Add(Objeto.RazonSocial)
                    Item.SubItems.Add(Objeto.Telefono)
                    Item.SubItems.Add(Objeto.Email)
                    Item.SubItems.Add(Objeto.Domicilio)
                    Item.SubItems.Add(Objeto.NumeroCuenta)
                    Item.SubItems.Add(Objeto.CBU)
                    If Objeto.Id_Categoria > 0 Then
                        Dim categoria As Entidades.Categoria = BuscarCategoriaId(Categorias, Objeto.Id_Categoria)
                        If categoria.Id > 0 Then
                            Item.SubItems.Add(categoria.Descripcion)
                        Else
                            Item.SubItems.Add("")
                        End If
                    Else
                        Item.SubItems.Add("")
                    End If
                    If Objeto.Id_Subcategoria > 0 Then
                        Dim subCategoria As Entidades.Categoria = BuscarCategoriaId(Subcategorias, Objeto.Id_Subcategoria)
                        If subCategoria.Id > 0 Then
                            Item.SubItems.Add(subCategoria.Descripcion)
                        Else
                            Item.SubItems.Add("")
                        End If
                    Else
                        Item.SubItems.Add("")
                    End If
                    Item.SubItems.Add(Objeto.DiasVencimiento)
                    'Evalúa si está habilitado el objeto
                    If Objeto.Habilitado = False Then
                        Item.BackColor = Color.Gray
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
                End If
            Next
        End If
        'Finaliza la actualización del control ListView
        lvConsulta.EndUpdate()
        'Actualiza los controles relacionados a los contadores
        lblProveedores.Text = "Proveedores = " & lvConsulta.Items.Count.ToString.Trim
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
        Dim NombreArchivo As String = "Proveedores (" & Now.Year.ToString.Trim & "-" & Now.Month.ToString.Trim.PadLeft(2).Replace(" ", "") & "-" & Now.Day.ToString.Trim.PadLeft(2).Replace(" ", "")
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

    Private Sub frmProveedoresConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

    Private Sub frmProveedoresConsultas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmProveedoresConsultas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Call CargarListView()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub lvConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvConsulta.SelectedIndexChanged

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        btnExportar.Enabled = False

        btnExportar.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Cierra el formulario
        Me.Close()
    End Sub

#End Region

End Class