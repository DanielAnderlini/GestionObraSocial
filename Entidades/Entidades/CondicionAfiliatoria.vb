' *******************************************************************
' *
' * Clase: CondicionAfiliatoria
' * Autor: Daniel Fernando Anderlini © 2025
' * Fecha de generación: 18/02/2025
' * Clase generada por: Daniel Fernando Anderlini
' *
' *******************************************************************
Public Class CondicionAfiliatoria

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

    Private mMes As Int16
    ''' <summary>
    ''' Propiedad que indica el o la Mes
    ''' </summary>
    ''' <value>mMes valor del tipo Int16.</value>
    ''' <returns>mMes valor del tipo Int16.</returns>
    ''' <remarks>Propiedad Mes.</remarks>
    Public Property Mes() As Int16
        Get
            Return mMes
        End Get
        Set(ByVal value As Int16)
            mMes = value
        End Set
    End Property

    Private mId_Afiliado As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Id_Afiliado
    ''' </summary>
    ''' <value>mId_Afiliado valor del tipo Int64.</value>
    ''' <returns>mId_Afiliado valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Id_Afiliado.</remarks>
    Public Property Id_Afiliado() As Int64
        Get
            Return mId_Afiliado
        End Get
        Set(ByVal value As Int64)
            mId_Afiliado = value
        End Set
    End Property

    Private mCUIL As Int64
    ''' <summary>
    ''' Propiedad que indica el o la CUIL
    ''' </summary>
    ''' <value>mCUIL valor del tipo Int64.</value>
    ''' <returns>mCUIL valor del tipo Int64.</returns>
    ''' <remarks>Propiedad CUIL.</remarks>
    Public Property CUIL() As Int64
        Get
            Return mCUIL
        End Get
        Set(ByVal value As Int64)
            mCUIL = value
        End Set
    End Property

    Private mDNI As Int64
    ''' <summary>
    ''' Propiedad que indica el o la DNI
    ''' </summary>
    ''' <value>mDNI valor del tipo Int64.</value>
    ''' <returns>mDNI valor del tipo Int64.</returns>
    ''' <remarks>Propiedad DNI.</remarks>
    Public Property DNI() As Int64
        Get
            Return mDNI
        End Get
        Set(ByVal value As Int64)
            mDNI = value
        End Set
    End Property

    Private mCUIL_Titular As Int64
    ''' <summary>
    ''' Propiedad que indica el o la CUIL_Titular
    ''' </summary>
    ''' <value>mCUIL_Titular valor del tipo Int64.</value>
    ''' <returns>mCUIL_Titular valor del tipo Int64.</returns>
    ''' <remarks>Propiedad CUIL_Titular.</remarks>
    Public Property CUIL_Titular() As Int64
        Get
            Return mCUIL_Titular
        End Get
        Set(ByVal value As Int64)
            mCUIL_Titular = value
        End Set
    End Property

    Private mTipoCondicion As String
    ''' <summary>
    ''' Propiedad que indica el o la TipoCondicion
    ''' </summary>
    ''' <value>mTipoCondicion valor del tipo String.</value>
    ''' <returns>mTipoCondicion valor del tipo String.</returns>
    ''' <remarks>Propiedad TipoCondicion.</remarks>
    Public Property TipoCondicion() As String
        Get
            Return mTipoCondicion
        End Get
        Set(ByVal value As String)
            mTipoCondicion = value
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
        mMes = 0
        mId_Afiliado = 0
        mCUIL = 0
        mDNI = 0
        mCUIL_Titular = 0
        mTipoCondicion = ""
    End Sub

#End Region

End Class
