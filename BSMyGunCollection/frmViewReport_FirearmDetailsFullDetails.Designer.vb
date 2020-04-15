<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReport_FirearmDetailsFullDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewReport_FirearmDetailsFullDetails))
        Me.FullDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.gryGunMaintanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryGunSmithDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_Collection_AccessoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.FullDetailsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.FullDetailsTableAdapter
        Me.gryGunMaintanceTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.gryGunMaintanceTableAdapter
        Me.qryGunSmithDetailsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.qryGunSmithDetailsTableAdapter
        Me.Gun_Collection_AccessoriesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_AccessoriesTableAdapter
        Me.Gun_Collection_ExtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_Collection_ExtTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_ExtTableAdapter
        CType(Me.FullDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gryGunMaintanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryGunSmithDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_ExtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(540, 290)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 290)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewReport_FirearmDetailsFullDetails"
        Me.Text = "Firearm Full Detailed Report"
        CType(Me.FullDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gryGunMaintanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryGunSmithDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_ExtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FullDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents gryGunMaintanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents qryGunSmithDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FullDetailsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.FullDetailsTableAdapter
    Friend WithEvents gryGunMaintanceTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.gryGunMaintanceTableAdapter
    Friend WithEvents qryGunSmithDetailsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.qryGunSmithDetailsTableAdapter
    Friend WithEvents Gun_Collection_AccessoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_AccessoriesTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_AccessoriesTableAdapter
    Friend WithEvents Gun_Collection_ExtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_ExtTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_ExtTableAdapter
End Class
