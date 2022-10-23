Imports System.Data.Odbc
Imports Amikom_Airlines

Public Class ClsCtlCekKursi : Implements infProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements infProses.InsertData
        Throw New NotImplementedException()
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

    Function CekTiketTerjual() As DataView

        Dim kodeakhir As DataView
        Try
            DTA = New OdbcDataAdapter("SELECT * from cek_kursi_terjual;", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek_kursi_terjual")
            kodeakhir = New DataView(DTS.Tables("cek_kursi_terjual"))
            Return kodeakhir
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
