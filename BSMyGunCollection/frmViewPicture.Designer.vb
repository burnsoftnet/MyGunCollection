Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewPicture
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewPicture))
        Me.PictureBox1 = New PictureBox
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.ExportPictureToolStripMenuItem = New ToolStripMenuItem
        Me.ChangePictureToolStripMenuItem = New ToolStripMenuItem
        Me.ToolStripSeparator1 = New ToolStripSeparator
        Me.CloseToolStripMenuItem = New ToolStripMenuItem
        Me.ImageToolStripMenuItem = New ToolStripMenuItem
        Me.AutoSizeToolStripMenuItem = New ToolStripMenuItem
        Me.StretchToolStripMenuItem = New ToolStripMenuItem
        Me.OpenFileDialog1 = New OpenFileDialog
        Me.SaveFileDialog1 = New SaveFileDialog
        Me.ToolTip1 = New ToolTip(Me.components)
        Me.EditDetailsToolStripMenuItem = New ToolStripMenuItem
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(395, 333)
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Me.ExportPictureToolStripMenuItem, Me.ChangePictureToolStripMenuItem, Me.ImageToolStripMenuItem, Me.EditDetailsToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(175, 142)
        '
        'ExportPictureToolStripMenuItem
        '
        Me.ExportPictureToolStripMenuItem.Image = CType(resources.GetObject("ExportPictureToolStripMenuItem.Image"), Image)
        Me.ExportPictureToolStripMenuItem.Name = "ExportPictureToolStripMenuItem"
        Me.ExportPictureToolStripMenuItem.Size = New Size(174, 22)
        Me.ExportPictureToolStripMenuItem.Text = "Export Picture"
        '
        'ChangePictureToolStripMenuItem
        '
        Me.ChangePictureToolStripMenuItem.Name = "ChangePictureToolStripMenuItem"
        Me.ChangePictureToolStripMenuItem.Size = New Size(174, 22)
        Me.ChangePictureToolStripMenuItem.Text = "Set As Main Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(171, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New Size(174, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.AutoSizeToolStripMenuItem, Me.StretchToolStripMenuItem})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New Size(174, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'AutoSizeToolStripMenuItem
        '
        Me.AutoSizeToolStripMenuItem.Name = "AutoSizeToolStripMenuItem"
        Me.AutoSizeToolStripMenuItem.Size = New Size(152, 22)
        Me.AutoSizeToolStripMenuItem.Text = "Original Size"
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New Size(152, 22)
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
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '
        'EditDetailsToolStripMenuItem
        '
        Me.EditDetailsToolStripMenuItem.Name = "EditDetailsToolStripMenuItem"
        Me.EditDetailsToolStripMenuItem.Size = New Size(174, 22)
        Me.EditDetailsToolStripMenuItem.Text = "Edit Details"
        '
        'frmViewPicture
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(395, 336)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewPicture"
        Me.Text = "View Picture"
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExportPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ChangePictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ToolTip1 As ToolTip
    Friend WithEvents EditDetailsToolStripMenuItem As ToolStripMenuItem
End Class
