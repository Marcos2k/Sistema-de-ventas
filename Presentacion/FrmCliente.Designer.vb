<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBID_Cliente = New System.Windows.Forms.TextBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TBFlag = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNGuardar)
        Me.GroupBox1.Controls.Add(Me.BTNCancelar)
        Me.GroupBox1.Controls.Add(Me.BTNEditar)
        Me.GroupBox1.Controls.Add(Me.BTNNuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Controls.Add(Me.TBTelefono)
        Me.GroupBox1.Controls.Add(Me.TBDireccion)
        Me.GroupBox1.Controls.Add(Me.TBApellido)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.TBID_Cliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'BTNGuardar
        '
        Me.BTNGuardar.Location = New System.Drawing.Point(244, 125)
        Me.BTNGuardar.Name = "BTNGuardar"
        Me.BTNGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNGuardar.TabIndex = 16
        Me.BTNGuardar.Text = "Guardar"
        Me.BTNGuardar.UseVisualStyleBackColor = True
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(244, 154)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancelar.TabIndex = 15
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'BTNEditar
        '
        Me.BTNEditar.Location = New System.Drawing.Point(244, 96)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(75, 23)
        Me.BTNEditar.TabIndex = 13
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.UseVisualStyleBackColor = True
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Location = New System.Drawing.Point(244, 67)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTNNuevo.TabIndex = 12
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dni"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apellido/s"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(79, 155)
        Me.TBDni.MaxLength = 8
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(121, 20)
        Me.TBDni.TabIndex = 5
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(79, 130)
        Me.TBTelefono.MaxLength = 10
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(121, 20)
        Me.TBTelefono.TabIndex = 4
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(79, 103)
        Me.TBDireccion.MaxLength = 99
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(121, 20)
        Me.TBDireccion.TabIndex = 3
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(79, 77)
        Me.TBApellido.MaxLength = 50
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(121, 20)
        Me.TBApellido.TabIndex = 2
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(79, 54)
        Me.TBNombre.MaxLength = 50
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre.TabIndex = 1
        '
        'TBID_Cliente
        '
        Me.TBID_Cliente.Location = New System.Drawing.Point(79, 28)
        Me.TBID_Cliente.MaxLength = 5
        Me.TBID_Cliente.Name = "TBID_Cliente"
        Me.TBID_Cliente.Size = New System.Drawing.Size(30, 20)
        Me.TBID_Cliente.TabIndex = 0
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHKEliminar)
        Me.GroupBox2.Controls.Add(Me.LblInexistente)
        Me.GroupBox2.Controls.Add(Me.BTNEliminar)
        Me.GroupBox2.Controls.Add(Me.TBBuscar)
        Me.GroupBox2.Controls.Add(Me.CBBuscar)
        Me.GroupBox2.Controls.Add(Me.Grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 355)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de de los clientes"
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
        Me.CBBuscar.Location = New System.Drawing.Point(35, 19)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(177, 21)
        Me.CBBuscar.TabIndex = 1
        Me.CBBuscar.Text = "Dni"
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
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TBFlag
        '
        Me.TBFlag.Location = New System.Drawing.Point(291, 66)
        Me.TBFlag.Name = "TBFlag"
        Me.TBFlag.Size = New System.Drawing.Size(39, 20)
        Me.TBFlag.TabIndex = 2
        Me.TBFlag.Text = "0"
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 456)
        Me.Controls.Add(Me.TBFlag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCliente"
        Me.Text = "Listado de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents BTNCancelar As System.Windows.Forms.Button
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BTNEditar As System.Windows.Forms.Button
    Friend WithEvents BTNNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents BTNGuardar As System.Windows.Forms.Button
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents TBFlag As System.Windows.Forms.TextBox
End Class
