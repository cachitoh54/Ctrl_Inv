Imports System.Data
Imports System.Data.OleDb
Public Class Iva
    Private cnnBD As New OleDbConnection
    Private SW As Boolean
    Private MS As Boolean

    Private Sub Iva_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Errores.SetError(Me.txtporc, Nothing)
    End Sub
    Private Sub Iva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
        End If
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        ' AbrirConexion()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT * FROM IVA WHERE Id=1"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                Me.txtporc.Text = dtr("Porc").ToString
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub btnact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnact.Click
        Try
            If Me.txtporc.Text = "" Then
                MsgBox("El campo Porcentaje se encuentra vacio.", MsgBoxStyle.Critical, "Atención")
                Me.txtporc.Select()
                Errores.SetError(Me.txtporc, Nothing)
                Exit Sub
            End If
            Dim spSQL As String
            spSQL = "UPDATE IVA " & _
                    "SET Porc=" & Me.txtporc.Text & " " & _
                    "WHERE Id=1"
            Dim cmd As New OleDbCommand(spSQL, cnnBD)
            cmd.ExecuteReader()
            ''''
            'SW = False
            Me.txtId.Text = Me.txtId.Text
            Me.Hide()
            Errores.SetError(Me.txtporc, Nothing)
            ID_ACCESO = 1
            Factura_Compra.Show()
            MsgBox("EL porcentaje se Actualizó.", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            Errores.SetError(Me.txtporc, Nothing)
        End Try
    End Sub
    Private Sub btnborr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborr.Click
        Me.txtporc.Clear()
        Me.txtporc.Select()
        Errores.SetError(Me.txtporc, Nothing)
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        Errores.SetError(Me.txtporc, Nothing)
        ID_ACCESO = 1
        Factura_Compra.Show()
    End Sub

    Private Sub txtporc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtporc.KeyPress
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
                   "Decimales.", MsgBoxStyle.Exclamation, "Atención")

        End If
        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnact.PerformClick()
        End If
    End Sub
End Class