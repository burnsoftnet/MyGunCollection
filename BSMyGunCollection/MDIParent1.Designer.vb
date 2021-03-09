Imports System.ComponentModel
Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class MDIParent1
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New MenuStrip()
        Me.FileMenu = New ToolStripMenuItem()
        Me.ImportFirearmToolStripMenuItem = New ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator3 = New ToolStripSeparator()
        Me.SaveToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator4 = New ToolStripSeparator()
        Me.ExitToolStripMenuItem = New ToolStripMenuItem()
        Me.EditMenu = New ToolStripMenuItem()
        Me.ManufacturersToolStripMenuItem = New ToolStripMenuItem()
        Me.AmmunitionTypeToolStripMenuItem = New ToolStripMenuItem()
        Me.ModelToolStripMenuItem = New ToolStripMenuItem()
        Me.PlaceOfOriginToolStripMenuItem = New ToolStripMenuItem()
        Me.GripTypesToolStripMenuItem = New ToolStripMenuItem()
        Me.FirearmConditionsToolStripMenuItem = New ToolStripMenuItem()
        Me.FirearmTypesToolStripMenuItem = New ToolStripMenuItem()
        Me.ClassificationToolStripMenuItem = New ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New ToolStripMenuItem()
        Me.GunToolStripMenuItem = New ToolStripMenuItem()
        Me.AddMmunitionToMyCollectionToolStripMenuItem = New ToolStripMenuItem()
        Me.AddToWishlistToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator10 = New ToolStripSeparator()
        Me.AddManufacturerToolStripMenuItem = New ToolStripMenuItem()
        Me.AmmToolStripMenuItem = New ToolStripMenuItem()
        Me.AddFirearmClassificationToolStripMenuItem = New ToolStripMenuItem()
        Me.AddModelToolStripMenuItem = New ToolStripMenuItem()
        Me.AddPlaceOfOriginToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator13 = New ToolStripSeparator()
        Me.MaintancePlanToolStripMenuItem = New ToolStripMenuItem()
        Me.DocumentToolStripMenuItem = New ToolStripMenuItem()
        Me.ViewMenu = New ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator11 = New ToolStripSeparator()
        Me.AmmunitionInventroyToolStripMenuItem = New ToolStripMenuItem()
        Me.WishlistToolStripMenuItem = New ToolStripMenuItem()
        Me.MaintancePlanToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ListedShopsToolStripMenuItem = New ToolStripMenuItem()
        Me.ListedBuyersToolStripMenuItem = New ToolStripMenuItem()
        Me.ListedGunsmithsToolStripMenuItem = New ToolStripMenuItem()
        Me.ListedAppriasersToolStripMenuItem = New ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New ToolStripMenuItem()
        Me.PickerToolStripMenuItem = New ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New ToolStripMenuItem()
        Me.QuickCollectionReportToolStripMenuItem = New ToolStripMenuItem()
        Me.QuickCollectionReportWNotesToolStripMenuItem = New ToolStripMenuItem()
        Me.AmmunitionCollectionReportToolStripMenuItem = New ToolStripMenuItem()
        Me.BoundBookToolStripMenuItem = New ToolStripMenuItem()
        Me.BoundBookVersion1ToolStripMenuItem = New ToolStripMenuItem()
        Me.BounfBookVersion2ToolStripMenuItem = New ToolStripMenuItem()
        Me.PrintOutWishlistToolStripMenuItem = New ToolStripMenuItem()
        Me.InsuranceReportToolStripMenuItem = New ToolStripMenuItem()
        Me.ByPurchasedValueToolStripMenuItem = New ToolStripMenuItem()
        Me.ByInsuredValueToolStripMenuItem = New ToolStripMenuItem()
        Me.ByAppraisedValueToolStripMenuItem = New ToolStripMenuItem()
        Me.InsuraceReportWithTotalToolStripMenuItem = New ToolStripMenuItem()
        Me.ByPurchasedValueToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ByInsuredValueToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ByAppraisedValueToolStripMenuItem1 = New ToolStripMenuItem()
        Me.CustomReportToolStripMenuItem = New ToolStripMenuItem()
        Me.BlankReportsToolStripMenuItem = New ToolStripMenuItem()
        Me.BoundBookToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ShootersCardToolStripMenuItem = New ToolStripMenuItem()
        Me.ShootersCardToolStripMenuItem1 = New ToolStripMenuItem()
        Me.ToolsMenu = New ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New ToolStripMenuItem()
        Me.CleanUpToolStripMenuItem = New ToolStripMenuItem()
        Me.DataPreLoaderToolStripMenuItem = New ToolStripMenuItem()
        Me.ReRunHotfixUpdatesToolStripMenuItem = New ToolStripMenuItem()
        Me.RunToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix1ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix2ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix3ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix4ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix5ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix6ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix7ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix8ToolStripMenuItem = New ToolStripMenuItem()
        Me.Hotfix9ToolStripMenuItem = New ToolStripMenuItem()
        Me.RedoAllToolStripMenuItem = New ToolStripMenuItem()
        Me.SearchCollectionToolStripMenuItem = New ToolStripMenuItem()
        Me.ShowDebugLogToolStripMenuItem = New ToolStripMenuItem()
        Me.WindowsMenu = New ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New ToolStripMenuItem()
        Me.HelpMenu = New ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New ToolStripMenuItem()
        Me.MiscFirearmLinksToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator8 = New ToolStripSeparator()
        Me.AboutToolStripMenuItem = New ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator12 = New ToolStripSeparator()
        Me.TechnicalSupportToolStripMenuItem = New ToolStripMenuItem()
        Me.ReportABugToolStripMenuItem = New ToolStripMenuItem()
        Me.KnowledgeBaseToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStrip = New ToolStrip()
        Me.OpenToolStripButton = New ToolStripButton()
        Me.SaveToolStripButton = New ToolStripButton()
        Me.ToolStripButton6 = New ToolStripButton()
        Me.ToolStripSeparator1 = New ToolStripSeparator()
        Me.ToolStripButton4 = New ToolStripButton()
        Me.ToolStripButton9 = New ToolStripButton()
        Me.ToolStripButton10 = New ToolStripButton()
        Me.ToolStripButton11 = New ToolStripButton()
        Me.ToolStripButton5 = New ToolStripButton()
        Me.ToolStripSeparator2 = New ToolStripSeparator()
        Me.ToolStripButton1 = New ToolStripButton()
        Me.ToolStripButton15 = New ToolStripButton()
        Me.ToolStripButton13 = New ToolStripButton()
        Me.ToolStripButton2 = New ToolStripButton()
        Me.ToolStripSeparator9 = New ToolStripSeparator()
        Me.ToolStripButton7 = New ToolStripButton()
        Me.ToolStripButton8 = New ToolStripSplitButton()
        Me.BoundBook1ToolStripMenuItem = New ToolStripMenuItem()
        Me.BoundBookVersion2ToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripButton14 = New ToolStripButton()
        Me.ToolStripButton12 = New ToolStripButton()
        Me.ToolStripSeparator16 = New ToolStripSeparator()
        Me.ToolStripButton3 = New ToolStripButton()
        Me.HelpToolStripButton = New ToolStripButton()
        Me.StatusStrip = New StatusStrip()
        Me.tsslErrorsFound = New ToolStripStatusLabel()
        Me.ToolStripStatusLabel = New ToolStripStatusLabel()
        Me.ToolTip = New ToolTip(Me.components)
        Me.Panel1 = New Panel()
        Me.lblTotal = New Label()
        Me.lbltotalview = New Label()
        Me.cmbView = New ComboBox()
        Me.ListBox1 = New ListBox()
        Me.ListStrip = New ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New ToolStripMenuItem()
        Me.EditToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator5 = New ToolStripSeparator()
        Me.ViewDetailedReportToolStripMenuItem = New ToolStripMenuItem()
        Me.ViewFullDetailedReportToolStripMenuItem = New ToolStripMenuItem()
        Me.ViewGunSmithReportToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripSeparator15 = New ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New ToolStripMenuItem()
        Me.CopyFirearmToolStripMenuItem = New ToolStripMenuItem()
        Me.RenameDisplayNameToolStripMenuItem = New ToolStripMenuItem()
        Me.GunCollectionBindingSource = New BindingSource(Me.components)
        Me.MGCDataSetBindingSource = New BindingSource(Me.components)
        Me.MGCDataSet = New MGCDataSet()
        Me.Gun_CollectionTableAdapter = New Gun_CollectionTableAdapter()
        Me.HelpProvider1 = New HelpProvider()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ListStrip.SuspendLayout()
        CType(Me.GunCollectionBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSetBindingSource, ISupportInitialize).BeginInit()
        CType(Me.MGCDataSet, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.AddItemToolStripMenuItem, Me.ViewMenu, Me.ReportsToolStripMenuItem, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New Size(727, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New ToolStripItem() {Me.ImportFirearmToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ImportFirearmToolStripMenuItem
        '
        Me.ImportFirearmToolStripMenuItem.Image = CType(resources.GetObject("ImportFirearmToolStripMenuItem.Image"), Image)
        Me.ImportFirearmToolStripMenuItem.Name = "ImportFirearmToolStripMenuItem"
        Me.ImportFirearmToolStripMenuItem.Size = New Size(154, 22)
        Me.ImportFirearmToolStripMenuItem.Text = "&Import Firearm"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((Keys.Control Or Keys.R), Keys)
        Me.OpenToolStripMenuItem.Size = New Size(154, 22)
        Me.OpenToolStripMenuItem.Text = "&Restore"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New Size(151, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((Keys.Control Or Keys.B), Keys)
        Me.SaveToolStripMenuItem.Size = New Size(154, 22)
        Me.SaveToolStripMenuItem.Text = "&Backup"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New Size(151, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New Size(154, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New ToolStripItem() {Me.ManufacturersToolStripMenuItem, Me.AmmunitionTypeToolStripMenuItem, Me.ModelToolStripMenuItem, Me.PlaceOfOriginToolStripMenuItem, Me.GripTypesToolStripMenuItem, Me.FirearmConditionsToolStripMenuItem, Me.FirearmTypesToolStripMenuItem, Me.ClassificationToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'ManufacturersToolStripMenuItem
        '
        Me.ManufacturersToolStripMenuItem.Image = CType(resources.GetObject("ManufacturersToolStripMenuItem.Image"), Image)
        Me.ManufacturersToolStripMenuItem.Name = "ManufacturersToolStripMenuItem"
        Me.ManufacturersToolStripMenuItem.Size = New Size(188, 22)
        Me.ManufacturersToolStripMenuItem.Text = "Manufacturers"
        '
        'AmmunitionTypeToolStripMenuItem
        '
        Me.AmmunitionTypeToolStripMenuItem.Image = CType(resources.GetObject("AmmunitionTypeToolStripMenuItem.Image"), Image)
        Me.AmmunitionTypeToolStripMenuItem.Name = "AmmunitionTypeToolStripMenuItem"
        Me.AmmunitionTypeToolStripMenuItem.Size = New Size(188, 22)
        Me.AmmunitionTypeToolStripMenuItem.Text = "Ammunition Type"
        '
        'ModelToolStripMenuItem
        '
        Me.ModelToolStripMenuItem.Image = CType(resources.GetObject("ModelToolStripMenuItem.Image"), Image)
        Me.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem"
        Me.ModelToolStripMenuItem.Size = New Size(188, 22)
        Me.ModelToolStripMenuItem.Text = "Manage Model Types"
        '
        'PlaceOfOriginToolStripMenuItem
        '
        Me.PlaceOfOriginToolStripMenuItem.Image = CType(resources.GetObject("PlaceOfOriginToolStripMenuItem.Image"), Image)
        Me.PlaceOfOriginToolStripMenuItem.Name = "PlaceOfOriginToolStripMenuItem"
        Me.PlaceOfOriginToolStripMenuItem.Size = New Size(188, 22)
        Me.PlaceOfOriginToolStripMenuItem.Text = "Place of Origin"
        '
        'GripTypesToolStripMenuItem
        '
        Me.GripTypesToolStripMenuItem.Image = CType(resources.GetObject("GripTypesToolStripMenuItem.Image"), Image)
        Me.GripTypesToolStripMenuItem.Name = "GripTypesToolStripMenuItem"
        Me.GripTypesToolStripMenuItem.Size = New Size(188, 22)
        Me.GripTypesToolStripMenuItem.Text = "Grip Types"
        '
        'FirearmConditionsToolStripMenuItem
        '
        Me.FirearmConditionsToolStripMenuItem.Image = CType(resources.GetObject("FirearmConditionsToolStripMenuItem.Image"), Image)
        Me.FirearmConditionsToolStripMenuItem.Name = "FirearmConditionsToolStripMenuItem"
        Me.FirearmConditionsToolStripMenuItem.Size = New Size(188, 22)
        Me.FirearmConditionsToolStripMenuItem.Text = "Firearm Conditions"
        '
        'FirearmTypesToolStripMenuItem
        '
        Me.FirearmTypesToolStripMenuItem.Image = CType(resources.GetObject("FirearmTypesToolStripMenuItem.Image"), Image)
        Me.FirearmTypesToolStripMenuItem.Name = "FirearmTypesToolStripMenuItem"
        Me.FirearmTypesToolStripMenuItem.Size = New Size(188, 22)
        Me.FirearmTypesToolStripMenuItem.Text = "Firearm Types"
        '
        'ClassificationToolStripMenuItem
        '
        Me.ClassificationToolStripMenuItem.Image = CType(resources.GetObject("ClassificationToolStripMenuItem.Image"), Image)
        Me.ClassificationToolStripMenuItem.Name = "ClassificationToolStripMenuItem"
        Me.ClassificationToolStripMenuItem.Size = New Size(188, 22)
        Me.ClassificationToolStripMenuItem.Text = "Classification"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.GunToolStripMenuItem, Me.AddMmunitionToMyCollectionToolStripMenuItem, Me.AddToWishlistToolStripMenuItem, Me.ToolStripSeparator10, Me.AddManufacturerToolStripMenuItem, Me.AmmToolStripMenuItem, Me.AddFirearmClassificationToolStripMenuItem, Me.AddModelToolStripMenuItem, Me.AddPlaceOfOriginToolStripMenuItem, Me.ToolStripSeparator13, Me.MaintancePlanToolStripMenuItem, Me.DocumentToolStripMenuItem})
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New Size(68, 20)
        Me.AddItemToolStripMenuItem.Text = "&Add Item"
        '
        'GunToolStripMenuItem
        '
        Me.GunToolStripMenuItem.Image = CType(resources.GetObject("GunToolStripMenuItem.Image"), Image)
        Me.GunToolStripMenuItem.Name = "GunToolStripMenuItem"
        Me.GunToolStripMenuItem.Size = New Size(258, 22)
        Me.GunToolStripMenuItem.Text = "Add Firearm"
        '
        'AddMmunitionToMyCollectionToolStripMenuItem
        '
        Me.AddMmunitionToMyCollectionToolStripMenuItem.Image = CType(resources.GetObject("AddMmunitionToMyCollectionToolStripMenuItem.Image"), Image)
        Me.AddMmunitionToMyCollectionToolStripMenuItem.Name = "AddMmunitionToMyCollectionToolStripMenuItem"
        Me.AddMmunitionToMyCollectionToolStripMenuItem.Size = New Size(258, 22)
        Me.AddMmunitionToMyCollectionToolStripMenuItem.Text = "Add Ammunition to my Collection"
        '
        'AddToWishlistToolStripMenuItem
        '
        Me.AddToWishlistToolStripMenuItem.Image = CType(resources.GetObject("AddToWishlistToolStripMenuItem.Image"), Image)
        Me.AddToWishlistToolStripMenuItem.Name = "AddToWishlistToolStripMenuItem"
        Me.AddToWishlistToolStripMenuItem.Size = New Size(258, 22)
        Me.AddToWishlistToolStripMenuItem.Text = "Add to Wishlist"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New Size(255, 6)
        '
        'AddManufacturerToolStripMenuItem
        '
        Me.AddManufacturerToolStripMenuItem.Image = CType(resources.GetObject("AddManufacturerToolStripMenuItem.Image"), Image)
        Me.AddManufacturerToolStripMenuItem.Name = "AddManufacturerToolStripMenuItem"
        Me.AddManufacturerToolStripMenuItem.Size = New Size(258, 22)
        Me.AddManufacturerToolStripMenuItem.Text = "Add Manufacturer"
        '
        'AmmToolStripMenuItem
        '
        Me.AmmToolStripMenuItem.Image = CType(resources.GetObject("AmmToolStripMenuItem.Image"), Image)
        Me.AmmToolStripMenuItem.Name = "AmmToolStripMenuItem"
        Me.AmmToolStripMenuItem.Size = New Size(258, 22)
        Me.AmmToolStripMenuItem.Text = "Add Ammunition Type"
        '
        'AddFirearmClassificationToolStripMenuItem
        '
        Me.AddFirearmClassificationToolStripMenuItem.Image = CType(resources.GetObject("AddFirearmClassificationToolStripMenuItem.Image"), Image)
        Me.AddFirearmClassificationToolStripMenuItem.Name = "AddFirearmClassificationToolStripMenuItem"
        Me.AddFirearmClassificationToolStripMenuItem.Size = New Size(258, 22)
        Me.AddFirearmClassificationToolStripMenuItem.Text = "Add Firearm Classification"
        '
        'AddModelToolStripMenuItem
        '
        Me.AddModelToolStripMenuItem.Image = CType(resources.GetObject("AddModelToolStripMenuItem.Image"), Image)
        Me.AddModelToolStripMenuItem.Name = "AddModelToolStripMenuItem"
        Me.AddModelToolStripMenuItem.Size = New Size(258, 22)
        Me.AddModelToolStripMenuItem.Text = "Add Model"
        '
        'AddPlaceOfOriginToolStripMenuItem
        '
        Me.AddPlaceOfOriginToolStripMenuItem.Image = CType(resources.GetObject("AddPlaceOfOriginToolStripMenuItem.Image"), Image)
        Me.AddPlaceOfOriginToolStripMenuItem.Name = "AddPlaceOfOriginToolStripMenuItem"
        Me.AddPlaceOfOriginToolStripMenuItem.Size = New Size(258, 22)
        Me.AddPlaceOfOriginToolStripMenuItem.Text = "Add Place of Origin"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New Size(255, 6)
        '
        'MaintancePlanToolStripMenuItem
        '
        Me.MaintancePlanToolStripMenuItem.Image = CType(resources.GetObject("MaintancePlanToolStripMenuItem.Image"), Image)
        Me.MaintancePlanToolStripMenuItem.Name = "MaintancePlanToolStripMenuItem"
        Me.MaintancePlanToolStripMenuItem.Size = New Size(258, 22)
        Me.MaintancePlanToolStripMenuItem.Text = "Maintenance Plan"
        '
        'DocumentToolStripMenuItem
        '
        Me.DocumentToolStripMenuItem.Image = CType(resources.GetObject("DocumentToolStripMenuItem.Image"), Image)
        Me.DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem"
        Me.DocumentToolStripMenuItem.Size = New Size(258, 22)
        Me.DocumentToolStripMenuItem.Text = "Document"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.ToolStripSeparator11, Me.AmmunitionInventroyToolStripMenuItem, Me.WishlistToolStripMenuItem, Me.MaintancePlanToolStripMenuItem1, Me.ListedShopsToolStripMenuItem, Me.ListedBuyersToolStripMenuItem, Me.ListedGunsmithsToolStripMenuItem, Me.ListedAppriasersToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.PickerToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New Size(195, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New Size(195, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New Size(192, 6)
        '
        'AmmunitionInventroyToolStripMenuItem
        '
        Me.AmmunitionInventroyToolStripMenuItem.Image = CType(resources.GetObject("AmmunitionInventroyToolStripMenuItem.Image"), Image)
        Me.AmmunitionInventroyToolStripMenuItem.Name = "AmmunitionInventroyToolStripMenuItem"
        Me.AmmunitionInventroyToolStripMenuItem.Size = New Size(195, 22)
        Me.AmmunitionInventroyToolStripMenuItem.Text = "&Ammunition Inventory"
        '
        'WishlistToolStripMenuItem
        '
        Me.WishlistToolStripMenuItem.Image = CType(resources.GetObject("WishlistToolStripMenuItem.Image"), Image)
        Me.WishlistToolStripMenuItem.Name = "WishlistToolStripMenuItem"
        Me.WishlistToolStripMenuItem.Size = New Size(195, 22)
        Me.WishlistToolStripMenuItem.Text = "&Wishlist"
        '
        'MaintancePlanToolStripMenuItem1
        '
        Me.MaintancePlanToolStripMenuItem1.Image = CType(resources.GetObject("MaintancePlanToolStripMenuItem1.Image"), Image)
        Me.MaintancePlanToolStripMenuItem1.Name = "MaintancePlanToolStripMenuItem1"
        Me.MaintancePlanToolStripMenuItem1.Size = New Size(195, 22)
        Me.MaintancePlanToolStripMenuItem1.Text = "&Maintenance Plan"
        '
        'ListedShopsToolStripMenuItem
        '
        Me.ListedShopsToolStripMenuItem.Image = CType(resources.GetObject("ListedShopsToolStripMenuItem.Image"), Image)
        Me.ListedShopsToolStripMenuItem.Name = "ListedShopsToolStripMenuItem"
        Me.ListedShopsToolStripMenuItem.Size = New Size(195, 22)
        Me.ListedShopsToolStripMenuItem.Text = "Listed Shops"
        '
        'ListedBuyersToolStripMenuItem
        '
        Me.ListedBuyersToolStripMenuItem.Image = CType(resources.GetObject("ListedBuyersToolStripMenuItem.Image"), Image)
        Me.ListedBuyersToolStripMenuItem.Name = "ListedBuyersToolStripMenuItem"
        Me.ListedBuyersToolStripMenuItem.Size = New Size(195, 22)
        Me.ListedBuyersToolStripMenuItem.Text = "Listed Buyers"
        '
        'ListedGunsmithsToolStripMenuItem
        '
        Me.ListedGunsmithsToolStripMenuItem.Image = CType(resources.GetObject("ListedGunsmithsToolStripMenuItem.Image"), Image)
        Me.ListedGunsmithsToolStripMenuItem.Name = "ListedGunsmithsToolStripMenuItem"
        Me.ListedGunsmithsToolStripMenuItem.Size = New Size(195, 22)
        Me.ListedGunsmithsToolStripMenuItem.Text = "Listed Gunsmiths"
        '
        'ListedAppriasersToolStripMenuItem
        '
        Me.ListedAppriasersToolStripMenuItem.Image = CType(resources.GetObject("ListedAppriasersToolStripMenuItem.Image"), Image)
        Me.ListedAppriasersToolStripMenuItem.Name = "ListedAppriasersToolStripMenuItem"
        Me.ListedAppriasersToolStripMenuItem.Size = New Size(195, 22)
        Me.ListedAppriasersToolStripMenuItem.Text = "Listed Appraisers"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Image = CType(resources.GetObject("DocumentsToolStripMenuItem.Image"), Image)
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New Size(195, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'PickerToolStripMenuItem
        '
        Me.PickerToolStripMenuItem.Image = CType(resources.GetObject("PickerToolStripMenuItem.Image"), Image)
        Me.PickerToolStripMenuItem.Name = "PickerToolStripMenuItem"
        Me.PickerToolStripMenuItem.Size = New Size(195, 22)
        Me.PickerToolStripMenuItem.Text = "Image Picker"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.QuickCollectionReportToolStripMenuItem, Me.QuickCollectionReportWNotesToolStripMenuItem, Me.AmmunitionCollectionReportToolStripMenuItem, Me.BoundBookToolStripMenuItem, Me.PrintOutWishlistToolStripMenuItem, Me.InsuranceReportToolStripMenuItem, Me.InsuraceReportWithTotalToolStripMenuItem, Me.CustomReportToolStripMenuItem, Me.BlankReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'QuickCollectionReportToolStripMenuItem
        '
        Me.QuickCollectionReportToolStripMenuItem.Image = CType(resources.GetObject("QuickCollectionReportToolStripMenuItem.Image"), Image)
        Me.QuickCollectionReportToolStripMenuItem.Name = "QuickCollectionReportToolStripMenuItem"
        Me.QuickCollectionReportToolStripMenuItem.Size = New Size(251, 22)
        Me.QuickCollectionReportToolStripMenuItem.Text = "Quick Collection Report"
        '
        'QuickCollectionReportWNotesToolStripMenuItem
        '
        Me.QuickCollectionReportWNotesToolStripMenuItem.Image = CType(resources.GetObject("QuickCollectionReportWNotesToolStripMenuItem.Image"), Image)
        Me.QuickCollectionReportWNotesToolStripMenuItem.Name = "QuickCollectionReportWNotesToolStripMenuItem"
        Me.QuickCollectionReportWNotesToolStripMenuItem.Size = New Size(251, 22)
        Me.QuickCollectionReportWNotesToolStripMenuItem.Text = "Quick Collection Report w/ Notes"
        '
        'AmmunitionCollectionReportToolStripMenuItem
        '
        Me.AmmunitionCollectionReportToolStripMenuItem.Image = CType(resources.GetObject("AmmunitionCollectionReportToolStripMenuItem.Image"), Image)
        Me.AmmunitionCollectionReportToolStripMenuItem.Name = "AmmunitionCollectionReportToolStripMenuItem"
        Me.AmmunitionCollectionReportToolStripMenuItem.Size = New Size(251, 22)
        Me.AmmunitionCollectionReportToolStripMenuItem.Text = "Ammunition Collection Report"
        '
        'BoundBookToolStripMenuItem
        '
        Me.BoundBookToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.BoundBookVersion1ToolStripMenuItem, Me.BounfBookVersion2ToolStripMenuItem})
        Me.BoundBookToolStripMenuItem.Image = CType(resources.GetObject("BoundBookToolStripMenuItem.Image"), Image)
        Me.BoundBookToolStripMenuItem.Name = "BoundBookToolStripMenuItem"
        Me.BoundBookToolStripMenuItem.Size = New Size(251, 22)
        Me.BoundBookToolStripMenuItem.Text = "Bound Book"
        '
        'BoundBookVersion1ToolStripMenuItem
        '
        Me.BoundBookVersion1ToolStripMenuItem.Name = "BoundBookVersion1ToolStripMenuItem"
        Me.BoundBookVersion1ToolStripMenuItem.Size = New Size(190, 22)
        Me.BoundBookVersion1ToolStripMenuItem.Text = "Bound Book Version 1"
        '
        'BounfBookVersion2ToolStripMenuItem
        '
        Me.BounfBookVersion2ToolStripMenuItem.Name = "BounfBookVersion2ToolStripMenuItem"
        Me.BounfBookVersion2ToolStripMenuItem.Size = New Size(190, 22)
        Me.BounfBookVersion2ToolStripMenuItem.Text = "Bound Book Version 2"
        '
        'PrintOutWishlistToolStripMenuItem
        '
        Me.PrintOutWishlistToolStripMenuItem.Image = CType(resources.GetObject("PrintOutWishlistToolStripMenuItem.Image"), Image)
        Me.PrintOutWishlistToolStripMenuItem.Name = "PrintOutWishlistToolStripMenuItem"
        Me.PrintOutWishlistToolStripMenuItem.Size = New Size(251, 22)
        Me.PrintOutWishlistToolStripMenuItem.Text = "Wishlist"
        '
        'InsuranceReportToolStripMenuItem
        '
        Me.InsuranceReportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.ByPurchasedValueToolStripMenuItem, Me.ByInsuredValueToolStripMenuItem, Me.ByAppraisedValueToolStripMenuItem})
        Me.InsuranceReportToolStripMenuItem.Image = CType(resources.GetObject("InsuranceReportToolStripMenuItem.Image"), Image)
        Me.InsuranceReportToolStripMenuItem.Name = "InsuranceReportToolStripMenuItem"
        Me.InsuranceReportToolStripMenuItem.Size = New Size(251, 22)
        Me.InsuranceReportToolStripMenuItem.Text = "Insurance Report"
        '
        'ByPurchasedValueToolStripMenuItem
        '
        Me.ByPurchasedValueToolStripMenuItem.Name = "ByPurchasedValueToolStripMenuItem"
        Me.ByPurchasedValueToolStripMenuItem.Size = New Size(177, 22)
        Me.ByPurchasedValueToolStripMenuItem.Text = "By Purchased Value"
        '
        'ByInsuredValueToolStripMenuItem
        '
        Me.ByInsuredValueToolStripMenuItem.Name = "ByInsuredValueToolStripMenuItem"
        Me.ByInsuredValueToolStripMenuItem.Size = New Size(177, 22)
        Me.ByInsuredValueToolStripMenuItem.Text = "By Insured Value"
        '
        'ByAppraisedValueToolStripMenuItem
        '
        Me.ByAppraisedValueToolStripMenuItem.Name = "ByAppraisedValueToolStripMenuItem"
        Me.ByAppraisedValueToolStripMenuItem.Size = New Size(177, 22)
        Me.ByAppraisedValueToolStripMenuItem.Text = "By Appraised Value"
        '
        'InsuraceReportWithTotalToolStripMenuItem
        '
        Me.InsuraceReportWithTotalToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.ByPurchasedValueToolStripMenuItem1, Me.ByInsuredValueToolStripMenuItem1, Me.ByAppraisedValueToolStripMenuItem1})
        Me.InsuraceReportWithTotalToolStripMenuItem.Image = CType(resources.GetObject("InsuraceReportWithTotalToolStripMenuItem.Image"), Image)
        Me.InsuraceReportWithTotalToolStripMenuItem.Name = "InsuraceReportWithTotalToolStripMenuItem"
        Me.InsuraceReportWithTotalToolStripMenuItem.Size = New Size(251, 22)
        Me.InsuraceReportWithTotalToolStripMenuItem.Text = "Insurance Report with Total"
        '
        'ByPurchasedValueToolStripMenuItem1
        '
        Me.ByPurchasedValueToolStripMenuItem1.Name = "ByPurchasedValueToolStripMenuItem1"
        Me.ByPurchasedValueToolStripMenuItem1.Size = New Size(177, 22)
        Me.ByPurchasedValueToolStripMenuItem1.Text = "By Purchased Value"
        '
        'ByInsuredValueToolStripMenuItem1
        '
        Me.ByInsuredValueToolStripMenuItem1.Name = "ByInsuredValueToolStripMenuItem1"
        Me.ByInsuredValueToolStripMenuItem1.Size = New Size(177, 22)
        Me.ByInsuredValueToolStripMenuItem1.Text = "By Insured Value"
        '
        'ByAppraisedValueToolStripMenuItem1
        '
        Me.ByAppraisedValueToolStripMenuItem1.Name = "ByAppraisedValueToolStripMenuItem1"
        Me.ByAppraisedValueToolStripMenuItem1.Size = New Size(177, 22)
        Me.ByAppraisedValueToolStripMenuItem1.Text = "By Appraised Value"
        '
        'CustomReportToolStripMenuItem
        '
        Me.CustomReportToolStripMenuItem.Image = CType(resources.GetObject("CustomReportToolStripMenuItem.Image"), Image)
        Me.CustomReportToolStripMenuItem.Name = "CustomReportToolStripMenuItem"
        Me.CustomReportToolStripMenuItem.Size = New Size(251, 22)
        Me.CustomReportToolStripMenuItem.Text = "Custom Report"
        '
        'BlankReportsToolStripMenuItem
        '
        Me.BlankReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.BoundBookToolStripMenuItem1, Me.ShootersCardToolStripMenuItem, Me.ShootersCardToolStripMenuItem1})
        Me.BlankReportsToolStripMenuItem.Name = "BlankReportsToolStripMenuItem"
        Me.BlankReportsToolStripMenuItem.Size = New Size(251, 22)
        Me.BlankReportsToolStripMenuItem.Text = "Blank Reports"
        '
        'BoundBookToolStripMenuItem1
        '
        Me.BoundBookToolStripMenuItem1.Name = "BoundBookToolStripMenuItem1"
        Me.BoundBookToolStripMenuItem1.Size = New Size(202, 22)
        Me.BoundBookToolStripMenuItem1.Text = "Bound Book"
        '
        'ShootersCardToolStripMenuItem
        '
        Me.ShootersCardToolStripMenuItem.Name = "ShootersCardToolStripMenuItem"
        Me.ShootersCardToolStripMenuItem.Size = New Size(202, 22)
        Me.ShootersCardToolStripMenuItem.Text = "Shooters Card w/ Target"
        '
        'ShootersCardToolStripMenuItem1
        '
        Me.ShootersCardToolStripMenuItem1.Name = "ShootersCardToolStripMenuItem1"
        Me.ShootersCardToolStripMenuItem1.Size = New Size(202, 22)
        Me.ShootersCardToolStripMenuItem1.Text = "Shooters Card"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {Me.OptionsToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.SearchCollectionToolStripMenuItem, Me.ShowDebugLogToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New Size(48, 20)
        Me.ToolsMenu.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = CType(resources.GetObject("OptionsToolStripMenuItem.Image"), Image)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New Size(173, 22)
        Me.OptionsToolStripMenuItem.Text = "&Settings"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), Image)
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New Size(173, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check For Updates"
        Me.CheckForUpdatesToolStripMenuItem.Visible = False
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.CleanUpToolStripMenuItem, Me.DataPreLoaderToolStripMenuItem, Me.ReRunHotfixUpdatesToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Image = CType(resources.GetObject("DatabaseToolStripMenuItem.Image"), Image)
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New Size(173, 22)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'CleanUpToolStripMenuItem
        '
        Me.CleanUpToolStripMenuItem.Image = CType(resources.GetObject("CleanUpToolStripMenuItem.Image"), Image)
        Me.CleanUpToolStripMenuItem.Name = "CleanUpToolStripMenuItem"
        Me.CleanUpToolStripMenuItem.Size = New Size(159, 22)
        Me.CleanUpToolStripMenuItem.Text = "C&lean-Up"
        '
        'DataPreLoaderToolStripMenuItem
        '
        Me.DataPreLoaderToolStripMenuItem.Image = CType(resources.GetObject("DataPreLoaderToolStripMenuItem.Image"), Image)
        Me.DataPreLoaderToolStripMenuItem.Name = "DataPreLoaderToolStripMenuItem"
        Me.DataPreLoaderToolStripMenuItem.Size = New Size(159, 22)
        Me.DataPreLoaderToolStripMenuItem.Text = "Data Pre-Loader"
        '
        'ReRunHotfixUpdatesToolStripMenuItem
        '
        Me.ReRunHotfixUpdatesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.RunToolStripMenuItem, Me.RedoAllToolStripMenuItem})
        Me.ReRunHotfixUpdatesToolStripMenuItem.Image = CType(resources.GetObject("ReRunHotfixUpdatesToolStripMenuItem.Image"), Image)
        Me.ReRunHotfixUpdatesToolStripMenuItem.Name = "ReRunHotfixUpdatesToolStripMenuItem"
        Me.ReRunHotfixUpdatesToolStripMenuItem.Size = New Size(159, 22)
        Me.ReRunHotfixUpdatesToolStripMenuItem.Text = "Hotfix Updates"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.Hotfix1ToolStripMenuItem, Me.Hotfix2ToolStripMenuItem, Me.Hotfix3ToolStripMenuItem, Me.Hotfix4ToolStripMenuItem, Me.Hotfix5ToolStripMenuItem, Me.Hotfix6ToolStripMenuItem, Me.Hotfix7ToolStripMenuItem, Me.Hotfix8ToolStripMenuItem, Me.Hotfix9ToolStripMenuItem})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New Size(118, 22)
        Me.RunToolStripMenuItem.Text = "Run "
        '
        'Hotfix1ToolStripMenuItem
        '
        Me.Hotfix1ToolStripMenuItem.Name = "Hotfix1ToolStripMenuItem"
        Me.Hotfix1ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix1ToolStripMenuItem.Text = "Hotfix 1"
        '
        'Hotfix2ToolStripMenuItem
        '
        Me.Hotfix2ToolStripMenuItem.Name = "Hotfix2ToolStripMenuItem"
        Me.Hotfix2ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix2ToolStripMenuItem.Text = "Hotfix 2"
        '
        'Hotfix3ToolStripMenuItem
        '
        Me.Hotfix3ToolStripMenuItem.Name = "Hotfix3ToolStripMenuItem"
        Me.Hotfix3ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix3ToolStripMenuItem.Text = "Hotfix 3"
        '
        'Hotfix4ToolStripMenuItem
        '
        Me.Hotfix4ToolStripMenuItem.Name = "Hotfix4ToolStripMenuItem"
        Me.Hotfix4ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix4ToolStripMenuItem.Text = "Hotfix 4"
        '
        'Hotfix5ToolStripMenuItem
        '
        Me.Hotfix5ToolStripMenuItem.Name = "Hotfix5ToolStripMenuItem"
        Me.Hotfix5ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix5ToolStripMenuItem.Text = "Hotfix 5"
        '
        'Hotfix6ToolStripMenuItem
        '
        Me.Hotfix6ToolStripMenuItem.Name = "Hotfix6ToolStripMenuItem"
        Me.Hotfix6ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix6ToolStripMenuItem.Text = "Hotfix 6"
        '
        'Hotfix7ToolStripMenuItem
        '
        Me.Hotfix7ToolStripMenuItem.Name = "Hotfix7ToolStripMenuItem"
        Me.Hotfix7ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix7ToolStripMenuItem.Text = "Hotfix 7"
        '
        'Hotfix8ToolStripMenuItem
        '
        Me.Hotfix8ToolStripMenuItem.Name = "Hotfix8ToolStripMenuItem"
        Me.Hotfix8ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix8ToolStripMenuItem.Text = "Hotfix 8"
        '
        'Hotfix9ToolStripMenuItem
        '
        Me.Hotfix9ToolStripMenuItem.Name = "Hotfix9ToolStripMenuItem"
        Me.Hotfix9ToolStripMenuItem.Size = New Size(115, 22)
        Me.Hotfix9ToolStripMenuItem.Text = "Hotfix 9"
        '
        'RedoAllToolStripMenuItem
        '
        Me.RedoAllToolStripMenuItem.Name = "RedoAllToolStripMenuItem"
        Me.RedoAllToolStripMenuItem.Size = New Size(118, 22)
        Me.RedoAllToolStripMenuItem.Text = "Redo All"
        '
        'SearchCollectionToolStripMenuItem
        '
        Me.SearchCollectionToolStripMenuItem.Image = CType(resources.GetObject("SearchCollectionToolStripMenuItem.Image"), Image)
        Me.SearchCollectionToolStripMenuItem.Name = "SearchCollectionToolStripMenuItem"
        Me.SearchCollectionToolStripMenuItem.Size = New Size(173, 22)
        Me.SearchCollectionToolStripMenuItem.Text = "Search Collection"
        '
        'ShowDebugLogToolStripMenuItem
        '
        Me.ShowDebugLogToolStripMenuItem.Name = "ShowDebugLogToolStripMenuItem"
        Me.ShowDebugLogToolStripMenuItem.Size = New Size(173, 22)
        Me.ShowDebugLogToolStripMenuItem.Text = "Show Debug Log"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New Size(151, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.MiscFirearmLinksToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.ToolStripSeparator12, Me.TechnicalSupportToolStripMenuItem, Me.ReportABugToolStripMenuItem, Me.KnowledgeBaseToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Image = CType(resources.GetObject("ContentsToolStripMenuItem.Image"), Image)
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((Keys.Control Or Keys.F1), Keys)
        Me.ContentsToolStripMenuItem.Size = New Size(175, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New Size(175, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New Size(175, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'MiscFirearmLinksToolStripMenuItem
        '
        Me.MiscFirearmLinksToolStripMenuItem.Image = CType(resources.GetObject("MiscFirearmLinksToolStripMenuItem.Image"), Image)
        Me.MiscFirearmLinksToolStripMenuItem.Name = "MiscFirearmLinksToolStripMenuItem"
        Me.MiscFirearmLinksToolStripMenuItem.Size = New Size(175, 22)
        Me.MiscFirearmLinksToolStripMenuItem.Text = "&Misc. Firearm Links"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New Size(172, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New Size(175, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Image = CType(resources.GetObject("RegisterToolStripMenuItem.Image"), Image)
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New Size(175, 22)
        Me.RegisterToolStripMenuItem.Text = "&Register"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Image = CType(resources.GetObject("PurchaseToolStripMenuItem.Image"), Image)
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New Size(175, 22)
        Me.PurchaseToolStripMenuItem.Text = "&Purchase"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New Size(172, 6)
        '
        'TechnicalSupportToolStripMenuItem
        '
        Me.TechnicalSupportToolStripMenuItem.Image = CType(resources.GetObject("TechnicalSupportToolStripMenuItem.Image"), Image)
        Me.TechnicalSupportToolStripMenuItem.Name = "TechnicalSupportToolStripMenuItem"
        Me.TechnicalSupportToolStripMenuItem.Size = New Size(175, 22)
        Me.TechnicalSupportToolStripMenuItem.Text = "Technical Support"
        '
        'ReportABugToolStripMenuItem
        '
        Me.ReportABugToolStripMenuItem.Image = CType(resources.GetObject("ReportABugToolStripMenuItem.Image"), Image)
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        Me.ReportABugToolStripMenuItem.Size = New Size(175, 22)
        Me.ReportABugToolStripMenuItem.Text = "Report a Bug"
        '
        'KnowledgeBaseToolStripMenuItem
        '
        Me.KnowledgeBaseToolStripMenuItem.Image = CType(resources.GetObject("KnowledgeBaseToolStripMenuItem.Image"), Image)
        Me.KnowledgeBaseToolStripMenuItem.Name = "KnowledgeBaseToolStripMenuItem"
        Me.KnowledgeBaseToolStripMenuItem.Size = New Size(175, 22)
        Me.KnowledgeBaseToolStripMenuItem.Text = "&Knowledge Base"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New Size(32, 32)
        Me.ToolStrip.Items.AddRange(New ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripButton6, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripButton15, Me.ToolStripButton13, Me.ToolStripButton2, Me.ToolStripSeparator9, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton14, Me.ToolStripButton12, Me.ToolStripSeparator16, Me.ToolStripButton3, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New Size(727, 39)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        Me.OpenToolStripButton.ImageTransparentColor = Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New Size(36, 36)
        Me.OpenToolStripButton.Text = "Open"
        Me.OpenToolStripButton.ToolTipText = "Restore Database"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        Me.SaveToolStripButton.ImageTransparentColor = Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New Size(36, 36)
        Me.SaveToolStripButton.Text = "Save"
        Me.SaveToolStripButton.ToolTipText = "Backup Database"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        Me.ToolStripButton6.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New Size(36, 36)
        Me.ToolStripButton6.Text = "Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "View Ammunition in My Collection"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), Image)
        Me.ToolStripButton9.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New Size(36, 36)
        Me.ToolStripButton9.Text = "Add Ammunition to the Collection"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), Image)
        Me.ToolStripButton10.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New Size(36, 36)
        Me.ToolStripButton10.Text = "View Wishlist"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), Image)
        Me.ToolStripButton11.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New Size(36, 36)
        Me.ToolStripButton11.Text = "Add Item to Wishlist!"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        Me.ToolStripButton5.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New Size(36, 36)
        Me.ToolStripButton5.Text = "View Maintenance Plan"
        Me.ToolStripButton5.ToolTipText = "View Maintenance Plan"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStrip_AddGun"
        Me.ToolStripButton1.ToolTipText = "Add Gun to Collection"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), Image)
        Me.ToolStripButton15.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New Size(36, 36)
        Me.ToolStripButton15.Text = "Firearm Gallery Picker"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), Image)
        Me.ToolStripButton13.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New Size(36, 36)
        Me.ToolStripButton13.Text = "Search Gun Collection"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStrip_DeleteGun"
        Me.ToolStripButton2.ToolTipText = "Delete Gun from Collection"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New Size(6, 39)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        Me.ToolStripButton7.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New Size(36, 36)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        Me.ToolStripButton7.ToolTipText = "Ammunition Inventory Report"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.DropDownItems.AddRange(New ToolStripItem() {Me.BoundBook1ToolStripMenuItem, Me.BoundBookVersion2ToolStripMenuItem})
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), Image)
        Me.ToolStripButton8.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New Size(48, 36)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        Me.ToolStripButton8.ToolTipText = "Bound Book Report"
        '
        'BoundBook1ToolStripMenuItem
        '
        Me.BoundBook1ToolStripMenuItem.Name = "BoundBook1ToolStripMenuItem"
        Me.BoundBook1ToolStripMenuItem.Size = New Size(190, 22)
        Me.BoundBook1ToolStripMenuItem.Text = "Bound Book Version 1"
        '
        'BoundBookVersion2ToolStripMenuItem
        '
        Me.BoundBookVersion2ToolStripMenuItem.Name = "BoundBookVersion2ToolStripMenuItem"
        Me.BoundBookVersion2ToolStripMenuItem.Size = New Size(190, 22)
        Me.BoundBookVersion2ToolStripMenuItem.Text = "Bound Book Version 2"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), Image)
        Me.ToolStripButton14.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New Size(36, 36)
        Me.ToolStripButton14.Text = "Documents"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), Image)
        Me.ToolStripButton12.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New Size(36, 36)
        Me.ToolStripButton12.Text = "Custom Report"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Application Updater"
        Me.ToolStripButton3.Visible = False
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        Me.HelpToolStripButton.ImageTransparentColor = Color.Fuchsia
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New Size(36, 36)
        Me.HelpToolStripButton.Text = "Help"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New ToolStripItem() {Me.tsslErrorsFound, Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New Point(0, 512)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New Size(727, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tsslErrorsFound
        '
        Me.tsslErrorsFound.AutoToolTip = True
        Me.tsslErrorsFound.DoubleClickEnabled = True
        Me.tsslErrorsFound.Enabled = False
        Me.tsslErrorsFound.Image = CType(resources.GetObject("tsslErrorsFound.Image"), Image)
        Me.tsslErrorsFound.Name = "tsslErrorsFound"
        Me.tsslErrorsFound.Size = New Size(16, 17)
        Me.tsslErrorsFound.ToolTipText = "Errors were detected in the Log File!"
        Me.tsslErrorsFound.Visible = False
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New Size(0, 17)
        '
        'Panel1
        '
        Me.Panel1.BackColor = SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lbltotalview)
        Me.Panel1.Controls.Add(Me.cmbView)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Dock = DockStyle.Left
        Me.Panel1.Location = New Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Size(161, 449)
        Me.Panel1.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New Point(41, 395)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New Size(0, 13)
        Me.lblTotal.TabIndex = 4
        '
        'lbltotalview
        '
        Me.lbltotalview.AutoSize = True
        Me.lbltotalview.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalview.Location = New Point(3, 382)
        Me.lbltotalview.Name = "lbltotalview"
        Me.lbltotalview.Size = New Size(130, 13)
        Me.lbltotalview.TabIndex = 3
        Me.lbltotalview.Text = "Total in Current View:"
        '
        'cmbView
        '
        Me.cmbView.FormattingEnabled = True
        Me.cmbView.Items.AddRange(New Object() {"ALL", "In Stock", "Class III", "C & R", "Non C & R", "Cust. Catalog #", "Sold/Stolen"})
        Me.cmbView.Location = New Point(6, 9)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New Size(141, 21)
        Me.cmbView.TabIndex = 2
        Me.cmbView.Text = "In Stock"
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ListStrip
        Me.ListBox1.DataSource = Me.GunCollectionBindingSource
        Me.ListBox1.DisplayMember = "FullName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New Point(6, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(141, 329)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "ID"
        '
        'ListStrip
        '
        Me.ListStrip.Items.AddRange(New ToolStripItem() {Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolStripSeparator5, Me.ViewDetailedReportToolStripMenuItem, Me.ViewFullDetailedReportToolStripMenuItem, Me.ViewGunSmithReportToolStripMenuItem, Me.ToolStripSeparator15, Me.DeleteToolStripMenuItem, Me.CopyFirearmToolStripMenuItem, Me.RenameDisplayNameToolStripMenuItem})
        Me.ListStrip.Name = "ListStrip"
        Me.ListStrip.Size = New Size(239, 192)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"), Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New Size(238, 22)
        Me.ViewToolStripMenuItem.Text = "&View Details"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New Size(238, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New Size(235, 6)
        '
        'ViewDetailedReportToolStripMenuItem
        '
        Me.ViewDetailedReportToolStripMenuItem.Image = CType(resources.GetObject("ViewDetailedReportToolStripMenuItem.Image"), Image)
        Me.ViewDetailedReportToolStripMenuItem.Name = "ViewDetailedReportToolStripMenuItem"
        Me.ViewDetailedReportToolStripMenuItem.Size = New Size(238, 22)
        Me.ViewDetailedReportToolStripMenuItem.Text = "View Detailed Report"
        '
        'ViewFullDetailedReportToolStripMenuItem
        '
        Me.ViewFullDetailedReportToolStripMenuItem.Image = CType(resources.GetObject("ViewFullDetailedReportToolStripMenuItem.Image"), Image)
        Me.ViewFullDetailedReportToolStripMenuItem.Name = "ViewFullDetailedReportToolStripMenuItem"
        Me.ViewFullDetailedReportToolStripMenuItem.Size = New Size(238, 22)
        Me.ViewFullDetailedReportToolStripMenuItem.Text = "View Complete Detailed Report"
        '
        'ViewGunSmithReportToolStripMenuItem
        '
        Me.ViewGunSmithReportToolStripMenuItem.Image = CType(resources.GetObject("ViewGunSmithReportToolStripMenuItem.Image"), Image)
        Me.ViewGunSmithReportToolStripMenuItem.Name = "ViewGunSmithReportToolStripMenuItem"
        Me.ViewGunSmithReportToolStripMenuItem.Size = New Size(238, 22)
        Me.ViewGunSmithReportToolStripMenuItem.Text = "View &Gun Smith Report"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New Size(235, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New Size(238, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'CopyFirearmToolStripMenuItem
        '
        Me.CopyFirearmToolStripMenuItem.Image = CType(resources.GetObject("CopyFirearmToolStripMenuItem.Image"), Image)
        Me.CopyFirearmToolStripMenuItem.Name = "CopyFirearmToolStripMenuItem"
        Me.CopyFirearmToolStripMenuItem.Size = New Size(238, 22)
        Me.CopyFirearmToolStripMenuItem.Text = "&Copy Firearm"
        '
        'RenameDisplayNameToolStripMenuItem
        '
        Me.RenameDisplayNameToolStripMenuItem.Name = "RenameDisplayNameToolStripMenuItem"
        Me.RenameDisplayNameToolStripMenuItem.Size = New Size(238, 22)
        Me.RenameDisplayNameToolStripMenuItem.Text = "&Rename Display Name"
        '
        'GunCollectionBindingSource
        '
        Me.GunCollectionBindingSource.DataMember = "Gun_Collection"
        Me.GunCollectionBindingSource.DataSource = Me.MGCDataSetBindingSource
        '
        'MGCDataSetBindingSource
        '
        Me.MGCDataSetBindingSource.DataSource = Me.MGCDataSet
        Me.MGCDataSetBindingSource.Position = 0
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
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(727, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "My Gun Collection"
        Me.WindowState = FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ListStrip.ResumeLayout(False)
        CType(Me.GunCollectionBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSetBindingSource, ISupportInitialize).EndInit()
        CType(Me.MGCDataSet, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsMenu As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MGCDataSetBindingSource As BindingSource
    Friend WithEvents MGCDataSet As MGCDataSet
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents AddManufacturerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPlaceOfOriginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GunCollectionBindingSource As BindingSource
    Friend WithEvents Gun_CollectionTableAdapter As Gun_CollectionTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmmunitionInventroyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMmunitionToMyCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickCollectionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmmunitionCollectionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents TechnicalSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportABugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KnowledgeBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents MaintancePlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintancePlanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ManufacturersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmmunitionTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaceOfOriginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListStrip As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ViewGunSmithReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents cmbView As ComboBox
    Friend WithEvents BoundBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ListedShopsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListedBuyersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents AddToWishlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WishlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintOutWishlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsuranceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByPurchasedValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByInsuredValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByAppraisedValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFirearmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameDisplayNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsslErrorsFound As ToolStripStatusLabel
    Friend WithEvents lbltotalview As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleanUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GripTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPreLoaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReRunHotfixUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents MiscFirearmLinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFirearmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ViewDetailedReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFullDetailedReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsuraceReportWithTotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByPurchasedValueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ByInsuredValueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ByAppraisedValueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents FirearmConditionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirearmTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlankReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoundBookToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuickCollectionReportWNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShootersCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShootersCardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowDebugLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListedGunsmithsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListedAppriasersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton8 As ToolStripSplitButton
    Friend WithEvents BoundBook1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoundBookVersion2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoundBookVersion1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BounfBookVersion2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFirearmClassificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents PickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hotfix9ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoAllToolStripMenuItem As ToolStripMenuItem

End Class
