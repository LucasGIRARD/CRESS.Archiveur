<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.configuration = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckedListBoxUsers = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxFonction = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProjet = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPole = New System.Windows.Forms.ComboBox()
        Me.BTN_toUnOrdered = New System.Windows.Forms.Button()
        Me.BTN_toOrdered = New System.Windows.Forms.Button()
        Me.ExpTree1 = New ExpTreeLib.ExpTree()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExpTree1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListView1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 565)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.configuration)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CheckedListBoxUsers)
        Me.Panel1.Controls.Add(Me.ComboBoxFonction)
        Me.Panel1.Controls.Add(Me.ComboBoxProjet)
        Me.Panel1.Controls.Add(Me.ComboBoxPole)
        Me.Panel1.Controls.Add(Me.BTN_toUnOrdered)
        Me.Panel1.Controls.Add(Me.BTN_toOrdered)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(319, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 559)
        Me.Panel1.TabIndex = 2
        '
        'configuration
        '
        Me.configuration.Location = New System.Drawing.Point(63, 520)
        Me.configuration.Name = "configuration"
        Me.configuration.Size = New System.Drawing.Size(75, 23)
        Me.configuration.TabIndex = 18
        Me.configuration.Text = "Configurer"
        Me.configuration.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Utilisateur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fonction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Projet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pôle"
        '
        'CheckedListBoxUsers
        '
        Me.CheckedListBoxUsers.FormattingEnabled = True
        Me.CheckedListBoxUsers.Location = New System.Drawing.Point(39, 177)
        Me.CheckedListBoxUsers.Name = "CheckedListBoxUsers"
        Me.CheckedListBoxUsers.Size = New System.Drawing.Size(121, 109)
        Me.CheckedListBoxUsers.TabIndex = 6
        '
        'ComboBoxFonction
        '
        Me.ComboBoxFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFonction.FormattingEnabled = True
        Me.ComboBoxFonction.Location = New System.Drawing.Point(39, 137)
        Me.ComboBoxFonction.Name = "ComboBoxFonction"
        Me.ComboBoxFonction.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFonction.TabIndex = 5
        '
        'ComboBoxProjet
        '
        Me.ComboBoxProjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProjet.FormattingEnabled = True
        Me.ComboBoxProjet.Location = New System.Drawing.Point(39, 97)
        Me.ComboBoxProjet.Name = "ComboBoxProjet"
        Me.ComboBoxProjet.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProjet.TabIndex = 4
        '
        'ComboBoxPole
        '
        Me.ComboBoxPole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPole.FormattingEnabled = True
        Me.ComboBoxPole.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxPole.Location = New System.Drawing.Point(39, 57)
        Me.ComboBoxPole.Name = "ComboBoxPole"
        Me.ComboBoxPole.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPole.TabIndex = 3
        '
        'BTN_toUnOrdered
        '
        Me.BTN_toUnOrdered.Location = New System.Drawing.Point(63, 345)
        Me.BTN_toUnOrdered.Name = "BTN_toUnOrdered"
        Me.BTN_toUnOrdered.Size = New System.Drawing.Size(75, 23)
        Me.BTN_toUnOrdered.TabIndex = 1
        Me.BTN_toUnOrdered.Text = "<-"
        Me.BTN_toUnOrdered.UseVisualStyleBackColor = True
        '
        'BTN_toOrdered
        '
        Me.BTN_toOrdered.Location = New System.Drawing.Point(63, 316)
        Me.BTN_toOrdered.Name = "BTN_toOrdered"
        Me.BTN_toOrdered.Size = New System.Drawing.Size(75, 23)
        Me.BTN_toOrdered.TabIndex = 0
        Me.BTN_toOrdered.Text = "->"
        Me.BTN_toOrdered.UseVisualStyleBackColor = True
        '
        'ExpTree1
        '
        Me.ExpTree1.AllowDrop = True
        Me.ExpTree1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExpTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpTree1.Location = New System.Drawing.Point(3, 3)
        Me.ExpTree1.Name = "ExpTree1"
        Me.ExpTree1.ShowRootLines = False
        Me.ExpTree1.Size = New System.Drawing.Size(310, 559)
        Me.ExpTree1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(519, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(310, 559)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 565)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Main"
        Me.Text = "CRESS-BN - Archiveur"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExpTree1 As ExpTreeLib.ExpTree
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBoxUsers As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBoxFonction As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProjet As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPole As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_toUnOrdered As System.Windows.Forms.Button
    Friend WithEvents BTN_toOrdered As System.Windows.Forms.Button
    Friend WithEvents configuration As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
