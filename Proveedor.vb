' *******************************************************************
' *
' * Clase: Proveedor
' * Autor: Daniel Fernando Anderlini © 2025
' * Fecha de generación: 17/03/2025
' * Clase generada por: Daniel Fernando Anderlini
' *
' *******************************************************************
Public Class Proveedor

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

    Private mNumeroSAP As Int64
    ''' <summary>
    ''' Propiedad que indica el o la NumeroSAP
    ''' </summary>
    ''' <value>mNumeroSAP valor del tipo Int64.</value>
    ''' <returns>mNumeroSAP valor del tipo Int64.</returns>
    ''' <remarks>Propiedad NumeroSAP.</remarks>
    Public Property NumeroSAP() As Int64
        Get
            Return mNumeroSAP
        End Get
        Set(ByVal value As Int64)
            mNumeroSAP = value
        End Set
    End Property

    Private mCUIT As Int64
    ''' <summary>
    ''' Propiedad que indica el o la CUIT
    ''' </summary>
    ''' <value>mCUIT valor del tipo Int64.</value>
    ''' <returns>mCUIT valor del tipo Int64.</returns>
    ''' <remarks>Propiedad CUIT.</remarks>
    Public Property CUIT() As Int64
        Get
            Return mCUIT
        End Get
        Set(ByVal value As Int64)
            mCUIT = value
        End Set
    End Property

    Private mRazonSocial As String
    ''' <summary>
    ''' Propiedad que indica el o la RazonSocial
    ''' </summary>
    ''' <value>mRazonSocial valor del tipo String.</value>
    ''' <returns>mRazonSocial valor del tipo String.</returns>
    ''' <remarks>Propiedad RazonSocial.</remarks>
    Public Property RazonSocial() As String
        Get
            Return mRazonSocial
        End Get
        Set(ByVal value As String)
            mRazonSocial = value
        End Set
    End Property

    Private mTelefono As String
    ''' <summary>
    ''' Propiedad que indica el o la Telefono
    ''' </summary>
    ''' <value>mTelefono valor del tipo String.</value>
    ''' <returns>mTelefono valor del tipo String.</returns>
    ''' <remarks>Propiedad Telefono.</remarks>
    Public Property Telefono() As String
        Get
            Return mTelefono
        End Get
        Set(ByVal value As String)
            mTelefono = value
        End Set
    End Property

    Private mEmail As String
    ''' <summary>
    ''' Propiedad que indica el o la Email
    ''' </summary>
    ''' <value>mEmail valor del tipo String.</value>
    ''' <returns>mEmail valor del tipo String.</returns>
    ''' <remarks>Propiedad Email.</remarks>
    Public Property Email() As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
        End Set
    End Property

    Private mDomicilio As String
    ''' <summary>
    ''' Propiedad que indica el o la Domicilio
    ''' </summary>
    ''' <value>mDomicilio valor del tipo String.</value>
    ''' <returns>mDomicilio valor del tipo String.</returns>
    ''' <remarks>Propiedad Domicilio.</remarks>
    Public Property Domicilio() As String
        Get
            Return mDomicilio
        End Get
        Set(ByVal value As String)
            mDomicilio = value
        End Set
    End Property

    Private mNumeroCuenta As String
    ''' <summary>
    ''' Propiedad que indica el o la NumeroCuenta
    ''' </summary>
    ''' <value>mNumeroCuenta valor del tipo String.</value>
    ''' <returns>mNumeroCuenta valor del tipo String.</returns>
    ''' <remarks>Propiedad NumeroCuenta.</remarks>
    Public Property NumeroCuenta() As String
        Get
            Return mNumeroCuenta
        End Get
        Set(ByVal value As String)
            mNumeroCuenta = value
        End Set
    End Property

    Private mCBU As String
    ''' <summary>
    ''' Propiedad que indica el o la CBU
    ''' </summary>
    ''' <value>mCBU valor del tipo String.</value>
    ''' <returns>mCBU valor del tipo String.</returns>
    ''' <remarks>Propiedad CBU.</remarks>
    Public Property CBU() As String
        Get
            Return mCBU
        End Get
        Set(ByVal value As String)
            mCBU = value
        End Set
    End Property

    Private mId_Categoria As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Id_Categoria
    ''' </summary>
    ''' <value>mId_Categoria valor del tipo Int64.</value>
    ''' <returns>mId_Categoria valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Id_Categoria.</remarks>
    Public Property Id_Categoria() As Int64
        Get
            Return mId_Categoria
        End Get
        Set(ByVal value As Int64)
            mId_Categoria = value
        End Set
    End Property

    Private mId_Subcategoria As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Id_Subcategoria
    ''' </summary>
    ''' <value>mId_Subcategoria valor del tipo Int64.</value>
    ''' <returns>mId_Subcategoria valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Id_Subcategoria.</remarks>
    Public Property Id_Subcategoria() As Int64
        Get
            Return mId_Subcategoria
        End Get
        Set(ByVal value As Int64)
            mId_Subcategoria = value
        End Set
    End Property

    Private mDiasVencimiento As Int16
    ''' <summary>
    ''' Propiedad que indica el o la DiasVencimiento
    ''' </summary>
    ''' <value>mDiasVencimiento valor del tipo Int16.</value>
    ''' <returns>mDiasVencimiento valor del tipo Int16.</returns>
    ''' <remarks>Propiedad DiasVencimiento.</remarks>
    Public Property DiasVencimiento() As Int16
        Get
            Return mDiasVencimiento
        End Get
        Set(ByVal value As Int16)
            mDiasVencimiento = value
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
        mNumeroSAP = 0
        mCUIT = 0
        mRazonSocial = ""
        mTelefono = ""
        mEmail = ""
        mDomicilio = ""
        mNumeroCuenta = ""
        mCBU = ""
        mId_Categoria = 0
        mId_Subcategoria = 0
        mDiasVencimiento = 0
        mHabilitado = True
    End Sub

#End Region

End Class
