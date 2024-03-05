<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_poles = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TXT_pole = New System.Windows.Forms.TextBox()
        Me.BTN_delPole = New System.Windows.Forms.Button()
        Me.BTN_addPole = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TAB_general = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonPathFolderServer = New System.Windows.Forms.Button()
        Me.ButtonPathBdd = New System.Windows.Forms.Button()
        Me.TextBoxPathFolderServer = New System.Windows.Forms.TextBox()
        Me.TextBoxPathBdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TAB_poles = New System.Windows.Forms.TabPage()
        Me.TAB_projets = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DGV_projet = New System.Windows.Forms.DataGridView()
        Me.CMB_projetPole = New System.Windows.Forms.ComboBox()
        Me.TXT_projet = New System.Windows.Forms.TextBox()
        Me.BTN_delProjet = New System.Windows.Forms.Button()
        Me.BTN_addProject = New System.Windows.Forms.Button()
        Me.TAB_fonctions = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.DGV_fonctions = New System.Windows.Forms.DataGridView()
        Me.CMB_fonctionProjet = New System.Windows.Forms.ComboBox()
        Me.CMB_fonctionPole = New System.Windows.Forms.ComboBox()
        Me.TXT_fonction = New System.Windows.Forms.TextBox()
        Me.BTN_delFonction = New System.Windows.Forms.Button()
        Me.BTN_addFonction = New System.Windows.Forms.Button()
        Me.TAB_utilisateurs = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.DGV_utilisateurs = New System.Windows.Forms.DataGridView()
        Me.TXT_utilisateur = New System.Windows.Forms.TextBox()
        Me.BTN_delUtilisateur = New System.Windows.Forms.Button()
        Me.BTN_addUtilisateur = New System.Windows.Forms.Button()
        Me.TAB_types = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.DGV_types = New System.Windows.Forms.DataGridView()
        Me.TXT_type = New System.Windows.Forms.TextBox()
        Me.BTN_delType = New System.Windows.Forms.Button()
        Me.BTN_addType = New System.Windows.Forms.Button()
        Me.TAB_extensions = New System.Windows.Forms.TabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.DGV_extensions = New System.Windows.Forms.DataGridView()
        Me.CMB_extensionType = New System.Windows.Forms.ComboBox()
        Me.TXT_extension = New System.Windows.Forms.TextBox()
        Me.BTN_delExtension = New System.Windows.Forms.Button()
        Me.BTN_addExtension = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileBrowserDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DGV_poles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TAB_general.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TAB_poles.SuspendLayout()
        Me.TAB_projets.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DGV_projet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_fonctions.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.DGV_fonctions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_utilisateurs.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.DGV_utilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_types.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.DGV_types, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_extensions.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.DGV_extensions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_poles
        '
        Me.DGV_poles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_poles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_poles.Location = New System.Drawing.Point(0, 0)
        Me.DGV_poles.Name = "DGV_poles"
        Me.DGV_poles.Size = New System.Drawing.Size(409, 332)
        Me.DGV_poles.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGV_poles)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TXT_pole)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BTN_delPole)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BTN_addPole)
        Me.SplitContainer1.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.TabIndex = 1
        '
        'TXT_pole
        '
        Me.TXT_pole.Location = New System.Drawing.Point(81, 6)
        Me.TXT_pole.Name = "TXT_pole"
        Me.TXT_pole.Size = New System.Drawing.Size(100, 20)
        Me.TXT_pole.TabIndex = 3
        '
        'BTN_delPole
        '
        Me.BTN_delPole.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delPole.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delPole.Name = "BTN_delPole"
        Me.BTN_delPole.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delPole.TabIndex = 1
        Me.BTN_delPole.Text = "Supprimer"
        Me.BTN_delPole.UseVisualStyleBackColor = True
        '
        'BTN_addPole
        '
        Me.BTN_addPole.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addPole.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addPole.Name = "BTN_addPole"
        Me.BTN_addPole.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addPole.TabIndex = 0
        Me.BTN_addPole.Text = "Ajouter"
        Me.BTN_addPole.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TAB_general)
        Me.TabControl1.Controls.Add(Me.TAB_poles)
        Me.TabControl1.Controls.Add(Me.TAB_projets)
        Me.TabControl1.Controls.Add(Me.TAB_fonctions)
        Me.TabControl1.Controls.Add(Me.TAB_utilisateurs)
        Me.TabControl1.Controls.Add(Me.TAB_types)
        Me.TabControl1.Controls.Add(Me.TAB_extensions)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 392)
        Me.TabControl1.TabIndex = 2
        '
        'TAB_general
        '
        Me.TAB_general.Controls.Add(Me.GroupBox3)
        Me.TAB_general.Location = New System.Drawing.Point(4, 22)
        Me.TAB_general.Name = "TAB_general"
        Me.TAB_general.Size = New System.Drawing.Size(409, 366)
        Me.TAB_general.TabIndex = 0
        Me.TAB_general.Text = "Général"
        Me.TAB_general.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonPathFolderServer)
        Me.GroupBox3.Controls.Add(Me.ButtonPathBdd)
        Me.GroupBox3.Controls.Add(Me.TextBoxPathFolderServer)
        Me.GroupBox3.Controls.Add(Me.TextBoxPathBdd)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 337)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Les emplacements"
        '
        'ButtonPathFolderServer
        '
        Me.ButtonPathFolderServer.Location = New System.Drawing.Point(243, 49)
        Me.ButtonPathFolderServer.Name = "ButtonPathFolderServer"
        Me.ButtonPathFolderServer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPathFolderServer.TabIndex = 7
        Me.ButtonPathFolderServer.Text = "Parcourir…"
        Me.ButtonPathFolderServer.UseVisualStyleBackColor = True
        '
        'ButtonPathBdd
        '
        Me.ButtonPathBdd.Location = New System.Drawing.Point(243, 23)
        Me.ButtonPathBdd.Name = "ButtonPathBdd"
        Me.ButtonPathBdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPathBdd.TabIndex = 6
        Me.ButtonPathBdd.Text = "Parcourir…"
        Me.ButtonPathBdd.UseVisualStyleBackColor = True
        '
        'TextBoxPathFolderServer
        '
        Me.TextBoxPathFolderServer.Location = New System.Drawing.Point(137, 51)
        Me.TextBoxPathFolderServer.Name = "TextBoxPathFolderServer"
        Me.TextBoxPathFolderServer.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPathFolderServer.TabIndex = 4
        '
        'TextBoxPathBdd
        '
        Me.TextBoxPathBdd.Location = New System.Drawing.Point(137, 25)
        Me.TextBoxPathBdd.Name = "TextBoxPathBdd"
        Me.TextBoxPathBdd.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPathBdd.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dossier serveur : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Base de donnée : "
        '
        'TAB_poles
        '
        Me.TAB_poles.Controls.Add(Me.SplitContainer1)
        Me.TAB_poles.Location = New System.Drawing.Point(4, 22)
        Me.TAB_poles.Name = "TAB_poles"
        Me.TAB_poles.Size = New System.Drawing.Size(409, 366)
        Me.TAB_poles.TabIndex = 1
        Me.TAB_poles.Text = "Pôles"
        Me.TAB_poles.UseVisualStyleBackColor = True
        '
        'TAB_projets
        '
        Me.TAB_projets.Controls.Add(Me.SplitContainer2)
        Me.TAB_projets.Location = New System.Drawing.Point(4, 22)
        Me.TAB_projets.Name = "TAB_projets"
        Me.TAB_projets.Size = New System.Drawing.Size(409, 366)
        Me.TAB_projets.TabIndex = 2
        Me.TAB_projets.Text = "Projets"
        Me.TAB_projets.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DGV_projet)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CMB_projetPole)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TXT_projet)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BTN_delProjet)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BTN_addProject)
        Me.SplitContainer2.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer2.SplitterDistance = 332
        Me.SplitContainer2.TabIndex = 2
        '
        'DGV_projet
        '
        Me.DGV_projet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_projet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_projet.Location = New System.Drawing.Point(0, 0)
        Me.DGV_projet.Name = "DGV_projet"
        Me.DGV_projet.Size = New System.Drawing.Size(409, 332)
        Me.DGV_projet.TabIndex = 0
        '
        'CMB_projetPole
        '
        Me.CMB_projetPole.FormattingEnabled = True
        Me.CMB_projetPole.Location = New System.Drawing.Point(81, 6)
        Me.CMB_projetPole.Name = "CMB_projetPole"
        Me.CMB_projetPole.Size = New System.Drawing.Size(68, 21)
        Me.CMB_projetPole.TabIndex = 4
        '
        'TXT_projet
        '
        Me.TXT_projet.Location = New System.Drawing.Point(155, 6)
        Me.TXT_projet.Name = "TXT_projet"
        Me.TXT_projet.Size = New System.Drawing.Size(100, 20)
        Me.TXT_projet.TabIndex = 3
        '
        'BTN_delProjet
        '
        Me.BTN_delProjet.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delProjet.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delProjet.Name = "BTN_delProjet"
        Me.BTN_delProjet.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delProjet.TabIndex = 1
        Me.BTN_delProjet.Text = "Supprimer"
        Me.BTN_delProjet.UseVisualStyleBackColor = True
        '
        'BTN_addProject
        '
        Me.BTN_addProject.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addProject.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addProject.Name = "BTN_addProject"
        Me.BTN_addProject.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addProject.TabIndex = 0
        Me.BTN_addProject.Text = "Ajouter"
        Me.BTN_addProject.UseVisualStyleBackColor = True
        '
        'TAB_fonctions
        '
        Me.TAB_fonctions.Controls.Add(Me.SplitContainer3)
        Me.TAB_fonctions.Location = New System.Drawing.Point(4, 22)
        Me.TAB_fonctions.Name = "TAB_fonctions"
        Me.TAB_fonctions.Size = New System.Drawing.Size(409, 366)
        Me.TAB_fonctions.TabIndex = 3
        Me.TAB_fonctions.Text = "Fonctions"
        Me.TAB_fonctions.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.DGV_fonctions)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.CMB_fonctionProjet)
        Me.SplitContainer3.Panel2.Controls.Add(Me.CMB_fonctionPole)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TXT_fonction)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BTN_delFonction)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BTN_addFonction)
        Me.SplitContainer3.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer3.SplitterDistance = 332
        Me.SplitContainer3.TabIndex = 2
        '
        'DGV_fonctions
        '
        Me.DGV_fonctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_fonctions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_fonctions.Location = New System.Drawing.Point(0, 0)
        Me.DGV_fonctions.Name = "DGV_fonctions"
        Me.DGV_fonctions.Size = New System.Drawing.Size(409, 332)
        Me.DGV_fonctions.TabIndex = 0
        '
        'CMB_fonctionProjet
        '
        Me.CMB_fonctionProjet.FormattingEnabled = True
        Me.CMB_fonctionProjet.Location = New System.Drawing.Point(155, 6)
        Me.CMB_fonctionProjet.Name = "CMB_fonctionProjet"
        Me.CMB_fonctionProjet.Size = New System.Drawing.Size(68, 21)
        Me.CMB_fonctionProjet.TabIndex = 5
        '
        'CMB_fonctionPole
        '
        Me.CMB_fonctionPole.FormattingEnabled = True
        Me.CMB_fonctionPole.Location = New System.Drawing.Point(81, 6)
        Me.CMB_fonctionPole.Name = "CMB_fonctionPole"
        Me.CMB_fonctionPole.Size = New System.Drawing.Size(68, 21)
        Me.CMB_fonctionPole.TabIndex = 5
        '
        'TXT_fonction
        '
        Me.TXT_fonction.Location = New System.Drawing.Point(229, 6)
        Me.TXT_fonction.Name = "TXT_fonction"
        Me.TXT_fonction.Size = New System.Drawing.Size(100, 20)
        Me.TXT_fonction.TabIndex = 3
        '
        'BTN_delFonction
        '
        Me.BTN_delFonction.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delFonction.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delFonction.Name = "BTN_delFonction"
        Me.BTN_delFonction.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delFonction.TabIndex = 1
        Me.BTN_delFonction.Text = "Supprimer"
        Me.BTN_delFonction.UseVisualStyleBackColor = True
        '
        'BTN_addFonction
        '
        Me.BTN_addFonction.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addFonction.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addFonction.Name = "BTN_addFonction"
        Me.BTN_addFonction.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addFonction.TabIndex = 0
        Me.BTN_addFonction.Text = "Ajouter"
        Me.BTN_addFonction.UseVisualStyleBackColor = True
        '
        'TAB_utilisateurs
        '
        Me.TAB_utilisateurs.Controls.Add(Me.SplitContainer4)
        Me.TAB_utilisateurs.Location = New System.Drawing.Point(4, 22)
        Me.TAB_utilisateurs.Name = "TAB_utilisateurs"
        Me.TAB_utilisateurs.Size = New System.Drawing.Size(409, 366)
        Me.TAB_utilisateurs.TabIndex = 4
        Me.TAB_utilisateurs.Text = "Uitlisateurs"
        Me.TAB_utilisateurs.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.DGV_utilisateurs)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.TXT_utilisateur)
        Me.SplitContainer4.Panel2.Controls.Add(Me.BTN_delUtilisateur)
        Me.SplitContainer4.Panel2.Controls.Add(Me.BTN_addUtilisateur)
        Me.SplitContainer4.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer4.SplitterDistance = 332
        Me.SplitContainer4.TabIndex = 2
        '
        'DGV_utilisateurs
        '
        Me.DGV_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_utilisateurs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_utilisateurs.Location = New System.Drawing.Point(0, 0)
        Me.DGV_utilisateurs.Name = "DGV_utilisateurs"
        Me.DGV_utilisateurs.Size = New System.Drawing.Size(409, 332)
        Me.DGV_utilisateurs.TabIndex = 0
        '
        'TXT_utilisateur
        '
        Me.TXT_utilisateur.Location = New System.Drawing.Point(81, 6)
        Me.TXT_utilisateur.Name = "TXT_utilisateur"
        Me.TXT_utilisateur.Size = New System.Drawing.Size(100, 20)
        Me.TXT_utilisateur.TabIndex = 2
        '
        'BTN_delUtilisateur
        '
        Me.BTN_delUtilisateur.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delUtilisateur.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delUtilisateur.Name = "BTN_delUtilisateur"
        Me.BTN_delUtilisateur.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delUtilisateur.TabIndex = 1
        Me.BTN_delUtilisateur.Text = "Supprimer"
        Me.BTN_delUtilisateur.UseVisualStyleBackColor = True
        '
        'BTN_addUtilisateur
        '
        Me.BTN_addUtilisateur.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addUtilisateur.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addUtilisateur.Name = "BTN_addUtilisateur"
        Me.BTN_addUtilisateur.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addUtilisateur.TabIndex = 0
        Me.BTN_addUtilisateur.Text = "Ajouter"
        Me.BTN_addUtilisateur.UseVisualStyleBackColor = True
        '
        'TAB_types
        '
        Me.TAB_types.Controls.Add(Me.SplitContainer5)
        Me.TAB_types.Location = New System.Drawing.Point(4, 22)
        Me.TAB_types.Name = "TAB_types"
        Me.TAB_types.Size = New System.Drawing.Size(409, 366)
        Me.TAB_types.TabIndex = 5
        Me.TAB_types.Text = "Types"
        Me.TAB_types.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.DGV_types)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.TXT_type)
        Me.SplitContainer5.Panel2.Controls.Add(Me.BTN_delType)
        Me.SplitContainer5.Panel2.Controls.Add(Me.BTN_addType)
        Me.SplitContainer5.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer5.SplitterDistance = 332
        Me.SplitContainer5.TabIndex = 3
        '
        'DGV_types
        '
        Me.DGV_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_types.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_types.Location = New System.Drawing.Point(0, 0)
        Me.DGV_types.Name = "DGV_types"
        Me.DGV_types.Size = New System.Drawing.Size(409, 332)
        Me.DGV_types.TabIndex = 0
        '
        'TXT_type
        '
        Me.TXT_type.Location = New System.Drawing.Point(81, 6)
        Me.TXT_type.Name = "TXT_type"
        Me.TXT_type.Size = New System.Drawing.Size(100, 20)
        Me.TXT_type.TabIndex = 2
        '
        'BTN_delType
        '
        Me.BTN_delType.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delType.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delType.Name = "BTN_delType"
        Me.BTN_delType.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delType.TabIndex = 1
        Me.BTN_delType.Text = "Supprimer"
        Me.BTN_delType.UseVisualStyleBackColor = True
        '
        'BTN_addType
        '
        Me.BTN_addType.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addType.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addType.Name = "BTN_addType"
        Me.BTN_addType.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addType.TabIndex = 0
        Me.BTN_addType.Text = "Ajouter"
        Me.BTN_addType.UseVisualStyleBackColor = True
        '
        'TAB_extensions
        '
        Me.TAB_extensions.Controls.Add(Me.SplitContainer6)
        Me.TAB_extensions.Location = New System.Drawing.Point(4, 22)
        Me.TAB_extensions.Name = "TAB_extensions"
        Me.TAB_extensions.Size = New System.Drawing.Size(409, 366)
        Me.TAB_extensions.TabIndex = 6
        Me.TAB_extensions.Text = "Extensions"
        Me.TAB_extensions.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.DGV_extensions)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.CMB_extensionType)
        Me.SplitContainer6.Panel2.Controls.Add(Me.TXT_extension)
        Me.SplitContainer6.Panel2.Controls.Add(Me.BTN_delExtension)
        Me.SplitContainer6.Panel2.Controls.Add(Me.BTN_addExtension)
        Me.SplitContainer6.Size = New System.Drawing.Size(409, 366)
        Me.SplitContainer6.SplitterDistance = 332
        Me.SplitContainer6.TabIndex = 3
        '
        'DGV_extensions
        '
        Me.DGV_extensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_extensions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_extensions.Location = New System.Drawing.Point(0, 0)
        Me.DGV_extensions.Name = "DGV_extensions"
        Me.DGV_extensions.Size = New System.Drawing.Size(409, 332)
        Me.DGV_extensions.TabIndex = 0
        '
        'CMB_extensionType
        '
        Me.CMB_extensionType.FormattingEnabled = True
        Me.CMB_extensionType.Location = New System.Drawing.Point(81, 6)
        Me.CMB_extensionType.Name = "CMB_extensionType"
        Me.CMB_extensionType.Size = New System.Drawing.Size(68, 21)
        Me.CMB_extensionType.TabIndex = 4
        '
        'TXT_extension
        '
        Me.TXT_extension.Location = New System.Drawing.Point(155, 6)
        Me.TXT_extension.Name = "TXT_extension"
        Me.TXT_extension.Size = New System.Drawing.Size(100, 20)
        Me.TXT_extension.TabIndex = 3
        '
        'BTN_delExtension
        '
        Me.BTN_delExtension.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_delExtension.Location = New System.Drawing.Point(334, 0)
        Me.BTN_delExtension.Name = "BTN_delExtension"
        Me.BTN_delExtension.Size = New System.Drawing.Size(75, 30)
        Me.BTN_delExtension.TabIndex = 1
        Me.BTN_delExtension.Text = "Supprimer"
        Me.BTN_delExtension.UseVisualStyleBackColor = True
        '
        'BTN_addExtension
        '
        Me.BTN_addExtension.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_addExtension.Location = New System.Drawing.Point(0, 0)
        Me.BTN_addExtension.Name = "BTN_addExtension"
        Me.BTN_addExtension.Size = New System.Drawing.Size(75, 30)
        Me.BTN_addExtension.TabIndex = 0
        Me.BTN_addExtension.Text = "Ajouter"
        Me.BTN_addExtension.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 392)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Options"
        Me.Text = " "
        CType(Me.DGV_poles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TAB_general.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TAB_poles.ResumeLayout(False)
        Me.TAB_projets.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DGV_projet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_fonctions.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.DGV_fonctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_utilisateurs.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.DGV_utilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_types.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.DGV_types, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_extensions.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.Panel2.PerformLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.DGV_extensions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_poles As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BTN_delPole As System.Windows.Forms.Button
    Friend WithEvents BTN_addPole As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TAB_general As System.Windows.Forms.TabPage
    Friend WithEvents TAB_poles As System.Windows.Forms.TabPage
    Friend WithEvents TAB_projets As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGV_projet As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_delProjet As System.Windows.Forms.Button
    Friend WithEvents BTN_addProject As System.Windows.Forms.Button
    Friend WithEvents TAB_fonctions As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGV_fonctions As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_delFonction As System.Windows.Forms.Button
    Friend WithEvents BTN_addFonction As System.Windows.Forms.Button
    Friend WithEvents TAB_utilisateurs As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGV_utilisateurs As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_delUtilisateur As System.Windows.Forms.Button
    Friend WithEvents BTN_addUtilisateur As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPathFolderServer As System.Windows.Forms.Button
    Friend WithEvents ButtonPathBdd As System.Windows.Forms.Button
    Friend WithEvents TextBoxPathFolderServer As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPathBdd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TXT_utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents TXT_pole As System.Windows.Forms.TextBox
    Friend WithEvents TXT_projet As System.Windows.Forms.TextBox
    Friend WithEvents TXT_fonction As System.Windows.Forms.TextBox
    Friend WithEvents CMB_projetPole As System.Windows.Forms.ComboBox
    Friend WithEvents CMB_fonctionPole As System.Windows.Forms.ComboBox
    Friend WithEvents FileBrowserDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CMB_fonctionProjet As System.Windows.Forms.ComboBox
    Friend WithEvents TAB_types As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGV_types As System.Windows.Forms.DataGridView
    Friend WithEvents TXT_type As System.Windows.Forms.TextBox
    Friend WithEvents BTN_delType As System.Windows.Forms.Button
    Friend WithEvents BTN_addType As System.Windows.Forms.Button
    Friend WithEvents TAB_extensions As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGV_extensions As System.Windows.Forms.DataGridView
    Friend WithEvents CMB_extensionType As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_extension As System.Windows.Forms.TextBox
    Friend WithEvents BTN_delExtension As System.Windows.Forms.Button
    Friend WithEvents BTN_addExtension As System.Windows.Forms.Button
End Class
