Public Class FrmBackup

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Funcion As New FBackup
        Try
            If Funcion.Backup_Base Then
                MessageBox.Show("Respaldo realizado con exito", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo realizar el respaldo, intenta nuevamente", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class