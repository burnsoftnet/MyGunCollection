Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmEditPicturedetails
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditPicturedetails))
        Me.txtNotes = New TextBox
        Me.txtName = New TextBox
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.btnCancel = New Button
        Me.btnUpdate = New Button
        Me.SuspendLayout()
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(9, 54)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New Size(299, 75)
        Me.txtNotes.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New Point(83, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(226, 20)
        Me.txtName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Notes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(74, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Picture Name:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New Point(9, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New Point(233, 142)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmEditPicturedetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(320, 173)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmEditPicturedetails"
        Me.Text = "Edit Picture Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
End Class
