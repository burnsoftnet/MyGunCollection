<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAppraiserDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAppraiserDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
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
        Me.chkSIB = New System.Windows.Forms.CheckBox()
        Me.txtLic = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.GunCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gun_CollectionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 415)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtZip)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnEdit)
        Me.TabPage1.Controls.Add(Me.txteMail)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtAddress1)
        Me.TabPage1.Controls.Add(Me.txtAddress2)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.txtWebSite)
        Me.TabPage1.Controls.Add(Me.txtCountry)
        Me.TabPage1.Controls.Add(Me.txtFax)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.chkSIB)
        Me.TabPage1.Controls.Add(Me.txtLic)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ImageKey = "l-Office_(Office)_Offices_1_32x32.gif"
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(292, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(30, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(103, 141)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(171, 20)
        Me.txtZip.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(170, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(30, 352)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 50
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txteMail
        '
        Me.txteMail.Location = New System.Drawing.Point(103, 271)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.ReadOnly = True
        Me.txteMail.Size = New System.Drawing.Size(171, 20)
        Me.txteMail.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(103, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(171, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(103, 36)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New System.Drawing.Size(171, 20)
        Me.txtAddress1.TabIndex = 2
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(103, 62)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New System.Drawing.Size(171, 20)
        Me.txtAddress2.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(103, 87)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(171, 20)
        Me.txtCity.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(103, 115)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(171, 20)
        Me.txtState.TabIndex = 5
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(103, 245)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New System.Drawing.Size(171, 20)
        Me.txtWebSite.TabIndex = 10
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(103, 167)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(171, 20)
        Me.txtCountry.TabIndex = 7
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(103, 216)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(171, 20)
        Me.txtFax.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(103, 193)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(171, 20)
        Me.txtPhone.TabIndex = 8
        '
        'chkSIB
        '
        Me.chkSIB.AutoSize = True
        Me.chkSIB.Enabled = False
        Me.chkSIB.Location = New System.Drawing.Point(103, 319)
        Me.chkSIB.Name = "chkSIB"
        Me.chkSIB.Size = New System.Drawing.Size(44, 17)
        Me.chkSIB.TabIndex = 13
        Me.chkSIB.Text = "Yes"
        Me.chkSIB.UseVisualStyleBackColor = True
        '
        'txtLic
        '
        Me.txtLic.Location = New System.Drawing.Point(103, 295)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New System.Drawing.Size(171, 20)
        Me.txtLic.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Still in Business:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "License:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Website:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Fax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.ImageKey = "Military_Gun_1_16x16.ico"
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Firearms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.GunCollectionBindingSource
        Me.ListBox1.DisplayMember = "FullName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(4, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 368)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ID"
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunCollectionBindingSource
        '
        Me.GunCollectionBindingSource.DataMember = "Gun_Collection"
        Me.GunCollectionBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = True
        '
        'frmViewAppraiserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewAppraiserDetails"
        Me.Text = "Appraiser Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
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
    Friend WithEvents chkSIB As System.Windows.Forms.CheckBox
    Friend WithEvents txtLic As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter
End Class
