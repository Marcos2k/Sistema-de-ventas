<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteProductos
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SisVentasDataSet = New SisVentas.SisVentasDataSet()
        Me.Mostrar_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_productoTableAdapter = New SisVentas.SisVentasDataSetTableAdapters.Mostrar_productoTableAdapter()
        CType(Me.SisVentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Mostrar_productoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisVentas.RPTProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(924, 449)
        Me.ReportViewer1.TabIndex = 0
        '
        'SisVentasDataSet
        '
        Me.SisVentasDataSet.DataSetName = "SisVentasDataSet"
        Me.SisVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mostrar_productoBindingSource
        '
        Me.Mostrar_productoBindingSource.DataMember = "Mostrar_producto"
        Me.Mostrar_productoBindingSource.DataSource = Me.SisVentasDataSet
        '
        'Mostrar_productoTableAdapter
        '
        Me.Mostrar_productoTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 449)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteProductos"
        Me.Text = "Reporte de Productos"
        CType(Me.SisVentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_productoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SisVentasDataSet As SisVentas.SisVentasDataSet
    Friend WithEvents Mostrar_productoTableAdapter As SisVentas.SisVentasDataSetTableAdapters.Mostrar_productoTableAdapter
End Class
