Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "Please answer the following phrase:"
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please answer the following phrase:"
        '
        'lblPhrase
        '
        Me.lblPhrase.Location = New System.Drawing.Point(13, 56)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(252, 38)
        Me.lblPhrase.TabIndex = 2
        Me.lblPhrase.Text = "lblPhrase"
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtWord
        '
        Me.txtWord.AccessibleDescription = "Please answer the following phrase:"
        Me.txtWord.AccessibleName = "txtWord"
        Me.txtWord.Location = New System.Drawing.Point(12, 97)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(254, 20)
        Me.txtWord.TabIndex = 3
        '
        'btnAnswer
        '
        Me.btnAnswer.AccessibleDescription = "Submite Anwser"
        Me.btnAnswer.AccessibleName = "btnAnswer"
        Me.btnAnswer.Location = New System.Drawing.Point(171, 124)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Submit"
        Me.btnAnswer.UseVisualStyleBackColor = true
        '
        'frmForgotPassword
        '
        Me.AcceptButton = Me.btnAnswer
        Me.AccessibleDescription = "Forgot Password"
        Me.AccessibleName = "frmForgotPassword"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 152)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnAnswer As Button
End Class
