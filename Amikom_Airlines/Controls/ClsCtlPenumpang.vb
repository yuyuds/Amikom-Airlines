Imports System.Data.Odbc

Public Class ClsCtlPenumpang
    Dim SQL As String

    Public Function SIMPAN_DATAPenumpang(ByVal _pbl As ClsEntInfoPenumpang) As String
        Dim KP As String
        KP = ""
        TUTUPKONESI()
        With _pbl
            SQL = "CALL INSERTPENUMPANG('" & kodebaru() & "','" & .Nama_penumpang & "')"
            MsgBox(Sql)
            Try
                DTA = New OdbcDataAdapter(Sql, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_KDPenumpang")
                KP = DTS.Tables("TABEL_KDPenumpang").Rows(0)(0).ToString

            Catch ex As Exception
                If _pbl Is Nothing Then
                    _pbl = New ClsEntInfoPenumpang
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
End Class
