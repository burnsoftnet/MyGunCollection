<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMaintancePlan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewMaintancePlan))
        Me.brnCancel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.nudIIRF = New System.Windows.Forms.NumericUpDown
        Me.nudIID = New System.Windows.Forms.NumericUpDown
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.txtOD = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.nudIIRF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brnCancel
        '
        Me.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.brnCancel.Location = New System.Drawing.Point(253, 318)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(75, 23)
        Me.brnCancel.TabIndex = 23
        Me.brnCancel.Text = "Cancel"
        Me.brnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(71, 318)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'nudIIRF
        '
        Me.nudIIRF.Location = New System.Drawing.Point(170, 167)
        Me.nudIIRF.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudIIRF.Name = "nudIIRF"
        Me.nudIIRF.ReadOnly = True
        Me.nudIIRF.Size = New System.Drawing.Size(220, 20)
        Me.nudIIRF.TabIndex = 21
        '
        'nudIID
        '
        Me.nudIID.Location = New System.Drawing.Point(169, 141)
        Me.nudIID.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudIID.Name = "nudIID"
        Me.nudIID.ReadOnly = True
        Me.nudIID.Size = New System.Drawing.Size(220, 20)
        Me.nudIID.TabIndex = 20
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(169, 203)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(221, 98)
        Me.txtNotes.TabIndex = 19
        '
        'txtOD
        '
        Me.txtOD.Location = New System.Drawing.Point(169, 32)
        Me.txtOD.Multiline = True
        Me.txtOD.Name = "txtOD"
        Me.txtOD.ReadOnly = True
        Me.txtOD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOD.Size = New System.Drawing.Size(221, 98)
        Me.txtOD.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(221, 20)
        Me.txtName.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Notes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Interval in Rounds Fired:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Interval In Days:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Operation Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(71, 318)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmViewMaintancePlan
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.brnCancel
        Me.ClientSize = New System.Drawing.Size(403, 355)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.brnCancel)
        Me.Controls.Add(Me.btnEdit)
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
        Me.HelpProvider1.SetHelpKeyword(Me, "Viewing a Maintenance Plan")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Viewing a Maintenance Plan")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewMaintancePlan"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Maintenance Plan"
        CType(Me.nudIIRF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents brnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents nudIIRF As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIID As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtOD As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
