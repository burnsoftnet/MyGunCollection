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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewDocuments))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocfilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocextDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DoccatDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachToFirearmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunCollectionDocsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_Collection_DocsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_DocsTableAdapter()
        Me.ToolStrip1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.GunCollectionDocsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(872, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AccessibleDescription = "Add Document"
        Me.ToolStripButton1.AccessibleName = "ToolStripButton1"
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add Document"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AccessibleDescription = "Refresh"
        Me.ToolStripButton2.AccessibleName = "ToolStripButton2"
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleDescription = "Document List"
        Me.DataGridView1.AccessibleName = "DataGridView1"
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DocnameDataGridViewTextBoxColumn, Me.DocdescriptionDataGridViewTextBoxColumn, Me.DocfilenameDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.DocextDataGridViewTextBoxColumn, Me.DoccatDataGridViewTextBoxColumn, Me.DtaDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.GunCollectionDocsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 425)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = true
        Me.IDDataGridViewTextBoxColumn.Visible = false
        '
        'DocnameDataGridViewTextBoxColumn
        '
        Me.DocnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DocnameDataGridViewTextBoxColumn.DataPropertyName = "doc_name"
        Me.DocnameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.DocnameDataGridViewTextBoxColumn.Name = "DocnameDataGridViewTextBoxColumn"
        Me.DocnameDataGridViewTextBoxColumn.ReadOnly = true
        '
        'DocdescriptionDataGridViewTextBoxColumn
        '
        Me.DocdescriptionDataGridViewTextBoxColumn.DataPropertyName = "doc_description"
        Me.DocdescriptionDataGridViewTextBoxColumn.FillWeight = 200!
        Me.DocdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DocdescriptionDataGridViewTextBoxColumn.Name = "DocdescriptionDataGridViewTextBoxColumn"
        Me.DocdescriptionDataGridViewTextBoxColumn.ReadOnly = true
        '
        'DocfilenameDataGridViewTextBoxColumn
        '
        Me.DocfilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DocfilenameDataGridViewTextBoxColumn.DataPropertyName = "doc_filename"
        Me.DocfilenameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.DocfilenameDataGridViewTextBoxColumn.Name = "DocfilenameDataGridViewTextBoxColumn"
        Me.DocfilenameDataGridViewTextBoxColumn.ReadOnly = true
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.ReadOnly = true
        '
        'DocextDataGridViewTextBoxColumn
        '
        Me.DocextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DocextDataGridViewTextBoxColumn.DataPropertyName = "doc_ext"
        Me.DocextDataGridViewTextBoxColumn.HeaderText = "Doc Type"
        Me.DocextDataGridViewTextBoxColumn.Name = "DocextDataGridViewTextBoxColumn"
        Me.DocextDataGridViewTextBoxColumn.ReadOnly = true
        Me.DocextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DoccatDataGridViewTextBoxColumn
        '
        Me.DoccatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DoccatDataGridViewTextBoxColumn.DataPropertyName = "doc_cat"
        Me.DoccatDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.DoccatDataGridViewTextBoxColumn.Name = "DoccatDataGridViewTextBoxColumn"
        Me.DoccatDataGridViewTextBoxColumn.ReadOnly = true
        Me.DoccatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DtaDataGridViewTextBoxColumn
        '
        Me.DtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DtaDataGridViewTextBoxColumn.DataPropertyName = "dta"
        Me.DtaDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DtaDataGridViewTextBoxColumn.Name = "DtaDataGridViewTextBoxColumn"
        Me.DtaDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AttachToFirearmToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 92)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"),System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AttachToFirearmToolStripMenuItem
        '
        Me.AttachToFirearmToolStripMenuItem.Image = CType(resources.GetObject("AttachToFirearmToolStripMenuItem.Image"),System.Drawing.Image)
        Me.AttachToFirearmToolStripMenuItem.Name = "AttachToFirearmToolStripMenuItem"
        Me.AttachToFirearmToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AttachToFirearmToolStripMenuItem.Text = "Attach  to Firearm"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'GunCollectionDocsBindingSource
        '
        Me.GunCollectionDocsBindingSource.DataMember = "Gun_Collection_Docs"
        Me.GunCollectionDocsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_DocsTableAdapter
        '
        Me.Gun_Collection_DocsTableAdapter.ClearBeforeFill = true
        '
        'frmViewDocuments
        '
        Me.AccessibleDescription = "View Documents"
        Me.AccessibleName = "frmViewDocuments"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmViewDocuments"
        Me.Text = "View Documents"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(false)
        CType(Me.GunCollectionDocsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

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
