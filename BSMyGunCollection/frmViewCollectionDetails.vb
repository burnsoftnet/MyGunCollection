Imports System.IO
Imports System.Data
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmViewCollectionDetails.  Main form to view the firearm details
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable once InconsistentNaming
Public Class frmViewCollectionDetails
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopId As String
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' The update pedning ass
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
    ''' The bs hasmultibarrels
    ''' </summary>
    Public BS_HASMULTIBARRELS As Boolean
    ''' <summary>
    ''' The bs defaultbarrelsystemid
    ''' </summary>
    Public BS_DEFAULTBARRELSYSTEMID As Long
    Public UpdatePendingMaint As Boolean
    Public IsShotGun As Boolean
    Public HasDocuments As Boolean
#Region " General Form Subs "
    'Save the form size to the config file so that it will be the same size when the user opens it back up
    Private Sub frmViewCollectionDetails_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Dim objS As New ViewSizeSettings
            objS.SaveViewCollectionDetails(Me.Height, Me.Width, Me.Location.X, Me.Location.Y)
            objS = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "frmViewCollectionDetails_Disposed"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'When the form first opens load all the data
    Private Sub frmViewCollectionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objS As New ViewSizeSettings
            objS.LoadViewCollectionDetails(Me.Height, Me.Width, Me.Location)
            objS = Nothing
            Label42.Visible = UsePetLoads
            txtPetLoads.Visible = UsePetLoads
            Lastviewedfirearm = ItemId
            If Len(ItemId) <> 0 Then
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
                Me.Close()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "frmViewCollectionDetails_Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Action to take when the form is double clicked
    Private Function Form_IsDoubleTab() As Boolean
        Dim bAns As Boolean = False
        If TabControl1.Width < 1000 Then bAns = True
        Return bAns
    End Function
    'Set the size of the tab control 
    Private Sub Form_SetTabContol(ByRef TabContentsAvgHeight As Long, ByRef TabContentsAvgWidth As Long)
        TabControl1.Width = Me.Width - 5
        TabControl1.Height = Me.Height - 60
        TabContentsAvgHeight = TabControl1.Height - 69
        TabContentsAvgWidth = TabControl1.Width - 27
    End Sub
    'Adjust the data grids on the form according to the form details, tabs footers, etc
    'to allow the form to be adjusted as well as the data below the grid to be viewable still.
    Private Sub Form_SetDataGrids(TabContentsAvgHeight As Long, TabContentsAvgWidth As Long)
        Dim DataGridHeightWithFooter As Long = 0
        DataGridHeightWithFooter = TabContentsAvgHeight - 57
        DataGridView1.Width = TabContentsAvgWidth
        DataGridView1.Height = DataGridHeightWithFooter
        DataGridView2.Width = TabContentsAvgWidth
        DataGridView2.Height = DataGridHeightWithFooter
        DataGridView3.Width = TabContentsAvgWidth
        DataGridView3.Height = DataGridHeightWithFooter
        DataGridView4.Width = TabContentsAvgWidth
        DataGridView4.Height = TabContentsAvgHeight
        DataGridView6.Width = TabContentsAvgWidth
        DataGridView6.Height = TabContentsAvgHeight - 20
    End Sub
    'set the size and form of the accessories tab
    Private Sub Form_FormatAccessories(Default_Labellocation As Long)
        Dim NewY As Integer = 0
        Dim OldX As Integer = 0
        'Accessories Totals X,Y Repositioning
        NewY = DataGridView1.Height + Default_Labellocation
        OldX = Label51.Location.X
        'Debug.Print(Label51.Location.Y)
        'Debug.Print(Label51.Location.X)
        Label51.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblTPV.Location.X
        lblTPV.Location = New System.Drawing.Point(OldX, NewY)
        OldX = Label52.Location.X
        Label52.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblTAV.Location.X
        lblTAV.Location = New System.Drawing.Point(OldX, NewY)
    End Sub
    'format the size and format of the Ammunition Tab
    Private Sub Form_FormatAmmo(Default_Labellocation As Long)
        Dim NewY As Integer = 0
        Dim OldX As Integer = 0
        'Ammunition Totals X,Y Repositioning
        NewY = DataGridView2.Height + Default_Labellocation
        OldX = Label45.Location.X
        Label45.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblAmmoTotal.Location.X
        lblAmmoTotal.Location = New System.Drawing.Point(OldX, NewY)
    End Sub
    'format the size and format of the Maintenance Tab
    Private Sub Form_FormatMaintenance(Default_Labellocation As Long)
        Dim NewY As Integer = 0
        Dim OldX As Integer = 0
        'Maintenance Totals X,Y Repositioning
        NewY = DataGridView3.Height + Default_Labellocation
        OldX = Label46.Location.X
        Label46.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblTotalRndsFired.Location.X
        lblTotalRndsFired.Location = New System.Drawing.Point(OldX, NewY)
        OldX = Label47.Location.X
        Label47.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblAvgRndsFired.Location.X
        lblAvgRndsFired.Location = New System.Drawing.Point(OldX, NewY)
        OldX = Label50.Location.X
        Label50.Location = New System.Drawing.Point(OldX, NewY)
        OldX = lblTotalFirearm.Location.X
        lblTotalFirearm.Location = New System.Drawing.Point(OldX, NewY)
    End Sub
    'format the size of the text box in the notes tab
    Private Sub Form_FormatNotes(Default_Notes As Long, Default_Notes_Width As Long)
        txtConCom.Width = TabControl1.Width - Default_Notes_Width ' was 8
        txtConCom.Height = TabControl1.Height - Default_Notes
        txtAddNotes.Width = TabControl1.Width - Default_Notes_Width
        txtAddNotes.Height = TabControl1.Height - Default_Notes
    End Sub
    'Action to take to re format all the details on the form when the Main form is resized
    Private Sub frmViewCollectionDetails_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim TabContentsAvgHeight As Long = 0
        Dim TabContentsAvgWidth As Long = 0
        Dim DEFAULT_LABELLOCATION As Long = 48
        Dim DEFAULT_NOTES As Long = 44
        Dim DEFAULT_NOTES_WIDTH As Long = 20
        If Form_IsDoubleTab() Then
            DEFAULT_LABELLOCATION = DEFAULT_LABELLOCATION - 6
            DEFAULT_NOTES = DEFAULT_NOTES + 10
        End If

        If Me.Width > 0 Then
            Call Form_SetTabContol(TabContentsAvgHeight, TabContentsAvgWidth)
            Call Form_SetDataGrids(TabContentsAvgHeight, TabContentsAvgWidth)
            ListView1.Width = TabContentsAvgWidth
            ListView1.Height = TabContentsAvgHeight

            Dim NewY As Integer = DataGridView1.Height + DEFAULT_LABELLOCATION
            Dim OldX As Integer = btnEdit.Location.X
            btnEdit.Location = New System.Drawing.Point(OldX, NewY)
            OldX = btnExit.Location.X
            btnExit.Location = New System.Drawing.Point(OldX, NewY)
            Call Form_FormatAccessories(DEFAULT_LABELLOCATION)
            Call Form_FormatAmmo(DEFAULT_LABELLOCATION)
            Call Form_FormatMaintenance(DEFAULT_LABELLOCATION)
            Call Form_FormatNotes(DEFAULT_NOTES, DEFAULT_NOTES_WIDTH)
        End If
    End Sub
    'Pictures Tab, when a picture thumbnail is double clicked, perform these action and bring up the picture viewer.
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim MyIndex As String = ListView1.FocusedItem.Index
        Dim ItemCount As Integer = ListView1.Items.Count
        Dim MyText As String = ListView1.Items(CInt(MyIndex)).Text
        Dim frmNew As New frmViewPicture
        frmNew.MdiParent = Me.MdiParent
        frmNew.MyID = CLng(MyText)
        frmNew.GroupID = CLng(ItemId)
        frmNew.Show()
    End Sub
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call LoadAmmoData()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region
#Region " General Tab Sub and Functions "
    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.Enter
        Me.Gun_Collection_AccessoriesTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Accessories, ItemId)
    End Sub
    Private Sub mnuPicItem_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPicItem_Show.Click
        Dim MyIndex As String = ListView1.FocusedItem.Index
        Dim ItemCount As Integer = ListView1.Items.Count
        Dim MyText As String = ListView1.Items(CInt(MyIndex)).Text
        Dim frmNew As New frmViewPicture
        frmNew.MdiParent = Me.MdiParent
        frmNew.MyID = CLng(MyText)
        frmNew.Show()
    End Sub
    Private Sub mnuPicItem_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPicItem_Delete.Click
        Dim msgAns As String = MsgBox("Are you sure you want to delete this picture?", MsgBoxStyle.YesNo, "Delete Picture")
        If msgAns = vbYes Then
            Dim MyIndex As String = ListView1.FocusedItem.Index
            Dim ItemCount As Integer = ListView1.Items.Count
            Dim MyText As String = ListView1.Items(CInt(MyIndex)).Text
            Dim SQL As String = "DELETE from Gun_Collection_Pictures where ID=" & MyText
            Dim obj As New BSDatabase
            obj.ConnExec(SQL)
            Call GetPics()
        End If
    End Sub
    Private Sub txtPurchasedFrom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurchasedFrom.Click
        Dim NewForm As New frmViewShopDetails
        NewForm.ShopId = ShopId
        NewForm.MdiParent = Me.MdiParent
        NewForm.Show()
    End Sub
    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        Call GetPics()
    End Sub
    Private Sub TabPage6_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage6.Enter
        Call LoadAmmoData()
    End Sub
    Private Sub TabPage7_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage7.Enter
        Call LoadMaintData()
    End Sub
    Private Sub TabPage8_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage8.Enter
        Try
            Me.GunSmith_DetailsTableAdapter.FillBy(Me.MGCDataSet.GunSmith_Details, ItemId)
        Catch ex As Exception
            Dim sSubFunc As String = "TabPage8.Enter.Gunsmith.Details"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region " Button Subs "
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddPicture.ItemID = ItemId
        frmAddPicture.MdiParent = Me.MdiParent
        frmAddPicture.Show()
    End Sub
    Private Sub btnAddAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccess.Click
        Dim frmNew As New frmAddAccessory
        frmNew.MdiParent = Me.MdiParent
        frmNew.ItemId = ItemId
        frmNew.IsShotGun = IsShotGun
        frmNew.Show()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Gun_Collection_AccessoriesTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Accessories, ItemId)
        Call LoadAddAccessories()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frmNew As New frmEditCollectionDetails
        frmNew.ItemID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
    Private Sub btnAddAmmo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAmmo.Click
        Dim frmNew As New frmAddCollectionAmmo
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call LoadAmmoData()
    End Sub
    Private Sub btnRefreshPics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPics.Click
        Call GetPics()
    End Sub
    Private Sub btnAddMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMain.Click
        frmAddMaintance.MdiParent = Me.MdiParent
        frmAddMaintance.GID = ItemId
        frmAddMaintance.BSID = BS_DEFAULTBARRELSYSTEMID
        frmAddMaintance.AmmoType = txtCal.Text
        frmAddMaintance.AmmoTypePet = txtPetLoads.Text
        frmAddMaintance.AmmoTypeCal3 = txtCaliber3.Text
        frmAddMaintance.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LoadMaintData()
    End Sub
    Private Sub btnGSLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSLog.Click
        frmAddGunSmithLog.MdiParent = Me.MdiParent
        frmAddGunSmithLog.GID = ItemId
        frmAddGunSmithLog.Show()
    End Sub
    Private Sub btnGSReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSReport.Click
        Me.Cursor = Cursors.WaitCursor
        frmViewReport_GunSmith.MdiParent = Me.MdiParent
        frmViewReport_GunSmith.GID = ItemId
        frmViewReport_GunSmith.Title = Me.Text
        frmViewReport_GunSmith.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub btnRefreshGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshGS.Click
        Me.GunSmith_DetailsTableAdapter.FillBy(Me.MGCDataSet.GunSmith_Details, ItemId)
    End Sub
    Private Sub btnPrintPreviewMaintanceReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreviewMaintanceReport.Click
        Me.Cursor = Cursors.WaitCursor
        Dim newForm As New frmViewReport_Maintenance
        newForm.MdiParent = Me.MdiParent
        newForm.MyGID = ItemId
        newForm.Title = Me.Text
        newForm.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlyer.Click
        Dim frmNew As New frmForSale
        frmNew.MdiParent = Me.MdiParent
        frmNew.MyID = ItemId
        frmNew.Show()
    End Sub
    Private Sub btnSold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSold.Click
        Dim frmNew As New frmSold
        frmNew.MdiParent = Me.MdiParent
        frmNew.ItemID = ItemId
        frmNew.Show()
        Me.Close()
    End Sub
    Private Sub btnUnDoSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnDoSale.Click
        Dim meAns As String = MsgBox("Are you sure you want to undo this sale?", MsgBoxStyle.YesNo, Me.Text)
        If meAns = vbYes Then
            Dim Obj As New BSDatabase
            Dim uSQL As String = "UPDATE Gun_Collection set ItemSold=0,BID=2,dtSold=NULL where ID=" & ItemId
            Obj.ConnExec(uSQL)
            MDIParent1.RefreshCollection()
            Me.Close()
        End If
    End Sub
#End Region
#Region " General Functions "
    'Count the number of pictures that is attached to this firearm.
    Function CountPics() As Long
        Dim Obj As New BSDatabase
        Dim iAns As Long = 0
        Try
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT Count(*) as Total from Gun_Collection_Pictures where CID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim rs As OdbcDataReader
            rs = CMD.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    iAns = rs("Total")
                End While
            End If
            rs.Close()
            rs = Nothing
            CMD = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "CountPics"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function
    Function GetPicIDListing(ByVal strIndex As String, ByVal intTotalImg As Integer) As Long
        Dim lAns As Long = 0
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Pictures where CID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            Dim i As Integer
            Dim c As Integer
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                RS.Read()
                For i = 1 To intTotalImg
                    If i <> 1 Then
                        c = intTotalImg - i
                    Else
                        c = intTotalImg
                    End If
                    If c = CInt(strIndex) Then
                        lAns = CLng(RS("ID"))
                    End If
                    RS.Read()
                Next i
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetPicIDListing"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return lAns
    End Function
#End Region
#Region " General Subs "
    'Load the Ammo collection tab based on the calibers listed in the main details page
    Sub LoadAmmoData()
        Try
            Dim Obj As New GlobalFunctions

            If Len(txtPetLoads.Text) = 0 And Len(txtCaliber3.Text) = 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Ammo, txtCal.Text)
                lblAmmoTotal.Text = Obj.TotalAmmoSelected(txtCal.Text)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) = 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet(Me.MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text)
                lblAmmoTotal.Text = Obj.TotalAmmoSelected(txtCal.Text, txtPetLoads.Text)
            ElseIf Len(txtPetLoads.Text) > 0 And Len(txtCaliber3.Text) > 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet3(Me.MGCDataSet.Gun_Collection_Ammo, txtCal.Text, txtPetLoads.Text, txtCaliber3.Text)
                lblAmmoTotal.Text = Obj.TotalAmmoSelected(txtCal.Text, txtPetLoads.Text, txtCaliber3.Text)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "LoadAmmoData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Load the maintenance data, also check to see if there are other barrels attached which will affect
    'the total rounds fired count base on the count from the barrel vs the count form the receiver
    Sub LoadMaintData()
        Dim Obj As New GlobalFunctions
        If Not BS_HASMULTIBARRELS Then
            Me.Maintance_DetailsTableAdapter.FillBy(Me.MGCDataSet.Maintance_Details, ItemId)
            Label50.Visible = False
            lblTotalFirearm.Visible = False
            lblTotalRndsFired.Text = Obj.TotalRoundsFired(ItemId)
            lblAvgRndsFired.Text = Obj.AverageRoundsFired(ItemId)
        Else
            Me.Maintance_DetailsTableAdapter.FillBy_BSID(Me.MGCDataSet.Maintance_Details, ItemId, BS_DEFAULTBARRELSYSTEMID)
            Label50.Visible = True
            lblTotalFirearm.Visible = True
            lblTotalFirearm.Text = Obj.TotalRoundsFired(ItemId)
            lblTotalRndsFired.Text = Obj.TotalRoundsFiredBS(BS_DEFAULTBARRELSYSTEMID)
            lblAvgRndsFired.Text = Obj.AverageRoundsFiredBS(BS_DEFAULTBARRELSYSTEMID)
        End If
    End Sub
    'Populate the selling information in the disposition tab.
    Sub LoadSellerData()
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_SoldTo where ID=" & SellerId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                If Not IsDBNull(RS("Name")) Then txtName.Text = RS("Name")
                If Not IsDBNull(RS("Address1")) Then txtAddress1.Text = RS("Address1")
                If Not IsDBNull(RS("Address2")) Then txtAddress2.Text = RS("Address2")
                If Not IsDBNull(RS("City")) Then txtCity.Text = RS("City")
                If Not IsDBNull(RS("ZipCode")) Then txtZip.Text = RS("ZipCode")
                If Not IsDBNull(RS("State")) Then txtState.Text = RS("State")
                If Not IsDBNull(RS("Phone")) Then txtPhone.Text = RS("Phone")
                If Not IsDBNull(RS("Country")) Then txtCountry.Text = RS("Country")
                If Not IsDBNull(RS("Fax")) Then txtFax.Text = RS("Fax")
                If Not IsDBNull(RS("eMail")) Then txteMail.Text = RS("eMail")
                If Not IsDBNull(RS("WebSite")) Then txtWebSite.Text = RS("WebSite")
                If Not IsDBNull(RS("Lic")) Then txtLic.Text = RS("Lic")
                If Not IsDBNull(RS("DLic")) Then txtDLic.Text = RS("DLic")
                If Not IsDBNull(RS("DOB")) Then txtDOB.Text = RS("DOB")
                If Not IsDBNull(RS("ResiDent")) Then txtRes.Text = RS("ResiDent")
            End While
            RS.Close()
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadSellerData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Load the Accessories and total up the cost of the accessories and the total appriased value
    Sub LoadAddAccessories()
        Dim ObjGF As New GlobalFunctions
        lblTPV.Text = ObjGF.AddPurchasePriceAccessories(ItemId)
        lblTAV.Text = ObjGF.AddAppriasedPriceAccessories(ItemId)
    End Sub
    'When a shotgun is selected, add the ability to put in what choke is in the firearm
    'But in order to do that, there are fields that need to be moved around just to keep things in order 
    'and try to keep the flow of data input relevant to the user.
    Sub AddChokeOption()
        Label53.Location = New System.Drawing.Point(Label27.Location.X, Label27.Location.Y)
        txtChoke.Location = New System.Drawing.Point(txtStorage.Location.X, txtStorage.Location.Y)
        Label53.Visible = True
        txtChoke.Visible = True

        Dim MoveDownXPoints As Integer = 26
        Dim NewY As Integer = txtStorage.Location.Y + MoveDownXPoints
        Dim OldX As Integer = txtStorage.Location.X
        txtStorage.Location = New System.Drawing.Point(OldX, NewY)
        OldX = Label27.Location.X
        Label27.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label9.Location.Y + MoveDownXPoints
        OldX = Label9.Location.X
        Label9.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtFinish.Location.X
        txtFinish.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label6.Location.Y + MoveDownXPoints
        OldX = Label6.Location.X
        Label6.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtNationality.Location.X
        txtNationality.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label13.Location.Y + MoveDownXPoints
        OldX = Label13.Location.X
        Label13.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtWeight.Location.X
        txtWeight.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label14.Location.Y + MoveDownXPoints
        OldX = Label14.Location.X
        Label14.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtLength.Location.X
        txtLength.Location = New System.Drawing.Point(OldX, NewY)
        NewY = Label15.Location.Y + MoveDownXPoints
        OldX = Label15.Location.X
        Label15.Location = New System.Drawing.Point(OldX, NewY)
        OldX = txtBarLen.Location.X
        txtBarLen.Location = New System.Drawing.Point(OldX, NewY)
    End Sub
    'Start Loading data for the form
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim ObjDF As New BurnSoft.Universal.BSDateTime
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection where ID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Call LoadAddAccessories()

            'Check to see if the firearm has extra barrels, if not remove the tab, otherwise populate the table.
            BS_HASMULTIBARRELS = ObjGF.HasMultiBarrelsListed(ItemId)
            BS_DEFAULTBARRELSYSTEMID = ObjGF.GetDefaultBarrelID(ItemId)
            If Not BS_HASMULTIBARRELS Then
                TabControl1.TabPages.Remove(TabPage10)
            Else
                Me.Gun_Collection_ExtTableAdapter.FillBy_GID(Me.MGCDataSet.Gun_Collection_Ext, ItemId)
                DataGridView5.Columns(0).Visible = False
            End If
            'Check to see if there are documents attached, if not remove the tab, otherwise populate the tab.
            HasDocuments = ObjGF.HasDocumentsAttached(ItemId)
            If Not HasDocuments Then
                TabControl1.TabPages.Remove(TabPage12)
            Else
                Me.Qry_DocsAndLinksTableAdapter.FillBy_GID(Me.MGCDataSet.qry_DocsAndLinks, ItemId)

            End If

            'Start populating the fields on the details for from the database
            While RS.Read
                Me.Text = RS("fullname")
                txtManu.Text = ObjGF.GetManufacturersName(RS("MID"))
                txtModel.Text = RS("ModelName")
                If Not IsDBNull(RS("SerialNumber")) Then txtSerial.Text = RS("SerialNumber")
                If Not IsDBNull(RS("Type")) Then txtType.Text = RS("Type")
                If Found(txtType.Text, "shotgun") Then IsShotGun = True
                If IsShotGun Then
                    If Not IsDBNull(RS("SGChoke")) Then txtChoke.Text = Trim(RS("SGChoke"))
                    Call AddChokeOption()
                End If
                If Not IsDBNull(RS("Caliber")) Then txtCal.Text = RS("Caliber")
                If Not IsDBNull(RS("Finish")) Then txtFinish.Text = RS("Finish")
                If Not IsDBNull(RS("Condition")) Then txtCondition.Text = RS("Condition")
                If Not IsDBNull(RS("Petloads")) Then txtPetLoads.Text = RS("Petloads")
                txtNationality.Text = ObjGF.GetNationalityName(RS("NatID"))
                If Not IsDBNull(RS("Weight")) Then txtWeight.Text = RS("Weight")
                If Not IsDBNull(RS("Height")) Then txtLength.Text = RS("Height")
                If Not IsDBNull(RS("BarrelLength")) Then txtBarLen.Text = RS("BarrelLength")
                If Not IsDBNull(RS("BarrelWidth")) Then txtBarWid.Text = RS("BarrelWidth")
                If Not IsDBNull(RS("BarrelHeight")) Then txtBarHei.Text = RS("BarrelHeight")
                If Not IsDBNull(RS("CustomID")) Then txtCustCatID.Text = RS("CustomID")
                txtGripType.Text = ObjGF.GetGripName(RS("GripID"))
                If Not IsDBNull(RS("Produced")) Then txtProduced.Text = RS("Produced")
                If Not IsDBNull(RS("Action")) Then txtAction.Text = RS("Action")
                If Not IsDBNull(RS("Feedsystem")) Then txtFeed.Text = RS("Feedsystem")
                If Not IsDBNull(RS("Sights")) Then txtSights.Text = RS("Sights")
                If Not IsDBNull(RS("StorageLocation")) Then txtStorage.Text = RS("StorageLocation")
                If Not IsDBNull(RS("PurchasedFrom")) Then txtPurchasedFrom.Text = RS("PurchasedFrom")
                If Not IsDBNull(RS("PurchasedPrice")) Then txtPurPrice.Text = RS("PurchasedPrice")
                If Not IsDBNull(RS("Importer")) Then txtImporter.Text = Trim(RS("Importer"))
                If Not IsDBNull(RS("SGChoke")) Then txtChoke.Text = Trim(RS("SGChoke"))


                If Not IsDBNull(RS("IsInBoundBook")) Then
                    If CInt(RS("IsInBoundBook")) = 0 Then
                        chkBoundBook.Checked = False
                    Else
                        chkBoundBook.Checked = True
                    End If
                Else
                    chkBoundBook.Checked = True
                End If

                If Not IsDBNull(RS("TwistRate")) Then txtTwistOfRate.Text = Trim(RS("TwistRate"))
                If Not IsDBNull(RS("lbs_trigger")) Then txtTriggerPull.Text = Trim(RS("lbs_trigger"))
                If Not IsDBNull(RS("Caliber3")) Then txtCaliber3.Text = Trim(RS("Caliber3"))
                If Not IsDBNull(RS("Classification")) Then txtClassification.Text = Trim(RS("Classification"))

                'Date of C & R
                If Not IsDBNull(RS("DateofCR")) Then
                    dtpDateofCR.Checked = True
                    dtpDateofCR.Value = ObjDF.FormatDate(RS("DateofCR"))
                    dtpDateofCR.Enabled = True
                End If
                dtpDateofCR.Enabled = False

                Dim iClassIII As Integer = 0
                If Not IsDBNull(RS("IsClassIII")) Then iClassIII = RS("IsClassIII")
                If Not IsDBNull(RS("ClassIII_owner")) Then txtClassIIIOwner.Text = RS("ClassIII_owner")
                If iClassIII = 0 Then
                    chkClassIII.Checked = False
                Else
                    chkClassIII.Checked = True
                End If

                If Not IsDBNull(RS("IsCandR")) Then
                    If CInt(RS("IsCandR")) = 0 Then
                        chkBoxCR.Checked = False
                    Else
                        chkBoxCR.Checked = True
                    End If
                Else
                    chkBoxCR.Checked = False
                End If
                If Not IsDBNull(RS("POI")) Then txtPOI.Text = Trim(RS("poi"))

                If Not IsDBNull(RS("ReManDT")) Then
                    dtpReManDT.Checked = True
                    dtpReManDT.Value = RS("ReManDT")
                    dtpReManDT.Enabled = True
                End If
                dtpReManDT.Enabled = False

                If Not IsDBNull(RS("dtp")) Then
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = RS("dtp")
                    dtpPurchased.Enabled = False
                Else
                    dtpPurchased.Checked = False
                    dtpPurchased.Value = RS("dt")
                    dtpPurchased.Enabled = False
                End If
                If Not IsDBNull(RS("AppraisedValue")) Then txtAppValue.Text = RS("AppraisedValue")
                ShopId = RS("SID")
                If Len(Trim(RS("AppraisalDate"))) <> 0 Then
                    dtpAppDate.Checked = True
                    dtpAppDate.Value = RS("AppraisalDate")
                    dtpAppDate.Enabled = False
                End If
                If Not IsDBNull(RS("AppraisedBy")) Then txtAppBy.Text = RS("AppraisedBy")
                If Not IsDBNull(RS("InsuredValue")) Then txtInsVal.Text = RS("InsuredValue")
                If Not IsDBNull(RS("ConditionComments")) Then txtConCom.Text = RS("ConditionComments")
                If Not IsDBNull(RS("AdditionalNotes")) Then txtAddNotes.Text = RS("AdditionalNotes")
                If Not IsDBNull(RS("BID")) Then SellerId = RS("BID")
                If Not IsDBNull(RS("dtSold")) Then lblSold.Text = "on " & RS("dtSold")
                If CInt(RS("ItemSold")) = 1 Then
                    IsSold = True
                    IsStolen = False
                ElseIf CInt(RS("ItemSold")) = 2 Then
                    IsSold = False
                    IsStolen = True
                Else
                    IsSold = False
                    IsStolen = False
                End If

            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
            Me.Refresh()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Public Sub GetPics()
        Try
            ListView1.Clear()
            imgPics.Images.Clear()
            Dim PicCount As Long = CountPics()
            Dim i As Long = 0
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT ID from Gun_Collection_Pictures where CID=" & ItemId '& " order by ID DESC"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim rs As OdbcDataReader
            Dim PicID As Long
            rs = CMD.ExecuteReader
            ListView1.Clear()
            If rs.HasRows Then
                rs.Read()
                For i = 1 To PicCount
                    PicID = CLng(rs("ID"))
                    GetPicsID(PicID, i)
                    rs.Read()
                Next i
            End If
            Obj.CloseDB()
            Obj = Nothing
            CMD = Nothing

        Catch ex As Exception
            Dim sSubFunc As String = "GetPics"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub GetPicsID(ByVal PicID As Long, ByVal i As Long)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT THUMB from Gun_Collection_Pictures where ID=" & PicID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim b() As Byte = CMD.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                DrawToScale(New Bitmap(stream), i, PicID)
                stream.Close()
                stream = Nothing
            End If
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetPicsID"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub DrawToScale(ByVal bmp As Image, ByVal imgindex As Integer, ByVal ImgID As Long)
        PictureBox1.Image = New Bitmap(bmp)
        imgPics.Images.Add(New Bitmap(bmp))

        Me.ListView1.LargeImageList = imgPics
        Me.ListView1.View = View.LargeIcon

        Dim osItem As ListViewItem.ListViewSubItem
        Dim oitem As ListViewItem = New ListViewItem
        oitem.Text = ImgID
        osItem = New ListViewItem.ListViewSubItem
        osItem.Text = ImgID
        oitem.SubItems.Add(osItem)
        ListView1.Items.Add(oitem)
        oitem.ImageIndex = imgindex - 1
    End Sub
    Private Sub ShowImage(ByVal s As String, ByVal imgIndex As Integer)
        Me.ListView1.LargeImageList = imgPics
        Me.ListView1.View = View.LargeIcon

        Dim osItem As ListViewItem.ListViewSubItem
        Dim oitem As ListViewItem = New ListViewItem
        oitem.Text = s

        osItem = New ListViewItem.ListViewSubItem
        osItem.Text = s

        oitem.SubItems.Add(osItem)

        osItem = New ListViewItem.ListViewSubItem
        osItem.Text = s & s
        oitem.SubItems.Add(osItem)
        If imgIndex >= 0 Then
            With ListView1
                .Items.Add(oitem)
            End With
            oitem.ImageIndex = imgIndex
        End If
    End Sub
#End Region
#Region " Data Object Subs "
    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If Me.UpdatePedningAss Then
            Me.Gun_Collection_AccessoriesTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Accessories)
            Me.UpdatePedningAss = False
        End If
    End Sub
    Private Sub GunCollectionAmmoBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionAmmoBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePending = True
        End If
    End Sub
    Private Sub DataGridView2_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowValidated
        If Me.UpdatePending Then
            Me.Gun_Collection_AmmoTableAdapter.Update(Me.MGCDataSet.Gun_Collection_Ammo)
            Me.UpdatePending = False
        End If
    End Sub
    Private Sub GunCollectionAccessoriesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles GunCollectionAccessoriesBindingSource.ListChanged
        If Me.MGCDataSet.HasChanges Then
            Me.UpdatePedningAss = True
        End If
    End Sub

    Private Sub DataGridView3_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        Call RunEditMaintenance()
    End Sub
    Private Sub DataGridView3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.Validated
        Try
            If Me.UpdatePendingMaint Then
                Me.Maintance_DetailsTableAdapter.Update(Me.MGCDataSet.Maintance_Details)
                Me.UpdatePendingMaint = False
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView3_Validated"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub MaintanceDetailsBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles MaintanceDetailsBindingSource.ListChanged
        Try
            If Me.MGCDataSet.HasChanges Then
                Me.UpdatePendingMaint = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "MaintanceDetailsBindingSource_ListChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub DataGridView4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView4.Validated
        Try
            If Me.UpdatePending Then
                Me.GunSmith_DetailsTableAdapter.Update(Me.MGCDataSet.GunSmith_Details)
                Me.UpdatePending = False
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DataGridView4_Validated"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub GunSmithDetailsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunSmithDetailsBindingSource.CurrentChanged
        Try
            If Me.MGCDataSet.HasChanges Then
                Me.UpdatePending = True
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GunSmithDetailsBindingSource_CurrentChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "XML Export Functions"
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim DefaultFileName As String = "ExportFirearm_" & Me.Text & ".xml"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.Filter = "XML File(*.xml)|*.xml"
            SaveFileDialog1.Title = "Export Data to XML File"
            SaveFileDialog1.FileName = Replace(Replace(Replace(DefaultFileName, " ", "_"), "/", "-"), "\", "-")
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = SaveFileDialog1.FileName
            Call XML_Generate(strFilePath)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton3_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub XML_Generate(ByVal strPath As String)
        Try
            Dim sAns As String = ""
            Dim NL As String = Chr(10) & Chr(13)
            sAns = "<?xml version=""1.0"" encoding=""utf-8"" ?>"
            sAns &= "<Firearm>" & NL
            sAns &= "   <MGC>"
            sAns &= "       <version>" & String.Format("Version {0}", Application.ProductVersion.ToString) & "</version>"
            sAns &= "   </MGC>"
            sAns &= XML_GenerateDetails()
            sAns &= XML_GenerateAss()
            sAns &= XML_GenerateMaint()
            sAns &= XML_GenerateGSmith()
            sAns &= XML_GenerateBarrelConversKit()
            sAns &= "</Firearm>" & NL
            sAns = Replace(sAns, "&", "&amp;")
            Dim ObjFS As New BSFileSystem
            ObjFS.OutPutToFile(strPath, sAns)
            MsgBox("Firearm was exported to " & Chr(10) & strPath)
        Catch ex As Exception
            Dim sSubFunc As String = "XML_Generate"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Function XML_GenerateDetails() As String
        Dim sAns As String = ""
        Dim NL As String = Chr(10) & Chr(13)
        sAns &= "    <Details>" & NL
        sAns &= "       <FullName>" & Me.Text & "</FullName>" & NL
        sAns &= "       <Manufacturer>" & txtManu.Text & "</Manufacturer>" & NL
        sAns &= "       <ModelName>" & txtModel.Text & "</ModelName>" & NL
        sAns &= "       <SerialNumber>" & txtSerial.Text & "</SerialNumber>" & NL
        sAns &= "       <Type>" & txtType.Text & "</Type>" & NL
        sAns &= "       <Caliber>" & txtCal.Text & "</Caliber>" & NL
        sAns &= "       <Finish>" & txtFinish.Text & "</Finish>" & NL
        sAns &= "       <Condition>" & txtCondition.Text & "</Condition>" & NL
        sAns &= "       <CustomID>" & txtCustCatID.Text & "</CustomID>" & NL
        sAns &= "       <NatID>" & txtNationality.Text & "</NatID>" & NL
        sAns &= "       <GripID>" & txtGripType.Text & "</GripID>" & NL
        sAns &= "       <Weight>" & txtWeight.Text & "</Weight>" & NL
        sAns &= "       <Height>" & txtLength.Text & "</Height>" & NL
        sAns &= "       <BarrelLength>" & txtBarLen.Text & "</BarrelLength>" & NL
        sAns &= "       <Action>" & txtAction.Text & "</Action>" & NL
        sAns &= "       <Feedsystem>" & txtFeed.Text & "</Feedsystem>" & NL
        sAns &= "       <Sights>" & txtSights.Text & "</Sights>" & NL
        sAns &= "       <PurchasedPrice>" & txtPurPrice.Text & "</PurchasedPrice>" & NL
        sAns &= "       <PurchasedFrom>" & txtPurchasedFrom.Text & "</PurchasedFrom>" & NL
        sAns &= "       <AppraisedValue>" & txtAppValue.Text & "</AppraisedValue>" & NL
        sAns &= "       <AppraisalDate>" & dtpAppDate.Value & "</AppraisalDate>" & NL
        sAns &= "       <AppraisedBy>" & txtAppBy.Text & "</AppraisedBy>" & NL
        sAns &= "       <InsuredValue>" & txtInsVal.Text & "</InsuredValue>" & NL
        sAns &= "       <StorageLocation>" & txtStorage.Text & "</StorageLocation>" & NL
        sAns &= "       <ConditionComments>" & txtConCom.Text & "</ConditionComments>" & NL
        sAns &= "       <AdditionalNotes>" & txtAddNotes.Text & "</AdditionalNotes>" & NL
        sAns &= "       <Produced>" & txtProduced.Text & "</Produced>" & NL
        sAns &= "       <IsCandR>" & chkBoxCR.Checked & "</IsCandR>" & NL
        sAns &= "       <PetLoads>" & txtPetLoads.Text & "</PetLoads>" & NL
        sAns &= "       <dtp>" & dtpPurchased.Value & "</dtp>" & NL
        sAns &= "       <Importer>" & txtImporter.Text & "</Importer>" & NL
        sAns &= "       <ReManDT>" & dtpReManDT.Value & "</ReManDT>" & NL
        sAns &= "       <POI>" & txtPOI.Text & "</POI>" & NL
        sAns &= "       <SGChoke>" & txtChoke.Text & "</SGChoke>" & NL
        sAns &= "       <Caliber3>" & txtCaliber3.Text & "</Caliber3>" & NL
        sAns &= "       <TwistOfRate>" & txtTwistOfRate.Text & "</TwistOfRate>" & NL
        sAns &= "       <TriggerPull>" & txtTriggerPull.Text & "</TriggerPull>" & NL
        sAns &= "       <BoundBook>" & chkBoundBook.Checked & "</BoundBook>" & NL
        sAns &= "       <Classification>" & txtClassification.Text & "</Classification>" & NL
        sAns &= "       <DateofCR>" & dtpDateofCR.Value & "</DateofCR>" & NL
        sAns &= "    </Details>" & NL
        Return sAns
    End Function
    Function XML_GenerateAss() As String
        Dim sAns As String = ""
        Dim NL As String = Chr(10) & Chr(13)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Accessories where GID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While RS.Read
                    sAns &= "    <Accessories>" & NL
                    sAns &= "       <Manufacturer>" & RS("Manufacturer") & "</Manufacturer>" & NL
                    sAns &= "       <Model>" & RS("Model") & "</Model>" & NL
                    sAns &= "       <SerialNumber>" & RS("SerialNumber") & "</SerialNumber>" & NL
                    sAns &= "       <Condition>" & RS("Condition") & "</Condition>" & NL
                    sAns &= "       <Notes>" & RS("Notes") & "</Notes>" & NL
                    sAns &= "       <Use>" & RS("Use") & "</Use>" & NL
                    sAns &= "       <PurValue>" & RS("PurValue") & "</PurValue>" & NL
                    sAns &= "    </Accessories>" & NL
                End While
            Else
                sAns &= "    <Accessories>" & NL
                sAns &= "    </Accessories>" & NL
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GenerateAss"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Function XML_GenerateMaint() As String
        Dim sAns As String = ""
        Dim NL As String = Chr(10) & Chr(13)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Maintance_Details where GID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While RS.Read
                    sAns &= "    <Maintance_Details>" & NL
                    sAns &= "       <Name>" & RS("Name") & "</Name>" & NL
                    sAns &= "       <OpDate>" & RS("OpDate") & "</OpDate>" & NL
                    sAns &= "       <OpDueDate>" & RS("OpDueDate") & "</OpDueDate>" & NL
                    sAns &= "       <RndFired>" & RS("RndFired") & "</RndFired>" & NL
                    sAns &= "       <Notes>" & RS("Notes") & "</Notes>" & NL
                    sAns &= "    </Maintance_Details>" & NL
                End While
            Else
                sAns &= "    <Maintance_Details>" & NL
                sAns &= "    </Maintance_Details>" & NL
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateMaint"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Function XML_GenerateGSmith() As String
        Dim sAns As String = ""
        Dim NL As String = Chr(10) & Chr(13)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from GunSmith_Details where GID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While RS.Read
                    sAns &= "    <GunSmith_Details>" & NL
                    sAns &= "       <gsmith>" & RS("gsmith") & "</gsmith>" & NL
                    sAns &= "       <sdate>" & RS("sdate") & "</sdate>" & NL
                    sAns &= "       <rdate>" & RS("rdate") & "</rdate>" & NL
                    sAns &= "       <od>" & RS("od") & "</od>" & NL
                    sAns &= "       <notes>" & RS("notes") & "</notes>" & NL
                    sAns &= "    </GunSmith_Details>" & NL
                End While
            Else
                sAns &= "    <GunSmith_Details>" & NL
                sAns &= "    </GunSmith_Details>" & NL
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateGSmith"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Function XML_GenerateBarrelConversKit() As String
        Dim sAns As String = ""
        Dim NL As String = Chr(10) & Chr(13)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Ext where GID=" & ItemId
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While RS.Read
                    sAns &= "    <BarrelConverstionKit_Details>" & NL
                    sAns &= "       <ModelName>" & RS("ModelName") & "</ModelName>" & NL
                    sAns &= "       <Caliber>" & RS("Caliber") & "</Caliber>" & NL
                    sAns &= "       <Finish>" & RS("Finish") & "</Finish>" & NL
                    sAns &= "       <BarrelLength>" & RS("BarrelLength") & "</BarrelLength>" & NL
                    sAns &= "       <PetLoads>" & RS("PetLoads") & "</PetLoads>" & NL
                    sAns &= "       <Action>" & RS("Action") & "</Action>" & NL
                    sAns &= "       <Feedsystem>" & RS("Feedsystem") & "</Feedsystem>" & NL
                    sAns &= "       <Sights>" & RS("Sights") & "</Sights>" & NL
                    sAns &= "       <PurchasedPrice>" & RS("PurchasedPrice") & "</PurchasedPrice>" & NL
                    sAns &= "       <PurchasedFrom>" & RS("PurchasedFrom") & "</PurchasedFrom>" & NL
                    sAns &= "       <dtp>" & RS("dtp") & "</dtp>" & NL
                    sAns &= "       <Height>" & RS("Height") & "</Height>" & NL
                    sAns &= "       <Type>" & RS("Type") & "</Type>" & NL
                    sAns &= "       <IsDefault>" & RS("IsDefault") & "</IsDefault>" & NL
                    sAns &= "    </BarrelConverstionKit_Details>" & NL
                End While
            Else
                sAns &= "    <BarrelConverstionKit_Details>" & NL
                sAns &= "    </BarrelConverstionKit_Details>" & NL
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "XML_GenerateBarrelConversKit"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
#End Region
    Sub DoEditAssItem()
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmEditAccessory.MdiParent = Me.MdiParent
        frmEditAccessory.ItemID = ItemID
        frmEditAccessory.Show()
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Call DoEditAssItem()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim ItemID As String = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
        frmCopyAccessory.MdiParent = Me.MdiParent
        frmCopyAccessory.ItemID = ItemID
        frmCopyAccessory.Show()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frmNew As New frmEditCollectionDetails
        frmNew.ItemID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Cursor = Cursors.WaitCursor
        Call CheckDefaultPic(ItemId)
        Dim frmNew As New frmViewReport_FirearmDetails
        frmNew.intID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub


    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Cursor = Cursors.WaitCursor
        Call CheckDefaultPic(ItemId)
        Dim frmNew As New frmViewReport_FirearmDetailsFullDetails()
        frmNew.intID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub btnAmmoReportByCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmmoReportByCal.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmNew As New frmViewReport_Ammo_By_Caliber
        frmNew.CAL = Trim(txtCal.Text)
        frmNew.PET = Trim(txtPetLoads.Text)
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim RowID As Long = DataGridView4.SelectedCells.Item(0).RowIndex
        DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView4.Rows(RowID).Selected = True
        Dim ItemID As String = DataGridView4.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New frmEditGunSmithLog
        frmNew.ID = ItemID
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim frmNew As New frmAddBarrelSystem
        frmNew.Gid = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub

    Private Sub btnVwAccessReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVwAccessReport.Click
        Dim frmNew As New frmViewReport_Accessories
        frmNew.GID = ItemId
        frmNew.Title = Me.Text
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub SetAsDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsDefaultToolStripMenuItem.Click
        Dim BID As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim ObjGF As New GlobalFunctions
        ObjGF.SwapDefaultBarrelSystems(BS_DEFAULTBARRELSYSTEMID, BID, ItemId)
        Call LoadData()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim BID As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim BNAME As String = DataGridView5.SelectedRows.Item(0).Cells.Item(1).Value
        Dim sAns As String = MsgBox("Are you sure you wish to delete " & BNAME & " from this firearm?", MsgBoxStyle.YesNo)
        Dim ObjGF As New GlobalFunctions
        If BS_DEFAULTBARRELSYSTEMID = BID Then
            MsgBox("This is set as the default Barrel/Unit for this firearm!" & Chr(13) & "Please set another item as the default before deleting this one!")
            Exit Sub
        Else
            Dim sMsg As String = ""
            ObjGF.DeleteBarrelSystem(BID, sMsg)
            MsgBox(sMsg)
            Call LoadData()
        End If
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        Dim BID As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New frmEditBarrelSystem
        frmNew.GID = ItemId
        frmNew.BID = BID
        frmNew.Recname = Me.Text
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Call LoadData()
    End Sub

    Private Sub btnGalleryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGalleryReport.Click
        Me.Cursor = Cursors.WaitCursor
        Dim newForm As New frmViewReport_Pictures
        newForm.MdiParent = Me.MdiParent
        newForm.MyGID = ItemId
        newForm.Title = Me.Text
        newForm.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub EditNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNotesToolStripMenuItem.Click
        Dim MyIndex As String = ListView1.FocusedItem.Index
        Dim ItemCount As Integer = ListView1.Items.Count
        Dim MyText As String = ListView1.Items(CInt(MyIndex)).Text
        Dim frmNew As New frmEditPicturedetails
        frmNew.MdiParent = Me.MdiParent
        frmNew.PID = CLng(MyText)
        frmNew.Show()
    End Sub
    'Delete maintenance details from firearm
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Try
            Dim RowID As Long = DataGridView3.SelectedCells.Item(0).RowIndex
            DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView3.Rows(RowID).Selected = True
            Dim MID As Long = DataGridView3.SelectedRows.Item(0).Cells.Item(0).Value
            Dim sAns As String = MsgBox("Are you sure you wish to delete this maintenance record?", MsgBoxStyle.YesNo)
            Dim Obj As New BSDatabase
            Dim SQL As String = "DELETE from Maintance_Details where ID=" & MID
            Obj.ConnExec(SQL)
            Call LoadMaintData()
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem1_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'get the id of the maintenance details ID and pass that ID to the edit Maintance form
    Sub RunEditMaintenance()
        Try
            Dim RowID As Long = DataGridView3.SelectedCells.Item(0).RowIndex
            DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView3.Rows(RowID).Selected = True
            Dim MID As Long = DataGridView3.SelectedRows.Item(0).Cells.Item(0).Value
            Dim frmNew As New frmEditMaintenance
            frmNew.MID = MID
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "RunEditMaintenance"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Context menu for Maintenance editing
    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click
        Call RunEditMaintenance()
    End Sub
    'bring up the Stolen Form when the Stole button was clicked in the sale and disposition tab
    Private Sub btnStolen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStolen.Click
        Dim frmNew As New frmStolen
        frmNew.MdiParent = Me.MdiParent
        frmNew.ItemID = ItemId
        frmNew.Show()
        Me.Close()
    End Sub
    'Create a report to print when the Print Sale button is clicked
    Private Sub btnPrintSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSale.Click
        Dim frmNew As New frmViewReport_FirearmSaleInvoice
        frmNew.MdiParent = Me.MdiParent
        frmNew.USER_ID = SellerId
        frmNew.FIREARM_ID = ItemId
        frmNew.Show()
    End Sub
    'Show appriaser details when the appriaser is clicked
    Private Sub txtAppBy_Click(sender As Object, e As System.EventArgs)
        Dim ObjGF As New GlobalFunctions
        Dim AppraiserID As Long = ObjGF.GetID("SELECT ID from Appriaser_Contact_Details where aName='" & txtAppBy.Text & "'")
        Dim NewForm As New frmViewAppraiserDetails
        NewForm.ShopID = AppraiserID
        NewForm.MdiParent = Me.MdiParent
        NewForm.Show()
    End Sub

    Private Sub DataGridView6_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellContentDoubleClick
        Dim DID As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        frmViewDocuments.GetDocumentfromDB(DID)
    End Sub

    Private Sub btnAddDocument_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDocument.Click
        Dim frmNew As New frmAddDocument
        frmNew.GID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub btnAddExistingDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExistingDoc.Click
        Dim frmNew As New frmLinkFromExistingDoc
        frmNew.GID = ItemId
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub

    Private Sub EditToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem3.Click
        Dim DID As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        Dim frmNew As New frmAddDocument
        frmNew.EditMode = True
        frmNew.DID = DID
        frmNew.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim DID As String = DataGridView6.SelectedRows.Item(0).Cells.Item(1).Value
        frmViewDocuments.GetDocumentfromDB(DID)
    End Sub

    Private Sub UnLinkToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnLinkToolStripMenuItem.Click
        Try
            Dim DID As String = DataGridView6.SelectedRows.Item(0).Cells.Item(0).Value
            Dim SQL As String = "delete from Gun_Collection_Docs_Links where id=" & DID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            Obj = Nothing
            MsgBox("Document was unlinked!")
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "UnLinkToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub MoveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MoveToolStripMenuItem.Click
        Dim BID As Long = DataGridView5.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frmNew As New frmMoveBarrelConKit
        frmNew.BarrelID = BID
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
End Class