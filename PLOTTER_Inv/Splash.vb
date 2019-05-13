Public Class Splash
    Dim Contador As Byte = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 100 Then
            Contador = Contador + 1
            ProgressBar1.Value = Contador
            lblBarra.Text = "Cargando el Sistema al " & ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Usuario.Show()
        End If
    End Sub
End Class