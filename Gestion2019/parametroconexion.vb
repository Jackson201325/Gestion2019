Imports MySql.Data.MySqlClient
Module parametroconexion
    Public OperacionABM As String
    Public CodigoABM As String
    Public conexion As MySqlConnection
    Public Sub abrirconexion()
        Dim servidor As String = "localhost"
        Dim usuario As String = "root"
        Dim password As String = ""
        Dim baseDatos As String = "stock2018"
        Dim url As String
        url = "server=" & servidor & "; user= " & usuario & "; password=" & password &
            "; database=" & baseDatos & ";"
        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = url
            conexion.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
