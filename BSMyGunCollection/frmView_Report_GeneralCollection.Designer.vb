<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView_Report_GeneralCollection
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.General_AccessoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.General_AccessoriesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.General_AccessoriesTableAdapter()
        CType(Me.General_AccessoriesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'General_AccessoriesBindingSource
        '
        Me.General_AccessoriesBindingSource.DataMember = "General_Accessories"
        Me.General_AccessoriesBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.General_AccessoriesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_GeneralAccessories.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(917, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'General_AccessoriesTableAdapter
        '
        Me.General_AccessoriesTableAdapter.ClearBeforeFill = true
        '
        'frmView_Report_GeneralCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmView_Report_GeneralCollection"
        Me.Text = "frmView_Report_GeneralCollection"
        CType(Me.General_AccessoriesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents General_AccessoriesBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents General_AccessoriesTableAdapter As MGCDataSetTableAdapters.General_AccessoriesTableAdapter
End Class
