Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditGunSmithLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditGunSmithLog))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtOD = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtGS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(148, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleName = "btnUpdate"
        Me.btnUpdate.Location = New System.Drawing.Point(28, 283)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'txtNotes
        '
        Me.txtNotes.AccessibleName = "txtNotes"
        Me.txtNotes.Location = New System.Drawing.Point(15, 201)
        Me.txtNotes.Multiline = true
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(234, 76)
        Me.txtNotes.TabIndex = 21
        '
        'txtOD
        '
        Me.txtOD.AccessibleName = "txtOD"
        Me.txtOD.Location = New System.Drawing.Point(15, 106)
        Me.txtOD.Multiline = true
        Me.txtOD.Name = "txtOD"
        Me.txtOD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOD.Size = New System.Drawing.Size(234, 76)
        Me.txtOD.TabIndex = 20
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.AccessibleName = "DateTimePicker2"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(108, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AccessibleName = "DateTimePicker1"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'txtGS
        '
        Me.txtGS.AccessibleName = "txtGS"
        Me.txtGS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtGS.Location = New System.Drawing.Point(108, 6)
        Me.txtGS.Name = "txtGS"
        Me.txtGS.Size = New System.Drawing.Size(141, 20)
        Me.txtGS.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Return Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ship Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Notes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Operation Details:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Gun Smith Name:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditGunSmithLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 329)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtOD)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtGS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmEditGunSmithLog"
        Me.Text = "Edit the Gun Smith Log"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtOD As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtGS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
