Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports DataGridViewAutoFilter
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewDocuments
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewDocuments))
        Me.ToolStrip1 = New ToolStrip()
        Me.ToolStripButton1 = New ToolStripButton()
        Me.ToolStripButton2 = New ToolStripButton()
        Me.DataGridView1 = New DataGridView()
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New ToolStripMenuItem()
        Me.AttachToFirearmToolStripMenuItem = New ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocnameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocdescriptionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocfilenameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocextDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.DoccatDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.DtaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GunCollectionDocsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_Collection_DocsTableAdapter = New Gun_Collection_DocsTableAdapter()
        Me.EditToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GunCollectionDocsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(872, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Add Document"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DocnameDataGridViewTextBoxColumn, Me.DocdescriptionDataGridViewTextBoxColumn, Me.DocfilenameDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.DocextDataGridViewTextBoxColumn, Me.DoccatDataGridViewTextBoxColumn, Me.DtaDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.GunCollectionDocsBindingSource
        Me.DataGridView1.Dock = DockStyle.Fill
        Me.DataGridView1.Location = New Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New Size(872, 425)
        Me.DataGridView1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Me.ViewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AttachToFirearmToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(170, 114)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"), Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New Size(169, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New Size(169, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AttachToFirearmToolStripMenuItem
        '
        Me.AttachToFirearmToolStripMenuItem.Image = CType(resources.GetObject("AttachToFirearmToolStripMenuItem.Image"), Image)
        Me.AttachToFirearmToolStripMenuItem.Name = "AttachToFirearmToolStripMenuItem"
        Me.AttachToFirearmToolStripMenuItem.Size = New Size(169, 22)
        Me.AttachToFirearmToolStripMenuItem.Text = "Attach  to Firearm"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DocnameDataGridViewTextBoxColumn
        '
        Me.DocnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocnameDataGridViewTextBoxColumn.DataPropertyName = "doc_name"
        Me.DocnameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.DocnameDataGridViewTextBoxColumn.Name = "DocnameDataGridViewTextBoxColumn"
        Me.DocnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocdescriptionDataGridViewTextBoxColumn
        '
        Me.DocdescriptionDataGridViewTextBoxColumn.DataPropertyName = "doc_description"
        Me.DocdescriptionDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.DocdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DocdescriptionDataGridViewTextBoxColumn.Name = "DocdescriptionDataGridViewTextBoxColumn"
        Me.DocdescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocfilenameDataGridViewTextBoxColumn
        '
        Me.DocfilenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocfilenameDataGridViewTextBoxColumn.DataPropertyName = "doc_filename"
        Me.DocfilenameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.DocfilenameDataGridViewTextBoxColumn.Name = "DocfilenameDataGridViewTextBoxColumn"
        Me.DocfilenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocextDataGridViewTextBoxColumn
        '
        Me.DocextDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocextDataGridViewTextBoxColumn.DataPropertyName = "doc_ext"
        Me.DocextDataGridViewTextBoxColumn.HeaderText = "Doc Type"
        Me.DocextDataGridViewTextBoxColumn.Name = "DocextDataGridViewTextBoxColumn"
        Me.DocextDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocextDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'DoccatDataGridViewTextBoxColumn
        '
        Me.DoccatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DoccatDataGridViewTextBoxColumn.DataPropertyName = "doc_cat"
        Me.DoccatDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.DoccatDataGridViewTextBoxColumn.Name = "DoccatDataGridViewTextBoxColumn"
        Me.DoccatDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoccatDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'DtaDataGridViewTextBoxColumn
        '
        Me.DtaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DtaDataGridViewTextBoxColumn.DataPropertyName = "dta"
        Me.DtaDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DtaDataGridViewTextBoxColumn.Name = "DtaDataGridViewTextBoxColumn"
        Me.DtaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GunCollectionDocsBindingSource
        '
        Me.GunCollectionDocsBindingSource.DataMember = "Gun_Collection_Docs"
        Me.GunCollectionDocsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_DocsTableAdapter
        '
        Me.Gun_Collection_DocsTableAdapter.ClearBeforeFill = True
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New Size(169, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'frmViewDocuments
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(872, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewDocuments"
        Me.Text = "View Documents"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GunCollectionDocsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionDocsBindingSource As BindingSource
    Friend WithEvents Gun_Collection_DocsTableAdapter As Gun_Collection_DocsTableAdapter
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocfilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocextDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DoccatDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachToFirearmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
