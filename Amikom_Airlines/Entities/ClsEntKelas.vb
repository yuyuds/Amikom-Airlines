Public Class ClsEntKelas
    Private _id_kelas As String
    Private _nama_kelas As String

    Public Property Id_kelas As String
        Get
            Return _id_kelas
        End Get
        Set(value As String)
            _id_kelas = value
        End Set
    End Property

    Public Property Nama_kelas As String
        Get
            Return _nama_kelas
        End Get
        Set(value As String)
            _nama_kelas = value
        End Set
    End Property
End Class
