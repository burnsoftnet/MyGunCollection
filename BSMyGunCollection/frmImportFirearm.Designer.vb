Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmImportFirearm
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmImportFirearm))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.lblFile = New Label
        Me.btnOpen = New Button
        Me.lblProg = New Label
        Me.ProgressBar1 = New ProgressBar
        Me.btnImport = New Button
        Me.HelpProvider1 = New HelpProvider
        Me.OpenFileDialog1 = New OpenFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(379, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "File:"
        '
        'lblFile
        '
        Me.lblFile.Location = New Point(47, 57)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New Size(263, 39)
        Me.lblFile.TabIndex = 2
        Me.lblFile.Text = "lblFile"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New Point(316, 52)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New Size(75, 23)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Select"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblProg
        '
        Me.lblProg.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblProg.Location = New Point(18, 125)
        Me.lblProg.Name = "lblProg"
        Me.lblProg.Size = New Size(260, 17)
        Me.lblProg.TabIndex = 8
        Me.lblProg.Text = "Label3"
        Me.lblProg.TextAlign = ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New Point(18, 99)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New Size(292, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New Point(316, 99)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New Size(75, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmImportFirearm
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(404, 154)
        Me.Controls.Add(Me.lblProg)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportFirearm"
        Me.Text = "Import Firearm from XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents lblProg As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnImport As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
