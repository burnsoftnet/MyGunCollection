<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPicture
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewPicture))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StretchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 333)
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportPictureToolStripMenuItem, Me.ChangePictureToolStripMenuItem, Me.ImageToolStripMenuItem, Me.EditDetailsToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 142)
        '
        'ExportPictureToolStripMenuItem
        '
        Me.ExportPictureToolStripMenuItem.Image = CType(resources.GetObject("ExportPictureToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportPictureToolStripMenuItem.Name = "ExportPictureToolStripMenuItem"
        Me.ExportPictureToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExportPictureToolStripMenuItem.Text = "Export Picture"
        '
        'ChangePictureToolStripMenuItem
        '
        Me.ChangePictureToolStripMenuItem.Name = "ChangePictureToolStripMenuItem"
        Me.ChangePictureToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ChangePictureToolStripMenuItem.Text = "Set As Main Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoSizeToolStripMenuItem, Me.StretchToolStripMenuItem})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'AutoSizeToolStripMenuItem
        '
        Me.AutoSizeToolStripMenuItem.Name = "AutoSizeToolStripMenuItem"
        Me.AutoSizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AutoSizeToolStripMenuItem.Text = "Original Size"
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StretchToolStripMenuItem.Text = "Stretch"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'EditDetailsToolStripMenuItem
        '
        Me.EditDetailsToolStripMenuItem.Name = "EditDetailsToolStripMenuItem"
        Me.EditDetailsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EditDetailsToolStripMenuItem.Text = "Edit Details"
        '
        'frmViewPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 336)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewPicture"
        Me.Text = "View Picture"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportPictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ChangePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
