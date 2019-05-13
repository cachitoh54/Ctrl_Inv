<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperarClave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperarClave))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblRecUsr = New System.Windows.Forms.Label()
        Me.btnAceptar4 = New System.Windows.Forms.Button()
        Me.txtUsr = New System.Windows.Forms.TextBox()
        Me.lblConfUsr = New System.Windows.Forms.Label()
        Me.lblNuevoUsr = New System.Windows.Forms.Label()
        Me.txtUsrCof = New System.Windows.Forms.TextBox()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.lblConf = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtConf = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtResp9 = New System.Windows.Forms.TextBox()
        Me.txtResp7 = New System.Windows.Forms.TextBox()
        Me.txtResp5 = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp1 = New System.Windows.Forms.TextBox()
        Me.txtResp8 = New System.Windows.Forms.TextBox()
        Me.txtResp6 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp0 = New System.Windows.Forms.TextBox()
        Me.lblPreg1 = New System.Windows.Forms.Label()
        Me.lblPreg0 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.lblConyUsr = New System.Windows.Forms.Label()
        Me.lblResSeg = New System.Windows.Forms.Label()
        Me.lblUsr = New System.Windows.Forms.Label()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.lblRecUsr)
        Me.GroupBox1.Controls.Add(Me.btnAceptar4)
        Me.GroupBox1.Controls.Add(Me.txtUsr)
        Me.GroupBox1.Controls.Add(Me.lblConfUsr)
        Me.GroupBox1.Controls.Add(Me.lblNuevoUsr)
        Me.GroupBox1.Controls.Add(Me.txtUsrCof)
        Me.GroupBox1.Controls.Add(Me.btnAceptar2)
        Me.GroupBox1.Controls.Add(Me.lblConf)
        Me.GroupBox1.Controls.Add(Me.lblClave)
        Me.GroupBox1.Controls.Add(Me.txtConf)
        Me.GroupBox1.Controls.Add(Me.txtClave)
        Me.GroupBox1.Controls.Add(Me.txtResp9)
        Me.GroupBox1.Controls.Add(Me.txtResp7)
        Me.GroupBox1.Controls.Add(Me.txtResp5)
        Me.GroupBox1.Controls.Add(Me.txtResp3)
        Me.GroupBox1.Controls.Add(Me.txtResp1)
        Me.GroupBox1.Controls.Add(Me.txtResp8)
        Me.GroupBox1.Controls.Add(Me.txtResp6)
        Me.GroupBox1.Controls.Add(Me.txtResp4)
        Me.GroupBox1.Controls.Add(Me.txtResp2)
        Me.GroupBox1.Controls.Add(Me.txtResp0)
        Me.GroupBox1.Controls.Add(Me.lblPreg1)
        Me.GroupBox1.Controls.Add(Me.lblPreg0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnAceptar3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNro)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtCI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(348, 158)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(66, 59)
        Me.btnBorrar.TabIndex = 90
        Me.btnBorrar.Text = "Limpiar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.Location = New System.Drawing.Point(412, 158)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(66, 59)
        Me.btnCancelar.TabIndex = 89
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblRecUsr
        '
        Me.lblRecUsr.AutoSize = True
        Me.lblRecUsr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRecUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecUsr.ForeColor = System.Drawing.Color.Yellow
        Me.lblRecUsr.Location = New System.Drawing.Point(11, 181)
        Me.lblRecUsr.Name = "lblRecUsr"
        Me.lblRecUsr.Size = New System.Drawing.Size(143, 26)
        Me.lblRecUsr.TabIndex = 88
        Me.lblRecUsr.Text = "  Haga Click aquí para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ""Recuperar el Usuario"""
        '
        'btnAceptar4
        '
        Me.btnAceptar4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptar4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar4.Image = CType(resources.GetObject("btnAceptar4.Image"), System.Drawing.Image)
        Me.btnAceptar4.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAceptar4.Location = New System.Drawing.Point(250, 75)
        Me.btnAceptar4.Name = "btnAceptar4"
        Me.btnAceptar4.Size = New System.Drawing.Size(83, 61)
        Me.btnAceptar4.TabIndex = 87
        Me.btnAceptar4.Text = "Aceptar"
        Me.btnAceptar4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar4.UseVisualStyleBackColor = False
        '
        'txtUsr
        '
        Me.txtUsr.Location = New System.Drawing.Point(21, 75)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(196, 20)
        Me.txtUsr.TabIndex = 86
        '
        'lblConfUsr
        '
        Me.lblConfUsr.AutoSize = True
        Me.lblConfUsr.Location = New System.Drawing.Point(18, 105)
        Me.lblConfUsr.Name = "lblConfUsr"
        Me.lblConfUsr.Size = New System.Drawing.Size(142, 13)
        Me.lblConfUsr.TabIndex = 85
        Me.lblConfUsr.Text = "Confirmar su Nuevo Usuario:"
        '
        'lblNuevoUsr
        '
        Me.lblNuevoUsr.AutoSize = True
        Me.lblNuevoUsr.Location = New System.Drawing.Point(18, 59)
        Me.lblNuevoUsr.Name = "lblNuevoUsr"
        Me.lblNuevoUsr.Size = New System.Drawing.Size(137, 13)
        Me.lblNuevoUsr.TabIndex = 84
        Me.lblNuevoUsr.Text = "Coloque su Nuevo Usuario:"
        '
        'txtUsrCof
        '
        Me.txtUsrCof.Location = New System.Drawing.Point(21, 121)
        Me.txtUsrCof.Name = "txtUsrCof"
        Me.txtUsrCof.Size = New System.Drawing.Size(196, 20)
        Me.txtUsrCof.TabIndex = 83
        '
        'btnAceptar2
        '
        Me.btnAceptar2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar2.Image = CType(resources.GetObject("btnAceptar2.Image"), System.Drawing.Image)
        Me.btnAceptar2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAceptar2.Location = New System.Drawing.Point(250, 75)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(83, 61)
        Me.btnAceptar2.TabIndex = 82
        Me.btnAceptar2.Text = "Aceptar"
        Me.btnAceptar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar2.UseVisualStyleBackColor = False
        '
        'lblConf
        '
        Me.lblConf.AutoSize = True
        Me.lblConf.Location = New System.Drawing.Point(18, 105)
        Me.lblConf.Name = "lblConf"
        Me.lblConf.Size = New System.Drawing.Size(160, 13)
        Me.lblConf.TabIndex = 81
        Me.lblConf.Text = "Confirmar su Nueva Contraseña:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(18, 59)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(155, 13)
        Me.lblClave.TabIndex = 80
        Me.lblClave.Text = "Coloque su Nueva Contraseña:"
        '
        'txtConf
        '
        Me.txtConf.Location = New System.Drawing.Point(21, 121)
        Me.txtConf.Name = "txtConf"
        Me.txtConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConf.Size = New System.Drawing.Size(196, 20)
        Me.txtConf.TabIndex = 79
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(21, 75)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtClave.Size = New System.Drawing.Size(196, 20)
        Me.txtClave.TabIndex = 78
        '
        'txtResp9
        '
        Me.txtResp9.Location = New System.Drawing.Point(92, 113)
        Me.txtResp9.Name = "txtResp9"
        Me.txtResp9.Size = New System.Drawing.Size(261, 20)
        Me.txtResp9.TabIndex = 77
        '
        'txtResp7
        '
        Me.txtResp7.Location = New System.Drawing.Point(92, 113)
        Me.txtResp7.Name = "txtResp7"
        Me.txtResp7.Size = New System.Drawing.Size(261, 20)
        Me.txtResp7.TabIndex = 76
        '
        'txtResp5
        '
        Me.txtResp5.Location = New System.Drawing.Point(93, 113)
        Me.txtResp5.Name = "txtResp5"
        Me.txtResp5.Size = New System.Drawing.Size(261, 20)
        Me.txtResp5.TabIndex = 75
        '
        'txtResp3
        '
        Me.txtResp3.Location = New System.Drawing.Point(92, 113)
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.Size = New System.Drawing.Size(261, 20)
        Me.txtResp3.TabIndex = 74
        '
        'txtResp1
        '
        Me.txtResp1.Location = New System.Drawing.Point(92, 113)
        Me.txtResp1.Name = "txtResp1"
        Me.txtResp1.Size = New System.Drawing.Size(261, 20)
        Me.txtResp1.TabIndex = 73
        '
        'txtResp8
        '
        Me.txtResp8.Location = New System.Drawing.Point(92, 68)
        Me.txtResp8.Name = "txtResp8"
        Me.txtResp8.Size = New System.Drawing.Size(261, 20)
        Me.txtResp8.TabIndex = 72
        '
        'txtResp6
        '
        Me.txtResp6.Location = New System.Drawing.Point(93, 68)
        Me.txtResp6.Name = "txtResp6"
        Me.txtResp6.Size = New System.Drawing.Size(261, 20)
        Me.txtResp6.TabIndex = 71
        '
        'txtResp4
        '
        Me.txtResp4.Location = New System.Drawing.Point(93, 68)
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.Size = New System.Drawing.Size(261, 20)
        Me.txtResp4.TabIndex = 70
        '
        'txtResp2
        '
        Me.txtResp2.Location = New System.Drawing.Point(92, 68)
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.Size = New System.Drawing.Size(261, 20)
        Me.txtResp2.TabIndex = 69
        '
        'txtResp0
        '
        Me.txtResp0.Location = New System.Drawing.Point(92, 68)
        Me.txtResp0.Name = "txtResp0"
        Me.txtResp0.Size = New System.Drawing.Size(261, 20)
        Me.txtResp0.TabIndex = 68
        '
        'lblPreg1
        '
        Me.lblPreg1.AutoSize = True
        Me.lblPreg1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg1.Location = New System.Drawing.Point(90, 93)
        Me.lblPreg1.Name = "lblPreg1"
        Me.lblPreg1.Size = New System.Drawing.Size(53, 17)
        Me.lblPreg1.TabIndex = 67
        Me.lblPreg1.Text = "Label6"
        '
        'lblPreg0
        '
        Me.lblPreg0.AutoSize = True
        Me.lblPreg0.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg0.Location = New System.Drawing.Point(90, 48)
        Me.lblPreg0.Name = "lblPreg0"
        Me.lblPreg0.Size = New System.Drawing.Size(53, 17)
        Me.lblPreg0.TabIndex = 66
        Me.lblPreg0.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Respuesta 2:"
        '
        'btnAceptar3
        '
        Me.btnAceptar3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar3.Image = CType(resources.GetObject("btnAceptar3.Image"), System.Drawing.Image)
        Me.btnAceptar3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAceptar3.Location = New System.Drawing.Point(379, 73)
        Me.btnAceptar3.Name = "btnAceptar3"
        Me.btnAceptar3.Size = New System.Drawing.Size(83, 61)
        Me.btnAceptar3.TabIndex = 64
        Me.btnAceptar3.Text = "Aceptar"
        Me.btnAceptar3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Respuesta 1:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAceptar.Location = New System.Drawing.Point(250, 54)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 61)
        Me.btnAceptar.TabIndex = 62
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Nro. de Cta. bancaria o Pasaporte:"
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(22, 94)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(168, 20)
        Me.txtNro.TabIndex = 60
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(160, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(30, 20)
        Me.txtId.TabIndex = 59
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(22, 53)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(168, 20)
        Me.txtCI.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nro. de Cédula:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(320, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'lblNuevo
        '
        Me.lblNuevo.AutoSize = True
        Me.lblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.lblNuevo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevo.ForeColor = System.Drawing.Color.Maroon
        Me.lblNuevo.Location = New System.Drawing.Point(29, 20)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(258, 22)
        Me.lblNuevo.TabIndex = 44
        Me.lblNuevo.Text = "Coloque su Nueva Contraseña"
        '
        'lblConyUsr
        '
        Me.lblConyUsr.AutoSize = True
        Me.lblConyUsr.BackColor = System.Drawing.Color.Transparent
        Me.lblConyUsr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConyUsr.ForeColor = System.Drawing.Color.Maroon
        Me.lblConyUsr.Location = New System.Drawing.Point(21, 11)
        Me.lblConyUsr.Name = "lblConyUsr"
        Me.lblConyUsr.Size = New System.Drawing.Size(279, 44)
        Me.lblConyUsr.TabIndex = 45
        Me.lblConyUsr.Text = "Colocar Datos para Recuperara " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Contraseña y/o Usuario"
        '
        'lblResSeg
        '
        Me.lblResSeg.AutoSize = True
        Me.lblResSeg.BackColor = System.Drawing.Color.Transparent
        Me.lblResSeg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResSeg.ForeColor = System.Drawing.Color.Maroon
        Me.lblResSeg.Location = New System.Drawing.Point(53, 11)
        Me.lblResSeg.Name = "lblResSeg"
        Me.lblResSeg.Size = New System.Drawing.Size(210, 44)
        Me.lblResSeg.TabIndex = 91
        Me.lblResSeg.Text = "Respuestas a Preguntas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        de Seguridad"
        '
        'lblUsr
        '
        Me.lblUsr.AutoSize = True
        Me.lblUsr.BackColor = System.Drawing.Color.Transparent
        Me.lblUsr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsr.ForeColor = System.Drawing.Color.Maroon
        Me.lblUsr.Location = New System.Drawing.Point(36, 20)
        Me.lblUsr.Name = "lblUsr"
        Me.lblUsr.Size = New System.Drawing.Size(227, 22)
        Me.lblUsr.TabIndex = 92
        Me.lblUsr.Text = "Coloque su Nuevo Usuario"
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'RecuperarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 302)
        Me.Controls.Add(Me.lblConyUsr)
        Me.Controls.Add(Me.lblUsr)
        Me.Controls.Add(Me.lblResSeg)
        Me.Controls.Add(Me.lblNuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RecuperarClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Contraseña y/o Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResp9 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp7 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp5 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp8 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp6 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp4 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp0 As System.Windows.Forms.TextBox
    Friend WithEvents lblPreg1 As System.Windows.Forms.Label
    Friend WithEvents lblPreg0 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNro As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar2 As System.Windows.Forms.Button
    Friend WithEvents lblConf As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtConf As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar4 As System.Windows.Forms.Button
    Friend WithEvents txtUsr As System.Windows.Forms.TextBox
    Friend WithEvents lblConfUsr As System.Windows.Forms.Label
    Friend WithEvents lblNuevoUsr As System.Windows.Forms.Label
    Friend WithEvents txtUsrCof As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblRecUsr As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNuevo As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblConyUsr As System.Windows.Forms.Label
    Friend WithEvents lblResSeg As System.Windows.Forms.Label
    Friend WithEvents lblUsr As System.Windows.Forms.Label
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
End Class
