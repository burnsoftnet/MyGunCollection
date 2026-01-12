<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFirearmDropDownListFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFirearmDropDownListFilter))
        Me.ChkLstBxItems = New System.Windows.Forms.CheckedListBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'ChkLstBxItems
        '
        Me.ChkLstBxItems.AccessibleDescription = "List of Itmes"
        Me.ChkLstBxItems.AccessibleName = "ChkLstBxItems"
        Me.ChkLstBxItems.FormattingEnabled = true
        Me.ChkLstBxItems.Location = New System.Drawing.Point(12, 12)
        Me.ChkLstBxItems.Name = "ChkLstBxItems"
        Me.ChkLstBxItems.Size = New System.Drawing.Size(309, 424)
        Me.ChkLstBxItems.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleDescription = "Save Changes"
        Me.BtnSave.AccessibleName = "BtnSave"
        Me.BtnSave.Location = New System.Drawing.Point(130, 442)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = true
        '
        'FrmFirearmDropDownListFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 475)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.ChkLstBxItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmFirearmDropDownListFilter"
        Me.Text = "Select the Firearm Filters to See"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ChkLstBxItems As CheckedListBox
    Friend WithEvents BtnSave As Button
End Class
