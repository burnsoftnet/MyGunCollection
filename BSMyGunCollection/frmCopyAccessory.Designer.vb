<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyAccessory
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.QryGunCollectionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet
        Me.QryGunCollectionDetailsTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.qryGunCollectionDetailsTableAdapter
        Me.btnCopy = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.QryGunCollectionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the firearm listed below to copy this accessory to:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.QryGunCollectionDetailsBindingSource
        Me.ComboBox1.DisplayMember = "FullName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
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
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryGunCollectionDetailsTableAdapter
        '
        Me.QryGunCollectionDetailsTableAdapter.ClearBeforeFill = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(203, 49)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(63, 22)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 84)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpProvider1.SetHelpKeyword(Me, "Copying an Accessory")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Copying an Accessory")
        Me.Name = "frmCopyAccessory"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Copy Accessory"
        CType(Me.QryGunCollectionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents QryGunCollectionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryGunCollectionDetailsTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.qryGunCollectionDetailsTableAdapter
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
