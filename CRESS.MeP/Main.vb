Public Class Main

#Region "objects"
    Public poles As CRESS.DLL.poles
    Public projets As CRESS.DLL.projets
    Public types As CRESS.DLL.types
    Public utilisateurs As CRESS.DLL.utilisateurs
    Public fonctions As CRESS.DLL.fonctions
    Public fichiers As CRESS.DLL.fichiers
    Public extensions As CRESS.DLL.extensions
#End Region

#Region "windows"
    Private _options As New Options
#End Region

#Region "declaration et affection variable"
    Private demarrer As Boolean = False

    Private _baseOK As Boolean = False
    Private _objectsOK As Boolean = False

    Private comboPole As New System.Collections.Generic.List(Of CRESS.DLL.standard)
    Private comboProjet As New System.Collections.Generic.List(Of CRESS.DLL.projet)
    Private comboFonction As New System.Collections.Generic.List(Of CRESS.DLL.fonction)

    Private selectedPole, selectedProjet As Integer
#End Region

    Public Sub New()
        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        init()
    End Sub

#Region "Init"

    Private Sub init()
        loadOptions()

        initObject()

        InitCombo()

        initLV()

        initTreeView()

        loadLD()

        demarrer = True
        stateCombo()
    End Sub

    Public Sub loadOptions()
        CRESS.DLL.classBdd.basePath = _options.PathBDD
        If IO.File.Exists(CRESS.DLL.classBdd.basePath) Then
            _baseOK = True
        Else
            _baseOK = False
        End If
    End Sub

    Private Sub initLV()
        ExpTreeLib.SystemImageListManager.SetListViewImageList(ListView1, True, False)
    End Sub

    Private Sub initObject()
        If _baseOK Then
            poles = New CRESS.DLL.poles
            projets = New CRESS.DLL.projets
            types = New CRESS.DLL.types
            utilisateurs = New CRESS.DLL.utilisateurs
            fonctions = New CRESS.DLL.fonctions
            fichiers = New CRESS.DLL.fichiers
            extensions = New CRESS.DLL.extensions
            _objectsOK = True
        Else
            poles = Nothing
            projets = Nothing
            types = Nothing
            utilisateurs = Nothing
            fonctions = Nothing
            fichiers = Nothing
            extensions = Nothing
            _objectsOK = False
        End If
    End Sub

    Private Sub initTreeView()
        If _options.PathServer <> Nothing And IO.Directory.Exists(_options.PathServer) Then
            ListView1.Visible = True
            BTN_toOrdered.Enabled = True
            BTN_toUnOrdered.Enabled = True
            loadLD()
        Else
            ListView1.Clear()
            ListView1.Visible = False
            BTN_toOrdered.Enabled = False
            BTN_toUnOrdered.Enabled = False
        End If
    End Sub

    Public Sub InitCombo()
        If _objectsOK Then
            CheckedListBoxUsers.DataSource = utilisateurs
            CheckedListBoxUsers.DisplayMember = "nom"

            ComboBoxPole.DataSource = Nothing
            comboPole.Clear()
            comboPole.Add(New CRESS.DLL.standard() With {.id = 0, .nom = ""})
            comboPole.AddRange(poles)
            ComboBoxPole.DataSource = comboPole
            ComboBoxPole.DisplayMember = "nom"
        End If
    End Sub

    Private Sub stateCombo() Handles ComboBoxProjet.SelectedValueChanged, ComboBoxPole.SelectedValueChanged, ComboBoxFonction.SelectedValueChanged
        If demarrer Then

            demarrer = False

            If ComboBoxPole.SelectedIndex > 0 Then
                ComboBoxProjet.Enabled = True
                If selectedPole <> ComboBoxPole.SelectedIndex Then
                    ComboBoxProjet.DataSource = Nothing
                    comboProjet.Clear()
                    comboProjet.Add(New CRESS.DLL.projet() With {.id = 0, .nom = ""})
                    comboProjet.AddRange(projets.FindAll(Function(x) x.idPole = ComboBoxPole.SelectedItem.id))
                    ComboBoxProjet.DataSource = comboProjet
                    ComboBoxProjet.DisplayMember = "nom"
                End If
            Else
                ComboBoxProjet.DataSource = Nothing
                ComboBoxProjet.Enabled = False
            End If

            If ComboBoxProjet.SelectedIndex > 0 Then
                ComboBoxFonction.Enabled = True
                If selectedProjet <> ComboBoxProjet.SelectedIndex Then
                    ComboBoxFonction.DataSource = Nothing
                    comboFonction.Clear()
                    comboFonction.Add(New CRESS.DLL.fonction() With {.id = 0, .nom = ""})
                    comboFonction.AddRange(fonctions.FindAll(Function(x) x.idProjet = ComboBoxProjet.SelectedItem.id))
                    ComboBoxFonction.DataSource = comboFonction
                    ComboBoxFonction.DisplayMember = "nom"
                End If
            Else
                ComboBoxFonction.DataSource = Nothing
                ComboBoxFonction.Enabled = False
            End If

            If ComboBoxFonction.SelectedIndex > 0 Then
                BTN_toOrdered.Enabled = True
            Else
                BTN_toOrdered.Enabled = False
            End If

            selectedPole = ComboBoxPole.SelectedIndex
            selectedProjet = ComboBoxProjet.SelectedIndex

            demarrer = True
        End If
    End Sub
#End Region

#Region "Form resize"

    Private Sub Main_ResizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin
        Enabled = 0
    End Sub

    Private Sub Main_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        Enabled = 1
    End Sub

#End Region

    Private Sub loadLD() Handles ComboBoxProjet.SelectedValueChanged, ComboBoxPole.SelectedValueChanged, ComboBoxFonction.SelectedValueChanged, CheckedListBoxUsers.SelectedValueChanged
        If _options.PathServer <> Nothing Then
            Dim dirList, dirList2, fileList As New System.Collections.ArrayList
            Dim TotalItems As Integer = 0
            Dim TotalItemsAffiche As Integer = 0
            Dim _users As System.Windows.Forms.CheckedListBox.CheckedItemCollection = CheckedListBoxUsers.CheckedItems
            Dim selectedPole, selectedProjet, selectedFonction, selectedType As Integer
            Dim CSI As ExpTreeLib.CShItem = ExpTreeLib.CShItem.GetCShItem(_options.PathServer)
            Dim _radioButtonUsersNo, _radioButtonUsersBy As Boolean

            selectedPole = selectedProjet = selectedFonction = Nothing

            dirList = CSI.GetDirectories
            dirList2.AddRange(dirList)
            fileList = CSI.GetFiles

            CRESS.DLL.utilities.getFileList(dirList2, dirList, fileList)

            TotalItems = dirList.Count + fileList.Count

            If TotalItems > 0 Then

                If ComboBoxPole.SelectedItem IsNot Nothing Then
                    selectedPole = ComboBoxPole.SelectedItem.id
                End If

                If ComboBoxProjet.SelectedItem IsNot Nothing Then
                    selectedProjet = ComboBoxProjet.SelectedItem.id
                End If

                If ComboBoxFonction.SelectedItem IsNot Nothing Then
                    selectedFonction = ComboBoxFonction.SelectedItem.id
                End If

                If _users.Count = 0 Then
                    _radioButtonUsersNo = True
                    _radioButtonUsersBy = False
                Else
                    _radioButtonUsersNo = False
                    _radioButtonUsersBy = True
                End If

                fileList = CRESS.DLL.utilities.getViewableFileList(fileList, Options.PathServer, _users, poles, projets, fonctions, fichiers, extensions, Nothing, Nothing, False, Nothing, Nothing, False, True, selectedPole, selectedProjet, selectedFonction, _radioButtonUsersNo, _radioButtonUsersBy, False, True, selectedType)

                TotalItemsAffiche = fileList.Count
                ListView1.BeginUpdate()
                ListView1.Items.Clear()
                ListView1.Refresh()

                For Each item As ExpTreeLib.CShItem In fileList
                    Dim lvi As New System.Windows.Forms.ListViewItem(item.DisplayName)
                    CRESS.DLL.utilities.addDataToLVI(lvi, item)

                    ListView1.Items.Add(lvi)
                Next

                ListView1.EndUpdate()
            Else
                ListView1.Items.Clear()
            End If
        End If
    End Sub

    Private Sub configuration_Click(sender As Object, e As EventArgs) Handles configuration.Click

        If _options.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            init()
        End If
    End Sub

    Private Sub BTN_toOrdered_Click(sender As Object, e As EventArgs) Handles BTN_toOrdered.Click
        If ComboBoxPole.SelectedItem IsNot Nothing And ComboBoxProjet.SelectedItem IsNot Nothing And ComboBoxFonction.SelectedItem IsNot Nothing And CheckedListBoxUsers.CheckedIndices.Count > 0 Then

            Dim _dirList, _dirList2, _fileList As New System.Collections.ArrayList()
            Dim _selectedPath As New ExpTreeLib.CShItem(ExpTree1.SelectedItem.Path)

            Dim _pole, _projet, _fonction As String
            Dim _idPole, _idProjet, _idFonction As Integer
            Dim _utilisateurArray As New System.Collections.Generic.List(Of Integer)

            _dirList = _selectedPath.GetDirectories
            _dirList2.AddRange(_dirList)
            _fileList = _selectedPath.GetFiles

            CRESS.DLL.utilities.getFileList(_dirList2, _dirList, _fileList)
            _fileList.Sort()

            _pole = ComboBoxPole.SelectedItem.nom
            _idPole = ComboBoxPole.SelectedItem.id


            _projet = ComboBoxProjet.SelectedItem.nom
            _idProjet = ComboBoxProjet.SelectedItem.id

            _fonction = ComboBoxFonction.SelectedItem.nom
            _idFonction = ComboBoxFonction.SelectedItem.id

            For Each _utilisateur As CRESS.DLL.standard In CheckedListBoxUsers.SelectedItems
                _utilisateurArray.Add(_utilisateur.id)
            Next

            CRESS.DLL.utilities.moveToServer(_fileList, _options.PathServer, _pole, _projet, _fonction, _idFonction, _utilisateurArray, extensions, types, fichiers)

            IO.Directory.Delete(ExpTree1.SelectedItem.Path)
            ExpTree1.RefreshTree()
            loadLD()
        Else
            MsgBox("Veuillez remplir une fonction, un pôle, un projet et au moins un utilisateur.")
        End If
    End Sub

    Private Sub BTN_toUnOrdered_Click(sender As Object, e As EventArgs) Handles BTN_toUnOrdered.Click
        Dim _csi As ExpTreeLib.CShItem
        Dim _newCheminFichier, _nomFichier As String
        For Each _item As System.Windows.Forms.ListViewItem In ListView1.SelectedItems
            _csi = _item.Tag

            _newCheminFichier = ExpTree1.SelectedItem.Path & "\" & _csi.DisplayName

            While IO.File.Exists(_newCheminFichier)
                _nomFichier = Microsoft.VisualBasic.InputBox("Saisir le nouveau nom", "Renommer")
                If _nomFichier <> Nothing Then
                    _newCheminFichier = ExpTree1.SelectedItem.Path & "\" & _nomFichier + "." & CRESS.DLL.utilities.GetExtension(_csi.DisplayName)
                End If
            End While

            IO.File.Move(_csi.Path, _newCheminFichier)

        Next
        loadLD()

    End Sub
End Class