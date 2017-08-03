<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewDocuments
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewDocuments))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachToFirearmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocfilenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocextDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DoccatDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.DtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunCollectionDocsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_Collection_DocsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_DocsTableAdapter()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GunCollectionDocsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add Document"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DocnameDataGridViewTextBoxColumn, Me.DocdescriptionDataGridViewTextBoxColumn, Me.DocfilenameDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.DocextDataGridViewTextBoxColumn, Me.DoccatDataGridViewTextBoxColumn, Me.DtaDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.GunCollectionDocsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 425)
        Me.DataGridView1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AttachToFirearmToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 114)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AttachToFirearmToolStripMenuItem
        '
        Me.AttachToFirearmToolStripMenuItem.Image = CType(resources.GetObject("AttachToFirearmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AttachToFirearmToolStripMenuItem.Name = "AttachToFirearmToolStripMenuItem"
        Me.AttachToFirearmToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
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
        Me.DocnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        Me.DocfilenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DocfilenameDataGridViewTextBoxColumn.DataPropertyName = "doc_filename"
        Me.DocfilenameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.DocfilenameDataGridViewTextBoxColumn.Name = "DocfilenameDataGridViewTextBoxColumn"
        Me.DocfilenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocextDataGridViewTextBoxColumn
        '
        Me.DocextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DocextDataGridViewTextBoxColumn.DataPropertyName = "doc_ext"
        Me.DocextDataGridViewTextBoxColumn.HeaderText = "Doc Type"
        Me.DocextDataGridViewTextBoxColumn.Name = "DocextDataGridViewTextBoxColumn"
        Me.DocextDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DoccatDataGridViewTextBoxColumn
        '
        Me.DoccatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DoccatDataGridViewTextBoxColumn.DataPropertyName = "doc_cat"
        Me.DoccatDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.DoccatDataGridViewTextBoxColumn.Name = "DoccatDataGridViewTextBoxColumn"
        Me.DoccatDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoccatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DtaDataGridViewTextBoxColumn
        '
        Me.DtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_DocsTableAdapter
        '
        Me.Gun_Collection_DocsTableAdapter.ClearBeforeFill = True
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'frmViewDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewDocuments"
        Me.Text = "View Documents"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GunCollectionDocsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionDocsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_DocsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_DocsTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocdescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocfilenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocextDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DoccatDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachToFirearmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
