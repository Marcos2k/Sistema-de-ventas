Public Class FrmCliente

    Dim Tabla As New DataTable 'variable que guarda los datos del procedimiento mostrar
    Private Sub Mostrar()
        'Muestra la tabla de la BD
        Try
            Dim Funcion As New FCliente 'crea un objeto en la clase FCliente
            Tabla = Funcion.Mostrar_Cliente 'carga el procedimiento a la tabla 

            Grilla.Columns.Item("ColEliminar").Visible = False 'Oculta la columna Eliminar

            If Tabla.Rows.Count <> 0 Then 'Pregunta: Si la tabla tiene filas que sean distinta de cero entonces
                Grilla.DataSource = Tabla 'Datasource : Fuente de datos = Tabla
                TBBuscar.Enabled = True
                Grilla.ColumnHeadersVisible = True 'Cabezales de la columna habilitados
                LblInexistente.Visible = False 'Oculta etiqueta
            Else
                Grilla.DataSource = Nothing
                TBBuscar.Enabled = False
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True 'Oculta etiqueta
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try
        'propiedades de los botones
        BTNNuevo.Visible = True
        BTNEditar.Visible = False

        Buscar() 'llama al procedimiento

    End Sub

    Private Sub Buscar()
        Try
            Dim DS As New DataSet 'conjunto de tablas
            DS.Tables.Add(Tabla.Copy) 'agrego la Tabla al data set usando la propiedad "Copy"

            Dim DV As New DataView(DS.Tables(0)) 'averiguar para que sirve un Dataview, DataView = Vista de datos
            DV.RowFilter = CBBuscar.Text & " like'" & TBBuscar.Text & "%'" 'filtra las filas en base Combo de busqueda comparando con el "Like" la caja de texto de busqueda

            If DV.Count <> 0 Then
                LblInexistente.Visible = False
                Grilla.DataSource = DV

                Ocultar_columnas()
            Else
                LblInexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try
    End Sub

    Private Sub Ocultar_columnas()
        Grilla.Columns(1).Visible = False 'oculta la columna en este caso seria la que muestre el "ID" 
    End Sub

    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombo()
        Mostrar()
        TBID_Cliente.Enabled = False
        TBFlag.Visible = False
    End Sub

    Private Sub CargarCombo()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("Nombre")
        CBBuscar.Items.Add("Apellido")
        CBBuscar.Items.Add("Dni")
        CBBuscar.Items.Add("Telefono")
    End Sub

    Private Sub TBNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TBNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del cliente")
        End If
    End Sub

    Private Sub TBApellido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TBApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el apellido del cliente")
        End If
    End Sub

    Private Sub TBDireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TBDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese la dirección del cliente")
        End If
    End Sub

    Private Sub TBTelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TBTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el telefono del cliente")
        End If
    End Sub

    Private Sub TBDni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TBDni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el documento del cliente")
        End If
    End Sub

    
    Public Sub Limpiar()
        BTNEditar.Visible = False
        BTNGuardar.Visible = True
        TBID_Cliente.Text = ""
        TBNombre.Text = ""
        TBApellido.Text = ""
        TBDireccion.Text = ""
        TBTelefono.Text = ""
        TBDni.Text = ""
    End Sub
    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click 
        Try
            If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDireccion.Text <> "" And TBTelefono.Text <> "" And TBDni.Text <> "" Then
                Dim Dato As New VCliente 'Creamos un objeto de clase VCliente
                Dim Funcion As New FCliente 'Creamos un objeto de la clase FCliente

                'pasamos valores
                Dato.GNombre = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                Dato.GApellido = TBApellido.Text
                Dato.GDireccion = TBDireccion.Text
                Dato.GTelefono = TBTelefono.Text
                Dato.GDni = TBDni.Text

                If Funcion.Insertar_Cliente(Dato) Then
                    MessageBox.Show("Cliente registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error al registrar cliente, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Campos incompletos, asegurese de llenarlos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNuevo.Click
        Limpiar() 'limpia los campos
        Mostrar() 'llena la tabla
    End Sub

    Private Sub Grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'este metodo se obtiene dando click sobre el DataGridView y seleccionando la propiedad "CellClick" 
        'es decir cuando le hagamos click un item especifico se ejecutará
        TBID_Cliente.Text = Grilla.SelectedCells.Item(1).Value 'Sintaxis: Objeto.Propiedad = DatagridView.CeldaSeleccionada.item("expresado en numero).Value
        TBNombre.Text = Grilla.SelectedCells.Item(2).Value
        TBApellido.Text = Grilla.SelectedCells.Item(3).Value
        TBDireccion.Text = Grilla.SelectedCells.Item(4).Value
        TBTelefono.Text = Grilla.SelectedCells.Item(5).Value
        TBDni.Text = Grilla.SelectedCells.Item(6).Value
        'habilta y deshabilta controles
        BTNEditar.Visible = True
        BTNGuardar.Visible = False
    End Sub



    Private Sub BTNEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEditar.Click
        'Declaramos un variable "Resultado" para hacer una pregunta si en verdad quiere modificar un dato
        Dim Resultado As DialogResult 'La clase/tipo DialogResultado, hace refencia al cuadro emergente de dialogo con el usuario

        'En la variable Resultado cargamos/guardamos la respuesta
        Resultado = MessageBox.Show("¿Realmente deseas editar datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Declaro condicional
        If Resultado = DialogResult.OK Then 'Si le damos click al boton OK procede, en caso de Cancelar no hace nada
            Try
                If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDireccion.Text <> "" And TBTelefono.Text <> "" And TBDni.Text <> "" And TBID_Cliente.Text <> "" Then
                    Dim Dato As New VCliente 'Creamos un objeto de clase VCliente
                    Dim Funcion As New FCliente 'Creamos un objeto de la clase FCliente

                    'pasamos valores
                    Dato.GID_Cliente = TBID_Cliente.Text
                    Dato.GNombre = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                    Dato.GApellido = TBApellido.Text
                    Dato.GDireccion = TBDireccion.Text
                    Dato.GTelefono = TBTelefono.Text
                    Dato.GDni = TBDni.Text

                    If Funcion.Editar_Cliente(Dato) Then
                        MessageBox.Show("Cliente modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar cliente, intente nuevamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Campos incompletos, asegurese de llenarlos por favor", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CHKEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKEliminar.CheckedChanged
        'Pregunta si el Checkbox esta selececionado
        'Sintaxis: Checkbox.Checkstate = CheckState.Checked
        If CHKEliminar.CheckState = CheckState.Checked Then
            Grilla.Columns.Item("ColEliminar").Visible = True
        Else
            Grilla.Columns.Item("ColEliminar").Visible = False
        End If
    End Sub

    Private Sub Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Metodo para ocultar o mostrar la grilla eliminar, cuando el checkbox se elige muestra la Columna "Eliminar"
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas eliminar los clientes seleccionados?", "Eliminar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                'bucle FOR para eliminar los items seleccionados
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then 'estudiar este algoritmo
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Cliente").Value)

                        Dim VDB As New VCliente
                        Dim Funcion As New FCliente

                        VDB.GID_Cliente = Onekey

                        If Funcion.Eliminar_Cliente(VDB) Then
                            'realiza las operaciones de la funcion Eliminar_Cliente desde la clase "FCliente"
                            MessageBox.Show("Cliente eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("El cliente no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("La eliminacion de registros fue cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mostrar()
        End If
        Call Limpiar()
    End Sub

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        If TBFlag.Text = "1" Then
            FrmVenta.TBID_Cliente.Text = Grilla.SelectedCells.Item(1).Value
            FrmVenta.TBNombre_Cliente.Text = Grilla.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub
End Class