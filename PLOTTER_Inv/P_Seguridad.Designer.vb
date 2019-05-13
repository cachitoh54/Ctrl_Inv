<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Seguridad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Seguridad))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResp5 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTacce = New System.Windows.Forms.TextBox()
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtResp5)
        Me.GroupBox3.Controls.Add(Me.txtResp4)
        Me.GroupBox3.Controls.Add(Me.txtResp3)
        Me.GroupBox3.Controls.Add(Me.txtResp2)
        Me.GroupBox3.Controls.Add(Me.txtResp1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(483, 248)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Preguntas de seguridad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "5-. ¿Cuál es tu canción favorita?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(285, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "4-. ¿Cuál era el modelo de tu primer carro?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "3-. ¿Qué te gusta más de Venezuela?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "2-. ¿Cuál es tu libro favorito?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "1-. ¿Cuál es tu cantante o banda preferida?"
        '
        'txtResp5
        '
        Me.txtResp5.Location = New System.Drawing.Point(26, 216)
        Me.txtResp5.Name = "txtResp5"
        Me.txtResp5.Size = New System.Drawing.Size(423, 20)
        Me.txtResp5.TabIndex = 4
        '
        'txtResp4
        '
        Me.txtResp4.Location = New System.Drawing.Point(26, 177)
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.Size = New System.Drawing.Size(423, 20)
        Me.txtResp4.TabIndex = 3
        '
        'txtResp3
        '
        Me.txtResp3.Location = New System.Drawing.Point(26, 138)
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.Size = New System.Drawing.Size(423, 20)
        Me.txtResp3.TabIndex = 2
        '
        'txtResp2
        '
        Me.txtResp2.Location = New System.Drawing.Point(26, 99)
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.Size = New System.Drawing.Size(423, 20)
        Me.txtResp2.TabIndex = 1
        '
        'txtResp1
        '
        Me.txtResp1.Location = New System.Drawing.Point(26, 59)
        Me.txtResp1.Name = "txtResp1"
        Me.txtResp1.Size = New System.Drawing.Size(423, 20)
        Me.txtResp1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btncerrar)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 78)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.Location = New System.Drawing.Point(6, 14)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 58)
        Me.btnActualizar.TabIndex = 63
        Me.btnActualizar.Text = "Registrar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Location = New System.Drawing.Point(85, 14)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 58)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Limpiar"
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
        Me.btncerrar.Location = New System.Drawing.Point(241, 14)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(80, 58)
        Me.btncerrar.TabIndex = 10
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.Location = New System.Drawing.Point(163, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 58)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Volver "
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(38, 347)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(36, 20)
        Me.txtId.TabIndex = 51
        Me.txtId.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(340, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Responder Preguntas de Seguridad"
        '
        'txtTacce
        '
        Me.txtTacce.Location = New System.Drawing.Point(38, 318)
        Me.txtTacce.Name = "txtTacce"
        Me.txtTacce.Size = New System.Drawing.Size(10, 20)
        Me.txtTacce.TabIndex = 53
        Me.txtTacce.Visible = False
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(73, 317)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 35
        Me.txtvacio.Visible = False
        '
        'P_Seguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 394)
        Me.Controls.Add(Me.txtvacio)
        Me.Controls.Add(Me.txtTacce)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "P_Seguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas de Seguridad"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResp5 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp4 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTacce As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
