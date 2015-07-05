Public Class VVenta
    Dim ID_Venta As Integer
    Dim ID_Cliente As Integer
    Dim Fecha_Venta As Date
    Dim Tipo_Documento As String
    Dim Nro_Documento As String

    Public Property GID_Venta
        Get
            Return ID_Venta
        End Get
        Set(ByVal value)
            ID_Venta = value
        End Set
    End Property

    Public Property GID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(ByVal value)
            ID_Cliente = value
        End Set
    End Property

    Public Property GFecha_Venta
        Get
            Return Fecha_Venta
        End Get
        Set(ByVal value)
            Fecha_Venta = value
        End Set
    End Property

    Public Property GTipo_Documento
        Get
            Return Tipo_Documento
        End Get
        Set(ByVal value)
            Tipo_Documento = value
        End Set
    End Property

    Public Property GNro_Documento
        Get
            Return Nro_Documento
        End Get
        Set(ByVal value)
            Nro_Documento = value
        End Set
    End Property

    Public Sub New()
        'Constructor en blanco
    End Sub

    Public Sub New(ByVal ID_Venta As Integer, ByVal ID_Cliente As Integer, ByVal Fecha_Venta As Date, ByVal Tipo_Documento As String, ByVal Nro_Documento As String)
        'Asignamos los valores Set & Get a los objetos
        GID_Venta = ID_Venta
        GID_Cliente = ID_Cliente
        GFecha_Venta = Fecha_Venta
        GTipo_Documento = Tipo_Documento
        GNro_Documento = Nro_Documento
    End Sub
End Class
