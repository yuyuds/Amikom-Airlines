Module ModObjekdanFungsi
    'cekKursi
    Public EntitasCekKursi As New ClsEntTiket
    Public KontrolCekKursi As New ClsCtlCekKursi


    'pemilihan
    Public EntitasPemilihan As New ClsEntPemesananTiket
    Public KontrolPemilihan As New ClsCtlPilihtiket

    'identitas pengguna
    Public EntitasIDPengguna As New ClsEntPembeli
    Public EntitasPesan As New ClsEntPemesananTiket
    Public KontrolIDPengguna As New ClsCtlIDPengguna

    'pemesanan tiket
    Public KontrolPemesanan As New ClsCtlPemesananTiket
    Public EntitasDetail As New ClsEntDetailPemesanan


    'penumpang
    Public EntitasPenumpang As New ClsEntInfoPenumpang
    Public KontrolPenumpang As New ClsCtlPenumpang

    'Cari tiket
    Public KontrolCariTiket As New ClsCtlCariTiket

    'jadwal
    Public EntitasJadwal As New ClsEntTiket
    Public KontrolJadwal As New ClsCtlJadwalBerangkat

End Module

