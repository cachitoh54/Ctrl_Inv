Imports System.Data
Imports System.Data.OleDb
Public Class Usuario
    Public cnnBD As New OleDbConnection
    Private SW As Boolean

    Private Sub Usuario_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.ProReg = False Then
            If My.Settings.Pro = False Then
                Me.tmTiempo.Start()
                Me.lblFact.Text = DateTime.Now
                My.Settings.FeCa = DateTime.Now.AddDays(15).Date
                My.Settings.Pro = True
                Me.lblFcad.Text = My.Settings.FeCa.ToString("dd/MM/yyyy")
                My.Settings.Save()
                Me.Size = New Size(Width:=451, Height:=354)
            Else
                Me.tmTiempo.Start()
                Me.lblFact.Text = DateTime.Now
                Me.lblFcad.Text = My.Settings.FeCa
                Me.Size = New Size(Width:=451, Height:=354)
            End If
        Else
            Me.Size = New Size(Width:=451, Height:=284)
        End If
       
        If CAD = False Then
            cnnBD.ConnectionString = fnStrCnn(1)
            cnnBD.Open()
            Dim stSQL As String
            stSQL = "SELECT * FROM Usuarios WHERE Id_usuario=3"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                Me.txtLogin2.Text = dtr("Usuario").ToString
                Me.txtclave2.Text = dtr("Contrasena").ToString
                If Me.txtLogin2.Text = "anulado" Or Me.txtclave2.Text = "0000" Then
                    Me.lbladmin2.Visible = True
                Else
                    Me.lbladmin2.Visible = False
                End If
            End If

            Me.txtLogin2.Clear()
            Me.txtclave2.Clear()
            Me.txtLogin.Select()
        Else
            Me.txtLogin.Select()
        End If
       
    End Sub

    Public Sub ActTiempo()
        Me.lblFact.Text = DateTime.Now
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        If CheckBox1.Checked = True Then
            cnnBD.Close()
            If txtLogin.Text = "" Then MsgBox("Ingrese el Usuario", vbInformation, "Nombre de Usuario") : txtLogin.Select() : Exit Sub
            If txtclave.Text = "" Then MsgBox("Ingrese la clave del Usuario", vbInformation, "Clave de Usuario") : txtclave.Select() : Exit Sub
            If (txtLogin.Text = "anulado" And txtclave.Text = "0000") Or (txtLogin.Text = "Usuari2" And txtclave.Text = "usuario2") Then
                MsgBox("El Usuario o Contraseña estan Errados.", MsgBoxStyle.Critical, "Atención")
              Call Limpiar()
                cnnBD.Close()
                Exit Sub
            End If
            cnnBD.ConnectionString = fnStrCnn(1)
            cnnBD.Open()
            Dim ssql As String = ""
            ssql = "SELECT * FROM USUARIOS WHERE Usuario='" & Me.txtLogin.Text & "' and " & _
                         " Contrasena='" & Me.txtclave.Text & "'"
            Dim cmd As New OleDbCommand(ssql, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                ID_ACCESO = dtr("Id_acceso").ToString
                Me.Hide()
                Menú.Show()
              Call Limpiar()
            Else
                MsgBox("El Usuario o Contraseña estan Errados.", MsgBoxStyle.Critical, "Atención")
               Call Limpiar()
                cnnBD.Close()
            End If
        Else
            Me.Hide()
            ID_ACCESO = 2
            Menú.Show()
            cnnBD.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.txtclave.Enabled = True
            Me.txtLogin.Enabled = True
            Me.txtLogin.Select()
        Else
            Me.txtclave.Enabled = False
            Me.txtLogin.Enabled = False
            Me.txtclave.Clear()
            Me.txtLogin.Clear()
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub lbladmin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbladmin2.Click
        If My.Settings.ProReg = False Then
            Me.Size = New Size(Width:=451, Height:=354)
        Else
            Me.Size = New Size(Width:=451, Height:=284)
        End If
        Me.Hide()
        V22D = True
        Admin2.Label11.Visible = False
        Admin2.Show()
    End Sub
    Private Sub txtLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLogin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtclave.Focus()
        End If
    End Sub
    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btningresar.PerformClick()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        If My.Settings.ProReg = False Then
            Me.Size = New Size(Width:=451, Height:=354)
        Else
            Me.Size = New Size(Width:=451, Height:=284)
        End If
        Call Limpiar()
    End Sub

    Private Sub lblRecUyC_Click(sender As System.Object, e As System.EventArgs) Handles lblRecUyC.Click
        If My.Settings.ProReg = False Then
            Me.Size = New Size(Width:=451, Height:=354)
        Else
            Me.Size = New Size(Width:=451, Height:=284)
        End If
        Call Limpiar()
        RecuperarClave.Show()
    End Sub

    Private Sub CheckBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CheckBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btningresar.PerformClick()
        End If
    End Sub
    Sub Limpiar()
        Me.txtclave.Clear()
        Me.txtLogin.Clear()
        Me.txtLogin.Select()
    End Sub

    Private Sub tmTiempo_Tick(sender As System.Object, e As System.EventArgs) Handles tmTiempo.Tick
        ActTiempo()
        If DateTime.Now > My.Settings.FeCa Then
            Me.Hide()
            Me.tmTiempo.Stop()
            If Factura_Compra.Visible = True Then
                CF = True
                If Factura_Compra.txtfactura.Text <> "" Then
                    Dim sfSQL As String
                    sfSQL = "Select * From Factura_Compra Where Nro_Factura=" & Factura_Compra.txtfactura.Text & ""
                    Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
                    dtr = cmdd.ExecuteReader
                    If dtr.HasRows = True Then
                        dtr.Read()
                        Factura_Compra.cbEstado.Text = dtr("Estado").ToString
                        If Factura_Compra.cbEstado.Text = "Abierto" Then
                            Factura_Compra.Text = MsgBox("Se eliminará este Registro!" & vbCrLf & vbCrLf & _
                                    Factura_Compra.txtfactura.Text, MsgBoxStyle.Critical, "Atención")
                            ELIMINA = True
                            Call Elim()
                            Proveedor.Close()
                            Factura_Compra.Close()
                            Menú.Close()
                            SerialReg.Show()
                        Else
                            Proveedor.Close()
                            Factura_Compra.Close()
                            Menú.Close()
                            SerialReg.Show()
                        End If

                    Else
                        Proveedor.Close()
                        Factura_Compra.Close()
                        Menú.Close()
                        SerialReg.Show()
                    End If
                End If
                Proveedor.Close()
                Factura_Compra.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Salida_Producto.Visible = True Then
                CF = True
                If Salida_Producto.txtNorden.Text <> "" Then
                    Dim sfSQL As String
                    sfSQL = "Select * From Salida_Entrega Where Nro_Orden=" & Salida_Producto.txtNorden.Text & ""
                    Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
                    dtr = cmdd.ExecuteReader
                    If dtr.HasRows = True Then
                        dtr.Read()
                        Salida_Producto.cbEstado.Text = dtr("Estado").ToString
                        If Salida_Producto.cbEstado.Text = "Abierto" Then
                            Salida_Producto.Text = MsgBox("Se eliminará este Registro!" & vbCrLf & vbCrLf & _
                                    Salida_Producto.txtNorden.Text, MsgBoxStyle.Critical, "Atención")
                            ELIMINA = False
                            Call Elim()
                            Productos.Close()
                            Empleados.Close()
                            Salida_Producto.Close()
                            Menú.Close()
                            SerialReg.Show()
                        Else
                            Productos.Close()
                            Empleados.Close()
                            Salida_Producto.Close()
                            Menú.Close()
                            SerialReg.Show()
                        End If

                    Else
                        Productos.Close()
                        Empleados.Close()
                        Salida_Producto.Close()
                        Menú.Close()
                        SerialReg.Show()
                    End If
                End If
                Productos.Close()
                Empleados.Close()
                Salida_Producto.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Empleados.Visible = True Then
                Empleados.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Admi_Usuario.Visible = True Then
                Admi_Usuario.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Admin2.Visible = True Then
                Admin2.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf frmEntDev.Visible = True Then
                frmEntDev.Close()
                Reports.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf frmFactura.Visible = True Then
                frmFactura.Close()
                Reports.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf frmProductos.Visible = True Then
                frmProductos.Close()
                Reports.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Iva.Visible = True Then
                Iva.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf P_Seguridad.Visible = True Then
                P_Seguridad.Close()
                Admi_Usuario.Close()
                Admin2.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Productos.Visible = True Then
                Productos.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Proveedor.Visible = True Then
                Proveedor.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf RecuperarClave.Visible = True Then
                RecuperarClave.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Reports.Visible = True Then
                Reports.Close()
                Menú.Close()
                SerialReg.Show()
            ElseIf Menú.Visible = True Then
                Menú.Close()
                SerialReg.Show()
            Else
                SerialReg.Show()
            End If
        End If
    End Sub
    Sub Elim()
        Try
            If ELIMINA = True Then
                Dim stSQL As String
                stSQL = "DELETE FROM Factura_Compra WHERE Nro_Factura=" & Factura_Compra.txtfactura.Text & ""
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteReader()
                MsgBox("Factura Eliminada.", MsgBoxStyle.Information, "Información")
            ElseIf ELIMINA = False Then
                Dim stSQL As String
                stSQL = "DELETE FROM Salida_Entrega WHERE Nro_Orden=" & Salida_Producto.txtNorden.Text & ""
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteReader()
                MsgBox("Nro. de Orden Eliminado.", MsgBoxStyle.Information, "Información")
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
