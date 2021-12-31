Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.PeopleAndPlaces

''' <summary>
''' Class FrmStolen.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmStolen
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' Handles the Load event of the frmStolen control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmStolen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    Sub SaveData()
        Try
            ''TODO #50 Convert This section
            Dim strName As String = FluffContent("CASE ID:" & txtCaseNo.Text)
            Dim strAddress1 As String = FluffContent("N/A")
            Dim strAddress2 As String = FluffContent("N/A")
            Dim strCity As String = FluffContent("N/A")
            Dim strZip As String = FluffContent("N/A")
            Dim strState As String = FluffContent("N/A")
            Dim strPhone As String = FluffContent("N/A")
            Dim strCountry As String = FluffContent("N/A")
            Dim strFax As String = FluffContent("N/A")
            Dim stremail As String = FluffContent("N/A")
            Dim strWebsite As String = FluffContent("N/A")
            Dim strLic As String = FluffContent("")
            Dim strDLic As String = FluffContent("STOLEN FIREARM")
            Dim strDob As String = dtpStolen.Value.Date
            Dim strRes As String = FluffContent("N/A")
            Dim sFinalPrice As String = FluffContent("0.00")
            Dim bid As Long
            Dim obj As New BSDatabase
            'Dim objo As New GlobalFunctions
            Dim errOut as String = ""
            If Not Helpers.IsRequired(strDLic, "Case Number", Text,errOut ) Then Exit Sub

            If Not Buyers.Exists(DatabasePath, strName, strAddress1, strAddress2, strCity, strState, strZip, strDob, strDLic, errOut)
                if Not Buyers.Add(DatabasePath, strName, strAddress1, strAddress2, strCity, strState, strZip, strPhone, strCountry,
                                  stremail, strLic, strWebsite, strFax, strDob, strDLic, strRes, errOut) Then Throw New Exception(errOut)
            End If
            'If Not objo.StolenBuyerExists(strName) Then
            '    Dim sql As String = "INSERT INTO Gun_Collection_SoldTo(Name,Address1," & _
            '                        "Address2,City,State,Country,Phone,fax,website,email," & _
            '                        "lic,DOB,Dlic,Resident,ZipCode,sync_lastupdate) VALUES('" & strName & "','" & _
            '                        strAddress1 & "','" & strAddress2 & "','" & strCity & "','" & _
            '                        strState & "','" & strCountry & "','" & strPhone & "','" & _
            '                        strFax & "','" & strWebsite & "','" & stremail & "','" & _
            '                        strLic & "','" & strDob & "','" & strDLic & "','" & _
            '                        strRes & "','" & strZip & "',Now())"
            '    obj.ConnExec(sql)
            'End If
            'bid = objo.GetID("SELECT ID from Gun_Collection_SoldTo where Name='" & strName & "'")
            bid = Buyers.GetId(DatabasePath,"SELECT ID from Gun_Collection_SoldTo where Name='" & strName & "'", errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            Dim uSql As String = "UPDATE Gun_Collection set ItemSold=2,BID=" & bid & ",dtSold='" & dtpStolen.Value & "',AppraisedValue='" & sFinalPrice & "',sync_lastupdate=Now() where ID=" & ItemId
            obj.ConnExec(uSql)
            'If Not MyCollection.MarkAsStolen(DatabasePath,Convert.ToInt32(ItemId), Convert.ToInt32(bid),dtpStolen.Value,"0.00", errOut ) Then Throw New Exception(errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        MDIParent1.RefreshCollection()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
End Class