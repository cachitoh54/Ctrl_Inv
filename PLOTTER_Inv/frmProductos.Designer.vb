﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Revisado_II_PDataSet = New PLOTTER_Inv.Revisado_II_PDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cnnBD = New System.Data.OleDb.OleDbConnection()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Revisado_II_PDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Revisado_II_PDataSet
        '
        'Revisado_II_PDataSet
        '
        Me.Revisado_II_PDataSet.DataSetName = "Revisado_II_PDataSet"
        Me.Revisado_II_PDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PLOTTER_Inv.rptProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(904, 676)
        Me.ReportViewer1.TabIndex = 0
        '
        'cnnBD
        '
        Me.cnnBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\BD_Imag\Revisado_D.accdb"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 676)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Inventario de Productos"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Revisado_II_PDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Revisado_II_PDataSet As PLOTTER_Inv.Revisado_II_PDataSet
    Friend WithEvents cnnBD As System.Data.OleDb.OleDbConnection
End Class
