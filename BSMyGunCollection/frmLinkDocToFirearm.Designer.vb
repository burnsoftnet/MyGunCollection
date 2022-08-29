Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmLinkDocToFirearm
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmLinkDocToFirearm))
        Me.btnAttach = New Button()
        Me.ComboBox1 = New ComboBox()
        Me.Label1 = New Label()
        Me.MGCDataSet = New MGCDataSet()
        Me.GunCollectionBindingSource = New BindingSource(Me.components)
        Me.Gun_CollectionTableAdapter = New Gun_CollectionTableAdapter()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttach
        '
        Me.btnAttach.Location = New Point(214, 45)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New Size(63, 22)
        Me.btnAttach.TabIndex = 5
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GunCollectionBindingSource
        Me.ComboBox1.DisplayMember = "FullName"
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New Point(15, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(180, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.Location = New Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(279, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the firearm listed below to link this Document to:"
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
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
        'frmLinkDocToFirearm
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(298, 93)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLinkDocToFirearm"
        Me.Text = "Link Document to Firearm"
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.GunCollectionBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAttach As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionBindingSource As BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As Gun_CollectionTableAdapter
End Class
