Public Class Rpt_Dez_Zona

    Private Sub Rpt_Dez_Zona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Diezmos_Zona' Puede moverla o quitarla según sea necesario.
        Me.MdiParent = Inicio
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Reportes_Diezmos_ZonaTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Diezmos_Zona, cbxzona.Text, desde.Text, hasta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class