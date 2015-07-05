<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNEditar = New System.Windows.Forms.Button()
        Me.BTNNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNEliminar_imagen = New System.Windows.Forms.PictureBox()
        Me.BTNCargar = New System.Windows.Forms.PictureBox()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.BTNEncontrar = New System.Windows.Forms.Button()
        Me.TBNombre_Categoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBPrecio_venta = New System.Windows.Forms.TextBox()
        Me.TBPrecio_Compra = New System.Windows.Forms.TextBox()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBID_Categoria = New System.Windows.Forms.TextBox()
        Me.TBID_Producto = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TBFlag = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTNEliminar_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHKEliminar)
        Me.GroupBox2.Controls.Add(Me.LblInexistente)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Controls.Add(Me.TBBuscar)
        Me.GroupBox2.Controls.Add(Me.CBBuscar)
        Me.GroupBox2.Controls.Add(Me.Grilla)
        Me.GroupBox2.Controls.Add(Me.BTNGuardar)
        Me.GroupBox2.Controls.Add(Me.BTNCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 355)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de de los productos"
        '
        'CHKEliminar
        '
        Me.CHKEliminar.AutoSize = True
        Me.CHKEliminar.Location = New System.Drawing.Point(16, 46)
        Me.CHKEliminar.Name = "CHKEliminar"
        Me.CHKEliminar.Size = New System.Drawing.Size(62, 17)
        Me.CHKEliminar.TabIndex = 15
        Me.CHKEliminar.Text = "Eliminar"
        Me.CHKEliminar.UseVisualStyleBackColor = True
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(175, 199)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 3
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(16, 326)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEliminar.TabIndex = 14
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(230, 20)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(151, 20)
        Me.TBBuscar.TabIndex = 2
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Nombre", "Nombre_Categoria"})
        Me.CBBuscar.Location = New System.Drawing.Point(35, 19)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(177, 21)
        Me.CBBuscar.TabIndex = 1
        Me.CBBuscar.Text = "Nombre"
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEliminar})
        Me.Grilla.Location = New System.Drawing.Point(16, 66)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(388, 254)
        Me.Grilla.TabIndex = 0
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        Me.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(178, 326)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 16
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(329, 326)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 15
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNEditar
        '
        Me.BTNEditar.Location = New System.Drawing.Point(255, 146)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEditar.TabIndex = 13
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.UseVisualStyleBackColor = True
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Location = New System.Drawing.Point(255, 117)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTNNuevo.TabIndex = 12
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio de compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Producto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNEliminar_imagen)
        Me.GroupBox1.Controls.Add(Me.BTNCargar)
        Me.GroupBox1.Controls.Add(Me.PBImagen)
        Me.GroupBox1.Controls.Add(Me.DTFecha)
        Me.GroupBox1.Controls.Add(Me.BTNEncontrar)
        Me.GroupBox1.Controls.Add(Me.TBNombre_Categoria)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBPrecio_venta)
        Me.GroupBox1.Controls.Add(Me.BTNEditar)
        Me.GroupBox1.Controls.Add(Me.BTNNuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBPrecio_Compra)
        Me.GroupBox1.Controls.Add(Me.TBStock)
        Me.GroupBox1.Controls.Add(Me.TBDescripcion)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.TBID_Categoria)
        Me.GroupBox1.Controls.Add(Me.TBID_Producto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 355)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'BTNEliminar_imagen
        '
        Me.BTNEliminar_imagen.BackgroundImage = CType(resources.GetObject("BTNEliminar_imagen.BackgroundImage"), System.Drawing.Image)
        Me.BTNEliminar_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNEliminar_imagen.Location = New System.Drawing.Point(87, 273)
        Me.BTNEliminar_imagen.Name = "BTNEliminar_imagen"
        Me.BTNEliminar_imagen.Size = New System.Drawing.Size(41, 35)
        Me.BTNEliminar_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNEliminar_imagen.TabIndex = 27
        Me.BTNEliminar_imagen.TabStop = False
        '
        'BTNCargar
        '
        Me.BTNCargar.BackgroundImage = CType(resources.GetObject("BTNCargar.BackgroundImage"), System.Drawing.Image)
        Me.BTNCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCargar.Location = New System.Drawing.Point(19, 273)
        Me.BTNCargar.Name = "BTNCargar"
        Me.BTNCargar.Size = New System.Drawing.Size(41, 35)
        Me.BTNCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNCargar.TabIndex = 26
        Me.BTNCargar.TabStop = False
        '
        'PBImagen
        '
        Me.PBImagen.BackgroundImage = Global.SisVentas.My.Resources.Resources.incognita
        Me.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagen.Location = New System.Drawing.Point(141, 257)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(95, 92)
        Me.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagen.TabIndex = 25
        Me.PBImagen.TabStop = False
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(128, 231)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(121, 20)
        Me.DTFecha.TabIndex = 24
        '
        'BTNEncontrar
        '
        Me.BTNEncontrar.Location = New System.Drawing.Point(289, 52)
        Me.BTNEncontrar.Name = "BTNEncontrar"
        Me.BTNEncontrar.Size = New System.Drawing.Size(41, 23)
        Me.BTNEncontrar.TabIndex = 23
        Me.BTNEncontrar.Text = "..."
        Me.BTNEncontrar.UseVisualStyleBackColor = True
        '
        'TBNombre_Categoria
        '
        Me.TBNombre_Categoria.Location = New System.Drawing.Point(164, 54)
        Me.TBNombre_Categoria.MaxLength = 20
        Me.TBNombre_Categoria.Name = "TBNombre_Categoria"
        Me.TBNombre_Categoria.Size = New System.Drawing.Size(119, 20)
        Me.TBNombre_Categoria.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Imagen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha de vencimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Precio de venta"
        '
        'TBPrecio_venta
        '
        Me.TBPrecio_venta.Location = New System.Drawing.Point(128, 205)
        Me.TBPrecio_venta.MaxLength = 10
        Me.TBPrecio_venta.Name = "TBPrecio_venta"
        Me.TBPrecio_venta.Size = New System.Drawing.Size(121, 20)
        Me.TBPrecio_venta.TabIndex = 17
        '
        'TBPrecio_Compra
        '
        Me.TBPrecio_Compra.Location = New System.Drawing.Point(128, 179)
        Me.TBPrecio_Compra.MaxLength = 10
        Me.TBPrecio_Compra.Name = "TBPrecio_Compra"
        Me.TBPrecio_Compra.Size = New System.Drawing.Size(121, 20)
        Me.TBPrecio_Compra.TabIndex = 5
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(128, 154)
        Me.TBStock.MaxLength = 20
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(121, 20)
        Me.TBStock.TabIndex = 4
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(128, 103)
        Me.TBDescripcion.MaxLength = 255
        Me.TBDescripcion.Multiline = True
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBDescripcion.Size = New System.Drawing.Size(121, 42)
        Me.TBDescripcion.TabIndex = 3
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(128, 77)
        Me.TBNombre.MaxLength = 50
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre.TabIndex = 2
        '
        'TBID_Categoria
        '
        Me.TBID_Categoria.Location = New System.Drawing.Point(128, 54)
        Me.TBID_Categoria.MaxLength = 3
        Me.TBID_Categoria.Name = "TBID_Categoria"
        Me.TBID_Categoria.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Categoria.TabIndex = 1
        '
        'TBID_Producto
        '
        Me.TBID_Producto.Location = New System.Drawing.Point(128, 28)
        Me.TBID_Producto.MaxLength = 3
        Me.TBID_Producto.Name = "TBID_Producto"
        Me.TBID_Producto.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Producto.TabIndex = 0
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'TBFlag
        '
        Me.TBFlag.Location = New System.Drawing.Point(258, 13)
        Me.TBFlag.Name = "TBFlag"
        Me.TBFlag.Size = New System.Drawing.Size(83, 20)
        Me.TBFlag.TabIndex = 4
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 456)
        Me.Controls.Add(Me.TBFlag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProducto"
        Me.Text = "Listado del catalogo de producto"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTNEliminar_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNEditar As System.Windows.Forms.Button
    Friend WithEvents BTNNuevo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBPrecio_Compra As System.Windows.Forms.TextBox
    Friend WithEvents TBStock As System.Windows.Forms.TextBox
    Friend WithEvents TBDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Producto As System.Windows.Forms.TextBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBPrecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents BTNEncontrar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar_imagen As System.Windows.Forms.PictureBox
    Friend WithEvents BTNCargar As System.Windows.Forms.PictureBox
    Friend WithEvents PBImagen As System.Windows.Forms.PictureBox
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TBFlag As System.Windows.Forms.TextBox
End Class
