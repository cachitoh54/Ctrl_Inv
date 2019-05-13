<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iva))
        Me.btnborr = New System.Windows.Forms.Button()
        Me.btnact = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtporc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnborr
        '
        Me.btnborr.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnborr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnborr.Image = CType(resources.GetObject("btnborr.Image"), System.Drawing.Image)
        Me.btnborr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnborr.Location = New System.Drawing.Point(153, 76)
        Me.btnborr.Name = "btnborr"
        Me.btnborr.Size = New System.Drawing.Size(73, 57)
        Me.btnborr.TabIndex = 14
        Me.btnborr.Text = "Borrar"
        Me.btnborr.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnborr.UseVisualStyleBackColor = False
        '
        'btnact
        '
        Me.btnact.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnact.Image = CType(resources.GetObject("btnact.Image"), System.Drawing.Image)
        Me.btnact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnact.Location = New System.Drawing.Point(82, 76)
        Me.btnact.Name = "btnact"
        Me.btnact.Size = New System.Drawing.Size(73, 57)
        Me.btnact.TabIndex = 13
        Me.btnact.Text = "Actualizar"
        Me.btnact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnact.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnback.Location = New System.Drawing.Point(11, 76)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 57)
        Me.btnback.TabIndex = 12
        Me.btnback.Text = "Cerrar"
        Me.btnback.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnback.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtporc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 58)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actualizar Porcentaje"
        '
        'txtporc
        '
        Me.txtporc.Location = New System.Drawing.Point(92, 19)
        Me.txtporc.Name = "txtporc"
        Me.txtporc.Size = New System.Drawing.Size(44, 20)
        Me.txtporc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "%"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(159, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(10, 20)
        Me.txtId.TabIndex = 4
        Me.txtId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Porcentaje:"
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Iva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(236, 144)
        Me.Controls.Add(Me.btnborr)
        Me.Controls.Add(Me.btnact)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Iva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control del IVA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnborr As System.Windows.Forms.Button
    Friend WithEvents btnact As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtporc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
End Class
