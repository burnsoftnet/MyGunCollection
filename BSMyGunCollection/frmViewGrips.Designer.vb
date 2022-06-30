Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewGrips
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewGrips))
        Me.ToolStrip1 = New ToolStrip
        Me.DataGridView1 = New DataGridView
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.GripDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.GunGripTypeBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_GripTypeTableAdapter = New Gun_GripTypeTableAdapter
        Me.HelpProvider1 = New HelpProvider
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunGripTypeBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(223, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GripDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunGripTypeBindingSource
        Me.DataGridView1.Location = New Point(0, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New Size(211, 233)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'GripDataGridViewTextBoxColumn
        '
        Me.GripDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.GripDataGridViewTextBoxColumn.DataPropertyName = "grip"
        Me.GripDataGridViewTextBoxColumn.HeaderText = "Grip Types"
        Me.GripDataGridViewTextBoxColumn.Name = "GripDataGridViewTextBoxColumn"
        Me.GripDataGridViewTextBoxColumn.Width = 83
        '
        'GunGripTypeBindingSource
        '
        Me.GunGripTypeBindingSource.DataMember = "Gun_GripType"
        Me.GunGripTypeBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_GripTypeTableAdapter
        '
        Me.Gun_GripTypeTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmViewGrips
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(223, 263)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing Grips")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing Grips")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewGrips"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Manage Grips"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunGripTypeBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunGripTypeBindingSource As BindingSource
    Friend WithEvents Gun_GripTypeTableAdapter As Gun_GripTypeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
