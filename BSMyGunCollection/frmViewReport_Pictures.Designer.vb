<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReport_Pictures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewReport_Pictures))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.Gun_Collection_PicturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_Collection_PicturesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_PicturesTableAdapter
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun_Collection_PicturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_Gun_Collection_Pictures"
        ReportDataSource1.Value = Me.Gun_Collection_PicturesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_Pictures_AllPictureDetails.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(680, 471)
        Me.ReportViewer1.TabIndex = 0
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewReport_Pictures"
        Me.Text = "frmViewReport_Pictures"
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun_Collection_PicturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Gun_Collection_PicturesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents Gun_Collection_PicturesTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_PicturesTableAdapter
End Class
