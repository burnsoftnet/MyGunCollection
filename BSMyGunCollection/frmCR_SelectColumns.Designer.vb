Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmCR_SelectColumns
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCR_SelectColumns))
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGSQL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowSQL = New System.Windows.Forms.Button()
        Me.btnHideSQL = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(12, 166)
        Me.txtSQL.Multiline = true
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(391, 121)
        Me.txtSQL.TabIndex = 4
        '
        'btnGetData
        '
        Me.btnGetData.AccessibleDescription = "Get Data Button"
        Me.btnGetData.AccessibleName = "btnGetData"
        Me.btnGetData.Location = New System.Drawing.Point(149, 125)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(75, 23)
        Me.btnGetData.TabIndex = 3
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = true
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AccessibleDescription = "Select the Columns that you wish to include in your report."
        Me.CheckedListBox1.AccessibleName = "CheckedListBox1"
        Me.CheckedListBox1.CheckOnClick = true
        Me.CheckedListBox1.FormattingEnabled = true
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 25)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(273, 94)
        Me.CheckedListBox1.TabIndex = 5
        '
        'btnGSQL
        '
        Me.btnGSQL.Location = New System.Drawing.Point(302, 293)
        Me.btnGSQL.Name = "btnGSQL"
        Me.btnGSQL.Size = New System.Drawing.Size(104, 23)
        Me.btnGSQL.TabIndex = 6
        Me.btnGSQL.Text = "Generate SQL"
        Me.btnGSQL.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select the Columns that you wish to include in your report."
        '
        'btnShowSQL
        '
        Me.btnShowSQL.Location = New System.Drawing.Point(12, 124)
        Me.btnShowSQL.Name = "btnShowSQL"
        Me.btnShowSQL.Size = New System.Drawing.Size(75, 23)
        Me.btnShowSQL.TabIndex = 8
        Me.btnShowSQL.Text = "Show SQL"
        Me.btnShowSQL.UseVisualStyleBackColor = true
        '
        'btnHideSQL
        '
        Me.btnHideSQL.AccessibleDescription = "Hide SQL Button"
        Me.btnHideSQL.AccessibleName = "btnHideSQL"
        Me.btnHideSQL.Location = New System.Drawing.Point(12, 125)
        Me.btnHideSQL.Name = "btnHideSQL"
        Me.btnHideSQL.Size = New System.Drawing.Size(75, 23)
        Me.btnHideSQL.TabIndex = 9
        Me.btnHideSQL.Text = "Hide SQL"
        Me.btnHideSQL.UseVisualStyleBackColor = true
        Me.btnHideSQL.Visible = false
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmCR_SelectColumns
        '
        Me.AcceptButton = Me.btnGetData
        Me.AccessibleDescription = "Custom Report Builder - Select Columns"
        Me.AccessibleName = "frmCR_SelectColumns"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 154)
        Me.Controls.Add(Me.btnHideSQL)
        Me.Controls.Add(Me.btnShowSQL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGSQL)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.btnGetData)
        Me.HelpProvider1.SetHelpKeyword(Me, "Custom Reports - Selecting the columns")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Custom Reports - Selecting the columns")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmCR_SelectColumns"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.Text = "Custom Report Builder - Select Columns"
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

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
