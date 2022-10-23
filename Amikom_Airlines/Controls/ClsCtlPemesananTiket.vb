Imports System.Data.Odbc
Imports Amikom_Airlines

Public Class ClsCtlPemesananTiket : Implements infProses
    Dim SQL As String

    Public Function InsertData(Ob As Object) As OdbcCommand Implements infProses.InsertData
        Dim data As New ClsEntDetailPemesanan
        data = Ob

        CMD = New OdbcCommand("insert into detail_pemesanan values('" & data.Id_detail & "','" & data.Kd_tiket & "','" & data.Kd_pemesanan & "',
                                '" & data.Id_penumpang & "','" & data.Seat & "'," & data.Harga_tiket & "," & data.Sub_total & ")", BUKAKONEKSI)
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
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements infProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPemesananTiket) As String
        Dim KP As String
        KP = ""
        TUTUPKONESI()
        With _pbl
            SQL = "CALL INSERTPEMESANAN('" & .Tgl_pembayaran & "','" & .Id_pembeli & "','" & .Status & "')"
            MsgBox(SQL)
            Try
                DTA = New OdbcDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_KDPesan")
                KP = DTS.Tables("TABEL_KDPesan").Rows(0)(0).ToString

            Catch ex As Exception
                If _pbl Is Nothing Then
                    _pbl = New ClsEntPemesananTiket
                End If
            End Try
        End With
        TUTUPKONESI()

        Return KP
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_detail,3))from detail_pemesanan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "DTL" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function




End Class
