Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditGunConditions
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditGunConditions))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunCollectionConditionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_Collection_ConditionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_ConditionTableAdapter()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GunCollectionConditionBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleDescription = "List of Firearm Conditions"
        Me.DataGridView1.AccessibleName = "DataGridView1"
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCollectionConditionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(292, 371)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = false
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 60
        '
        'GunCollectionConditionBindingSource
        '
        Me.GunCollectionConditionBindingSource.DataMember = "Gun_Collection_Condition"
        Me.GunCollectionConditionBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_ConditionTableAdapter
        '
        Me.Gun_Collection_ConditionTableAdapter.ClearBeforeFill = true
        '
        'frmEditGunConditions
        '
        Me.AccessibleDescription = "Firearm Conditions"
        Me.AccessibleName = "frmEditGunConditions"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 371)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmEditGunConditions"
        Me.Text = "Firearm Conditions"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GunCollectionConditionBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionConditionBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ConditionTableAdapter As Gun_Collection_ConditionTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
