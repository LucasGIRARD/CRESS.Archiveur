<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Save
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
        Me.ComboBoxFonction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxPole = New System.Windows.Forms.ComboBox()
        Me.CheckedListBoxUsers = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxProjet = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxFileOverwrite = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ComboBoxFonction
        '
        Me.ComboBoxFonction.FormattingEnabled = True
        Me.ComboBoxFonction.Location = New System.Drawing.Point(33, 234)
        Me.ComboBoxFonction.Name = "ComboBoxFonction"
        Me.ComboBoxFonction.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFonction.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fonction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pôle"
        '
        'ComboBoxPole
        '
        Me.ComboBoxPole.FormattingEnabled = True
        Me.ComboBoxPole.Location = New System.Drawing.Point(33, 150)
        Me.ComboBoxPole.Name = "ComboBoxPole"
        Me.ComboBoxPole.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPole.TabIndex = 6
        '
        'CheckedListBoxUsers
        '
        Me.CheckedListBoxUsers.FormattingEnabled = True
        Me.CheckedListBoxUsers.Location = New System.Drawing.Point(34, 260)
        Me.CheckedListBoxUsers.Name = "CheckedListBoxUsers"
        Me.CheckedListBoxUsers.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBoxUsers.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Projet"
        '
        'ComboBoxProjet
        '
        Me.ComboBoxProjet.FormattingEnabled = True
        Me.ComboBoxProjet.Location = New System.Drawing.Point(33, 191)
        Me.ComboBoxProjet.Name = "ComboBoxProjet"
        Me.ComboBoxProjet.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProjet.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fichier en cours d'enregistrement :"
        '
        'LabelFile
        '
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Location = New System.Drawing.Point(12, 35)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(72, 13)
        Me.LabelFile.TabIndex = 1
        Me.LabelFile.Text = "Aucun Fichier"
        Me.LabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Erreur : un ou plusieurs champs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "n'est pas rempli!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxFileOverwrite
        '
        Me.CheckBoxFileOverwrite.AutoSize = True
        Me.CheckBoxFileOverwrite.Location = New System.Drawing.Point(33, 99)
        Me.CheckBoxFileOverwrite.Name = "CheckBoxFileOverwrite"
        Me.CheckBoxFileOverwrite.Size = New System.Drawing.Size(141, 17)
        Me.CheckBoxFileOverwrite.TabIndex = 2
        Me.CheckBoxFileOverwrite.Text = "Ecrasé si le fichier existe"
        Me.CheckBoxFileOverwrite.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 411)
        Me.Controls.Add(Me.CheckBoxFileOverwrite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelFile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxProjet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBoxUsers)
        Me.Controls.Add(Me.ComboBoxPole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxFonction)
        Me.Name = "Save"
        Me.Text = "Save"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxFonction As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPole As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBoxUsers As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxProjet As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelFile As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFileOverwrite As System.Windows.Forms.CheckBox
End Class
