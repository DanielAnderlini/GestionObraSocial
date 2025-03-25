' *******************************************************************
' *
' * Clase: DatosGeneral
' * Autor: Daniel Fernando Anderlini © 2025
' * Fecha de generación: 13/03/2025
' * Clase generada por: Daniel Fernando Anderlini
' *
' *******************************************************************
Public Class DatosGeneral

#Region "Propiedades públicas"

    Private mId As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Id
    ''' </summary>
    ''' <value>mId valor del tipo Int64.</value>
    ''' <returns>mId valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Id.</remarks>
    Public Property Id() As Int64
        Get
            Return mId
        End Get
        Set(ByVal value As Int64)
            mId = value
        End Set
    End Property

    Private mEntidad As String
    ''' <summary>
    ''' Propiedad que indica el o la Entidad
    ''' </summary>
    ''' <value>mEntidad valor del tipo String.</value>
    ''' <returns>mEntidad valor del tipo String.</returns>
    ''' <remarks>Propiedad Entidad.</remarks>
    Public Property Entidad() As String
        Get
            Return mEntidad
        End Get
        Set(ByVal value As String)
            mEntidad = value
        End Set
    End Property

    Private mCodigo As String
    ''' <summary>
    ''' Propiedad que indica el o la Codigo
    ''' </summary>
    ''' <value>mCodigo valor del tipo String.</value>
    ''' <returns>mCodigo valor del tipo String.</returns>
    ''' <remarks>Propiedad Codigo.</remarks>
    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal value As String)
            mCodigo = value
        End Set
    End Property

    Private mDescripcion As String
    ''' <summary>
    ''' Propiedad que indica el o la Descripcion
    ''' </summary>
    ''' <value>mDescripcion valor del tipo String.</value>
    ''' <returns>mDescripcion valor del tipo String.</returns>
    ''' <remarks>Propiedad Descripcion.</remarks>
    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal value As String)
            mDescripcion = value
        End Set
    End Property

    Private mHabilitado As Boolean
    ''' <summary>
    ''' Propiedad que indica el o la Habilitado
    ''' </summary>
    ''' <value>mHabilitado valor del tipo Boolean.</value>
    ''' <returns>mHabilitado valor del tipo Boolean.</returns>
    ''' <remarks>Propiedad Habilitado.</remarks>
    Public Property Habilitado() As Boolean
        Get
            Return mHabilitado
        End Get
        Set(ByVal value As Boolean)
            mHabilitado = value
        End Set
    End Property

#End Region

#Region "Métodos Públicos"

    ''' <summary>
    ''' Procedimiento ejecutado al instanciar la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        mId = 0
        mEntidad = ""
        mCodigo = ""
        mDescripcion = ""
        mHabilitado = True
    End Sub

#End Region

End Class
