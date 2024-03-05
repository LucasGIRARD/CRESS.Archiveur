Public Class fichier
    Inherits standard

    Private _idExtension As Integer
    Private _idFonction As Integer
    Private _idsUtilisateur As New List(Of Integer)

    Public Property idExtension As Integer
        Get
            Return _idExtension
        End Get
        Set(ByVal value As Integer)
            _idExtension = value
        End Set
    End Property

    Public Property idFonction As Integer
        Get
            Return _idFonction
        End Get
        Set(ByVal value As Integer)
            _idFonction = value
        End Set
    End Property

    Public Property idsUtilisateur As List(Of Integer)
        Get
            Return _idsUtilisateur
        End Get
        Set(ByVal value As List(Of Integer))
            _idsUtilisateur = value
        End Set
    End Property
End Class