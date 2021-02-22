<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAccessory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddAccessory))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMan = New System.Windows.Forms.TextBox
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.txtUse = New System.Windows.Forms.TextBox
        Me.cmdCondition = New System.Windows.Forms.ComboBox
        Me.txtPurVal = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAppValue = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkCIV = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkIsChoke = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Notes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Purchased Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Use:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Condition:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Serial Number:"
        '
        'txtMan
        '
        Me.txtMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMan.Location = New System.Drawing.Point(136, 13)
        Me.txtMan.Name = "txtMan"
        Me.txtMan.Size = New System.Drawing.Size(194, 20)
        Me.txtMan.TabIndex = 1
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtModel.Location = New System.Drawing.Point(136, 39)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(194, 20)
        Me.txtModel.TabIndex = 2
        '
        'txtSerial
        '
        Me.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSerial.Location = New System.Drawing.Point(136, 65)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(194, 20)
        Me.txtSerial.TabIndex = 3
        '
        'txtUse
        '
        Me.txtUse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUse.Location = New System.Drawing.Point(136, 122)
        Me.txtUse.Name = "txtUse"
        Me.txtUse.Size = New System.Drawing.Size(194, 20)
        Me.txtUse.TabIndex = 5
        '
        'cmdCondition
        '
        Me.cmdCondition.FormattingEnabled = True
        Me.cmdCondition.Items.AddRange(New Object() {"New", "New, Discontinued", "Perfect", "Excellent", "Very Good", "Good", "Fair", "Poor", "Antique Factory New", "Antique Excellent", "Antique Fine", "Antique Very Good", "Antique Good", "Antique Fair", "Antique Poor"})
        Me.cmdCondition.Location = New System.Drawing.Point(136, 95)
        Me.cmdCondition.Name = "cmdCondition"
        Me.cmdCondition.Size = New System.Drawing.Size(194, 21)
        Me.cmdCondition.TabIndex = 4
        Me.cmdCondition.Text = "New"
        '
        'txtPurVal
        '
        Me.txtPurVal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPurVal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPurVal.Location = New System.Drawing.Point(136, 148)
        Me.txtPurVal.Name = "txtPurVal"
        Me.txtPurVal.Size = New System.Drawing.Size(194, 20)
        Me.txtPurVal.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(16, 267)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(315, 71)
        Me.txtNotes.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(45, 347)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(213, 347)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Appraised Value:"
        '
        'txtAppValue
        '
        Me.txtAppValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAppValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAppValue.Location = New System.Drawing.Point(137, 174)
        Me.txtAppValue.Name = "txtAppValue"
        Me.txtAppValue.Size = New System.Drawing.Size(194, 20)
        Me.txtAppValue.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Include in Appraised Value:"
        '
        'chkCIV
        '
        Me.chkCIV.AutoSize = True
        Me.chkCIV.Location = New System.Drawing.Point(181, 202)
        Me.chkCIV.Name = "chkCIV"
        Me.chkCIV.Size = New System.Drawing.Size(44, 17)
        Me.chkCIV.TabIndex = 8
        Me.chkCIV.Text = "Yes"
        Me.chkCIV.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Is this a Shotgun Choke?"
        Me.Label10.Visible = False
        '
        'chkIsChoke
        '
        Me.chkIsChoke.AutoSize = True
        Me.chkIsChoke.Location = New System.Drawing.Point(181, 228)
        Me.chkIsChoke.Name = "chkIsChoke"
        Me.chkIsChoke.Size = New System.Drawing.Size(44, 17)
        Me.chkIsChoke.TabIndex = 9
        Me.chkIsChoke.Text = "Yes"
        Me.chkIsChoke.UseVisualStyleBackColor = True
        Me.chkIsChoke.Visible = False
        '
        'frmAddAccessory
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(343, 373)
        Me.Controls.Add(Me.chkIsChoke)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkCIV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAppValue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtPurVal)
        Me.Controls.Add(Me.cmdCondition)
        Me.Controls.Add(Me.txtUse)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Accessories")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Accessories")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAccessory"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Accessory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMan As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents txtUse As System.Windows.Forms.TextBox
    Friend WithEvents cmdCondition As System.Windows.Forms.ComboBox
    Friend WithEvents txtPurVal As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAppValue As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkCIV As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkIsChoke As System.Windows.Forms.CheckBox
End Class
