Public Class fichiers
    Inherits List(Of fichier)

    Private _table As String = "FICHIERS"

    Public Sub New()
        LoadData()
    End Sub

    Public Sub LoadData()
        Dim _resultatBdd As New DataTable
        Dim _item As New fichier

        _resultatBdd = classBdd.LoadDb("SELECT F.id, F.nom, F.id_extension, F.id_fonction, FU.id_utilisateur FROM " & _table & " As F LEFT JOIN(SELECT id_fichier, id_utilisateur FROM " & _table & "_UTILISATEURS) AS FU ON FU.id_fichier = F.id ORDER BY F.id", _table, "")
        For Each dr As DataRow In _resultatBdd.Rows

            If dr("id").ToString <> _item.id.ToString Then
                If _item.id <> 0 Then
                    MyBase.Add(_item)
                    _item = New fichier
                End If

                With _item
                    .id = dr("id").ToString
                    .nom = dr("nom").ToString
                    .idExtension = dr("id_extension")
                    .idFonction = dr("id_fonction")
                End With
                If Not IsDBNull(dr("id_utilisateur")) Then
                    _item.idsUtilisateur.Add(dr("id_utilisateur"))
                End If
                MyBase.Add(_item)
            End If
        Next
    End Sub

    Public Overloads Sub Add(ByVal _idFonction As Integer, ByVal _idExtension As Integer, ByVal _idsUtilisateur As List(Of Integer), ByVal _nom As String)
        Dim _item As New fichier
        Dim _id As Integer = classBdd.SaveDb("INSERT INTO " & _table & " (id_fonction, id_extension, nom) VALUES ('" & _idFonction & "', '" & _idExtension & "', '" & _nom & "')", "")

        _item.id = _id
        _item.nom = _nom
        _item.idFonction = _idFonction
        _item.idExtension = _idExtension
        _item.idsUtilisateur = _idsUtilisateur
        MyBase.Add(_item)

        For Each _idUtilisateur As Integer In _idsUtilisateur
            classBdd.SaveDb("INSERT INTO " & _table & "_UTILISATEURS (id_fichier, id_utilisateur) VALUES ('" & _id & "', '" & _idUtilisateur & "')", "")
        Next
    End Sub

    Public Sub Rename(ByVal _newName As String, ByVal _id As Integer)
        classBdd.SaveDb("UPDATE " & _table & " SET nom = " & _newName & " WHERE id = '" & _id & "'", "")
    End Sub

    Public Overloads Sub Remove(ByVal _path As String, ByVal _pole As String, ByVal _projet As String, ByVal _fonction As String, ByVal _item As fichier, ByRef _extensions As extensions)
        Try
            classBdd.DeleteInDb("DELETE FROM " & _table & "_UTILISATEURS WHERE id_fichier = " & _item.id, "")
            classBdd.DeleteInDb("DELETE FROM " & _table & " WHERE id = " & _item.id, "")
            MyBase.Remove(_item)
            IO.File.Delete(_path & "\" & _pole & "\" & _projet & "\" & _fonction & "\" & _item.nom & "." & _extensions.Find(Function(x) x.id = _item.idExtension).nom)
        Catch ex As Exception

        End Try
    End Sub
End Class