'***********************************************************************************************
'*
'*  Clase: AfiliadosDBF
'*  Capa: Negocios
'*  Autor: Daniel Fernando Anderlini
'*  Fecha de creación: 14/02/2025
'*  Descripción: Clase utilizada para contener toda la lógica del sistema y sirve como interface
'*               con la capa de datos.
'*
'***********************************************************************************************
Public Class AfiliadosDBF

#Region "Métodos públicos"


    ''' <summary>
    ''' Función utilizada para consultar un todas los afiliados
    ''' </summary>
    ''' <param name="CadenaConexion">Obligatorio. Cadena de caracteres con la cadena de conexión a la base de datos.</param>
    ''' <param name="TipoBaseDatos">Obligatorio. Cadena de caracteres con el tipo de base de datos a utilizar.</param>
    ''' <returns>Colección de objetos de la clase "AfiliadoDBF".</returns>
    ''' <remarks></remarks>
    Public Function ConsultaTodos(ByVal CadenaConexion As String, ByVal TipoBaseDatos As String) As Entidades.AfiliadosDBF
        Dim Valor As New Entidades.AfiliadosDBF
        'Evalúa con que tipo de base de datos se esta trabajando
        Select Case TipoBaseDatos.ToUpper.Trim
            Case "SQL"

            Case "OLEDB"
                Dim CapaDatos As New CapaDatos.AfiliadosDBF
                Try
                    'Ejecuta acciones sobre la capa de datos
                    Valor = CapaDatos.ConsultaTodosOLEDB(CadenaConexion)
                Catch ex As Exception
                    'Genera el nuevo error
                    Throw New ArgumentException(ex.Message)
                Finally
                    'Libera el objeto utilizado 
                    CapaDatos = Nothing
                End Try
            Case "MYSQL"

            Case "SQLCE"

        End Select
        'Valor de retorno de la función
        Return Valor
    End Function


#End Region

End Class
