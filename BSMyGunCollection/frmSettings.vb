Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmSettings.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmSettings
    ''' <summary>
    ''' The record identifier
    ''' </summary>
    Dim RecID As Integer
    ''' <summary>
    ''' The first run
    ''' </summary>
    Dim FirstRun As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmSettings control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstRun = True
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
            FirstRun = False
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the ChkPassword control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ChkPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPassword.CheckedChanged
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
            Dim sSubFunc As String = "ChkPassword_CheckedChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnExit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Gets the data.
    ''' </summary>
    Sub GetData()
        Try
            Dim Obj As New BSDatabase
            Dim intUsePass As Integer
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT TOP 1 * from Owner_Info"
            Dim CMD As New Odbc.OdbcCommand(SQL, Obj.Conn)
            Dim RS As Odbc.OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                RS.Read()
                RecID = CInt(RS("ID"))
                txtName.Text = Trim(RS("name"))
                txtAddress.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("address")))
                txtCity.Text = Trim(RS("City"))
                txtState.Text = Trim(RS("State"))
                txtZip.Text = Trim(RS("Zip"))
                txtPhone.Text = Trim(RS("Phone"))
                txtCCD.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("CCDWL")))
                intUsePass = CInt(RS("UsePWD"))
                If intUsePass = 1 Then
                    txtPWD.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("PWD")))
                    txtCPWD.Text = Trim(txtPWD.Text)
                    ChkPassword.Checked = True
                    txtLogin.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("UID")))
                    txtPhrase.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("forgot_phrase")))
                    txtWord.Text = Trim(BurnSoft.Security.RegularEncryption.SHA.One.Decrypt(RS("forgot_word")))
                Else
                    ChkPassword.Checked = False
                End If
            Else
                RecID = 0
            End If
            RS.Close()
            CMD = Nothing
            RS = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the reg data.
    ''' </summary>
    Private Sub GetRegData()
        Try
            Dim ObjR As New BSRegistry
            Call ObjR.GetSettings(lblLastSuc.Text, chkAOBU.Checked, nudDays.Value, chkBAKCleanup.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked)
        Catch ex As Exception
            Dim sSubFunc As String = "GetRegData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Function SaveData() As Integer
        Try
            Dim ObjR As New BSRegistry
            ObjR.SaveSettings("0000", chkBAKCleanup.Checked, nudDays.Value, False, False, chkAOBU.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked)
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
            Dim strAddress As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtAddress.Text))
            Dim strCity As String = FluffContent(txtCity.Text)
            Dim strState As String = FluffContent(txtState.Text)
            Dim strZipCode As String = FluffContent(txtZip.Text)
            Dim strPhone As String = FluffContent(txtPhone.Text)
            Dim strCCD As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtCCD.Text))
            Dim strPWD As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtPWD.Text))
            Dim strCPWD As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtCPWD.Text))
            Dim strPhrase As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtPhrase.Text))
            Dim strWord As String = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(txtWord.Text))
            Dim strUID As String = txtLogin.Text
            OwnerLic = txtCCD.Text
            If Len(strUID) = 0 Then strUID = "admin"
            strUID = BurnSoft.Security.RegularEncryption.SHA.One.Encrypt(FluffContent(strUID))
            Dim bUsePassword As Boolean = ChkPassword.Checked
            Dim iUsePassword As Integer = 0
            If Not IsRequired(strName, "Name", Me.Text) Then Return 1 : Exit Function
            If ChkPassword.Checked Then
                If Not IsRequired(txtLogin.Text, "User Name", Me.Text) Then Return 1 : Exit Function
                If Not IsRequired(txtPWD.Text, "Password", Me.Text) Then Return 1 : Exit Function
                If Not IsRequired(txtPhrase.Text, "Forgot Phrase", Me.Text) Then Return 1 : Exit Function
                If Not IsRequired(txtWord.Text, "Forgot Key Word", Me.Text) Then Return 1 : Exit Function
            End If
            If bUsePassword Then
                If InStr(strPWD, strCPWD, CompareMethod.Text) = 0 Then
                    MsgBox("Passwords do not match!", MsgBoxStyle.Critical, Me.Text)
                    Return 1
                    Exit Function
                End If
            End If
            If bUsePassword Then iUsePassword = 1
            Dim Obj As New BSDatabase
            Dim SQL As String
            If RecID = 0 Then
                SQL = "INSERT INTO Owner_Info(name,address,City,State,Zip,Phone,CCDWL,UsePWD,PWD,UID,forgot_word,forgot_phrase,sync_lastupdate) VALUES('" &
                            strName & "','" & strAddress & "','" & strCity & "','" & strState & "','" & strZipCode & "','" &
                            strPhone & "','" & strCCD & "'," & iUsePassword & ",'" & strPWD & "','" & strUID & "','" &
                            strWord & "','" & strPhrase & "',Now())"
            Else
                SQL = "UPDATE Owner_Info set Name='" & strName & "',address='" & strAddress & "',City='" &
                        strCity & "',Zip='" & strZipCode & "',State='" & strState & "',Phone='" & strPhone & "',CCDWL='" & strCCD &
                        "',UsePWD=" & iUsePassword & ",PWD='" & strPWD & "', UID='" & strUID & "', forgot_word='" &
                        strWord & "', forgot_phrase='" & strPhrase & "',sync_lastupdate=Now() where ID=" & RecID
            End If
            Obj.ConnExec(SQL)
            Dim ObjGF As New GlobalFunctions
            If UseNumberCatOnly Then
                Call ObjGF.SetCatalogType("num")
            Else
                Call ObjGF.SetCatalogType("let")
            End If
            Obj = Nothing
            Return 0
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If SaveData() = 0 Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnApply control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Call SaveData()
    End Sub
    ''' <summary>
    ''' Handles the CheckedChanged event of the chkNCCID control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkNCCID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNCCID.CheckedChanged
        If Not FirstRun Then
            If chkNCCID.Checked Then
                Dim ObjGF As New GlobalFunctions
                If Not ObjGF.CatalogIsNumeric Then
                    MsgBox("There are non-numeric numbers currently in the catalog!")
                    Dim sAns As String = MsgBox("Do you want to set new Numeric values for the Catalog ID?", MsgBoxStyle.YesNo)
                    If sAns = vbYes Then
                        Call ObjGF.SetCatalogValuesToNumeric()
                        MsgBox("Remember to click on the Save button to apply these settings!")
                    Else
                        chkNCCID.Checked = False
                    End If
                End If
            End If
        End If
    End Sub
End Class