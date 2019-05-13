Imports System.Data
Imports System.Data.OleDb
Public Class Admi_Usuario
    Private cnnBD As New OleDbConnection
    Private SW As Boolean
    Private Resultado As Boolean
    Private MS As Boolean

    Private Sub Admi_Usuario_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call ErroresPri()
        ID_ACCESO = 1
        Me.Visible = False
        Menú.Show()
    End Sub

    Private Sub Admi_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ID_ACCESO = 1
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        'AbrirConexion()
        Try
            Me.txtId.Text = 1
            Dim stSQL As String
            stSQL = "SELECT * FROM Usuarios WHERE Id_usuario=1"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            dtr.Read()
            Me.txtTacce.Text = dtr("Id_acceso").ToString
            ''''
            Me.txtId.Text = Me.txtId.Text
            Me.txtLogin.Select()
            SW = False
        Catch ex As Exception
            MsgBox("Este Usuario no está Registrado. ", MsgBoxStyle.Information, "Atención")
        End Try
    End Sub
  
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call ErroresPri()
        If txtLogin.Text.Trim = "" Then
            MsgBox("El Campo Usuario no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        If txtpassword.Text.Trim = "" Then
            MsgBox("El Campo Contraseña no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Try
            Dim stSQL As String
            stSQL = "UPDATE Usuarios " & _
                   "SET Usuario='" & Me.txtLogin.Text & "'" & _
                   ", Contrasena='" & Me.txtpassword.Text & "', Cedula='" & Me.txtCI.Text & "'" & _
                   ", Id_acceso=" & Me.txtTacce.Text & ", Cuenta=" & Me.txtCta.Text & "" & _
                   " WHERE Id_usuario=" & Me.txtId.Text & ""
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            If MessageBox.Show("¿Desea Cambiar los Datos Seleccionados?" & vbCrLf & vbCrLf & _
                   Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Me.txtId.Text = Me.txtId.Text
                MsgBox("La Actualización fue Exitosa.", MsgBoxStyle.Information, "Información")
                Me.Close()
                Menú.Show()
            Else
                Me.txtId.Text = 1
                Dim sttQL As String
                sttQL = "SELECT * FROM Usuarios WHERE Id_usuario=1"
                Dim cmd2 As New OleDbCommand(sttQL, cnnBD)
                Dim dtr2 As OleDbDataReader
                dtr2 = cmd2.ExecuteReader
                dtr2.Read()
                Me.txtLogin.Text = dtr2("Usuario").ToString
                Me.txtpassword.Text = dtr2("Contrasena").ToString
                Me.txtCI.Text = dtr2("Cedula").ToString
                Me.txtCta.Text = dtr2("Cuenta").ToString
                Me.txtTacce.Text = dtr2("Id_acceso").ToString
                ''''''
                Me.txtId.Text = Me.txtId.Text
                SW = False
            End If
        Catch ex As Exception
            MsgBox("Uno o más datos ya se encuentran registrados," & Chr(13) & _
                   "revíselos y corrija la información.", MsgBoxStyle.Information, "Atención")
            Me.txtLogin.Select()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Call ErroresPri()
        Me.Hide()
        ID_ACCESO = 1
        Menú.Show()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtId.Text.Trim = "" Then
            MsgBox("El campo Código no Debe estar vacío", MsgBoxStyle.Information, "Información")
            Exit Sub
        End If
        Try
            Dim stSQL As String
            stSQL = "DELETE FROM Usuarios WHERE Id_usuario=" & Me.txtId.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                    Me.txtLogin.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Me.txtId.Text = Me.txtId.Text
            End If
            MsgBox("Los Datos se Eliminaron Exitosamente.", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Call ErroresPri()
        If MessageBox.Show("¿Está seguro que desea Reiniciar" & Chr(13) & _
                           "el del 2do. Administrador?",
                  "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                  MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then

            Try
                Dim Re1, Re2, Re3, Re4, Re5 As String
                Re1 = Me.txtResp1.Text
                Re2 = Me.txtResp2.Text
                Re3 = Me.txtResp3.Text
                Re4 = Me.txtResp4.Text
                Re5 = Me.txtResp5.Text
                Re1 = ""
                Re2 = ""
                Re3 = ""
                Re4 = ""
                Re5 = ""
                Dim stSQL As String
                Me.txtLogin2.Text = "anulado"
                Me.txtpassword2.Text = "0000"
                Me.txtCI2.Text = "Anulado2"
                Me.txtCta2.Text = "22222222"
                stSQL = "UPDATE Usuarios " & _
                       "SET Usuario='" & Me.txtLogin2.Text & "'" & _
                       ", Contrasena='" & Me.txtpassword2.Text & "', Cedula='" & Me.txtCI2.Text & "'" & _
                       ", Cuenta=" & Me.txtCta2.Text & "" & _
                       ", Ask1='" & Re1 & "', Ask2='" & Re2 & "',  Ask3='" & Re3 & "'" & _
                       ",  Ask4='" & Re4 & "',  Ask5='" & Re5 & "'" & _
                       " WHERE Id_usuario=3"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteReader()
                Me.txtId.Text = Me.txtId.Text
                MsgBox("El Reinicio del 2do. Administrador" & Chr(13) & _
                       "se realizó con Éxito.", MsgBoxStyle.Information, "Información")
                Usuario.lbladmin2.Visible = True
                Me.Visible = False
                Menú.Show()
            Catch ex As Exception
                MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Call ErroresPri()
        If MessageBox.Show("¿Desea Salir del Sistem?" & vbCrLf & vbCrLf & _
                    Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            Me.cnnBD.Close()
            End
        Else
            Me.cnnBD.Close()
            Exit Sub
        End If
    End Sub

    Private Sub txtLogin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLogin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtCI.Focus()
        End If
    End Sub
    Private Sub txtCI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        Dim cadena As String = sender.Text
        Dim num As String = "1234567890"
        MS = True
        If Len(cadena) > 0 Then
            num += "."
        End If
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        For Each caracter In num
            If e.KeyChar = caracter Then
                e.Handled = False
                MS = False
                Exit For
            Else
                MS = True
                e.Handled = True
            End If
        Next
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
            MS = False
        End If
        If MS = True Then
            MsgBox("Este campo sólo admite" & Chr(13) & _
                   "Números Enteros y" & Chr(13) & _
                   "puntos y guiones.", MsgBoxStyle.Exclamation, "Atención")

        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtCI.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtCta.Focus()
        End If
    End Sub
    Private Sub txtCta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCta.KeyPress
        Dim cadena As String = sender.Text
        Dim num As String = "1234567890"
        MS = True
        If Len(cadena) > 0 Then
            num += "."
        End If
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        For Each caracter In num
            If e.KeyChar = caracter Then
                e.Handled = False
                MS = False
                Exit For
            Else
                MS = True
                e.Handled = True
            End If
        Next
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
            MS = False
        End If
        If MS = True Then
            MsgBox("Este campo sólo admite" & Chr(13) & _
                   "Números Enteros y" & Chr(13) & _
                   "puntos y guiones.", MsgBoxStyle.Exclamation, "Atención")

        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtCta.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnActualizar.PerformClick()
        End If
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Call ErroresPri()
        If ID_ACCESO = 1 Then
            Me.Hide()
            P_Seguridad.Show()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Call ErroresPri()
        Me.txtLogin.Clear()
        Me.txtpassword.Clear()
        Me.txtCI.Clear()
        Me.txtCta.Clear()
        Me.txtLogin.Select()
    End Sub
    Sub ErroresPri()
        Errores.SetError(Me.txtCI, Nothing)
        Errores.SetError(Me.txtCta, Nothing)
    End Sub
End Class