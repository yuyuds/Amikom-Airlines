Imports System.Data.Odbc
Imports Amikom_Airlines

Public Class ClsCtlJadwalBerangkat : Implements infProses

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
            DTA = New OdbcDataAdapter("SELECT * from jadwal_berangkat;", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_JadwalBerangkat")
            Dim grid As New DataView(DTS.Tables("Tabel_JadwalBerangkat"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements infProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
