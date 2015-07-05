<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalle_Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalle_Venta))
        Me.CB_Tipo_Documento = New System.Windows.Forms.ComboBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.TBNombre_Cliente = New System.Windows.Forms.TextBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNro_Documento = New System.Windows.Forms.TextBox()
        Me.TBID_Cliente = New System.Windows.Forms.TextBox()
        Me.TBID_Venta = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBQuitar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TBNombre_Producto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBID_Producto = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.NUPStock = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NUPCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBPrecio_unitario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUPStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUPCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_Tipo_Documento
        '
        Me.CB_Tipo_Documento.FormattingEnabled = True
        Me.CB_Tipo_Documento.Items.AddRange(New Object() {"Boleta" & Global.Microsoft.VisualBasic.ChrW(9), "Factura"})
        Me.CB_Tipo_Documento.Location = New System.Drawing.Point(127, 105)
        Me.CB_Tipo_Documento.Name = "CB_Tipo_Documento"
        Me.CB_Tipo_Documento.Size = New System.Drawing.Size(121, 21)
        Me.CB_Tipo_Documento.TabIndex = 26
        Me.CB_Tipo_Documento.Text = "Factura"
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
        'CHKEliminar
        '
        Me.CHKEliminar.AutoSize = True
        Me.CHKEliminar.Location = New System.Drawing.Point(16, 30)
        Me.CHKEliminar.Name = "CHKEliminar"
        Me.CHKEliminar.Size = New System.Drawing.Size(62, 17)
        Me.CHKEliminar.TabIndex = 15
        Me.CHKEliminar.Text = "Eliminar"
        Me.CHKEliminar.UseVisualStyleBackColor = True
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(127, 77)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(121, 20)
        Me.DTFecha.TabIndex = 25
        '
        'TBNombre_Cliente
        '
        Me.TBNombre_Cliente.Location = New System.Drawing.Point(127, 53)
        Me.TBNombre_Cliente.MaxLength = 50
        Me.TBNombre_Cliente.Name = "TBNombre_Cliente"
        Me.TBNombre_Cliente.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre_Cliente.TabIndex = 17
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
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(127, 135)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 15
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_Tipo_Documento)
        Me.GroupBox1.Controls.Add(Me.DTFecha)
        Me.GroupBox1.Controls.Add(Me.TBNombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBNro_Documento)
        Me.GroupBox1.Controls.Add(Me.TBID_Cliente)
        Me.GroupBox1.Controls.Add(Me.TBID_Venta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 197)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Numero Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Numero Documento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tipo de Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo de Documento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID [Venta]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID [Venta]"
        '
        'TBNro_Documento
        '
        Me.TBNro_Documento.Location = New System.Drawing.Point(127, 130)
        Me.TBNro_Documento.MaxLength = 10
        Me.TBNro_Documento.Name = "TBNro_Documento"
        Me.TBNro_Documento.Size = New System.Drawing.Size(121, 20)
        Me.TBNro_Documento.TabIndex = 4
        '
        'TBID_Cliente
        '
        Me.TBID_Cliente.Location = New System.Drawing.Point(91, 54)
        Me.TBID_Cliente.MaxLength = 50
        Me.TBID_Cliente.Name = "TBID_Cliente"
        Me.TBID_Cliente.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Cliente.TabIndex = 1
        '
        'TBID_Venta
        '
        Me.TBID_Venta.Location = New System.Drawing.Point(91, 28)
        Me.TBID_Venta.MaxLength = 5
        Me.TBID_Venta.Name = "TBID_Venta"
        Me.TBID_Venta.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Venta.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBQuitar)
        Me.GroupBox2.Controls.Add(Me.CHKEliminar)
        Me.GroupBox2.Controls.Add(Me.LblInexistente)
        Me.GroupBox2.Controls.Add(Me.Grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 367)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de ventas"
        '
        'TBQuitar
        '
        Me.TBQuitar.Location = New System.Drawing.Point(84, 25)
        Me.TBQuitar.Name = "TBQuitar"
        Me.TBQuitar.Size = New System.Drawing.Size(93, 23)
        Me.TBQuitar.TabIndex = 16
        Me.TBQuitar.Text = "Quitar articulos"
        Me.TBQuitar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(254, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TBNombre_Producto
        '
        Me.TBNombre_Producto.Location = New System.Drawing.Point(127, 29)
        Me.TBNombre_Producto.MaxLength = 50
        Me.TBNombre_Producto.Name = "TBNombre_Producto"
        Me.TBNombre_Producto.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre_Producto.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ID Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Producto"
        '
        'TBID_Producto
        '
        Me.TBID_Producto.Location = New System.Drawing.Point(91, 29)
        Me.TBID_Producto.MaxLength = 50
        Me.TBID_Producto.Name = "TBID_Producto"
        Me.TBID_Producto.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Producto.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnImprimir)
        Me.GroupBox3.Controls.Add(Me.BtnNuevo)
        Me.GroupBox3.Controls.Add(Me.BTNAgregar)
        Me.GroupBox3.Controls.Add(Me.NUPStock)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.BTNCancelar)
        Me.GroupBox3.Controls.Add(Me.NUPCantidad)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TBPrecio_unitario)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TBNombre_Producto)
        Me.GroupBox3.Controls.Add(Me.BtnBuscar)
        Me.GroupBox3.Controls.Add(Me.TBID_Producto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 164)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimir.Location = New System.Drawing.Point(229, 86)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(57, 43)
        Me.BtnImprimir.TabIndex = 38
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(40, 135)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 37
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Location = New System.Drawing.Point(220, 135)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BTNAgregar.TabIndex = 36
        Me.BTNAgregar.Text = "Agregar"
        Me.BTNAgregar.UseVisualStyleBackColor = True
        '
        'NUPStock
        '
        Me.NUPStock.Location = New System.Drawing.Point(203, 56)
        Me.NUPStock.Name = "NUPStock"
        Me.NUPStock.Size = New System.Drawing.Size(54, 20)
        Me.NUPStock.TabIndex = 35
        Me.NUPStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(162, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Stock"
        '
        'NUPCantidad
        '
        Me.NUPCantidad.Location = New System.Drawing.Point(91, 56)
        Me.NUPCantidad.Name = "NUPCantidad"
        Me.NUPCantidad.Size = New System.Drawing.Size(54, 20)
        Me.NUPCantidad.TabIndex = 33
        Me.NUPCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Precio Unitario"
        '
        'TBPrecio_unitario
        '
        Me.TBPrecio_unitario.Location = New System.Drawing.Point(91, 86)
        Me.TBPrecio_unitario.Name = "TBPrecio_unitario"
        Me.TBPrecio_unitario.Size = New System.Drawing.Size(86, 20)
        Me.TBPrecio_unitario.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cantidad"
        '
        'FrmDetalle_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 456)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmDetalle_Venta"
        Me.Text = "Listado de detalle de venta"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUPStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUPCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_Tipo_Documento As System.Windows.Forms.ComboBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBNombre_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNro_Documento As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Venta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TBNombre_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBID_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NUPStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NUPCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TBPrecio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents TBQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
