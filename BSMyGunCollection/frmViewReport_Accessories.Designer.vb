Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewReport_Accessories
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewReport_Accessories))
        Me.Gun_Collection_AccessoriesBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_Collection_AccessoriesTableAdapter = New Gun_Collection_AccessoriesTableAdapter
        Me.ToolStrip1 = New ToolStrip
        Me.ReportViewer1 = New ReportViewer
        CType(Me.Gun_Collection_AccessoriesBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gun_Collection_AccessoriesBindingSource
        '
        Me.Gun_Collection_AccessoriesBindingSource.DataMember = "Gun_Collection_Accessories"
        Me.Gun_Collection_AccessoriesBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_AccessoriesTableAdapter
        '
        Me.Gun_Collection_AccessoriesTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New Size(737, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_Gun_Collection_Accessories"
        ReportDataSource1.Value = Me.Gun_Collection_AccessoriesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_Accessories.rdlc"
        Me.ReportViewer1.Location = New Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(737, 326)
        Me.ReportViewer1.TabIndex = 2
        '
        'frmViewReport_Accessories
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(737, 351)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewReport_Accessories"
        Me.Text = "frmViewReport_Accessories"
        CType(Me.Gun_Collection_AccessoriesBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gun_Collection_AccessoriesBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_Collection_AccessoriesTableAdapter As Gun_Collection_AccessoriesTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ReportViewer1 As ReportViewer
End Class
