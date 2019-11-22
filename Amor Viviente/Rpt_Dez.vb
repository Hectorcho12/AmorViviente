Imports Microsoft.Reporting.WinForms
Public Class Rpt_Dez

    Private Sub Rpt_Ofr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Me.MdiParent = Inicio
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'Amor_VivienteDataSet1.Reportes_Diezmos' Puede moverla o quitarla según sea necesario.

        'Dim rp As New ReportParameterCollection()
        'rp.Add(New ReportParameter("Zona", cbxzona.Text))
        'ReportViewer1.LocalReport.SetParameters(rp)

        Dim zona = cbxzona.Text
        Dim sector = cbxsector.Text


        Me.Reportes_DiezmosTableAdapter.Fill(Me.Amor_VivienteDataSet1.Reportes_Diezmos, zona, sector, desde.Text, hasta.Text)


        Me.ReportViewer1.RefreshReport()
    End Sub

    
    
End Class