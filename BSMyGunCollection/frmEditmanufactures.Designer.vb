Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditmanufactures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditmanufactures))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Gun_ManufacturerTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_ManufacturerTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleName = "gridMain"
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunManufacturerBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(230, 320)
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
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'Gun_ManufacturerTableAdapter
        '
        Me.Gun_ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(230, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.AccessibleName = "mnuExit"
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.ExitToolStripMenuItem.ToolTipText = "Close Window"
        '
        'frmEditmanufactures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 344)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Editing Manufactures")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Editing Manufactures")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditmanufactures"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Edit Manufactures"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunManufacturerBindingSource As BindingSource
    Friend WithEvents Gun_ManufacturerTableAdapter As Gun_ManufacturerTableAdapter
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
