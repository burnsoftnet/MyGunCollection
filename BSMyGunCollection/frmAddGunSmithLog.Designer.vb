Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddGunSmithLog
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddGunSmithLog))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.Label4 = New Label
        Me.Label5 = New Label
        Me.txtGS = New TextBox
        Me.DateTimePicker1 = New DateTimePicker
        Me.DateTimePicker2 = New DateTimePicker
        Me.txtOD = New TextBox
        Me.txtNotes = New TextBox
        Me.btnAdd = New Button
        Me.btnCancel = New Button
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gun Smith Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(2, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operation Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(2, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Notes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(2, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ship Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(2, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Return Date:"
        '
        'txtGS
        '
        Me.txtGS.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtGS.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtGS.Location = New Point(98, 6)
        Me.txtGS.Name = "txtGS"
        Me.txtGS.Size = New Size(141, 20)
        Me.txtGS.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New Point(98, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New Size(141, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New Point(98, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New Size(141, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'txtOD
        '
        Me.txtOD.Location = New Point(5, 106)
        Me.txtOD.Multiline = True
        Me.txtOD.Name = "txtOD"
        Me.txtOD.ScrollBars = ScrollBars.Vertical
        Me.txtOD.Size = New Size(234, 76)
        Me.txtOD.TabIndex = 8
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(5, 201)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = ScrollBars.Vertical
        Me.txtNotes.Size = New Size(234, 76)
        Me.txtNotes.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(18, 283)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(138, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddGunSmithLog
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(245, 313)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
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
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding to the Gun Smith Log")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding to the Gun Smith Log")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddGunSmithLog"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Gun Smith Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGS As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtOD As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
