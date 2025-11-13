Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddToWishList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddToWishList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtManu = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtSS = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suggested Store:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Qty.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Notes:"
        '
        'txtManu
        '
        Me.txtManu.AccessibleDescription = "Manufacturer"
        Me.txtManu.AccessibleName = "txtManu"
        Me.txtManu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtManu.Location = New System.Drawing.Point(113, 20)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New System.Drawing.Size(172, 20)
        Me.txtManu.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.AccessibleDescription = "Model"
        Me.txtModel.AccessibleName = "txtModel"
        Me.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtModel.Location = New System.Drawing.Point(113, 46)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(172, 20)
        Me.txtModel.TabIndex = 7
        '
        'txtSS
        '
        Me.txtSS.AccessibleDescription = "Suggested Store"
        Me.txtSS.AccessibleName = "txtSS"
        Me.txtSS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSS.Location = New System.Drawing.Point(113, 72)
        Me.txtSS.Name = "txtSS"
        Me.txtSS.Size = New System.Drawing.Size(172, 20)
        Me.txtSS.TabIndex = 8
        '
        'txtQty
        '
        Me.txtQty.AccessibleDescription = "Qty that you want"
        Me.txtQty.AccessibleName = "txtQty"
        Me.txtQty.Location = New System.Drawing.Point(113, 98)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(172, 20)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Text = "1"
        '
        'txtValue
        '
        Me.txtValue.AccessibleDescription = "Price of item"
        Me.txtValue.AccessibleName = "txtValue"
        Me.txtValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtValue.Location = New System.Drawing.Point(113, 124)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(172, 20)
        Me.txtValue.TabIndex = 10
        '
        'txtNotes
        '
        Me.txtNotes.AccessibleDescription = "Notes"
        Me.txtNotes.AccessibleName = "txtNotes"
        Me.txtNotes.Location = New System.Drawing.Point(5, 166)
        Me.txtNotes.Multiline = true
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(280, 100)
        Me.txtNotes.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "Save to Database"
        Me.btnAdd.AccessibleName = "btnAdd"
        Me.btnAdd.Location = New System.Drawing.Point(42, 271)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = "Exit without Saving"
        Me.btnCancel.AccessibleName = "btnCancel"
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(162, 271)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddToWishList
        '
        Me.AccessibleDescription = "Add Item to Wishlist"
        Me.AccessibleName = "frmAddToWishList"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(291, 302)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtSS)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtManu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding to WishList")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding to WishList")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAddToWishList"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.ShowInTaskbar = false
        Me.Text = "Add Item to Wishlist"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtManu As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtSS As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
