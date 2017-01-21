<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditModelTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditModelTypes))
        Me.lblMsg = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtManufacturer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.Location = New System.Drawing.Point(17, 41)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(252, 20)
        Me.lblMsg.TabIndex = 16
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(187, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Update"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtModel.Location = New System.Drawing.Point(91, 87)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(180, 20)
        Me.txtModel.TabIndex = 13
        '
        'txtManufacturer
        '
        Me.txtManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtManufacturer.Location = New System.Drawing.Point(91, 61)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(180, 20)
        Me.txtManufacturer.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 33)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "In this section, you can edit the Model of a gun from a specific manufacturer."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Model:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manufacturer:"
        '
        'frmEditModelTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 177)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditModelTypes"
        Me.Text = "Edit Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
