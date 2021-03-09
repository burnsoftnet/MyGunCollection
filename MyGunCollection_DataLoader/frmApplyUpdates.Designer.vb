Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmApplyUpdates
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmApplyUpdates))
        Me.ProgressBar1 = New ProgressBar
        Me.btnCancel = New Button
        Me.gbWelcome = New GroupBox
        Me.lblTXTStatus = New Label
        Me.lblDataStatus = New Label
        Me.ProgressBar2 = New ProgressBar
        Me.Label1 = New Label
        Me.lblStatusMsg = New Label
        Me.PictureBox1 = New PictureBox
        Me.lblTitle = New Label
        Me.SplitContainer1 = New SplitContainer
        Me.Timer1 = New Timer(Me.components)
        Me.gbWelcome.SuspendLayout()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New Point(19, 46)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New Size(289, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(293, 299)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbWelcome
        '
        Me.gbWelcome.Controls.Add(Me.lblTXTStatus)
        Me.gbWelcome.Controls.Add(Me.lblDataStatus)
        Me.gbWelcome.Controls.Add(Me.ProgressBar2)
        Me.gbWelcome.Controls.Add(Me.ProgressBar1)
        Me.gbWelcome.Controls.Add(Me.Label1)
        Me.gbWelcome.Controls.Add(Me.lblStatusMsg)
        Me.gbWelcome.Location = New Point(31, 67)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New Size(337, 222)
        Me.gbWelcome.TabIndex = 2
        Me.gbWelcome.TabStop = False
        Me.gbWelcome.Text = "Applying Updates"
        '
        'lblTXTStatus
        '
        Me.lblTXTStatus.Location = New Point(19, 122)
        Me.lblTXTStatus.Name = "lblTXTStatus"
        Me.lblTXTStatus.Size = New Size(289, 19)
        Me.lblTXTStatus.TabIndex = 6
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataStatus.Location = New Point(16, 72)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.RightToLeft = RightToLeft.No
        Me.lblDataStatus.Size = New Size(298, 17)
        Me.lblDataStatus.TabIndex = 5
        Me.lblDataStatus.Text = "Status of Dataset listed above:"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New Point(19, 92)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New Size(289, 23)
        Me.ProgressBar2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(16, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = RightToLeft.No
        Me.Label1.Size = New Size(298, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please wait while we apply the updates."
        '
        'lblStatusMsg
        '
        Me.lblStatusMsg.Location = New Point(16, 26)
        Me.lblStatusMsg.Name = "lblStatusMsg"
        Me.lblStatusMsg.Size = New Size(313, 17)
        Me.lblStatusMsg.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        Me.PictureBox1.Location = New Point(14, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(144, 252)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New Font("Microsoft Sans Serif", 9.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New Point(47, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(292, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "[Title]"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbWelcome)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTitle)
        Me.SplitContainer1.Size = New Size(583, 335)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmApplyUpdates
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(583, 336)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmApplyUpdates"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "frmApplyUpdates"
        Me.gbWelcome.ResumeLayout(False)
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbWelcome As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatusMsg As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDataStatus As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents lblTXTStatus As Label
End Class
