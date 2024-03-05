Public Class Options

#Region "public vars"
    Public ConnectionActivate As Boolean
    Public ConnectionLogin As String
    Public ConnectionPass As String
    Public PathBDD As String
    Public PathServer As String
#End Region

#Region "private vars"
    Private PathFichierXML As String = IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location) & "\Options.xml"
    Private comboProjet As New System.Collections.Generic.List(Of CRESS.DLL.projet)
    Private scriptRunning As Boolean
    Private _pathOK As Boolean = False
#End Region

#Region "windows"
    Private _main As Main
#End Region

    Public Sub New()
        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ReadXml()

    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scriptRunning = True

        For Each f As System.Windows.Forms.Form In My.Application.OpenForms
            If f.Name = "Main" Then
                _main = f
            End If
        Next

        RefreshForm()

        checkPath()
        loadObjects()

        initCMBPoleType()
        scriptRunning = False
    End Sub

    Private Sub checkPath()

        If PathBDD <> "" And PathServer <> "" And IO.File.Exists(PathBDD) And IO.Directory.Exists(PathServer) Then
            If _pathOK = False Then
                _pathOK = True
                loadObjects()
            End If
        Else
            If _pathOK = True Then
                _pathOK = False
                loadObjects()
            End If
        End If
    End Sub

    Private Sub loadObjects()
        If _pathOK Then
            DGV_poles.DataSource = _main.poles
            DGV_poles.ReadOnly = True
            DGV_projet.DataSource = _main.projets
            DGV_projet.ReadOnly = True
            DGV_projet.Columns.Remove(DGV_projet.Columns(0))

            Dim comboboxColumnProjetPole As New System.Windows.Forms.DataGridViewComboBoxColumn

            comboboxColumnProjetPole.DataPropertyName = "idPole"
            comboboxColumnProjetPole.HeaderText = "Pôle"

            comboboxColumnProjetPole.DataSource = _main.poles
            comboboxColumnProjetPole.ValueMember = "id"
            comboboxColumnProjetPole.DisplayMember = "nom"

            DGV_projet.Columns.Insert(0, comboboxColumnProjetPole)


            DGV_fonctions.DataSource = _main.fonctions
            DGV_fonctions.ReadOnly = True
            DGV_fonctions.Columns.Remove(DGV_fonctions.Columns(0))

            Dim comboboxColumnFonctionProjet As New System.Windows.Forms.DataGridViewComboBoxColumn

            comboboxColumnFonctionProjet.DataPropertyName = "idProjet"
            comboboxColumnFonctionProjet.HeaderText = "Projet"

            comboboxColumnFonctionProjet.DataSource = _main.projets
            comboboxColumnFonctionProjet.ValueMember = "id"
            comboboxColumnFonctionProjet.DisplayMember = "nom"

            DGV_fonctions.Columns.Insert(0, comboboxColumnFonctionProjet)

            DGV_utilisateurs.DataSource = _main.utilisateurs
            DGV_utilisateurs.ReadOnly = True
            DGV_types.DataSource = _main.types
            DGV_types.ReadOnly = True
            DGV_extensions.DataSource = _main.extensions
            DGV_extensions.ReadOnly = True

            DGV_extensions.Columns.Remove(DGV_extensions.Columns(0))

            Dim comboboxColumnExtensionType As New System.Windows.Forms.DataGridViewComboBoxColumn

            comboboxColumnExtensionType.DataPropertyName = "idType"
            comboboxColumnExtensionType.HeaderText = "Type"

            comboboxColumnExtensionType.DataSource = _main.types
            comboboxColumnExtensionType.ValueMember = "id"
            comboboxColumnExtensionType.DisplayMember = "nom"

            DGV_extensions.Columns.Insert(0, comboboxColumnExtensionType)

            TAB_poles.Enabled = True
            TAB_projets.Enabled = True
            TAB_fonctions.Enabled = True
            TAB_utilisateurs.Enabled = True
            TAB_types.Enabled = True
            TAB_extensions.Enabled = True
        Else
            DGV_poles.DataSource = Nothing
            DGV_projet.DataSource = Nothing
            DGV_fonctions.DataSource = Nothing
            DGV_utilisateurs.DataSource = Nothing
            DGV_types.DataSource = Nothing
            DGV_extensions.DataSource = Nothing

            TAB_poles.Enabled = False
            TAB_projets.Enabled = False
            TAB_fonctions.Enabled = False
            TAB_utilisateurs.Enabled = False
            TAB_types.Enabled = False
            TAB_extensions.Enabled = False
        End If
    End Sub

    Private Sub initCMBPoleType()
        scriptRunning = True
        CMB_projetPole.DataSource = Nothing
        CMB_fonctionPole.DataSource = Nothing

        If _pathOK Then
            CMB_projetPole.DataSource = _main.poles
            CMB_projetPole.DisplayMember = "nom"
            CMB_fonctionPole.DataSource = _main.poles
            CMB_fonctionPole.DisplayMember = "nom"
            CMB_extensionType.DataSource = _main.types
            CMB_extensionType.DisplayMember = "nom"
        End If
        scriptRunning = False
        stateCombo()
    End Sub

    Private Sub stateCombo() Handles CMB_fonctionPole.SelectedValueChanged
        If Not scriptRunning Then
            scriptRunning = True

            CMB_fonctionProjet.Enabled = True

            CMB_fonctionProjet.DataSource = Nothing
            comboProjet.Clear()
            comboProjet.AddRange(_main.projets.FindAll(Function(x) x.idPole = CMB_fonctionPole.SelectedItem.id))
            CMB_fonctionProjet.DataSource = comboProjet
            CMB_fonctionProjet.DisplayMember = "nom"

            scriptRunning = False
        End If
    End Sub

    Private Sub RefreshForm()

        TextBoxPathBdd.Text = PathBDD
        TextBoxPathFolderServer.Text = PathServer
    End Sub

    Private Sub RefreshVars()

        PathBDD = TextBoxPathBdd.Text
        PathServer = TextBoxPathFolderServer.Text
    End Sub
#Region "Button action"

    Private Sub ButtonPathBdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPathBdd.Click
        If FileBrowserDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxPathBdd.Text = FileBrowserDialog.FileName
            PathBDD = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub ButtonPathFolderServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPathFolderServer.Click
        If FolderBrowserDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxPathFolderServer.Text = FolderBrowserDialog.SelectedPath
            PathServer = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub Options_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RefreshVars()
        ModifyXml()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BTN_addPole_Click(sender As Object, e As EventArgs) Handles BTN_addPole.Click
        If TXT_pole.Text <> "" And Not _main.poles.Exists(Function(x) x.nom = TXT_pole.Text) Then

            _main.poles.Add(PathServer, TXT_pole.Text)
            DGV_poles.DataSource = Nothing
            DGV_poles.DataSource = _main.poles

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_poles.DataSource)
            myCurrencyManager.Refresh()

            initCMBPoleType()
        End If
        TXT_pole.Text = ""
    End Sub

    Private Sub BTN_delPole_Click(sender As Object, e As EventArgs) Handles BTN_delPole.Click
        If DGV_poles.CurrentRow IsNot Nothing Then
            Dim _id As Integer = DGV_poles.CurrentRow.Cells(0).Value

            DGV_poles.ClearSelection()

            _main.poles.Remove(PathServer, _main.poles.Find(Function(x) x.id = _id), _main.projets, _main.fonctions, _main.fichiers, _main.extensions)
            DGV_poles.DataSource = Nothing
            DGV_poles.DataSource = _main.poles
        End If
    End Sub

    Private Sub BTN_addProject_Click(sender As Object, e As EventArgs) Handles BTN_addProject.Click
        If TXT_projet.Text <> "" And CMB_projetPole.SelectedItem IsNot Nothing And Not _main.projets.Exists(Function(x) x.idPole = CMB_projetPole.SelectedItem.id And x.nom = TXT_projet.Text) Then

            _main.projets.Add(PathServer, TXT_projet.Text, CMB_projetPole.SelectedItem.nom, CMB_projetPole.SelectedItem.id)
            DGV_projet.DataSource = Nothing
            DGV_projet.DataSource = _main.projets

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_projet.DataSource)
            myCurrencyManager.Refresh()

            stateCombo()
        End If
        TXT_projet.Text = ""
    End Sub

    Private Sub BTN_delProjet_Click(sender As Object, e As EventArgs) Handles BTN_delProjet.Click
        If DGV_projet.CurrentRow IsNot Nothing Then
            Dim _id As Integer = DGV_projet.CurrentRow.Cells(1).Value
            Dim _idPole As Integer = DGV_projet.CurrentRow.Cells(0).Value
            Dim _pole As CRESS.DLL.standard = _main.poles.Find(Function(x) x.id = _idPole)

            DGV_projet.ClearSelection()
            _main.projets.Remove(PathServer, _pole.nom, _main.projets.Find(Function(x) x.id = _id), _main.fonctions, _main.fichiers, _main.extensions)
            DGV_projet.DataSource = Nothing
            DGV_projet.DataSource = _main.projets
        End If
    End Sub

    Private Sub BTN_addFonction_Click(sender As Object, e As EventArgs) Handles BTN_addFonction.Click
        If TXT_fonction.Text <> "" And CMB_fonctionPole.SelectedItem IsNot Nothing And Not _main.fonctions.Exists(Function(x) x.idProjet = CMB_fonctionProjet.SelectedItem.id And x.nom = TXT_fonction.Text) Then

            _main.fonctions.Add(PathServer, TXT_fonction.Text, CMB_fonctionPole.SelectedItem.nom, CMB_fonctionProjet.SelectedItem.nom, CMB_fonctionProjet.SelectedItem.id)
            DGV_fonctions.DataSource = Nothing
            DGV_fonctions.DataSource = _main.fonctions

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_fonctions.DataSource)
            myCurrencyManager.Refresh()
        End If
        TXT_fonction.Text = ""
    End Sub

    Private Sub BTN_delFonction_Click(sender As Object, e As EventArgs) Handles BTN_delFonction.Click
        If DGV_fonctions.CurrentRow IsNot Nothing Then
            Dim _id As Integer = DGV_fonctions.CurrentRow.Cells(1).Value
            Dim _idProjet As Integer = DGV_fonctions.CurrentRow.Cells(0).Value
            Dim _projet As CRESS.DLL.projet = _main.projets.Find(Function(x) x.id = _idProjet)
            Dim _pole As CRESS.DLL.standard = _main.poles.Find(Function(x) x.id = _projet.idPole)

            DGV_fonctions.ClearSelection()
            _main.fonctions.Remove(PathServer, _pole.nom, _projet.nom, _main.fonctions.Find(Function(x) x.idProjet = _idProjet And x.id = _id), _main.fichiers, _main.extensions)
            DGV_fonctions.DataSource = Nothing
            DGV_fonctions.DataSource = _main.fonctions
        End If
    End Sub

    Private Sub BTN_addUtilisateur_Click(sender As Object, e As EventArgs) Handles BTN_addUtilisateur.Click
        If TXT_utilisateur.Text <> "" And Not _main.utilisateurs.Exists(Function(x) x.nom = TXT_utilisateur.Text) Then

            _main.utilisateurs.Add(TXT_utilisateur.Text)
            DGV_utilisateurs.DataSource = Nothing
            DGV_utilisateurs.DataSource = _main.utilisateurs

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_utilisateurs.DataSource)
            myCurrencyManager.Refresh()

        End If
        TXT_utilisateur.Text = ""
    End Sub

    Private Sub BTN_delUtilisateur_Click(sender As Object, e As EventArgs) Handles BTN_delUtilisateur.Click
        If DGV_utilisateurs.CurrentRow IsNot Nothing Then
            _main.utilisateurs.Remove(_main.utilisateurs.Find(Function(x) x.id = DGV_utilisateurs.CurrentRow.Cells(0).Value And x.nom = DGV_utilisateurs.CurrentRow.Cells(1).Value))
            DGV_utilisateurs.DataSource = Nothing
            DGV_utilisateurs.DataSource = _main.utilisateurs
        End If
    End Sub

    Private Sub BTN_addType_Click(sender As Object, e As EventArgs) Handles BTN_addType.Click
        If TXT_type.Text <> "" And Not _main.types.Exists(Function(x) x.nom = TXT_type.Text) Then

            _main.types.Add(TXT_type.Text)
            DGV_types.DataSource = Nothing
            DGV_types.DataSource = _main.types

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_types.DataSource)
            myCurrencyManager.Refresh()

        End If
        TXT_type.Text = ""
    End Sub

    Private Sub BTN_delType_Click(sender As Object, e As EventArgs) Handles BTN_delType.Click
        If DGV_types.CurrentRow IsNot Nothing Then
            _main.types.Remove(_main.types.Find(Function(x) x.id = DGV_types.CurrentRow.Cells(0).Value And x.nom = DGV_types.CurrentRow.Cells(1).Value))
            DGV_types.DataSource = Nothing
            DGV_types.DataSource = _main.types
        End If
    End Sub

    Private Sub BTN_addExtension_Click(sender As Object, e As EventArgs) Handles BTN_addExtension.Click
        If TXT_extension.Text <> "" And CMB_extensionType.SelectedItem IsNot Nothing And Not _main.extensions.Exists(Function(x) x.idType = CMB_extensionType.SelectedItem.id And x.nom = TXT_extension.Text) Then

            _main.extensions.Add(CMB_extensionType.SelectedItem.id, TXT_extension.Text)
            DGV_extensions.DataSource = Nothing
            DGV_extensions.DataSource = _main.extensions

            '??? but works
            Dim myCurrencyManager As System.Windows.Forms.CurrencyManager = Me.BindingContext(DGV_extensions.DataSource)
            myCurrencyManager.Refresh()
        End If
        TXT_extension.Text = ""
    End Sub

    Private Sub BTN_delExtension_Click(sender As Object, e As EventArgs) Handles BTN_delExtension.Click
        If DGV_extensions.CurrentRow IsNot Nothing Then
            _main.extensions.Remove(_main.extensions.Find(Function(x) x.id = DGV_extensions.CurrentRow.Cells(1).Value And x.nom = DGV_extensions.CurrentRow.Cells(2).Value))
            DGV_extensions.DataSource = Nothing
            DGV_extensions.DataSource = _main.extensions
        End If
    End Sub

#End Region

#Region "Xml function"
    Public Sub ReadXml()

        Try
            If IO.File.Exists(PathFichierXML) Then
                Dim XMLconfig As Xml.XmlDocument = New Xml.XmlDocument 'declaration d'un fichier xml
                XMLconfig.Load(PathFichierXML) 'chargement du fichier XML, PathFichierXML est une variable dans laquelle je stocke le chemin de mon fichier xml 
                Dim node As Xml.XmlNode = XMLconfig.DocumentElement 'noeud de ton document XML 
                Dim Childnode As Xml.XmlNode = XMLconfig.DocumentElement 'noeud de ton document XML
                For Each node In node.ChildNodes 'je parcours chaque noeuds

                    If node.Attributes("value").InnerText = "Connect" Then
                        For Each Childnode In node.ChildNodes

                            If Childnode.Name = "Activate" Then
                                ConnectionActivate = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "Login" Then
                                ConnectionLogin = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "Pass" Then
                                ConnectionPass = Childnode.Attributes("value").InnerText
                            End If

                        Next

                    ElseIf node.Attributes("value").InnerText = "Path" Then
                        For Each Childnode In node.ChildNodes

                            If Childnode.Name = "BDD" Then
                                PathBDD = Childnode.Attributes("value").InnerText
                            ElseIf Childnode.Name = "Server" Then
                                PathServer = Childnode.Attributes("value").InnerText
                            End If

                        Next
                    End If
                Next
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ModifyXml()

        Try
            Dim XMLconfig As Xml.XmlDocument = New Xml.XmlDocument 'declaration d'un fichier xml

            If IO.File.Exists(PathFichierXML) Then
                XMLconfig.Load(PathFichierXML) 'chargement du fichier XML, PathFichierXML est une variable dans laquelle je stocke le chemin de mon fichier xml 
            Else
                XMLconfig.LoadXml("<Application xmlns=""Options""><Option value=""Display""><Type value=""DeployAll""/><PanelLeft value=""""/><PanelRight value=""""/><PanelUsers value=""""/><PanelFiles value=""""/><PanelSystem value=""""/><PanelDate value=""""/></Option><Option value=""Connect""><Activate value=""""/><Login value=""""/><Pass value=""""/></Option><Option value=""Path""><BDD value=""TODO""/><Server value=""""/><Save value=""""/></Option></Application>")
            End If

            Dim node As Xml.XmlNode = XMLconfig.DocumentElement 'noeud de ton document XML 
            Dim Childnode As Xml.XmlNode = XMLconfig.DocumentElement 'noeud de ton document XML
            For Each node In node.ChildNodes 'je parcours chaque noeuds

                If node.Attributes("value").InnerText = "Connect" Then
                    For Each Childnode In node.ChildNodes

                        If Childnode.Name = "Activate" Then
                            Childnode.Attributes("value").InnerText = ConnectionActivate

                        ElseIf Childnode.Name = "Login" Then
                            Childnode.Attributes("value").InnerText = ConnectionLogin

                        ElseIf Childnode.Name = "Pass" Then
                            Childnode.Attributes("value").InnerText = ConnectionPass
                        End If
                    Next
                ElseIf node.Attributes("value").InnerText = "Path" Then
                    For Each Childnode In node.ChildNodes

                        If Childnode.Name = "BDD" Then
                            Childnode.Attributes("value").InnerText = PathBDD
                        ElseIf Childnode.Name = "Server" Then
                            Childnode.Attributes("value").InnerText = PathServer
                        End If

                    Next
                End If
            Next
            XMLconfig.Save(PathFichierXML) 'enregistrement
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

End Class