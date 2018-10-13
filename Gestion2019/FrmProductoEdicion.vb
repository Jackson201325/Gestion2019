Imports MySql.Data.MySqlClient
Public Class FrmProductoEdicion
    Dim adaptador As MySqlDataAdapter 'consultas select en la bd
    Dim comando As MySqlCommand 'ejecutar inser, delete update en la bd
    Dim datos As DataSet 'almacena resultado en la conslta sql
    Private Sub FrmProductoEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OperacionABM = "nuevo" Then
            lblTitulo.Text = "Registro de productos - Nuevo"
        ElseIf OperacionABM = "modificar" Then
            lblTitulo.Text = "Registro de productos - Editar " & CodigoABM
            Call buscarRegistro(CodigoABM)
        End If
    End Sub
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String

        Try
            sql = "select * from producto where id=" & codigo
            abrirconexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "producto")
            txtCodigo.Text = datos.Tables("producto").Rows(0).Item("id")
            txtBarra.Text = datos.Tables("producto").Rows(0).Item("barra")
            txtDescripcion.Text = datos.Tables("producto").Rows(0).Item("descripcion")
            txtCategoria.Text = datos.Tables("producto").Rows(0).Item("idcategoria")
            txtMarca.Text = datos.Tables("producto").Rows(0).Item("idmarca")
            txtProveedor.Text = datos.Tables("producto").Rows(0).Item("idproveedor")
            txtCosto.Text = datos.Tables("producto").Rows(0).Item("costo")
            txtPrecio.Text = datos.Tables("producto").Rows(0).Item("precio")
            txtStock.Text = datos.Tables("producto").Rows(0).Item("stock")
            Call buscarCategoria(txtCategoria.Text)
            Call buscarMarca(txtMarca.Text)
            Call buscarProveedor(txtProveedor.Text)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Sub
    Private Sub buscarCategoria(codigo As Integer)
        Dim sql As String

        Try
            sql = "select * from categoria where id= " & codigo
            abrirconexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "categoria")
            txtNombreCategoria.Text = datos.Tables("categoria").Rows(0).Item("descripcion")


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub
    Private Sub buscarMarca(codigo As Integer)
        Dim sql As String

        Try
            sql = "select * from marca where id= " & codigo
            abrirconexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "marca")
            txtNombreMarca.Text = datos.Tables("marca").Rows(0).Item("descripcion")


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub
    Private Sub buscarProveedor(codigo As Integer)
        Dim sql As String

        Try
            sql = "select * from proveedor where id= " & codigo
            abrirconexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet

            adaptador.Fill(datos, "proveedor")
            txtNombreProveedor.Text = datos.Tables("proveedor").Rows(0).Item("nombre")


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub
End Class