Public NotInheritable Class utilities
    Private Sub New()

    End Sub

    Shared Function FichierUtilisateur(ByRef fichiers As fichiers, ByVal _fileName As String, ByVal _idFonction As Integer, ByVal checkedUtilisateurs As Windows.Forms.CheckedListBox.CheckedItemCollection)
        Dim _return As Boolean = False
        If checkedUtilisateurs.Count > 0 And fichiers.Count > 0 And _idFonction <> 0 Then
            For Each _utilisateur As standard In checkedUtilisateurs
                If Not fichiers.Find(Function(x) x.nom = GetName(_fileName) And x.idFonction = _idFonction).idsUtilisateur.Contains(_utilisateur.id) = Nothing Then
                    _return = True
                    Exit For
                End If
            Next
        ElseIf Not fichiers.Find(Function(x) x.nom = _fileName And x.idFonction = _idFonction) Is Nothing Then
            _return = True
        End If

        Return _return
    End Function

    Shared Function getViewableFileList(ByVal _fileList As System.Collections.ArrayList, ByVal _pathServer As String, ByVal _users As Windows.Forms.CheckedListBox.CheckedItemCollection, ByRef poles As poles, ByRef projets As projets, ByRef fonctions As fonctions, ByRef fichiers As fichiers, ByRef extensions As extensions, ByVal _dateDernierModifDebut As Date, ByVal _dateDernierModifFin As Date, ByVal _checkBoxDateModify As Boolean, ByVal _dateCreaDebut As Date, ByVal _dateCreaFin As Date, ByVal _checkBoxDateCreate As Boolean, ByVal _checkBoxSystemHiddenFile As Boolean, ByVal _selectedPole As Integer, ByVal _selectedProjet As Integer, ByVal _selectedFonction As Integer, ByVal _radioButtonUsersNo As Boolean, ByVal _radioButtonUsersBy As Boolean, ByVal _radioButtonUsersByReverse As Boolean, ByVal _checkBoxSystemFileType As Boolean, ByVal _selectedType As Integer) As System.Collections.ArrayList
        Dim _finalFileList As New System.Collections.ArrayList
        Dim _idPole, _idProjet, _idFonction As Integer
        Dim _pathSplitted() As String
        Dim fileName As String
        Dim _isFichierUtilisateur As Boolean = False

        For Each _item As ExpTreeLib.CShItem In _fileList
            _idPole = _idProjet = _idFonction = Nothing

            If Not _item.Path.Contains(_pathServer) Then
                Continue For
            End If

            _pathSplitted = _item.Path.Remove(0, _pathServer.Length + 1).Split("\")

            If _pathSplitted.Length < 4 Then
                Continue For
            End If

            getIdsPath(_pathSplitted, _idPole, _idProjet, _idFonction, poles, projets, fonctions)

            If _idPole = Nothing Or _idProjet = Nothing Or _idFonction = Nothing Then
                Continue For
            End If

            fileName = _pathSplitted(3)

            _isFichierUtilisateur = FichierUtilisateur(fichiers, fileName, _idFonction, _users)
            Dim _extensionOK As Boolean = False
            Dim _extension As extension = extensions.Find(Function(x) x.nom = GetExtension(_item.Path))
            If _extension IsNot Nothing Then
                _extensionOK = _extension.idType = _selectedType
            End If

            If ((Date.Compare(_item.LastWriteTime, _dateDernierModifDebut) = 1 And Date.Compare(_item.LastWriteTime, _dateDernierModifFin) = -1 _
                 And _checkBoxDateModify = True) Or _checkBoxDateModify = False) _
                    And ((Date.Compare(_item.LastWriteTime, _dateCreaDebut) = 1 And Date.Compare(_item.LastWriteTime, _dateCreaFin) = -1 _
                    And _checkBoxDateCreate = True) Or _checkBoxDateCreate = False) _
                    And ((_checkBoxSystemHiddenFile = False And _item.IsHidden = False) Or _checkBoxSystemHiddenFile = True) _
                    And (_selectedPole = 0 Or _idPole = _selectedPole) _
                    And (_selectedProjet = 0 Or _idProjet = _selectedProjet) _
                    And (_selectedFonction = 0 Or _idFonction = _selectedFonction) _
                    And (_radioButtonUsersNo = True Or ((_radioButtonUsersBy = True And _isFichierUtilisateur = True) _
                    Or (_radioButtonUsersByReverse = True And _isFichierUtilisateur = False))) _
                    And (_checkBoxSystemFileType = False Or (_selectedType = 0 _
                    Or _extensionOK)) Then
                _finalFileList.Add(_item)
            End If
        Next

        Return _finalFileList
    End Function

    Shared Sub getIdsPath(ByVal _pathSplitted() As String, ByRef _idPole As Integer, ByRef _idProjet As Integer, ByRef _idFonction As Integer, ByRef poles As poles, ByRef projets As projets, ByRef fonctions As fonctions)
        Dim _findedPole As standard
        Dim _findedProjet As projet
        Dim _findedFonction As fonction
        Dim _idPole2 As Integer
        Dim _idProjet2 As Integer

        If _pathSplitted.Length >= 1 Then
            _findedPole = poles.Find(Function(x) x.nom = _pathSplitted(0))
            If Not _findedPole Is Nothing Then
                _idPole = _findedPole.id
                _idPole2 = _idPole
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        If _pathSplitted.Length >= 2 Then
            _findedProjet = projets.Find(Function(x) x.nom = _pathSplitted(1) And x.idPole = _idPole2)
            If Not _findedProjet Is Nothing Then
                _idProjet = _findedProjet.id
                _idProjet2 = _idProjet
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        If _pathSplitted.Length >= 3 Then
            _findedFonction = fonctions.Find(Function(x) x.nom = _pathSplitted(2) And x.idProjet = _idProjet2)
            If Not _findedFonction Is Nothing Then
                _idFonction = _findedFonction.id
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Shared Sub addDataToLVI(ByRef lvi As ListViewItem, ByRef item As ExpTreeLib.CShItem)
        Dim testTime As New DateTime(1970, 1, 1)

        If Not item.IsDisk And item.IsFileSystem Then
            Dim attr As IO.FileAttributes
            attr = GetAttr(item.Path)
            Dim SB As New Text.StringBuilder()
            If (attr And IO.FileAttributes.System) = IO.FileAttributes.System Then SB.Append("S")
            If (attr And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then SB.Append("H")
            If (attr And IO.FileAttributes.ReadOnly) = IO.FileAttributes.ReadOnly Then SB.Append("R")
            If (attr And IO.FileAttributes.Archive) = IO.FileAttributes.Archive Then SB.Append("A")
            lvi.SubItems.Add(SB.ToString)
        Else
            lvi.SubItems.Add("")
        End If
        If Not item.IsDisk And item.IsFileSystem And Not item.IsFolder Then
            If item.Length > 1024 Then
                lvi.SubItems.Add(String.Format(item.Length / 1024, "#,### KB"))
            Else
                lvi.SubItems.Add(String.Format(item.Length, "##0 Bytes"))
            End If
        Else
            lvi.SubItems.Add("")
        End If
        lvi.SubItems.Add(item.TypeName)

        If item.IsDisk Then
            lvi.SubItems.Add("")
        Else
            If item.LastWriteTime = testTime Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(item.LastWriteTime)
            End If
        End If
        lvi.ImageIndex = ExpTreeLib.SystemImageListManager.GetIconIndex(item, False)
        lvi.Tag = item
    End Sub

    Shared Sub moveToServer(ByVal _fileList As System.Collections.ArrayList, ByVal _pathServer As String, ByVal _pole As String, ByVal _projet As String, ByVal _fonction As String, ByVal _idFonction As Integer, ByVal _utilisateurArray As List(Of Integer), ByRef extensions As extensions, ByRef types As types, ByRef fichiers As fichiers)

        Dim _nomFichier, _cheminFichier, _extensionFichier As String
        Dim idExtension As Integer

        Dim formType As New DialogType
        formType.ComboBoxFileType.DataSource = types
        formType.ComboBoxFileType.DisplayMember = "nom"

        For Each item As ExpTreeLib.CShItem In _fileList
            _cheminFichier = item.Path
            _nomFichier = GetName(_cheminFichier)
            _extensionFichier = GetExtension(item.Path)
            Dim NewCheminFichier As String = _pathServer + "\" + _pole + "\" + _projet + "\" + _fonction + "\" + item.DisplayName

            While IO.File.Exists(NewCheminFichier)
                Dim NewName As String
                NewName = Microsoft.VisualBasic.InputBox("Saisir le nouveau nom", "Renommer")

                If NewName <> Nothing Then
                    _nomFichier = NewName
                    NewCheminFichier = _pathServer + "\" + _pole + "\" + _projet + "\" + _fonction + "\" + _nomFichier + "." + _extensionFichier
                End If
            End While

            IO.File.Move(_cheminFichier, NewCheminFichier)

            Microsoft.VisualBasic.MsgBox(_cheminFichier.ToString & " moved to " & NewCheminFichier.ToString)

            If extensions.Find(Function(x) x.nom = _extensionFichier) Is Nothing Then
                If formType.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim _type As Integer
                    If formType.ComboBoxFileType.Items.Contains(formType.ComboBoxFileType.Text) Then
                        _type = types.Find(Function(x) x.nom = formType.ComboBoxFileType.Text).id
                    ElseIf formType.ComboBoxFileType.SelectedItem <> Nothing Then
                        _type = formType.ComboBoxFileType.SelectedItem.id
                    Else
                        _type = types.Add(formType.ComboBoxFileType.Text).id
                    End If

                    extensions.Add(_type, _extensionFichier)
                End If

            End If

            idExtension = extensions.Find(Function(x) x.nom = _extensionFichier).id

            fichiers.Add(_idFonction, idExtension, _utilisateurArray, _nomFichier)
        Next
    End Sub

    Shared Sub supprimer(ByVal _isFolder As Boolean, ByVal _path As String, ByRef poles As poles, ByRef projets As projets, ByRef fonctions As fonctions, ByRef fichiers As fichiers, ByRef extensions As extensions)
        Dim _idPole, _idProjet, _idFonction As Integer
        Dim _pathSplitted() As String
        Dim _extension As extension

        If _isFolder Then
            'IO.Directory.Delete(_path, True)
        Else
            IO.File.Delete(_path)
            _pathSplitted = _path.Split("\")
            getIdsPath(_pathSplitted, _idPole, _idProjet, _idFonction, poles, projets, fonctions)

            If _idPole = Nothing Or _idProjet = Nothing Or _idFonction = Nothing Then
                Exit Sub
            End If

            _extension = extensions.Find(Function(x) x.nom = GetExtension(_pathSplitted(3)))

            If _extension IsNot Nothing Then
                fichiers.Remove(fichiers.Find(Function(x) x.nom = GetName(_pathSplitted(3)) And x.idExtension = _extension.id And x.idFonction = _idFonction))
            End If
        End If
    End Sub

    Shared Sub renommer(ByVal _name As String, ByVal _path As String, ByVal _parentPath As String, ByRef poles As poles, ByRef projets As projets, ByRef fonctions As fonctions, ByRef fichiers As fichiers, ByRef extensions As extensions)
        Dim NewName, Extension, newpath As String
        Dim _idPole, _idProjet, _idFonction As Integer
        Dim _pathSplitted() As String
        Dim _extension As extension
        Dim _fichier As fichier = Nothing

        NewName = InputBox("Saisir le nouveau nom", "Renommer", _name)

        If NewName <> Nothing Then
            Extension = CRESS.DLL.utilities.GetExtension(_path)
            newpath = _parentPath & "\" & NewName & "." & Extension

            Rename(_path, newpath)
            _pathSplitted = _path.Split("\")

            getIdsPath(_pathSplitted, _idPole, _idProjet, _idFonction, poles, projets, fonctions)

            _extension = extensions.Find(Function(x) x.nom = GetExtension(_pathSplitted(3)))

            If _extension IsNot Nothing And _idFonction <> Nothing Then
                _fichier = fichiers.Find(Function(x) x.nom = GetName(_pathSplitted(3)) And x.idExtension = _extension.id And x.idFonction = _idFonction)
            End If

            If _fichier IsNot Nothing Then
                fichiers.Rename(NewName, _idFonction)
            ElseIf _idFonction <> Nothing Then
                fonctions.Rename(NewName, _idFonction)
            ElseIf _idProjet <> Nothing Then
                projets.Rename(NewName, _idProjet)
            ElseIf _idPole <> Nothing Then
                poles.Rename(NewName, _idPole)
            End If

        End If
    End Sub

    Shared Sub backFromServer(ByVal Sql As String, ByVal Table As String, ByVal Base As String)





    End Sub

    Shared Sub getFileList(ByVal _dirToDo As System.Collections.ArrayList, ByRef _dirList As System.Collections.ArrayList, ByRef _fileList As System.Collections.ArrayList)
        Dim _list As System.Collections.ArrayList

        For Each _dir As ExpTreeLib.CShItem In _dirToDo
            _list = _dir.GetDirectories
            _dirList.AddRange(_list)
            _fileList.AddRange(_dir.GetFiles)
            getFileList(_list, _dirList, _fileList)
        Next
    End Sub

    Shared Function GetExtension(ByVal path As String) As String
        Dim _ext As String = New System.IO.FileInfo(path).Extension
        Dim _return As String = ""

        If _ext <> Nothing Then
            _return = _ext.ToString.Substring(1)
        End If

        Return _return
    End Function

    Shared Function GetName(ByVal path As String) As String
        Dim Extension As String = New System.IO.FileInfo(path).Extension.ToString
        Dim NameExtension As String = New System.IO.FileInfo(path).Name.ToString
        Dim NameExtensionLenght As Integer = CType(NameExtension.Length, Integer)
        Dim ExtensionLenght As Integer = CType(Extension.Length, Integer)
        Dim StrictNameLenght As Integer = NameExtensionLenght - ExtensionLenght
        Return NameExtension.Remove(StrictNameLenght, ExtensionLenght)
    End Function
End Class
