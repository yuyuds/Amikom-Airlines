Public Class FormUtama

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub JadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadwalToolStripMenuItem.Click
        FormJadwal_Keberangkatan.Show()
    End Sub

    Private Sub CariTiketToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CariTiketToolStripMenuItem1.Click
        FormCariTiket.Show()
    End Sub

    Private Sub CekTersediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CekTersediaToolStripMenuItem.Click
        FormCekKursidanPesawat.Show()
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormID_Pengguna.Show()
    End Sub

    Private Sub InputPemesananTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputPemesananTiketToolStripMenuItem.Click
        FormPemesananTiket.Show()
    End Sub

    Private Sub InputPenumpangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputPenumpangToolStripMenuItem.Click
        FormPenumpang.Show()
    End Sub
End Class