Imports System.ComponentModel

Public Class Form2
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub btnGuardarC_Click(sender As Object, e As EventArgs) Handles btnGuardarC.Click
        Try
            If Me.ValidateChildren And txtIdCliente.Text <> String.Empty And txtNombre.Text <> String.Empty And Not IsNumeric(txtNombre.Text) And txtApellido.Text <> String.Empty And Not IsNumeric(txtApellido.Text) And txtDireccionC.Text <> String.Empty And Not IsNumeric(txtDireccionC.Text) Then
                Dim agregar As String = "insert into factura.cliente values('" + txtIdCliente.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccionC.Text + "')"
                If (conexion.insertar(agregar, txtIdCliente.Text)) Then
                    MessageBox.Show("Cliente agregado")
                    tablaClientes()
                Else
                    MessageBox.Show("Datos existentes")
                End If
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tablaClientes()
        conexion.Llenar("select * from factura.cliente", "factura.cliente")
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click
        Try
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtNproducto.Text <> String.Empty And Not IsNumeric(txtNproducto.Text) And txtDescripcion.Text <> String.Empty And Not IsNumeric(txtDescripcion.Text) Then
                Dim agregar As String = "insert into factura.producto values('" + txtProducto.Text + "','" + txtNproducto.Text + "','" + txtDescripcion.Text + "')"
                If (conexion.insertar2(agregar, txtProducto.Text)) Then
                    MessageBox.Show("Producto agregado")
                    tablaProducto()
                Else
                    MessageBox.Show("Datos existentes")
                End If
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tablaProducto()
        conexion.Llenar("select * from factura.producto", "factura.producto")
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Form1.Show()
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged
        txtIdCliente.Focus()
    End Sub

    Private Sub txtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccionC_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccionC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtNproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub btnNuevoC_Click(sender As Object, e As EventArgs) Handles btnNuevoC.Click
        txtIdCliente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccionC.Clear()
    End Sub

    Private Sub btnNuevoP_Click(sender As Object, e As EventArgs) Handles btnNuevoP.Click
        txtProducto.Clear()
        txtNproducto.Clear()
        txtDescripcion.Clear()
    End Sub
End Class