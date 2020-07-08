Imports System.ComponentModel

Public Class Form1
    Dim conexion As New conexion()
    Dim dt As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarFactura()
    End Sub

    Private Sub buscar()
        Try
            dt = conexion.busqueda(" factura.Venta ", " idVenta like '%" + txtBuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgFactura.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgFactura.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("factura.Venta", "idCliente='" + txtIDCliente.Text + "'")) Then
                MessageBox.Show("Eliminado")
                mostrarFactura()
                limpiarVenta()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtIDVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDVenta.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDCliente.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDProducto.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub limpiar()
        txtIDVenta.Clear()
        txtFecha.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtIDCliente.Clear()
        txtIDProducto.Clear()
    End Sub

    Private Sub limpiarVenta()
        txtIDCliente.Clear()
        txtFecha.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub dtgFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFactura.CellClick
        Dim FilaActual As Integer
        FilaActual = dtgFactura.CurrentRow.Index
        txtIDCliente.Text = dtgFactura.Rows(FilaActual).Cells(0).Value
        txtPrecio.Text = dtgFactura.Rows(FilaActual).Cells(4).Value
        txtCantidad.Text = dtgFactura.Rows(FilaActual).Cells(5).Value
        txtFecha.Text = dtgFactura.Rows(FilaActual).Cells(6).Value
    End Sub

    Private Sub mostrarFactura()
        conexion.Llenar("select Venta.idCliente as 'ID Cliente', Cliente.nombre as 'Nombre', Cliente.apellido as 'Apellido', Producto.nombreProducto as 'Producto', precio as 'Precio', cantidad as 'Cantidad',fechaVenta as 'Fecha de Venta' 
from factura.cliente as Cliente
inner join factura.Venta as Venta 
on Cliente.idCliente = Venta.idCliente
inner join factura.producto as Producto
on Venta.idProducto = Producto.idProducto;", "factura.cliente, factura.producto, factura.Venta")
        dtgFactura.DataSource = conexion.ds.Tables("factura.cliente, factura.producto, factura.Venta")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim update As String = "idCliente='" + txtIDCliente.Text + "', fechaVenta='" + txtFecha.Text + "', precio='" + txtPrecio.Text + "', cantidad='" + txtCantidad.Text + "'"
        If (conexion.modificar(" factura.Venta ", update, " idCliente= '" + txtIDCliente.Text + "'")) Then
            MessageBox.Show("Datos actualizados")
            mostrarFactura()
            limpiarVenta()
        Else
            MessageBox.Show("Error al actualizar los datos")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Me.ValidateChildren And txtIDVenta.Text <> String.Empty And txtFecha.Text <> String.Empty And txtPrecio.Text <> String.Empty And txtCantidad.Text <> String.Empty And txtIDCliente.Text <> String.Empty And txtIDProducto.Text <> String.Empty Then
                Dim agregar As String = "insert into factura.Venta values('" + txtIDVenta.Text + "','" + txtFecha.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtIDCliente.Text + "','" + txtIDProducto.Text + "')"
                If (conexion.insertar(agregar, txtIDVenta.Text)) Then
                    MessageBox.Show("Venta Realizada")
                    mostrarFactura()
                    limpiar()
                Else
                    MessageBox.Show("Datos existentes")
                End If
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarCliente()
    End Sub

    Private Sub BuscarCliente()
        Try
            dt = conexion.busqueda(" factura.Venta ", " idCliente like '%" + txtBuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgFactura.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgFactura.DataSource = Nothing
                mostrarFactura()
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFecha_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIDVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtIDVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub
    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIDCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIDCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIDProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIDProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        ToolTip1.SetToolTip(txtFecha, "Ingrese la fecha YYYY-MM-DD")
        ToolTip1.ToolTipTitle = "Fecha"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
