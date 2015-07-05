Public Class VCliente
    'esta clase es usada como constructor de objetos usando Setter(Enviar) y Getter(Obtener)
    'declaramos variables 
    Dim ID_Cliente As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Direccion As String
    Dim Telefono As String
    Dim Dni As String

    'El metodo Setter me permite guardar un dato en aquellos objetos poseen atibutos ya en memoria
    'El metodo Getter leer los datos que esos atributos de los objetos ya contienen

    'El prefijo G = Get
    Public Property GID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(ByVal value)
            ID_Cliente = value
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

    Public Property GDni
        Get
            Return Dni
        End Get
        Set(ByVal value)
            Dni = value
        End Set
    End Property
    'Declaramos constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Cliente As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Dni As String)
        'Asigno los objetos con su metodos G = Var
        GID_Cliente = ID_Cliente
        GNombre = Nombre
        GApellido = Apellido
        GDireccion = Direccion
        GTelefono = Telefono
        GDni = Dni
    End Sub
End Class
