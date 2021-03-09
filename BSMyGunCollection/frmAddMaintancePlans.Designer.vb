Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddMaintancePlans
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddMaintancePlans))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.Label4 = New Label
        Me.Label5 = New Label
        Me.txtName = New TextBox
        Me.txtOD = New TextBox
        Me.txtNotes = New TextBox
        Me.nudIID = New NumericUpDown
        Me.nudIIRF = New NumericUpDown
        Me.btnAdd = New Button
        Me.brnCancel = New Button
        Me.HelpProvider1 = New HelpProvider
        CType(Me.nudIID, ISupportInitialize).BeginInit()
        CType(Me.nudIIRF, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operation Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interval In Days:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(147, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Interval in Rounds Fired:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New Point(12, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notes:"
        '
        'txtName
        '
        Me.txtName.Location = New Point(169, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(221, 20)
        Me.txtName.TabIndex = 5
        '
        'txtOD
        '
        Me.txtOD.Location = New Point(169, 47)
        Me.txtOD.Multiline = True
        Me.txtOD.Name = "txtOD"
        Me.txtOD.ScrollBars = ScrollBars.Vertical
        Me.txtOD.Size = New Size(221, 98)
        Me.txtOD.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(169, 218)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = ScrollBars.Vertical
        Me.txtNotes.Size = New Size(221, 98)
        Me.txtNotes.TabIndex = 7
        '
        'nudIID
        '
        Me.nudIID.Location = New Point(169, 156)
        Me.nudIID.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudIID.Name = "nudIID"
        Me.nudIID.Size = New Size(220, 20)
        Me.nudIID.TabIndex = 8
        '
        'nudIIRF
        '
        Me.nudIIRF.Location = New Point(170, 182)
        Me.nudIIRF.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudIIRF.Name = "nudIIRF"
        Me.nudIIRF.Size = New Size(220, 20)
        Me.nudIIRF.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(71, 347)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'brnCancel
        '
        Me.brnCancel.DialogResult = DialogResult.Cancel
        Me.brnCancel.Location = New Point(255, 347)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New Size(75, 23)
        Me.brnCancel.TabIndex = 11
        Me.brnCancel.Text = "Cancel"
        Me.brnCancel.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddMaintancePlans
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.brnCancel
        Me.ClientSize = New Size(434, 382)
        Me.Controls.Add(Me.brnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.nudIIRF)
        Me.Controls.Add(Me.nudIID)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtOD)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding A Maintenance Plan")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding A Maintenance Plan")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddMaintancePlans"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Maintenance Plan"
        CType(Me.nudIID, ISupportInitialize).EndInit()
        CType(Me.nudIIRF, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtOD As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents nudIID As NumericUpDown
    Friend WithEvents nudIIRF As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents brnCancel As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
