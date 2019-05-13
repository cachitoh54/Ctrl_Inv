Imports System.Data
Imports System.Data.OleDb
Public Class P_Seguridad
    Private cnnBD As New OleDbConnection
    Private SW As Boolean
    Private Resultado As Boolean

    Private Sub P_Seguridad_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If V2D = True Then
            Usuario.Show()
        Else
            If ID_ACCESO = 1 Then
                Me.Visible = False
                Admi_Usuario.Show()
            ElseIf ID_ACCESO = 3 Then
                Me.Visible = False
                Admin2.Show()
            End If
        End If
    End Sub
    Private Sub P_Seguridad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        ' AbrirConexion()
        Try
            If ID_ACCESO = 1 Then
                Me.txtId.Text = 1
                Dim stSQL As String
                stSQL = "SELECT * FROM Usuarios WHERE Id_usuario=1"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                Dim dtr As OleDbDataReader
                dtr = cmd.ExecuteReader
                dtr.Read()
                Me.txtResp1.Text = dtr("Ask1").ToString
                Me.txtResp2.Text = dtr("Ask2").ToString
                Me.txtResp3.Text = dtr("Ask3").ToString
                Me.txtResp4.Text = dtr("Ask4").ToString
                Me.txtResp5.Text = dtr("Ask5").ToString
                Me.txtTacce.Text = dtr("Id_acceso").ToString
                ''''''
                Me.txtId.Text = Me.txtId.Text
            End If
            If ID_ACCESO = 3 Then
                Me.txtId.Text = 3
                Dim stSQL As String
                stSQL = "SELECT * FROM Usuarios WHERE Id_usuario=3"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                Dim dtr As OleDbDataReader
                dtr = cmd.ExecuteReader
                dtr.Read()
                Me.txtResp1.Text = dtr("Ask1").ToString
                Me.txtResp2.Text = dtr("Ask2").ToString
                Me.txtResp3.Text = dtr("Ask3").ToString
                Me.txtResp4.Text = dtr("Ask4").ToString
                Me.txtResp5.Text = dtr("Ask5").ToString
                Me.txtTacce.Text = dtr("Id_acceso").ToString
                ''''''
                Me.txtId.Text = Me.txtId.Text
            End If
        Catch ex As Exception
            MsgBox("Este Usuario no está Registrado. ", MsgBoxStyle.Information, "Atención")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim stSQL As String
            stSQL = "UPDATE Usuarios " & _
                   "SET Ask1='" & Me.txtResp1.Text & "', Ask2='" & Me.txtResp2.Text & "', Ask3='" & Me.txtResp3.Text & "'" & _
                   ", Ask4='" & Me.txtResp4.Text & "', Ask5='" & Me.txtResp5.Text & "'" & _
                   " WHERE Id_usuario=" & Me.txtId.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            If MessageBox.Show("¿Desea Guardar estas Respuestas?" & vbCrLf & vbCrLf & _
                   Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Me.txtId.Text = Me.txtId.Text

                MsgBox("Sus Respuestas fueron Registradas.", MsgBoxStyle.Information, "Información")
                If ID_ACCESO = 1 Then
                    If V22D = True Then
                        MsgBox("El Sistema se cerrará automáticamente" & Chr(13) & _
                               "para completar el registro.", MsgBoxStyle.Information, "Información")
                        End
                    Else
                        Me.Close()
                        Admi_Usuario.Close()
                        Menú.Show()
                    End If
                ElseIf ID_ACCESO = 3 Then
                    MsgBox("El Sistema se cerrará automáticamente" & Chr(13) & _
                           "para completar el registro.", MsgBoxStyle.Information, "Información")
                    End
                ElseIf ID_ACCESO = 2 Then
                    MsgBox("El Sistema se cerrará automáticamente" & Chr(13) & _
                          "para completar el registro.", MsgBoxStyle.Information, "Información")
                    End
                ElseIf ID_ACCESO = 0 Then
                    MsgBox("El Sistema se cerrará automáticamente" & Chr(13) & _
                          "para completar el registro.", MsgBoxStyle.Information, "Información")
                    End
                End If
            Else
                Me.txtResp1.Clear()
                Me.txtResp2.Clear()
                Me.txtResp3.Clear()
                Me.txtResp4.Clear()
                Me.txtResp5.Clear()
                Me.txtResp1.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            Me.txtResp1.Clear()
            Me.txtResp2.Clear()
            Me.txtResp3.Clear()
            Me.txtResp4.Clear()
            Me.txtResp5.Clear()
            Me.txtResp1.Select()
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btncerrar.Click
        If V2D = True Then
            Me.Close()
            Usuario.Show()
        Else
            If MessageBox.Show("¿Desea Salir del Sistem?" & vbCrLf & vbCrLf & _
                       Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                       MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                End
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        'Me.Hide()
        If V2D = True Then
            Me.Close()
            Usuario.Show()
        Else
            If ID_ACCESO = 1 Then
                Admi_Usuario.Show()
                Me.Close()
            ElseIf ID_ACCESO = 3 Then
                Admin2.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Me.txtResp1.Clear()
        Me.txtResp2.Clear()
        Me.txtResp3.Clear()
        Me.txtResp4.Clear()
        Me.txtResp5.Clear()
        Me.txtResp1.Select()
    End Sub

    Private Sub txtResp1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtResp2.Focus()
        End If
    End Sub

    Private Sub txtResp2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtResp3.Focus()
        End If
    End Sub

    Private Sub txtResp3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtResp4.Focus()
        End If
    End Sub

    Private Sub txtResp4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp4.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtResp5.Focus()
        End If
    End Sub

    Private Sub txtResp5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp5.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnActualizar.PerformClick()
        End If
    End Sub
End Class