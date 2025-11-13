Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmAddDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDocument))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblSelectedDoc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "Save document to Database Button"
        Me.btnAdd.AccessibleName = "SaveButton"
        Me.btnAdd.Location = New System.Drawing.Point(187, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 25)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleDescription = "Browse to attach documentq"
        Me.btnBrowse.AccessibleName = "AttachDocBrowserButton"
        Me.btnBrowse.Location = New System.Drawing.Point(58, 210)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(73, 25)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblSelectedDoc
        '
        Me.lblSelectedDoc.AccessibleDescription = "The Selected Docuement Label"
        Me.lblSelectedDoc.AccessibleName = "selectedDocumentLabel"
        Me.lblSelectedDoc.Location = New System.Drawing.Point(80, 141)
        Me.lblSelectedDoc.Name = "lblSelectedDoc"
        Me.lblSelectedDoc.Size = New System.Drawing.Size(225, 54)
        Me.lblSelectedDoc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(3, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(3, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Document:"
        '
        'txtTitle
        '
        Me.txtTitle.AccessibleDescription = "The title of the document"
        Me.txtTitle.AccessibleName = "DocumentTitle"
        Me.txtTitle.Location = New System.Drawing.Point(83, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(222, 20)
        Me.txtTitle.TabIndex = 8
        '
        'txtDescription
        '
        Me.txtDescription.AccessibleDescription = "Document Description"
        Me.txtDescription.AccessibleName = "Description"
        Me.txtDescription.Location = New System.Drawing.Point(83, 36)
        Me.txtDescription.Multiline = true
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(222, 60)
        Me.txtDescription.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Category:"
        '
        'txtCat
        '
        Me.txtCat.AccessibleDescription = "Document Category"
        Me.txtCat.AccessibleName = "Category"
        Me.txtCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCat.Location = New System.Drawing.Point(83, 102)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(222, 20)
        Me.txtCat.TabIndex = 11
        '
        'frmAddDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 247)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSelectedDoc)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBrowse)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAddDocument"
        Me.Text = "Add Document"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblSelectedDoc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCat As TextBox
End Class
