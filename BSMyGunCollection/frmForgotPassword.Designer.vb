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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmForgotPassword))
        Me.PictureBox1 = New PictureBox
        Me.Label1 = New Label
        Me.lblPhrase = New Label
        Me.txtWord = New TextBox
        Me.btnAnswer = New Button
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        Me.PictureBox1.Location = New Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(37, 36)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(55, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(211, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please answer the following phrase:"
        '
        'lblPhrase
        '
        Me.lblPhrase.Location = New Point(13, 56)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New Size(252, 38)
        Me.lblPhrase.TabIndex = 2
        Me.lblPhrase.Text = "lblPhrase"
        Me.lblPhrase.TextAlign = ContentAlignment.TopCenter
        '
        'txtWord
        '
        Me.txtWord.Location = New Point(12, 97)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New Size(254, 20)
        Me.txtWord.TabIndex = 3
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New Point(171, 124)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New Size(75, 23)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Submit"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'frmForgotPassword
        '
        Me.AcceptButton = Me.btnAnswer
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(292, 152)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Name = "FrmForgotPassword"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnAnswer As Button
End Class
