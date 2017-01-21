Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmCopyAccessory
    Public ItemID As String
    Private FullName As String
    Function GetFullName(ByVal strID As String) As String
        Dim sAns As String = ""
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                sAns = Trim(RS("Manufacturer")) & " " & Trim(RS("Model"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetFullName"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Sub DoCopy(ByVal StrID As String)
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim strMan As String = ""
            Dim strModel As String = ""
            Dim strSerial As String = ""
            Dim strCondition As String = ""
            Dim strUse As String = ""
            Dim strPurVal As String = ""
            Dim strNotes As String = ""
            Dim strAppVal As String = "0"
            Dim iCIV As Integer = 0
            Dim IC As Integer = 0

            While RS.Read
                strMan = RS("Manufacturer")
                strModel = RS("Model")
                strSerial = RS("SerialNumber")
                strCondition = RS("Condition")
                strUse = RS("Use")
                strPurVal = RS("PurValue")
                strNotes = RS("Notes")
                If Not IsDBNull(RS("AppValue")) Then strAppVal = RS("AppValue")
                If Not IsDBNull(RS("CIV")) Then iCIV = RS("CIV")
                If Not IsDBNull(RS("IC")) Then IC = RS("IC")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            SQL = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,sync_lastupdate,AppValue,CIV,IC) VALUES(" & _
                        StrID & ",'" & strMan & "','" & strModel & "','" & strSerial & "','" & strCondition & "','" & _
                        strNotes & "','" & strUse & "','" & strPurVal & "',Now(),'" & strAppVal & "'," & iCIV & "," & IC & ")"
            Call Obj.ConnExec(SQL)
        Catch ex As Exception
            Dim sSubFunc As String = "DoCopy"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmCopyAccessory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.QryGunCollectionDetailsTableAdapter.FillBy_Default(Me.MGCDataSet.qryGunCollectionDetails)
            FullName = GetFullName(ItemID)
            Label1.Text &= FullName
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            Dim strFireArmID As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text
            Call DoCopy(strFireArmID)
            Dim strMsg As String = FullName & " was copied to " & strFireArmName
            Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to copy it to another item?", MsgBoxStyle.YesNo, Me.Text)
            If sAns = vbNo Then Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnCopy.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class