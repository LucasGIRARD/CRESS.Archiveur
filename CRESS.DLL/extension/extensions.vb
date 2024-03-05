Public Class extensions
    Inherits List(Of extension)

    Private _table As String = "EXTENSIONS"

    Public Sub New()
        LoadData()
    End Sub

    Public Sub LoadData()
        Dim _resultatBdd As New DataTable
        _resultatBdd = classBdd.LoadDb("SELECT * FROM " & _table, _table, "")
        For Each dr As DataRow In _resultatBdd.Rows
            MyBase.Add(New extension With
                         {.id = dr("id").ToString,
                         .nom = dr("nom").ToString,
                         .idType = dr("id_type").ToString})
        Next
    End Sub

    Public Overloads Sub Add(ByVal _idType As Integer, ByVal _nom As String)
        Dim _item As New extension
        Dim _id As Integer = classBdd.SaveDb("INSERT INTO " & _table & " (id_type, nom) VALUES ('" & _idType & "', '" & _nom & "')", "")

        _item.id = _id
        _item.nom = _nom
        _item.idType = _idType
        MyBase.Add(_item)
    End Sub

    Public Overloads Sub Remove(ByVal _item As extension)
        classBdd.DeleteInDb("DELETE FROM " & _table & " WHERE id = " & _item.id, "")
        MyBase.Remove(_item)
    End Sub
End Class