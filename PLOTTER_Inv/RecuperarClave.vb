Imports System.Data
Imports System.Data.OleDb
Public Class RecuperarClave
    Private cnnBD As New OleDbConnection
    Dim Re0, Re1, Re2, Re3, Re4, Re5, Re6, Re7, Re8, Re9, CI As String
    Private SW As Boolean
    Private MS As Boolean
    Private Sub RecuperarClave_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblConyUsr.Visible = True
        Me.lblUsr.Visible = False
        Me.lblResSeg.Visible = False
        Me.txtClave.Visible = False
        Me.txtConf.Visible = False
        Me.txtId.Visible = False
        Me.lblClave.Visible = False
        Me.lblConf.Visible = False
        Me.lblNuevo.Visible = False
        Me.lblPreg0.Visible = False
        Me.lblPreg1.Visible = False
        Me.lblNuevoUsr.Visible = False
        Me.lblConfUsr.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.txtResp0.Visible = False
        Me.txtResp1.Visible = False
        Me.txtResp2.Visible = False
        Me.txtResp3.Visible = False
        Me.txtResp4.Visible = False
        Me.txtResp5.Visible = False
        Me.txtResp6.Visible = False
        Me.txtResp7.Visible = False
        Me.txtResp8.Visible = False
        Me.txtResp9.Visible = False
        Me.lblRecUsr.Visible = False
        Me.btnAceptar2.Visible = False
        Me.btnAceptar4.Visible = False
        Me.txtCI.Visible = True
        Me.txtUsr.Visible = False
        Me.txtUsrCof.Visible = False
        Me.btnAceptar3.Visible = False
        Me.txtCI.Select()
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        'AbrirConexion()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If Me.txtCI.Text = "" Then
            MsgBox("Debe colocar el Número de Cédula.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtCI.Select()
            Exit Sub
        End If
        If Me.txtNro.Text = "" Then
            MsgBox("Debe colocar el Número" & Chr(13) & _
                   "de Cuenta o Pasaporte.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtNro.Select()
            Exit Sub
        End If
        Repetir()
    End Sub
    Private Sub Repetir()
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Cuenta=" & Me.txtNro.Text & ""
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Me.txtId.Text = dtr("Id_usuario").ToString
                Me.lblConyUsr.Visible = False
                Me.lblResSeg.Visible = True
                Me.Label1.Visible = False
                Me.Label2.Visible = False
                Me.txtCI.Visible = False
                Me.txtNro.Visible = False
                Me.btnAceptar.Enabled = False
                Me.Label3.Visible = True
                Me.Label4.Visible = True
                Me.lblPreg0.Visible = True
                Me.lblPreg1.Visible = True
                Me.btnCancelar.Visible = True
                Me.btnAceptar.Visible = False
                Me.btnAceptar3.Visible = True
                Dim Num As New Random
Repite:
                Dim a As Integer = 0
                Dim Sqlc As String
                Sqlc = "Select * From Usuarios Order By Cedula"
                Dim cmdb As New OleDbCommand(Sqlc, cnnBD)
                Dim dtrb As OleDbDataReader
                dtrb = cmdb.ExecuteReader
                dtrb.Read()
                Dim minum As String = Num.Next(0, 5)
                Dim minum2 As String = Num.Next(0, 5)

                Dim Pregunta() As String

                ReDim Pregunta(5)

                Pregunta(0) = dtrb("Ask1").ToString
                Pregunta(1) = dtrb("Ask2").ToString
                Pregunta(2) = dtrb("Ask3").ToString
                Pregunta(3) = dtrb("Ask4").ToString
                Pregunta(4) = dtrb("Ask5").ToString

                Me.lblPreg0.Text = (Pregunta(minum))
                Me.lblPreg1.Text = (Pregunta(minum2))
                If minum = minum2 Then
                    GoTo Repite
                End If

                If lblPreg0.Text = Pregunta(0) And Me.lblPreg1.Text = Pregunta(1) Then
                    Me.txtResp0.Visible = True
                    Me.txtResp3.Visible = True
                End If
                If lblPreg0.Text = Pregunta(0) And Me.lblPreg1.Text = Pregunta(2) Then
                    Me.txtResp0.Visible = True
                    Me.txtResp5.Visible = True
                End If
                If lblPreg0.Text = Pregunta(0) And Me.lblPreg1.Text = Pregunta(3) Then
                    Me.txtResp0.Visible = True
                    Me.txtResp7.Visible = True
                End If
                If lblPreg0.Text = Pregunta(0) And Me.lblPreg1.Text = Pregunta(4) Then
                    Me.txtResp0.Visible = True
                    Me.txtResp9.Visible = True
                End If
                If lblPreg0.Text = Pregunta(1) And Me.lblPreg1.Text = Pregunta(0) Then
                    Me.txtResp2.Visible = True
                    Me.txtResp1.Visible = True
                End If
                If lblPreg0.Text = Pregunta(1) And Me.lblPreg1.Text = Pregunta(2) Then
                    Me.txtResp2.Visible = True
                    Me.txtResp5.Visible = True
                End If
                If lblPreg0.Text = Pregunta(1) And Me.lblPreg1.Text = Pregunta(3) Then
                    Me.txtResp2.Visible = True
                    Me.txtResp7.Visible = True
                End If
                If lblPreg0.Text = Pregunta(1) And Me.lblPreg1.Text = Pregunta(4) Then
                    Me.txtResp2.Visible = True
                    Me.txtResp9.Visible = True
                End If
                If lblPreg0.Text = Pregunta(2) And Me.lblPreg1.Text = Pregunta(0) Then
                    Me.txtResp4.Visible = True
                    Me.txtResp1.Visible = True
                End If
                If lblPreg0.Text = Pregunta(2) And Me.lblPreg1.Text = Pregunta(1) Then
                    Me.txtResp4.Visible = True
                    Me.txtResp3.Visible = True
                End If
                If lblPreg0.Text = Pregunta(2) And Me.lblPreg1.Text = Pregunta(3) Then
                    Me.txtResp4.Visible = True
                    Me.txtResp7.Visible = True
                End If
                If lblPreg0.Text = Pregunta(2) And Me.lblPreg1.Text = Pregunta(4) Then
                    Me.txtResp4.Visible = True
                    Me.txtResp9.Visible = True
                End If
                If lblPreg0.Text = Pregunta(3) And Me.lblPreg1.Text = Pregunta(0) Then
                    Me.txtResp6.Visible = True
                    Me.txtResp1.Visible = True
                End If
                If lblPreg0.Text = Pregunta(3) And Me.lblPreg1.Text = Pregunta(1) Then
                    Me.txtResp6.Visible = True
                    Me.txtResp3.Visible = True
                End If
                If lblPreg0.Text = Pregunta(3) And Me.lblPreg1.Text = Pregunta(2) Then
                    Me.txtResp6.Visible = True
                    Me.txtResp5.Visible = True
                End If
                If lblPreg0.Text = Pregunta(3) And Me.lblPreg1.Text = Pregunta(4) Then
                    Me.txtResp6.Visible = True
                    Me.txtResp9.Visible = True
                End If
                If lblPreg0.Text = Pregunta(4) And Me.lblPreg1.Text = Pregunta(0) Then
                    Me.txtResp8.Visible = True
                    Me.txtResp1.Visible = True
                End If
                If lblPreg0.Text = Pregunta(4) And Me.lblPreg1.Text = Pregunta(1) Then
                    Me.txtResp8.Visible = True
                    Me.txtResp3.Visible = True
                End If
                If lblPreg0.Text = Pregunta(4) And Me.lblPreg1.Text = Pregunta(2) Then
                    Me.txtResp8.Visible = True
                    Me.txtResp5.Visible = True
                End If
                If lblPreg0.Text = Pregunta(4) And Me.lblPreg1.Text = Pregunta(3) Then
                    Me.txtResp8.Visible = True
                    Me.txtResp7.Visible = True
                End If
            Else
                MsgBox("El Nro de Cédula y/o el Nro." & Chr(13) & _
                       "de Cuenta son Incorrectos.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtCI.Clear()
                Me.txtNro.Clear()
                Me.txtCI.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar3_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar3.Click
        Re0 = Me.txtResp0.Text
        Re3 = Me.txtResp3.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask1='" & Re0 & "' And Ask2='" & Re3 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call cero()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub cero()
        Re0 = Me.txtResp0.Text
        Re5 = Me.txtResp5.Text
        CI = Me.txtCI.Text
        Try

            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask1='" & Re0 & "' And Ask3='" & Re5 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call uno()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub uno()
        Re0 = Me.txtResp0.Text
        Re7 = Me.txtResp7.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask1='" & Re0 & "' And Ask4='" & Re7 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call dos()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub dos()
        Re0 = Me.txtResp0.Text
        Re9 = Me.txtResp9.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask1='" & Re0 & "' And Ask5='" & Re9 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call tres()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub tres()
        Re2 = Me.txtResp2.Text
        Re1 = Me.txtResp1.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask2='" & Re2 & "' And Ask1='" & Re1 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call cuatro()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub cuatro()
        Re2 = Me.txtResp2.Text
        Re5 = Me.txtResp5.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask2='" & Re2 & "' And Ask3='" & Re5 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call cinco()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub cinco()
        Re2 = Me.txtResp2.Text
        Re7 = Me.txtResp7.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask2='" & Re2 & "' And Ask4='" & Re7 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call seis()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub seis()
        Re2 = Me.txtResp2.Text
        Re9 = Me.txtResp9.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask2='" & Re2 & "' And Ask5='" & Re9 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call siete()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub siete()
        Re4 = Me.txtResp4.Text
        Re1 = Me.txtResp1.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask3='" & Re4 & "' And Ask1='" & Re1 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call ocho()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub ocho()
        Re4 = Me.txtResp4.Text
        Re3 = Me.txtResp3.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask3='" & Re4 & "' And Ask2='" & Re3 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call nueve()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub nueve()
        Re4 = Me.txtResp4.Text
        Re7 = Me.txtResp7.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask3='" & Re4 & "' And Ask4='" & Re7 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call diez()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub diez()
        Re4 = Me.txtResp4.Text
        Re9 = Me.txtResp9.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask3='" & Re4 & "' And Ask5='" & Re9 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call once()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub once()
        Re6 = Me.txtResp6.Text
        Re1 = Me.txtResp1.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask4='" & Re6 & "' And Ask1='" & Re1 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call doce()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub doce()
        Re6 = Me.txtResp6.Text
        Re3 = Me.txtResp3.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask4='" & Re6 & "' And Ask2='" & Re3 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call trece()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub trece()
        Re6 = Me.txtResp6.Text
        Re5 = Me.txtResp5.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask4='" & Re6 & "' And Ask3='" & Re5 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call catorce()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub catorce()
        Re6 = Me.txtResp6.Text
        Re9 = Me.txtResp9.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask4='" & Re6 & "' And Ask5='" & Re9 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call quince()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub quince()
        Re8 = Me.txtResp8.Text
        Re1 = Me.txtResp1.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask5='" & Re8 & "' And Ask1='" & Re1 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call diesciseis()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub diesciseis()
        Re8 = Me.txtResp8.Text
        Re3 = Me.txtResp3.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask5='" & Re8 & "' And Ask2='" & Re3 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call diescisiete()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub diescisiete()
        Re8 = Me.txtResp8.Text
        Re5 = Me.txtResp5.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask5='" & Re8 & "' And Ask3='" & Re5 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                Call diesciocho()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub diesciocho()
        Re8 = Me.txtResp8.Text
        Re7 = Me.txtResp7.Text
        CI = Me.txtCI.Text
        Try
            Dim SQL As String
            SQL = "Select * From Usuarios Where Cedula='" & Me.txtCI.Text & "' And Ask5='" & Re8 & "' And Ask4='" & Re7 & "'"
            Dim cmd As New OleDbCommand(SQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.Read = True Then
                Call Resp()
            Else
                MsgBox("Una de las Respuestas o las" & Chr(13) & _
                       "dos son incorrectas.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtResp0.Clear()
                Me.txtResp1.Clear()
                Me.txtResp2.Clear()
                Me.txtResp3.Clear()
                Me.txtResp4.Clear()
                Me.txtResp5.Clear()
                Me.txtResp6.Clear()
                Me.txtResp7.Clear()
                Me.txtResp8.Clear()
                Me.txtResp9.Clear()
                Me.txtResp0.Visible = False
                Me.txtResp1.Visible = False
                Me.txtResp2.Visible = False
                Me.txtResp3.Visible = False
                Me.txtResp4.Visible = False
                Me.txtResp5.Visible = False
                Me.txtResp6.Visible = False
                Me.txtResp7.Visible = False
                Me.txtResp8.Visible = False
                Me.txtResp9.Visible = False
                Repetir()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Resp()

        Me.lblConyUsr.Visible = False
        Me.lblResSeg.Visible = False
        Me.lblUsr.Visible = False
        Me.lblNuevo.Visible = False
        Me.Label3.Visible = False
        Me.Label1.Visible = False
        Me.Label4.Visible = False
        Me.lblConfUsr.Visible = False
        Me.lblNuevoUsr.Visible = False
        Me.txtId.Visible = False
        Me.txtResp0.Visible = False
        Me.txtResp1.Visible = False
        Me.txtResp2.Visible = False
        Me.txtResp3.Visible = False
        Me.txtResp4.Visible = False
        Me.txtResp5.Visible = False
        Me.txtResp6.Visible = False
        Me.txtResp7.Visible = False
        Me.txtResp8.Visible = False
        Me.txtResp9.Visible = False
        Me.lblNuevo.Visible = True
        Me.btnAceptar3.Visible = False
        Me.txtClave.Visible = True
        Me.txtConf.Visible = True
        Me.lblConf.Visible = True
        Me.lblClave.Visible = True
        Me.lblPreg0.Visible = False
        Me.lblPreg1.Visible = False
        Me.lblRecUsr.Visible = True
        Me.btnAceptar2.Visible = True
        Me.btnCancelar.Visible = True
        Me.txtClave.Select()

    End Sub

    Private Sub btnAceptar2_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar2.Click
        If Me.txtClave.Text = "" Then
            MsgBox("El Campo Contraseña no debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtClave.Select()
            Exit Sub
        End If
        If Me.txtConf.Text = "" Then
            MsgBox("El Campo Confirmar Contraseña no debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtConf.Select()
            Exit Sub
        End If
        Try
            If Me.txtClave.Text = Me.txtConf.Text Then
                Dim SQL As String
                SQL = "Update Usuarios Set Contrasena='" & txtClave.Text & "'" & _
                "Where Id_usuario=" & Me.txtId.Text & ""
                Call Veri_Clave()
                If SW = True Then
                    MsgBox("Ya se encuentra registrada" & Chr(13) & _
                           "esta contraseña", MsgBoxStyle.Exclamation, "Inforamción")
                Else
                    Dim cmd As New OleDbCommand(SQL, cnnBD)
                    Dim dtr As OleDbDataReader
                    dtr = cmd.ExecuteReader
                    MsgBox("Se registró con éxito" & Chr(13) & _
                           "su nueva Contraseña.", MsgBoxStyle.Information, "Información")
                    If MessageBox.Show("Sí desea Recuperar su Usuario" & Chr(13) & _
                                       "Seleccione (Si) y luego haga" & Chr(13) & _
                                       "Click en Recuperar el Usuario.", "Seleccione", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                     MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
                        Me.Close()
                    End If
                End If
                Me.txtClave.Clear()
                Me.txtConf.Clear()
                Me.txtClave.Select()
            Else
                MsgBox("Los Números de Contraseña no coinciden.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtClave.Clear()
                Me.txtConf.Clear()
                Me.txtClave.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Veri_Clave()
        Try
            'Dim Resultado As Boolean = True
            Dim srSQL As String
            srSQL = "Select * From Usuarios Where Contrasena= '" & Me.txtClave.Text & "'"
            Dim cmdd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmdd.ExecuteReader
            If dtr.Read = True Then
                SW = True
            Else
                SW = False
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub

    Private Sub btnAceptar4_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar4.Click
        If Me.txtUsr.Text = "" Then
            MsgBox("El Campo Usuario no debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtUsr.Select()
            Exit Sub
        End If
        If Me.txtUsrCof.Text = "" Then
            MsgBox("El Campo Confirmar Usuario no debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtUsrCof.Select()
            Exit Sub
        End If
        Try
            If Me.txtUsr.Text = Me.txtUsrCof.Text Then
                Dim SQL As String
                SQL = "Update Usuarios Set Usuario='" & txtUsr.Text & "'" & _
               " Where Id_usuario=" & Me.txtId.Text & ""
                Call Veri_Usuario()
                If SW = True Then
                    MsgBox("Ya está registrado" & Chr(13) & _
                           "este usuario.", MsgBoxStyle.Exclamation, "Inforamción")
                Else
                    Dim cmd As New OleDbCommand(SQL, cnnBD)
                    Dim dtr As OleDbDataReader
                    dtr = cmd.ExecuteReader
                    MsgBox("Se registró con éxito" & Chr(13) & _
                           "su nuevo Usuario.", MsgBoxStyle.Information, "Información")
                    Me.Close()
                End If
                Me.txtUsr.Clear()
                Me.txtUsrCof.Clear()
                Me.txtUsr.Select()
            Else
                MsgBox("Los Nombres de Usuario no coinciden.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtUsr.Clear()
                Me.txtUsrCof.Clear()
                Me.txtUsr.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Veri_Usuario()
        Try
            'Dim Resultado As Boolean = True
            Dim srSQL As String
            srSQL = "Select * From Usuarios Where Usuario= '" & Me.txtUsr.Text & "'"
            Dim cmdd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmdd.ExecuteReader
            If dtr.Read = True Then
                SW = True
            Else
                SW = False
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub lblRecUsr_Click(sender As System.Object, e As System.EventArgs) Handles lblRecUsr.Click
        Me.lblConyUsr.Visible = False
        Me.txtClave.Clear()
        Me.txtConf.Clear()
        Me.lblUsr.Visible = True
        Me.lblResSeg.Visible = False
        Me.lblNuevo.Visible = False
        Me.lblRecUsr.Visible = False
        Me.lblNuevoUsr.Visible = True
        Me.lblConfUsr.Visible = True
        Me.txtUsr.Visible = True
        Me.txtUsrCof.Visible = True
        Me.txtClave.Visible = False
        Me.txtConf.Visible = False
        Me.lblConf.Visible = False
        Me.lblClave.Visible = False
        Me.btnAceptar2.Visible = False
        Me.btnAceptar4.Visible = True
        Me.btnCancelar.Visible = True
        Me.txtUsr.Select()
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Me.txtCI.Clear()
        Me.txtNro.Clear()
        Me.txtResp0.Clear()
        Me.txtResp1.Clear()
        Me.txtResp2.Clear()
        Me.txtResp3.Clear()
        Me.txtResp4.Clear()
        Me.txtResp5.Clear()
        Me.txtResp6.Clear()
        Me.txtResp7.Clear()
        Me.txtResp8.Clear()
        Me.txtResp9.Clear()
        Me.txtClave.Clear()
        Me.txtConf.Clear()
        Me.txtUsr.Clear()
        Me.txtUsrCof.Clear()
        Me.txtCI.Select()
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
            Me.txtNro.Focus()
        End If
    End Sub

    Private Sub txtNro_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNro.KeyPress
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
                   "puntos.", MsgBoxStyle.Exclamation, "Atención")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtConf.Focus()
        End If
    End Sub
    Private Sub txtConf_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtConf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnAceptar2.PerformClick()
        End If
    End Sub

    Private Sub txtUsr_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtUsrCof.Focus()
        End If
    End Sub

    Private Sub txtUsrCof_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsrCof.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnAceptar4.PerformClick()
        End If
    End Sub
    Sub ErroresPri()
        Errores.SetError(Me.txtCI, Nothing)
        Errores.SetError(Me.txtNro, Nothing)
    End Sub
End Class