Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmAddBarrelSystem.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddBarrelSystem
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' Automatics the fill.
    ''' </summary>
    Sub AutoFill()
        Try
            Dim errOut As String = ""
            txtCal.AutoCompleteCustomSource = Ammo.Caliber(DatabasePath,errOut )
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtFeedSys.AutoCompleteCustomSource = GunCollection.Feedsystem(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtSight.AutoCompleteCustomSource = GunCollection.Sights(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtPetLoads.AutoCompleteCustomSource = Ammo.Caliber(DatabasePath,errOut )
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtFinish.AutoCompleteCustomSource = GunCollection.Finish(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtAction.AutoCompleteCustomSource = GunCollection.Action(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtPurFrom.AutoCompleteCustomSource = Gun.ShopDetails(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtSysType.AutoCompleteCustomSource = GunCollection.BarrelSysTypes(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
        Catch ex As Exception
            Call LogError(Name, "AutoFill", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim errOut as String = ""
            Dim lst as List(Of BarrelSystems) = ExtraBarrelConvoKits.GetCurrentBarrelDetailstList(DatabasePath, Gid, errOut)

            For Each o As BarrelSystems In lst
                txtRecieverName.Text = o.FullName
                txtBarLen.Text = o.BarrelLength
                txtOvLen.Text = o.Height
                txtAction.Text = o.Action
                txtFeedSys.Text = o.FeedSystem
                txtSight.Text = o.Sights
                txtPetLoads.Text = o.PetLoads
                txtPurPrice.Text = o.PurchasedPrice
                txtPurFrom.Text = o.PurchasedFrom
                txtFinish.Text = o.Finish
            Next

        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddBarrelSystem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddBarrelSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call AutoFill()
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim sName As String = FluffContent(txtName.Text)
            Dim sysType As String = FluffContent(txtSysType.Text)
            Dim cal As String = FluffContent(txtCal.Text)
            Dim barLen As String = FluffContent(txtBarLen.Text)
            Dim ovalLen As String = FluffContent(txtOvLen.Text)
            Dim stockFinish As String = FluffContent(txtFinish.Text)
            Dim fAction As String = FluffContent(txtAction.Text)
            Dim feedSys As String = FluffContent(txtFeedSys.Text)
            Dim sights As String = FluffContent(txtSight.Text)
            Dim petLoads As String = FluffContent(txtPetLoads.Text)
            Dim purPrice As String = FluffContent(txtPurPrice.Text)
            Dim purFrom As String = FluffContent(txtPurFrom.Text)
            Dim errOut as String = ""

            If Not Helpers.IsRequired(sName, "Name", Text,errOut) Then Exit Sub
            If Not Helpers.IsRequired(sysType, "System Type", Text,errOut) Then Exit Sub
            If Not Helpers.IsRequired(cal, "Caliber", Text,errOut) Then Exit Sub
            If Not Helpers.IsRequired(purPrice, "Purchase Price", Text,errOut) Then Exit Sub
            If Not Helpers.IsRequired(purFrom, "Purchased From", Text,errOut) Then Exit Sub

            if Not ExtraBarrelConvoKits.Add(DatabasePath, Gid, sName, cal, stockFinish, barLen, petLoads, fAction, feedSys, sights, purPrice, purFrom,ovalLen, sysType, chkSetDefault.Checked, DateTime.Now, errOut) Then Throw New Exception(errOut)
            Dim barrelId As Long = ExtraBarrelConvoKits.GetBarrelId(DatabasePath, Gid, errOut)
            If Not ExtraBarrelConvoKits.AddLink(DatabasePath, barrelId, Gid, errOut) Then Throw New Exception(errOut)
            Dim defaultBarrelId As Long

            If chkSetDefault.Checked Then
                defaultBarrelId = ExtraBarrelConvoKits.GetBarrelId(DatabasePath, Gid, errOut, true)
                If Not ExtraBarrelConvoKits.SwapDefaultBarrelSystems(DatabasePath, defaultBarrelId, barrelId, Gid, errOut) then Throw New Exception(errOut)
            End If
            Dim frmNew As New FrmViewCollectionDetails
            frmNew.GunId = Gid
            frmNew.MdiParent = MdiParent
            frmNew.Show()
            Close()

        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class