Imports System.ComponentModel
Imports System.IO
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Universal

''' <summary>
''' Class frmViewCollectionDetails.  Main form to view the firearm details
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewCollectionDetails
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
            Dim sSubFunc As String = "frmViewCollectionDetails_Disposed"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "frmViewCollectionDetails_Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
        Dim msgAns As String = MsgBox("Are you sure you want to delete this picture?", MsgBoxStyle.YesNo, "Delete Picture")
        If msgAns = vbYes Then
            Dim myIndex As String = ListView1.FocusedItem.Index
            Dim myText As String = ListView1.Items(CInt(myIndex)).Text
            Dim sql As String = "DELETE from Gun_Collection_Pictures where ID=" & myText
            Dim obj As New BSDatabase
            obj.ConnExec(sql)
            Call GetPics()
        End If
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
        Dim frmNew As New frmAddAccessory
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
        Dim frmNew As New frmEditCollectionDetails
        frmNew.ItemId = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
    Private Sub btnAddAmmo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAmmo.Click
        Dim frmNew As New frmAddCollectionAmmo
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
        Dim frmNew As New frmForSale
        frmNew.MdiParent = MdiParent
        frmNew.MyId = GunId
        frmNew.Show()
    End Sub
    Private Sub btnSold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSold.Click
        Dim frmNew As New frmSold
        frmNew.MdiParent = MdiParent
        frmNew.ItemId = GunId
        frmNew.Show()
        Close()
    End Sub
    Private Sub btnUnDoSale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnDoSale.Click
        Dim meAns As String = MsgBox("Are you sure you want to undo this sale?", MsgBoxStyle.YesNo, Text)
        If meAns = vbYes Then
            Dim obj As New BSDatabase
            Dim uSql As String = "UPDATE Gun_Collection set ItemSold=0,BID=2,dtSold=NULL where ID=" & GunId
            obj.ConnExec(uSql)
            MDIParent1.RefreshCollection()
            Close()
        End If
    End Sub
#End Region
#Region " General Functions "
    ''' <summary>
    ''' Counts the pics. Count the number of pictures that is attached to this firearm.
    ''' </summary>
    ''' <returns>System.Int64.</returns>
    Function CountPics() As Long
        Dim obj As New BSDatabase
        Dim iAns As Long = 0
        Try
            Call obj.ConnectDB()
            Dim sql As String = "SELECT Count(*) as Total from Gun_Collection_Pictures where CID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    iAns = rs("Total")
                End While
            End If
            rs.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "CountPics"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function

#End Region
#Region " General Subs "
    ''' <summary>
    ''' Loads the ammo data. Load the Ammo collection tab based on the calibers listed in the main details page
    ''' </summary>
    Sub LoadAmmoData()
        Try
            Dim obj As New GlobalFunctions

            If Len(txtPetLoads.Text) = 0 And Len(txtCaliber3.Text) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillBy(MGCDataSet.Gun_Collection_Ammo, txtCal.Text)
                lblAmmoTotal.Text = obj.TotalAmmoSelected(txtCal.Text)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet(MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text)
                lblAmmoTotal.Text = obj.TotalAmmoSelected(txtCal.Text, txtPetLoads.Text)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) > 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet3(MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text, txtCaliber3.Text)
                lblAmmoTotal.Text = obj.TotalAmmoSelected(txtCal.Text, txtPetLoads.Text, txtCaliber3.Text)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "LoadAmmoData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the maint data. Load the maintenance data, also check to see if there are other barrels attached which will affect
    ''' the total rounds fired count base on the count from the barrel vs the count form the receiver
    ''' </summary>
    Sub LoadMaintData()
        Dim obj As New GlobalFunctions
        If Not BsHasmultibarrels Then
            Maintance_DetailsTableAdapter.FillBy(MGCDataSet.Maintance_Details, GunId)
            Label50.Visible = False
            lblTotalFirearm.Visible = False
            lblTotalRndsFired.Text = obj.TotalRoundsFired(GunId)
            lblAvgRndsFired.Text = obj.AverageRoundsFired(GunId)
        Else
            Maintance_DetailsTableAdapter.FillBy_BSID(MGCDataSet.Maintance_Details, GunId, BsDefaultbarrelsystemid)
            Label50.Visible = True
            lblTotalFirearm.Visible = True
            lblTotalFirearm.Text = obj.TotalRoundsFired(GunId)
            lblTotalRndsFired.Text = obj.TotalRoundsFiredBS(BsDefaultbarrelsystemid)
            lblAvgRndsFired.Text = obj.AverageRoundsFiredBS(BsDefaultbarrelsystemid)
        End If
    End Sub
    'Populate the selling information in the disposition tab.
    Sub LoadSellerData()
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_SoldTo where ID=" & SellerId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                If Not IsDBNull(rs("Name")) Then txtName.Text = rs("Name")
                If Not IsDBNull(rs("Address1")) Then txtAddress1.Text = rs("Address1")
                If Not IsDBNull(rs("Address2")) Then txtAddress2.Text = rs("Address2")
                If Not IsDBNull(rs("City")) Then txtCity.Text = rs("City")
                If Not IsDBNull(rs("ZipCode")) Then txtZip.Text = rs("ZipCode")
                If Not IsDBNull(rs("State")) Then txtState.Text = rs("State")
                If Not IsDBNull(rs("Phone")) Then txtPhone.Text = rs("Phone")
                If Not IsDBNull(rs("Country")) Then txtCountry.Text = rs("Country")
                If Not IsDBNull(rs("Fax")) Then txtFax.Text = rs("Fax")
                If Not IsDBNull(rs("eMail")) Then txteMail.Text = rs("eMail")
                If Not IsDBNull(rs("WebSite")) Then txtWebSite.Text = rs("WebSite")
                If Not IsDBNull(rs("Lic")) Then txtLic.Text = rs("Lic")
                If Not IsDBNull(rs("DLic")) Then txtDLic.Text = rs("DLic")
                If Not IsDBNull(rs("DOB")) Then txtDOB.Text = rs("DOB")
                If Not IsDBNull(rs("ResiDent")) Then txtRes.Text = rs("ResiDent")
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadSellerData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the add accessories. Load the Accessories and total up the cost of the accessories and the total appriased value
    ''' </summary>
    Sub LoadAddAccessories()
        Dim objGf As New GlobalFunctions
        lblTPV.Text = objGf.AddPurchasePriceAccessories(GunId)
        lblTAV.Text = objGf.AddAppriasedPriceAccessories(GunId)
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
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Dim objDf As New BSDateTime
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection where ID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            Call LoadAddAccessories()

            'Check to see if the firearm has extra barrels, if not remove the tab, otherwise populate the table.
            BsHasmultibarrels = objGf.HasMultiBarrelsListed(GunId)
            BsDefaultbarrelsystemid = objGf.GetDefaultBarrelID(GunId)
            If Not BsHasmultibarrels Then
                TabControl1.TabPages.Remove(TabPage10)
            Else
                Gun_Collection_ExtTableAdapter.FillBy_GID(MGCDataSet.Gun_Collection_Ext, GunId)
                DataGridView5.Columns(0).Visible = False
            End If
            'Check to see if there are documents attached, if not remove the tab, otherwise populate the tab.
            HasDocuments = objGf.HasDocumentsAttached(GunId)
            If Not HasDocuments Then
                TabControl1.TabPages.Remove(TabPage12)
            Else
                Qry_DocsAndLinksTableAdapter.FillBy_GID(MGCDataSet.qry_DocsAndLinks, GunId)

            End If

            'Start populating the fields on the details for from the database
            While rs.Read
                Text = rs("fullname")
                txtManu.Text = objGf.GetManufacturersName(rs("MID"))
                txtModel.Text = rs("ModelName")
                If Not IsDBNull(rs("SerialNumber")) Then txtSerial.Text = rs("SerialNumber")
                If Not IsDBNull(rs("Type")) Then txtType.Text = rs("Type")
                If Found(txtType.Text, "shotgun") Then IsShotGun = True
                If IsShotGun Then
                    If Not IsDBNull(rs("SGChoke")) Then txtChoke.Text = Trim(rs("SGChoke"))
                    Call AddChokeOption()
                End If
                If Not IsDBNull(rs("Caliber")) Then txtCal.Text = rs("Caliber")
                If Not IsDBNull(rs("Finish")) Then txtFinish.Text = rs("Finish")
                If Not IsDBNull(rs("Condition")) Then txtCondition.Text = rs("Condition")
                If Not IsDBNull(rs("Petloads")) Then txtPetLoads.Text = rs("Petloads")
                txtNationality.Text = objGf.GetNationalityName(rs("NatID"))
                If Not IsDBNull(rs("Weight")) Then txtWeight.Text = rs("Weight")
                If Not IsDBNull(rs("Height")) Then txtLength.Text = rs("Height")
                If Not IsDBNull(rs("BarrelLength")) Then txtBarLen.Text = rs("BarrelLength")
                If Not IsDBNull(rs("BarrelWidth")) Then txtBarWid.Text = rs("BarrelWidth")
                If Not IsDBNull(rs("BarrelHeight")) Then txtBarHei.Text = rs("BarrelHeight")
                If Not IsDBNull(rs("CustomID")) Then txtCustCatID.Text = rs("CustomID")
                txtGripType.Text = objGf.GetGripName(rs("GripID"))
                If Not IsDBNull(rs("Produced")) Then txtProduced.Text = rs("Produced")
                If Not IsDBNull(rs("Action")) Then txtAction.Text = rs("Action")
                If Not IsDBNull(rs("Feedsystem")) Then txtFeed.Text = rs("Feedsystem")
                If Not IsDBNull(rs("Sights")) Then txtSights.Text = rs("Sights")
                If Not IsDBNull(rs("StorageLocation")) Then txtStorage.Text = rs("StorageLocation")
                If Not IsDBNull(rs("PurchasedFrom")) Then txtPurchasedFrom.Text = rs("PurchasedFrom")
                If Not IsDBNull(rs("PurchasedPrice")) Then txtPurPrice.Text = rs("PurchasedPrice")
                If Not IsDBNull(rs("Importer")) Then txtImporter.Text = Trim(rs("Importer"))
                If Not IsDBNull(rs("SGChoke")) Then txtChoke.Text = Trim(rs("SGChoke"))


                If Not IsDBNull(rs("IsInBoundBook")) Then
                    If CInt(rs("IsInBoundBook")) = 0 Then
                        chkBoundBook.Checked = False
                    Else
                        chkBoundBook.Checked = True
                    End If
                Else
                    chkBoundBook.Checked = True
                End If

                If Not IsDBNull(rs("TwistRate")) Then txtTwistOfRate.Text = Trim(rs("TwistRate"))
                If Not IsDBNull(rs("lbs_trigger")) Then txtTriggerPull.Text = Trim(rs("lbs_trigger"))
                If Not IsDBNull(rs("Caliber3")) Then txtCaliber3.Text = Trim(rs("Caliber3"))
                If Not IsDBNull(rs("Classification")) Then txtClassification.Text = Trim(rs("Classification"))

                'Date of C & R
                If Not IsDBNull(rs("DateofCR")) Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = objDf.FormatDate(rs("DateofCR"))
                    dtpDateofCR.Enabled = True
                End If
                dtpDateofCR.Enabled = False

                Dim iClassIii As Integer = 0
                If Not IsDBNull(rs("IsClassIII")) Then iClassIii = rs("IsClassIII")
                If Not IsDBNull(rs("ClassIII_owner")) Then txtClassIIIOwner.Text = rs("ClassIII_owner")
                If iClassIii = 0 Then
                    chkClassIII.Checked = False
                Else
                    chkClassIII.Checked = True
                End If

                If Not IsDBNull(rs("IsCandR")) Then
                    If CInt(rs("IsCandR")) = 0 Then
                        chkBoxCR.Checked = False
                    Else
                        chkBoxCR.Checked = True
                    End If
                Else
                    chkBoxCR.Checked = False
                End If
                If Not IsDBNull(rs("POI")) Then txtPOI.Text = Trim(rs("poi"))

                If Not IsDBNull(rs("ReManDT")) Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = rs("ReManDT")
                    dtpReManDT.Enabled = True
                End If
                dtpReManDT.Enabled = False

                If Not IsDBNull(rs("dtp")) Then
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = rs("dtp")
                    dtpPurchased.Enabled = False
                Else
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = rs("dt")
                    dtpPurchased.Enabled = False
                End If
                If Not IsDBNull(rs("AppraisedValue")) Then txtAppValue.Text = rs("AppraisedValue")
                ShopId = rs("SID")
                If Len(Trim(rs("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = rs("AppraisalDate")
                    dtpAppDate.Enabled = False
                End If
                If Not IsDBNull(rs("AppraisedBy")) Then txtAppBy.Text = rs("AppraisedBy")
                If Not IsDBNull(rs("InsuredValue")) Then txtInsVal.Text = rs("InsuredValue")
                If Not IsDBNull(rs("ConditionComments")) Then txtConCom.Text = rs("ConditionComments")
                If Not IsDBNull(rs("AdditionalNotes")) Then txtAddNotes.Text = rs("AdditionalNotes")
                If Not IsDBNull(rs("BID")) Then SellerId = rs("BID")
' ReSharper disable LocalizableElement
                If Not IsDBNull(rs("dtSold")) Then lblSold.Text = "on " & rs("dtSold")
' ReSharper restore LocalizableElement
                If CInt(rs("ItemSold")) = 1 Then
                    IsSold = True
                    IsStolen = False
                ElseIf CInt(rs("ItemSold")) = 2 Then
                    IsSold = False
                    IsStolen = True
                Else
                    IsSold = False
                    IsStolen = False
                End If

            End While
            rs.Close()
            obj.CloseDB()
            Refresh()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the pics.
    ''' </summary>
    Public Sub GetPics()
        Try
            ListView1.Clear()
            imgPics.Images.Clear()
            Dim picCount As Long = CountPics()
            Dim i As Long 
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT ID from Gun_Collection_Pictures where CID=" & GunId '& " order by ID DESC"
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            Dim picId As Long
            rs = cmd.ExecuteReader
            ListView1.Clear()
            If rs.HasRows Then
                rs.Read()
                For i = 1 To picCount
                    picId = CLng(rs("ID"))
                    GetPicsId(picId, i)
                    rs.Read()
                Next i
            End If
            obj.CloseDB()

        Catch ex As Exception
            Dim sSubFunc As String = "GetPics"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the pics identifier.
    ''' </summary>
    ''' <param name="picId">The pic identifier.</param>
    ''' <param name="i">The i.</param>
    Sub GetPicsId(ByVal picId As Long, ByVal i As Long)
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT THUMB from Gun_Collection_Pictures where ID=" & picId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim b() As Byte = cmd.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                DrawToScale(New Bitmap(stream), i, picId)
                stream.Close()
            End If
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetPicsID"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "DataGridView3_Validated"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "MaintanceDetailsBindingSource_ListChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "DataGridView4_Validated"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "GunSmithDetailsBindingSource_CurrentChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Call XML_Generate(strFilePath)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton3_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' XMLs the generate.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    Sub XML_Generate(ByVal strPath As String)
        Try
            Dim sAns As String 
            Dim nl As String = Chr(10) & Chr(13)
            sAns = "<?xml version=""1.0"" encoding=""utf-8"" ?>"
            sAns &= "<Firearm>" & nl
            sAns &= "   <MGC>"
            sAns &= "       <version>" & String.Format("Version {0}", Application.ProductVersion.ToString) & "</version>"
            sAns &= "   </MGC>"
            sAns &= XML_GenerateDetails()
            sAns &= XML_GenerateAss()
            sAns &= XML_GenerateMaint()
            sAns &= XML_GenerateGSmith()
            sAns &= XML_GenerateBarrelConversKit()
            sAns &= "</Firearm>" & nl
            sAns = Replace(sAns, "&", "&amp;")
            Dim objFs As New BSFileSystem
            objFs.OutPutToFile(strPath, sAns)
            MsgBox("Firearm was exported to " & Chr(10) & strPath)
        Catch ex As Exception
            Dim sSubFunc As String = "XML_Generate"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' XMLs the generate details.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function XML_GenerateDetails() As String
        Dim sAns As String = ""
        Dim nl As String = Chr(10) & Chr(13)
        sAns &= "    <Details>" & nl
        sAns &= "       <FullName>" & Text & "</FullName>" & nl
        sAns &= "       <Manufacturer>" & txtManu.Text & "</Manufacturer>" & nl
        sAns &= "       <ModelName>" & txtModel.Text & "</ModelName>" & nl
        sAns &= "       <SerialNumber>" & txtSerial.Text & "</SerialNumber>" & nl
        sAns &= "       <Type>" & txtType.Text & "</Type>" & nl
        sAns &= "       <Caliber>" & txtCal.Text & "</Caliber>" & nl
        sAns &= "       <Finish>" & txtFinish.Text & "</Finish>" & nl
        sAns &= "       <Condition>" & txtCondition.Text & "</Condition>" & nl
        sAns &= "       <CustomID>" & txtCustCatID.Text & "</CustomID>" & nl
        sAns &= "       <NatID>" & txtNationality.Text & "</NatID>" & nl
        sAns &= "       <GripID>" & txtGripType.Text & "</GripID>" & nl
        sAns &= "       <Weight>" & txtWeight.Text & "</Weight>" & nl
        sAns &= "       <Height>" & txtLength.Text & "</Height>" & nl
        sAns &= "       <BarrelLength>" & txtBarLen.Text & "</BarrelLength>" & nl
        sAns &= "       <BarWid>" & txtBarWid.Text & "</BarWid>" & nl
        sAns &= "       <BarHei>" & txtBarHei.Text & "</BarHei>" & nl
        sAns &= "       <Action>" & txtAction.Text & "</Action>" & nl
        sAns &= "       <Feedsystem>" & txtFeed.Text & "</Feedsystem>" & nl
        sAns &= "       <Sights>" & txtSights.Text & "</Sights>" & nl
        sAns &= "       <PurchasedPrice>" & txtPurPrice.Text & "</PurchasedPrice>" & nl
        sAns &= "       <PurchasedFrom>" & txtPurchasedFrom.Text & "</PurchasedFrom>" & nl
        sAns &= "       <AppraisedValue>" & txtAppValue.Text & "</AppraisedValue>" & nl
        sAns &= "       <AppraisalDate>" & dtpAppDate.Value & "</AppraisalDate>" & nl
        sAns &= "       <AppraisedBy>" & txtAppBy.Text & "</AppraisedBy>" & nl
        sAns &= "       <InsuredValue>" & txtInsVal.Text & "</InsuredValue>" & nl
        sAns &= "       <StorageLocation>" & txtStorage.Text & "</StorageLocation>" & nl
        sAns &= "       <ConditionComments>" & txtConCom.Text & "</ConditionComments>" & nl
        sAns &= "       <AdditionalNotes>" & txtAddNotes.Text & "</AdditionalNotes>" & nl
        sAns &= "       <Produced>" & txtProduced.Text & "</Produced>" & nl
        sAns &= "       <IsCandR>" & chkBoxCR.Checked & "</IsCandR>" & nl
        sAns &= "       <PetLoads>" & txtPetLoads.Text & "</PetLoads>" & nl
        sAns &= "       <dtp>" & dtpPurchased.Value & "</dtp>" & nl
        sAns &= "       <Importer>" & txtImporter.Text & "</Importer>" & nl
        sAns &= "       <ReManDT>" & dtpReManDT.Value & "</ReManDT>" & nl
        sAns &= "       <POI>" & txtPOI.Text & "</POI>" & nl
        sAns &= "       <SGChoke>" & txtChoke.Text & "</SGChoke>" & nl
        sAns &= "       <Caliber3>" & txtCaliber3.Text & "</Caliber3>" & nl
        sAns &= "       <TwistOfRate>" & txtTwistOfRate.Text & "</TwistOfRate>" & nl
        sAns &= "       <TriggerPull>" & txtTriggerPull.Text & "</TriggerPull>" & nl
        sAns &= "       <BoundBook>" & chkBoundBook.Checked & "</BoundBook>" & nl
        sAns &= "       <Classification>" & txtClassification.Text & "</Classification>" & nl
        sAns &= "       <DateofCR>" & dtpDateofCR.Value & "</DateofCR>" & nl
        sAns &= "       <IsClassIII>" & chkClassIII.Checked & "</IsClassIII>" & nl
        sAns &= "       <ClassIiiOwner>" & txtClassIIIOwner.Text  & "</ClassIiiOwner>" & nl
        sAns &= "    </Details>" & nl
        Return sAns
    End Function
    ''' <summary>
    ''' XMLs the generate ass.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function XML_GenerateAss() As String
        Dim sAns As String = ""
        Dim nl As String = Chr(10) & Chr(13)
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_Accessories where GID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    sAns &= "    <Accessories>" & nl
                    sAns &= "       <Manufacturer>" & rs("Manufacturer") & "</Manufacturer>" & nl
                    sAns &= "       <Model>" & rs("Model") & "</Model>" & nl
                    sAns &= "       <SerialNumber>" & rs("SerialNumber") & "</SerialNumber>" & nl
                    sAns &= "       <Condition>" & rs("Condition") & "</Condition>" & nl
                    sAns &= "       <Notes>" & rs("Notes") & "</Notes>" & nl
                    sAns &= "       <Use>" & rs("Use") & "</Use>" & nl
                    sAns &= "       <PurValue>" & rs("PurValue") & "</PurValue>" & nl
                    sAns &= "       <appValue>" & rs("appValue") & "</appValue>" & nl
                    Dim civ as Boolean = False
                    If rs("civ") = 1 Then civ = True
                    sAns &= "       <civ>" & civ & "</civ>" & nl
                    Dim ic as Boolean = False
                    If rs("ic") = 1 Then civ = True
                    sAns &= "       <ic>" & ic & "</ic>" & nl
                    sAns &= "    </Accessories>" & nl
                End While
            Else
                sAns &= "    <Accessories>" & nl
                sAns &= "    </Accessories>" & nl
            End If
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GenerateAss"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' XMLs the generate maint.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function XML_GenerateMaint() As String
        Dim sAns As String = ""
        Dim nl As String = Chr(10) & Chr(13)
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Maintance_Details where GID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    sAns &= "    <Maintance_Details>" & nl
                    sAns &= "       <Name>" & rs("Name") & "</Name>" & nl
                    sAns &= "       <OpDate>" & rs("OpDate") & "</OpDate>" & nl
                    sAns &= "       <OpDueDate>" & rs("OpDueDate") & "</OpDueDate>" & nl
                    sAns &= "       <RndFired>" & rs("RndFired") & "</RndFired>" & nl
                    sAns &= "       <Notes>" & rs("Notes") & "</Notes>" & nl
                    sAns &= "    </Maintance_Details>" & nl
                End While
            Else
                sAns &= "    <Maintance_Details>" & nl
                sAns &= "    </Maintance_Details>" & nl
            End If
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateMaint"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' XMLs the generate g smith.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function XML_GenerateGSmith() As String
        Dim sAns As String = ""
        Dim nl As String = Chr(10) & Chr(13)
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from GunSmith_Details where GID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    sAns &= "    <GunSmith_Details>" & nl
                    sAns &= "       <gsmith>" & rs("gsmith") & "</gsmith>" & nl
                    sAns &= "       <sdate>" & rs("sdate") & "</sdate>" & nl
                    sAns &= "       <rdate>" & rs("rdate") & "</rdate>" & nl
                    sAns &= "       <od>" & rs("od") & "</od>" & nl
                    sAns &= "       <notes>" & rs("notes") & "</notes>" & nl
                    sAns &= "    </GunSmith_Details>" & nl
                End While
            Else
                sAns &= "    <GunSmith_Details>" & nl
                sAns &= "    </GunSmith_Details>" & nl
            End If
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateGSmith"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' XMLs the generate barrel convers kit.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function XML_GenerateBarrelConversKit() As String
        Dim sAns As String = ""
        Dim nl As String = Chr(10) & Chr(13)
        Try
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_Ext where GID=" & GunId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    sAns &= "    <BarrelConverstionKit_Details>" & nl
                    sAns &= "       <ModelName>" & rs("ModelName") & "</ModelName>" & nl
                    sAns &= "       <Caliber>" & rs("Caliber") & "</Caliber>" & nl
                    sAns &= "       <Finish>" & rs("Finish") & "</Finish>" & nl
                    sAns &= "       <BarrelLength>" & rs("BarrelLength") & "</BarrelLength>" & nl
                    sAns &= "       <PetLoads>" & rs("PetLoads") & "</PetLoads>" & nl
                    sAns &= "       <Action>" & rs("Action") & "</Action>" & nl
                    sAns &= "       <Feedsystem>" & rs("Feedsystem") & "</Feedsystem>" & nl
                    sAns &= "       <Sights>" & rs("Sights") & "</Sights>" & nl
                    sAns &= "       <PurchasedPrice>" & rs("PurchasedPrice") & "</PurchasedPrice>" & nl
                    sAns &= "       <PurchasedFrom>" & rs("PurchasedFrom") & "</PurchasedFrom>" & nl
                    sAns &= "       <dtp>" & rs("dtp") & "</dtp>" & nl
                    sAns &= "       <Height>" & rs("Height") & "</Height>" & nl
                    sAns &= "       <Type>" & rs("Type") & "</Type>" & nl
                    sAns &= "       <IsDefault>" & rs("IsDefault") & "</IsDefault>" & nl
                    sAns &= "    </BarrelConverstionKit_Details>" & nl
                End While
            Else
                sAns &= "    <BarrelConverstionKit_Details>" & nl
                sAns &= "    </BarrelConverstionKit_Details>" & nl
            End If
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateBarrelConversKit"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
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
        Dim frmNew As New frmEditCollectionDetails
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
        Call CheckDefaultPic(GunId)
        Dim frmNew As New FrmViewReportFirearmDetails
        frmNew.IntId = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Cursor = Cursors.Arrow
    End Sub

    ''' <summary>
    ''' Handles the Click event of the ToolStripButton5 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton5.Click
        Cursor = Cursors.WaitCursor
        Call CheckDefaultPic(GunId)
        Dim frmNew As New FrmViewReportFirearmDetailsFullDetails()
        frmNew.IntId = GunId
        frmNew.MdiParent = MdiParent
        frmNew.Show()
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
        Dim frmNew As New frmEditGunSmithLog
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
        Dim frmNew As New frmAddBarrelSystem
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
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim objGf As New GlobalFunctions
        objGf.SwapDefaultBarrelSystems(BsDefaultbarrelsystemid, bid, GunId)
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim objGf As New GlobalFunctions
        If BsDefaultbarrelsystemid = bid Then
            MsgBox("This is set as the default Barrel/Unit for this firearm!" & Chr(13) & "Please set another item as the default before deleting this one!")
            Exit Sub
        Else
            Dim sMsg As String = ""
            objGf.DeleteBarrelSystem(bid, sMsg)
            MsgBox(sMsg)
            Call LoadData()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem1.Click
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New frmEditBarrelSystem
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
        Dim frmNew As New frmEditPicturedetails
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
            Dim obj As New BSDatabase
            Dim sql As String = "DELETE from Maintance_Details where ID=" & mid
            obj.ConnExec(sql)
            Call LoadMaintData()
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem1_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
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
            Dim frmNew As New frmEditMaintenance
            frmNew.Mid = mid
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "RunEditMaintenance"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
        Dim frmNew As New frmStolen
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
        Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        frmViewDocuments.GetDocumentfromDb(did)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAddDocument control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim frmNew As New frmAddDocument
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
        Dim frmNew As New frmLinkFromExistingDoc
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
        Dim frmNew As New frmAddDocument
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
        Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        frmViewDocuments.GetDocumentfromDb(did)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the UnLinkToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub UnLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnLinkToolStripMenuItem.Click
        Try
            Dim did As String = DataGridView6.SelectedRows.Item(0).Cells.Item(0).Value
            Dim sql As String = "delete from Gun_Collection_Docs_Links where id=" & did
            Dim obj As New BSDatabase
            obj.ConnExec(sql)
            MsgBox("Document was unlinked!")
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "UnLinkToolStripMenuItem_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the MoveToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub MoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToolStripMenuItem.Click
        Dim bid As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New frmMoveBarrelConKit
        frmNew.BarrelId = bid
        frmNew.MdiParent = MdiParent
        frmNew.Show()
        Close()
    End Sub
End Class