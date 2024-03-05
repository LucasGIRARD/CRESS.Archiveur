Imports System.IO

Public Class Save
    Private _fileName As String
    Private _filePath As String
    Private _fileExtension As String
    Public formMain As Main

    Private _listPole As New List(Of CRESS.DLL.standard)
    Private _listProject As New List(Of CRESS.DLL.projet)
    Private _listFunction As New List(Of CRESS.DLL.fonction)

    Private _selectedPole, _selectedProject As Integer

    Private busy As Boolean = False

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Public Sub ShowDialogp(ByVal __path As String)

        _filePath = __path

        _fileExtension = CRESS.DLL.utilities.GetExtension(_filePath)
        If (_fileExtension <> "") Then
            _fileName = CRESS.DLL.utilities.GetName(_filePath) & "." & _fileExtension
        Else
            _fileName = CRESS.DLL.utilities.GetName(_filePath)
        End If

        LabelFile.Text = _fileName

        InitCombo()
        StateCombo()

        Me.ShowDialog()
    End Sub

    Public Sub InitCombo()
        CheckedListBoxUsers.DataSource = formMain.utilisateurs
        CheckedListBoxUsers.DisplayMember = "nom"

        ComboBoxPole.DataSource = Nothing
        _listPole.Clear()
        _listPole.AddRange(formMain.poles)
        ComboBoxPole.DataSource = _listPole
        ComboBoxPole.DisplayMember = "nom"
    End Sub

    Private Sub StateCombo() Handles ComboBoxProjet.SelectedValueChanged, ComboBoxPole.SelectedValueChanged
        If busy = False Then

            busy = True

            If ComboBoxPole.SelectedIndex > -1 Then
                ComboBoxProjet.Enabled = True
                If _selectedPole <> ComboBoxPole.SelectedItem.id Then
                    ComboBoxProjet.DataSource = Nothing
                    _listProject.Clear()

                    _listProject.AddRange(formMain.projets.FindAll(Function(x) x.idPole = ComboBoxPole.SelectedItem.id))
                    ComboBoxProjet.DataSource = _listProject
                    ComboBoxProjet.DisplayMember = "nom"
                End If
            Else
                ComboBoxProjet.DataSource = Nothing
                ComboBoxProjet.Enabled = False
            End If

            If ComboBoxProjet.SelectedIndex > -1 Then
                ComboBoxFonction.Enabled = True
                If _selectedProject <> ComboBoxProjet.SelectedItem.id Then
                    ComboBoxFonction.DataSource = Nothing
                    _listFunction.Clear()

                    _listFunction.AddRange(formMain.fonctions.FindAll(Function(x) x.idProjet = ComboBoxProjet.SelectedItem.id))
                    ComboBoxFonction.DataSource = _listFunction
                    ComboBoxFonction.DisplayMember = "nom"
                End If
            Else
                ComboBoxFonction.DataSource = Nothing
                ComboBoxFonction.Enabled = False
            End If
            If ComboBoxPole.SelectedItem IsNot Nothing Then
                _selectedPole = ComboBoxPole.SelectedItem.id
            End If

            If ComboBoxProjet.SelectedItem IsNot Nothing Then
                _selectedProject = ComboBoxProjet.SelectedItem.id
            End If

            busy = False
            End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBoxFonction.Text <> Nothing And ComboBoxPole.Text <> Nothing And ComboBoxProjet.Text <> Nothing And CheckedListBoxUsers.CheckedIndices.Count > 0 Then

            Dim __pole, __project, __function As String
            Dim __idPole, __idProject, __idFunction As Integer
            Dim __userList As New System.Collections.Generic.List(Of Integer)
            Dim __fileArray As New System.Collections.ArrayList()

            If Not formMain.poles.Exists(Function(x) x.nom = ComboBoxPole.Text) Then
                __pole = ComboBoxPole.Text
                __idPole = formMain.poles.Add(formMain.formOptions.PathServer, __pole).id
            ElseIf ComboBoxPole.SelectedItem IsNot Nothing Then
                __pole = ComboBoxPole.SelectedItem.nom
                __idPole = ComboBoxPole.SelectedItem.id
            Else
                __pole = ComboBoxPole.Text
                __idPole = formMain.poles.Find(Function(x) x.nom = __pole).id
            End If

            Dim t As Boolean = formMain.projets.Exists(Function(x) x.idPole = __idPole And x.nom = ComboBoxProjet.Text)
            If Not formMain.projets.Exists(Function(x) x.idPole = __idPole And x.nom = ComboBoxProjet.Text) Then
                __project = ComboBoxProjet.Text
                __idProject = formMain.projets.Add(formMain.formOptions.PathServer, __project, __pole, __idPole).id
            ElseIf ComboBoxProjet.SelectedItem IsNot Nothing Then
                __project = ComboBoxProjet.SelectedItem.nom
                __idProject = ComboBoxProjet.SelectedItem.id
            Else
                __project = ComboBoxProjet.Text
                __idProject = formMain.projets.Find(Function(x) x.idPole = __idPole And x.nom = __project).id
            End If


            If Not formMain.fonctions.Exists(Function(x) x.idProjet = __idProject And x.nom = ComboBoxFonction.Text) Then
                __function = ComboBoxFonction.Text
                __idFunction = formMain.fonctions.Add(formMain.formOptions.PathServer, __function, __pole, __project, __idProject).id
            ElseIf ComboBoxFonction.SelectedItem IsNot Nothing Then
                __function = ComboBoxFonction.SelectedItem.nom
                __idFunction = ComboBoxFonction.SelectedItem.id
            Else
                __function = ComboBoxFonction.Text
                __idFunction = formMain.fonctions.Find(Function(x) x.idProjet = __idProject And x.nom = __function).id
            End If

            For Each _utilisateur As CRESS.DLL.standard In CheckedListBoxUsers.SelectedItems
                __userList.Add(_utilisateur.id)
            Next

            Dim __selectedFile As New ExpTreeLib.CShItem(_filePath)
            __fileArray.Add(__selectedFile)

            CRESS.DLL.utilities.moveToServer(__fileArray, formMain.formOptions.PathServer, __pole, __project, __function, __idFunction, __userList, formMain.extensions, formMain.types, formMain.fichiers)

            formMain.InitCombo()
            Me.Close()
        Else
            MsgBox("Veuillez remplir une fonction, un pôle, un projet et au moins un utilisateur.")
        End If
    End Sub
End Class