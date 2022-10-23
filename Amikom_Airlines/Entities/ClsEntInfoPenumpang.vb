Public Class ClsEntInfoPenumpang
    Private _id_penumpang As String
    Private _nama_penumpang As String

    Public Property Id_penumpang As String
        Get
            Return _id_penumpang
        End Get
        Set(value As String)
            _id_penumpang = value
        End Set
    End Property

    Public Property Nama_penumpang As String
        Get
            Return _nama_penumpang
        End Get
        Set(value As String)
            _nama_penumpang = value
        End Set
    End Property
End Class
