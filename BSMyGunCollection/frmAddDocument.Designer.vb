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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddDocument))
        Me.btnAdd = New Button()
        Me.btnBrowse = New Button()
        Me.OpenFileDialog1 = New OpenFileDialog()
        Me.lblSelectedDoc = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label1 = New Label()
        Me.txtTitle = New TextBox()
        Me.txtDescription = New TextBox()
        Me.Label4 = New Label()
        Me.txtCat = New TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(187, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(91, 25)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New Point(58, 210)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New Size(73, 25)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblSelectedDoc
        '
        Me.lblSelectedDoc.Location = New Point(80, 141)
        Me.lblSelectedDoc.Name = "lblSelectedDoc"
        Me.lblSelectedDoc.Size = New Size(225, 54)
        Me.lblSelectedDoc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(3, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(3, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Document:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New Point(83, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New Size(222, 20)
        Me.txtTitle.TabIndex = 8
        '
        'txtDescription
        '
        Me.txtDescription.Location = New Point(83, 36)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New Size(222, 60)
        Me.txtDescription.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Category:"
        '
        'txtCat
        '
        Me.txtCat.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCat.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCat.Location = New Point(83, 102)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New Size(222, 20)
        Me.txtCat.TabIndex = 11
        '
        'frmAddDocument
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(319, 247)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddDocument"
        Me.Text = "Add Document"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
