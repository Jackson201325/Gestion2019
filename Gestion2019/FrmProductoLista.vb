Imports MySql.Data.MySqlClient
Public Class FrmProductoLista
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("", "")

    End Sub

    Private Sub ejecutarConsultar()

        Dim condicion As String = ""
        If optcodigo.Checked Then
            condicion = "where id= '" & txtbuscar.Text & "'"
        ElseIf optBarra.Checked Then
            condicion = "where bara like '%" & txtbuscar.Text & "'"
        ElseIf optMarca.Checked Then
            condicion = "where marca like '%" & txtbuscar.Text & "%'"
        ElseIf optProveedor.Checked Then
            condicion = "where proveedor like '%" & txtbuscar.Text & "%'"
        ElseIf optCategoria.Checked Then
            condicion = "where categoria like '%" & txtbuscar.Text & "%'"
        ElseIf optdescripcion.Checked Then
            condicion = "where descripcion like '%" & txtbuscar.Text & "%'"

        End If

        Dim ordenar As String = ""

        If optoCodigo.Checked Then
            ordenar = "order by id"
        ElseIf optoDescripcion.Checked Then
            ordenar = "order by descripcion"
        End If
        Call cargarRegistros(condicion, ordenar)



    End Sub
    Private Sub cargarRegistros(condicion As String, ordenar As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM consultaproducto " & condicion & ordenar
        Try
            Call abrirconexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grilla.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Call ejecutarConsultar()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        OperacionABM = "nuevo"
        FrmProductoEdicion.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        OperacionABM = "modificar"
        CodigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        FrmProductoEdicion.Show()
    End Sub
End Class
