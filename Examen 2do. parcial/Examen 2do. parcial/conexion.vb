Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public comand As SqlCommand
    Public dv As New DataView
    Public adap As SqlDataAdapter
    Public datos2 As DataSet

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Llenar(ByVal sql, ByVal tabla)
        Try
            ds.Tables.Clear()
            da = New SqlDataAdapter(sql, conexion)
            cmb = New SqlCommandBuilder(da)
            da.Fill(ds, tabla)
            dv.Table = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error de conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function insertar(ByVal sql, ByVal ID)
        Dim reader As SqlDataReader
        Dim contador As Int32 = 0
        conexion.Open()
        comand = New SqlCommand("select * from factura.cliente where idCliente ='" + ID + "'", conexion)
        reader = comand.ExecuteReader()
        While reader.Read
            contador = contador + 1
        End While
        reader.Close()
        If contador = 0 Then
            comando = New SqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
                conexion.Close()
            End If
        Else
            Return False

        End If
    End Function

    Function insertar2(ByVal sql, ByVal ID)
        Dim reader As SqlDataReader
        Dim contador As Int32 = 0
        conexion.Open()
        comand = New SqlCommand("select * from factura.producto where idProducto ='" + ID + "'", conexion)
        reader = comand.ExecuteReader()
        While reader.Read
            contador = contador + 1
        End While
        reader.Close()
        If contador = 0 Then
            comando = New SqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
                conexion.Close()
            End If
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Function insertar3(ByVal sql, ByVal ID)
        Dim reader As SqlDataReader
        Dim contador As Int32 = 0
        conexion.Open()
        comand = New SqlCommand("select * from factura.Venta where idProducto ='" + ID + "'", conexion)
        reader = comand.ExecuteReader()
        While reader.Read
            contador = contador + 1
        End While
        reader.Close()
        If contador = 0 Then
            comando = New SqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
                conexion.Close()
            End If
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = " Delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
            conexion.Close()
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If i > 0 Then
            Return True
            conexion.Close()
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Function busqueda(ByVal tabla, ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from " + tabla + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class