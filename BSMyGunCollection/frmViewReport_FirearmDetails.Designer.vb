Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmViewReportFirearmDetails
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewReportFirearmDetails))
        Me.FullDetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.ReportViewer1 = New ReportViewer
        Me.FullDetailsTableAdapter = New FullDetailsTableAdapter
        CType(Me.FullDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullDetailsBindingSource
        '
        Me.FullDetailsBindingSource.DataMember = "FullDetails"
        Me.FullDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_FullDetails"
        ReportDataSource1.Value = Me.FullDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_FirearmDetails.rdlc"
        Me.ReportViewer1.Location = New Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(522, 459)
        Me.ReportViewer1.TabIndex = 0
        '
        'FullDetailsTableAdapter
        '
        Me.FullDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmViewReport_FirearmDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(522, 459)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewReportFirearmDetails"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Firearm Detailed Report"
        CType(Me.FullDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents FullDetailsBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents FullDetailsTableAdapter As FullDetailsTableAdapter
End Class
