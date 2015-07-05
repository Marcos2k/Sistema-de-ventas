Imports System.Data.SqlClient 'importamos libreria para trabajar con SQL Server
Public Class Conexion

    Dim Cadena As String = ("Data source=(local);initial catalog=Sisventas;integrated security=true") 'cadena de conexion 
    Protected Conector As New SqlConnection 'variable para el conectarse

    Public ID_usuario As Integer

    Protected Function Conectar() 'funcion para conectarse a la BD 
        Try
            Conector = New SqlConnection(Cadena) 'declaramos la variable "Conexion" para poder asociarse a la base de datos usando los parametros de la cadena
            Conector.Open() 'abre la conexion
            Return True ' como es un funcion retorna verdadero en caso de conectarse con exito
        Catch ex As Exception 'en caso de error :
            MsgBox(ex.Message) 'mensaje de aviso del posible fallo
            Return False 'retorna falso por que no se conecto
        End Try
    End Function

    Protected Function Desconectar() 'funcion para desconectarse a la BD 
        Try
            'pregunta "Si en caso de que el estado de la conexion sea "abierto"", si es asi esta se cierra y confirma con un "True"
            If Conector.State = ConnectionState.Open Then
                Conector.Close() 'cierra la conexion
                Return True 'confirma  y retorna verdadero
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'mensaje de aviso del posible fallo
            Return False 'retorna falso por que no se conecto
        End Try
    End Function
End Class
