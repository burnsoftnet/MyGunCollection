<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.gbWelcome = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblWelcomeMsg = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWelcome.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(583, 335)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(166, 295)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(303, 295)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(65, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'gbWelcome
        '
        Me.gbWelcome.Controls.Add(Me.Label1)
        Me.gbWelcome.Controls.Add(Me.lblWelcomeMsg)
        Me.gbWelcome.Location = New System.Drawing.Point(31, 67)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(337, 222)
        Me.gbWelcome.TabIndex = 2
        Me.gbWelcome.TabStop = False
        Me.gbWelcome.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Click on the Next Button to Continue. "
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.Location = New System.Drawing.Point(16, 26)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New System.Drawing.Size(313, 93)
        Me.lblWelcomeMsg.TabIndex = 0
        Me.lblWelcomeMsg.Text = "Welcome to the Application.ProductName.  This program will update the following a" & _
            "pplication that is installed:"""
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(47, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "[Title]"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 338)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Gun Collection - Data Loader"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWelcome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeMsg As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
