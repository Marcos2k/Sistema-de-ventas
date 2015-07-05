Imports System.Data.SqlClient 'Importamos libreria para usar SQL Server 
Public Class FUsuarios
    Inherits Conexion 'Hereda las propiedades de la clase conexion
    Dim Comando As New SqlCommand
    Public Function Validar_Usuario(ByVal Dato As VUsuario)
        Conectar() 'se conecta a la base de datos
        Comando = New SqlCommand("Validar_usuarios")
        Comando.CommandType = CommandType.StoredProcedure
        Comando.Connection = Conector 'establezco la conexion

        Comando.Parameters.AddWithValue("@Login", Dato.GLogin)
        Comando.Parameters.AddWithValue("@Password", Dato.GPassword)

        Dim DR As SqlDataReader 'Declaramos un DataReader

        Try
            DR = Comando.ExecuteReader 'Ejecuta consulta
            If DR.HasRows Then 'Si el DR tiene la fila consultada
                Return True
            Else
                Return False 'no devuelve valor
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar() 'Desconecta de la base de datos
        End Try
    End Function
End Class
