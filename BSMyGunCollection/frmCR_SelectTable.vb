Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmCR_SelectTable
    Function GetTableName(ByVal TID As Long) As String
        Dim sAns As String = ""
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "SELECT * from CR_TableList where id=" & TID
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                sAns = RS("Tables")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetTableName"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    Private Sub frmCR_SelectTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CR_SavedReportsTableAdapter.Fill(Me.MGCDataSet.CR_SavedReports)
            Me.CR_TableListTableAdapter.Fill(Me.MGCDataSet.CR_TableList)
            Dim ObjGF As New GlobalFunctions
            If ObjGF.ObjectExistsinDB("CR_SavedReports") Then
                Me.Height = 157
            Else
                Me.Height = 102
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            Dim TID As Long = ComboBox1.SelectedValue
            Dim TName As String = ComboBox1.Text
            Dim frmNew As New frmCR_SelectColumns
            frmNew.TableID = TID
            frmNew.TableName = TName
            frmNew.TableRealName = GetTableName(TID)
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnNext.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnLoadSaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSaved.Click
        Try
            Dim SRID As Long = ComboBox2.SelectedValue
            Dim ReportName As String = ComboBox2.Text
            Dim ObjGF As New GlobalFunctions
            Dim SQL As String = ObjGF.GetReportSQL(SRID)
            Dim frmnew As New frmCR_ViewReport
            frmnew.SQL = Replace(SQL, "''", "'")
            frmnew.ReportName = ReportName
            frmnew.MdiParent = Me.MdiParent
            frmnew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "btnLoadSaved.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class