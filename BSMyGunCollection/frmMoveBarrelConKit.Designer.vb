Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmMoveBarrelConKit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoveBarrelConKit))
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.cmbFirearm = New System.Windows.Forms.ComboBox()
        Me.GunCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gun_CollectionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter()
        CType(Me.GunCollectionBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnAttach
        '
        Me.btnAttach.AccessibleDescription = "Move, and close form"
        Me.btnAttach.AccessibleName = "btnAttach"
        Me.btnAttach.Location = New System.Drawing.Point(245, 45)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(63, 22)
        Me.btnAttach.TabIndex = 8
        Me.btnAttach.Text = "Move"
        Me.btnAttach.UseVisualStyleBackColor = true
        '
        'cmbFirearm
        '
        Me.cmbFirearm.AccessibleDescription = "Select the firearm listed below to link this Document to:"
        Me.cmbFirearm.AccessibleName = "cmbFirearm"
        Me.cmbFirearm.DataSource = Me.GunCollectionBindingSource
        Me.cmbFirearm.DisplayMember = "FullName"
        Me.cmbFirearm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFirearm.FormattingEnabled = true
        Me.cmbFirearm.Location = New System.Drawing.Point(15, 47)
        Me.cmbFirearm.Name = "cmbFirearm"
        Me.cmbFirearm.Size = New System.Drawing.Size(209, 21)
        Me.cmbFirearm.TabIndex = 7
        Me.cmbFirearm.ValueMember = "ID"
        '
        'GunCollectionBindingSource
        '
        Me.GunCollectionBindingSource.DataMember = "Gun_Collection"
        Me.GunCollectionBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select the firearm listed below to link this Document to:"
        '
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = true
        '
        'frmMoveBarrelConKit
        '
        Me.AccessibleDescription = "Move Barrel/Conversion Kit"
        Me.AccessibleName = "frmMoveBarrelConKit"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 83)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.cmbFirearm)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmMoveBarrelConKit"
        Me.Text = "Move Barrel/Conversion Kit"
        CType(Me.GunCollectionBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnAttach As Button
    Friend WithEvents cmbFirearm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionBindingSource As BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As Gun_CollectionTableAdapter
End Class
