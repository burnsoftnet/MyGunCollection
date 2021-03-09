Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New SplitContainer
        Me.PictureBox1 = New PictureBox
        Me.btnCancel = New Button
        Me.btnNext = New Button
        Me.gbWelcome = New GroupBox
        Me.Label1 = New Label
        Me.lblWelcomeMsg = New Label
        Me.lblTitle = New Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.gbWelcome.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New Point(2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnNext)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbWelcome)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTitle)
        Me.SplitContainer1.Size = New Size(583, 335)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 5
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
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(166, 295)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New Point(303, 295)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New Size(65, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'gbWelcome
        '
        Me.gbWelcome.Controls.Add(Me.Label1)
        Me.gbWelcome.Controls.Add(Me.lblWelcomeMsg)
        Me.gbWelcome.Location = New Point(31, 67)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New Size(337, 222)
        Me.gbWelcome.TabIndex = 2
        Me.gbWelcome.TabStop = False
        Me.gbWelcome.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.Location = New Point(16, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(298, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Click on the Next Button to Continue. "
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.Location = New Point(16, 26)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New Size(313, 93)
        Me.lblWelcomeMsg.TabIndex = 0
        Me.lblWelcomeMsg.Text = "Welcome to the Application.ProductName.  This program will update the following application that is installed:"""
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
        'frmMain
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(582, 338)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmMain"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "My Gun Collection - Data Loader"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.gbWelcome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents gbWelcome As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcomeMsg As Label
    Friend WithEvents lblTitle As Label

End Class
