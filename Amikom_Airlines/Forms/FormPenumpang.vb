Public Class FormPenumpang
    Private Sub FormPenumpang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Focus()
        txtIDPenumpang.Text = KontrolPenumpang.kodebaru()
        txtIDPenumpang.Enabled = False

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasPenumpang
            .Id_penumpang = txtIDPenumpang.Text
            .Nama_penumpang = txtNama.Text
        End With

        KontrolPenumpang.SIMPAN_DATAPenumpang(EntitasPenumpang)

        MdiParent = FormUtama
    End Sub
End Class