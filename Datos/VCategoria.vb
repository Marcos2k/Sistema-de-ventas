Public Class VCategoria
    'esta clase es usada como constructor de objetos usando Setter(Enviar) y Getter(Obtener)
    'declaramos variables 
    Dim ID_Categoria As Integer
    Dim Nombre_Categoria As String

    Public Property GID_Categoria
        Get
            Return ID_Categoria
        End Get
        Set(ByVal value)
            ID_Categoria = value
        End Set
    End Property

    Public Property GNombre_Categoria
        Get
            Return Nombre_Categoria
        End Get
        Set(ByVal value)
            Nombre_Categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Categoria As Integer, ByVal Nombre_Categoria As String)
        'Asigno los objetos con su metodos G = Var
        GID_Categoria = ID_Categoria
        GNombre_Categoria = Nombre_Categoria
    End Sub
End Class
