Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditFirearmType
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmEditFirearmType))
        Me.DataGridView1 = New DataGridView
        Me.MGCDataSet = New MGCDataSet
        Me.GunTypeBindingSource = New BindingSource(Me.components)
        Me.Gun_TypeTableAdapter = New Gun_TypeTableAdapter
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.GunTypeBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunTypeBindingSource
        Me.DataGridView1.Dock = DockStyle.Fill
        Me.DataGridView1.Location = New Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New Size(292, 396)
        Me.DataGridView1.TabIndex = 0
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'GunTypeBindingSource
        '
        Me.GunTypeBindingSource.DataMember = "Gun_Type"
        Me.GunTypeBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_TypeTableAdapter
        '
        Me.Gun_TypeTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 56
        '
        'frmEditFirearmType
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(292, 396)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditFirearmType"
        Me.Text = "Firearm Types"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.GunTypeBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunTypeBindingSource As BindingSource
    Friend WithEvents Gun_TypeTableAdapter As Gun_TypeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
