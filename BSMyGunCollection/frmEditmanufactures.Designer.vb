<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditmanufactures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditmanufactures))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GunManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.Gun_ManufacturerTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_ManufacturerTableAdapter
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunManufacturerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(226, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Manufacture Name"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.Width = 165
        '
        'GunManufacturerBindingSource
        '
        Me.GunManufacturerBindingSource.DataMember = "Gun_Manufacturer"
        Me.GunManufacturerBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_ManufacturerTableAdapter
        '
        Me.Gun_ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditmanufactures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 346)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Editing Manufactures")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Editing Manufactures")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditmanufactures"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Edit Manufactures"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunManufacturerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_ManufacturerTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_ManufacturerTableAdapter
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
