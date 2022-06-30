Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmCR_EditSQL
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmCR_EditSQL))
        Me.txtSQL = New TextBox()
        Me.btnSave = New Button()
        Me.btnViewInReport = New Button()
        Me.Label1 = New Label()
        Me.txtTitle = New TextBox()
        Me.Label2 = New Label()
        Me.SuspendLayout()
        '
        'txtSQL
        '
        Me.txtSQL.Location = New Point(12, 63)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New Size(536, 287)
        Me.txtSQL.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New Point(65, 356)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnViewInReport
        '
        Me.btnViewInReport.Location = New Point(337, 356)
        Me.btnViewInReport.Name = "btnViewInReport"
        Me.btnViewInReport.Size = New Size(134, 23)
        Me.btnViewInReport.TabIndex = 2
        Me.btnViewInReport.Text = "View in Report"
        Me.btnViewInReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New Point(48, 10)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New Size(500, 20)
        Me.txtTitle.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SQL:"
        '
        'frmCR_EditSQL
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(560, 389)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewInReport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSQL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCR_EditSQL"
        Me.Text = "Edit SQL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQL As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnViewInReport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
End Class
