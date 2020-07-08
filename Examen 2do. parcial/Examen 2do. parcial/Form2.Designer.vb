<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtDireccionC = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNproducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardarC = New System.Windows.Forms.Button()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnNuevoC = New System.Windows.Forms.Button()
        Me.btnNuevoP = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDireccionC
        '
        Me.txtDireccionC.Location = New System.Drawing.Point(103, 185)
        Me.txtDireccionC.Multiline = True
        Me.txtDireccionC.Name = "txtDireccionC"
        Me.txtDireccionC.Size = New System.Drawing.Size(225, 58)
        Me.txtDireccionC.TabIndex = 5
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(103, 133)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(225, 22)
        Me.txtApellido.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombres"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDireccionC)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 275)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(103, 58)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(225, 22)
        Me.txtIdCliente.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNproducto)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 214)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Producto"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(103, 58)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(225, 22)
        Me.txtProducto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID Producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(103, 138)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(225, 58)
        Me.txtDescripcion.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Descripción"
        '
        'txtNproducto
        '
        Me.txtNproducto.Location = New System.Drawing.Point(103, 93)
        Me.txtNproducto.Name = "txtNproducto"
        Me.txtNproducto.Size = New System.Drawing.Size(225, 22)
        Me.txtNproducto.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 34)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnGuardarC
        '
        Me.btnGuardarC.Location = New System.Drawing.Point(372, 233)
        Me.btnGuardarC.Name = "btnGuardarC"
        Me.btnGuardarC.Size = New System.Drawing.Size(82, 54)
        Me.btnGuardarC.TabIndex = 15
        Me.btnGuardarC.Text = "Guardar Cliente"
        Me.btnGuardarC.UseVisualStyleBackColor = True
        '
        'btnGuardarP
        '
        Me.btnGuardarP.Location = New System.Drawing.Point(372, 453)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(82, 54)
        Me.btnGuardarP.TabIndex = 16
        Me.btnGuardarP.Text = "Guardar Producto"
        Me.btnGuardarP.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(377, 12)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(82, 54)
        Me.btnVentas.TabIndex = 17
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnNuevoC
        '
        Me.btnNuevoC.Location = New System.Drawing.Point(372, 204)
        Me.btnNuevoC.Name = "btnNuevoC"
        Me.btnNuevoC.Size = New System.Drawing.Size(82, 23)
        Me.btnNuevoC.TabIndex = 18
        Me.btnNuevoC.Text = "Nuevo"
        Me.btnNuevoC.UseVisualStyleBackColor = True
        '
        'btnNuevoP
        '
        Me.btnNuevoP.Location = New System.Drawing.Point(372, 424)
        Me.btnNuevoP.Name = "btnNuevoP"
        Me.btnNuevoP.Size = New System.Drawing.Size(82, 23)
        Me.btnNuevoP.TabIndex = 19
        Me.btnNuevoP.Text = "Nuevo"
        Me.btnNuevoP.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(471, 516)
        Me.Controls.Add(Me.btnNuevoP)
        Me.Controls.Add(Me.btnNuevoC)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnGuardarP)
        Me.Controls.Add(Me.btnGuardarC)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDireccionC As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNproducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGuardarC As Button
    Friend WithEvents btnGuardarP As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnNuevoP As Button
    Friend WithEvents btnNuevoC As Button
End Class
