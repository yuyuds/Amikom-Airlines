Public Class FormCekKursidanPesawat

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGCekKursi.Rows(br)
                cbCekMaskapai.Text = .Cells(0).Value.ToString
                cbCekTujuan.Text = .Cells(1).Value.ToString
                cbCekJam.Text = .Cells(2).Value.ToString
                cbCekKelas.Text = .Cells(3).Value.ToString
                cbSeat.Text = .Cells(4).Value.ToString

            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolCekKursi.tampilData.ToTable
        DGCekKursi.DataSource = DTGrid

        'nama_maskapai
        cbCekMaskapai.DataSource = DTGrid
        cbCekMaskapai.ValueMember = "nama_maskapai"
        cbCekMaskapai.DisplayMember = "nama_maskapai"



        'tujuan
        cbCekTujuan.DataSource = DTGrid
        cbCekTujuan.ValueMember = "tujuan"
        cbCekTujuan.DisplayMember = "tujuan"

        'jam berangkat
        cbCekJam.DataSource = DTGrid
        cbCekJam.ValueMember = "departure"
        cbCekJam.DisplayMember = "departure"

        'kelas
        cbCekKelas.DataSource = DTGrid
        cbCekKelas.ValueMember = "nama_kelas"
        cbCekKelas.DisplayMember = "nama_kelas"

        'seat
        cbSeat.DataSource = DTGrid
        cbSeat.ValueMember = "seat"
        cbSeat.DisplayMember = "seat"

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGCekKursi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGCekKursi.CurrentCell = DGCekKursi.Item(1, baris)
            'AturButton(False)
            IsiBox(baris)
        End If
    End Sub



    Private Sub RefreshGrid_v2()
        DTGrid = KontrolCekKursi.CekTiketTerjual.ToTable
        DGCekKursi.DataSource = DTGrid

        'nama_maskapai
        cbCekMaskapai.DataSource = DTGrid
        cbCekMaskapai.ValueMember = "nama_maskapai"
        cbCekMaskapai.DisplayMember = "nama_maskapai"

        'tujuan
        cbCekTujuan.DataSource = DTGrid
        cbCekTujuan.ValueMember = "tujuan"
        cbCekTujuan.DisplayMember = "tujuan"

        'jam berangkat
        cbCekJam.DataSource = DTGrid
        cbCekJam.ValueMember = "departure"
        cbCekJam.DisplayMember = "departure"

        'kelas
        cbCekKelas.DataSource = DTGrid
        cbCekKelas.ValueMember = "nama_kelas"
        cbCekKelas.DisplayMember = "nama_kelas"

        'seat
        cbSeat.DataSource = DTGrid
        cbSeat.ValueMember = "seat"
        cbSeat.DisplayMember = "seat"

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGCekKursi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGCekKursi.CurrentCell = DGCekKursi.Item(1, baris)
            ' AturButton(False)
            IsiBox(baris)
        End If
    End Sub
    Private Sub FormCekKursidanPesawat_Load(sender As Object, e As EventArgs) Handles Me.Load

        MdiParent = FormUtama

        'isi combo tipe
        cbTipe.Items.Add("Tiket Tersedia")
        cbTipe.Items.Add("Tiket Terjual")


    End Sub

    Private Sub cbTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipe.SelectedIndexChanged
        Dim arrTipe = Split(cbTipe.SelectedItem)
        If cbTipe.Text = "Tiket Tersedia" Then
            RefreshGrid()
        Else
            RefreshGrid_v2()
        End If

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class
