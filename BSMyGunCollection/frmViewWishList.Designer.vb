Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports DataGridViewAutoFilter
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmViewWishList
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewWishList))
        Me.DataGridView1 = New DataGridView
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New ToolStripMenuItem
        Me.ToolStripSeparator1 = New ToolStripSeparator
        Me.DeleteToolStripMenuItem = New ToolStripMenuItem
        Me.WishlistBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripButton1 = New ToolStripButton
        Me.ToolStripButton4 = New ToolStripButton
        Me.ToolStripButton2 = New ToolStripButton
        Me.ToolStripButton3 = New ToolStripButton
        Me.WishlistTableAdapter = New WishlistTableAdapter
        Me.HelpProvider1 = New HelpProvider
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.ManufacturerDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn
        Me.ModelDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.PlacetoBuyDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn
        Me.QtyDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.ValueDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.NotesDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.WishlistBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.PlacetoBuyDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.ValueDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.WishlistBindingSource
        Me.DataGridView1.Location = New Point(1, 36)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New Size(451, 228)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Me.EditToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(117, 54)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New Size(116, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(113, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New Size(116, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'WishlistBindingSource
        '
        Me.WishlistBindingSource.DataMember = "Wishlist"
        Me.WishlistBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(452, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(36, 36)
        Me.ToolStripButton1.Text = "Add to Wishlist!"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New Size(36, 36)
        Me.ToolStripButton4.Text = "Refresh List"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(36, 36)
        Me.ToolStripButton2.Text = "Preview and Print Wishlist!"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(36, 36)
        Me.ToolStripButton3.Text = "Close Wishlist"
        '
        'WishlistTableAdapter
        '
        Me.WishlistTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManufacturerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.ManufacturerDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic
        Me.ManufacturerDataGridViewTextBoxColumn.Width = 111
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModelDataGridViewTextBoxColumn.Width = 61
        '
        'PlacetoBuyDataGridViewTextBoxColumn
        '
        Me.PlacetoBuyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.PlacetoBuyDataGridViewTextBoxColumn.DataPropertyName = "PlacetoBuy"
        Me.PlacetoBuyDataGridViewTextBoxColumn.HeaderText = "Place to Buy"
        Me.PlacetoBuyDataGridViewTextBoxColumn.Name = "PlacetoBuyDataGridViewTextBoxColumn"
        Me.PlacetoBuyDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlacetoBuyDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.PlacetoBuyDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic
        Me.PlacetoBuyDataGridViewTextBoxColumn.Width = 108
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyDataGridViewTextBoxColumn.Width = 48
        '
        'ValueDataGridViewTextBoxColumn
        '
        Me.ValueDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.ValueDataGridViewTextBoxColumn.DataPropertyName = "Value"
        Me.ValueDataGridViewTextBoxColumn.HeaderText = "Value"
        Me.ValueDataGridViewTextBoxColumn.Name = "ValueDataGridViewTextBoxColumn"
        Me.ValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValueDataGridViewTextBoxColumn.Width = 59
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Width = 60
        '
        'frmViewWishList
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(452, 266)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing Wishlist")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing Wishlist")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewWishList"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.Text = "My Wishlist"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.WishlistBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents WishlistBindingSource As BindingSource
    Friend WithEvents WishlistTableAdapter As WishlistTableAdapter
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacetoBuyDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
