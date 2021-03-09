Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmEditWishlist
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditWishlist))
        Me.btnCancel = New Button
        Me.btnEdit = New Button
        Me.txtNotes = New TextBox
        Me.txtValue = New TextBox
        Me.txtQty = New TextBox
        Me.txtSS = New TextBox
        Me.txtModel = New TextBox
        Me.txtManu = New TextBox
        Me.Label6 = New Label
        Me.Label5 = New Label
        Me.Label4 = New Label
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.HelpProvider1 = New HelpProvider
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(163, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New Point(43, 257)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(75, 23)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New Point(6, 152)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New Size(280, 100)
        Me.txtNotes.TabIndex = 25
        '
        'txtValue
        '
        Me.txtValue.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtValue.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtValue.Location = New Point(114, 110)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New Size(172, 20)
        Me.txtValue.TabIndex = 24
        '
        'txtQty
        '
        Me.txtQty.Location = New Point(114, 84)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New Size(172, 20)
        Me.txtQty.TabIndex = 23
        Me.txtQty.Text = "1"
        '
        'txtSS
        '
        Me.txtSS.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSS.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSS.Location = New Point(114, 58)
        Me.txtSS.Name = "txtSS"
        Me.txtSS.Size = New Size(172, 20)
        Me.txtSS.TabIndex = 22
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtModel.Location = New Point(114, 32)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New Size(172, 20)
        Me.txtModel.TabIndex = 21
        '
        'txtManu
        '
        Me.txtManu.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtManu.Location = New Point(114, 6)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New Size(172, 20)
        Me.txtManu.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New Point(3, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(44, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New Point(3, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(40, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New Point(3, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Qty.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(105, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Suggested Store:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(45, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Model:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Manufacturer:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditWishlist
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(294, 289)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
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
        Me.HelpProvider1.SetHelpKeyword(Me, "Edit Item in Wish list")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Edit Item in Wish list")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditWishlist"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "frmEditWishlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtSS As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtManu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
