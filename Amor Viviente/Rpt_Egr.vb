Imports Microsoft.Reporting.WinForms
Public Class Rpt_Egr

    Private Sub Rpt_Egr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rp As New ReportParameterCollection()
        rp.Add(New ReportParameter("desde", dtpdesde.Text))
        ReportViewer1.LocalReport.SetParameters(rp)

        Dim rp2 As New ReportParameterCollection()
        rp2.Add(New ReportParameter("hasta", dtphasta.Text))
        ReportViewer1.LocalReport.SetParameters(rp2)


        Me.Reportes_Egresos_entradasTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Egresos_entradas, dtpdesde.Text, dtphasta.Text)
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Egresos_salidas' Puede moverla o quitarla según sea necesario.
        Me.Reportes_Egresos_salidasTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Egresos_salidas, dtpdesde.Text, dtphasta.Text)
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Egresos_capital' Puede moverla o quitarla según sea necesario.
        Me.Reportes_Egresos_capitalTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Egresos_capital, dtpdesde.Text, dtphasta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class