' *******************************************************************
' *
' * Clase: Afiliado
' * Autor: Daniel Fernando Anderlini © 2025
' * Fecha de generación: 14/02/2025
' * Clase generada por: Daniel Fernando Anderlini
' *
' *******************************************************************
Public Class Afiliado

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

    Private mApellidos As String
    ''' <summary>
    ''' Propiedad que indica el o la Apellidos
    ''' </summary>
    ''' <value>mApellidos valor del tipo String.</value>
    ''' <returns>mApellidos valor del tipo String.</returns>
    ''' <remarks>Propiedad Apellidos.</remarks>
    Public Property Apellidos() As String
        Get
            Return mApellidos
        End Get
        Set(ByVal value As String)
            mApellidos = value
        End Set
    End Property

    Private mNombres As String
    ''' <summary>
    ''' Propiedad que indica el o la Nombres
    ''' </summary>
    ''' <value>mNombres valor del tipo String.</value>
    ''' <returns>mNombres valor del tipo String.</returns>
    ''' <remarks>Propiedad Nombres.</remarks>
    Public Property Nombres() As String
        Get
            Return mNombres
        End Get
        Set(ByVal value As String)
            mNombres = value
        End Set
    End Property

    Private mFechaNacimiento As Date
    ''' <summary>
    ''' Propiedad que indica el o la FechaNacimiento
    ''' </summary>
    ''' <value>mFechaNacimiento valor del tipo Date.</value>
    ''' <returns>mFechaNacimiento valor del tipo Date.</returns>
    ''' <remarks>Propiedad FechaNacimiento.</remarks>
    Public Property FechaNacimiento() As Date
        Get
            Return mFechaNacimiento
        End Get
        Set(ByVal value As Date)
            mFechaNacimiento = value
        End Set
    End Property

    Private mGenero As String
    ''' <summary>
    ''' Propiedad que indica el o la Genero
    ''' </summary>
    ''' <value>mGenero valor del tipo String.</value>
    ''' <returns>mGenero valor del tipo String.</returns>
    ''' <remarks>Propiedad Genero.</remarks>
    Public Property Genero() As String
        Get
            Return mGenero
        End Get
        Set(ByVal value As String)
            mGenero = value
        End Set
    End Property

    Private mCUILT_Titular As Int64
    ''' <summary>
    ''' Propiedad que indica el o la CUILT_Titular
    ''' </summary>
    ''' <value>mCUILT_Titular valor del tipo Int64.</value>
    ''' <returns>mCUILT_Titular valor del tipo Int64.</returns>
    ''' <remarks>Propiedad CUILT_Titular.</remarks>
    Public Property CUILT_Titular() As Int64
        Get
            Return mCUILT_Titular
        End Get
        Set(ByVal value As Int64)
            mCUILT_Titular = value
        End Set
    End Property

    Private mRelacion As String
    ''' <summary>
    ''' Propiedad que indica el o la Relacion
    ''' </summary>
    ''' <value>mRelacion valor del tipo String.</value>
    ''' <returns>mRelacion valor del tipo String.</returns>
    ''' <remarks>Propiedad Relacion.</remarks>
    Public Property Relacion() As String
        Get
            Return mRelacion
        End Get
        Set(ByVal value As String)
            mRelacion = value
        End Set
    End Property

    Private mTipoAfiliado As String
    ''' <summary>
    ''' Propiedad que indica el o la TipoAfiliado
    ''' </summary>
    ''' <value>mTipoAfiliado valor del tipo String.</value>
    ''' <returns>mTipoAfiliado valor del tipo String.</returns>
    ''' <remarks>Propiedad TipoAfiliado.</remarks>
    Public Property TipoAfiliado() As String
        Get
            Return mTipoAfiliado
        End Get
        Set(ByVal value As String)
            mTipoAfiliado = value
        End Set
    End Property

    Private mUATRE As Boolean
    ''' <summary>
    ''' Propiedad que indica el o la UATRE
    ''' </summary>
    ''' <value>mUATRE valor del tipo Boolean.</value>
    ''' <returns>mUATRE valor del tipo Boolean.</returns>
    ''' <remarks>Propiedad UATRE.</remarks>
    Public Property UATRE() As Boolean
        Get
            Return mUATRE
        End Get
        Set(ByVal value As Boolean)
            mUATRE = value
        End Set
    End Property

    Private mProvincia As String
    ''' <summary>
    ''' Propiedad que indica el o la Provincia
    ''' </summary>
    ''' <value>mProvincia valor del tipo String.</value>
    ''' <returns>mProvincia valor del tipo String.</returns>
    ''' <remarks>Propiedad Provincia.</remarks>
    Public Property Provincia() As String
        Get
            Return mProvincia
        End Get
        Set(ByVal value As String)
            mProvincia = value
        End Set
    End Property

    Private mBocaExpendio As Int64
    ''' <summary>
    ''' Propiedad que indica el o la BocaExpendio
    ''' </summary>
    ''' <value>mBocaExpendio valor del tipo Int64.</value>
    ''' <returns>mBocaExpendio valor del tipo Int64.</returns>
    ''' <remarks>Propiedad BocaExpendio.</remarks>
    Public Property BocaExpendio() As Int64
        Get
            Return mBocaExpendio
        End Get
        Set(ByVal value As Int64)
            mBocaExpendio = value
        End Set
    End Property

    Private mDepartamento As String
    ''' <summary>
    ''' Propiedad que indica el o la Departamento
    ''' </summary>
    ''' <value>mDepartamento valor del tipo String.</value>
    ''' <returns>mDepartamento valor del tipo String.</returns>
    ''' <remarks>Propiedad Departamento.</remarks>
    Public Property Departamento() As String
        Get
            Return mDepartamento
        End Get
        Set(ByVal value As String)
            mDepartamento = value
        End Set
    End Property

    Private mLocalidad As String
    ''' <summary>
    ''' Propiedad que indica el o la Localidad
    ''' </summary>
    ''' <value>mLocalidad valor del tipo String.</value>
    ''' <returns>mLocalidad valor del tipo String.</returns>
    ''' <remarks>Propiedad Localidad.</remarks>
    Public Property Localidad() As String
        Get
            Return mLocalidad
        End Get
        Set(ByVal value As String)
            mLocalidad = value
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

    Private mTipoCarga As String
    ''' <summary>
    ''' Propiedad que indica el o la TipoCarga
    ''' </summary>
    ''' <value>mTipoCarga valor del tipo String.</value>
    ''' <returns>mTipoCarga valor del tipo String.</returns>
    ''' <remarks>Propiedad TipoCarga.</remarks>
    Public Property TipoCarga() As String
        Get
            Return mTipoCarga
        End Get
        Set(ByVal value As String)
            mTipoCarga = value
        End Set
    End Property

    Private mNombreCompleto As String
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return mApellidos.Trim & ", " & mNombres.Trim
        End Get
    End Property

    Private mEdad As Int64
    Public ReadOnly Property Edad() As Int16
        Get
            If Not mFechaNacimiento = Nothing Then
                mEdad = Fix((DateDiff(DateInterval.Month, mFechaNacimiento, Now)) / 12)
            Else
                mEdad = 0
            End If
            Return mEdad
        End Get
    End Property

#End Region

#Region "Métodos Públicos"

    ''' <summary>
    ''' Procedimiento ejecutado al instanciar la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        mId = 0
        mCUIL = 0
        mApellidos = ""
        mNombres = ""
        mFechaNacimiento = Nothing
        mGenero = ""
        mCUILT_Titular = 0
        mRelacion = ""
        mTipoAfiliado = ""
        mUATRE = False
        mProvincia = ""
        mBocaExpendio = 0
        mDepartamento = ""
        mLocalidad = ""
        mDomicilio = ""
        mTelefono = ""
        mEmail = ""
        mTipoCarga = ""
    End Sub

#End Region

End Class
