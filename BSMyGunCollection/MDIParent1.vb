Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.hotixes.types
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.MsgBox
''' <summary>
''' Class MDIParent1.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class MDIParent1
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' The m child form number
    ''' </summary>
    Private _mChildFormNumber As Integer = 0
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
    ''' Converts to olbartoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each childForm As Form In MdiChildren
            childForm.Close()
        Next
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AmmToolStripMenuItem.Click
        Dim frmNew As New FrmAddAmmo
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmNew As New AboutBox1
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub GunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GunToolStripMenuItem.Click
        Dim frmNew As New FrmAddFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddModelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddModelToolStripMenuItem.Click
        Dim frmNew As New FrmAddModel
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddManufacturerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddManufacturerToolStripMenuItem.Click
        Dim frmNew As New FrmAddManufacturer
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddPlaceOfOriginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddPlaceOfOriginToolStripMenuItem.Click
        Dim frmNew As New FrmAddNationality
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionInventroyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AmmunitionInventroyToolStripMenuItem.Click
        frmViewAmmoInventory.MdiParent = Me
        frmViewAmmoInventory.Show()
    End Sub
 
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub QuickCollectionReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles QuickCollectionReportToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New FrmViewReport
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionCollectionReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AmmunitionCollectionReportToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Ammo
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ReportABugToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReportABugToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MenuBug
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub KnowledgeBaseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles KnowledgeBaseToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MenuWiki
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedShopsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ListedShopsToolStripMenuItem.Click
        frmViewShops.MdiParent = Me
        frmViewShops.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedBuyersToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ListedBuyersToolStripMenuItem.Click
        frmViewBuyers.MdiParent = Me
        frmViewBuyers.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub IndexToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles IndexToolStripMenuItem.Click
        Help.ShowHelpIndex(Me, MyHelpFile)
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PlaceOfOriginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PlaceOfOriginToolStripMenuItem.Click
        frmEditNationality.MdiParent = Me
        frmEditNationality.Show()
    End Sub

#End Region
#Region " Tool Strip Subs "
    ''' <summary>
    ''' Converts to olstripbutton2_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Call DoDelete()
        Call RefreshCollection()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New FrmAddFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    ''' <summary>
    ''' Converts to olstripbutton_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SaveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveToolStripButton.Click
        Call DoBackup()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call DoBackup()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton4_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        frmViewAmmoInventory.MdiParent = Me
        frmViewAmmoInventory.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MaintancePlanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MaintancePlanToolStripMenuItem.Click
        frmAddMaintancePlans.MdiParent = Me
        frmAddMaintancePlans.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MaintancePlanToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MaintancePlanToolStripMenuItem1.Click
        frmViewMaintancePlanList.MdiParent = Me
        frmViewMaintancePlanList.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton5_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton5.Click
        frmViewMaintancePlanList.MdiParent = Me
        frmViewMaintancePlanList.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ManufacturersToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManufacturersToolStripMenuItem.Click
        frmEditmanufactures.MdiParent = Me
        frmEditmanufactures.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AmmunitionTypeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AmmunitionTypeToolStripMenuItem.Click
        frmEditAmmunitionType.MdiParent = Me
        frmEditAmmunitionType.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ModelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ModelToolStripMenuItem.Click
        frmEditModel.MdiParent = Me
        frmEditModel.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Call DoHelp()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub HelpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HelpToolStripButton.Click
        Call DoHelp()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmSettings.MdiParent = Me
        frmSettings.Show()
    End Sub
    ''' <summary>
    ''' Converts to mycollectiontoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddMmunitionToMyCollectionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddMmunitionToMyCollectionToolStripMenuItem.Click
        Dim frmNew As New FrmAddCollectionAmmo
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim myValue As Long = ListBox1.SelectedValue
        Dim frmNew As New FrmViewCollectionDetails
        frmNew.MdiParent = Me
        frmNew.GunId = myValue
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim myValue As Long = ListBox1.SelectedValue
        Dim frmNew As New FrmEditCollectionDetails
        frmNew.ItemId = myValue
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call DoDelete()
        Call RefreshCollection()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton6_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton6.Click
        frmSettings.MdiParent = Me
        frmSettings.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton7_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton7.Click
        Cursor = Cursors.WaitCursor
        frmViewReport_Ammo.MdiParent = Me
        frmViewReport_Ammo.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewGunSmithReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewGunSmithReportToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim myValue As Long = ListBox1.SelectedValue
        frmViewReport_GunSmith.MdiParent = Me
        frmViewReport_GunSmith.Gid = myValue
        frmViewReport_GunSmith.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton9_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton9.Click
        Dim frmNew As New FrmAddCollectionAmmo
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton10_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton10.Click
        Dim frmNew As New frmViewWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton11_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton11.Click
        Dim frmNew As New FrmAddToWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to wishlisttoolstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddToWishlistToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddToWishlistToolStripMenuItem.Click
        Dim frmNew As New FrmAddToWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PrintOutWishlistToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintOutWishlistToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_WishList
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub WishlistToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WishlistToolStripMenuItem.Click
        Dim frmNew As New frmViewWishList
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByPurchasedValueToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByPurchasedValueToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByInsuredValueToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByInsuredValueToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_InsuredValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByAppraisedValueToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByAppraisedValueToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_ApprisedValue
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CopyFirearmToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyFirearmToolStripMenuItem.Click
        Try
            Dim itemId As Long = ListBox1.SelectedValue
            Dim frmNew As New FrmAddFirearm
            frmNew.IsCopy = True
            frmNew.CopyId = itemId
            frmNew.MdiParent = Me
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "CopyFirearmToolStripMenuItem.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region " Form Subs "

    ''' <summary>
    ''' Actions to perform when the application closes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        Try
            If DoAutoBackup Then
                Dim myProcess As New Process
                myProcess.StartInfo.FileName = ApplicationPath & "\" & MyBackup
                myProcess.StartInfo.Arguments = "/auto"
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                myProcess.Start()
            End If
            If Not RunningRegForm Then Application.Exit()
        Catch ex As Exception
            Call LogError(Name, "Disposed", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Actions to perform when the form loads up
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MDIParent1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowDebugLogToolStripMenuItem.Visible = DebugMode

        Try
            If OwnerInformation.LoginEnabled(DatabasePath, UseMyUid, UseMyPwd, UseMyForgotWord, UseMyForgotPhrase, _errOut) And Not IsLoggedIn Then
                Call Buggerme("mdiparent1.load", "Password Protected! Loading login for")
                frmLogin.Show()
            End If

            Lastviewedfirearm = 0
            OwnerId = OwnerInformation.GetOwnerId(DatabasePath, OwnerName, OwnerLic, _errOut)
            if _errOut.Length > 0 Then Throw New Exception(_errOut)

            Call Buggerme("mdiparent1.load", "Owner ID=" & OwnerId)
            Call Buggerme("mdiparent1.load", "Updating App Details")

            If Not MyRegistry.UpDateAppDetails(Application.ProductVersion,Application.ProductName,Application.ExecutablePath(),ApplicationPath,MyLogFile, DatabasePath, ApplicationPathData, _errOut) Then Throw New Exception(_errOut)
            Call Buggerme("mdiparent1.load", "Checking Registration for App")
            'This section was added to change to free version
            Call CheckBackup()
            RunningRegForm = False
            ToolStripStatusLabel.Text = ""
            ToolStripSeparator4.Visible = False
            'End of mock registration

            IsReady = True
            cmbView.Text = MyRegistry.GetViewSettings("VIEW_FirearmList",_errOut, "In Stock")
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Call Buggerme("mdiparent1.load", "View The Selected Collection: " & cmbView.Text)
            Call Buggerme("mdiparent1.load", "Refreshing Collection list")
            Call RefreshCollection()
            If OwnerId = 0 Then
                Dim frmNew As New FrmSettings
                frmNew.MdiParent = Me
                frmNew.Show()
            End If
            Dim hotfixList As List(Of HotFixList) = MyRegistry.GetHotxes(_errOut)

            For Each o As HotFixList In hotfixList
                if Not o.Id.Equals("LastUpdate") Then
                    Select o.Id
                        Case 10
                            Hotfix10ToolStripMenuItem.Enabled = False
                        Case 9
                            Hotfix9ToolStripMenuItem.Enabled = False
                        Case 8
                            Hotfix8ToolStripMenuItem.Enabled = False
                        Case 7
                            Hotfix7ToolStripMenuItem.Enabled = False
                        Case 6
                            Hotfix6ToolStripMenuItem.Enabled = False
                        Case 5
                            Hotfix5ToolStripMenuItem.Enabled = False
                        Case 4
                            Hotfix4ToolStripMenuItem.Enabled = False
                        Case 3
                            Hotfix3ToolStripMenuItem.Enabled = False
                        Case 2
                            Hotfix2ToolStripMenuItem.Enabled = False
                        Case 1
                            Hotfix1ToolStripMenuItem.Enabled = False
                    End Select    
                End If
            Next

            if BurnSoft.Applications.MGC.hotixes.HotFix.NeedsUpdate(DatabasePath, _errOut) Then
                Dim ans = MsgBox("Updates need to be applied. Apply Now?", MsgBoxStyle.YesNo, "Database Updates Required!")
                If ans.Equals(vbyes) Then
                    Dim applied As String = ""
                    If BurnSoft.Applications.MGC.hotixes.HotFix.ApplyMissingHotFixes(DatabasePath, _errOut, applied) Then
                        If applied.Length > 0 Then
                            MsgBox($"Applied Hotfix: {applied}")
                        Else 
                            MsgBox($"No Updates applied")
                        End If
                    Else 
                        Throw new Exception(_errOut)
                    End If
                End If

            End If
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Check when the last time a back was done
    ''' </summary>
    Sub CheckBackup()
        Try
    
            Dim lastSucBackup As String = ""
            Dim alertOnBackUp As Boolean
            Dim trackHistoryDays As Integer
            Dim trackHistory As Boolean
            MyRegistry.GetSettings(lastSucBackup, alertOnBackUp, trackHistoryDays, trackHistory, DoAutoBackup, DoOriginalImage, UsePetLoads, PersonalMark, UseNumberCatOnly, Auditammo, Useautoassign, Disableuniquecustcatid, Useselectiveboundbook, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            If Not alertOnBackUp Then Exit Sub
            Dim myLastDateDiff As Long = DateDiff(DateInterval.Day, CDate(lastSucBackup), DateTime.Now)
            Dim obj As New MsgClass
            If myLastDateDiff > trackHistoryDays Then obj.DoMessage("It has been " & myLastDateDiff & " days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Exclamantion, "Last Backup Notice", , True, "Backup Warning", False)
        Catch ex As Exception
            Call LogError(Name, "CheckBackup", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Select Item from Side List.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.DoubleClick
        Try
            Cursor = Cursors.WaitCursor
            Dim myValue As Long = ListBox1.SelectedValue
            Dim frmNew As New FrmViewCollectionDetails
            frmNew.MdiParent = Me
            frmNew.GunId = myValue
            frmNew.Show()
            Cursor = Cursors.Arrow
        Catch ex As Exception
            Call LogError(Name,"ListBox1.DoubleClick", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Resize event of the MDIParent1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub MDIParent1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Height <> 0 Then
            ListBox1.Height = Height - 188
            Dim p As Point
            p = New Point(lbltotalview.Location.X, ListBox1.Height + 35)
            lbltotalview.Location = p
            p = New Point(lblTotal.Location.X, lbltotalview.Location.Y + 13)
            lblTotal.Location = p
        End If
    End Sub
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the ComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbView.SelectedIndexChanged
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
        Dim childForm As New Form
        childForm.MdiParent = Me
        _mChildFormNumber += 1
        childForm.Text = $"Window " & _mChildFormNumber
        childForm.Show()
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
    ''' Clean up the Database
    ''' </summary>
    Sub DoDelete()
        Try
            Dim itemName As String = ListBox1.Text
            Dim itemId As Long = ListBox1.SelectedValue
            Dim strMsg As String = "Are you sure that you wish to delete " & itemName & " from your collection?"
            Dim bIsNotOld As Boolean = MyCollection.IsNotOldEnouthForDelete(DatabasePath, itemId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            If bIsNotOld Then strMsg = "BATFE recommends that you keep a record of the firearm for over 5 years of sale." & Chr(10) & strMsg
            Dim myAns As String = MsgBox(strMsg, MsgBoxStyle.YesNo, "Delete Firearm from Collection")
            If myAns = vbYes Then
                If Not MyCollection.Delete(DatabasePath, itemId, _errOut) Then Throw New Exception(_errOut)
                MsgBox(itemName & " was removed from your collection.", MsgBoxStyle.Information, "Deleted Item")
            End If
        Catch ex As Exception
            Dim strProcedure As String = "DoDelete"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
 
    ''' <summary>
    ''' Does the backup.
    ''' </summary>
    Sub DoBackup()
        Try
            DoAutoBackup = False
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = ApplicationPath & "\" & MyBackup
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            Close()
        Catch ex As Exception
            Dim strProcedure As String = "DoBackup"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Does the restore.
    ''' </summary>
    Sub DoRestore()
        Try
            DoAutoBackup = False
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = ApplicationPath & "\" & MyRestore
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            Close()
        Catch ex As Exception
            Dim strProcedure As String = "DoRestore"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
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
                    Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
                Case "IN STOCK"
                    Gun_CollectionTableAdapter.FillByInStock(MGCDataSet.Gun_Collection)
                Case "IN STOCK - LETHAL"
                    Gun_CollectionTableAdapter.FillByInStockLethal(MGCDataSet.Gun_Collection)
                Case "IN STOCK - NON-LETHAL"
                    Gun_CollectionTableAdapter.FillByInStockNonLethal(MGCDataSet.Gun_Collection)
                Case "COMPETITION"
                    Gun_CollectionTableAdapter.FillByCompetitionGuns(MGCDataSet.Gun_Collection)
                Case "SOLD/STOLEN"
                    Gun_CollectionTableAdapter.FillBySold(MGCDataSet.Gun_Collection)
                Case "C & R"
                    Gun_CollectionTableAdapter.FillByCandR(MGCDataSet.Gun_Collection)
                Case "NON C & R"
                    Gun_CollectionTableAdapter.FillByNonCAndR(MGCDataSet.Gun_Collection)
                Case UCase("Cust. Catalog #")
                    Gun_CollectionTableAdapter.FillBy_CustomIDList(MGCDataSet.Gun_Collection)
                Case UCase("Class III")
                    Gun_CollectionTableAdapter.FillBy_IsClassIII(MGCDataSet.Gun_Collection)
                Case Else
                    Gun_CollectionTableAdapter.FillByInStock(MGCDataSet.Gun_Collection)
            End Select
            ListBox1.Refresh()
            lblTotal.Text = ListBox1.Items.Count
            If Lastviewedfirearm > 0 Then ListBox1.SelectedValue = Lastviewedfirearm
            If IsReady Then If Not MyRegistry.SaveFirearmListSort(cmbView.SelectedItem.ToString, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim strProcedure As String = "RefreshCollection"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Show the help file
    ''' </summary>
    Sub DoHelp()
        Try
            Help.ShowHelp(Me, MyHelpFile)
        Catch ex As Exception
            Call LogError(Name, "DoHelp", Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub RenameDisplayNameToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RenameDisplayNameToolStripMenuItem.Click
        Try
            Dim itemName As String = ListBox1.Text
            Dim itemId As Long = ListBox1.SelectedValue
            Dim strNewName As String = InputBox("Type in the new name for " & itemName & ":", "Rename Firearm Display Name", itemName)
            If Len(strNewName) = 0 Then Exit Sub
            If Not MyCollection.RenameFullName(DatabasePath, itemId, FluffContent(strNewName), _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "RenameDisplayNameToolStripMenuItem.Click", Err.Number, ex.Message.ToString)
        End Try
        Call RefreshCollection()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBookToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BoundBookToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CleanUpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CleanUpToolStripMenuItem.Click
        Dim frmNew As New FrmDbCleanup
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub GripTypesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GripTypesToolStripMenuItem.Click
        Dim frmNew As New FrmViewGrips
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the tsslErrorsFound control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub tsslErrorsFound_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsslErrorsFound.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MyLogFile
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
    End Sub

    ''' <summary>
    ''' Res the run this host fix by identifier.
    ''' </summary>
    ''' <param name="myId">My identifier.</param>
    Sub ReRunThisHostFixbyId(myId As Integer)
        ApplyHotFix(myId)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CustomReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomReportToolStripMenuItem.Click
        Dim frmNew As New frmCR_SelectTable
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ImportFirearmToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ImportFirearmToolStripMenuItem.Click
        Dim frmNew As New FrmImportFirearm
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton12_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton12.Click
        Dim frmNew As New frmCR_SelectTable
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewDetailedReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewDetailedReportToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            If Not Pictures.HasDefaultPicture(DatabasePath, ListBox1.SelectedValue, ApplicationPath, DefaultPic, _errOut,true ) then Throw New Exception(_errOut)
            Dim frmNew As New frmViewReport_FirearmDetails
            frmNew.IntId = ListBox1.SelectedValue
            frmNew.MdiParent = Me
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ViewDetailedReportToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ViewFullDetailedReportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewFullDetailedReportToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            If Not Pictures.HasDefaultPicture(DatabasePath, ListBox1.SelectedValue, ApplicationPath, DefaultPic, _errOut,true ) then Throw New Exception(_errOut)
            Dim frmNew As New frmViewReport_FirearmDetailsFullDetails()
            frmNew.IntId = ListBox1.SelectedValue
            frmNew.MdiParent = Me
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ViewFullDetailedReportToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByPurchasedValueToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByPurchasedValueToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ByInsuredValueToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByInsuredValueToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_InsuredValue_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Menu Link to bring up report By Appriased Value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ByAppraisedValueToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ByAppraisedValueToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Insurance_ApprisedValue_wTotal
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
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
    Private Sub SearchCollectionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchCollectionToolStripMenuItem.Click
        Call RunSearch()
    End Sub
    ''' <summary>
    ''' Another link to run search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton13.Click
        Call RunSearch()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub FirearmConditionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FirearmConditionsToolStripMenuItem.Click
        Dim frmNew As New FrmEditGunConditions
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub FirearmTypesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FirearmTypesToolStripMenuItem.Click
        Dim frmNew As New FrmEditFirearmType
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBookToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BoundBookToolStripMenuItem1.Click
        Dim frmNew As New frmViewReport_Blank_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub QuickCollectionReportWNotesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles QuickCollectionReportWNotesToolStripMenuItem.Click
        Dim frmnew As New frmViewReport_Quickinv_w_DetailNotes
        frmnew.MdiParent = Me
        frmnew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ShootersCardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShootersCardToolStripMenuItem.Click
        Dim frmNew As New frmViewReport_Blank_ShootersCard
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ShootersCardToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShootersCardToolStripMenuItem1.Click
        Dim frmNew As New frmViewReport_Blank_ShootersCard2
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ShowDebugLogToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShowDebugLogToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "notepad.exe" 'Application.LocalUserAppDataPath.ToString & "\" & DEBUG_FILE
        myProcess.StartInfo.Arguments = Application.LocalUserAppDataPath.ToString & "\" & DebugFile
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.Start()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedGunsmithsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListedGunsmithsToolStripMenuItem.Click
        frmViewGunSmiths.MdiParent = Me
        frmViewGunSmiths.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ListedAppriasersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListedAppriasersToolStripMenuItem.Click
        frmViewAppraisers.MdiParent = Me
        frmViewAppraisers.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentToolStripMenuItem.Click
        Dim frmNew As New FrmAddDocument
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton8_buttonclick.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton8_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton8.ButtonClick
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBookVersion2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoundBookVersion2ToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook2
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBookVersion1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoundBookVersion1ToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BounfBookVersion2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BounfBookVersion2ToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook2
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ClassificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassificationToolStripMenuItem.Click
        Dim frmNew As New EditGunClassications
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub AddFirearmClassificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFirearmClassificationToolStripMenuItem.Click
        Dim frmNew As New FrmAddFirearmClassification
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        Call ViewDocuments()
    End Sub
    ''' <summary>
    ''' Views the documents.
    ''' </summary>
    Private Sub ViewDocuments()
        frmViewDocuments.MdiParent = Me
        frmViewDocuments.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton14_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Call ViewDocuments()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub PickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickerToolStripMenuItem.Click
        Call ShowFirearmGalleryPicker()
    End Sub
    ''' <summary>
    ''' Shows the firearm gallery picker.
    ''' </summary>
    Sub ShowFirearmGalleryPicker()
        frmFirearmImagePicker.MdiParent = Me
        frmFirearmImagePicker.Show()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton15_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        Call ShowFirearmGalleryPicker()
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub BoundBook1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoundBook1ToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_BoundBook
        frmNew.MdiParent = Me
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix1ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(1)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix2ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(2)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix3ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(3)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix4ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(4)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix5ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(5)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix6ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(6)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix7ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(7)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix8ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(8)
    End Sub
    ''' <summary>
    ''' Run Hotfix 9 menu Link
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Hotfix9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix9ToolStripMenuItem.Click
        Call ReRunThisHostFixbyId(9)
    End Sub
    ''' <summary>
    ''' Closes the connection.
    ''' </summary>
    Private Sub CloseConnection()
        MGCDataSet.Dispose()
        'GunCollectionBindingSource.Dispose()
        'MGCDataSetBindingSource.Dispose()
    End Sub
    
    ''' <summary>
    ''' Applies the hot fix.
    ''' </summary>
    ''' <param name="number">The number.</param>
    Private Sub ApplyHotFix(number As Integer)
        Try
            CloseConnection()
            If BurnSoft.Applications.MGC.hotixes.HotFix.Run(DatabasePath,number, _errOut) Then
                MsgBox($"Hotfix {number} was Applied!")
            Else 
                MsgBox(_errOut)
            End If
            RefreshCollection()
        Catch ex As Exception
            Call LogError(Name, $"ApplyHotfix_{number}", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Hotfix10ToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Hotfix10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hotfix10ToolStripMenuItem.Click
        ApplyHotFix(10)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DisablePasswordToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DisablePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisablePasswordToolStripMenuItem.Click
        CloseConnection()
        If BurnSoft.Applications.MGC.hotixes.HfDatabase.Security.RemovePassword(DatabasePath, _errOut) Then
            MsgBox("Password Removed")
        Else 
            MsgBox(_errOut)
        End If
        RefreshCollection()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EnablePasswordToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EnablePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnablePasswordToolStripMenuItem.Click
        CloseConnection()
        If BurnSoft.Applications.MGC.hotixes.HfDatabase.Security.AddPassword(DatabasePath, _errOut) Then
            MsgBox("Password Removed")
        Else 
            MsgBox(_errOut)
        End If
        RefreshCollection()
    End Sub
End Class
