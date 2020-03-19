<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditWishlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditWishlist))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtSS = New System.Windows.Forms.TextBox
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtManu = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(163, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(43, 257)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(6, 152)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(280, 100)
        Me.txtNotes.TabIndex = 25
        '
        'txtValue
        '
        Me.txtValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtValue.Location = New System.Drawing.Point(114, 110)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(172, 20)
        Me.txtValue.TabIndex = 24
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(114, 84)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(172, 20)
        Me.txtQty.TabIndex = 23
        Me.txtQty.Text = "1"
        '
        'txtSS
        '
        Me.txtSS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSS.Location = New System.Drawing.Point(114, 58)
        Me.txtSS.Name = "txtSS"
        Me.txtSS.Size = New System.Drawing.Size(172, 20)
        Me.txtSS.TabIndex = 22
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtModel.Location = New System.Drawing.Point(114, 32)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(172, 20)
        Me.txtModel.TabIndex = 21
        '
        'txtManu
        '
        Me.txtManu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtManu.Location = New System.Drawing.Point(114, 6)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New System.Drawing.Size(172, 20)
        Me.txtManu.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Qty.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Suggested Store:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Model:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Manufacturer:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmEditWishlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 289)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpKeyword(Me, "Edit Item in Wish list")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Edit Item in Wish list")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditWishlist"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "frmEditWishlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSS As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtManu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
