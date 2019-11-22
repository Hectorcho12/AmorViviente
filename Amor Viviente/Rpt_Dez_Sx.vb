Public Class Rpt_Dez_Sx

    Private Sub Rpt_Dez_Sx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_DiezmosSX' Puede moverla o quitarla según sea necesario.
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Reportes_DiezmosSXTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_DiezmosSX, cbxzona.Text, cbxsector.Text, desde.Text, hasta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class