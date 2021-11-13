'Imports BSMyGunCollection.MGC
'Imports System.Data.Odbc
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.PeopleAndPlaces

''' <summary>
''' Class FrmViewBuyers.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewBuyers
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Refreshes the list.
    ''' </summary>
    Sub RefreshList()
        Try
            Gun_Collection_SoldToTableAdapter.Fill(MGCDataSet.Gun_Collection_SoldTo)
        Catch ex As Exception
            Dim sSubFunc As String = "RefreshList"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewBuyers control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewBuyers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Call RefreshList()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the DoubleClick event of the ListBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.DoubleClick
        Try
            Dim myValue As Long = ListBox1.SelectedValue
            Dim frmNew As New frmViewBuyerDetails
            frmNew.MdiParent = MdiParent
            frmNew.BuyerId = myValue
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "ListBox1_DoubleClick"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    'Private Function HasCollectionAttached(ByVal strId As String) As Integer
    '    Dim iAns As Integer = 0
    '    Dim sql As String = "SELECT Count(*) as Total from Gun_Collection where ItemSold=1 and BID=" & strId
    '    Try
    '        Dim obj As New BSDatabase
    '        Call obj.ConnectDB()
    '        Dim cmd As New OdbcCommand(sql, obj.Conn)
    '        Dim rs As OdbcDataReader
    '        rs = cmd.ExecuteReader
    '        If rs.HasRows Then
    '            While (rs.Read)
    '                iAns = rs("Total")
    '            End While
    '        End If
    '        rs.Close()
    '        Call obj.CloseDB()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "HasCollectionAttached"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try
    '    Return iAns
    'End Function
    'Private Function GetBuyerName(ByVal strId As String) As String
    '    Dim sAns As String = ""
    '    Dim sql As String = "SELECT name from Gun_Collection_SoldTo where ID=" & strId
    '    Try
    '        Dim obj As New BSDatabase
    '        Call obj.ConnectDB()
    '        Dim cmd As New OdbcCommand(sql, obj.Conn)
    '        Dim rs As OdbcDataReader
    '        rs = cmd.ExecuteReader
    '        If rs.HasRows Then
    '            While (rs.Read)
    '                sAns = rs("name")
    '            End While
    '        End If
    '        rs.Close()
    '        Call obj.CloseDB()
    '    Catch ex As Exception
    '        Dim sSubFunc As String = "GetBuyerName"
    '        Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
    '    End Try
    '    Return sAns
    'End Function
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim myValue As Long = ListBox1.SelectedValue
            'Dim strName As String = GetBuyerName(myValue)
            Dim strName As String = Buyers.GetName(DatabasePath, Convert.ToInt32(myValue), _errOut)
            'Dim obj As New BSDatabase
            'Dim sql As String = "DELETE from Gun_Collection_SoldTo where ID=" & myValue
            Dim sMsg As String = MsgBox("Are you sure that you want to delete " & strName & " from the database.", MsgBoxStyle.YesNo, "Delete a Buyer")
            'Dim intColTotal As Integer = HasCollectionAttached(myValue)
            Dim intColTotal As Integer = MyCollection.HasCollectionAttached(DatabasePath, Convert.ToInt32(myValue), _errOut)
            If sMsg = vbYes Then
                If intColTotal <> 0 Then
                    MsgBox("Cannot delete " & strName & "! It still has " & intColTotal & " firearms attached to it!", MsgBoxStyle.Critical, "Cannot Delete Buyer")
                Else
                    'obj.ConnExec(sql)
                    If Not Buyers.Delete(DatabasePath, Convert.ToInt32(myValue), _errOut) Then Throw New Exception(_errOut)
                    Call RefreshList()
                End If
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton1_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Call RefreshList()
    End Sub
End Class