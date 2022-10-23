Public Class FormJadwal_Keberangkatan


    Private Sub RefreshGrid()
        DTGrid = KontrolJadwal.tampilData.ToTable
        DGJadwalBerangkat.DataSource = DTGrid

    End Sub

    Private Sub FormJadwal_Keberangkatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshGrid()
        MdiParent = FormUtama
    End Sub

    Private Sub DGJadwalBerangkat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJadwalBerangkat.CellContentClick

    End Sub
End Class