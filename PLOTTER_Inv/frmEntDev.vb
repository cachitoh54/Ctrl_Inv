Public Class frmEntDev

    Private Sub frmEntDev_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.dtpfechaI.Text = Fecha.FechaI
        Me.dtpfechaF.Text = Fecha.FechaF
        cnnBD.Open()
        Try
            Dim fecha = Format(Me.dtpfechaI.Value, "yyyy/MM/dd")
            Dim fecha2 = Format(Me.dtpfechaF.Value, "yyyy/MM/dd")
            Dim bSQL As String
            bSQL = "SELECT SE.Nro_Orden, SE.Fecha, SE.Cod_empleado, SE.Nombres, SE.Cedula, SD.Cod_Productos,  SD.Descripcion, SD.Cantidad, SD.Devolucion FROM Salida_Entrega SE INNER JOIN Salida_Devolucion SD ON SE.Nro_Orden = SD.Nro_Orden WHERE " & _
            "SE.Fecha Between#" & fecha & "# and #" & fecha2 & "#"
            Dim cmd As New OleDb.OleDbDataAdapter(bSQL, cnnBD)
            Revisado_II_PDataSet.Salida_Entrega.Clear()
            Revisado_II_PDataSet.Salida_Devolucion.Clear()
            cmd.Fill(Revisado_II_PDataSet, "Salida_Devolucion")
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