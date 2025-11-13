Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmDbCleanup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDbCleanup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbActionList = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select an Action that you wish to perform on the database:"
        '
        'cbActionList
        '
        Me.cbActionList.AccessibleDescription = "Please Select an Action that you wish to perform on the database:"
        Me.cbActionList.AccessibleName = "cbActionList"
        Me.cbActionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActionList.FormattingEnabled = true
        Me.cbActionList.Items.AddRange(New Object() {"Remove All Data", "Clear Caliber List", "Clear Ammunition List", "Clear Ammunition Audit List", "Clear Collection List", "Clear Grip Types", "Clear Buyer List", "Clear Gun Shop List", "Clear Models and Manufacturers", "Clear Nationality", "Clear Gun Type", "Clear Maintance Plans", "Clear WishList", "Clear Saved Custom Reports"})
        Me.cbActionList.Location = New System.Drawing.Point(16, 36)
        Me.cbActionList.Name = "cbActionList"
        Me.cbActionList.Size = New System.Drawing.Size(179, 21)
        Me.cbActionList.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.AccessibleDescription = "Start"
        Me.btnStart.AccessibleName = "btnStart"
        Me.btnStart.Enabled = false
        Me.btnStart.Location = New System.Drawing.Point(231, 32)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(88, 24)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = true
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 36)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(179, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = false
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.Location = New System.Drawing.Point(16, 64)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 4
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmDbCleanup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 80)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cbActionList)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Database Clean-Up")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Database Clean-Up")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmDbCleanup"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.Text = "Database Clean Up"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbActionList As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
