Public Class FrmProducto
    Dim Tabla As DataTable

    Private Sub Mostrar()
        'Muestra la tabla de la BD
        Try
            Dim Funcion As New FProducto 'crea un objeto en la clase FCliente
            Tabla = Funcion.Mostrar_Producto 'carga el procedimiento a la tabla 

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

        Buscar() 'busca la categoria correspondiente
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
        TBID_Producto.Enabled = False
        TBNombre_Categoria.Enabled = False
        TBID_Categoria.Enabled = False
        TBFlag.Visible = False 'oculta la "banderita"
    End Sub


    Private Sub BTNCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCargar.Click
        'OFD= Open File Dialog
        If OFD.ShowDialog() = DialogResult.OK Then 'Condiciona: Si OFD muestra un dialogo y el resultado es OK
            PBImagen.BackgroundImage = Nothing 'la imagen de fondo se convierte en Nothing(osea nada)
            PBImagen.Image = New Bitmap(OFD.FileName) 'Picturebox toma la imagen que se le asigna con el OFD
            PBImagen.SizeMode = PictureBoxSizeMode.StretchImage 'El temaño del Picturebox sera igual el tamaño "Strech"
        End If
    End Sub

    Private Sub BTNEliminar_imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar_imagen.Click
        PBImagen.Image = Nothing 'la imagen de fondo se convierte en Nothing(osea nada)
        PBImagen.BackgroundImage = My.Resources.incognita 'busca la imagen predeterminada en la carpeta resources
        PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Limpiar()
        'limpia todos los campos incluso la imagen
        TBID_Producto.Text = ""
        TBID_Categoria.Text = ""
        TBNombre_Categoria.Text = ""
        TBNombre.Text = ""
        TBDescripcion.Text = ""
        TBStock.Text = ""
        TBPrecio_Compra.Text = ""
        TBPrecio_venta.Text = ""
        DTFecha.Text = Date.Now
        'limpia la imagen
        PBImagen.Image = Nothing 'la imagen de fondo se convierte en Nothing(osea nada)
        PBImagen.BackgroundImage = My.Resources.incognita 'busca la imagen predeterminada en la carpeta resources
        PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
        'desahabilta el campo de el nombre de la categoria
        TBNombre_Categoria.Enabled = False
    End Sub
    Private Sub BTNNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNuevo.Click
        Limpiar()
        Mostrar()
        BTNGuardar.Visible = True
    End Sub

    Private Sub BTNGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGuardar.Click
        Try
            If Me.ValidateChildren = True And TBID_Categoria.Text <> "" And TBNombre.Text <> "" And TBDescripcion.Text <> "" And TBStock.Text <> "" And TBPrecio_Compra.Text <> "" And TBPrecio_venta.Text <> "" And DTFecha.Text <> "" Then

                Dim Dato As New VProducto 'Creamos un objeto de clase VProducto
                Dim Funcion As New FProducto 'Creamos un objeto de la clase FProducto

                'pasamos valores
                Dato.GID_Categoria = TBID_Categoria.Text
                Dato.GNombre = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                Dato.GDescripcion = TBDescripcion.Text
                Dato.GStock = TBStock.Text
                Dato.GPrecio_Compra = TBPrecio_Compra.Text
                Dato.GPrecio_Venta = TBPrecio_venta.Text
                Dato.GFecha_Vencimiento = DTFecha.Text
                'Grabando imagen
                'pasamos la imagen 'MS= MemoryStream
                Dim MS As New IO.MemoryStream()

                If PBImagen.Image Is Nothing Then 'Condiciona: Si la imagen no esta en blanco
                    'Var=Variable 'RawFormat= le avisa que formato tiene la imagen
                    PBImagen.Image = My.Resources.incognita
                    PBImagen.Image.Save(MS, PBImagen.Image.RawFormat) 'Sintaxis: PictureBox.image.Save(Var, Picturebox.image.RawFormat)
                Else 'si la imagen esta en blanco
                    PBImagen.Image = New Bitmap(OFD.FileName)
                    PBImagen.Image.Save(MS, PBImagen.Image.RawFormat)
                End If
                'finalmente  grabo la imagen

                Dato.GImagen = MS.GetBuffer

                If Funcion.Insertar_Producto(Dato) Then
                    MessageBox.Show("Producto registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error al registrar producto, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Campos incompletos, asegurese de llenarlos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEditar.Click
        'Declaramos un variable "Resultado" para hacer una pregunta si en verdad quiere modificar un dato
        Dim Resultado As DialogResult 'La clase/tipo DialogResultado, hace refencia al cuadro emergente de dialogo con el usuario

        'En la variable Resultado cargamos/guardamos la respuesta
        Resultado = MessageBox.Show("¿Realmente deseas editar datos del producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Declaro condicional
        If Resultado = DialogResult.OK Then 'Si le damos click al boton OK procede, en caso de Cancelar no hace nada
            Try
                If Me.ValidateChildren = True And TBID_Categoria.Text <> "" And TBNombre.Text <> "" And TBDescripcion.Text <> "" And TBStock.Text <> "" And TBPrecio_Compra.Text <> "" And TBPrecio_venta.Text <> "" And DTFecha.Text <> "" Then
                    Dim Dato As New VProducto 'Creamos un objeto de clase VProducto
                    Dim Funcion As New FProducto 'Creamos un objeto de la clase FProducto

                    'pasamos valores
                    Dato.GID_Producto = TBID_Producto.Text
                    Dato.GID_Categoria = TBID_Categoria.Text
                    Dato.GNombre = TBNombre.Text 'Sintaxis : Objeto.propiedad = Objeto.propiedad
                    Dato.GDescripcion = TBDescripcion.Text
                    Dato.GStock = TBStock.Text
                    Dato.GPrecio_Compra = TBPrecio_Compra.Text
                    Dato.GPrecio_Venta = TBPrecio_venta.Text
                    Dato.GFecha_Vencimiento = DTFecha.Text

                    'Grabando imagen
                    'pasamos la imagen 'MS= MemoryStream
                    Dim MS As New IO.MemoryStream()

                    If PBImagen.Image Is Nothing Then 'Condiciona: Si la imagen no esta en blanco
                        'Var=Variable 'RawFormat= le avisa que formato tiene la imagen
                        PBImagen.Image = My.Resources.incognita
                        PBImagen.Image.Save(MS, PBImagen.Image.RawFormat) 'Sintaxis: PictureBox.image.Save(Var, Picturebox.image.RawFormat)
                    Else 'si la imagen esta en blanco
                        PBImagen.Image = New Bitmap(OFD.FileName)
                        PBImagen.Image.Save(MS, PBImagen.Image.RawFormat)
                    End If
                    'finalmente  grabo la imagen
                    Dato.GImagen = MS.GetBuffer

                    If Funcion.Editar_Producto(Dato) Then
                        MessageBox.Show("Producto modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar producto, intente nuevamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Campos incompletos, asegurese de llenarlos por favor", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Pasamos los datos de la Grilla a las cajas de texto
        TBID_Producto.Text = Grilla.SelectedCells.Item(1).Value
        TBID_Categoria.Text = Grilla.SelectedCells.Item(2).Value
        TBNombre_Categoria.Text = Grilla.SelectedCells.Item(3).Value
        TBNombre.Text = Grilla.SelectedCells.Item(4).Value
        TBDescripcion.Text = Grilla.SelectedCells.Item(5).Value
        TBStock.Text = Grilla.SelectedCells.Item(6).Value
        TBPrecio_Compra.Text = Grilla.SelectedCells.Item(7).Value
        TBPrecio_venta.Text = Grilla.SelectedCells.Item(8).Value
        DTFecha.Text = Grilla.SelectedCells.Item(9).Value

        'metodo para mostrar la imagen
        'I = Imagen
        'MS= MemoryStream
        Try
            'verifica e intenta cargar la imagen si no la tiene muestra el signo incognito
            PBImagen.BackgroundImage = Nothing
            Dim I() As Byte = Grilla.SelectedCells.Item(10).Value
            Dim MS As New IO.MemoryStream(I)

            PBImagen.Image = Image.FromStream(MS)
            PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            PBImagen.Image = My.Resources.incognita
        End Try

        BTNGuardar.Visible = False
        BTNEditar.Visible = True
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

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas eliminar los productos seleccionados?", "Eliminar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                'bucle FOR para eliminar los items seleccionados
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then 'estudiar este algoritmo
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Producto").Value)

                        Dim VDB As New VProducto 'VDB = Varible Data Base
                        Dim Funcion As New FProducto

                        VDB.GID_Producto = Onekey

                        If Funcion.Eliminar_Producto(VDB) Then
                            'realiza las operaciones de la funcion Eliminar_Producto desde la clase "FProducto"
                            MessageBox.Show("Producto eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("El producto no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub BTNEncontrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEncontrar.Click
        FrmCategoria.TBFlag.Text = "1"
        FrmCategoria.ShowDialog()
    End Sub

    Private Sub Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Metodo para ocultar o mostrar la grilla eliminar, cuando el checkbox se elige muestra la Columna "Eliminar"
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub

    
    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        If TBFlag.Text = "1" Then
            FrmDetalle_Venta.TBID_Producto.Text = Grilla.SelectedCells.Item(1).Value
            FrmDetalle_Venta.TBNombre_Producto.Text = Grilla.SelectedCells.Item(4).Value
            FrmDetalle_Venta.NUPStock.Value = Grilla.SelectedCells.Item(6).Value
            FrmDetalle_Venta.TBPrecio_unitario.Text = Grilla.SelectedCells.Item(8).Value

            Me.Close()
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub
End Class