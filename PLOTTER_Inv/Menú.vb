Imports System.Data
Imports System.Data.OleDb
Public Class Menú
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MessageBox.Show("¿Desea Salir del Sistem?" & vbCrLf & vbCrLf & _
                   Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub lblCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCambio.Click
        Me.Hide()
        If ID_ACCESO = 1 Then
            Me.Hide()
            Admi_Usuario.Show()
        End If
    End Sub

    Private Sub Menú_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ID_ACCESO = 1 Then
            Usuario.Visible = True
        ElseIf ID_ACCESO = 2 Then
            Usuario.Visible = True
        ElseIf ID_ACCESO = 3 Then
            Me.lbladmin2.Visible = False
            Usuario.Visible = True
        End If
    End Sub

    Private Sub Menú_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If ID_ACCESO = 1 Then
            Select Case e.KeyCode
                Case Keys.F1
                    Me.Visible = False
                    Call Productos.Show()
                Case Keys.F2
                    Me.Visible = False
                    Call Empleados.Show()
                Case Keys.F3
                    Me.Visible = False
                    Call Proveedor.Show()
                Case Keys.F4
                    Me.Visible = False
                    Call Factura_Compra.Show()
                Case Keys.F5
                    Me.Visible = False
                    Call Salida_Producto.Show()
                Case Keys.F6
                    Me.Visible = False
                    Call Reports.Show()
                Case Keys.F7
                    Me.Visible = False
                    Me.Hide()
                    V3D = True
                    Call Admi_Usuario.Show()
            End Select
        End If
        If ID_ACCESO = 2 Then
            Select Case e.KeyCode
                Case Keys.F1
                    Me.Visible = False
                    Call Productos.Show()
                Case Keys.F2
                    Me.Visible = False
                    Call Empleados.Show()
                Case Keys.F3
                    Me.Visible = False
                    Call Proveedor.Show()
                Case Keys.F4
                    Me.Visible = False
                    Call Factura_Compra.Show()
                Case Keys.F5
                    Me.Visible = False
                    Call Salida_Producto.Show()
                Case Keys.F6
                    MsgBox("Usted no está autorizada para " & Chr(13) & _
                           "acceder a los Reportes.")
            End Select
        End If
        If ID_ACCESO = 3 Then
            Select Case e.KeyCode
                Case Keys.F1
                    Me.Visible = False
                    Call Productos.Show()
                Case Keys.F2
                    Me.Visible = False
                    Call Empleados.Show()
                Case Keys.F3
                    Me.Visible = False
                    Call Proveedor.Show()
                Case Keys.F4
                    Me.Visible = False
                    Call Factura_Compra.Show()
                Case Keys.F5
                    Me.Visible = False
                    Call Salida_Producto.Show()
                Case Keys.F6
                    Me.Visible = False
                    Call Reports.Show()
                Case Keys.F7
                    Me.Visible = False
                    Me.Hide()
                    Call Admin2.Show()
            End Select
        End If
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide()
        If ID_ACCESO = 1 Then
            V3D = True
            Me.lblCambio.Visible = True
            Me.lbladmin2.Visible = False
            Me.lblBven.Visible = True
        Else
            Me.Hide()
            If ID_ACCESO = 3 Then
                Me.lblCambio.Visible = False
                Me.lblBven.Visible = False
            Else

                Me.Hide()
                ID_ACCESO = 2
                Me.lblCambio.Visible = False
                Me.lbladmin2.Visible = False
                Me.btnReport.Enabled = False
                Me.lblBven.Visible = False
            End If
        End If
    End Sub

    Private Sub lbladmin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbladmin2.Click
        If ID_ACCESO = 3 Then
            Me.Hide()
            Admin2.Show()
        End If
    End Sub

    Private Sub lblCambiarU_Click(sender As System.Object, e As System.EventArgs) Handles lblCambiarU.Click
        If My.Settings.ProReg = False Then
            Usuario.Size = New Size(Width:=451, Height:=354)
        Else
            Usuario.Size = New Size(Width:=451, Height:=284)
        End If
        Me.Close()
    End Sub
    Private Sub btnListP_Click(sender As System.Object, e As System.EventArgs) Handles btnListP.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Productos.Show()
        End If
        If ID_ACCESO = 2 Then
            Me.Visible = False
            Productos.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Productos.Show()
        End If
    End Sub
    Private Sub btnEmpl_Click(sender As System.Object, e As System.EventArgs) Handles btnEmpl.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Empleados.Show()
        End If
        If ID_ACCESO = 2 Then
            Me.Visible = False
            Empleados.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Empleados.Show()
        End If
    End Sub
    Private Sub btnProv_Click(sender As System.Object, e As System.EventArgs) Handles btnProv.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Proveedor.Show()
        End If
        If ID_ACCESO = 2 Then
            Me.Visible = False
            Proveedor.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Proveedor.Show()
        End If
    End Sub
    Private Sub btnFac_Click(sender As System.Object, e As System.EventArgs) Handles btnFac.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Factura_Compra.Show()
        End If
        If ID_ACCESO = 2 Then
            Me.Visible = False
            Factura_Compra.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Factura_Compra.Show()
        End If
    End Sub
    Private Sub btnEntr_Click(sender As System.Object, e As System.EventArgs) Handles btnEntr.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Salida_Producto.Show()
        End If
        If ID_ACCESO = 2 Then
            Me.Visible = False
            Salida_Producto.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Salida_Producto.Show()
        End If
    End Sub
    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        If ID_ACCESO = 1 Then
            Me.Visible = False
            Reports.Show()
        End If
        If ID_ACCESO = 3 Then
            Me.Visible = False
            Reports.Show()
        End If
    End Sub
    Private Sub btnListP_MouseHover(sender As Object, e As System.EventArgs) Handles btnListP.MouseHover
        Me.btnListP.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnListP_MouseLeave(sender As Object, e As System.EventArgs) Handles btnListP.MouseLeave
        Me.btnListP.Size = New Size(Width:=100, Height:=86)
    End Sub
    Private Sub btnEmpl_MouseHover(sender As Object, e As System.EventArgs) Handles btnEmpl.MouseHover
        Me.btnEmpl.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnEmpl_MouseLeave(sender As Object, e As System.EventArgs) Handles btnEmpl.MouseLeave
        Me.btnEmpl.Size = New Size(Width:=100, Height:=86)
    End Sub
    Private Sub btnProv_MouseHover(sender As Object, e As System.EventArgs) Handles btnProv.MouseHover
        Me.btnProv.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnProv_MouseLeave(sender As Object, e As System.EventArgs) Handles btnProv.MouseLeave
        Me.btnProv.Size = New Size(Width:=100, Height:=86)
    End Sub
    Private Sub btnFac_MouseHover(sender As Object, e As System.EventArgs) Handles btnFac.MouseHover
        Me.btnFac.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnFac_MouseLeave(sender As Object, e As System.EventArgs) Handles btnFac.MouseLeave
        Me.btnFac.Size = New Size(Width:=100, Height:=86)
    End Sub
    Private Sub btnEntr_MouseHover(sender As Object, e As System.EventArgs) Handles btnEntr.MouseHover
        Me.btnEntr.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnEntr_MouseLeave(sender As Object, e As System.EventArgs) Handles btnEntr.MouseLeave
        Me.btnEntr.Size = New Size(Width:=100, Height:=86)
    End Sub
    Private Sub btnReport_MouseHover(sender As Object, e As System.EventArgs) Handles btnReport.MouseHover
        Me.btnReport.Size = New Size(Width:=120, Height:=106)
    End Sub
    Private Sub btnReport_MouseLeave(sender As Object, e As System.EventArgs) Handles btnReport.MouseLeave
        Me.btnReport.Size = New Size(Width:=100, Height:=86)
    End Sub
End Class