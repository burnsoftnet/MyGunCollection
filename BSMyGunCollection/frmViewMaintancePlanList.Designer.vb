<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMaintancePlanList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewMaintancePlanList))
        Me.MaintancePlansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.Maintance_PlansTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Maintance_PlansTableAdapter
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.MaintancePlansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(8, 8)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(150, 175)
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
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(226, 284)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(226, 309)
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
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 277)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "ID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(226, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(26, 22)
        Me.ToolStripLabel1.Text = "Add"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel2.Text = "Refresh"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(25, 22)
        Me.ToolStripLabel3.Text = "Exit"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmViewMaintancePlanList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 309)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing a Maintenance Plan")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing a Maintenance Plan")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewMaintancePlanList"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Maintenance Plan List"
        CType(Me.MaintancePlansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents MaintancePlansBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Maintance_PlansTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Maintance_PlansTableAdapter
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
