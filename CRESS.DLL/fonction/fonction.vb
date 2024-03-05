Public Class fonction
    Inherits standard

    Private _idProjet As Integer

    Public Property idProjet As Integer
        Get
            Return _idProjet
        End Get
        Set(ByVal value As Integer)
            _idProjet = value
        End Set
    End Property
End Class