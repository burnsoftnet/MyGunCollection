Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddManufacturer
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddManufacturer))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.txtMan = New TextBox
        Me.btnAdd = New Button
        Me.btnCancel = New Button
        Me.chkKTop = New CheckBox
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(305, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "In this section, you can add a Firearm Manufacturer to the database, this will to" & _
            " go the Auto Suggestion feature when you are going to add one of your firearms i" & _
            "n the database."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(11, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manufacturer Name:"
        '
        'txtMan
        '
        Me.txtMan.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtMan.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtMan.Location = New Point(135, 64)
        Me.txtMan.Name = "txtMan"
        Me.txtMan.Size = New Size(181, 20)
        Me.txtMan.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(39, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(209, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkKTop
        '
        Me.chkKTop.AutoSize = True
        Me.chkKTop.Location = New Point(14, 86)
        Me.chkKTop.Name = "chkKTop"
        Me.chkKTop.Size = New Size(88, 17)
        Me.chkKTop.TabIndex = 9
        Me.chkKTop.Text = "Keep on Top"
        Me.chkKTop.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddManufacturer
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(341, 140)
        Me.Controls.Add(Me.chkKTop)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Manufacturers")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Manufacturers")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddManufacturer"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Manufacturer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMan As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkKTop As CheckBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
