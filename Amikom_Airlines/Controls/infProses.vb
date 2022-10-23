Imports System.Data.Odbc

Public Interface infProses

    Function InsertData(Ob As Object) As OdbcCommand
    Function UpdateData(Ob As Object) As OdbcCommand
    Function DeleteData(kunci As String) As OdbcCommand
    Function tampilData() As DataView
    Function cariData(kunci As String) As DataView
End Interface
