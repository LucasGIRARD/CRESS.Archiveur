Public Class poles
    Inherits standards

    Public Sub New()
        table = "POLES"
        MyBase.LoadData()
    End Sub

    Public Overloads Function Add(ByVal _path As String, ByVal _nom As String)
        Try
            MkDir(_path + "\" + _nom)
        Catch ex As Exception

        End Try

        Return MyBase.Add(_nom)
    End Function

    Public Sub Rename(ByVal _newName As String, ByVal _id As Integer)
        classBdd.SaveDb("UPDATE " & table & " SET nom = " & _newName & " WHERE id = '" & _id & "'", "")
    End Sub

    Public Overloads Sub Remove(ByVal _path As String, ByVal _item As standard, ByRef _projets As projets, ByRef _fonctions As fonctions, ByRef _fichiers As fichiers, ByRef _extensions As extensions)
        Try
            For Each _projet As projet In _projets.FindAll(Function(x) x.idPole = _item.id)
                _projets.Remove(_path, _item.nom, _projet, _fonctions, _fichiers, _extensions)
            Next
            RmDir(_path + "\" + _item.nom)
            MyBase.Remove(_item)
        Catch ex As Exception

        End Try
    End Sub
End Class