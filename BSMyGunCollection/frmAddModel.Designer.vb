Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddModel
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddModel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.chkKTop = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "In this section, you can add the Model of a gun from a specific manufacturer."
        '
        'txtManufacturer
        '
        Me.txtManufacturer.AccessibleDescription = "Manufacturer"
        Me.txtManufacturer.AccessibleName = "txtManufacturer"
        Me.txtManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtManufacturer.Location = New System.Drawing.Point(91, 61)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(180, 20)
        Me.txtManufacturer.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.AccessibleDescription = "Model"
        Me.txtModel.AccessibleName = "txtModel"
        Me.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtModel.Location = New System.Drawing.Point(91, 87)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(180, 20)
        Me.txtModel.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "Add Model Button"
        Me.btnAdd.AccessibleName = "btnAdd"
        Me.btnAdd.Location = New System.Drawing.Point(20, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Model"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = "Exit form"
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(187, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'lblMsg
        '
        Me.lblMsg.Location = New System.Drawing.Point(17, 41)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(252, 20)
        Me.lblMsg.TabIndex = 7
        '
        'chkKTop
        '
        Me.chkKTop.AccessibleDescription = "Keep on Top"
        Me.chkKTop.AccessibleName = "chkKTop"
        Me.chkKTop.AutoSize = true
        Me.chkKTop.Location = New System.Drawing.Point(15, 118)
        Me.chkKTop.Name = "chkKTop"
        Me.chkKTop.Size = New System.Drawing.Size(88, 17)
        Me.chkKTop.TabIndex = 8
        Me.chkKTop.Text = "Keep on Top"
        Me.chkKTop.UseVisualStyleBackColor = true
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddModel
        '
        Me.AcceptButton = Me.btnAdd
        Me.AccessibleDescription = "Add Model"
        Me.AccessibleName = "frmAddModel"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(288, 176)
        Me.Controls.Add(Me.chkKTop)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Model")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Model")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAddModel"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Model"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents chkKTop As CheckBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
