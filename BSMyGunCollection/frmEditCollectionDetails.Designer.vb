Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmEditCollectionDetails
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditCollectionDetails))
        Me.btnCancel = New Button()
        Me.btnUpdate = New Button()
        Me.txtBarHei = New TextBox()
        Me.txtBarWid = New TextBox()
        Me.Label17 = New Label()
        Me.Label16 = New Label()
        Me.HelpProvider1 = New HelpProvider()
        Me.TabControl1 = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.Label39 = New Label()
        Me.txtCaliber3 = New TextBox()
        Me.txtChoke = New TextBox()
        Me.Label35 = New Label()
        Me.dtpSold = New DateTimePicker()
        Me.Label34 = New Label()
        Me.txtImporter = New TextBox()
        Me.Label33 = New Label()
        Me.dtpPurchased = New DateTimePicker()
        Me.Label32 = New Label()
        Me.txtPetLoads = New TextBox()
        Me.Label12 = New Label()
        Me.Label21 = New Label()
        Me.cmdCondition = New ComboBox()
        Me.GunCollectionConditionBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.txtPurPrice = New TextBox()
        Me.txtPurchasedFrom = New TextBox()
        Me.txtStorage = New TextBox()
        Me.txtSights = New TextBox()
        Me.txtFeed = New TextBox()
        Me.txtAction = New TextBox()
        Me.txtProduced = New TextBox()
        Me.txtGripType = New TextBox()
        Me.txtCustCatID = New TextBox()
        Me.txtBarLen = New TextBox()
        Me.txtLength = New TextBox()
        Me.txtWeight = New TextBox()
        Me.txtNationality = New TextBox()
        Me.txtFinish = New TextBox()
        Me.Label28 = New Label()
        Me.Label27 = New Label()
        Me.Label22 = New Label()
        Me.Label20 = New Label()
        Me.Label19 = New Label()
        Me.Label18 = New Label()
        Me.Label15 = New Label()
        Me.Label14 = New Label()
        Me.Label13 = New Label()
        Me.Label11 = New Label()
        Me.txtCal = New TextBox()
        Me.Label10 = New Label()
        Me.Label9 = New Label()
        Me.Label8 = New Label()
        Me.Label7 = New Label()
        Me.Label6 = New Label()
        Me.Label5 = New Label()
        Me.txtType = New TextBox()
        Me.txtSerial = New TextBox()
        Me.txtModel = New TextBox()
        Me.txtManu = New TextBox()
        Me.Label4 = New Label()
        Me.Label3 = New Label()
        Me.Label2 = New Label()
        Me.Label1 = New Label()
        Me.TabPage4 = New TabPage()
        Me.txtClassIIIOwner = New TextBox()
        Me.Label61 = New Label()
        Me.chkClassIII = New CheckBox()
        Me.Label60 = New Label()
        Me.cmbClassification = New ComboBox()
        Me.GunCollectionClassificationBindingSource = New BindingSource(Me.components)
        Me.dtpDateofCR = New DateTimePicker()
        Me.Label38 = New Label()
        Me.txtTriggerPull = New TextBox()
        Me.txtTwistOfRate = New TextBox()
        Me.Label37 = New Label()
        Me.Label36 = New Label()
        Me.txtInsVal = New TextBox()
        Me.Label26 = New Label()
        Me.txtAppBy = New TextBox()
        Me.dtpAppDate = New DateTimePicker()
        Me.txtAppValue = New TextBox()
        Me.Label25 = New Label()
        Me.Label24 = New Label()
        Me.Label23 = New Label()
        Me.Label55 = New Label()
        Me.chkBoundBook = New CheckBox()
        Me.Label54 = New Label()
        Me.txtPOI = New TextBox()
        Me.dtpReManDT = New DateTimePicker()
        Me.Label30 = New Label()
        Me.Label29 = New Label()
        Me.chkBoxCR = New CheckBox()
        Me.Label31 = New Label()
        Me.TabPage2 = New TabPage()
        Me.txtConCom = New TextBox()
        Me.TabPage3 = New TabPage()
        Me.txtAddNotes = New TextBox()
        Me.Gun_Collection_ConditionTableAdapter = New Gun_Collection_ConditionTableAdapter()
        Me.Gun_Collection_ClassificationTableAdapter = New Gun_Collection_ClassificationTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GunCollectionConditionBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GunCollectionClassificationBindingSource, ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(424, 493)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(129, 22)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New Point(55, 493)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New Size(173, 23)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "Update Firearm Details"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtBarHei
        '
        Me.txtBarHei.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarHei.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarHei.Location = New Point(297, 701)
        Me.txtBarHei.Name = "txtBarHei"
        Me.txtBarHei.Size = New Size(156, 20)
        Me.txtBarHei.TabIndex = 15
        Me.txtBarHei.Visible = False
        '
        'txtBarWid
        '
        Me.txtBarWid.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarWid.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarWid.Location = New Point(297, 675)
        Me.txtBarWid.Name = "txtBarWid"
        Me.txtBarWid.Size = New Size(156, 20)
        Me.txtBarWid.TabIndex = 14
        Me.txtBarWid.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New Point(197, 704)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New Size(71, 13)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Barrel Height:"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New Point(197, 678)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New Size(68, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Barrel Width:"
        Me.Label16.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New Size(622, 485)
        Me.TabControl1.TabIndex = 133
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.txtCaliber3)
        Me.TabPage1.Controls.Add(Me.txtChoke)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.dtpSold)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.txtImporter)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.dtpPurchased)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.txtPetLoads)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.cmdCondition)
        Me.TabPage1.Controls.Add(Me.txtPurPrice)
        Me.TabPage1.Controls.Add(Me.txtPurchasedFrom)
        Me.TabPage1.Controls.Add(Me.txtStorage)
        Me.TabPage1.Controls.Add(Me.txtSights)
        Me.TabPage1.Controls.Add(Me.txtFeed)
        Me.TabPage1.Controls.Add(Me.txtAction)
        Me.TabPage1.Controls.Add(Me.txtProduced)
        Me.TabPage1.Controls.Add(Me.txtGripType)
        Me.TabPage1.Controls.Add(Me.txtCustCatID)
        Me.TabPage1.Controls.Add(Me.txtBarLen)
        Me.TabPage1.Controls.Add(Me.txtLength)
        Me.TabPage1.Controls.Add(Me.txtWeight)
        Me.TabPage1.Controls.Add(Me.txtNationality)
        Me.TabPage1.Controls.Add(Me.txtFinish)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtCal)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtType)
        Me.TabPage1.Controls.Add(Me.txtSerial)
        Me.TabPage1.Controls.Add(Me.txtModel)
        Me.TabPage1.Controls.Add(Me.txtManu)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New Padding(3)
        Me.TabPage1.Size = New Size(614, 459)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New Point(16, 319)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New Size(58, 13)
        Me.Label39.TabIndex = 199
        Me.Label39.Text = "Caliber #3:"
        '
        'txtCaliber3
        '
        Me.txtCaliber3.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCaliber3.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCaliber3.Location = New Point(116, 316)
        Me.txtCaliber3.Name = "txtCaliber3"
        Me.txtCaliber3.Size = New Size(156, 20)
        Me.txtCaliber3.TabIndex = 198
        '
        'txtChoke
        '
        Me.txtChoke.Location = New Point(440, 342)
        Me.txtChoke.Name = "txtChoke"
        Me.txtChoke.Size = New Size(156, 20)
        Me.txtChoke.TabIndex = 197
        Me.txtChoke.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New Point(319, 345)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New Size(78, 13)
        Me.Label35.TabIndex = 196
        Me.Label35.Text = "Current Choke:"
        Me.Label35.Visible = False
        '
        'dtpSold
        '
        Me.dtpSold.Format = DateTimePickerFormat.[Short]
        Me.dtpSold.Location = New Point(116, 344)
        Me.dtpSold.Name = "dtpSold"
        Me.dtpSold.Size = New Size(156, 20)
        Me.dtpSold.TabIndex = 195
        Me.dtpSold.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New Point(16, 347)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New Size(69, 13)
        Me.Label34.TabIndex = 194
        Me.Label34.Text = "Date of Sale:"
        Me.Label34.Visible = False
        '
        'txtImporter
        '
        Me.txtImporter.AllowDrop = True
        Me.txtImporter.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtImporter.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtImporter.Location = New Point(116, 55)
        Me.txtImporter.Name = "txtImporter"
        Me.txtImporter.Size = New Size(156, 20)
        Me.txtImporter.TabIndex = 134
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New Point(16, 58)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New Size(55, 13)
        Me.Label33.TabIndex = 189
        Me.Label33.Text = "Importer: *"
        '
        'dtpPurchased
        '
        Me.dtpPurchased.Format = DateTimePickerFormat.[Short]
        Me.dtpPurchased.Location = New Point(116, 264)
        Me.dtpPurchased.Name = "dtpPurchased"
        Me.dtpPurchased.ShowCheckBox = True
        Me.dtpPurchased.Size = New Size(156, 20)
        Me.dtpPurchased.TabIndex = 142
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New Point(16, 268)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New Size(87, 13)
        Me.Label32.TabIndex = 188
        Me.Label32.Text = "Date Purchased:"
        '
        'txtPetLoads
        '
        Me.txtPetLoads.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPetLoads.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPetLoads.Location = New Point(116, 291)
        Me.txtPetLoads.Name = "txtPetLoads"
        Me.txtPetLoads.Size = New Size(156, 20)
        Me.txtPetLoads.TabIndex = 160
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New Point(16, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(58, 13)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "Caliber #2:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New Point(16, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New Size(454, 13)
        Me.Label21.TabIndex = 185
        Me.Label21.Text = "NOTE: the Asterisk ( * ) denotes required fields for record keeping and reports!"
        '
        'cmdCondition
        '
        Me.cmdCondition.DataSource = Me.GunCollectionConditionBindingSource
        Me.cmdCondition.DisplayMember = "Name"
        Me.cmdCondition.FormattingEnabled = True
        Me.cmdCondition.Location = New Point(116, 185)
        Me.cmdCondition.Name = "cmdCondition"
        Me.cmdCondition.Size = New Size(156, 21)
        Me.cmdCondition.TabIndex = 139
        Me.cmdCondition.ValueMember = "Name"
        '
        'GunCollectionConditionBindingSource
        '
        Me.GunCollectionConditionBindingSource.DataMember = "Gun_Collection_Condition"
        Me.GunCollectionConditionBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'txtPurPrice
        '
        Me.txtPurPrice.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurPrice.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurPrice.Location = New Point(116, 238)
        Me.txtPurPrice.Name = "txtPurPrice"
        Me.txtPurPrice.Size = New Size(156, 20)
        Me.txtPurPrice.TabIndex = 141
        '
        'txtPurchasedFrom
        '
        Me.txtPurchasedFrom.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurchasedFrom.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurchasedFrom.Location = New Point(116, 212)
        Me.txtPurchasedFrom.Name = "txtPurchasedFrom"
        Me.txtPurchasedFrom.Size = New Size(156, 20)
        Me.txtPurchasedFrom.TabIndex = 140
        '
        'txtStorage
        '
        Me.txtStorage.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtStorage.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtStorage.Location = New Point(440, 186)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.Size = New Size(156, 20)
        Me.txtStorage.TabIndex = 153
        '
        'txtSights
        '
        Me.txtSights.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSights.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSights.Location = New Point(440, 160)
        Me.txtSights.Name = "txtSights"
        Me.txtSights.Size = New Size(156, 20)
        Me.txtSights.TabIndex = 152
        '
        'txtFeed
        '
        Me.txtFeed.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFeed.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFeed.Location = New Point(440, 134)
        Me.txtFeed.Name = "txtFeed"
        Me.txtFeed.Size = New Size(156, 20)
        Me.txtFeed.TabIndex = 151
        '
        'txtAction
        '
        Me.txtAction.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAction.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAction.Location = New Point(440, 108)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New Size(156, 20)
        Me.txtAction.TabIndex = 150
        '
        'txtProduced
        '
        Me.txtProduced.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtProduced.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtProduced.Location = New Point(440, 81)
        Me.txtProduced.Name = "txtProduced"
        Me.txtProduced.Size = New Size(156, 20)
        Me.txtProduced.TabIndex = 149
        '
        'txtGripType
        '
        Me.txtGripType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtGripType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtGripType.Location = New Point(440, 55)
        Me.txtGripType.Name = "txtGripType"
        Me.txtGripType.Size = New Size(156, 20)
        Me.txtGripType.TabIndex = 148
        '
        'txtCustCatID
        '
        Me.txtCustCatID.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCustCatID.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCustCatID.Location = New Point(440, 29)
        Me.txtCustCatID.Name = "txtCustCatID"
        Me.txtCustCatID.Size = New Size(156, 20)
        Me.txtCustCatID.TabIndex = 147
        '
        'txtBarLen
        '
        Me.txtBarLen.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarLen.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarLen.Location = New Point(440, 316)
        Me.txtBarLen.Name = "txtBarLen"
        Me.txtBarLen.Size = New Size(156, 20)
        Me.txtBarLen.TabIndex = 159
        '
        'txtLength
        '
        Me.txtLength.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtLength.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtLength.Location = New Point(440, 291)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New Size(156, 20)
        Me.txtLength.TabIndex = 158
        '
        'txtWeight
        '
        Me.txtWeight.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtWeight.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtWeight.Location = New Point(440, 264)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New Size(156, 20)
        Me.txtWeight.TabIndex = 157
        '
        'txtNationality
        '
        Me.txtNationality.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtNationality.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtNationality.Location = New Point(440, 239)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New Size(156, 20)
        Me.txtNationality.TabIndex = 156
        '
        'txtFinish
        '
        Me.txtFinish.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFinish.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFinish.Location = New Point(440, 212)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New Size(156, 20)
        Me.txtFinish.TabIndex = 155
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New Point(16, 215)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New Size(94, 13)
        Me.Label28.TabIndex = 184
        Me.Label28.Text = "Purchased From: *"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New Point(319, 189)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New Size(91, 13)
        Me.Label27.TabIndex = 183
        Me.Label27.Text = "Storage Location:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New Point(16, 241)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New Size(88, 13)
        Me.Label22.TabIndex = 178
        Me.Label22.Text = "Purchased Price:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New Point(319, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New Size(39, 13)
        Me.Label20.TabIndex = 177
        Me.Label20.Text = "Sights:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New Point(319, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New Size(117, 13)
        Me.Label19.TabIndex = 176
        Me.Label19.Text = "Feed System/Capacity:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New Point(319, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New Size(40, 13)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "Action:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New Point(319, 319)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New Size(73, 13)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "Barrel Length:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New Point(319, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New Size(79, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Overall Length:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New Point(319, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New Size(44, 13)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Weight:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New Point(319, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(102, 13)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "Manufactured Date:"
        '
        'txtCal
        '
        Me.txtCal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCal.Location = New Point(116, 159)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New Size(156, 20)
        Me.txtCal.TabIndex = 138
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(319, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(89, 13)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Stock/Grip Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(319, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(37, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Finish:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New Point(16, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(54, 13)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Condition:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(319, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(104, 13)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Custom Catalog No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(319, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(77, 13)
        Me.Label6.TabIndex = 166
        Me.Label6.Text = "Place of origin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(16, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(98, 13)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Caliber Or Gauge: *"
        '
        'txtType
        '
        Me.txtType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtType.Location = New Point(116, 133)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New Size(156, 20)
        Me.txtType.TabIndex = 137
        '
        'txtSerial
        '
        Me.txtSerial.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSerial.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSerial.Location = New Point(116, 107)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New Size(156, 20)
        Me.txtSerial.TabIndex = 136
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtModel.Location = New Point(116, 81)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New Size(156, 20)
        Me.txtModel.TabIndex = 135
        '
        'txtManu
        '
        Me.txtManu.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtManu.Location = New Point(116, 30)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New Size(156, 20)
        Me.txtManu.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(41, 13)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Type: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(16, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(83, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Serial Number: *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(46, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Model: *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(80, 13)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Manufacturer: *"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtClassIIIOwner)
        Me.TabPage4.Controls.Add(Me.Label61)
        Me.TabPage4.Controls.Add(Me.chkClassIII)
        Me.TabPage4.Controls.Add(Me.Label60)
        Me.TabPage4.Controls.Add(Me.cmbClassification)
        Me.TabPage4.Controls.Add(Me.dtpDateofCR)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.txtTriggerPull)
        Me.TabPage4.Controls.Add(Me.txtTwistOfRate)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.txtInsVal)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.txtAppBy)
        Me.TabPage4.Controls.Add(Me.dtpAppDate)
        Me.TabPage4.Controls.Add(Me.txtAppValue)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label55)
        Me.TabPage4.Controls.Add(Me.chkBoundBook)
        Me.TabPage4.Controls.Add(Me.Label54)
        Me.TabPage4.Controls.Add(Me.txtPOI)
        Me.TabPage4.Controls.Add(Me.dtpReManDT)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.chkBoxCR)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Location = New Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New Padding(3)
        Me.TabPage4.Size = New Size(614, 459)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Collector Details"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtClassIIIOwner
        '
        Me.txtClassIIIOwner.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtClassIIIOwner.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtClassIIIOwner.Location = New Point(110, 206)
        Me.txtClassIIIOwner.Name = "txtClassIIIOwner"
        Me.txtClassIIIOwner.Size = New Size(156, 20)
        Me.txtClassIIIOwner.TabIndex = 239
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New Point(10, 209)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New Size(41, 13)
        Me.Label61.TabIndex = 238
        Me.Label61.Text = "Owner:"
        '
        'chkClassIII
        '
        Me.chkClassIII.AutoSize = True
        Me.chkClassIII.Location = New Point(109, 185)
        Me.chkClassIII.Name = "chkClassIII"
        Me.chkClassIII.Size = New Size(44, 17)
        Me.chkClassIII.TabIndex = 237
        Me.chkClassIII.Text = "Yes"
        Me.chkClassIII.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New Point(9, 186)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New Size(73, 13)
        Me.Label60.TabIndex = 236
        Me.Label60.Text = "Class III Item?"
        '
        'cmbClassification
        '
        Me.cmbClassification.AllowDrop = True
        Me.cmbClassification.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.cmbClassification.DataSource = Me.GunCollectionClassificationBindingSource
        Me.cmbClassification.DisplayMember = "myclass"
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.Location = New Point(429, 73)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New Size(156, 21)
        Me.cmbClassification.TabIndex = 224
        Me.cmbClassification.ValueMember = "myclass"
        '
        'GunCollectionClassificationBindingSource
        '
        Me.GunCollectionClassificationBindingSource.DataMember = "Gun_Collection_Classification"
        Me.GunCollectionClassificationBindingSource.DataSource = Me.MGCDataSet
        '
        'dtpDateofCR
        '
        Me.dtpDateofCR.Checked = False
        Me.dtpDateofCR.Format = DateTimePickerFormat.[Short]
        Me.dtpDateofCR.Location = New Point(429, 99)
        Me.dtpDateofCR.Name = "dtpDateofCR"
        Me.dtpDateofCR.ShowCheckBox = True
        Me.dtpDateofCR.Size = New Size(156, 20)
        Me.dtpDateofCR.TabIndex = 223
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New Point(308, 103)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New Size(75, 13)
        Me.Label38.TabIndex = 222
        Me.Label38.Text = "Date of C && R:"
        '
        'txtTriggerPull
        '
        Me.txtTriggerPull.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTriggerPull.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTriggerPull.Location = New Point(108, 158)
        Me.txtTriggerPull.Name = "txtTriggerPull"
        Me.txtTriggerPull.Size = New Size(156, 20)
        Me.txtTriggerPull.TabIndex = 221
        '
        'txtTwistOfRate
        '
        Me.txtTwistOfRate.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTwistOfRate.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTwistOfRate.Location = New Point(108, 129)
        Me.txtTwistOfRate.Name = "txtTwistOfRate"
        Me.txtTwistOfRate.Size = New Size(156, 20)
        Me.txtTwistOfRate.TabIndex = 220
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New Point(8, 161)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New Size(97, 13)
        Me.Label37.TabIndex = 219
        Me.Label37.Text = "Trigger Pull  ( lbs. ):"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New Point(7, 132)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New Size(73, 13)
        Me.Label36.TabIndex = 218
        Me.Label36.Text = "Twist of Rate:"
        '
        'txtInsVal
        '
        Me.txtInsVal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtInsVal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtInsVal.Location = New Point(107, 99)
        Me.txtInsVal.Name = "txtInsVal"
        Me.txtInsVal.Size = New Size(156, 20)
        Me.txtInsVal.TabIndex = 216
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New Point(7, 102)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New Size(75, 13)
        Me.Label26.TabIndex = 217
        Me.Label26.Text = "Insured Value:"
        '
        'txtAppBy
        '
        Me.txtAppBy.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAppBy.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAppBy.Location = New Point(107, 73)
        Me.txtAppBy.Name = "txtAppBy"
        Me.txtAppBy.Size = New Size(156, 20)
        Me.txtAppBy.TabIndex = 212
        '
        'dtpAppDate
        '
        Me.dtpAppDate.Checked = False
        Me.dtpAppDate.Format = DateTimePickerFormat.[Short]
        Me.dtpAppDate.Location = New Point(107, 47)
        Me.dtpAppDate.Name = "dtpAppDate"
        Me.dtpAppDate.ShowCheckBox = True
        Me.dtpAppDate.Size = New Size(156, 20)
        Me.dtpAppDate.TabIndex = 211
        '
        'txtAppValue
        '
        Me.txtAppValue.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAppValue.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAppValue.Location = New Point(107, 21)
        Me.txtAppValue.Name = "txtAppValue"
        Me.txtAppValue.Size = New Size(156, 20)
        Me.txtAppValue.TabIndex = 210
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New Point(7, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New Size(72, 13)
        Me.Label25.TabIndex = 215
        Me.Label25.Text = "Appraised By:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New Point(7, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New Size(79, 13)
        Me.Label24.TabIndex = 214
        Me.Label24.Text = "Appraisal Date:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New Point(7, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New Size(87, 13)
        Me.Label23.TabIndex = 213
        Me.Label23.Text = "Appraised Value:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New Point(308, 74)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New Size(71, 13)
        Me.Label55.TabIndex = 208
        Me.Label55.Text = "Classification:"
        '
        'chkBoundBook
        '
        Me.chkBoundBook.AutoSize = True
        Me.chkBoundBook.Checked = True
        Me.chkBoundBook.CheckState = CheckState.Checked
        Me.chkBoundBook.Location = New Point(429, 47)
        Me.chkBoundBook.Name = "chkBoundBook"
        Me.chkBoundBook.Size = New Size(44, 17)
        Me.chkBoundBook.TabIndex = 207
        Me.chkBoundBook.Text = "Yes"
        Me.chkBoundBook.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New Point(308, 47)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New Size(100, 13)
        Me.Label54.TabIndex = 206
        Me.Label54.Text = "Add to Bound Book"
        '
        'txtPOI
        '
        Me.txtPOI.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPOI.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPOI.Location = New Point(429, 158)
        Me.txtPOI.Name = "txtPOI"
        Me.txtPOI.Size = New Size(156, 20)
        Me.txtPOI.TabIndex = 197
        '
        'dtpReManDT
        '
        Me.dtpReManDT.Checked = False
        Me.dtpReManDT.Format = DateTimePickerFormat.[Short]
        Me.dtpReManDT.Location = New Point(429, 129)
        Me.dtpReManDT.Name = "dtpReManDT"
        Me.dtpReManDT.ShowCheckBox = True
        Me.dtpReManDT.Size = New Size(156, 20)
        Me.dtpReManDT.TabIndex = 196
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New Point(308, 161)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New Size(83, 13)
        Me.Label30.TabIndex = 195
        Me.Label30.Text = "Place Of Import:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New Point(308, 132)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New Size(109, 13)
        Me.Label29.TabIndex = 194
        Me.Label29.Text = "Remanufacture Date:"
        '
        'chkBoxCR
        '
        Me.chkBoxCR.AutoSize = True
        Me.chkBoxCR.Location = New Point(429, 24)
        Me.chkBoxCR.Name = "chkBoxCR"
        Me.chkBoxCR.Size = New Size(44, 17)
        Me.chkBoxCR.TabIndex = 187
        Me.chkBoxCR.Text = "Yes"
        Me.chkBoxCR.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New Point(308, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New Size(89, 13)
        Me.Label31.TabIndex = 188
        Me.Label31.Text = "Is C && R Qualified"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtConCom)
        Me.TabPage2.Location = New Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.TabPage2.Size = New Size(614, 459)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Condition Comments"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtConCom
        '
        Me.txtConCom.Location = New Point(3, 5)
        Me.txtConCom.Multiline = True
        Me.txtConCom.Name = "txtConCom"
        Me.txtConCom.ScrollBars = ScrollBars.Vertical
        Me.txtConCom.Size = New Size(608, 426)
        Me.txtConCom.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtAddNotes)
        Me.TabPage3.Location = New Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New Size(614, 459)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Additional Notes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtAddNotes
        '
        Me.txtAddNotes.Location = New Point(0, 5)
        Me.txtAddNotes.Multiline = True
        Me.txtAddNotes.Name = "txtAddNotes"
        Me.txtAddNotes.ScrollBars = ScrollBars.Vertical
        Me.txtAddNotes.Size = New Size(611, 429)
        Me.txtAddNotes.TabIndex = 31
        '
        'Gun_Collection_ConditionTableAdapter
        '
        Me.Gun_Collection_ConditionTableAdapter.ClearBeforeFill = True
        '
        'Gun_Collection_ClassificationTableAdapter
        '
        Me.Gun_Collection_ClassificationTableAdapter.ClearBeforeFill = True
        '
        'frmEditCollectionDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(622, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtBarHei)
        Me.Controls.Add(Me.txtBarWid)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.HelpProvider1.SetHelpKeyword(Me, "Edit a Firearm")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Edit a Firearm")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCollectionDetails"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Edit Firearm in my Collection"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GunCollectionConditionBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GunCollectionClassificationBindingSource, ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtBarHei As TextBox
    Friend WithEvents txtBarWid As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtImporter As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents dtpPurchased As DateTimePicker
    Friend WithEvents Label32 As Label
    Friend WithEvents txtPetLoads As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmdCondition As ComboBox
    Friend WithEvents txtPurPrice As TextBox
    Friend WithEvents txtPurchasedFrom As TextBox
    Friend WithEvents txtStorage As TextBox
    Friend WithEvents txtSights As TextBox
    Friend WithEvents txtFeed As TextBox
    Friend WithEvents txtAction As TextBox
    Friend WithEvents txtProduced As TextBox
    Friend WithEvents txtGripType As TextBox
    Friend WithEvents txtCustCatID As TextBox
    Friend WithEvents txtBarLen As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents txtFinish As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtManu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConCom As TextBox
    Friend WithEvents txtAddNotes As TextBox
    Friend WithEvents dtpSold As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionConditionBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ConditionTableAdapter As Gun_Collection_ConditionTableAdapter
    Friend WithEvents txtChoke As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtPOI As TextBox
    Friend WithEvents dtpReManDT As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents chkBoxCR As CheckBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents chkBoundBook As CheckBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtAppBy As TextBox
    Friend WithEvents dtpAppDate As DateTimePicker
    Friend WithEvents txtAppValue As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtInsVal As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txtCaliber3 As TextBox
    Friend WithEvents txtTriggerPull As TextBox
    Friend WithEvents txtTwistOfRate As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents dtpDateofCR As DateTimePicker
    Friend WithEvents Label38 As Label
    Friend WithEvents cmbClassification As ComboBox
    Friend WithEvents GunCollectionClassificationBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ClassificationTableAdapter As Gun_Collection_ClassificationTableAdapter
    Friend WithEvents txtClassIIIOwner As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents chkClassIII As CheckBox
    Friend WithEvents Label60 As Label
End Class
