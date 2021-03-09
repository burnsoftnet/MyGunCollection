Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewBuyerDetails
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewBuyerDetails))
        Me.TabControl1 = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.Label21 = New Label()
        Me.Label29 = New Label()
        Me.txtRes = New TextBox()
        Me.txtDOB = New TextBox()
        Me.txtDLic = New TextBox()
        Me.Label30 = New Label()
        Me.Label31 = New Label()
        Me.txtZip = New TextBox()
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
        Me.txtLic = New TextBox()
        Me.Label32 = New Label()
        Me.Label33 = New Label()
        Me.Label34 = New Label()
        Me.Label35 = New Label()
        Me.Label36 = New Label()
        Me.Label37 = New Label()
        Me.Label38 = New Label()
        Me.Label39 = New Label()
        Me.Label40 = New Label()
        Me.Label41 = New Label()
        Me.TabPage2 = New TabPage()
        Me.DataGridView1 = New DataGridView()
        Me.FullNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.CaliberDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.AppraisedValue = New DataGridViewTextBoxColumn()
        Me.dtSold = New DataGridViewTextBoxColumn()
        Me.GunCollectionBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_CollectionTableAdapter = New Gun_CollectionTableAdapter()
        Me.btnEdit = New Button()
        Me.btnCanel = New Button()
        Me.btnUpdate = New Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New Point(3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New Size(701, 304)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.txtRes)
        Me.TabPage1.Controls.Add(Me.txtDOB)
        Me.TabPage1.Controls.Add(Me.txtDLic)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.txtZip)
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
        Me.TabPage1.Controls.Add(Me.txtLic)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Location = New Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New Padding(3)
        Me.TabPage1.Size = New Size(693, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New Point(298, 179)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New Size(102, 13)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "Residency/Alien ID:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New Point(298, 154)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New Size(69, 13)
        Me.Label29.TabIndex = 143
        Me.Label29.Text = "Date of Birth:"
        '
        'txtRes
        '
        Me.txtRes.Location = New Point(416, 176)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New Size(171, 20)
        Me.txtRes.TabIndex = 142
        '
        'txtDOB
        '
        Me.txtDOB.Location = New Point(416, 151)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New Size(171, 20)
        Me.txtDOB.TabIndex = 141
        '
        'txtDLic
        '
        Me.txtDLic.Location = New Point(416, 124)
        Me.txtDLic.Name = "txtDLic"
        Me.txtDLic.ReadOnly = True
        Me.txtDLic.Size = New Size(171, 20)
        Me.txtDLic.TabIndex = 140
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New Point(298, 127)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New Size(114, 13)
        Me.Label30.TabIndex = 139
        Me.Label30.Text = "Drivers License/Other:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New Point(6, 154)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New Size(53, 13)
        Me.Label31.TabIndex = 138
        Me.Label31.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New Point(75, 150)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New Size(171, 20)
        Me.txtZip.TabIndex = 137
        '
        'txteMail
        '
        Me.txteMail.Location = New Point(416, 72)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.ReadOnly = True
        Me.txteMail.Size = New Size(171, 20)
        Me.txteMail.TabIndex = 136
        '
        'txtName
        '
        Me.txtName.Location = New Point(75, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New Size(171, 20)
        Me.txtName.TabIndex = 135
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New Point(75, 46)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New Size(171, 20)
        Me.txtAddress1.TabIndex = 134
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New Point(75, 72)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New Size(171, 20)
        Me.txtAddress2.TabIndex = 133
        '
        'txtCity
        '
        Me.txtCity.Location = New Point(75, 98)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New Size(171, 20)
        Me.txtCity.TabIndex = 132
        '
        'txtState
        '
        Me.txtState.Location = New Point(75, 124)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New Size(171, 20)
        Me.txtState.TabIndex = 131
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New Point(416, 46)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New Size(171, 20)
        Me.txtWebSite.TabIndex = 130
        '
        'txtCountry
        '
        Me.txtCountry.Location = New Point(75, 176)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New Size(171, 20)
        Me.txtCountry.TabIndex = 129
        '
        'txtFax
        '
        Me.txtFax.Location = New Point(416, 20)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New Size(171, 20)
        Me.txtFax.TabIndex = 128
        '
        'txtPhone
        '
        Me.txtPhone.Location = New Point(75, 202)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New Size(171, 20)
        Me.txtPhone.TabIndex = 127
        '
        'txtLic
        '
        Me.txtLic.Location = New Point(416, 98)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New Size(171, 20)
        Me.txtLic.TabIndex = 126
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New Point(298, 101)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New Size(81, 13)
        Me.Label32.TabIndex = 125
        Me.Label32.Text = "FFL# or 4473#:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New Point(298, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New Size(34, 13)
        Me.Label33.TabIndex = 124
        Me.Label33.Text = "email:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New Point(299, 49)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New Size(49, 13)
        Me.Label34.TabIndex = 123
        Me.Label34.Text = "Website:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New Point(298, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New Size(27, 13)
        Me.Label35.TabIndex = 122
        Me.Label35.Text = "Fax:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New Point(6, 206)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New Size(41, 13)
        Me.Label36.TabIndex = 121
        Me.Label36.Text = "Phone:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New Point(6, 179)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New Size(46, 13)
        Me.Label37.TabIndex = 120
        Me.Label37.Text = "Country:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New Point(6, 127)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New Size(35, 13)
        Me.Label38.TabIndex = 119
        Me.Label38.Text = "State:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New Point(6, 98)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New Size(27, 13)
        Me.Label39.TabIndex = 118
        Me.Label39.Text = "City:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New Point(6, 49)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New Size(48, 13)
        Me.Label40.TabIndex = 117
        Me.Label40.Text = "Address:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New Point(6, 23)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New Size(38, 13)
        Me.Label41.TabIndex = 116
        Me.Label41.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.TabPage2.Size = New Size(693, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchased"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.FullNameDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CaliberDataGridViewTextBoxColumn, Me.AppraisedValue, Me.dtSold})
        Me.DataGridView1.DataSource = Me.GunCollectionBindingSource
        Me.DataGridView1.Location = New Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New Size(677, 267)
        Me.DataGridView1.TabIndex = 0
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullNameDataGridViewTextBoxColumn.Width = 60
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number"
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaliberDataGridViewTextBoxColumn
        '
        Me.CaliberDataGridViewTextBoxColumn.DataPropertyName = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.HeaderText = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.Name = "CaliberDataGridViewTextBoxColumn"
        Me.CaliberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AppraisedValue
        '
        Me.AppraisedValue.DataPropertyName = "AppraisedValue"
        Me.AppraisedValue.HeaderText = "Sold For"
        Me.AppraisedValue.Name = "AppraisedValue"
        Me.AppraisedValue.ReadOnly = True
        '
        'dtSold
        '
        Me.dtSold.DataPropertyName = "dtSold"
        Me.dtSold.HeaderText = "Date Sold"
        Me.dtSold.Name = "dtSold"
        Me.dtSold.ReadOnly = True
        '
        'GunCollectionBindingSource
        '
        Me.GunCollectionBindingSource.DataMember = "Gun_Collection"
        Me.GunCollectionBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New Point(130, 314)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCanel
        '
        Me.btnCanel.Location = New Point(388, 314)
        Me.btnCanel.Name = "btnCanel"
        Me.btnCanel.Size = New Size(75, 23)
        Me.btnCanel.TabIndex = 2
        Me.btnCanel.Text = "Cancel"
        Me.btnCanel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New Point(130, 314)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'frmViewBuyerDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(703, 341)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCanel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewBuyerDetails"
        Me.Text = "View Buyer Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        CType(Me.GunCollectionBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtRes As TextBox
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtDLic As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtZip As TextBox
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
    Friend WithEvents txtLic As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionBindingSource As BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As Gun_CollectionTableAdapter
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaliberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppraisedValue As DataGridViewTextBoxColumn
    Friend WithEvents dtSold As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCanel As Button
    Friend WithEvents btnUpdate As Button
End Class
