Imports System.Data
Imports System.Data.OleDb
Public Class Salida_Producto
    Private cnnBD As New OleDbConnection
    Private SW As Boolean
    Private Resultado As Boolean
    Private monto As Boolean
    Private WS As Boolean
    Private TFA As Boolean
    Private TFC As Boolean
    Private BOC As Boolean
    Private WSC As Boolean
    Private XCL As Boolean
    Private GF As Boolean
    Private Sub Salida_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
            Me.btnEntre.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.btnEliminar.Enabled = False
            'Me.btnagregar.Enabled = False
        ElseIf ID_ACCESO = 3 Then
            Me.btnEliminar.Enabled = False
        End If

        Me.txtfecha.Text = "00/00/0000"
        Me.txtfecha.ValidatingType = GetType(System.DateTime)
        Me.ToolFecha.IsBalloon = True

        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        ' AbrirConexion()
        If cheTipo.Checked = True Then
            Me.txtCantidad.Visible = False
            Me.lblCantidad.Visible = False
            Me.txtdev.Visible = True
            Me.lbldev.Visible = True
        Else
            Me.txtCantidad.Visible = True
            Me.lblCantidad.Visible = True
            Me.txtdev.Visible = False
            Me.lbldev.Visible = False
        End If
        Call LLENARCBOPROD()
        Call LlenarcmbNomE()
        Me.cbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbNomE.Text = "Seleccionar"
        Me.cmbcodigo.Text = "Seleccionar"
        Me.cbEstado.Text = "Seleccionar"
        Me.txtfecha.Clear()
        Me.txtCodE.Clear()
        Me.cbEstado.Select()
    End Sub
    Private Sub Salida_Producto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Sub salir()
        If MessageBox.Show("¿Desea Salir del Sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            If WSC = False Then
                WSC = True
            End If
        End If
    End Sub
    Sub AntCierre()
        MsgBox("Asegurese de Cerrar antes" & vbCrLf & _
               "el Número de Orden.", MsgBoxStyle.Exclamation, "Atención")
    End Sub
   
    Sub Cierre()
        Try
            Dim sfSQL As String
            sfSQL = "Select * From Salida_Entrega Where Nro_Orden=" & Me.txtNorden.Text & ""
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
            For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
                If mRow.Cells(9).Value = "Abierto" Then
                    sfSQL = "Select Estado From Salida_Entrega" 'Where Estado=" & Me.txtfactura.Text & ""
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
    Sub ListDtg()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT SE.Cod_Empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos," & vbCrLf & _
                    "SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion," & vbCrLf & _
                    "SE.Estado FROM Salida_Entrega SE INNER JOIN Salida_Devolucion SD ON " & vbCrLf & _
                    "SE.Nro_Orden = SD.Nro_Orden;"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Salida_Entrega")
                DTB.Load(dtr)
                dtgvLista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
            Call Cierre2()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call ErroresPri()
        Try
            If cbEstado.SelectedIndex = -1 Or cbEstado.SelectedIndex = 0 Then
                MsgBox("Para Guaradar, El estado" & Chr(13) & _
                       "debe estar Abierto.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If cbEstado.SelectedIndex = 2 Then
                MsgBox("El Estado Es Incorrecto.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtfecha.Text.Trim = "" Then
                MsgBox("El Campo Fecha no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If cmbNomE.Text.Trim = "" Then
                MsgBox("El Campo Nombre no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If cmbcodigo.Text.Trim = "" Then
                MsgBox("El Campo Código de Producto" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtCodE.Text.Trim = "" Then
                MsgBox("El Campo Código de Empleado" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtNorden.Text.Trim = "" Then
                MsgBox("El Campo Nro. de Orden" & Chr(13) & _
                       "no debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If txtProductos.Text.Trim = "" Then
                MsgBox("El Campo Producto no" & Chr(13) & _
                       "debe estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If

            If cheTipo.Checked = False Then
                If txtCantidad.Text.Trim = "" Then
                    MsgBox("El Campo Cantidad no" & Chr(13) & _
                           "debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtCantidad.Clear()
                    Me.txtCantidad.Select()
                    Exit Sub
                End If
            Else
                If cheTipo.Checked = True Then
                    If txtdev.Text.Trim = "" Then
                        MsgBox("El Campo Devolución no" & Chr(13) & _
                               "debe estar vacio.", MsgBoxStyle.Exclamation, "Atención")
                        Me.txtdev.Clear()
                        Me.txtdev.Select()
                        Exit Sub
                    End If
                End If
            End If

            If SW = False Then
                Call guarEntrega()
                If monto = True Then
                    Exit Sub
                End If
                If SW = False Then
                    Call guardarSalida()
                    Call LlenarLista()
                Else
                    MsgBox("Este Nro. de Orden ya Existe.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtNorden.Text = ""
                    Me.txtNorden.Select()
                    SW = False
                    Exit Sub
                End If
                MsgBox("Los Datos Fueron Guardados.", MsgBoxStyle.Information, "Información")
                Me.txtfecha.Enabled = False
                Me.cheTipo.Enabled = False
                Me.cmbNomE.Enabled = False
                Me.txtCodE.Enabled = False
                Me.txtNorden.Enabled = False
                Me.cmbcodigo.Text = ""
                Me.txtProductos.Text = ""
                Me.txtCantidad.Text = ""
                Me.txtdev.Text = ""
                Me.cmbcodigo.Text = "Seleccionar"
                Me.cmbcodigo.Select()
                SW = True
            Else
                If cheTipo.Checked = True Then
                    Call guardarSalida()
                    If Resultado = True Then
                        Me.cmbcodigo.Text = "Seleccionar"
                        Me.cmbcodigo.Select()
                        Exit Sub
                    Else
                        Call LlenarLista()
                        MsgBox("Los Datos fueron Guardados.", MsgBoxStyle.Information, "Información")
                        Me.txtfecha.Enabled = False
                        Me.cheTipo.Enabled = False
                        Me.cmbNomE.Enabled = False
                        Me.txtCodE.Enabled = False
                        Me.txtNorden.Enabled = False
                        'Me.txtfecha.Text = ""
                        Me.cmbcodigo.Text = ""
                        Me.txtProductos.Text = ""
                        Me.txtdev.Text = ""
                        Me.txtCantidad.Text = ""
                        Me.cmbcodigo.Text = "Seleccionar"
                        Me.cmbcodigo.Select()
                        SW = True
                    End If
                ElseIf cheTipo.Checked = False Then
                        Call guardarSalida()
                        If Resultado = True Then
                            Me.cmbcodigo.Text = "Seleccionar"
                            Me.cmbcodigo.Select()
                            Exit Sub
                        Else
                            Call LlenarLista()
                            MsgBox("Los Datos fueron Guardados.", MsgBoxStyle.Information, "Información")
                            Me.txtfecha.Enabled = False
                            Me.cmbNomE.Enabled = False
                            Me.txtCodE.Enabled = False
                            Me.txtNorden.Enabled = False
                            'Me.txtfecha.Text = ""
                            Me.cmbcodigo.Text = ""
                            Me.txtProductos.Text = ""
                            Me.txtdev.Text = ""
                            Me.txtCantidad.Text = ""
                            Me.cmbcodigo.Text = "Seleccionar"
                            Me.cmbcodigo.Select()
                            SW = True
                        End If
                    End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub cantidad()
        Try
            Dim ssql As String
            ssql = "SELECT * FROM Productos WHERE Cod_productos = '" & Me.cmbcodigo.SelectedValue & "'" & _
            "AND Existencia <" & Me.txtCantidad.Text
            Dim cmd As New OleDbCommand(ssql, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            If dtr.HasRows = False Then
                monto = False
            Else
                monto = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub guarEntrega()
        Try
            If cheTipo.Checked = False Then
                Call cantidad()
                If monto = True Then
                    Dim SQL As String
                    SQL = "Select * From Productos Where Cod_Productos='" & Me.cmbcodigo.Text & "' Or Descripcion='" & Me.cmbcodigo.Text & "'"
                    Dim cmd As New OleDbCommand(SQL, cnnBD)
                    Dim dtr As OleDbDataReader
                    dtr = cmd.ExecuteReader
                    dtr.Read()
                    Me.lblExistencia.Text = dtr("Existencia").ToString

                    MsgBox("La cantidad que se dispone a entregar" & Chr(13) & _
                           "es mayor a la existente y usted tan solo" & Chr(13) & _
                           "cuenta con..." & Chr(13) & Chr(13) & _
                           "(" & Me.lblExistencia.Text & ") unidades de este Producto.", MsgBoxStyle.Exclamation, "Atención")
                    Me.txtCantidad.Clear()
                    Me.txtCantidad.Select()
                    Exit Sub
                Else
                    Dim fecha = Me.txtfecha.Text
                    Dim stSQL As String
                    stSQL = "SELECT * FROM Salida_Entrega WHERE Nro_Orden =" & Me.txtNorden.Text
                    Dim cmd1 As New OleDbCommand(stSQL, cnnBD)
                    Dim dtr1 As OleDbDataReader
                    dtr1 = cmd1.ExecuteReader
                    If dtr1.HasRows = False Then
                        stSQL = "INSERT INTO Salida_Entrega " & _
                                      "(Nro_Orden, Cod_Empleado, Fecha, Cedula, Nombres, Estado) " & _
                                      "VALUES (" & Me.txtNorden.Text & ", '" & Me.txtCodE.Text & "', '" & fecha & _
                                      "', '" & Me.txtci.Text & "', '" & _
                                      Me.cmbNomE.Text & "', '" & Me.cbEstado.Text & "')"
                        Dim cmd As New OleDbCommand(stSQL, cnnBD)
                        cmd.ExecuteNonQuery()
                    Else
                        SW = True
                    End If
                End If
            Else
                If cheTipo.Checked = True Then
                    Dim fecha = Me.txtfecha.Text
                    Dim stSQL As String
                    stSQL = "SELECT * FROM Salida_Entrega WHERE Nro_Orden =" & Me.txtNorden.Text
                    Dim cmd1 As New OleDbCommand(stSQL, cnnBD)
                    Dim dtr1 As OleDbDataReader
                    dtr1 = cmd1.ExecuteReader
                    If dtr1.HasRows = False Then
                        stSQL = "INSERT INTO Salida_Entrega " & _
                                      "(Nro_Orden, Cod_Empleado, Fecha, Cedula, Nombres, Estado) " & _
                                      "VALUES (" & Me.txtNorden.Text & ", '" & Me.txtCodE.Text & "', '" & fecha & _
                                      "', '" & Me.txtci.Text & "', '" & _
                                      Me.cmbNomE.Text & "', '" & Me.cbEstado.Text & "')"
                        Dim cmd As New OleDbCommand(stSQL, cnnBD)
                        cmd.ExecuteNonQuery()
                    Else
                        SW = True
                    End If
                End If
            End If
            Me.cmbcodigo.Text = Me.cmbcodigo.Text
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub guardarSalida()
        Try
            If cheTipo.Checked = False Then
                Dim stSQL As String
                stSQL = "INSERT INTO Salida_Devolucion " & _
                              "(Cod_empleado, Cod_Productos, Nro_Orden, Cantidad, Descripcion)" & _
                              "VALUES ('" & Me.txtCodE.Text & "', '" & Me.cmbcodigo.SelectedValue & "', " & _
                              Me.txtNorden.Text & ", '" & Me.txtCantidad.Text & "', '" & Me.txtProductos.Text & "')"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteNonQuery()
                Resultado = False
                Me.cmbcodigo.Text = Me.cmbcodigo.Text
            Else
                If cheTipo.Checked = True Then
                    Dim sdSQL As String
                    sdSQL = "INSERT INTO Salida_Devolucion " & _
                                  "(Cod_empleado, Cod_Productos, Nro_Orden, Devolucion, Descripcion) " & _
                                  "VALUES ('" & Me.txtCodE.Text & "', '" & Me.cmbcodigo.SelectedValue & "', " & _
                                  Me.txtNorden.Text & ", '" & txtdev.Text & "', '" & Me.txtProductos.Text & "')"
                    Dim cmd As New OleDbCommand(sdSQL, cnnBD)
                    cmd.ExecuteNonQuery()
                    Resultado = False
                    Me.cmbcodigo.Text = Me.cmbcodigo.Text
                End If
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox("Este Producto ya está registrado" & Chr(13) & _
                   "para este Número de Orden.", MsgBoxStyle.Exclamation, "Atención")
            Resultado = True
            Exit Sub
        End Try
    End Sub
    Sub Entrega()
        Try
            Dim srSQL As String
            srSQL = "Select * From Salida_Devolucion Where Nro_Orden =" & txtNorden.Text
            Dim cmd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmd.ExecuteReader
            If dtr.Read = False Then
                Resultado = False
            Else
                Resultado = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub LlenarLista()
        Try
            'If cheTipo.Checked = False Then
            Dim sSQL As String
            sSQL = "SELECT SE.Cod_empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos, SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion, SE.Estado FROM Salida_Entrega SE, Salida_Devolucion SD WHERE " & _
                   "SE.Nro_Orden=" & Me.txtNorden.Text & " and " & _
                   "SD.Nro_Orden=" & Me.txtNorden.Text & ";"
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Salida_Entrega")
                DTB.Load(dtr)
                dtgvLista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
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
            Else
                SW = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub LlenarcmbNomE()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT * FROM Empleados  ORDER BY Nombres ASC"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Empleados")
                DTB.Load(dtr)
                cmbNomE.DataSource = DTB
                cmbNomE.ValueMember = "Cod_Empleado"
                cmbNomE.DisplayMember = "Nombres"
            Else
                SW = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call ErroresPri()
        If txtNorden.Text.Trim = "" Then
            MsgBox("Debe seleccionar la Fecha, elegir un Nombre" & Chr(13) & _
                   "de Empleado y por último colocar el Número" & Chr(13) & _
                   "de Orden que desa buscar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Try
            Dim sfSQL As String
            For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
                If mRow.Cells(9).Value = "Abierto" Then
                    sfSQL = "Select * From Salida_Devolucion Where Nro_Orden=" & Me.txtNorden.Text & ""
                    Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
                    Dim dtr2 As OleDbDataReader
                    dtr2 = cmdd.ExecuteReader
                    If dtr2.HasRows = True Then
                        MsgBox("Asegurese de Cerrar antes" & vbCrLf & _
                               "el Número de Orden.", MsgBoxStyle.Exclamation, "Atención")
                        Exit Sub
                    End If
                End If
            Next
            Dim fecha = Me.txtfecha.Text
            Dim bSQL As String
            bSQL = "SELECT SE.Cod_empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos, SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion, SE.Estado FROM Salida_Entrega SE, Salida_Devolucion SD WHERE " & _
            "SE.Nro_Orden=" & Me.txtNorden.Text & " and " & _
            "SD.Nro_Orden=" & Me.txtNorden.Text & ""
           
            Dim cmd As New OleDbCommand(bSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            If dtr.HasRows = True Then
                Dim dtb As New DataTable("Salida_Entrega AND Salida_Devolucion AND Productos")
                dtb.Load(dtr)
                Me.dtgvLista.DataSource = dtb
                cmd.Dispose()
                dtr = Nothing
                MOSTRARDATOS()
            Else
                MsgBox("El Nro de Orden no Existe ó la" & Chr(13) & _
                       "Fecha y/o Empleado no coinciden.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtNorden.Clear()
                Me.txtNorden.Select()
                Exit Sub
            End If
            ''''
            Call Buscar()
            SW = False
            Me.txtNor.Text = Me.txtNorden.Text
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Buscar()

        Try
            Dim sSQL As String
            sSQL = "SELECT SE.Cod_empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos, SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion, SE.Estado FROM Salida_Entrega SE, Salida_Devolucion SD WHERE " & _
            "SE.Nro_Orden=" & Me.txtNorden.Text & " and " & _
            "SD.Nro_Orden=" & Me.txtNorden.Text & ""
            Dim cmd As New OleDbCommand(sSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            Me.cmbNomE.Text = dtr("Nombres").ToString
            Me.cmbcodigo.Text = dtr("Cod_Productos").ToString
            Me.txtCodE.Text = dtr("Cod_empleado").ToString
            Me.txtNorden.Text = dtr("Nro_Orden").ToString
            Me.txtfecha.Text = dtr("Fecha").ToString
            Me.txtProductos.Text = dtr("Descripcion").ToString
            Me.txtdev.Text = dtr("Devolucion").ToString
            Me.txtCantidad.Text = dtr("Cantidad").ToString
            Me.txtci.Text = dtr("Cedula").ToString
            Me.cbEstado.Text = dtr("Estado").ToString
            Dim a As Short = Val(Me.txtCantidad.Text)
            Dim b As Short = Val(Me.txtdev.Text)
            If a <> 0 Then
                Me.txtCantidad.Visible = True
                Me.lblCantidad.Visible = True
                Me.txtdev.Visible = False
                Me.lbldev.Visible = False
            End If
            If b <> 0 Then
                Me.txtdev.Visible = True
                Me.lbldev.Visible = True
                Me.txtCantidad.Visible = False
                Me.lblCantidad.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Este Nro. de Orden no existe.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtNorden.Clear()
        End Try
    End Sub

    Private Sub cmbNomE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNomE.SelectedIndexChanged
        Try
            txtci.Text = CType(Me.cmbNomE.DataSource, DataTable).Rows(Me.cmbNomE.SelectedIndex)("Cedula")
            txtCodE.Text = CType(Me.cmbNomE.DataSource, DataTable).Rows(Me.cmbNomE.SelectedIndex)("Cod_empleado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    
    Private Sub dtgvLista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvLista.GotFocus
        If txtNorden.Text = "" Then
            GF = True
        Else
            GF = True
        End If
    End Sub
    Private Sub dtgvLista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvLista.CellClick       
        If sender.currentcell.columnIndex = 3 Then
            Datos(sender.CURRENTCELL.ROWINDEX)
            btnGuardar.Enabled = False
        End If
    End Sub
    Sub Datos(ByVal IND As Integer)

        Me.cmbNomE.Text = dtgvLista.Rows(IND).Cells(2).Value
        Me.txtci.Text = dtgvLista.Rows(IND).Cells(1).Value
        Me.cmbcodigo.Text = dtgvLista.Rows(IND).Cells(4).Value
        Me.txtNorden.Text = dtgvLista.Rows(IND).Cells(3).Value
        Me.txtCantidad.Text = dtgvLista.Rows(IND).Cells(6).Value
        Me.txtdev.Text = dtgvLista.Rows(IND).Cells(7).Value
        Me.txtProductos.Text = dtgvLista.Rows(IND).Cells(8).Value
        Me.txtfecha.Text = dtgvLista.Rows(IND).Cells(5).Value
        Me.txtCodE.Text = dtgvLista.Rows(IND).Cells(0).Value
        Me.cbEstado.Text = dtgvLista.Rows(IND).Cells(9).Value
        MOSTRARDATOS()

    End Sub
    Sub MOSTRARDATOS()
        With Me.dtgvLista
            If .Rows.Count <= 0 Then Exit Sub
            .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            .RowHeadersWidth = CInt(.Width * 0.01)
            .Columns(0).Width = CInt(.Width * 0.08)
            .Columns(1).Width = CInt(.Width * 0.08)
            .Columns(2).Width = CInt(.Width * 0.14)
            .Columns(3).Width = CInt(.Width * 0.07)
            .Columns(4).Width = CInt(.Width * 0.08)
            .Columns(5).Width = CInt(.Width * 0.1)
            .Columns(6).Width = CInt(.Width * 0.08)
            .Columns(7).Width = CInt(.Width * 0.09)
            .Columns(8).Width = CInt(.Width * 0.2)
            .Columns(9).Width = CInt(.Width * 0.068)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim CellStyle As New DataGridViewCellStyle
            CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
            CellStyle.WrapMode = DataGridViewTriState.True
            CellStyle.BackColor = Color.FromArgb(162, 215, 255)
            CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
            CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle = CellStyle
            .RowHeadersDefaultCellStyle = CellStyle

            .Columns(0).HeaderText = "Cod. de Empleado"
            .Columns(1).HeaderText = "Cédula"
            .Columns(2).HeaderText = "Nombre"
            .Columns(3).HeaderText = "Nro de Orden"
            .Columns(4).HeaderText = "Cod de Producto"
            .Columns(5).HeaderText = "Fecha"
            .Columns(6).HeaderText = "Cantidad"
            .Columns(7).HeaderText = "Devolución"
            .Columns(8).HeaderText = "Descripción"
            .Columns(9).HeaderText = "Estado"

            .DefaultCellStyle.SelectionBackColor = Color.Orange
            .DefaultCellStyle.SelectionForeColor = Color.Black

            Dim sSql As String
            Dim entrega As Long
            Dim salida As Long
            For Each rw As DataGridViewRow In Me.dtgvLista.Rows
                sSql = "SELECT * FROM Salida_Devolucion WHERE Cantidad=" & rw.Cells(6).Value & " AND Devolucion=" & rw.Cells(7).Value & ""
                Dim cmd3 As New OleDbCommand(sSql, cnnBD)
                cmd3.ExecuteReader()
                If entrega = rw.Cells(6).Value Then
                    rw.DefaultCellStyle.BackColor = Color.PaleTurquoise
                    rw.DefaultCellStyle.ForeColor = Color.Black
                End If
                If salida = rw.Cells(7).Value Then
                    rw.DefaultCellStyle.BackColor = Color.Pink
                    rw.DefaultCellStyle.ForeColor = Color.Black
                End If
                If SW = True And (TFA = True Or BOC = True Or XCL = True) Then
                    If rw.Cells(9).Value = "Abierto" Then
                        rw.DefaultCellStyle.BackColor = Color.DarkRed
                        rw.DefaultCellStyle.ForeColor = Color.White
                    End If
                ElseIf SW = True Then
                    If rw.Cells(9).Value = "Abierto" Then
                        rw.DefaultCellStyle.BackColor = Color.DarkRed
                        rw.DefaultCellStyle.ForeColor = Color.White
                    End If
                End If
            Next
            Dim a As Short = Val(Me.txtCantidad.Text)
            Dim b As Short = Val(Me.txtdev.Text)
            If a <> 0 Then
                Me.txtCantidad.Visible = True
                Me.lblCantidad.Visible = True
                Me.txtdev.Visible = False
                Me.lbldev.Visible = False
            End If
            If b <> 0 Then
                Me.txtdev.Visible = True
                Me.lbldev.Visible = True
                Me.txtCantidad.Visible = False
                Me.lblCantidad.Visible = False
            End If
        End With
    End Sub

    Private Sub btnEntre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntre.Click
        Call ErroresPri()
        Try
            If cbEstado.SelectedIndex <> 2 Then
                MsgBox("El estado debe ser Cerrado.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            If Me.txtNorden.Text = "" Then
                MsgBox("Bebe guardar primero un" & Chr(13) & _
                       "Nro. de Orden.", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            Else
                Call Nro()
                If Resultado = True Then
                    MsgBox("Este Nro. de Orden ya existe.", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                Else
                    If SW = False Then
                        Exit Sub
                    Else
                        If cheTipo.Checked = False Then
                            Dim ssql As String = ""
                            Dim Exist As Long = 0
                            For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
                                If txtNorden.Text = mRow.Cells(3).Value Then
                                    mRow.Selected = True
                                    ssql = "SELECT * FROM Productos WHERE Cod_productos = '" & mRow.Cells(4).Value & "'"
                                    Dim cmd As New OleDbCommand(ssql, cnnBD)
                                    Dim dtr As OleDbDataReader
                                    dtr = cmd.ExecuteReader
                                    dtr.Read()
                                    If dtr.HasRows = True Then
                                        Dim n As Integer = dtr("Existencia").ToString
                                        Dim m As Integer = mRow.Cells(6).Value
                                        Exist = dtr("Existencia").ToString - mRow.Cells(6).Value
                                        ssql = "UPDATE Productos SET Existencia=" & Exist & " " & _
                                                                      " WHERE Cod_Productos='" & mRow.Cells(4).Value & "'"
                                        Dim cmd2 As New OleDbCommand(ssql, cnnBD)
                                        cmd2.ExecuteNonQuery()
                                        cmd2.Dispose()
                                    Else
                                        ssql = "UPDATE Productos SET Existencia=" & Exist & " WHERE Cod_Productos='" & mRow.Cells(7).Value & "'"
                                        Dim cmd2 As New OleDbCommand(ssql, cnnBD)
                                        cmd2.ExecuteNonQuery()
                                        cmd2.Dispose()
                                    End If
                                    ssql = "UPDATE Salida_Entrega SET ESTADO='Cerrado' WHERE " & _
                                                      "Nro_Orden=" & mRow.Cells(3).Value & "" & _
                                                      "AND Cod_empleado=" & mRow.Cells(0).Value & ""
                                    Dim cmd3 As New OleDbCommand(ssql, cnnBD)
                                    cmd3.ExecuteNonQuery()
                                    cmd3.Dispose()
                                    dtr.Close()
                                    dtr = Nothing
                                End If
                            Next
                        Else
                            If cheTipo.Checked = True Then
                                Dim ssql2 As String = ""
                                Dim Exist2 As Long = 0
                                For Each nRow As DataGridViewRow In Me.dtgvLista.Rows
                                    If txtNorden.Text = nRow.Cells(3).Value Then
                                        nRow.Selected = True
                                        ssql2 = "SELECT * FROM Productos WHERE Cod_productos = '" & nRow.Cells(4).Value & "'"
                                        Dim cmd As New OleDbCommand(ssql2, cnnBD)
                                        Dim dtr As OleDbDataReader
                                        dtr = cmd.ExecuteReader
                                        dtr.Read()
                                        If dtr.HasRows = True Then
                                            Dim n As Integer = dtr("Existencia").ToString
                                            Dim m As Integer = nRow.Cells(7).Value
                                            Exist2 = nRow.Cells(7).Value + dtr("Existencia").ToString
                                            ssql2 = "UPDATE Productos SET Existencia=" & Exist2 & " " & _
                                                                          " WHERE Cod_Productos='" & nRow.Cells(4).Value & "'"
                                            Dim cmd2 As New OleDbCommand(ssql2, cnnBD)
                                            cmd2.ExecuteNonQuery()
                                            cmd2.Dispose()
                                        Else
                                            ssql2 = "UPDATE Productos SET Existencia=" & Exist2 & " WHERE Cod_Productos='" & nRow.Cells(7).Value & "'"
                                            Dim cmd2 As New OleDbCommand(ssql2, cnnBD)
                                            cmd2.ExecuteNonQuery()
                                            cmd2.Dispose()
                                        End If

                                        ssql2 = "UPDATE Salida_Entrega SET ESTADO='Cerrado' WHERE " & _
                                                  "Nro_Orden=" & nRow.Cells(3).Value & "" & _
                                                  "AND Cod_empleado=" & nRow.Cells(0).Value & ""
                                        Dim cmd3 As New OleDbCommand(ssql2, cnnBD)
                                        cmd3.ExecuteNonQuery()
                                        cmd3.Dispose()
                                        dtr.Close()
                                        dtr = Nothing
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            End If
            Call LlenarLista()
            If cheTipo.Checked = False Then
                Me.lblEntrega.Visible = True
            Else
                If cheTipo.Checked = True Then
                    Me.lblDevo.Visible = True
                End If
            End If
            MsgBox("Los datos fueron Actualizados" & Chr(13) & _
                   "al Inventario.", MsgBoxStyle.Information, "Información")
            Me.cmbNomE.Text = ""
            Me.txtci.Clear()
            Me.txtCodE.Clear()
            Me.cmbcodigo.Text = ""
            Me.txtProductos.Clear()
            Me.txtCantidad.Clear()
            Me.txtdev.Clear()
            Me.txtfecha.Clear()
            Me.txtfecha.Enabled = False
            Me.cmbNomE.Enabled = True
            Me.txtCodE.Enabled = True
            Me.txtNorden.Enabled = True
            Me.cbEstado.Select()
            Me.txtNorden.Text = ""
            Me.cheTipo.Enabled = True
            Me.btnGuardar.Enabled = False
            SW = False       
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Nro()
        Try
            Dim stSQL As String
            stSQL = "SELECT * FROM Salida_Entrega WHERE Nro_Orden =" & Me.txtNorden.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
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
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call ErroresPri()
        For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
            If mRow.Cells(9).Value = "Abierto" Then
                Call Cierre2()
                If WS = True Then
                    Call ListDtg()
                End If
                Call AntCierre()
                Exit Sub
            End If
        Next
        Me.txtci.Text = ""
        Me.cmbcodigo.Text = ""
        Me.txtNorden.Text = ""
        Me.txtProductos.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtCodE.Text = ""
        Me.lblEntrega.Visible = False
        Me.lblDevo.Visible = False
        If cheTipo.Checked = True Then
            Me.txtCantidad.Visible = False
            Me.lblCantidad.Visible = False
            Me.txtdev.Visible = True
            Me.lbldev.Visible = True
        Else
            Me.txtCantidad.Visible = True
            Me.lblCantidad.Visible = True
            Me.txtdev.Visible = False
            Me.lbldev.Visible = False
        End If
        If ID_ACCESO = 2 Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
        Me.cheTipo.Enabled = True
        Me.txtCantidad.Text = ""
        Me.txtdev.Text = ""
        Me.dtgvLista.DataSource = Nothing
        Me.txtfecha.Clear()
        Me.txtfecha.Enabled = True
        Me.cmbNomE.Text = "Seleccionar"
        Me.cmbcodigo.Text = "Seleccionar"
        Me.cbEstado.Text = "Seleccionar"
        Me.cbEstado.Select()
        SW = False
    End Sub
    Private Sub cbEstado_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbEstado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtfecha.Focus()
        End If
    End Sub
    Private Sub txtfecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfecha.KeyPress
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
            Me.txtNorden.Focus()
        End If
    End Sub
    Private Sub txtNorden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNorden.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtNorden, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtNorden, "Este campo sólo" & Chr(13) & _
                                           "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.cmbNomE.Focus()
        End If
    End Sub

    Private Sub cmbNomE_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNomE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbcodigo.Focus()
        End If
    End Sub
    Private Sub cmbcodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtProductos.Focus()
        End If
    End Sub

    Private Sub txtProductos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductos.KeyPress
        If lblCantidad.Visible = True Then
            If Asc(e.KeyChar) = 13 Then
                Me.txtCantidad.Focus()
            End If
        ElseIf lblCantidad.Visible = False Then
            If Asc(e.KeyChar) = 13 Then
                Me.txtdev.Focus()
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtCantidad, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtCantidad, "Este campo sólo" & Chr(13) & _
                                             "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnGuardar.PerformClick()
        End If
    End Sub
    Private Sub txtdev_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdev.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtdev, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtdev, "Este campo sólo" & Chr(13) & _
                                        "admite Números!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Call ErroresPri()
        Try
            If Me.txtNorden.Text = "" Or Me.txtNorden.Text <> "" Then
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
            SW = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub Limpiar()
        Try
            Me.txtci.Text = ""
            Me.cmbcodigo.Text = ""
            Me.txtNorden.Text = ""
            Me.txtProductos.Text = ""
            Me.txtCantidad.Text = ""
            Me.txtCodE.Text = ""
            Me.lblEntrega.Visible = False
            Me.lblDevo.Visible = False
            If cheTipo.Checked = True Then
                Me.txtCantidad.Visible = False
                Me.lblCantidad.Visible = False
                Me.txtdev.Visible = True
                Me.lbldev.Visible = True
            Else
                Me.txtCantidad.Visible = True
                Me.lblCantidad.Visible = True
                Me.txtdev.Visible = False
                Me.lbldev.Visible = False
            End If
            If ID_ACCESO = 2 Then
                Me.btnGuardar.Enabled = False
            Else
                Me.btnGuardar.Enabled = True
            End If
            Me.cheTipo.Enabled = True
            Me.txtCantidad.Text = ""
            Me.txtdev.Text = ""
            Me.dtgvLista.DataSource = Nothing
            Me.txtfecha.Enabled = True
            Me.cmbNomE.Text = "Seleccionar"
            Me.cmbcodigo.Text = "Seleccionar"
            Me.cbEstado.Text = "Seleccionar"
            Me.cbEstado.Select()
            SW = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cheTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheTipo.CheckedChanged
        If cheTipo.Checked = True Then
            Me.txtCantidad.Visible = False
            Me.lblCantidad.Visible = False
            Me.txtdev.Visible = True
            Me.lbldev.Visible = True
        Else
            Me.txtCantidad.Visible = True
            Me.lblCantidad.Visible = True
            Me.txtdev.Visible = False
            Me.lbldev.Visible = False
        End If
    End Sub

    Private Sub btnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleados.Click
        Call ErroresPri()
        'Me.Hide()
        If ID_ACCESO = 1 Then
            Empleados.btnCerrar.Enabled = False
            Empleados.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 2 And Resultado = False Then
            Empleados.btnCerrar.Enabled = False
            Empleados.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 3 Then
            Empleados.btnCerrar.Enabled = False
            Empleados.Show()
        End If
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        Call ErroresPri()
        'Me.Hide()
        If ID_ACCESO = 1 Then
            Productos.btncerrar.Enabled = False
            Productos.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 2 Then
            Productos.btncerrar.Enabled = False
            Productos.Show()
        End If
        'Me.Hide()
        If ID_ACCESO = 3 Then
            Productos.btncerrar.Enabled = False
            Productos.Show()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Call ErroresPri()
        If txtNorden.Text.Trim = "" Then
            MsgBox("El Campo Nro. de Orden" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtNorden.Select()
            Exit Sub
        Else
            Call ExiOrden()
            If SW = False Then
                MsgBox("Este Nro. de Orden no existe." & vbCrLf & vbCrLf & _
                       Me.txtNorden.Text, MsgBoxStyle.Exclamation, "Atención")
                Me.cmbNomE.Text = ""
                Me.txtci.Text = ""
                Me.txtNorden.Text = ""
                Me.cmbcodigo.Text = ""
                Me.txtfecha.Text = ""
                Me.txtCodE.Text = ""
                Me.txtProductos.Text = ""
                Me.txtCantidad.Text = ""
                Me.txtdev.Text = ""
                Me.dtgvLista.DataSource = Nothing
                Me.txtfecha.Enabled = True
                Me.cmbNomE.Enabled = True
                Me.txtci.Enabled = True
                Me.txtNorden.Enabled = True
                Me.txtCodE.Enabled = True
                Me.cmbNomE.Text = "Seleccionar"
                Me.cmbcodigo.Text = "Seleccionar"
                Me.cbEstado.Text = "Seleccionar"
                Me.txtCodE.Clear()
                Exit Sub
            Else
                Try
                    Dim stSQL As String
                    stSQL = "DELETE FROM Salida_Entrega WHERE Nro_Orden=" & Me.txtNorden.Text & ""
                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    If MessageBox.Show("¿Desea Eliminar El Registro?" & vbCrLf & vbCrLf & _
                            Me.txtNorden.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        cmd.ExecuteReader()
                        SW = False
                        Call LlenarLista()
                    End If
                    Me.cmbNomE.Text = ""
                    Me.txtci.Text = ""
                    Me.txtNorden.Text = ""
                    Me.cmbcodigo.Text = ""
                    Me.txtfecha.Text = ""
                    Me.txtCodE.Text = ""
                    Me.txtProductos.Text = ""
                    Me.txtCantidad.Text = ""
                    Me.txtdev.Text = ""
                    Me.cmbNomE.Enabled = True
                    Me.txtci.Enabled = True
                    Me.txtNorden.Enabled = True
                    Me.txtCodE.Enabled = True
                    Me.txtfecha.Enabled = True
                    Me.cmbNomE.Text = "Seleccionar"
                    Me.cmbcodigo.Text = "Seleccionar"
                    Me.cbEstado.Text = "Seleccionar"
                    Me.txtCodE.Clear()
                    Me.lblEntrega.Visible = False
                    Me.lblDevo.Visible = False
                    Me.cbEstado.Select()
                    Call Lista()
                    MsgBox("El Número de Orden fue Eliminada." & vbCrLf & vbCrLf & _
                           Me.txtNorden.Text, MsgBoxStyle.Information, "Información")
                Catch ex As Exception
                    MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub
    Sub ExiOrden()
        Try
            Dim srSQL As String
            srSQL = "Select * From Salida_Entrega Where Nro_Orden= " & Me.txtNorden.Text
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
    Sub Refrescar()
        Try
            Dim sfSQL As String
            For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
                If mRow.Cells(9).Value = "Abierto" Then
                    sfSQL = "Select * From Salida_Devolucion Where Nro_Orden=" & Me.txtNorden.Text & ""
                    Dim cmdd As New OleDbCommand(sfSQL, cnnBD)
                    Dim dtr2 As OleDbDataReader
                    dtr2 = cmdd.ExecuteReader
                    If dtr2.HasRows = True Then
                        MsgBox("Asegurese de Cerrar antes" & vbCrLf & _
                               "el Número de Orden.", MsgBoxStyle.Exclamation, "Atención")
                        Exit Sub
                    End If
                End If
            Next
            Dim stSQL As String = ""
            stSQL = "SELECT SE.Cod_Empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos, SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion, SE.Estado FROM Salida_Entrega SE INNER JOIN Salida_Devolucion SD ON SE.Nro_Orden = SD.Nro_Orden;"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Salida_Entrega")
                DTB.Load(dtr)
                dtgvLista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Call ErroresPri()
             Try
                If Me.txtNorden.Text = "" Or Me.txtNorden.Text <> "" Then
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
                        Me.dtgvLista.DataSource = Nothing
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

    Private Sub btnlista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlista.Click
        Call ErroresPri()
        Me.txtCantidad.Visible = False
        Me.lblCantidad.Visible = False
        Me.txtdev.Visible = False
        Me.lbldev.Visible = False
        Me.lblEntrega.Visible = False
        Me.lblDevo.Visible = False
        Try
                Call ListDtg()
                If SW = True Then
                    Call ListDtg()
                    Call AntCierre()
                    Exit Sub
                Else
                    Call ListDtg()
                End If
                Me.btnGuardar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            End Try
    End Sub
    Sub Lista()
        Try
            Dim stSQL As String = ""
            stSQL = "SELECT SE.Cod_Empleado, SE.Cedula, SE.Nombres, SE.Nro_Orden, SD.Cod_Productos, SE.Fecha, SD.Cantidad, SD.Devolucion, SD.Descripcion, SE.Estado FROM Salida_Entrega SE INNER JOIN Salida_Devolucion SD ON SE.Nro_Orden = SD.Nro_Orden;"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader

            If dtr.HasRows = True Then
                Dim DTB As New DataTable("Salida_Entrega")
                DTB.Load(dtr)
                dtgvLista.DataSource = DTB
            End If
            cmd.Dispose()
            dtr = Nothing
            MOSTRARDATOS()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Call ErroresPri()
        If Me.txtNorden.Text = "" Then
            Me.cmbcodigo.Text = "Seleccionar"
            Me.cmbNomE.Text = "Seleccionar"
            Me.txtfecha.Clear()
            Me.txtCodE.Clear()
            Me.txtProductos.Clear()
            Me.txtNorden.Clear()
            Me.txtCantidad.Clear()
            Me.txtdev.Clear()
        End If
        Try
            If Me.txtNorden.Enabled = True Then
                Dim sfSQL As String
                For Each mRow As DataGridViewRow In Me.dtgvLista.Rows
                    If mRow.Cells(9).Value = "Abierto" Then
                        sfSQL = "Select * From Salida_Devolucion Where Nro_Orden=" & Me.txtNorden.Text & ""
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
                Me.cmbcodigo.Text = "Seleccionar"
                Me.cmbNomE.Text = "Seleccionar"
                Me.txtfecha.Clear()
                Me.txtCodE.Clear()
                Me.txtProductos.Clear()
                Me.txtNorden.Clear()
                Me.txtCantidad.Clear()
                Me.txtdev.Clear()
            Else
                Me.cmbcodigo.Text = "Seleccionar"
                Me.txtProductos.Clear()
                Me.txtCantidad.Clear()
                Me.txtdev.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub dtgvLista_ColumnAdded(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dtgvLista.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Sub ErroresPri()
        Errores.SetError(Me.txtCantidad, Nothing)
        Errores.SetError(Me.txtdev, Nothing)
        Errores.SetError(Me.txtNorden, Nothing)
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