Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmLinkDocToFirearm
    Public DocID As Long ' Document ID
    'When for first loads, populate dropdown list
    Private Sub frmLinkDocToFirearm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Gun_CollectionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection)
    End Sub
    Sub LinkDocToFirearm(GID As String)
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "INSERT INTO Gun_Collection_Docs_Links (GID,DID) VALUES(" & GID & "," & DocID & ")"
            Obj.ConnExec(SQL)
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LinkDocToFirearm"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnAttach_Click(sender As System.Object, e As System.EventArgs) Handles btnAttach.Click
        Try
            Dim strFireArmID As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text
            Call LinkDocToFirearm(strFireArmID)
            Dim strMsg As String = "Document was copied to " & strFireArmName
            Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to link it to another firearm?", MsgBoxStyle.YesNo, Me.Text)
            If sAns = vbNo Then Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAttach.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class