<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBven = New System.Windows.Forms.Label()
        Me.btnProv = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEntr = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFac = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEmpl = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnListP = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCambiarU = New System.Windows.Forms.Label()
        Me.txtLogin2 = New System.Windows.Forms.TextBox()
        Me.txtclave2 = New System.Windows.Forms.TextBox()
        Me.lbladmin2 = New System.Windows.Forms.Label()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEntr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEmpl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnListP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblBven)
        Me.GroupBox1.Controls.Add(Me.btnProv)
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEntr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFac)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnEmpl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnListP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 388)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione su Opción:"
        '
        'lblBven
        '
        Me.lblBven.AutoSize = True
        Me.lblBven.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBven.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBven.Location = New System.Drawing.Point(194, 28)
        Me.lblBven.Name = "lblBven"
        Me.lblBven.Size = New System.Drawing.Size(288, 25)
        Me.lblBven.TabIndex = 43
        Me.lblBven.Text = "BIENVENIDO MAURICIO!!!"
        '
        'btnProv
        '
        Me.btnProv.BackColor = System.Drawing.Color.Transparent
        Me.btnProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProv.Image = CType(resources.GetObject("btnProv.Image"), System.Drawing.Image)
        Me.btnProv.Location = New System.Drawing.Point(199, 280)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(100, 86)
        Me.btnProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnProv.TabIndex = 39
        Me.btnProv.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.Location = New System.Drawing.Point(546, 94)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 86)
        Me.btnReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReport.TabIndex = 42
        Me.btnReport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "  Lista de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Productos:"
        '
        'btnEntr
        '
        Me.btnEntr.BackColor = System.Drawing.Color.Transparent
        Me.btnEntr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntr.Image = CType(resources.GetObject("btnEntr.Image"), System.Drawing.Image)
        Me.btnEntr.Location = New System.Drawing.Point(546, 280)
        Me.btnEntr.Name = "btnEntr"
        Me.btnEntr.Size = New System.Drawing.Size(100, 86)
        Me.btnEntr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEntr.TabIndex = 41
        Me.btnEntr.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Empleados:"
        '
        'btnFac
        '
        Me.btnFac.BackColor = System.Drawing.Color.Transparent
        Me.btnFac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFac.Image = CType(resources.GetObject("btnFac.Image"), System.Drawing.Image)
        Me.btnFac.Location = New System.Drawing.Point(370, 280)
        Me.btnFac.Name = "btnFac"
        Me.btnFac.Size = New System.Drawing.Size(100, 86)
        Me.btnFac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFac.TabIndex = 40
        Me.btnFac.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "    Lista de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedores:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(377, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 30)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "   Factura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Compra:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(162, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnEmpl
        '
        Me.btnEmpl.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpl.Image = CType(resources.GetObject("btnEmpl.Image"), System.Drawing.Image)
        Me.btnEmpl.Location = New System.Drawing.Point(28, 280)
        Me.btnEmpl.Name = "btnEmpl"
        Me.btnEmpl.Size = New System.Drawing.Size(100, 86)
        Me.btnEmpl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEmpl.TabIndex = 38
        Me.btnEmpl.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 30)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Entrega y Devolución" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       de Productos:"
        '
        'btnListP
        '
        Me.btnListP.BackColor = System.Drawing.Color.Transparent
        Me.btnListP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListP.Image = CType(resources.GetObject("btnListP.Image"), System.Drawing.Image)
        Me.btnListP.Location = New System.Drawing.Point(28, 94)
        Me.btnListP.Name = "btnListP"
        Me.btnListP.Size = New System.Drawing.Size(100, 86)
        Me.btnListP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnListP.TabIndex = 37
        Me.btnListP.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(561, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Reportes:"
        '
        'lblCambiarU
        '
        Me.lblCambiarU.AutoSize = True
        Me.lblCambiarU.BackColor = System.Drawing.Color.Transparent
        Me.lblCambiarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCambiarU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambiarU.ForeColor = System.Drawing.Color.Maroon
        Me.lblCambiarU.Location = New System.Drawing.Point(12, 416)
        Me.lblCambiarU.Name = "lblCambiarU"
        Me.lblCambiarU.Size = New System.Drawing.Size(85, 30)
        Me.lblCambiarU.TabIndex = 50
        Me.lblCambiarU.Text = "Cambiar de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario"
        Me.lblCambiarU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLogin2
        '
        Me.txtLogin2.Location = New System.Drawing.Point(386, 407)
        Me.txtLogin2.Name = "txtLogin2"
        Me.txtLogin2.Size = New System.Drawing.Size(29, 20)
        Me.txtLogin2.TabIndex = 49
        Me.txtLogin2.Visible = False
        '
        'txtclave2
        '
        Me.txtclave2.Location = New System.Drawing.Point(421, 407)
        Me.txtclave2.Name = "txtclave2"
        Me.txtclave2.Size = New System.Drawing.Size(25, 20)
        Me.txtclave2.TabIndex = 48
        Me.txtclave2.Visible = False
        '
        'lbladmin2
        '
        Me.lbladmin2.AutoSize = True
        Me.lbladmin2.BackColor = System.Drawing.Color.Transparent
        Me.lbladmin2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbladmin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladmin2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbladmin2.Location = New System.Drawing.Point(192, 418)
        Me.lbladmin2.Name = "lbladmin2"
        Me.lbladmin2.Size = New System.Drawing.Size(135, 26)
        Me.lbladmin2.TabIndex = 47
        Me.lbladmin2.Text = "Cambio de Clave 2do. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Administrador"
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.BackColor = System.Drawing.Color.Transparent
        Me.lblCambio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCambio.Location = New System.Drawing.Point(198, 430)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(134, 16)
        Me.lblCambio.TabIndex = 46
        Me.lblCambio.Text = "ADMINISTRADOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Salir"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(601, 406)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 40)
        Me.Button7.TabIndex = 44
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(455, 407)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 52
        Me.txtvacio.Visible = False
        '
        'Menú
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 472)
        Me.Controls.Add(Me.txtvacio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCambiarU)
        Me.Controls.Add(Me.txtLogin2)
        Me.Controls.Add(Me.txtclave2)
        Me.Controls.Add(Me.lbladmin2)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menú"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEntr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEmpl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnListP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProv As System.Windows.Forms.PictureBox
    Friend WithEvents btnReport As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEntr As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFac As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEmpl As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnListP As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCambiarU As System.Windows.Forms.Label
    Friend WithEvents txtLogin2 As System.Windows.Forms.TextBox
    Friend WithEvents txtclave2 As System.Windows.Forms.TextBox
    Friend WithEvents lbladmin2 As System.Windows.Forms.Label
    Friend WithEvents lblCambio As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents lblBven As System.Windows.Forms.Label
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
End Class
