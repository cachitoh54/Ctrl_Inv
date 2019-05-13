Public Class frmFactura

    Private Sub frmFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.dtpfechaI.Text = Fecha.FechaI
        Me.dtpfechaF.Text = Fecha.FechaF
        cnnBD.Open()
        Try
            Dim fecha = Format(Me.dtpfechaI.Value, "yyyy/MM/dd")
            Dim fecha2 = Format(Me.dtpfechaF.Value, "yyyy/MM/dd")

            Dim stSQL As String
            stSQL = "SELECT F.Nro_Factura, F.Fecha, Pr.Cod_Proveedor, PC.Cod_Productos, PC.Precio_empaque, PC.Precio_unidad, F.Iva, PC.Cantidad, PC.Peso, PC.Transporte FROM Productos Pd INNER JOIN ((Proveedor Pr INNER JOIN Factura_Compra F ON Pr.Cod_Proveedor = F.Cod_Proveedor) INNER JOIN Producto_Compra PC ON F.Nro_Factura = PC.Nro_Factura) ON Pd.Cod_Productos = PC.Cod_Productos WHERE " & _
             "F.Fecha Between #" & fecha & "# and #" & fecha2 & "#"
            Dim cmd As New OleDb.OleDbDataAdapter(stSQL, cnnBD)
            Revisado_II_PDataSet.Productos.Clear()
            Revisado_II_PDataSet.Factura_Compra.Clear()
            Revisado_II_PDataSet.Producto_Compra.Clear()
            cmd.Fill(Revisado_II_PDataSet, "Producto_Compra")
            Me.ReportViewer1.RefreshReport()
            Reports.txtfechaI.Clear()
            Reports.txtfechaF.Clear()
            'WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class