Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Types


''' <summary>
''' Class frmEditBarrelSystem.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditBarrelSystem
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' The recname
    ''' </summary>
    Public Recname As String
    ''' <summary>
    ''' The bid
    ''' </summary>
    Public Bid As Long
    ''' <summary>
    ''' Error container string
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Automatics the fill.
    ''' </summary>
    Sub AutoFill()
        Try
            txtCal.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.Gun.Cal(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtFeedSys.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.Feedsystem(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtSight.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.Sights(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtPetLoads.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.PetLoads(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtFinish.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.Finish(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtAction.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.Action(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtPurFrom.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.Gun.ShopDetails(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtSysType.AutoCompleteCustomSource =  BurnSoft.Applications.MGC.AutoFill.GunCollection.BarrelSysTypes(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

        Catch ex As Exception
            Call LogError(Name, "AutoFill", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        txtRecieverName.Text = Recname
        Try
            Dim lst As List(Of BarrelSystems) = BurnSoft.Applications.MGC.Firearms.ExtraBarrelConvoKits.GetList(DatabasePath, Bid, _errOut)

            For Each o As BarrelSystems In lst
                txtName.Text = Trim(o.ModelName)
                txtSysType.Text = Trim(o.ExtType)
                txtCal.Text = Trim(o.Caliber)
                txtBarLen.Text = Trim(o.BarrelLength)
                txtOvLen.Text = Trim(o.Height)
                txtFinish.Text = Trim(o.Finish)
                txtAction.Text = Trim(o.Action)
                txtFeedSys.Text = Trim(o.FeedSystem)
                txtSight.Text = Trim(o.Sights)
                txtPetLoads.Text = Trim(o.PetLoads)
                txtPurPrice.Text = Trim(o.PurchasedPrice)
                txtPurFrom.Text = Trim(o.PurchasedFrom)
            Next
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
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    Sub SaveData()
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

            If Not Helpers.IsRequired(sName, "Name", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(sysType, "System Type", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(cal, "Caliber", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(purPrice, "Purchase Price", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(purFrom, "Purchased From", Text, _errOut) Then Exit Sub

            If Not BurnSoft.Applications.MGC.Firearms.ExtraBarrelConvoKits.Update(DatabasePath, Bid,Gid,sName, cal, stockFinish, barLen, petLoads, fAction, feedSys, sights, purPrice, purFrom, ovalLen, sysType, _errOut ) Then Throw New Exception(_errOut)
            MdiParent.Refresh()
            Close()
        Catch ex As Exception
            Call LogError(Name, "SaveData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditBarrelSystem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditBarrelSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadData()
        Call AutoFill()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
End Class