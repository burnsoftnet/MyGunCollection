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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirearmImagePicker))
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnLeft
        '
        Me.btnLeft.AccessibleDescription = "Scroll Left"
        Me.btnLeft.AccessibleName = "btnLeft"
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLeft.Location = New System.Drawing.Point(-7, 0)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(31, 448)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = true
        '
        'btnRight
        '
        Me.btnRight.AccessibleDescription = "Scroll Right"
        Me.btnRight.AccessibleName = "btnRight"
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnRight.Location = New System.Drawing.Point(758, 0)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(31, 448)
        Me.btnRight.TabIndex = 2
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = true
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(46, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = true
        Me.txtName.Size = New System.Drawing.Size(693, 20)
        Me.txtName.TabIndex = 3
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "picture"
        Me.PictureBox1.AccessibleName = "PictureBox1"
        Me.PictureBox1.Location = New System.Drawing.Point(21, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = false
        '
        'frmFirearmImagePicker
        '
        Me.AccessibleDescription = "Firearm Chooser"
        Me.AccessibleName = "frmFirearmImagePicker"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 448)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmFirearmImagePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Firearm Chooser"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
