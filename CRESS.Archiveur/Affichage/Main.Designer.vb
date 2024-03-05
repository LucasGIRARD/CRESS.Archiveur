<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderModifyDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenommerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckedListBoxUsers = New System.Windows.Forms.CheckedListBox()
        Me.RadioButtonUsersByReverse = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUsersBy = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUsersNo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRetractUsers = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxProjet = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPole = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFonction = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonRetractFiles = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBoxFileType = New System.Windows.Forms.ComboBox()
        Me.CheckBoxFileType = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystemHiddenFile = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRetractSystem = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePickerModifyEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerModifyStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerCreateEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerCreateStart = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxDateModify = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDateCreate = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonRetractDate = New System.Windows.Forms.Button()
        Me.ExpTree1 = New ExpTreeLib.ExpTree()
        Me.ButtonRetractLeft = New System.Windows.Forms.Button()
        Me.ButtonRetractRight = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.LabelItem = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxListViewDisplay = New System.Windows.Forms.ComboBox()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BTN_bottomPanel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListView, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExpTree1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRetractLeft, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRetractRight, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1278, 821)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderName, Me.ColumnHeaderAttributes, Me.ColumnHeaderSize, Me.ColumnHeaderType, Me.ColumnHeaderModifyDate})
        Me.ListView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView.Location = New System.Drawing.Point(233, 3)
        Me.ListView.MinimumSize = New System.Drawing.Size(250, 4)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(658, 815)
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Name"
        '
        'ColumnHeaderAttributes
        '
        Me.ColumnHeaderAttributes.Text = "Attributes"
        '
        'ColumnHeaderSize
        '
        Me.ColumnHeaderSize.Text = "Size"
        '
        'ColumnHeaderType
        '
        Me.ColumnHeaderType.Text = "Type"
        '
        'ColumnHeaderModifyDate
        '
        Me.ColumnHeaderModifyDate.Text = "Modified"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenommerToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(134, 48)
        '
        'RenommerToolStripMenuItem
        '
        Me.RenommerToolStripMenuItem.Name = "RenommerToolStripMenuItem"
        Me.RenommerToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RenommerToolStripMenuItem.Text = "Renommer"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(199, 815)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckedListBoxUsers)
        Me.Panel1.Controls.Add(Me.RadioButtonUsersByReverse)
        Me.Panel1.Controls.Add(Me.RadioButtonUsersBy)
        Me.Panel1.Controls.Add(Me.RadioButtonUsersNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonRetractUsers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 224)
        Me.Panel1.TabIndex = 0
        '
        'CheckedListBoxUsers
        '
        Me.CheckedListBoxUsers.FormattingEnabled = True
        Me.CheckedListBoxUsers.Location = New System.Drawing.Point(41, 113)
        Me.CheckedListBoxUsers.Name = "CheckedListBoxUsers"
        Me.CheckedListBoxUsers.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBoxUsers.TabIndex = 5
        '
        'RadioButtonUsersByReverse
        '
        Me.RadioButtonUsersByReverse.AutoSize = True
        Me.RadioButtonUsersByReverse.Location = New System.Drawing.Point(41, 89)
        Me.RadioButtonUsersByReverse.Name = "RadioButtonUsersByReverse"
        Me.RadioButtonUsersByReverse.Size = New System.Drawing.Size(106, 17)
        Me.RadioButtonUsersByReverse.TabIndex = 4
        Me.RadioButtonUsersByReverse.Text = "utilisateur inversé"
        Me.RadioButtonUsersByReverse.UseVisualStyleBackColor = True
        '
        'RadioButtonUsersBy
        '
        Me.RadioButtonUsersBy.AutoSize = True
        Me.RadioButtonUsersBy.Location = New System.Drawing.Point(41, 66)
        Me.RadioButtonUsersBy.Name = "RadioButtonUsersBy"
        Me.RadioButtonUsersBy.Size = New System.Drawing.Size(87, 17)
        Me.RadioButtonUsersBy.TabIndex = 3
        Me.RadioButtonUsersBy.Text = "par utilisateur"
        Me.RadioButtonUsersBy.UseVisualStyleBackColor = True
        '
        'RadioButtonUsersNo
        '
        Me.RadioButtonUsersNo.AutoSize = True
        Me.RadioButtonUsersNo.Checked = True
        Me.RadioButtonUsersNo.Location = New System.Drawing.Point(41, 43)
        Me.RadioButtonUsersNo.Name = "RadioButtonUsersNo"
        Me.RadioButtonUsersNo.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonUsersNo.TabIndex = 2
        Me.RadioButtonUsersNo.TabStop = True
        Me.RadioButtonUsersNo.Text = "aucun"
        Me.RadioButtonUsersNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtres Utilisateurs"
        '
        'ButtonRetractUsers
        '
        Me.ButtonRetractUsers.FlatAppearance.BorderSize = 0
        Me.ButtonRetractUsers.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRetractUsers.Name = "ButtonRetractUsers"
        Me.ButtonRetractUsers.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRetractUsers.TabIndex = 0
        Me.ButtonRetractUsers.Text = "-"
        Me.ButtonRetractUsers.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ComboBoxProjet)
        Me.Panel2.Controls.Add(Me.ComboBoxPole)
        Me.Panel2.Controls.Add(Me.ComboBoxFonction)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ButtonRetractFiles)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 174)
        Me.Panel2.TabIndex = 1
        '
        'ComboBoxProjet
        '
        Me.ComboBoxProjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProjet.FormattingEnabled = True
        Me.ComboBoxProjet.Location = New System.Drawing.Point(40, 100)
        Me.ComboBoxProjet.Name = "ComboBoxProjet"
        Me.ComboBoxProjet.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProjet.TabIndex = 7
        '
        'ComboBoxPole
        '
        Me.ComboBoxPole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPole.FormattingEnabled = True
        Me.ComboBoxPole.Location = New System.Drawing.Point(40, 60)
        Me.ComboBoxPole.Name = "ComboBoxPole"
        Me.ComboBoxPole.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPole.TabIndex = 6
        '
        'ComboBoxFonction
        '
        Me.ComboBoxFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFonction.FormattingEnabled = True
        Me.ComboBoxFonction.Location = New System.Drawing.Point(40, 140)
        Me.ComboBoxFonction.Name = "ComboBoxFonction"
        Me.ComboBoxFonction.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFonction.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Projet :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pôle : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filtres Fichiers"
        '
        'ButtonRetractFiles
        '
        Me.ButtonRetractFiles.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRetractFiles.Name = "ButtonRetractFiles"
        Me.ButtonRetractFiles.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRetractFiles.TabIndex = 0
        Me.ButtonRetractFiles.Text = "-"
        Me.ButtonRetractFiles.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fonction :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBoxFileType)
        Me.Panel3.Controls.Add(Me.CheckBoxFileType)
        Me.Panel3.Controls.Add(Me.CheckBoxSystemHiddenFile)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ButtonRetractSystem)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(4, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 154)
        Me.Panel3.TabIndex = 2
        '
        'ComboBoxFileType
        '
        Me.ComboBoxFileType.Enabled = False
        Me.ComboBoxFileType.FormattingEnabled = True
        Me.ComboBoxFileType.Location = New System.Drawing.Point(40, 120)
        Me.ComboBoxFileType.Name = "ComboBoxFileType"
        Me.ComboBoxFileType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFileType.TabIndex = 6
        '
        'CheckBoxFileType
        '
        Me.CheckBoxFileType.AutoSize = True
        Me.CheckBoxFileType.Location = New System.Drawing.Point(40, 97)
        Me.CheckBoxFileType.Name = "CheckBoxFileType"
        Me.CheckBoxFileType.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxFileType.TabIndex = 4
        Me.CheckBoxFileType.Text = "Type de fichier : "
        Me.CheckBoxFileType.UseVisualStyleBackColor = True
        '
        'CheckBoxSystemHiddenFile
        '
        Me.CheckBoxSystemHiddenFile.AutoSize = True
        Me.CheckBoxSystemHiddenFile.Location = New System.Drawing.Point(40, 73)
        Me.CheckBoxSystemHiddenFile.Name = "CheckBoxSystemHiddenFile"
        Me.CheckBoxSystemHiddenFile.Size = New System.Drawing.Size(100, 17)
        Me.CheckBoxSystemHiddenFile.TabIndex = 3
        Me.CheckBoxSystemHiddenFile.Text = "Fichiers cachés"
        Me.CheckBoxSystemHiddenFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Filtres systeme"
        '
        'ButtonRetractSystem
        '
        Me.ButtonRetractSystem.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRetractSystem.Name = "ButtonRetractSystem"
        Me.ButtonRetractSystem.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRetractSystem.TabIndex = 0
        Me.ButtonRetractSystem.Text = "-"
        Me.ButtonRetractSystem.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.DateTimePickerModifyEnd)
        Me.Panel4.Controls.Add(Me.DateTimePickerModifyStart)
        Me.Panel4.Controls.Add(Me.DateTimePickerCreateEnd)
        Me.Panel4.Controls.Add(Me.DateTimePickerCreateStart)
        Me.Panel4.Controls.Add(Me.CheckBoxDateModify)
        Me.Panel4.Controls.Add(Me.CheckBoxDateCreate)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.ButtonRetractDate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(4, 577)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(191, 194)
        Me.Panel4.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Au"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Du"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Au"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Du"
        '
        'DateTimePickerModifyEnd
        '
        Me.DateTimePickerModifyEnd.Enabled = False
        Me.DateTimePickerModifyEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerModifyEnd.Location = New System.Drawing.Point(76, 171)
        Me.DateTimePickerModifyEnd.Name = "DateTimePickerModifyEnd"
        Me.DateTimePickerModifyEnd.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePickerModifyEnd.TabIndex = 7
        '
        'DateTimePickerModifyStart
        '
        Me.DateTimePickerModifyStart.Enabled = False
        Me.DateTimePickerModifyStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerModifyStart.Location = New System.Drawing.Point(76, 147)
        Me.DateTimePickerModifyStart.Name = "DateTimePickerModifyStart"
        Me.DateTimePickerModifyStart.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePickerModifyStart.TabIndex = 6
        '
        'DateTimePickerCreateEnd
        '
        Me.DateTimePickerCreateEnd.Enabled = False
        Me.DateTimePickerCreateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerCreateEnd.Location = New System.Drawing.Point(76, 98)
        Me.DateTimePickerCreateEnd.Name = "DateTimePickerCreateEnd"
        Me.DateTimePickerCreateEnd.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePickerCreateEnd.TabIndex = 5
        '
        'DateTimePickerCreateStart
        '
        Me.DateTimePickerCreateStart.Enabled = False
        Me.DateTimePickerCreateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerCreateStart.Location = New System.Drawing.Point(76, 72)
        Me.DateTimePickerCreateStart.Name = "DateTimePickerCreateStart"
        Me.DateTimePickerCreateStart.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePickerCreateStart.TabIndex = 4
        '
        'CheckBoxDateModify
        '
        Me.CheckBoxDateModify.AutoSize = True
        Me.CheckBoxDateModify.Location = New System.Drawing.Point(40, 122)
        Me.CheckBoxDateModify.Name = "CheckBoxDateModify"
        Me.CheckBoxDateModify.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxDateModify.TabIndex = 3
        Me.CheckBoxDateModify.Text = "Modification : "
        Me.CheckBoxDateModify.UseVisualStyleBackColor = True
        '
        'CheckBoxDateCreate
        '
        Me.CheckBoxDateCreate.AutoSize = True
        Me.CheckBoxDateCreate.Location = New System.Drawing.Point(40, 47)
        Me.CheckBoxDateCreate.Name = "CheckBoxDateCreate"
        Me.CheckBoxDateCreate.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxDateCreate.TabIndex = 2
        Me.CheckBoxDateCreate.Text = "Création : "
        Me.CheckBoxDateCreate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Filtres date"
        '
        'ButtonRetractDate
        '
        Me.ButtonRetractDate.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRetractDate.Name = "ButtonRetractDate"
        Me.ButtonRetractDate.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRetractDate.TabIndex = 0
        Me.ButtonRetractDate.Text = "-"
        Me.ButtonRetractDate.UseVisualStyleBackColor = True
        '
        'ExpTree1
        '
        Me.ExpTree1.AllowDrop = True
        Me.ExpTree1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExpTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpTree1.Location = New System.Drawing.Point(922, 3)
        Me.ExpTree1.Name = "ExpTree1"
        Me.ExpTree1.ShowRootLines = False
        Me.ExpTree1.Size = New System.Drawing.Size(353, 815)
        Me.ExpTree1.TabIndex = 2
        '
        'ButtonRetractLeft
        '
        Me.ButtonRetractLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRetractLeft.Location = New System.Drawing.Point(208, 3)
        Me.ButtonRetractLeft.Name = "ButtonRetractLeft"
        Me.ButtonRetractLeft.Size = New System.Drawing.Size(19, 815)
        Me.ButtonRetractLeft.TabIndex = 3
        Me.ButtonRetractLeft.Text = "<"
        Me.ButtonRetractLeft.UseVisualStyleBackColor = True
        '
        'ButtonRetractRight
        '
        Me.ButtonRetractRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRetractRight.Location = New System.Drawing.Point(897, 3)
        Me.ButtonRetractRight.Name = "ButtonRetractRight"
        Me.ButtonRetractRight.Size = New System.Drawing.Size(19, 815)
        Me.ButtonRetractRight.TabIndex = 4
        Me.ButtonRetractRight.Text = ">"
        Me.ButtonRetractRight.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(85, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Item(s)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Item(s)"
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(66, 0)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(13, 13)
        Me.LabelTotalItem.TabIndex = 1
        Me.LabelTotalItem.Text = "0"
        '
        'LabelItem
        '
        Me.LabelItem.AutoSize = True
        Me.LabelItem.Location = New System.Drawing.Point(3, 0)
        Me.LabelItem.Name = "LabelItem"
        Me.LabelItem.Size = New System.Drawing.Size(13, 13)
        Me.LabelItem.TabIndex = 0
        Me.LabelItem.Text = "0"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxListViewDisplay, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonOptions, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 855)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1278, 32)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ComboBoxListViewDisplay
        '
        Me.ComboBoxListViewDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ComboBoxListViewDisplay.FormattingEnabled = True
        Me.ComboBoxListViewDisplay.Items.AddRange(New Object() {"Miniatures", "Mosaiques", "Icônes", "Liste", "Détails"})
        Me.ComboBoxListViewDisplay.Location = New System.Drawing.Point(1154, 5)
        Me.ComboBoxListViewDisplay.Name = "ComboBoxListViewDisplay"
        Me.ComboBoxListViewDisplay.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxListViewDisplay.TabIndex = 0
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonOptions.Location = New System.Drawing.Point(3, 4)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOptions.TabIndex = 0
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.LabelItem)
        Me.Panel5.Controls.Add(Me.LabelTotalItem)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(429, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(420, 26)
        Me.Panel5.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem, Me.OuvrirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.BTN_bottomPanel, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1284, 890)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'BTN_bottomPanel
        '
        Me.BTN_bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_bottomPanel.Location = New System.Drawing.Point(3, 830)
        Me.BTN_bottomPanel.Name = "BTN_bottomPanel"
        Me.BTN_bottomPanel.Size = New System.Drawing.Size(1278, 19)
        Me.BTN_bottomPanel.TabIndex = 5
        Me.BTN_bottomPanel.Text = "-"
        Me.BTN_bottomPanel.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.ClientSize = New System.Drawing.Size(1284, 890)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 300)
        Me.Name = "Main"
        Me.Text = "CRESS-BN - Archiveur"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonOptions As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents ExpTree1 As ExpTreeLib.ExpTree
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRetractUsers As System.Windows.Forms.Button
    Friend WithEvents ButtonRetractFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonRetractSystem As System.Windows.Forms.Button
    Friend WithEvents ButtonRetractDate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBoxUsers As System.Windows.Forms.CheckedListBox
    Friend WithEvents RadioButtonUsersByReverse As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUsersBy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUsersNo As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxProjet As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPole As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxFonction As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFileType As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSystemHiddenFile As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxFileType As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerModifyEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerModifyStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCreateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCreateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxDateModify As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDateCreate As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelTotalItem As System.Windows.Forms.Label
    Friend WithEvents LabelItem As System.Windows.Forms.Label
    Friend WithEvents ComboBoxListViewDisplay As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ButtonRetractLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonRetractRight As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RenommerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ColumnHeaderName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderAttributes As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderModifyDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BTN_bottomPanel As Button
End Class
