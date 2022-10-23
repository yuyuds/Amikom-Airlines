Public Class ClsEntJadwal
    Private _id_jadwal As String
    Private _departure As Date

    Public Property Id_jadwal As String
        Get
            Return _id_jadwal
        End Get
        Set(value As String)
            _id_jadwal = value
        End Set
    End Property

    Public Property Departure As Date
        Get
            Return _departure
        End Get
        Set(value As Date)
            _departure = value
        End Set
    End Property
End Class
