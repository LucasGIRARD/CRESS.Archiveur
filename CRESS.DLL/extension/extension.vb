Public Class extension
    Inherits standard

    Private _idType As Integer

    Public Property idType As Integer
        Get
            Return _idType
        End Get
        Set(ByVal value As Integer)
            _idType = value
        End Set
    End Property
End Class
