Imports System.Data
Imports System.Data.OleDb
Public Class Admin2
    Private cnnBD As New OleDbConnection
    Private SW As Boolean
    Private MS As Boolean

    Private Sub Admin2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cnnBD.Close()
        Call ErroresPri()
        If V22D = True Then
            If My.Settings.ProReg = False Then
                Usuario.Size = New Size(Width:=451, Height:=354)
            Else
                Usuario.Size = New Size(Width:=451, Height:=284)
            End If
            Usuario.Show()
        Else
            If ID_ACCESO = 3 Then
                Menú.Show()
            Else
                If V2D = True Then
                    Usuario.lbladmin2.Visible = False
                    Usuario.Show()
                Else
                    Usuario.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Admin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        ID_ACCESO = 3
        Try
            Me.txtId.Text = 3
            Dim stSQL As String
            stSQL = "SELECT * FROM Usuarios WHERE Id_usuario=3"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            dtr.Read()
            Me.txtTacce.Text = dtr("Id_acceso").ToString
            ''''
            Me.txtId.Text = Me.txtId.Text
            SW = False
        Catch ex As Exception
            MessageBox.Show("Este Usuario no está Registrado!" & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
        Me.txtLogin.Select()
    End Sub

    Private Sub btnact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnact.Click
        Call ErroresPri()
        If txtLogin.Text.Trim = "" Then
            MsgBox("El Campo Usuario no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        If txtpassword.Text.Trim = "" Then
            MsgBox("El Campo Contraseña no puede estar vacío", MsgBoxStyle.Exclamation, "Atención")
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
            If MessageBox.Show("¿Desea Registrar estos Datos?" & vbCrLf & vbCrLf & _
                   Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Me.txtId.Text = Me.txtId.Text
                MsgBox("El Registro se realizó de manera exitosa.", MsgBoxStyle.Information, "Información")
                Me.Close()
                Menú.Close()
                P_Seguridad.Show()
                Usuario.lbladmin2.Visible = False
                V2D = True
            Else
                Me.txtLogin.Clear()
                Me.txtpassword.Clear()
                Me.txtTacce.Clear()
                Me.txtCI.Clear()
                Me.txtCta.Clear()
                Me.txtLogin.Select()
            End If
        Catch ex As Exception
            MsgBox("Uno o más datos ya se encuentran registrados," & Chr(13) & _
                   "revíselos y corrija la información.", MsgBoxStyle.Information, "Atención")
            Me.txtLogin.Select()
        End Try
    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        Call ErroresPri()
        Me.txtLogin.Clear()
        Me.txtpassword.Clear()
        Me.txtCI.Clear()
        Me.txtCta.Clear()
        Me.txtLogin.Select()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Call ErroresPri()
        If ID_ACCESO = 3 Then
            If MessageBox.Show("¿Desea Salir del Sistem?" & vbCrLf & vbCrLf & _
                  Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                  MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                End
            Else
                Exit Sub
            End If
        ElseIf ID_ACCESO = 1 Then
            Me.Close()
        ElseIf ID_ACCESO = 0 Then
            Me.Close()
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
            Me.btnact.PerformClick()
        End If
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Call ErroresPri()
        If ID_ACCESO = 3 Then
            Me.Hide()
            P_Seguridad.Show()
        ElseIf ID_ACCESO = 1 Then
            Me.Hide()
            P_Seguridad.Show()
        End If
    End Sub
    Sub ErroresPri()
        Errores.SetError(Me.txtCI, Nothing)
        Errores.SetError(Me.txtCta, Nothing)
    End Sub
End Class