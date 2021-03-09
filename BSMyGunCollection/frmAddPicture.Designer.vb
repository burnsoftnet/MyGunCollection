Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddPicture
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddPicture))
        Me.btnBrowse = New Button
        Me.btnAdd = New Button
        Me.PictureBox1 = New PictureBox
        Me.OpenFileDialog1 = New OpenFileDialog
        Me.HelpProvider1 = New HelpProvider
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.txtName = New TextBox
        Me.txtNotes = New TextBox
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New Point(12, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New Size(100, 25)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(161, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(91, 25)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Point(4, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(311, 265)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(4, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Picture Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(4, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Notes:"
        '
        'txtName
        '
        Me.txtName.Location = New Point(84, 322)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(226, 20)
        Me.txtName.TabIndex = 5
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(10, 370)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New Size(299, 75)
        Me.txtNotes.TabIndex = 6
        '
        'frmAddPicture
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(322, 450)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBrowse)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Pictures")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Pictures")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddPicture"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Add Picture"
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNotes As TextBox
End Class
