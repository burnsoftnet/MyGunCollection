Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmEditMaintenance
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
        Me.components = New Container
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditMaintenance))
        Me.chkInAVG = New CheckBox
        Me.Label7 = New Label
        Me.txtAmmoUsed = New TextBox
        Me.Label6 = New Label
        Me.Button1 = New Button
        Me.btnCancel = New Button
        Me.btnAdd = New Button
        Me.txtNotes = New TextBox
        Me.NumericUpDown1 = New NumericUpDown
        Me.DateTimePicker2 = New DateTimePicker
        Me.DateTimePicker1 = New DateTimePicker
        Me.Label5 = New Label
        Me.Label4 = New Label
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.btnViewPlans = New Button
        Me.ComboBox1 = New ComboBox
        Me.MaintancePlansBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Label1 = New Label
        Me.Maintance_PlansTableAdapter = New Maintance_PlansTableAdapter
        Me.HelpProvider1 = New HelpProvider
        CType(Me.NumericUpDown1, ISupportInitialize).BeginInit()
        CType(Me.MaintancePlansBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkInAVG
        '
        Me.chkInAVG.AutoSize = True
        Me.chkInAVG.Checked = True
        Me.chkInAVG.CheckState = CheckState.Checked
        Me.chkInAVG.Location = New Point(204, 122)
        Me.chkInAVG.Name = "chkInAVG"
        Me.chkInAVG.Size = New Size(44, 17)
        Me.chkInAVG.TabIndex = 24
        Me.chkInAVG.Text = "Yes"
        Me.chkInAVG.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(12, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(117, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Count in Final Average:"
        '
        'txtAmmoUsed
        '
        Me.txtAmmoUsed.Location = New Point(86, 274)
        Me.txtAmmoUsed.Name = "txtAmmoUsed"
        Me.txtAmmoUsed.Size = New Size(316, 20)
        Me.txtAmmoUsed.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(12, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(67, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Ammo Used:"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = ImageLayout.Stretch
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Me.Button1.Location = New Point(373, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(29, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(251, 303)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(64, 303)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Update"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(12, 165)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = ScrollBars.Vertical
        Me.txtNotes.Size = New Size(392, 98)
        Me.txtNotes.TabIndex = 25
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New Point(204, 98)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New Size(163, 20)
        Me.NumericUpDown1.TabIndex = 21
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New Point(204, 71)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New Size(163, 20)
        Me.DateTimePicker2.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New Point(204, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New Size(163, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Notes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(189, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Rounds Fired since Last Maintenance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(105, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Operation Due Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(82, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Operation Date:"
        '
        'btnViewPlans
        '
        Me.btnViewPlans.BackgroundImageLayout = ImageLayout.Stretch
        Me.btnViewPlans.Image = CType(resources.GetObject("btnViewPlans.Image"), Image)
        Me.btnViewPlans.Location = New Point(374, 8)
        Me.btnViewPlans.Name = "btnViewPlans"
        Me.btnViewPlans.Size = New Size(30, 32)
        Me.btnViewPlans.TabIndex = 15
        Me.btnViewPlans.TextImageRelation = TextImageRelation.ImageAboveText
        Me.btnViewPlans.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MaintancePlansBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New Point(204, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(164, 21)
        Me.ComboBox1.TabIndex = 14
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
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(96, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Maintenance Plan:"
        '
        'Maintance_PlansTableAdapter
        '
        Me.Maintance_PlansTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditMaintenance
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(422, 344)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmEditMaintenance"
        Me.Text = "Edit Maintenance Details"
        CType(Me.NumericUpDown1, ISupportInitialize).EndInit()
        CType(Me.MaintancePlansBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkInAVG As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmmoUsed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnViewPlans As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MaintancePlansBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Maintance_PlansTableAdapter As Maintance_PlansTableAdapter
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
