Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class EditGunClassications
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(EditGunClassications))
        Me.DataGridView1 = New DataGridView()
        Me.GunCollectionClassificationBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_Collection_ClassificationTableAdapter = New Gun_Collection_ClassificationTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.MyclassDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionClassificationBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MyclassDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCollectionClassificationBindingSource
        Me.DataGridView1.Location = New Point(-2, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New Size(220, 352)
        Me.DataGridView1.TabIndex = 0
        '
        'GunCollectionClassificationBindingSource
        '
        Me.GunCollectionClassificationBindingSource.DataMember = "Gun_Collection_Classification"
        Me.GunCollectionClassificationBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_ClassificationTableAdapter
        '
        Me.Gun_Collection_ClassificationTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'MyclassDataGridViewTextBoxColumn
        '
        Me.MyclassDataGridViewTextBoxColumn.DataPropertyName = "myclass"
        Me.MyclassDataGridViewTextBoxColumn.FillWeight = 160.0!
        Me.MyclassDataGridViewTextBoxColumn.HeaderText = "Class Type"
        Me.MyclassDataGridViewTextBoxColumn.Name = "MyclassDataGridViewTextBoxColumn"
        Me.MyclassDataGridViewTextBoxColumn.Width = 160
        '
        'EditGunClassications
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(220, 350)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditGunClassications"
        Me.Text = "Classification"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunCollectionClassificationBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionClassificationBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ClassificationTableAdapter As Gun_Collection_ClassificationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyclassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
