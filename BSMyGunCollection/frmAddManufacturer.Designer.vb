Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddManufacturer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddManufacturer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMan = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkKTop = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "In this section, you can add a Firearm Manufacturer to the database, this will to"& _ 
    " go the Auto Suggestion feature when you are going to add one of your firearms i"& _ 
    "n the database."
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manufacturer Name:"
        '
        'txtMan
        '
        Me.txtMan.AccessibleDescription = "Manufacturer Name:"
        Me.txtMan.AccessibleName = "txtMan"
        Me.txtMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMan.Location = New System.Drawing.Point(135, 64)
        Me.txtMan.Name = "txtMan"
        Me.txtMan.Size = New System.Drawing.Size(181, 20)
        Me.txtMan.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "Save change sto database"
        Me.btnAdd.AccessibleName = "btnAdd"
        Me.btnAdd.Location = New System.Drawing.Point(39, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = "Exit window"
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(209, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'chkKTop
        '
        Me.chkKTop.AccessibleDescription = "Keep on Top checkbox to add more"
        Me.chkKTop.AccessibleName = "chkKTop"
        Me.chkKTop.AutoSize = true
        Me.chkKTop.Location = New System.Drawing.Point(14, 86)
        Me.chkKTop.Name = "chkKTop"
        Me.chkKTop.Size = New System.Drawing.Size(88, 17)
        Me.chkKTop.TabIndex = 9
        Me.chkKTop.Text = "Keep on Top"
        Me.chkKTop.UseVisualStyleBackColor = true
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddManufacturer
        '
        Me.AcceptButton = Me.btnAdd
        Me.AccessibleDescription = "Add Manufacturer"
        Me.AccessibleName = "frmAddManufacturer"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(341, 140)
        Me.Controls.Add(Me.chkKTop)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Manufacturers")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Manufacturers")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAddManufacturer"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.Text = "Add Manufacturer"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMan As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkKTop As CheckBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
