Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAmmoCalc
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
        Me.btnFinish = New Button
        Me.GroupBox1 = New GroupBox
        Me.txtCurQty = New Label
        Me.Label4 = New Label
        Me.btnAdd = New Button
        Me.NumericUpDown1 = New NumericUpDown
        Me.Label2 = New Label
        Me.ComboBox1 = New ComboBox
        Me.GunCollectionAmmoBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.Label1 = New Label
        Me.ListView1 = New ListView
        Me.ID = New ColumnHeader
        Me.AU = New ColumnHeader
        Me.QTY = New ColumnHeader
        Me.Gun_Collection_AmmoTableAdapter = New Gun_Collection_AmmoTableAdapter
        Me.btnCancel = New Button
        Me.Label3 = New Label
        Me.lblTotal = New Label
        Me.chkbxUI = New CheckBox
        Me.HelpProvider1 = New HelpProvider
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinish
        '
        Me.btnFinish.Location = New Point(33, 284)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New Size(75, 23)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "&Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCurQty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(280, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ammunition in Inventory"
        '
        'txtCurQty
        '
        Me.txtCurQty.AutoSize = True
        Me.txtCurQty.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurQty.Location = New Point(125, 50)
        Me.txtCurQty.Name = "txtCurQty"
        Me.txtCurQty.Size = New Size(0, 13)
        Me.txtCurQty.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(9, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Current Qty:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(81, 100)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(99, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New Point(125, 74)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New Size(145, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(9, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qty. Used:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GunCollectionAmmoBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New Point(125, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(145, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ID"
        '
        'GunCollectionAmmoBindingSource
        '
        Me.GunCollectionAmmoBindingSource.DataMember = "Gun_Collection_Ammo"
        Me.GunCollectionAmmoBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Ammunition:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New ColumnHeader() {Me.ID, Me.AU, Me.QTY})
        Me.ListView1.Location = New Point(2, 147)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New Size(280, 97)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 2
        '
        'AU
        '
        Me.AU.Text = "Ammo Used"
        Me.AU.Width = 193
        '
        'QTY
        '
        Me.QTY.Text = "Qty."
        Me.QTY.Width = 67
        '
        'Gun_Collection_AmmoTableAdapter
        '
        Me.Gun_Collection_AmmoTableAdapter.ClearBeforeFill = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(168, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(117, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Current Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New Point(208, 254)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New Size(0, 13)
        Me.lblTotal.TabIndex = 5
        '
        'chkbxUI
        '
        Me.chkbxUI.AutoSize = True
        Me.chkbxUI.Checked = True
        Me.chkbxUI.CheckState = CheckState.Checked
        Me.chkbxUI.Location = New Point(3, 254)
        Me.chkbxUI.Name = "chkbxUI"
        Me.chkbxUI.Size = New Size(108, 17)
        Me.chkbxUI.TabIndex = 4
        Me.chkbxUI.Text = "Update Inventory"
        Me.chkbxUI.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAmmoCalc
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(289, 319)
        Me.Controls.Add(Me.chkbxUI)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFinish)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpKeyword(Me, "Ammo Calculator")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Ammo Calculator")
        Me.Name = "FrmAmmoCalc"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Ammo Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, ISupportInitialize).EndInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinish As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionAmmoBindingSource As BindingSource
    Friend WithEvents Gun_Collection_AmmoTableAdapter As Gun_Collection_AmmoTableAdapter
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents AU As ColumnHeader
    Friend WithEvents QTY As ColumnHeader
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents chkbxUI As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCurQty As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
