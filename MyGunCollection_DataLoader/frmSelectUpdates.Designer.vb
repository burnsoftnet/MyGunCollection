Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmSelectUpdates
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmSelectUpdates))
        Me.btnCancel = New Button
        Me.lblWelcomeMsg = New Label
        Me.SplitContainer1 = New SplitContainer
        Me.PictureBox1 = New PictureBox
        Me.btnNext = New Button
        Me.gbWelcome = New GroupBox
        Me.CheckBox8 = New CheckBox
        Me.CheckBox7 = New CheckBox
        Me.CheckBox6 = New CheckBox
        Me.CheckBox5 = New CheckBox
        Me.CheckBox4 = New CheckBox
        Me.CheckBox3 = New CheckBox
        Me.CheckBox2 = New CheckBox
        Me.CheckBox1 = New CheckBox
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.lblTitle = New Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.gbWelcome.SuspendLayout()
        Me.SuspendLayout()
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
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.Location = New Point(16, 16)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New Size(313, 17)
        Me.lblWelcomeMsg.TabIndex = 0
        Me.lblWelcomeMsg.Text = "Select the components below that you wish to update:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New Point(1, 3)
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
        Me.SplitContainer1.TabIndex = 6
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
        Me.gbWelcome.Controls.Add(Me.CheckBox8)
        Me.gbWelcome.Controls.Add(Me.CheckBox7)
        Me.gbWelcome.Controls.Add(Me.CheckBox6)
        Me.gbWelcome.Controls.Add(Me.CheckBox5)
        Me.gbWelcome.Controls.Add(Me.CheckBox4)
        Me.gbWelcome.Controls.Add(Me.CheckBox3)
        Me.gbWelcome.Controls.Add(Me.CheckBox2)
        Me.gbWelcome.Controls.Add(Me.CheckBox1)
        Me.gbWelcome.Controls.Add(Me.Label3)
        Me.gbWelcome.Controls.Add(Me.Label2)
        Me.gbWelcome.Controls.Add(Me.Label1)
        Me.gbWelcome.Controls.Add(Me.lblWelcomeMsg)
        Me.gbWelcome.Location = New Point(14, 53)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New Size(385, 236)
        Me.gbWelcome.TabIndex = 2
        Me.gbWelcome.TabStop = False
        Me.gbWelcome.Text = "Select the components"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New Point(163, 117)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New Size(117, 17)
        Me.CheckBox8.TabIndex = 13
        Me.CheckBox8.Text = "Maintenance Plans"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New Point(255, 93)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New Size(92, 17)
        Me.CheckBox7.TabIndex = 12
        Me.CheckBox7.Text = "Firearm Types"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New Point(15, 117)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New Size(141, 17)
        Me.CheckBox6.TabIndex = 11
        Me.CheckBox6.Text = "Manufacturer Nationality"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New Point(152, 93)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New Size(97, 17)
        Me.CheckBox5.TabIndex = 10
        Me.CheckBox5.Text = "Firearm Models"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New Point(15, 93)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New Size(131, 17)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Firearm Manufacturers"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New Point(212, 70)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New Size(77, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Grip Types"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New Point(86, 70)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New Size(120, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Ammunition Calibers"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = CheckState.Checked
        Me.CheckBox1.Location = New Point(15, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New Size(65, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "All Items"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(16, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(363, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NOTE: This will only add to the database and not over write anything."
        '
        'Label2
        '
        Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(16, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(350, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOTE:  THE NEXT STEP WILL REQUIRE AN  INTERNET CONNECTION.  MAKRE SURE YOU ARE CO" & _
            "NNECTED TO THE INTERNET FIRST!!"
        '
        'Label1
        '
        Me.Label1.Location = New Point(16, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(298, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Click on the Next Button to Continue. "
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
        'frmSelectUpdates
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(582, 338)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmSelectUpdates"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "frmSelectUpdates"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblWelcomeMsg As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents gbWelcome As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
