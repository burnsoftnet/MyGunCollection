Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmViewReportFirearmDetailsFullDetails
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
        Dim ReportDataSource3 As ReportDataSource = New ReportDataSource
        Dim ReportDataSource4 As ReportDataSource = New ReportDataSource
        Dim ReportDataSource5 As ReportDataSource = New ReportDataSource
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewReportFirearmDetailsFullDetails))
        Me.FullDetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.gryGunMaintanceBindingSource = New BindingSource(Me.components)
        Me.qryGunSmithDetailsBindingSource = New BindingSource(Me.components)
        Me.Gun_Collection_AccessoriesBindingSource = New BindingSource(Me.components)
        Me.ReportViewer1 = New ReportViewer
        Me.FullDetailsTableAdapter = New FullDetailsTableAdapter
        Me.gryGunMaintanceTableAdapter = New gryGunMaintanceTableAdapter
        Me.qryGunSmithDetailsTableAdapter = New qryGunSmithDetailsTableAdapter
        Me.Gun_Collection_AccessoriesTableAdapter = New Gun_Collection_AccessoriesTableAdapter
        Me.Gun_Collection_ExtBindingSource = New BindingSource(Me.components)
        Me.Gun_Collection_ExtTableAdapter = New Gun_Collection_ExtTableAdapter
        CType(Me.FullDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.gryGunMaintanceBindingSource, ISupportInitialize).BeginInit()
        CType(Me.qryGunSmithDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_AccessoriesBindingSource, ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_ExtBindingSource, ISupportInitialize).BeginInit()
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
        'gryGunMaintanceBindingSource
        '
        Me.gryGunMaintanceBindingSource.DataMember = "gryGunMaintance"
        Me.gryGunMaintanceBindingSource.DataSource = Me.MGCDataSet
        '
        'qryGunSmithDetailsBindingSource
        '
        Me.qryGunSmithDetailsBindingSource.DataMember = "qryGunSmithDetails"
        Me.qryGunSmithDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_Collection_AccessoriesBindingSource
        '
        Me.Gun_Collection_AccessoriesBindingSource.DataMember = "Gun_Collection_Accessories"
        Me.Gun_Collection_AccessoriesBindingSource.DataSource = Me.MGCDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_FullDetails"
        ReportDataSource1.Value = Me.FullDetailsBindingSource
        ReportDataSource2.Name = "MGCDataSet_gryGunMaintance"
        ReportDataSource2.Value = Me.gryGunMaintanceBindingSource
        ReportDataSource3.Name = "MGCDataSet_qryGunSmithDetails"
        ReportDataSource3.Value = Me.qryGunSmithDetailsBindingSource
        ReportDataSource4.Name = "MGCDataSet_Gun_Collection_Accessories"
        ReportDataSource4.Value = Me.Gun_Collection_AccessoriesBindingSource
        ReportDataSource5.Name = "MGCDataSet_Gun_Collection_Ext"
        ReportDataSource5.Value = Me.Gun_Collection_ExtBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_FirearmFullDetailsER.rdlc"
        Me.ReportViewer1.Location = New Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(540, 290)
        Me.ReportViewer1.TabIndex = 0
        '
        'FullDetailsTableAdapter
        '
        Me.FullDetailsTableAdapter.ClearBeforeFill = True
        '
        'gryGunMaintanceTableAdapter
        '
        Me.gryGunMaintanceTableAdapter.ClearBeforeFill = True
        '
        'qryGunSmithDetailsTableAdapter
        '
        Me.qryGunSmithDetailsTableAdapter.ClearBeforeFill = True
        '
        'Gun_Collection_AccessoriesTableAdapter
        '
        Me.Gun_Collection_AccessoriesTableAdapter.ClearBeforeFill = True
        '
        'Gun_Collection_ExtBindingSource
        '
        Me.Gun_Collection_ExtBindingSource.DataMember = "Gun_Collection_Ext"
        Me.Gun_Collection_ExtBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_Collection_ExtTableAdapter
        '
        Me.Gun_Collection_ExtTableAdapter.ClearBeforeFill = True
        '
        'frmViewReport_FirearmDetailsFullDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(540, 290)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewReportFirearmDetailsFullDetails"
        Me.Text = "Firearm Full Detailed Report"
        CType(Me.FullDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.gryGunMaintanceBindingSource, ISupportInitialize).EndInit()
        CType(Me.qryGunSmithDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_AccessoriesBindingSource, ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_ExtBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents FullDetailsBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents gryGunMaintanceBindingSource As BindingSource
    Friend WithEvents qryGunSmithDetailsBindingSource As BindingSource
    Friend WithEvents FullDetailsTableAdapter As FullDetailsTableAdapter
    Friend WithEvents gryGunMaintanceTableAdapter As gryGunMaintanceTableAdapter
    Friend WithEvents qryGunSmithDetailsTableAdapter As qryGunSmithDetailsTableAdapter
    Friend WithEvents Gun_Collection_AccessoriesBindingSource As BindingSource
    Friend WithEvents Gun_Collection_AccessoriesTableAdapter As Gun_Collection_AccessoriesTableAdapter
    Friend WithEvents Gun_Collection_ExtBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ExtTableAdapter As Gun_Collection_ExtTableAdapter
End Class
