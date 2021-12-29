Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmViewGunSmithDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewGunSmithDetails
    ''' <summary>
    ''' The shop identifier
    ''' </summary>
    Public ShopId As String
    ''' <summary>
    ''' The shop name
    ''' </summary>
    Public ShopName As String
    ''' <summary>
    ''' The error out container
    ''' </summary>
    Dim _errOut as String 
    ''' <summary>
    ''' Pops the data.
    ''' </summary>
    Sub PopData()
        Try
            Dim lst As List(Of GunSmithContacts) = GunSmiths.Get(DatabasePath, Convert.ToInt32(ShopId), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each l As GunSmithContacts In lst
                ShopName = l.Name
                txtName.Text = l.Name
                txtAddress1.Text = l.Address1
                txtAddress2.Text = l.Address2
                txtCity.Text = l.City
                txtState.Text = l.State
                txtCountry.Text =l.Country
                txtPhone.Text = l.Phone
                txtFax.Text = l.Fax
                txtWebSite.Text = l.WebSite
                txteMail.Text = l.Email
                txtLic.Text = l.Lic
                txtZip.Text = l.ZipCode
                chkSIB.Checked = l.StillInBusiness
            Next
        Catch ex As Exception
            Call LogError(Name, "PopLoad", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewGunSmithDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewGunSmithDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopData()
        Gun_Collection_GunSmithsTableAdapter.Fill(MGCDataSet.Gun_Collection_GunSmiths, txtName.Text)
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
        btnSave.Visible = True
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
        btnSave.Visible = False
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call EnabledForm()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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

            If Not Helpers.IsRequired(strName, "Name", Text, _errOut) Then Exit Sub

            If Not GunSmiths.Update(DatabasePath, Convert.ToInt32(ShopId), strName, strAddress1,
                                     strAddress2, strCity, strState, strZip,
                                     strCountry, strPhone, strFax, stremail,
                                     strLic, strWebsite, chkSIB.Checked, _errOut) Then Throw New Exception(_errOut)

            If String.Compare(FluffContent(ShopName), strName) <> 0 Then
                Dim sAns As String = MsgBox("Gunsmith Name Changed from " & ShopName & " to " & txtName.Text & "!" & Chr(10) & "Do you wish to update all your firearms with the update?", vbYesNo, "Gunsmith Name Change Alert!")
                If sAns = vbYes Then

                    If Not GunSmiths.UpdateSmithDetails(DatabasePath, FluffContent(ShopName), strName, _errOut) Then Throw New Exception(_errOut)
                End If
            End If
        Catch ex As Exception
            Call LogError(Name, "btnSave.Click", Err.Number, ex.Message.ToString)
        End Try
        Call DisableForm()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class