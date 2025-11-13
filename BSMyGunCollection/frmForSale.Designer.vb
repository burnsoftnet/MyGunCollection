Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmForSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForSale))
        Me.ForSaleDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Owner_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryGunForSaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryGunForSaleTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.qryGunForSaleTableAdapter()
        Me.Owner_InfoTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Owner_InfoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ForSaleDataTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.ForSaleDataTableAdapter()
        CType(Me.ForSaleDataBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Owner_InfoBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.qryGunForSaleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ForSaleDataBindingSource
        '
        Me.ForSaleDataBindingSource.DataMember = "ForSaleData"
        Me.ForSaleDataBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Owner_InfoBindingSource
        '
        Me.Owner_InfoBindingSource.DataMember = "Owner_Info"
        Me.Owner_InfoBindingSource.DataSource = Me.MGCDataSet
        '
        'qryGunForSaleBindingSource
        '
        Me.qryGunForSaleBindingSource.DataMember = "qryGunForSale"
        Me.qryGunForSaleBindingSource.DataSource = Me.MGCDataSet
        '
        'qryGunForSaleTableAdapter
        '
        Me.qryGunForSaleTableAdapter.ClearBeforeFill = true
        '
        'Owner_InfoTableAdapter
        '
        Me.Owner_InfoTableAdapter.ClearBeforeFill = true
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_qryGunForSale"
        ReportDataSource1.Value = Me.ForSaleDataBindingSource
        ReportDataSource2.Name = "MGCDataSet_Owner_Info"
        ReportDataSource2.Value = Me.Owner_InfoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_ForSale.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(613, 471)
        Me.ReportViewer1.TabIndex = 0
        '
        'ForSaleDataTableAdapter
        '
        Me.ForSaleDataTableAdapter.ClearBeforeFill = true
        '
        'frmForSale
        '
        Me.AccessibleDescription = "Firearm For Sale!!"
        Me.AccessibleName = "frmForSale"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmForSale"
        Me.Text = "Firearm For Sale!!"
        CType(Me.ForSaleDataBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Owner_InfoBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.qryGunForSaleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents qryGunForSaleBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents qryGunForSaleTableAdapter As qryGunForSaleTableAdapter
    Friend WithEvents Owner_InfoBindingSource As BindingSource
    Friend WithEvents Owner_InfoTableAdapter As Owner_InfoTableAdapter
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents ForSaleDataBindingSource As BindingSource
    Friend WithEvents ForSaleDataTableAdapter As ForSaleDataTableAdapter
End Class
