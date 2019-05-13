<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.txtLogin2 = New System.Windows.Forms.TextBox()
        Me.txtclave2 = New System.Windows.Forms.TextBox()
        Me.lbladmin2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblRecUyC = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.lblFact = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFcad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin2
        '
        Me.txtLogin2.Location = New System.Drawing.Point(287, 192)
        Me.txtLogin2.Name = "txtLogin2"
        Me.txtLogin2.Size = New System.Drawing.Size(15, 20)
        Me.txtLogin2.TabIndex = 36
        Me.txtLogin2.Visible = False
        '
        'txtclave2
        '
        Me.txtclave2.Location = New System.Drawing.Point(307, 130)
        Me.txtclave2.Name = "txtclave2"
        Me.txtclave2.Size = New System.Drawing.Size(100, 20)
        Me.txtclave2.TabIndex = 35
        Me.txtclave2.Visible = False
        '
        'lbladmin2
        '
        Me.lbladmin2.AutoSize = True
        Me.lbladmin2.BackColor = System.Drawing.Color.Transparent
        Me.lbladmin2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbladmin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladmin2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbladmin2.Location = New System.Drawing.Point(171, 16)
        Me.lbladmin2.Name = "lbladmin2"
        Me.lbladmin2.Size = New System.Drawing.Size(91, 26)
        Me.lbladmin2.TabIndex = 34
        Me.lbladmin2.Text = "Registrar 2do. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Administrador"
        Me.lbladmin2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.lblRecUyC)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.txtclave)
        Me.GroupBox1.Controls.Add(Me.lbladmin2)
        Me.GroupBox1.Controls.Add(Me.lblclave)
        Me.GroupBox1.Controls.Add(Me.lblusuario)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 212)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verificación"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(106, 149)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 57)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Limpiar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'lblRecUyC
        '
        Me.lblRecUyC.AutoSize = True
        Me.lblRecUyC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRecUyC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecUyC.ForeColor = System.Drawing.Color.Maroon
        Me.lblRecUyC.Location = New System.Drawing.Point(147, 109)
        Me.lblRecUyC.Name = "lblRecUyC"
        Me.lblRecUyC.Size = New System.Drawing.Size(99, 26)
        Me.lblRecUyC.TabIndex = 8
        Me.lblRecUyC.Text = "¿Olvidó su Usuario " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   y/o Contraseña?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 149)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Location = New System.Drawing.Point(41, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Es administrador"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(90, 59)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(156, 20)
        Me.txtLogin.TabIndex = 0
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.Color.Transparent
        Me.btningresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Image = CType(resources.GetObject("btningresar.Image"), System.Drawing.Image)
        Me.btningresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresar.Location = New System.Drawing.Point(187, 149)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 57)
        Me.btningresar.TabIndex = 3
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(90, 85)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtclave.Size = New System.Drawing.Size(156, 20)
        Me.txtclave.TabIndex = 2
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Location = New System.Drawing.Point(20, 88)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(64, 13)
        Me.lblclave.TabIndex = 1
        Me.lblclave.Text = "Contraseña:"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(38, 62)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(46, 13)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "Usuario:"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Maroon
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.Location = New System.Drawing.Point(326, 180)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(70, 38)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Cancelar"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(305, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BIENVEDIDO!!!"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\vit\Desktop\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\MP10" & _
    "\MP10.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'lblFact
        '
        Me.lblFact.AutoSize = True
        Me.lblFact.Location = New System.Drawing.Point(337, 267)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(39, 13)
        Me.lblFact.TabIndex = 40
        Me.lblFact.Text = "Label3"
        Me.lblFact.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(81, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 26)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Para mayor información, contacte al proveedor de la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicación al 04169051541 / " & _
    "(0239)2120365"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblFcad
        '
        Me.lblFcad.AutoSize = True
        Me.lblFcad.BackColor = System.Drawing.Color.Transparent
        Me.lblFcad.ForeColor = System.Drawing.Color.Black
        Me.lblFcad.Location = New System.Drawing.Point(275, 251)
        Me.lblFcad.Name = "lblFcad"
        Me.lblFcad.Size = New System.Drawing.Size(41, 13)
        Me.lblFcad.TabIndex = 38
        Me.lblFcad.Text = "lblFcad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(44, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Este producto tiene fecha de vigencia hasta el:"
        '
        'tmTiempo
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(288, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.lblFact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFcad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLogin2)
        Me.Controls.Add(Me.txtclave2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogin2 As System.Windows.Forms.TextBox
    Friend WithEvents txtclave2 As System.Windows.Forms.TextBox
    Friend WithEvents lbladmin2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecUyC As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents lblFact As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFcad As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmTiempo As System.Windows.Forms.Timer

End Class
