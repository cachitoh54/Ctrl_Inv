<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura_Compra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura_Compra))
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.txttrans = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprecioU = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprecioE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbcodigo = New System.Windows.Forms.ComboBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtgvlista = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnir = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtFactu = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnIva = New System.Windows.Forms.Button()
        Me.lblCerrarF = New System.Windows.Forms.Label()
        Me.btnProv = New System.Windows.Forms.Button()
        Me.CMBPROV = New System.Windows.Forms.ComboBox()
        Me.txtfact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolFecha = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTodos
        '
        Me.btnTodos.BackColor = System.Drawing.Color.Blue
        Me.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTodos.Image = CType(resources.GetObject("btnTodos.Image"), System.Drawing.Image)
        Me.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTodos.Location = New System.Drawing.Point(542, 248)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(114, 53)
        Me.btnTodos.TabIndex = 34
        Me.btnTodos.Text = "Listar"
        Me.btnTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTodos.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Brown
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnguardar.Location = New System.Drawing.Point(645, 602)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(145, 71)
        Me.btnguardar.TabIndex = 41
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.Color.GreenYellow
        Me.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnFactura.Location = New System.Drawing.Point(676, 196)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(114, 105)
        Me.btnFactura.TabIndex = 40
        Me.btnFactura.Text = "Cerrar Factura"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtpeso)
        Me.GroupBox3.Controls.Add(Me.txttrans)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtprecioU)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.txtprecioE)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbcodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 112)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Producto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(218, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Bs."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(455, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Bs."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(456, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Bs."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(218, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Kgms."
        '
        'txtpeso
        '
        Me.txtpeso.Location = New System.Drawing.Point(115, 79)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(103, 20)
        Me.txtpeso.TabIndex = 30
        Me.txtpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttrans
        '
        Me.txttrans.Location = New System.Drawing.Point(352, 79)
        Me.txttrans.Name = "txttrans"
        Me.txttrans.Size = New System.Drawing.Size(103, 20)
        Me.txttrans.TabIndex = 33
        Me.txttrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(285, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Transporte:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Peso Neto:"
        '
        'txtprecioU
        '
        Me.txtprecioU.Location = New System.Drawing.Point(115, 55)
        Me.txtprecioU.Name = "txtprecioU"
        Me.txtprecioU.Size = New System.Drawing.Size(103, 20)
        Me.txtprecioU.TabIndex = 13
        Me.txtprecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(404, 31)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(51, 20)
        Me.txtcantidad.TabIndex = 18
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtprecioE
        '
        Me.txtprecioE.Location = New System.Drawing.Point(352, 54)
        Me.txtprecioE.Name = "txtprecioE"
        Me.txtprecioE.Size = New System.Drawing.Size(103, 20)
        Me.txtprecioE.TabIndex = 17
        Me.txtprecioE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Código:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Precio Empaque:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio Unitario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad:"
        '
        'cmbcodigo
        '
        Me.cmbcodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbcodigo.FormattingEnabled = True
        Me.cmbcodigo.Location = New System.Drawing.Point(115, 31)
        Me.cmbcodigo.Name = "cmbcodigo"
        Me.cmbcodigo.Size = New System.Drawing.Size(174, 21)
        Me.cmbcodigo.TabIndex = 4
        Me.cmbcodigo.Text = "Seleccionar"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Green
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnbuscar.Location = New System.Drawing.Point(542, 196)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(114, 52)
        Me.btnbuscar.TabIndex = 33
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(10, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'dtgvlista
        '
        Me.dtgvlista.AllowUserToAddRows = False
        Me.dtgvlista.AllowUserToDeleteRows = False
        Me.dtgvlista.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dtgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvlista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgvlista.Location = New System.Drawing.Point(12, 307)
        Me.dtgvlista.Name = "dtgvlista"
        Me.dtgvlista.ReadOnly = True
        Me.dtgvlista.Size = New System.Drawing.Size(778, 289)
        Me.dtgvlista.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btncerrar)
        Me.GroupBox2.Controls.Add(Me.btnir)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 602)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 71)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(279, 12)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(87, 56)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.Location = New System.Drawing.Point(364, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(87, 56)
        Me.btncerrar.TabIndex = 14
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnir
        '
        Me.btnir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnir.Image = CType(resources.GetObject("btnir.Image"), System.Drawing.Image)
        Me.btnir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnir.Location = New System.Drawing.Point(109, 12)
        Me.btnir.Name = "btnir"
        Me.btnir.Size = New System.Drawing.Size(87, 56)
        Me.btnir.TabIndex = 12
        Me.btnir.Text = "Regresar"
        Me.btnir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnir.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.Location = New System.Drawing.Point(194, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(87, 56)
        Me.btnnuevo.TabIndex = 13
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.Location = New System.Drawing.Point(23, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 56)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtFactu)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnIva)
        Me.GroupBox1.Controls.Add(Me.lblCerrarF)
        Me.GroupBox1.Controls.Add(Me.btnProv)
        Me.GroupBox1.Controls.Add(Me.CMBPROV)
        Me.GroupBox1.Controls.Add(Me.txtfact)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtIva)
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtfactura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 171)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Factura"
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.SystemColors.Window
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(444, 16)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(112, 26)
        Me.txtfecha.TabIndex = 57
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFactu
        '
        Me.txtFactu.Location = New System.Drawing.Point(357, 87)
        Me.txtFactu.Name = "txtFactu"
        Me.txtFactu.ReadOnly = True
        Me.txtFactu.Size = New System.Drawing.Size(62, 20)
        Me.txtFactu.TabIndex = 56
        Me.txtFactu.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(241, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Refrescar %"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "%"
        '
        'btnIva
        '
        Me.btnIva.BackColor = System.Drawing.Color.DarkGreen
        Me.btnIva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIva.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIva.Location = New System.Drawing.Point(194, 137)
        Me.btnIva.Name = "btnIva"
        Me.btnIva.Size = New System.Drawing.Size(41, 23)
        Me.btnIva.TabIndex = 27
        Me.btnIva.Text = "IVA%"
        Me.btnIva.UseVisualStyleBackColor = False
        '
        'lblCerrarF
        '
        Me.lblCerrarF.AutoSize = True
        Me.lblCerrarF.BackColor = System.Drawing.Color.Red
        Me.lblCerrarF.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrarF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCerrarF.Location = New System.Drawing.Point(166, 55)
        Me.lblCerrarF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCerrarF.Name = "lblCerrarF"
        Me.lblCerrarF.Size = New System.Drawing.Size(232, 29)
        Me.lblCerrarF.TabIndex = 8
        Me.lblCerrarF.Text = "FACTURA CERRADA"
        Me.lblCerrarF.Visible = False
        '
        'btnProv
        '
        Me.btnProv.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProv.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProv.Location = New System.Drawing.Point(426, 113)
        Me.btnProv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(73, 23)
        Me.btnProv.TabIndex = 20
        Me.btnProv.Text = "Proveedor"
        Me.btnProv.UseVisualStyleBackColor = False
        '
        'CMBPROV
        '
        Me.CMBPROV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBPROV.FormattingEnabled = True
        Me.CMBPROV.Location = New System.Drawing.Point(119, 113)
        Me.CMBPROV.Name = "CMBPROV"
        Me.CMBPROV.Size = New System.Drawing.Size(300, 21)
        Me.CMBPROV.TabIndex = 19
        Me.CMBPROV.Text = "Seleccionar"
        '
        'txtfact
        '
        Me.txtfact.Location = New System.Drawing.Point(437, 89)
        Me.txtfact.Name = "txtfact"
        Me.txtfact.ReadOnly = True
        Me.txtfact.Size = New System.Drawing.Size(62, 20)
        Me.txtfact.TabIndex = 17
        Me.txtfact.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Estado:"
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(119, 137)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(54, 20)
        Me.txtIva.TabIndex = 3
        '
        'cbEstado
        '
        Me.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Seleccionar", "Abierto", "Cerrado"})
        Me.cbEstado.Location = New System.Drawing.Point(63, 26)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 23)
        Me.cbEstado.TabIndex = 54
        Me.cbEstado.Text = "Selecionar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "IVA:"
        '
        'txtfactura
        '
        Me.txtfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Location = New System.Drawing.Point(119, 89)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(135, 21)
        Me.txtfactura.TabIndex = 1
        Me.txtfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. de Factura:"
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Factura_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 677)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtgvlista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Factura_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura y Recepción de Productos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpeso As System.Windows.Forms.TextBox
    Friend WithEvents txttrans As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtprecioU As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbcodigo As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnir As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnIva As System.Windows.Forms.Button
    Friend WithEvents lblCerrarF As System.Windows.Forms.Label
    Friend WithEvents btnProv As System.Windows.Forms.Button
    Friend WithEvents CMBPROV As System.Windows.Forms.ComboBox
    Friend WithEvents txtfact As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtFactu As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolFecha As System.Windows.Forms.ToolTip
End Class
