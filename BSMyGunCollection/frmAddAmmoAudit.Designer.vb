Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddAmmoAudit
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
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.txtPrice = New TextBox
        Me.nudQty = New NumericUpDown
        Me.dtpPurchased = New DateTimePicker
        Me.btnAdd = New Button
        Me.btnCancel = New Button
        Me.Label4 = New Label
        Me.nudNumBox = New NumericUpDown
        Me.txtStore = New TextBox
        Me.Label5 = New Label
        CType(Me.nudQty, ISupportInitialize).BeginInit()
        CType(Me.nudNumBox, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'txtPrice
        '
        Me.txtPrice.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPrice.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPrice.Location = New Point(79, 40)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New Size(113, 20)
        Me.txtPrice.TabIndex = 2
        '
        'nudQty
        '
        Me.nudQty.Location = New Point(79, 14)
        Me.nudQty.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New Size(113, 20)
        Me.nudQty.TabIndex = 1
        '
        'dtpPurchased
        '
        Me.dtpPurchased.Format = DateTimePickerFormat.[Short]
        Me.dtpPurchased.Location = New Point(79, 65)
        Me.dtpPurchased.Name = "dtpPurchased"
        Me.dtpPurchased.Size = New Size(113, 20)
        Me.dtpPurchased.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(12, 149)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(117, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "# of Boxes:"
        '
        'nudNumBox
        '
        Me.nudNumBox.Location = New Point(79, 91)
        Me.nudNumBox.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudNumBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumBox.Name = "nudNumBox"
        Me.nudNumBox.Size = New Size(113, 20)
        Me.nudNumBox.TabIndex = 4
        Me.nudNumBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtStore
        '
        Me.txtStore.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtStore.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtStore.Location = New Point(79, 117)
        Me.txtStore.Name = "txtStore"
        Me.txtStore.Size = New Size(113, 20)
        Me.txtStore.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Store:"
        '
        'frmAddAmmoAudit
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(208, 184)
        Me.Controls.Add(Me.txtStore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudNumBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpPurchased)
        Me.Controls.Add(Me.nudQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddAmmoAudit"
        Me.Text = "Add Ammo - Audit"
        CType(Me.nudQty, ISupportInitialize).EndInit()
        CType(Me.nudNumBox, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents dtpPurchased As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents nudNumBox As NumericUpDown
    Friend WithEvents txtStore As TextBox
    Friend WithEvents Label5 As Label
End Class
