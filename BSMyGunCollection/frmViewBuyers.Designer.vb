Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewBuyers
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New Container
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewBuyers))
        Me.ListBox1 = New ListBox
        Me.GunCollectionSoldToBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_Collection_SoldToTableAdapter = New Gun_Collection_SoldToTableAdapter
        Me.HelpProvider1 = New HelpProvider
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripButton1 = New ToolStripButton
        Me.ToolStripSeparator1 = New ToolStripSeparator
        Me.ToolStripButton2 = New ToolStripButton
        CType(Me.GunCollectionSoldToBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.GunCollectionSoldToBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New Point(-1, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(221, 238)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ID"
        '
        'GunCollectionSoldToBindingSource
        '
        Me.GunCollectionSoldToBindingSource.DataMember = "Gun_Collection_SoldTo"
        Me.GunCollectionSoldToBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_SoldToTableAdapter
        '
        Me.Gun_Collection_SoldToTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(218, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Delete User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh List"
        '
        'frmViewBuyers
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(218, 264)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing Listed Buyers")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing Listed Buyers")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmViewBuyers"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Buyers"
        CType(Me.GunCollectionSoldToBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionSoldToBindingSource As BindingSource
    Friend WithEvents Gun_Collection_SoldToTableAdapter As Gun_Collection_SoldToTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
