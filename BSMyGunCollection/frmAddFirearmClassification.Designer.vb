Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddFirearmClassification
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddFirearmClassification))
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.txtClass = New TextBox()
        Me.chkKeepOpen = New CheckBox()
        Me.btnAdd = New Button()
        Me.btnCancel = New Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(288, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add custom firearm classifications ( antique, C&&R, Modern ) to use for your collection."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classification Type:"
        '
        'txtClass
        '
        Me.txtClass.Location = New Point(110, 53)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New Size(177, 20)
        Me.txtClass.TabIndex = 2
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Location = New Point(9, 84)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New Size(117, 17)
        Me.chkKeepOpen.TabIndex = 3
        Me.chkKeepOpen.Text = "Keep window open"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(33, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New Point(187, 108)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddFirearmClassification
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(300, 148)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddFirearmClassification"
        Me.Text = "Add Firearm Classification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClass As TextBox
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
