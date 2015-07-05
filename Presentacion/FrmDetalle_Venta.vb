Public Class FrmDetalle_Venta
    Dim Tabla As New DataTable 'Creamos un tabla en memoria

    Private Sub Bloquear_Controles()
        'Bloquea ciertos controles para que estos no pueda modificarse
        TBID_Venta.Enabled = False
        TBID_Cliente.Enabled = False
        TBNombre_Cliente.Enabled = False
        DTFecha.Enabled = False
        CB_Tipo_Documento.Enabled = False
        TBNro_Documento.Enabled = False
        TBID_Producto.Enabled = False
        TBNombre_Producto.Enabled = False
    End Sub
    Private Sub Llenar_NumericalUpDown_Cantidad()
        'indica el valor maximo y el minimo del control
        NUPCantidad.Maximum = 100000
        NUPCantidad.Minimum = 1
    End Sub
    Private Sub FrmDetalle_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloquear_Controles()
        Llenar_NumericalUpDown_Cantidad()
        Mostrar()
        Uso_del_Tooltip()
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
    Private Sub Mostrar()
        Try
            Dim Funcion As New FDetalle_Venta 'crea un objeto en la clase FCliente
            Tabla = Funcion.Mostrar_Detalle_Venta 'carga el procedimiento a la tabla 

            Grilla.Columns.Item("ColEliminar").Visible = False 'Oculta la columna Eliminar

            If Tabla.Rows.Count <> 0 Then 'Pregunta: Si la tabla tiene filas que sean distinta de cero entonces
                Grilla.DataSource = Tabla 'Datasource : Fuente de datos = Tabla
                Grilla.ColumnHeadersVisible = True 'Cabezales de la columna habilitados
                LblInexistente.Visible = False 'Oculta etiqueta
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True 'Oculta etiqueta
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try
        'propiedades de los botones
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim DS As New DataSet 'conjunto de tablas
            DS.Tables.Add(Tabla.Copy) 'agrego la Tabla al data set usando la propiedad "Copy"

            Dim DV As New DataView(DS.Tables(0)) 'averiguar para que sirve un Dataview, DataView = Vista de datos
            DV.RowFilter = "ID_Venta='" & TBID_Venta.Text & "'"

            If DV.Count <> 0 Then
                LblInexistente.Visible = False
                Grilla.DataSource = DV

                Ocultar_Columnas()
            Else
                LblInexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try
    End Sub
    Private Sub Limpiar()
        'Limpia las campos
        TBID_Producto.Text = ""
        TBNombre_Producto.Text = ""
        TBPrecio_unitario.Text = ""
        NUPCantidad.Value = 1 'hace que vuelvan al valor inicial
        NUPStock.Value = 1
    End Sub
   
    Private Sub Ocultar_Columnas()
        Grilla.Columns(1).Visible = False
        Grilla.Columns(2).Visible = False
        Grilla.Columns(3).Visible = False
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


    Private Sub TBQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBQuitar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas eliminar los articulos de la venta?", "Eliminar articulos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                'bucle FOR para eliminar los items seleccionados
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then 'estudiar este algoritmo
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Detalle").Value)
                        'Onekey= una llave haciendo referencia a PK de la tabla
                        Dim VDB As New VDetalle_Venta
                        Dim Funcion As New FDetalle_Venta

                        VDB.GID_Detalle = Onekey

                        'pasa los valores para aumentar el stock
                        VDB.GID_Producto = Grilla.SelectedCells.Item(3).Value  'Value convierte el valor a un numero o letra
                        VDB.GID_Venta = Grilla.SelectedCells.Item(2).Value
                        VDB.GCantidad = Grilla.SelectedCells.Item(5).Value

                        If Funcion.Eliminar_Detalle_Venta(VDB) Then
                            'realiza las operaciones de la funcion Eliminar_Cliente desde la clase "FCliente"
                            If Funcion.Aumentar_Stock(VDB) Then
                                'Aumenta el stock usando un procedimiento almacenado
                            End If
                            MessageBox.Show("Articulo eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Articulo no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FrmProducto.TBFlag.Text = "1"
        FrmProducto.ShowDialog()
    End Sub

    Private Sub Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Metodo para ocultar o mostrar la grilla eliminar, cuando el checkbox se elige muestra la Columna "Eliminar"
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click
        If Me.ValidateChildren = True And TBID_Producto.Text <> "" And TBNombre_Producto.Text <> "" And TBPrecio_unitario.Text <> "" Then

            Dim Dato As New VDetalle_Venta
            Dim Funcion As New FDetalle_Venta

            Dato.GID_Venta = TBID_Venta.Text
            Dato.GID_Producto = TBID_Producto.Text
            Dato.GCantidad = NUPCantidad.Value
            Dato.GPrecio_Unitario = TBPrecio_unitario.Text

            If Funcion.Insertar_Detalle_Venta(Dato) Then
                If Funcion.Disminuir_Stock(Dato) Then
                    'disminuye el stock
                End If
                MessageBox.Show("Venta realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Mostrar()
                Limpiar()
            Else
                MessageBox.Show("La venta no fue realizada de nuevo,reintente o contacte con el administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Faltan algunos datos por favor completalos", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub NUPCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUPCantidad.ValueChanged
        Dim Cantidad As Double

        Cantidad = NUPCantidad.Value

        If NUPCantidad.Value > NUPStock.Value Then 'Compara si la cantidad a vender es mayor que el stock 
            MessageBox.Show("La cantidad que intentas vender supera el stock", "Error al vender producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BTNAgregar.Enabled = False
            NUPCantidad.Value = NUPStock.Value
        Else
            BTNAgregar.Enabled = True
        End If

        If NUPCantidad.Value = 0 Then
            NUPCantidad.Value = 1
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub

    Private Sub Uso_del_Tooltip()
        ToolTip1.SetToolTip(BtnImprimir, "Imprimir reportes de la compra")
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        FrmReporteComprobante.TBIDVenta.Text = Me.TBID_Venta.Text
        FrmReporteComprobante.ShowDialog()
    End Sub
End Class