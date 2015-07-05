Imports System.Data.SqlClient 'importamos libreria para trabajar con SQL Server
Public Class FCategoria
    Inherits Conexion 'hereda todos los atributos de la clase "Conexion" asi de esta forma podemos utilizar funciones de ella

    Dim Comando As New SqlCommand

    Public Function Mostrar_Categoria() As DataTable
        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Mostrar_Categoria") 'proceso almacenado en la BD SQL Server 
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

    Public Function Insertar_Categoria(ByVal Dato As VCategoria) As Boolean
        'lo declaramos tipo Boolean asi nos devuelve un True si ha insertado un dato,en caso de NO insertar devuelve un False

        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Insertar_Categoria") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector  'pasa la varible conector igual/similar que en ADO.net 

            'pasamos los parametros al comando -Sintaxis : Comando.Parametros.Agregarconvalor("@Parametro", variable.G)-
            Comando.Parameters.AddWithValue("@Nombre_Categoria", Dato.GNombre_Categoria)
            
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

    Public Function Editar_Categoria(ByVal Dato As VCategoria) As Boolean
        'Al declarar la variable "Dato" la usamos como referencia de clase VCliente
        'lo declaramos tipo Boolean asi nos devuelve un True si ha insertado un dato,en caso de NO insertar devuelve un False

        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Editar_Categoria") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector  'pasa la varible conector igual/similar que en ADO.net 

            'pasamos los parametros al comando -Sintaxis : Comando.Parametros.Agregarconvalor("@Parametro", variable.G)-
            Comando.Parameters.AddWithValue("@ID_Categoria", Dato.GID_Categoria)
            Comando.Parameters.AddWithValue("@Nombre_Categoria", Dato.GNombre_Categoria)

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

    Public Function Eliminar_Categoria(ByVal Dato As VCategoria) As Boolean
        Try
            Conectar() 'Llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Eliminar_Categoria") 'Proceso almacenado en la BD SQL Server
            Comando.CommandType = CommandType.StoredProcedure 'selecciona proceso almacenado
            Comando.Connection = Conector 'pasa la varible conector igual/similar que en ADO.net

            'paso el parametro del comando pero sin usar el "AddWithValue" cambiandolo por "Add" solamente
            'Sintaxis : Comando.Parametros.Agregar("@VariableSql", SqlDbType.Nvarchar,(longitud en numeros)).Valor = Variable dato.MetodoGetter
            Comando.Parameters.Add("@ID_Categoria", SqlDbType.NVarChar, 50).Value = Dato.GID_Categoria

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
