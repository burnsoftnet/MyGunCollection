Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewMaintancePlanList
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewMaintancePlanList))
        Me.MaintancePlansBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Maintance_PlansTableAdapter = New Maintance_PlansTableAdapter
        Me.ToolStripContainer1 = New ToolStripContainer
        Me.ToolStripContainer2 = New ToolStripContainer
        Me.ListBox1 = New ListBox
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripLabel1 = New ToolStripLabel
        Me.ToolStripLabel2 = New ToolStripLabel
        Me.ToolStripLabel3 = New ToolStripLabel
        Me.HelpProvider1 = New HelpProvider
        CType(Me.MaintancePlansBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaintancePlansBindingSource
        '
        Me.MaintancePlansBindingSource.DataMember = "Maintance_Plans"
        Me.MaintancePlansBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Maintance_PlansTableAdapter
        '
        Me.Maintance_PlansTableAdapter.ClearBeforeFill = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New Size(150, 150)
        Me.ToolStripContainer1.Location = New Point(8, 8)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New Size(150, 175)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2
        '
        Me.ToolStripContainer2.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.ListBox1)
        Me.ToolStripContainer2.ContentPanel.Size = New Size(226, 284)
        Me.ToolStripContainer2.Dock = DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New Size(226, 309)
        Me.ToolStripContainer2.TabIndex = 3
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.MaintancePlansBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(219, 277)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "ID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = DockStyle.None
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(226, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New Size(26, 22)
        Me.ToolStripLabel1.Text = "Add"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New Size(45, 22)
        Me.ToolStripLabel2.Text = "Refresh"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New Size(25, 22)
        Me.ToolStripLabel3.Text = "Exit"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmViewMaintancePlanList
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(226, 309)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing a Maintenance Plan")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing a Maintenance Plan")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmViewMaintancePlanList"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Maintenance Plan List"
        CType(Me.MaintancePlansBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents MaintancePlansBindingSource As BindingSource
    Friend WithEvents Maintance_PlansTableAdapter As Maintance_PlansTableAdapter
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
