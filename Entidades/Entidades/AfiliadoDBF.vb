' *******************************************************************
' *
' * Clase: AfiliadoDBF
' * Autor: Daniel Fernando Anderlini © 2025
' * Fecha de generación: 14/02/2025
' * Clase generada por: Daniel Fernando Anderlini
' *
' *******************************************************************
Public Class AfiliadoDBF

#Region "Declaraciones públicas"

#End Region

#Region "Propiedades públicas"

    Private mcuil As Int64
    ''' <summary>
    ''' Propiedad que indica el o la cuil
    ''' </summary>
    ''' <value>mcuil valor del tipo Int64.</value>
    ''' <returns>mcuil valor del tipo Int64.</returns>
    ''' <remarks>Propiedad cuil.</remarks>
    Public Property cuil() As Int64
        Get
            Return mcuil
        End Get
        Set(ByVal value As Int64)
            mcuil = value
        End Set
    End Property

    Private mtipo As Int16
    ''' <summary>
    ''' Propiedad que indica el o la tipo
    ''' </summary>
    ''' <value>mtipo valor del tipo Int16.</value>
    ''' <returns>mtipo valor del tipo Int16.</returns>
    ''' <remarks>Propiedad tipo.</remarks>
    Public Property tipo() As Int16
        Get
            Return mtipo
        End Get
        Set(ByVal value As Int16)
            mtipo = value
        End Set
    End Property

    Private mDocu As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Docu
    ''' </summary>
    ''' <value>mDocu valor del tipo Int64.</value>
    ''' <returns>mDocu valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Docu.</remarks>
    Public Property Docu() As Int64
        Get
            Return mDocu
        End Get
        Set(ByVal value As Int64)
            mDocu = value
        End Set
    End Property

    Private mSecu As Int16
    ''' <summary>
    ''' Propiedad que indica el o la Secu
    ''' </summary>
    ''' <value>mSecu valor del tipo Int16.</value>
    ''' <returns>mSecu valor del tipo Int16.</returns>
    ''' <remarks>Propiedad Secu.</remarks>
    Public Property Secu() As Int16
        Get
            Return mSecu
        End Get
        Set(ByVal value As Int16)
            mSecu = value
        End Set
    End Property

    Private mNomb As String
    ''' <summary>
    ''' Propiedad que indica el o la Nomb
    ''' </summary>
    ''' <value>mNomb valor del tipo String.</value>
    ''' <returns>mNomb valor del tipo String.</returns>
    ''' <remarks>Propiedad Nomb.</remarks>
    Public Property Nomb() As String
        Get
            Return mNomb
        End Get
        Set(ByVal value As String)
            mNomb = value
        End Set
    End Property

    Private mBexp As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Bexp
    ''' </summary>
    ''' <value>mBexp valor del tipo Int64.</value>
    ''' <returns>mBexp valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Bexp.</remarks>
    Public Property Bexp() As Int64
        Get
            Return mBexp
        End Get
        Set(ByVal value As Int64)
            mBexp = value
        End Set
    End Property

    Private mFnac As Date
    ''' <summary>
    ''' Propiedad que indica el o la Fnac
    ''' </summary>
    ''' <value>mFnac valor del tipo Date.</value>
    ''' <returns>mFnac valor del tipo Date.</returns>
    ''' <remarks>Propiedad Fnac.</remarks>
    Public Property Fnac() As Date
        Get
            Return mFnac
        End Get
        Set(ByVal value As Date)
            mFnac = value
        End Set
    End Property

    Private mSexo As Char
    ''' <summary>
    ''' Propiedad que indica el o la Sexo
    ''' </summary>
    ''' <value>mSexo valor del tipo Char.</value>
    ''' <returns>mSexo valor del tipo Char.</returns>
    ''' <remarks>Propiedad Sexo.</remarks>
    Public Property Sexo() As Char
        Get
            Return mSexo
        End Get
        Set(ByVal value As Char)
            mSexo = value
        End Set
    End Property

    Private mOrig As Char
    ''' <summary>
    ''' Propiedad que indica el o la Orig
    ''' </summary>
    ''' <value>mOrig valor del tipo Char.</value>
    ''' <returns>mOrig valor del tipo Char.</returns>
    ''' <remarks>Propiedad Orig.</remarks>
    Public Property Orig() As Char
        Get
            Return mOrig
        End Get
        Set(ByVal value As Char)
            mOrig = value
        End Set
    End Property

    Private mUatre As Char
    ''' <summary>
    ''' Propiedad que indica el o la Uatre
    ''' </summary>
    ''' <value>mUatre valor del tipo Char.</value>
    ''' <returns>mUatre valor del tipo Char.</returns>
    ''' <remarks>Propiedad Uatre.</remarks>
    Public Property Uatre() As Char
        Get
            Return mUatre
        End Get
        Set(ByVal value As Char)
            mUatre = value
        End Set
    End Property

    Private mCuif As Int64
    ''' <summary>
    ''' Propiedad que indica el o la Cuif
    ''' </summary>
    ''' <value>mCuif valor del tipo Int64.</value>
    ''' <returns>mCuif valor del tipo Int64.</returns>
    ''' <remarks>Propiedad Cuif.</remarks>
    Public Property Cuif() As Int64
        Get
            Return mCuif
        End Get
        Set(ByVal value As Int64)
            mCuif = value
        End Set
    End Property

    Private mCond As String
    ''' <summary>
    ''' Propiedad que indica el o la Cond
    ''' </summary>
    ''' <value>mCond valor del tipo String.</value>
    ''' <returns>mCond valor del tipo String.</returns>
    ''' <remarks>Propiedad Cond.</remarks>
    Public Property Cond() As String
        Get
            Return mCond
        End Get
        Set(ByVal value As String)
            mCond = value
        End Set
    End Property

    Private mNumeroProvincia As Int16
    Public ReadOnly Property NewProperty() As Int16
        Get
            mNumeroProvincia = Math.Truncate(mBexp / 1000000000)
            Return mNumeroProvincia
        End Get
    End Property

#End Region

#Region "Métodos Públicos"

    ''' <summary>
    ''' Procedimiento ejecutado al instanciar la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        mcuil = 0
        mtipo = 0
        mDocu = 0
        mSecu = 0
        mNomb = ""
        mBexp = 0
        mFnac = Nothing
        mSexo = ""
        mOrig = ""
        mUatre = ""
        mCuif = 0
        mCond = ""
    End Sub

#End Region

End Class
