<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLinkFromExistingDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLinkFromExistingDoc))
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.GunCollectionDocsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_Collection_DocsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_DocsTableAdapter()
        Me.cmbDoc = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunCollectionDocsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.cmbDoc.Location = New System.Drawing.Point(48, 47)
        Me.cmbDoc.Name = "cmbDoc"
        Me.cmbDoc.Size = New System.Drawing.Size(237, 21)
        Me.cmbDoc.TabIndex = 0
        Me.cmbDoc.ValueMember = "ID"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(210, 75)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select a document from the collection to link to this firearm"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(48, 75)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmLinkFromExistingDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 110)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbDoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLinkFromExistingDoc"
        Me.Text = "Document Collection"
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunCollectionDocsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionDocsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_DocsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_DocsTableAdapter
    Friend WithEvents cmbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
