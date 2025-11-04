<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLinkAccessoryToFirearm
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
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_CollectionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter()
        CType(Me.GunCollectionBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnAttach
        '
        Me.btnAttach.AccessibleDescription = "Attach selected foc to firearm"
        Me.btnAttach.AccessibleName = "btnAttach"
        Me.btnAttach.Location = New System.Drawing.Point(214, 45)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(63, 22)
        Me.btnAttach.TabIndex = 8
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = true
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleDescription = "Select the firearm listed below to link this Document to:"
        Me.ComboBox1.AccessibleName = "ComboBox1"
        Me.ComboBox1.DataSource = Me.GunCollectionBindingSource
        Me.ComboBox1.DisplayMember = "FullName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(15, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select the firearm listed below to link this Accessory to:"
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
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = true
        '
        'FrmLinkAccessoryToFirearm
        '
        Me.AccessibleDescription = "Link Accessory to Firearm"
        Me.AccessibleName = "FrmLinkAccessoryToFirearm"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 98)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLinkAccessoryToFirearm"
        Me.Text = "Link Accessory to Firearm"
        CType(Me.GunCollectionBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnAttach As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunCollectionBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_CollectionTableAdapter As MGCDataSetTableAdapters.Gun_CollectionTableAdapter
End Class
