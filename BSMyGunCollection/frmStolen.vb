Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmStolen
    Public ItemID As String
    Public ASKINGPRICE As String
    Private Sub frmStolen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Sub SaveData()
        Try
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
            Dim strDOB As String = dtpStolen.Value.Date
            Dim strRes As String = FluffContent("N/A")
            Dim sFinalPrice As String = FluffContent("0.00")
            Dim BID As Long = 0
            Dim sLic As String = ""
            Dim Obj As New BSDatabase
            Dim Objo As New GlobalFunctions
            If Not IsRequired(strDLic, "Case Number", Me.Text) Then Exit Sub
            If Not Objo.StolenBuyerExists(strName) Then
                Dim SQL As String = "INSERT INTO Gun_Collection_SoldTo(Name,Address1," & _
                                    "Address2,City,State,Country,Phone,fax,website,email," & _
                                    "lic,DOB,Dlic,Resident,ZipCode,sync_lastupdate) VALUES('" & strName & "','" & _
                                    strAddress1 & "','" & strAddress2 & "','" & strCity & "','" & _
                                    strState & "','" & strCountry & "','" & strPhone & "','" & _
                                    strFax & "','" & strWebsite & "','" & stremail & "','" & _
                                    strLic & "','" & strDOB & "','" & strDLic & "','" & _
                                    strRes & "','" & strZip & "',Now())"
                Obj.ConnExec(SQL)
            End If
            BID = Objo.GetID("SELECT ID from Gun_Collection_SoldTo where Name='" & strName & "'")
            Dim uSQL As String = "UPDATE Gun_Collection set ItemSold=2,BID=" & BID & ",dtSold='" & dtpStolen.Value & "',AppraisedValue='" & sFinalPrice & "',sync_lastupdate=Now() where ID=" & ItemID
            Obj.ConnExec(uSQL)
            MDIParent1.RefreshCollection()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
End Class