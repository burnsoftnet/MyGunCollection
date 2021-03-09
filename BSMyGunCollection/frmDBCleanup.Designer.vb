Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmDbCleanup
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmDBCleanup))
        Me.Label1 = New Label
        Me.cbActionList = New ComboBox
        Me.btnStart = New Button
        Me.ProgressBar1 = New ProgressBar
        Me.lblStatus = New Label
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(318, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select an Action that you wish to perform on the database:"
        '
        'cbActionList
        '
        Me.cbActionList.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbActionList.FormattingEnabled = True
        Me.cbActionList.Items.AddRange(New Object() {"Remove All Data", "Clear Caliber List", "Clear Ammunition List", "Clear Ammunition Audit List", "Clear Collection List", "Clear Grip Types", "Clear Buyer List", "Clear Gun Shop List", "Clear Models and Manufacturers", "Clear Nationality", "Clear Gun Type", "Clear Maintance Plans", "Clear WishList", "Clear Saved Custom Reports"})
        Me.cbActionList.Location = New Point(16, 36)
        Me.cbActionList.Name = "cbActionList"
        Me.cbActionList.Size = New Size(179, 21)
        Me.cbActionList.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New Point(231, 32)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New Size(88, 24)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New Point(16, 36)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New Size(179, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New Point(16, 64)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New Size(0, 13)
        Me.lblStatus.TabIndex = 4
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmDBCleanup
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(365, 80)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cbActionList)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Database Clean-Up")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Database Clean-Up")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDBCleanup"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Database Clean Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbActionList As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
