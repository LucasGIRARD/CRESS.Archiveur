<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDisplayCustomDate = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisplayCustomSystem = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisplayCustomFiles = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisplayCustomUsers = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisplayCustomLeft = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDisplayCustomRight = New System.Windows.Forms.CheckBox()
        Me.RadioButtonDisplayCustom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDisplayLastUse = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDisplayRetractAll = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDisplayDeployAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonPathFolderSave = New System.Windows.Forms.Button()
        Me.ButtonPathFolderServer = New System.Windows.Forms.Button()
        Me.ButtonPathBdd = New System.Windows.Forms.Button()
        Me.TextBoxPathFolderSave = New System.Windows.Forms.TextBox()
        Me.TextBoxPathFolderServer = New System.Windows.Forms.TextBox()
        Me.TextBoxPathBdd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileBrowserDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(414, 225)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomDate)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomSystem)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomFiles)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomUsers)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomLeft)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisplayCustomRight)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDisplayCustom)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDisplayLastUse)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDisplayRetractAll)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDisplayDeployAll)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 258)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnaliser L'affichage"
        '
        'CheckBoxDisplayCustomDate
        '
        Me.CheckBoxDisplayCustomDate.AutoSize = True
        Me.CheckBoxDisplayCustomDate.Location = New System.Drawing.Point(44, 235)
        Me.CheckBoxDisplayCustomDate.Name = "CheckBoxDisplayCustomDate"
        Me.CheckBoxDisplayCustomDate.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxDisplayCustomDate.TabIndex = 9
        Me.CheckBoxDisplayCustomDate.Text = "Date"
        Me.CheckBoxDisplayCustomDate.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayCustomSystem
        '
        Me.CheckBoxDisplayCustomSystem.AutoSize = True
        Me.CheckBoxDisplayCustomSystem.Location = New System.Drawing.Point(44, 212)
        Me.CheckBoxDisplayCustomSystem.Name = "CheckBoxDisplayCustomSystem"
        Me.CheckBoxDisplayCustomSystem.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxDisplayCustomSystem.TabIndex = 8
        Me.CheckBoxDisplayCustomSystem.Text = "Système"
        Me.CheckBoxDisplayCustomSystem.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayCustomFiles
        '
        Me.CheckBoxDisplayCustomFiles.AutoSize = True
        Me.CheckBoxDisplayCustomFiles.Location = New System.Drawing.Point(44, 189)
        Me.CheckBoxDisplayCustomFiles.Name = "CheckBoxDisplayCustomFiles"
        Me.CheckBoxDisplayCustomFiles.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxDisplayCustomFiles.TabIndex = 7
        Me.CheckBoxDisplayCustomFiles.Text = "Fichiers"
        Me.CheckBoxDisplayCustomFiles.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayCustomUsers
        '
        Me.CheckBoxDisplayCustomUsers.AutoSize = True
        Me.CheckBoxDisplayCustomUsers.Location = New System.Drawing.Point(44, 164)
        Me.CheckBoxDisplayCustomUsers.Name = "CheckBoxDisplayCustomUsers"
        Me.CheckBoxDisplayCustomUsers.Size = New System.Drawing.Size(77, 17)
        Me.CheckBoxDisplayCustomUsers.TabIndex = 6
        Me.CheckBoxDisplayCustomUsers.Text = "Uitlisateurs"
        Me.CheckBoxDisplayCustomUsers.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayCustomLeft
        '
        Me.CheckBoxDisplayCustomLeft.AutoSize = True
        Me.CheckBoxDisplayCustomLeft.Location = New System.Drawing.Point(29, 141)
        Me.CheckBoxDisplayCustomLeft.Name = "CheckBoxDisplayCustomLeft"
        Me.CheckBoxDisplayCustomLeft.Size = New System.Drawing.Size(143, 17)
        Me.CheckBoxDisplayCustomLeft.TabIndex = 5
        Me.CheckBoxDisplayCustomLeft.Text = "Filtres (panneau gauche)"
        Me.CheckBoxDisplayCustomLeft.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayCustomRight
        '
        Me.CheckBoxDisplayCustomRight.AutoSize = True
        Me.CheckBoxDisplayCustomRight.Location = New System.Drawing.Point(29, 118)
        Me.CheckBoxDisplayCustomRight.Name = "CheckBoxDisplayCustomRight"
        Me.CheckBoxDisplayCustomRight.Size = New System.Drawing.Size(172, 17)
        Me.CheckBoxDisplayCustomRight.TabIndex = 4
        Me.CheckBoxDisplayCustomRight.Text = "Arborescence (panneau droite)"
        Me.CheckBoxDisplayCustomRight.UseVisualStyleBackColor = True
        '
        'RadioButtonDisplayCustom
        '
        Me.RadioButtonDisplayCustom.AutoSize = True
        Me.RadioButtonDisplayCustom.Location = New System.Drawing.Point(9, 90)
        Me.RadioButtonDisplayCustom.Name = "RadioButtonDisplayCustom"
        Me.RadioButtonDisplayCustom.Size = New System.Drawing.Size(138, 17)
        Me.RadioButtonDisplayCustom.TabIndex = 3
        Me.RadioButtonDisplayCustom.TabStop = True
        Me.RadioButtonDisplayCustom.Text = "Personnaliser (afficher) :"
        Me.RadioButtonDisplayCustom.UseVisualStyleBackColor = True
        '
        'RadioButtonDisplayLastUse
        '
        Me.RadioButtonDisplayLastUse.AutoSize = True
        Me.RadioButtonDisplayLastUse.Location = New System.Drawing.Point(9, 67)
        Me.RadioButtonDisplayLastUse.Name = "RadioButtonDisplayLastUse"
        Me.RadioButtonDisplayLastUse.Size = New System.Drawing.Size(204, 17)
        Me.RadioButtonDisplayLastUse.TabIndex = 2
        Me.RadioButtonDisplayLastUse.TabStop = True
        Me.RadioButtonDisplayLastUse.Text = "afficher comme à la dernière utilisation"
        Me.RadioButtonDisplayLastUse.UseVisualStyleBackColor = True
        '
        'RadioButtonDisplayRetractAll
        '
        Me.RadioButtonDisplayRetractAll.AutoSize = True
        Me.RadioButtonDisplayRetractAll.Location = New System.Drawing.Point(9, 43)
        Me.RadioButtonDisplayRetractAll.Name = "RadioButtonDisplayRetractAll"
        Me.RadioButtonDisplayRetractAll.Size = New System.Drawing.Size(78, 17)
        Me.RadioButtonDisplayRetractAll.TabIndex = 1
        Me.RadioButtonDisplayRetractAll.TabStop = True
        Me.RadioButtonDisplayRetractAll.Text = "Tout replier"
        Me.RadioButtonDisplayRetractAll.UseVisualStyleBackColor = True
        '
        'RadioButtonDisplayDeployAll
        '
        Me.RadioButtonDisplayDeployAll.AutoSize = True
        Me.RadioButtonDisplayDeployAll.Location = New System.Drawing.Point(9, 19)
        Me.RadioButtonDisplayDeployAll.Name = "RadioButtonDisplayDeployAll"
        Me.RadioButtonDisplayDeployAll.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonDisplayDeployAll.TabIndex = 0
        Me.RadioButtonDisplayDeployAll.TabStop = True
        Me.RadioButtonDisplayDeployAll.Text = "Tout déployer"
        Me.RadioButtonDisplayDeployAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonPathFolderSave)
        Me.GroupBox3.Controls.Add(Me.ButtonPathFolderServer)
        Me.GroupBox3.Controls.Add(Me.ButtonPathBdd)
        Me.GroupBox3.Controls.Add(Me.TextBoxPathFolderSave)
        Me.GroupBox3.Controls.Add(Me.TextBoxPathFolderServer)
        Me.GroupBox3.Controls.Add(Me.TextBoxPathBdd)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(231, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 216)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Les emplacements"
        '
        'ButtonPathFolderSave
        '
        Me.ButtonPathFolderSave.Location = New System.Drawing.Point(243, 75)
        Me.ButtonPathFolderSave.Name = "ButtonPathFolderSave"
        Me.ButtonPathFolderSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPathFolderSave.TabIndex = 8
        Me.ButtonPathFolderSave.Text = "Parcourir…"
        Me.ButtonPathFolderSave.UseVisualStyleBackColor = True
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
        'TextBoxPathFolderSave
        '
        Me.TextBoxPathFolderSave.Location = New System.Drawing.Point(137, 77)
        Me.TextBoxPathFolderSave.Name = "TextBoxPathFolderSave"
        Me.TextBoxPathFolderSave.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPathFolderSave.TabIndex = 5
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Dossier de sauvegarde : "
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
        'Options
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(572, 266)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDisplayLastUse As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDisplayRetractAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDisplayDeployAll As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxDisplayCustomUsers As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisplayCustomLeft As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisplayCustomRight As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButtonDisplayCustom As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxDisplayCustomDate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisplayCustomSystem As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisplayCustomFiles As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPathFolderSave As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPathFolderServer As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPathBdd As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPathFolderSave As System.Windows.Forms.Button
    Friend WithEvents ButtonPathFolderServer As System.Windows.Forms.Button
    Friend WithEvents ButtonPathBdd As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FileBrowserDialog As OpenFileDialog
End Class
