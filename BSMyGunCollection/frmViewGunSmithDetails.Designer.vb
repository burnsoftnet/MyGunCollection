Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewGunSmithDetails
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewGunSmithDetails))
        Me.TabControl1 = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.btnSave = New Button()
        Me.Label12 = New Label()
        Me.txtZip = New TextBox()
        Me.btnCancel = New Button()
        Me.btnEdit = New Button()
        Me.txteMail = New TextBox()
        Me.txtName = New TextBox()
        Me.txtAddress1 = New TextBox()
        Me.txtAddress2 = New TextBox()
        Me.txtCity = New TextBox()
        Me.txtState = New TextBox()
        Me.txtWebSite = New TextBox()
        Me.txtCountry = New TextBox()
        Me.txtFax = New TextBox()
        Me.txtPhone = New TextBox()
        Me.chkSIB = New CheckBox()
        Me.txtLic = New TextBox()
        Me.Label11 = New Label()
        Me.Label10 = New Label()
        Me.Label9 = New Label()
        Me.Label8 = New Label()
        Me.Label7 = New Label()
        Me.Label6 = New Label()
        Me.Label5 = New Label()
        Me.Label4 = New Label()
        Me.Label3 = New Label()
        Me.Label2 = New Label()
        Me.Label1 = New Label()
        Me.TabPage2 = New TabPage()
        Me.ListBox1 = New ListBox()
        Me.GunCollectionGunSmithsBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_Collection_GunSmithsTableAdapter = New Gun_Collection_GunSmithsTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GunCollectionGunSmithsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New Size(300, 415)
        Me.TabControl1.TabIndex = 1
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
        Me.TabPage1.Location = New Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New Padding(3)
        Me.TabPage1.Size = New Size(292, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New Point(30, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New Point(6, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(53, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New Point(103, 141)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New Size(171, 20)
        Me.txtZip.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(170, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New Point(30, 352)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(75, 23)
        Me.btnEdit.TabIndex = 50
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txteMail
        '
        Me.txteMail.Location = New Point(103, 271)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.ReadOnly = True
        Me.txteMail.Size = New Size(171, 20)
        Me.txteMail.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New Point(103, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New Size(171, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New Point(103, 36)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New Size(171, 20)
        Me.txtAddress1.TabIndex = 2
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New Point(103, 62)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New Size(171, 20)
        Me.txtAddress2.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New Point(103, 87)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New Size(171, 20)
        Me.txtCity.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.Location = New Point(103, 115)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New Size(171, 20)
        Me.txtState.TabIndex = 5
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New Point(103, 245)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New Size(171, 20)
        Me.txtWebSite.TabIndex = 10
        '
        'txtCountry
        '
        Me.txtCountry.Location = New Point(103, 167)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New Size(171, 20)
        Me.txtCountry.TabIndex = 7
        '
        'txtFax
        '
        Me.txtFax.Location = New Point(103, 216)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New Size(171, 20)
        Me.txtFax.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New Point(103, 193)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New Size(171, 20)
        Me.txtPhone.TabIndex = 8
        '
        'chkSIB
        '
        Me.chkSIB.AutoSize = True
        Me.chkSIB.Enabled = False
        Me.chkSIB.Location = New Point(103, 319)
        Me.chkSIB.Name = "chkSIB"
        Me.chkSIB.Size = New Size(44, 17)
        Me.chkSIB.TabIndex = 13
        Me.chkSIB.Text = "Yes"
        Me.chkSIB.UseVisualStyleBackColor = True
        '
        'txtLic
        '
        Me.txtLic.Location = New Point(103, 295)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New Size(171, 20)
        Me.txtLic.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New Point(6, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(82, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Still in Business:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(4, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(47, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "License:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(4, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(34, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New Point(6, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(49, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Website:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(6, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(27, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Fax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(6, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(41, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(6, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(46, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(5, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(35, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(27, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(48, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(38, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.ImageKey = "Military_Gun_1_16x16.ico"
        Me.TabPage2.Location = New Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.TabPage2.Size = New Size(292, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Firearms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.GunCollectionGunSmithsBindingSource
        Me.ListBox1.DisplayMember = "FullName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New Point(4, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(282, 368)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "FullName"
        '
        'GunCollectionGunSmithsBindingSource
        '
        Me.GunCollectionGunSmithsBindingSource.DataMember = "Gun_Collection_GunSmiths"
        Me.GunCollectionGunSmithsBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_Collection_GunSmithsTableAdapter
        '
        Me.Gun_Collection_GunSmithsTableAdapter.ClearBeforeFill = True
        '
        'frmViewGunSmithDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(302, 415)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewGunSmithDetails"
        Me.Text = "Gunsmith Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GunCollectionGunSmithsBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txteMail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtWebSite As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents chkSIB As CheckBox
    Friend WithEvents txtLic As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GunCollectionGunSmithsBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents Gun_Collection_GunSmithsTableAdapter As Gun_Collection_GunSmithsTableAdapter
    Friend WithEvents btnSave As Button
End Class
