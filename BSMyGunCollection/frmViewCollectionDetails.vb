Imports System.ComponentModel
Imports System.IO
Imports BSMyGunCollection.LogginAndSettings
Imports BurnSoft.Applications.MGC.Ammo
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmViewCollectionDetails.  Main form to view the firearm details
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewCollectionDetails
    ''' <summary>
    ''' The Gun Collection identifier
    ''' </summary>
    Public GunId As String
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopId As String
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' The update pending ass
    ''' </summary>
    Public UpdatePedningAss As Boolean
    ''' <summary>
    ''' The is sold
    ''' </summary>
    Public IsSold As Boolean
    ''' <summary>
    ''' The is stolen
    ''' </summary>
    Public IsStolen As Boolean
    ''' <summary>
    ''' The seller identifier
    ''' </summary>
    Public SellerId As String
    ''' <summary>
    ''' The bs has multi barrels
    ''' </summary>
    Public BsHasmultibarrels As Boolean
    ''' <summary>
    ''' The bs default barrel system id
    ''' </summary>
    Public BsDefaultbarrelsystemid As Long
    ''' <summary>
    ''' The update pending maint
    ''' </summary>
    Public UpdatePendingMaint As Boolean
    ''' <summary>
    ''' The is shot gun
    ''' </summary>
    Public IsShotGun As Boolean
    ''' <summary>
    ''' The has documents
    ''' </summary>
    Public HasDocuments As Boolean
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
#Region " General Form Subs "
    ''' <summary>
    ''' Handles the Disposed event of the frmViewCollectionDetails control. Save the form size to the config file so that it will be the same size when the user opens it back up
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewCollectionDetails_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        Try
            Dim objS As New ViewSizeSettings
            objS.SaveViewCollectionDetails(Height, Width, Location.X, Location.Y)
        Catch ex As Exception
            Call LogError(Name, "frmViewCollectionDetails_Disposed", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewCollectionDetails control.  When the form first opens load all the data
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewCollectionDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim objS As New ViewSizeSettings
            objS.LoadViewCollectionDetails(Height, Width, Location)
            Label42.Visible = UsePetLoads
            txtPetLoads.Visible = UsePetLoads
            Lastviewedfirearm = GunId
            If Len(GunId) <> 0 Then
                Call LoadData()
                If IsSold Or IsStolen Then
                    btnSold.Visible = False
                    btnStolen.Visible = False
                    btnFlyer.Visible = False
                    btnUnDoSale.Visible = True
                    btnPrintSale.Visible = True
                    If IsSold Then pbSold.Visible = True
                    If IsStolen Then pbStolen.Visible = True
                    lblSold.Visible = True
                    LoadSellerData()
                Else
                    btnPrintSale.Visible = False
                    pbSold.Visible = False
                    pbStolen.Visible = False
                    btnUnDoSale.Visible = False
                    lblSold.Visible = False
                End If
            Else
                Close()
            End If
        Catch ex As Exception
            Call LogError(Name, "frmViewCollectionDetails_Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Forms the is double tab. Action to take when the form is double clicked
    ''' </summary>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Private Function Form_IsDoubleTab() As Boolean
        Dim bAns As Boolean = False
        If TabControl1.Width < 1000 Then bAns = True
        Return bAns
    End Function
    ''' <summary>
    ''' Forms the set tab control. Set the size of the tab control 
    ''' </summary>
    ''' <param name="tabContentsAvgHeight">Average height of the tab contents.</param>
    ''' <param name="tabContentsAvgWidth">Average width of the tab contents.</param>
    Private Sub Form_SetTabContol(ByRef tabContentsAvgHeight As Long, ByRef tabContentsAvgWidth As Long)
        TabControl1.Width = Width - 5
        TabControl1.Height = Height - 60
        tabContentsAvgHeight = TabControl1.Height - 69
        tabContentsAvgWidth = TabControl1.Width - 27
    End Sub
    ''' <summary>
    ''' Forms the set data grids. Adjust the data grids on the form according to the form details, tabs footers, etc
    ''' to allow the form to be adjusted as well as the data below the grid to be viewable still.
    ''' </summary>
    ''' <param name="tabContentsAvgHeight">Average height of the tab contents.</param>
    ''' <param name="tabContentsAvgWidth">Average width of the tab contents.</param>
    Private Sub Form_SetDataGrids(tabContentsAvgHeight As Long, tabContentsAvgWidth As Long)
        Dim dataGridHeightWithFooter As Long
        dataGridHeightWithFooter = tabContentsAvgHeight - 57
        DataGridView1.Width = tabContentsAvgWidth
        DataGridView1.Height = dataGridHeightWithFooter
        DataGridView2.Width = tabContentsAvgWidth
        DataGridView2.Height = dataGridHeightWithFooter
        DataGridView3.Width = tabContentsAvgWidth
        DataGridView3.Height = dataGridHeightWithFooter
        DataGridView4.Width = tabContentsAvgWidth
        DataGridView4.Height = tabContentsAvgHeight
        DataGridView6.Width = tabContentsAvgWidth
        DataGridView6.Height = tabContentsAvgHeight - 20
    End Sub
    ''' <summary>
    ''' Forms the format accessories. set the size and form of the accessories tab
    ''' </summary>
    ''' <param name="defaultLabellocation">The default label location.</param>
    Private Sub Form_FormatAccessories(defaultLabellocation As Long)
        Dim newY As Integer 
        Dim oldX As Integer 
        'Accessories Totals X,Y Repositioning
        newY = DataGridView1.Height + defaultLabellocation
        oldX = Label51.Location.X
        Label51.Location = New Point(oldX, newY)
        oldX = lblTPV.Location.X
        lblTPV.Location = New Point(oldX, newY)
        oldX = Label52.Location.X
        Label52.Location = New Point(oldX, newY)
        oldX = lblTAV.Location.X
        lblTAV.Location = New Point(oldX, newY)
    End Sub
    ''' <summary>
    ''' Forms the format ammo. format the size and format of the Ammunition Tab
    ''' </summary>
    ''' <param name="defaultLabellocation">The default label location.</param>
    Private Sub Form_FormatAmmo(defaultLabellocation As Long)
        Dim newY As Integer 
        Dim oldX As Integer 
        'Ammunition Totals X,Y Repositioning
        newY = DataGridView2.Height + defaultLabellocation
        oldX = Label45.Location.X
        Label45.Location = New Point(oldX, newY)
        oldX = lblAmmoTotal.Location.X
        lblAmmoTotal.Location = New Point(oldX, newY)
    End Sub
    ''' <summary>
    ''' Forms the format maintenance. format the size and format of the Maintenance Tab
    ''' </summary>
    ''' <param name="defaultLabellocation">The default label location.</param>
    Private Sub Form_FormatMaintenance(defaultLabellocation As Long)
        Dim newY As Integer 
        Dim oldX As Integer 
        'Maintenance Totals X,Y Repositioning
        newY = DataGridView3.Height + defaultLabellocation
        oldX = Label46.Location.X
        Label46.Location = New Point(oldX, newY)
        oldX = lblTotalRndsFired.Location.X
        lblTotalRndsFired.Location = New Point(oldX, newY)
        oldX = Label47.Location.X
        Label47.Location = New Point(oldX, newY)
        oldX = lblAvgRndsFired.Location.X
        lblAvgRndsFired.Location = New Point(oldX, newY)
        oldX = Label50.Location.X
        Label50.Location = New Point(oldX, newY)
        oldX = lblTotalFirearm.Location.X
        lblTotalFirearm.Location = New Point(oldX, newY)
    End Sub
    ''' <summary>
    ''' Forms the format notes. format the size of the text box in the notes tab
    ''' </summary>
    ''' <param name="defaultNotes">The default notes.</param>
    ''' <param name="defaultNotesWidth">Default width of the notes.</param>
    Private Sub Form_FormatNotes(defaultNotes As Long, defaultNotesWidth As Long)
        txtConCom.Width = TabControl1.Width - defaultNotesWidth ' was 8
        txtConCom.Height = TabControl1.Height - defaultNotes
        txtAddNotes.Width = TabControl1.Width - defaultNotesWidth
        txtAddNotes.Height = TabControl1.Height - defaultNotes
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmViewCollectionDetails control. Action to take to re format all the details on the form when the Main form is resized
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewCollectionDetails_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Dim tabContentsAvgHeight As Long = 0
        Dim tabContentsAvgWidth As Long = 0
        Dim defaultLabellocation As Long = 48
        Dim defaultNotes As Long = 44
        Dim defaultNotesWidth As Long = 20
        If Form_IsDoubleTab() Then
            defaultLabellocation = defaultLabellocation - 6
            defaultNotes = defaultNotes + 10
        End If

        If Width > 0 Then
            Call Form_SetTabContol(tabContentsAvgHeight, tabContentsAvgWidth)
            Call Form_SetDataGrids(tabContentsAvgHeight, tabContentsAvgWidth)
            ListView1.Width = tabContentsAvgWidth
            ListView1.Height = tabContentsAvgHeight

            Dim newY As Integer = DataGridView1.Height + defaultLabellocation
            Dim oldX As Integer = btnEdit.Location.X
            btnEdit.Location = New Point(oldX, newY)
            oldX = btnExit.Location.X
            btnExit.Location = New Point(oldX, newY)
            Call Form_FormatAccessories(defaultLabellocation)
            Call Form_FormatAmmo(defaultLabellocation)
            Call Form_FormatMaintenance(defaultLabellocation)
            Call Form_FormatNotes(defaultNotes, defaultNotesWidth)
        End If
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the ListView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListView1.DoubleClick
        Dim myIndex As String = ListView1.FocusedItem.Index
        Dim myText As String = ListView1.Items(CInt(myIndex)).Text
        Dim frmNew As New frmViewPicture
        frmNew.MdiParent = MdiParent
        frmNew.MyId = CLng(myText)
        frmNew.GroupId = CLng(GunId)
        frmNew.Show()
    End Sub

#End Region
#Region " General Tab Sub and Functions "
    ''' <summary>
    ''' Handles the Enter event of the TabPage4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage4.Enter
        Gun_Collection_AccessoriesTableAdapter.FillBy(MGCDataSet.Gun_Collection_Accessories, GunId)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the mnuPicItem_Show control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub mnuPicItem_Show_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPicItem_Show.Click
        Dim myIndex As String = ListView1.FocusedItem.Index
        Dim myText As String = ListView1.Items(CInt(myIndex)).Text
        Dim frmNew As New frmViewPicture
        frmNew.MdiParent = MdiParent
        frmNew.MyId = CLng(myText)
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the mnuPicItem_Delete control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub mnuPicItem_Delete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPicItem_Delete.Click
        Try 
            Dim msgAns As String = MsgBox("Are you sure you want to delete this picture?", MsgBoxStyle.YesNo, "Delete Picture")
            If msgAns = vbYes Then
                Dim myIndex As String = ListView1.FocusedItem.Index
                Dim myText As String = ListView1.Items(CInt(myIndex)).Text
                If Not Pictures.Delete(DatabasePath, Convert.ToInt32(myText), _errOut) Then Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "mnuPicItem_Delete_Click", Err.Number, ex.Message.ToString)
        End Try
        Call GetPics()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the txtPurchasedFrom control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub txtPurchasedFrom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurchasedFrom.Click
        Dim newForm As New frmViewShopDetails
        newForm.ShopId = ShopId
        newForm.MdiParent = MdiParent
        newForm.Show()
    End Sub
    ''' <summary>
    ''' Handles the Enter event of the TabPage3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage3.Enter
        Call GetPics()
    End Sub
    Private Sub TabPage6_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage6.Enter
        Call LoadAmmoData()
    End Sub
    Private Sub TabPage7_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage7.Enter
        Call LoadMaintData()
    End Sub
    Private Sub TabPage8_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage8.Enter
        Try
            GunSmith_DetailsTableAdapter.FillBy(MGCDataSet.GunSmith_Details, GunId)
        Catch ex As Exception
            Dim sSubFunc As String = "TabPage8.Enter.Gunsmith.Details"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region " Button Subs "
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        frmAddPicture.ItemId = GunId
        frmAddPicture.MdiParent = MdiParent
        frmAddPicture.Show()
    End Sub
    Private Sub btnAddAccess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAccess.Click
        Dim frmNew As New FrmAddAccessory
        frmNew.MdiParent = MdiParent
        frmNew.ItemId = GunId
        frmNew.IsShotGun = IsShotGun
        frmNew.Show()
    End Sub
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        Gun_Collection_AccessoriesTableAdapter.FillBy(MGCDataSet.Gun_Collection_Accessories, GunId)
        Call LoadAddAccessories()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Dim frmNew As New FrmEditCollectionDetails
        frmNew.ItemId = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
    Private Sub btnAddAmmo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAmmo.Click
        Dim frmNew As New FrmAddCollectionAmmo
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call LoadAmmoData()
    End Sub
    Private Sub btnRefreshPics_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshPics.Click
        Call GetPics()
    End Sub
    Private Sub btnAddMain_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddMain.Click
        frmAddMaintance.MdiParent = MdiParent
        frmAddMaintance.Gid = GunId
        frmAddMaintance.Bsid = BsDefaultbarrelsystemid
        frmAddMaintance.AmmoType = txtCal.Text
        frmAddMaintance.AmmoTypePet = txtPetLoads.Text
        frmAddMaintance.AmmoTypeCal3 = txtCaliber3.Text
        frmAddMaintance.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Call LoadMaintData()
    End Sub
    Private Sub btnGSLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGSLog.Click
        frmAddGunSmithLog.MdiParent = MdiParent
        frmAddGunSmithLog.Gid = GunId
        frmAddGunSmithLog.Show()
    End Sub
    Private Sub btnGSReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGSReport.Click
        Cursor = Cursors.WaitCursor
        frmViewReport_GunSmith.MdiParent = MdiParent
        frmViewReport_GunSmith.Gid = GunId
        frmViewReport_GunSmith.Title = Text
        frmViewReport_GunSmith.Show()
        Cursor = Cursors.Arrow
    End Sub
    Private Sub btnRefreshGS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshGS.Click
        GunSmith_DetailsTableAdapter.FillBy(MGCDataSet.GunSmith_Details, GunId)
    End Sub
    Private Sub btnPrintPreviewMaintanceReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintPreviewMaintanceReport.Click
        Cursor = Cursors.WaitCursor
        Dim newForm As New FrmViewReportMaintenance
        newForm.MdiParent = MdiParent
        newForm.MyGid = GunId
        newForm.Title = Text
        newForm.Show()
        Cursor = Cursors.Arrow
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFlyer.Click
        Dim frmNew As New FrmForSale
        frmNew.MdiParent = MdiParent
        frmNew.MyId = GunId
        frmNew.Show()
    End Sub
    Private Sub btnSold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSold.Click
        Dim frmNew As New FrmSold
        frmNew.MdiParent = MdiParent
        frmNew.ItemId = GunId
        frmNew.Show()
        Close()
    End Sub
    Private Sub btnUnDoSale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnDoSale.Click
        Try
            Dim meAns As String = MsgBox("Are you sure you want to undo this sale?", MsgBoxStyle.YesNo, Text)
            If meAns = vbYes Then
                If Not MyCollection.UnMarkAsStolenOrSold(DatabasePath, GunId, _errOut) Then Throw New Exception(_errOut)
                MDIParent1.RefreshCollection()
                Close()
            End If
        Catch ex As Exception
            Call LogError(Name, "btnUnDoSale_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region " General Subs "
    ''' <summary>
    ''' Loads the ammo data. Load the Ammo collection tab based on the calibers listed in the main details page
    ''' </summary>
    Sub LoadAmmoData()
        Try
            If Len(txtPetLoads.Text) = 0 And Len(txtCaliber3.Text) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillBy(MGCDataSet.Gun_Collection_Ammo, txtCal.Text)
                lblAmmoTotal.Text = Inventory.TotalAmmoSelected(DatabasePath,txtCal.Text, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet(MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text)
                lblAmmoTotal.Text = Inventory.TotalAmmoSelected(DatabasePath,txtCal.Text,txtPetLoads.Text, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) > 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet3(MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text, txtCaliber3.Text)
                lblAmmoTotal.Text = Inventory.TotalAmmoSelected(DatabasePath,txtCal.Text,txtPetLoads.Text,txtCaliber3.Text, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "LoadAmmoData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the maint data. Load the maintenance data, also check to see if there are other barrels attached which will affect
    ''' the total rounds fired count base on the count from the barrel vs the count form the receiver
    ''' </summary>
    Sub LoadMaintData()
        Try
            If Not BsHasmultibarrels Then
                Maintance_DetailsTableAdapter.FillBy(MGCDataSet.Maintance_Details, GunId)
                Label50.Visible = False
                lblTotalFirearm.Visible = False
                lblTotalRndsFired.Text = MaintanceDetails.TotalRoundsFired(DatabasePath, GunId, _errOut)
                If _errOut.Length > 0 And Not _errOut.Equals("Object cannot be cast from DBNull to other types") Then Throw New Exception(_errOut)
                lblAvgRndsFired.Text = MaintanceDetails.AverageRoundsFired(DatabasePath, GunId, _errOut)
                If _errOut.Length > 0 And Not _errOut.Equals("Object cannot be cast from DBNull to other types") Then Throw New Exception(_errOut)
            Else
                Maintance_DetailsTableAdapter.FillBy_BSID(MGCDataSet.Maintance_Details, GunId, BsDefaultbarrelsystemid)
                Label50.Visible = True
                lblTotalFirearm.Visible = True

                lblTotalFirearm.Text = MaintanceDetails.TotalRoundsFired(DatabasePath, GunId, _errOut)  
                If _errOut.Length > 0 And Not _errOut.Equals("Object cannot be cast from DBNull to other types") Then Throw New Exception(_errOut)
                lblTotalRndsFired.Text = MaintanceDetails.TotalRoundsFiredBs(DatabasePath, BsDefaultbarrelsystemid, _errOut)
                If _errOut.Length > 0 And Not _errOut.Equals("Object cannot be cast from DBNull to other types") Then Throw New Exception(_errOut)
                lblAvgRndsFired.Text = MaintanceDetails.AverageRoundsFiredBs(DatabasePath, BsDefaultbarrelsystemid, _errOut)
                If _errOut.Length > 0 And Not _errOut.Equals("Object cannot be cast from DBNull to other types") Then Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "LoadMaintData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Populate the selling information in the disposition tab.
    Sub LoadSellerData()
        Try
            Dim lst as List (Of BuyersList) = Buyers.Get(DatabasePath,Convert.ToInt32(SellerId), _errOut )
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each l As BuyersList In lst
                txtName.Text = l.Name
                txtAddress1.Text = l.Address1
                txtAddress2.Text = l.Address2
                txtCity.Text = l.City
                txtZip.Text = l.ZipCode
                txtState.Text = l.State
                txtPhone.Text = l.Phone
                txtCountry.Text = l.Country
                txtFax.Text = l.Fax
                txteMail.Text = l.Email
                txtWebSite.Text = l.WebSite
                txtLic.Text = l.Lic
                txtDLic.Text = l.Dlic
                txtDOB.Text = l.Dob
                txtRes.Text = l.Resident
            Next
        Catch ex As Exception
            Call LogError(Name, "LoadSellerData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the add accessories. Load the Accessories and total up the cost of the accessories and the total appriased value
    ''' </summary>
    Sub LoadAddAccessories()
        lblTPV.Text = Accessories.SumUpPurchaseValue(DatabasePath, Convert.ToInt32(GunId), _errOut)
        lblTAV.Text = Accessories.SumUpAppriaseValue(DatabasePath, Convert.ToInt32(GunId), _errOut)
    End Sub
    ''' <summary>
    ''' Adds the choke option.  When a shotgun is selected, add the ability to put in what choke is in the firearm
    ''' But in order to do that, there are fields that need to be moved around just to keep things in order 
    ''' and try to keep the flow of data input relevant to the user.
    ''' </summary>
    Sub AddChokeOption()
        Label53.Location = New Point(Label27.Location.X, Label27.Location.Y)
        txtChoke.Location = New Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label53.Visible = True
        txtChoke.Visible = True

        Dim moveDownXPoints As Integer = 26
        Dim newY As Integer = txtStorage.Location.Y + moveDownXPoints
        Dim oldX As Integer = txtStorage.Location.X
        txtStorage.Location = New Point(oldX, newY)
        oldX = Label27.Location.X
        Label27.Location = New Point(oldX, newY)
        newY = Label9.Location.Y + moveDownXPoints
        oldX = Label9.Location.X
        Label9.Location = New Point(oldX, newY)
        oldX = txtFinish.Location.X
        txtFinish.Location = New Point(oldX, newY)
        newY = Label6.Location.Y + moveDownXPoints
        oldX = Label6.Location.X
        Label6.Location = New Point(oldX, newY)
        oldX = txtNationality.Location.X
        txtNationality.Location = New Point(oldX, newY)
        newY = Label13.Location.Y + moveDownXPoints
        oldX = Label13.Location.X
        Label13.Location = New Point(oldX, newY)
        oldX = txtWeight.Location.X
        txtWeight.Location = New Point(oldX, newY)
        newY = Label14.Location.Y + moveDownXPoints
        oldX = Label14.Location.X
        Label14.Location = New Point(oldX, newY)
        oldX = txtLength.Location.X
        txtLength.Location = New Point(oldX, newY)
        newY = Label15.Location.Y + moveDownXPoints
        oldX = Label15.Location.X
        Label15.Location = New Point(oldX, newY)
        oldX = txtBarLen.Location.X
        txtBarLen.Location = New Point(oldX, newY)
    End Sub
    ''' <summary>
    ''' Loads the data. Start Loading data for the form
    ''' </summary>
    Sub LoadData()
        Try
            Call LoadAddAccessories()

            'Check to see if the firearm has extra barrels, if not remove the tab, otherwise populate the table.
            BsHasmultibarrels = ExtraBarrelConvoKits.HasMultiBarrelsListed(DatabasePath, GunId, _errOut)
            if _errOut.Length >0 Then Throw New Exception(_errOut)
            BsDefaultbarrelsystemid = ExtraBarrelConvoKits.GetDefaultBarrelId(DatabasePath, GunId, _errOut)
            if _errOut.Length >0 Then Throw New Exception(_errOut)

            If Not BsHasmultibarrels Then
                TabControl1.TabPages.Remove(TabPage10)
            Else
                Gun_Collection_ExtTableAdapter.FillBy_GID(MGCDataSet.Gun_Collection_Ext, GunId)
                DataGridView5.Columns(0).Visible = False
            End If
            'Check to see if there are documents attached, if not remove the tab, otherwise populate the tab.
            HasDocuments = Documents.HasDocumentsAttached(DatabasePath, GunId, _errOut)
            BsDefaultbarrelsystemid = ExtraBarrelConvoKits.GetDefaultBarrelId(DatabasePath, GunId, _errOut)

            If Not HasDocuments Then
                TabControl1.TabPages.Remove(TabPage12)
            Else
                Qry_DocsAndLinksTableAdapter.FillBy_GID(MGCDataSet.qry_DocsAndLinks, GunId)

            End If

            Dim lst as List(Of GunCollectionList) = MyCollection.GetList(DatabasePath, GunId, _errOut)
            if _errOut.Length >0 Then Throw New Exception(_errOut)

            For Each l As GunCollectionList In lst
                Text = l.FullName
                txtManu.Text = l.Manufacturer
                txtModel.Text  = l.ModelName
                txtSerial.Text = l.SerialNumber
                txtType.Text = l.Type
                IsShotGun = l.IsShotGun
                If IsShotGun Then
                    txtChoke.Text = l.ShotGunChoke
                    Call AddChokeOption()
                End If
                txtCal.Text = l.Caliber
                txtFinish.Text = l.Finish
                txtCondition.Text = l.Condition
                txtPetLoads.Text = l.PetLoads
                txtNationality.Text = l.Nationality
                txtWeight.Text = l.Weight
                txtLength.Text = l.Height
                txtBarLen.Text = l.BarrelLength
                txtBarWid.Text = l.BarrelWidth
                txtBarHei.Text = l.BarrelHeight
                txtCustCatID.Text = l.CustomId
                txtGripType.Text = l.GripType
                txtProduced.Text = l.DateProduced
                txtAction.Text = l.Action
                txtFeed.Text = l.FeedSystem
                txtSights.Text = l.Sights
                txtStorage.Text = l.StorageLocation
                txtPurchasedFrom.Text = l.PurchaseFrom
                txtPurPrice.Text = l.PurchasePrice
                txtImporter.Text = l.Importer
                txtChoke.Text =l.ShotGunChoke
                chkBoundBook.Checked = l.IsInBoundBook
                txtTwistOfRate.Text = l.TwistRate
                txtTriggerPull.Text = l.TriggerPullInPounds
                txtCaliber3.Text = l.Caliber3
                txtClassification.Text = l.Classification

                If l.DateOfCAndR.Length > 0 Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = l.DateOfCAndR
                    dtpDateofCR.Enabled = True
                End If
                dtpDateofCR.Enabled = False

                chkClassIII.Checked = l.IsClass3Item
                chkBoxCR.Checked = l.IsCAndR

                if l.RemanufactureDate.Length > 0 Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = l.RemanufactureDate
                    dtpReManDT.Enabled = True
                End If
                dtpReManDT.Enabled = False

                If l.DateTimeAdded.Length > 0 Then
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = l.DateTimeAdded
                    dtpPurchased.Enabled = False
                Else 
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = l.DateTimeAddedInDb
                    dtpPurchased.Enabled = False
                End If

                txtAppValue.Text = l.AppriasedValue
                ShopId = l.Sid
                If l.AppraisalDate.Length > 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = l.AppraisalDate
                    dtpAppDate.Enabled = False
                End If

                txtAppBy.Text = l.AppriasedBy
                txtInsVal.Text = l.InsuredValue
                txtConCom.Text = l.ConditionComments
                txtAddNotes.Text = l.AdditionalNotes
                SellerId = l.Bid
                lblSold.Text = $"on {l.DateSold}"
                IsSold = l.WasSold
                IsStolen = l.WasStolen
                chkNonLethal.Checked = l.IsNonLethal
                chkIsCompeition.Checked = l.IsCompetition
            Next

            Refresh()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the pics.
    ''' </summary>
    Public Sub GetPics()
        Try
            ListView1.Clear()
            imgPics.Images.Clear()
            Dim i As Long = 1
            Dim lst as List(Of PictureDetails) = Pictures.GetList(DatabasePath, GunId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each o As PictureDetails In lst
                GetPicsId(o.Id, i)
                i = i + 1
            Next
        Catch ex As Exception
            Call LogError(Name, "GetPics", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the pics identifier.
    ''' </summary>
    ''' <param name="picId">The pic identifier.</param>
    ''' <param name="i">The i.</param>
    Sub GetPicsId(ByVal picId As Long, ByVal i As Long)
        Try
            Dim b() As Byte = Pictures.GetThumbnailPicture(DatabasePath, picId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                DrawToScale(New Bitmap(stream), i, picId)
                stream.Close()
            End If
        Catch ex As Exception
            Call LogError(Name, "GetPicsID", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Draws to scale.
    ''' </summary>
    ''' <param name="bmp">The BMP.</param>
    ''' <param name="imgindex">The img index.</param>
    ''' <param name="imgId">The img identifier.</param>
    Private Sub DrawToScale(ByVal bmp As Image, ByVal imgindex As Integer, ByVal imgId As Long)
        PictureBox1.Image = New Bitmap(bmp)
        imgPics.Images.Add(New Bitmap(bmp))

        ListView1.LargeImageList = imgPics
        ListView1.View = View.LargeIcon

        Dim osItem As ListViewItem.ListViewSubItem
        Dim oitem As ListViewItem = New ListViewItem
        oitem.Text = imgId
        osItem = New ListViewItem.ListViewSubItem
        osItem.Text = imgId
        oitem.SubItems.Add(osItem)
        ListView1.Items.Add(oitem)
        oitem.ImageIndex = imgindex - 1
    End Sub

#End Region
#Region " Data Object Subs "
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If UpdatePedningAss Then
            Gun_Collection_AccessoriesTableAdapter.Update(MGCDataSet.Gun_Collection_Accessories)
            UpdatePedningAss = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunCollectionAmmoBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionAmmoBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCollectionAmmoBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePending = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the RowValidated event of the DataGridView2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView2_RowValidated(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.RowValidated
        If UpdatePending Then
            Gun_Collection_AmmoTableAdapter.Update(MGCDataSet.Gun_Collection_Ammo)
            UpdatePending = False
        End If
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the GunCollectionAccessoriesBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub GunCollectionAccessoriesBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles GunCollectionAccessoriesBindingSource.ListChanged
        If MGCDataSet.HasChanges Then
            UpdatePedningAss = True
        End If
    End Sub
    ''' <summary>
    ''' Handles the CellContentDoubleClick event of the DataGridView3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView3_CellContentDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        Call RunEditMaintenance()
    End Sub
    ''' <summary>
    ''' Handles the Validated event of the DataGridView3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView3.Validated
        Try
            If UpdatePendingMaint Then
                Maintance_DetailsTableAdapter.Update(MGCDataSet.Maintance_Details)
                UpdatePendingMaint = False
            End If
        Catch ex As Exception
            Call LogError(Name,  "DataGridView3_Validated", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the ListChanged event of the MaintanceDetailsBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
    Private Sub MaintanceDetailsBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles MaintanceDetailsBindingSource.ListChanged
        Try
            If MGCDataSet.HasChanges Then
                UpdatePendingMaint = True
            End If
        Catch ex As Exception
            Call LogError(Name, "MaintanceDetailsBindingSource_ListChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Validated event of the DataGridView4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView4_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView4.Validated
        Try
            If UpdatePending Then
                GunSmith_DetailsTableAdapter.Update(MGCDataSet.GunSmith_Details)
                UpdatePending = False
            End If
        Catch ex As Exception
            Call LogError(Name, "DataGridView4_Validated", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the CurrentChanged event of the GunSmithDetailsBindingSource control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub GunSmithDetailsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GunSmithDetailsBindingSource.CurrentChanged
        Try
            If MGCDataSet.HasChanges Then
                UpdatePending = True
            End If
        Catch ex As Exception
            Call LogError(Name, "GunSmithDetailsBindingSource_CurrentChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "XML Export Functions"
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Try
            Dim defaultFileName As String = "ExportFirearm_" & Text & ".xml"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.Filter = $"XML File(*.xml)|*.xml"
            SaveFileDialog1.Title = $"Export Data to XML File"
            SaveFileDialog1.FileName = Replace(Replace(Replace(defaultFileName, " ", "_"), "/", "-"), "\", "-")
            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = SaveFileDialog1.FileName
            Dim appVersion as String = String.Format("App Version {0}", Application.ProductVersion.ToString) & $"  ,  " & String.Format("DB Version {0}", DatabaseRelated.GetDatabaseVersion(DatabasePath, _errOut))
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

            If Not XmlExport.Generate(DatabasePath, Convert.ToInt32(GunId), appVersion, strFilePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name,  "ToolStripButton3_Click", Err.Number, ex.Message.ToString)
        End Try
        Close()
    End Sub
#End Region
    ''' <summary>
    ''' Does the edit ass item.
    ''' </summary>
    Sub DoEditAssItem()
' ReSharper disable LocalVariableHidesMember
        Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
' ReSharper restore LocalVariableHidesMember
        frmEditAccessory.MdiParent = MdiParent
        frmEditAccessory.ItemId = itemId
        FrmEditAccessory.GunId = Convert.ToInt32(GunId)
        frmEditAccessory.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        Call DoEditAssItem()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the CopyToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
' ReSharper disable LocalVariableHidesMember
        Dim itemId As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
' ReSharper restore LocalVariableHidesMember
        frmCopyAccessory.MdiParent = MdiParent
        frmCopyAccessory.ItemId = itemId
        frmCopyAccessory.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New FrmEditCollectionDetails
        frmNew.ItemId = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Cursor = Cursors.WaitCursor
        Try
            If Not Pictures.HasDefaultPicture(DatabasePath, GunId, ApplicationPath, DefaultPic, _errOut,true ) then Throw New Exception(_errOut)
            Call GetPics()
            Dim frmNew As New FrmViewReportFirearmDetails
            frmNew.IntId = GunId
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton2_Click", Err.Number, ex.Message.ToString)
        End Try
        Cursor = Cursors.Arrow
    End Sub

    ''' <summary>
    ''' Handles the Click event of the ToolStripButton5 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton5.Click
        Cursor = Cursors.WaitCursor
        Try
            If Not Pictures.HasDefaultPicture(DatabasePath, GunId, ApplicationPath, DefaultPic, _errOut,true ) then Throw New Exception(_errOut)
            Call GetPics()
            Dim frmNew As New FrmViewReportFirearmDetailsFullDetails()
            frmNew.IntId = GunId
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton5_Click", Err.Number, ex.Message.ToString)
        End Try
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAmmoReportByCal control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAmmoReportByCal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAmmoReportByCal.Click
        Cursor = Cursors.WaitCursor
        Dim frmNew As New FrmViewReportAmmoByCaliber
        frmNew.Cal = Trim(txtCal.Text)
        frmNew.Pet = Trim(txtPetLoads.Text)
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripMenuItem1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim rowId As Long = DataGridView4.SelectedCells.Item(0).RowIndex
        DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView4.Rows(rowId).Selected = True
' ReSharper disable once LocalVariableHidesMember
        Dim itemId As String = DataGridView4.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New FrmEditGunSmithLog
        frmNew.Id = itemId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton6 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton6.Click
        Dim frmNew As New FrmAddBarrelSystem
        frmNew.Gid = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnVwAccessReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnVwAccessReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVwAccessReport.Click
        Dim frmNew As New FrmViewReportAccessories
        frmNew.Gid = GunId
        frmNew.Title = Text
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the SetAsDefaultToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub SetAsDefaultToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetAsDefaultToolStripMenuItem.Click
       Try
           Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
           if Not ExtraBarrelConvoKits.SwapDefaultBarrelSystems(DatabasePath, BsDefaultbarrelsystemid, bid, GunId, _errOut) Then Throw New Exception(_errOut)
       Catch ex As Exception
           Call LogError(Name, "SetAsDefaultToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
       End Try
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try     
            Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
            If BsDefaultbarrelsystemid = bid Then
                MsgBox("This is set as the default Barrel/Unit for this firearm!" & Chr(13) & "Please set another item as the default before deleting this one!")
                Exit Sub
            Else
                Dim sMsg As String = ""
                If Not ExtraBarrelConvoKits.DeleteBarrelSystem(DatabasePath, BID,sMsg, _errOut) Then Throw New Exception(_errOut)
                MsgBox(sMsg)
                Call LoadData()
            End If
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem1.Click
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New FrmEditBarrelSystem
        frmNew.Gid = GunId
        frmNew.Bid = bid
        frmNew.Recname = Text
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton7 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton7.Click
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnGalleryReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnGalleryReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGalleryReport.Click
        Cursor = Cursors.WaitCursor
        Dim newForm As New FrmViewReportPictures
        newForm.MdiParent = MdiParent
        newForm.MyGid = GunId
        newForm.Title = Text
        newForm.Show()
        Cursor = Cursors.Arrow
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditNotesToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditNotesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditNotesToolStripMenuItem.Click
        Dim myIndex As String = ListView1.FocusedItem.Index
        Dim myText As String = ListView1.Items(CInt(myIndex)).Text
        Dim frmNew As New FrmEditPicturedetails
        frmNew.MdiParent = MdiParent
        frmNew.Pid = CLng(myText)
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem1 control. Delete maintenance details from firearm
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Try
            Dim rowId As Long = DataGridView3.SelectedCells.Item(0).RowIndex
            DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView3.Rows(rowId).Selected = True
            Dim mid As Long = DataGridView3.SelectedRows.Item(0).Cells.Item(0).Value

            If Not MaintanceDetails.Delete(DatabasePath, mid, _errOut) Then Throw New Exception(_errOut)
            
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem1_Click", Err.Number, ex.Message.ToString)
        End Try
        Call LoadMaintData()
    End Sub
    ''' <summary>
    ''' Runs the edit maintenance. get the id of the maintenance details ID and pass that ID to the edit Maintance form
    ''' </summary>
    Sub RunEditMaintenance()
        Try
            Dim rowId As Long = DataGridView3.SelectedCells.Item(0).RowIndex
            DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView3.Rows(rowId).Selected = True
            Dim mid As Long = DataGridView3.SelectedRows.Item(0).Cells.Item(0).Value
            Dim frmNew As New FrmEditMaintenance
            frmNew.Mid = mid
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "RunEditMaintenance", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem2 control. Context menu for Maintenance editing
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem2.Click
        Call RunEditMaintenance()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnStolen control. bring up the Stolen Form when the Stole button was clicked in the sale and disposition tab
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnStolen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStolen.Click
        Dim frmNew As New FrmStolen
        frmNew.MdiParent = MdiParent
        frmNew.ItemId = GunId
        frmNew.Show()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnPrintSale control. Create a report to print when the Print Sale button is clicked
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnPrintSale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintSale.Click
        Dim frmNew As New FrmViewReportFirearmSaleInvoice
        frmNew.MdiParent = MdiParent
        frmNew.UserId = SellerId
        frmNew.FirearmId = GunId
        frmNew.Show()
    End Sub

    ''' <summary>
    ''' Handles the CellContentDoubleClick event of the DataGridView6 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub DataGridView6_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentDoubleClick
        Try
            Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
            If Not Documents.GetDocumentFromDb(DatabasePath, ApplicationPath, did, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "DataGridView6_CellContentDoubleClick", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAddDocument control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim frmNew As New FrmAddDocument
        frmNew.Gid = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAddExistingDoc control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAddExistingDoc_Click(sender As Object, e As EventArgs) Handles btnAddExistingDoc.Click
        Dim frmNew As New FrmLinkFromExistingDoc
        frmNew.Gid = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem3.Click
        Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        Dim frmNew As New FrmAddDocument
        frmNew.EditMode = True
        frmNew.Did = did
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ViewToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Try
            Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
            If Not Documents.GetDocumentFromDb(DatabasePath, ApplicationPath, did, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "ViewToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the UnLinkToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub UnLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnLinkToolStripMenuItem.Click
        Try
            Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(0).Value
            If Not Documents.DeleteDocLink(DatabasePath, did, _errOut) Then Throw New Exception(_errOut)
            MsgBox("Document was unlinked!")
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "UnLinkToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the MoveToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub MoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToolStripMenuItem.Click
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New FrmMoveBarrelConKit
        frmNew.BarrelId = bid
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the chkIsCompetition control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <exception cref="System.Exception"></exception>
    Private Sub chkIsCompeition_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsCompeition.CheckedChanged
        Try
            If Not MyCollection.SetAsCompetitionGun(DatabasePath, Convert.ToInt32(GunId), chkIsCompeition.Checked, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "chkIsCompetition_CheckedChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub chkNonLethal_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonLethal.CheckedChanged
        Try
            If Not MyCollection.SetAsNonLethal(DatabasePath, Convert.ToInt32(GunId), chkNonLethal.Checked, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "chkNonLethal_CheckedChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class