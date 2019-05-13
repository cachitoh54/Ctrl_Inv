<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCta = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnact = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtTacce = New System.Windows.Forms.TextBox()
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(278, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCta)
        Me.GroupBox1.Controls.Add(Me.txtCI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnact)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 209)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2do. Administrador"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(163, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 26)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Actualizar Respuestas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      de Seguridad"
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(73, 103)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCta.Size = New System.Drawing.Size(168, 20)
        Me.txtCta.TabIndex = 63
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(73, 77)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCI.Size = New System.Drawing.Size(168, 20)
        Me.txtCI.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Cta. o Pste:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Cédula:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(73, 51)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(168, 20)
        Me.txtpassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Clave:"
        '
        'btnact
        '
        Me.btnact.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnact.Image = CType(resources.GetObject("btnact.Image"), System.Drawing.Image)
        Me.btnact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnact.Location = New System.Drawing.Point(11, 143)
        Me.btnact.Name = "btnact"
        Me.btnact.Size = New System.Drawing.Size(75, 57)
        Me.btnact.TabIndex = 1
        Me.btnact.Text = "Registrar"
        Me.btnact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnact.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Usuario:"
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.Image = CType(resources.GetObject("btnborrar.Image"), System.Drawing.Image)
        Me.btnborrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnborrar.Location = New System.Drawing.Point(84, 143)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 57)
        Me.btnborrar.TabIndex = 3
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(73, 25)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(168, 20)
        Me.txtLogin.TabIndex = 5
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(401, 129)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(14, 20)
        Me.txtId.TabIndex = 4
        Me.txtId.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Maroon
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(344, 177)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(53, 43)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'txtTacce
        '
        Me.txtTacce.Location = New System.Drawing.Point(339, 111)
        Me.txtTacce.Name = "txtTacce"
        Me.txtTacce.Size = New System.Drawing.Size(14, 20)
        Me.txtTacce.TabIndex = 39
        Me.txtTacce.Visible = False
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(359, 129)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 40
        Me.txtvacio.Visible = False
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Admin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 232)
        Me.Controls.Add(Me.txtvacio)
        Me.Controls.Add(Me.txtTacce)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Admin2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2do. Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnact As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTacce As System.Windows.Forms.TextBox
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
End Class
