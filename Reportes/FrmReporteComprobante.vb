Public Class FrmReporteComprobante

    Private Sub FrmReporteComprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBIDVenta.Visible = False
            'TODO: esta línea de código carga datos en la tabla 'SisVentasDataSet.Generar_Comprobante' Puede moverla o quitarla según sea necesario.
        
        Try 'En caso de genere conflictos en las llaves primarias o foreneas de la base de datos
            Me.Generar_ComprobanteTableAdapter.Fill(Me.SisVentasDataSet.Generar_Comprobante, ID_Venta:=TBIDVenta.Text)
            Me.RVVisordeReporte.RefreshReport()
        Catch ex As Exception
            Me.RVVisordeReporte.RefreshReport()
        End Try
    End Sub
End Class