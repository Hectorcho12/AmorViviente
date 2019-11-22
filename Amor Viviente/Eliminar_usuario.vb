Public Class Eliminar_usuario

    Public conexion As New Conexiones
    Dim nombre As String
    Dim contra As String

    Private Sub Eliminar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio



        conexion.llenardgv(dgveliminar, "Exec Usr_Mostrar")

        dgveliminar.Columns(0).Width = 200
        dgveliminar.Columns(1).Width = 200

        dgveliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub dgveliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgveliminar.CellContentClick
        btnborrar.Enabled = True

        nombre = dgveliminar.CurrentRow.Cells.Item(0).Value.ToString
        contra = dgveliminar.CurrentRow.Cells.Item(1).Value.ToString


    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click



        conexion.insertar("Exec Usr_Modificacion @ID = '" & nombre & "', @Pass = '" & contra & "',@cargo = " & cargo & ",@estado = " & 0)
        conexion.llenardgv(dgveliminar, "Exec Usr_Mostrar")
        MsgBox("Usuario Eliminado", MsgBoxStyle.Information)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ClsLetrasyNumeros(e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        conexion.llenardgv(dgveliminar, "Exec Usr_buscador @user = '" & TextBox1.Text & "'")
    End Sub
End Class