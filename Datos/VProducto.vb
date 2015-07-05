Public Class VProducto
    Dim ID_Producto As Integer 'usado como PK en SQL
    Dim ID_Categoria As Integer 'usado como FK en SQL
    Dim Nombre As String
    Dim Descripcion As String
    Dim Stock As Double
    Dim Precio_Compra As Double
    Dim Precio_Venta As Double
    Dim Fecha_Vencimiento As Date
    Dim Imagen() As Byte 'lo declaro como array para guardar las imagenes

    'Usamos Setter ang Getter
    Public Property GID_Producto
        Get
            Return ID_Producto
        End Get
        Set(ByVal value)
            ID_Producto = value
        End Set
    End Property

    Public Property GID_Categoria
        Get
            Return ID_Categoria
        End Get
        Set(ByVal value)
            ID_Categoria = value
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

    Public Property GDescripcion
        Get
            Return Descripcion
        End Get
        Set(ByVal value)
            Descripcion = value
        End Set
    End Property

    Public Property GStock
        Get
            Return Stock
        End Get
        Set(ByVal value)
            Stock = value
        End Set
    End Property

    Public Property GPrecio_Compra
        Get
            Return Precio_Compra
        End Get
        Set(ByVal value)
            Precio_Compra = value
        End Set
    End Property

    Public Property GPrecio_Venta
        Get
            Return Precio_Venta
        End Get
        Set(ByVal value)
            Precio_Venta = value
        End Set
    End Property

    Public Property GFecha_Vencimiento
        Get
            Return Fecha_Vencimiento
        End Get
        Set(ByVal value)
            Fecha_vencimiento = value
        End Set
    End Property

    Public Property GImagen
        Get
            Return Imagen
        End Get
        Set(ByVal value)
            Imagen = value
        End Set
    End Property
    Public Sub New()
        'constructor en blanco
    End Sub
    Public Sub New(ByVal ID_Prodcuto As Integer, ByVal ID_Categoria As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Stock As Double, ByVal Precio_Compra As Double, ByVal Precio_Venta As Double, ByVal Fecha_Vencimiento As Date, ByVal Imagen() As Byte)
        GID_Producto = ID_Prodcuto
        GID_Categoria = ID_Categoria
        GNombre = Nombre
        GDescripcion = Descripcion
        GStock = Stock
        GPrecio_Compra = Precio_Compra
        GPrecio_Venta = Precio_Venta
        GFecha_Vencimiento = Fecha_Vencimiento
        GImagen = Imagen
    End Sub
End Class
