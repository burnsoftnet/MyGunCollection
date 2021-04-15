Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmCrSelectTable
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmCrSelectTable))
        Me.Label1 = New Label()
        Me.ComboBox1 = New ComboBox()
        Me.CRTableListBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.CR_TableListTableAdapter = New CR_TableListTableAdapter()
        Me.btnNext = New Button()
        Me.cmsNextMenu = New ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ComboBox2 = New ComboBox()
        Me.CRSavedReportsBindingSource = New BindingSource(Me.components)
        Me.CR_SavedReportsTableAdapter = New CR_SavedReportsTableAdapter()
        Me.btnLoadSaved = New Button()
        Me.cmsSavedReports = New ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New ToolStripMenuItem()
        Me.Label2 = New Label()
        Me.HelpProvider1 = New HelpProvider()
        Me.btnSQLEditor = New Button()
        Me.btnEdit = New Button()
        CType(Me.CRTableListBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.cmsNextMenu.SuspendLayout()
        CType(Me.CRSavedReportsBindingSource, ISupportInitialize).BeginInit()
        Me.cmsSavedReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(250, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the Table that you wish to gather Data From:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CRTableListBindingSource
        Me.ComboBox1.DisplayMember = "DN"
        Me.ComboBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.ComboBox1, "Custom Reports")
        Me.HelpProvider1.SetHelpNavigator(Me.ComboBox1, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.ComboBox1, "Custom Reports")
        Me.ComboBox1.Location = New Point(9, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.HelpProvider1.SetShowHelp(Me.ComboBox1, True)
        Me.ComboBox1.Size = New Size(169, 21)
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
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'CR_TableListTableAdapter
        '
        Me.CR_TableListTableAdapter.ClearBeforeFill = True
        '
        'btnNext
        '
        Me.btnNext.ContextMenuStrip = Me.cmsNextMenu
        Me.btnNext.Location = New Point(184, 39)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New Size(58, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'cmsNextMenu
        '
        Me.cmsNextMenu.Items.AddRange(New ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsNextMenu.Name = "cmsNextMenu"
        Me.cmsNextMenu.Size = New Size(183, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New Size(182, 22)
        Me.ToolStripMenuItem1.Text = "New with SQL Editor"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CRSavedReportsBindingSource
        Me.ComboBox2.DisplayMember = "ReportName"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New Point(9, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New Size(169, 21)
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
        Me.btnLoadSaved.ContextMenuStrip = Me.cmsSavedReports
        Me.btnLoadSaved.Location = New Point(184, 88)
        Me.btnLoadSaved.Name = "btnLoadSaved"
        Me.btnLoadSaved.Size = New Size(58, 23)
        Me.btnLoadSaved.TabIndex = 7
        Me.btnLoadSaved.Text = "Load"
        Me.btnLoadSaved.UseVisualStyleBackColor = True
        '
        'cmsSavedReports
        '
        Me.cmsSavedReports.Items.AddRange(New ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cmsSavedReports.Name = "cmsSavedReports"
        Me.cmsSavedReports.Size = New Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(164, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Or you can Load a Saved Report"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'btnSQLEditor
        '
        Me.btnSQLEditor.Location = New Point(248, 39)
        Me.btnSQLEditor.Name = "btnSQLEditor"
        Me.btnSQLEditor.Size = New Size(75, 23)
        Me.btnSQLEditor.TabIndex = 9
        Me.btnSQLEditor.Text = "SQL Editor"
        Me.btnSQLEditor.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New Point(249, 87)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmCR_SelectTable
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(334, 125)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSQLEditor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLoadSaved)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Custom Reports")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Custom Reports")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCrSelectTable"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Custom Report Builder - Select Table"
        CType(Me.CRTableListBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.cmsNextMenu.ResumeLayout(False)
        CType(Me.CRSavedReportsBindingSource, ISupportInitialize).EndInit()
        Me.cmsSavedReports.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents CRTableListBindingSource As BindingSource
    Friend WithEvents CR_TableListTableAdapter As CR_TableListTableAdapter
    Friend WithEvents btnNext As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CRSavedReportsBindingSource As BindingSource
    Friend WithEvents CR_SavedReportsTableAdapter As CR_SavedReportsTableAdapter
    Friend WithEvents btnLoadSaved As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents cmsSavedReports As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsNextMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnSQLEditor As Button
    Friend WithEvents btnEdit As Button
End Class
