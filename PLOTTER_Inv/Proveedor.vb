Imports System.Data
Imports System.Data.OleDb
Public Class Proveedor
    Private cnnBD As New OleDbConnection
    Dim Resultado As Boolean = True
    Private SW As Boolean
    Private MS As Boolean
    Private Sub Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
            Me.btnactualizar.Enabled = False
            Me.btneliminar.Enabled = False
            Me.btnagregar.Enabled = False
        ElseIf ID_ACCESO = 3 Then
            Me.btneliminar.Enabled = False
        End If
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        da.SelectCommand = New OleDbCommand("Select * From Proveedor", cnnBD)
        da.Fill(dt)
        cboCod.DataSource = dt
        cboCod.DisplayMember = "Cod_Proveedor"
        Call Lista()
        Me.cboCod.Text = "Seleccionar"
    End Sub
    Private Sub frmForm1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Errores.SetError(Me.txttlf, Nothing)
        If ID_ACCESO = 1 And btncerrar.Enabled = False Or ID_ACCESO = 2 And btncerrar.Enabled = False Or ID_ACCESO = 3 And btncerrar.Enabled = False Then
            If ID_ACCESO = 1 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
            ElseIf ID_ACCESO = 2 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
            ElseIf ID_ACCESO = 3 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
            End If
        Else
            Me.Visible = False
            Menú.Show()
        End If
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Errores.SetError(Me.txttlf, Nothing)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        If cboCod.Text.Trim = "Seleccionar" Then
            MsgBox("Debe asignar un Código" & Chr(13) & _
                   "al Proveedor.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCod.Select()
            Exit Sub
        End If
        If cboCod.Text.Trim = "" Then
            MsgBox("El Código de Proveedor" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCod.Select()
            Exit Sub
        End If
        If txtRif.Text.Trim = "" Then
            MsgBox("El Campo Nro. de Rif" & Chr(13) & _
                   "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtRif.Select()
            Exit Sub
        End If
        If txtprov.Text.Trim = "" Then
            MsgBox("El Campo Proveedor no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtprov.Select()
            Exit Sub
        End If
        If txtdir.Text.Trim = "" Then
            MsgBox("El Campo Dirección no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtdir.Select()
            Exit Sub
        End If
        If txtcor.Text.Trim = "" Then
            MsgBox("El Campo Email@ no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtcor.Select()
            Exit Sub
        End If
        If txttlf.Text.Trim = "" Then
            MsgBox("El Campo Teléfono no" & Chr(13) & _
                   "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txttlf.Select()
            Exit Sub
        End If
      
        Try
            Dim stSQL As String
            stSQL = "INSERT INTO Proveedor ( Cod_Proveedor, Rif, Proveedor, Direccion, Correo, Telefono) " & _
                                 "VALUES ('" & Me.cboCod.Text & "', '" & Me.txtRif.Text & "', '" & Me.txtprov.Text & "', '" & Me.txtdir.Text & "', '" & Me.txtcor.Text & "', '" & Me.txttlf.Text & "')"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            cmd.ExecuteReader()
            ''''
            SW = False
            Call Lista()
            Me.txtcod2.Text = Me.txtRif.Text
            Me.txtRif.Text = ""
            Me.txtcod2.Text = ""
            Me.cboCod.Text = "Seleccionar"
            Me.txtprov.Text = ""
            Me.txtdir.Text = ""
            Me.txtcor.Text = ""
            Me.txttlf.Text = ""
            Me.txtcod2.Text = Me.cboCod.Text
            MsgBox("Los Datos Fueron Registrados.", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MsgBox("Este Proveedor ya Existe.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtRif.Text = ""
            Me.txtcod2.Text = ""
            Me.cboCod.Text = "Seleccionar"
            Me.txtprov.Text = ""
            Me.txtdir.Text = ""
            Me.txtcor.Text = ""
            Me.txttlf.Text = ""
        End Try
        'End If
        da.SelectCommand = New OleDbCommand("Select * From Proveedor", cnnBD)
        da.Fill(dt)
        cboCod.DataSource = dt
        cboCod.DisplayMember = "Cod_Proveedor"
        Me.cboCod.Text = "Seleccionar"
    End Sub

    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click

        Errores.SetError(Me.txttlf, Nothing)
        If cboCod.Text.Trim = "Seleccionar" Or cboCod.Text.Trim = "" Then
            MsgBox("Debe Seleccionar un " & Chr(13) & _
                   "Código de Proveedor.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        Else
            Call ExiProv()
            If SW = False Then
                MsgBox("Este Proveedor no está Registrado." & vbCrLf & vbCrLf & _
                       Me.cboCod.Text, MsgBoxStyle.Exclamation, "Atención")
                Me.txtRif.Clear()
                Me.txtdir.Clear()
                Me.txtprov.Clear()
                Me.txtcor.Clear()
                Me.txttlf.Clear()
                Me.cboCod.Text = ""
                Me.cboCod.Text = "Seleccionar"
                Exit Sub
            Else
            End If
            If txtRif.Text.Trim = "" Then
                MsgBox("El Campo Nro. de Rif" & Chr(13) & _
                       "no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtRif.Select()
                Exit Sub
            End If
            If txtprov.Text.Trim = "" Then
                MsgBox("El Campo Proveedor no" & Chr(13) & _
                       "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtprov.Select()
                Exit Sub
            End If
            If txtdir.Text.Trim = "" Then
                MsgBox("El Campo Dirección no" & Chr(13) & _
                       "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtdir.Select()
                Exit Sub
            End If
            If txtcor.Text.Trim = "" Then
                MsgBox("El Campo Email@ no" & Chr(13) & _
                       "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txtcor.Select()
                Exit Sub
            End If
            If txttlf.Text.Trim = "" Then
                MsgBox("El campo Teléfono no" & Chr(13) & _
                       "puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                Me.txttlf.Select()
                Exit Sub
            End If
        End If
        Try
            Dim stSQL As String
            stSQL = "UPDATE Proveedor " & _
                    "SET Cod_Proveedor='" & Me.cboCod.Text & "', Rif='" & Me.txtRif.Text & "', Proveedor='" & Me.txtprov.Text & "', Direccion='" & Me.txtdir.Text & "', Correo='" & Me.txtcor.Text & "', Telefono='" & Me.txttlf.Text & "' " & _
                    "WHERE Cod_Proveedor='" & Me.cboCod.Text & "'"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            cmd.ExecuteReader()
            '''''
            SW = False
            Call Lista()
            Me.txtcod2.Text = Me.cboCod.Text
            'Me.txtcod2.Text = Me.txtRif.Text
            MsgBox("Los Datos Fueron Actualizados.", MsgBoxStyle.Information, "Información")
            Me.txtRif.Text = ""
            Me.txtcod2.Text = ""
            Me.cboCod.Text = "Seleccionar"
            Me.txtprov.Text = ""
            Me.txtdir.Text = ""
            Me.txtcor.Text = ""
            Me.txttlf.Text = ""
            Me.txtRif.Select()
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
        ' Me.Show()
    End Sub
    Sub ExiProv()
        Try
            Dim srSQL As String
            srSQL = "Select * From Proveedor Where Cod_Proveedor= '" & Me.cboCod.Text & "'"
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

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click

        Errores.SetError(Me.txttlf, Nothing)
        If Me.cboCod.Text.Trim = "Seleccionar" Or Me.cboCod.Text.Trim = "" Then
            MsgBox("Debe seleccionar el Proveedor" & Chr(13) & _
                   "que desea Eliminar.", MsgBoxStyle.Exclamation, "Atención")
            Me.cboCod.Text = "Seleccionar"
            Exit Sub
        Else
            Call ExiProv()
            If SW = False Then
                MsgBox("Este Proveedor no está Registrado." & vbCrLf & vbCrLf & _
                      Me.cboCod.Text, MsgBoxStyle.Exclamation, "Atención")
                Me.txtRif.Clear()
                Me.txtdir.Clear()
                Me.txtprov.Clear()
                Me.txtcor.Clear()
                Me.txttlf.Clear()
                Me.cboCod.Text = ""
                Me.cboCod.Text = "Seleccionar"
                Exit Sub
            Else
                Dim da As New OleDbDataAdapter
                Dim dt As New DataTable
                If cboCod.Text.Trim = "" Then
                    MsgBox("El Campo Código no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If
                Try
                    Dim stSQL As String
                    stSQL = "DELETE FROM Proveedor WHERE Cod_Proveedor='" & Me.cboCod.Text & "'"
                    Dim cmd As New OleDbCommand(stSQL, cnnBD)
                    If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                            Me.cboCod.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                        cmd.ExecuteReader()
                    End If
                    Call Eliminar()
                    If SW = True Then
                        Exit Sub
                    Else
                        SW = False
                        Call Lista()
                        Me.txtcod2.Text = Me.cboCod.Text
                        Me.txtRif.Text = ""
                        Me.txtcod2.Text = ""
                        Me.cboCod.Text = "Seleccionar"
                        Me.txtprov.Text = ""
                        Me.txtdir.Text = ""
                        Me.txtcor.Text = ""
                        Me.txttlf.Text = ""
                        Me.txtRif.Select()
                        Me.txtcod2.Text = Me.cboCod.Text
                        MsgBox("Los Datos Fueron Eliminados.", MsgBoxStyle.Information, "Información")
                        Me.Show()
                        da.SelectCommand = New OleDbCommand("Select * From Proveedor", cnnBD)
                        da.Fill(dt)
                        cboCod.DataSource = dt
                        cboCod.DisplayMember = "Cod_Proveedor"
                        cboCod.Text = "Seleccionar"
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub
    Sub Eliminar()
        Try
            Dim stSQL As String
            stSQL = "Select * FROM Proveedor WHERE Cod_Proveedor='" & Me.cboCod.Text & "'"
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
        Errores.SetError(Me.txttlf, Nothing)
        If cboCod.Text = "Seleccionar" Then
            MsgBox("No ha Seleccionado ningún Proveedor.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Try
            Dim stSQL As String
            stSQL = "SELECT * FROM Proveedor WHERE Cod_Proveedor='" & Me.cboCod.Text & "'"
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            Me.txtcod2.Text = dtr("Cod_Proveedor").ToString
            Me.cboCod.Text = dtr("Cod_Proveedor").ToString
            Me.txtRif.Text = dtr("Rif").ToString
            Me.txtprov.Text = dtr("Proveedor").ToString
            Me.txtdir.Text = dtr("Direccion").ToString
            Me.txtcor.Text = dtr("Correo").ToString
            Me.txttlf.Text = dtr("Telefono").ToString

            ''''''
            Me.txtcod2.Text = Me.cboCod.Text
            'Me.txtcod2.Text = Me.txtRif.Text
            SW = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btncrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrear.Click
        Errores.SetError(Me.txttlf, Nothing)
        Me.txtRif.Text = ""
        Me.txtcod2.Text = ""
        Me.cboCod.Text = ""
        Me.txtprov.Text = ""
        Me.txtdir.Text = ""
        Me.txtcor.Text = ""
        Me.txttlf.Text = ""
        Me.cboCod.Select()
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Errores.SetError(Me.txttlf, Nothing)
        If MessageBox.Show("¿Desea Salir del Sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                      MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Lista()
        Dim sSQL As String
        sSQL = "SELECT * FROM Proveedor ORDER BY Cod_Proveedor"
        Dim cmd As New OleDbCommand(sSQL, cnnBD)
        Dim dtr As OleDbDataReader
        dtr = cmd.ExecuteReader
        Dim dtb As New DataTable
        dtb.Load(dtr)
        Me.dtgvLista.DataSource = dtb
        Me.dtgvLista.Columns(0).Visible = True
        cmd = Nothing : dtb = Nothing : dtr = Nothing
        verListadoPro()
    End Sub
    Private Sub dtgvLista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvLista.CellClick
        Errores.SetError(Me.txttlf, Nothing)
        If sender.currentcell.columnIndex = 0 Then
            Datos(sender.CURRENTCELL.ROWINDEX)
        End If
    End Sub

    Private Sub dtgvLista_ColumnAdded(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dtgvLista.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub dtgvLista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvLista.GotFocus
        SW = True
    End Sub
    Sub Datos(ByVal IND As Integer)
        Me.cboCod.Text = dtgvLista.Rows(IND).Cells(0).Value
        Me.txtRif.Text = dtgvLista.Rows(IND).Cells(1).Value
        Me.txtprov.Text = dtgvLista.Rows(IND).Cells(2).Value
        Me.txtdir.Text = dtgvLista.Rows(IND).Cells(3).Value
        Me.txtcor.Text = dtgvLista.Rows(IND).Cells(4).Value
        Me.txttlf.Text = dtgvLista.Rows(IND).Cells(5).Value
        verListadoPro()
    End Sub
    Private Sub dtgvLista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvLista.SelectionChanged
        Dim C As String = ""
        If SW = True Then
            'sender.CURRENTCELL.COLUMNINDEX COLUMNA A LA QUE SE LE DIO CLIC
            C = dtgvLista.Rows(sender.CURRENTCELL.ROWINDEX).Cells(0).Value
            'Me.txtcod2.Text = C
            Me.cboCod.Text = C
            Call btnbuscar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub verListadoPro()
        With Me.dtgvLista
            'Altura de la cebezera
            .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            'Ancho de las columnas incluyendo la cabecera
            .RowHeadersWidth = CInt(.Width * 0.03)
            .Columns(0).Width = CInt(.Width * 0.08)
            .Columns(1).Width = CInt(.Width * 0.12)
            .Columns(2).Width = CInt(.Width * 0.15)
            .Columns(3).Width = CInt(.Width * 0.3)
            .Columns(4).Width = CInt(.Width * 0.2)
            .Columns(5).Width = CInt(.Width * 0.12)


            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Dim CellStyle As New DataGridViewCellStyle
            CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
            CellStyle.WrapMode = DataGridViewTriState.True
            CellStyle.BackColor = Color.FromArgb(162, 215, 255)
            CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
            CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle = CellStyle
            .RowHeadersDefaultCellStyle = CellStyle

            'Títulos de la cabecera
            .Columns(0).HeaderText = "Cod. Proveedor"
            .Columns(1).HeaderText = "Rif"
            .Columns(2).HeaderText = "Proveedor"
            .Columns(3).HeaderText = "Dirección"
            .Columns(4).HeaderText = "Correo"
            .Columns(5).HeaderText = "Teléfono"

            'Color del cursor de campos y de la fuente
            .DefaultCellStyle.SelectionBackColor = Color.Aqua
            .DefaultCellStyle.SelectionForeColor = Color.Black
            For Each rw As DataGridViewRow In Me.dtgvLista.Rows
                rw.DefaultCellStyle.BackColor = Color.Azure
                rw.DefaultCellStyle.ForeColor = Color.Black
            Next
        End With
    End Sub
    Private Sub txttlf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttlf.KeyPress
        Dim cadena As String = sender.Text
        Dim num As String = "1234567890"
        MS = True
        If Len(cadena) > 0 Then
            num += ".-"
        End If
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "00" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "00" And Len(cadena) = 1 Then
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
            Me.btnagregar.PerformClick()
        End If
    End Sub
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click

        Errores.SetError(Me.txttlf, Nothing)
        If ID_ACCESO = 1 And btncerrar.Enabled = False Or ID_ACCESO = 2 And btncerrar.Enabled = False Or ID_ACCESO = 3 And btncerrar.Enabled = False Then
            If ID_ACCESO = 1 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
                Me.Close()
            ElseIf ID_ACCESO = 2 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
                Me.Close()
            ElseIf ID_ACCESO = 3 And btncerrar.Enabled = False Then
                Me.Visible = False
                Factura_Compra.Show()
                Me.Close()
            End If
        Else
            Me.Visible = False
            Menú.Show()
            Me.Close()
        End If
    End Sub
    Private Sub cboCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCod.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtRif.Focus()
        End If
    End Sub
    Private Sub txtRif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRif.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtprov.Focus()
        End If
    End Sub
    Private Sub txtprov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprov.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtdir.Focus()
        End If
    End Sub
    Private Sub txtdir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtcor.Focus()
        End If
    End Sub
    Private Sub txtcor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txttlf.Focus()
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Errores.SetError(Me.txttlf, Nothing)
        Me.txtRif.Text = ""
        Me.txtcod2.Text = ""
        Me.cboCod.Text = "Seleccionar"
        Me.txtprov.Text = ""
        Me.txtdir.Text = ""
        Me.txtcor.Text = ""
        Me.txttlf.Text = ""
    End Sub
End Class