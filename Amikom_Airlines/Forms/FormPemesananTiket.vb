Public Class FormPemesananTiket


    Private Sub FormPemesananTiket_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtIDPembeli.Focus()

        'isi combo tipe
        cbStatus.Items.Add("Active")
        cbStatus.Items.Add("Non-Active")

        txtIDDetail.Text = KontrolPemesanan.kodebaru()
        txtIDDetail.Enabled = False


        MdiParent = FormUtama

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasPesan
            .Kd_pemesanan = txtIDPemesanan.Text
            .Tgl_pembayaran = DateTimePicker1.Text
            .Id_pembeli = txtIDPembeli.Text
            .Status = cbStatus.Text
        End With

        With EntitasDetail
            .Kd_tiket = txtIDPemesanan.Text
            .Kd_pemesanan = DateTimePicker1.Text
            .Id_penumpang = txtIDPembeli.Text
            .Seat = txtSeat.Text
            .Harga_tiket = txtHargaTiket.Text
            .Sub_total = txtSubTotal.Text
        End With


        'table pemesanan_tiket
        KontrolPemesanan.SIMPAN_DATA(EntitasPesan)
        KontrolPemesanan.InsertData(EntitasDetail)

    End Sub
End Class