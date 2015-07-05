Imports System.Data.SqlClient
Public Class FBackup
    'Esta clase se encarga de realizar el backup en la base de datos
    Inherits Conexion

    Dim Comando As New SqlCommand

    Public Function Backup_Base() As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Backup_base")
            Comando.CommandType = CommandType.StoredProcedure 'Indica que es un procedimiento almacenado en la base de datos
            Comando.Connection = Conector 'Establezco la conexion

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

End Class
