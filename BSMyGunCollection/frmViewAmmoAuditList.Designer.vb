Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports DataGridViewAutoFilter
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewAmmoAuditList
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewAmmoAuditList))
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripButton2 = New ToolStripButton
        Me.ToolStripButton1 = New ToolStripButton
        Me.ToolStripButton3 = New ToolStripButton
        Me.DataGridView1 = New DataGridView
        Me.GunCollectionAmmoPriceAuditBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.HelpProvider1 = New HelpProvider
        Me.Gun_Collection_Ammo_PriceAuditTableAdapter = New Gun_Collection_Ammo_PriceAuditTableAdapter
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.DTADataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.QtyDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.PricePaidDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.PPB = New DataGridViewTextBoxColumn
        Me.store = New DataGridViewAutoFilterTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAmmoPriceAuditBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(554, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Calculate and Update Price Per Bullet"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(23, 22)
        Me.ToolStripButton3.Text = "Close"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DTADataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.PricePaidDataGridViewTextBoxColumn, Me.PPB, Me.store})
        Me.DataGridView1.DataSource = Me.GunCollectionAmmoPriceAuditBindingSource
        Me.DataGridView1.Dock = DockStyle.Fill
        Me.DataGridView1.Location = New Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New Size(554, 295)
        Me.DataGridView1.TabIndex = 1
        '
        'GunCollectionAmmoPriceAuditBindingSource
        '
        Me.GunCollectionAmmoPriceAuditBindingSource.DataMember = "Gun_Collection_Ammo_PriceAudit"
        Me.GunCollectionAmmoPriceAuditBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_Ammo_PriceAuditTableAdapter
        '
        Me.Gun_Collection_Ammo_PriceAuditTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DTADataGridViewTextBoxColumn
        '
        Me.DTADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.DTADataGridViewTextBoxColumn.DataPropertyName = "DTA"
        Me.DTADataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DTADataGridViewTextBoxColumn.Name = "DTADataGridViewTextBoxColumn"
        Me.DTADataGridViewTextBoxColumn.Width = 89
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.Width = 48
        '
        'PricePaidDataGridViewTextBoxColumn
        '
        Me.PricePaidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.PricePaidDataGridViewTextBoxColumn.DataPropertyName = "PricePaid"
        Me.PricePaidDataGridViewTextBoxColumn.HeaderText = "Price Paid"
        Me.PricePaidDataGridViewTextBoxColumn.Name = "PricePaidDataGridViewTextBoxColumn"
        Me.PricePaidDataGridViewTextBoxColumn.Width = 80
        '
        'PPB
        '
        Me.PPB.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.PPB.DataPropertyName = "PPB"
        Me.PPB.HeaderText = "Price Per Bullet"
        Me.PPB.Name = "PPB"
        Me.PPB.Width = 96
        '
        'store
        '
        Me.store.DataPropertyName = "store"
        Me.store.HeaderText = "Store Name"
        Me.store.Name = "store"
        Me.store.SortMode = DataGridViewColumnSortMode.Programmatic
        '
        'frmViewAmmoAuditList
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(554, 320)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewAmmoAuditList"
        Me.Text = "Ammo Audit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunCollectionAmmoPriceAuditBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionAmmoPriceAuditBindingSource As BindingSource
    Friend WithEvents Gun_Collection_Ammo_PriceAuditTableAdapter As Gun_Collection_Ammo_PriceAuditTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PPB As DataGridViewTextBoxColumn
    Friend WithEvents store As DataGridViewAutoFilterTextBoxColumn
End Class
