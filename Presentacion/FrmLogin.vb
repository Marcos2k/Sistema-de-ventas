Public Class FrmLogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = TimeOfDay
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblHora.Text = TimeOfDay
    End Sub

    Private Sub BTNSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSalir.Click
        Me.Close()
    End Sub

    Private Sub BTNIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIngresar.Click

        Dim Dato As New VUsuario
        Dim Funcion As New FUsuarios
        Try
            Dato.GLogin = TBUsuario.Text 'Introducimos el Usuario
            Dato.GPassword = TBPassword.Text 'Introducciomos la contraseña

            If Funcion.Validar_Usuario(Dato) = True Then
                FrmInicio.ShowDialog()
                Me.Hide() 'Se esconde el formulario
            Else
                MessageBox.Show("Datos incorrectos, ingrese nuevamente", "Acceso denegado")
                TBUsuario.Text = ""
                TBPassword.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class