Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewReport_Insurance_InsuredValue_wTotal
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
        Dim ReportDataSource1 As ReportDataSource = New ReportDataSource
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewReport_Insurance_InsuredValue_wTotal))
        Me.qryGunCollectionDetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.ReportViewer1 = New ReportViewer
        Me.qryGunCollectionDetailsTableAdapter = New qryGunCollectionDetailsTableAdapter
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripLabel1 = New ToolStripLabel
        Me.ToolStripComboBox1 = New ToolStripComboBox
        CType(Me.qryGunCollectionDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'qryGunCollectionDetailsBindingSource
        '
        Me.qryGunCollectionDetailsBindingSource.DataMember = "qryGunCollectionDetails"
        Me.qryGunCollectionDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_qryGunCollectionDetails"
        ReportDataSource1.Value = Me.qryGunCollectionDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_Insurance_InsuredValue_wTotal.rdlc"
        Me.ReportViewer1.Location = New Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(401, 228)
        Me.ReportViewer1.TabIndex = 0
        '
        'qryGunCollectionDetailsTableAdapter
        '
        Me.qryGunCollectionDetailsTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(401, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New Size(49, 22)
        Me.ToolStripLabel1.Text = "Sort By: "
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Default", "Price", "Custom Catalog No.", "Caliber", "Type"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New Size(121, 25)
        Me.ToolStripComboBox1.Text = "Default"
        '
        'frmViewReport_Insurance_InsuredValue_wTotal
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(401, 253)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewReport_Insurance_InsuredValue_wTotal"
        Me.Text = "Insurance Report By Insured Value with Total"
        CType(Me.qryGunCollectionDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents qryGunCollectionDetailsBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents qryGunCollectionDetailsTableAdapter As qryGunCollectionDetailsTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
End Class
