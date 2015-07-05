Public Class VUsuario
    Dim ID_Usuario As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Dni As String
    Dim Direccion As String
    Dim Telefono As String
    Dim Login As String
    Dim Password As String
    Dim Acceso As String

    'Metodos Setter and Getter
    Public Property GID_Usuario
        Get
            Return ID_Usuario 'Devuelve un valor 
        End Get
        Set(ByVal value)
            ID_Usuario = value
        End Set
    End Property

    Public Property GNombre
        Get
            Return Nombre
        End Get
        Set(ByVal value)
            Nombre = value
        End Set
    End Property

    Public Property GApellido
        Get
            Return Apellido
        End Get
        Set(ByVal value)
            Apellido = value
        End Set
    End Property

    Public Property GDni
        Get
            Return Dni
        End Get
        Set(ByVal value)
            Dni = value
        End Set
    End Property

    Public Property GDireccion
        Get
            Return Direccion
        End Get
        Set(ByVal value)
            Direccion = value
        End Set
    End Property

    Public Property GTelefono
        Get
            Return Telefono
        End Get
        Set(ByVal value)
            Telefono = value
        End Set
    End Property

    Public Property GLogin
        Get
            Return Login
        End Get
        Set(ByVal value)
            Login = value
        End Set
    End Property

    Public Property GPassword
        Get
            Return Password
        End Get
        Set(ByVal value)
            Password = value
        End Set
    End Property

    Public Property GAcceso
        Get
            Return Acceso
        End Get
        Set(ByVal value)
            Acceso = value
        End Set
    End Property

    Public Sub New()
        'Constructor en Blanco
    End Sub

    Public Sub New(ByVal ID_Usuario As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Dni As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Login As String, ByVal Password As String, ByVal Acesso As String)
        'Asiganamos los objetos
        GID_Usuario = ID_Usuario
        GNombre = Nombre
        GApellido = Apellido
        GDni = Dni
        GDireccion = Direccion
        GTelefono = Telefono
        GLogin = Login
        GPassword = Password
        GAcceso = Acesso
    End Sub
End Class
