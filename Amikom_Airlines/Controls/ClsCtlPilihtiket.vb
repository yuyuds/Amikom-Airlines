Imports System.Data.Odbc
Imports Amikom_Airlines

Public Class ClsCtlPilihtiket : Implements infProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements infProses.InsertData
        Dim data As New ClsEntPemesananTiket
        data = Ob
        CMD = New OdbcCommand("insert into pemesanan_tiket(`kd_pemesanan`) values('" & data.Kd_pemesanan & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONESI)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OdbcCommand Implements infProses.UpdateData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(kunci As String) As OdbcCommand Implements infProses.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements infProses.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT * from cek_kursi;", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_CekKursi")
            Dim grid As New DataView(DTS.Tables("Tabel_CekKursi"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements infProses.cariData
        Throw New NotImplementedException()
    End Function

    Function ID_Penumpang() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_penumpang,2))from info_penumpang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "SEAT" & Strings.Right("0" & kodeakhir + 1, 2)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function ID_Pemesanan() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(kd_pemesanan,3))from pemesanan_tiket", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PAY" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


End Class
