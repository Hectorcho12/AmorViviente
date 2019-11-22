Public Class Eliminar__Usuario

    Dim codigo As Integer
    Dim nombre As String
    Dim sector As Integer
    Dim cant As Integer

    Public conexion As New Conexiones

    Private Sub Eliminar__Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio

        Dim query = "exec Grp_mostrar"
        conexion.llenardgv(dgveliminar, query)


        dgveliminar.Columns(1).Width = 250
        dgveliminar.Columns(3).Width = 150

        dgveliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnborrar.Click

        conexion.insertar("Exec Grp_Modificacion @codigo = " & codigo & ", @grupo = '" & nombre & "', @sector = " & sector & ",@Miembros =" & cant & ",@estado =" & 0)
        MsgBox("Grupo eliminado con exito!", MsgBoxStyle.Information)

        Dim query = "exec Grp_mostrar"
        conexion.llenardgv(dgveliminar, query)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgveliminar.CellContentClick
        btnborrar.Enabled = True
        codigo = dgveliminar.CurrentRow.Cells.Item(0).Value.ToString
        nombre = dgveliminar.CurrentRow.Cells.Item(1).Value.ToString
        sector = dgveliminar.CurrentRow.Cells.Item(2).Value.ToString
        cant = dgveliminar.CurrentRow.Cells.Item(3).Value.ToString
    End Sub

   
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Clear()
        If ComboBox1.Text = "Nombre" Then
            TextBox1.MaxLength = 30

        ElseIf ComboBox1.Text = "Sector" Then
            TextBox1.MaxLength = 2
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If ComboBox1.Text = "Nombre" Then
            ClsLetrasyNumeros(e)

        ElseIf ComboBox1.Text = "Sector" Then
            ClsNumeros(e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Nombre" Then

            conexion.llenardgv(dgveliminar, "Exec [Grp_Buscador-Nombre] @nombre = '" & TextBox1.Text & "'")
        End If
        If ComboBox1.Text = "Sector" Then

            conexion.llenardgv(dgveliminar, "Exec [Grp_Buscador-Sector] @Sector = '" & TextBox1.Text + "'")
        End If
    End Sub
End Class