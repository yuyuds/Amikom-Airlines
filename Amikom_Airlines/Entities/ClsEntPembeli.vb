Public Class ClsEntPembeli
    Private _id_pembeli As String
    Private _nama_pembeli As String
    Private _NIK As String
    Private _email As String
    Private _no_hp As String

    Public Property Id_pembeli As String
        Get
            Return _id_pembeli
        End Get
        Set(value As String)
            _id_pembeli = value
        End Set
    End Property

    Public Property Nama_pembeli As String
        Get
            Return _nama_pembeli
        End Get
        Set(value As String)
            _nama_pembeli = value
        End Set
    End Property

    Public Property NIK As String
        Get
            Return _NIK
        End Get
        Set(value As String)
            _NIK = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property No_hp As String
        Get
            Return _no_hp
        End Get
        Set(value As String)
            _no_hp = value
        End Set
    End Property
End Class
