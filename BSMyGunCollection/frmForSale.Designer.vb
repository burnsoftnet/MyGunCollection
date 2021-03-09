Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmForSale
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmForSale))
        Me.ForSaleDataBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Owner_InfoBindingSource = New BindingSource(Me.components)
        Me.qryGunForSaleBindingSource = New BindingSource(Me.components)
        Me.qryGunForSaleTableAdapter = New qryGunForSaleTableAdapter
        Me.Owner_InfoTableAdapter = New Owner_InfoTableAdapter
        Me.ReportViewer1 = New ReportViewer
        Me.ForSaleDataTableAdapter = New ForSaleDataTableAdapter
        CType(Me.ForSaleDataBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.Owner_InfoBindingSource, ISupportInitialize).BeginInit()
        CType(Me.qryGunForSaleBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ForSaleDataBindingSource
        '
        Me.ForSaleDataBindingSource.DataMember = "ForSaleData"
        Me.ForSaleDataBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
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
        Me.qryGunForSaleTableAdapter.ClearBeforeFill = True
        '
        'Owner_InfoTableAdapter
        '
        Me.Owner_InfoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_qryGunForSale"
        ReportDataSource1.Value = Me.ForSaleDataBindingSource
        ReportDataSource2.Name = "MGCDataSet_Owner_Info"
        ReportDataSource2.Value = Me.Owner_InfoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_ForSale.rdlc"
        Me.ReportViewer1.Location = New Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New Size(613, 471)
        Me.ReportViewer1.TabIndex = 0
        '
        'ForSaleDataTableAdapter
        '
        Me.ForSaleDataTableAdapter.ClearBeforeFill = True
        '
        'frmForSale
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(613, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmForSale"
        Me.Text = "Firearm For Sale!!"
        CType(Me.ForSaleDataBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.Owner_InfoBindingSource, ISupportInitialize).EndInit()
        CType(Me.qryGunForSaleBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
