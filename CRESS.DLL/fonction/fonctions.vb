Public Class fonctions
    Inherits List(Of fonction)

    Private _table As String = "FONCTIONS"

    Public Sub New()
        LoadData()
    End Sub

    Public Sub LoadData()
        Dim _resultatBdd As New DataTable
        _resultatBdd = classBdd.LoadDb("SELECT * FROM " & _table, _table, "")
        For Each dr As DataRow In _resultatBdd.Rows
            MyBase.Add(New fonction With
                         {.id = dr("id").ToString,
                         .idProjet = dr("id_projet").ToString,
                         .nom = dr("nom").ToString})
        Next
    End Sub

    Public Overloads Function Add(ByVal _path As String, ByVal _nom As String, ByVal _pole As String, ByVal _projet As String, ByVal _idProjet As Integer)
        Dim _item As New fonction
        Dim _id As Integer = classBdd.SaveDb("INSERT INTO " & _table & " (id_projet, nom) VALUES ('" & _idProjet & "', '" & _nom & "')", "")

        Try
            MkDir(_path + "\" + _pole + "\" + _projet + "\" + _nom)
        Catch ex As Exception

        End Try

        _item.id = _id
        _item.idProjet = _idProjet
        _item.nom = _nom
        MyBase.Add(_item)
        Return _item
    End Function

    Public Overloads Sub Remove(ByVal _path As String, ByVal _pole As String, ByVal _projet As String, ByVal _item As fonction, ByRef _fichiers As fichiers, ByRef _extensions As extensions)
        Try
            For Each _fichier As fichier In _fichiers.FindAll(Function(x) x.idFonction = _item.id)
                _fichiers.Remove(_path, _pole, _projet, _item.nom, _fichier, _extensions)
            Next
            classBdd.DeleteInDb("DELETE FROM " & _table & " WHERE id = " & _item.id, "")
            MyBase.Remove(_item)
            RmDir(_path + "\" + _pole + "\" + _projet + "\" + _item.nom)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Rename(ByVal _newName As String, ByVal _id As Integer)
        classBdd.SaveDb("UPDATE " & _table & " SET nom = " & _newName & " WHERE id = '" & _id & "'", "")
    End Sub
End Class