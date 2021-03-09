Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmViewAppraisers
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewAppraisers))
        Me.ToolStrip1 = New ToolStrip()
        Me.ToolStripButton1 = New ToolStripButton()
        Me.ToolStripSeparator1 = New ToolStripSeparator()
        Me.ToolStripButton2 = New ToolStripButton()
        Me.ToolStripSeparator2 = New ToolStripSeparator()
        Me.ToolStripButton3 = New ToolStripButton()
        Me.ListBox1 = New ListBox()
        Me.AppriaserContactDetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Appriaser_Contact_DetailsTableAdapter = New Appriaser_Contact_DetailsTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AppriaserContactDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(211, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Add a Shop"
        Me.ToolStripButton1.ToolTipText = "Add a Shop to the database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Delete Shop"
        Me.ToolStripButton2.ToolTipText = "Delete a Shop from the Database."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(23, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.AppriaserContactDetailsBindingSource
        Me.ListBox1.DisplayMember = "aName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New Point(0, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(206, 290)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.ValueMember = "ID"
        '
        'AppriaserContactDetailsBindingSource
        '
        Me.AppriaserContactDetailsBindingSource.DataMember = "Appriaser_Contact_Details"
        Me.AppriaserContactDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Appriaser_Contact_DetailsTableAdapter
        '
        Me.Appriaser_Contact_DetailsTableAdapter.ClearBeforeFill = True
        '
        'frmViewAppraisers
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(211, 322)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewAppraisers"
        Me.Text = "View Appraisers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AppriaserContactDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents AppriaserContactDetailsBindingSource As BindingSource
    Friend WithEvents Appriaser_Contact_DetailsTableAdapter As Appriaser_Contact_DetailsTableAdapter
End Class
