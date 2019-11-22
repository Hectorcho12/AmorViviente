Public Class bitacora

    Public conexion As New Conexiones()
    Private Sub dtphasta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        conexion.llenardgv(DataGridView1, "exec Bit_Mostrar")


        DataGridView1.Columns(1).Width = 450
        DataGridView1.Columns(2).Width = 250
    End Sub


End Class