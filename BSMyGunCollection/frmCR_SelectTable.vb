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
    'Load the comboboxes from the datasets and resize the for if it does or doesn't have any saved reports.
    Sub LoadData()
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
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'When form loads
    Private Sub frmCR_SelectTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'When the next button is clicked, get the value and pass them over to the select columns form and open it
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
    'Load from the saved reports when the Load button is clicked
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
    'when the user right clicks on the Load button, this is one of the context menu
    'options that appears that allows the user to delete the custom report.
    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim selectedName As String = ComboBox2.SelectedText
            Dim selectedValue As String = ComboBox2.SelectedValue
            Dim sAns As String = MsgBox("Are you sure you want to delete " & selectedName & " Report?", MsgBoxStyle.YesNo, "Delete Custom Report")
            If sAns = vbYes Then
                Dim SQL As String = "delete from CR_SavedReports where ID=" & selectedValue
                Dim Obj As New BSDatabase
                Obj.ConnExec(SQL)
                Obj = Nothing
                MsgBox("Report was deleted")
                Call LoadData()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'when the user right clicks on the Load button, this is one of the context menu
    'options that appears that allows the user to edit the custom report.
    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim RID As Long = ComboBox2.SelectedValue
        Dim frmNew As New frmCR_EditSQL
        frmNew.RID = RID
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
    'when the user right clicks on the Next button, this is one of the context menu
    'options that appears that allows the user to edit the custom report.
    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frmNew As New frmCR_EditSQL
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
End Class