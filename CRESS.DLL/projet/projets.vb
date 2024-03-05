Public Class projets
    Inherits List(Of projet)

    Private _table As String = "PROJETS"

    Public Sub New()
        LoadData()
    End Sub

    Public Sub LoadData()
        Dim _resultatBdd As New DataTable
        _resultatBdd = classBdd.LoadDb("SELECT * FROM " & _table, _table, "")
        For Each dr As DataRow In _resultatBdd.Rows
            MyBase.Add(New Projet With
                         {.id = dr("id").ToString,
                         .idPole = dr("id_pole").ToString,
                         .nom = dr("nom").ToString})
        Next
    End Sub

    Public Overloads Function Add(ByVal _path As String, ByVal _nom As String, ByVal _pole As String, ByVal _idPole As Integer)
        Dim _item As New projet
        Dim _id As Integer = classBdd.SaveDb("INSERT INTO " & _table & " (id_pole, nom) VALUES ('" & _idPole & "', '" & _nom & "')", "")

        Try
            MkDir(_path + "\" + _pole + "\" + _nom)
        Catch ex As Exception

        End Try

        _item.id = _id
        _item.idPole = _idPole
        _item.nom = _nom
        MyBase.Add(_item)
        Return _item
    End Function

    Public Overloads Sub Remove(ByVal _path As String, ByVal _pole As String, ByVal _item As projet, ByRef _fonctions As fonctions, ByRef _fichiers As fichiers, ByRef _extensions As extensions)
        Try
            For Each _fonction As fonction In _fonctions.FindAll(Function(x) x.idProjet = _item.id)
                _fonctions.Remove(_path, _pole, _item.nom, _fonction, _fichiers, _extensions)
            Next
            classBdd.DeleteInDb("DELETE FROM " & _table & " WHERE id = " & _item.id, "")
            RmDir(_path + "\" + _pole + "\" + _item.nom)
            MyBase.Remove(_item)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Rename(ByVal _newName As String, ByVal _id As Integer)
        classBdd.SaveDb("UPDATE " & _table & " SET nom = " & _newName & " WHERE id = '" & _id & "'", "")
    End Sub
End Class