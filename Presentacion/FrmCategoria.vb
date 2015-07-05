Public Class FrmCategoria
    Dim Tabla As New DataTable
    Private Sub FrmCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar()
        TBID_Categoria.Enabled = False
        TBFlag.Visible = False
    End Sub
    Private Sub Cargar_Combo()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("ID Categoria")
        CBBuscar.Items.Add("Nombre de la categoria")
    End Sub

    Private Sub Mostrar()
        'Muestra la tabla de la BD
        Try
            Dim Funcion As New FCategoria 'crea un objeto en la clase FCategoria
            Tabla = Funcion.Mostrar_Categoria 'carga el procedimiento a la tabla 

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

    Private Sub TBNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then 'Si en el caso que la cantidad de caracteres sea mayor a 0
            'Sintaxis: DirectCast(Sender,TextBox).text.Longitud -Sender:Envio,Length:Longitud-
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la categoria")
        End If
    End Sub
    Public Sub Limpiar()
        BTNEditar.Visible = False
        BTNGuardar.Visible = True
        TBID_Categoria.Text = ""
        TBNombre.Text = ""
    End Sub
    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click
        Try
            If Me.ValidateChildren = True And TBNombre.Text <> "" Then
                Dim Dato As New VCategoria 'Creamos un objeto de clase VCliente
                Dim Funcion As New FCategoria 'Creamos un objeto de la clase FCliente

                'pasamos valores
                Dato.GNombre_Categoria = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad

                If Funcion.Insertar_Categoria(Dato) Then
                    MessageBox.Show("Categoria registrada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error al registrar categoria, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        TBID_Categoria.Text = Grilla.SelectedCells.Item(1).Value 'Sintaxis: Objeto.Propiedad = DatagridView.CeldaSeleccionada.item("expresado en numero).Value
        TBNombre.Text = Grilla.SelectedCells.Item(2).Value
        'habilta y deshabilta controles
        BTNEditar.Visible = True
        BTNGuardar.Visible = False
    End Sub

    Private Sub BTNEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEditar.Click
        'Declaramos un variable "Resultado" para hacer una pregunta si en verdad quiere modificar un dato
        Dim Resultado As DialogResult 'La clase/tipo DialogResultado, hace refencia al cuadro emergente de dialogo con el usuario

        'En la variable Resultado cargamos/guardamos la respuesta
        Resultado = MessageBox.Show("¿Realmente deseas editar datos de la categoria?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Declaro condicional
        If Resultado = DialogResult.OK Then 'Si le damos click al boton OK procede, en caso de Cancelar no hace nada
            Try
                If Me.ValidateChildren = True And TBNombre.Text <> "" Then
                    Dim Dato As New VCategoria 'Creamos un objeto de clase VCliente
                    Dim Funcion As New FCategoria 'Creamos un objeto de la clase FCliente

                    'pasamos valores
                    Dato.GID_Categoria = TBID_Categoria.Text
                    Dato.GNombre_Categoria = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad

                    If Funcion.Editar_Categoria(Dato) Then
                        MessageBox.Show("Categoria modificada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar categoria, intente nuevamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Resultado = MessageBox.Show("Realmente deseas eliminar las categorias seleccionadas?", "Eliminar categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                'bucle FOR para eliminar los items seleccionados
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then 'estudiar este algoritmo
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Categoria").Value)

                        Dim VDB As New VCategoria
                        Dim Funcion As New FCategoria

                        VDB.GID_Categoria = Onekey

                        If Funcion.Eliminar_Categoria(VDB) Then
                            'realiza las operaciones de la funcion Eliminar_Cliente desde la clase "FCategoria"
                            MessageBox.Show("Categoria eliminada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("La categoria no pudo ser eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            FrmProducto.TBID_Categoria.Text = Grilla.SelectedCells.Item(1).Value
            FrmProducto.TBNombre_Categoria.Text = Grilla.SelectedCells.Item(2).Value
            'cierra el formulario
            Me.Close()
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub
End Class