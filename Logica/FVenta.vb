Imports System.Data.SqlClient 'Importamos libreria SQL Server 
Public Class FVenta
    Inherits Conexion 'hereda todos los atributos de la clase "Conexion" asi de esta forma podemos utilizar funciones de ella

    Dim Comando As New SqlCommand

    Public Function Mostrar_Ventas() As DataTable 'usamos el datatable para mostrar las ventas
        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Mostrar_Ventas") 'proceso almacenado en la BD SQL Server 
            Comando.CommandType = CommandType.StoredProcedure 'seleciona procedimiento almacenado
            Comando.Connection = Conector    ' pasa la varible conector igual/similar que en ADO.net 

            If Comando.ExecuteNonQuery Then 'Si el Comando ejecuta la Consulta
                Dim Tabla As New DataTable 'creamos el objeto/variable de la tabla
                Dim Adaptador As New SqlDataAdapter(Comando) 'paso el comando al Adaptador 
                Adaptador.Fill(Tabla) 'Fill = Llenar en Inglés 
                Return Tabla 'Devuelve la tabla llena en caso de ser verdadero 
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar() 'una vez realizada la tarea me desconecto de la BD 
        End Try
    End Function

    Public Function Insertar_Venta(ByVal Dato As VVenta) As Boolean
        'lo declaramos tipo Boolean asi nos devuelve un True si ha insertado un dato,en caso de NO insertar devuelve un False

        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Insertar_Venta") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector  'pasa la varible conector igual/similar que en ADO.net 

            'pasamos los parametros al comando -Sintaxis : Comando.Parametros.Agregarconvalor("@Parametro", variable.G)-
            Comando.Parameters.AddWithValue("@ID_Cliente", Dato.GID_Cliente)
            Comando.Parameters.AddWithValue("@Fecha_venta", Dato.GFecha_Venta)
            Comando.Parameters.AddWithValue("@Tipo_Documento", Dato.GTipo_Documento)
            Comando.Parameters.AddWithValue("@Nro_Documento", Dato.GNro_Documento)

            If Comando.ExecuteNonQuery Then 'ejecuto el comando
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
            Return False
        Finally
            Desconectar()
        End Try

    End Function

    Public Function Editar_Venta(ByVal Dato As VVenta) As Boolean
        'Al declarar la variable "Dato" la usamos como referencia de clase VCliente
        'lo declaramos tipo Boolean asi nos devuelve un True si ha insertado un dato,en caso de NO insertar devuelve un False

        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Editar_Venta") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector  'pasa la varible conector igual/similar que en ADO.net 

            'pasamos los parametros al comando -Sintaxis : Comando.Parametros.Agregarconvalor("@Parametro", variable.G)-
            Comando.Parameters.AddWithValue("@ID_Venta", Dato.GID_Venta)
            Comando.Parameters.AddWithValue("@ID_Cliente", Dato.GID_Cliente)
            Comando.Parameters.AddWithValue("@Fecha_venta", Dato.GFecha_Venta)
            Comando.Parameters.AddWithValue("@Tipo_Documento", Dato.GTipo_Documento)
            Comando.Parameters.AddWithValue("@Nro_Documento", Dato.GNro_Documento)

            If Comando.ExecuteNonQuery Then 'ejecuto el comando
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Eliminar_Venta(ByVal Dato As VVenta) As Boolean
        Try
            Conectar() 'Llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Eliminar_Venta") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector 'pasa la varible conector igual/similar que en ADO.net

            'paso el parametro del comando pero sin usar el "AddWithValue" cambiandolo por "Add" solamente
            'Sintaxis : Comando.Parametros.Agregar("@VariableSql", SqlDbType.Nvarchar,(longitud en numeros)).Valor = Variable dato.MetodoGetter
            Comando.Parameters.Add("@ID_Venta", SqlDbType.NVarChar, 50).Value = Dato.GID_Venta

            If Comando.ExecuteNonQuery Then 'Ejecuto el comando

                Return True 'si se ejecuta con exito muestra el mensaje
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
