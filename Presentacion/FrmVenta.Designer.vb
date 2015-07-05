<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_Tipo_Documento = New System.Windows.Forms.ComboBox()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.BTNEncontrar = New System.Windows.Forms.Button()
        Me.TBNombre_Cliente = New System.Windows.Forms.TextBox()
        Me.BTNGuardar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.BTNEditar = New System.Windows.Forms.Button()
        Me.BTNNuevo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNro_Documento = New System.Windows.Forms.TextBox()
        Me.TBID_Cliente = New System.Windows.Forms.TextBox()
        Me.TBID_Venta = New System.Windows.Forms.TextBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_Tipo_Documento)
        Me.GroupBox1.Controls.Add(Me.DTFecha)
        Me.GroupBox1.Controls.Add(Me.BTNEncontrar)
        Me.GroupBox1.Controls.Add(Me.TBNombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNEditar)
        Me.GroupBox1.Controls.Add(Me.BTNNuevo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBNro_Documento)
        Me.GroupBox1.Controls.Add(Me.TBID_Cliente)
        Me.GroupBox1.Controls.Add(Me.TBID_Venta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 236)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
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
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(127, 77)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(121, 20)
        Me.DTFecha.TabIndex = 25
        '
        'BTNEncontrar
        '
        Me.BTNEncontrar.Location = New System.Drawing.Point(254, 51)
        Me.BTNEncontrar.Name = "BTNEncontrar"
        Me.BTNEncontrar.Size = New System.Drawing.Size(41, 23)
        Me.BTNEncontrar.TabIndex = 24
        Me.BTNEncontrar.Text = "..."
        Me.BTNEncontrar.UseVisualStyleBackColor = True
        '
        'TBNombre_Cliente
        '
        Me.TBNombre_Cliente.Location = New System.Drawing.Point(127, 54)
        Me.TBNombre_Cliente.MaxLength = 50
        Me.TBNombre_Cliente.Name = "TBNombre_Cliente"
        Me.TBNombre_Cliente.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre_Cliente.TabIndex = 17
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(254, 132)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 16
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(254, 161)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 15
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNEditar
        '
        Me.BTNEditar.Location = New System.Drawing.Point(254, 103)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEditar.TabIndex = 13
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.UseVisualStyleBackColor = True
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Location = New System.Drawing.Point(254, 74)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTNNuevo.TabIndex = 12
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.UseVisualStyleBackColor = True
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ID Cliente"
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
        Me.TBID_Cliente.Location = New System.Drawing.Point(91, 53)
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
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(230, 20)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(151, 20)
        Me.TBBuscar.TabIndex = 2
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
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Nro_Documento", "Dni"})
        Me.CBBuscar.Location = New System.Drawing.Point(35, 19)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(177, 21)
        Me.CBBuscar.TabIndex = 1
        Me.CBBuscar.Text = "Nro_Documento"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblInexistente)
        Me.GroupBox2.Controls.Add(Me.TBBuscar)
        Me.GroupBox2.Controls.Add(Me.CBBuscar)
        Me.GroupBox2.Controls.Add(Me.Grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 355)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de ventas"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmVenta"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNEditar As System.Windows.Forms.Button
    Friend WithEvents BTNNuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNro_Documento As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Venta As System.Windows.Forms.TextBox
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents TBNombre_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents BTNEncontrar As System.Windows.Forms.Button
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_Tipo_Documento As System.Windows.Forms.ComboBox
End Class
