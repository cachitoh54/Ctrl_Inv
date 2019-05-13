Imports System.Data
Imports System.Data.OleDb
Public Class Empleados
    Private cnnBD As New OleDbConnection
    Dim Resultado As Boolean
    Private SW As Boolean
    Private MS As Boolean
    Private Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_ACCESO = 2 Then
            Me.btnActualizar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnAgregar.Enabled = False
        ElseIf ID_ACCESO = 3 Then
            Me.btnEliminar.Enabled = False
        End If
        cnnBD.ConnectionString = fnStrCnn(1)
        cnnBD.Open()
        Call Lista()
        Me.txtcedula.Select()
    End Sub
    Private Sub frmForm1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call ErroresPri()
        If ID_ACCESO = 1 And btnCerrar.Enabled = False Or ID_ACCESO = 2 And btnCerrar.Enabled = False Or ID_ACCESO = 3 And btnCerrar.Enabled = False Then
            If ID_ACCESO = 1 And btnCerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            ElseIf ID_ACCESO = 2 And btnCerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            ElseIf ID_ACCESO = 3 And btnCerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
            End If
        Else
            Me.Visible = False
            Menú.Show()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Call ErroresPri()
        If txtcedula.Text.Trim = "" Then
            MsgBox("El Campo Cédula no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtcedula.Select()
            Exit Sub
        End If
        If txtnombre.Text.Trim = "" Then
            MsgBox("El Campo Nombre no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtnombre.Select()
            Exit Sub
        End If
        If txttlf.Text.Trim = "" Then
            MsgBox("El Campo Teléfono no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txttlf.Select()
            Exit Sub
        End If

        Call Persona()
        If Resultado = True Then
            MsgBox("La Persona Ya Existe.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtcedula.Clear()
            Me.txtnombre.Clear()
            Me.txttlf.Clear()
            Me.txtcedula.Select()
            Exit Sub
        Else
            Try
                Dim stSQL As String
                stSQL = "INSERT INTO Empleados ( Cedula, Nombres, Telefono) " & _
                                     "VALUES ('" & Me.txtcedula.Text & "', '" & Me.txtnombre.Text & "','" & Me.txttlf.Text & "')"
                Dim cmd As New OleDbCommand(stSQL, cnnBD)
                cmd.ExecuteReader()
                ''''
                SW = False
                Call Lista()
                Me.txtCod.Text = Me.txtcodigo.Text
                MsgBox("Los Datos fueron Registrados", MsgBoxStyle.Information, "Información")
                Me.txtcedula.Clear()
                Me.txtnombre.Clear()
                Me.txttlf.Clear()
                Me.txtcedula.Select()
            Catch ex As Exception
                MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
    Sub Persona()
        Try
            Dim srSQL As String
            srSQL = "Select * From Empleados Where Cedula= '" & Me.txtcedula.Text & "'"
            Dim cmdd As New OleDbCommand(srSQL, cnnBD)
            dtr = cmdd.ExecuteReader
            If dtr.Read = True Then
                Resultado = True
            Else
                Resultado = False
            End If
        Catch ex As Exception
            MsgBox("Error de Procedimiento" + ex.ToString)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call ErroresPri()
        If txtcedula.Text.Trim = "" Then
            MsgBox("El campo  de Cédula no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtcedula.Select()
            Exit Sub
        End If
        If txtnombre.Text.Trim = "" Then
            MsgBox("El campo de Nombre no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txtnombre.Select()
            Exit Sub
        End If

        If txttlf.Text.Trim = "" Then
            MsgBox("El campo  de Teléfono no puede estar vacío.", MsgBoxStyle.Exclamation, "Atención")
            Me.txttlf.Select()
            Exit Sub
        End If

        Try
            Dim stSQL As String
            stSQL = "UPDATE Empleados " & _
                    "SET Cedula='" & Me.txtcedula.Text & "', Nombres='" & Me.txtnombre.Text & "', Telefono='" & Me.txttlf.Text & "' " & _
                    "WHERE Cod_empleado=" & Me.txtcodigo.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            cmd.ExecuteReader()
            '''''
            SW = False
            Call Lista()
            Me.txtCod.Text = Me.txtcodigo.Text
            MsgBox("Los Datos Fueron Actulizados Satisfactoriamente.", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Call ErroresPri()
        If txtcodigo.Text.Trim = "" Then
            MsgBox("Para Eliminar un Empleado, debe" & Chr(13) & _
                   "Seleccionar un Número de Cédula" & Chr(13) & _
                   "de la Lista de Empleados.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Try
            Dim stSQL As String
            stSQL = "DELETE FROM Empleados WHERE Cod_empleado=" & Me.txtcodigo.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            If MessageBox.Show("¿Desea eliminar el Registro?" & vbCrLf & vbCrLf & _
                    Me.txtnombre.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteReader()
                SW = False
                Call Lista()
                Me.txtCod.Text = Me.txtcodigo.Text
                MsgBox("Los datos fueron eliminados.", MsgBoxStyle.Information, "Información")
                Me.txtcedula.Clear()
                Me.txtnombre.Clear()
                Me.txttlf.Clear()
                Me.txtcodigo.Clear()
                Me.txtCod.Clear()
                Me.txtcedula.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim stSQL As String
            stSQL = "SELECT * FROM Empleados WHERE Cod_empleado=" & Me.txtcodigo.Text
            Dim cmd As New OleDbCommand(stSQL, cnnBD)
            Dim dtr As OleDbDataReader
            dtr = cmd.ExecuteReader
            dtr.Read()
            Me.txtCod.Text = dtr("Cod_empleado").ToString
            Me.txtcodigo.Text = dtr("Cod_empleado").ToString
            Me.txtcedula.Text = dtr("Cedula").ToString
            Me.txtnombre.Text = dtr("Nombres").ToString

            Me.txttlf.Text = dtr("Telefono").ToString

            ''''''
            SW = False
            Call Lista()
            Me.txtCod.Text = Me.txtcodigo.Text
            SW = False
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Call ErroresPri()
        If MessageBox.Show("¿Desea Salir del Sistema?" & vbCrLf & vbCrLf & _
                     Me.txtvacio.Text, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                     MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Lista()

        Dim sSQL As String
        sSQL = "SELECT * FROM Empleados ORDER BY Cod_empleado"
        Dim cmd As New OleDbCommand(sSQL, cnnBD)
        Dim dtr As OleDbDataReader
        dtr = cmd.ExecuteReader
        Dim dtb As New DataTable
        dtb.Load(dtr)
        Me.dtgLista.DataSource = dtb
        Me.dtgLista.Columns(0).Visible = False
        cmd = Nothing : dtb = Nothing : dtr = Nothing
        verListadoEM()

        'Dim sSQL As String
        'sSQL = "SELECT * FROM Empleados ORDER BY Cod_empleado"
        'Dim cmd As New OleDbCommand(sSQL, cnnBD)
        'Dim dtr As OleDbDataReader
        'dtr = cmd.ExecuteReader
        'Dim dtb As New DataTable
        'dtb.Load(dtr)
        'Me.dtgLista.DataSource = dtb
        'Me.dtgLista.Columns(0).Visible = False
        'cmd = Nothing : dtb = Nothing : dtr = Nothing
        'verListadoEM()
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Call ErroresPri()
        Me.txtCod.Text = ""
        Me.txtcodigo.Text = ""
        Me.txtcedula.Text = ""
        Me.txtnombre.Text = ""
        Me.txttlf.Text = ""
        Me.txtcedula.Select()
    End Sub
    Private Sub dtgLista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgLista.CellClick
        Call ErroresPri()
        If sender.currentcell.columnIndex = 1 Then
            Datos(sender.CURRENTCELL.ROWINDEX)
        End If
    End Sub

    Private Sub dtgLista_ColumnAdded(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dtgLista.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub dtgLista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLista.GotFocus
        SW = True
    End Sub
    Sub Datos(ByVal IND As Integer)
        Me.txtcodigo.Text = dtgLista.Rows(IND).Cells(0).Value
        Me.txtcedula.Text = dtgLista.Rows(IND).Cells(1).Value
        Me.txtnombre.Text = dtgLista.Rows(IND).Cells(2).Value
        Me.txttlf.Text = dtgLista.Rows(IND).Cells(3).Value
        verListadoEM()
    End Sub
    Private Sub dtgLista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLista.SelectionChanged
        Dim C As String = ""
        If SW = True Then
            C = dtgLista.Rows(sender.CURRENTCELL.ROWINDEX).Cells(0).Value
            Me.txtcodigo.Text = C
            Call btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub verListadoEM()

        With Me.dtgLista
            .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            .RowHeadersWidth = CInt(.Width * 0.03)
            .Columns(0).Width = CInt(.Width * 0.1)
            .Columns(1).Width = CInt(.Width * 0.2)
            .Columns(2).Width = CInt(.Width * 0.5)
            .Columns(3).Width = CInt(.Width * 0.27)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim CellStyle As New DataGridViewCellStyle
            CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
            CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
            CellStyle.WrapMode = DataGridViewTriState.True
            CellStyle.BackColor = Color.FromArgb(162, 215, 255)
            CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
            CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle = CellStyle
            .RowHeadersDefaultCellStyle = CellStyle

            .Columns(0).HeaderText = "Cod. de Empleados"
            .Columns(1).HeaderText = "Cédula"
            .Columns(2).HeaderText = "Nombre y Apellido"
            .Columns(3).HeaderText = "Teléfono"

            .DefaultCellStyle.SelectionBackColor = Color.Orange
            .DefaultCellStyle.SelectionForeColor = Color.Black

            For Each rw As DataGridViewRow In Me.dtgLista.Rows
                rw.DefaultCellStyle.BackColor = Color.Azure
                rw.DefaultCellStyle.ForeColor = Color.Black
            Next

        End With

        'With Me.dtgLista
        '    .Font = New Font(New FontFamily("Calibri"), 9.2F, FontStyle.Regular)
        '    .EnableHeadersVisualStyles = False
        '    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        '    .ColumnHeadersHeight = 40

        '    .RowHeadersWidth = CInt(.Width * 0.03)
        '    .Columns(0).Width = CInt(.Width * 0.1)
        '    .Columns(1).Width = CInt(.Width * 0.2)
        '    .Columns(2).Width = CInt(.Width * 0.5)
        '    .Columns(3).Width = CInt(.Width * 0.27)

        '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '    Dim CellStyle As New DataGridViewCellStyle
        '    CellStyle.Font = New Font(.Font.Name, .Font.Size, FontStyle.Bold)
        '    CellStyle.Font = New Font(New FontFamily("Calibri"), 8.5F, FontStyle.Bold)
        '    CellStyle.WrapMode = DataGridViewTriState.True
        '    CellStyle.BackColor = Color.FromArgb(162, 215, 255)
        '    CellStyle.ForeColor = Color.FromArgb(0, 0, 0)
        '    CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .ColumnHeadersDefaultCellStyle = CellStyle
        '    .RowHeadersDefaultCellStyle = CellStyle

        '    .Columns(0).HeaderText = "Cod. de Empleados"
        '    .Columns(1).HeaderText = "Cédula"
        '    .Columns(2).HeaderText = "Nombre y Apellido"
        '    .Columns(3).HeaderText = "Teléfono"

        '    .DefaultCellStyle.SelectionBackColor = Color.Orange
        '    .DefaultCellStyle.SelectionForeColor = Color.Black

        '    For Each rw As DataGridViewRow In Me.dtgLista.Rows
        '        rw.DefaultCellStyle.BackColor = Color.Azure
        '        rw.DefaultCellStyle.ForeColor = Color.Black
        '    Next

        'End With
    End Sub
    Private Sub txtcedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress
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
            Me.txtnombre.Focus()
        End If
    End Sub
    Private Sub txtnombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            Errores.SetError(Me.txtnombre, Nothing)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Errores.SetError(Me.txtnombre, "Este campo sólo" & Chr(13) & _
                                           "admite Letras!")
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txttlf.Focus()
        End If
    End Sub
   
    Private Sub txttlf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttlf.KeyPress
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
            Me.btnAgregar.PerformClick()
        End If
    End Sub
  
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Call ErroresPri()
        If ID_ACCESO = 1 And btnCerrar.Enabled = False Or ID_ACCESO = 2 And btnCerrar.Enabled = False Or ID_ACCESO = 3 And btnCerrar.Enabled = False Then
            If ID_ACCESO = 1 And btnCerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
                Me.Close()
            ElseIf ID_ACCESO = 2 And btnCerrar.Enabled = False Then
                Me.Visible = False
                Salida_Producto.Show()
                Me.Close()
            ElseIf ID_ACCESO = 3 And btnCerrar.Enabled = False Then
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
    Sub ErroresPri()
        Errores.SetError(Me.txtcedula, Nothing)
        Errores.SetError(Me.txtnombre, Nothing)
        Errores.SetError(Me.txttlf, Nothing)
    End Sub
End Class