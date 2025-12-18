Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewReport_FirearmSaleInvoice
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewReport_FirearmSaleInvoice))
        Me.Gun_Collection_SoldToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.ForSaleDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Gun_Collection_SoldToTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_SoldToTableAdapter()
        Me.ForSaleDataTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.ForSaleDataTableAdapter()
        CType(Me.Gun_Collection_SoldToBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ForSaleDataBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Gun_Collection_SoldToBindingSource
        '
        Me.Gun_Collection_SoldToBindingSource.DataMember = "Gun_Collection_SoldTo"
        Me.Gun_Collection_SoldToBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ForSaleDataBindingSource
        '
        Me.ForSaleDataBindingSource.DataMember = "ForSaleData"
        Me.ForSaleDataBindingSource.DataSource = Me.MGCDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_Gun_Collection_SoldTo"
        ReportDataSource1.Value = Me.Gun_Collection_SoldToBindingSource
        ReportDataSource2.Name = "MGCDataSet_ForSaleData"
        ReportDataSource2.Value = Me.ForSaleDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_FirearmSaleInvoice.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(973, 668)
        Me.ReportViewer1.TabIndex = 0
        '
        'Gun_Collection_SoldToTableAdapter
        '
        Me.Gun_Collection_SoldToTableAdapter.ClearBeforeFill = true
        '
        'ForSaleDataTableAdapter
        '
        Me.ForSaleDataTableAdapter.ClearBeforeFill = true
        '
        'frmViewReport_FirearmSaleInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 668)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmViewReport_FirearmSaleInvoice"
        Me.Text = "Firearm Sale Invoice"
        CType(Me.Gun_Collection_SoldToBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ForSaleDataBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents Gun_Collection_SoldToBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_Collection_SoldToTableAdapter As Gun_Collection_SoldToTableAdapter
    Friend WithEvents ForSaleDataBindingSource As BindingSource
    Friend WithEvents ForSaleDataTableAdapter As ForSaleDataTableAdapter
End Class
