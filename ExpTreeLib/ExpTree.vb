Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text

Imports System.Windows.Forms
Imports ExpTreeLib.CShItem
Imports ExpTreeLib.ShellDll
Imports ExpTreeLib.SystemImageListManager


<DefaultProperty("StartUpDirectory"), DefaultEvent("StartUpDirectoryChanged")> _
Public Class ExpTree
    Inherits System.Windows.Forms.UserControl

    Private Root As TreeNode

    Public Event StartUpDirectoryChanged(ByVal newVal As StartDir)

    Public Event ExpTreeNodeSelected(ByVal SelPath As String, ByVal Item As CShItem)

    Private EnableEventPost As Boolean = True 'flag to supress ExpTreeNodeSelected raising during refresh and 

    Private m_showHiddenFolders As Boolean = True


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        'setting the imagelist here allows many good things to happen, but
        ' also one bad thing -- the "tooltip" like display of selectednode.text
        ' is made invisible.  This remains a problem to be solved.
        SystemImageListManager.SetTreeViewImageList(tv1, False)

        AddHandler StartUpDirectoryChanged, AddressOf OnStartUpDirectoryChanged

        OnStartUpDirectoryChanged(m_StartUpDirectory)

        'If tv1.IsHandleCreated Then
        '    If Me.AllowDrop Then
        '        If Application.OleRequired = Threading.ApartmentState.STA Then
        '            DragDropHandler = New TVDragWrapper(tv1)
        '            Dim res As Integer
        '            res = RegisterDragDrop(tv1.Handle, DragDropHandler)
        '            If Not (res = 0) Or (res = -2147221247) Then
        '                Marshal.ThrowExceptionForHR(res)
        '                Throw New Exception("Failed to Register DragDrop for " & Me.Name)
        '            End If
        '        Else
        '            Throw New ThreadStateException("ThreadMustBeSTA")
        '        End If
        '    End If
        'End If


    End Sub
    'ExpTree overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tv1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'tv1
        '
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.HideSelection = False
        Me.tv1.ImageIndex = -1
        Me.tv1.Name = "tv1"
        Me.tv1.SelectedImageIndex = -1
        Me.tv1.ShowRootLines = False
        Me.tv1.Size = New System.Drawing.Size(200, 264)
        Me.tv1.TabIndex = 0
        '
        'ExpTree
        '
        Me.AllowDrop = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tv1})
        Me.Name = "ExpTree"
        Me.Size = New System.Drawing.Size(200, 264)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "   Public Properties"

#Region "       RootItem"
    '<Summary>
    ' RootItem is a Run-Time only Property
    ' Setting this Item via an External call results in
    '  re-setting the entire tree to be rooted in the 
    '  input CShItem
    ' The new CShItem must be a valid CShItem of some kind
    '  of Folder (File Folder or System Folder)
    ' Attempts to set it using a non-Folder CShItem are ignored
    '</Summary>
    <Browsable(False)> _
    Public Property RootItem() As CShItem
        Get
            Return Root.Tag
        End Get
        Set(ByVal Value As CShItem)
            If Value.IsFolder Then
                If Not IsNothing(Root) Then
                    ClearTree()
                End If
                Root = New TreeNode(Value.DisplayName)
                BuildTree(Value.GetDirectories())
                Root.ImageIndex = SystemImageListManager.GetIconIndex(Value, False)
                Root.SelectedImageIndex = Root.ImageIndex
                Root.Tag = Value
                tv1.Nodes.Add(Root)
                Root.Expand()
                tv1.SelectedNode = Root
            End If
        End Set
    End Property
#End Region

#Region "       SelectedItem"
    <Browsable(False)> _
    Public ReadOnly Property SelectedItem() As CShItem
        Get
            If Not IsNothing(tv1.SelectedNode) Then
                Return tv1.SelectedNode.Tag
            Else
                Return Nothing
            End If
        End Get
    End Property
#End Region

#Region "       ShowHidden"
    <Category("Options"), _
    Description("Show Hidden Directories."), _
    DefaultValue(True), Browsable(True)> _
   Public Property ShowHiddenFolders() As Boolean
        Get
            Return m_showHiddenFolders
        End Get
        Set(ByVal Value As Boolean)
            m_showHiddenFolders = Value
        End Set
    End Property
#End Region

#Region "       ShowRootLines"
    <Category("Options"), _
  Description("Allow Collapse of Root Item."), _
  DefaultValue(True), Browsable(True)> _
Public Property ShowRootLines() As Boolean
        Get
            Return tv1.ShowRootLines
        End Get
        Set(ByVal Value As Boolean)
            If Not (Value = tv1.ShowRootLines) Then
                tv1.ShowRootLines = Value
                tv1.Refresh()
            End If
        End Set
    End Property
#End Region

#Region "       StartupDir"

    Public Enum StartDir As Integer
        Desktop = &H0
        Programs = &H2
        Controls = &H3
        Printers = &H4
        Personal = &H5
        Favorites = &H6
        Startup = &H7
        Recent = &H8
        SendTo = &H9
        StartMenu = &HB
        MyDocuments = &HC
        'MyMusic = &HD
        'MyVideo = &HE
        DesktopDirectory = &H10
        MyComputer = &H11
        My_Network_Places = &H12
        'NETHOOD = &H13
        'FONTS = &H14
        ApplicatationData = &H1A
        'PRINTHOOD = &H1B
        Internet_Cache = &H20
        Cookies = &H21
        History = &H22
        Windows = &H24
        System = &H25
        Program_Files = &H26
        MyPictures = &H27
        Profile = &H28
        Systemx86 = &H29
        AdminTools = &H30
    End Enum

    Private m_StartUpDirectory As StartDir = StartDir.Desktop

    <Category("Options"), _
     Description("Sets the Initial Directory of the Tree"), _
     DefaultValue(StartDir.Desktop), Browsable(True)> _
    Public Property StartUpDirectory() As StartDir
        Get
            Return m_StartUpDirectory
        End Get
        Set(ByVal Value As StartDir)
            If Array.IndexOf([Enum].GetValues(Value.GetType), Value) >= 0 Then
                m_StartUpDirectory = Value
                RaiseEvent StartUpDirectoryChanged(Value)
            Else
                Throw New ApplicationException("Invalid Initial StartUpDirectory")
            End If
        End Set
    End Property
#End Region

#End Region

#Region "   Public Methods"

#Region "       RefreshTree"
    '''<Summary>RefreshTree Method thanks to Calum McLellan</Summary>
    <Description("Refresh the Tree and all nodes through the currently selected item")> _
    Public Sub RefreshTree(Optional ByVal rootCSI As CShItem = Nothing)
        'Modified to use ExpandANode(CShItem) rather than ExpandANode(path)
        'Set refresh variable for BeforeExpand method
        EnableEventPost = False
        'Begin Calum's change -- With some modification
        Dim Selnode As TreeNode
        If IsNothing(Me.tv1.SelectedNode) Then
            Selnode = Me.Root
        Else
            Selnode = Me.tv1.SelectedNode
        End If
        'End Calum's change
        Try
            Me.tv1.BeginUpdate()
            Dim SelCSI As CShItem = Selnode.Tag
            'Set root node
            If IsNothing(rootCSI) Then
                Me.RootItem = Me.RootItem
            Else
                Me.RootItem = rootCSI
            End If
            'Try to expand the node
            If Not Me.ExpandANode(SelCSI) Then
                Dim nodeList As New ArrayList()
                While Not IsNothing(Selnode.Parent)
                    nodeList.Add(Selnode.Parent)
                    Selnode = Selnode.Parent
                End While

                For Each Selnode In nodeList
                    If Me.ExpandANode(CType(Selnode.Tag, CShItem)) Then Exit For
                Next
            End If
            'Reset refresh variable for BeforeExpand method
        Finally
            Me.tv1.EndUpdate()
        End Try
        EnableEventPost = True
        'We suppressed EventPosting during refresh, so give it one now
        tv1_AfterSelect(Me, New TreeViewEventArgs(tv1.SelectedNode))
    End Sub
#End Region

#Region "       ExpandANode"
    Public Function ExpandANode(ByVal newPath As String) As Boolean
        ExpandANode = False     'assume failure
        Dim newItem As CShItem
        Try
            newItem = GetCShItem(newPath)
            If newItem Is Nothing Then Exit Function
            If Not newItem.IsFolder Then Exit Function
        Catch
            Exit Function
        End Try
        Return ExpandANode(newItem)
    End Function

    Public Function ExpandANode(ByVal newItem As CShItem) As Boolean
        ExpandANode = False     'assume failure
        Dim baseNode As TreeNode = Root
        tv1.BeginUpdate()
        baseNode.Expand() 'Ensure base is filled in
            'do the drill down -- Node to expand must be included in tree
            Dim testNode As TreeNode
            Dim lim As Integer = CShItem.PidlCount(newItem.PIDL) - CShItem.PidlCount(baseNode.Tag.pidl)
        'Test ExpandARow again on XP to ensure that the CP problem ix fixed
            Do While lim > 0
                For Each testNode In baseNode.Nodes
                    If CShItem.IsAncestorOf(testNode.Tag, newItem, False) Then
                        baseNode = testNode
                        RefreshNode(baseNode)   'ensure up-to-date
                        baseNode.Expand()
                        lim -= 1
                        GoTo NEXLEV
                    End If
                Next
                GoTo XIT     'on falling thru For, we can't find it, so get out
NEXLEV:     Loop
            'after falling thru here, we have found & expanded the node
            Me.tv1.HideSelection = False
            Me.Select()
            Me.tv1.SelectedNode = baseNode
            ExpandANode = True
XIT:        tv1.EndUpdate()
    End Function
#End Region

#End Region

#Region "   Initial Dir Set Handler"

    Private Sub OnStartUpDirectoryChanged(ByVal newVal As StartDir)
        If Not IsNothing(Root) Then
            ClearTree()
        End If
        Dim special As CShItem
        special = GetCShItem(CType(Val(m_StartUpDirectory), ShellDll.CSIDL))
        Root = New TreeNode(special.DisplayName)
        Root.ImageIndex = SystemImageListManager.GetIconIndex(special, False)
        Root.SelectedImageIndex = Root.ImageIndex
        Root.Tag = special
        BuildTree(special.GetDirectories())
        tv1.Nodes.Add(Root)
        Root.Expand()
    End Sub

    Private Sub RefreshLs()
        tv1.SelectedNode = tv1.SelectedNode
    End Sub

    Private Sub BuildTree(ByVal L1 As ArrayList)
        L1.Sort()
        Dim CSI As CShItem
        For Each CSI In L1
            If Not (CSI.IsHidden And Not m_showHiddenFolders) Then
                Root.Nodes.Add(MakeNode(CSI))
            End If
        Next
    End Sub

    Private Function MakeNode(ByVal item As CShItem) As TreeNode
        Dim newNode As New TreeNode(item.DisplayName)
        newNode.Tag = item
        newNode.ImageIndex = SystemImageListManager.GetIconIndex(item, False)
        newNode.SelectedImageIndex = SystemImageListManager.GetIconIndex(item, True)
        'The following code, from Calum implements the following logic
        ' Allow/disallow the showing of Hidden folders based on ShowHidden Propert
        ' For Removable disks, always show + (allow expansion) - avoids floppy access
        ' For all others, add + based on HasSubFolders
        '  Except - If showing Hidden dirs, do extra check to  allow for
        '  the case of all hidden items in the Dir which will cause
        '  HasSubFolders to be always left unset
        If item.IsRemovable Then             'Calum's fix to hidden file fix
            newNode.Nodes.Add(New TreeNode(" : "))
        ElseIf item.HasSubFolders Then
            newNode.Nodes.Add(New TreeNode(" : "))
            'Begin Calum's change so Hidden dirs with all hidden content are expandable
        ElseIf item.GetDirectories.Count > 0 Then   'Added Code
            newNode.Nodes.Add(New TreeNode(" : "))  'Added Code
            'End Calum's change
        End If
        Return newNode
    End Function

    Private Sub ClearTree()
        tv1.Nodes.Clear()
        Root = Nothing
    End Sub
#End Region

#Region "   TreeView BeforeExpand Event"

    Private Sub tv1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tv1.BeforeExpand
        Dim oldCursor As Cursor = Cursor
        Cursor = Cursors.WaitCursor
        If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Text.Equals(" : ") Then
            'Debug.WriteLine("Expanding -- " & e.Node.Text)
            e.Node.Nodes.Clear()
            Dim CSI As CShItem = e.Node.Tag
            Dim D As ArrayList = CSI.GetDirectories()

            If D.Count > 0 Then
                D.Sort()    'uses the class comparer
                Dim item As CShItem
                For Each item In D
                    If Not (item.IsHidden And Not m_showHiddenFolders) Then
                        e.Node.Nodes.Add(MakeNode(item))
                    End If
                Next
            End If
        Else    'Ensure content is accurate
            RefreshNode(e.Node)
        End If
        Cursor = oldCursor
    End Sub
#End Region

#Region "   TreeView AfterSelect Event"
    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        Dim node As TreeNode = e.Node
        Dim CSI As CShItem = e.Node.Tag
        If CSI Is Root.Tag AndAlso Not tv1.ShowRootLines Then
            With tv1
                Try
                    .BeginUpdate()
                    .ShowRootLines = True
                    RefreshNode(node)
                    .ShowRootLines = False
                Finally
                    .EndUpdate()
                End Try
            End With
        Else
            RefreshNode(node)
        End If
        If EnableEventPost Then 'turned off during RefreshTree
            If CSI.Path.StartsWith(":") Then
                RaiseEvent ExpTreeNodeSelected(CSI.DisplayName, CSI)
            Else
                RaiseEvent ExpTreeNodeSelected(CSI.Path, CSI)
            End If
        End If
    End Sub
#End Region

#Region "   RefreshNode Sub"

    Private Sub RefreshNode(ByVal thisRoot As TreeNode)
        'Debug.WriteLine("In RefreshNode: Node = " & thisRoot.Tag.path & " -- " & thisRoot.Tag.displayname)
        If Not (thisRoot.Nodes.Count = 1 AndAlso thisRoot.Nodes(0).Text.Equals(" : ")) Then
            Dim thisItem As CShItem = thisRoot.Tag
            If thisItem.RefreshDirectories Then   'RefreshDirectories True = the contained list of Directories has changed
                Dim curDirs As ArrayList = thisItem.GetDirectories(False) 'suppress 2nd refresh
                Dim delNodes As New ArrayList()
                Dim node As TreeNode
                For Each node In thisRoot.Nodes 'this is the old node contents
                    Dim i As Integer
                    For i = 0 To curDirs.Count - 1
                        If CType(curDirs(i), CShItem).Equals(node.Tag) Then
                            curDirs.RemoveAt(i)   'found it, don't compare again
                            GoTo NXTOLD
                        End If
                    Next
                    'fall thru = node no longer here
                    delNodes.Add(node)
NXTOLD:         Next
                If delNodes.Count + curDirs.Count > 0 Then  'had changes
                    Try
                        tv1.BeginUpdate()
                        For Each node In delNodes 'dir not here anymore, delete node
                            thisRoot.Nodes.Remove(node)
                        Next
                        'any CShItems remaining in curDirs is a new dir under thisRoot
                        Dim csi As CShItem
                        For Each csi In curDirs
                            If Not (csi.IsHidden And Not m_showHiddenFolders) Then
                                thisRoot.Nodes.Add(MakeNode(csi))
                            End If
                        Next
                        'we only need to resort if we added
                        'sort is based on CShItem in .Tag
                        If curDirs.Count > 0 Then
                            Dim tmpA(thisRoot.Nodes.Count - 1) As TreeNode
                            thisRoot.Nodes.CopyTo(tmpA, 0)
                            Array.Sort(tmpA, New TagComparer())
                            thisRoot.Nodes.Clear()
                            thisRoot.Nodes.AddRange(tmpA)
                        End If
                    Catch ex As Exception
                        Debug.WriteLine("Error in RefreshNode -- " & ex.ToString _
                                        & vbCrLf & ex.StackTrace)
                    Finally
                        tv1.EndUpdate()
                    End Try
                End If
            End If
        End If
        'Debug.WriteLine("Exited RefreshNode")
    End Sub

#End Region

#Region "   TreeView VisibleChanged Event"
    '''<Summary>When a form containing this control is Hidden and then re-Shown,
    ''' the association to the SystemImageList is lost.  Also lost is the
    ''' Expanded state of the various TreeNodes. 
    ''' The VisibleChanged Event occurs when the form is re-shown (and other times
    '''  as well).  
    ''' We re-establish the SystemImageList as the ImageList for the TreeView and
    ''' restore at least some of the Expansion.</Summary> 
    Private Sub tv1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.VisibleChanged
        If tv1.Visible Then
            SystemImageListManager.SetTreeViewImageList(tv1, False)
            If Not Root Is Nothing Then
                Root.Expand()
                If Not IsNothing(tv1.SelectedNode) Then
                    tv1.SelectedNode.Expand()
                Else
                    tv1.SelectedNode = Me.Root
                End If
            End If
        End If
    End Sub
#End Region

#Region "   TreeView BeforeCollapse Event"
    '''<Summary>Should never occur since if the condition tested for is True,
    ''' the user should never be able to Collapse the node. However, it is
    ''' theoretically possible for the code to request a collapse of this node
    ''' If it occurs, cancel it</Summary>
    Private Sub tv1_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tv1.BeforeCollapse
        If Not tv1.ShowRootLines AndAlso e.Node Is Root Then
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "   tv1_HandleDestroyed"
    Private Sub tv1_HandleDestroyed(ByVal sender As Object, ByVal e As EventArgs) Handles tv1.HandleDestroyed
        'Debug.WriteLine("in handle destroyed")
        If Me.AllowDrop Then
            Dim res As Integer
            res = RevokeDragDrop(tv1.Handle)
            If res <> 0 Then
                Debug.WriteLine("RevokeDragDrop returned " & res)
            End If
            'Else
            '    Debug.WriteLine("HandleDestroyed with allowdrop false")
        End If
    End Sub
#End Region

#Region "   FindAncestorNode"
    '''<Summary>Given a CShItem, find the TreeNode that belongs to the
    ''' equivalent (matching PIDL) CShItem's most immediate surviving ancestor.
    '''  Note: referential comparison might not work since there is no guarantee
    ''' that the exact same CShItem is stored in the tree.</Summary>
    '''<returns> Me.Root if not found, otherwise the Treenode whose .Tag is
    ''' equivalent to the input CShItem's most immediate surviving ancestor </returns>
    Private Function FindAncestorNode(ByVal CSI As CShItem) As TreeNode
        FindAncestorNode = Nothing
        If Not CSI.IsFolder Then Exit Function 'only folders in tree
        Dim baseNode As TreeNode = Root
        'Dim cp As cPidl = CSI.clsPidl     'the cPidl rep of the PIDL to be found
        Dim testNode As TreeNode
        Dim lim As Integer = PidlCount(CSI.PIDL) - PidlCount(baseNode.Tag.pidl)
        Do While lim > 1
            For Each testNode In baseNode.Nodes
                If CShItem.IsAncestorOf(testNode.Tag, CSI, False) Then
                    baseNode = testNode
                    baseNode.Expand()
                    lim -= 1
                    GoTo NEXTLEV
                End If
            Next
            'CSI's Ancestor may have moved or been deleted, return the last one
            ' found (if none, will return Me.Root)
            Return baseNode
NEXTLEV: Loop
        'on fall thru, we have it
        Return baseNode
    End Function
#End Region

End Class
