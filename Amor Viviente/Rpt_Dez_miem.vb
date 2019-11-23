Public Class Rpt_Dez_miem
    Public conexion As New Conexiones
    Dim miembro As Integer
    Private Sub Rpt_Dez_miem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Diezmos_M' Puede moverla o quitarla según sea necesario.
        Me.MdiParent = Inicio

        conexion.llenardgv(dgvmiembros, "Exec Mbr_Mostrar")

        dgvmiembros.Columns(0).Visible = False
        dgvmiembros.Columns(2).Visible = False

        dgvmiembros.Columns(1).Width = 170

        dgvmiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub cbxbuscador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbuscador.SelectedIndexChanged
        txtbuscador.Clear()

        If cbxbuscador.Text = "Nombre" Then
            txtbuscador.MaxLength = 84

        ElseIf cbxbuscador.Text = "Sector" Then
            txtbuscador.MaxLength = 2

        ElseIf cbxbuscador.Text = "Grupo" Then
            txtbuscador.MaxLength = 30
        End If
    End Sub

    Private Sub txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles txtbuscador.TextChanged
        If cbxbuscador.Text = "Nombre" Then
            conexion.llenardgv(dgvmiembros, "exec Mbr_buscador @Nombre = '" & txtbuscador.Text & "'")

        ElseIf cbxbuscador.Text = "Sector" Then
            conexion.llenardgv(dgvmiembros, "exec [Mbr_buscador-sector] @sector = '" & txtbuscador.Text & "'")

        ElseIf cbxbuscador.Text = "Grupo" Then
            conexion.llenardgv(dgvmiembros, "exec [Mbr_buscador-grupo] @grupo = '" & txtbuscador.Text & "'")
        End If
    End Sub

    Private Sub dgvmiembros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmiembros.CellContentClick
        Button1.Enabled = True

        miembro = dgvmiembros.CurrentRow.Cells.Item(0).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Reportes_Diezmos_MTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Diezmos_M, miembro, desde.Text, hasta.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class