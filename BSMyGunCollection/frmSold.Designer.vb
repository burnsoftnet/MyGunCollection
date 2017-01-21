<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSold
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSold))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txteMail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtWebSite = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLic = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDLic = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbPrevBuyer = New System.Windows.Forms.ComboBox()
        Me.GunCollectionSoldToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Gun_Collection_SoldToTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_SoldToTableAdapter()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpSale = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnNA = New System.Windows.Forms.Button()
        CType(Me.GunCollectionSoldToBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(129, 165)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(191, 20)
        Me.txtZip.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(245, 476)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(40, 476)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Finsh Sale"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txteMail
        '
        Me.txteMail.Location = New System.Drawing.Point(130, 295)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.Size = New System.Drawing.Size(190, 20)
        Me.txteMail.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(130, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(130, 60)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(190, 20)
        Me.txtAddress1.TabIndex = 4
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(130, 86)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(190, 20)
        Me.txtAddress2.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(130, 111)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(190, 20)
        Me.txtCity.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(130, 139)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(190, 20)
        Me.txtState.TabIndex = 8
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(130, 269)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(190, 20)
        Me.txtWebSite.TabIndex = 13
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(129, 191)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(191, 20)
        Me.txtCountry.TabIndex = 10
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(130, 243)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(190, 20)
        Me.txtFax.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(130, 217)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(190, 20)
        Me.txtPhone.TabIndex = 11
        '
        'txtLic
        '
        Me.txtLic.Location = New System.Drawing.Point(130, 319)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.Size = New System.Drawing.Size(190, 20)
        Me.txtLic.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "FFL# or 4473#:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Website:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Fax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Drivers License/Other:"
        '
        'txtDLic
        '
        Me.txtDLic.Location = New System.Drawing.Point(130, 345)
        Me.txtDLic.Name = "txtDLic"
        Me.txtDLic.Size = New System.Drawing.Size(190, 20)
        Me.txtDLic.TabIndex = 16
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(130, 371)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(190, 20)
        Me.txtDOB.TabIndex = 17
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(130, 397)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(190, 20)
        Me.txtRes.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Date of Birth:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Residency/Alien ID:"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Use Previous Buyer:"
        '
        'cmbPrevBuyer
        '
        Me.cmbPrevBuyer.DataSource = Me.GunCollectionSoldToBindingSource
        Me.cmbPrevBuyer.DisplayMember = "Name"
        Me.cmbPrevBuyer.FormattingEnabled = True
        Me.cmbPrevBuyer.Location = New System.Drawing.Point(130, 6)
        Me.cmbPrevBuyer.Name = "cmbPrevBuyer"
        Me.cmbPrevBuyer.Size = New System.Drawing.Size(190, 21)
        Me.cmbPrevBuyer.TabIndex = 1
        Me.cmbPrevBuyer.ValueMember = "ID"
        '
        'GunCollectionSoldToBindingSource
        '
        Me.GunCollectionSoldToBindingSource.DataMember = "Gun_Collection_SoldTo"
        Me.GunCollectionSoldToBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(326, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(44, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Gun_Collection_SoldToTableAdapter
        '
        Me.Gun_Collection_SoldToTableAdapter.ClearBeforeFill = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 427)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Date of Sale:"
        '
        'dtpSale
        '
        Me.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSale.Location = New System.Drawing.Point(129, 424)
        Me.dtpSale.Name = "dtpSale"
        Me.dtpSale.Size = New System.Drawing.Size(113, 20)
        Me.dtpSale.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 453)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 13)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Final Sale Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(129, 450)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(191, 20)
        Me.txtPrice.TabIndex = 20
        '
        'btnNA
        '
        Me.btnNA.Location = New System.Drawing.Point(326, 59)
        Me.btnNA.Name = "btnNA"
        Me.btnNA.Size = New System.Drawing.Size(44, 23)
        Me.btnNA.TabIndex = 5
        Me.btnNA.Text = "N/A"
        Me.btnNA.UseVisualStyleBackColor = True
        '
        'frmSold
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(378, 508)
        Me.Controls.Add(Me.btnNA)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpSale)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.cmbPrevBuyer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtDLic)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txteMail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtWebSite)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLic)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Adding Buyer Information")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Adding Buyer Information")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSold"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Seller and Complete"
        CType(Me.GunCollectionSoldToBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txteMail As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLic As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDLic As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtRes As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbPrevBuyer As System.Windows.Forms.ComboBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionSoldToBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_Collection_SoldToTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_Collection_SoldToTableAdapter
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnNA As System.Windows.Forms.Button
End Class
