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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.General_Accessories_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_Collection_AccessoriesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_AccessoriesTableAdapter()
        Me.General_AccessoriesTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.General_AccessoriesTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.General_Accessories_BindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.FillByToolStrip.SuspendLayout
        Me.SuspendLayout
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_GeneralAccessories.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'General_Accessories_BindingSource
        '
        Me.General_Accessories_BindingSource.DataSource = Me.MGCDataSet
        Me.General_Accessories_BindingSource.Position = 0
        '
        'Gun_Collection_AccessoriesTableAdapter
        '
        Me.Gun_Collection_AccessoriesTableAdapter.ClearBeforeFill = true
        '
        'General_AccessoriesTableAdapter
        '
        Me.General_AccessoriesTableAdapter.ClearBeforeFill = true
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(111, 25)
        Me.FillByToolStrip.TabIndex = 1
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'frmView_Report_GeneralCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmView_Report_GeneralCollection"
        Me.Text = "frmView_Report_GeneralCollection"
        CType(Me.MGCDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.General_Accessories_BindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.FillByToolStrip.ResumeLayout(false)
        Me.FillByToolStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents General_Accessories_BindingSource As BindingSource
    Friend WithEvents Gun_Collection_AccessoriesTableAdapter As MGCDataSetTableAdapters.Gun_Collection_AccessoriesTableAdapter
    Friend WithEvents General_AccessoriesTableAdapter As MGCDataSetTableAdapters.General_AccessoriesTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
