Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Security.RegularEncryption.SHA

''' <summary>
''' Class frmSettings.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmSettings
    ''' <summary>
    ''' The record identifier
    ''' </summary>
    Dim _recId As Integer
    ''' <summary>
    ''' The first run
    ''' </summary>
    Dim _firstRun As Boolean
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
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "ChkPassword_CheckedChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim obj As New BSDatabase
            Dim intUsePass As Integer
            Call obj.ConnectDB()
            Dim sql As String = "SELECT TOP 1 * from Owner_Info"
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                rs.Read()
                _recId = CInt(rs("ID"))
                txtName.Text = Trim(rs("name"))
                txtAddress.Text = Trim(One.Decrypt(rs("address")))
                txtCity.Text = Trim(rs("City"))
                txtState.Text = Trim(rs("State"))
                txtZip.Text = Trim(rs("Zip"))
                txtPhone.Text = Trim(rs("Phone"))
                txtCCD.Text = Trim(One.Decrypt(rs("CCDWL")))
                intUsePass = CInt(rs("UsePWD"))
                If intUsePass = 1 Then
                    txtPWD.Text = Trim(One.Decrypt(rs("PWD")))
                    txtCPWD.Text = Trim(txtPWD.Text)
                    ChkPassword.Checked = True
                    txtLogin.Text = Trim(One.Decrypt(rs("UID")))
                    txtPhrase.Text = Trim(One.Decrypt(rs("forgot_phrase")))
                    txtWord.Text = Trim(One.Decrypt(rs("forgot_word")))
                Else
                    ChkPassword.Checked = False
                End If
            Else
                _recId = 0
            End If
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Gets the reg data.
    ''' </summary>
    Private Sub GetRegData()
        Try
            Dim objR As New BSRegistry
            Call objR.GetSettings(lblLastSuc.Text, chkAOBU.Checked, nudDays.Value, chkBAKCleanup.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked)
        Catch ex As Exception
            Dim sSubFunc As String = "GetRegData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Function SaveData() As Integer
        Try
            Dim objR As New BSRegistry
            objR.SaveSettings("0000", chkBAKCleanup.Checked, nudDays.Value, False, False, chkAOBU.Checked, chkBackupOnExit.Checked, chkDoOriginalImage.Checked, chkPetLoads.Checked, chkIPer.Checked, chkNCCID.Checked, chkAAP.Checked, chkAACID.Checked, chkUnique.Checked, chkSelectiveBoundBook.Checked)
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
            Dim strAddress As String = One.Encrypt(FluffContent(txtAddress.Text))
            Dim strCity As String = FluffContent(txtCity.Text)
            Dim strState As String = FluffContent(txtState.Text)
            Dim strZipCode As String = FluffContent(txtZip.Text)
            Dim strPhone As String = FluffContent(txtPhone.Text)
            Dim strCcd As String = One.Encrypt(FluffContent(txtCCD.Text))
            Dim strPwd As String = One.Encrypt(FluffContent(txtPWD.Text))
            Dim strCpwd As String = One.Encrypt(FluffContent(txtCPWD.Text))
            Dim strPhrase As String = One.Encrypt(FluffContent(txtPhrase.Text))
            Dim strWord As String = One.Encrypt(FluffContent(txtWord.Text))
            Dim strUid As String = txtLogin.Text
            OwnerLic = txtCCD.Text
            If Len(strUid) = 0 Then strUid = "admin"
            strUid = One.Encrypt(FluffContent(strUid))
            Dim bUsePassword As Boolean = ChkPassword.Checked
            Dim iUsePassword As Integer = 0
' ReSharper disable VbUnreachableCode
            If Not IsRequired(strName, "Name", Text) Then Return 1 : Exit Function
            If ChkPassword.Checked Then
                If Not IsRequired(txtLogin.Text, "User Name", Text) Then Return 1 : Exit Function
                If Not IsRequired(txtPWD.Text, "Password", Text) Then Return 1 : Exit Function
                If Not IsRequired(txtPhrase.Text, "Forgot Phrase", Text) Then Return 1 : Exit Function
                If Not IsRequired(txtWord.Text, "Forgot Key Word", Text) Then Return 1 : Exit Function
            End If
            If bUsePassword Then
                If InStr(strPwd, strCpwd, CompareMethod.Text) = 0 Then
                    MsgBox("Passwords do not match!", MsgBoxStyle.Critical, Text)
                    Return 1
                    Exit Function
                End If
            End If
            ' ReSharper restore VbUnreachableCode
            If bUsePassword Then iUsePassword = 1
            Dim obj As New BSDatabase
            Dim sql As String
            If _recId = 0 Then
                sql = "INSERT INTO Owner_Info(name,address,City,State,Zip,Phone,CCDWL,UsePWD,PWD,UID,forgot_word,forgot_phrase,sync_lastupdate) VALUES('" &
                            strName & "','" & strAddress & "','" & strCity & "','" & strState & "','" & strZipCode & "','" &
                            strPhone & "','" & strCcd & "'," & iUsePassword & ",'" & strPwd & "','" & strUid & "','" &
                            strWord & "','" & strPhrase & "',Now())"
            Else
                sql = "UPDATE Owner_Info set Name='" & strName & "',address='" & strAddress & "',City='" &
                        strCity & "',Zip='" & strZipCode & "',State='" & strState & "',Phone='" & strPhone & "',CCDWL='" & strCcd &
                        "',UsePWD=" & iUsePassword & ",PWD='" & strPwd & "', UID='" & strUid & "', forgot_word='" &
                        strWord & "', forgot_phrase='" & strPhrase & "',sync_lastupdate=Now() where ID=" & _recId
            End If
            obj.ConnExec(sql)
            Dim objGf As New GlobalFunctions
            If UseNumberCatOnly Then
                Call objGf.SetCatalogType("num")
            Else
                Call objGf.SetCatalogType("let")
            End If
            Return 0
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
                Dim objGf As New GlobalFunctions
                If Not objGf.CatalogIsNumeric Then
                    MsgBox("There are non-numeric numbers currently in the catalog!")
                    Dim sAns As String = MsgBox("Do you want to set new Numeric values for the Catalog ID?", MsgBoxStyle.YesNo)
                    If sAns = vbYes Then
                        Call objGf.SetCatalogValuesToNumeric()
                        MsgBox("Remember to click on the Save button to apply these settings!")
                    Else
                        chkNCCID.Checked = False
                    End If
                End If
            End If
        End If
    End Sub
End Class