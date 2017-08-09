<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveBarrelConKit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoveBarrelConKit))
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.cmbFirearm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.GunCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_CollectionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttach
        '
        Me.btnAttach.Location = New System.Drawing.Point(245, 45)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(63, 22)
        Me.btnAttach.TabIndex = 8
        Me.btnAttach.Text = "Move"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'cmbFirearm
        '
        Me.cmbFirearm.DataSource = Me.GunCollectionBindingSource
        Me.cmbFirearm.DisplayMember = "FullName"
        Me.cmbFirearm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFirearm.FormattingEnabled = True
        Me.cmbFirearm.Location = New System.Drawing.Point(15, 47)
        Me.cmbFirearm.Name = "cmbFirearm"
        Me.cmbFirearm.Size = New System.Drawing.Size(209, 21)
        Me.cmbFirearm.TabIndex = 7
        Me.cmbFirearm.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select the firearm listed below to link this Document to:"
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunCollectionBindingSource
        '
        Me.GunCollectionBindingSource.DataMember = "Gun_Collection"
        Me.GunCollectionBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = True
        '
        'frmMoveBarrelConKit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 83)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.cmbFirearm)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMoveBarrelConKit"
        Me.Text = "Move Barrel/Conversion Kit"
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents cmbFirearm As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter
End Class
