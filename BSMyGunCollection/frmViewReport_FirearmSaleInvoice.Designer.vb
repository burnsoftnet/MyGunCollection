Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmViewReportFirearmSaleInvoice
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmViewReportFirearmSaleInvoice))
        Me.ReportViewer1 = New ReportViewer
        Me.Gun_Collection_SoldToBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Gun_Collection_SoldToTableAdapter = New Gun_Collection_SoldToTableAdapter
        Me.ForSaleDataBindingSource = New BindingSource(Me.components)
        Me.ForSaleDataTableAdapter = New ForSaleDataTableAdapter
        CType(Me.Gun_Collection_SoldToBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.ForSaleDataBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_Gun_Collection_SoldTo"
        ReportDataSource1.Value = Me.Gun_Collection_SoldToBindingSource
        ReportDataSource2.Name = "MGCDataSet_ForSaleData"
        ReportDataSource2.Value = Me.ForSaleDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_FirearmSaleInvoice.rdlc"
        Me.ReportViewer1.Location = New Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(643, 489)
        Me.ReportViewer1.TabIndex = 0
        '
        'Gun_Collection_SoldToBindingSource
        '
        Me.Gun_Collection_SoldToBindingSource.DataMember = "Gun_Collection_SoldTo"
        Me.Gun_Collection_SoldToBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_SoldToTableAdapter
        '
        Me.Gun_Collection_SoldToTableAdapter.ClearBeforeFill = True
        '
        'ForSaleDataBindingSource
        '
        Me.ForSaleDataBindingSource.DataMember = "ForSaleData"
        Me.ForSaleDataBindingSource.DataSource = Me.MGCDataSet
        '
        'ForSaleDataTableAdapter
        '
        Me.ForSaleDataTableAdapter.ClearBeforeFill = True
        '
        'frmViewReport_FirearmSaleInvoice
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(643, 489)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "FrmViewReportFirearmSaleInvoice"
        Me.Text = "Firearm Sale Invoice"
        CType(Me.Gun_Collection_SoldToBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.ForSaleDataBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents Gun_Collection_SoldToBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_Collection_SoldToTableAdapter As Gun_Collection_SoldToTableAdapter
    Friend WithEvents ForSaleDataBindingSource As BindingSource
    Friend WithEvents ForSaleDataTableAdapter As ForSaleDataTableAdapter
End Class
