Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.Applications.MGC.Types
''' <summary>
''' Class frmViewShopDetails.  This is the main form that will handle the ability to view and edit the gun shop details
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewShopDetails
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopId As String
    ''' <summary>
    ''' The shop name
    ''' </summary>
    Public ShopName As String
    ''' <summary>
    ''' Populates the data.
    ''' </summary>
    ''' <exception cref="Exception"></exception>
    Sub PopData()
        Try
            Dim errOut as String = ""
            Dim myList As List(Of GunShopDetails) = Shops.Get(DatabasePath,Convert.ToInt32(ShopId),errOut )
            If errOut.Length > 0 Then Throw New Exception(errOut)

            For Each o As GunShopDetails In myList
                txtName.Text = o.Name
                ShopName = o.Name
                txtAddress1.Text = o.Address1
                txtAddress2.Text = o.Address2
                txtCity.Text = o.City
                txtState.Text = o.State
                txtPhone.Text = o.Phone
                txtFax.Text = o.Fax
                txtWebSite.Text = o.WebSite
                txteMail.Text = o.Email
                txtLic.Text = o.Lic
                txtZip.Text = o.ZipCode
                chkSIB.Checked = o.StillInBusiness
            Next

        Catch ex As Exception
            Dim sSubFunc As String = "PopLoad"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewShopDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewShopDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Gun_CollectionTableAdapter.FillByShop(MGCDataSet.Gun_Collection, ShopId)
        Call PopData()
    End Sub
    ''' <summary>
    ''' Enables the form.
    ''' </summary>
    Sub EnabledForm()
        txtName.ReadOnly = False
        txtAddress1.ReadOnly = False
        txtAddress2.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
        txtCountry.ReadOnly = False
        txtPhone.ReadOnly = False
        txtFax.ReadOnly = False
        txteMail.ReadOnly = False
        txtLic.ReadOnly = False
        txtWebSite.ReadOnly = False
        chkSIB.Enabled = True
        btnUpdate.Visible = True
        btnEdit.Visible = False
    End Sub
    ''' <summary>
    ''' Disables the form.
    ''' </summary>
    Sub DisableForm()
        txtName.ReadOnly = True
        txtAddress1.ReadOnly = True
        txtAddress2.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        txtZip.ReadOnly = True
        txtCountry.ReadOnly = True
        txtPhone.ReadOnly = True
        txtFax.ReadOnly = True
        txteMail.ReadOnly = True
        txtLic.ReadOnly = True
        txtWebSite.ReadOnly = True
        chkSIB.Enabled = False
        btnEdit.Visible = True
        btnUpdate.Visible = False
    End Sub
    ''' <summary>
    ''' Handles the 1 event of the btnEdit_Click control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Call EnabledForm()
    End Sub
    ''' <summary>
    ''' Handles the 1 event of the btnCancel_Click control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    ''' <exception cref="Exception"></exception>
    ''' <exception cref="Exception"></exception>
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strAddress1 As String = FluffContent(txtAddress1.Text)
            Dim strAddress2 As String = FluffContent(txtAddress2.Text)
            Dim strCity As String = FluffContent(txtCity.Text)
            Dim strZip As String = FluffContent(txtZip.Text)
            Dim strState As String = FluffContent(txtState.Text)
            Dim strPhone As String = FluffContent(txtPhone.Text)
            Dim strCountry As String = FluffContent(txtCountry.Text)
            Dim strFax As String = FluffContent(txtFax.Text)
            Dim stremail As String = FluffContent(txteMail.Text)
            Dim strWebsite As String = FluffContent(txtWebSite.Text)
            Dim strLic As String = FluffContent(txtLic.Text)
            Dim errOut as String = ""

            If Not IsRequired(strName, "Name", Text) Then Exit Sub

            If Not Shops.Update(DatabasePath, Convert.ToInt32(ShopId), strName, strAddress1, strAddress2, strCity, strState, strZip,strCountry, strPhone, strFax, strWebsite, stremail, strLic,chkSIB.Checked, errOut) Then Throw New Exception(errOut)
            
            If String.Compare(FluffContent(ShopName), strName) <> 0 Then
                Dim sAns As String = MsgBox("Shop Name Changed from " & ShopName & " to " & txtName.Text & "!" & Chr(10) & "Do you wish to update all your firearms with the update?", vbYesNo, "ShopID Name Change Alert!")
                If sAns = vbYes Then
                    If Not MyCollection.UpdateShopName(DatabasePath, strName, ShopName, errOut) Then Throw New Exception(errOut)
                End If
            End If
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Call DisableForm()
    End Sub
End Class