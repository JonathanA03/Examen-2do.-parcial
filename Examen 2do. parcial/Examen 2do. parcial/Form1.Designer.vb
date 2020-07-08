<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dtgFactura = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Datos.SuspendLayout()
        CType(Me.dtgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datos
        '
        Me.Datos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Datos.Controls.Add(Me.btnGuardar)
        Me.Datos.Controls.Add(Me.btnEliminar)
        Me.Datos.Controls.Add(Me.btnActualizar)
        Me.Datos.Controls.Add(Me.txtIDProducto)
        Me.Datos.Controls.Add(Me.Label6)
        Me.Datos.Controls.Add(Me.txtIDCliente)
        Me.Datos.Controls.Add(Me.Label5)
        Me.Datos.Controls.Add(Me.txtCantidad)
        Me.Datos.Controls.Add(Me.txtPrecio)
        Me.Datos.Controls.Add(Me.Label4)
        Me.Datos.Controls.Add(Me.Label3)
        Me.Datos.Controls.Add(Me.txtFecha)
        Me.Datos.Controls.Add(Me.Label2)
        Me.Datos.Controls.Add(Me.txtIDVenta)
        Me.Datos.Controls.Add(Me.Label1)
        Me.Datos.Location = New System.Drawing.Point(12, 12)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(355, 357)
        Me.Datos.TabIndex = 0
        Me.Datos.TabStop = False
        Me.Datos.Text = "Datos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(14, 294)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 41)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(243, 294)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 41)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(129, 294)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(82, 41)
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Location = New System.Drawing.Point(120, 241)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(189, 22)
        Me.txtIDProducto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID Producto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(120, 198)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(189, 22)
        Me.txtIDCliente.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID Cliente"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(120, 154)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(189, 22)
        Me.txtCantidad.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(120, 112)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(189, 22)
        Me.txtPrecio.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(120, 72)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(189, 22)
        Me.txtFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Venta"
        '
        'txtIDVenta
        '
        Me.txtIDVenta.Location = New System.Drawing.Point(120, 30)
        Me.txtIDVenta.MaxLength = 4
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.Size = New System.Drawing.Size(189, 22)
        Me.txtIDVenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID venta"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(138, 30)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 41)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dtgFactura
        '
        Me.dtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFactura.Location = New System.Drawing.Point(373, 42)
        Me.dtgFactura.Name = "dtgFactura"
        Me.dtgFactura.RowHeadersWidth = 51
        Me.dtgFactura.RowTemplate.Height = 24
        Me.dtgFactura.Size = New System.Drawing.Size(752, 427)
        Me.dtgFactura.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(470, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(181, 22)
        Me.txtBuscar.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 94)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 41)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1137, 477)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dtgFactura)
        Me.Controls.Add(Me.Datos)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tienda"
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.dtgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datos As GroupBox
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dtgFactura As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
End Class
