<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbInFa = New System.Windows.Forms.RadioButton()
        Me.rbEnDe = New System.Windows.Forms.RadioButton()
        Me.rbPro = New System.Windows.Forms.RadioButton()
        Me.gboxBtn = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.txtvacio = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnirmenu = New System.Windows.Forms.Button()
        Me.gboxFechas = New System.Windows.Forms.GroupBox()
        Me.txtfechaF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfechaI = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolFecha = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gboxBtn.SuspendLayout()
        Me.gboxFechas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbInFa)
        Me.GroupBox1.Controls.Add(Me.rbEnDe)
        Me.GroupBox1.Controls.Add(Me.rbPro)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 110)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el tipo de Reporte"
        '
        'rbInFa
        '
        Me.rbInFa.AutoSize = True
        Me.rbInFa.Location = New System.Drawing.Point(22, 75)
        Me.rbInFa.Name = "rbInFa"
        Me.rbInFa.Size = New System.Drawing.Size(126, 30)
        Me.rbInFa.TabIndex = 2
        Me.rbInFa.TabStop = True
        Me.rbInFa.Text = "Factura e Ingreso de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Productos"
        Me.rbInFa.UseVisualStyleBackColor = True
        '
        'rbEnDe
        '
        Me.rbEnDe.AutoSize = True
        Me.rbEnDe.Location = New System.Drawing.Point(22, 43)
        Me.rbEnDe.Name = "rbEnDe"
        Me.rbEnDe.Size = New System.Drawing.Size(145, 30)
        Me.rbEnDe.TabIndex = 1
        Me.rbEnDe.TabStop = True
        Me.rbEnDe.Text = "Entrega y Devolución de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Productos"
        Me.rbEnDe.UseVisualStyleBackColor = True
        '
        'rbPro
        '
        Me.rbPro.AutoSize = True
        Me.rbPro.Location = New System.Drawing.Point(22, 21)
        Me.rbPro.Name = "rbPro"
        Me.rbPro.Size = New System.Drawing.Size(133, 17)
        Me.rbPro.TabIndex = 0
        Me.rbPro.TabStop = True
        Me.rbPro.Text = "Relación de Productos"
        Me.rbPro.UseVisualStyleBackColor = True
        '
        'gboxBtn
        '
        Me.gboxBtn.Controls.Add(Me.btnlimpiar)
        Me.gboxBtn.Controls.Add(Me.btnReport)
        Me.gboxBtn.Controls.Add(Me.txtvacio)
        Me.gboxBtn.Controls.Add(Me.btncerrar)
        Me.gboxBtn.Controls.Add(Me.btnirmenu)
        Me.gboxBtn.Location = New System.Drawing.Point(12, 209)
        Me.gboxBtn.Name = "gboxBtn"
        Me.gboxBtn.Size = New System.Drawing.Size(397, 90)
        Me.gboxBtn.TabIndex = 58
        Me.gboxBtn.TabStop = False
        Me.gboxBtn.Text = "Comandos"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlimpiar.Location = New System.Drawing.Point(68, 23)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(62, 59)
        Me.btnlimpiar.TabIndex = 36
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(266, 19)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(122, 66)
        Me.btnReport.TabIndex = 12
        Me.btnReport.Text = " Generar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reportes"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'txtvacio
        '
        Me.txtvacio.Location = New System.Drawing.Point(232, 42)
        Me.txtvacio.Name = "txtvacio"
        Me.txtvacio.Size = New System.Drawing.Size(15, 20)
        Me.txtvacio.TabIndex = 35
        Me.txtvacio.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Transparent
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncerrar.Location = New System.Drawing.Point(131, 23)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(62, 59)
        Me.btncerrar.TabIndex = 13
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnirmenu
        '
        Me.btnirmenu.BackColor = System.Drawing.Color.Transparent
        Me.btnirmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnirmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnirmenu.Image = CType(resources.GetObject("btnirmenu.Image"), System.Drawing.Image)
        Me.btnirmenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnirmenu.Location = New System.Drawing.Point(5, 23)
        Me.btnirmenu.Name = "btnirmenu"
        Me.btnirmenu.Size = New System.Drawing.Size(62, 59)
        Me.btnirmenu.TabIndex = 14
        Me.btnirmenu.Text = "Volver"
        Me.btnirmenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnirmenu.UseVisualStyleBackColor = False
        '
        'gboxFechas
        '
        Me.gboxFechas.BackColor = System.Drawing.Color.Transparent
        Me.gboxFechas.Controls.Add(Me.txtfechaF)
        Me.gboxFechas.Controls.Add(Me.Label2)
        Me.gboxFechas.Controls.Add(Me.Label1)
        Me.gboxFechas.Controls.Add(Me.txtfechaI)
        Me.gboxFechas.Location = New System.Drawing.Point(12, 128)
        Me.gboxFechas.Name = "gboxFechas"
        Me.gboxFechas.Size = New System.Drawing.Size(397, 76)
        Me.gboxFechas.TabIndex = 57
        Me.gboxFechas.TabStop = False
        Me.gboxFechas.Text = "Ingresar fechas:"
        '
        'txtfechaF
        '
        Me.txtfechaF.BackColor = System.Drawing.SystemColors.Info
        Me.txtfechaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfechaF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtfechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechaF.Location = New System.Drawing.Point(265, 33)
        Me.txtfechaF.Mask = "00/00/0000"
        Me.txtfechaF.Name = "txtfechaF"
        Me.txtfechaF.Size = New System.Drawing.Size(112, 29)
        Me.txtfechaF.TabIndex = 47
        Me.txtfechaF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Desde:"
        '
        'txtfechaI
        '
        Me.txtfechaI.BackColor = System.Drawing.SystemColors.Info
        Me.txtfechaI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfechaI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtfechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechaI.Location = New System.Drawing.Point(58, 33)
        Me.txtfechaI.Mask = "00/00/0000"
        Me.txtfechaI.Name = "txtfechaI"
        Me.txtfechaI.Size = New System.Drawing.Size(114, 29)
        Me.txtfechaI.TabIndex = 46
        Me.txtfechaI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PLOTTER_Inv.My.Resources.Resources.TRANSPARENTE__1_
        Me.PictureBox1.Location = New System.Drawing.Point(239, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 311)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboxBtn)
        Me.Controls.Add(Me.gboxFechas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Reporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxBtn.ResumeLayout(False)
        Me.gboxBtn.PerformLayout()
        Me.gboxFechas.ResumeLayout(False)
        Me.gboxFechas.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbInFa As System.Windows.Forms.RadioButton
    Friend WithEvents rbEnDe As System.Windows.Forms.RadioButton
    Friend WithEvents rbPro As System.Windows.Forms.RadioButton
    Friend WithEvents gboxBtn As System.Windows.Forms.GroupBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents txtvacio As System.Windows.Forms.TextBox
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnirmenu As System.Windows.Forms.Button
    Friend WithEvents gboxFechas As System.Windows.Forms.GroupBox
    Friend WithEvents txtfechaF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfechaI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents ToolFecha As System.Windows.Forms.ToolTip
End Class
