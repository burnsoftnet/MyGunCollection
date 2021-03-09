Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmCopyAccessory
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
        Me.components = New Container
        Me.Label1 = New Label
        Me.ComboBox1 = New ComboBox
        Me.QryGunCollectionDetailsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet
        Me.QryGunCollectionDetailsTableAdapter = New qryGunCollectionDetailsTableAdapter
        Me.btnCopy = New Button
        Me.HelpProvider1 = New HelpProvider
        CType(Me.QryGunCollectionDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New Point(1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(279, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the firearm listed below to copy this accessory to:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.QryGunCollectionDetailsBindingSource
        Me.ComboBox1.DisplayMember = "FullName"
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New Point(4, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New Size(180, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ID"
        '
        'QryGunCollectionDetailsBindingSource
        '
        Me.QryGunCollectionDetailsBindingSource.DataMember = "qryGunCollectionDetails"
        Me.QryGunCollectionDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'QryGunCollectionDetailsTableAdapter
        '
        Me.QryGunCollectionDetailsTableAdapter.ClearBeforeFill = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New Point(203, 49)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New Size(63, 22)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'frmCopyAccessory
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(294, 84)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpKeyword(Me, "Copying an Accessory")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Copying an Accessory")
        Me.Name = "frmCopyAccessory"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Copy Accessory"
        CType(Me.QryGunCollectionDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents QryGunCollectionDetailsBindingSource As BindingSource
    Friend WithEvents QryGunCollectionDetailsTableAdapter As qryGunCollectionDetailsTableAdapter
    Friend WithEvents btnCopy As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
