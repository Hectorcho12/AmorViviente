﻿Public Class ModalOfrendas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rpt_Ofr_Sx.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Rpt_Ofr.Show()
        Me.Close()
    End Sub
End Class