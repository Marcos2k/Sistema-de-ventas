Public Class FrmReporteProductos

    Private Sub FrmReporteProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SisVentasDataSet.Mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_productoTableAdapter.Fill(Me.SisVentasDataSet.Mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class