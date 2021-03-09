Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmFirearmImagePicker
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmFirearmImagePicker))
        Me.btnLeft = New Button()
        Me.btnRight = New Button()
        Me.txtName = New TextBox()
        Me.PictureBox1 = New PictureBox()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New Point(-7, 0)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New Size(31, 448)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New Point(758, 0)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New Size(31, 448)
        Me.btnRight.TabIndex = 2
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.BorderStyle = BorderStyle.FixedSingle
        Me.txtName.Location = New Point(46, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New Size(693, 20)
        Me.txtName.TabIndex = 3
        Me.txtName.TextAlign = HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Point(21, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(739, 417)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmFirearmImagePicker
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(786, 448)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFirearmImagePicker"
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Firearm Chooser"
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
