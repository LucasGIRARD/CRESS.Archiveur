Public Class Options

#Region "public vars"
    Public DisplayType As String
    Public DisplayPanelLeft As Boolean
    Public DisplayPanelRight As Boolean
    Public DisplayPanelUsers As Boolean
    Public DisplayPanelFiles As Boolean
    Public DisplayPanelSystem As Boolean
    Public DisplayPanelDate As Boolean
    Public DisplayPanelBottom As Boolean = True
    Public ConnectionActivate As Boolean
    Public ConnectionLogin As String
    Public ConnectionPass As String
    Public PathBDD As String
    Public PathServer As String
    Public PathSave As String
#End Region


#Region "private vars"
    Private PathFichierXML As String = IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location) & "\Options.xml"
#End Region

    Public Sub New()
        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ReadXml()
        InitForm()
    End Sub

#Region "Form function"

    Private Sub InitForm()
        RefreshForm()
        RadioButton_Selected()
    End Sub

    Private Sub RefreshForm()
        CheckBoxDisplayCustomLeft.Checked = DisplayPanelLeft
        CheckBoxDisplayCustomRight.Checked = DisplayPanelRight
        CheckBoxDisplayCustomUsers.Checked = DisplayPanelUsers
        CheckBoxDisplayCustomFiles.Checked = DisplayPanelFiles
        CheckBoxDisplayCustomSystem.Checked = DisplayPanelSystem
        CheckBoxDisplayCustomDate.Checked = DisplayPanelDate
        TextBoxPathBdd.Text = PathBDD
        FolderBrowserDialog.SelectedPath = PathBDD
        TextBoxPathFolderServer.Text = PathServer
        TextBoxPathFolderSave.Text = PathSave

        If DisplayType = "DeployAll" Then
            RadioButtonDisplayDeployAll.Checked = True
        ElseIf DisplayType = "RetractAll" Then
            RadioButtonDisplayRetractAll.Checked = True
        ElseIf DisplayType = "LastUse" Then
            RadioButtonDisplayLastUse.Checked = True
        ElseIf DisplayType = "Custom" Then
            RadioButtonDisplayCustom.Checked = True
        Else
            MsgBox("bug display fichier xml")
            RadioButtonDisplayDeployAll.Checked = True
        End If
    End Sub

    Private Sub RefreshVars()
        DisplayPanelLeft = CheckBoxDisplayCustomLeft.Checked
        DisplayPanelRight = CheckBoxDisplayCustomRight.Checked
        DisplayPanelUsers = CheckBoxDisplayCustomUsers.Checked
        DisplayPanelFiles = CheckBoxDisplayCustomFiles.Checked
        DisplayPanelSystem = CheckBoxDisplayCustomSystem.Checked
        DisplayPanelDate = CheckBoxDisplayCustomDate.Checked
        PathBDD = TextBoxPathBdd.Text
        PathServer = TextBoxPathFolderServer.Text
        PathSave = TextBoxPathFolderSave.Text
    End Sub

    Private Sub RadioButton_Selected() Handles RadioButtonDisplayCustom.CheckedChanged, RadioButtonDisplayDeployAll.CheckedChanged, RadioButtonDisplayLastUse.CheckedChanged, RadioButtonDisplayRetractAll.CheckedChanged
        If RadioButtonDisplayCustom.Checked = True Then
            CheckBoxDisplayCustomDate.Enabled = True
            CheckBoxDisplayCustomFiles.Enabled = True
            CheckBoxDisplayCustomLeft.Enabled = True
            CheckBoxDisplayCustomRight.Enabled = True
            CheckBoxDisplayCustomSystem.Enabled = True
            CheckBoxDisplayCustomUsers.Enabled = True

            DisplayType = "Custom"
        Else
            CheckBoxDisplayCustomDate.Enabled = False
            CheckBoxDisplayCustomFiles.Enabled = False
            CheckBoxDisplayCustomLeft.Enabled = False
            CheckBoxDisplayCustomRight.Enabled = False
            CheckBoxDisplayCustomSystem.Enabled = False
            CheckBoxDisplayCustomUsers.Enabled = False
        End If


        If RadioButtonDisplayDeployAll.Checked = True Then
            DisplayType = "DeployAll"
        ElseIf RadioButtonDisplayLastUse.Checked = True Then
            DisplayType = "LastUse"
        ElseIf RadioButtonDisplayRetractAll.Checked = True Then
            DisplayType = "RetractAll"
        End If

    End Sub

#End Region

#Region "Button action"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        RefreshVars()
        ModifyXml()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonPathBdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPathBdd.Click
        FileBrowserDialog.FileName = PathBDD
        If FileBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxPathBdd.Text = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub ButtonPathFolderServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPathFolderServer.Click
        FolderBrowserDialog.SelectedPath = PathServer
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxPathFolderServer.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub ButtonPathFolderSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPathFolderSave.Click
        FolderBrowserDialog.SelectedPath = PathSave
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxPathFolderSave.Text = FolderBrowserDialog.SelectedPath
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

                    If node.Attributes("value").InnerText = "Display" Then
                        For Each Childnode In node.ChildNodes

                            If Childnode.Name = "Type" Then
                                DisplayType = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelLeft" Then
                                DisplayPanelLeft = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelRight" Then
                                DisplayPanelRight = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelUsers" Then
                                DisplayPanelUsers = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelFiles" Then
                                DisplayPanelFiles = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelSystem" Then
                                DisplayPanelSystem = Childnode.Attributes("value").InnerText

                            ElseIf Childnode.Name = "PanelDate" Then
                                DisplayPanelDate = Childnode.Attributes("value").InnerText
                            End If

                        Next

                    ElseIf node.Attributes("value").InnerText = "Connect" Then
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
                            ElseIf Childnode.Name = "Save" Then
                                PathSave = Childnode.Attributes("value").InnerText
                            End If

                        Next
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

                If node.Attributes("value").InnerText = "Display" Then
                    For Each Childnode In node.ChildNodes

                        If Childnode.Name = "Type" Then
                            Childnode.Attributes("value").InnerText = DisplayType

                        ElseIf Childnode.Name = "PanelLeft" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelLeft

                        ElseIf Childnode.Name = "PanelRight" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelRight

                        ElseIf Childnode.Name = "PanelUsers" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelUsers

                        ElseIf Childnode.Name = "PanelFiles" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelFiles

                        ElseIf Childnode.Name = "PanelSystem" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelSystem

                        ElseIf Childnode.Name = "PanelDate" Then
                            Childnode.Attributes("value").InnerText = DisplayPanelDate
                        End If

                    Next


                ElseIf node.Attributes("value").InnerText = "Connect" Then
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

                        ElseIf Childnode.Name = "Save" Then
                            Childnode.Attributes("value").InnerText = PathSave
                        End If

                    Next
                End If
            Next
            XMLconfig.Save(PathFichierXML) 'enregistrement
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class
