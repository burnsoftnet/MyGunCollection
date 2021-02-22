<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReport_Quickinv_w_DetailNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewReport_Quickinv_w_DetailNotes))
        Me.FullDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.FullDetailsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.FullDetailsTableAdapter
        CType(Me.FullDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "Sort By: "
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Default", "Manufacturer", "Type", "Caliber"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStripComboBox1.Text = "Default"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MGCDataSet_FullDetails"
        ReportDataSource1.Value = Me.FullDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSMyGunCollection.Report_QuickDetails.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 25)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(683, 465)
        Me.ReportViewer1.TabIndex = 1
        '
        'FullDetailsTableAdapter
        '
        Me.FullDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmViewReport_Quickinv_w_DetailNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 490)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewReport_Quickinv_w_DetailNotes"
        Me.Text = "Quick Collection Report w/ Notes"
        CType(Me.FullDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FullDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents FullDetailsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.FullDetailsTableAdapter
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
End Class
