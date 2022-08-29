Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmSettings.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmSettings
    ''' <summary>
    ''' The record identifier
    ''' </summary>
    Dim _recId As Integer
    ''' <summary>
    ''' The first run
    ''' </summary>
    Dim _firstRun As Boolean
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' Handles the Load event of the frmSettings control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _firstRun = True
        Try
            Call GetData()
            Call GetRegData()
            If Not ChkPassword.Checked Then
                txtPWD.Enabled = False
                txtCPWD.Enabled = False
                txtLogin.Enabled = False
                txtPhrase.Enabled = False
                txtWord.Enabled = False
            End If
            _firstRun = False
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the ChkPassword control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ChkPassword_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChkPassword.CheckedChanged
        Try
            If Not ChkPassword.Checked Then
                txtPWD.Enabled = False
                txtCPWD.Enabled = False
                txtLogin.Enabled = False
                txtPhrase.Enabled = False
                txtWord.Enabled = False
            Else
                txtPWD.Enabled = True
                txtCPWD.Enabled = True
                txtLogin.Enabled = True
                txtPhrase.Enabled = True
                txtWord.Enabled = True
            End If
        Catch ex As Exception
            Call LogError(Name, "ChkPassword_CheckedChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnExit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    ''' <summary>
    ''' Gets the data.
    ''' </summary>
    Sub GetData()
        Try
            Dim lst as List(Of OwnerInfo) = OwnerInformation.GetOwnerInfo(DatabasePath, _errOut)
            If _errOut.Length > 0 then Throw New Exception(_errOut)
            For Each o As OwnerInfo In lst
                _recId = o.Id
                txtName.Text = o.Name
                txtAddress.Text = o.Address
                txtCity.Text = o.City
                txtState.Text = o.State
                txtZip.Text = o.ZipCode
                txtPhone.Text = o.Phone
                txtCCD.Text = o.Ccdwl
                ChkPassword.Checked = o.UsePassword
                If o.UsePassword Then
                    txtPWD.Text = o.Password
                    txtCPWD.Text = txtPWD.Text
                    txtLogin.Text = o.UserName
                    txtPhrase.Text = o.ForgotPhrase
                    txtWord.Text = o.ForgotWord
                End If
            Next
        Catch ex As Exception
            Call LogError(Name, "GetData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the reg data.
    ''' </summary>
    Private Sub GetRegData()
        Try
            MyRegistry.GetSettings(lblLastSuc.Text, chkAOBU.Checked, nudDays.Value, chkBAKCleanup.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
        
        Catch ex As Exception
            Call LogError(Name, "GetRegData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Function SaveData() As Integer
        Try
            If Not MyRegistry.SaveSettings("0000", chkBAKCleanup.Checked, Convert.ToInt32(nudDays.Value), False, chkAOBU.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked, _errOut) Then Throw New Exception(_errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            DoAutoBackup = chkBackupOnExit.Checked
            DoOriginalImage = chkDoOriginalImage.Checked
            UsePetLoads = chkPetLoads.Checked
            PersonalMark = chkIPer.Checked
            Auditammo = chkAAP.Checked
            UseNumberCatOnly = chkNCCID.Checked
            Useautoassign = chkAACID.Checked
            Disableuniquecustcatid = chkUnique.Checked
            Useselectiveboundbook = chkSelectiveBoundBook.Checked
            Dim strName As String = FluffContent(txtName.Text)
            Dim strAddress As String = FluffContent(txtAddress.Text)
            Dim strCity As String = FluffContent(txtCity.Text)
            Dim strState As String = FluffContent(txtState.Text)
            Dim strZipCode As String = FluffContent(txtZip.Text)
            Dim strPhone As String = FluffContent(txtPhone.Text)
            Dim strCcd As String = FluffContent(txtCCD.Text)
            Dim strPwd As String = FluffContent(txtPWD.Text)
            Dim strCpwd As String = FluffContent(txtCPWD.Text)
            Dim strPhrase As String = FluffContent(txtPhrase.Text)
            Dim strWord As String = FluffContent(txtWord.Text)
            Dim strUid As String = txtLogin.Text
            OwnerLic = txtCCD.Text
            If Len(strUid) = 0 Then strUid = "admin"
            strUid = FluffContent(strUid)

' ReSharper disable once VbUnreachableCode
            If Not Helpers.IsRequired(strName, "Name", Text, _errOut) Then Return 1 : Exit Function
            If ChkPassword.Checked Then
' ReSharper disable once VbUnreachableCode
                If Not Helpers.IsRequired(txtLogin.Text, "User Name", Text, _errOut) Then Return 1 : Exit Function
' ReSharper disable once VbUnreachableCode
                If Not Helpers.IsRequired(txtPWD.Text, "Password", Text, _errOut) Then Return 1 : Exit Function
' ReSharper disable once VbUnreachableCode
                If Not Helpers.IsRequired(txtPhrase.Text, "Forgot Phrase", Text, _errOut) Then Return 1 : Exit Function
' ReSharper disable VbUnreachableCode
                If Not Helpers.IsRequired(txtWord.Text, "Forgot Key Word", Text, _errOut) Then Return 1 : Exit Function
' ReSharper restore VbUnreachableCode
            End If
            If ChkPassword.Checked Then
                If InStr(strPwd, strCpwd, CompareMethod.Text) = 0 Then
                    MsgBox("Passwords do not match!", MsgBoxStyle.Critical, Text)
                    Return 1
' ReSharper disable once VbUnreachableCode
                    Exit Function
                End If
            End If
            If Not OwnerInformation.Update(DatabasePath, _recId, strName, strAddress, strCity , strState, strZipCode, strPhone, strCcd, ChkPassword.Checked, strPwd, strUid, strWord, strPhrase, _errOut) Then Throw New Exception(_errOut)
            
            If UseNumberCatOnly Then
                If Not MyCollection.SetCatalogType(DatabasePath, MyCollection.CatalogType.Numeric, _errOut) Then Throw New Exception(_errOut)
            Else
                If Not MyCollection.SetCatalogType(DatabasePath, MyCollection.CatalogType.Text, _errOut) Then Throw New Exception(_errOut)
            End If
            Return 0
        Catch ex As Exception
            Call LogError(Name, "SaveData", Err.Number, ex.Message.ToString)
        End Try
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If SaveData() = 0 Then
            Close()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnApply control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
        Call SaveData()
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the chkNCCID control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkNCCID_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkNCCID.CheckedChanged
        If Not _firstRun Then
            If chkNCCID.Checked Then
                If Not MyCollection.CatalogIsNumeric(DatabasePath, _errOut)
                    MsgBox("There are non-numeric numbers currently in the catalog!")
                    Dim sAns As String = MsgBox("Do you want to set new Numeric values for the Catalog ID?", MsgBoxStyle.YesNo)
                    If sAns = vbYes Then
                        If not MyCollection.SetCatalogValuesToNumeric(DatabasePath, _errOut) Then Throw New Exception(_errOut)
                        MsgBox("Remember to click on the Save button to apply these settings!")
                    Else
                        chkNCCID.Checked = False
                    End If
                End If
            End If
        End If
    End Sub
End Class