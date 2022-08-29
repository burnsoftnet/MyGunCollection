Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmSearch_Collection
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmSearch_Collection))
        Me.Label1 = New Label
        Me.Label2 = New Label
        Me.cmbLookIn = New ComboBox
        Me.dgvResults = New DataGridView
        Me.Label3 = New Label
        Me.txtLookFor = New TextBox
        Me.btnSearch = New Button
        Me.Label4 = New Label
        Me.lblResults = New Label
        CType(Me.dgvResults, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(702, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Look in "
        '
        'cmbLookIn
        '
        Me.cmbLookIn.FormattingEnabled = True
        Me.cmbLookIn.Items.AddRange(New Object() {"Display Name", "Manufacturer", "Model Name", "Serial No.", "Type", "Caliber", "Finish", "Condition", "Custom Catalog ID.", "Weight", "Height", "Stock Type", "Barrel Length", "Action", "Feed System", "Sights", "Purchased Price", "Purchased From", "Storage Location", "Additional Notes", "Produced", "Pet Loads", "Condition Comments"})
        Me.cmbLookIn.Location = New Point(62, 57)
        Me.cmbLookIn.Name = "cmbLookIn"
        Me.cmbLookIn.Size = New Size(142, 21)
        Me.cmbLookIn.TabIndex = 2
        Me.cmbLookIn.Text = "Display Name"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New Point(10, 96)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvResults.Size = New Size(699, 265)
        Me.dgvResults.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(210, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(22, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "For"
        '
        'txtLookFor
        '
        Me.txtLookFor.Location = New Point(238, 57)
        Me.txtLookFor.Name = "txtLookFor"
        Me.txtLookFor.Size = New Size(144, 20)
        Me.txtLookFor.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New Point(399, 55)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(504, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(97, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Number of Results:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New Point(607, 60)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New Size(0, 13)
        Me.lblResults.TabIndex = 8
        '
        'frmSearch_Collection
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(721, 373)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtLookFor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.cmbLookIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch_Collection"
        Me.SizeGripStyle = SizeGripStyle.Hide
        Me.Text = "Search Collection"
        CType(Me.dgvResults, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbLookIn As ComboBox
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLookFor As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResults As Label
End Class
