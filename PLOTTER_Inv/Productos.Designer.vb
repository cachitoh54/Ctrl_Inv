<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAmbar = New System.Windows.Forms.Button()
        Me.btnFucsia = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtimag2 = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtCodPro = New System.Windows.Forms.TextBox()
        Me.cboCodPro = New System.Windows.Forms.ComboBox()
        Me.txtimag = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lebel1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtprecioU = New System.Windows.Forms.TextBox()
        Me.txtprecioE = New System.Windows.Forms.TextBox()
        Me.txtstockM = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblAmbar = New System.Windows.Forms.Label()
        Me.dtgListado = New System.Windows.Forms.DataGridView()
        Me.lblFucsia = New System.Windows.Forms.Label()
        Me.lblVerde = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnRojo)
        Me.GroupBox4.Controls.Add(Me.btnVerde)
        Me.GroupBox4.Controls.Add(Me.btnAmbar)
        Me.GroupBox4.Controls.Add(Me.btnFucsia)
        Me.GroupBox4.Controls.Add(Me.btnLista)
        Me.GroupBox4.Location = New System.Drawing.Point(396, 466)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 66)
        Me.GroupBox4.TabIndex = 62
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Comandos de Estado de los Productos"
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.IndianRed
        Me.btnRojo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRojo.ForeColor = System.Drawing.Color.Black
        Me.btnRojo.Location = New System.Drawing.Point(87, 28)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(39, 23)
        Me.btnRojo.TabIndex = 46
        Me.btnRojo.Text = "Ro"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnVerde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerde.ForeColor = System.Drawing.Color.Black
        Me.btnVerde.Location = New System.Drawing.Point(10, 28)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(39, 23)
        Me.btnVerde.TabIndex = 44
        Me.btnVerde.Text = "Ve"
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnAmbar
        '
        Me.btnAmbar.BackColor = System.Drawing.Color.PeachPuff
        Me.btnAmbar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAmbar.Location = New System.Drawing.Point(49, 28)
        Me.btnAmbar.Name = "btnAmbar"
        Me.btnAmbar.Size = New System.Drawing.Size(39, 23)
        Me.btnAmbar.TabIndex = 45
        Me.btnAmbar.Text = "Am"
        Me.btnAmbar.UseVisualStyleBackColor = False
        '
        'btnFucsia
        '
        Me.btnFucsia.BackColor = System.Drawing.Color.Thistle
        Me.btnFucsia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFucsia.ForeColor = System.Drawing.Color.Black
        Me.btnFucsia.Location = New System.Drawing.Point(126, 28)
        Me.btnFucsia.Name = "btnFucsia"
        Me.btnFucsia.Size = New System.Drawing.Size(39, 23)
        Me.btnFucsia.TabIndex = 47
        Me.btnFucsia.Text = "Vi"
        Me.btnFucsia.UseVisualStyleBackColor = False
        '
        'btnLista
        '
        Me.btnLista.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.Location = New System.Drawing.Point(170, 17)
        Me.btnLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(77, 35)
        Me.btnLista.TabIndex = 48
        Me.btnLista.Text = "Ver Lista Completa"
        Me.btnLista.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnmenu)
        Me.GroupBox3.Controls.Add(Me.btncerrar)
        Me.GroupBox3.Location = New System.Drawing.Point(734, 473)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 78)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandos de Salida"
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmenu.Location = New System.Drawing.Point(6, 17)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(112, 51)
        Me.btnmenu.TabIndex = 25
        Me.btnmenu.Text = "Regresar"
        Me.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.Location = New System.Drawing.Point(117, 17)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(112, 51)
        Me.btncerrar.TabIndex = 18
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'picFoto
        '
        Me.picFoto.BackColor = System.Drawing.Color.Transparent
        Me.picFoto.BackgroundImage = CType(resources.GetObject("picFoto.BackgroundImage"), System.Drawing.Image)
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picFoto.Location = New System.Drawing.Point(733, 206)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(232, 248)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 57
        Me.picFoto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picFoto, "Haga Click aquí" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "una Imagen.")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(733, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnCrear)
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.btnagregar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(16, 466)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 92)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos de Relación de Productos"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Image = CType(resources.GetObject("btnCrear.Image"), System.Drawing.Image)
        Me.btnCrear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCrear.Location = New System.Drawing.Point(152, 16)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 63)
        Me.btnCrear.TabIndex = 16
        Me.btnCrear.Text = "Nuevo "
        Me.btnCrear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Image = CType(resources.GetObject("btnactualizar.Image"), System.Drawing.Image)
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnactualizar.Location = New System.Drawing.Point(79, 16)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 63)
        Me.btnactualizar.TabIndex = 20
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.MistyRose
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Image = CType(resources.GetObject("btnagregar.Image"), System.Drawing.Image)
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.Location = New System.Drawing.Point(6, 16)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 63)
        Me.btnagregar.TabIndex = 19
        Me.btnagregar.Text = "Guardar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.Location = New System.Drawing.Point(225, 16)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 63)
        Me.btneliminar.TabIndex = 17
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtimag2)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.txtCodPro)
        Me.GroupBox1.Controls.Add(Me.cboCodPro)
        Me.GroupBox1.Controls.Add(Me.txtimag)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtcodP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Lebel1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.txtprecioU)
        Me.GroupBox1.Controls.Add(Me.txtprecioE)
        Me.GroupBox1.Controls.Add(Me.txtstockM)
        Me.GroupBox1.Controls.Add(Me.txtexistencia)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 178)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visualización"
        '
        'txtimag2
        '
        Me.txtimag2.Location = New System.Drawing.Point(590, 107)
        Me.txtimag2.Name = "txtimag2"
        Me.txtimag2.Size = New System.Drawing.Size(11, 20)
        Me.txtimag2.TabIndex = 44
        Me.txtimag2.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(604, 131)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(91, 41)
        Me.btnBorrar.TabIndex = 43
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'txtCodPro
        '
        Me.txtCodPro.Location = New System.Drawing.Point(643, 57)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Size = New System.Drawing.Size(10, 20)
        Me.txtCodPro.TabIndex = 42
        Me.txtCodPro.Visible = False
        '
        'cboCodPro
        '
        Me.cboCodPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCodPro.FormattingEnabled = True
        Me.cboCodPro.Location = New System.Drawing.Point(141, 39)
        Me.cboCodPro.Name = "cboCodPro"
        Me.cboCodPro.Size = New System.Drawing.Size(169, 21)
        Me.cboCodPro.TabIndex = 40
        '
        'txtimag
        '
        Me.txtimag.Location = New System.Drawing.Point(604, 83)
        Me.txtimag.Name = "txtimag"
        Me.txtimag.Size = New System.Drawing.Size(10, 20)
        Me.txtimag.TabIndex = 39
        Me.txtimag.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(329, 19)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(94, 41)
        Me.btnbuscar.TabIndex = 15
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(562, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Bs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Bs."
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(141, 66)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(418, 20)
        Me.txtdescripcion.TabIndex = 22
        '
        'txtcodP
        '
        Me.txtcodP.Location = New System.Drawing.Point(554, 31)
        Me.txtcodP.Name = "txtcodP"
        Me.txtcodP.ReadOnly = True
        Me.txtcodP.Size = New System.Drawing.Size(30, 20)
        Me.txtcodP.TabIndex = 21
        Me.txtcodP.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Precio Unitario:"
        '
        'Lebel1
        '
        Me.Lebel1.AutoSize = True
        Me.Lebel1.Location = New System.Drawing.Point(92, 43)
        Me.Lebel1.Name = "Lebel1"
        Me.Lebel1.Size = New System.Drawing.Size(43, 13)
        Me.Lebel1.TabIndex = 1
        Me.Lebel1.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stock Mínimo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcón:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Existencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Precio Empaque:"
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(141, 93)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(169, 20)
        Me.txtmarca.TabIndex = 2
        '
        'txtprecioU
        '
        Me.txtprecioU.Location = New System.Drawing.Point(141, 119)
        Me.txtprecioU.Name = "txtprecioU"
        Me.txtprecioU.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioU.TabIndex = 3
        Me.txtprecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtprecioE
        '
        Me.txtprecioE.Location = New System.Drawing.Point(459, 119)
        Me.txtprecioE.Name = "txtprecioE"
        Me.txtprecioE.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioE.TabIndex = 4
        Me.txtprecioE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstockM
        '
        Me.txtstockM.Location = New System.Drawing.Point(141, 145)
        Me.txtstockM.Name = "txtstockM"
        Me.txtstockM.Size = New System.Drawing.Size(82, 20)
        Me.txtstockM.TabIndex = 6
        Me.txtstockM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtexistencia
        '
        Me.txtexistencia.Location = New System.Drawing.Point(483, 93)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(76, 20)
        Me.txtexistencia.TabIndex = 5
        Me.txtexistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.BackColor = System.Drawing.Color.IndianRed
        Me.lblRed.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.ForeColor = System.Drawing.Color.Black
        Me.lblRed.Location = New System.Drawing.Point(741, 142)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(215, 57)
        Me.lblRed.TabIndex = 58
        Me.lblRed.Text = "   ""LA EXISTENCIA DE ESTE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  PRODUCTO SE ENCUENTRA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      EN EL STOCK MÍNIMO"""
        Me.lblRed.Visible = False
        '
        'lblAmbar
        '
        Me.lblAmbar.AutoSize = True
        Me.lblAmbar.BackColor = System.Drawing.Color.PeachPuff
        Me.lblAmbar.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmbar.Location = New System.Drawing.Point(730, 142)
        Me.lblAmbar.Name = "lblAmbar"
        Me.lblAmbar.Size = New System.Drawing.Size(239, 57)
        Me.lblAmbar.TabIndex = 56
        Me.lblAmbar.Text = """ALERTA..!!! LA EXISTENCIA DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         ESTE PRODUCTO ESTÁ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     CERCA DEL STOCK" & _
    " MÍNIMO"""
        Me.lblAmbar.Visible = False
        '
        'dtgListado
        '
        Me.dtgListado.AllowUserToAddRows = False
        Me.dtgListado.AllowUserToDeleteRows = False
        Me.dtgListado.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgListado.Location = New System.Drawing.Point(12, 206)
        Me.dtgListado.Name = "dtgListado"
        Me.dtgListado.ReadOnly = True
        Me.dtgListado.Size = New System.Drawing.Size(707, 248)
        Me.dtgListado.TabIndex = 52
        '
        'lblFucsia
        '
        Me.lblFucsia.AutoSize = True
        Me.lblFucsia.BackColor = System.Drawing.Color.Thistle
        Me.lblFucsia.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFucsia.ForeColor = System.Drawing.Color.Black
        Me.lblFucsia.Location = New System.Drawing.Point(736, 142)
        Me.lblFucsia.Name = "lblFucsia"
        Me.lblFucsia.Size = New System.Drawing.Size(224, 57)
        Me.lblFucsia.TabIndex = 59
        Me.lblFucsia.Text = "   ""LA EXISTENCIA DE ESTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      PRODUCTO ESTÁ POR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DEBAJO DEL STOCK MÍNIMO"""
        Me.lblFucsia.Visible = False
        '
        'lblVerde
        '
        Me.lblVerde.AutoSize = True
        Me.lblVerde.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblVerde.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerde.ForeColor = System.Drawing.Color.Black
        Me.lblVerde.Location = New System.Drawing.Point(753, 143)
        Me.lblVerde.Name = "lblVerde"
        Me.lblVerde.Size = New System.Drawing.Size(196, 57)
        Me.lblVerde.TabIndex = 60
        Me.lblVerde.Text = """LA EXISTENCIA DE ESTE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         PRODUCTO NO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " TIENE OBSERVACIONES"""
        Me.lblVerde.Visible = False
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(670, 483)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 35
        Me.txtvacio.Visible = False
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 573)
        Me.Controls.Add(Me.txtvacio)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAmbar)
        Me.Controls.Add(Me.dtgListado)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblFucsia)
        Me.Controls.Add(Me.lblVerde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnAmbar As System.Windows.Forms.Button
    Friend WithEvents btnFucsia As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtCodPro As System.Windows.Forms.TextBox
    Friend WithEvents cboCodPro As System.Windows.Forms.ComboBox
    Friend WithEvents txtimag As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lebel1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioU As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioE As System.Windows.Forms.TextBox
    Friend WithEvents txtstockM As System.Windows.Forms.TextBox
    Friend WithEvents txtexistencia As System.Windows.Forms.TextBox
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblAmbar As System.Windows.Forms.Label
    Friend WithEvents dtgListado As System.Windows.Forms.DataGridView
    Friend WithEvents lblFucsia As System.Windows.Forms.Label
    Friend WithEvents lblVerde As System.Windows.Forms.Label
    Friend WithEvents txtimag2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
End Class
