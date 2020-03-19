Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Public Class frmCR_EditSQL
    Public RID As Long
    'Get the data from the database based on the report id
    Sub LoadData()
        Try
            Dim SQL As String = "select * from CR_SavedReports where id=" & RID
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                txtTitle.Text = RS("ReportName")
                txtSQL.Text = RS("MySQL")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'when for first loas
    Private Sub frmCR_EditSQL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If RID > 0 Then
            Call LoadData()
        Else
            Me.Text = "Add SQL for Custom Report"
        End If
    End Sub
    'when the user is ready to view the results, they click on the view in report button and this will pass the sql statement to the viewer
    Private Sub btnViewInReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewInReport.Click
        Dim frmnew As New frmCR_ViewReport
        frmnew.SQL = txtSQL.Text
        frmnew.MdiParent = Me.MdiParent
        frmnew.Show()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            Dim Obj As New BSDatabase
            Dim ObjOF As New GlobalFunctions
            Dim ReportName As String = FluffContent(txtTitle.Text)
            Dim MySQL As String = FluffContent(txtSQL.Text)
            Dim SQL As String = ""
            If RID = 0 Then
                SQL = "INSERT INTO CR_SavedReports (ReportName,MySQL) VALUES('" & ReportName & "','" & MySQL & "')"
            Else
                SQL = "UPDATE CR_SavedReports set ReportName='" & ReportName & "',MySQL='" & MySQL & "' where ID=" & RID
            End If
            Obj.ConnExec(SQL)
            MsgBox("Report Was Saved!")
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnSave_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class