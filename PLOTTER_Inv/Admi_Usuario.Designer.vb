<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admi_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admi_Usuario))
        Me.dtgvUsuario = New System.Windows.Forms.DataGridView()
        Me.txtTacce = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpassword2 = New System.Windows.Forms.TextBox()
        Me.txtLogin2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.txtResp5 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp1 = New System.Windows.Forms.TextBox()
        Me.txtCta = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.txtCI2 = New System.Windows.Forms.TextBox()
        Me.txtCta2 = New System.Windows.Forms.TextBox()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dtgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvUsuario
        '
        Me.dtgvUsuario.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dtgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgvUsuario.Location = New System.Drawing.Point(436, 4)
        Me.dtgvUsuario.Name = "dtgvUsuario"
        Me.dtgvUsuario.Size = New System.Drawing.Size(25, 15)
        Me.dtgvUsuario.TabIndex = 47
        Me.dtgvUsuario.Visible = False
        '
        'txtTacce
        '
        Me.txtTacce.Location = New System.Drawing.Point(545, 128)
        Me.txtTacce.Name = "txtTacce"
        Me.txtTacce.Size = New System.Drawing.Size(10, 20)
        Me.txtTacce.TabIndex = 38
        Me.txtTacce.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(407, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 26)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Reiniciar Clave del 2do. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Administrador"
        '
        'txtpassword2
        '
        Me.txtpassword2.Location = New System.Drawing.Point(529, 134)
        Me.txtpassword2.Name = "txtpassword2"
        Me.txtpassword2.Size = New System.Drawing.Size(10, 20)
        Me.txtpassword2.TabIndex = 45
        Me.txtpassword2.Visible = False
        '
        'txtLogin2
        '
        Me.txtLogin2.Location = New System.Drawing.Point(408, 130)
        Me.txtLogin2.Name = "txtLogin2"
        Me.txtLogin2.Size = New System.Drawing.Size(23, 20)
        Me.txtLogin2.TabIndex = 44
        Me.txtLogin2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(343, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btncerrar)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 86)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.Location = New System.Drawing.Point(13, 20)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 58)
        Me.btnActualizar.TabIndex = 62
        Me.btnActualizar.Text = "Registrar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(92, 20)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 58)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Limpiar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Transparent
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.Location = New System.Drawing.Point(249, 20)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(80, 58)
        Me.btncerrar.TabIndex = 10
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.Location = New System.Drawing.Point(170, 20)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 58)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Volver "
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(529, 170)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(23, 20)
        Me.txtId.TabIndex = 39
        Me.txtId.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtvacio)
        Me.GroupBox1.Controls.Add(Me.txtResp5)
        Me.GroupBox1.Controls.Add(Me.txtResp4)
        Me.GroupBox1.Controls.Add(Me.txtResp3)
        Me.GroupBox1.Controls.Add(Me.txtResp2)
        Me.GroupBox1.Controls.Add(Me.txtResp1)
        Me.GroupBox1.Controls.Add(Me.txtCta)
        Me.GroupBox1.Controls.Add(Me.txtCI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 226)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuario"
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(331, 112)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 64
        Me.txtvacio.Visible = False
        '
        'txtResp5
        '
        Me.txtResp5.Location = New System.Drawing.Point(298, 112)
        Me.txtResp5.Name = "txtResp5"
        Me.txtResp5.Size = New System.Drawing.Size(12, 20)
        Me.txtResp5.TabIndex = 62
        Me.txtResp5.Visible = False
        '
        'txtResp4
        '
        Me.txtResp4.Location = New System.Drawing.Point(287, 112)
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.Size = New System.Drawing.Size(10, 20)
        Me.txtResp4.TabIndex = 63
        Me.txtResp4.Visible = False
        '
        'txtResp3
        '
        Me.txtResp3.Location = New System.Drawing.Point(274, 112)
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.Size = New System.Drawing.Size(12, 20)
        Me.txtResp3.TabIndex = 62
        Me.txtResp3.Visible = False
        '
        'txtResp2
        '
        Me.txtResp2.Location = New System.Drawing.Point(260, 112)
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.Size = New System.Drawing.Size(13, 20)
        Me.txtResp2.TabIndex = 61
        Me.txtResp2.Visible = False
        '
        'txtResp1
        '
        Me.txtResp1.Location = New System.Drawing.Point(248, 112)
        Me.txtResp1.Name = "txtResp1"
        Me.txtResp1.Size = New System.Drawing.Size(10, 20)
        Me.txtResp1.TabIndex = 60
        Me.txtResp1.Visible = False
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(74, 103)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCta.Size = New System.Drawing.Size(168, 20)
        Me.txtCta.TabIndex = 59
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(74, 77)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCI.Size = New System.Drawing.Size(168, 20)
        Me.txtCI.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Cta. o Pste:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cédula:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(74, 51)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(236, 20)
        Me.txtpassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(74, 25)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(236, 20)
        Me.txtLogin.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(409, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 26)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Actualizar Respuestas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       de Seguridad"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.SlateBlue
        Me.btnreset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreset.Location = New System.Drawing.Point(439, 151)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 39)
        Me.btnreset.TabIndex = 43
        Me.btnreset.Text = "Reiniciar"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'txtCI2
        '
        Me.txtCI2.Location = New System.Drawing.Point(477, 2)
        Me.txtCI2.Name = "txtCI2"
        Me.txtCI2.Size = New System.Drawing.Size(17, 20)
        Me.txtCI2.TabIndex = 60
        Me.txtCI2.Visible = False
        '
        'txtCta2
        '
        Me.txtCta2.Location = New System.Drawing.Point(509, 1)
        Me.txtCta2.Name = "txtCta2"
        Me.txtCta2.Size = New System.Drawing.Size(14, 20)
        Me.txtCta2.TabIndex = 61
        Me.txtCta2.Visible = False
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Admi_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 250)
        Me.Controls.Add(Me.txtCta2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCI2)
        Me.Controls.Add(Me.dtgvUsuario)
        Me.Controls.Add(Me.txtTacce)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpassword2)
        Me.Controls.Add(Me.txtLogin2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnreset)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Admi_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador Principal"
        CType(Me.dtgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgvUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents txtTacce As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtCI2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCta2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp4 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp5 As System.Windows.Forms.TextBox
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
