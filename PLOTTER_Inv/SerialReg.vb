Imports System.Data
Imports System.Data.OleDb
Public Class SerialReg
    Public cnnBD As New OleDbConnection
    Private Sub SerialReg_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If SER = True Then
            CAD = True
            e.Cancel = False
        Else
            End
        End If
        'End
    End Sub

    Private Sub SerialReg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Usuario.Hide()
        Me.txt1.Select()
    End Sub

    Private Sub btnSerial_Click(sender As System.Object, e As System.EventArgs) Handles btnSerial.Click
        If txt1.Text & txt2.Text & txt3.Text & txt4.Text = My.Settings.Ser Then

            My.Settings.ProReg = True
            My.Settings.Save()
            Me.Hide()
            MsgBox("Felicidades Mauricio!!!" & Chr(13) & Chr(13) & _
                   "El Porducto ha sido Regirtrado" & Chr(13) & _
                   "Exitosamente.", MsgBoxStyle.Information, "Bienvenido")
            SER = True
            Me.Close()
            Usuario.ShowDialog()
            'Me.Hide()
        Else
            MsgBox("El serial es incorrecto!", MsgBoxStyle.Critical, "Error")
            Me.txt1.Text = ""
            Me.txt2.Text = ""
            Me.txt3.Text = ""
            Me.txt4.Text = ""
            Me.txt1.Select()
        End If
    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Me.txt2.Focus()
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Me.txt3.Focus()
        End If
    End Sub

    Private Sub txt3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Me.txt4.Focus()
        End If
    End Sub
End Class