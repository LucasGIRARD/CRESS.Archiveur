Public Class projet
    Inherits standard

    Private _idPole As Integer

    Public Property idPole As Integer
        Get
            Return _idPole
        End Get
        Set(ByVal value As Integer)
            _idPole = value
        End Set
    End Property
End Class
