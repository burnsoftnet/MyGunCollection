Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditAmmunitionType
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditAmmunitionType))
        Me.DataGridView1 = New DataGridView
        Me.CalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Me.GunCalBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_CalTableAdapter = New Gun_CalTableAdapter
        Me.HelpProvider1 = New HelpProvider
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunCalBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.CalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GunCalBindingSource
        Me.DataGridView1.Location = New Point(2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New Size(258, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'CalDataGridViewTextBoxColumn
        '
        Me.CalDataGridViewTextBoxColumn.DataPropertyName = "Cal"
        Me.CalDataGridViewTextBoxColumn.HeaderText = "Caliber"
        Me.CalDataGridViewTextBoxColumn.Name = "CalDataGridViewTextBoxColumn"
        Me.CalDataGridViewTextBoxColumn.Width = 200
        '
        'GunCalBindingSource
        '
        Me.GunCalBindingSource.DataMember = "Gun_Cal"
        Me.GunCalBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_CalTableAdapter
        '
        Me.Gun_CalTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditAmmunitionType
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(265, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Editing Ammunition Type")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Editing Ammunition Type")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmEditAmmunitionType"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Edit Ammunition Type"
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunCalBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCalBindingSource As BindingSource
    Friend WithEvents Gun_CalTableAdapter As Gun_CalTableAdapter
    Friend WithEvents CalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
