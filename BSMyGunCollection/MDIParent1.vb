Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BSMyGunCollection.Cyhper
Imports BurnSoft.MsgBox
''' <summary>
''' Class MDIParent1.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class MDIParent1
    ''' <summary>
    ''' The m child form number
    ''' </summary>
    Private m_ChildFormNumber As Integer = 0
    ''' <summary>
    ''' Converts to try.
    ''' </summary>
    Public DaysLeftToTry As String
    ''' <summary>
    ''' The is ready
    ''' </summary>
    Public IsReady As Boolean = False
    ''' <summary>
    ''' The running reg form
    ''' </summary>
    Public RunningRegForm As Boolean
#Region " Menu Subs "
    ''' <summary>
    ''' Exit the Application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    ''' <summary>
    ''' Converts to olbartoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmmToolStripMenuItem.Click
        Dim frmNew As New frmAddAmmo
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmNew As New AboutBox1
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub GunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunToolStripMenuItem.Click
        Dim frmNew As New frmAddFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddModelToolStripMenuItem.Click
        Dim frmNew As New frmAddModel
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddManufacturerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddManufacturerToolStripMenuItem.Click
        Dim frmNew As New frmAddManufacturer
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddPlaceOfOriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPlaceOfOriginToolStripMenuItem.Click
        Dim frmNew As New frmAddNationality
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CollectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmNew As New frmViewReport
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Call CheckForUpdates()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionInventroyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmmunitionInventroyToolStripMenuItem.Click
        frmViewAmmoInventory.MdiParent = Me
        frmViewAmmoInventory.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionInventoryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmViewReport_Ammo.MdiParent = Me
        frmViewReport_Ammo.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub QuickCollectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickCollectionReportToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionCollectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmmunitionCollectionReportToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Ammo
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub TechnicalSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechnicalSupportToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_SUPPORT
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ReportABugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportABugToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_BUG
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub KnowledgeBaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnowledgeBaseToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_WIKI
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_SHOP
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedShopsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListedShopsToolStripMenuItem.Click
        frmViewShops.MdiParent = Me
        frmViewShops.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedBuyersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListedBuyersToolStripMenuItem.Click
        frmViewBuyers.MdiParent = Me
        frmViewBuyers.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexToolStripMenuItem.Click
        Help.ShowHelpIndex(Me, MY_HELP_FILE)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_SITESEARCH
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PlaceOfOriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaceOfOriginToolStripMenuItem.Click
        frmEditNationality.MdiParent = Me
        frmEditNationality.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        BSRegistration.StatusMessage = ToolStripStatusLabel.Text
        BSRegistration.Show()
    End Sub
#End Region
#Region " Tool Strip Subs "
    ''' <summary>
    ''' Converts to olstripbutton2_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Call DoDelete()
        Call RefreshCollection()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New frmAddFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton3_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Call CheckForUpdates()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Call DoBackup()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Call DoBackup()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton4_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmViewAmmoInventory.MdiParent = Me
        frmViewAmmoInventory.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MaintancePlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintancePlanToolStripMenuItem.Click
        frmAddMaintancePlans.MdiParent = Me
        frmAddMaintancePlans.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MaintancePlanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintancePlanToolStripMenuItem1.Click
        frmViewMaintancePlanList.MdiParent = Me
        frmViewMaintancePlanList.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton5_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmViewMaintancePlanList.MdiParent = Me
        frmViewMaintancePlanList.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ManufacturersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManufacturersToolStripMenuItem.Click
        frmEditmanufactures.MdiParent = Me
        frmEditmanufactures.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmmunitionTypeToolStripMenuItem.Click
        frmEditAmmunitionType.MdiParent = Me
        frmEditAmmunitionType.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelToolStripMenuItem.Click
        frmEditModel.MdiParent = Me
        frmEditModel.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Call DoHelp()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        Call DoHelp()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmSettings.MdiParent = Me
        frmSettings.Show()
    End Sub
    ''' <summary>
    ''' Converts to mycollectiontoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddMmunitionToMyCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMmunitionToMyCollectionToolStripMenuItem.Click
        Dim frmNew As New frmAddCollectionAmmo
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmViewCollectionDetails
        frmNew.MdiParent = Me
        frmNew.ItemID = MyValue
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim MyValue As Long = ListBox1.SelectedValue
        Dim frmNew As New frmEditCollectionDetails
        frmNew.ItemID = MyValue
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Call DoDelete()
        Call RefreshCollection()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton6_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmSettings.MdiParent = Me
        frmSettings.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton7_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.Cursor = Cursors.WaitCursor
        frmViewReport_Ammo.MdiParent = Me
        frmViewReport_Ammo.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewGunSmithReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewGunSmithReportToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim MyValue As Long = ListBox1.SelectedValue
        frmViewReport_GunSmith.MdiParent = Me
        frmViewReport_GunSmith.GID = MyValue
        frmViewReport_GunSmith.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton9_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        Dim frmNew As New frmAddCollectionAmmo
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton10_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Dim frmNew As New frmViewWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton11_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        Dim frmNew As New frmAddToWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to wishlisttoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddToWishlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToWishlistToolStripMenuItem.Click
        Dim frmNew As New frmAddToWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PrintOutWishlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOutWishlistToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_WishList
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub WishlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WishlistToolStripMenuItem.Click
        Dim frmNew As New frmViewWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByPurchasedValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPurchasedValueToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByInsuredValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByInsuredValueToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_InsuredValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByAppraisedValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAppraisedValueToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_ApprisedValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CopyFirearmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyFirearmToolStripMenuItem.Click
        Try
            Dim ItemName As String = ListBox1.Text
            Dim ItemID As Long = ListBox1.SelectedValue
            Dim frmNew As New frmAddFirearm
            frmNew.IsCopy = True
            frmNew.CopyID = ItemID
            frmNew.MdiParent = Me
            frmNew.Show()
        Catch ex As Exception
            Dim strProcedure As String = "CopyFirearmToolStripMenuItem.Click"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region " Form Subs "

    ''' <summary>
    ''' Actions to perform when the application closes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            If DoAutoBackup Then
                Dim myProcess As New Process
                myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_BACKUP
                myProcess.StartInfo.Arguments = "/auto"
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                myProcess.Start()
            End If
            If Not RunningRegForm Then Global.System.Windows.Forms.Application.Exit()
        Catch ex As Exception
            Dim strProcedure As String = "Disposed"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Actions to perform when the form loads up
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDebugLogToolStripMenuItem.Visible = DEBUG_MODE
        Dim iOS As Integer = Environment.OSVersion.Version.Major
        Try
            If LoginEnabled(UseMyPWD, UseMyUID, UseMyForgotWord, UseMyForgotPhrase) And Not IsLoggedIN Then
                Call Buggerme("mdiparent1.load", "Password Protected! Loading login for")
                frmLogin.Show()
            End If
            LASTVIEWEDFIREARM = 0
            Dim ObjR As New BSRegistry
            OwnerID = GetOwnerID()
            Call Buggerme("mdiparent1.load", "Owner ID=" & OwnerID)
            Call Buggerme("mdiparent1.load", "Updating App Details")
            ObjR.UpDateAppDetails()
            Call Buggerme("mdiparent1.load", "Checking Registration for App")
            'TODO: Remove this to allow free version
            'Call DoRegistrationProcessForApp()
            '#32 This section was added to change to free version
            RunningRegForm = False
            ToolStripStatusLabel.Text = ""
            RegisterToolStripMenuItem.Enabled = False
            RegisterToolStripMenuItem.Visible = False
            ToolStripSeparator4.Visible = False
            PurchaseToolStripMenuItem.Visible = False
            '#32 End of mock registration

            IsReady = True
            cmbView.Text = ObjR.GetViewSettings("VIEW_FirearmList", "In Stock")
            Call Buggerme("mdiparent1.load", "View The Selected Collection: " & cmbView.Text)
            Call Buggerme("mdiparent1.load", "Refreshing Collection list")
            Call RefreshCollection()
            If OwnerID = 0 Then
                Dim frmNew As New frmSettings
                frmNew.MdiParent = Me
                frmNew.Show()
            End If
        Catch ex As Exception
            Dim strProcedure As String = "Load"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Check when the last time a back was done
    ''' </summary>
    Sub CheckBackup()
        Try
            Dim ObjR As New BSRegistry
            Dim LastSucBackup As String = ""
            Dim AlertOnBackUp As Boolean
            Dim TrackHistoryDays As Integer
            Dim TrackHistory As Boolean
            Call ObjR.GetSettings(LastSucBackup, AlertOnBackUp, TrackHistoryDays, TrackHistory, DoAutoBackup, DoOriginalImage, UsePetLoads, PersonalMark, UseNumberCatOnly, AUDITAMMO, USEAUTOASSIGN, DISABLEUNIQUECUSTCATID, USESELECTIVEBOUNDBOOK)
            If Not AlertOnBackUp Then Exit Sub
            Dim MyLastDateDiff As Long = DateDiff(DateInterval.Day, CDate(LastSucBackup), DateTime.Now)
            Dim Obj As New MsgClass
            If MyLastDateDiff > TrackHistoryDays Then Obj.DoMessage("It has been " & MyLastDateDiff & " days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Exclamantion, "Last Backup Notice", , True, "Backup Warning", False)
        Catch ex As Exception
            Dim strProcedure As String = "CheckBackup"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Select Item from Side List.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim MyValue As Long = ListBox1.SelectedValue
            Dim frmNew As New frmViewCollectionDetails
            frmNew.MdiParent = Me
            frmNew.ItemID = MyValue
            frmNew.Show()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Dim strProcedure As String = "ListBox1.DoubleClick"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call RefreshCollection()
    End Sub
    Private Sub MDIParent1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> 0 Then
            ListBox1.Height = Me.Height - 188
            Dim p As New Point
            p = New Point(lbltotalview.Location.X, ListBox1.Height + 35)
            Me.lbltotalview.Location = p
            p = New Point(lblTotal.Location.X, lbltotalview.Location.Y + 13)
            Me.lblTotal.Location = p
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbView.SelectedIndexChanged
        Call RefreshCollection()
    End Sub
#End Region
#Region " General Subs and Functions "
    ''' <summary>
    ''' Show new form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim ChildForm As New System.Windows.Forms.Form
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    ''' <summary>
    ''' Perform restore
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Call DoRestore()
    End Sub
    ''' <summary>
    ''' Mark if the item was sold or not
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <returns></returns>
    Function IsNotOldEnough(ByVal strID As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT ItemSold, dtSold from qryGunCollectionDetails where ID=" & strID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim strDate As String = ""
            Dim IsSold As Integer = 0
            While RS.Read()
                If Not IsDBNull(RS("dtSold")) Then
                    strDate = RS("dtSold")
                Else
                    strDate = DateTime.Now.ToString
                End If
                IsSold = CInt(RS("ItemSold"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            If IsSold > 0 Then
                If DateDiff(DateInterval.Year, CDate(strDate), DateTime.Now) < 5 Then bAns = True
            End If
        Catch ex As Exception
            Dim strProcedure As String = "IsNotOldEnough"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Clean up the Database
    ''' </summary>
    Sub DoDelete()
        Try
            Dim ItemName As String = ListBox1.Text
            Dim ItemID As Long = ListBox1.SelectedValue
            Dim strMsg As String = "Are you sure that you wish to delete " & ItemName & " from your collection?"
            Dim bIsNotOld As Boolean = IsNotOldEnough(ItemID)
            If bIsNotOld Then strMsg = "BATFE recommends that you keep a record of the firearm for over 5 years of sale." & Chr(10) & strMsg
            Dim MyAns As String = MsgBox(strMsg, MsgBoxStyle.YesNo, "Delete Firearm from Collection")
            If MyAns = vbYes Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "DELETE from Gun_Collection where ID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE from Maintance_Details where GID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE from Gun_Collection_Pictures where CID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE from Gun_Collection_Accessories where GID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE from GunSmith_Details where GID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE from Gun_Collection_Ext where GID=" & ItemID
                Obj.ConnExec(SQL)
                SQL = "DELETE FROM Gun_Collection_Ext_Links where GID=" & ItemID
                Obj.ConnExec(SQL)
                MsgBox(ItemName & " was removed from your collection.", MsgBoxStyle.Information, "Deleted Item")
            End If
        Catch ex As Exception
            Dim strProcedure As String = "DoDelete"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub CheckForUpdates()
        Try
            DoAutoBackup = False
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_UPDATER
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            Me.Close()
        Catch ex As Exception
            Dim strProcedure As String = "CheckForUpdates"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub DoBackup()
        Try
            DoAutoBackup = False
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_BACKUP
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            Me.Close()
        Catch ex As Exception
            Dim strProcedure As String = "DoBackup"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub DoRestore()
        Try
            DoAutoBackup = False
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_RESTORE
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            Me.Close()
        Catch ex As Exception
            Dim strProcedure As String = "DoRestore"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Refresh the collection
    ''' </summary>
    Public Sub RefreshCollection()
        Try
            MGCDataSetBindingSource.ResetBindings(True)
            Select Case UCase(cmbView.SelectedItem.ToString)
                Case "ALL"
                    Me.Gun_CollectionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection)
                Case "IN STOCK"
                    Me.Gun_CollectionTableAdapter.FillByInStock(Me.MGCDataSet.Gun_Collection)
                Case "SOLD/STOLEN"
                    Me.Gun_CollectionTableAdapter.FillBySold(Me.MGCDataSet.Gun_Collection)
                Case "C & R"
                    Me.Gun_CollectionTableAdapter.FillByCandR(Me.MGCDataSet.Gun_Collection)
                Case "NON C & R"
                    Me.Gun_CollectionTableAdapter.FillByNonCAndR(Me.MGCDataSet.Gun_Collection)
                Case UCase("Cust. Catalog #")
                    Me.Gun_CollectionTableAdapter.FillBy_CustomIDList(Me.MGCDataSet.Gun_Collection)
                Case UCase("Class III")
                    Me.Gun_CollectionTableAdapter.FillBy_IsClassIII(Me.MGCDataSet.Gun_Collection)
                Case Else
                    Me.Gun_CollectionTableAdapter.FillByInStock(Me.MGCDataSet.Gun_Collection)
            End Select
            Me.ListBox1.Refresh()
            lblTotal.Text = Me.ListBox1.Items.Count
            If LASTVIEWEDFIREARM > 0 Then Me.ListBox1.SelectedValue = LASTVIEWEDFIREARM
            Dim ObjR As New BSRegistry
            If IsReady Then ObjR.SaveFirearmListSort(cmbView.SelectedItem.ToString)
        Catch ex As Exception
            Dim strProcedure As String = "RefreshCollection"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Show the help file
    ''' </summary>
    Sub DoHelp()
        Try
            Help.ShowHelp(Me, MY_HELP_FILE)
        Catch ex As Exception
            Dim strProcedure As String = "DoHelp"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub RenameDisplayNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameDisplayNameToolStripMenuItem.Click
        Try
            Dim ItemName As String = ListBox1.Text
            Dim ItemID As Long = ListBox1.SelectedValue
            Dim Obj As New BSDatabase
            Dim strNewName As String = InputBox("Type in the new name for " & ItemName & ":", "Rename Firearm Display Name", ItemName)
            If Len(strNewName) = 0 Then Exit Sub
            Dim sql As String = "UPDATE Gun_Collection set FullName='" & strNewName & "',sync_lastupdate=Now() where ID=" & ItemID
            Obj.ConnExec(sql)
            Call RefreshCollection()
        Catch ex As Exception
            Dim strProcedure As String = "RenameDisplayNameToolStripMenuItem.Click"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoundBookToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CleanUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanUpToolStripMenuItem.Click
        Dim frmNew As New frmDBCleanup
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub GripTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GripTypesToolStripMenuItem.Click
        Dim frmNew As New frmViewGrips
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the tsslErrorsFound control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub tsslErrorsFound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsslErrorsFound.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MyLogFile
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DataPreLoaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPreLoaderToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_DATALOADER
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Runs the hot fix.
    ''' </summary>
    Public Sub RunHotFix()
        DoAutoBackup = False
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_HOTFIX_FILE
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
        Global.System.Windows.Forms.Application.Exit()
        End
    End Sub
    ''' <summary>
    ''' Res the run hot fix updates.
    ''' </summary>
    Public Sub ReRunHotFixUpdates()
        DoAutoBackup = False
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_HOTFIX_FILE
        myProcess.StartInfo.Arguments = "/redo /debug"
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
        Application.Exit()
        End
    End Sub
    ''' <summary>
    ''' Res the run this host fixby identifier.
    ''' </summary>
    ''' <param name="myID">My identifier.</param>
    Sub ReRunThisHostFixbyID(myID As Integer)
        DoAutoBackup = False
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = APPLICATION_PATH & "\" & MY_HOTFIX_FILE
        myProcess.StartInfo.Arguments = "/hotfix=" & myID
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
        Application.Exit()
        End
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CustomReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomReportToolStripMenuItem.Click
        Dim frmNew As New frmCR_SelectTable
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MiscFirearmLinksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscFirearmLinksToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_LINKS
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ImportFirearmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportFirearmToolStripMenuItem.Click
        Dim frmNew As New frmImportFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton12_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Dim frmNew As New frmCR_SelectTable
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewDetailedReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDetailedReportToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Call CheckDefaultPic(ListBox1.SelectedValue)
        Dim frmNew As New frmViewReport_FirearmDetails
        frmNew.intID = ListBox1.SelectedValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewFullDetailedReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFullDetailedReportToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Call CheckDefaultPic(ListBox1.SelectedValue)
        Dim frmNew As New frmViewReport_FirearmDetailsFullDetails()
        frmNew.intID = ListBox1.SelectedValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByPurchasedValueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPurchasedValueToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByInsuredValueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByInsuredValueToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_InsuredValue_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Menu Link to bring up report By Appriased Value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ByAppraisedValueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAppraisedValueToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_ApprisedValue_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Menu Link to run search
    ''' </summary>
    Sub RunSearch()
        Dim frmNew As New frmSearch_Collection
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Menu link to search collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SearchCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCollectionToolStripMenuItem.Click
        Call RunSearch()
    End Sub
    ''' <summary>
    ''' Another link to run search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Call RunSearch()
    End Sub

    Private Sub FirearmConditionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirearmConditionsToolStripMenuItem.Click
        Dim frmNew As New frmEditGunConditions
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub FirearmTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirearmTypesToolStripMenuItem.Click
        Dim frmNew As New frmEditFirearmType
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub BoundBookToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoundBookToolStripMenuItem1.Click
        Dim frmNew As New frmViewReport_Blank_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub QuickCollectionReportWNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickCollectionReportWNotesToolStripMenuItem.Click
        Dim frmnew As New frmViewReport_Quickinv_w_DetailNotes
        frmnew.MdiParent = Me
        frmnew.Show()
    End Sub

    Private Sub ShootersCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShootersCardToolStripMenuItem.Click
        Dim frmNew As New frmViewReport_Blank_ShootersCard
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub ShootersCardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShootersCardToolStripMenuItem1.Click
        Dim frmNew As New frmViewReport_Blank_ShootersCard2
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub ShowDebugLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDebugLogToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "notepad.exe" 'Application.LocalUserAppDataPath.ToString & "\" & DEBUG_FILE
        myProcess.StartInfo.Arguments = Application.LocalUserAppDataPath.ToString & "\" & DEBUG_FILE
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
    End Sub
    Private Sub ListedGunsmithsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListedGunsmithsToolStripMenuItem.Click
        frmViewGunSmiths.MdiParent = Me
        frmViewGunSmiths.Show()
    End Sub

    Private Sub ListedAppriasersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListedAppriasersToolStripMenuItem.Click
        frmViewAppraisers.MdiParent = Me
        frmViewAppraisers.Show()
    End Sub

    Private Sub DocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DocumentToolStripMenuItem.Click
        Dim frmNew As New frmAddDocument
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    Private Sub ToolStripButton8_ButtonClick(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.ButtonClick
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BoundBookVersion2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoundBookVersion2ToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook2
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BoundBookVersion1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoundBookVersion1ToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BounfBookVersion2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BounfBookVersion2ToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook2
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ClassificationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassificationToolStripMenuItem.Click
        Dim frmNew As New EditGunClassications
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub AddFirearmClassificationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddFirearmClassificationToolStripMenuItem.Click
        Dim frmNew As New frmAddFirearmClassification
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DocumentsToolStripMenuItem.Click
        Call ViewDocuments()
    End Sub
    Private Sub ViewDocuments()
        frmViewDocuments.MdiParent = Me
        frmViewDocuments.Show()
    End Sub
    Private Sub ToolStripButton14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton14.Click
        Call ViewDocuments()
    End Sub

    Private Sub PickerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PickerToolStripMenuItem.Click
        Call ShowFirearmGalleryPicker()
    End Sub
    Sub ShowFirearmGalleryPicker()
        frmFirearmImagePicker.MdiParent = Me
        frmFirearmImagePicker.Show()
    End Sub
    Private Sub ToolStripButton15_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton15.Click
        Call ShowFirearmGalleryPicker()
    End Sub

    Private Sub BoundBook1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoundBook1ToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub RedoAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoAllToolStripMenuItem.Click
        Call ReRunHotFixUpdates()
    End Sub

    Private Sub Hotfix1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix1ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(1)
    End Sub

    Private Sub Hotfix2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix2ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(2)
    End Sub

    Private Sub Hotfix3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix3ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(3)
    End Sub

    Private Sub Hotfix4ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix4ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(4)
    End Sub

    Private Sub Hotfix5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix5ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(5)
    End Sub

    Private Sub Hotfix6ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix6ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(6)
    End Sub

    Private Sub Hotfix7ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix7ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(7)
    End Sub

    Private Sub Hotfix8ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix8ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(8)
    End Sub
    ''' <summary>
    ''' Run Hotfix 9 Mnue Link
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Hotfix9ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Hotfix9ToolStripMenuItem.Click
        Call ReRunThisHostFixbyID(9)
    End Sub
End Class
