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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddFirearmClassification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.chkKeepOpen = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add custom firearm classifications ( antique, C&&R, Modern ) to use for your coll"& _ 
    "ection."
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classification Type:"
        '
        'txtClass
        '
        Me.txtClass.AccessibleDescription = "Classification Type"
        Me.txtClass.AccessibleName = "txtClass"
        Me.txtClass.Location = New System.Drawing.Point(110, 53)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(177, 20)
        Me.txtClass.TabIndex = 2
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AccessibleDescription = "Keep window open checkbox to add more"
        Me.chkKeepOpen.AccessibleName = "chkKeepOpen"
        Me.chkKeepOpen.AutoSize = true
        Me.chkKeepOpen.Location = New System.Drawing.Point(9, 84)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New System.Drawing.Size(117, 17)
        Me.chkKeepOpen.TabIndex = 3
        Me.chkKeepOpen.Text = "Keep window open"
        Me.chkKeepOpen.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "Save changes to database"
        Me.btnAdd.AccessibleName = "btnAdd"
        Me.btnAdd.Location = New System.Drawing.Point(33, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = "Cancel without saving"
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.Location = New System.Drawing.Point(187, 108)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'frmAddFirearmClassification
        '
        Me.AccessibleDescription = "Add Firearm Classification"
        Me.AccessibleName = "frmAddFirearmClassification"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 148)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAddFirearmClassification"
        Me.Text = "Add Firearm Classification"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClass As TextBox
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
