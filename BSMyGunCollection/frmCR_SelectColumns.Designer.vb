Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmCrSelectColumns
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmCrSelectColumns))
        Me.txtSQL = New TextBox
        Me.btnGetData = New Button
        Me.CheckedListBox1 = New CheckedListBox
        Me.BindingSource1 = New BindingSource(Me.components)
        Me.btnGSQL = New Button
        Me.Label1 = New Label
        Me.btnShowSQL = New Button
        Me.btnHideSQL = New Button
        Me.HelpProvider1 = New HelpProvider
        CType(Me.BindingSource1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSQL
        '
        Me.txtSQL.Location = New Point(12, 166)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New Size(391, 121)
        Me.txtSQL.TabIndex = 4
        '
        'btnGetData
        '
        Me.btnGetData.Location = New Point(149, 125)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New Size(75, 23)
        Me.btnGetData.TabIndex = 3
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New Point(12, 25)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New Size(273, 94)
        Me.CheckedListBox1.TabIndex = 5
        '
        'btnGSQL
        '
        Me.btnGSQL.Location = New Point(302, 293)
        Me.btnGSQL.Name = "btnGSQL"
        Me.btnGSQL.Size = New Size(104, 23)
        Me.btnGSQL.TabIndex = 6
        Me.btnGSQL.Text = "Generate SQL"
        Me.btnGSQL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(279, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select the Columns that you wish to include in your report."
        '
        'btnShowSQL
        '
        Me.btnShowSQL.Location = New Point(12, 124)
        Me.btnShowSQL.Name = "btnShowSQL"
        Me.btnShowSQL.Size = New Size(75, 23)
        Me.btnShowSQL.TabIndex = 8
        Me.btnShowSQL.Text = "Show SQL"
        Me.btnShowSQL.UseVisualStyleBackColor = True
        '
        'btnHideSQL
        '
        Me.btnHideSQL.Location = New Point(12, 125)
        Me.btnHideSQL.Name = "btnHideSQL"
        Me.btnHideSQL.Size = New Size(75, 23)
        Me.btnHideSQL.TabIndex = 9
        Me.btnHideSQL.Text = "Hide SQL"
        Me.btnHideSQL.UseVisualStyleBackColor = True
        Me.btnHideSQL.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmCR_SelectColumns
        '
        Me.AcceptButton = Me.btnGetData
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(297, 154)
        Me.Controls.Add(Me.btnHideSQL)
        Me.Controls.Add(Me.btnShowSQL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGSQL)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.btnGetData)
        Me.HelpProvider1.SetHelpKeyword(Me, "Custom Reports - Selecting the columns")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Custom Reports - Selecting the columns")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCrSelectColumns"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Custom Report Builder - Select Columns"
        CType(Me.BindingSource1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQL As TextBox
    Friend WithEvents btnGetData As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnGSQL As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowSQL As Button
    Friend WithEvents btnHideSQL As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
