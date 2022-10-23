Public Class ClsEntPemesananTiket
    Private _kd_pemesanan As String
    Private _tgl_pembayaran As Date
    Private _id_pembeli As String
    Private _status As String

    Public Property Kd_pemesanan As String
        Get
            Return _kd_pemesanan
        End Get
        Set(value As String)
            _kd_pemesanan = value
        End Set
    End Property

    Public Property Tgl_pembayaran As Date
        Get
            Return _tgl_pembayaran
        End Get
        Set(value As Date)
            _tgl_pembayaran = value
        End Set
    End Property

    Public Property Id_pembeli As String
        Get
            Return _id_pembeli
        End Get
        Set(value As String)
            _id_pembeli = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property
End Class
