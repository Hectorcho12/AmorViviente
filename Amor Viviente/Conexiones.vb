Imports System.Data.SqlClient
Imports System.Data


Public Class Conexiones
    Public servidor As String = "Data Source=localhost;Initial Catalog=Amor_Viviente;Integrated Security=True"
    Public cnn As New SqlConnection(servidor)


    'Conectar a la base de datos
    Public Sub conectar()
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar a BD" & vbCrLf & ex.Message)
        End Try
    End Sub

    'Desconectar de la base de datos
    Public Sub desconectar()
        Try
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Buscar usuario en base de datos
    Public Sub logearse(usuario As String, pass As String, Query As String)

        cnn.Open()
        Dim comando = New SqlCommand(Query, cnn)
        comando.Parameters.AddWithValue("Usuario", usuario)
        comando.Parameters.AddWithValue("Contraseña", pass)

        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable()

        cargo = 0

        da.Fill(dt)


        If (dt.Rows.Count = 1) Then


            User = usuario
            contraseña = pass

            MsgBox("Bienvenido", MsgBoxStyle.DefaultButton1)
            insertar("Exec Bit_Registro @descripcion = 'ha ingresado un usuario', @Usuario = '" & User & "',@fecha = '" & DateString & "'")

            Dim columna As DataRow = dt.Rows(dt.Rows.Count - 1)
            Dim item As Object
            item = columna.Item("UsrCrg")

            cargo = item

            If item = 1 Then
                Inicio.Show()
                Login.Close()
            End If
            If item = 2 Then
                Inicio.Show()
                Login.Close()
            End If




        Else

            MsgBox("Usuario y/o contraseña incorrecta", MsgBoxStyle.Critical)


        End If
    End Sub
    'LLena cualquier datagridview
    Public Sub llenardgv(dgv As DataGridView, Query As String)

        conectar()
        Dim comando As New SqlCommand(Query, cnn)
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable

        da.Fill(dt)

        dgv.DataSource = dt

        desconectar()

    End Sub
    'llena cualquier combobox
    Public Sub llenarCbx(cbx As ComboBox, Query As String, dm As String, vm As String)

        conectar()
        Dim da As New SqlDataAdapter(Query, cnn)
        Dim ds As New DataSet
        da.Fill(ds)


        cbx.DataSource = ds.Tables(0)
        cbx.DisplayMember = dm
        cbx.ValueMember = vm

        desconectar()

    End Sub
    'Obtiene el codigo de cualquier grupo dando como parametro el nombre 
    Public Function ObtenerCod(campo As String, query As String) As Integer
        conectar()

        Dim da As New SqlDataAdapter(query, cnn)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim columna As DataRow = dt.Rows(dt.Rows.Count - 1)
        Dim item As Object
        item = columna.Item(campo)
        desconectar()
        Return item
    End Function

    'Ejecutar Querys
    Public Sub insertar(ByVal query As String)
        Dim comando As New SqlCommand(query, cnn)
        Try
            conectar()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            desconectar()

        End Try
    End Sub

    Public Function val(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand
        Try
            conectar()
            cmd = New SqlCommand(query, cnn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function Contar(ByVal query As String) As Integer
        Dim cmd As New SqlCommand

        conectar()
        cmd = New SqlCommand(query, cnn)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)

        Return dt.Rows.Count

    End Function
End Class
