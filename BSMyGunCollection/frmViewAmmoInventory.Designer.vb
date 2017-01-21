<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAmmoInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAmmoInventory))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GunCollectionAmmoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.Gun_Collection_AmmoTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_AmmoTableAdapter
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.tslAmmoTotal = New System.Windows.Forms.ToolStripLabel
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ManufacturerDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
        Me.GrainDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
        Me.JacketDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vel_n = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAmmoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CalDataGridViewTextBoxColumn, Me.GrainDataGridViewTextBoxColumn, Me.JacketDataGridViewTextBoxColumn, Me.vel_n, Me.Qty1DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCollectionAmmoBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.Location = New System.Drawing.Point(3, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(711, 272)
        Me.DataGridView1.TabIndex = 0
        '
        'GunCollectionAmmoBindingSource
        '
        Me.GunCollectionAmmoBindingSource.DataMember = "Gun_Collection_Ammo"
        Me.GunCollectionAmmoBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_AmmoTableAdapter
        '
        Me.Gun_Collection_AmmoTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.tslAmmoTotal})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(716, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Add Ammunition to Collection"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add to Qty of Selected Ammunition"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add Qty & Audit"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "View Audit Details"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'tslAmmoTotal
        '
        Me.tslAmmoTotal.Name = "tslAmmoTotal"
        Me.tslAmmoTotal.Size = New System.Drawing.Size(136, 22)
        Me.tslAmmoTotal.Text = "Total Rounds in Inventory:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManufacturerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'CalDataGridViewTextBoxColumn
        '
        Me.CalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CalDataGridViewTextBoxColumn.DataPropertyName = "Cal"
        Me.CalDataGridViewTextBoxColumn.HeaderText = "Cal"
        Me.CalDataGridViewTextBoxColumn.Name = "CalDataGridViewTextBoxColumn"
        Me.CalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.CalDataGridViewTextBoxColumn.Width = 63
        '
        'GrainDataGridViewTextBoxColumn
        '
        Me.GrainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GrainDataGridViewTextBoxColumn.DataPropertyName = "Grain"
        Me.GrainDataGridViewTextBoxColumn.HeaderText = "Grain"
        Me.GrainDataGridViewTextBoxColumn.Name = "GrainDataGridViewTextBoxColumn"
        Me.GrainDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrainDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GrainDataGridViewTextBoxColumn.Width = 73
        '
        'JacketDataGridViewTextBoxColumn
        '
        Me.JacketDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.JacketDataGridViewTextBoxColumn.DataPropertyName = "Jacket"
        Me.JacketDataGridViewTextBoxColumn.HeaderText = "Jacket"
        Me.JacketDataGridViewTextBoxColumn.Name = "JacketDataGridViewTextBoxColumn"
        Me.JacketDataGridViewTextBoxColumn.Width = 64
        '
        'vel_n
        '
        Me.vel_n.DataPropertyName = "vel_n"
        Me.vel_n.HeaderText = "Velocity (FPS)"
        Me.vel_n.Name = "vel_n"
        '
        'Qty1DataGridViewTextBoxColumn
        '
        Me.Qty1DataGridViewTextBoxColumn.DataPropertyName = "Qty1"
        Me.Qty1DataGridViewTextBoxColumn.HeaderText = "Qty."
        Me.Qty1DataGridViewTextBoxColumn.Name = "Qty1DataGridViewTextBoxColumn"
        '
        'frmViewAmmoInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 299)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Ammunition Inventory")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Ammunition Inventory")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewAmmoInventory"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Ammunition Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunCollectionAmmoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionAmmoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_AmmoTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_AmmoTableAdapter
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tslAmmoTotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents GrainDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents JacketDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vel_n As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
