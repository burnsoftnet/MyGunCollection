Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmLinkFromExistingDoc
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmLinkFromExistingDoc))
        Me.MGCDataSet = New MGCDataSet()
        Me.GunCollectionDocsBindingSource = New BindingSource(Me.components)
        Me.Gun_Collection_DocsTableAdapter = New Gun_Collection_DocsTableAdapter()
        Me.cmbDoc = New ComboBox()
        Me.btnAdd = New Button()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.btnCancel = New Button()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionDocsBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'GunCollectionDocsBindingSource
        '
        Me.GunCollectionDocsBindingSource.DataMember = "Gun_Collection_Docs"
        Me.GunCollectionDocsBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_Collection_DocsTableAdapter
        '
        Me.Gun_Collection_DocsTableAdapter.ClearBeforeFill = True
        '
        'cmbDoc
        '
        Me.cmbDoc.DataSource = Me.GunCollectionDocsBindingSource
        Me.cmbDoc.DisplayMember = "doc_name"
        Me.cmbDoc.FormattingEnabled = True
        Me.cmbDoc.Location = New Point(48, 47)
        Me.cmbDoc.Name = "cmbDoc"
        Me.cmbDoc.Size = New Size(237, 21)
        Me.cmbDoc.TabIndex = 0
        Me.cmbDoc.ValueMember = "ID"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(210, 75)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(281, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select a document from the collection to link to this firearm"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New Point(48, 75)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmLinkFromExistingDoc
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(301, 110)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbDoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLinkFromExistingDoc"
        Me.Text = "Document Collection"
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.GunCollectionDocsBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionDocsBindingSource As BindingSource
    Friend WithEvents Gun_Collection_DocsTableAdapter As Gun_Collection_DocsTableAdapter
    Friend WithEvents cmbDoc As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
End Class
