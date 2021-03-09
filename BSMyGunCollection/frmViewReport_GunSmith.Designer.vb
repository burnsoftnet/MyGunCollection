Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewReport_GunSmith
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
        Dim ReportDataSource2 As ReportDataSource = New ReportDataSource
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewReport_GunSmith))
        Me.GunSmith_DetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.qryGunSmithDetailsBindingSource = New BindingSource(Me.components)
        Me.ReportViewer1 = New ReportViewer
        Me.GunSmith_DetailsTableAdapter = New GunSmith_DetailsTableAdapter
        Me.qryGunSmithDetailsTableAdapter = New qryGunSmithDetailsTableAdapter
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripLabel1 = New ToolStripLabel
        Me.ToolStripComboBox1 = New ToolStripComboBox
        CType(Me.GunSmith_DetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.qryGunSmithDetailsBindingSource, ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunSmith_DetailsBindingSource
        '
        Me.GunSmith_DetailsBindingSource.DataMember = "GunSmith_Details"
        Me.GunSmith_DetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'qryGunSmithDetailsBindingSource
        '
        Me.qryGunSmithDetailsBindingSource.DataMember = "qryGunSmithDetails"
        Me.qryGunSmithDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_GunSmith_Details"
        ReportDataSource1.Value = Me.GunSmith_DetailsBindingSource
        ReportDataSource2.Name = "MGCDataSet_qryGunSmithDetails"
        ReportDataSource2.Value = Me.qryGunSmithDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_GunSmith.rdlc"
        Me.ReportViewer1.Location = New Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(521, 352)
        Me.ReportViewer1.TabIndex = 0
        '
        'GunSmith_DetailsTableAdapter
        '
        Me.GunSmith_DetailsTableAdapter.ClearBeforeFill = True
        '
        'qryGunSmithDetailsTableAdapter
        '
        Me.qryGunSmithDetailsTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(521, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New Size(46, 22)
        Me.ToolStripLabel1.Text = "Sort By:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Default", "Gun Smith", "Ship Date", "Receive Date"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New Size(121, 25)
        Me.ToolStripComboBox1.Text = "Default"
        '
        'frmViewReport_GunSmith
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(521, 377)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewReport_GunSmith"
        Me.Text = "Gun Smith Report"
        CType(Me.GunSmith_DetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.qryGunSmithDetailsBindingSource, ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents GunSmith_DetailsBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents qryGunSmithDetailsBindingSource As BindingSource
    Friend WithEvents GunSmith_DetailsTableAdapter As GunSmith_DetailsTableAdapter
    Friend WithEvents qryGunSmithDetailsTableAdapter As qryGunSmithDetailsTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
End Class
