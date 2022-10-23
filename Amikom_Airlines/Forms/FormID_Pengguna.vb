Public Class FormID_Pengguna

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        'btnSave.Enabled = Not st

    End Sub

    Private Sub FormID_Pengguna_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtNama.Text = ""
        txtEmail.Text = ""
        txtNoHp.Text = ""
        txtNIK.Text = ""

        txtNama.Focus()
        MdiParent = FormUtama
        'AturButton(True)

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click



        With EntitasIDPengguna
            .Nama_pembeli = txtNama.Text
            .NIK = txtNIK.Text
            .Email = txtEmail.Text
            .No_hp = txtNoHp.Text
        End With


        KontrolIDPengguna.SIMPAN_DATA(EntitasIDPengguna)


    End Sub
End Class