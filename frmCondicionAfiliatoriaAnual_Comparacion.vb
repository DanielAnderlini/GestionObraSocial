Imports System.IO
Imports System.IO.Stream
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmCondicionAfiliatoriaAnual_Comparacion

#Region "Propiedades públicas"

#End Region

#Region "Declaraciones"

    Dim anosMovimientos As New List(Of Int16)
    Dim anos As New SortedList
    Dim meses As New SortedList

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
                .SetToolTip(btnAgregar, "Agregar")
                .SetToolTip(btnQuitar, "Quitar")
                .SetToolTip(btnExportar, "Exportar")
                .SetToolTip(btnBuscar, "Buscar")
                .SetToolTip(btnAgregar, "Agregar")
                .SetToolTip(btnQuitar, "Eliminar")
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
    ''' Procedimiento utilizado para inicializar los controles ComboBox
    ''' </summary>
    Private Sub CargarComboBox()
        'Determinación del los valores máximos y mínimos de años
        anosMovimientos = AnosDisponibles()
        For Each ano As Int16 In anosMovimientos
            cbAno.Items.Add(ano)
        Next
        If cbAno.Items.Count > 0 Then
            cbAno.Text = cbAno.Items(0)
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para configurar el control ListView
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigurarListView()
        Dim ancho As Int16 = 60
        Try
            With lvConsulta
                'Definiciones generales del control
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True
                .MultiSelect = False
                .ShowItemToolTips = True
                'Inserta las nuevas columnas
                .Columns.Add("Año") '0
                .Columns.Add("01") '1
                .Columns.Add("02") '2
                .Columns.Add("03") '3
                .Columns.Add("04") '4
                .Columns.Add("05") '5
                .Columns.Add("06") '6
                .Columns.Add("07") '7
                .Columns.Add("08") '8
                .Columns.Add("09") '9
                .Columns.Add("10") '10
                .Columns.Add("11") '11
                .Columns.Add("12") '12
                .Columns.Add("Total") '13
                .Columns(0).TextAlign = HorizontalAlignment.Center
                .Columns(13).TextAlign = HorizontalAlignment.Right
                'Definición del tamaño de las columnas
                .Columns(0).Width = ancho
                For indice As Int16 = 1 To 12
                    .Columns(indice).Width = 50
                    .Columns(indice).TextAlign = HorizontalAlignment.Right
                    ancho += .Columns(indice).Width
                Next
                .Columns(13).Width = .Width - ancho - 10
            End With
        Catch ex As Exception
            'Presenta mensaje de error
            Dim CadenaMsg As String = ex.Message & vbCrLf & vbCrLf & "Método: ConfigurarListView"
            Throw New ArgumentException(CadenaMsg)
        End Try
    End Sub

    ''' <summary>
    ''' Función utilizada para determinar la cantidad de afiliados en condiciones por mes desde la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Function afiliadosCondicionesMes(ByVal ano As Int16, ByVal mes As Int16) As Int64
        Dim valor As Int64 = 0
        Dim CapaNeg As New CapaNegocios.CondicionesAfiliatorias
        Dim cadenaConexionAnual As String = DeterminarCadenaConexionMovimiento(ano)
        Try
            'Consulta a los datos de la base de datos:
            valor = CapaNeg.ConsultaMesCantidad(cadenaConexionAnual, TipoBaseDatos, mes)
        Catch ex As Exception
            'Presenta mensaje de error
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Libera el objeto utilizado para recuperar los datos
            CapaNeg = Nothing
        End Try
        'Valor de retorno de la fucnión
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
        'Evalúa la existencia de objetos en la colección
        If lbAnos.Items.Count > 0 Then
            'Inicializa la etiqueta de progreso
            lblMensajeProgreso.Text = ""
            lblMensajeProgreso.Visible = True
            'Carga los años
            anos.Clear()
            Dim afiliadosCondiciones As Int64 = 0
            Dim totalAnual As Int64 = 0
            For Each anoTexto As Int16 In lbAnos.Items
                'Actualiza la etiqueta de progreso
                lblMensajeProgreso.Text = "Procesando " & anoTexto.ToString.Trim
                My.Application.DoEvents()
                anos.Add(anoTexto, anoTexto.ToString.Trim)
                'Carga la lista de afiliados en condiciones por año
                meses.Clear()
                totalAnual = 0
                For mes As Int16 = 1 To 12
                    afiliadosCondiciones = afiliadosCondicionesMes(anoTexto, mes)
                    totalAnual += afiliadosCondiciones
                    meses.Add(mes, afiliadosCondiciones)
                Next
                Item = lvConsulta.Items.Add(anoTexto)
                Dim enumerador As IDictionaryEnumerator = meses.GetEnumerator
                While enumerador.MoveNext
                    Item.SubItems.Add(enumerador.Value)
                End While
                If (lvConsulta.Items.Count Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.LightBlue
                End If
                Item.SubItems.Add(totalAnual)
                'Inserción del comentario del ítem
                Item.ToolTipText = anoTexto
                'Asignación del Id. al que representa
                Item.Tag = anoTexto
            Next
        End If
        'Inicializa la etiqueta de progreso
        lblMensajeProgreso.Text = ""
        lblMensajeProgreso.Visible = False
        'Finaliza la actualización del control ListView
        lvConsulta.EndUpdate()
        'Actualiza los controles relacionados a los contadores
        tpConsulta.Text = "Consulta (" & lvConsulta.Items.Count.ToString.Trim & ")"
        'Evalúa si el control tiene ítems, para seleccionar el primero
        If lvConsulta.Items.Count > 0 Then
            lvConsulta.Items(0).Selected = True
            lvConsulta.Select()
            lvConsulta.EnsureVisible(0)
        End If
    End Sub

    ''' <summary>
    ''' Procedimeinto utilizado para cargar el gráfico
    ''' </summary>
    Private Sub CargaGrafico()
        With chGrafico
            .Series.Clear()
            chGrafico.Series.Add("IncomeMode")
            With chGrafico.Series(0)
                .Name = "Amount"
                .Font = New Font("Arial", 8, FontStyle.Italic)
                .BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
                .Color = Color.Magenta
                .BackSecondaryColor = Color.Purple
                .IsValueShownAsLabel = True
                .LabelBackColor = Color.Transparent
                .LabelForeColor = Color.Purple
                .CustomProperties = "DrawingStyle = Cylinder ,PixelPointWidth = 26"
            End With
            With chGrafico.Series(0)
                .Font = New Font("Arial", 8, FontStyle.Italic)
                .BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
                .Color = Color.Aqua
                .BackSecondaryColor = Color.Blue
                .IsValueShownAsLabel = True
                .SmartLabelStyle.CalloutStyle = DataVisualization.Charting.LabelCalloutStyle.Box
                .LabelBackColor = Color.Transparent
                .LabelForeColor = Color.Blue
                .CustomProperties = "DrawingStyle = Cylinder ,PixelPointWidth = 26"
            End With
            With chGrafico.ChartAreas(0)
                .AxisX.Interval = 1
                .AxisX.LabelStyle.Angle = -90
                .AxisX.Title = "IncomeMode"
                .AxisY.Title = "Units"
            End With
        End With
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para graficar
    ''' </summary>
    Private Sub Graficar()
        'Evalúa si hay ítems en el control ListView de estadísticas
        If lvConsulta.Items.Count > 0 Then
            With chGrafico
                .BeginInit()
                .Series.Clear()
                For Each Item As ListViewItem In lvConsulta.Items
                    .Series.Add(Item.SubItems(0).Text)
                    .Series(Item.SubItems(0).Text).ChartType = DataVisualization.Charting.SeriesChartType.Line
                    '.Series(Item.SubItems(0).Text).Color = Color.Blue
                    .Series(Item.SubItems(0).Text).IsValueShownAsLabel = chkVerValores.Checked
                    '.Series(Item.SubItems(0).Text).LabelForeColor = .Series(Item.SubItems(0).Text).Color
                    For Each columna As ColumnHeader In lvConsulta.Columns
                        If columna.Index > 0 And columna.Index < 13 Then
                            .Series(Item.SubItems(0).Text).Points.AddXY(columna.Text, Item.SubItems(columna.Index).Text)
                        End If
                    Next
                Next
                .EndInit()
            End With
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento utilizado para exportar los datos
    ''' </summary>
    Private Sub ExportarCSV()
        Dim Dialogo As New SaveFileDialog
        Dim NombreArchivo As String = "Padrón de afiliados"
        Dim CaracterSeparador As Char = ";"
        Dim CadenaMsg As String = ""
        Dim TotalGrupo As Decimal = 0
        Dim Total As Decimal = 0
        Try
            With Dialogo
                If lvConsulta.Items.Count > 0 Then
                    NombreArchivo &= " Items "
                    For Each Item As ListViewItem In lvConsulta.Items
                        NombreArchivo &= "-" & Item.SubItems(0).Text.Trim
                    Next
                End If
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
                    MessageBox.Show(CadenaMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub frmCondicionAfiliatoriaAnual_Comparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Inicializar()
    End Sub

	Private Sub frmCondicionAfiliatoriaAnual_Comparacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	End Sub

	Private Sub frmCondicionAfiliatoriaAnual_Comparacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	End Sub

	Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cbAno.Text.Trim.Length > 0 Then
            Dim existe As Boolean = False
            For indice As Int16 = 0 To lbAnos.Items.Count - 1
                If CInt(cbAno.Text) = lbAnos.Items(indice) Then
                    existe = True
                    Exit For
                End If
            Next
            If existe = False Then
                lbAnos.Items.Add(cbAno.Text)
            End If
        End If
    End Sub

	Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If lbAnos.SelectedItems.Count > 0 Then
            lbAnos.Items.Remove(lbAnos.SelectedItem)
        End If
    End Sub

	Private Sub tcConsultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcConsultas.SelectedIndexChanged
        If tcConsultas.SelectedTab Is tpConsulta Then
            Call CargarListView()
        End If
        If tcConsultas.SelectedTab Is tpGrafico Then
            Call Graficar()
        End If
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
        Call ExportarCSV()
        btnExportar.Enabled = True
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Call Graficar()
    End Sub

    Private Sub btnPDFGrafico_Click(sender As Object, e As EventArgs) Handles btnPDFGrafico.Click

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Cierra el formulario
        Me.Close()
    End Sub

#End Region

End Class