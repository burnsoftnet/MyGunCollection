<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBuyerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewBuyerDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtDLic = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaliberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppraisedValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtSold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MGCDataSet = New BSMyGunCollection.MGCDataSet()
        Me.Gun_CollectionTableAdapter = New BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCanel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(701, 304)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(693, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(298, 179)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "Residency/Alien ID:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(298, 154)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 143
        Me.Label29.Text = "Date of Birth:"
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(416, 176)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(171, 20)
        Me.txtRes.TabIndex = 142
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(416, 151)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(171, 20)
        Me.txtDOB.TabIndex = 141
        '
        'txtDLic
        '
        Me.txtDLic.Location = New System.Drawing.Point(416, 124)
        Me.txtDLic.Name = "txtDLic"
        Me.txtDLic.ReadOnly = True
        Me.txtDLic.Size = New System.Drawing.Size(171, 20)
        Me.txtDLic.TabIndex = 140
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(298, 127)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 13)
        Me.Label30.TabIndex = 139
        Me.Label30.Text = "Drivers License/Other:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 154)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 13)
        Me.Label31.TabIndex = 138
        Me.Label31.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(75, 150)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(171, 20)
        Me.txtZip.TabIndex = 137
        '
        'txteMail
        '
        Me.txteMail.Location = New System.Drawing.Point(416, 72)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.ReadOnly = True
        Me.txteMail.Size = New System.Drawing.Size(171, 20)
        Me.txteMail.TabIndex = 136
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(171, 20)
        Me.txtName.TabIndex = 135
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(75, 46)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New System.Drawing.Size(171, 20)
        Me.txtAddress1.TabIndex = 134
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(75, 72)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New System.Drawing.Size(171, 20)
        Me.txtAddress2.TabIndex = 133
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(75, 98)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(171, 20)
        Me.txtCity.TabIndex = 132
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(75, 124)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(171, 20)
        Me.txtState.TabIndex = 131
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(416, 46)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New System.Drawing.Size(171, 20)
        Me.txtWebSite.TabIndex = 130
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(75, 176)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(171, 20)
        Me.txtCountry.TabIndex = 129
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(416, 20)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(171, 20)
        Me.txtFax.TabIndex = 128
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(75, 202)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(171, 20)
        Me.txtPhone.TabIndex = 127
        '
        'txtLic
        '
        Me.txtLic.Location = New System.Drawing.Point(416, 98)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New System.Drawing.Size(171, 20)
        Me.txtLic.TabIndex = 126
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(298, 101)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 13)
        Me.Label32.TabIndex = 125
        Me.Label32.Text = "FFL# or 4473#:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(298, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(34, 13)
        Me.Label33.TabIndex = 124
        Me.Label33.Text = "email:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(299, 49)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(49, 13)
        Me.Label34.TabIndex = 123
        Me.Label34.Text = "Website:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(298, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(27, 13)
        Me.Label35.TabIndex = 122
        Me.Label35.Text = "Fax:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 206)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(41, 13)
        Me.Label36.TabIndex = 121
        Me.Label36.Text = "Phone:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 179)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(46, 13)
        Me.Label37.TabIndex = 120
        Me.Label37.Text = "Country:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 127)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 13)
        Me.Label38.TabIndex = 119
        Me.Label38.Text = "State:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(6, 98)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(27, 13)
        Me.Label39.TabIndex = 118
        Me.Label39.Text = "City:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 49)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(48, 13)
        Me.Label40.TabIndex = 117
        Me.Label40.Text = "Address:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 23)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(38, 13)
        Me.Label41.TabIndex = 116
        Me.Label41.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(693, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchased"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullNameDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CaliberDataGridViewTextBoxColumn, Me.AppraisedValue, Me.dtSold})
        Me.DataGridView1.DataSource = Me.GunCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(677, 267)
        Me.DataGridView1.TabIndex = 0
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.MGCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gun_CollectionTableAdapter
        '
        Me.Gun_CollectionTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(130, 314)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCanel
        '
        Me.btnCanel.Location = New System.Drawing.Point(388, 314)
        Me.btnCanel.Name = "btnCanel"
        Me.btnCanel.Size = New System.Drawing.Size(75, 23)
        Me.btnCanel.TabIndex = 2
        Me.btnCanel.Text = "Cancel"
        Me.btnCanel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(130, 314)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'frmViewBuyerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 341)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCanel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewBuyerDetails"
        Me.Text = "View Buyer Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtRes As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtDLic As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MGCDataSet As BSMyGunCollection.MGCDataSet
    Friend WithEvents GunCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As BSMyGunCollection.MGCDataSetTableAdapters.Gun_CollectionTableAdapter
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaliberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppraisedValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtSold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCanel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
