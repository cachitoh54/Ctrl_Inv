Public Class Reports

    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        Call ErrorPri()
        Try
            If Seleccion = 1 Then
                If txtfechaI.MaskFull = False Or txtfechaF.MaskFull = False Then
                    MsgBox("Los campos Fecha no debe" & Chr(13) &
                           "estar vacios.", MsgBoxStyle.Exclamation, "Atención")
                Else

                    If CDate(Me.txtfechaI.Text) > CDate(Me.txtfechaF.Text) Then
                        Call Erro()
                    Else
                        Fecha.FechaI = Me.txtfechaI.Text
                        Fecha.FechaF = Me.txtfechaF.Text
                        frmEntDev.Show()
                    End If
                End If
                End If
                If Seleccion = 2 Then
                If txtfechaI.MaskFull = False Or txtfechaF.MaskFull = False Then
                    MsgBox("Los campos Fecha no debe" & Chr(13) &
                           "estar vacios.", MsgBoxStyle.Exclamation, "Atención")
                Else
                    If CDate(Me.txtfechaI.Text) > CDate(Me.txtfechaF.Text) Then
                        Call Erro()
                    Else
                        Fecha.FechaI = Me.txtfechaI.Text
                        Fecha.FechaF = Me.txtfechaF.Text
                        frmFactura.Show()
                    End If
                End If
                End If
            If Seleccion = 3 Then
                If txtfechaI.MaskFull = False Or txtfechaF.MaskFull = False Then
                    frmProductos.Show()
                End If
            End If
            Me.txtfechaI.Clear()
            Me.txtfechaF.Clear()
            Me.txtfechaI.Select()
            'Me.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Erro()
        MsgBox("La fecha de inicio no puede" & Chr(13) &
               "ser mayor a la fecha final.", MsgBoxStyle.Exclamation, "Atención")
        Me.txtfechaI.Clear()
        Me.txtfechaF.Clear()
        Me.txtfechaI.Select()
    End Sub

    Private Sub Reports_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call ErrorPri()
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Menú.Show()
        ElseIf ID_ACCESO = 2 Then
            Me.Visible = False
            Menú.Show()
        ElseIf ID_ACCESO = 3 Then
            Me.Visible = False
            Menú.Show()
        End If
    End Sub
    Private Sub Reports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ErrorPri()
        If ID_ACCESO = 1 Then
        End If
        If ID_ACCESO = 3 Then
        End If
        Me.txtfechaI.Text = "00/00/0000"
        Me.txtfechaF.Text = "00/00/0000"
        Me.txtfechaI.ValidatingType = GetType(System.DateTime)
        Me.txtfechaF.ValidatingType = GetType(System.DateTime)
        Me.ToolFecha.IsBalloon = True

        Me.txtfechaI.Clear()
        Me.txtfechaF.Clear()
        Me.txtfechaI.Visible = False
        Me.txtfechaF.Visible = False
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.gboxFechas.Visible = False
        Me.gboxBtn.Location = New Point(12, 128)
        Me.Size = New Size(Width:=437, Height:=270)
    End Sub

    Private Sub rbEnDe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbEnDe.CheckedChanged
        Call ErrorPri()
        Seleccion = 1
        Me.txtfechaI.Visible = True
        Me.txtfechaF.Visible = True
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.gboxFechas.Visible = True
        Me.gboxBtn.Location = New Point(12, 210)
        Me.Size = New Size(Width:=437, Height:=350)
        Me.txtfechaI.Select()
    End Sub

    Private Sub rbInFa_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbInFa.CheckedChanged
        Call ErrorPri()
        Seleccion = 2
        Me.txtfechaI.Visible = True
        Me.txtfechaF.Visible = True
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.gboxFechas.Visible = True
        Me.gboxBtn.Location = New Point(12, 210)
        Me.Size = New Size(Width:=437, Height:=350)
        Me.txtfechaI.Select()
    End Sub

    Private Sub rbPro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPro.CheckedChanged
        Call ErrorPri()
        Seleccion = 3
        Me.txtfechaI.Visible = False
        Me.txtfechaF.Visible = False
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.gboxFechas.Visible = False
        Me.gboxBtn.Location = New Point(12, 128)
        Me.Size = New Size(Width:=437, Height:=270)
        Me.btnReport.Focus()
    End Sub

    Private Sub btnirmenu_Click(sender As System.Object, e As System.EventArgs) Handles btnirmenu.Click
        Call ErrorPri()
        If ID_ACCESO = 1 Then
            rbEnDe.Checked = True
            Menú.Show()
        End If

        If ID_ACCESO = 3 Then
            rbEnDe.Checked = True
            Menú.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btncerrar.Click
        Call ErrorPri()
        If MessageBox.Show("¿Desea Salir del Sistema?" & vbCrLf & vbCrLf & _
                      Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                      MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtfechaI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfechaI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtfechaI, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtfechaI, "Este campo sólo" & Chr(13) & _
                                           "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtfechaF.Focus()
        End If
    End Sub

    Private Sub txtfechaF_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfechaF.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtfechaF, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtfechaF, "Este campo sólo" & Chr(13) & _
                                           "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnReport.PerformClick()
        End If
    End Sub
    Sub ErrorPri()
        Errores.SetError(Me.txtfechaI, Nothing)
        Errores.SetError(Me.txtfechaF, Nothing)
    End Sub

    Private Sub btnlimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnlimpiar.Click
        Me.txtfechaI.Clear()
        Me.txtfechaF.Clear()
        Me.txtfechaI.Select()
    End Sub

    Private Sub txtfechaI_TypeValidationCompleted(sender As System.Object, e As System.Windows.Forms.TypeValidationEventArgs) Handles txtfechaI.TypeValidationCompleted
        If Me.txtfechaI.MaskFull = True Then
            If (Not e.IsValidInput) Then
                Me.ToolFecha.ToolTipTitle = "Invalid Date"
                Me.ToolFecha.Show("La Fecha que ha ingresado es incorrecta!", Me.txtfechaI, 0, -20, 4000)
                Me.txtfechaI.Clear()
                Me.txtfechaI.Select()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtfechaF_TypeValidationCompleted(sender As System.Object, e As System.Windows.Forms.TypeValidationEventArgs) Handles txtfechaF.TypeValidationCompleted
        If Me.txtfechaF.MaskFull = True Then
            If (Not e.IsValidInput) Then
                Me.ToolFecha.ToolTipTitle = "Dato Invalido"
                Me.ToolFecha.Show("La Fecha que ha ingresado es incorrecta!", Me.txtfechaI, 0, -20, 4000)
                Me.txtfechaF.Clear()
                Me.txtfechaF.Select()
                e.Cancel = True
            End If
        End If
    End Sub
End Class