Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewReport_Pictures
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewReport_Pictures))
        Me.ReportViewer1 = New ReportViewer
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_Collection_PicturesBindingSource = New BindingSource(Me.components)
        Me.Gun_Collection_PicturesTableAdapter = New Gun_Collection_PicturesTableAdapter
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_PicturesBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_Gun_Collection_Pictures"
        ReportDataSource1.Value = Me.Gun_Collection_PicturesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_Pictures_AllPictureDetails.rdlc"
        Me.ReportViewer1.Location = New Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(680, 471)
        Me.ReportViewer1.TabIndex = 0
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_PicturesBindingSource
        '
        Me.Gun_Collection_PicturesBindingSource.DataMember = "Gun_Collection_Pictures"
        Me.Gun_Collection_PicturesBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_Collection_PicturesTableAdapter
        '
        Me.Gun_Collection_PicturesTableAdapter.ClearBeforeFill = True
        '
        'frmViewReport_Pictures
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(680, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewReport_Pictures"
        Me.Text = "frmViewReport_Pictures"
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_PicturesBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents Gun_Collection_PicturesBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_Collection_PicturesTableAdapter As Gun_Collection_PicturesTableAdapter
End Class
