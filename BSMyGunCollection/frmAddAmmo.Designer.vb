Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddAmmo
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddAmmo))
        Me.txtAmmo = New TextBox
        Me.Button1 = New Button
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.Button2 = New Button
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'txtAmmo
        '
        Me.txtAmmo.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAmmo.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAmmo.Location = New Point(54, 95)
        Me.txtAmmo.Name = "txtAmmo"
        Me.txtAmmo.Size = New Size(239, 20)
        Me.txtAmmo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New Point(54, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Ammo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(51, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(283, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "In this section, you can add ammunition to the database so you can use later to a" & _
            "dd to your collection either with the gun or the type amount of ammunition that " & _
            "you have in stock."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'Button2
        '
        Me.Button2.DialogResult = DialogResult.Cancel
        Me.Button2.Location = New Point(180, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddAmmo
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New Size(354, 156)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAmmo)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Ammunition Type")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Ammunition Type")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAmmo"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Add Ammunition Caliber to Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmmo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
