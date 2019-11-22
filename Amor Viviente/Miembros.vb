Imports System.Data.SqlClient
Public Class Miembros

    Public Codigo As Integer
    Public PrimerNombre As String
    Public SegundoNombre As String
    Public PrimerApellido As String
    Public SegundoApellido As String
    Public genero As Boolean
    Public Grupo As Integer
    Public fecha As Date

    '////////////////// Ingreso de nuevos miembros a la base de datos///////////////////////
    Public Sub Mbr_Ingreso()

        Dim conexion As New Conexiones

        conexion.conectar()
        Dim Query = "exec Mbr_Ingreso @Pnom, @Snom, @Pape, @Sape, @gen, @fecha, @gru"
        Dim comando As New SqlCommand(Query, conexion.cnn)

        comando.Parameters.AddWithValue("Pnom", Me.PrimerNombre)
        comando.Parameters.AddWithValue("Snom", Me.SegundoNombre)
        comando.Parameters.AddWithValue("Pape", Me.PrimerApellido)
        comando.Parameters.AddWithValue("Sape", Me.SegundoApellido)
        comando.Parameters.AddWithValue("gen", Me.genero)
        comando.Parameters.AddWithValue("fecha", Me.fecha)
        comando.Parameters.AddWithValue("gru", Me.Grupo)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable()

        da.Fill(dt)

        conexion.desconectar()

    End Sub

    Public Sub Mbr_Modificacion()

        Dim conexion As New Conexiones
        conexion.conectar()
        Dim Query = "exec Mbr_Modificacion @codigo,@Pnom, @Snom, @Pape, @Sape, @gen, @fecha, @gru"
        Dim comando As New SqlCommand(Query, conexion.cnn)

        comando.Parameters.AddWithValue("Codigo", Me.Codigo)
        comando.Parameters.AddWithValue("Pnom", Me.PrimerNombre)
        comando.Parameters.AddWithValue("Snom", Me.SegundoNombre)
        comando.Parameters.AddWithValue("Pape", Me.PrimerApellido)
        comando.Parameters.AddWithValue("Sape", Me.SegundoApellido)
        comando.Parameters.AddWithValue("gen", Me.genero)
        comando.Parameters.AddWithValue("fecha", Me.fecha)
        comando.Parameters.AddWithValue("gru", Me.Grupo)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable()

        da.Fill(dt)

        conexion.desconectar()

    End Sub

    
End Class
