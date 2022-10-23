Public Class ClsEntRute
    Private _id_rute As String
    Private _tujuan As String

    Public Property Id_rute As String
        Get
            Return _id_rute
        End Get
        Set(value As String)
            _id_rute = value
        End Set
    End Property

    Public Property Tujuan As String
        Get
            Return _tujuan
        End Get
        Set(value As String)
            _tujuan = value
        End Set
    End Property
End Class
