<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewGeneralAccessories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewGeneralAccessories))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.dgvGeneralTable = New System.Windows.Forms.DataGridView()
        Me.cmnuAccessory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachToFirearmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralAccessoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.GeneralAccessoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.General_AccessoriesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.General_AccessoriesTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.UseDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.IsLinked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgvGeneralTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmnuAccessory.SuspendLayout
        CType(Me.GeneralAccessoriesBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GeneralAccessoriesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnAdd, Me.tsbRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1172, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsBtnAdd
        '
        Me.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAdd.Image = CType(resources.GetObject("tsBtnAdd.Image"),System.Drawing.Image)
        Me.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAdd.Name = "tsBtnAdd"
        Me.tsBtnAdd.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnAdd.Text = "Add Accessory"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.AccessibleDescription = "Refresh Data"
        Me.tsbRefresh.AccessibleName = "tsbRefresh"
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = CType(resources.GetObject("tsbRefresh.Image"),System.Drawing.Image)
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefresh.Text = "Refresh Data"
        '
        'dgvGeneralTable
        '
        Me.dgvGeneralTable.AccessibleDescription = "View General Accessories List in Database"
        Me.dgvGeneralTable.AccessibleName = "dgvGeneralTable"
        Me.dgvGeneralTable.AllowUserToAddRows = false
        Me.dgvGeneralTable.AllowUserToDeleteRows = false
        Me.dgvGeneralTable.AllowUserToOrderColumns = true
        Me.dgvGeneralTable.AutoGenerateColumns = false
        Me.dgvGeneralTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeneralTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn, Me.UseDataGridViewTextBoxColumn, Me.IsLinked, Me.NotesDataGridViewTextBoxColumn})
        Me.dgvGeneralTable.ContextMenuStrip = Me.cmnuAccessory
        Me.dgvGeneralTable.DataSource = Me.GeneralAccessoriesBindingSource1
        Me.dgvGeneralTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGeneralTable.Location = New System.Drawing.Point(0, 25)
        Me.dgvGeneralTable.Name = "dgvGeneralTable"
        Me.dgvGeneralTable.ReadOnly = true
        Me.dgvGeneralTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGeneralTable.Size = New System.Drawing.Size(1172, 447)
        Me.dgvGeneralTable.TabIndex = 1
        '
        'cmnuAccessory
        '
        Me.cmnuAccessory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AttachToFirearmToolStripMenuItem, Me.DuplicateToolStripMenuItem})
        Me.cmnuAccessory.Name = "cmnuAccessory"
        Me.cmnuAccessory.Size = New System.Drawing.Size(168, 92)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"),System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"),System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'AttachToFirearmToolStripMenuItem
        '
        Me.AttachToFirearmToolStripMenuItem.Image = CType(resources.GetObject("AttachToFirearmToolStripMenuItem.Image"),System.Drawing.Image)
        Me.AttachToFirearmToolStripMenuItem.Name = "AttachToFirearmToolStripMenuItem"
        Me.AttachToFirearmToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AttachToFirearmToolStripMenuItem.Text = "&Attach To Firearm"
        '
        'DuplicateToolStripMenuItem
        '
        Me.DuplicateToolStripMenuItem.Image = CType(resources.GetObject("DuplicateToolStripMenuItem.Image"),System.Drawing.Image)
        Me.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem"
        Me.DuplicateToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DuplicateToolStripMenuItem.Text = "D&uplicate"
        '
        'GeneralAccessoriesBindingSource1
        '
        Me.GeneralAccessoriesBindingSource1.DataMember = "General_Accessories"
        Me.GeneralAccessoriesBindingSource1.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralAccessoriesBindingSource
        '
        Me.GeneralAccessoriesBindingSource.DataMember = "General_Accessories"
        Me.GeneralAccessoriesBindingSource.DataSource = Me.MGCDataSet
        '
        'General_AccessoriesTableAdapter
        '
        Me.General_AccessoriesTableAdapter.ClearBeforeFill = true
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = true
        Me.IDDataGridViewTextBoxColumn.Visible = false
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = true
        Me.ManufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = true
        Me.ModelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number"
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = true
        Me.SerialNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        Me.ConditionDataGridViewTextBoxColumn.ReadOnly = true
        Me.ConditionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'UseDataGridViewTextBoxColumn
        '
        Me.UseDataGridViewTextBoxColumn.DataPropertyName = "Use"
        Me.UseDataGridViewTextBoxColumn.HeaderText = "Use"
        Me.UseDataGridViewTextBoxColumn.Name = "UseDataGridViewTextBoxColumn"
        Me.UseDataGridViewTextBoxColumn.ReadOnly = true
        Me.UseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IsLinked
        '
        Me.IsLinked.DataPropertyName = "IsLinked"
        Me.IsLinked.HeaderText = "IsLinked"
        Me.IsLinked.Name = "IsLinked"
        Me.IsLinked.ReadOnly = true
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.FillWeight = 300!
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = true
        Me.NotesDataGridViewTextBoxColumn.Width = 300
        '
        'frmViewGeneralAccessories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 472)
        Me.Controls.Add(Me.dgvGeneralTable)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmViewGeneralAccessories"
        Me.Text = "General Accessories"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgvGeneralTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmnuAccessory.ResumeLayout(false)
        CType(Me.GeneralAccessoriesBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GeneralAccessoriesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsBtnAdd As ToolStripButton
    Friend WithEvents dgvGeneralTable As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GeneralAccessoriesBindingSource As BindingSource
    Friend WithEvents General_AccessoriesTableAdapter As MGCDataSetTableAdapters.General_AccessoriesTableAdapter
    Friend WithEvents GeneralAccessoriesBindingSource1 As BindingSource
    Friend WithEvents cmnuAccessory As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttachToFirearmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbRefresh As ToolStripButton
    Friend WithEvents DuplicateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents UseDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents IsLinked As DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
