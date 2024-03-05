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
    Public formOptions As New Options
    Private _formSave As New Save
#End Region

#Region "declaration et affection variable"
    Private _fileWatcher As FileSystem.DirectoryMonitor
    'Private _fileWatcher As IO.FileSystemWatcher


    Private _filteCreationDateStart As Date
    Private _filteCreationDateEnd As Date

    Private _filteModificationDateStart As Date
    Private _filteModificationDateEnd As Date
    Private _taskbarClose As Boolean = False
    Private _busy As Boolean = True
    Private _filePathBddOK As Boolean = False
    Private _objectsOK As Boolean = False
    Private _watcherEnabled As Boolean = False

    Private _listPole As New List(Of CRESS.DLL.standard)
    Private _listProject As New List(Of CRESS.DLL.projet)
    Private _listFunction As New List(Of CRESS.DLL.fonction)

    Private __selectedPole, __selectedProject As Integer
#End Region

#Region "option's vars"
    Private _displayType As String
    Private _displayPanelLeft As Boolean
    Private _displayPanelRight As Boolean
    Private _displayPanelUsers As Boolean
    Private _displayPanelFiles As Boolean
    Private _displayPanelSystem As Boolean
    Private _displayPanelDate As Boolean
    Private _displayPanelBottom As Boolean
#End Region

#Region "Init"
    Public Sub New()
        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        _formSave.formMain = Me

        Opacity = 0
        ShowInTaskbar = False

        LoadformOptions()

        InitFilter()

        InitObject()

        InitCombo()

        InitLV()

        InitTreeView()

        InitWatcher()

        _busy = False
        StateCombo()
    End Sub

    Public Sub LoadformOptions()
        _displayType = formOptions.DisplayType
        _displayPanelLeft = formOptions.DisplayPanelLeft
        _displayPanelRight = formOptions.DisplayPanelRight
        _displayPanelUsers = formOptions.DisplayPanelUsers
        _displayPanelFiles = formOptions.DisplayPanelFiles
        _displayPanelSystem = formOptions.DisplayPanelSystem
        _displayPanelDate = formOptions.DisplayPanelDate
        _displayPanelBottom = formOptions.DisplayPanelBottom


        If IO.File.Exists(formOptions.PathBDD) Then
            CRESS.DLL.classBdd.basePath = formOptions.PathBDD
            _filePathBddOK = True
        End If
    End Sub

    Private Sub InitFilter()
        DateTimePickerCreateStart.Value = DateTimePickerCreateStart.Value.AddYears(-2)
        DateTimePickerModifyStart.Value = DateTimePickerModifyStart.Value.AddYears(-2)

        _filteCreationDateStart = DateTimePickerCreateStart.Value
        _filteCreationDateEnd = DateTimePickerCreateEnd.Value
        _filteModificationDateStart = DateTimePickerModifyStart.Value
        _filteModificationDateEnd = DateTimePickerModifyEnd.Value
    End Sub

    Private Sub InitLV()
        ExpTreeLib.SystemImageListManager.SetListViewImageList(ListView, True, False)
        ComboBoxListViewDisplay.SelectedItem = ComboBoxListViewDisplay.Items(2)
    End Sub

    Private Sub InitObject()
        If _filePathBddOK Then
            poles = New CRESS.DLL.poles
            projets = New CRESS.DLL.projets
            types = New CRESS.DLL.types
            utilisateurs = New CRESS.DLL.utilisateurs
            fonctions = New CRESS.DLL.fonctions
            fichiers = New CRESS.DLL.fichiers
            extensions = New CRESS.DLL.extensions
            _objectsOK = True
        End If
    End Sub

    Private Sub InitTreeView()
        If formOptions.PathServer <> Nothing And IO.Directory.Exists(formOptions.PathServer) Then
            ExpTree1.RootItem = ExpTreeLib.CShItem.GetCShItem(formOptions.PathServer)
            ExpTree1.Visible = True
        Else
            ExpTree1.Visible = False
            ExpTree1.RootItem = ExpTreeLib.CShItem.GetCShItem(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        End If
    End Sub

    Private Sub InitWatcher()
        If formOptions.PathSave <> Nothing And IO.Directory.Exists(formOptions.PathSave) And _filePathBddOK Then

            _fileWatcher = New FileSystem.DirectoryMonitor(formOptions.PathSave)
            AddHandler _fileWatcher.Change, AddressOf _formSave.ShowDialogp
            _fileWatcher.Start()

            '_fileWatcher = New IO.FileSystemWatcher() With {
            '    .Path = formOptions.PathSave,
            '    .NotifyFilter = IO.NotifyFilters.LastWrite,
            '    .IncludeSubdirectories = True
            '}
            'AddHandler _fileWatcher.Changed, AddressOf _formSave.ShowDialogp
            '_fileWatcher.EnableRaisingEvents = True
            '_watcherEnabled = True


        End If
    End Sub

    Public Sub InitCombo()
        If _objectsOK Then
            CheckedListBoxUsers.DataSource = utilisateurs
            CheckedListBoxUsers.DisplayMember = "nom"

            ComboBoxPole.DataSource = Nothing
            _listPole.Clear()
            _listPole.Add(New CRESS.DLL.standard() With {.id = 0, .nom = ""})
            _listPole.AddRange(poles)
            ComboBoxPole.DataSource = _listPole
            ComboBoxPole.DisplayMember = "nom"


            ComboBoxFileType.DataSource = types
            ComboBoxFileType.DisplayMember = "nom"
        End If
    End Sub

#End Region

    Private Sub StateCombo() Handles ComboBoxProjet.SelectedValueChanged, ComboBoxPole.SelectedValueChanged
        If _busy = False Then

            _busy = True

            If ComboBoxPole.SelectedIndex > 0 Then
                ComboBoxProjet.Enabled = True
                If __selectedPole <> ComboBoxPole.SelectedIndex Then
                    ComboBoxProjet.DataSource = Nothing
                    _listProject.Clear()
                    _listProject.Add(New CRESS.DLL.projet() With {.id = 0, .nom = ""})
                    _listProject.AddRange(projets.FindAll(Function(x) x.idPole = ComboBoxPole.SelectedItem.id))
                    ComboBoxProjet.DataSource = _listProject
                    ComboBoxProjet.DisplayMember = "nom"
                End If
            Else
                ComboBoxProjet.DataSource = Nothing
                ComboBoxProjet.Enabled = False
            End If

            If ComboBoxProjet.SelectedIndex > 0 Then
                ComboBoxFonction.Enabled = True
                If __selectedProject <> ComboBoxProjet.SelectedIndex Then
                    ComboBoxFonction.DataSource = Nothing
                    _listFunction.Clear()
                    _listFunction.Add(New CRESS.DLL.fonction() With {.id = 0, .nom = ""})
                    _listFunction.AddRange(fonctions.FindAll(Function(x) x.idProjet = ComboBoxProjet.SelectedItem.id))
                    ComboBoxFonction.DataSource = _listFunction
                    ComboBoxFonction.DisplayMember = "nom"
                End If
            Else
                ComboBoxFonction.DataSource = Nothing
                ComboBoxFonction.Enabled = False
            End If

            __selectedPole = ComboBoxPole.SelectedIndex
            __selectedProject = ComboBoxProjet.SelectedIndex

            _busy = False
        End If
    End Sub

#Region "ListView Fonction"

    Private Sub ComboBoxListViewDisplay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxListViewDisplay.SelectedIndexChanged
        Select Case ComboBoxListViewDisplay.SelectedItem.ToString
            Case "Détails"
                ListView.View = View.Details
            Case "Icônes"
                ListView.View = View.LargeIcon
            Case "Liste"
                ListView.View = View.List
            Case "Miniatures"
                ListView.View = View.SmallIcon
            Case "Mosaiques"
                ListView.View = View.Tile
        End Select
    End Sub

    Private Sub RefreshLV(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RadioButtonUsersNo.CheckedChanged, RadioButtonUsersByReverse.CheckedChanged, RadioButtonUsersBy.CheckedChanged,
        ComboBoxFileType.SelectedValueChanged, ComboBoxProjet.SelectedValueChanged, ComboBoxPole.SelectedValueChanged, ComboBoxFonction.SelectedValueChanged,
        CheckedListBoxUsers.SelectedValueChanged, CheckBoxSystemHiddenFile.CheckedChanged, CheckBoxDateCreate.CheckedChanged, CheckBoxDateModify.CheckedChanged

        If _busy = False Then
            ExpTree1.RefreshTree()
        End If

    End Sub

    Private Sub AfterNodeSelect(ByVal pathName As String, ByVal CSI As ExpTreeLib.CShItem) Handles ExpTree1.ExpTreeNodeSelected
        If _busy = False Then
            Dim __dirArray, __dirArray2, __fileArray As New ArrayList()
            Dim __totalItems As Integer = 0
            Dim __totalItemsShowed As Integer = 0
            Dim __users As Windows.Forms.CheckedListBox.CheckedItemCollection = CheckedListBoxUsers.CheckedItems
            Dim __selectedPole, __selectedProject, __selectedFunction, __selectedType As Integer

            __selectedPole = __selectedProject = __selectedFunction = Nothing

            __dirArray = CSI.GetDirectories
            __dirArray2.AddRange(__dirArray)
            __fileArray = CSI.GetFiles

            CRESS.DLL.utilities.getFileList(__dirArray2, __dirArray, __fileArray)

            __totalItems = __dirArray.Count + __fileArray.Count

            If __totalItems > 0 Then

                If ComboBoxPole.SelectedItem IsNot Nothing Then
                    __selectedPole = ComboBoxPole.SelectedItem.id
                End If

                If ComboBoxProjet.SelectedItem IsNot Nothing Then
                    __selectedProject = ComboBoxProjet.SelectedItem.id
                End If

                If ComboBoxFonction.SelectedItem IsNot Nothing Then
                    __selectedFunction = ComboBoxFonction.SelectedItem.id
                End If

                If ComboBoxFileType.SelectedItem IsNot Nothing Then
                    __selectedType = ComboBoxFileType.SelectedItem.id
                End If



                __fileArray = CRESS.DLL.utilities.getViewableFileList(__fileArray, formOptions.PathServer, __users, poles, projets, fonctions, fichiers, extensions, _filteModificationDateStart, _filteModificationDateEnd, CheckBoxDateModify.Checked, _filteCreationDateStart, _filteCreationDateEnd, CheckBoxDateCreate.Checked, CheckBoxSystemHiddenFile.Checked, __selectedPole, __selectedProject, __selectedFunction, RadioButtonUsersNo.Checked, RadioButtonUsersBy.Checked, RadioButtonUsersByReverse.Checked, CheckBoxFileType.Checked, __selectedType)

                __totalItemsShowed = __fileArray.Count
                ListView.BeginUpdate()
                ListView.Items.Clear()
                ListView.Refresh()

                For Each item As ExpTreeLib.CShItem In __fileArray
                    Dim __listViewItem As New ListViewItem(item.DisplayName)
                    CRESS.DLL.utilities.addDataToLVI(__listViewItem, item)

                    ListView.Items.Add(__listViewItem)
                Next

                ListView.EndUpdate()
            Else
                ListView.Items.Clear()
            End If

            LabelItem.Text = __totalItemsShowed
            LabelTotalItem.Text = __totalItems
        End If
    End Sub

    Private Sub ListView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView.DoubleClick
        Dim __item As ExpTreeLib.CShItem = ListView.SelectedItems(0).Tag
        If __item.IsFolder Then
            ExpTree1.ExpandANode(__item)
        Else
            Try

                Process.Start(__item.Path)
                Opacity = 0
                ShowInTaskbar = False

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Erreur au lancement de l'application")
            End Try
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim __item As ExpTreeLib.CShItem = ListView.SelectedItems(0).Tag

        CRESS.DLL.utilities.supprimer(__item.IsFolder, __item.Path, poles, projets, fonctions, fichiers, extensions)

        ExpTree1.RefreshTree()
    End Sub

    Private Sub RenommerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenommerToolStripMenuItem.Click
        Dim __item As ExpTreeLib.CShItem = ListView.SelectedItems(0).Tag
        Dim __itemName As String = CRESS.DLL.utilities.GetName(__item.Path)

        CRESS.DLL.utilities.renommer(__itemName, __item.Path, __item.Parent.Path, poles, projets, fonctions, fichiers, extensions)

        ExpTree1.RefreshTree()
    End Sub

#End Region

#Region "DateTimePicker"

    Private Sub DateTimePicker1Update() Handles DateTimePickerCreateStart.ValueChanged
        If _busy = False Then
            _filteCreationDateStart = DateTimePickerCreateStart.Value
            ExpTree1.RefreshTree()
        End If
    End Sub

    Private Sub DateTimePicker2Update() Handles DateTimePickerCreateEnd.ValueChanged
        If _busy = False Then
            _filteCreationDateEnd = DateTimePickerCreateEnd.Value
            ExpTree1.RefreshTree()
        End If
    End Sub

    Private Sub DateTimePicker3Update() Handles DateTimePickerModifyStart.ValueChanged
        If _busy = False Then
            _filteModificationDateStart = DateTimePickerModifyStart.Value
            ExpTree1.RefreshTree()
        End If
    End Sub

    Private Sub DateTimePicker4Update() Handles DateTimePickerModifyEnd.ValueChanged
        If _busy = False Then
            _filteModificationDateEnd = DateTimePickerModifyEnd.Value
            ExpTree1.RefreshTree()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDateCreate.CheckedChanged
        If CheckBoxDateCreate.CheckState = CheckState.Checked Then
            DateTimePickerCreateStart.Enabled = True
            DateTimePickerCreateEnd.Enabled = True
        Else
            DateTimePickerCreateStart.Enabled = False
            DateTimePickerCreateEnd.Enabled = False
        End If
        ExpTree1.RefreshTree()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDateModify.CheckedChanged
        If CheckBoxDateModify.CheckState = CheckState.Checked Then
            DateTimePickerModifyStart.Enabled = True
            DateTimePickerModifyEnd.Enabled = True
        Else
            DateTimePickerModifyStart.Enabled = False
            DateTimePickerModifyEnd.Enabled = False
        End If
        ExpTree1.RefreshTree()
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

#Region "Retract/Deploy"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractLeft.Click

        If _displayPanelLeft = True Then
            TableLayoutPanel1.ColumnStyles(0).Width = 0
            ButtonRetractLeft.Text = ">"
            _displayPanelLeft = False
        Else
            TableLayoutPanel1.ColumnStyles(0).Width = 205
            ButtonRetractLeft.Text = "<"
            _displayPanelLeft = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractRight.Click
        If _displayPanelRight = True Then
            TableLayoutPanel1.ColumnStyles(4).Width = 0
            ButtonRetractRight.Text = "<"
            _displayPanelRight = False
        Else
            TableLayoutPanel1.ColumnStyles(4).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(4).Width = 35
            ButtonRetractRight.Text = ">"
            _displayPanelRight = True
        End If
    End Sub

    Private Sub BTN_bottomPanel_Click(sender As Object, e As EventArgs) Handles BTN_bottomPanel.Click
        If _displayPanelBottom = True Then
            TableLayoutPanel4.RowStyles(2).Height = 0
            BTN_bottomPanel.Text = "+"
            _displayPanelBottom = False
        Else
            TableLayoutPanel4.RowStyles(2).Height = 38
            BTN_bottomPanel.Text = "-"
            _displayPanelBottom = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractUsers.Click
        If _displayPanelUsers = True Then
            TableLayoutPanel2.RowStyles(0).Height = TableLayoutPanel2.RowStyles(0).Height - 190
            ButtonRetractUsers.Text = "+"
            _displayPanelUsers = False
        Else
            TableLayoutPanel2.RowStyles(0).Height = TableLayoutPanel2.RowStyles(0).Height + 190
            ButtonRetractUsers.Text = "-"
            _displayPanelUsers = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractFiles.Click
        If _displayPanelFiles = True Then
            TableLayoutPanel2.RowStyles(1).Height = TableLayoutPanel2.RowStyles(1).Height - 140
            ButtonRetractFiles.Text = "+"
            _displayPanelFiles = False
        Else
            TableLayoutPanel2.RowStyles(1).Height = TableLayoutPanel2.RowStyles(1).Height + 140
            ButtonRetractFiles.Text = "-"
            _displayPanelFiles = True
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractSystem.Click
        If _displayPanelSystem = True Then
            TableLayoutPanel2.RowStyles(2).Height = TableLayoutPanel2.RowStyles(2).Height - 120
            ButtonRetractSystem.Text = "+"
            _displayPanelSystem = False
        Else
            TableLayoutPanel2.RowStyles(2).Height = TableLayoutPanel2.RowStyles(2).Height + 120
            ButtonRetractSystem.Text = "-"
            _displayPanelSystem = True
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetractDate.Click
        If _displayPanelDate = True Then
            TableLayoutPanel2.RowStyles(3).Height = TableLayoutPanel2.RowStyles(3).Height - 160
            ButtonRetractDate.Text = "+"
            _displayPanelDate = False
        Else
            TableLayoutPanel2.RowStyles(3).Height = TableLayoutPanel2.RowStyles(3).Height + 160
            ButtonRetractDate.Text = "-"
            _displayPanelDate = True
        End If

    End Sub

#End Region

#Region "notify icon contextual menu"

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        _taskbarClose = True
        Close()
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        Opacity = 1
        ShowInTaskbar = True
    End Sub

#End Region

    Private Sub ButtonformOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOptions.Click
        If formOptions.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim __lastFilePathBddOK As Boolean = _filePathBddOK

            LoadformOptions()
            If Not __lastFilePathBddOK And _filePathBddOK And Not _objectsOK Then
                InitObject()
                InitCombo()
            End If

            InitLV()

            InitTreeView()

            InitWatcher()

            StateCombo()

        End If
    End Sub

    Private Sub CheckBoxSystemFileType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxFileType.CheckedChanged
        If CheckBoxFileType.CheckState = CheckState.Checked Then
            ComboBoxFileType.Enabled = True
        Else
            ComboBoxFileType.Enabled = False
        End If
        ExpTree1.RefreshTree()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _taskbarClose Then
            e.Cancel = True
            Opacity = 0
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        If ListView.SelectedItems.Count = 0 Then
            e.Cancel = True
        Else
            Dim __item As ExpTreeLib.CShItem = ListView.SelectedItems(0).Tag
            If __item.IsFolder Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Opacity = 1
        ShowInTaskbar = True
    End Sub

End Class