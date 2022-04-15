Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddCollectionAmmo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCollectionAmmo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMan = New System.Windows.Forms.TextBox()
        Me.txtGrain = New System.Windows.Forms.TextBox()
        Me.txtJacket = New System.Windows.Forms.TextBox()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.NumericUpDown()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.txtQty,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Caliber:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Grain:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jacket:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Qty:"
        '
        'txtMan
        '
        Me.txtMan.AccessibleName = "txtMan"
        Me.txtMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMan.Location = New System.Drawing.Point(95, 29)
        Me.txtMan.Name = "txtMan"
        Me.txtMan.Size = New System.Drawing.Size(147, 20)
        Me.txtMan.TabIndex = 1
        '
        'txtGrain
        '
        Me.txtGrain.AccessibleName = "txtGrain"
        Me.txtGrain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGrain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtGrain.Location = New System.Drawing.Point(95, 107)
        Me.txtGrain.Name = "txtGrain"
        Me.txtGrain.Size = New System.Drawing.Size(147, 20)
        Me.txtGrain.TabIndex = 4
        '
        'txtJacket
        '
        Me.txtJacket.AccessibleName = "txtJacket"
        Me.txtJacket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtJacket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtJacket.Location = New System.Drawing.Point(95, 133)
        Me.txtJacket.Name = "txtJacket"
        Me.txtJacket.Size = New System.Drawing.Size(147, 20)
        Me.txtJacket.TabIndex = 5
        '
        'txtCal
        '
        Me.txtCal.AccessibleName = "txtCal"
        Me.txtCal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCal.Location = New System.Drawing.Point(95, 81)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(147, 20)
        Me.txtCal.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtName"
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Location = New System.Drawing.Point(95, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(147, 20)
        Me.txtName.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleName = "btnAdd"
        Me.btnAdd.Location = New System.Drawing.Point(37, 221)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(141, 221)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NOTE: All fields are Required!"
        '
        'txtQty
        '
        Me.txtQty.AccessibleName = "txtQty"
        Me.txtQty.Location = New System.Drawing.Point(95, 184)
        Me.txtQty.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(120, 20)
        Me.txtQty.TabIndex = 7
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'txtVelocity
        '
        Me.txtVelocity.AccessibleName = "txtVelocity"
        Me.txtVelocity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVelocity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVelocity.Location = New System.Drawing.Point(95, 158)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(147, 20)
        Me.txtVelocity.TabIndex = 6
        Me.txtVelocity.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Velocity (FPS):"
        '
        'FrmAddCollectionAmmo
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(265, 261)
        Me.Controls.Add(Me.txtVelocity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.txtJacket)
        Me.Controls.Add(Me.txtGrain)
        Me.Controls.Add(Me.txtMan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Ammunition")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Ammunition")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmAddCollectionAmmo"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.Text = "Add Ammo to My Collection"
        CType(Me.txtQty,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMan As TextBox
    Friend WithEvents txtGrain As TextBox
    Friend WithEvents txtJacket As TextBox
    Friend WithEvents txtCal As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQty As NumericUpDown
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents txtVelocity As TextBox
    Friend WithEvents Label8 As Label
End Class
