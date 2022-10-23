Imports System.Data.Odbc
Imports Amikom_Airlines

Public Class ClsCtlIDPengguna : Implements infProses
    Dim SQL As String

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
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements infProses.cariData
        Throw New NotImplementedException()
    End Function


    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPembeli) As String

        Dim IDP As String
        IDP = ""
        TUTUPKONESI()
        With _pbl
            SQL = "CALL INSERTPEMBELI('" & .Nama_pembeli & "','" & .NIK & "','" & .Email & "','" & .No_hp & "')"
            MsgBox(SQL)
            Try
                DTA = New OdbcDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_JUAL")
                IDP = DTS.Tables("TABEL_ID_JUAL").Rows(0)(0).ToString

            Catch ex As Exception
                If _pbl Is Nothing Then
                    _pbl = New ClsEntPembeli
                End If
            End Try
        End With
        TUTUPKONESI()

        Return IDP
    End Function


End Class
