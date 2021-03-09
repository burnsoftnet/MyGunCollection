Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports DataGridViewAutoFilter
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmViewCollectionDetails
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmViewCollectionDetails))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.TabControl1 = New TabControl()
        Me.TabPage5 = New TabPage()
        Me.Label59 = New Label()
        Me.txtCaliber3 = New TextBox()
        Me.dtpPurchased = New DateTimePicker()
        Me.Label43 = New Label()
        Me.pbStolen = New PictureBox()
        Me.txtChoke = New TextBox()
        Me.Label53 = New Label()
        Me.lblSold = New Label()
        Me.pbSold = New PictureBox()
        Me.PictureBox1 = New PictureBox()
        Me.txtImporter = New TextBox()
        Me.Label44 = New Label()
        Me.Label42 = New Label()
        Me.txtPetLoads = New TextBox()
        Me.txtCondition = New TextBox()
        Me.txtPurPrice = New TextBox()
        Me.txtPurchasedFrom = New TextBox()
        Me.txtStorage = New TextBox()
        Me.txtSights = New TextBox()
        Me.txtFeed = New TextBox()
        Me.txtAction = New TextBox()
        Me.txtProduced = New TextBox()
        Me.txtGripType = New TextBox()
        Me.txtCustCatID = New TextBox()
        Me.txtBarHei = New TextBox()
        Me.txtBarWid = New TextBox()
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
        Me.Label17 = New Label()
        Me.Label16 = New Label()
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
        Me.TabPage11 = New TabPage()
        Me.dtpDateofCR = New DateTimePicker()
        Me.txtClassIIIOwner = New TextBox()
        Me.Label61 = New Label()
        Me.chkClassIII = New CheckBox()
        Me.Label60 = New Label()
        Me.txtTriggerPull = New TextBox()
        Me.txtTwistOfRate = New TextBox()
        Me.Label57 = New Label()
        Me.Label58 = New Label()
        Me.txtInsVal = New TextBox()
        Me.txtAppBy = New TextBox()
        Me.dtpAppDate = New DateTimePicker()
        Me.txtAppValue = New TextBox()
        Me.Label26 = New Label()
        Me.Label25 = New Label()
        Me.Label24 = New Label()
        Me.Label23 = New Label()
        Me.Label56 = New Label()
        Me.txtClassification = New TextBox()
        Me.Label55 = New Label()
        Me.chkBoundBook = New CheckBox()
        Me.Label54 = New Label()
        Me.chkBoxCR = New CheckBox()
        Me.Label12 = New Label()
        Me.txtPOI = New TextBox()
        Me.dtpReManDT = New DateTimePicker()
        Me.Label48 = New Label()
        Me.Label49 = New Label()
        Me.TabPage1 = New TabPage()
        Me.txtConCom = New TextBox()
        Me.TabPage2 = New TabPage()
        Me.txtAddNotes = New TextBox()
        Me.TabPage3 = New TabPage()
        Me.btnGalleryReport = New Button()
        Me.btnRefreshPics = New Button()
        Me.ListView1 = New ListView()
        Me.mnuPictre = New ContextMenuStrip(Me.components)
        Me.mnuPicItem_Show = New ToolStripMenuItem()
        Me.EditNotesToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator1 = New ToolStripSeparator()
        Me.mnuPicItem_Delete = New ToolStripMenuItem()
        Me.btnAdd = New Button()
        Me.TabPage10 = New TabPage()
        Me.DataGridView5 = New DataGridView()
        Me.mnuBarrel = New ContextMenuStrip(Me.components)
        Me.SetAsDefaultToolStripMenuItem = New ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New ToolStripMenuItem()
        Me.MoveToolStripMenuItem = New ToolStripMenuItem()
        Me.TabPage4 = New TabPage()
        Me.lblTAV = New Label()
        Me.Label52 = New Label()
        Me.lblTPV = New Label()
        Me.Label51 = New Label()
        Me.btnVwAccessReport = New Button()
        Me.btnRefresh = New Button()
        Me.btnAddAccess = New Button()
        Me.DataGridView1 = New DataGridView()
        Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Me.AppValue = New DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New ToolStripMenuItem()
        Me.TabPage6 = New TabPage()
        Me.btnAmmoReportByCal = New Button()
        Me.lblAmmoTotal = New Label()
        Me.Label45 = New Label()
        Me.Button1 = New Button()
        Me.btnAddAmmo = New Button()
        Me.DataGridView2 = New DataGridView()
        Me.Qty1 = New DataGridViewTextBoxColumn()
        Me.TabPage7 = New TabPage()
        Me.lblTotalFirearm = New Label()
        Me.Label50 = New Label()
        Me.lblAvgRndsFired = New Label()
        Me.Label47 = New Label()
        Me.lblTotalRndsFired = New Label()
        Me.Label46 = New Label()
        Me.btnPrintPreviewMaintanceReport = New Button()
        Me.Button2 = New Button()
        Me.DataGridView3 = New DataGridView()
        Me.MaintID = New DataGridViewTextBoxColumn()
        Me.au = New DataGridViewTextBoxColumn()
        Me.mnuMain = New ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New ToolStripMenuItem()
        Me.btnAddMain = New Button()
        Me.TabPage8 = New TabPage()
        Me.btnRefreshGS = New Button()
        Me.btnGSLog = New Button()
        Me.DataGridView4 = New DataGridView()
        Me.ID = New DataGridViewTextBoxColumn()
        Me.mnuGunSmith = New ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New ToolStripMenuItem()
        Me.btnGSReport = New Button()
        Me.TabPage9 = New TabPage()
        Me.btnPrintSale = New Button()
        Me.btnStolen = New Button()
        Me.btnUnDoSale = New Button()
        Me.GroupBox1 = New GroupBox()
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
        Me.btnSold = New Button()
        Me.btnFlyer = New Button()
        Me.TabPage12 = New TabPage()
        Me.btnAddExistingDoc = New Button()
        Me.btnAddDocument = New Button()
        Me.DataGridView6 = New DataGridView()
        Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Me.mnuDocsMenu = New ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New ToolStripMenuItem()
        Me.UnLinkToolStripMenuItem = New ToolStripMenuItem()
        Me.EditToolStripMenuItem3 = New ToolStripMenuItem()
        Me.ImageList1 = New ImageList(Me.components)
        Me.OpenFileDialog1 = New OpenFileDialog()
        Me.btnExit = New Button()
        Me.btnEdit = New Button()
        Me.imgPics = New ImageList(Me.components)
        Me.HelpProvider1 = New HelpProvider()
        Me.ToolStrip1 = New ToolStrip()
        Me.ToolStripButton1 = New ToolStripButton()
        Me.ToolStripButton6 = New ToolStripButton()
        Me.ToolStripButton7 = New ToolStripButton()
        Me.ToolStripSeparator3 = New ToolStripSeparator()
        Me.ToolStripButton2 = New ToolStripButton()
        Me.ToolStripButton5 = New ToolStripButton()
        Me.ToolStripButton3 = New ToolStripButton()
        Me.ToolStripSeparator2 = New ToolStripSeparator()
        Me.ToolStripButton4 = New ToolStripButton()
        Me.SaveFileDialog1 = New SaveFileDialog()
        Me.IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.ModelNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.CaliberDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.BarrelLengthDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.PetLoadsDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.PurchasedPriceDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GunCollectionExtBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.ManufacturerDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.UseDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.PurValueDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GunCollectionAccessoriesBindingSource = New BindingSource(Me.components)
        Me.ManufacturerDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.CalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GrainDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.JacketDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.GunCollectionAmmoBindingSource = New BindingSource(Me.components)
        Me.NameDataGridViewTextBoxColumn1 = New DataGridViewAutoFilterTextBoxColumn()
        Me.OpDateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.OpDueDateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.RndFiredDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Me.MaintanceDetailsBindingSource = New BindingSource(Me.components)
        Me.GsmithDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.SdateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.RdateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.OdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Me.GunSmithDetailsBindingSource = New BindingSource(Me.components)
        Me.LinkIDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocnameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocdescriptionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocfilenameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.DocextDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.DoccatDataGridViewTextBoxColumn = New DataGridViewAutoFilterTextBoxColumn()
        Me.DtaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Me.QryDocsAndLinksBindingSource = New BindingSource(Me.components)
        Me.Gun_Collection_AccessoriesTableAdapter = New Gun_Collection_AccessoriesTableAdapter()
        Me.Gun_Collection_AmmoTableAdapter = New Gun_Collection_AmmoTableAdapter()
        Me.Maintance_DetailsTableAdapter = New Maintance_DetailsTableAdapter()
        Me.GunSmith_DetailsTableAdapter = New GunSmith_DetailsTableAdapter()
        Me.Gun_Collection_ExtTableAdapter = New Gun_Collection_ExtTableAdapter()
        Me.Qry_DocsAndLinksTableAdapter = New qry_DocsAndLinksTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.pbStolen, ISupportInitialize).BeginInit()
        CType(Me.pbSold, ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.mnuPictre.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        CType(Me.DataGridView5, ISupportInitialize).BeginInit()
        Me.mnuBarrel.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView2, ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView3, ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.DataGridView4, ISupportInitialize).BeginInit()
        Me.mnuGunSmith.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        CType(Me.DataGridView6, ISupportInitialize).BeginInit()
        Me.mnuDocsMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GunCollectionExtBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAccessoriesBindingSource, ISupportInitialize).BeginInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MaintanceDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.GunSmithDetailsBindingSource, ISupportInitialize).BeginInit()
        CType(Me.QryDocsAndLinksBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New Size(112, 19)
        Me.TabControl1.Location = New Point(0, 28)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New Size(1150, 467)
        Me.TabControl1.TabIndex = 113
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label59)
        Me.TabPage5.Controls.Add(Me.txtCaliber3)
        Me.TabPage5.Controls.Add(Me.dtpPurchased)
        Me.TabPage5.Controls.Add(Me.Label43)
        Me.TabPage5.Controls.Add(Me.pbStolen)
        Me.TabPage5.Controls.Add(Me.txtChoke)
        Me.TabPage5.Controls.Add(Me.Label53)
        Me.TabPage5.Controls.Add(Me.lblSold)
        Me.TabPage5.Controls.Add(Me.pbSold)
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Controls.Add(Me.txtImporter)
        Me.TabPage5.Controls.Add(Me.Label44)
        Me.TabPage5.Controls.Add(Me.Label42)
        Me.TabPage5.Controls.Add(Me.txtPetLoads)
        Me.TabPage5.Controls.Add(Me.txtCondition)
        Me.TabPage5.Controls.Add(Me.txtPurPrice)
        Me.TabPage5.Controls.Add(Me.txtPurchasedFrom)
        Me.TabPage5.Controls.Add(Me.txtStorage)
        Me.TabPage5.Controls.Add(Me.txtSights)
        Me.TabPage5.Controls.Add(Me.txtFeed)
        Me.TabPage5.Controls.Add(Me.txtAction)
        Me.TabPage5.Controls.Add(Me.txtProduced)
        Me.TabPage5.Controls.Add(Me.txtGripType)
        Me.TabPage5.Controls.Add(Me.txtCustCatID)
        Me.TabPage5.Controls.Add(Me.txtBarHei)
        Me.TabPage5.Controls.Add(Me.txtBarWid)
        Me.TabPage5.Controls.Add(Me.txtBarLen)
        Me.TabPage5.Controls.Add(Me.txtLength)
        Me.TabPage5.Controls.Add(Me.txtWeight)
        Me.TabPage5.Controls.Add(Me.txtNationality)
        Me.TabPage5.Controls.Add(Me.txtFinish)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.txtCal)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.txtType)
        Me.TabPage5.Controls.Add(Me.txtSerial)
        Me.TabPage5.Controls.Add(Me.txtModel)
        Me.TabPage5.Controls.Add(Me.txtManu)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.ImageIndex = 0
        Me.TabPage5.Location = New Point(4, 42)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New Size(1142, 421)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Standard Details"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New Point(14, 323)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New Size(58, 13)
        Me.Label59.TabIndex = 229
        Me.Label59.Text = "Caliber #3:"
        '
        'txtCaliber3
        '
        Me.txtCaliber3.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCaliber3.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCaliber3.Location = New Point(114, 320)
        Me.txtCaliber3.Name = "txtCaliber3"
        Me.txtCaliber3.ReadOnly = True
        Me.txtCaliber3.Size = New Size(156, 20)
        Me.txtCaliber3.TabIndex = 228
        '
        'dtpPurchased
        '
        Me.dtpPurchased.Checked = False
        Me.dtpPurchased.Enabled = False
        Me.dtpPurchased.Format = DateTimePickerFormat.[Short]
        Me.dtpPurchased.Location = New Point(114, 267)
        Me.dtpPurchased.Name = "dtpPurchased"
        Me.dtpPurchased.Size = New Size(154, 20)
        Me.dtpPurchased.TabIndex = 227
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New Point(14, 273)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New Size(81, 13)
        Me.Label43.TabIndex = 226
        Me.Label43.Text = "Purchase Date:"
        '
        'pbStolen
        '
        Me.pbStolen.BackgroundImageLayout = ImageLayout.Stretch
        Me.pbStolen.BorderStyle = BorderStyle.Fixed3D
        Me.pbStolen.Image = CType(resources.GetObject("pbStolen.Image"), Image)
        Me.pbStolen.Location = New Point(665, 24)
        Me.pbStolen.Name = "pbStolen"
        Me.pbStolen.Size = New Size(131, 70)
        Me.pbStolen.SizeMode = PictureBoxSizeMode.StretchImage
        Me.pbStolen.TabIndex = 201
        Me.pbStolen.TabStop = False
        Me.pbStolen.Visible = False
        '
        'txtChoke
        '
        Me.txtChoke.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtChoke.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtChoke.Location = New Point(457, 342)
        Me.txtChoke.Name = "txtChoke"
        Me.txtChoke.ReadOnly = True
        Me.txtChoke.Size = New Size(156, 20)
        Me.txtChoke.TabIndex = 200
        Me.txtChoke.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New Point(336, 345)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New Size(78, 13)
        Me.Label53.TabIndex = 199
        Me.Label53.Text = "Current Choke:"
        Me.Label53.Visible = False
        '
        'lblSold
        '
        Me.lblSold.Location = New Point(665, 105)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Size = New Size(131, 23)
        Me.lblSold.TabIndex = 198
        Me.lblSold.Text = "Sold On"
        Me.lblSold.TextAlign = ContentAlignment.MiddleCenter
        Me.lblSold.Visible = False
        '
        'pbSold
        '
        Me.pbSold.BackgroundImageLayout = ImageLayout.Stretch
        Me.pbSold.BorderStyle = BorderStyle.Fixed3D
        Me.pbSold.Image = CType(resources.GetObject("pbSold.Image"), Image)
        Me.pbSold.Location = New Point(665, 24)
        Me.pbSold.Name = "pbSold"
        Me.pbSold.Size = New Size(131, 73)
        Me.pbSold.SizeMode = PictureBoxSizeMode.StretchImage
        Me.pbSold.TabIndex = 197
        Me.pbSold.TabStop = False
        Me.pbSold.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Point(714, 278)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(100, 82)
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'txtImporter
        '
        Me.txtImporter.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtImporter.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtImporter.BackColor = SystemColors.Control
        Me.txtImporter.Location = New Point(114, 50)
        Me.txtImporter.Name = "txtImporter"
        Me.txtImporter.ReadOnly = True
        Me.txtImporter.Size = New Size(156, 20)
        Me.txtImporter.TabIndex = 175
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New Point(14, 53)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New Size(55, 13)
        Me.Label44.TabIndex = 176
        Me.Label44.Text = "Importer: *"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New Point(14, 297)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New Size(58, 13)
        Me.Label42.TabIndex = 172
        Me.Label42.Text = "Caliber #2:"
        '
        'txtPetLoads
        '
        Me.txtPetLoads.Location = New Point(114, 294)
        Me.txtPetLoads.Name = "txtPetLoads"
        Me.txtPetLoads.ReadOnly = True
        Me.txtPetLoads.Size = New Size(156, 20)
        Me.txtPetLoads.TabIndex = 171
        '
        'txtCondition
        '
        Me.txtCondition.Location = New Point(114, 181)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.ReadOnly = True
        Me.txtCondition.Size = New Size(156, 20)
        Me.txtCondition.TabIndex = 168
        '
        'txtPurPrice
        '
        Me.txtPurPrice.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurPrice.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurPrice.Location = New Point(114, 237)
        Me.txtPurPrice.Name = "txtPurPrice"
        Me.txtPurPrice.ReadOnly = True
        Me.txtPurPrice.Size = New Size(156, 20)
        Me.txtPurPrice.TabIndex = 163
        '
        'txtPurchasedFrom
        '
        Me.txtPurchasedFrom.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurchasedFrom.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurchasedFrom.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Underline, GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasedFrom.ForeColor = Color.Blue
        Me.txtPurchasedFrom.Location = New Point(114, 211)
        Me.txtPurchasedFrom.Name = "txtPurchasedFrom"
        Me.txtPurchasedFrom.ReadOnly = True
        Me.txtPurchasedFrom.Size = New Size(156, 20)
        Me.txtPurchasedFrom.TabIndex = 162
        '
        'txtStorage
        '
        Me.txtStorage.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtStorage.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtStorage.Location = New Point(457, 181)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.ReadOnly = True
        Me.txtStorage.Size = New Size(156, 20)
        Me.txtStorage.TabIndex = 161
        '
        'txtSights
        '
        Me.txtSights.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSights.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSights.Location = New Point(457, 155)
        Me.txtSights.Name = "txtSights"
        Me.txtSights.ReadOnly = True
        Me.txtSights.Size = New Size(156, 20)
        Me.txtSights.TabIndex = 160
        '
        'txtFeed
        '
        Me.txtFeed.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFeed.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFeed.Location = New Point(457, 129)
        Me.txtFeed.Name = "txtFeed"
        Me.txtFeed.ReadOnly = True
        Me.txtFeed.Size = New Size(156, 20)
        Me.txtFeed.TabIndex = 159
        '
        'txtAction
        '
        Me.txtAction.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAction.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAction.Location = New Point(457, 103)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.ReadOnly = True
        Me.txtAction.Size = New Size(156, 20)
        Me.txtAction.TabIndex = 158
        '
        'txtProduced
        '
        Me.txtProduced.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtProduced.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtProduced.Location = New Point(457, 76)
        Me.txtProduced.Name = "txtProduced"
        Me.txtProduced.ReadOnly = True
        Me.txtProduced.Size = New Size(156, 20)
        Me.txtProduced.TabIndex = 157
        '
        'txtGripType
        '
        Me.txtGripType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtGripType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtGripType.Location = New Point(457, 50)
        Me.txtGripType.Name = "txtGripType"
        Me.txtGripType.ReadOnly = True
        Me.txtGripType.Size = New Size(156, 20)
        Me.txtGripType.TabIndex = 156
        '
        'txtCustCatID
        '
        Me.txtCustCatID.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCustCatID.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCustCatID.Location = New Point(457, 24)
        Me.txtCustCatID.Name = "txtCustCatID"
        Me.txtCustCatID.ReadOnly = True
        Me.txtCustCatID.Size = New Size(156, 20)
        Me.txtCustCatID.TabIndex = 155
        '
        'txtBarHei
        '
        Me.txtBarHei.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarHei.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarHei.Location = New Point(762, 393)
        Me.txtBarHei.Name = "txtBarHei"
        Me.txtBarHei.ReadOnly = True
        Me.txtBarHei.Size = New Size(156, 20)
        Me.txtBarHei.TabIndex = 139
        Me.txtBarHei.Visible = False
        '
        'txtBarWid
        '
        Me.txtBarWid.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarWid.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarWid.Location = New Point(762, 367)
        Me.txtBarWid.Name = "txtBarWid"
        Me.txtBarWid.ReadOnly = True
        Me.txtBarWid.Size = New Size(156, 20)
        Me.txtBarWid.TabIndex = 137
        Me.txtBarWid.Visible = False
        '
        'txtBarLen
        '
        Me.txtBarLen.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarLen.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarLen.Location = New Point(457, 316)
        Me.txtBarLen.Name = "txtBarLen"
        Me.txtBarLen.ReadOnly = True
        Me.txtBarLen.Size = New Size(156, 20)
        Me.txtBarLen.TabIndex = 135
        '
        'txtLength
        '
        Me.txtLength.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtLength.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtLength.Location = New Point(457, 290)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.Size = New Size(156, 20)
        Me.txtLength.TabIndex = 134
        '
        'txtWeight
        '
        Me.txtWeight.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtWeight.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtWeight.Location = New Point(457, 260)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New Size(156, 20)
        Me.txtWeight.TabIndex = 133
        '
        'txtNationality
        '
        Me.txtNationality.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtNationality.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtNationality.Location = New Point(457, 234)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.ReadOnly = True
        Me.txtNationality.Size = New Size(156, 20)
        Me.txtNationality.TabIndex = 130
        '
        'txtFinish
        '
        Me.txtFinish.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFinish.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFinish.Location = New Point(457, 208)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.ReadOnly = True
        Me.txtFinish.Size = New Size(156, 20)
        Me.txtFinish.TabIndex = 126
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New Point(14, 214)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New Size(87, 13)
        Me.Label28.TabIndex = 154
        Me.Label28.Text = "Purchased From:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New Point(336, 184)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New Size(91, 13)
        Me.Label27.TabIndex = 153
        Me.Label27.Text = "Storage Location:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New Point(14, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New Size(88, 13)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "Purchased Price:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New Point(336, 158)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New Size(39, 13)
        Me.Label20.TabIndex = 147
        Me.Label20.Text = "Sights:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New Point(336, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New Size(117, 13)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "Feed System/Capacity:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New Point(336, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New Size(40, 13)
        Me.Label18.TabIndex = 145
        Me.Label18.Text = "Action:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New Point(662, 396)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New Size(71, 13)
        Me.Label17.TabIndex = 144
        Me.Label17.Text = "Barrel Height:"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New Point(662, 370)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New Size(68, 13)
        Me.Label16.TabIndex = 143
        Me.Label16.Text = "Barrel Width:"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New Point(336, 319)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New Size(73, 13)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Barrel Length:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New Point(336, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New Size(79, 13)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "Overall Length:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New Point(336, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New Size(44, 13)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "Weight:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New Point(336, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(102, 13)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "Manufactured Date:"
        '
        'txtCal
        '
        Me.txtCal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCal.Location = New Point(114, 155)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.ReadOnly = True
        Me.txtCal.Size = New Size(156, 20)
        Me.txtCal.TabIndex = 123
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(336, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(89, 13)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Stock/Grip Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(336, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(37, 13)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Finish:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New Point(14, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(54, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Condition:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(336, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(104, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Custom Catalog No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(336, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(77, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Place of origin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(14, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(98, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Caliber Or Gauge: *"
        '
        'txtType
        '
        Me.txtType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtType.Location = New Point(114, 129)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New Size(156, 20)
        Me.txtType.TabIndex = 122
        '
        'txtSerial
        '
        Me.txtSerial.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSerial.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSerial.Location = New Point(114, 103)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New Size(156, 20)
        Me.txtSerial.TabIndex = 121
        '
        'txtModel
        '
        Me.txtModel.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtModel.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtModel.Location = New Point(114, 77)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New Size(156, 20)
        Me.txtModel.TabIndex = 120
        '
        'txtManu
        '
        Me.txtManu.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtManu.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtManu.Location = New Point(114, 25)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.ReadOnly = True
        Me.txtManu.Size = New Size(156, 20)
        Me.txtManu.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(14, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(41, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Type: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(14, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(83, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Serial Number: *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(14, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(46, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Model: *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(80, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Manufacturer: *"
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.dtpDateofCR)
        Me.TabPage11.Controls.Add(Me.txtClassIIIOwner)
        Me.TabPage11.Controls.Add(Me.Label61)
        Me.TabPage11.Controls.Add(Me.chkClassIII)
        Me.TabPage11.Controls.Add(Me.Label60)
        Me.TabPage11.Controls.Add(Me.txtTriggerPull)
        Me.TabPage11.Controls.Add(Me.txtTwistOfRate)
        Me.TabPage11.Controls.Add(Me.Label57)
        Me.TabPage11.Controls.Add(Me.Label58)
        Me.TabPage11.Controls.Add(Me.txtInsVal)
        Me.TabPage11.Controls.Add(Me.txtAppBy)
        Me.TabPage11.Controls.Add(Me.dtpAppDate)
        Me.TabPage11.Controls.Add(Me.txtAppValue)
        Me.TabPage11.Controls.Add(Me.Label26)
        Me.TabPage11.Controls.Add(Me.Label25)
        Me.TabPage11.Controls.Add(Me.Label24)
        Me.TabPage11.Controls.Add(Me.Label23)
        Me.TabPage11.Controls.Add(Me.Label56)
        Me.TabPage11.Controls.Add(Me.txtClassification)
        Me.TabPage11.Controls.Add(Me.Label55)
        Me.TabPage11.Controls.Add(Me.chkBoundBook)
        Me.TabPage11.Controls.Add(Me.Label54)
        Me.TabPage11.Controls.Add(Me.chkBoxCR)
        Me.TabPage11.Controls.Add(Me.Label12)
        Me.TabPage11.Controls.Add(Me.txtPOI)
        Me.TabPage11.Controls.Add(Me.dtpReManDT)
        Me.TabPage11.Controls.Add(Me.Label48)
        Me.TabPage11.Controls.Add(Me.Label49)
        Me.TabPage11.Location = New Point(4, 42)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New Size(1142, 421)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Collector Details"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'dtpDateofCR
        '
        Me.dtpDateofCR.Checked = False
        Me.dtpDateofCR.Enabled = False
        Me.dtpDateofCR.Format = DateTimePickerFormat.[Short]
        Me.dtpDateofCR.Location = New Point(442, 112)
        Me.dtpDateofCR.Name = "dtpDateofCR"
        Me.dtpDateofCR.Size = New Size(154, 20)
        Me.dtpDateofCR.TabIndex = 232
        '
        'txtClassIIIOwner
        '
        Me.txtClassIIIOwner.Location = New Point(109, 217)
        Me.txtClassIIIOwner.Name = "txtClassIIIOwner"
        Me.txtClassIIIOwner.ReadOnly = True
        Me.txtClassIIIOwner.Size = New Size(156, 20)
        Me.txtClassIIIOwner.TabIndex = 231
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New Point(9, 220)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New Size(41, 13)
        Me.Label61.TabIndex = 230
        Me.Label61.Text = "Owner:"
        '
        'chkClassIII
        '
        Me.chkClassIII.AutoSize = True
        Me.chkClassIII.Enabled = False
        Me.chkClassIII.Location = New Point(108, 196)
        Me.chkClassIII.Name = "chkClassIII"
        Me.chkClassIII.Size = New Size(44, 17)
        Me.chkClassIII.TabIndex = 229
        Me.chkClassIII.Text = "Yes"
        Me.chkClassIII.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New Point(8, 197)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New Size(73, 13)
        Me.Label60.TabIndex = 228
        Me.Label60.Text = "Class III Item?"
        '
        'txtTriggerPull
        '
        Me.txtTriggerPull.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTriggerPull.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTriggerPull.Location = New Point(109, 167)
        Me.txtTriggerPull.Name = "txtTriggerPull"
        Me.txtTriggerPull.ReadOnly = True
        Me.txtTriggerPull.Size = New Size(156, 20)
        Me.txtTriggerPull.TabIndex = 227
        '
        'txtTwistOfRate
        '
        Me.txtTwistOfRate.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTwistOfRate.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTwistOfRate.Location = New Point(109, 138)
        Me.txtTwistOfRate.Name = "txtTwistOfRate"
        Me.txtTwistOfRate.ReadOnly = True
        Me.txtTwistOfRate.Size = New Size(156, 20)
        Me.txtTwistOfRate.TabIndex = 226
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New Point(9, 170)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New Size(97, 13)
        Me.Label57.TabIndex = 225
        Me.Label57.Text = "Trigger Pull  ( lbs. ):"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New Point(8, 141)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New Size(73, 13)
        Me.Label58.TabIndex = 224
        Me.Label58.Text = "Twist of Rate:"
        '
        'txtInsVal
        '
        Me.txtInsVal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtInsVal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtInsVal.Location = New Point(108, 112)
        Me.txtInsVal.Name = "txtInsVal"
        Me.txtInsVal.ReadOnly = True
        Me.txtInsVal.Size = New Size(156, 20)
        Me.txtInsVal.TabIndex = 223
        '
        'txtAppBy
        '
        Me.txtAppBy.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAppBy.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAppBy.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Underline, GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppBy.Location = New Point(108, 86)
        Me.txtAppBy.Name = "txtAppBy"
        Me.txtAppBy.ReadOnly = True
        Me.txtAppBy.Size = New Size(156, 20)
        Me.txtAppBy.TabIndex = 222
        '
        'dtpAppDate
        '
        Me.dtpAppDate.Checked = False
        Me.dtpAppDate.Enabled = False
        Me.dtpAppDate.Format = DateTimePickerFormat.[Short]
        Me.dtpAppDate.Location = New Point(108, 59)
        Me.dtpAppDate.Name = "dtpAppDate"
        Me.dtpAppDate.Size = New Size(154, 20)
        Me.dtpAppDate.TabIndex = 221
        '
        'txtAppValue
        '
        Me.txtAppValue.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAppValue.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAppValue.Location = New Point(108, 30)
        Me.txtAppValue.Name = "txtAppValue"
        Me.txtAppValue.ReadOnly = True
        Me.txtAppValue.Size = New Size(156, 20)
        Me.txtAppValue.TabIndex = 220
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New Point(8, 115)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New Size(75, 13)
        Me.Label26.TabIndex = 219
        Me.Label26.Text = "Insured Value:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New Point(8, 89)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New Size(72, 13)
        Me.Label25.TabIndex = 218
        Me.Label25.Text = "Appraised By:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New Point(8, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New Size(79, 13)
        Me.Label24.TabIndex = 217
        Me.Label24.Text = "Appraisal Date:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New Point(8, 33)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New Size(87, 13)
        Me.Label23.TabIndex = 216
        Me.Label23.Text = "Appraised Value:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New Point(321, 115)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New Size(75, 13)
        Me.Label56.TabIndex = 215
        Me.Label56.Text = "Date of C && R:"
        '
        'txtClassification
        '
        Me.txtClassification.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtClassification.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtClassification.Location = New Point(442, 86)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.ReadOnly = True
        Me.txtClassification.Size = New Size(156, 20)
        Me.txtClassification.TabIndex = 205
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New Point(321, 89)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New Size(71, 13)
        Me.Label55.TabIndex = 204
        Me.Label55.Text = "Classification:"
        '
        'chkBoundBook
        '
        Me.chkBoundBook.AutoSize = True
        Me.chkBoundBook.Checked = True
        Me.chkBoundBook.CheckState = CheckState.Checked
        Me.chkBoundBook.Enabled = False
        Me.chkBoundBook.Location = New Point(442, 62)
        Me.chkBoundBook.Name = "chkBoundBook"
        Me.chkBoundBook.Size = New Size(44, 17)
        Me.chkBoundBook.TabIndex = 203
        Me.chkBoundBook.Text = "Yes"
        Me.chkBoundBook.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New Point(321, 63)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New Size(100, 13)
        Me.Label54.TabIndex = 202
        Me.Label54.Text = "Add to Bound Book"
        '
        'chkBoxCR
        '
        Me.chkBoxCR.AutoSize = True
        Me.chkBoxCR.Enabled = False
        Me.chkBoxCR.Location = New Point(442, 32)
        Me.chkBoxCR.Name = "chkBoxCR"
        Me.chkBoxCR.Size = New Size(44, 17)
        Me.chkBoxCR.TabIndex = 201
        Me.chkBoxCR.Text = "Yes"
        Me.chkBoxCR.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New Point(321, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(89, 13)
        Me.Label12.TabIndex = 200
        Me.Label12.Text = "Is C && R Qualified"
        '
        'txtPOI
        '
        Me.txtPOI.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPOI.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPOI.Location = New Point(442, 167)
        Me.txtPOI.Name = "txtPOI"
        Me.txtPOI.ReadOnly = True
        Me.txtPOI.Size = New Size(156, 20)
        Me.txtPOI.TabIndex = 199
        '
        'dtpReManDT
        '
        Me.dtpReManDT.Checked = False
        Me.dtpReManDT.Enabled = False
        Me.dtpReManDT.Format = DateTimePickerFormat.[Short]
        Me.dtpReManDT.Location = New Point(442, 138)
        Me.dtpReManDT.Name = "dtpReManDT"
        Me.dtpReManDT.Size = New Size(156, 20)
        Me.dtpReManDT.TabIndex = 198
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New Point(321, 170)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New Size(83, 13)
        Me.Label48.TabIndex = 197
        Me.Label48.Text = "Place Of Import:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New Point(321, 141)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New Size(109, 13)
        Me.Label49.TabIndex = 196
        Me.Label49.Text = "Remanufacture Date:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtConCom)
        Me.TabPage1.ImageIndex = 1
        Me.TabPage1.Location = New Point(4, 42)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New Padding(3)
        Me.TabPage1.Size = New Size(1142, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Condition Comments"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtConCom
        '
        Me.txtConCom.Location = New Point(0, 6)
        Me.txtConCom.Multiline = True
        Me.txtConCom.Name = "txtConCom"
        Me.txtConCom.ReadOnly = True
        Me.txtConCom.ScrollBars = ScrollBars.Vertical
        Me.txtConCom.Size = New Size(601, 401)
        Me.txtConCom.TabIndex = 62
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAddNotes)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New Point(4, 42)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.TabPage2.Size = New Size(1142, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Additional Notes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAddNotes
        '
        Me.txtAddNotes.Location = New Point(1, 6)
        Me.txtAddNotes.Multiline = True
        Me.txtAddNotes.Name = "txtAddNotes"
        Me.txtAddNotes.ReadOnly = True
        Me.txtAddNotes.ScrollBars = ScrollBars.Vertical
        Me.txtAddNotes.Size = New Size(600, 401)
        Me.txtAddNotes.TabIndex = 63
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnGalleryReport)
        Me.TabPage3.Controls.Add(Me.btnRefreshPics)
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.btnAdd)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New Point(4, 42)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New Padding(3)
        Me.TabPage3.Size = New Size(1142, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Picture(s)"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnGalleryReport
        '
        Me.btnGalleryReport.Location = New Point(340, 6)
        Me.btnGalleryReport.Name = "btnGalleryReport"
        Me.btnGalleryReport.Size = New Size(124, 21)
        Me.btnGalleryReport.TabIndex = 3
        Me.btnGalleryReport.Text = "View Gallery Report"
        Me.btnGalleryReport.UseVisualStyleBackColor = True
        '
        'btnRefreshPics
        '
        Me.btnRefreshPics.Location = New Point(182, 6)
        Me.btnRefreshPics.Name = "btnRefreshPics"
        Me.btnRefreshPics.Size = New Size(76, 21)
        Me.btnRefreshPics.TabIndex = 2
        Me.btnRefreshPics.Text = "Refresh"
        Me.btnRefreshPics.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.ContextMenuStrip = Me.mnuPictre
        Me.ListView1.Location = New Point(7, 36)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New Size(592, 362)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'mnuPictre
        '
        Me.mnuPictre.Items.AddRange(New ToolStripItem() {Me.mnuPicItem_Show, Me.EditNotesToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuPicItem_Delete})
        Me.mnuPictre.Name = "mnuPictre"
        Me.mnuPictre.ShowItemToolTips = False
        Me.mnuPictre.Size = New Size(129, 76)
        '
        'mnuPicItem_Show
        '
        Me.mnuPicItem_Show.Image = CType(resources.GetObject("mnuPicItem_Show.Image"), Image)
        Me.mnuPicItem_Show.Name = "mnuPicItem_Show"
        Me.mnuPicItem_Show.Size = New Size(128, 22)
        Me.mnuPicItem_Show.Text = "&Show"
        '
        'EditNotesToolStripMenuItem
        '
        Me.EditNotesToolStripMenuItem.Image = CType(resources.GetObject("EditNotesToolStripMenuItem.Image"), Image)
        Me.EditNotesToolStripMenuItem.Name = "EditNotesToolStripMenuItem"
        Me.EditNotesToolStripMenuItem.Size = New Size(128, 22)
        Me.EditNotesToolStripMenuItem.Text = "Edit Notes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(125, 6)
        '
        'mnuPicItem_Delete
        '
        Me.mnuPicItem_Delete.Image = CType(resources.GetObject("mnuPicItem_Delete.Image"), Image)
        Me.mnuPicItem_Delete.Name = "mnuPicItem_Delete"
        Me.mnuPicItem_Delete.Size = New Size(128, 22)
        Me.mnuPicItem_Delete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New Point(8, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New Size(83, 21)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.DataGridView5)
        Me.TabPage10.ImageIndex = 9
        Me.TabPage10.Location = New Point(4, 42)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New Padding(3)
        Me.TabPage10.Size = New Size(1142, 421)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Barrels/Conversion Kits"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.[True]
        Me.DataGridView5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ModelNameDataGridViewTextBoxColumn, Me.CaliberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.BarrelLengthDataGridViewTextBoxColumn, Me.PetLoadsDataGridViewTextBoxColumn, Me.PurchasedPriceDataGridViewTextBoxColumn})
        Me.DataGridView5.ContextMenuStrip = Me.mnuBarrel
        Me.DataGridView5.DataSource = Me.GunCollectionExtBindingSource
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
        Me.DataGridView5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView5.Dock = DockStyle.Fill
        Me.DataGridView5.Location = New Point(3, 3)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New Size(1136, 415)
        Me.DataGridView5.TabIndex = 0
        '
        'mnuBarrel
        '
        Me.mnuBarrel.Items.AddRange(New ToolStripItem() {Me.SetAsDefaultToolStripMenuItem, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem, Me.MoveToolStripMenuItem})
        Me.mnuBarrel.Name = "mnuBarrel"
        Me.mnuBarrel.Size = New Size(148, 92)
        '
        'SetAsDefaultToolStripMenuItem
        '
        Me.SetAsDefaultToolStripMenuItem.Name = "SetAsDefaultToolStripMenuItem"
        Me.SetAsDefaultToolStripMenuItem.Size = New Size(147, 22)
        Me.SetAsDefaultToolStripMenuItem.Text = "&Set As Default"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New Size(147, 22)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New Size(147, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New Size(147, 22)
        Me.MoveToolStripMenuItem.Text = "&Move"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblTAV)
        Me.TabPage4.Controls.Add(Me.Label52)
        Me.TabPage4.Controls.Add(Me.lblTPV)
        Me.TabPage4.Controls.Add(Me.Label51)
        Me.TabPage4.Controls.Add(Me.btnVwAccessReport)
        Me.TabPage4.Controls.Add(Me.btnRefresh)
        Me.TabPage4.Controls.Add(Me.btnAddAccess)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.ImageIndex = 5
        Me.TabPage4.Location = New Point(4, 42)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New Padding(3)
        Me.TabPage4.Size = New Size(1142, 421)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Accessories"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblTAV
        '
        Me.lblTAV.AutoSize = True
        Me.lblTAV.Location = New Point(390, 418)
        Me.lblTAV.Name = "lblTAV"
        Me.lblTAV.Size = New Size(0, 13)
        Me.lblTAV.TabIndex = 7
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New Point(247, 419)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New Size(136, 13)
        Me.Label52.TabIndex = 6
        Me.Label52.Text = "Total Appraised Value:"
        '
        'lblTPV
        '
        Me.lblTPV.AutoSize = True
        Me.lblTPV.Location = New Point(147, 420)
        Me.lblTPV.Name = "lblTPV"
        Me.lblTPV.Size = New Size(0, 13)
        Me.lblTPV.TabIndex = 5
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New Point(8, 420)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New Size(133, 13)
        Me.Label51.TabIndex = 4
        Me.Label51.Text = "Total Purchase Value:"
        '
        'btnVwAccessReport
        '
        Me.btnVwAccessReport.Location = New Point(394, 8)
        Me.btnVwAccessReport.Name = "btnVwAccessReport"
        Me.btnVwAccessReport.Size = New Size(75, 23)
        Me.btnVwAccessReport.TabIndex = 3
        Me.btnVwAccessReport.Text = "View Report"
        Me.btnVwAccessReport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New Point(224, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAddAccess
        '
        Me.btnAddAccess.Location = New Point(8, 8)
        Me.btnAddAccess.Name = "btnAddAccess"
        Me.btnAddAccess.Size = New Size(113, 23)
        Me.btnAddAccess.TabIndex = 1
        Me.btnAddAccess.Text = "Add Accessory"
        Me.btnAddAccess.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ManufacturerDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn, Me.UseDataGridViewTextBoxColumn, Me.PurValueDataGridViewTextBoxColumn, Me.AppValue, Me.NotesDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.GunCollectionAccessoriesBindingSource
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New Point(8, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New Size(775, 370)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 2
        '
        'AppValue
        '
        Me.AppValue.DataPropertyName = "AppValue"
        Me.AppValue.HeaderText = "Appraised Value"
        Me.AppValue.Name = "AppValue"
        Me.AppValue.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Me.EditToolStripMenuItem, Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(103, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New Size(102, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.btnAmmoReportByCal)
        Me.TabPage6.Controls.Add(Me.lblAmmoTotal)
        Me.TabPage6.Controls.Add(Me.Label45)
        Me.TabPage6.Controls.Add(Me.Button1)
        Me.TabPage6.Controls.Add(Me.btnAddAmmo)
        Me.TabPage6.Controls.Add(Me.DataGridView2)
        Me.TabPage6.ImageIndex = 3
        Me.TabPage6.Location = New Point(4, 42)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New Size(1142, 421)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Ammunition"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnAmmoReportByCal
        '
        Me.btnAmmoReportByCal.Location = New Point(429, 8)
        Me.btnAmmoReportByCal.Name = "btnAmmoReportByCal"
        Me.btnAmmoReportByCal.Size = New Size(112, 23)
        Me.btnAmmoReportByCal.TabIndex = 6
        Me.btnAmmoReportByCal.Text = "Print Ammo List"
        Me.btnAmmoReportByCal.UseVisualStyleBackColor = True
        '
        'lblAmmoTotal
        '
        Me.lblAmmoTotal.AutoSize = True
        Me.lblAmmoTotal.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmoTotal.Location = New Point(54, 387)
        Me.lblAmmoTotal.Name = "lblAmmoTotal"
        Me.lblAmmoTotal.Size = New Size(0, 13)
        Me.lblAmmoTotal.TabIndex = 5
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New Point(8, 387)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New Size(40, 13)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.Location = New Point(228, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddAmmo
        '
        Me.btnAddAmmo.Location = New Point(8, 9)
        Me.btnAddAmmo.Name = "btnAddAmmo"
        Me.btnAddAmmo.Size = New Size(75, 23)
        Me.btnAddAmmo.TabIndex = 1
        Me.btnAddAmmo.Text = "Add Ammunition"
        Me.btnAddAmmo.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New DataGridViewColumn() {Me.Qty1, Me.ManufacturerDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn, Me.CalDataGridViewTextBoxColumn, Me.GrainDataGridViewTextBoxColumn, Me.JacketDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.GunCollectionAmmoBindingSource
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter
        Me.DataGridView2.Location = New Point(11, 38)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New Size(593, 346)
        Me.DataGridView2.TabIndex = 0
        '
        'Qty1
        '
        Me.Qty1.DataPropertyName = "Qty1"
        Me.Qty1.HeaderText = "Qty."
        Me.Qty1.Name = "Qty1"
        Me.Qty1.ReadOnly = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.lblTotalFirearm)
        Me.TabPage7.Controls.Add(Me.Label50)
        Me.TabPage7.Controls.Add(Me.lblAvgRndsFired)
        Me.TabPage7.Controls.Add(Me.Label47)
        Me.TabPage7.Controls.Add(Me.lblTotalRndsFired)
        Me.TabPage7.Controls.Add(Me.Label46)
        Me.TabPage7.Controls.Add(Me.btnPrintPreviewMaintanceReport)
        Me.TabPage7.Controls.Add(Me.Button2)
        Me.TabPage7.Controls.Add(Me.DataGridView3)
        Me.TabPage7.Controls.Add(Me.btnAddMain)
        Me.TabPage7.ImageIndex = 6
        Me.TabPage7.Location = New Point(4, 42)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New Padding(3)
        Me.TabPage7.Size = New Size(1142, 421)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Maintenance"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'lblTotalFirearm
        '
        Me.lblTotalFirearm.AutoSize = True
        Me.lblTotalFirearm.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFirearm.Location = New Point(612, 389)
        Me.lblTotalFirearm.Name = "lblTotalFirearm"
        Me.lblTotalFirearm.Size = New Size(0, 13)
        Me.lblTotalFirearm.TabIndex = 10
        Me.lblTotalFirearm.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New Point(468, 389)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New Size(147, 13)
        Me.Label50.TabIndex = 9
        Me.Label50.Text = "Total Rounds of Firearm:"
        Me.Label50.Visible = False
        '
        'lblAvgRndsFired
        '
        Me.lblAvgRndsFired.AutoSize = True
        Me.lblAvgRndsFired.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRndsFired.Location = New Point(384, 389)
        Me.lblAvgRndsFired.Name = "lblAvgRndsFired"
        Me.lblAvgRndsFired.Size = New Size(0, 13)
        Me.lblAvgRndsFired.TabIndex = 8
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New Point(240, 390)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New Size(137, 13)
        Me.Label47.TabIndex = 7
        Me.Label47.Text = "Average Rounds Fired:"
        '
        'lblTotalRndsFired
        '
        Me.lblTotalRndsFired.AutoSize = True
        Me.lblTotalRndsFired.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRndsFired.Location = New Point(132, 391)
        Me.lblTotalRndsFired.Name = "lblTotalRndsFired"
        Me.lblTotalRndsFired.Size = New Size(0, 13)
        Me.lblTotalRndsFired.TabIndex = 6
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New Point(6, 391)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New Size(119, 13)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = "Total Rounds Fired:"
        '
        'btnPrintPreviewMaintanceReport
        '
        Me.btnPrintPreviewMaintanceReport.Location = New Point(169, 10)
        Me.btnPrintPreviewMaintanceReport.Name = "btnPrintPreviewMaintanceReport"
        Me.btnPrintPreviewMaintanceReport.Size = New Size(129, 23)
        Me.btnPrintPreviewMaintanceReport.TabIndex = 4
        Me.btnPrintPreviewMaintanceReport.Text = "Print Preview Report"
        Me.btnPrintPreviewMaintanceReport.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New Point(384, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New DataGridViewColumn() {Me.MaintID, Me.NameDataGridViewTextBoxColumn1, Me.OpDateDataGridViewTextBoxColumn, Me.OpDueDateDataGridViewTextBoxColumn, Me.RndFiredDataGridViewTextBoxColumn, Me.au, Me.NotesDataGridViewTextBoxColumn1})
        Me.DataGridView3.ContextMenuStrip = Me.mnuMain
        Me.DataGridView3.DataSource = Me.MaintanceDetailsBindingSource
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView3.Location = New Point(6, 38)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New Size(629, 346)
        Me.DataGridView3.TabIndex = 1
        '
        'MaintID
        '
        Me.MaintID.DataPropertyName = "id"
        Me.MaintID.FillWeight = 5.0!
        Me.MaintID.HeaderText = "MaintID"
        Me.MaintID.Name = "MaintID"
        Me.MaintID.ReadOnly = True
        Me.MaintID.Visible = False
        Me.MaintID.Width = 5
        '
        'au
        '
        Me.au.DataPropertyName = "au"
        Me.au.HeaderText = "Ammo Used"
        Me.au.Name = "au"
        Me.au.ReadOnly = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New ToolStripItem() {Me.DeleteToolStripMenuItem1, Me.EditToolStripMenuItem2})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New Size(108, 48)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Image = CType(resources.GetObject("DeleteToolStripMenuItem1.Image"), Image)
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "&Delete"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Image = CType(resources.GetObject("EditToolStripMenuItem2.Image"), Image)
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New Size(107, 22)
        Me.EditToolStripMenuItem2.Text = "&Edit"
        '
        'btnAddMain
        '
        Me.btnAddMain.Location = New Point(6, 10)
        Me.btnAddMain.Name = "btnAddMain"
        Me.btnAddMain.Size = New Size(81, 23)
        Me.btnAddMain.TabIndex = 0
        Me.btnAddMain.Text = "Add Maintance"
        Me.btnAddMain.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnRefreshGS)
        Me.TabPage8.Controls.Add(Me.btnGSLog)
        Me.TabPage8.Controls.Add(Me.DataGridView4)
        Me.TabPage8.Controls.Add(Me.btnGSReport)
        Me.TabPage8.ImageIndex = 7
        Me.TabPage8.Location = New Point(4, 42)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New Padding(3)
        Me.TabPage8.Size = New Size(1142, 421)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Gun Smith"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnRefreshGS
        '
        Me.btnRefreshGS.Location = New Point(420, 6)
        Me.btnRefreshGS.Name = "btnRefreshGS"
        Me.btnRefreshGS.Size = New Size(75, 23)
        Me.btnRefreshGS.TabIndex = 3
        Me.btnRefreshGS.Text = "Refresh"
        Me.btnRefreshGS.UseVisualStyleBackColor = True
        '
        'btnGSLog
        '
        Me.btnGSLog.Location = New Point(8, 6)
        Me.btnGSLog.Name = "btnGSLog"
        Me.btnGSLog.Size = New Size(137, 23)
        Me.btnGSLog.TabIndex = 0
        Me.btnGSLog.Text = "Add to Gun Smith Log"
        Me.btnGSLog.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New DataGridViewColumn() {Me.ID, Me.GsmithDataGridViewTextBoxColumn, Me.SdateDataGridViewTextBoxColumn, Me.RdateDataGridViewTextBoxColumn, Me.OdDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn2})
        Me.DataGridView4.ContextMenuStrip = Me.mnuGunSmith
        Me.DataGridView4.DataSource = Me.GunSmithDetailsBindingSource
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Window
        DataGridViewCellStyle10.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.[False]
        Me.DataGridView4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView4.Location = New Point(11, 35)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New Size(703, 366)
        Me.DataGridView4.TabIndex = 2
        '
        'ID
        '
        Me.ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.ID.DataPropertyName = "ID"
        Me.ID.FillWeight = 2.0!
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 2
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        Me.ID.Width = 2
        '
        'mnuGunSmith
        '
        Me.mnuGunSmith.Items.AddRange(New ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnuGunSmith.Name = "mnuGunSmith"
        Me.mnuGunSmith.Size = New Size(133, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New Size(132, 22)
        Me.ToolStripMenuItem1.Text = "Edit Details"
        '
        'btnGSReport
        '
        Me.btnGSReport.Location = New Point(228, 6)
        Me.btnGSReport.Name = "btnGSReport"
        Me.btnGSReport.Size = New Size(122, 23)
        Me.btnGSReport.TabIndex = 1
        Me.btnGSReport.Text = "Print Preview Report"
        Me.btnGSReport.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btnPrintSale)
        Me.TabPage9.Controls.Add(Me.btnStolen)
        Me.TabPage9.Controls.Add(Me.btnUnDoSale)
        Me.TabPage9.Controls.Add(Me.GroupBox1)
        Me.TabPage9.Controls.Add(Me.btnSold)
        Me.TabPage9.Controls.Add(Me.btnFlyer)
        Me.TabPage9.ImageIndex = 8
        Me.TabPage9.Location = New Point(4, 42)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New Padding(3)
        Me.TabPage9.Size = New Size(1142, 421)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Sale/Disposition"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btnPrintSale
        '
        Me.btnPrintSale.Location = New Point(133, 302)
        Me.btnPrintSale.Name = "btnPrintSale"
        Me.btnPrintSale.Size = New Size(122, 23)
        Me.btnPrintSale.TabIndex = 5
        Me.btnPrintSale.Text = "Print Simple Invoice"
        Me.btnPrintSale.UseVisualStyleBackColor = True
        '
        'btnStolen
        '
        Me.btnStolen.Location = New Point(319, 6)
        Me.btnStolen.Name = "btnStolen"
        Me.btnStolen.Size = New Size(111, 24)
        Me.btnStolen.TabIndex = 4
        Me.btnStolen.Text = "Mark Item as Stolen"
        Me.btnStolen.UseVisualStyleBackColor = True
        '
        'btnUnDoSale
        '
        Me.btnUnDoSale.Location = New Point(9, 302)
        Me.btnUnDoSale.Name = "btnUnDoSale"
        Me.btnUnDoSale.Size = New Size(104, 23)
        Me.btnUnDoSale.TabIndex = 3
        Me.btnUnDoSale.Text = "Undo Disposition"
        Me.btnUnDoSale.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtRes)
        Me.GroupBox1.Controls.Add(Me.txtDOB)
        Me.GroupBox1.Controls.Add(Me.txtDLic)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.txteMail)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtAddress1)
        Me.GroupBox1.Controls.Add(Me.txtAddress2)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtWebSite)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtLic)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Location = New Point(8, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(657, 251)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buyer Information"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New Point(309, 183)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New Size(102, 13)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Residency/Alien ID:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New Point(308, 158)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New Size(69, 13)
        Me.Label29.TabIndex = 114
        Me.Label29.Text = "Date of Birth:"
        '
        'txtRes
        '
        Me.txtRes.Location = New Point(426, 180)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New Size(171, 20)
        Me.txtRes.TabIndex = 113
        '
        'txtDOB
        '
        Me.txtDOB.Location = New Point(426, 155)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New Size(171, 20)
        Me.txtDOB.TabIndex = 112
        '
        'txtDLic
        '
        Me.txtDLic.Location = New Point(426, 128)
        Me.txtDLic.Name = "txtDLic"
        Me.txtDLic.ReadOnly = True
        Me.txtDLic.Size = New Size(171, 20)
        Me.txtDLic.TabIndex = 111
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New Point(308, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New Size(114, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Drivers License/Other:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New Point(16, 158)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New Size(53, 13)
        Me.Label31.TabIndex = 109
        Me.Label31.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New Point(85, 154)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New Size(171, 20)
        Me.txtZip.TabIndex = 108
        '
        'txteMail
        '
        Me.txteMail.Location = New Point(426, 76)
        Me.txteMail.Name = "txteMail"
        Me.txteMail.ReadOnly = True
        Me.txteMail.Size = New Size(171, 20)
        Me.txteMail.TabIndex = 107
        '
        'txtName
        '
        Me.txtName.Location = New Point(85, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New Size(171, 20)
        Me.txtName.TabIndex = 106
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New Point(85, 50)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New Size(171, 20)
        Me.txtAddress1.TabIndex = 105
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New Point(85, 76)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New Size(171, 20)
        Me.txtAddress2.TabIndex = 104
        '
        'txtCity
        '
        Me.txtCity.Location = New Point(85, 102)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New Size(171, 20)
        Me.txtCity.TabIndex = 103
        '
        'txtState
        '
        Me.txtState.Location = New Point(85, 128)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New Size(171, 20)
        Me.txtState.TabIndex = 102
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New Point(426, 50)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New Size(171, 20)
        Me.txtWebSite.TabIndex = 101
        '
        'txtCountry
        '
        Me.txtCountry.Location = New Point(85, 180)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New Size(171, 20)
        Me.txtCountry.TabIndex = 100
        '
        'txtFax
        '
        Me.txtFax.Location = New Point(426, 24)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New Size(171, 20)
        Me.txtFax.TabIndex = 99
        '
        'txtPhone
        '
        Me.txtPhone.Location = New Point(85, 206)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New Size(171, 20)
        Me.txtPhone.TabIndex = 98
        '
        'txtLic
        '
        Me.txtLic.Location = New Point(426, 102)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.ReadOnly = True
        Me.txtLic.Size = New Size(171, 20)
        Me.txtLic.TabIndex = 97
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New Point(308, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New Size(47, 13)
        Me.Label32.TabIndex = 96
        Me.Label32.Text = "License:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New Point(308, 79)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New Size(34, 13)
        Me.Label33.TabIndex = 95
        Me.Label33.Text = "email:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New Point(309, 53)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New Size(49, 13)
        Me.Label34.TabIndex = 94
        Me.Label34.Text = "Website:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New Point(308, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New Size(27, 13)
        Me.Label35.TabIndex = 93
        Me.Label35.Text = "Fax:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New Point(16, 210)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New Size(41, 13)
        Me.Label36.TabIndex = 92
        Me.Label36.Text = "Phone:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New Point(16, 183)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New Size(46, 13)
        Me.Label37.TabIndex = 91
        Me.Label37.Text = "Country:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New Point(16, 131)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New Size(35, 13)
        Me.Label38.TabIndex = 90
        Me.Label38.Text = "State:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New Point(16, 102)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New Size(27, 13)
        Me.Label39.TabIndex = 89
        Me.Label39.Text = "City:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New Point(16, 53)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New Size(48, 13)
        Me.Label40.TabIndex = 88
        Me.Label40.Text = "Address:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New Point(16, 27)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New Size(38, 13)
        Me.Label41.TabIndex = 87
        Me.Label41.Text = "Name:"
        '
        'btnSold
        '
        Me.btnSold.Location = New Point(170, 6)
        Me.btnSold.Name = "btnSold"
        Me.btnSold.Size = New Size(120, 24)
        Me.btnSold.TabIndex = 1
        Me.btnSold.Text = "Mark Item as Sold"
        Me.btnSold.UseVisualStyleBackColor = True
        '
        'btnFlyer
        '
        Me.btnFlyer.Location = New Point(8, 6)
        Me.btnFlyer.Name = "btnFlyer"
        Me.btnFlyer.Size = New Size(128, 23)
        Me.btnFlyer.TabIndex = 0
        Me.btnFlyer.Text = "Print Preview Flyer"
        Me.btnFlyer.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.btnAddExistingDoc)
        Me.TabPage12.Controls.Add(Me.btnAddDocument)
        Me.TabPage12.Controls.Add(Me.DataGridView6)
        Me.TabPage12.ImageIndex = 10
        Me.TabPage12.Location = New Point(4, 42)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New Padding(3)
        Me.TabPage12.Size = New Size(1142, 421)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = "Documents"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'btnAddExistingDoc
        '
        Me.btnAddExistingDoc.Location = New Point(204, 12)
        Me.btnAddExistingDoc.Name = "btnAddExistingDoc"
        Me.btnAddExistingDoc.Size = New Size(75, 23)
        Me.btnAddExistingDoc.TabIndex = 2
        Me.btnAddExistingDoc.Text = "Add Existing"
        Me.btnAddExistingDoc.UseVisualStyleBackColor = True
        '
        'btnAddDocument
        '
        Me.btnAddDocument.Location = New Point(42, 12)
        Me.btnAddDocument.Name = "btnAddDocument"
        Me.btnAddDocument.Size = New Size(75, 23)
        Me.btnAddDocument.TabIndex = 1
        Me.btnAddDocument.Text = "Add New"
        Me.btnAddDocument.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New DataGridViewColumn() {Me.LinkIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DocnameDataGridViewTextBoxColumn, Me.DocdescriptionDataGridViewTextBoxColumn, Me.DocfilenameDataGridViewTextBoxColumn, Me.DocextDataGridViewTextBoxColumn, Me.DoccatDataGridViewTextBoxColumn, Me.DtaDataGridViewTextBoxColumn})
        Me.DataGridView6.ContextMenuStrip = Me.mnuDocsMenu
        Me.DataGridView6.DataSource = Me.QryDocsAndLinksBindingSource
        Me.DataGridView6.Location = New Point(8, 41)
        Me.DataGridView6.MultiSelect = False
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView6.Size = New Size(1116, 354)
        Me.DataGridView6.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'mnuDocsMenu
        '
        Me.mnuDocsMenu.Items.AddRange(New ToolStripItem() {Me.ViewToolStripMenuItem, Me.UnLinkToolStripMenuItem, Me.EditToolStripMenuItem3})
        Me.mnuDocsMenu.Name = "mnuDocsMenu"
        Me.mnuDocsMenu.Size = New Size(109, 70)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"), Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New Size(108, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'UnLinkToolStripMenuItem
        '
        Me.UnLinkToolStripMenuItem.Image = CType(resources.GetObject("UnLinkToolStripMenuItem.Image"), Image)
        Me.UnLinkToolStripMenuItem.Name = "UnLinkToolStripMenuItem"
        Me.UnLinkToolStripMenuItem.Size = New Size(108, 22)
        Me.UnLinkToolStripMenuItem.Text = "Unlink"
        '
        'EditToolStripMenuItem3
        '
        Me.EditToolStripMenuItem3.Image = CType(resources.GetObject("EditToolStripMenuItem3.Image"), Image)
        Me.EditToolStripMenuItem3.Name = "EditToolStripMenuItem3"
        Me.EditToolStripMenuItem3.Size = New Size(108, 22)
        Me.EditToolStripMenuItem3.Text = "Edit"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        Me.ImageList1.TransparentColor = Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "2.ico")
        Me.ImageList1.Images.SetKeyName(1, "ITPRO_32_x_32.ico")
        Me.ImageList1.Images.SetKeyName(2, "Winxpicons_System_16_32x32.ico")
        Me.ImageList1.Images.SetKeyName(3, "Military_OtherWeapon_3_32x32.ico")
        Me.ImageList1.Images.SetKeyName(4, "Control Panel.ico")
        Me.ImageList1.Images.SetKeyName(5, "Military_OtherWeapon_4_32x32.ico")
        Me.ImageList1.Images.SetKeyName(6, "_14_16x16.ico")
        Me.ImageList1.Images.SetKeyName(7, "_5_16x16.ico")
        Me.ImageList1.Images.SetKeyName(8, "Others_Other1_5_32x32.ico")
        Me.ImageList1.Images.SetKeyName(9, "Barrel.ico")
        Me.ImageList1.Images.SetKeyName(10, "documents_16_x_16.ico")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = DialogResult.Cancel
        Me.btnExit.Location = New Point(339, 523)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New Size(75, 23)
        Me.btnExit.TabIndex = 114
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New Point(163, 523)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(75, 23)
        Me.btnEdit.TabIndex = 115
        Me.btnEdit.Text = "Edit Details"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'imgPics
        '
        Me.imgPics.ColorDepth = ColorDepth.Depth16Bit
        Me.imgPics.ImageSize = New Size(64, 64)
        Me.imgPics.TransparentColor = Color.Transparent
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(1184, 25)
        Me.ToolStrip1.TabIndex = 118
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Edit Details"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        Me.ToolStripButton6.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New Size(23, 22)
        Me.ToolStripButton6.Text = "Add Barrel/Conversion Kit Display"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        Me.ToolStripButton7.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New Size(23, 22)
        Me.ToolStripButton7.Text = "Refresh View"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Print Preview Detail"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        Me.ToolStripButton5.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New Size(23, 22)
        Me.ToolStripButton5.Text = "Print Preview Complete Details Report"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(23, 22)
        Me.ToolStripButton3.Text = "Export to XML"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New Size(23, 22)
        Me.ToolStripButton4.Text = "Exit"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 2
        '
        'ModelNameDataGridViewTextBoxColumn
        '
        Me.ModelNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName"
        Me.ModelNameDataGridViewTextBoxColumn.HeaderText = "Model Name"
        Me.ModelNameDataGridViewTextBoxColumn.Name = "ModelNameDataGridViewTextBoxColumn"
        Me.ModelNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModelNameDataGridViewTextBoxColumn.Width = 85
        '
        'CaliberDataGridViewTextBoxColumn
        '
        Me.CaliberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.CaliberDataGridViewTextBoxColumn.DataPropertyName = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.HeaderText = "Caliber"
        Me.CaliberDataGridViewTextBoxColumn.Name = "CaliberDataGridViewTextBoxColumn"
        Me.CaliberDataGridViewTextBoxColumn.ReadOnly = True
        Me.CaliberDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.CaliberDataGridViewTextBoxColumn.Width = 85
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.TypeDataGridViewTextBoxColumn.Width = 77
        '
        'BarrelLengthDataGridViewTextBoxColumn
        '
        Me.BarrelLengthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.BarrelLengthDataGridViewTextBoxColumn.DataPropertyName = "BarrelLength"
        Me.BarrelLengthDataGridViewTextBoxColumn.HeaderText = "Barrel Length"
        Me.BarrelLengthDataGridViewTextBoxColumn.Name = "BarrelLengthDataGridViewTextBoxColumn"
        Me.BarrelLengthDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarrelLengthDataGridViewTextBoxColumn.Width = 87
        '
        'PetLoadsDataGridViewTextBoxColumn
        '
        Me.PetLoadsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.PetLoadsDataGridViewTextBoxColumn.DataPropertyName = "PetLoads"
        Me.PetLoadsDataGridViewTextBoxColumn.HeaderText = "Pet Loads"
        Me.PetLoadsDataGridViewTextBoxColumn.Name = "PetLoadsDataGridViewTextBoxColumn"
        Me.PetLoadsDataGridViewTextBoxColumn.ReadOnly = True
        Me.PetLoadsDataGridViewTextBoxColumn.Width = 74
        '
        'PurchasedPriceDataGridViewTextBoxColumn
        '
        Me.PurchasedPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.PurchasedPriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasedPrice"
        Me.PurchasedPriceDataGridViewTextBoxColumn.HeaderText = "Purchased Price"
        Me.PurchasedPriceDataGridViewTextBoxColumn.Name = "PurchasedPriceDataGridViewTextBoxColumn"
        Me.PurchasedPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurchasedPriceDataGridViewTextBoxColumn.Width = 101
        '
        'GunCollectionExtBindingSource
        '
        Me.GunCollectionExtBindingSource.DataMember = "Gun_Collection_Ext"
        Me.GunCollectionExtBindingSource.DataSource = Me.MGCDataSet
        '
        'MGCDataSet
        '
        Me.MGCDataSet.DataSetName = "MGCDataSet"
        Me.MGCDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManufacturerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModelDataGridViewTextBoxColumn.Width = 5
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number"
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        Me.ConditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UseDataGridViewTextBoxColumn
        '
        Me.UseDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.UseDataGridViewTextBoxColumn.DataPropertyName = "Use"
        Me.UseDataGridViewTextBoxColumn.HeaderText = "Use"
        Me.UseDataGridViewTextBoxColumn.Name = "UseDataGridViewTextBoxColumn"
        Me.UseDataGridViewTextBoxColumn.ReadOnly = True
        Me.UseDataGridViewTextBoxColumn.Width = 51
        '
        'PurValueDataGridViewTextBoxColumn
        '
        Me.PurValueDataGridViewTextBoxColumn.DataPropertyName = "PurValue"
        Me.PurValueDataGridViewTextBoxColumn.HeaderText = "Purchase Value"
        Me.PurValueDataGridViewTextBoxColumn.Name = "PurValueDataGridViewTextBoxColumn"
        Me.PurValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Width = 60
        '
        'GunCollectionAccessoriesBindingSource
        '
        Me.GunCollectionAccessoriesBindingSource.DataMember = "Gun_Collection_Accessories"
        Me.GunCollectionAccessoriesBindingSource.DataSource = Me.MGCDataSet
        '
        'ManufacturerDataGridViewTextBoxColumn1
        '
        Me.ManufacturerDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.ManufacturerDataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn1.Name = "ManufacturerDataGridViewTextBoxColumn1"
        Me.ManufacturerDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ManufacturerDataGridViewTextBoxColumn1.Width = 95
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 60
        '
        'CalDataGridViewTextBoxColumn
        '
        Me.CalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.CalDataGridViewTextBoxColumn.DataPropertyName = "Cal"
        Me.CalDataGridViewTextBoxColumn.HeaderText = "Caliber"
        Me.CalDataGridViewTextBoxColumn.Name = "CalDataGridViewTextBoxColumn"
        Me.CalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalDataGridViewTextBoxColumn.Width = 64
        '
        'GrainDataGridViewTextBoxColumn
        '
        Me.GrainDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.GrainDataGridViewTextBoxColumn.DataPropertyName = "Grain"
        Me.GrainDataGridViewTextBoxColumn.HeaderText = "Grain"
        Me.GrainDataGridViewTextBoxColumn.Name = "GrainDataGridViewTextBoxColumn"
        Me.GrainDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrainDataGridViewTextBoxColumn.Width = 57
        '
        'JacketDataGridViewTextBoxColumn
        '
        Me.JacketDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.JacketDataGridViewTextBoxColumn.DataPropertyName = "Jacket"
        Me.JacketDataGridViewTextBoxColumn.HeaderText = "Jacket"
        Me.JacketDataGridViewTextBoxColumn.Name = "JacketDataGridViewTextBoxColumn"
        Me.JacketDataGridViewTextBoxColumn.ReadOnly = True
        Me.JacketDataGridViewTextBoxColumn.Width = 64
        '
        'GunCollectionAmmoBindingSource
        '
        Me.GunCollectionAmmoBindingSource.DataMember = "Gun_Collection_Ammo"
        Me.GunCollectionAmmoBindingSource.DataSource = Me.MGCDataSet
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Maintance Plan"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.[True]
        Me.NameDataGridViewTextBoxColumn1.Width = 97
        '
        'OpDateDataGridViewTextBoxColumn
        '
        Me.OpDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.OpDateDataGridViewTextBoxColumn.DataPropertyName = "OpDate"
        Me.OpDateDataGridViewTextBoxColumn.HeaderText = "Operation Date"
        Me.OpDateDataGridViewTextBoxColumn.Name = "OpDateDataGridViewTextBoxColumn"
        Me.OpDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpDateDataGridViewTextBoxColumn.Width = 96
        '
        'OpDueDateDataGridViewTextBoxColumn
        '
        Me.OpDueDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.OpDueDateDataGridViewTextBoxColumn.DataPropertyName = "OpDueDate"
        Me.OpDueDateDataGridViewTextBoxColumn.HeaderText = "Operation Due Date"
        Me.OpDueDateDataGridViewTextBoxColumn.Name = "OpDueDateDataGridViewTextBoxColumn"
        Me.OpDueDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpDueDateDataGridViewTextBoxColumn.Width = 96
        '
        'RndFiredDataGridViewTextBoxColumn
        '
        Me.RndFiredDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.RndFiredDataGridViewTextBoxColumn.DataPropertyName = "RndFired"
        Me.RndFiredDataGridViewTextBoxColumn.HeaderText = "Rounds Fired"
        Me.RndFiredDataGridViewTextBoxColumn.Name = "RndFiredDataGridViewTextBoxColumn"
        Me.RndFiredDataGridViewTextBoxColumn.ReadOnly = True
        Me.RndFiredDataGridViewTextBoxColumn.Width = 87
        '
        'NotesDataGridViewTextBoxColumn1
        '
        Me.NotesDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NotesDataGridViewTextBoxColumn1.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn1.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn1.Name = "NotesDataGridViewTextBoxColumn1"
        Me.NotesDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn1.Width = 60
        '
        'MaintanceDetailsBindingSource
        '
        Me.MaintanceDetailsBindingSource.DataMember = "Maintance_Details"
        Me.MaintanceDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'GsmithDataGridViewTextBoxColumn
        '
        Me.GsmithDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.GsmithDataGridViewTextBoxColumn.DataPropertyName = "gsmith"
        Me.GsmithDataGridViewTextBoxColumn.HeaderText = "Gun Smith"
        Me.GsmithDataGridViewTextBoxColumn.Name = "GsmithDataGridViewTextBoxColumn"
        Me.GsmithDataGridViewTextBoxColumn.ReadOnly = True
        Me.GsmithDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        Me.GsmithDataGridViewTextBoxColumn.Width = 75
        '
        'SdateDataGridViewTextBoxColumn
        '
        Me.SdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.SdateDataGridViewTextBoxColumn.DataPropertyName = "sdate"
        Me.SdateDataGridViewTextBoxColumn.HeaderText = "Ship Date"
        Me.SdateDataGridViewTextBoxColumn.Name = "SdateDataGridViewTextBoxColumn"
        Me.SdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.SdateDataGridViewTextBoxColumn.Width = 73
        '
        'RdateDataGridViewTextBoxColumn
        '
        Me.RdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.RdateDataGridViewTextBoxColumn.DataPropertyName = "rdate"
        Me.RdateDataGridViewTextBoxColumn.HeaderText = "Receive Date"
        Me.RdateDataGridViewTextBoxColumn.Name = "RdateDataGridViewTextBoxColumn"
        Me.RdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RdateDataGridViewTextBoxColumn.Width = 90
        '
        'OdDataGridViewTextBoxColumn
        '
        Me.OdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.OdDataGridViewTextBoxColumn.DataPropertyName = "od"
        Me.OdDataGridViewTextBoxColumn.HeaderText = "Operation Details"
        Me.OdDataGridViewTextBoxColumn.Name = "OdDataGridViewTextBoxColumn"
        Me.OdDataGridViewTextBoxColumn.Width = 104
        '
        'NotesDataGridViewTextBoxColumn2
        '
        Me.NotesDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.NotesDataGridViewTextBoxColumn2.DataPropertyName = "notes"
        Me.NotesDataGridViewTextBoxColumn2.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn2.Name = "NotesDataGridViewTextBoxColumn2"
        Me.NotesDataGridViewTextBoxColumn2.Width = 60
        '
        'GunSmithDetailsBindingSource
        '
        Me.GunSmithDetailsBindingSource.DataMember = "GunSmith_Details"
        Me.GunSmithDetailsBindingSource.DataSource = Me.MGCDataSet
        '
        'LinkIDDataGridViewTextBoxColumn
        '
        Me.LinkIDDataGridViewTextBoxColumn.DataPropertyName = "LinkID"
        Me.LinkIDDataGridViewTextBoxColumn.FillWeight = 5.0!
        Me.LinkIDDataGridViewTextBoxColumn.HeaderText = "LinkID"
        Me.LinkIDDataGridViewTextBoxColumn.Name = "LinkIDDataGridViewTextBoxColumn"
        Me.LinkIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LinkIDDataGridViewTextBoxColumn.Visible = False
        Me.LinkIDDataGridViewTextBoxColumn.Width = 5
        '
        'DocnameDataGridViewTextBoxColumn
        '
        Me.DocnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocnameDataGridViewTextBoxColumn.DataPropertyName = "doc_name"
        Me.DocnameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.DocnameDataGridViewTextBoxColumn.Name = "DocnameDataGridViewTextBoxColumn"
        Me.DocnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocdescriptionDataGridViewTextBoxColumn
        '
        Me.DocdescriptionDataGridViewTextBoxColumn.DataPropertyName = "doc_description"
        Me.DocdescriptionDataGridViewTextBoxColumn.FillWeight = 400.0!
        Me.DocdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DocdescriptionDataGridViewTextBoxColumn.Name = "DocdescriptionDataGridViewTextBoxColumn"
        Me.DocdescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocfilenameDataGridViewTextBoxColumn
        '
        Me.DocfilenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocfilenameDataGridViewTextBoxColumn.DataPropertyName = "doc_filename"
        Me.DocfilenameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.DocfilenameDataGridViewTextBoxColumn.Name = "DocfilenameDataGridViewTextBoxColumn"
        Me.DocfilenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocextDataGridViewTextBoxColumn
        '
        Me.DocextDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DocextDataGridViewTextBoxColumn.DataPropertyName = "doc_ext"
        Me.DocextDataGridViewTextBoxColumn.HeaderText = "Doc Type"
        Me.DocextDataGridViewTextBoxColumn.Name = "DocextDataGridViewTextBoxColumn"
        Me.DocextDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocextDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'DoccatDataGridViewTextBoxColumn
        '
        Me.DoccatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DoccatDataGridViewTextBoxColumn.DataPropertyName = "doc_cat"
        Me.DoccatDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.DoccatDataGridViewTextBoxColumn.Name = "DoccatDataGridViewTextBoxColumn"
        Me.DoccatDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoccatDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.[True]
        '
        'DtaDataGridViewTextBoxColumn
        '
        Me.DtaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.DtaDataGridViewTextBoxColumn.DataPropertyName = "dta"
        Me.DtaDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DtaDataGridViewTextBoxColumn.Name = "DtaDataGridViewTextBoxColumn"
        Me.DtaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QryDocsAndLinksBindingSource
        '
        Me.QryDocsAndLinksBindingSource.DataMember = "qry_DocsAndLinks"
        Me.QryDocsAndLinksBindingSource.DataSource = Me.MGCDataSet
        '
        'Gun_Collection_AccessoriesTableAdapter
        '
        Me.Gun_Collection_AccessoriesTableAdapter.ClearBeforeFill = True
        '
        'Gun_Collection_AmmoTableAdapter
        '
        Me.Gun_Collection_AmmoTableAdapter.ClearBeforeFill = True
        '
        'Maintance_DetailsTableAdapter
        '
        Me.Maintance_DetailsTableAdapter.ClearBeforeFill = True
        '
        'GunSmith_DetailsTableAdapter
        '
        Me.GunSmith_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Gun_Collection_ExtTableAdapter
        '
        Me.Gun_Collection_ExtTableAdapter.ClearBeforeFill = True
        '
        'Qry_DocsAndLinksTableAdapter
        '
        Me.Qry_DocsAndLinksTableAdapter.ClearBeforeFill = True
        '
        'frmViewCollectionDetails
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1184, 496)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.HelpProvider1.SetHelpKeyword(Me, "6")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me, "6")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmViewCollectionDetails"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "View Full Detailed Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.pbStolen, ISupportInitialize).EndInit()
        CType(Me.pbSold, ISupportInitialize).EndInit()
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.mnuPictre.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        CType(Me.DataGridView5, ISupportInitialize).EndInit()
        Me.mnuBarrel.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView1, ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.DataGridView2, ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGridView3, ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        CType(Me.DataGridView4, ISupportInitialize).EndInit()
        Me.mnuGunSmith.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        CType(Me.DataGridView6, ISupportInitialize).EndInit()
        Me.mnuDocsMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GunCollectionExtBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        CType(Me.GunCollectionAccessoriesBindingSource, ISupportInitialize).EndInit()
        CType(Me.GunCollectionAmmoBindingSource, ISupportInitialize).EndInit()
        CType(Me.MaintanceDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.GunSmithDetailsBindingSource, ISupportInitialize).EndInit()
        CType(Me.QryDocsAndLinksBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnAdd As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtConCom As TextBox
    Friend WithEvents txtAddNotes As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents txtPurPrice As TextBox
    Friend WithEvents txtPurchasedFrom As TextBox
    Friend WithEvents txtStorage As TextBox
    Friend WithEvents txtSights As TextBox
    Friend WithEvents txtFeed As TextBox
    Friend WithEvents txtAction As TextBox
    Friend WithEvents txtProduced As TextBox
    Friend WithEvents txtGripType As TextBox
    Friend WithEvents txtCustCatID As TextBox
    Friend WithEvents txtBarHei As TextBox
    Friend WithEvents txtBarWid As TextBox
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
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents GunCollectionAccessoriesBindingSource As BindingSource
    Friend WithEvents Gun_Collection_AccessoriesTableAdapter As Gun_Collection_AccessoriesTableAdapter
    Friend WithEvents btnAddAccess As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GunCollectionAmmoBindingSource As BindingSource
    Friend WithEvents Gun_Collection_AmmoTableAdapter As Gun_Collection_AmmoTableAdapter
    Friend WithEvents btnAddAmmo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents imgPics As ImageList
    Friend WithEvents btnRefreshPics As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents btnAddMain As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents MaintanceDetailsBindingSource As BindingSource
    Friend WithEvents Maintance_DetailsTableAdapter As Maintance_DetailsTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents btnGSLog As Button
    Friend WithEvents btnGSReport As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents GunSmithDetailsBindingSource As BindingSource
    Friend WithEvents GunSmith_DetailsTableAdapter As GunSmith_DetailsTableAdapter
    Friend WithEvents btnRefreshGS As Button
    Friend WithEvents mnuPictre As ContextMenuStrip
    Friend WithEvents mnuPicItem_Show As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuPicItem_Delete As ToolStripMenuItem
    Friend WithEvents btnPrintPreviewMaintanceReport As Button
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents btnFlyer As Button
    Friend WithEvents btnSold As Button
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents btnUnDoSale As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JacketDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Qty1 As DataGridViewTextBoxColumn
    Friend WithEvents Label42 As Label
    Friend WithEvents txtPetLoads As TextBox
    Friend WithEvents txtImporter As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents lblAmmoTotal As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents lblTotalRndsFired As Label
    Friend WithEvents lblAvgRndsFired As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents pbSold As PictureBox
    Friend WithEvents lblSold As Label
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents btnAmmoReportByCal As Button
    Friend WithEvents mnuGunSmith As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents GsmithDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents SdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents btnVwAccessReport As Button
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents GunCollectionExtBindingSource As BindingSource
    Friend WithEvents Gun_Collection_ExtTableAdapter As Gun_Collection_ExtTableAdapter
    Friend WithEvents mnuBarrel As ContextMenuStrip
    Friend WithEvents SetAsDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label50 As Label
    Friend WithEvents lblTotalFirearm As Label
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaliberDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents BarrelLengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PetLoadsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnGalleryReport As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppValue As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTAV As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents lblTPV As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents EditNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMain As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaintID As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents OpDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpDueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RndFiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents au As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents txtChoke As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents pbStolen As PictureBox
    Friend WithEvents btnStolen As Button
    Friend WithEvents btnPrintSale As Button
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents chkBoxCR As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPOI As TextBox
    Friend WithEvents dtpReManDT As DateTimePicker
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents chkBoundBook As CheckBox
    Friend WithEvents txtClassification As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label56 As Label
    Friend WithEvents txtInsVal As TextBox
    Friend WithEvents txtAppBy As TextBox
    Friend WithEvents dtpAppDate As DateTimePicker
    Friend WithEvents txtAppValue As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dtpPurchased As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents txtTriggerPull As TextBox
    Friend WithEvents txtTwistOfRate As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents txtCaliber3 As TextBox
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents QryDocsAndLinksBindingSource As BindingSource
    Friend WithEvents Qry_DocsAndLinksTableAdapter As qry_DocsAndLinksTableAdapter
    Friend WithEvents btnAddExistingDoc As Button
    Friend WithEvents mnuDocsMenu As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnLinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LinkIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DocnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocfilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocextDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DoccatDataGridViewTextBoxColumn As DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtClassIIIOwner As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents chkClassIII As CheckBox
    Friend WithEvents Label60 As Label
    Friend WithEvents dtpDateofCR As DateTimePicker
End Class
