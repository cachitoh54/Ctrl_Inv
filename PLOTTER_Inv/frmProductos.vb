Public Class frmProductos

    Private Sub frmProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cnnBD.Open()
        Try
            Dim sSQL As String
            sSQL = "SELECT * FROM Productos"
            Dim cmd As New OleDb.OleDbDataAdapter(sSQL, cnnBD)
            Revisado_II_PDataSet.Productos.Clear()
            cmd.Fill(Revisado_II_PDataSet, "Productos")
            Me.ReportViewer1.RefreshReport()
            'WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
End Class