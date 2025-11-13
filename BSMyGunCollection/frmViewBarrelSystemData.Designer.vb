<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBarrelSystemData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewBarrelSystemData))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GunCollectionExtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_Collection_ExtTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_ExtTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GIDDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.ModelNameDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.CaliberDataGridViewTextBoxColumn = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.FinishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarrelLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetLoadsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedsystemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SightsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasedPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasedFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDefaultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GunCollectionExtBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GIDDataGridViewTextBoxColumn, Me.ModelNameDataGridViewTextBoxColumn, Me.CaliberDataGridViewTextBoxColumn, Me.FinishDataGridViewTextBoxColumn, Me.BarrelLengthDataGridViewTextBoxColumn, Me.PetLoadsDataGridViewTextBoxColumn, Me.ActionDataGridViewTextBoxColumn, Me.FeedsystemDataGridViewTextBoxColumn, Me.SightsDataGridViewTextBoxColumn, Me.PurchasedPriceDataGridViewTextBoxColumn, Me.PurchasedFromDataGridViewTextBoxColumn, Me.DtpDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.IsDefaultDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCollectionExtBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'GunCollectionExtBindingSource
        '
        Me.GunCollectionExtBindingSource.DataMember = "Gun_Collection_Ext"
        Me.GunCollectionExtBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_ExtTableAdapter
        '
        Me.Gun_Collection_ExtTableAdapter.ClearBeforeFill = true
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'GIDDataGridViewTextBoxColumn
        '
        Me.GIDDataGridViewTextBoxColumn.DataPropertyName = "GID"
        Me.GIDDataGridViewTextBoxColumn.HeaderText = "GID"
        Me.GIDDataGridViewTextBoxColumn.Name = "GIDDataGridViewTextBoxColumn"
        Me.GIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ModelNameDataGridViewTextBoxColumn
        '
        Me.ModelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName"
        Me.ModelNameDataGridViewTextBoxColumn.HeaderText = "ModelName"
        Me.ModelNameDataGridViewTextBoxColumn.Name = "ModelNameDataGridViewTextBoxColumn"
        Me.ModelNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CaliberDataGridViewTextBoxColumn
        '
        Me.CaliberDataGridViewTextBoxColumn.DataPropertyName = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.HeaderText = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.Name = "CaliberDataGridViewTextBoxColumn"
        Me.CaliberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FinishDataGridViewTextBoxColumn
        '
        Me.FinishDataGridViewTextBoxColumn.DataPropertyName = "Finish"
        Me.FinishDataGridViewTextBoxColumn.HeaderText = "Finish"
        Me.FinishDataGridViewTextBoxColumn.Name = "FinishDataGridViewTextBoxColumn"
        '
        'BarrelLengthDataGridViewTextBoxColumn
        '
        Me.BarrelLengthDataGridViewTextBoxColumn.DataPropertyName = "BarrelLength"
        Me.BarrelLengthDataGridViewTextBoxColumn.HeaderText = "BarrelLength"
        Me.BarrelLengthDataGridViewTextBoxColumn.Name = "BarrelLengthDataGridViewTextBoxColumn"
        '
        'PetLoadsDataGridViewTextBoxColumn
        '
        Me.PetLoadsDataGridViewTextBoxColumn.DataPropertyName = "PetLoads"
        Me.PetLoadsDataGridViewTextBoxColumn.HeaderText = "PetLoads"
        Me.PetLoadsDataGridViewTextBoxColumn.Name = "PetLoadsDataGridViewTextBoxColumn"
        '
        'ActionDataGridViewTextBoxColumn
        '
        Me.ActionDataGridViewTextBoxColumn.DataPropertyName = "Action"
        Me.ActionDataGridViewTextBoxColumn.HeaderText = "Action"
        Me.ActionDataGridViewTextBoxColumn.Name = "ActionDataGridViewTextBoxColumn"
        '
        'FeedsystemDataGridViewTextBoxColumn
        '
        Me.FeedsystemDataGridViewTextBoxColumn.DataPropertyName = "Feedsystem"
        Me.FeedsystemDataGridViewTextBoxColumn.HeaderText = "Feedsystem"
        Me.FeedsystemDataGridViewTextBoxColumn.Name = "FeedsystemDataGridViewTextBoxColumn"
        '
        'SightsDataGridViewTextBoxColumn
        '
        Me.SightsDataGridViewTextBoxColumn.DataPropertyName = "Sights"
        Me.SightsDataGridViewTextBoxColumn.HeaderText = "Sights"
        Me.SightsDataGridViewTextBoxColumn.Name = "SightsDataGridViewTextBoxColumn"
        '
        'PurchasedPriceDataGridViewTextBoxColumn
        '
        Me.PurchasedPriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasedPrice"
        Me.PurchasedPriceDataGridViewTextBoxColumn.HeaderText = "PurchasedPrice"
        Me.PurchasedPriceDataGridViewTextBoxColumn.Name = "PurchasedPriceDataGridViewTextBoxColumn"
        '
        'PurchasedFromDataGridViewTextBoxColumn
        '
        Me.PurchasedFromDataGridViewTextBoxColumn.DataPropertyName = "PurchasedFrom"
        Me.PurchasedFromDataGridViewTextBoxColumn.HeaderText = "PurchasedFrom"
        Me.PurchasedFromDataGridViewTextBoxColumn.Name = "PurchasedFromDataGridViewTextBoxColumn"
        '
        'DtpDataGridViewTextBoxColumn
        '
        Me.DtpDataGridViewTextBoxColumn.DataPropertyName = "dtp"
        Me.DtpDataGridViewTextBoxColumn.HeaderText = "dtp"
        Me.DtpDataGridViewTextBoxColumn.Name = "DtpDataGridViewTextBoxColumn"
        '
        'HeightDataGridViewTextBoxColumn
        '
        Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "Height"
        Me.HeightDataGridViewTextBoxColumn.HeaderText = "Height"
        Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'IsDefaultDataGridViewTextBoxColumn
        '
        Me.IsDefaultDataGridViewTextBoxColumn.DataPropertyName = "IsDefault"
        Me.IsDefaultDataGridViewTextBoxColumn.HeaderText = "IsDefault"
        Me.IsDefaultDataGridViewTextBoxColumn.Name = "IsDefaultDataGridViewTextBoxColumn"
        '
        'frmViewBarrelSystemData
        '
        Me.AccessibleName = "frmViewBarrelSystemData"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmViewBarrelSystemData"
        Me.Text = "Raw Barrel System Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GunCollectionExtBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionExtBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ExtTableAdapter As MGCDataSetTableAdapters.Gun_Collection_ExtTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GIDDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ModelNameDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents CaliberDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents FinishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarrelLengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PetLoadsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedsystemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SightsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedFromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsDefaultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
