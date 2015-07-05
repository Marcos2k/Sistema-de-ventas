<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteComprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RVVisordeReporte = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SisVentasDataSet = New SisVentas.SisVentasDataSet()
        Me.Generar_ComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Generar_ComprobanteTableAdapter = New SisVentas.SisVentasDataSetTableAdapters.Generar_ComprobanteTableAdapter()
        Me.TBIDVenta = New System.Windows.Forms.TextBox()
        CType(Me.SisVentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Generar_ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RVVisordeReporte
        '
        Me.RVVisordeReporte.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_ComprobanteBindingSource
        Me.RVVisordeReporte.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVVisordeReporte.LocalReport.ReportEmbeddedResource = "SisVentas.RPTComprobante.rdlc"
        Me.RVVisordeReporte.Location = New System.Drawing.Point(0, 0)
        Me.RVVisordeReporte.Name = "RVVisordeReporte"
        Me.RVVisordeReporte.Size = New System.Drawing.Size(924, 449)
        Me.RVVisordeReporte.TabIndex = 0
        '
        'SisVentasDataSet
        '
        Me.SisVentasDataSet.DataSetName = "SisVentasDataSet"
        Me.SisVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Generar_ComprobanteBindingSource
        '
        Me.Generar_ComprobanteBindingSource.DataMember = "Generar_Comprobante"
        Me.Generar_ComprobanteBindingSource.DataSource = Me.SisVentasDataSet
        '
        'Generar_ComprobanteTableAdapter
        '
        Me.Generar_ComprobanteTableAdapter.ClearBeforeFill = True
        '
        'TBIDVenta
        '
        Me.TBIDVenta.Location = New System.Drawing.Point(12, 46)
        Me.TBIDVenta.Name = "TBIDVenta"
        Me.TBIDVenta.Size = New System.Drawing.Size(100, 20)
        Me.TBIDVenta.TabIndex = 1
        '
        'FrmReporteComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 449)
        Me.Controls.Add(Me.TBIDVenta)
        Me.Controls.Add(Me.RVVisordeReporte)
        Me.Name = "FrmReporteComprobante"
        Me.Text = "Reporte de Comprobante"
        CType(Me.SisVentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Generar_ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RVVisordeReporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_ComprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SisVentasDataSet As SisVentas.SisVentasDataSet
    Friend WithEvents Generar_ComprobanteTableAdapter As SisVentas.SisVentasDataSetTableAdapters.Generar_ComprobanteTableAdapter
    Friend WithEvents TBIDVenta As System.Windows.Forms.TextBox
End Class
