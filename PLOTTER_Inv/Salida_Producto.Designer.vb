<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salida_Producto))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNor = New System.Windows.Forms.TextBox()
        Me.btnlista = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cheTipo = New System.Windows.Forms.CheckBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNorden = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnEntre = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblDevo = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.GroupBox()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldev = New System.Windows.Forms.Label()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.txtCodE = New System.Windows.Forms.TextBox()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.cmbcodigo = New System.Windows.Forms.ComboBox()
        Me.cmbNomE = New System.Windows.Forms.ComboBox()
        Me.txtdev = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblEntrega = New System.Windows.Forms.Label()
        Me.dtgvLista = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolFecha = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.txtProducto.SuspendLayout()
        CType(Me.dtgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtNor)
        Me.GroupBox4.Controls.Add(Me.btnlista)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.cheTipo)
        Me.GroupBox4.Controls.Add(Me.cbEstado)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtNorden)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(337, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(523, 106)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gropo de Selección"
        '
        'txtNor
        '
        Me.txtNor.Location = New System.Drawing.Point(246, 26)
        Me.txtNor.Name = "txtNor"
        Me.txtNor.ReadOnly = True
        Me.txtNor.Size = New System.Drawing.Size(43, 20)
        Me.txtNor.TabIndex = 37
        Me.txtNor.Visible = False
        '
        'btnlista
        '
        Me.btnlista.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnlista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlista.Image = CType(resources.GetObject("btnlista.Image"), System.Drawing.Image)
        Me.btnlista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlista.Location = New System.Drawing.Point(422, 58)
        Me.btnlista.Name = "btnlista"
        Me.btnlista.Size = New System.Drawing.Size(97, 42)
        Me.btnlista.TabIndex = 33
        Me.btnlista.Text = "Listar"
        Me.btnlista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlista.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.BlueViolet
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(326, 58)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 42)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cheTipo
        '
        Me.cheTipo.AutoSize = True
        Me.cheTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cheTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheTipo.Location = New System.Drawing.Point(21, 75)
        Me.cheTipo.Name = "cheTipo"
        Me.cheTipo.Size = New System.Drawing.Size(97, 19)
        Me.cheTipo.TabIndex = 18
        Me.cheTipo.Text = "Devolución"
        Me.cheTipo.UseVisualStyleBackColor = True
        '
        'cbEstado
        '
        Me.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Seleccionar", "Abierto", "Cerrado"})
        Me.cbEstado.Location = New System.Drawing.Point(75, 25)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 23)
        Me.cbEstado.TabIndex = 19
        Me.cbEstado.Text = "Seleccionar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Estado:"
        '
        'txtNorden
        '
        Me.txtNorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNorden.Location = New System.Drawing.Point(404, 27)
        Me.txtNorden.Name = "txtNorden"
        Me.txtNorden.Size = New System.Drawing.Size(93, 21)
        Me.txtNorden.TabIndex = 11
        Me.txtNorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(301, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nro. de Orden:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnMenu)
        Me.GroupBox3.Controls.Add(Me.btnEntre)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 124)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controles de Registro de Entrega / Devolución:"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMenu.Location = New System.Drawing.Point(238, 63)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 54)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Regresar"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnEntre
        '
        Me.btnEntre.BackColor = System.Drawing.Color.GreenYellow
        Me.btnEntre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntre.Image = CType(resources.GetObject("btnEntre.Image"), System.Drawing.Image)
        Me.btnEntre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEntre.Location = New System.Drawing.Point(6, 19)
        Me.btnEntre.Name = "btnEntre"
        Me.btnEntre.Size = New System.Drawing.Size(159, 99)
        Me.btnEntre.TabIndex = 0
        Me.btnEntre.Text = "Registro de Entrega ó Devolución"
        Me.btnEntre.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.Location = New System.Drawing.Point(238, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 54)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo "
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblDevo
        '
        Me.lblDevo.AutoSize = True
        Me.lblDevo.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.lblDevo.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevo.Location = New System.Drawing.Point(296, 38)
        Me.lblDevo.Name = "lblDevo"
        Me.lblDevo.Size = New System.Drawing.Size(308, 29)
        Me.lblDevo.TabIndex = 41
        Me.lblDevo.Text = "DEVOLUCIÓN REGISTRADA"
        Me.lblDevo.Visible = False
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.Transparent
        Me.txtProducto.Controls.Add(Me.lblExistencia)
        Me.txtProducto.Controls.Add(Me.Label5)
        Me.txtProducto.Controls.Add(Me.txtProductos)
        Me.txtProducto.Controls.Add(Me.Label4)
        Me.txtProducto.Controls.Add(Me.lbldev)
        Me.txtProducto.Controls.Add(Me.btnEmpleados)
        Me.txtProducto.Controls.Add(Me.btnProductos)
        Me.txtProducto.Controls.Add(Me.txtCodE)
        Me.txtProducto.Controls.Add(Me.txtci)
        Me.txtProducto.Controls.Add(Me.cmbcodigo)
        Me.txtProducto.Controls.Add(Me.cmbNomE)
        Me.txtProducto.Controls.Add(Me.txtdev)
        Me.txtProducto.Controls.Add(Me.Label3)
        Me.txtProducto.Controls.Add(Me.lblCantidad)
        Me.txtProducto.Controls.Add(Me.Label8)
        Me.txtProducto.Controls.Add(Me.txtCantidad)
        Me.txtProducto.Location = New System.Drawing.Point(338, 214)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(523, 143)
        Me.txtProducto.TabIndex = 35
        Me.txtProducto.TabStop = False
        Me.txtProducto.Text = "Relación de Productos"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.ForeColor = System.Drawing.Color.Black
        Me.lblExistencia.Location = New System.Drawing.Point(443, 112)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(39, 13)
        Me.lblExistencia.TabIndex = 36
        Me.lblExistencia.Text = "Label2"
        Me.lblExistencia.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Descripción de Producto:"
        '
        'txtProductos
        '
        Me.txtProductos.Location = New System.Drawing.Point(133, 86)
        Me.txtProductos.Name = "txtProductos"
        Me.txtProductos.Size = New System.Drawing.Size(293, 20)
        Me.txtProductos.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Código de Producto:"
        '
        'lbldev
        '
        Me.lbldev.AutoSize = True
        Me.lbldev.Location = New System.Drawing.Point(33, 115)
        Me.lbldev.Name = "lbldev"
        Me.lbldev.Size = New System.Drawing.Size(98, 13)
        Me.lbldev.TabIndex = 26
        Me.lbldev.Text = "Cantidad Devuelta:"
        Me.lbldev.Visible = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.Location = New System.Drawing.Point(431, 28)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(86, 23)
        Me.btnEmpleados.TabIndex = 28
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.Location = New System.Drawing.Point(431, 83)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(86, 23)
        Me.btnProductos.TabIndex = 27
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'txtCodE
        '
        Me.txtCodE.Location = New System.Drawing.Point(133, 31)
        Me.txtCodE.Name = "txtCodE"
        Me.txtCodE.Size = New System.Drawing.Size(61, 20)
        Me.txtCodE.TabIndex = 24
        Me.txtCodE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(241, 117)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(25, 20)
        Me.txtci.TabIndex = 15
        Me.txtci.Visible = False
        '
        'cmbcodigo
        '
        Me.cmbcodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbcodigo.FormattingEnabled = True
        Me.cmbcodigo.Items.AddRange(New Object() {"Seleccionar"})
        Me.cmbcodigo.Location = New System.Drawing.Point(133, 57)
        Me.cmbcodigo.Name = "cmbcodigo"
        Me.cmbcodigo.Size = New System.Drawing.Size(165, 21)
        Me.cmbcodigo.TabIndex = 30
        Me.cmbcodigo.Text = "Seleccionar"
        '
        'cmbNomE
        '
        Me.cmbNomE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbNomE.FormattingEnabled = True
        Me.cmbNomE.Location = New System.Drawing.Point(255, 29)
        Me.cmbNomE.Name = "cmbNomE"
        Me.cmbNomE.Size = New System.Drawing.Size(170, 21)
        Me.cmbNomE.TabIndex = 13
        Me.cmbNomE.Text = "Seleccionar"
        '
        'txtdev
        '
        Me.txtdev.Location = New System.Drawing.Point(133, 112)
        Me.txtdev.Name = "txtdev"
        Me.txtdev.Size = New System.Drawing.Size(61, 20)
        Me.txtdev.TabIndex = 25
        Me.txtdev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtdev.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(29, 115)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(104, 13)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "Cantidad Entregada:"
        Me.lblCantidad.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Código de Empleado:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(133, 112)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtCantidad.TabIndex = 18
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.Visible = False
        '
        'lblEntrega
        '
        Me.lblEntrega.AutoSize = True
        Me.lblEntrega.BackColor = System.Drawing.Color.Red
        Me.lblEntrega.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrega.ForeColor = System.Drawing.Color.White
        Me.lblEntrega.Location = New System.Drawing.Point(316, 38)
        Me.lblEntrega.Name = "lblEntrega"
        Me.lblEntrega.Size = New System.Drawing.Size(270, 29)
        Me.lblEntrega.TabIndex = 40
        Me.lblEntrega.Text = "ENTREGA REGISTRADA"
        Me.lblEntrega.Visible = False
        '
        'dtgvLista
        '
        Me.dtgvLista.AllowUserToAddRows = False
        Me.dtgvLista.AllowUserToDeleteRows = False
        Me.dtgvLista.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dtgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgvLista.Location = New System.Drawing.Point(6, 371)
        Me.dtgvLista.Name = "dtgvLista"
        Me.dtgvLista.ReadOnly = True
        Me.dtgvLista.Size = New System.Drawing.Size(854, 294)
        Me.dtgvLista.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btncerrar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 125)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles de Relación de Datos:"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.Location = New System.Drawing.Point(9, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 56)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.Location = New System.Drawing.Point(9, 74)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(156, 42)
        Me.btncerrar.TabIndex = 6
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Brown
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.Location = New System.Drawing.Point(171, 17)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 99)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar Entrega ó Devolución"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(90, 19)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 56)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.SystemColors.Window
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(739, 12)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(112, 26)
        Me.txtfecha.TabIndex = 59
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(693, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Fecha:"
        '
        'Salida_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 677)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblDevo)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblEntrega)
        Me.Controls.Add(Me.dtgvLista)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Salida_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrega y Devolución de Productos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.txtProducto.ResumeLayout(False)
        Me.txtProducto.PerformLayout()
        CType(Me.dtgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlista As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cheTipo As System.Windows.Forms.CheckBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnEntre As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblDevo As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcodigo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents lbldev As System.Windows.Forms.Label
    Friend WithEvents txtCodE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdev As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents cmbNomE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNorden As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblEntrega As System.Windows.Forms.Label
    Friend WithEvents dtgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNor As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolFecha As System.Windows.Forms.ToolTip
End Class
