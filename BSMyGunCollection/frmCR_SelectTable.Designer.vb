<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCR_SelectTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCR_SelectTable))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CRTableListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.CR_TableListTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.CR_TableListTableAdapter
        Me.btnNext = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.CRSavedReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CR_SavedReportsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.CR_SavedReportsTableAdapter
        Me.btnLoadSaved = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.CRTableListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRSavedReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Table that you wish to gather Data From:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CRTableListBindingSource
        Me.ComboBox1.DisplayMember = "DN"
        Me.ComboBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.ComboBox1, "Custom Reports")
        Me.HelpProvider1.SetHelpNavigator(Me.ComboBox1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.ComboBox1, "Custom Reports")
        Me.ComboBox1.Location = New System.Drawing.Point(9, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.HelpProvider1.SetShowHelp(Me.ComboBox1, True)
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "ID"
        '
        'CRTableListBindingSource
        '
        Me.CRTableListBindingSource.DataMember = "CR_TableList"
        Me.CRTableListBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CR_TableListTableAdapter
        '
        Me.CR_TableListTableAdapter.ClearBeforeFill = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(199, 38)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CRSavedReportsBindingSource
        Me.ComboBox2.DisplayMember = "ReportName"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox2.TabIndex = 6
        Me.ComboBox2.ValueMember = "ID"
        '
        'CRSavedReportsBindingSource
        '
        Me.CRSavedReportsBindingSource.DataMember = "CR_SavedReports"
        Me.CRSavedReportsBindingSource.DataSource = Me.MGCDataSet
        '
        'CR_SavedReportsTableAdapter
        '
        Me.CR_SavedReportsTableAdapter.ClearBeforeFill = True
        '
        'btnLoadSaved
        '
        Me.btnLoadSaved.Location = New System.Drawing.Point(199, 88)
        Me.btnLoadSaved.Name = "btnLoadSaved"
        Me.btnLoadSaved.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadSaved.TabIndex = 7
        Me.btnLoadSaved.Text = "Load"
        Me.btnLoadSaved.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Or you can Load a Saved Report"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmCR_SelectTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 68)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLoadSaved)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Custom Reports")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Custom Reports")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCR_SelectTable"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Custom Report Builder - Select Table"
        CType(Me.CRTableListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRSavedReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents CRTableListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CR_TableListTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.CR_TableListTableAdapter
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CRSavedReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CR_SavedReportsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.CR_SavedReportsTableAdapter
    Friend WithEvents btnLoadSaved As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
