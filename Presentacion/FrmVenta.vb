Public Class FrmVenta
    Dim Tabla As New DataTable
    Private Sub FrmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub Mostrar()
        'Muestra la tabla de la BD
        Try
            Dim Funcion As New FVenta 'crea un objeto en la clase FVenta
            Tabla = Funcion.Mostrar_Ventas 'carga el procedimiento a la tabla 

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
        Grilla.Columns(2).Visible = False
    End Sub

    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar()
        TBID_Venta.Enabled = False
        TBID_Cliente.Enabled = False
        TBNombre_Cliente.Enabled = False
    End Sub

    Public Sub Limpiar()
        BTNEditar.Visible = False
        BTNGuardar.Visible = True
        TBID_Venta.Text = ""
        TBID_Cliente.Text = ""
        DTFecha.Text = Date.Now
        TBNombre_Cliente.Text = ""
        TBNro_Documento.Text = ""
    End Sub
    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click
        Try
            If Me.ValidateChildren = True And TBID_Cliente.Text <> "" And DTFecha.Text <> "" And TBNombre_Cliente.Text <> "" And TBNro_Documento.Text <> "" And CB_Tipo_Documento.Text <> "" Then
                Dim Dato As New VVenta 'Creamos un objeto de clase VVenta
                Dim Funcion As New FVenta 'Creamos un objeto de la clase FVenta

                'pasamos valores
                Dato.GID_Cliente = TBID_Cliente.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                Dato.GFecha_Venta = DTFecha.Text
                Dato.GTipo_Documento = CB_Tipo_Documento.Text
                Dato.GNro_Documento = TBNro_Documento.Text


                If Funcion.Insertar_Venta(Dato) Then
                    MessageBox.Show("Venta registrada con exito, vamos a añadir productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                    Cargar_Detalle()
                Else
                    MessageBox.Show("Error al registrar Venta, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        TBID_Venta.Text = Grilla.SelectedCells.Item(1).Value 'Sintaxis: Objeto.Propiedad = DatagridView.CeldaSeleccionada.item("expresado en numero).Value
        TBID_Cliente.Text = Grilla.SelectedCells.Item(2).Value
        TBNombre_Cliente.Text = Grilla.SelectedCells.Item(3).Value
        DTFecha.Text = Grilla.SelectedCells.Item(5).Value
        CB_Tipo_Documento.Text = Grilla.SelectedCells.Item(6).Value
        TBNro_Documento.Text = Grilla.SelectedCells.Item(7).Value
        'habilta y deshabilta controles
        BTNEditar.Visible = True
        BTNGuardar.Visible = False
    End Sub



    Private Sub BTNEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEditar.Click
        'Declaramos un variable "Resultado" para hacer una pregunta si en verdad quiere modificar un dato
        Dim Resultado As DialogResult 'La clase/tipo DialogResultado, hace refencia al cuadro emergente de dialogo con el usuario

        'En la variable Resultado cargamos/guardamos la respuesta
        Resultado = MessageBox.Show("¿Realmente deseas editar datos de la venta?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Declaro condicional
        If Resultado = DialogResult.OK Then 'Si le damos click al boton OK procede, en caso de Cancelar no hace nada
            Try
                If Me.ValidateChildren = True And TBID_Cliente.Text <> "" And TBID_Venta.Text <> "" And DTFecha.Text <> "" And TBNombre_Cliente.Text <> "" And TBNro_Documento.Text <> "" And CB_Tipo_Documento.Text <> "" Then
                    Dim Dato As New VVenta 'Creamos un objeto de clase VVenta
                    Dim Funcion As New FVenta 'Creamos un objeto de la clase FVenta

                    'pasamos valores
                    Dato.GID_Venta = TBID_Venta.Text
                    Dato.GID_Cliente = TBID_Cliente.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                    Dato.GFecha_Venta = DTFecha.Text
                    Dato.GTipo_Documento = CB_Tipo_Documento.Text
                    Dato.GNro_Documento = TBNro_Documento.Text

                    If Funcion.Editar_Venta(Dato) Then
                        MessageBox.Show("Venta modificada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar venta, intente nuevamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Campos incompletos, asegurese de llenarlos por favor", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub TBBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub Cargar_Detalle()
        'Comenzamos a cargar los detalles de la venta del cliente
        'SelectedCells= Toma el valor de la celda seleccionada
        'El Item 4 representa el Dni, dato que no me hace falta usar , por eso no lo envio.
        FrmDetalle_Venta.TBID_Venta.Text = Grilla.SelectedCells.Item(1).Value
        FrmDetalle_Venta.TBID_Cliente.Text = Grilla.SelectedCells.Item(2).Value
        FrmDetalle_Venta.TBNombre_Cliente.Text = Grilla.SelectedCells.Item(3).Value
        FrmDetalle_Venta.DTFecha.Text = Grilla.SelectedCells.Item(5).Value
        FrmDetalle_Venta.CB_Tipo_Documento.Text = Grilla.SelectedCells.Item(6).Value
        FrmDetalle_Venta.TBNro_Documento.Text = Grilla.SelectedCells.Item(7).Value

        FrmDetalle_Venta.ShowDialog() 'muestro el sig. formulario , en este caso el "Detalle de Venta"
    End Sub
   
    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        Cargar_Detalle()
    End Sub

    Private Sub BTNEncontrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEncontrar.Click
        FrmCliente.TBFlag.Text = "1"
        FrmCliente.ShowDialog()
    End Sub

    Private Sub BTNCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancelar.Click
        Dim Resultado As DialogResult
        Dim Resultado2 As DialogResult
        Resultado = MessageBox.Show("¿Realmente deseas salir?", "Saliendo del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Resultado2 = MessageBox.Show("Te pregunto de nuevo,¿Realmente deseas salir?", "Saliendo del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'pregunta si desea salir del formulario
        If Resultado = DialogResult.OK Then
            If Resultado2 = DialogResult.OK Then
                Me.Close()
            End If
        End If

    End Sub
End Class