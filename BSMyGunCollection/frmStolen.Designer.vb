Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmStolen
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmStolen))
        Me.Label1 = New Label
        Me.dtpStolen = New DateTimePicker
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.txtCaseNo = New TextBox
        Me.btnSave = New Button
        Me.btnCancel = New Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(347, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'dtpStolen
        '
        Me.dtpStolen.Location = New Point(138, 116)
        Me.dtpStolen.Name = "dtpStolen"
        Me.dtpStolen.Size = New Size(200, 20)
        Me.dtpStolen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(3, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(113, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Reported Stolen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Case Number:"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New Point(138, 143)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New Size(200, 20)
        Me.txtCaseNo.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New Point(41, 189)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(227, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmStolen
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(362, 228)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpStolen)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStolen"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Mark Firearm as Stolen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStolen As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
