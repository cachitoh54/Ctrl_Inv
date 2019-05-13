Imports System.Data             ' NAMESPACE A UTILIZAR
Imports System.Data.OleDb       ' NAMESPACE A UTILIZAR
Imports System.IO
Imports System.IO.StreamReader
Public Class Productos
    Private cnnBD As New OleDbConnection
    Private sDir As String = "C:\BD_Imag\imag_Plotter\"
    Private SW As Boolean
    Dim totalDtgv As Integer = 0
    Dim v, n As String
    Dim svSQL As String
    Dim sNQL As String
    Private MS As Boolean
    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
            Me.btnactualizar.Enabled = False
            Me.btneliminar.Enabled = False
            Me.btnagregar.Enabled = False
        ElseIf ID_ACCESO = 3 Then
            Me.btneliminar.Enabled = False
        End If

        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        CargaBox()
       
        Call Listado()
        Me.cboCodPro.Text = "Seleccionar"
        Me.picFoto.Enabled = False
    End Sub
    Public Sub CargaBox()
        Dim tabla As New DataTable
        Dim boxSQL As String = "Select * From Productos"
        Dim adpt As New OleDbDataAdapter(boxSQL, cnnBD)
        adpt.Fill(tabla)
        Me.cboCodPro.DataSource = tabla
        Me.cboCodPro.DisplayMember = "Cod_Productos"
        Me.cboCodPro.ValueMember = "Cod_Productos"
    End Sub
    Private Sub frmForm1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call ErroresPri()
        If ID_ACCESO = 1 And btncerrar.Enabled = False Or ID_ACCESO = 2 And btncerrar.Enabled = False Or ID_ACCESO = 3 And btncerrar.Enabled = False Then
            If ID_ACCESO = 1 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            ElseIf ID_ACCESO = 2 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            ElseIf ID_ACCESO = 3 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            End If
        Else
            Me.Visible = False
            Menú.Show()
        End If
    End Sub
    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Call ErroresPri()
        If cboCodPro.Text.Trim = "Seleccionar" Then
            MsgBox("Debe asignar un Código al Producto.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCodPro.Select()
            Exit Sub
        End If
        If cboCodPro.Text.Trim = "" Then
            MsgBox("El Campo Código no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        If txtdescripcion.Text.Trim = "" Then
            MsgBox("El Campo Descripción no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtdescripcion.Select()
            Exit Sub
        End If

        If txtmarca.Text.Trim = "" Then
            MsgBox("El Campo Marca no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtmarca.Select()
            Exit Sub
        End If

        If txtexistencia.Text.Trim = "" Then
            MsgBox("El Campo Existencia no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtexistencia.Select()
            Exit Sub
        End If

        If txtprecioU.Text.Trim = "" Then
            MsgBox("El Campo Precio Unitario" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtprecioU.Select()
            Exit Sub
        End If

        If txtprecioE.Text.Trim = "" Then
            MsgBox("El Campo Precio Empaque" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtprecioE.Select()
            Exit Sub
        End If

        If txtstockM.Text.Trim = "" Then
            MsgBox("El Campo Stock Mínimo" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtstockM.Select()
            Exit Sub
        End If

        Try
            If txtimag.Text = "" Then
                If MessageBox.Show("¿Desea seleccionar una Imagen" & Chr(13) & _
                                   "para este Producto?" & vbCrLf & vbCrLf & _
                       Me.txtimag.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                       MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                    Call Buscar_Imag()
                    If SW = True Then
                        Me.txtcodP.Text = ""
                        Me.cboCodPro.Text = "Seleccionar"
                        Me.txtdescripcion.Text = ""
                        Me.txtprecioU.Text = ""
                        Me.txtprecioE.Text = ""
                        Me.txtmarca.Text = ""
                        Me.txtexistencia.Text = ""
                        Me.txtstockM.Text = ""
                        Exit Sub
                    End If

                    Dim stSQL As String
                    stSQL = "INSERT INTO Productos ( Cod_Productos, Descripcion, Precio_unidad, Precio_empaque, Marca, " & _
                            "Existencia, Stock_Minimo, Foto) " & _
                            "VALUES ('" & Me.cboCodPro.Text & "', '" & Me.txtdescripcion.Text & "', '" & Me.txtprecioU.Text & _
                            "', '" & Me.txtprecioE.Text & "', '" & Me.txtmarca.Text & "', " & Me.txtexistencia.Text & _
                            ", " & Me.txtstockM.Text & ", '" & Me.txtimag.Text & "')"
                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    cmd.ExecuteReader()
                    ''''
                    SW = False
                    Call Listado()
                    Me.picFoto.Image.Save(sDir & txtimag.Text)
                    MsgBox("Los Datos fueron Registrados.", MsgBoxStyle.Information, "Información")
                    Me.lblAmbar.Visible = False
                    Me.lblFucsia.Visible = False
                    Me.lblRed.Visible = False
                    Me.lblVerde.Visible = False
                    Me.txtcodP.Text = ""
                    Me.txtCodPro.Text = ""
                    Me.txtdescripcion.Text = ""
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtmarca.Text = ""
                    Me.txtexistencia.Text = ""
                    Me.txtstockM.Text = ""
                    Me.txtimag.Clear()
                    Me.txtimag2.Clear()
                    Me.picFoto.Enabled = False
                    Me.picFoto.Image = Nothing
                    CargaBox()
                    cboCodPro.Text = "Seleccionar"
                    Me.txtCodPro.Select()
                    Exit Sub
                Else
                    Dim stSQL As String
                    stSQL = "INSERT INTO Productos ( Cod_Productos, Descripcion, Precio_unidad, Precio_empaque, Marca, " & _
                            "Existencia, Stock_Minimo) " & _
                            "VALUES ('" & Me.cboCodPro.Text & "', '" & Me.txtdescripcion.Text & "', " & Me.txtprecioU.Text & _
                            ", " & Me.txtprecioE.Text & ", '" & Me.txtmarca.Text & "', " & Me.txtexistencia.Text & _
                            ", " & Me.txtstockM.Text & ")"

                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    cmd.ExecuteReader()
                    ''''
                    SW = False
                    Call Listado()
                    MsgBox("Los Datos fueron Registrados.", MsgBoxStyle.Information, "Información")
                    Me.picFoto.Enabled = False
                    Me.lblAmbar.Visible = False
                    Me.lblFucsia.Visible = False
                    Me.lblRed.Visible = False
                    Me.lblVerde.Visible = False
                    Me.txtcodP.Text = ""
                    Me.txtCodPro.Text = ""
                    Me.txtimag.Clear()
                    Me.txtimag2.Clear()
                    Me.txtdescripcion.Text = ""
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtmarca.Text = ""
                    Me.txtexistencia.Text = ""
                    Me.txtstockM.Text = ""
                    CargaBox()
                    cboCodPro.Text = "Seleccionar"
                    Me.cboCodPro.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox("Este Producto ya Existe.", MsgBoxStyle.Exclamation, "Atención")
            Me.picFoto.Enabled = False
            Me.lblAmbar.Visible = False
            Me.lblFucsia.Visible = False
            Me.lblRed.Visible = False
            Me.lblVerde.Visible = False
            Me.txtcodP.Text = ""
            Me.txtCodPro.Text = ""
            Me.cboCodPro.Text = "Seleccionar"
            Me.txtdescripcion.Text = ""
            Me.txtprecioU.Text = ""
            Me.txtprecioE.Text = ""
            Me.txtmarca.Text = ""
            Me.txtexistencia.Text = ""
            Me.txtstockM.Text = ""
            Me.txtimag.Clear()
            Me.txtimag2.Clear()
            Me.picFoto.Image = Nothing
            Me.cboCodPro.Select()
        End Try
    End Sub
    Sub Buscar_Imag()
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "All Files |*.*"
            ofd.RestoreDirectory = True
            If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                picFoto.Image = Image.FromFile(ofd.FileName)
                txtimag.Text = ofd.SafeFileName
                SW = False
                Call Imagenes()
            Else
                SW = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Imagenes()
        Try
            Dim srSQL As String
            srSQL = "Select * From Productos Where Foto= '" & Me.txtimag.Text & "'"
            Dim cmdd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmdd.ExecuteReader
            If dtr.Read = False Then
                SW = False
            Else
                MsgBox("Esta Imagen ya está Registrada." & Chr(13) & _
                       "para este Producto.", MsgBoxStyle.Critical, "Atención")
                Me.picFoto.Image = Nothing
                Me.txtimag.Clear()
                Call Buscar_Imag()
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub
    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        Call ErroresPri()
        If Me.cboCodPro.Text.Trim = "Seleccionar" Or Me.cboCodPro.Text.Trim = "" Then
            MsgBox("Debe Seleccionar un" & Chr(13) & _
                   "Código de Producto.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCodPro.Text = "Seleccionar"
            Exit Sub
        Else
            Call ExiPro()
            If SW = False Then
                MsgBox("Este Producto no está Registrado." & vbCrLf & vbCrLf & _
                   Me.cboCodPro.Text, MsgBoxStyle.Exclamation, "Atención")
                Me.cboCodPro.Text = ""
                Me.txtdescripcion.Clear()
                Me.txtmarca.Clear()
                Me.txtexistencia.Clear()
                Me.txtprecioU.Clear()
                Me.txtprecioE.Clear()
                Me.txtstockM.Clear()
                Me.cboCodPro.Text = "Seleccionar"
                Exit Sub
            Else
                If cboCodPro.Text.Trim = "Seleccionar" Then
                    MsgBox("Debe Asignar un Código al Producto.", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If
                If cboCodPro.Text.Trim = "" Then
                    MsgBox("El Campo Código no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If
                If txtdescripcion.Text.Trim = "" Then
                    MsgBox("El Campo Descripción no" & Chr(13) & _
                           "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtdescripcion.Select()
                    Exit Sub
                End If

                If txtmarca.Text.Trim = "" Then
                    MsgBox("El Campo Marca no" & Chr(13) & _
                           "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtmarca.Select()
                    Exit Sub
                End If

                If txtexistencia.Text.Trim = "" Then
                    MsgBox("El Campo Existencia no" & Chr(13) & _
                           "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtexistencia.Select()
                    Exit Sub
                End If

                If txtprecioU.Text.Trim = "" Then
                    MsgBox("El Campo Precio Unitario" & Chr(13) & _
                           "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtprecioU.Select()
                    Exit Sub
                End If

                If txtprecioE.Text.Trim = "" Then
                    MsgBox("El Campo Precio Empaque" & Chr(13) & _
                           "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtprecioE.Select()
                    Exit Sub
                End If

                If txtstockM.Text.Trim = "" Then
                    MsgBox("El Campo Stock Mínimo" & Chr(13) & _
                           "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtstockM.Select()
                    Exit Sub
                End If
            End If
        End If
        Try
            If txtimag.Text = "" Then
                If Me.cboCodPro.Text <> Me.txtcodP.Text Then
                    MsgBox("Debe seleccionar el Producto.", MsgBoxStyle.Exclamation, "Seleccionar")
                    Me.lblAmbar.Visible = False
                    Me.lblFucsia.Visible = False
                    Me.lblRed.Visible = False
                    Me.lblVerde.Visible = False
                    Me.txtdescripcion.Text = ""
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtmarca.Text = ""
                    Me.txtexistencia.Text = ""
                    Me.txtstockM.Text = ""
                    Me.txtimag.Clear()
                    Me.txtimag2.Clear()
                    Me.picFoto.Image = Nothing
                    Exit Sub
                Else
                    Dim stSQL As String
                    stSQL = "UPDATE Productos " & _
                            "SET Cod_Productos='" & Me.cboCodPro.Text & "', Descripcion='" & Me.txtdescripcion.Text & "', Precio_unidad=" & Me.txtprecioU.Text & ", Precio_empaque=" & Me.txtprecioE.Text & ", Marca='" & Me.txtmarca.Text & "', Existencia=" & Me.txtexistencia.Text & ", Stock_Minimo=" & Me.txtstockM.Text & " " & _
                            "WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    cmd.ExecuteReader()
                End If
            Else
                Dim stpSQL As String
                stpSQL = "UPDATE Productos " & _
                        "SET Cod_Productos='" & Me.cboCodPro.Text & "', Descripcion='" & Me.txtdescripcion.Text & "', Precio_unidad=" & Me.txtprecioU.Text & ", Precio_empaque=" & Me.txtprecioE.Text & ", Marca='" & Me.txtmarca.Text & "', Existencia=" & Me.txtexistencia.Text & ", Stock_Minimo=" & Me.txtstockM.Text & " " & _
                        "WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
                If Me.txtimag2.Text = "" Then
                    Call imag2()
                Else
                    If Me.txtimag.Text <> Me.txtimag2.Text Then
                        Dim cmd6 As New OleDbCommand(stpSQL, cnnBD)
                        cmd6.ExecuteReader()
                        Call Otro()
                        Me.Refresh()
                    Else
                        Call Imagenes2()
                        Dim cmd3 As New OleDbCommand(stpSQL, cnnBD)
                        cmd3.ExecuteReader()
                        Me.Refresh()
                    End If
                End If
            End If
            '''''
            SW = False
            Call Listado()
            Me.txtcodP.Text = Me.cboCodPro.Text
            Dim stock, exis, vp As Double
            exis = txtexistencia.Text
            stock = txtstockM.Text
            If exis < stock Then
                Me.lblAmbar.Visible = False
                Me.lblRed.Visible = False
                Me.lblVerde.Visible = False
                Me.lblFucsia.Visible = True
            Else
                If exis = stock Then
                    Me.lblAmbar.Visible = False
                    Me.lblFucsia.Visible = False
                    Me.lblVerde.Visible = False
                    Me.lblRed.Visible = True
                Else
                    vp = (stock * 50 / 100) + stock
                    If exis < vp Then
                        Me.lblFucsia.Visible = False
                        Me.lblRed.Visible = False
                        Me.lblVerde.Visible = False
                        Me.lblAmbar.Visible = True
                    Else
                        If exis > stock Then
                            Me.lblAmbar.Visible = False
                            Me.lblFucsia.Visible = False
                            Me.lblRed.Visible = False
                            Me.lblVerde.Visible = True
                        End If
                    End If
                End If
            End If

            MsgBox("La Actualización fue Exitosa.", MsgBoxStyle.Information, "Información")
            Me.lblAmbar.Visible = False
            Me.lblFucsia.Visible = False
            Me.lblRed.Visible = False
            Me.lblVerde.Visible = False
            Me.txtcodP.Text = ""
            Me.txtCodPro.Text = ""
            Me.txtdescripcion.Text = ""
            Me.txtprecioU.Text = ""
            Me.txtprecioE.Text = ""
            Me.txtmarca.Text = ""
            Me.txtexistencia.Text = ""
            Me.txtstockM.Text = ""
            Me.txtimag.Clear()
            Me.txtimag2.Clear()
            Me.picFoto.Enabled = False
            Me.picFoto.Image = Nothing
            CargaBox()
            Me.cboCodPro.Text = "Seleccionar"
            Me.txtCodPro.Select()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub ExiPro()
        Try
            Dim srSQL As String
            srSQL = "Select * From Productos Where Cod_Productos= '" & Me.cboCodPro.Text & "'"
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
    Sub imag2()
        Dim stpSQL As String
        stpSQL = "UPDATE Productos " & _
                            "SET Cod_Productos='" & Me.cboCodPro.Text & "', Descripcion='" & Me.txtdescripcion.Text & "', Precio_unidad=" & Me.txtprecioU.Text & ", Precio_empaque=" & Me.txtprecioE.Text & ", Marca='" & Me.txtmarca.Text & "', Existencia=" & Me.txtexistencia.Text & ", Stock_Minimo=" & Me.txtstockM.Text & ", Foto='" & Me.txtimag.Text & "' " & _
                            "WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
        Dim cmd2 As New OleDbCommand(stpSQL, cnnBD)
        cmd2.ExecuteReader()
        Me.picFoto.Image.Save(sDir & Me.txtimag.Text)
    End Sub
    Sub Imagenes2()
        If Me.txtimag.Text <> Me.txtimag2.Text Then
            Dim Archivo As String
            Archivo = "C:\BD_Imag\imag_Plotter\"
            Dim stpSQL As String
            stpSQL = "UPDATE Productos SET Foto= '" & Me.txtimag.Text & "' " & _
            "WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
            Dim cmd As New OleDbCommand(stpSQL, cnnBD)

            File.Delete(Archivo & Me.txtimag2.Text)
            cmd.ExecuteReader()

            Dim cmd2 As New OleDbCommand(stpSQL, cnnBD)
            cmd2.ExecuteReader()
            Me.picFoto.Image.Save(sDir & txtimag.Text)
        End If
    End Sub
    Sub Imag_Act()
        Try
            Dim Archivo As String
            Archivo = "C:\BD_Imag\imag_Plotter\"
            Dim stpSQL As String
            stpSQL = "UPDATE Productos SET Foto= '" & Me.txtimag.Text & "' " & _
            "WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
            Dim cmd As New OleDbCommand(stpSQL, cnnBD)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Otro()
        Dim Archivo As String
        Archivo = "C:\BD_Imag\imag_Plotter\"
        Try
            My.Computer.FileSystem.DeleteFile(Archivo & Me.txtimag2.Text,
                           FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
            Call Imag_Act()
            Me.picFoto.Image.Save(Archivo & Me.txtimag.Text)
        Catch ex As Exception
            MsgBox("Fue Cancelado el cambio de" & Chr(13) & _
                   "la imagen del producto..." & Chr(13) & Chr(13) & _
                   Me.cboCodPro.Text, MsgBoxStyle.Information, "Atención")
            Exit Sub
        End Try
    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Call ErroresPri()
        If Me.cboCodPro.Text.Trim = "Seleccionar" Or Me.cboCodPro.Text.Trim = "" Then
            MsgBox("Debe seleccionar el Producto" & Chr(13) & _
                   "que desea Eliminar.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCodPro.Text = "Seleccionar"
            Exit Sub
        Else
            Call ExiPro()
            If SW = False Then
                MsgBox("Este Producto no está Registrado." & vbCrLf & vbCrLf & _
                   Me.cboCodPro.Text, MsgBoxStyle.Exclamation, "Atención")
                Me.cboCodPro.Text = ""
                Me.txtdescripcion.Clear()
                Me.txtmarca.Clear()
                Me.txtexistencia.Clear()
                Me.txtprecioU.Clear()
                Me.txtprecioE.Clear()
                Me.txtstockM.Clear()
                Me.cboCodPro.Text = "Seleccionar"
                Exit Sub
            Else
                Dim da As New OleDbDataAdapter
                Dim dt As New DataTable
                If cboCodPro.Text.Trim = "" Then
                    MsgBox("El campo Código no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If
                Try
                    If Me.txtimag.Text = "" Then
                        If Me.cboCodPro.Text <> Me.txtcodP.Text Then
                            MsgBox("Debe seleccionar el Producto.", MsgBoxStyle.Exclamation, "Seleccionar")
                            Me.lblAmbar.Visible = False
                            Me.lblFucsia.Visible = False
                            Me.lblRed.Visible = False
                            Me.lblVerde.Visible = False
                            Me.txtdescripcion.Text = ""
                            Me.txtprecioU.Text = ""
                            Me.txtprecioE.Text = ""
                            Me.txtmarca.Text = ""
                            Me.txtexistencia.Text = ""
                            Me.txtstockM.Text = ""
                            Me.picFoto.Image = Nothing
                        Else

                            Dim stSQL As String
                            stSQL = "DELETE FROM Productos WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
                            Dim cmd As New OleDbCommand(stSQL, cnnBD)
                            If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                                    Me.cboCodPro.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                                cmd.ExecuteNonQuery()
                            End If
                        End If
                    Else
                        If Me.cboCodPro.Text <> Me.txtcodP.Text Then
                            MsgBox("Debe seleccionar el Producto.", MsgBoxStyle.Exclamation, "Seleccionar")
                            Me.lblAmbar.Visible = False
                            Me.lblFucsia.Visible = False
                            Me.lblRed.Visible = False
                            Me.lblVerde.Visible = False
                            Me.txtdescripcion.Text = ""
                            Me.txtprecioU.Text = ""
                            Me.txtprecioE.Text = ""
                            Me.txtmarca.Text = ""
                            Me.txtexistencia.Text = ""
                            Me.txtstockM.Text = ""
                            Me.picFoto.Image = Nothing
                        Else
                            Dim stSQL As String
                            stSQL = "DELETE FROM Productos WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
                            Dim cmd As New OleDbCommand(stSQL, cnnBD)
                            If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                                    Me.cboCodPro.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                                Call Fotografias()
                                cmd.ExecuteNonQuery()
                                Me.txtimag.Clear()
                                Me.txtimag2.Clear()
                            End If
                        End If
                    End If
                    Call Eliminar()
                    If SW = True Then
                        Exit Sub
                    Else
                        SW = False
                        Call Listado()
                        Me.lblAmbar.Visible = False
                        Me.lblFucsia.Visible = False
                        Me.lblRed.Visible = False
                        Me.lblVerde.Visible = False
                        Me.txtcodP.Text = Me.cboCodPro.Text
                        Me.txtcodP.Text = ""
                        Me.cboCodPro.Text = ""
                        Me.txtdescripcion.Text = ""
                        Me.txtprecioU.Text = ""
                        Me.txtprecioE.Text = ""
                        Me.txtmarca.Text = ""
                        Me.txtexistencia.Text = ""
                        Me.txtstockM.Text = ""
                        Me.txtimag.Clear()
                        Me.txtimag2.Clear()
                        Me.picFoto.Image = Nothing
                        Me.cboCodPro.Select()
                        MsgBox("Los Productos fueron Eliminados.", MsgBoxStyle.Information, "Información")
                        da.SelectCommand = New OleDbCommand("Select * From Productos", cnnBD)
                        da.Fill(dt)
                        cboCodPro.DataSource = dt
                        cboCodPro.DisplayMember = "Cod_Productos"
                        cboCodPro.Text = "Seleccionar"
                        Me.picFoto.Enabled = False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub
    Sub Fotografias()
        Me.picFoto.Image.Dispose()
        Me.picFoto.Image = Nothing
        Dim Archivo As String
        Archivo = "C:\BD_Imag\imag_Plotter\"
        Dim stSQL As String
        stSQL = "SELECT * FROM Productos WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
        Dim cmd As New OleDbCommand(stSQL, cnnBD)
        Dim dtr As OleDbDataReader
        dtr = cmd.ExecuteReader()
        dtr.Read()
        Me.txtimag.Text = dtr("Foto").ToString
        Me.txtimag2.Text = dtr("Foto").ToString
        File.Delete(Archivo & Me.txtimag2.Text)
    End Sub
    Sub Eliminar()
        Try
            Dim stSQL As String
            stSQL = "Select * FROM Productos WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            dtr = cmd.ExecuteReader()
            If dtr.Read = True Then
                SW = True
            Else
                SW = False
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call ErroresPri()
        Me.txtimag.Clear()
        Me.txtimag2.Clear()
        If cboCodPro.Text = "" Then
            MsgBox("Debe seleccionar un Producto.", MsgBoxStyle.Exclamation, "Atención")
            Call ErroresPri()
            Exit Sub
        End If
        Me.picFoto.Enabled = True
        Try
            picFoto.Image = Nothing
            Dim stSQL As String
            stSQL = "SELECT * FROM Productos WHERE Cod_Productos='" & Me.cboCodPro.Text & "'"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            If dtr.HasRows = True Then
                Me.cboCodPro.Text = dtr("Cod_Productos").ToString
                Me.txtdescripcion.Text = dtr("Descripcion").ToString
                Me.txtprecioU.Text = dtr("Precio_unidad").ToString
                Me.txtprecioE.Text = dtr("Precio_empaque").ToString
                Me.txtmarca.Text = dtr("Marca").ToString
                Me.txtexistencia.Text = dtr("Existencia").ToString
                Me.txtstockM.Text = dtr("Stock_Minimo").ToString
                Me.txtimag.Text = dtr("Foto").ToString
                Me.txtimag2.Text = dtr("Foto").ToString
                If txtimag.Text = "" Then
                    If dtr.HasRows = True Then
                        Me.cboCodPro.Text = dtr("Cod_Productos").ToString
                        Me.txtprecioU.Text = dtr("Precio_unidad").ToString
                        Me.txtprecioE.Text = dtr("Precio_empaque").ToString
                        Me.txtmarca.Text = dtr("Marca").ToString
                        Me.txtexistencia.Text = dtr("Existencia").ToString
                        Me.txtstockM.Text = dtr("Stock_Minimo").ToString
                        Me.txtcodP.Text = Me.cboCodPro.Text
                    End If
                Else
                    If Not IsDBNull(dtr("foto")) = True Then
                        If System.IO.File.Exists(sDir & dtr("foto")) = True Then
                            picFoto.Image = Image.FromFile(sDir & dtr("foto"))
                        Else
                            picFoto.Image = Image.FromFile(sDir & "vacío.jpg")
                        End If
                    Else
                        picFoto.Image = Image.FromFile(sDir & "vacío.jpg")
                    End If
                    If Not IsDBNull(dtr("foto")) = False Then
                        MessageBox.Show("El Producto no fue localizado", "Código " & Me.cboCodPro.Text & " no existe", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                    Me.txtcodP.Text = Me.cboCodPro.Text
                    SW = False
                    Dim stock, exis, vp As Double
                    exis = txtexistencia.Text
                    stock = txtstockM.Text
                    If exis < stock Then
                        Me.lblAmbar.Visible = False
                        Me.lblRed.Visible = False
                        Me.lblVerde.Visible = False
                        Me.lblFucsia.Visible = True
                    Else
                        If exis = stock Then
                            Me.lblAmbar.Visible = False
                            Me.lblFucsia.Visible = False
                            Me.lblVerde.Visible = False
                            Me.lblRed.Visible = True
                        Else
                            vp = (stock * 50 / 100) + stock
                            If exis < vp Then
                                Me.lblFucsia.Visible = False
                                Me.lblRed.Visible = False
                                Me.lblVerde.Visible = False
                                Me.lblAmbar.Visible = True

                            Else
                                If exis > stock Then
                                    Me.lblAmbar.Visible = False
                                    Me.lblFucsia.Visible = False
                                    Me.lblRed.Visible = False
                                    Me.lblVerde.Visible = True
                                End If
                            End If
                        End If
                    End If
                End If
                Dim stock2, exis2, vp2 As Double
                exis2 = txtexistencia.Text
                stock2 = txtstockM.Text
                If exis2 < stock2 Then
                    Me.lblAmbar.Visible = False
                    Me.lblRed.Visible = False
                    Me.lblVerde.Visible = False
                    Me.lblFucsia.Visible = True
                Else
                    If exis2 = stock2 Then
                        Me.lblAmbar.Visible = False
                        Me.lblFucsia.Visible = False
                        Me.lblVerde.Visible = False
                        Me.lblRed.Visible = True
                    Else
                        vp2 = (stock2 * 50 / 100) + stock2
                        If exis2 < vp2 Then
                            Me.lblFucsia.Visible = False
                            Me.lblRed.Visible = False
                            Me.lblVerde.Visible = False
                            Me.lblAmbar.Visible = True

                        Else
                            If exis2 > stock2 Then
                                Me.lblAmbar.Visible = False
                                Me.lblFucsia.Visible = False
                                Me.lblRed.Visible = False
                                Me.lblVerde.Visible = True
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Call ErroresPri()
        If MessageBox.Show("¿Desea Salir del Sistema?" & vbCrLf & vbCrLf & _
                     Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                     MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Listado()
        Dim sSQL As String
        sSQL = "SELECT * FROM Productos ORDER BY Cod_Productos"
        Dim cmd As New OleDbCommand(sSQL, cnnBD)
        Dim dtr As OleDbDataReader
        dtr = cmd.ExecuteReader
        Dim dtb As New DataTable
        dtb.Load(dtr)
        Me.dtgListado.DataSource = dtb
        Me.dtgListado.Columns(7).Visible = False
        cmd = Nothing : dtb = Nothing : dtr = Nothing
        verListado()
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Call ErroresPri()
        Me.lblAmbar.Visible = False
        Me.lblFucsia.Visible = False
        Me.lblRed.Visible = False
        Me.lblVerde.Visible = False
        Me.txtcodP.Text = ""
        Me.txtCodPro.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtprecioU.Text = ""
        Me.txtprecioE.Text = ""
        Me.txtmarca.Text = ""
        Me.txtexistencia.Text = ""
        Me.txtstockM.Text = ""
        Me.cboCodPro.Text = ""
        Me.txtimag.Clear()
        Me.txtimag2.Clear()
        Me.cboCodPro.Select()
        Me.picFoto.Image = Nothing
        Me.picFoto.Enabled = True
    End Sub

    Private Sub dtgListado_ColumnAdded(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dtgListado.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub dtgListado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgListado.GotFocus
        SW = True
    End Sub
    Private Sub dtgListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListado.CellClick
        Call ErroresPri()
        Dim C As String = ""
        If SW = True Then
            C = dtgListado.Rows(sender.CURRENTCELL.ROWINDEX).Cells(0).Value
            cboCodPro.Text = C
            Call btnbuscar_Click(Nothing, Nothing)
        End If
        If sender.currentcell.columnIndex = 0 Then
            MOSTRARDATOS(sender.CURRENTCELL.ROWINDEX)
            Call btnbuscar_Click(Nothing, Nothing)
        End If
    End Sub
    Sub MOSTRARDATOS(ByVal IND As Integer)
        Me.cboCodPro.Text = dtgListado.Rows(IND).Cells(0).Value
        Me.txtdescripcion.Text = dtgListado.Rows(IND).Cells(1).Value
        Me.txtexistencia.Text = dtgListado.Rows(IND).Cells(5).Value
        Me.txtmarca.Text = dtgListado.Rows(IND).Cells(4).Value
        Me.txtprecioU.Text = dtgListado.Rows(IND).Cells(2).Value
        Me.txtprecioE.Text = dtgListado.Rows(IND).Cells(3).Value
        Me.txtstockM.Text = dtgListado.Rows(IND).Cells(6).Value
        Call verListado()
    End Sub
    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        Call ErroresPri()
        If ID_ACCESO = 1 And btncerrar.Enabled = False Or ID_ACCESO = 2 And btncerrar.Enabled = False Or ID_ACCESO = 3 And btncerrar.Enabled = False Then
            If ID_ACCESO = 1 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
                Me.Close()
            ElseIf ID_ACCESO = 2 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
                Me.Close()
            ElseIf ID_ACCESO = 3 And btncerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
                Me.Close()
            End If
        Else
            Me.Visible = False
            Menú.Show()
            Me.Close()
        End If
    End Sub
    Private Sub verListado()
        With Me.dtgListado
            'If .Rows.Count <= 0 Then Exit Sub
            .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            .RowHeadersWidth = CInt(.Width * 0.03)
            .Columns(0).Width = CInt(.Width * 0.12)
            .Columns(1).Width = CInt(.Width * 0.28)
            .Columns(2).Width = CInt(.Width * 0.11)
            .Columns(3).Width = CInt(.Width * 0.12)
            .Columns(4).Width = CInt(.Width * 0.14)
            .Columns(5).Width = CInt(.Width * 0.1)
            .Columns(6).Width = CInt(.Width * 0.1)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim CellStyle As New DataGridViewCellStyle
            CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
            CellStyle.WrapMode = DataGridViewTriState.True
            CellStyle.BackColor = Color.FromArgb(162, 215, 255)
            CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
            CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle = CellStyle
            .RowHeadersDefaultCellStyle = CellStyle
            .Columns(0).HeaderText = "Cod. Productos"
            .Columns(1).HeaderText = "Descripción"
            .Columns(2).HeaderText = "Precio por Unidad"
            .Columns(3).HeaderText = "Precio por Empaque"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "Existencia"
            .Columns(6).HeaderText = "Stock Mínimo"
           
            .DefaultCellStyle.SelectionBackColor = Color.Aqua
            .DefaultCellStyle.SelectionForeColor = Color.Black
            For Each rw As DataGridViewRow In Me.dtgListado.Rows
                rw.DefaultCellStyle.BackColor = Color.Azure
                rw.DefaultCellStyle.ForeColor = Color.Black
            Next
            Dim sSql As String = ""
            Dim exis As Long
            Dim Stock As Long
            Dim vp As Long
            For Each rw As DataGridViewRow In Me.dtgListado.Rows
                exis = rw.Cells(5).Value
                Stock = rw.Cells(6).Value
                sSql = "SELECT * FROM Productos WHERE Cod_Productos='" & rw.Cells(0).Value & "'"
                Dim cmd3 As New OleDbCommand(sSql, cnnBD)
                cmd3.ExecuteNonQuery()
                If exis < Stock Then
                    rw.DefaultCellStyle.BackColor = Color.Thistle
                Else
                    If exis = Stock Then
                        rw.DefaultCellStyle.BackColor = Color.IndianRed
                    Else
                        vp = (Stock * 50 / 100) + Stock
                        If exis < vp Then
                            rw.DefaultCellStyle.BackColor = Color.PeachPuff
                        Else
                            If exis > Stock Then
                                rw.DefaultCellStyle.BackColor = Color.PaleTurquoise
                            End If
                        End If
                    End If
                End If
            Next
        End With
    End Sub
    Sub CondicionVer()
        Try
            Dim srSQL As String
            srSQL = "SELECT * FROM Productos WHERE Existencia>=((Stock_Minimo*50/100)+Stock_Minimo) ORDER BY Cod_Productos"
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

    Private Sub btnVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerde.Click
        Call ErroresPri()
        Call CondicionVer()
        If SW = False Then
            MsgBox("No existen productos en" & Chr(13) & _
                   "esta condición..." & Chr(13) & Chr(13) & _
                   "(VERDE)", MsgBoxStyle.Information, "Información")
            Me.lblVerde.Visible = False
            Exit Sub
        Else
            Me.lblAmbar.Visible = False
            Me.lblRed.Visible = False
            Me.lblFucsia.Visible = False
            SW = False
            Me.dtgListado.DataSource = Nothing
            Dim sSQL As String
            sSQL = "SELECT * FROM Productos WHERE Existencia>=((Stock_Minimo*50/100)+Stock_Minimo) ORDER BY Cod_Productos"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            Dim dtb As New DataTable
            dtb.Load(dtr)
            Me.dtgListado.DataSource = dtb
            Me.dtgListado.Columns(7).Visible = False
            cmd = Nothing : dtb = Nothing : dtr = Nothing

            With Me.dtgListado
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 40

                .RowHeadersWidth = CInt(.Width * 0.03)
                .Columns(0).Width = CInt(.Width * 0.12)
                .Columns(1).Width = CInt(.Width * 0.28)
                .Columns(2).Width = CInt(.Width * 0.11)
                .Columns(3).Width = CInt(.Width * 0.12)
                .Columns(4).Width = CInt(.Width * 0.14)
                .Columns(5).Width = CInt(.Width * 0.1)
                .Columns(6).Width = CInt(.Width * 0.1)

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).HeaderText = "Cod. Productos"
                .Columns(1).HeaderText = "Descripción"
                .Columns(2).HeaderText = "Precio por Unidad"
                .Columns(3).HeaderText = "Precio por Empaque"
                .Columns(4).HeaderText = "Marca"
                .Columns(5).HeaderText = "Existencia"
                .Columns(6).HeaderText = "Stock Mínimo"

                .DefaultCellStyle.SelectionBackColor = Color.Orange
                .DefaultCellStyle.SelectionForeColor = Color.Black

                .Columns(1).DefaultCellStyle.BackColor = Color.PaleTurquoise
                .Columns(2).DefaultCellStyle.BackColor = Color.PaleTurquoise
                .Columns(3).DefaultCellStyle.BackColor = Color.PaleTurquoise
                .Columns(4).DefaultCellStyle.BackColor = Color.PaleTurquoise
                .Columns(5).DefaultCellStyle.BackColor = Color.PaleTurquoise
                .Columns(6).DefaultCellStyle.BackColor = Color.PaleTurquoise

                .DefaultCellStyle.SelectionBackColor = Color.Aqua

                Me.lblVerde.Visible = True
            End With
            Me.picFoto.Image = Nothing
        End If
    End Sub
    Sub CondicionAmb()
        Try
            Dim srSQL As String
            srSQL = "SELECT * FROM Productos WHERE Existencia>Stock_Minimo and Existencia<((Stock_Minimo*50/100)+Stock_Minimo) ORDER BY Cod_Productos"
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

    Private Sub btnAmbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmbar.Click
        Call ErroresPri()
        Call CondicionAmb()
        If SW = False Then
            MsgBox("No existen productos en" & Chr(13) & _
                   "esta condición..." & Chr(13) & Chr(13) & _
                   "(AMBAR)", MsgBoxStyle.Information, "Información")
            Me.lblAmbar.Visible = False
            Exit Sub
        Else
            Me.lblVerde.Visible = False
            Me.lblRed.Visible = False
            Me.lblFucsia.Visible = False
            SW = False
            Me.dtgListado.DataSource = Nothing
            Dim sSQL As String
            sSQL = "SELECT * FROM Productos WHERE Existencia>Stock_Minimo and Existencia<((Stock_Minimo*50/100)+Stock_Minimo) ORDER BY Cod_Productos"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            Dim dtb As New DataTable
            dtb.Load(dtr)
            Me.dtgListado.DataSource = dtb
            Me.dtgListado.Columns(7).Visible = False
            cmd = Nothing : dtb = Nothing : dtr = Nothing

            With Me.dtgListado
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 40

                .RowHeadersWidth = CInt(.Width * 0.03)
                .Columns(0).Width = CInt(.Width * 0.12)
                .Columns(1).Width = CInt(.Width * 0.28)
                .Columns(2).Width = CInt(.Width * 0.11)
                .Columns(3).Width = CInt(.Width * 0.12)
                .Columns(4).Width = CInt(.Width * 0.14)
                .Columns(5).Width = CInt(.Width * 0.1)
                .Columns(6).Width = CInt(.Width * 0.1)

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).HeaderText = "Cod. Productos"
                .Columns(1).HeaderText = "Descripción"
                .Columns(2).HeaderText = "Precio por Unidad"
                .Columns(3).HeaderText = "Precio por Empaque"
                .Columns(4).HeaderText = "Marca"
                .Columns(5).HeaderText = "Existencia"
                .Columns(6).HeaderText = "Stock Mínimo"

                .Columns(1).DefaultCellStyle.BackColor = Color.PeachPuff
                .Columns(2).DefaultCellStyle.BackColor = Color.PeachPuff
                .Columns(3).DefaultCellStyle.BackColor = Color.PeachPuff
                .Columns(4).DefaultCellStyle.BackColor = Color.PeachPuff
                .Columns(5).DefaultCellStyle.BackColor = Color.PeachPuff
                .Columns(6).DefaultCellStyle.BackColor = Color.PeachPuff

                .DefaultCellStyle.SelectionBackColor = Color.Aqua

                Me.lblAmbar.Visible = True
            End With
            Me.picFoto.Image = Nothing
        End If
    End Sub
    Sub CondicionRoj()
        Try
            Dim srSQL As String
            srSQL = "SELECT * FROM Productos WHERE Existencia=Stock_Minimo ORDER BY Cod_Productos"
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

    Private Sub btnRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRojo.Click
        Call ErroresPri()
        Call CondicionRoj()
        If SW = False Then
            MsgBox("No existen productos en" & Chr(13) & _
                   "esta condición..." & Chr(13) & Chr(13) & _
                   "(ROJO)", MsgBoxStyle.Information, "Información")
            Me.lblRed.Visible = False
            Exit Sub
        Else
            Me.lblAmbar.Visible = False
            Me.lblVerde.Visible = False
            Me.lblFucsia.Visible = False
            SW = False
            Me.dtgListado.DataSource = Nothing
            Dim sSQL As String
            sSQL = "SELECT * FROM Productos WHERE Existencia=Stock_Minimo ORDER BY Cod_Productos"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            Dim dtb As New DataTable
            dtb.Load(dtr)
            Me.dtgListado.DataSource = dtb
            Me.dtgListado.Columns(7).Visible = False
            cmd = Nothing : dtb = Nothing : dtr = Nothing

            With Me.dtgListado
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 40

                .RowHeadersWidth = CInt(.Width * 0.03)
                .Columns(0).Width = CInt(.Width * 0.12)
                .Columns(1).Width = CInt(.Width * 0.28)
                .Columns(2).Width = CInt(.Width * 0.11)
                .Columns(3).Width = CInt(.Width * 0.12)
                .Columns(4).Width = CInt(.Width * 0.14)
                .Columns(5).Width = CInt(.Width * 0.1)
                .Columns(6).Width = CInt(.Width * 0.1)

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).HeaderText = "Cod. Productos"
                .Columns(1).HeaderText = "Descripción"
                .Columns(2).HeaderText = "Precio por Unidad"
                .Columns(3).HeaderText = "Precio por Empaque"
                .Columns(4).HeaderText = "Marca"
                .Columns(5).HeaderText = "Existencia"
                .Columns(6).HeaderText = "Stock Mínimo"

                .Columns(1).DefaultCellStyle.BackColor = Color.IndianRed
                .Columns(2).DefaultCellStyle.BackColor = Color.IndianRed
                .Columns(3).DefaultCellStyle.BackColor = Color.IndianRed
                .Columns(4).DefaultCellStyle.BackColor = Color.IndianRed
                .Columns(5).DefaultCellStyle.BackColor = Color.IndianRed
                .Columns(6).DefaultCellStyle.BackColor = Color.IndianRed

                .DefaultCellStyle.SelectionBackColor = Color.Aqua
                Me.lblRed.Visible = True
            End With
            Me.picFoto.Image = Nothing
        End If
    End Sub
    Sub CondicionFuc()
        Try
            Dim srSQL As String
            srSQL = "SELECT * FROM Productos WHERE Existencia<Stock_Minimo ORDER BY Cod_Productos"
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

    Private Sub btnFucsia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFucsia.Click
        Call ErroresPri()
        Call CondicionFuc()
        If SW = False Then
            MsgBox("No existen productos en" & Chr(13) & _
                   "esta condición..." & Chr(13) & Chr(13) & _
                   "(FUCSIA)", MsgBoxStyle.Information, "Información")
            Me.lblFucsia.Visible = False
            Exit Sub
        Else
            Me.lblAmbar.Visible = False
            Me.lblVerde.Visible = False
            Me.lblRed.Visible = False
            SW = False
            Me.dtgListado.DataSource = Nothing
            Dim sSQL As String
            sSQL = "SELECT * FROM Productos WHERE Existencia<Stock_Minimo ORDER BY Cod_Productos"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            Dim dtb As New DataTable
            dtb.Load(dtr)
            Me.dtgListado.DataSource = dtb
            Me.dtgListado.Columns(7).Visible = False
            cmd = Nothing : dtb = Nothing : dtr = Nothing

            With Me.dtgListado
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 40

                .RowHeadersWidth = CInt(.Width * 0.03)
                .Columns(0).Width = CInt(.Width * 0.12)
                .Columns(1).Width = CInt(.Width * 0.28)
                .Columns(2).Width = CInt(.Width * 0.11)
                .Columns(3).Width = CInt(.Width * 0.12)
                .Columns(4).Width = CInt(.Width * 0.14)
                .Columns(5).Width = CInt(.Width * 0.1)
                .Columns(6).Width = CInt(.Width * 0.1)

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).HeaderText = "Cod. Productos"
                .Columns(1).HeaderText = "Descripción"
                .Columns(2).HeaderText = "Precio por Unidad"
                .Columns(3).HeaderText = "Precio por Empaque"
                .Columns(4).HeaderText = "Marca"
                .Columns(5).HeaderText = "Existencia"
                .Columns(6).HeaderText = "Stock Mínimo"

                .DefaultCellStyle.SelectionBackColor = Color.Orange
                .DefaultCellStyle.SelectionForeColor = Color.Black

                .Columns(1).DefaultCellStyle.BackColor = Color.Thistle
                .Columns(2).DefaultCellStyle.BackColor = Color.Thistle
                .Columns(3).DefaultCellStyle.BackColor = Color.Thistle
                .Columns(4).DefaultCellStyle.BackColor = Color.Thistle
                .Columns(5).DefaultCellStyle.BackColor = Color.Thistle
                .Columns(6).DefaultCellStyle.BackColor = Color.Thistle

                .DefaultCellStyle.SelectionBackColor = Color.Aqua
                Me.lblFucsia.Visible = True
            End With
            Me.picFoto.Image = Nothing
        End If
    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click
        Call ErroresPri()
        Me.lblAmbar.Visible = False
        Me.lblVerde.Visible = False
        Me.lblRed.Visible = False
        Me.lblFucsia.Visible = False
        SW = False
        Me.dtgListado.DataSource = Nothing
        Dim svSQL As String
        svSQL = "SELECT * FROM Productos  ORDER BY Cod_Productos"
        Dim cmd As New OleDbCommand(svSQL, cnnBD)
        Dim dtr As OleDbDataReader
        dtr = cmd.ExecuteReader
        Dim dtb As New DataTable
        dtb.Load(dtr)
        Me.dtgListado.DataSource = dtb
        Me.dtgListado.Columns(7).Visible = False
        cmd = Nothing : dtb = Nothing : dtr = Nothing
        With Me.dtgListado

            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            .RowHeadersWidth = CInt(.Width * 0.03)
            .Columns(0).Width = CInt(.Width * 0.12)
            .Columns(1).Width = CInt(.Width * 0.28)
            .Columns(2).Width = CInt(.Width * 0.11)
            .Columns(3).Width = CInt(.Width * 0.12)
            .Columns(4).Width = CInt(.Width * 0.14)
            .Columns(5).Width = CInt(.Width * 0.1)
            .Columns(6).Width = CInt(.Width * 0.1)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(0).HeaderText = "Cod. Productos"
            .Columns(1).HeaderText = "Descripción"
            .Columns(2).HeaderText = "Precio por Unidad"
            .Columns(3).HeaderText = "Precio por Empaque"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "Existencia"
            .Columns(6).HeaderText = "Stock Mínimo"

            Dim sSql As String = ""
            Dim exis As Long
            Dim Stock As Long
            Dim vp As Long
            For Each rw As DataGridViewRow In Me.dtgListado.Rows
                exis = rw.Cells(5).Value
                Stock = rw.Cells(6).Value
                sSql = "SELECT * FROM Productos WHERE Cod_Productos='" & rw.Cells(0).Value & "'"
                Dim cmd3 As New OleDbCommand(sSql, cnnBD)
                cmd3.ExecuteNonQuery()
                If exis < Stock Then
                    rw.DefaultCellStyle.BackColor = Color.Thistle
                Else
                    If exis = Stock Then
                        rw.DefaultCellStyle.BackColor = Color.IndianRed
                    Else
                        vp = (Stock * 50 / 100) + Stock
                        If exis < vp Then
                            rw.DefaultCellStyle.BackColor = Color.PeachPuff
                        Else
                            If exis > Stock Then
                                rw.DefaultCellStyle.BackColor = Color.PaleTurquoise
                            End If
                        End If
                    End If
                End If
            Next
        End With
        Me.picFoto.Image = Nothing
    End Sub
    Private Sub txtexistencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtexistencia.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtexistencia, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtexistencia, "Este campo sólo" & Chr(13) & _
                                               "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtprecioU.Focus()
        End If
    End Sub
    Private Sub txtstockM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstockM.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtstockM, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtstockM, "Este campo sólo" & Chr(13) & _
                                           "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnagregar.PerformClick()
        End If
    End Sub

    Private Sub picFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFoto.Click
        Call ErroresPri()
        If ID_ACCESO = 2 Then
            Me.picFoto.Enabled = False
        Else
            Try
                If txtimag.Text <> "" Then
                    Call Buscar_Imag()
                    If SW = True Then
                        Me.picFoto.Enabled = False
                        Me.lblAmbar.Visible = False
                        Me.lblFucsia.Visible = False
                        Me.lblRed.Visible = False
                        Me.lblVerde.Visible = False
                        Me.txtcodP.Text = ""
                        Me.txtCodPro.Text = ""
                        Me.cboCodPro.Text = "Seleccionar"
                        Me.txtdescripcion.Text = ""
                        Me.txtprecioU.Text = ""
                        Me.txtprecioE.Text = ""
                        Me.txtmarca.Text = ""
                        Me.txtexistencia.Text = ""
                        Me.txtstockM.Text = ""
                        Me.txtimag.Clear()
                        Me.txtimag2.Clear()
                        Me.picFoto.Image = Nothing
                        Me.cboCodPro.Select()
                        Exit Sub
                    End If
                Else
                    Call Buscar_Imag()
                    If SW = True Then
                        Me.picFoto.Enabled = False
                        Me.lblAmbar.Visible = False
                        Me.lblFucsia.Visible = False
                        Me.lblRed.Visible = False
                        Me.lblVerde.Visible = False
                        Me.txtcodP.Text = ""
                        Me.txtCodPro.Text = ""
                        Me.cboCodPro.Text = "Seleccionar"
                        Me.txtdescripcion.Text = ""
                        Me.txtprecioU.Text = ""
                        Me.txtprecioE.Text = ""
                        Me.txtmarca.Text = ""
                        Me.txtexistencia.Text = ""
                        Me.txtstockM.Text = ""
                        Me.txtimag.Clear()
                        Me.txtimag2.Clear()
                        Me.picFoto.Image = Nothing
                        Me.cboCodPro.Select()
                        Exit Sub
                    End If
                End If
                Me.picFoto.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
    Private Sub cboCodPro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCodPro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtdescripcion.Focus()
        End If
    End Sub
    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtmarca.Focus()
        End If
    End Sub
    Private Sub txtmarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtexistencia.Focus()
        End If
    End Sub
    Private Sub txtprecioU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecioU.KeyPress
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
            Me.txtprecioE.Focus()
        End If
    End Sub
    Private Sub txtprecioE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecioE.KeyPress
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
            Me.txtstockM.Focus()
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call ErroresPri()
        Me.lblAmbar.Visible = False
        Me.lblFucsia.Visible = False
        Me.lblRed.Visible = False
        Me.lblVerde.Visible = False
        Me.txtcodP.Text = ""
        Me.txtCodPro.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtprecioU.Text = ""
        Me.txtprecioE.Text = ""
        Me.txtmarca.Text = ""
        Me.txtexistencia.Text = ""
        Me.txtstockM.Text = ""
        Me.cboCodPro.Text = "Seleccionar"
        Me.txtimag.Clear()
        Me.picFoto.Image = Nothing
        Me.picFoto.Enabled = False
    End Sub
    Private Sub picFoto_MouseHover(sender As Object, e As System.EventArgs) Handles picFoto.MouseHover
        If ID_ACCESO = 2 Then
            Me.picFoto.Cursor = Cursors.Arrow
        End If
    End Sub
    Sub ErroresPri()
        Errores.SetError(Me.txtprecioU, Nothing)
        Errores.SetError(Me.txtprecioE, Nothing)
        Errores.SetError(Me.txtstockM, Nothing)
        Errores.SetError(Me.txtexistencia, Nothing)
    End Sub
End Class