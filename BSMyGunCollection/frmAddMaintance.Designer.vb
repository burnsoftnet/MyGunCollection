<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMaintance
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddMaintance))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MaintancePlansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.Maintance_PlansTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Maintance_PlansTableAdapter
        Me.btnViewPlans = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAmmoUsed = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkInAVG = New System.Windows.Forms.CheckBox
        CType(Me.MaintancePlansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maintenance Plan:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MaintancePlansBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(204, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ID"
        '
        'MaintancePlansBindingSource
        '
        Me.MaintancePlansBindingSource.DataMember = "Maintance_Plans"
        Me.MaintancePlansBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Maintance_PlansTableAdapter
        '
        Me.Maintance_PlansTableAdapter.ClearBeforeFill = True
        '
        'btnViewPlans
        '
        Me.btnViewPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPlans.Image = CType(resources.GetObject("btnViewPlans.Image"), System.Drawing.Image)
        Me.btnViewPlans.Location = New System.Drawing.Point(374, 2)
        Me.btnViewPlans.Name = "btnViewPlans"
        Me.btnViewPlans.Size = New System.Drawing.Size(30, 32)
        Me.btnViewPlans.TabIndex = 2
        Me.btnViewPlans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnViewPlans.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operation Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Operation Due Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Rounds Fired since Last Maintenance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Notes:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(163, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(204, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(163, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(204, 92)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(163, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(12, 159)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(392, 98)
        Me.txtNotes.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(64, 297)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(251, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(373, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ammo Used:"
        '
        'txtAmmoUsed
        '
        Me.txtAmmoUsed.Location = New System.Drawing.Point(86, 268)
        Me.txtAmmoUsed.Name = "txtAmmoUsed"
        Me.txtAmmoUsed.Size = New System.Drawing.Size(316, 20)
        Me.txtAmmoUsed.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Count in Final Average:"
        '
        'chkInAVG
        '
        Me.chkInAVG.AutoSize = True
        Me.chkInAVG.Checked = True
        Me.chkInAVG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInAVG.Location = New System.Drawing.Point(204, 116)
        Me.chkInAVG.Name = "chkInAVG"
        Me.chkInAVG.Size = New System.Drawing.Size(44, 17)
        Me.chkInAVG.TabIndex = 7
        Me.chkInAVG.Text = "Yes"
        Me.chkInAVG.UseVisualStyleBackColor = True
        '
        'frmAddMaintance
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(415, 331)
        Me.Controls.Add(Me.chkInAVG)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAmmoUsed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewPlans)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Maintenance Details")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Maintenance Details")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddMaintance"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Maintenance Details"
        CType(Me.MaintancePlansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents MaintancePlansBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Maintance_PlansTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Maintance_PlansTableAdapter
    Friend WithEvents btnViewPlans As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAmmoUsed As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkInAVG As System.Windows.Forms.CheckBox
End Class
