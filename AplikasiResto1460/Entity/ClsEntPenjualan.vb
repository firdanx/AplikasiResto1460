Public Class ClsEntPenjualan
    Private _idJual As String
    Private _total As Integer
    Private _tgljual As Date
    Private _idKasir As String

    Public Property IdJual As String
        Get
            Return _idJual
        End Get
        Set(value As String)
            _idJual = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    Public Property Tgljual As Date
        Get
            Return _tgljual
        End Get
        Set(value As Date)
            _tgljual = value
        End Set
    End Property

    Public Property IdKasir As String
        Get
            Return _idKasir
        End Get
        Set(value As String)
            _idKasir = value
        End Set
    End Property
End Class
