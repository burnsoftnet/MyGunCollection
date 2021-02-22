<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAmmoAudit
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.nudQty = New System.Windows.Forms.NumericUpDown
        Me.dtpPurchased = New System.Windows.Forms.DateTimePicker
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.nudNumBox = New System.Windows.Forms.NumericUpDown
        Me.txtStore = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'txtPrice
        '
        Me.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPrice.Location = New System.Drawing.Point(79, 40)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(113, 20)
        Me.txtPrice.TabIndex = 2
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(79, 14)
        Me.nudQty.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(113, 20)
        Me.nudQty.TabIndex = 1
        '
        'dtpPurchased
        '
        Me.dtpPurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchased.Location = New System.Drawing.Point(79, 65)
        Me.dtpPurchased.Name = "dtpPurchased"
        Me.dtpPurchased.Size = New System.Drawing.Size(113, 20)
        Me.dtpPurchased.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 149)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(117, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "# of Boxes:"
        '
        'nudNumBox
        '
        Me.nudNumBox.Location = New System.Drawing.Point(79, 91)
        Me.nudNumBox.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudNumBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumBox.Name = "nudNumBox"
        Me.nudNumBox.Size = New System.Drawing.Size(113, 20)
        Me.nudNumBox.TabIndex = 4
        Me.nudNumBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtStore
        '
        Me.txtStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStore.Location = New System.Drawing.Point(79, 117)
        Me.txtStore.Name = "txtStore"
        Me.txtStore.Size = New System.Drawing.Size(113, 20)
        Me.txtStore.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Store:"
        '
        'frmAddAmmoAudit
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(208, 184)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddAmmoAudit"
        Me.Text = "Add Ammo - Audit"
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpPurchased As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudNumBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtStore As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
