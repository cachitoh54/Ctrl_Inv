Imports System.Data
Imports System.Data.OleDb
Public Class Factura_Compra
    Public cnnBD As New OleDbConnection
    Private SW As Boolean
    Private Resultado As Boolean
    Private WS As Boolean
    Private TFA As Boolean
    Private TFC As Boolean
    Private BOC As Boolean
    Private WSC As Boolean
    Private XCL As Boolean
    Private GF As Boolean
    Private MS As Boolean

    Private Sub Factura_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
            Me.btnguardar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnFactura.Enabled = False
            Me.btnIva.Enabled = False
            Me.Button1.Enabled = False
        Else
            If ID_ACCESO = 3 Then
                Me.btnEliminar.Enabled = False
            End If
        End If

        Me.txtfecha.Text = "00/00/0000"
        Me.txtfecha.ValidatingType = GetType(System.DateTime)
        Me.ToolFecha.IsBalloon = True

        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        Call LLENARCBOPROD()
        Call LLENARCBOPROV()
        Call MOSTRARIVA()
        Me.cbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtfactura.Clear()
        Me.txtfecha.Text = ""
        Me.txtIva.Enabled = False
        'Me.CMBPROV.SelectedIndex =
        'Me.cmbcodigo.SelectedIndex = 1
        Me.cbEstado.Text = "Seleccionar"
        Me.CMBPROV.Text = "Seleccionar"
        Me.cmbcodigo.Text = "Seleccionar"
        Me.txtcantidad.Clear()
        Me.txtprecioU.Clear()
        Me.txtprecioE.Clear()
        Me.cbEstado.Select()
    End Sub

    Private Sub Factura_Compra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call ErroresPri()
        Try
            If CF = True Then
                e.Cancel = False
            Else
                If TFA = False And BOC = False Then
                    XCL = True
                    Call ListDtg()
                    If SW = True Then
                        Call ListDtg()
                        Call AntCierre()
                        e.Cancel = True
                    Else
                        Menú.Show()
                    End If
                    If TFA = True Then
                        If SW = False Then
                        End If
                    ElseIf BOC = True Then
                        If SW = False Then
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            e.Cancel = True
        End Try
    End Sub
    Sub AntCierre()
        MsgBox("Asegurese de Cerrar" & vbCrLf & _
               "antes la Factura.", MsgBoxStyle.Exclamation, "Atención")
    End Sub
    Sub Cierre()
        Try
            Dim sfSQL As String
            sfSQL = "Select * From Factura_Compra Where Nro_Factura=" & Me.txtfactura.Text & ""
            Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
            dtr = cmdd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                Me.cbEstado.Text = dtr("Estado").ToString
                If Me.cbEstado.Text = "Abierto" Then
                    SW = True
                Else
                    Call Cierre2()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Cierre2()
        Try
            Dim sfSQL As String
            For Each mRow As DataGridViewRow In Me.dtgvlista.Rows
                If mRow.Cells(10).Value = "Abierto" Then
                    sfSQL = "Select Estado From Factura_Compra" 'Where Estado=" & Me.txtfactura.Text & ""
                    Dim cmd As New OleDbCommand(sfSQL, cnnBD)
                    dtr = cmd.ExecuteReader
                    If dtr.HasRows = True Then
                        SW = True
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub IrMenu()
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
    Private Sub btnir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnir.Click
        Call ErroresPri()
        Try
            If Me.txtfactura.Text = "" Or Me.txtfactura.Text <> "" Then
                TFA = True
                Call ListDtg()
                If SW = True Then
                    Call ListDtg()
                    Call AntCierre()
                    TFA = False
                    Exit Sub
                Else
                    If ID_ACCESO = 1 Then
                        Me.Visible = False
                        Menú.Show()
                        Me.Close()
                        Call Limpiar()
                        TFA = False
                    ElseIf ID_ACCESO = 2 Then
                        Me.Visible = False
                        Menú.Show()
                        Me.Close()
                        Call Limpiar()
                        TFA = False
                    ElseIf ID_ACCESO = 3 Then
                        Me.Visible = False
                        Menú.Show()
                        Me.Close()
                        Call Limpiar()
                        TFA = False
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Limpiar()
        Try
            Me.txtfact.Enabled = True
            Me.CMBPROV.Enabled = True
            Me.txtfact.Text = ""
            Me.txtfactura.Text = ""
            Me.CMBPROV.Text = ""
            Me.cmbcodigo.Text = ""
            Me.txtfecha.Text = ""
            Me.txtprecioU.Text = ""
            Me.txtprecioE.Text = ""
            Me.txtpeso.Text = ""
            Me.txttrans.Text = ""
            Me.txtcantidad.Text = ""
            If ID_ACCESO = 2 Then
                Me.btnguardar.Enabled = False
                Me.btnIva.Enabled = False
                Me.Button1.Enabled = False
            Else
                Me.btnguardar.Enabled = True
                Me.btnIva.Enabled = True
                Me.Button1.Enabled = True
            End If
            Me.lblCerrarF.Visible = False
            Me.dtgvlista.DataSource = Nothing
            Me.txtfecha.Enabled = True
            Me.CMBPROV.Text = "Seleccionar"
            Me.cbEstado.Text = "Seleccionar"
            Me.cmbcodigo.Text = "Seleccionar"
            Me.cbEstado.Select()
            SW = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Call ErroresPri()
        Try
            If cbEstado.SelectedIndex = -1 Or cbEstado.SelectedIndex = 0 Then
                MsgBox("Para Guardar, el Estado" & Chr(13) & _
                       "debe estar Abierto.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If cbEstado.SelectedIndex = 2 Then
                MsgBox("El Estado Seleccionado" & Chr(13) & _
                       "es Incorrecto.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            Me.txtfecha.Enabled = False
            Me.txtfactura.Enabled = False
            Me.txtfact.Enabled = False
            Me.CMBPROV.Enabled = False
            Me.txtIva.Enabled = False
            Me.btnIva.Enabled = False
            Me.Button1.Enabled = False

            If txtfactura.Text.Trim = "" Then
                MsgBox("El Campo Nro. de Factura" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtfecha.Enabled = True
                Me.txtfactura.Enabled = True
                Me.CMBPROV.Enabled = True
                Me.txtIva.Enabled = True
                Me.btnIva.Enabled = True
                Me.Button1.Enabled = True
                Exit Sub
            End If

            If CMBPROV.Text.Trim = "Seleccionar" Or CMBPROV.SelectedIndex <= -1 Then
                MsgBox("Debe Selccioar Un Proveedor.", MsgBoxStyle.Exclamation, "Atención")
                Me.CMBPROV.Enabled = True
                Me.txtIva.Enabled = True
                Me.btnIva.Enabled = True
                Me.Button1.Enabled = True
                Exit Sub
            End If

            If txtfecha.Text.Trim = "" Then
                MsgBox("El campo Fecha no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If cmbcodigo.Text.Trim = "" Then
                MsgBox("Debe Seleccionar un" & Chr(13) & _
                       "Código de Producto.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtprecioU.Text.Trim = "" Then
                MsgBox("El Campo Precio Unitario" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtprecioE.Text.Trim = "" Then
                MsgBox("El Campo Precio Empaque" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If txtpeso.Text.Trim = "" Then
                MsgBox("El Campo Peso Neto no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If txttrans.Text.Trim = "" Then
                MsgBox("El Campo Transporte no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtcantidad.Text.Trim = "" Then
                MsgBox("El Campo Cantidad no" & Chr(13) & _
                       "debe star vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If SW = False Then
                Call guardarfact()
                If SW = False Then
                    Call guardarproducto()
                    Call LLENARDATAGRID()
                Else
                    MsgBox("Esta Factura ya Existe.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtfactura.Text = ""
                    Me.txtfact.Text = ""
                    Me.txtfactura.Enabled = True
                    Me.txtfact.Enabled = True
                    Me.CMBPROV.Enabled = True
                    SW = False
                    Exit Sub
                End If
                MsgBox("Los Datos Fueron Guardados.", MsgBoxStyle.Information, "Información")
                Me.cmbcodigo.Text = ""
                Me.txtprecioU.Text = ""
                Me.txtprecioE.Text = ""
                Me.txtpeso.Text = ""
                Me.txttrans.Text = ""
                Me.txtcantidad.Text = ""
                Me.cmbcodigo.Select()
                SW = True
            Else
                Call guardarproducto()
                If Resultado = True Then
                    Me.cmbcodigo.Text = "Seleccionar"
                    Me.cmbcodigo.Select()
                    Exit Sub
                Else
                    Call LLENARDATAGRID()
                    MsgBox("Los Datos Fueron Guardados.", MsgBoxStyle.Information, "Información")
                    Me.cmbcodigo.Text = ""
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtpeso.Text = ""
                    Me.txttrans.Text = ""
                    Me.txtcantidad.Text = ""
                    Me.cmbcodigo.Select()
                    SW = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub guardarfact()
        Try

            Dim stSQL As String
            stSQL = "SELECT * FROM Factura_Compra WHERE Nro_Factura=" & Me.txtfactura.Text & ""
            Dim cmd1 As New OleDbCommand(stSQL, cnnBD)
            Dim dtr1 As OleDbDataReader
            dtr1 = cmd1.ExecuteReader
            If dtr1.HasRows = False Then
                stSQL = "INSERT INTO Factura_Compra " & _
                              "( Nro_Factura, Fecha, Cod_Proveedor, Iva, Estado) " & _
                              "VALUES (" & Me.txtfactura.Text & ", '" & Me.txtfecha.Text & "', '" & _
                              Me.CMBPROV.SelectedValue & "', " & Me.txtIva.Text & ", '" & Me.cbEstado.Text & "')"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteNonQuery()
            Else
                SW = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub guardarproducto()
        Try
            Dim stSQL As String
            stSQL = "INSERT INTO Producto_Compra (Nro_Factura, Cod_Productos, Cod_Proveedor, Precio_unidad, Precio_empaque, Peso, Transporte, Cantidad) " & _
                                 "VALUES (" & txtfactura.Text & ", '" & cmbcodigo.SelectedValue & "', '" & _
                                 CMBPROV.SelectedValue & "', " & txtprecioU.Text & ", " & txtprecioE.Text & ", " & Me.txtpeso.Text & ", " & Me.txttrans.Text & ", " & Me.txtcantidad.Text & ")"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            cmd.ExecuteNonQuery()
            Resultado = False
            Me.txtfact.Text = Me.txtfactura.Text
        Catch ex As Exception
            MsgBox("Este Producto ya está" & Chr(13) & _
                   "registrado para esta" & Chr(13) & _
                   "Factura y Proveedor.", MsgBoxStyle.Exclamation, "Atención")
            Resultado = True
            Exit Sub
        End Try
    End Sub
    Sub borrarfactura()
        Try
            Dim stSQL As String
            stSQL = "DELETE FROM Factura_Compra WHERE Nro_Factura=" & Me.txtfactura.Text & ""
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                    Me.txtfactura.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Call LLENARDATAGRID()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub LLENARDATAGRID()
        Try
            Dim sSQL As String
            sSQL = "SELECT p.Cod_Productos, f.Nro_Factura, f.Fecha, f.Cod_Proveedor, p.Precio_unidad, p.Precio_empaque, p.Peso, p.Transporte, p.Cantidad, f.Iva, f.Estado FROM Factura_Compra f, Producto_Compra p WHERE " & _
                   "f.Nro_Factura=" & Me.txtfactura.Text & " and " & _
                   "p.Nro_Factura=" & Me.txtfactura.Text & ";"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Factura_Compra")
                DTB.Load(dtr)
                dtgvlista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub LocProducto(ByVal sCed As String)
        Try
            Me.cmbcodigo.SelectedValue = ""
            Me.txtfactura.Text = ""
            Dim sSQL As String
            sSQL = "SELECT * FROM Factura_Compra WHERE Nro_Factura=" & sCed & ""
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            If dtr.HasRows = True Then
                Me.txtIva.Text = dtr("Iva").ToString

                Dim sstSQL As String
                sstSQL = "SELECT * FROM Productos WHERE Cod_Productos = '" & Me.cmbcodigo.Text & "'"
                Dim cmdd As New OleDbCommand(sstSQL, cnnBD)
                Dim dtrr As OleDbDataReader
                dtrr = cmdd.ExecuteReader
                dtrr.Read()

                Me.txtprecioU.Text = dtrr("Precio_unidad").ToString
                Me.txtprecioE.Text = dtrr("Precio_empaque").ToString

                Dim sttSQL As String
                sttSQL = "SELECT * FROM Producto_Compra WHERE Nro_Factura = '" & Me.txtcantidad.Text & "'"
                Dim ccmd As New OleDbCommand(sttSQL, cnnBD)
                Dim ddtr As OleDbDataReader
                ddtr = ccmd.ExecuteReader
                ddtr.Read()
                Me.txtcantidad.Text = ddtr("Cantidad").ToString
                Me.txtpeso.Text = dtrr("Peso").ToString
                Me.txttrans.Text = dtrr("Transporte").ToString

                Me.cmbcodigo.Text = Me.cmbcodigo.Text
                Me.txtcantidad.Text = Me.txtcantidad.Text
            Else
                MessageBox.Show("El Producto no fue localizado", "CodigoDeProducto" & sCed, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Call ErroresPri()
        For Each mRow As DataGridViewRow In Me.dtgvlista.Rows
            If mRow.Cells(10).Value = "Abierto" Then
                Call Cierre2()
                If WS = True Then
                    Call ListDtg()
                End If
                Call AntCierre()
                Exit Sub
            End If
        Next
        Try
            Dim sfSQL As String
            sfSQL = "Select * From Factura_Compra Where Nro_Factura=" & Me.txtfactura.Text & ""
            Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
            If Me.txtfactura.Text = "" Then
                Me.txtfact.Enabled = True
                Me.CMBPROV.Enabled = True
                Me.txtfecha.Clear()
                Me.txtfact.Text = ""
                Me.txtfactura.Text = ""
                Me.CMBPROV.Text = ""
                Me.cmbcodigo.Text = ""
                Me.txtprecioU.Text = ""
                Me.txtprecioE.Text = ""
                Me.txtpeso.Text = ""
                Me.txttrans.Text = ""
                Me.txtcantidad.Text = ""
                Me.btnguardar.Enabled = True
                Me.btnIva.Enabled = True
                Me.Button1.Enabled = True
                Me.lblCerrarF.Visible = False
                Me.dtgvlista.DataSource = Nothing
                Me.txtfecha.Enabled = True
                Me.CMBPROV.Text = "Seleccionar"
                Me.cbEstado.Text = "Seleccionar"
                Me.cmbcodigo.Text = "Seleccionar"
                Me.cbEstado.Select()
                SW = False
                Exit Sub
            Else
                If Me.txtfactura.Text <> "" Then
                    Me.txtfact.Enabled = True
                    Me.CMBPROV.Enabled = True
                    Me.txtfact.Text = ""
                    Me.txtfactura.Text = ""
                    Me.CMBPROV.Text = ""
                    Me.cmbcodigo.Text = ""
                    Me.txtfecha.Clear()
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtpeso.Text = ""
                    Me.txttrans.Text = ""
                    Me.txtcantidad.Text = ""
                    If ID_ACCESO = 2 Then
                        Me.btnguardar.Enabled = False
                        Me.btnIva.Enabled = False
                        Me.Button1.Enabled = False
                    Else
                        Me.btnguardar.Enabled = True
                        Me.btnIva.Enabled = True
                        Me.Button1.Enabled = True
                    End If
                    Me.lblCerrarF.Visible = False
                    Me.dtgvlista.DataSource = Nothing
                    Me.txtfecha.Enabled = True
                    Me.CMBPROV.Text = "Seleccionar"
                    Me.cbEstado.Text = "Seleccionar"
                    Me.cmbcodigo.Text = "Seleccionar"
                    Me.cbEstado.Select()
                    SW = False
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            Call ErroresPri()
        End Try
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call ErroresPri()
        If txtfactura.Text.Trim = "" Then
            MsgBox("Debe elegir una Factura.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Try
            If Me.txtfactura.Text <> "" Then
                Dim fecha = Me.txtfecha.Text
                Dim sSQL As String
                sSQL = "SELECT p.Cod_Productos, f.Nro_Factura, f.Fecha, f.Cod_Proveedor, p.Precio_unidad, p.Precio_empaque, p.Peso, p.Transporte, p.Cantidad, f.Iva, f.Estado FROM Factura_Compra f, Producto_Compra p WHERE " & _
                       "f.Nro_Factura=" & Me.txtfactura.Text & " and " & _
                       "p.Nro_Factura=" & Me.txtfactura.Text & ""
                Dim cmd As New OleDbCommand(sSQL, cnnBD)
                Dim dtr As OleDbDataReader
                dtr = cmd.ExecuteReader
                If dtr.HasRows = True Then
                    Dim dtb As New DataTable("Factura_Compra AND Producto_Compra AND Productos")
                    dtb.Load(dtr)
                    Me.dtgvlista.DataSource = dtb
                    cmd.Dispose()
                    dtr = Nothing
                    MOSTRARDATOS()
                    Call Buscar()
                Else
                    MsgBox("El Nro de Factura no Existe", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtfactura.Clear()
                    Me.txtfactura.Select()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            Call ErroresPri()
        End Try
    End Sub
    Sub Buscar()
        Try
            Dim sSQL As String
            sSQL = "SELECT p.Cod_Productos, f.Nro_Factura, f.Fecha, f.Cod_Proveedor, p.Precio_unidad, p.Precio_empaque, p.Peso, p.Transporte, p.Cantidad, f.Iva, f.Estado FROM Factura_Compra f, Producto_Compra p WHERE " & _
                   "f.Nro_Factura=" & Me.txtfactura.Text & " and " & _
                   "p.Nro_Factura=" & Me.txtfactura.Text & ""
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            Me.cmbcodigo.Text = dtr("Cod_productos").ToString
            Me.txtfactura.Text = dtr("Nro_Factura").ToString
            Me.txtfact.Text = dtr("Nro_Factura").ToString
            Me.txtfecha.Text = dtr("Fecha").ToString
            Me.CMBPROV.Text = dtr("Cod_Proveedor").ToString
            Me.txtIva.Text = dtr("IVA").ToString
            Me.txtprecioU.Text = dtr("Precio_unidad").ToString
            Me.txtprecioE.Text = dtr("Precio_empaque").ToString
            Me.txtpeso.Text = dtr("Peso").ToString
            Me.txttrans.Text = dtr("Transporte").ToString
            Me.txtcantidad.Text = dtr("Cantidad").ToString
            Me.cbEstado.Text = dtr("Estado").ToString
        Catch ex As Exception
            MsgBox("Esta Factura no existe.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtfactura.Clear()
        End Try
    End Sub

    Sub ListDtg()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT PC.Cod_Productos, F.Nro_Factura, F.Fecha, Pr.Cod_Proveedor, PC.Precio_unidad," & vbCrLf & _
                    "PC.Precio_empaque, PC.Peso, PC.Transporte, PC.Cantidad, F.Iva, F.Estado" & vbCrLf & _
                    "FROM Productos Pd INNER JOIN ((Proveedor Pr INNER JOIN Factura_Compra F" & vbCrLf & _
                    "ON Pr.Cod_Proveedor = F.Cod_Proveedor) INNER JOIN Producto_Compra PC ON" & vbCrLf & _
                    "F.Nro_Factura = PC.Nro_Factura) ON Pd.Cod_Productos = PC.Cod_Productos;"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Factura_Compra")
                DTB.Load(dtr)
                dtgvlista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
            Call Cierre2()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Sub salir()
        If MessageBox.Show("¿Desea Salir del Sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            If WSC = False Then
                WSC = True
            End If
        End If
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Call ErroresPri()
        Try
            If Me.txtfactura.Text = "" Or Me.txtfactura.Text <> "" Then
                BOC = True
                Call ListDtg()
                If SW = True Then
                    Call ListDtg()
                    Call AntCierre()
                    BOC = False
                    Exit Sub
                Else
                    Call salir()
                    If WSC = True Then
                        Me.dtgvlista.DataSource = Nothing
                        SW = False
                        End
                    Else
                        BOC = False
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub dtgvlist_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvlista.CellClick
        If sender.currentcell.columnIndex = 1 Then
            Datos(sender.CURRENTCELL.ROWINDEX)
            btnguardar.Enabled = False
        End If
    End Sub
    Private Sub dtgvlista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvlista.GotFocus
        If txtfactura.Text = "" Then
            GF = True
        Else
            GF = True
        End If
    End Sub

    Sub Datos(ByVal IND As Integer)
        Me.cmbcodigo.Text = dtgvlista.Rows(IND).Cells(0).Value
        Me.txtfactura.Text = dtgvlista.Rows(IND).Cells(1).Value
        Me.txtfecha.Text = dtgvlista.Rows(IND).Cells(2).Value
        Me.CMBPROV.Text = dtgvlista.Rows(IND).Cells(3).Value
        Me.txtprecioU.Text = dtgvlista.Rows(IND).Cells(4).Value
        Me.txtprecioE.Text = dtgvlista.Rows(IND).Cells(5).Value
        Me.txtpeso.Text = dtgvlista.Rows(IND).Cells(6).Value
        Me.txttrans.Text = dtgvlista.Rows(IND).Cells(7).Value
        Me.txtcantidad.Text = dtgvlista.Rows(IND).Cells(8).Value
        Me.txtIva.Text = dtgvlista.Rows(IND).Cells(9).Value
        Me.cbEstado.Text = dtgvlista.Rows(IND).Cells(10).Value
        MOSTRARDATOS()
    End Sub
    Sub MOSTRARDATOS()
        With Me.dtgvlista
            'Entra con la base de datos vacia
            If .Rows.Count <= 0 Then Exit Sub
            .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
            ' Deshabilitamos el estilo por defecto
            .EnableHeadersVisualStyles = False
            ' Deshabilitamos la modificación del alto de la columnas
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            ' Establecemos el alto del encabezado de las columnas
            .ColumnHeadersHeight = 50
            ' Establecemos el ancho de los encabezados
            ' De la columna encabezado de las fila (un % del ancho del grid)
            .RowHeadersWidth = CInt(.Width * 0.03)
            ' De las columnas
            .Columns(0).Width = CInt(.Width * 0.1)
            .Columns(1).Width = CInt(.Width * 0.09)
            .Columns(2).Width = CInt(.Width * 0.1)
            .Columns(3).Width = CInt(.Width * 0.09)
            .Columns(4).Width = CInt(.Width * 0.1)
            .Columns(5).Width = CInt(.Width * 0.1)
            .Columns(6).Width = CInt(.Width * 0.09)
            .Columns(7).Width = CInt(.Width * 0.09)
            .Columns(8).Width = CInt(.Width * 0.07)
            .Columns(9).Width = CInt(.Width * 0.05)
            .Columns(10).Width = CInt(.Width * 0.1)
            '.Columns(9).Width = CInt(.Width * 0.15)

            ' Colocamos texto al encabezado  de las columnas  (un % del ancho del grid)
            ' La columna 
            ' Alineamos (Centrado) los encabezados
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ' Alineamos el contenido de las columnas
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Creamos un estilo para encabezado y le modificamos sus propiedades
            Dim CellStyle As New DataGridViewCellStyle
            CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
            CellStyle.WrapMode = DataGridViewTriState.True
            CellStyle.BackColor = Color.FromArgb(162, 215, 255)
            CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
            CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle = CellStyle   ' Encabezado columnas
            .RowHeadersDefaultCellStyle = CellStyle      ' Encabezado filas
            ' Area de datos
            .DefaultCellStyle.SelectionBackColor = Color.Tan
            .DefaultCellStyle.SelectionForeColor = Color.Black
            '.Columns(4).DefaultCellStyle.Format = "-####.00"
            .Columns(0).HeaderText = "Código de Producto"
            .Columns(1).HeaderText = "Nro. de Factura"
            .Columns(2).HeaderText = "Fecha"
            .Columns(3).HeaderText = "Código de Proveedor"
            .Columns(4).HeaderText = "Precio por Unidad"
            .Columns(5).HeaderText = "Precio por Empaque"
            .Columns(6).HeaderText = "Peso Neto"
            .Columns(7).HeaderText = "Transporte"
            .Columns(8).HeaderText = "Cantidad"
            .Columns(9).HeaderText = "Iva%"
            .Columns(10).HeaderText = "Estado"

            For Each rw As DataGridViewRow In Me.dtgvlista.Rows
                rw.DefaultCellStyle.BackColor = Color.Azure
                rw.DefaultCellStyle.ForeColor = Color.Black
                If SW = True And (TFA = True Or BOC = True Or XCL = True) Then
                    If rw.Cells(10).Value = "Abierto" Then
                        rw.DefaultCellStyle.BackColor = Color.DarkRed
                        rw.DefaultCellStyle.ForeColor = Color.White
                    End If
                ElseIf SW = True Then
                    If rw.Cells(10).Value = "Abierto" Then
                        rw.DefaultCellStyle.BackColor = Color.DarkRed
                        rw.DefaultCellStyle.ForeColor = Color.White
                    End If
                End If
            Next
        End With
    End Sub
    Sub LLENARCBOPROD()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT * FROM Productos  ORDER BY Cod_Productos ASC"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim DTB As New DataTable
                DTB.Load(dtr)
                cmbcodigo.DataSource = DTB
                cmbcodigo.ValueMember = "Cod_Productos"
                cmbcodigo.DisplayMember = "Descripcion"
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub LLENARCBOPROV()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT * FROM Proveedor ORDER BY Cod_Proveedor ASC"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim DTB As New DataTable
                DTB.Load(dtr)
                CMBPROV.DataSource = DTB
                CMBPROV.ValueMember = "Cod_Proveedor"
                CMBPROV.DisplayMember = "Proveedor"
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub MOSTRARIVA()
        Try
            Dim stSQL As String
            stSQL = "SELECT * FROM IVA WHERE Id=1"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                Me.txtIva.Text = dtr("Porc").ToString
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProv.Click
        'Me.Hide()
        Call ErroresPri()
        If ID_ACCESO = 1 Then
            Proveedor.btncerrar.Enabled = False
            Proveedor.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 2 Then
            Proveedor.btncerrar.Enabled = False
            Proveedor.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 3 Then
            Proveedor.btncerrar.Enabled = False
            Proveedor.Show()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Call ErroresPri()
        If txtfactura.Text.Trim = "" Then
            MsgBox("El Campo Nro. de Factura" & Chr(13) & _
                   "no puede estar vacío", MsgBoxStyle.Exclamation, "Atención")
            Me.txtfactura.Select()
            Exit Sub
        Else
            Call ExiFact()
            If SW = False Then
                MsgBox("Esta Factura no existe." & vbCrLf & vbCrLf & _
                       Me.txtfactura.Text, MsgBoxStyle.Exclamation, "Atención")
                Call ErroresPri()
                Me.txtfecha.Clear()
                Me.txtfactura.Clear()
                Me.txtfact.Text = ""
                Me.txtfactura.Text = ""
                Me.CMBPROV.Text = ""
                Me.cmbcodigo.Text = ""
                Me.txtprecioU.Text = ""
                Me.txtprecioE.Text = ""
                Me.txtpeso.Text = ""
                Me.txttrans.Text = ""
                Me.txtcantidad.Text = ""
                Me.cmbcodigo.Text = "Seleccionar"
                Me.CMBPROV.Text = "Seleccionar"
                Me.txtfactura.Select()
                Exit Sub
            Else
                Try
                    Dim stSQL As String
                    stSQL = "DELETE FROM Factura_Compra WHERE Nro_Factura=" & Me.txtfactura.Text & ""
                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    If MessageBox.Show("¿Desea Eliminar El Registro?" & vbCrLf & vbCrLf & _
                            Me.txtfactura.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        cmd.ExecuteReader()
                        SW = False
                        Call LLENARDATAGRID()
                    End If
                    Me.txtfecha.Clear()
                    Me.txtfact.Text = ""
                    Me.txtfactura.Text = ""
                    Me.CMBPROV.Text = ""
                    Me.cmbcodigo.Text = ""
                    Me.txtprecioU.Text = ""
                    Me.txtprecioE.Text = ""
                    Me.txtpeso.Text = ""
                    Me.txttrans.Text = ""
                    Me.txtcantidad.Text = ""
                    Me.txtfecha.Enabled = True
                    Me.btnIva.Enabled = True
                    Me.Button1.Enabled = True
                    Me.txtfactura.Enabled = True
                    Me.txtfact.Enabled = True
                    Me.CMBPROV.Enabled = True
                    Call Lista()
                    MsgBox("Factura Eliminada.", MsgBoxStyle.Information, "Información")
                Catch ex As Exception
                    MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub
    Sub ExiFact()
        Try
            Dim srSQL As String
            srSQL = "Select * From Factura_Compra Where Nro_Factura= " & Me.txtfactura.Text
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
    Sub Eliminar()
        Try
            Dim stSQL As String
            stSQL = "Select * FROM Factura_Compra WHERE Nro_Factura=" & Me.txtfactura.Text
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
    Sub llenartabla()
        Try
            Dim sSQL As String
            sSQL = "SELECT p.Cod_Productos, f.Nro_Factura, f.Fecha, f.Cod_Proveedor, p.Precio_unidad, p.Precio_empaque, p.Peso, p.Transporte, p.Cantidad, f.Iva, f.Estado FROM Factura_Compra f, Producto_Compra p WHERE " & _
                   "f.Nro_Factura=" & Me.txtfactura.Text & " and " & _
                   "p.Nro_Factura=" & Me.txtfactura.Text & ""

            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim dtb As New DataTable("Factura_Compra AND Producto_Compra AND Productos")
                dtb.Load(dtr)
                Me.dtgvlista.DataSource = dtb
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LLENARDATAGRID()
    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Call ErroresPri()
        Try
            If cbEstado.SelectedIndex <> 2 Then
                MsgBox("Para Facturar, el Estado" & Chr(13) & _
                       "debe estar Cerrado.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            Dim serror As String = ""
            If txtfactura.Text.Trim = "" Then serror &= vbCrLf
            If CMBPROV.Text.Trim = "" Then serror &= vbCrLf
            If serror <> "" Then
                MsgBox("Debe hacer el procedimiento correcto" & Chr(13) & _
                       "sí desea Cerrar alguna Factura.", MsgBoxStyle.Exclamation, "Atención")
                Me.cmbcodigo.Text = ""
                Me.txtfecha.Text = ""
                Me.txtprecioU.Text = ""
                Me.txtprecioE.Text = ""
                Me.txtpeso.Text = ""
                Me.txttrans.Text = ""
                Me.txtcantidad.Text = ""
                Exit Sub
            Else
                Call Provee()
                If Resultado = True Then
                    MsgBox("Esta Factura ya está Cerrada.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtfactura.Text = ""
                    Me.txtpeso.Text = ""
                    Me.txttrans.Text = ""
                    Me.txtfact.Text = ""
                    Me.txtfecha.Enabled = True
                    Me.CMBPROV.Text = "Seleccionar"
                    Me.cbEstado.Text = "Seleccionar"
                    Me.cmbcodigo.Text = "Seleccionar"
                    Me.txtcantidad.Clear()
                    Me.txtprecioU.Clear()
                    Me.txtprecioE.Clear()
                    Me.txtfactura.Select()
                    Exit Sub
                Else
                    Dim sSql As String = ""
                    Dim Exist As Long = 0
                    For Each fRow As DataGridViewRow In Me.dtgvlista.Rows
                        If txtfactura.Text = fRow.Cells(1).Value Then
                            fRow.Selected = True
                            sSql = "SELECT * FROM Productos WHERE Cod_Productos='" & fRow.Cells(0).Value & "'"
                            Dim cmd As New OleDbCommand(sSql, cnnBD)
                            Dim dtr As OleDbDataReader
                            dtr = cmd.ExecuteReader
                            dtr.Read()
                            If dtr.HasRows = True Then
                                Dim n As Integer = dtr("Existencia").ToString
                                Dim m As Integer = fRow.Cells(8).Value
                                Exist = fRow.Cells(8).Value + dtr("Existencia").ToString
                                sSql = "UPDATE Productos SET Existencia=" & Exist & " " & _
                                                              " WHERE Cod_Productos='" & fRow.Cells(0).Value & "'"
                                Dim cmd2 As New OleDbCommand(sSql, cnnBD)
                                cmd2.ExecuteNonQuery()
                                cmd2.Dispose()
                            Else
                                sSql = "UPDATE Productos SET Existencia=" & Exist & " WHERE Cod_Productos='" & fRow.Cells(0).Value & "'"
                                Dim cmd2 As New OleDbCommand(sSql, cnnBD)
                                cmd2.ExecuteNonQuery()
                                cmd2.Dispose()
                            End If
                            sSql = "UPDATE Factura_Compra SET ESTADO='Cerrado' WHERE " & _
                                      "Nro_Factura=" & fRow.Cells(1).Value & "" & _
                                      " AND Cod_Proveedor='" & fRow.Cells(3).Value & "'"
                            Dim cmd3 As New OleDbCommand(sSql, cnnBD)
                            cmd3.ExecuteNonQuery()
                            cmd3.Dispose()
                            dtr.Close()
                            dtr = Nothing
                        End If
                    Next
                End If
            End If
            Call LLENARDATAGRID()
            Me.lblCerrarF.Visible = True
            MsgBox("Los Datos han sido Facturados.", MsgBoxStyle.Information, "Atención")
            Me.txtfecha.Clear()
            Me.txtfactura.Text = ""
            Me.txtfact.Text = ""
            Me.btnIva.Enabled = True
            Me.Button1.Enabled = True
            Me.CMBPROV.Text = "Seleccionar"
            Me.cmbcodigo.Text = "Seleccionar"
            Me.cbEstado.Text = "Seleccionar"
            Me.txtpeso.Text = ""
            Me.txttrans.Text = ""
            Me.txtcantidad.Text = ""
            Me.txtprecioU.Text = ""
            Me.txtprecioE.Text = ""
            Me.txtfecha.Enabled = True
            Me.btnguardar.Enabled = True
            Me.txtfactura.Enabled = True
            Me.txtfact.Enabled = True
            Me.CMBPROV.Enabled = True
            Me.lblCerrarF.Visible = False
            Me.cbEstado.Select()
            SW = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Provee()
        Try
            Dim srSQL As String
            srSQL = "Select * From Factura_Compra Where Nro_Factura =" & txtfactura.Text & ""
            Dim cmd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                dtr.Read()
                Me.cbEstado.Text = dtr("Estado").ToString
                If Me.cbEstado.Text = "Cerrado" Then
                    Resultado = True
                Else
                    Resultado = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub btnCerrarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblCerrarF.Visible = True
    End Sub
    Private Sub cbEstado_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbEstado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtfecha.Focus()
        End If
    End Sub
    Private Sub txtfecha_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfecha.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtfecha, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtfecha, "Este campo sólo" & Chr(13) & _
                                          "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtfactura.Focus()
        End If
    End Sub
    Private Sub txtfactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfactura.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtfactura, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtfactura, "Este campo sólo" & Chr(13) & _
                                            "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.CMBPROV.Focus()
        End If
    End Sub
    Private Sub CMBPROV_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CMBPROV.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbcodigo.Focus()
        End If
    End Sub
    Private Sub cmbcodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtcantidad.Focus()
        End If
    End Sub
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtcantidad, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtcantidad, "Este campo sólo" & Chr(13) & _
                                             "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtprecioU.Focus()
        End If
    End Sub

    Private Sub btnIva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIva.Click
        Call ErroresPri()
        Iva.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call ErroresPri()
        If ID_ACCESO = 2 Then
            Me.btnIva.Enabled = False
        End If
        Call MOSTRARIVA()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call ErroresPri()
        If Me.txtfactura.Text = "" Then
            Me.txtfecha.Clear()
            Me.txtfactura.Text = ""
            Me.txtfact.Text = ""
            Me.CMBPROV.Text = "Seleccionar"
            Me.cmbcodigo.Text = "Seleccionar"
            Me.txtpeso.Clear()
            Me.txttrans.Clear()
            Me.txtcantidad.Clear()
            Me.txtprecioU.Clear()
            Me.txtprecioE.Clear()
            Me.txtfactura.Enabled = True
            Me.txtfact.Enabled = True
            Me.CMBPROV.Enabled = True
            Exit Sub
        End If
        Try
            If Me.txtfactura.Enabled = True Then
                Dim sfSQL As String
                For Each mRow As DataGridViewRow In Me.dtgvlista.Rows
                    If mRow.Cells(10).Value = "Abierto" Then
                        sfSQL = "Select * From Factura_Compra Where Nro_Factura=" & Me.txtfactura.Text & ""
                        Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
                        dtr = cmdd.ExecuteReader
                        If dtr.HasRows = False Then
                            Call AntCierre()
                            Exit Sub
                        End If
                    Else
                        Call ListDtg()
                        If SW = True Then
                            Call ListDtg()
                            Call AntCierre()
                            Exit Sub
                        End If
                    End If
                Next
                Me.txtfecha.Clear()
                Me.txtfactura.Text = ""
                Me.txtfact.Text = ""
                Me.CMBPROV.Text = "Seleccionar"
                Me.cmbcodigo.Text = "Seleccionar"
                Me.txtpeso.Clear()
                Me.txttrans.Clear()
                Me.txtcantidad.Clear()
                Me.txtprecioU.Clear()
                Me.txtprecioE.Clear()
                Me.txtfactura.Enabled = True
                Me.txtfact.Enabled = True
                Me.CMBPROV.Enabled = True
            Else
                Me.cmbcodigo.Text = "Seleccionar"
                Me.txtpeso.Clear()
                Me.txttrans.Clear()
                Me.txtcantidad.Clear()
                Me.txtprecioU.Clear()
                Me.txtprecioE.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub

    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        Call ErroresPri()
        Try
            Call ListDtg()
            If SW = True Then
                Call ListDtg()
                Call AntCierre()
                Exit Sub
            Else
                Call ListDtg()
            End If

            Me.btnguardar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Lista()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT PC.Cod_Productos, F.Nro_Factura, F.Fecha, Pr.Cod_Proveedor, PC.Precio_unidad, PC.Precio_empaque, PC.Peso, PC.Transporte, PC.Cantidad, F.Iva, F.Estado FROM Productos Pd INNER JOIN ((Proveedor Pr INNER JOIN Factura_Compra F ON Pr.Cod_Proveedor = F.Cod_Proveedor) INNER JOIN Producto_Compra PC ON F.Nro_Factura = PC.Nro_Factura) ON Pd.Cod_Productos = PC.Cod_Productos;"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Factura_Compra")
                DTB.Load(dtr)
                dtgvlista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
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
            Me.txtpeso.Focus()
        End If
    End Sub
    Private Sub txtpeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpeso.KeyPress
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
            Me.txttrans.Focus()
        End If
    End Sub
    Private Sub txttrans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttrans.KeyPress
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
            Me.btnguardar.PerformClick()
        End If
    End Sub

    Private Sub dtgvlista_ColumnAdded(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dtgvlista.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub txtIva_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtIva.KeyPress
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
    End Sub
   
    Sub ErroresPri()
        Errores.SetError(Me.txtcantidad, Nothing)
        Errores.SetError(Me.txtfactura, Nothing)
        Errores.SetError(Me.txtprecioE, Nothing)
        Errores.SetError(Me.txtprecioU, Nothing)
        Errores.SetError(Me.txtpeso, Nothing)
        Errores.SetError(Me.txttrans, Nothing)
        Errores.SetError(Me.txtfecha, Nothing)
    End Sub

    Private Sub txtfecha_TypeValidationCompleted(sender As System.Object, e As System.Windows.Forms.TypeValidationEventArgs) Handles txtfecha.TypeValidationCompleted
        If Me.txtfecha.MaskFull = True Then
            If (Not e.IsValidInput) Then
                Me.ToolFecha.ToolTipTitle = "Dato Invalido"
                Me.ToolFecha.Show("La Fecha que ha ingresado es incorrecta!", Me.txtfecha, 0, -20, 4000)
                Me.txtfecha.Clear()
                Me.txtfecha.Select()
                e.Cancel = True
            End If
        End If
    End Sub
End Class