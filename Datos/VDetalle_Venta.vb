Public Class VDetalle_Venta
    Dim ID_Detalle As Integer
    Dim ID_Venta As Integer
    Dim ID_Producto As Integer
    Dim Cantidad As Double
    Dim Precio_Unitario As Double

    'Usando Setter & Getter 
    Public Property GID_Detalle
        Get
            Return ID_Detalle
        End Get
        Set(ByVal value)
            ID_Detalle = value
        End Set
    End Property

    Public Property GID_Venta
        Get
            Return ID_Venta
        End Get
        Set(ByVal value)
            ID_Venta = value
        End Set
    End Property

    Public Property GID_Producto
        Get
            Return ID_Producto
        End Get
        Set(ByVal value)
            ID_Producto = value
        End Set
    End Property

    Public Property GCantidad
        Get
            Return Cantidad
        End Get
        Set(ByVal value)
            Cantidad = value
        End Set
    End Property

    Public Property GPrecio_Unitario
        Get
            Return Precio_Unitario
        End Get
        Set(ByVal value)
            Precio_Unitario = value
        End Set
    End Property

    Public Sub New()
        'Constructor en blanco
    End Sub

    Public Sub New(ByVal ID_Detalle As Integer, ByVal ID_Venta As Integer, ByVal ID_Producto As Integer, ByVal Cantidad As Double, ByVal Precio_Unitario As Double)
        GID_Detalle = ID_Detalle
        GID_Venta = ID_Venta
        GID_Producto = ID_Producto
        GCantidad = Cantidad
        GPrecio_Unitario = Precio_Unitario
    End Sub
End Class
