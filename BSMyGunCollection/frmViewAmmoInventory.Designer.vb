Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports DataGridViewAutoFilter
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewAmmoInventory
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewAmmoInventory))
        Me.DataGridView1 = New DataGridView()
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.CalDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.GrainDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.JacketDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.vel_n = New DataGridViewTextBoxColumn()
        Me.Qty1DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GunCollectionAmmoBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_Collection_AmmoTableAdapter = New Gun_Collection_AmmoTableAdapter()
        Me.ToolStrip1 = New ToolStrip()
        Me.ToolStripButton4 = New ToolStripButton()
        Me.ToolStripSeparator1 = New ToolStripSeparator()
        Me.ToolStripButton1 = New ToolStripButton()
        Me.ToolStripButton5 = New ToolStripButton()
        Me.ToolStripButton6 = New ToolStripButton()
        Me.ToolStripSeparator2 = New ToolStripSeparator()
        Me.ToolStripButton2 = New ToolStripButton()
        Me.ToolStripSeparator3 = New ToolStripSeparator()
        Me.ToolStripButton3 = New ToolStripButton()
        Me.tslAmmoTotal = New ToolStripLabel()
        Me.HelpProvider1 = New HelpProvider()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CalDataGridViewTextBoxColumn, Me.GrainDataGridViewTextBoxColumn, Me.JacketDataGridViewTextBoxColumn, Me.vel_n, Me.Qty1DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCollectionAmmoBindingSource
        Me.DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.Location = New Point(3, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New Size(711, 272)
        Me.DataGridView1.TabIndex = 0
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
        Me.ManufacturerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'CalDataGridViewTextBoxColumn
        '
        Me.CalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.CalDataGridViewTextBoxColumn.DataPropertyName = "Cal"
        Me.CalDataGridViewTextBoxColumn.HeaderText = "Cal"
        Me.CalDataGridViewTextBoxColumn.Name = "CalDataGridViewTextBoxColumn"
        Me.CalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.CalDataGridViewTextBoxColumn.Width = 63
        '
        'GrainDataGridViewTextBoxColumn
        '
        Me.GrainDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.GrainDataGridViewTextBoxColumn.DataPropertyName = "Grain"
        Me.GrainDataGridViewTextBoxColumn.HeaderText = "Grain"
        Me.GrainDataGridViewTextBoxColumn.Name = "GrainDataGridViewTextBoxColumn"
        Me.GrainDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.GrainDataGridViewTextBoxColumn.Width = 73
        '
        'JacketDataGridViewTextBoxColumn
        '
        Me.JacketDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
        'GunCollectionAmmoBindingSource
        '
        Me.GunCollectionAmmoBindingSource.DataMember = "Gun_Collection_Ammo"
        Me.GunCollectionAmmoBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_AmmoTableAdapter
        '
        Me.Gun_Collection_AmmoTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.tslAmmoTotal})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(732, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New Size(23, 22)
        Me.ToolStripButton4.Text = "Add Ammunition to Collection"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Add to Qty of Selected Ammunition"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        Me.ToolStripButton5.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New Size(23, 22)
        Me.ToolStripButton5.Text = "Add Qty & Audit"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        Me.ToolStripButton6.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New Size(23, 22)
        Me.ToolStripButton6.Text = "View Audit Details"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New Size(6, 25)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'tslAmmoTotal
        '
        Me.tslAmmoTotal.Name = "tslAmmoTotal"
        Me.tslAmmoTotal.Size = New Size(146, 22)
        Me.tslAmmoTotal.Text = "Total Rounds in Inventory:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmViewAmmoInventory
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(732, 326)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Ammunition Inventory")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Ammunition Inventory")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewAmmoInventory"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Ammunition Inventory"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionAmmoBindingSource As BindingSource
    Friend WithEvents Gun_Collection_AmmoTableAdapter As Gun_Collection_AmmoTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents tslAmmoTotal As ToolStripLabel
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents GrainDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents JacketDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents vel_n As DataGridViewTextBoxColumn
    Friend WithEvents Qty1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
