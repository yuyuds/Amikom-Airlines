Public Class ClsEntTiket
    Private _kd_tiket As String
    Private _nama_maskapai As String
    Private _id_jadwal As String
    Private _id_kelas As String
    Private _id_rute As String
    Private _arrived As Date

    Public Property Kd_tiket As String
        Get
            Return _kd_tiket
        End Get
        Set(value As String)
            _kd_tiket = value
        End Set
    End Property

    Public Property Nama_maskapai As String
        Get
            Return _nama_maskapai
        End Get
        Set(value As String)
            _nama_maskapai = value
        End Set
    End Property

    Public Property Id_jadwal As String
        Get
            Return _id_jadwal
        End Get
        Set(value As String)
            _id_jadwal = value
        End Set
    End Property

    Public Property Id_kelas As String
        Get
            Return _id_kelas
        End Get
        Set(value As String)
            _id_kelas = value
        End Set
    End Property

    Public Property Id_rute As String
        Get
            Return _id_rute
        End Get
        Set(value As String)
            _id_rute = value
        End Set
    End Property

    Public Property Arrived As Date
        Get
            Return _arrived
        End Get
        Set(value As Date)
            _arrived = value
        End Set
    End Property
End Class
