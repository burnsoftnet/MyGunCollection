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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddToWishList))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.Label3 = New Label
        Me.Label4 = New Label
        Me.Label5 = New Label
        Me.Label6 = New Label
        Me.txtManu = New TextBox
        Me.txtModel = New TextBox
        Me.txtSS = New TextBox
        Me.txtQty = New TextBox
        Me.txtValue = New TextBox
        Me.txtNotes = New TextBox
        Me.btnAdd = New Button
        Me.btnCancel = New Button
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(2, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(2, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(2, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suggested Store:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New Point(2, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Qty.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New Point(2, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New Point(2, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Notes:"
        '
        'txtManu
        '
        Me.txtManu.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtManu.Location = New Point(113, 20)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New Size(172, 20)
        Me.txtManu.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtModel.Location = New Point(113, 46)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New Size(172, 20)
        Me.txtModel.TabIndex = 7
        '
        'txtSS
        '
        Me.txtSS.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSS.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSS.Location = New Point(113, 72)
        Me.txtSS.Name = "txtSS"
        Me.txtSS.Size = New Size(172, 20)
        Me.txtSS.TabIndex = 8
        '
        'txtQty
        '
        Me.txtQty.Location = New Point(113, 98)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New Size(172, 20)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Text = "1"
        '
        'txtValue
        '
        Me.txtValue.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtValue.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtValue.Location = New Point(113, 124)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New Size(172, 20)
        Me.txtValue.TabIndex = 10
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(5, 166)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New Size(280, 100)
        Me.txtNotes.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(42, 271)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(162, 271)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmAddToWishList
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(291, 302)
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
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding to WishList")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding to WishList")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddToWishList"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.Text = "Add Item to Wishlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
