Public Class ClsEntDetailPemesanan
    Private _id_detail As String
    Private _kd_tiket As String
    Private _kd_pemesanan As String
    Private _id_penumpang As String
    Private _seat As String
    Private _harga_tiket As Integer
    Private _sub_total As Integer

    Public Property Id_detail As String
        Get
            Return _id_detail
        End Get
        Set(value As String)
            _id_detail = value
        End Set
    End Property

    Public Property Kd_tiket As String
        Get
            Return _kd_tiket
        End Get
        Set(value As String)
            _kd_tiket = value
        End Set
    End Property

    Public Property Kd_pemesanan As String
        Get
            Return _kd_pemesanan
        End Get
        Set(value As String)
            _kd_pemesanan = value
        End Set
    End Property

    Public Property Id_penumpang As String
        Get
            Return _id_penumpang
        End Get
        Set(value As String)
            _id_penumpang = value
        End Set
    End Property

    Public Property Seat As String
        Get
            Return _seat
        End Get
        Set(value As String)
            _seat = value
        End Set
    End Property

    Public Property Harga_tiket As Integer
        Get
            Return _harga_tiket
        End Get
        Set(value As Integer)
            _harga_tiket = value
        End Set
    End Property

    Public Property Sub_total As Integer
        Get
            Return _sub_total
        End Get
        Set(value As Integer)
            _sub_total = value
        End Set
    End Property
End Class
