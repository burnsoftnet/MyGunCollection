Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Public Class frmViewBuyers
    Sub RefreshList()
        Try
            Me.Gun_Collection_SoldToTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_SoldTo)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshList"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmViewBuyers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call RefreshList()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            Dim MyValue As Long = ListBox1.SelectedValue
            Dim frmNew As New frmViewBuyerDetails
            frmNew.MdiParent = Me.MdiParent
            frmNew.BuyerID = MyValue
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "ListBox1_DoubleClick"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Function HasCollectionAttached(ByVal strID As String) As Integer
        Dim iAns As Integer = 0
        Dim SQL As String = "SELECT Count(*) as Total from Gun_Collection where ItemSold=1 and BID=" & strID
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    iAns = RS("Total")
                End While
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Call Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "HasCollectionAttached"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function
    Private Function GetBuyerName(ByVal strID As String) As String
        Dim sAns As String = ""
        Dim SQL As String = "SELECT name from Gun_Collection_SoldTo where ID=" & strID
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    sAns = RS("name")
                End While
            End If
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Call Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetBuyerName"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim MyValue As Long = ListBox1.SelectedValue
            Dim strName As String = GetBuyerName(MyValue)
            Dim Obj As New BSDatabase
            Dim SQL As String = "DELETE from Gun_Collection_SoldTo where ID=" & MyValue
            Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strName & " from the database.", MsgBoxStyle.YesNo, "Delete a Buyer")
            Dim intColTotal As Integer = HasCollectionAttached(MyValue)
            If sMsg = vbYes Then
                If intColTotal <> 0 Then
                    MsgBox("Cannot delete " & strName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Buyer")
                Else
                    Obj.ConnExec(SQL)
                    Call RefreshList()
                End If
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton1_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Call RefreshList()
    End Sub
End Class