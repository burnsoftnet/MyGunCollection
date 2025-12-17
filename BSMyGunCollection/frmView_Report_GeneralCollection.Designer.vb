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
        Me.MgcDataSet1 = New BSMyGunCollection.MGCDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.General_AccessoriesTableAdapter1 = New BSMyGunCollection.MGCDataSetTableAdapters.General_AccessoriesTableAdapter()
        CType(Me.MgcDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
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
        'MgcDataSet1
        '
        Me.MgcDataSet1.DataSetName = "MGCDataSet"
        Me.MgcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.MgcDataSet1
        Me.BindingSource1.Position = 0
        '
        'General_AccessoriesTableAdapter1
        '
        Me.General_AccessoriesTableAdapter1.ClearBeforeFill = true
        '
        'frmView_Report_GeneralCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmView_Report_GeneralCollection"
        Me.Text = "frmView_Report_GeneralCollection"
        CType(Me.MgcDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MgcDataSet1 As MGCDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents General_AccessoriesTableAdapter1 As MGCDataSetTableAdapters.General_AccessoriesTableAdapter
End Class
