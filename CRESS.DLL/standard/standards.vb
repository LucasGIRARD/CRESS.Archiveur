Public MustInherit Class standards
    Inherits List(Of standard)

    Private _table As String

    Public Property table As String
        Get
            Return _table
        End Get
        Set(value As String)
            _table = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub LoadData()
        Dim _resultatBdd As New DataTable
        _resultatBdd = classBdd.LoadDb("SELECT * FROM " & table, table, "")
        For Each dr As DataRow In _resultatBdd.Rows
            MyBase.Add(New standard With
                         {.id = dr("id").ToString,
                         .nom = dr("nom").ToString})
        Next
    End Sub

    Public Overridable Overloads Function Add(ByVal _nom As String)
        Dim _item As New standard
        Dim _id As Integer = classBdd.SaveDb("INSERT INTO " + table + " (nom) VALUES ('" & _nom & "')", "")

        _item.id = _id
        _item.nom = _nom
        MyBase.Add(_item)
        Return _item
    End Function

    Public Overloads Sub Remove(ByVal _item As standard)
        classBdd.DeleteInDb("DELETE FROM " & table & " WHERE id = " & _item.id, "")
        MyBase.Remove(_item)
    End Sub
End Class